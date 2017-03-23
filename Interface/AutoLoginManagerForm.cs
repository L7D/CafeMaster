using System;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;
using CafeMaster_UI.Lib;

namespace CafeMaster_UI.Interface
{
	public partial class AutoLoginManagerForm : Form
	{
		private Point startPoint;
		private Pen lineDrawer = new Pen( GlobalVar.MasterColor )
		{
			Width = 1
		};

		public AutoLoginManagerForm( )
		{
			InitializeComponent( );

			this.SetStyle( ControlStyles.ResizeRedraw, true );
			this.SetStyle( ControlStyles.OptimizedDoubleBuffer, true );
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

		private void AutoLoginManagerForm_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // 위
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // 왼쪽
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // 오른쪽
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
		}

		private void AutoLoginManagerForm_Load( object sender, EventArgs e )
		{
			string accountString = null;
			AutoLogin.GetAccountDataResult result = AutoLogin.GetAccountData( out accountString );

			switch ( result )
			{
				case AutoLogin.GetAccountDataResult.Success:
					if ( !string.IsNullOrEmpty( accountString ) )
					{
						string[ ] dataTable = accountString.Trim( ).Split( '\n' );

						if ( dataTable.Length == 2 )
						{
							this.USERID_VALUE.Text = dataTable[ 0 ];
							this.PWD_VALUE.Text = new string( '*', dataTable[ 1 ].Length * new Random( DateTime.Now.Second ).Next( 2, 4 ) );

							if ( System.IO.File.Exists( GlobalVar.APP_DIR + @"\data\profileImage.jpg" ) )
							{
								try
								{
									this.PROFILE_IMAGE.BackgroundImage = Image.FromFile( GlobalVar.APP_DIR + @"\data\profileImage.jpg" );
								}
								catch ( Exception ) { }
							}
						}
						else
						{
							NotifyBox.Show( this, "오류", "죄송합니다, 자동 로그인 데이터를 불러오지 못했습니다, 데이터 구조 문제가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
							this.Close( );
						}
					}
					else
					{
						NotifyBox.Show( this, "오류", "죄송합니다, 자동 로그인 데이터를 불러오지 못했습니다, 데이터 구조 문제가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
						this.Close( );
					}

					break;
				case AutoLogin.GetAccountDataResult.FileNotFound:
					NotifyBox.Show( this, "오류", "죄송합니다, 자동 로그인 데이터를 불러오지 못했습니다, 파일을 찾을 수 없습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
					this.Close( );
					break;
				case AutoLogin.GetAccountDataResult.DecryptFailed:
					NotifyBox.Show( this, "오류", "죄송합니다, 자동 로그인 데이터를 불러오지 못했습니다, 복호화 오류가 발생했습니다, 설정이 초기화되었습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
					AutoLogin.DeleteAccountData( );
					this.Close( );
					break;
				case AutoLogin.GetAccountDataResult.Unknown:
					NotifyBox.Show( this, "오류", "죄송합니다, 자동 로그인 데이터를 불러오지 못했습니다, 알 수 없는 오류가 발생했습니다, 설정이 초기화되었습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
					AutoLogin.DeleteAccountData( );
					this.Close( );
					break;
				default:
					NotifyBox.Show( this, "오류", "죄송합니다, 자동 로그인 데이터를 불러오지 못했습니다, 알 수 없는 오류가 발생했습니다, 설정이 초기화되었습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
					AutoLogin.DeleteAccountData( );
					this.Close( );
					break;
			}
		}

		private void RESET_AUTOLOGIN_BUTTON_Click( object sender, EventArgs e )
		{
			if ( NotifyBox.Show( this, "경고", "자동 로그인을 다시 설정하시겠습니까?", NotifyBoxType.YesNo, NotifyBoxIcon.Warning ) == NotifyBoxResult.No ) return;
			
			this.Close( );
			AutoLoginSettingForm Form = new AutoLoginSettingForm( );
			Form.ShowDialog( );
		}

		private void DISABLE_AUTOLOGIN_BUTTON_Click( object sender, EventArgs e )
		{
			if ( NotifyBox.Show( this, "경고", "자동 로그인 설정을 해제하면 다음 실행시 부터 자동 로그인이 적용되지 않습니다\n자동 로그인 설정을 해제하시겠습니까?", NotifyBoxType.YesNo, NotifyBoxIcon.Warning ) == NotifyBoxResult.No ) return;

			if ( AutoLogin.DeleteAccountData( ) )
			{
				NotifyBox.Show( this, "자동 로그인 해제", "자동 로그인 설정이 해제되었습니다, 다음 실행시 부터 자동 로그인이 적용되지 않습니다.", NotifyBoxType.OK, NotifyBoxIcon.Information );
				this.Close( );
			}
			else
			{
				NotifyBox.Show( this, "오류", "죄송합니다, 자동 로그인 설정을 해제할 수 없습니다, 알 수 없는 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
				this.Close( );
			}
		}
	}
}
