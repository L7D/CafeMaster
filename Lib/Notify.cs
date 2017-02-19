using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CafeMaster_UI.Lib
{
	public struct NotifyData
	{
		public string threadTitle;
		public string threadNumber;
		public string threadAuthor;
		public string threadURL;
		public string threadTime;
		public int threadHit;


		// by ThreadDetailStruct
		public string detailTime;
		public string detailAuthor;
		public string authorIconGIF;
		public string boardName;




		public bool focused;
	}

	public struct NotifyIgnoreData
	{
		public string threadNumber;
	}

	static class Notify
	{
		public static List<NotifyData> lists = new List<NotifyData>( );
		public static List<NotifyIgnoreData> ignoreData = new List<NotifyIgnoreData>( );

		public static bool IsAlreadyAdded( string threadNumber )
		{
			Predicate<NotifyData> finder = ( NotifyData data ) => { return data.threadNumber == threadNumber; };

			return lists.FindIndex( finder ) > -1;
		}

		public static void Add( string threadTitle, string threadNumber, string threadAuthor, string threadURL, string threadTime, int threadHit )
		{
			NotifyData data = new NotifyData( );
			data.threadTitle = HttpUtility.HtmlDecode( threadTitle );
			data.threadNumber = threadNumber;
			data.threadAuthor = threadAuthor;
			data.threadURL = threadURL;
			data.threadTime = threadTime;
			data.threadHit = threadHit;
			data.focused = false;

			TopProgressMessage.Set( "#" + threadNumber + " 게시글의 정보를 불러오고 있습니다 ... [2/3]" );

			ThreadDetailStruct? detailStruct = NaverRequest.ThreadDetailRequest( threadNumber );

			if ( detailStruct.HasValue )
			{
				data.authorIconGIF = detailStruct.Value.authorIconGIF;
				data.boardName = detailStruct.Value.boardName;
				data.detailTime = detailStruct.Value.detailTime;
				data.detailAuthor = detailStruct.Value.detailAuthor;
			}

			lists.Insert( 0, data );

			//await Task.Run( new Action( ( ) => Advice.CheckThread( data ) ) );
			//Advice.CheckThread( data );

			if ( Config.Get( "CaptureEnable", "true" ).ToLower( ) == "true" )
			{
				TopProgressMessage.Set( "#" + threadNumber + " 게시글을 캡쳐하고 있습니다 ... [3/3]" );

				Main main = Utility.GetMainForm( );

				if ( main != null )
				{
					if ( main.InvokeRequired )
					{
						main.Invoke( new Action( ( ) =>
						{
							BrowserCapture.Capture( threadNumber );
						} ) );
					}
					else
					{
						BrowserCapture.Capture( threadNumber );
					}
				}
			}
			else
			{
				TopProgressMessage.Set( "#" + threadNumber + " 게시글 설정으로 인해 캡쳐하지 않습니다. [3/3]" );
			}
		}

		public static void Sort( )
		{
			lists = lists.OrderByDescending( c => c.threadNumber ).ToList( );

			// 예외처리바람;
			RefreshMainNotifyPanel( );
			Save( );
		}

		public static void RefreshMainNotifyPanel( )
		{
			Main main = Utility.GetMainForm( );

			if ( main != null )
			{
				if ( main.InvokeRequired )
				{
					main.Invoke( new Action( ( ) => main.RefreshNotifyPanel( ) ) );
				}
				else
				{
					main.RefreshNotifyPanel( );
				}
			}
		}

		//public static void AddIgnore( string threadNumber )
		//{
		//	NotifyIgnoreData data = new NotifyIgnoreData( );
		//	data.threadNumber = threadNumber;

		//	ignoreData.Add( data );

		//	Save( );
		//}

		public static void Remove( string number, bool noRefresh = false, bool noSave = false )
		{
			int index = 0;

			foreach ( NotifyData i in lists )
			{
				if ( i.threadNumber.Equals( number ) )
				{
					lists.RemoveAt( index );

					break;
				}

				index++;
			}

			if ( !noRefresh )
				RefreshMainNotifyPanel( );

			if ( !noSave )
				Save( );
		}

		public static NotifyData? GetDataByNumber( string threadNumber )
		{
			Predicate<NotifyData> finder = ( NotifyData data ) => { return data.threadNumber == threadNumber; };
			int index = lists.FindIndex( finder );

			if ( index > -1 && lists?[ index ] != null )
			{
				return lists[ index ];
			}

			return null;
		}

		public static void SetFocused( string threadNumber, bool newValue )
		{
			Predicate<NotifyData> finder = ( NotifyData data ) => { return data.threadNumber == threadNumber; };
			int index = lists.FindIndex( finder );

			if ( index > -1 && lists?[ index ] != null )
			{
				NotifyData oldData = lists[ index ];

				oldData.focused = newValue;

				lists[ index ] = oldData;

				Save( );
			}
			else
			{
				NotifyBox.Show( null, "오류", "죄송합니다, 데이터 조작 중 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
			}
		}

		public static void Save( )
		{
			JsonArrayCollection collection = new JsonArrayCollection( );

			foreach ( NotifyData i in lists )
			{
				JsonObjectCollection collection2 = new JsonObjectCollection( );

				collection2.Add( new JsonStringValue( "threadNumber", i.threadNumber ) );
				collection2.Add( new JsonStringValue( "threadTitle", i.threadTitle ) );
				collection2.Add( new JsonStringValue( "threadAuthor", i.threadAuthor ) );
				collection2.Add( new JsonStringValue( "threadURL", i.threadURL ) );
				collection2.Add( new JsonStringValue( "threadTime", i.threadTime ) );
				collection2.Add( new JsonNumericValue( "threadHit", i.threadHit ) );
				collection2.Add( new JsonBooleanValue( "focused", i.focused ) );

				collection2.Add( new JsonStringValue( "authorIconGIF", i.authorIconGIF ) );
				collection2.Add( new JsonStringValue( "boardName", i.boardName ) );
				collection2.Add( new JsonStringValue( "detailTime", i.detailTime ) );
				collection2.Add( new JsonStringValue( "detailAuthor", i.detailAuthor ) );

				collection.Add( collection2 );
			}

			File.WriteAllText( GlobalVar.APP_DIR + @"\data\notify.db", collection.ToString( ) );

			//StringBuilder dataTable = new StringBuilder( );

			//foreach ( NotifyIgnoreData data in ignoreData )
			//{
			//	dataTable.AppendLine( data.threadNumber );
			//}

			//File.WriteAllText( GlobalVar.APP_DIR + @"\data\notifyIgnores.db", dataTable.ToString( ) );
		}

		public static void Load( )
		{
			if ( File.Exists( GlobalVar.APP_DIR + @"\data\notify.db" ) )
			{
				try
				{
					string data = File.ReadAllText( GlobalVar.APP_DIR + @"\data\notify.db" );

					JsonArrayCollection collection = ( JsonArrayCollection ) new JsonTextParser( ).Parse( data );

					foreach ( JsonObjectCollection i in collection )
					{
						NotifyData newNotifyData = new NotifyData( );
						newNotifyData.threadNumber = i[ "threadNumber" ].GetValue( ).ToString( );
						newNotifyData.threadTitle = HttpUtility.HtmlDecode( i[ "threadTitle" ].GetValue( ).ToString( ) );
						newNotifyData.threadAuthor = i[ "threadAuthor" ].GetValue( ).ToString( );
						newNotifyData.threadURL = i[ "threadURL" ].GetValue( ).ToString( );
						newNotifyData.threadTime = i[ "threadTime" ].GetValue( ).ToString( );
						newNotifyData.threadHit = int.Parse( i[ "threadHit" ].GetValue( ).ToString( ) );

						newNotifyData.authorIconGIF = i[ "authorIconGIF" ].GetValue( ).ToString( );
						newNotifyData.boardName = i[ "boardName" ].GetValue( ).ToString( );
						newNotifyData.detailTime = i[ "detailTime" ].GetValue( ).ToString( );
						newNotifyData.detailAuthor = i[ "detailAuthor" ].GetValue( ).ToString( );

						if ( i[ "focused" ] != null )
							newNotifyData.focused = bool.Parse( i[ "focused" ].GetValue( ).ToString( ) );
						else
							newNotifyData.focused = false;

						lists.Add( newNotifyData );
					}

					RefreshMainNotifyPanel( );
				}
				catch ( FormatException )
				{
					NotifyBox.Show( null, "오류", "죄송합니다, 데이터베이스 파일이 손상되어 불러올 수 없었습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
				}
				catch ( Exception ex )
				{
					NotifyBox.Show( null, "오류", "죄송합니다, 데이터베이스 파일이 손상되어 불러올 수 없었습니다.\n\n" + ex.Message, NotifyBoxType.OK, NotifyBoxIcon.Error );
				}
			}

			//	if ( File.Exists( GlobalVar.APP_DIR + @"\data\notifyIgnores.db" ) )
			//	{
			//		try
			//		{
			//			string[ ] data2 = File.ReadAllLines( GlobalVar.APP_DIR + @"\data\notifyIgnores.db" );

			//			for ( int i = 0; i < data2.Length; i++ )
			//			{
			//				NotifyIgnoreData newData = new NotifyIgnoreData( );
			//				newData.threadNumber = data2[ i ];

			//				ignoreData.Add( newData );
			//			}
			//		}
			//		catch ( FormatException )
			//		{
			//			NotifyBox.Show( null, "심각한 오류", "notifyIgnores.db 파일이 손상되었습니다, 데이터를 불러올 수 없습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
			//		}
			//		catch ( IOException ex )
			//		{
			//			NotifyBox.Show( null, "심각한 오류", "notifyIgnores.db 파일 데이터를 불러올 수 없습니다.\n\n" + ex.Message, NotifyBoxType.OK, NotifyBoxIcon.Error );
			//		}
			//		catch ( Exception ex )
			//		{
			//			NotifyBox.Show( null, "심각한 오류", "notifyIgnores.db 파일 데이터를 불러올 수 없습니다.\n\n" + ex.Message, NotifyBoxType.OK, NotifyBoxIcon.Error );
			//		}
			//	}
		}
	}
}
