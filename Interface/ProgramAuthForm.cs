using CafeMaster_UI.Lib;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CafeMaster_UI.Interface
{
	public partial class ProgramAuthForm : Form
	{
		private Point startPoint;
		private Pen lineDrawer = new Pen( GlobalVar.MasterColor )
		{
			Width = 1
		};

		public ProgramAuthForm( )
		{
			InitializeComponent( );
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
			Application.Exit( );
		}

		private void ProgramAuthForm_Load( object sender, EventArgs e )
		{
			Version version = System.Reflection.Assembly.GetExecutingAssembly( ).GetName( ).Version;

			this.VERSION_LABEL.Text = "버전 " + version.Major + "." + version.Minor + "." + version.Build + "." + version.Revision + " - 자른이미지 by 잰(cony****)님, on(dbxh****)님";
		}

		private void ProgramAuthForm_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // 위
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // 왼쪽
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // 오른쪽
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
		}

		private void USER_AUTH_BUTTON_Click( object sender, EventArgs e )
		{
			//this.USER_AUTH_BUTTON.Enabled = false;
			//this.PASSCODE_TEXTBOX.Enabled = false;
			//this.USER_AUTH_BUTTON.ButtonText = "인증 하는 중 ...";

			//System.Threading.Thread request = new System.Threading.Thread( ( ) =>
			//{
			//	CheckForIllegalCrossThreadCalls = false;

			//	bool access = Lib.Gate.Access( this.PASSCODE_TEXTBOX.Text.Trim( ) );

			//	if ( this.InvokeRequired )
			//	{
			//		this.Invoke( new Action( ( ) =>
			//		{
			//			this.USER_AUTH_BUTTON.Enabled = true;
			//			this.PASSCODE_TEXTBOX.Enabled = true;
			//			this.PASSCODE_TEXTBOX.Clear( );
			//			this.USER_AUTH_BUTTON.ButtonText = "사용자 인증 >";
			//		} ) );
			//	}
			//	else
			//	{
			//		this.USER_AUTH_BUTTON.Enabled = true;
			//		this.PASSCODE_TEXTBOX.Enabled = true;
			//		this.PASSCODE_TEXTBOX.Clear( );
			//		this.USER_AUTH_BUTTON.ButtonText = "사용자 인증 >";
			//	}

			//	if ( access )
			//	{
			//		GlobalVar.AUTH = true;
			//		this.Close( );
			//	}
			//	else
			//	{
			//		GlobalVar.AUTH = false;

			//		NotifyBox.Show( this, "인증 오류", "올바르지 않은 사용자 인증 코드 입니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
			//	}
			//} )
			//{
			//	IsBackground = true
			//};
			//request.Start( );
		}

		private void PASSCODE_TEXTBOX_KeyPress( object sender, KeyPressEventArgs e )
		{
			if ( e.KeyChar == ( char ) 13 )
			{
				this.USER_AUTH_BUTTON_Click( null, EventArgs.Empty );
				e.Handled = true;
			}
		}
	}
}
