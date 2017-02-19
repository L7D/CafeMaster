using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMaster_UI.Lib
{
	// http://stackoverflow.com/questions/11309827/window-application-flash-like-orange-on-taskbar-when-minimize
	public static class FlashWindow
	{
		[DllImport( "user32.dll" )]
		[return: MarshalAs( UnmanagedType.Bool )]
		private static extern bool FlashWindowEx( ref FLASHWINFO pwfi );

		[StructLayout( LayoutKind.Sequential )]
		private struct FLASHWINFO
		{
			/// <summary>
			/// The size of the structure in bytes.
			/// </summary>
			public uint cbSize;
			/// <summary>
			/// A Handle to the Window to be Flashed. The window can be either opened or minimized.
			/// </summary>
			public IntPtr hwnd;
			/// <summary>
			/// The Flash Status.
			/// </summary>
			public uint dwFlags;
			/// <summary>
			/// The number of times to Flash the window.
			/// </summary>
			public uint uCount;
			/// <summary>
			/// The rate at which the Window is to be flashed, in milliseconds. If Zero, the function uses the default cursor blink rate.
			/// </summary>
			public uint dwTimeout;
		}

		/// <summary>
		/// Stop flashing. The system restores the window to its original stae.
		/// </summary>
		public const uint FLASHW_STOP = 0;

		/// <summary>
		/// Flash the window caption.
		/// </summary>
		public const uint FLASHW_CAPTION = 1;

		/// <summary>
		/// Flash the taskbar button.
		/// </summary>
		public const uint FLASHW_TRAY = 2;

		/// <summary>
		/// Flash both the window caption and taskbar button.
		/// This is equivalent to setting the FLASHW_CAPTION | FLASHW_TRAY flags.
		/// </summary>
		public const uint FLASHW_ALL = 3;

		/// <summary>
		/// Flash continuously, until the FLASHW_STOP flag is set.
		/// </summary>
		public const uint FLASHW_TIMER = 4;

		/// <summary>
		/// Flash continuously until the window comes to the foreground.
		/// </summary>
		public const uint FLASHW_TIMERNOFG = 12;


		/// <summary>
		/// Flash the spacified Window (Form) until it recieves focus.
		/// </summary>
		/// <param name="form">The Form (Window) to Flash.</param>
		/// <returns></returns>
		public static bool Flash( System.Windows.Forms.Form form )
		{
			// Make sure we're running under Windows 2000 or later
			if ( Win2000OrLater )
			{
				FLASHWINFO fi = Create_FLASHWINFO( form.Handle, FLASHW_ALL | FLASHW_TIMERNOFG, uint.MaxValue, 0 );
				return FlashWindowEx( ref fi );
			}
			return false;
		}

		private static FLASHWINFO Create_FLASHWINFO( IntPtr handle, uint flags, uint count, uint timeout )
		{
			FLASHWINFO fi = new FLASHWINFO( );
			fi.cbSize = Convert.ToUInt32( Marshal.SizeOf( fi ) );
			fi.hwnd = handle;
			fi.dwFlags = flags;
			fi.uCount = count;
			fi.dwTimeout = timeout;
			return fi;
		}

		/// <summary>
		/// Flash the specified Window (form) for the specified number of times
		/// </summary>
		/// <param name="form">The Form (Window) to Flash.</param>
		/// <param name="count">The number of times to Flash.</param>
		/// <returns></returns>
		public static bool Flash( System.Windows.Forms.Form form, uint count )
		{
			if ( Win2000OrLater )
			{
				FLASHWINFO fi = Create_FLASHWINFO( form.Handle, FLASHW_ALL, count, 0 );
				return FlashWindowEx( ref fi );
			}
			return false;
		}

		/// <summary>
		/// Start Flashing the specified Window (form)
		/// </summary>
		/// <param name="form">The Form (Window) to Flash.</param>
		/// <returns></returns>
		public static bool Start( System.Windows.Forms.Form form )
		{
			if ( Win2000OrLater )
			{
				FLASHWINFO fi = Create_FLASHWINFO( form.Handle, FLASHW_ALL, uint.MaxValue, 0 );
				return FlashWindowEx( ref fi );
			}
			return false;
		}

		/// <summary>
		/// Stop Flashing the specified Window (form)
		/// </summary>
		/// <param name="form"></param>
		/// <returns></returns>
		public static bool Stop( System.Windows.Forms.Form form )
		{
			if ( Win2000OrLater )
			{
				FLASHWINFO fi = Create_FLASHWINFO( form.Handle, FLASHW_STOP, uint.MaxValue, 0 );
				return FlashWindowEx( ref fi );
			}
			return false;
		}

		/// <summary>
		/// A boolean value indicating whether the application is running on Windows 2000 or later.
		/// </summary>
		private static bool Win2000OrLater
		{
			get { return System.Environment.OSVersion.Version.Major >= 5; }
		}
	}

	static class Utility
	{
		// Lerp (Linear interpolation, 선형보간법) 
		// p 의 값이 0에 가까워질수록 ( a - b ) 에 비례하여 중간 값이 커진다 (애니메이션이 빨라진다)
		// p 의 값이 1에 가까워질수록 ( a - b ) 에 비례하여 중간 값이 작아진다 (애니메이션이 느려진다)
		// ( p 의 값이 0 ~ 1F )
		// http://stackoverflow.com/questions/33044848/c-sharp-lerping-from-position-to-position
		// http://dodnet.tistory.com/993
		public static float Lerp( float a, float b, float p )
		{
			return a * p + b * ( 1 - p );
		}

		public static int Clamp( int original, int max, int min )
		{
			if ( original > max )
				return max;

			if ( original < min )
				return min;

			return original;
		}

		public static Color LerpColor( Color a, Color b, float p )
		{
			float newR = 0, newG = 0, newB = 0, newA = 0;

			newR = a.R * p + b.R * ( 1 - p );
			newG = a.G * p + b.G * ( 1 - p );
			newB = a.B * p + b.B * ( 1 - p );
			newA = a.A * p + b.A * ( 1 - p );

			//return Color.FromArgb( (int)Math.Round( newR ), ( int ) newG, ( int ) newB );
			return Color.FromArgb( ( int ) Math.Round( newA ), ( int ) Math.Round( newR ), ( int ) Math.Round( newG ), ( int ) Math.Round( newB ) );
		}

		// http://bananamandoo.tistory.com/27
		public static void Delay( int ms )
		{
			DateTime ThisMoment = DateTime.Now;
			DateTime AfterWards = ThisMoment.Add( new TimeSpan( 0, 0, 0, 0, ms ) );

			while ( AfterWards >= ThisMoment )
			{
				Application.DoEvents( );
				ThisMoment = DateTime.Now;
			}
		}

		public static string StripFolderName( string folderName )
		{
			return System.Text.RegularExpressions.Regex.Replace( folderName, "[\\\\/:*?\"<>|]", "_" );
		}

		public enum LogSeverity
		{
			NORMAL,
			EXCEPTION,
			ERROR
		}

		// https://msdn.microsoft.com/ko-kr/library/8kb3ddd4(v=vs.110).aspx
		// http://www.codeproject.com/Tips/606379/Caller-Info-Attributes-in-Csharp
		public static void LogWrite( string errorString, LogSeverity severity = LogSeverity.NORMAL,
		[CallerMemberName] string debugTrace_CallerName = null,
		[CallerFilePath] string debugTrace_CallerFilePath = null,
		[CallerLineNumber] int debugTrace_CallerLine = -1 )
		{
			try
			{
				string path = GlobalVar.APP_DIR + @"\log\" + DateTime.Now.ToString( "yyyy-MM-dd" );

				if ( !Directory.Exists( path ) )
					Directory.CreateDirectory( path );

				File.AppendAllText( path + @"\error.log",
					string.Format( "CafeMaster_CrashLog_{0} @{1} :	{2} -> #{3}		{4}:{5}" + Environment.NewLine,
						DateTime.Now.ToString( "HH:mm:ss" ), // 0
						severity.ToString( ), // 1
						debugTrace_CallerName, // 2
						errorString, // 3
						Path.GetFileName( debugTrace_CallerFilePath ), // 4
						debugTrace_CallerLine // 5
					),
				Encoding.UTF8 );
			}
			catch ( Exception ) { }
		}

		// http://stackoverflow.com/questions/14488796/does-net-provide-an-easy-way-convert-bytes-to-kb-mb-gb-etc
		private static readonly string[ ] SizeSuffixes =
				  { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

		public static string SizeSuffix( Int64 value, int decimalPlaces = 1 )
		{
			if ( value < 0 ) { return "-" + SizeSuffix( -value ); }

			int i = 0;
			decimal dValue = ( decimal ) value;
			while ( Math.Round( dValue, decimalPlaces ) >= 1000 )
			{
				dValue /= 1024;
				i++;
			}

			return string.Format( "{0:n" + decimalPlaces + "} {1}", dValue, SizeSuffixes[ i ] );
		}

		public static Form GetFormByName( string name )
		{
			foreach ( Form i in Application.OpenForms )
			{
				if ( i.Name == name )
					return i;
			}

			return null;
		}

		public static Main GetMainForm( )
		{
			foreach ( Form i in Application.OpenForms )
			{
				if ( i.Name == "Main" )
					return ( Main ) i;
			}

			return null;
		}

		// http://stackoverflow.com/questions/10520048/calculate-md5-checksum-for-a-file
		public static string GetMD5Hash( string fileName )
		{
			using ( MD5 md5 = MD5.Create( ) )
			{
				using ( FileStream stream = File.OpenRead( fileName ) )
				{
					return Convert.ToBase64String( md5.ComputeHash( stream ) );
				}
			}
		}

		public static string GetMD5Hash( byte[ ] fileByte )
		{
			using ( MD5 md5 = MD5.Create( ) )
			{
				using ( Stream stream = new MemoryStream( fileByte ) )
				{
					return Convert.ToBase64String( md5.ComputeHash( stream ) );
				}
			}
		}

		public static void URLSetAllNaverCookie( string url )
		{
			foreach ( CookieStruct i in GlobalVar.COOKIES_LIST )
			{
				WinAPI.InternetSetCookie( url, i.id, i.value );
			}
		}

		// http://fdin.tistory.com/entry/C%EC%97%90%EC%84%9C-WebBrowser-cookie%EB%A5%BC-HttpWebRequest%EB%A1%9C-%EC%98%AE%EA%B8%B0%EA%B8%B0
		public static class CookieFetch
		{
			[DllImport( "wininet.dll", SetLastError = true )]
			private static extern bool InternetGetCookieEx(
		string url,
		string cookieName,
		StringBuilder cookieData,
		ref int size,
		Int32 dwFlags,
		IntPtr lpReserved );

			private const Int32 InternetCookieHttponly = 0x2000;

			/// <summary>  
			/// Gets the URI cookie container.  
			/// </summary>  
			/// <param name="uri">The URI.  
			/// <returns></returns>  
			public static CookieContainer GetUriCookieContainer( Uri uri )
			{
				CookieContainer cookies = null;
				// Determine the size of the cookie  
				int datasize = 8192 * 16;
				StringBuilder cookieData = new StringBuilder( datasize );
				if ( !InternetGetCookieEx( uri.ToString( ), null, cookieData, ref datasize, InternetCookieHttponly, IntPtr.Zero ) )
				{
					if ( datasize < 0 )
						return null;
					// Allocate stringbuilder large enough to hold the cookie  
					cookieData = new StringBuilder( datasize );
					if ( !InternetGetCookieEx(
						uri.ToString( ),
						null, cookieData,
						ref datasize,
						InternetCookieHttponly,
						IntPtr.Zero ) )
						return null;
				}

				if ( cookieData.Length > 0 )
				{
					cookies = new CookieContainer( );
					cookies.SetCookies( uri, cookieData.ToString( ).Replace( ';', ',' ) );
				}

				return cookies;
			}
		}

		public static MemoryStream FileToMemoryStream( string dir )
		{
			try
			{
				return new MemoryStream( File.ReadAllBytes( dir ) );
			}
			catch
			{
				return null;
			}
		}
		public static MemoryStream URLFileToMemoryStream( string url )
		{
			try
			{
				return new MemoryStream( ( new WebClient( ) ).DownloadData( url ) );
			}
			catch
			{
				return null;
			}
		}

		public static byte[ ] URLFileToByteArray( string url )
		{
			try
			{
				return ( new WebClient( ) ).DownloadData( url );
			}
			catch
			{
				return new byte[ ] { };
			}
		}
	}

	// http://www.philosophicalgeek.com/2009/01/03/determine-cpu-usage-of-current-process-c-and-c/
	//class CpuUsage
	//{
	//	[DllImport( "kernel32.dll", SetLastError = true )]
	//	static extern bool GetSystemTimes(
	//				out System.Runtime.InteropServices.ComTypes.FILETIME lpIdleTime,
	//				out System.Runtime.InteropServices.ComTypes.FILETIME lpKernelTime,
	//				out System.Runtime.InteropServices.ComTypes.FILETIME lpUserTime
	//				);

	//	System.Runtime.InteropServices.ComTypes.FILETIME _prevSysKernel;
	//	System.Runtime.InteropServices.ComTypes.FILETIME _prevSysUser;

	//	TimeSpan _prevProcTotal;

	//	Int16 _cpuUsage;
	//	DateTime _lastRun;
	//	long _runCount;

	//	public CpuUsage( )
	//	{
	//		_cpuUsage = -1;
	//		_lastRun = DateTime.MinValue;
	//		_prevSysUser.dwHighDateTime = _prevSysUser.dwLowDateTime = 0;
	//		_prevSysKernel.dwHighDateTime = _prevSysKernel.dwLowDateTime = 0;
	//		_prevProcTotal = TimeSpan.MinValue;
	//		_runCount = 0;
	//	}

	//	public short GetUsage( )
	//	{
	//		short cpuCopy = _cpuUsage;
	//		if ( Interlocked.Increment( ref _runCount ) == 1 )
	//		{
	//			if ( !EnoughTimePassed )
	//			{
	//				Interlocked.Decrement( ref _runCount );
	//				return cpuCopy;
	//			}

	//			System.Runtime.InteropServices.ComTypes.FILETIME sysIdle, sysKernel, sysUser;
	//			TimeSpan procTime;

	//			Process process = Process.GetCurrentProcess( );
	//			procTime = process.TotalProcessorTime;

	//			if ( !GetSystemTimes( out sysIdle, out sysKernel, out sysUser ) )
	//			{
	//				Interlocked.Decrement( ref _runCount );
	//				return cpuCopy;
	//			}

	//			if ( !IsFirstRun )
	//			{
	//				UInt64 sysKernelDiff = SubtractTimes( sysKernel, _prevSysKernel );
	//				UInt64 sysUserDiff = SubtractTimes( sysUser, _prevSysUser );

	//				UInt64 sysTotal = sysKernelDiff + sysUserDiff;

	//				Int64 procTotal = procTime.Ticks - _prevProcTotal.Ticks;

	//				if ( sysTotal > 0 )
	//				{
	//					_cpuUsage = ( short ) ( ( 100.0 * procTotal ) / sysTotal );
	//				}
	//			}

	//			_prevProcTotal = procTime;
	//			_prevSysKernel = sysKernel;
	//			_prevSysUser = sysUser;

	//			_lastRun = DateTime.Now;

	//			cpuCopy = _cpuUsage;
	//		}
	//		Interlocked.Decrement( ref _runCount );

	//		return cpuCopy;

	//	}

	//	private UInt64 SubtractTimes( System.Runtime.InteropServices.ComTypes.FILETIME a, System.Runtime.InteropServices.ComTypes.FILETIME b )
	//	{
	//		UInt64 aInt = ( ( UInt64 ) ( a.dwHighDateTime << 32 ) ) | ( UInt64 ) a.dwLowDateTime;
	//		UInt64 bInt = ( ( UInt64 ) ( b.dwHighDateTime << 32 ) ) | ( UInt64 ) b.dwLowDateTime;

	//		return aInt - bInt;
	//	}

	//	private bool EnoughTimePassed
	//	{
	//		get
	//		{
	//			const int minimumElapsedMS = 250;
	//			TimeSpan sinceLast = DateTime.Now - _lastRun;
	//			return sinceLast.TotalMilliseconds > minimumElapsedMS;
	//		}
	//	}

	//	private bool IsFirstRun
	//	{
	//		get
	//		{
	//			return ( _lastRun == DateTime.MinValue );
	//		}
	//	}
	//}
}
