﻿using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Json;
using System.Text;
using System.Threading;

namespace CafeMaster_UI.Lib
{
	struct TableDataTable
	{
		public string number;
		public string title;
		//public string commentCount;
		public string author;
		public string url;
		public string time;

		public int hit;
		public int like;
	}

	static class TopProgressMessage
	{
		public static void Set( string message )
		{
			Main main = Utility.GetMainForm( );

			if ( main != null )
			{
				main.StartWorker( message );
			}
		}

		public static void End( )
		{
			Main main = Utility.GetMainForm( );

			if ( main != null )
			{
				main.EndWorker( );
			}
		}
	}

	static class Parse
	{
		public static List<TableDataTable> TotalArticlePageCrawling( string html )
		{
			List<TableDataTable> list = new List<TableDataTable>( );

			HtmlDocument document = new HtmlDocument( );
			document.LoadHtml( html );

			int count = 0;
			int iCount = 0;
			foreach ( HtmlNode i in document.DocumentNode.SelectNodes( "//tr" ) )
			{
				if ( i.GetAttributeValue( "align", "NONE" ) == "center" && i.GetAttributeValue( "class", "NONE" ) != "bg-color" && i.GetAttributeValue( "class", "NONE" ) != "bg-color _noticeArticle" )
				{
					if ( count == iCount )
					{
						TableDataTable table = new TableDataTable( );

						int icc = 0;
						int parseCount = 0;

						foreach ( HtmlNode i2 in i.SelectNodes( "//a" ) )
						{
							if ( i2.GetAttributeValue( "href", "" ).StartsWith( "/ArticleRead.nhn" ) && i2.GetAttributeValue( "class", "" ) == "m-tcol-c" )
							{
								if ( count == icc )
								{
									table.url = "http://cafe.naver.com" + i2.GetAttributeValue( "href", "" );
									table.title = i2.InnerText.Trim( ).Replace( Environment.NewLine, "" );
								}

								icc++;
							}
						}

						foreach ( HtmlNode i2 in i.ChildNodes )
						{
							if ( i2.Name != "#text" )
							{
								switch ( parseCount )
								{
									case 0:
										table.number = i2.InnerText.Trim( );
										break;
									case 1:
										// null
										break;
									case 2:
										string nickData = i2.InnerText.Trim( );

										//11 ~ end
										int end = nickData.IndexOf( "wordBreak($(" );

										table.author = nickData.Substring( 11, end - 11 );

										break;
									case 3:
										table.time = i2.InnerText.Trim( );

										break;
									case 4:
										table.hit = int.Parse( i2.InnerText.Trim( ) );

										break;
									case 5:
										table.like = int.Parse( i2.InnerText.Trim( ) );

										break;
								}

								parseCount++;
							}
						}

						list.Add( table );
						count++;
					}

					iCount++;
				}
			}

			return list;
		}
	}

	static class Observer
	{
		private static Timer ObserverTimer = null;
		private static short IntervalTemp = 30;
		private static bool WORKING = false;

		static Observer( )
		{
			ObserverTimer = new Timer( Progress );
		}

		public static void Start( )
		{
			short syncInterval;

			if ( short.TryParse( Config.Get( "SyncInterval", "30" ), out syncInterval ) )
			{
				if ( syncInterval < 30 || syncInterval > 300 )
				{
					Config.Set( "SyncInterval", "30" );
					syncInterval = 30;
				}

				IntervalTemp = syncInterval;
				ObserverTimer.Change( 0, 1000 * syncInterval );
			}
			else
			{
				Config.Set( "SyncInterval", "30" );
				IntervalTemp = 30;
				ObserverTimer.Change( 0, 30000 ); // 30 초
			}
		}

		public static void ChangeInterval( short interval )
		{
			if ( interval < 30 || interval > 300 )
			{
				Config.Set( "SyncInterval", "30" );
				interval = 30;
			}

			IntervalTemp = interval;
			ObserverTimer.Change( 1000 * interval, 1000 * interval );
		}

		public static void Stop( )
		{
			ObserverTimer.Change( Timeout.Infinite, Timeout.Infinite );
		}

		public static void ForceProgress( )
		{
			Progress( null );
			ObserverTimer.Change( 0, 1000 * IntervalTemp );
		}

