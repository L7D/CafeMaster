using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeMaster_UI.Interface;
using CafeMaster_UI.Lib;
using WinFormAnimation;

namespace CafeMaster_UI
{
	public partial class Main : Form
	{
		//맞춤법 검사기 추가하기 -> 해결
		//게시글 -> 게시물로 수정 바람 -> 해결
		//경고 부여시 퍼스나콘 없는 문제 수정 바람 -> 해결

		//게시글 없는 유저 활동정지 처리방법 -> 해결
		//http://cafe.naver.com/ManageActivityStopPopupView.nhn?clubid=25430492&memberids=ljh100154
		public MaskForm maskForm;
		private Point startPoint;
		private Pen lineDrawer = new Pen( GlobalVar.MasterColor )
		{
			Width = 1
		};
		private NetworkStatus CurrentNetworkStatus;
		public enum NetworkStatus
		{
			Syncing,
			Idle,
			Error
		}

		private bool IS_NOTIFY_CHILD_PANEL_SELECTED_MODE_private;
		public bool IS_NOTIFY_CHILD_PANEL_SELECTED_MODE
		{
			get
			{
				return IS_NOTIFY_CHILD_PANEL_SELECTED_MODE_private;
			}
			set
			{
				IS_NOTIFY_CHILD_PANEL_SELECTED_MODE_private = value;

				if ( value )
				{
					this.CHILD_PANEL_UTIL_ALL_SELECT.Visible = true;
					this.CHILD_PANEL_UTIL_DELETE.Visible = true;
					this.CHILD_PANEL_LABEL_SELECTED_COUNT.Visible = true;
				}
				else
				{
					this.CHILD_PANEL_UTIL_ALL_SELECT.Visible = false;
					this.CHILD_PANEL_UTIL_DELETE.Visible = false;
					this.CHILD_PANEL_LABEL_SELECTED_COUNT.Visible = false;
				}
			}
		}
		Bitmap img;

		public Main( )
		{
			InitializeComponent( );

			this.SetStyle( ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.Opaque, true );
			this.UpdateStyles( );

			this.Opacity = 0;

			img = GetHighPerformanceBitmap( Image.FromFile( GlobalVar.APP_DIR + @"\BACKGROUND_01.png" ) );
			this.NOTIFY_PANEL.VerticalScroll.LargeChange = 1;
			//this.NOTIFY_PANEL_OUTER.Size = new Size( NOTIFY_PANEL.Width - 16, 590 );

			//Point pt = new Point( this.NOTIFY_PANEL.AutoScrollPosition.X,
			//			 this.NOTIFY_PANEL.AutoScrollPosition.Y );
			//this.vScrollBar1.Minimum = 0;
			//this.vScrollBar1.Maximum = this.NOTIFY_PANEL.DisplayRectangle.Height;
			//this.vScrollBar1.LargeChange = vScrollBar1.Maximum /
			//			 vScrollBar1.Height + this.NOTIFY_PANEL.Height;
			//this.vScrollBar1.SmallChange = 15;
			//this.vScrollBar1.Value = Math.Abs( this.NOTIFY_PANEL.AutoScrollPosition.Y );
		}

		public void SetNetworkStatus( NetworkStatus status )
		{
			if ( this.InvokeRequired )
			{
				this.Invoke( new Action( ( ) =>
				{
					this.CurrentNetworkStatus = status;

					switch ( status )
					{
						case NetworkStatus.Idle:
							this.NETWORK_SYNC_ANIMATION_TIMER.Stop( );
							this.NETWORK_STATUS_ICON.Image = Properties.Resources.NETWORK_IDLE;
							this.TOOL_TIP.SetToolTip( this.NETWORK_STATUS_ICON, "온라인" );
							break;
						case NetworkStatus.Error:
							this.NETWORK_SYNC_ANIMATION_TIMER.Stop( );
							this.NETWORK_STATUS_ICON.Image = Properties.Resources.NETWORK_ISERROR;
							this.TOOL_TIP.SetToolTip( this.NETWORK_STATUS_ICON, "통신 오류가 발생하였습니다." );
							break;
						case NetworkStatus.Syncing:
							this.NETWORK_SYNC_ANIMATION_TIMER.Start( );
							this.TOOL_TIP.SetToolTip( this.NETWORK_STATUS_ICON, "서버와 정보를 교환하고 있습니다 ..." );
							break;
					}
				} ) );
			}
			else
			{
				this.CurrentNetworkStatus = status;

				switch ( status )
				{
					case NetworkStatus.Idle:
						this.NETWORK_SYNC_ANIMATION_TIMER.Stop( );
						this.NETWORK_STATUS_ICON.Image = Properties.Resources.NETWORK_IDLE;
						this.TOOL_TIP.SetToolTip( this.NETWORK_STATUS_ICON, "온라인" );
						break;
					case NetworkStatus.Error:
						this.NETWORK_SYNC_ANIMATION_TIMER.Stop( );
						this.NETWORK_STATUS_ICON.Image = Properties.Resources.NETWORK_ISERROR;
						this.TOOL_TIP.SetToolTip( this.NETWORK_STATUS_ICON, " 오류가 발생하였습니다." );
						break;
					case NetworkStatus.Syncing:
						this.NETWORK_SYNC_ANIMATION_TIMER.Start( );
						this.TOOL_TIP.SetToolTip( this.NETWORK_STATUS_ICON, "서버와 정보를 교환하고 있습니다 ..." );
						break;
				}
			}
		}

