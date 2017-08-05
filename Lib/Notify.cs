using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

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
		public string authorRank;
		public string personaconURL;
		public string articleName;


		public bool focused;
	}

	static class Notify
	{
		private static List<NotifyData> LISTS = new List<NotifyData>( );

		// 외부에서 데이터를 설정하는 SetData 메소드를 위해서 대리자 생성
		public delegate void DataSettingDelegate( ref NotifyData data );

		static Notify( )
		{

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

			ThreadDetailStruct? detailStruct = NaverRequest.GetSpecificThreadDetail( threadID );

			if ( detailStruct.HasValue )
			{
				data.threadAuthor = detailStruct.Value.threadAuthor;
				data.threadTime = detailStruct.Value.threadTime;
				data.personaconURL = detailStruct.Value.personaconURL;
				data.articleName = detailStruct.Value.articleName;
				data.authorRank = detailStruct.Value.authorRank;
			}
			else
			{
				data.threadAuthor = "NULL(NULL)";
				data.threadTime = "00:00";
				data.personaconURL = "";
				data.articleName = "알 수 없음";
				data.authorRank = "새싹멤버";
			}

			LISTS.Insert( 0, data );

			//await Task.Run( new Action( ( ) => Advice.CheckThread( data ) ) );
			//Advice.CheckThread( data );

			if ( Config.Get( "CaptureEnable", "1" ) == "1" )
			{
				TopProgressMessage.Set( "#" + threadID + " 게시글을 캡처하고 있습니다 ... [3/3]" );

				Main mainForm = Utility.GetMainForm( );

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

		// Null reference exception 발생 메소드 <- 해결완료;
		private static readonly object locker = new object( );
		public static void RefreshMainNotifyPanel( )
		{
			lock ( locker )
			{
				Main mainForm = Utility.GetMainForm( );

				if ( mainForm != null )
				{
					if ( mainForm.InvokeRequired )
						mainForm.Invoke( new Action( ( ) => mainForm.RefreshNotifyPanel( ) ) );
					else
						mainForm.RefreshNotifyPanel( );
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

		public static void Remove( string threadID, bool noRefresh = false, bool noSave = false )
		{
			for ( int i = 0; i < LISTS.Count; i++ )
			{
				if ( LISTS[ i ].threadID == threadID )
				{
					LISTS.RemoveAt( i );
					break;
				}
			}

			if ( !noSave )
				Save( );

			if ( !noRefresh )
				RefreshMainNotifyPanel( );
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

		public static bool RemoveAll( )
		{
			try
			{
				DBProvider.SQLite sqliteProvider = new DBProvider.SQLite( "core.db", GlobalVar.NOTIFY_ARTICLE_CREATE_SQLITE );

				sqliteProvider.ExecuteQuery( "DELETE FROM ArticleNotification" );

				sqliteProvider.Close( );

				return true;
			}
			catch ( System.Data.SQLite.SQLiteException ex )
			{
				Utility.WriteErrorLog( "SQLiteException - " + ex.Message, Utility.LogSeverity.EXCEPTION );
				NotifyBox.Show( null, "오류", "죄송합니다, 데이터를 삭제하지 못했습니다, SQLite 오류가 발생했습니다.\n\n" + ex.Message + " (0x" + ( ex.ErrorCode > 0 ? ex.ErrorCode : 0 ) + ")", NotifyBoxType.OK, NotifyBoxIcon.Error );

				return false;
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				NotifyBox.Show( null, "오류", "죄송합니다, 데이터를 삭제하지 못했습니다, 알 수 없는 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );

				return false;
			}
		}

		public static void Save( )
		{
			Main mainForm = Utility.GetMainForm( );

			if ( mainForm != null )
				mainForm.MaskShow( );

			try
			{
				DBProvider.SQLite sqliteProvider = new DBProvider.SQLite( "core.db", GlobalVar.NOTIFY_ARTICLE_CREATE_SQLITE );

				sqliteProvider.ExecuteQuery( "DELETE FROM ArticleNotification" );

				foreach ( NotifyData i in LISTS )
				{
					sqliteProvider.ExecuteQuery(
						string.Format( "INSERT INTO ArticleNotification VALUES ( {0}, '{1}', '{2}', '{3}', '{4}', {5}, {6}, '{7}', '{8}', '{9}' )",
							i.threadID,
							i.threadTitle.Replace( "'", "''" ),
							i.threadAuthor,
							i.threadURL,
							i.threadTime,
							i.threadHit,
							i.focused == true ? 1 : 0,
							i.personaconURL,
							i.articleName,
							i.authorRank
						)
					);


					Application.DoEvents( );
				}

				sqliteProvider.Close( );


			}
			catch ( System.Data.SQLite.SQLiteException ex )
			{
				Utility.WriteErrorLog( "SQLiteException - " + ex.Message, Utility.LogSeverity.EXCEPTION );
				NotifyBox.Show( null, "오류", "죄송합니다, 데이터를 저장하지 못했습니다, SQLite 오류가 발생했습니다.\n\n" + ex.Message + " (0x" + ( ex.ErrorCode > 0 ? ex.ErrorCode : 0 ) + ")", NotifyBoxType.OK, NotifyBoxIcon.Error );
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				NotifyBox.Show( null, "오류", "죄송합니다, 데이터를 저장하지 못했습니다, 알 수 없는 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
			}
			finally
			{
				if ( mainForm != null )
					mainForm.MaskClose( );
			}
		}

		public static void Initialize( )
		{
			try
			{
				DBProvider.SQLite sqliteProvider = new DBProvider.SQLite( "core.db", GlobalVar.NOTIFY_ARTICLE_CREATE_SQLITE );

				sqliteProvider.ExecuteDataReader( "SELECT * FROM ArticleNotification ORDER BY threadID DESC", ( System.Data.SQLite.SQLiteDataReader reader ) =>
				{
					LISTS.Add( new NotifyData( )
					{
						threadID = reader[ "threadID" ].ToString( ),
						threadTitle = HttpUtility.HtmlDecode( reader[ "threadTitle" ].ToString( ) ),
						threadURL = reader[ "threadURL" ].ToString( ),
						threadHit = int.Parse( reader[ "threadHit" ].ToString( ) ),
						threadTime = reader[ "threadTime" ].ToString( ),
						threadAuthor = HttpUtility.HtmlDecode( reader[ "threadAuthor" ].ToString( ) ),
						personaconURL = reader[ "personaconURL" ].ToString( ),
						articleName = reader[ "articleName" ].ToString( ),
						authorRank = reader[ "authorRank" ].ToString( ),
						focused = reader[ "focused" ].ToString( ) == "1" ? true : false
					} );

					//newNotifyData.threadID = reader[ "threadID" ].ToString( );
					//newNotifyData.threadTitle = HttpUtility.HtmlDecode( reader[ "threadTitle" ].ToString( ) );
					//newNotifyData.threadURL = reader[ "threadURL" ].ToString( );
					//newNotifyData.threadHit = int.Parse( reader[ "threadHit" ].ToString( ) );

					//newNotifyData.threadTime = reader[ "threadTime" ].ToString( );
					//newNotifyData.threadAuthor = reader[ "threadAuthor" ].ToString( );
					//newNotifyData.personaconURL = reader[ "personaconURL" ].ToString( );
					//newNotifyData.articleName = reader[ "articleName" ].ToString( );
					//newNotifyData.authorRank = reader[ "authorRank" ].ToString( );

					//if ( reader[ "focused" ] != null )
					//	newNotifyData.focused = reader[ "focused" ].ToString( ) == "1" ? true : false;
					//else
					//	newNotifyData.focused = false;

					return true;
				} );

				sqliteProvider.Close( );
				RefreshMainNotifyPanel( );
				//foreach( JsonObjectCollection i in collection )
				//{
				//	NotifyData newNotifyData = new NotifyData( );
				//	newNotifyData.threadID = i[ "threadID" ].GetValue( ).ToString( );
				//	newNotifyData.threadTitle = HttpUtility.HtmlDecode( i[ "threadTitle" ].GetValue( ).ToString( ) );
				//	newNotifyData.threadURL = i[ "threadURL" ].GetValue( ).ToString( );
				//	newNotifyData.threadHit = int.Parse( i[ "threadHit" ].GetValue( ).ToString( ) );

				//	newNotifyData.threadTime = i[ "threadTime" ].GetValue( ).ToString( );
				//	newNotifyData.threadAuthor = i[ "threadAuthor" ].GetValue( ).ToString( );
				//	newNotifyData.personaconURL = i[ "personaconURL" ].GetValue( ).ToString( );
				//	newNotifyData.articleName = i[ "articleName" ].GetValue( ).ToString( );
				//	newNotifyData.authorRank = i[ "authorRank" ].GetValue( ).ToString( );

				//	if ( i[ "focused" ] != null )
				//		newNotifyData.focused = bool.Parse( i[ "focused" ].GetValue( ).ToString( ) );
				//	else
				//		newNotifyData.focused = false;

				//	LISTS.Add( newNotifyData );
				//}
			}
			catch ( System.Data.SQLite.SQLiteException ex )
			{
				Utility.WriteErrorLog( "SQLiteException - " + ex.Message, Utility.LogSeverity.EXCEPTION );
				NotifyBox.Show( null, "오류", "죄송합니다, 알림 데이터 파일을 불러올 수 없습니다, SQLite 오류가 발생했습니다.\n\n" + ex.Message + " (0x" + ( ex.ErrorCode > 0 ? ex.ErrorCode : 0 ) + ")", NotifyBoxType.OK, NotifyBoxIcon.Error );
			}
			//catch ( FormatException ex )
			//{
			//	Utility.WriteErrorLog( "FormatException - " + ex.Message, Utility.LogSeverity.EXCEPTION );
			//	NotifyBox.Show( null, "오류", "죄송합니다, 알림 데이터 파일이 손상되어 불러올 수 없습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
			//}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				NotifyBox.Show( null, "오류", "죄송합니다, 알림 데이터 파일을 불러올 수 없습니다, 알 수 없는 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
			}
		}
	}
}
