using System;
using System.Collections;
using System.IO;
using System.Text;

namespace CafeMaster_UI.Lib
{
	static class Config
	{
		private static Hashtable CONFIGS = new Hashtable( );

		static Config( )
		{
			Load( );
		}

		public static void Save( )
		{
			try
			{
				StringBuilder sb = new StringBuilder( );

				sb.AppendLine( "# 우윳빛깔 카페스탭 설정 파일 ver " + GlobalVar.CURRENT_VERSION + " #" );
				sb.AppendLine( "# 이 파일을 함부로 수정하지 마세요! #" + Environment.NewLine );

				int count = 0;
				foreach ( string data in CONFIGS.Keys )
				{
					if ( ++count == CONFIGS.Count )
						sb.Append( data + " -> " + CONFIGS[ data ] );
					else
						sb.AppendLine( data + " -> " + CONFIGS[ data ] );
				}

				if ( !Directory.Exists( GlobalVar.DATA_DIR ) )
					Directory.CreateDirectory( GlobalVar.DATA_DIR );

				File.WriteAllText( GlobalVar.CONFIG_DIR, sb.ToString( ), Encoding.UTF8 );
			}
			catch ( IOException ex )
			{
				Utility.WriteErrorLog( "ConfigIOError - " + ex.Message, Utility.LogSeverity.EXCEPTION );
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
			}
		}

		public static void Load( )
		{
			try
			{
				if ( !Directory.Exists( GlobalVar.DATA_DIR ) )
					Directory.CreateDirectory( GlobalVar.DATA_DIR );

				if ( !File.Exists( GlobalVar.CONFIG_DIR ) )
				{
					Reset( );
					return;
				}

				Hashtable tempTable = new Hashtable( );

				foreach ( string i in File.ReadAllLines( GlobalVar.CONFIG_DIR, Encoding.UTF8 ) )
				{
					if ( string.IsNullOrEmpty( i ) ) continue;
					if ( i.StartsWith( "#" ) && i.EndsWith( "#" ) ) continue;

					string[ ] str = i.Split( new string[ 1 ] { "->" }, StringSplitOptions.RemoveEmptyEntries );

					if ( str.Length > 2 )
					{
						// Test -> Value -> Data 같은 config 데이터를 처리하기 위함
						tempTable.Add(
							str[ 0 ].Trim( ),
							i.Substring( i.IndexOf( "->" ) + 2 ).Trim( )
						);
					}
					else
					{
						tempTable.Add(
							str[ 0 ].Trim( ),
							str[ 1 ].Trim( )
						);
					}
				}

				CONFIGS = tempTable;
			}
			catch ( IOException ex )
			{
				Utility.WriteErrorLog( "ConfigIOError - " + ex.Message, Utility.LogSeverity.EXCEPTION );
			}
			catch ( ArgumentOutOfRangeException ex )
			{
				Utility.WriteErrorLog( "ConfigStringIndexError - " + ex.Message, Utility.LogSeverity.EXCEPTION );
				Reset( );
			}
			catch ( IndexOutOfRangeException ex )
			{
				Utility.WriteErrorLog( "ConfigIndexError - " + ex.Message, Utility.LogSeverity.EXCEPTION );
				Reset( );
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
			}
		}

		public static void Reset( )
		{
			string configValue = "# 우윳빛깔 카페스탭 설정 파일 ver " + GlobalVar.CURRENT_VERSION + " #$# 이 파일을 함부로 수정하지 마세요! #$$SoundEnable -> 1$SyncInterval -> 30$CaptureEnable -> 1$UXSendEnable -> 1".Replace( "$", Environment.NewLine );

			try
			{
				if ( !Directory.Exists( GlobalVar.DATA_DIR ) )
					Directory.CreateDirectory( GlobalVar.DATA_DIR );

				File.WriteAllText( GlobalVar.CONFIG_DIR, configValue, Encoding.UTF8 );

				Hashtable tempTable = new Hashtable( );

				foreach ( string i in File.ReadAllLines( GlobalVar.CONFIG_DIR, Encoding.UTF8 ) )
				{
					if ( string.IsNullOrEmpty( i ) ) continue;
					if ( i.StartsWith( "#" ) && i.EndsWith( "#" ) ) continue;

					string[ ] str = i.Split( new string[ 1 ] { "->" }, StringSplitOptions.RemoveEmptyEntries );

					if ( str.Length == 2 )
					{
						tempTable.Add(
							str[ 0 ].Trim( ),
							str[ 1 ].Trim( )
						);
					}
				}

				CONFIGS = tempTable;
			}
			catch ( IOException ex )
			{
				Utility.WriteErrorLog( "ConfigIOError - " + ex.Message, Utility.LogSeverity.EXCEPTION );
			}
			catch ( IndexOutOfRangeException ex )
			{
				Utility.WriteErrorLog( "ConfigIndexError - " + ex.Message, Utility.LogSeverity.EXCEPTION );
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
			}
		}

		public static string Get( string id, string defaultData = null )
		{
			object data = CONFIGS[ id ];

			if ( data != null )
				return data.ToString( );
			else
			{
				if ( defaultData == null )
					return default( string );
				else
					return defaultData;
			}
		}

		public static void Set( string id, string data )
		{
			CONFIGS[ id ] = data;

			Save( );
		}
	}
}