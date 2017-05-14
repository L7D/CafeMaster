using System;
using System.Drawing;
using System.Windows.Forms;
using CafeMaster_UI.Lib;

namespace CafeMaster_UI.Interface
{
	public partial class AutoLoginSettingForm : Form
	{
		private Point startPoint;
		private Pen lineDrawer = new Pen( GlobalVar.MasterColor )
		{
			Width = 1
		};
		private string IDTemp = "";
		private string PWDTemp = "";

		public AutoLoginSettingForm( )
		{
			InitializeComponent( );

			this.SetStyle( ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true );
			this.UpdateStyles( );
			this.Opacity = 0;
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

		private void AutoLoginSettingForm_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // 위
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // 왼쪽
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // 오른쪽
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
		}

		private void browserBehind_Navigating( object sender, WebBrowserNavigatingEventArgs e )
		{
			try
			{
				System.Collections.Specialized.NameValueCollection query = System.Web.HttpUtility.ParseQueryString( e.Url.Query );

				if ( query.Get( "a" ) == "log.naver" ) // 위에 로고를 클릭함.
				{
					e.Cancel = true;
					this.browserBehind.Navigate( "https://nid.naver.com/nidlogin.login?svctype=64" );
					return;
				}

				if ( e.Url.OriginalString.StartsWith( "http://my.naver.com/" ) )
				{
					this.browserBehind.Visible = false;
					this.TIP_LABEL.Text = "로그인 데이터를 가져오고 있습니다 ...";

					e.Cancel = true;

					if ( Utility.GetUriCookieContainer( e.Url ).GetCookies( e.Url ).Count > 0 )
					{
						AutoLogin.SetAccountDataResult result = AutoLogin.SetAccountData( IDTemp, PWDTemp, IDTemp );

						switch ( result )
						{
							case AutoLogin.SetAccountDataResult.Success:
								NotifyBox.Show( this, "자동 로그인 설정 완료", "자동 로그인 설정을 완료했습니다, 다음 로그인 시 부터 자동 로그인이 적용됩니다.", NotifyBoxType.OK, NotifyBoxIcon.Information );
								this.Close( );
								break;
							case AutoLogin.SetAccountDataResult.FileCreateFailed:
								NotifyBox.Show( this, "오류", "죄송합니다, 자동 로그인 설정을 하지 못했습니다, 파일 접근 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
								this.Close( );
								break;
							case AutoLogin.SetAccountDataResult.EncryptFailed:
								NotifyBox.Show( this, "오류", "죄송합니다, 자동 로그인 설정을 하지 못했습니다, 암호화 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
								this.Close( );
								break;
							case AutoLogin.SetAccountDataResult.Unknown:
								NotifyBox.Show( this, "오류", "죄송합니다, 자동 로그인 설정을 하지 못했습니다, 알 수 없는 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
								this.Close( );
								break;
							default:
								NotifyBox.Show( this, "오류", "죄송합니다, 자동 로그인 설정을 하지 못했습니다, 알 수 없는 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
								this.Close( );
								break;
						}

						return;
					}
					else
					{
						Utility.WriteErrorLog( "CookieIsEmpty_AutoLoginSettingForm", Utility.LogSeverity.ERROR );
						NotifyBox.Show( this, "오류", "죄송합니다, 로그인 데이터를 가져올 수 없었습니다, 다시 시도하세요.", NotifyBoxType.OK, NotifyBoxIcon.Error );
						this.Close( );
					}
				}
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				NotifyBox.Show( this, "오류", "죄송합니다, 로그인 데이터를 가져올 수 없었습니다, 다시 시도하세요.", NotifyBoxType.OK, NotifyBoxIcon.Error );
				this.Close( );
			}
		}

		private void AutoLoginSettingForm_Load( object sender, EventArgs e )
		{
			Animation.UI.FadeIn( this );
		}

		private void browserLoginButtonPressedEvent( object sender, EventArgs e )
		{
			HtmlElementCollection inputs = this.browserBehind.Document.GetElementsByTagName( "input" );

			foreach ( HtmlElement i in inputs )
			{
				if ( i.GetAttribute( "type" ) == "text" && i.GetAttribute( "id" ) == "id" ) // 아이디 폼
				{
					IDTemp = i.GetAttribute( "value" );
				}
				else if ( i.GetAttribute( "type" ) == "password" && i.GetAttribute( "id" ) == "pw" ) // 암호 폼
				{
					PWDTemp = i.GetAttribute( "value" );
				}
			}
		}

		private void browserBehind_DocumentCompleted( object sender, WebBrowserDocumentCompletedEventArgs e )
		{
			if ( !e.Url.ToString( ).StartsWith( "https://nid.naver.com/nidlogin.login" ) ) return;

			HtmlElementCollection inputs = this.browserBehind.Document.GetElementsByTagName( "input" );

			foreach ( HtmlElement i in inputs )
			{
				if ( i.GetAttribute( "type" ) == "submit" && i.GetAttribute( "alt" ) == "로그인" )
				{
					i.AttachEventHandler( "onclick", browserLoginButtonPressedEvent );
					return;
				}
			}

			Utility.WriteErrorLog( "AutoLoginEventAttachFailed", Utility.LogSeverity.ERROR );
			NotifyBox.Show( this, "오류", "죄송합니다, 자동 로그인 설정을 위한 기본 설정을 할 수 없었습니다, 다시 시도하세요.", NotifyBoxType.OK, NotifyBoxIcon.Error );
			this.Close( );
		}
	}
}
