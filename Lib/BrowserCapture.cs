using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CafeMaster_UI.Lib
{
	// http://pietschsoft.com/post/2008/07/C-Generate-WebPage-Thumbmail-Screenshot-Image
	static class BrowserCapture
	{
		public static void Capture( string threadNumber )
		{
			lock ( typeof( BrowserCapture ) )
			{
				try
				{
					string url = "http://cafe.naver.com/" + GlobalVar.CAFE_URL_ID + "/" + threadNumber;

					WebBrowser wb = new WebBrowser( );
					wb.ScrollBarsEnabled = false;
					wb.ScriptErrorsSuppressed = true;

					WinAPI.CoInternetSetFeatureEnabled( 21, 0x00000002, true );
					Utility.SetUriCookieContainerToNaverCookies( url );

					wb.Navigate( url );

					while ( wb.ReadyState != WebBrowserReadyState.Complete )
					{
						Application.DoEvents( );
					}

					wb.Width = wb.Document.Body.ScrollRectangle.Width;
					wb.Height = wb.Document.Body.ScrollRectangle.Height;

					Bitmap bitmap = new Bitmap( wb.Width, wb.Height );
					wb.DrawToBitmap( bitmap, new Rectangle( 0, 0, wb.Width, wb.Height ) );
					wb.Dispose( );

					if ( !Directory.Exists( GlobalVar.CAPTURE_DIR ) )
						Directory.CreateDirectory( GlobalVar.CAPTURE_DIR );

					bitmap.Save( GlobalVar.CAPTURE_DIR + "\\" + threadNumber + ".png", System.Drawing.Imaging.ImageFormat.Png );
					bitmap.Dispose( );
				}
				catch ( Exception ex )
				{
					Utility.WriteErrorLog( "CaptureException #" + threadNumber + " - " + ex.Message, Utility.LogSeverity.EXCEPTION );
				}
			}
		}

		public static bool FileAvailable( string threadNumber )
		{
			return File.Exists( GlobalVar.CAPTURE_DIR + "\\" + threadNumber + ".png" );
		}

		public static void OpenImage( string threadNumber )
		{
			if ( File.Exists( GlobalVar.CAPTURE_DIR + "\\" + threadNumber + ".png" ) )
			{
				try
				{
					System.Diagnostics.Process.Start( GlobalVar.CAPTURE_DIR + "\\" + threadNumber + ".png" );
				}
				catch ( Exception ex )
				{
					Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
					NotifyBox.Show( null, "오류", "죄송합니다, 이미지 파일을 여는 도중 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
				}
			}
			else
			{
				Utility.WriteErrorLog( "CaptureImageNotFound", Utility.LogSeverity.ERROR );
				NotifyBox.Show( null, "오류", "죄송합니다, 이 게시물에 대한 캡처된 이미지가 없습니다.", NotifyBoxType.OK, NotifyBoxIcon.Warning );
			}
		}

		// TO DO
		public static void DeleteImage( string threadNumber )
		{

		}
	}
}