		private static void Progress( object status )
		{
			if ( WORKING ) return;

			WORKING = true;

			int currentArticlePage = 1; // 현재 게시판 페이지
			bool newThreadFound = false;
			List<string> newThreadNumberTemp = new List<string>( );
			string[ ] savedDataTable = ThreadDataStore.Get( ); // 최적화 필요;

			searchThreadPage: // 페이지 루프를 위한 goto

			int newThreadCount = 0;

			TopProgressMessage.Set( "새로운 게시물을 확인하고 있습니다 ... [" + currentArticlePage + "p]" );

			NaverRequest.New( "http://cafe.naver.com/ArticleList.nhn?search.clubid=" + GlobalVar.CAFE_ID + "&search.boardtype=L&search.page=" + currentArticlePage, NaverRequest.RequestMethod.GET, Encoding.Default, ( value ) =>
			{
				List<TableDataTable> newDataTable = Parse.TotalArticlePageCrawling( value );

				for ( int i = 0; i < newDataTable.Count; i++ )
				{
					bool dataStoreFound = false;

					for ( int i2 = 0; i2 < savedDataTable.Length; i2++ )
					{
						if ( newDataTable[ i ].number == savedDataTable[ i2 ] )
						{
							dataStoreFound = true;
							break;
						}
					}

					if ( !dataStoreFound ) // 새로운 글
					{
						if ( Notify.Exists( newDataTable[ i ].number ) ) continue;

						newThreadFound = true;

						TopProgressMessage.Set( "#" + newDataTable[ i ].number + " 게시글의 정보를 불러오고 있습니다 ... [1/3]" );

						newThreadNumberTemp.Add( newDataTable[ i ].number );

						Notify.Add( newDataTable[ i ] );

						newThreadCount++;
					}
				}
			} );

			if ( newThreadCount >= 15 ) // 기본 설정으로 게시판 한 페이지 당 15개의 글이 있음, 이상으로 글이 있을 시 새로운 글이 다음 페이지에 있을 수 있으므로 다음 페이지도 검색
			{
				currentArticlePage++;
				goto searchThreadPage;
			}

			if ( newThreadFound )
			{
				ThreadDataStore.Add( newThreadNumberTemp );
				Notify.Sort( );

				Utility.FlashWindow.Flash( ); // 작업표시줄 하이라이트 처리

				if ( Config.Get( "SoundEnable", "1" ) == "1" )
					SoundNotify.PlayNotify( );
			}

			Thread.Sleep( 1000 );

			TopProgressMessage.End( );
			WORKING = false;
		}
	}

	static class ThreadDataStore
	{
		private static readonly string DATA_FILE_LOCATION;

		static ThreadDataStore( )
		{
			DATA_FILE_LOCATION = GlobalVar.DATA_DIR + @"\dataTable.dat";
		}

		public static void Initialize( )
		{
			try
			{
				if ( !Directory.Exists( GlobalVar.DATA_DIR ) )
					Directory.CreateDirectory( GlobalVar.DATA_DIR );

				if ( !File.Exists( DATA_FILE_LOCATION ) ) // 데이터 파일이 없을 시 
				{
					NaverRequest.New( "http://cafe.naver.com/ArticleList.nhn?search.clubid=" + GlobalVar.CAFE_ID + "&search.boardtype=L&userDisplay=15", NaverRequest.RequestMethod.GET, Encoding.Default, ( value ) =>
					{
						//File.WriteAllText( "log.txt", value, Encoding.Default );

						JsonArrayCollection collection = new JsonArrayCollection( );
						List<TableDataTable> dataTable = Parse.TotalArticlePageCrawling( value );

						foreach ( TableDataTable i in dataTable )
						{
							collection.Add( new JsonStringValue( null, i.number ) );
						}

						File.WriteAllText( DATA_FILE_LOCATION, collection.ToString( ) );

						Thread.Sleep( 1000 );

						TopProgressMessage.End( );
					} );
				}

				Notify.Initialize( );
			}
			catch ( IOException ex )
			{
				Utility.WriteErrorLog( "IOException - " + ex.Message, Utility.LogSeverity.EXCEPTION );
				NotifyBox.Show( null, "오류", "죄송합니다, 데이터를 불러오지 못했습니다, 파일 접근 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				NotifyBox.Show( null, "오류", "죄송합니다, 데이터를 불러오지 못했습니다, 알 수 없는 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
			}
		}

		public static void Add( string threadID )
		{
			try
			{
				if ( !File.Exists( DATA_FILE_LOCATION ) ) return;

				JsonArrayCollection collection = ( JsonArrayCollection ) new JsonTextParser( ).Parse( File.ReadAllText( DATA_FILE_LOCATION ) );

				collection.Add( new JsonStringValue( null, threadID ) );

				File.WriteAllText( DATA_FILE_LOCATION, collection.ToString( ) );
			}
			catch ( IOException ex )
			{
				Utility.WriteErrorLog( "IOException - " + ex.Message, Utility.LogSeverity.EXCEPTION );
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
			}
		}

		public static void Add( List<string> threadIDList )
		{
			try
			{
				if ( !File.Exists( DATA_FILE_LOCATION ) ) return;

				JsonArrayCollection collection = ( JsonArrayCollection ) new JsonTextParser( ).Parse( File.ReadAllText( DATA_FILE_LOCATION ) );

				foreach ( string i in threadIDList )
				{
					collection.Add( new JsonStringValue( null, i ) );
				}
				
				File.WriteAllText( DATA_FILE_LOCATION, collection.ToString( ) );
			}
			catch ( IOException ex )
			{
				Utility.WriteErrorLog( "IOException - " + ex.Message, Utility.LogSeverity.EXCEPTION );
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
			}
		}

		public static string[ ] Get( )
		{
			try
			{
				if ( File.Exists( DATA_FILE_LOCATION ) )
				{
					JsonArrayCollection collection = ( JsonArrayCollection ) new JsonTextParser( ).Parse( File.ReadAllText( DATA_FILE_LOCATION ) );
					string[ ] dataTable = new string[ collection.Count ];
					int count = 0;

					foreach ( JsonStringValue i in collection )
					{
						dataTable[ count ] = i.Value;
						count++;
					}

					return dataTable;
				}
				else
					return new string[ ] { };
			}
			catch { return new string[ ] { }; }
		}
	}
}
