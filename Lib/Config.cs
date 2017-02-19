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

				sb.Append( "[Milk Power Cafe Staff Config]" + Environment.NewLine + Environment.NewLine );

				foreach ( string data in CONFIGS.Keys )
				{
					sb.AppendLine( data + " = " + CONFIGS[ data ] );
				}

				if ( !Directory.Exists( GlobalVar.DATA_DIR ) )
					Directory.CreateDirectory( GlobalVar.DATA_DIR );

				File.WriteAllText( GlobalVar.CONFIG_DIR, sb.ToString( ), Encoding.UTF8 );
			}
			catch ( IOException ex )
			{
				Utility.LogWrite( "ConfigIOError - " + ex.Message, Utility.LogSeverity.EXCEPTION );
			}
			catch ( Exception ex )
			{
				Utility.LogWrite( ex.Message, Utility.LogSeverity.EXCEPTION );
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
					if ( i.StartsWith( "[" ) && i.EndsWith( "]" ) ) continue;

					string[ ] str = i.Split( new char[ 1 ] { '=' }, StringSplitOptions.RemoveEmptyEntries );

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
				Utility.LogWrite( "ConfigIOError - " + ex.Message, Utility.LogSeverity.EXCEPTION );
			}
			catch ( IndexOutOfRangeException ex )
			{
				Utility.LogWrite( "ConfigStructError - " + ex.Message, Utility.LogSeverity.EXCEPTION );
			}
			catch ( Exception ex )
			{
				Utility.LogWrite( ex.Message, Utility.LogSeverity.EXCEPTION );
			}
		}

		public static void Reset( )
		{
			string configValue = @"[Milk Power Cafe Staff Config]$$SoundMute = False$SyncInterval = 30$CaptureEnable = True$UXSendEnable = True".Replace( "$", Environment.NewLine );

			try
			{
				if ( !Directory.Exists( GlobalVar.DATA_DIR ) )
					Directory.CreateDirectory( GlobalVar.DATA_DIR );

				File.WriteAllText( GlobalVar.CONFIG_DIR, configValue, Encoding.UTF8 );

				Hashtable tempTable = new Hashtable( );

				foreach ( string i in File.ReadAllLines( GlobalVar.CONFIG_DIR, Encoding.UTF8 ) )
				{
					if ( string.IsNullOrEmpty( i ) ) continue;
					if ( i.StartsWith( "[" ) && i.EndsWith( "]" ) ) continue;

					string[ ] str = i.Split( new char[ 1 ] { '=' }, StringSplitOptions.RemoveEmptyEntries );

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
				Utility.LogWrite( "ConfigIOError - " + ex.Message, Utility.LogSeverity.EXCEPTION );
			}
			catch ( IndexOutOfRangeException ex )
			{
				Utility.LogWrite( "ConfigStructError - " + ex.Message, Utility.LogSeverity.EXCEPTION );
			}
			catch ( Exception ex )
			{
				Utility.LogWrite( ex.Message, Utility.LogSeverity.EXCEPTION );
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
