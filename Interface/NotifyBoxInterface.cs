using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CafeMaster_UI.Lib;

namespace CafeMaster_UI.Interface
{
	public partial class NotifyBoxInterface : Form
	{
		private Point startPoint;
		private Pen lineDrawer = new Pen( GlobalVar.MasterColor )
		{
			Width = 1
		};
		public NotifyBoxResult Result;

		public NotifyBoxInterface( string title, string message, NotifyBoxType type, NotifyBoxIcon icon )
		{
			InitializeComponent( );

			TITLE_LABEL.Text = title;
			MESSAGE_LABEL.Text = message;

			this.SetStyle( ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true );
			this.UpdateStyles( );
			this.Opacity = 0;

			switch ( icon )
			{
				case NotifyBoxIcon.Error:
					TYPE_ICON.Image = Properties.Resources.ERROR_ICON;
					System.Media.SystemSounds.Hand.Play( );
					break;
				case NotifyBoxIcon.Information:
					TYPE_ICON.Image = Properties.Resources.INFORMATION_ICON;
					System.Media.SystemSounds.Beep.Play( );
					break;
				case NotifyBoxIcon.Warning:
					TYPE_ICON.Image = Properties.Resources.WARNING_ICON;
					System.Media.SystemSounds.Exclamation.Play( );
					break;
				case NotifyBoxIcon.Question:
					TYPE_ICON.Image = Properties.Resources.QUESTION_ICON;
					System.Media.SystemSounds.Beep.Play( );
					break;
				case NotifyBoxIcon.Danger:
					TYPE_ICON.Image = Properties.Resources.DANGER_ICON;
					System.Media.SystemSounds.Hand.Play( );
					break;
			}

			switch ( type )
			{
				case NotifyBoxType.OK:
					OK_Button.Visible = true;
					Yes_Button.Visible = false;
					NO_Button.Visible = false;

					OK_Button.Focus( );

					this.FormClosing += delegate ( object sender, FormClosingEventArgs e )
					{
						if ( Result != NotifyBoxResult.OK )
						{
							Result = NotifyBoxResult.OK;
						}
					};
					break;
				case NotifyBoxType.YesNo:
					OK_Button.Visible = false;
					Yes_Button.Visible = true;
					NO_Button.Visible = true;

					this.FormClosing += delegate ( object sender, FormClosingEventArgs e )
					{
						if ( Result != NotifyBoxResult.Yes && Result != NotifyBoxResult.No )
						{
							Result = NotifyBoxResult.No;
						}
					};
					break;
			}
		}

		private void Yes_Button_Click( object sender, EventArgs e )
		{
			Result = NotifyBoxResult.Yes;
			this.CloseForm( );
		}

		private void NO_Button_Click( object sender, EventArgs e )
		{
			Result = NotifyBoxResult.No;
			this.CloseForm( );
		}

		private void OK_Button_Click( object sender, EventArgs e )
		{
			Result = NotifyBoxResult.OK;
			this.CloseForm( );
		}

		private void CloseForm( )
		{
			Animation.UI.FadeOut( this, true );
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

			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
		}

		private void NotifyBoxInterface_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // 위
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // 왼쪽
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // 오른쪽
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
		}

		private void NotifyBoxInterface_Load( object sender, EventArgs e )
		{
			Animation.UI.FadeIn( this );

			this.APP_TITLE_BAR.Parent = centerNotifyImageBox;
			this.MESSAGE_LABEL.Parent = centerNotifyImageBox;
			this.TYPE_ICON.Parent = centerNotifyImageBox;
			this.OK_Button.Parent = centerNotifyImageBox;
			this.Yes_Button.Parent = centerNotifyImageBox;
			this.NO_Button.Parent = centerNotifyImageBox;
			this.COPY_TEXT_BUTTON.Parent = centerNotifyImageBox;

			//this.MESSAGE_LABEL.BackColor = Color.FromArgb( 200, 255, 255, 255 );

			if ( Config.Get( "ThemeEnable", "1" ) == "0" ) return;

			if ( Directory.Exists( GlobalVar.LAYOUT_DIR ) )
			{
				try
				{
					string[ ] files = Directory.GetFiles( GlobalVar.LAYOUT_DIR, "notifyBox_*.png" );

					if ( files.Length > 0 )
					{
						this.centerNotifyImageBox.Visible = true;
						this.centerNotifyImageBox.Image = new Bitmap(
								Utility.FileToMemoryStream( files[ new Random( DateTime.Now.Second ).Next( 0, files.Length ) ]
							)
						);
					}
				}
				catch { }
			}
			else
			{
				this.centerNotifyImageBox.Image = null;
			}
		}

		private void COPY_TEXT_BUTTON_Click( object sender, EventArgs e )
		{
			Clipboard.SetText( this.MESSAGE_LABEL.Text );

			this.TOOL_TIP.SetToolTip( this.COPY_TEXT_BUTTON, "텍스트가 클립보드에 복사되었습니다!" );
		}
	}
}
