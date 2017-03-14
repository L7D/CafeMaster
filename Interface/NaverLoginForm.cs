using System;
using System.Drawing;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using CafeMaster_UI.Lib;

namespace CafeMaster_UI.Interface
{
	public partial class NaverLoginForm : Form
	{
		private Point startPoint;
		private Pen lineDrawer = new Pen( GlobalVar.MasterColor )
		{
			Width = 1
		};

		public NaverLoginForm( )
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
			Application.Exit( );
		}

		private void NaverLoginForm_Paint( object sender, PaintEventArgs e )
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

					e.Cancel = true;

					CookieCollection collection = Utility.GetUriCookieContainer( e.Url ).GetCookies( e.Url );

					if ( collection.Count > 0 )
					{
						StringBuilder cookiesString = new StringBuilder( );

						foreach ( Cookie i in collection )
						{
							cookiesString.Append( i.Name + "=" + i.Value + "; " );
						}

						GlobalVar.COOKIES = cookiesString.ToString( ).Substring( 0, cookiesString.Length - 2 );
						GlobalVar.COOKIES_LIST = Utility.CookieParse( GlobalVar.COOKIES );

						bool isValidAccount = NaverRequest.AccountPermissionCheck( );

						if ( isValidAccount )
							this.Close( );
						else
						{
							NotifyBox.Show( this, "오류", "죄송합니다, 해당 계정은 연애혁명 공식 팬카페 '카페혁명 우윳빛깔 232'의 스탭이 아닙니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
							System.Diagnostics.Process.GetCurrentProcess( ).Kill( );
							//Application.Exit( );
						}
					}
					else
					{
						Utility.WriteErrorLog( "CookieIsEmpty", Utility.LogSeverity.ERROR );
						NotifyBox.Show( this, "오류", "죄송합니다, 로그인 데이터를 가져올 수 없었습니다, 다시 시도하세요.", NotifyBoxType.OK, NotifyBoxIcon.Error );
						Application.Exit( );
					}
				}
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				NotifyBox.Show( this, "오류", "죄송합니다, 로그인 데이터를 가져올 수 없었습니다, 다시 시도하세요.", NotifyBoxType.OK, NotifyBoxIcon.Error );
				Application.Exit( );
			}
		}

		private void SetMessage( string text, bool end = false )
		{
			if ( this.InvokeRequired )
			{
				this.Invoke( new Action( ( ) =>
				{
					this.AUTOLOGIN_DESC.Text = text;

					if ( end )
						this.DotAnimationTimer.Stop( );
					else
						this.DotAnimationTimer.Start( );
				} ) );
			}
			else
			{
				this.AUTOLOGIN_DESC.Text = text;

				if ( end )
					this.DotAnimationTimer.Stop( );
				else
					this.DotAnimationTimer.Start( );
			}
		}

		private void SetMode( bool isAutoLogin )
		{
			if ( this.InvokeRequired )
			{
				this.Invoke( new Action( ( ) =>
				{
					if ( isAutoLogin )
					{
						this.browserBehind.Visible = false;
						this.AUTOLOGIN_DESC.Visible = true;
						this.PROFILE_IMAGE.Visible = true;

						if ( System.IO.File.Exists( GlobalVar.APP_DIR + @"\data\profileImage.jpg" ) )
						{
							try
							{
								this.PROFILE_IMAGE.BackgroundImage = new Bitmap( Utility.FileToMemoryStream( GlobalVar.APP_DIR + @"\data\profileImage.jpg" ) );
							}
							catch { }
						}
					}
					else
					{
						this.browserBehind.Visible = true;
						this.AUTOLOGIN_DESC.Visible = false;
						this.PROFILE_IMAGE.Visible = false;
					}
				} ) );
			}
			else
			{
				if ( isAutoLogin )
				{
					this.browserBehind.Visible = false;
					this.AUTOLOGIN_DESC.Visible = true;
					this.PROFILE_IMAGE.Visible = true;

					if ( System.IO.File.Exists( GlobalVar.APP_DIR + @"\data\profileImage.jpg" ) )
					{
						try
						{
							this.PROFILE_IMAGE.BackgroundImage = new Bitmap( Utility.FileToMemoryStream( GlobalVar.APP_DIR + @"\data\profileImage.jpg" ) );
						}
						catch { }
					}
				}
				else
				{
					this.browserBehind.Visible = true;
					this.AUTOLOGIN_DESC.Visible = false;
					this.PROFILE_IMAGE.Visible = false;
				}
			}
		}

		private void NaverLoginForm_Load( object sender, EventArgs e )
		{
			Thread thread = new Thread( ( ) =>
			{
				if ( AutoLogin.IsEnabled( ) )
				{
					SetMode( true );
					SetMessage( "계정 자동 로그인 정보를 불러오는 중 " );

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
									SetMessage( "계정 자동 로그인을 시도하고 있습니다, 조금만 기다려주세요 " );

									Thread.Sleep( 1000 );

									CookieCollection collection;
									NaverRequest.NaverLoginResult result2 = NaverRequest.LoginHttp( dataTable[ 0 ], dataTable[ 1 ], out collection );

									switch ( result2 )
									{
										case NaverRequest.NaverLoginResult.Success:
											StringBuilder sb = new StringBuilder( );

											foreach ( Cookie i in collection )
											{
												sb.Append( i.Name + "=" + i.Value + "; " );
											}

											GlobalVar.COOKIES = sb.ToString( ).Substring( 0, sb.Length - 2 );
											GlobalVar.COOKIES_LIST = Utility.CookieParse( GlobalVar.COOKIES );

											bool isValidAccount = NaverRequest.AccountPermissionCheck( );

											if ( isValidAccount )
											{
												SetMessage( dataTable[ 0 ] + " 계정 자동 로그인을 성공했습니다.", true );

												Thread.Sleep( 1000 );

												if ( this.InvokeRequired )
													this.Invoke( new Action( ( ) => this.Close( ) ) );
												else
													this.Close( );

												break;
											}
											else
											{
												NotifyBox.Show( this, "오류", "죄송합니다, 해당 계정은 연애혁명 공식 팬카페 '카페혁명 우윳빛깔 232'의 스탭이 아닙니다, 자동 로그인 설정이 초기화되었습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
												AutoLogin.DeleteAccountData( );
												System.Diagnostics.Process.GetCurrentProcess( ).Kill( );
												//Application.Exit( );

												return;
											}
										case NaverRequest.NaverLoginResult.IDorPWDError:
											NotifyBox.Show( this, "오류", "죄송합니다, 로그인에 실패했습니다, 아이디 또는 비밀번호가 올바르지 않습니다, 설정이 초기화되었습니다.", NotifyBoxType.OK, NotifyBoxIcon.Warning );
											AutoLogin.DeleteAccountData( );

											SetMode( false );

											break;
										case NaverRequest.NaverLoginResult.SecurityBlocked:
											NotifyBox.Show( this, "오류", "죄송합니다, 로그인에 실패했습니다, 보안 설정을 확인하세요.", NotifyBoxType.OK, NotifyBoxIcon.Warning );

											SetMode( false );

											break;
										case NaverRequest.NaverLoginResult.RequestError:
											NotifyBox.Show( this, "오류", "죄송합니다, 로그인에 실패했습니다, 서버 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );

											SetMode( false );

											break;
									}
								}
								else
								{
									NotifyBox.Show( this, "오류", "죄송합니다, 자동 로그인 데이터를 불러오지 못했습니다, 데이터 구조 문제가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );

									SetMode( false );
								}
							}
							else
							{
								NotifyBox.Show( this, "오류", "죄송합니다, 자동 로그인 데이터를 불러오지 못했습니다, 데이터 구조 문제가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );

								SetMode( false );
							}

							break;
						case AutoLogin.GetAccountDataResult.FileNotFound:
							NotifyBox.Show( this, "오류", "죄송합니다, 자동 로그인 데이터를 불러오지 못했습니다, 파일을 찾을 수 없습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );

							SetMode( false );

							break;
						case AutoLogin.GetAccountDataResult.DecryptFailed:
							NotifyBox.Show( this, "오류", "죄송합니다, 자동 로그인 데이터를 불러오지 못했습니다, 복호화 오류가 발생했습니다, 설정이 초기화되었습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
							AutoLogin.DeleteAccountData( );

							SetMode( false );

							break;
						case AutoLogin.GetAccountDataResult.Unknown:
							NotifyBox.Show( this, "오류", "죄송합니다, 자동 로그인 데이터를 불러오지 못했습니다, 알 수 없는 오류가 발생했습니다, 설정이 초기화되었습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
							AutoLogin.DeleteAccountData( );

							SetMode( false );
							break;
						default:
							NotifyBox.Show( this, "오류", "죄송합니다, 자동 로그인 데이터를 불러오지 못했습니다, 알 수 없는 오류가 발생했습니다, 설정이 초기화되었습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
							AutoLogin.DeleteAccountData( );

							SetMode( false );

							break;
					}
				}
				else
				{
					SetMode( false );
				}
			} )
			{
				IsBackground = true
			};

			thread.Start( );
		}

		byte dotCount = 0;
		private void DotAnimationTimer_Tick( object sender, EventArgs e )
		{
			if ( dotCount > 2 )
			{
				dotCount = 0;
				if ( this.AUTOLOGIN_DESC.Text.Length > 3 )
					this.AUTOLOGIN_DESC.Text = this.AUTOLOGIN_DESC.Text.Substring( 0, this.AUTOLOGIN_DESC.Text.Length - 3 );
			}
			else
			{
				this.AUTOLOGIN_DESC.Text = this.AUTOLOGIN_DESC.Text + ".";
				dotCount++;
			}
		}
	}
}