		private readonly object locker = new object( );
		public void RefreshNotifyPanel( )
		{
			lock ( locker )
			{
				//int scrollPosTemp = this.NOTIFY_PANEL_VScrollBar.Value;
				int scrollPosTemp = this.NOTIFY_PANEL.VerticalScroll.Value;
				int y = 10;

				this.NOTIFY_PANEL.Enabled = false;
				this.NOTIFY_PANEL.Controls.Clear( );

				foreach ( NotifyData data in Notify.GetAll( ) )
				{
					NotifyChildPanel panel = new NotifyChildPanel( data );
					panel.Location = new Point( 5, y );
					panel.NotifyChildPanelSelectedChanged += new NotifyChildPanel.NotifyChildPanelSelectedEvent( NotifyChildSelectedChanged );

					y += panel.Height + 10;

					this.NOTIFY_PANEL.Controls.Add( panel );
					Application.DoEvents( );
				}

				if ( scrollPosTemp > 0 )
					this.NOTIFY_PANEL.ScrollDown( scrollPosTemp );

				this.NOTIFY_PANEL.Enabled = true;
			}
		}

		public void StartWorker( string message, bool useRed )
		{
			if ( this.InvokeRequired )
			{
				this.Invoke( new Action( ( ) =>
				{
					if ( CurrentNetworkStatus != NetworkStatus.Syncing )
						SetNetworkStatus( NetworkStatus.Syncing );

					if ( !this.CURRENT_PROGRESS_LABEL.Visible )
						this.CURRENT_PROGRESS_LABEL.Visible = true;

					this.CURRENT_PROGRESS_LABEL.Text = message;

					if ( useRed )
						this.CURRENT_PROGRESS_LABEL.ForeColor = Color.Red;
					else
						this.CURRENT_PROGRESS_LABEL.ForeColor = Color.Black;
				} ) );
			}
			else
			{
				if ( CurrentNetworkStatus != NetworkStatus.Syncing )
					SetNetworkStatus( NetworkStatus.Syncing );

				if ( !this.CURRENT_PROGRESS_LABEL.Visible )
					this.CURRENT_PROGRESS_LABEL.Visible = true;

				this.CURRENT_PROGRESS_LABEL.Text = message;

				if ( useRed )
					this.CURRENT_PROGRESS_LABEL.ForeColor = Color.Red;
				else
					this.CURRENT_PROGRESS_LABEL.ForeColor = Color.Black;
			}
		}

		public void EndWorker( )
		{
			if ( this.InvokeRequired )
			{
				this.Invoke( new Action( ( ) =>
				{
					SetNetworkStatus( NetworkStatus.Idle );
					this.CURRENT_PROGRESS_LABEL.Visible = false;
					this.CURRENT_PROGRESS_LABEL.Text = "";
				} ) );
			}
			else
			{
				SetNetworkStatus( NetworkStatus.Idle );
				this.CURRENT_PROGRESS_LABEL.Visible = false;
				this.CURRENT_PROGRESS_LABEL.Text = "";
			}
		}

		private void NotifyChildSelectedChanged( NotifyChildPanel control )
		{
			int allCount = 0;
			int selectedCount = 0;

			if ( this.NOTIFY_PANEL.Controls.Count > 0 )
			{
				foreach ( Control i in this.NOTIFY_PANEL.Controls )
				{
					if ( i.Name != "NotifyChildPanel" ) continue;

					allCount++;

					if ( ( ( NotifyChildPanel ) i ).CHECKED )
					{
						selectedCount++;
					}
				}

				this.CHILD_PANEL_LABEL_SELECTED_COUNT.Text = "전체 " + allCount + "개 중 " + selectedCount + "개 선택함";
			}

			if ( selectedCount <= 0 )
				this.IS_NOTIFY_CHILD_PANEL_SELECTED_MODE = false;
		}


