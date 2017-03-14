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
		public string threadID;
		public string threadURL;
		public int threadHit; // 데이터 추가 시점에 조회수

		// for NaverRequest.ThreadDetailStruct
		public string threadTime;
		public string threadAuthor;
		public string personaconURL;
		public string articleName;


		public bool focused;
	}

	static class Notify
	{
		private static List<NotifyData> LISTS = new List<NotifyData>( );
		private static Main mainForm = null;
		private static readonly string NOTIFY_FILE_LOCATION;

		// 외부에서 데이터를 설정하는 SetData 메소드를 위해서 대리자 생성
		public delegate void DataSettingDelegate( ref NotifyData data );

		static Notify( )
		{
			NOTIFY_FILE_LOCATION = GlobalVar.DATA_DIR + @"\notify.db";
		}

		public static bool Exists( string threadNumber )
		{
			//Predicate<NotifyData> finder = ( NotifyData data ) => { return data.threadNumber == threadNumber; };

			return LISTS.FindIndex( ( NotifyData data ) =>
			{
				return data.threadID == threadNumber;
			} ) > -1;
		}

		public static void Add( TableDataTable table )
		{
			string threadID = table.number;

			NotifyData data = new NotifyData( );

			data.threadTitle = HttpUtility.HtmlDecode( table.title );
			data.threadID = table.number;
			data.threadURL = table.url;
			data.threadHit = table.hit;
			data.focused = false;

			TopProgressMessage.Set( "#" + threadID + " 게시글의 정보를 불러오고 있습니다 ... [2/3]" );

			ThreadDetailStruct? detailStruct = NaverRequest.ThreadDetailRequest( threadID );

			if ( detailStruct.HasValue )
			{
				data.threadAuthor = detailStruct.Value.threadAuthor;
				data.threadTime = detailStruct.Value.threadTime;
				data.personaconURL = detailStruct.Value.personaconURL;
				data.articleName = detailStruct.Value.articleName;
			}
			else
			{
				data.threadAuthor = "NULL(NULL)";
				data.threadTime = "00:00";
				data.articleName = "알 수 없음";
			}

			LISTS.Insert( 0, data );

			//await Task.Run( new Action( ( ) => Advice.CheckThread( data ) ) );
			//Advice.CheckThread( data );

			if ( Config.Get( "CaptureEnable", "1" ) == "1" )
			{
				TopProgressMessage.Set( "#" + threadID + " 게시글을 캡처하고 있습니다 ... [3/3]" );

				if ( mainForm != null )
				{
					if ( mainForm.InvokeRequired )
						mainForm.Invoke( new Action( ( ) => BrowserCapture.Capture( threadID ) ) );
					else
						BrowserCapture.Capture( threadID );
				}
			}
			else
			{
				TopProgressMessage.Set( "#" + threadID + " 게시글을 설정에 의해 캡처하지 않습니다. [3/3]" );
			}
		}

		public static void Sort( )
		{
			LISTS = LISTS.OrderByDescending( data => data.threadID ).ToList( );

			RefreshMainNotifyPanel( );
			Save( );
		}

		public static void RefreshMainNotifyPanel( )
		{
			if ( mainForm != null )
			{
				if ( mainForm.InvokeRequired )
					mainForm.Invoke( new Action( ( ) => mainForm.RefreshNotifyPanel( ) ) );
				else
					mainForm.RefreshNotifyPanel( );
			}
		}

		//public static void AddIgnore( string threadNumber )
		//{
		//	NotifyIgnoreData data = new NotifyIgnoreData( );
		//	data.threadNumber = threadNumber;

		//	ignoreData.Add( data );

		//	Save( );
		//}

		public static void Remove( string threadID, bool noRefresh = false, bool noSave = false )
		{
			int index = 0;

			foreach ( NotifyData i in LISTS )
			{
				if ( i.threadID == threadID )
				{
					LISTS.RemoveAt( index );

					break;
				}

				index++;
			}

			if ( !noRefresh )
				RefreshMainNotifyPanel( );

			if ( !noSave )
				Save( );
		}

		public static NotifyData? GetDataByID( string threadID )
		{
			NotifyData data = LISTS.Find( ( NotifyData v ) =>
			{
				return v.threadID == threadID;
			} );

			return data;
		}

		public static List<NotifyData> GetAll( )
		{
			return LISTS;
		}

		public static void SetData( string threadID, DataSettingDelegate setCallBack )
		{
			int index = LISTS.FindIndex( ( NotifyData data ) =>
			{
				return data.threadID == threadID;
			} );

			if ( index > -1 && LISTS?[ index ] != null )
			{
				NotifyData oldData = LISTS[ index ];

				setCallBack.Invoke( ref oldData );

				LISTS[ index ] = oldData;

				Save( );
			}
			else
			{
				Utility.WriteErrorLog( "NotifyIndexError", Utility.LogSeverity.EXCEPTION );
				NotifyBox.Show( null, "오류", "죄송합니다, 데이터 조작 중 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
			}
		}

		public static void SetFocused( string threadID, bool newFocusValue )
		{
			//Predicate<NotifyData> finder = ( NotifyData data ) => { return data.threadID == threadNumber; };
			int index = LISTS.FindIndex( ( NotifyData data ) =>
			{
				return data.threadID == threadID;
			} );

			if ( index > -1 && LISTS?[ index ] != null )
			{
				NotifyData oldData = LISTS[ index ];
				oldData.focused = newFocusValue;
				LISTS[ index ] = oldData;

				Save( );
			}
			else
			{
				Utility.WriteErrorLog( "NotifyIndexError", Utility.LogSeverity.EXCEPTION );
				NotifyBox.Show( null, "오류", "죄송합니다, 데이터 조작 중 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
			}
		}

		public static void Save( )
		{
			JsonArrayCollection collection = new JsonArrayCollection( );

			foreach ( NotifyData i in LISTS )
			{
				JsonObjectCollection collection2 = new JsonObjectCollection( );

				collection2.Add( new JsonStringValue( "threadID", i.threadID ) );
				collection2.Add( new JsonStringValue( "threadTitle", i.threadTitle ) );
				collection2.Add( new JsonStringValue( "threadAuthor", i.threadAuthor ) );
				collection2.Add( new JsonStringValue( "threadURL", i.threadURL ) );
				collection2.Add( new JsonStringValue( "threadTime", i.threadTime ) );
				collection2.Add( new JsonNumericValue( "threadHit", i.threadHit ) );

				// Boolean
				collection2.Add( new JsonBooleanValue( "focused", i.focused ) );

				collection2.Add( new JsonStringValue( "personaconURL", i.personaconURL ) );
				collection2.Add( new JsonStringValue( "articleName", i.articleName ) );

				collection.Add( collection2 );
			}

			File.WriteAllText( NOTIFY_FILE_LOCATION, collection.ToString( ) );

			//StringBuilder dataTable = new StringBuilder( );

			//foreach ( NotifyIgnoreData data in ignoreData )
			//{
			//	dataTable.AppendLine( data.threadNumber );
			//}

			//File.WriteAllText( GlobalVar.APP_DIR + @"\data\notifyIgnores.db", dataTable.ToString( ) );
		}

		public static void Initialize( )
		{
			mainForm = Utility.GetMainForm( );

			if ( File.Exists( NOTIFY_FILE_LOCATION ) )
			{
				try
				{
					string data = File.ReadAllText( NOTIFY_FILE_LOCATION );

					JsonArrayCollection collection = ( JsonArrayCollection ) new JsonTextParser( ).Parse( data );

					foreach ( JsonObjectCollection i in collection )
					{
						NotifyData newNotifyData = new NotifyData( );
						newNotifyData.threadID = i[ "threadID" ].GetValue( ).ToString( );
						newNotifyData.threadTitle = HttpUtility.HtmlDecode( i[ "threadTitle" ].GetValue( ).ToString( ) );
						newNotifyData.threadURL = i[ "threadURL" ].GetValue( ).ToString( );
						newNotifyData.threadHit = int.Parse( i[ "threadHit" ].GetValue( ).ToString( ) );

						newNotifyData.threadTime = i[ "threadTime" ].GetValue( ).ToString( );
						newNotifyData.threadAuthor = i[ "threadAuthor" ].GetValue( ).ToString( );
						newNotifyData.personaconURL = i[ "personaconURL" ].GetValue( ).ToString( );
						newNotifyData.articleName = i[ "articleName" ].GetValue( ).ToString( );

						if ( i[ "focused" ] != null )
							newNotifyData.focused = bool.Parse( i[ "focused" ].GetValue( ).ToString( ) );
						else
							newNotifyData.focused = false;

						LISTS.Add( newNotifyData );
					}

					RefreshMainNotifyPanel( );
				}
				catch ( FormatException ex )
				{
					Utility.WriteErrorLog( "FormatException - " + ex.Message, Utility.LogSeverity.EXCEPTION );
					NotifyBox.Show( null, "오류", "죄송합니다, 알림 데이터 파일이 손상되어 불러올 수 없습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
				}
				catch ( Exception ex )
				{
					Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
					NotifyBox.Show( null, "오류", "죄송합니다, 알림 데이터 파일이 손상되어 불러올 수 없습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
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
