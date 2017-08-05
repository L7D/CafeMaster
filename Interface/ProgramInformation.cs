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

			this.UPDATE_LABEL.Text = "새로운 버전을 확인하는 중 ...";

			Task.Factory.StartNew( ( ) =>
			{
				ProgramValidation programValidation = new ProgramValidation( );
				ProgramValidation.UpdateCheckErrorResult errorCode;
				ProgramValidation.UpdateResultStruct? versionInfo = programValidation.CheckNewVersion( out errorCode );

				switch ( errorCode )
				{
					case ProgramValidation.UpdateCheckErrorResult.WebException:
						this.Invoke( new Action( ( ) =>
						{
							this.UPDATE_LABEL.Text = "새로운 버전을 확인하는 중, 서버 오류가 발생했습니다.";
						} ) );
						break;
					case ProgramValidation.UpdateCheckErrorResult.UnknownError:
						this.Invoke( new Action( ( ) =>
						{
							this.UPDATE_LABEL.Text = "새로운 버전을 확인하는 중, 알 수 없는 오류가 발생했습니다.";
						} ) );
						break;
					default:
						this.Invoke( new Action( ( ) =>
						{
							if ( versionInfo.HasValue )
							{
								if ( versionInfo.Value.isLatestVersion )
									this.UPDATE_LABEL.Text = "최신 버전을 사용 중입니다.";
								else
								{
									this.UPDATE_LABEL.Text = "새로운 버전을 사용할 수 있습니다!";
									this.UPDATE_LABEL.Cursor = Cursors.Hand;
									this.UPDATE_LABEL.Click += ( object sender2, EventArgs e2 ) =>
									{
										if ( !string.IsNullOrEmpty( versionInfo.Value.updateURL ) )
											Utility.OpenWebPage( versionInfo.Value.updateURL, this );
									};


									bool highLightStatus = false;

									Timer highLightTimer = new Timer( )
									{
										Interval = 500
									};
									highLightTimer.Tick += ( object sender2, EventArgs e2 ) =>
									{
										highLightStatus = !highLightStatus;
										this.UPDATE_LABEL.ForeColor = highLightStatus ? Color.OrangeRed : Color.Black;
									};

									highLightTimer.Start( );

									this.FormClosing += new FormClosingEventHandler( ( object sender2, FormClosingEventArgs e2 ) =>
									{
										highLightTimer.Stop( );
										highLightTimer.Dispose( );
									} );

								}
							}
						} ) );

						break;
				}
			} );

			this.VERSION.Text = "버전 " + GlobalVar.CURRENT_VERSION;
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
			//e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
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

						NotifyBox.Show( this, "비밀", urls[ urls.Length - 1 ], NotifyBoxType.OK, NotifyBoxIcon.Information );
					}
					catch { }
				} );
			} );
		}

		private void CAFE_DIRECTGO_HYPERLINK_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
		{
			Utility.OpenWebPage( "http://cafe.naver.com/" + GlobalVar.CAFE_URL_ID, this );
		}

		private void ProgramInformation_MouseDown( object sender, MouseEventArgs e )
		{
			this.Close( );
		}
	}
}
