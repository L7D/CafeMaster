using System;
using System.IO;
using System.Management;
using System.Security.Cryptography;
using System.Text;

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

		private static string AESKEY
		{
			get
			{
				// http://chindaara.blogspot.kr/2013/05/get-bios-serial-number.html

				foreach ( ManagementObject data in ( new ManagementObjectSearcher( " Select * From Win32_BIOS " ) ).Get( ) )
				{
					return "MILK_POWER_CAFE_STAFF^KEY^" + data[ "SerialNumber" ].ToString( );
				}

				return "MILK_POWER_CAFE_STAFF^KEY^" + Environment.MachineName;
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
					Utility.WriteErrorLog( "AccountFileNotFound", Utility.LogSeverity.ERROR );
					return false;
				}
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				return false;
			}
		}

		public static SetAccountDataResult SetAccountData( string id, string pwd, string nickName )
		{
			try
			{
				byte[ ] utf8KeyByte = Encoding.UTF8.GetBytes( AESKEY );
				byte[ ] key = new byte[ 16 ];

				Array.Copy(
					utf8KeyByte,
					key,
					utf8KeyByte.Length > key.Length ? key.Length : utf8KeyByte.Length
				);

				RijndaelManaged rijndaelCipher = new RijndaelManaged( )
				{
					Mode = CipherMode.CBC,
					Padding = PaddingMode.PKCS7,
					KeySize = 128,
					BlockSize = 128,
					Key = key,
					IV = key
				};
				ICryptoTransform encrypt = rijndaelCipher.CreateEncryptor( );

				byte[ ] stringByteData = Encoding.UTF8.GetBytes( id + "\n" + pwd + "\n" + nickName );

				if ( !Directory.Exists( GlobalVar.APP_DIR + @"\data" ) )
					Directory.CreateDirectory( GlobalVar.APP_DIR + @"\data" );

				File.WriteAllText( GlobalVar.APP_DIR + @"\data\account.dat",
					@"// 우윳빛깔 카페스탭 자동 로그인 데이터 파일 //" + Environment.NewLine + "// 경고 : 절대로 다른 사람에게 이 파일을 공유하지 마십시오, 개인정보가 유출될 수 있습니다!!! //" + Environment.NewLine + Environment.NewLine +
					Convert.ToBase64String( encrypt.TransformFinalBlock( stringByteData, 0, stringByteData.Length ) ) );

				return SetAccountDataResult.Success;
			}
			catch ( CryptographicException ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				return SetAccountDataResult.EncryptFailed;
			}
			catch ( IOException ex )
			{
				Utility.WriteErrorLog( "IOException - " + ex.Message, Utility.LogSeverity.EXCEPTION );
				return SetAccountDataResult.FileCreateFailed;
			}
			catch ( UnauthorizedAccessException ex )
			{
				Utility.WriteErrorLog( "UnauthorizedAccessException - " + ex.Message, Utility.LogSeverity.EXCEPTION );
				return SetAccountDataResult.FileCreateFailed;
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				return SetAccountDataResult.Unknown;
			}
		}

		public static void ModifyAccountDataNickName( string newNickName )
		{
			string dataString;

			if ( AutoLogin.GetAccountData( out dataString ) == GetAccountDataResult.Success )
			{
				string[ ] dataTable = dataString.Trim( ).Split( '\n' );

				if ( dataTable.Length == 3 && dataTable[ 2 ] != newNickName )
				{
					AutoLogin.SetAccountData(
						dataTable[ 0 ],
						dataTable[ 1 ],
						newNickName
					);
				}
			}
		}

		// http://intro0517.tistory.com/37
		public static GetAccountDataResult GetAccountData( out string accountString )
		{
			if ( !File.Exists( GlobalVar.APP_DIR + @"\data\account.dat" ) )
			{
				accountString = null;
				return GetAccountDataResult.FileNotFound;
			}

			try
			{
				byte[ ] utf8KeyByte = Encoding.UTF8.GetBytes( AESKEY );
				byte[ ] key = new byte[ 16 ];

				Array.Copy(
					utf8KeyByte,
					key,
					utf8KeyByte.Length > key.Length ? key.Length : utf8KeyByte.Length
				);

				RijndaelManaged rijndaelCipher = new RijndaelManaged( )
				{
					Mode = CipherMode.CBC,
					Padding = PaddingMode.PKCS7,
					KeySize = 128,
					BlockSize = 128,
					Key = key,
					IV = key
				};
				ICryptoTransform decrypt = rijndaelCipher.CreateDecryptor( );

				string[ ] dataLines = File.ReadAllLines( GlobalVar.APP_DIR + @"\data\account.dat" );

				if ( dataLines.Length != 4 )
				{
					throw new Exception( "올바르지 않은 데이터 파일" );
				}

				byte[ ] encryptedData = Convert.FromBase64String( dataLines[ 3 ] );

				accountString = Encoding.UTF8.GetString( decrypt.TransformFinalBlock( encryptedData, 0, encryptedData.Length ) );

				return GetAccountDataResult.Success;
			}
			catch ( CryptographicException ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				accountString = null;
				return GetAccountDataResult.DecryptFailed;
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				accountString = null;
				return GetAccountDataResult.Unknown;
			}
		}
	}
}
