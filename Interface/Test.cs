using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeMaster_UI.Lib;

namespace CafeMaster_UI.Interface
{
	public partial class Test : Form
	{
		public Test( )
		{
			InitializeComponent( );

			Utility.SetUriCookieContainerToNaverCookies( "http://cafe.naver.com" );
			this.webBrowser1.Navigate( "https://chat.cafe.naver.com/ChatHome.nhn?cafeId=25430492" );
		}

		private void webBrowser1_DocumentCompleted( object sender, WebBrowserDocumentCompletedEventArgs e )
		{


			//MessageBox.Show( "webBrowser1_DocumentCompleted - " + e.Url );

			
		}

		private void webBrowser1_Navigating( object sender, WebBrowserNavigatingEventArgs e )
		{
			MessageBox.Show( "webBrowser1_Navigating - " + e.TargetFrameName + " / " + e.Url );
		}

		private void webBrowser1_Navigated( object sender, WebBrowserNavigatedEventArgs e )
		{
			
		}

		private void button1_Click( object sender, EventArgs e )
		{
			HtmlElementCollection li = webBrowser1.Document.GetElementsByTagName( "a" );
			string capcha = "<strong class='blind'>멤버</strong>";

			foreach ( HtmlElement i in li )
			{
				// https://www.codeproject.com/Questions/72495/How-to-get-class-attribute-of-an-HTML-element-in-C
				if ( i.GetAttribute( "className" ) == "N=a:top.member _click(ChatHomeGNB|ShowMemberTab) _stopDefault" )
				{
					//MessageBox.Show( "멤버 Found" );
					i.InvokeMember( "click" );
					break;
				}
			}

			HtmlElementCollection input = webBrowser1.Document.GetElementsByTagName( "input" );

			foreach ( HtmlElement i in input )
			{
				// https://www.codeproject.com/Questions/72495/How-to-get-class-attribute-of-an-HTML-element-in-C
				if ( i.GetAttribute( "className" ) == "_click(CafeMemberSearch|RemoveDefaultKeyword)" )
				{
					//MessageBox.Show( "input found" );
					i.SetAttribute( "value", "232" );
					i.InvokeMember( "click" );
					break;
				}
			}
		}
	}
}
