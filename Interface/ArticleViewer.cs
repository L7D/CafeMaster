using CafeMaster_UI.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMaster_UI.Interface
{
	public partial class ArticleViewer : Form
	{
		bool noCookies = true;
		[DllImport( "wininet.dll", CharSet = CharSet.Auto, SetLastError = true )]
		public static extern bool InternetSetCookie( string lpszUrlName, string lbszCookieName, string lpszCookieData );
		string url;

		// http://stackoverflow.com/questions/6470842/how-do-i-display-a-popup-from-a-webbrowser-in-another-window-i-created/6473442#6473442

		public ArticleViewer( )
		{
			InitializeComponent( );
		}

		public ArticleViewer( string url )
		{
			InitializeComponent( );
			this.url = url;
			
		}

		private void ArticleViewer_Load( object sender, EventArgs e )
		{
			//this.WEB_BROWSER.Document.Cookie = GlobalVar.COOKIES;

			//MessageBox.Show( url );
			foreach ( CookieStruct i in GlobalVar.COOKIES_LIST )
			{
				InternetSetCookie( "http://cafe.naver.com", i.id, i.value );
			}

			this.WEB_BROWSER.Navigate( url );


		}


		SHDocVw.WebBrowser nativeBrowser;
		protected override void OnLoad( EventArgs e )
		{
			base.OnLoad( e );
			nativeBrowser = ( SHDocVw.WebBrowser ) WEB_BROWSER.ActiveXInstance;
			nativeBrowser.NewWindow2 += nativeBrowser_NewWindow2;
		}
		protected override void OnFormClosing( FormClosingEventArgs e )
		{
			nativeBrowser.NewWindow2 -= nativeBrowser_NewWindow2;
			base.OnFormClosing( e );
		}

		void nativeBrowser_NewWindow2( ref object ppDisp, ref bool Cancel )
		{
			//var popup = new ArticleViewerSub( );
			//popup.Show( this );
			//ppDisp = popup.BROWSER.ActiveXInstance;
		}

		private void CLOSE_BUTTON_Click( object sender, EventArgs e )
		{
			this.Close( );
		}

		private void WEB_BROWSER_Navigated( object sender, WebBrowserNavigatedEventArgs e )
		{
			if( noCookies )
			{
				
				noCookies = false;
				//this.WEB_BROWSER.Refresh( );
				//this.WEB_BROWSER.Document.Cookie = GlobalVar.COOKIES;
			}
		}

		private void LinkClicked( object sender, EventArgs e )
		{

			HtmlElement link = WEB_BROWSER.Document.ActiveElement;
			url = link.GetAttribute( "href" );
		}

		private void WEB_BROWSER_DocumentCompleted( object sender, WebBrowserDocumentCompletedEventArgs e )
		{
			HtmlElementCollection links = WEB_BROWSER.Document.Links;
			foreach ( HtmlElement var in links )
			{
				var.AttachEventHandler( "onclick", LinkClicked );
			}
		}

		private void WEB_BROWSER_NewWindow( object sender, CancelEventArgs e )
		{
			//e.Cancel = true;
			//WEB_BROWSER.Navigate( url );
			//MessageBox.Show( url);
			
		}

		private void WEB_BROWSER_Navigating( object sender, WebBrowserNavigatingEventArgs e )
		{
			
			//e.Cancel = true;

			//this.WEB_BROWSER.Navigate( e.Url );
		}
	}
}
