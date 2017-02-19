using HtmlAgilityPack;
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
			int PAGE = 1;
			bool newFound = false;

			retry:

			TopProgressMessage.Set( PAGE + "페이지의 새로운 게시글을 확인하고 있습니다 ..." );

			string[ ] savedDataTable = Data.Get( ); // 최적화 필요;
			int newCount = 0;

			NaverRequest.New( "http://cafe.naver.com/ArticleList.nhn?search.clubid=" + GlobalVar.CAFE_ID + "&search.boardtype=L&search.page=" + PAGE, NaverRequest.RequestMethod.GET, Encoding.Default, ( value ) =>
			{
				List<TableDataTable> newDataTable = Parse.TotalArticlePageCrawling( value );

				for ( int i = 0; i < newDataTable.Count; i++ )
				{
					bool found = false;

					for ( int i2 = 0; i2 < savedDataTable.Length; i2++ )
					{
						if ( newDataTable[ i ].number == savedDataTable[ i2 ] )
						{
							found = true;
							break;
						}
					}

					if ( !found )
					{
						if ( Notify.IsAlreadyAdded( newDataTable[ i ].number ) ) continue;

						newFound = true;

						TopProgressMessage.Set( "#" + newDataTable[ i ].number + " 게시글의 정보를 불러오고 있습니다 ... [1/3]" );

						Data.Add( newDataTable[ i ].number );

						Notify.Add(
							newDataTable[ i ].title,
							newDataTable[ i ].number,
							newDataTable[ i ].author,
							newDataTable[ i ].url,
							newDataTable[ i ].time,
							newDataTable[ i ].hit
						);

						newCount++;
					}
				}
			} );

			if ( newCount >= 15 )
			{
				PAGE++;
				goto retry;
			}

			if ( newFound )
			{
				Notify.Sort( );

				Main main = Utility.GetMainForm( );

				if ( main != null )
					FlashWindow.Flash( main );

				if ( Config.Get( "SoundMute", "false" ).ToLower( ) == "false" )
					SoundNotify.PlayNotify( );
			}

			Thread.Sleep( 1000 );

			TopProgressMessage.End( );
		}
	}

	static class Data
	{
		public static void Initialize( )
		{
			try
			{
				if ( !Directory.Exists( GlobalVar.DATA_DIR ) )
					Directory.CreateDirectory( GlobalVar.DATA_DIR );

				if ( !File.Exists( GlobalVar.DATA_DIR + @"\dataTable.dat" ) )
				{
					NaverRequest.New( "http://cafe.naver.com/ArticleList.nhn?search.clubid=" + GlobalVar.CAFE_ID + "&search.boardtype=L", NaverRequest.RequestMethod.GET, Encoding.Default, ( value ) =>
					{
						JsonArrayCollection collection = new JsonArrayCollection( );
						List<TableDataTable> dataTable = Parse.TotalArticlePageCrawling( value );

						foreach ( TableDataTable i in dataTable )
						{
							collection.Add( new JsonStringValue( null, i.number ) );
						}

						File.WriteAllText( GlobalVar.DATA_DIR + @"\dataTable.dat", collection.ToString( ) );

						Thread.Sleep( 1000 );

						TopProgressMessage.End( );
					} );
				}

				Notify.Load( );
			}
			catch ( IOException ex )
			{
				Utility.LogWrite( "IOException - " + ex.Message, Utility.LogSeverity.EXCEPTION );
				NotifyBox.Show( null, "오류", "죄송합니다, 데이터를 불러오지 못했습니다, 파일 접근 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
			}
			catch ( Exception ex )
			{
				Utility.LogWrite( ex.Message, Utility.LogSeverity.EXCEPTION );
				NotifyBox.Show( null, "오류", "죄송합니다, 데이터를 불러오지 못했습니다, 알 수 없는 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
			}
		}

		public static void Add( string number )
		{
			try
			{
				if ( !File.Exists( GlobalVar.DATA_DIR + @"\dataTable.dat" ) ) return;

				JsonArrayCollection collection = ( JsonArrayCollection ) new JsonTextParser( ).Parse( File.ReadAllText( GlobalVar.DATA_DIR + @"\dataTable.dat" ) );

				collection.Insert( 0, new JsonStringValue( null, number ) );

				File.WriteAllText( GlobalVar.DATA_DIR + @"\dataTable.dat", collection.ToString( ) );
			}
			catch ( IOException ex )
			{
				Utility.LogWrite( "IOException - " + ex.Message, Utility.LogSeverity.EXCEPTION );
				NotifyBox.Show( null, "오류", "죄송합니다, 데이터를 저장하지 못했습니다, 파일 접근 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
			}
			catch ( Exception ex )
			{
				Utility.LogWrite( ex.Message, Utility.LogSeverity.EXCEPTION );
				NotifyBox.Show( null, "오류", "죄송합니다, 데이터를 저장하지 못했습니다, 알 수 없는 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
			}
		}

		public static string[ ] Get( )
		{
			try
			{
				if ( File.Exists( GlobalVar.DATA_DIR + @"\dataTable.dat" ) )
				{
					JsonArrayCollection collection = ( JsonArrayCollection ) new JsonTextParser( ).Parse( File.ReadAllText( GlobalVar.DATA_DIR + @"\dataTable.dat" ) );
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
			catch ( Exception ) { return new string[ ] { }; }
		}
	}
}
