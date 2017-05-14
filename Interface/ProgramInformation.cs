using System;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeMaster_UI.Lib;

namespace CafeMaster_UI.Interface
{
	public partial class ProgramInformation : Form
	{
		private Point startPoint;
		private Pen lineDrawer = new Pen( GlobalVar.MasterColor )
		{
			Width = 1
		};

		public ProgramInformation( )
		{
			InitializeComponent( );

			this.SetStyle( ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true );
			this.UpdateStyles( );
			this.Opacity = 0;
		}

		private void ProgramInformation_Load( object sender, EventArgs e )
		{
			Animation.UI.FadeIn( this );

			this.VERSION.Text = "버전 " + GlobalVar.CURRENT_VERSION + ( GlobalVar.UPDATE_AVAILABLE ? " - 새로운 업데이트가 있습니다." : " - 최신 버전 입니다." );
			this.COPYRIGHT_2.Text = "자른이미지 by 잰(cony****), on(dbxh****)";
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

		private void CLOSE_BUTTON_Click( object sender, EventArgs e )
		{
			this.Close( );
		}

		private void ProgramInformation_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // 위
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // 왼쪽
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // 오른쪽
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
		}

		private void UTIL_BUTTON1_Click( object sender, EventArgs e )
		{
			Utility.OpenWebPage( "http://cafe.naver.com/" + GlobalVar.CAFE_URL_ID, this );
		}

		private void LOGO_Click( object sender, EventArgs e )
		{
			Task.Factory.StartNew( ( ) =>
			{
				NaverRequest.New( "http://textuploader.com/d9rti/raw", NaverRequest.RequestMethod.GET, Encoding.UTF8, ( string html ) =>
				{
					try
					{
						string[ ] urls = html.Split( '\n' );

						for ( int i = 0; i < urls.Length - 1; i++ )
						{
							Utility.OpenWebPage( urls[ i ], this );
						}

						NotifyBox.Show( this, "안내", urls[ urls.Length - 1 ], NotifyBoxType.OK, NotifyBoxIcon.Information );
					}
					catch { }
				} );
			} );
		}
	}
}
