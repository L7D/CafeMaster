using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CafeMaster_UI.Lib
{
	static class AutoLogin
	{
		public enum SetAccountDataResult
		{
			EncryptFailed,
			FileCreateFailed,
			Unknown,
			Success
		}

		public enum GetAccountDataResult
		{
			DecryptFailed,
			FileNotFound,
			Unknown,
			Success
		}

		private static string KEY
		{
			get
			{
				return "MilkPowerCafeStaff-AESKey-" + Environment.MachineName;
			}
		}

		public static bool IsEnabled( )
		{
			return File.Exists( GlobalVar.APP_DIR + @"\data\account.dat" );
		}

		public static bool DeleteAccountData( )
		{
			try
			{
				if ( File.Exists( GlobalVar.APP_DIR + @"\data\account.dat" ) )
				{
					File.Delete( GlobalVar.APP_DIR + @"\data\account.dat" );

					return true;
				}
				else
				{
					Utility.LogWrite( "AccountFileNotFound", Utility.LogSeverity.ERROR );
					return false;
				}
			}
			catch ( Exception ex )
			{
				Utility.LogWrite( ex.Message, Utility.LogSeverity.EXCEPTION );
				return false;
			}
		}

		public static SetAccountDataResult SetAccountData( string id, string pwd )
		{
			try
			{
				string passKey = KEY;

				PasswordDeriveBytes key = new PasswordDeriveBytes( passKey, Encoding.ASCII.GetBytes( passKey.Length.ToString( ) ) );
				ICryptoTransform encrypt = ( new RijndaelManaged( ) ).CreateEncryptor( key.GetBytes( 32 ), key.GetBytes( 16 ) );

				byte[ ] stringByteData = Encoding.UTF8.GetBytes( id + "\n" + pwd );

				MemoryStream ms = new MemoryStream( );
				CryptoStream cryptoStream = new CryptoStream( ms, encrypt, CryptoStreamMode.Write );

				cryptoStream.Write( stringByteData, 0, stringByteData.Length );
				cryptoStream.FlushFinalBlock( );

				if ( !Directory.Exists( GlobalVar.APP_DIR + @"\data" ) )
				{
					Directory.CreateDirectory( GlobalVar.APP_DIR + @"\data" );
				}

				File.WriteAllBytes( GlobalVar.APP_DIR + @"\data\account.dat", ms.ToArray( ) );

				return SetAccountDataResult.Success;
			}
			catch ( CryptographicException ex )
			{
				Utility.LogWrite( ex.Message, Utility.LogSeverity.EXCEPTION );
				return SetAccountDataResult.EncryptFailed;
			}
			catch ( IOException ex )
			{
				Utility.LogWrite( "IOException - " + ex.Message, Utility.LogSeverity.EXCEPTION );
				return SetAccountDataResult.FileCreateFailed;
			}
			catch ( UnauthorizedAccessException ex )
			{
				Utility.LogWrite( "UnauthorizedAccessException - " + ex.Message, Utility.LogSeverity.EXCEPTION );
				return SetAccountDataResult.FileCreateFailed;
			}
			catch ( Exception ex )
			{
				Utility.LogWrite( ex.Message, Utility.LogSeverity.EXCEPTION );
				return SetAccountDataResult.Unknown;
			}
		}

		// http://stackoverflow.com/questions/240258/removing-trailing-nulls-from-byte-array-in-c-sharp
		private static byte[ ] TrimByte( byte[ ] fileByte )
		{
			var i = fileByte.Length - 1;
			while ( fileByte[ i ] == 0 )
			{
				--i;
			}
			var temp = new byte[ i + 1 ];
			Array.Copy( fileByte, temp, i + 1 );
			return temp;
		}

		public static GetAccountDataResult GetAccountData( out string accountString )
		{
			if ( !File.Exists( GlobalVar.APP_DIR + @"\data\account.dat" ) )
			{
				accountString = null;
				return GetAccountDataResult.FileNotFound;
			}

			try
			{
				string passKey = KEY;

				PasswordDeriveBytes key = new PasswordDeriveBytes( passKey, Encoding.ASCII.GetBytes( passKey.Length.ToString( ) ) );
				ICryptoTransform decrypt = ( new RijndaelManaged( ) ).CreateDecryptor( key.GetBytes( 32 ), key.GetBytes( 16 ) );

				byte[ ] fileByte = File.ReadAllBytes( GlobalVar.APP_DIR + @"\data\account.dat" );

				MemoryStream ms = new MemoryStream( fileByte );
				CryptoStream cryptoStream = new CryptoStream( ms, decrypt, CryptoStreamMode.Read );

				byte[ ] originalData = new byte[ fileByte.Length ];

				int count = cryptoStream.Read( originalData, 0, originalData.Length );

				accountString = Encoding.UTF8.GetString( TrimByte( originalData ) );

				return GetAccountDataResult.Success;
			}
			catch ( CryptographicException ex )
			{
				Utility.LogWrite( ex.Message, Utility.LogSeverity.EXCEPTION );
				accountString = null;
				return GetAccountDataResult.DecryptFailed;
			}
			catch ( Exception ex )
			{
				Utility.LogWrite( ex.Message, Utility.LogSeverity.EXCEPTION );
				accountString = null;
				return GetAccountDataResult.Unknown;
			}
		}
	}
}