		private void Main_Shown( object sender, EventArgs e )
		{
			Animation.UI.FadeIn( this, ( ) =>
			{
				this.Refresh( );

				SetNetworkStatus( NetworkStatus.Syncing );

				InitializeUI( );

				Task.Factory.StartNew( ( ) =>
				{
					TopProgressMessage.Set( "프로그램 무결성을 확인하고 있습니다 ..." );

					//if ( !Utility.ProgramValidCheck( ) )
					//{
					//	GlobalVar.CRCCheckFailed = true;
					//	TopProgressMessage.End( );
					//	SetNetworkStatus( NetworkStatus.Error );

					//	if ( this.InvokeRequired )
					//	{
					//		this.Invoke( new Action( ( ) =>
					//		{
					//			this.STEP_CHATBOX.Visible = false;
					//		} ) );
					//	}
					//	else
					//		this.STEP_CHATBOX.Visible = false;

					//	NotifyBox.Show( this, "오류", "죄송합니다, 프로그램이 변조되었습니다.\n\n보안상의 문제로 변조된 프로그램은 사용할 수 없습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
					//	Application.Exit( );

					//	return;
					//}

					TopProgressMessage.Set( "프로그램 버전을 확인하고 있습니다 ..." );

					ProgramValidation programValidation = new ProgramValidation( );
					ProgramValidation.UpdateCheckErrorResult errorCode;
					ProgramValidation.UpdateResultStruct? versionInfo = programValidation.CheckNewVersion( out errorCode );

					switch ( errorCode )
					{
						case ProgramValidation.UpdateCheckErrorResult.WebException:
							GlobalVar.UPDATE_AVAILABLE = false;
							break;
						case ProgramValidation.UpdateCheckErrorResult.UnknownError:
							GlobalVar.UPDATE_AVAILABLE = false;
							break;
						default:
							if ( versionInfo.HasValue )
							{
								GlobalVar.VERSION_INFO = versionInfo.Value;

								if ( versionInfo.Value.isLatestVersion )
									GlobalVar.UPDATE_AVAILABLE = false;
								else
								{
									GlobalVar.UPDATE_AVAILABLE = true;
									UpdateAvailable( versionInfo.Value );
								}
							}

							break;
					}

					TopProgressMessage.Set( "네이버 계정 토큰을 불러오고 있습니다 ..." );

					if ( NaverAccountInitialize( ) && !string.IsNullOrEmpty( GlobalVar.COOKIES ) && GlobalVar.COOKIES_LIST.Count != 0 )
					{
						TopProgressMessage.Set( "데이터를 불러오고 있습니다 ..." );

						ThreadDataStore.Initialize( );

						Task.Delay( 2000 );

						TopProgressMessage.End( );

						Observer.Start( );

						if ( this.InvokeRequired )
						{
							this.Invoke( new Action( ( ) =>
							{
								CheckNotifyListIsBlank( );
							} ) );
						}
						else
							CheckNotifyListIsBlank( );
					}
					else
					{
						TopProgressMessage.End( );
						SetNetworkStatus( NetworkStatus.Error );

						NotifyBox.Show( this, "오류", "죄송합니다, 네이버 계정 인증을 하는 중 오류가 발생했습니다.\n\n프로그램을 다시 시작하십시오.", NotifyBoxType.OK, NotifyBoxIcon.Error );
						Application.Exit( );
					}
				} );
			} );

		}

		private void CheckNotifyListIsBlank( )
		{
			if ( this.NOTIFY_PANEL.Controls.Count == 0 )
			{
				this.NOTIFYBOX_EMPTY_ICON.Visible = true;
				this.NOTIFYBOX_EMPTY_TITLE.Visible = true;
				this.NOTIFYBOX_EMPTY_DESC.Visible = true;
			}
		}

		private void Main_Load( object sender, EventArgs e )
		{
			//new Welcome( ).ShowDialog( );

			new NaverLoginForm( ).ShowDialog( );

			Analysis.Run( "110257" );

			//this.NOTIFY_PANEL_OUTER.Parent = this.pictureBox2;

			//if ( this.Disposing || this.IsDisposed ) return;
		}

		private void UpdateAvailable( ProgramValidation.UpdateResultStruct versionInfo )
		{
			if ( this.InvokeRequired )
			{
				this.Invoke( new Action( ( ) =>
				{
					this.UPDATE_AVAILABLE.Visible = true;
					this.APP_NOTIFY_ICON.ShowBalloonTip( 30000, "우윳빛깔 카페스탭", "새로운 프로그램 업데이트가 있습니다, 지금 업데이트 하는 것을 권장합니다.", ToolTipIcon.None );
					this.CURRENT_PROGRESS_LABEL.Location = new Point( 553, 13 );
					this.UPDATE_ICON_HIGHLIGHT_TIMER.Start( );

					UpdateNotifyForm form = new UpdateNotifyForm( versionInfo );
					form.Show( this );
				} ) );
			}
			else
			{
				this.UPDATE_AVAILABLE.Visible = true;
				this.APP_NOTIFY_ICON.ShowBalloonTip( 30000, "우윳빛깔 카페스탭", "새로운 프로그램 업데이트가 있습니다, 지금 업데이트 하는 것을 권장합니다.", ToolTipIcon.None );
				this.CURRENT_PROGRESS_LABEL.Location = new Point( 553, 13 );
				this.UPDATE_ICON_HIGHLIGHT_TIMER.Start( );

				UpdateNotifyForm form = new UpdateNotifyForm( versionInfo );
				form.Show( this );
			}
		}

