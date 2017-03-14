using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Json;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CafeMaster_UI.Lib
{
	//public enum ServerNotificationType
	//{
	//	NORMAL, // 파란색 보통 상태
	//	WARNING, // 노란색 주의 상태
	//	CRITICAL // 빨간색 경고 상태
	//}

	//public struct ServerNotification
	//{
	//	public ServerNotificationType type;
	//	public string title;
	//	public string desc;

	//	public ServerNotification( ServerNotificationType type, string title, string desc )
	//	{
	//		this.type = type;
	//		this.title = title;
	//		this.desc = desc;
	//	}
	//}

	//static class GlobalServer
	//{
	//	private static string TOKEN
	//	{
	//		get
	//		{
	//			return "CM_TOKEN_TESTER";
	//		}
	//	}


	//	public static bool INITIALIZED
	//	{
	//		get;
	//		set;
	//	}

	//	서버에서 가져온 데이터 변수
	//	public static int SERVER_STATUS = 0;
	//	public static int SYNC_INTERVAL = 10;
	//	public static string LATEST_VERSION = "1.0.0.0";
	//	public static List<ServerNotification> NOTIFICATIONS = new List<ServerNotification>( );


	//	private static Timer SYNC_TIMER = null;

	//	private static void Sync( object status )
	//	{
	//		Main main = Utility.GetMainForm( );

	//		if ( main != null )
	//			main.SetNetworkIcon( 2 );


	//		Console.WriteLine( "Timer run!" );

	//		try
	//		{
	//			HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( "http://textuploader.com/d1286/raw" );
	//			request.Method = "GET";
	//			request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";
	//			request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";

	//			using ( HttpWebResponse response = ( HttpWebResponse ) request.GetResponse( ) )
	//			{
	//				using ( Stream responseStream = response.GetResponseStream( ) )
	//				{
	//					using ( StreamReader reader = new StreamReader( responseStream, Encoding.UTF8 ) )
	//					{
	//						string htmlString = reader.ReadToEnd( );

	//						if ( htmlString.Contains( ">Error 404</" ) )
	//						{
	//							if ( main != null )
	//								main.SetNetworkIcon( 3 );
	//						}
	//						else
	//						{
	//							bool success = JSONDataParseAndFinish( htmlString );

	//							if ( success )
	//							{

	//								if ( SYNC_TIMER != null )
	//									SYNC_TIMER.Change( SYNC_INTERVAL * 1000, SYNC_INTERVAL * 1000 );

	//								Console.WriteLine( htmlString );
	//								Console.WriteLine( SERVER_STATUS.ToString( ) );
	//								Console.WriteLine( SYNC_INTERVAL.ToString( ) );
	//								Console.WriteLine( LATEST_VERSION.ToString( ) );

	//								Thread.Sleep( 1000 );

	//								if ( main != null )
	//									main.SetNetworkIcon( 1 );
	//							}
	//							else
	//							{
	//								Console.WriteLine( "DATA ERROR" );

	//								if ( main != null )
	//									main.SetNetworkIcon( 3 );
	//							}
	//						}
	//					}
	//				}
	//			}
	//		}
	//		catch ( WebException ex )
	//		{
	//			Console.WriteLine( ex.Message );

	//			if ( main != null )
	//				main.SetNetworkIcon( 3 );
	//		}
	//		catch ( Exception ex )
	//		{
	//			Console.WriteLine( ex.Message );

	//			if ( main != null )
	//				main.SetNetworkIcon( 3 );
	//		}
	//	}

	//	public static bool JSONDataParseAndFinish( string htmlData )
	//	{
	//		try
	//		{
	//			JsonObjectCollection collection = ( JsonObjectCollection ) ( new JsonTextParser( ) ).Parse( htmlData );
	//			JsonObjectCollection master = ( JsonObjectCollection ) collection[ "master" ];

	//			NOTIFICATIONS.Clear( );

	//			foreach ( JsonObjectCollection i in ( JsonArrayCollection ) collection[ "notification" ] )
	//			{
	//				NOTIFICATIONS.Add( new ServerNotification(
	//					( ServerNotificationType ) ( int.Parse( i[ "type" ].GetValue( ).ToString( ) ) ),
	//					i[ "title" ].GetValue( ).ToString( ),
	//					i[ "desc" ].GetValue( ).ToString( )
	//				 ) );
	//			}

	//			SERVER_STATUS = int.Parse( master[ "serverStatus" ].GetValue( ).ToString( ) );
	//			SYNC_INTERVAL = int.Parse( master[ "syncInterval" ].GetValue( ).ToString( ) );
	//			LATEST_VERSION = master[ "latestVersion" ].GetValue( ).ToString( );

	//			return true;
	//		}
	//		catch ( NullReferenceException ex ) // json 데이터 손상
	//		{
	//			Console.WriteLine( "NullReferenceException:" + ex.Message );

	//			return false;
	//		}
	//		catch ( FormatException ex ) // 올바른 json string 이 아닐경우
	//		{
	//			Console.WriteLine( "FormatException:" + ex.Message );

	//			return false;
	//		}
	//		catch ( Exception ex )
	//		{
	//			Console.WriteLine( ex.Message );

	//			return false;
	//		}
	//	}

	//	public static bool Initialize( )
	//	{
	//		Main main = Utility.GetMainForm( );

	//		if ( main != null )
	//			main.SetNetworkIcon( 2 );

	//		try
	//		{
	//			HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( "http://textuploader.com/d1286/raw" );
	//			request.Method = "GET";
	//			request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";
	//			request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";

	//			using ( HttpWebResponse response = ( HttpWebResponse ) request.GetResponse( ) )
	//			{
	//				using ( Stream responseStream = response.GetResponseStream( ) )
	//				{
	//					using ( StreamReader reader = new StreamReader( responseStream, Encoding.UTF8 ) )
	//					{
	//						string htmlString = reader.ReadToEnd( );

	//						if ( htmlString.Contains( ">Error 404</" ) )
	//						{
	//							if ( main != null )
	//								main.SetNetworkIcon( 3 );

	//							INITIALIZED = false;
	//							return false;
	//						}
	//						else
	//						{
	//							bool success = JSONDataParseAndFinish( htmlString );

	//							if ( success )
	//							{

	//								SYNC_TIMER = new Timer( Sync );
	//								SYNC_TIMER.Change( SYNC_INTERVAL * 1000, SYNC_INTERVAL * 1000 );

	//								Console.WriteLine( htmlString );
	//								Console.WriteLine( SERVER_STATUS.ToString( ) );
	//								Console.WriteLine( SYNC_INTERVAL.ToString( ) );
	//								Console.WriteLine( LATEST_VERSION.ToString( ) );

	//								Thread.Sleep( 1000 );

	//								if ( main != null )
	//									main.SetNetworkIcon( 1 );

	//								INITIALIZED = true;
	//								return true;
	//							}
	//							else
	//							{
	//								Console.WriteLine( "DATA ERROR" );

	//								if ( main != null )
	//									main.SetNetworkIcon( 3 );

	//								INITIALIZED = false;
	//								return true;
	//							}
	//						}
	//					}
	//				}
	//			}
	//		}
	//		catch ( NullReferenceException ex ) // json 데이터 손상
	//		{
	//			Console.WriteLine( "NullReferenceException:" + ex.Message );
	//			INITIALIZED = false;

	//			return false;
	//		}
	//		catch ( FormatException ex ) // 올바른 json string 이 아닐경우
	//		{
	//			Console.WriteLine( "FormatException:" + ex.Message );
	//			INITIALIZED = false;

	//			return false;
	//		}
	//		catch ( WebException ex )
	//		{
	//			Console.WriteLine( ex.Message );
	//			INITIALIZED = false;

	//			return false;
	//		}
	//		catch ( Exception ex )
	//		{
	//			Console.WriteLine( ex.Message );
	//			INITIALIZED = false;

	//			return false;
	//		}
	//	}

	//	public static void SendLogData( string dataJSON )
	//	{
	//		try
	//		{
	//			string url = "http://127.0.0.1:8085/cafemaster/log.php";

	//			byte[ ] sendData = Encoding.UTF8.GetBytes( "token=" + TOKEN + "&data=" + Convert.ToBase64String( Encoding.UTF8.GetBytes( dataJSON ) ) );


	//			HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( url );
	//			request.Method = "POST";
	//			request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";
	//			request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";




	//			request.ContentLength = sendData.Length;

	//			using ( Stream requestStream = request.GetRequestStream( ) )
	//			{
	//				requestStream.Write( sendData, 0, sendData.Length );
	//			}


	//			using ( StreamWriter requestStream = new StreamWriter( request.GetRequestStream( ), Encoding.UTF8 ) )
	//			{
	//				requestStream.Write( sendData );
	//			}

	//			using ( HttpWebResponse response = ( HttpWebResponse ) request.GetResponse( ) )
	//			{
	//				using ( Stream responseStream = response.GetResponseStream( ) )
	//				{
	//					using ( StreamReader reader = new StreamReader( responseStream, Encoding.UTF8 ) )
	//					{
	//						string htmlString = reader.ReadToEnd( );

	//						JsonObjectCollection jsonCollection = ( JsonObjectCollection ) ( new JsonTextParser( ) ).Parse( htmlString );

	//						Console.WriteLine( htmlString );
	//					}
	//				}
	//			}
	//		}
	//		catch ( Exception ex )
	//		{
	//			Console.WriteLine( ex.Message );
	//		}
	//	}

	//	public static byte[ ] EncryptData( string dataJSON )
	//	{
	//		try
	//		{
	//			string passKey = "TEST";

	//			PasswordDeriveBytes key = new PasswordDeriveBytes( passKey, Encoding.ASCII.GetBytes( passKey.Length.ToString( ) ) );
	//			ICryptoTransform encrypt = ( new RijndaelManaged( ) ).CreateEncryptor( key.GetBytes( 32 ), key.GetBytes( 16 ) );

	//			byte[ ] stringByteData = Encoding.UTF8.GetBytes( dataJSON );

	//			MemoryStream ms = new MemoryStream( );
	//			CryptoStream cryptoStream = new CryptoStream( ms, encrypt, CryptoStreamMode.Write );

	//			cryptoStream.Write( stringByteData, 0, stringByteData.Length );
	//			cryptoStream.FlushFinalBlock( );

	//			return ms.ToArray( );
	//			ms.ToArray( );
	//		}
	//		catch ( Exception ex )
	//		{
	//			Console.WriteLine( ex.Message );

	//			return new byte[ ] { };
	//		}
	//	}
	//}
}
