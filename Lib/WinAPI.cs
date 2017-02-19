using System;
using System.Runtime.InteropServices;

namespace CafeMaster_UI.Lib
{
	static class WinAPI
	{
		[DllImport( "user32.dll" )]
		private static extern uint FindWindow( string lpClassName, string lpWindowName );

		[DllImport( "user32.dll" )]
		private static extern uint FindWindowEx( uint hWnd1, uint hWnd2, string lpsz1, string lpsz2 );

		[DllImport( "user32.dll" )]
		private static extern uint SendMessage( uint hwnd, uint wMsg, uint wParam, uint lParam );

		[DllImport( "user32.dll" )]
		private static extern uint PostMessage( uint hwnd, uint wMsg, uint wParam, uint lParam );

		[DllImport( "user32.dll" )]
		private static extern bool SetForegroundWindow( IntPtr hwnd );

		public static uint FindWin( string lpClassName, string lpWindowName )
		{
			return FindWindow( lpClassName, lpWindowName );
		}

		public static void FocusWindow( IntPtr hwnd )
		{
			SetForegroundWindow( hwnd );
		}

		[DllImport( "wininet.dll", CharSet = CharSet.Auto, SetLastError = true )]
		public static extern bool InternetSetCookie( string lpszUrlName, string lbszCookieName, string lpszCookieData );

		[DllImport( "urlmon.dll" )]
		[PreserveSig]
		[return: MarshalAs( UnmanagedType.Error )]
		public static extern int CoInternetSetFeatureEnabled( int FeatureEntry, [MarshalAs( UnmanagedType.U4 )] int dwFlags, bool fEnable );

		// http://stackoverflow.com/questions/15720803/webbrowser-disable-all-audio-output-from-online-radio-to-youtube
		//[DllImport( "winmm.dll" )]
		//public static extern int waveOutGetVolume( IntPtr h, out uint dwVolume );

		//[DllImport( "winmm.dll" )]
		//public static extern int waveOutSetVolume( IntPtr h, uint dwVolume );
	}
}