		private void InitializeUI( )
		{
			IS_NOTIFY_CHILD_PANEL_SELECTED_MODE = false;

			if ( !string.IsNullOrEmpty( GlobalVar.COOKIES ) && GlobalVar.COOKIES_LIST.Count != 0 && !GlobalVar.CRCCheckFailed )
			{
				this.STEP_CHATBOX.Visible = false;

				Utility.SetUriCookieContainerToNaverCookies( "http://cafe.naver.com" );

				this.STEP_CHATBOX.ProgressChanged += ( e, d ) =>
				{
					if ( d.CurrentProgress != d.MaximumProgress ) return;

					HtmlElement notifyElement = this.STEP_CHATBOX.Document.GetElementById( "notiMsgContainer" );

					// "홍보성 스팸 메시지를 보시면 멤버 프로필을 선택해서 신고해주세요." top 알림 메세지 지우기
					if ( notifyElement != null )
						notifyElement.OuterHtml = "";

					if ( File.Exists( GlobalVar.CUSTOM_STYLESHEET_DIR ) )
					{
						// 기존 카페채팅 text형식 스타일시트를 무효화 한 후 커스텀 스타일시트로 변경
						foreach ( HtmlElement i in this.STEP_CHATBOX.Document.GetElementsByTagName( "style" ) )
						{
							if ( i.GetAttribute( "type" ) == "text/css" )
							{
								try
								{
									i.InnerHtml = File.ReadAllText( GlobalVar.CUSTOM_STYLESHEET_DIR, System.Text.Encoding.Default );

									break;
								}
								catch { }
							}
						}

						// <link rel="stylesheet" href="/static/css/chat_broker/cafe_chat-1468839309000-70734.css" type="text/css">
						// 기존 카페채팅 link형식 스타일시트 무효화
						foreach ( HtmlElement i in this.STEP_CHATBOX.Document.GetElementsByTagName( "link" ) )
						{
							if ( i.GetAttribute( "rel" ) == "stylesheet" && i.GetAttribute( "type" ) == "text/css" )
							{
								i.SetAttribute( "href", "" );

								break;
							}
						}
					}

					if ( !GlobalVar.CRCCheckFailed )
						this.STEP_CHATBOX.Visible = true;
				};

				this.STEP_CHATBOX.Navigate( new Uri( GlobalVar.CAFE_CHAT_URL ) );
			}
			else
			{
				this.STEP_CHATBOX.DocumentText = "0";
				this.STEP_CHATBOX.Document.OpenNew( true );
				this.STEP_CHATBOX.Document.Write( @"<html>
					<head>
						<style>
							html, body {
								margin: 0;
								width: 100%;
								height: 100%;
								border: 1px solid #bcbcbc;
							}
						</style>
					</head>
					<body>
					</body>
				</html>" );
				this.STEP_CHATBOX.Refresh( );
			}

			if ( Config.Get( "SoundEnable", "1" ) == "1" )
			{
				this.BELL_STATUS_BUTTON.Image = Properties.Resources.BELL_NORMAL;
				SoundNotify.PlayWelcome( );
			}
			else
				this.BELL_STATUS_BUTTON.Image = Properties.Resources.BELL_IGNORE;
		}

		private bool NaverAccountInitialize( )
		{
			NaverAccountInformation? accountInformation = NaverRequest.AccountRequest( );
			Action<NaverAccountInformation> callBack = ( NaverAccountInformation info ) =>
			{
				GlobalVar.NAVER_USER_ID = info.email;
				AutoLogin.ModifyAccountDataNickName( info.nickName );

				if ( info.iconURL != "N" ) // 프로필 이미지가 설정되지 않으면 이미지 URL 이 N임
				{
					try
					{
						if ( !Directory.Exists( GlobalVar.DATA_DIR ) )
							Directory.CreateDirectory( GlobalVar.DATA_DIR );

						MemoryStream profileImageX80 = Utility.URLFileToMemoryStream( info.iconURL.Replace( "?type=s160", "?type=s80" ) );
						//MemoryStream profileImageX2 = Utility.URLFileToMemoryStream( info.iconURL );

						if ( profileImageX80 != null )
						{
							this.NAVER_ICON_IMAGE.BackgroundImage = new Bitmap( profileImageX80 );
						}
						else
						{
							Utility.WriteErrorLog( "NaverProfileImageX80LoadFailed", Utility.LogSeverity.ERROR );
							NotifyBox.Show( this, "오류", "죄송합니다, 계정 프로필을 불러오는 중 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
						}

						byte[ ] profileImageX160 = Utility.URLFileToByteArray( info.iconURL );

						if ( profileImageX160.Length > 0 )
						{
							File.WriteAllBytes( GlobalVar.PROFILE_TEMP_DIR, profileImageX160 );
						}
						else
						{
							Utility.WriteErrorLog( "NaverProfileImageX160LoadFailed", Utility.LogSeverity.ERROR );
							NotifyBox.Show( this, "오류", "죄송합니다, 계정 프로필을 불러오는 중 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
						}
					}
					catch ( Exception ex )
					{
						Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
						NotifyBox.Show( this, "오류", "죄송합니다, 계정 프로필을 불러오는 중 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
					}
				}
			};

			if ( accountInformation.HasValue )
			{
				if ( this.InvokeRequired )
					this.Invoke( new Action( ( ) => callBack( accountInformation.Value ) ) );
				else
					callBack( accountInformation.Value );

				return true;
			}

			return false;
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
			if ( NotifyBox.Show( this, "우윳빛깔 카페스탭", "우윳빛깔 카페스탭을 종료하시겠습니까?", NotifyBoxType.YesNo, NotifyBoxIcon.Question ) == NotifyBoxResult.Yes )
			{
				Animation.UI.FadeOut( this, true );
			}
		}

		
		private void Main_Paint( object sender, PaintEventArgs e )
		{
		
		}

		private void HIDE_BUTTON_Click( object sender, EventArgs e )
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void BELL_STATUS_BUTTON_Click( object sender, EventArgs e )
		{
			Config.Set( "SoundEnable", Config.Get( "SoundEnable", "1" ) == "1" ? "0" : "1" );

			this.BELL_STATUS_BUTTON.Image = Config.Get( "SoundEnable", "1" ) == "1" ? Properties.Resources.BELL_NORMAL : Properties.Resources.BELL_IGNORE;
		}

		//string[ ] ignoreLockControls =
		//{
		//	"APP_TITLE",
		//	"APP_TITLE_BAR",
		//	"APP_ICON",
		//	"CLOSE_BUTTON",
		//	"HIDE_BUTTON",
		//	"BELL_STATUS_BUTTON",
		//	"PROGRAM_LOCK_BUTTON",
		//	"BACKGROUND_SPLASH",
		//	"UPDATE_AVAILABLE",
		//	"OPTION_BUTTON",
		//	"CHILD_PANEL_UTIL_ALL_SELECT",
		//	"CHILD_PANEL_UTIL_DELETE",
		//	"INFO_BUTTON"
		//};

		//private void PROGRAM_LOCK_BUTTON_Click( object sender, EventArgs e )
		//{
		//	GlobalVar.PROGRAM_LOCKED = !GlobalVar.PROGRAM_LOCKED;

		//	if ( GlobalVar.PROGRAM_LOCKED )
		//	{
		//		this.PROGRAM_LOCK_BUTTON.Image = Properties.Resources.locked;
		//		GlobalVar.AUTH = false;

		//		foreach ( Control i in this.Controls )
		//		{
		//			bool found = false;

		//			for ( int i2 = 0; i2 < ignoreLockControls.Length; i2++ )
		//			{
		//				if ( ignoreLockControls[ i2 ] == i.Name )
		//				{
		//					found = true;
		//					break;
		//				}
		//			}

		//			if ( !found )
		//			{
		//				i.Visible = false;
		//			}
		//		}

		//		this.PROGRAM_LOCK_TITLE_LABEL.Visible = true;
		//		this.PROGRAM_LOCK_DESC_LABEL.Visible = true;
		//		this.PROGRAM_LOCK_ICON.Visible = true;
		//	}
		//	else
		//	{
		//		this.PROGRAM_LOCK_BUTTON.Image = Properties.Resources.unlocked;

		//		if ( !GlobalVar.AUTH )
		//		{
		//			new ProgramAuthForm( ).ShowDialog( );

		//			if ( !GlobalVar.AUTH )
		//			{
		//				this.Close( );
		//			}
		//			else
		//			{
		//				foreach ( Control i in this.Controls )
		//				{
		//					bool found = false;

		//					for ( int i2 = 0; i2 < ignoreLockControls.Length; i2++ )
		//					{
		//						if ( ignoreLockControls[ i2 ] == i.Name )
		//						{
		//							found = true;
		//							break;
		//						}
		//					}

		//					if ( !found )
		//					{
		//						i.Visible = true;
		//					}
		//				}
		//			}

		//			this.PROGRAM_LOCK_TITLE_LABEL.Visible = false;
		//			this.PROGRAM_LOCK_DESC_LABEL.Visible = false;
		//			this.PROGRAM_LOCK_ICON.Visible = false;
		//		}
		//	}
		//}

		public static void NumberSmoothEffect( int start, int end, Action<float> Callback, Action<float> AnimationEnd = null )
		{
			float val = start;

			System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer( )
			{
				Interval = 10
			};
			animationTimer.Tick += ( object sender, EventArgs e ) =>
			{
				if ( Math.Round( val ) == end )
				{
					animationTimer.Stop( );
					AnimationEnd?.Invoke( end );
					return;
				}

				val = Utility.Lerp( val, end, 0.8F );
				Callback.Invoke( val );
			};

			animationTimer.Start( );
		}

		private void NOTIFY_PANEL_Scroll( object sender, ScrollEventArgs e )
		{
			//this.NOTIFY_PANEL.Invalidate( );
			this.NOTIFY_PANEL.Update( );
			this.NOTIFY_PANEL.Invalidate( );
			
			//this.NOTIFY_PANEL_VScrollBar.Value = Math.Abs( this.NOTIFY_PANEL.AutoScrollPosition.Y );
		}

		//TextureBrush myBrush = new TextureBrush(Image.FromFile( ") );
		

		public Bitmap GetHighPerformanceBitmap( Image original )
		{
			Bitmap bitmap;

			bitmap = new Bitmap( original.Width, original.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb );
			bitmap.SetResolution( original.HorizontalResolution, original.VerticalResolution );

			using ( Graphics g = Graphics.FromImage( bitmap ) )
			{
				g.DrawImage( original, new Rectangle( new Point( 0, 0 ), bitmap.Size ), new Rectangle( new Point( 0, 0 ), bitmap.Size ), GraphicsUnit.Pixel );
			}

			return bitmap;
		}

		protected override void OnPaint( PaintEventArgs e )
		{
			base.OnPaint( e );

			int w = this.Width, h = this.Height;

			e.Graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
			e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

			//e.Graphics.FillRectangle( myBrush, this.ClientRectangle );
			e.Graphics.DrawImage( img, this.ClientRectangle );
			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // 위
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // 왼쪽
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // 오른쪽
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
		}

		private void NOTIFY_PANEL_MouseWheel( object sender, MouseEventArgs e )
		{
			//this.NOTIFY_PANEL.Invalidate( );
			this.NOTIFY_PANEL.Update( );
			this.NOTIFY_PANEL.Invalidate( );
			//this.NOTIFY_PANEL_VScrollBar.Value = Math.Abs( this.NOTIFY_PANEL.AutoScrollPosition.Y );
		}

		private void FORCE_REFRESH_BUTTON_Click( object sender, EventArgs e )
		{
			if ( this.FORCE_SYNC_DELAY_TIMER.Enabled )
			{
				NotifyBox.Show( this, "오류", "너무 자주 동기화를 시도했습니다, 잠시 후 다시 시도하세요.", NotifyBoxType.OK, NotifyBoxIcon.Warning );
				return;
			}

			if ( NotifyBox.Show( this, "지금 동기화", "지금 데이터를 동기화하시겠습니까?", NotifyBoxType.YesNo, NotifyBoxIcon.Question ) == NotifyBoxResult.Yes )
			{
				Observer.ForceRefresh( );

				this.FORCE_SYNC_DELAY_TIMER.Start( );
			}
		}

		private void UPDATE_AVAILABLE_Click( object sender, EventArgs e )
		{
			UpdateNotifyForm form = new UpdateNotifyForm( GlobalVar.VERSION_INFO );
			form.Show( this );
		}

		private void OPTION_BUTTON_Click( object sender, EventArgs e )
		{
			( new OptionForm( ) ).ShowDialog( );
		}

		private void NOTIFY_PANEL_ControlRemoved( object sender, ControlEventArgs e )
		{
			if ( this.NOTIFY_PANEL.Controls.Count == 0 ) // 컨트롤이 전부 삭제되었을 때?
			{
				// 알림이 없음을 알려주는 UI Visible 속성 변경
				this.NOTIFYBOX_EMPTY_ICON.Visible = true;
				this.NOTIFYBOX_EMPTY_TITLE.Visible = true;
				this.NOTIFYBOX_EMPTY_DESC.Visible = true;

				this.IS_NOTIFY_CHILD_PANEL_SELECTED_MODE = false; // 선택 모드 해제
			}

			//this.NOTIFY_PANEL_VScrollBar.Minimum = this.NOTIFY_PANEL.VerticalScroll.Minimum;
			//this.NOTIFY_PANEL_VScrollBar.Maximum = this.NOTIFY_PANEL.VerticalScroll.Maximum;
			//this.NOTIFY_PANEL_VScrollBar.LargeChange = this.NOTIFY_PANEL.VerticalScroll.LargeChange;
			//this.NOTIFY_PANEL_VScrollBar.SmallChange = 15;
			//this.NOTIFY_PANEL_VScrollBar.Value = Math.Abs( this.NOTIFY_PANEL.AutoScrollPosition.Y );
		}

		private void NOTIFY_PANEL_ControlAdded( object sender, ControlEventArgs e )
		{
			// 알림이 추가되었을 때 알림이 없음을 알려주는 UI Visible 속성 변경
			if ( this.NOTIFYBOX_EMPTY_ICON.Visible || this.NOTIFYBOX_EMPTY_TITLE.Visible || this.NOTIFYBOX_EMPTY_DESC.Visible )
			{
				this.NOTIFYBOX_EMPTY_ICON.Visible = false;
				this.NOTIFYBOX_EMPTY_TITLE.Visible = false;
				this.NOTIFYBOX_EMPTY_DESC.Visible = false;
			}

			//this.NOTIFY_PANEL_VScrollBar.Minimum = this.NOTIFY_PANEL.VerticalScroll.Minimum;
			//this.NOTIFY_PANEL_VScrollBar.Maximum = this.NOTIFY_PANEL.VerticalScroll.Maximum;
			//this.NOTIFY_PANEL_VScrollBar.LargeChange = this.NOTIFY_PANEL.VerticalScroll.LargeChange;
			//this.NOTIFY_PANEL_VScrollBar.SmallChange = 15;
			//this.NOTIFY_PANEL_VScrollBar.Value = Math.Abs( this.NOTIFY_PANEL.AutoScrollPosition.Y );
		}

		private void INFO_BUTTON_Click( object sender, EventArgs e )
		{
			( new ProgramInformation( ) ).ShowDialog( );
		}

		private void FORCE_SYNC_DELAY_TIMER_Tick( object sender, EventArgs e )
		{
			this.FORCE_SYNC_DELAY_TIMER.Stop( );
		}

		private void Main_FormClosing( object sender, FormClosingEventArgs e )
		{
			if ( GlobalVar.NoCloseSave ) return;


			//Notify.Save( ); // 데이터 저장시 오류 발생;
			Config.Save( );
		}

		private void APP_NOTIFY_ICON_MENU_ITEM_1_Click( object sender, EventArgs e )
		{
			this.Close( );
		}

		//private void UTIL_ICON_BUTTON1_Click( object sender, EventArgs e )
		//{
		//	Utility.OpenWebPage( GlobalVar.CAFE_RULE_URL, this );
		//}

		//private void UTIL_ICON_BUTTON2_Click( object sender, EventArgs e )
		//{
		//	Utility.OpenWebPage( GlobalVar.CAFE_MANAGE_HOME_URL, this );
		//}

		//private void UTIL_ICON_BUTTON4_Click( object sender, EventArgs e )
		//{
		//	Utility.OpenWebPage( GlobalVar.CAFE_MANAGE_JOINMANAGE_URL, this );
		//}

		//private void UTIL_ICON_BUTTON5_Click( object sender, EventArgs e )
		//{
		//	Utility.OpenWebPage( GlobalVar.NAVER_SPELL_CHECKER_URL, this );
		//}

		//private void UTIL_ICON_BUTTON6_Click( object sender, EventArgs e )
		//{
		//	( new CafeRankViewer( ) ).ShowDialog( );
		//}

		//private void UTIL_ICON_BUTTON7_Click( object sender, EventArgs e )
		//{
		//	( new MemberWarningForm( ) ).ShowDialog( );
		//}

		//private void UTIL_ICON_BUTTON8_Click( object sender, EventArgs e )
		//{
		//	( new MemberActivityStopListForm( ) ).ShowDialog( );
		//}

		public void MaskShow( )
		{
			if ( maskForm != null && !maskForm.IsDisposed && !maskForm.Disposing )
				return;

			MaskForm mask = new MaskForm( );
			mask.Owner = this;
			mask.Size = new Size( this.Width, this.Height );
			mask.Location = this.Location;
			this.FormClosing += ( object sender2, FormClosingEventArgs e2 ) =>
			{
				if ( mask != null && !mask.IsDisposed && !mask.Disposing )
					mask.Close( );
			};
			this.LocationChanged += ( object sender2, EventArgs e2 ) =>
			{
				mask.Location = this.Location;
			};
			mask.Show( );
			mask.Refresh( );

			this.maskForm = mask;
		}

		public void MaskClose( )
		{
			if ( maskForm != null && !maskForm.IsDisposed && !maskForm.Disposing )
				maskForm.Close( );
		}

		private void CHILD_PANEL_UTIL_DELETE_Click( object sender, EventArgs e )
		{
			if ( NotifyBox.Show( this, "삭제 확인", "선택한 새 게시물 알림을 모두 삭제하시겠습니까?", NotifyBoxType.YesNo, NotifyBoxIcon.Warning ) != NotifyBoxResult.Yes ) return;

			this.CHILD_PANEL_UTIL_ALL_SELECT_privClicked = false;

			int count = 0;
			foreach ( Control i in this.NOTIFY_PANEL.Controls )
			{
				if ( i.Name != "NotifyChildPanel" ) continue;
				if ( !( ( NotifyChildPanel ) i ).CHECKED ) continue; // 선택되지 않은 알림은 삭제하지 않음

				Notify.Remove( ( ( NotifyChildPanel ) i ).THREAD_ID, true, true ); // noRefresh, noSave 모드로 알림 삭제
				count++;
				Application.DoEvents( );
			}

			// 마스크 기능 시험 사용

			Notify.Save( );
			RefreshNotifyPanel( );

			NotifyBox.Show( this, "삭제 완료", "선택한 " + count + " 개의 새 게시물 알림을 삭제했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Information );
		}

		private bool CHILD_PANEL_UTIL_ALL_SELECT_privClicked; // 이미 전체선택 버튼을 클릭한 경우를 기억하기 위함
		private void CHILD_PANEL_UTIL_ALL_SELECT_Click( object sender, EventArgs e )
		{
			if ( !this.IS_NOTIFY_CHILD_PANEL_SELECTED_MODE ) return; // 선택 모드가 아닐 때 리턴

			this.CHILD_PANEL_UTIL_ALL_SELECT_privClicked = !this.CHILD_PANEL_UTIL_ALL_SELECT_privClicked; // 반전

			foreach ( Control i in this.NOTIFY_PANEL.Controls )
			{
				if ( i.Name != "NotifyChildPanel" ) continue;

				( ( NotifyChildPanel ) i ).ExternalSelectChange( this.CHILD_PANEL_UTIL_ALL_SELECT_privClicked ); // 알림 선택 취소 또는 선택
			}

			//if ( this.CHILD_PANEL_UTIL_ALL_SELECT_privClicked ) // 이미 전체선택 버튼을 클릭한 경우
			//{

			//}
			//else
			//{
			//	this.CHILD_PANEL_UTIL_ALL_SELECT_privClicked = true;

			//	foreach ( Control i in this.NOTIFY_PANEL.Controls )
			//	{
			//		if ( i.Name != "NotifyChildPanel" ) continue;

			//		( ( NotifyChildPanel ) i ).ExternalSelectChange( true ); // 선택
			//	}
			//}
		}

		private byte syncAnimationWIFISignalCount = 0;
		private void NETWORK_SYNC_ANIMATION_TIMER_Tick( object sender, EventArgs e )
		{
			if ( syncAnimationWIFISignalCount++ >= 2 )
				syncAnimationWIFISignalCount = 0;

			this.NETWORK_STATUS_ICON.Image = Properties.Resources.ResourceManager.GetObject( "NETWORK_SYNC_" + syncAnimationWIFISignalCount ) as Image;
		}

		private void NOTIFY_PANEL_Paint( object sender, PaintEventArgs e )
		{

		}
		
		private void NOTIFY_PANEL_OUTER_Paint( object sender, PaintEventArgs e )
		{
			int w = this.NOTIFY_PANEL_OUTER.Width, h = this.NOTIFY_PANEL_OUTER.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 2, w, 2 ); // 위
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래

			//e.Graphics.DrawLine( lineDrawer, 0, 2, 0, h ); // 왼쪽
			//e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 2, w - lineDrawer.Width, h ); // 오른쪽
		}

		bool updateIconHighLightStatus = false;
		private void UPDATE_ICON_HIGHLIGHT_TIMER_Tick( object sender, EventArgs e )
		{
			updateIconHighLightStatus = !updateIconHighLightStatus;
			this.UPDATE_AVAILABLE.Image = updateIconHighLightStatus ? Properties.Resources.UPDATE_25x25 : Properties.Resources.UPDATE_25x25_BLACK;
		}

		bool errorIconHighLightStatus = false;
		private void ERROR_ICON_HIGHLIGHT_TIMER_Tick( object sender, EventArgs e )
		{
			errorIconHighLightStatus = !errorIconHighLightStatus;
			this.PROGRAM_ERROR_HAPPEND.Image = errorIconHighLightStatus ? Properties.Resources.ERROR_ICON_25x25 : Properties.Resources.ERROR_ICON_25x25_BLACK;
		}

		private void PROGRAM_ERROR_HAPPEND_Click( object sender, EventArgs e )
		{
			ProgramErrorNotify form = new ProgramErrorNotify( );
			form.Show( this );
		}

		private void TOGGLE_CHATBOX_Click( object sender, EventArgs e )
		{
			this.STEP_CHATBOX.Visible = !this.STEP_CHATBOX.Visible;
		}

		private void CUSTOM_USER_WARN_BUTTON_Click( object sender, EventArgs e )
		{
			( new MemberWarningForm( ) ).ShowDialog( );
		}

		private void CUSTOM_MEMBER_ACTIVITY_STOP_BUTTON_Click( object sender, EventArgs e )
		{
			( new MemberActivityStopListForm( ) ).ShowDialog( );
		}

		private void RULE_VIEW_BUTTON_Click( object sender, EventArgs e )
		{
			Utility.OpenWebPage( GlobalVar.CAFE_RULE_URL, this );
		}

		private void USER_ACCEPT_BUTTON_Click( object sender, EventArgs e )
		{
			Utility.OpenWebPage( GlobalVar.CAFE_MANAGE_JOINMANAGE_URL, this );
		}

		private void CAFE_MANAGEMENT_BUTTON_Click( object sender, EventArgs e )
		{
			Utility.OpenWebPage( GlobalVar.CAFE_MANAGE_HOME_URL, this );
		}

		private void CAFE_RANK_RULE_BUTTON_Click( object sender, EventArgs e )
		{
			Utility.ProgramErrorHappendTick( );
			( new CafeRankViewer( ) ).ShowDialog( );
		}
	}
}
