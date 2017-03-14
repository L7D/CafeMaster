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
	public partial class MemberActivityStopForm : Form
	{
		private Point startPoint;
		private Pen lineDrawer = new Pen( GlobalVar.MasterColor )
		{
			Width = 1
		};

		public MemberActivityStopForm( )
		{
			InitializeComponent( );

			this.SetStyle( ControlStyles.ResizeRedraw, true );
			this.SetStyle( ControlStyles.OptimizedDoubleBuffer, true );

			
		}

		private void WEB_BROWSER_DocumentCompleted( object sender, WebBrowserDocumentCompletedEventArgs e )
		{
			//if ( !first ) return;
			//this.Width = this.WEB_BROWSER.Document.Body.ScrollRectangle.Width;
			//this.Height = this.WEB_BROWSER.Document.Body.ScrollRectangle.Height;

			HtmlElementCollection el = WEB_BROWSER.Document.GetElementsByTagName( "a" );

			foreach ( HtmlElement eee in el )
			{
				MessageBox.Show( eee.GetAttribute( "class" ) );
				if ( eee.GetAttribute( "class" ) == "btn_type _click(ManageActivityStopPopupView|Close) _stopDefault" )
				{
					// cafe.naver.com/CafeMemberExistCheck.nhn?clubid=25430492&memberid=skrud0319

					// clubid=25016505&activityStop.executorId=smhjyh2007&memberids=yjy1926179&activityStop.violationCode=2&activityStop.reason=test%21%21%21%21&duration=0
				}
			}

			
			//this.Refresh( );

			//first = false;
		}

		private void ArticleViewerSub_Load( object sender, EventArgs e )
		{
			Utility.SetUriCookieContainerToNaverCookies( "http://cafe.naver.com" );
			this.WEB_BROWSER.Navigate( "http://cafe.naver.com/ManageActivityStopPopupView.nhn?clubid=25430492&memberids=ljh100154" );
			//this.WEB_BROWSER.Document.Window.Unload += new HtmlElementEventHandler( ( sender2, e2 ) =>
			//{
			//	MessageBox.Show( e2.EventType );
			//	//this.Close( );
			//} );
		}

		private void APP_TITLE_BAR_MouseMove( object sender, MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Left )
			{
				this.Location = new Point(
					this.Left - ( startPoint.X - e.X ),
					Math.Max( this.Top - ( startPoint.Y - e.Y ), Screen.FromHandle( this.Handle ).WorkingArea.Top )
				);
			}
		}

		private void APP_TITLE_BAR_MouseDown( object sender, MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Left )
				startPoint = e.Location;
		}

		private void APP_TITLE_BAR_Paint( object sender, PaintEventArgs e )
		{
			int w = this.APP_TITLE_BAR.Width, h = this.APP_TITLE_BAR.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // 위
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // 왼쪽
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // 오른쪽
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
		}

		private void ArticleViewerSub_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // 위
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // 왼쪽
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // 오른쪽
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
		}

		private void CLOSE_BUTTON_Click( object sender, EventArgs e )
		{
			this.Close( );
		}
	}
}
