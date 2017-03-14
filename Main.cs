using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using CafeMaster_UI.Interface;
using CafeMaster_UI.Lib;

namespace CafeMaster_UI
{
	public partial class Main : Form
	{
		//맞춤법 검사기 추가하기
		//게시글 -> 게시물로 수정 바람
		
		//게시글 없는 유저 활동정지 처리방법
		//http://cafe.naver.com/ManageActivityStopPopupView.nhn?clubid=25430492&memberids=ljh100154

		private Point startPoint;
		private Pen lineDrawer = new Pen( GlobalVar.MasterColor )
		{
			Width = 1
		};

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

				NotifyChildSelectedModeChanged( value );
			}
		}

		public Main( )
		{
			InitializeComponent( );

			this.SetStyle( ControlStyles.ResizeRedraw, true );
			this.SetStyle( ControlStyles.OptimizedDoubleBuffer, true );
		}

		//public void SetNetworkIcon( int type )
		//{
		//	if ( this.InvokeRequired )
		//	{
		//		this.Invoke( new Action( ( ) =>
		//		{
		//			switch ( type )
		//			{
		//				case 0:
		//					this.NETWORK_STATUS_ICON.Image = Properties.Resources.NETWORK_NOT_INIT;
		//					this.TOOL_TIP.SetToolTip( this.NETWORK_STATUS_ICON, "우유 서버 연결 상태 : 초기화 하는 중 ..." );
		//					break;
		//				case 1:
		//					this.NETWORK_STATUS_ICON.Image = Properties.Resources.NETWORK_ONLINE;
		//					this.TOOL_TIP.SetToolTip( this.NETWORK_STATUS_ICON, "우유 서버 연결 상태 : 온라인" );
		//					break;
		//				case 2:
		//					this.NETWORK_STATUS_ICON.Image = Properties.Resources.NETWORK_WORKING;
		//					this.TOOL_TIP.SetToolTip( this.NETWORK_STATUS_ICON, "우유 서버 연결 상태 : 동기화 하는 중 ..." );
		//					break;
		//				case 3:
		//					this.NETWORK_STATUS_ICON.Image = Properties.Resources.NETWORK_OFFLINE;
		//					this.TOOL_TIP.SetToolTip( this.NETWORK_STATUS_ICON, "우유 서버 연결 상태 : 오프라인" );
		//					break;
		//				default:
		//					this.NETWORK_STATUS_ICON.Image = Properties.Resources.NETWORK_NOT_INIT;
		//					this.TOOL_TIP.SetToolTip( this.NETWORK_STATUS_ICON, "우유 서버 연결 상태 : 초기화 하는 중 ..." );
		//					break;
		//			}
		//		} ) );
		//	}
		//	else
		//	{
		//		switch ( type )
		//		{
		//			case 0:
		//				this.NETWORK_STATUS_ICON.Image = Properties.Resources.NETWORK_NOT_INIT;
		//				this.TOOL_TIP.SetToolTip( this.NETWORK_STATUS_ICON, "우유 서버 연결 상태 : 초기화 하는 중 ..." );
		//				break;
		//			case 1:
		//				this.NETWORK_STATUS_ICON.Image = Properties.Resources.NETWORK_ONLINE;
		//				this.TOOL_TIP.SetToolTip( this.NETWORK_STATUS_ICON, "우유 서버 연결 상태 : 온라인" );
		//				break;
		//			case 2:
		//				this.NETWORK_STATUS_ICON.Image = Properties.Resources.NETWORK_WORKING;
		//				this.TOOL_TIP.SetToolTip( this.NETWORK_STATUS_ICON, "우유 서버 연결 상태 : 동기화 하는 중 ..." );
		//				break;
		//			case 3:
		//				this.NETWORK_STATUS_ICON.Image = Properties.Resources.NETWORK_OFFLINE;
		//				this.TOOL_TIP.SetToolTip( this.NETWORK_STATUS_ICON, "우유 서버 연결 상태 : 오프라인" );
		//				break;
		//			default:
		//				this.NETWORK_STATUS_ICON.Image = Properties.Resources.NETWORK_NOT_INIT;
		//				this.TOOL_TIP.SetToolTip( this.NETWORK_STATUS_ICON, "우유 서버 연결 상태 : 초기화 하는 중 ..." );
		//				break;
		//		}
		//	}
		//}

		public void RefreshNotifyPanel( )
		{
			this.NOTIFY_PANEL.Enabled = false;

			int scrollPosTemp = this.NOTIFY_PANEL.VerticalScroll.Value;
			int y = 10;

			this.NOTIFY_PANEL.Controls.Clear( );

			foreach ( NotifyData data in Notify.GetAll( ) )
			{
				NotifyChildPanel panel = new NotifyChildPanel( data );
				panel.Location = new Point( 10, y );

				y += panel.Height + 5;

				this.NOTIFY_PANEL.Controls.Add( panel );
			}

			this.NOTIFY_PANEL.ScrollDown( scrollPosTemp );
			this.NOTIFY_PANEL.Enabled = true;
		}

		public void StartWorker( string message )
		{
			if ( this.InvokeRequired )
			{
				this.Invoke( new Action( ( ) =>
				{
					if ( !this.LOADING_GIFIMAGE.Visible )
						this.LOADING_GIFIMAGE.Visible = true;

					if ( !this.CURRENT_PROGRESS_LABEL.Visible )
						this.CURRENT_PROGRESS_LABEL.Visible = true;

					this.CURRENT_PROGRESS_LABEL.Text = message;
				} ) );
			}
			else
			{
				if ( !this.LOADING_GIFIMAGE.Visible )
					this.LOADING_GIFIMAGE.Visible = true;

				if ( !this.CURRENT_PROGRESS_LABEL.Visible )
					this.CURRENT_PROGRESS_LABEL.Visible = true;

				this.CURRENT_PROGRESS_LABEL.Text = message;
			}
		}

		public void EndWorker( )
		{
			if ( this.InvokeRequired )
			{
				this.Invoke( new Action( ( ) =>
				{
					this.LOADING_GIFIMAGE.Visible = false;
					this.CURRENT_PROGRESS_LABEL.Visible = false;
					this.CURRENT_PROGRESS_LABEL.Text = "";
				} ) );
			}
			else
			{
				this.LOADING_GIFIMAGE.Visible = false;
				this.CURRENT_PROGRESS_LABEL.Visible = false;
				this.CURRENT_PROGRESS_LABEL.Text = "";
			}
		}

		public void NotifyChildSelectedChanged( Control control )
		{
			if ( this.NOTIFY_PANEL.Controls.Count > 0 )
			{
				foreach ( Control i in this.NOTIFY_PANEL.Controls )
				{
					if ( i.Name != "NotifyChildPanel" ) continue;
					if ( ( ( NotifyChildPanel ) i ).CHECKED ) return;
				}
			}

			this.IS_NOTIFY_CHILD_PANEL_SELECTED_MODE = false;
		}

		private void NotifyChildSelectedModeChanged( bool status )
		{
			if ( status )
			{
				this.CHILD_PANEL_UTIL_ALL_SELECT.Visible = true;
				this.CHILD_PANEL_UTIL_DELETE.Visible = true;
			}
			else
			{
				this.CHILD_PANEL_UTIL_ALL_SELECT.Visible = false;
				this.CHILD_PANEL_UTIL_DELETE.Visible = false;
			}
		}

		private void Main_Load( object sender, EventArgs e )
		{
			//new Welcome( ).ShowDialog( );
			//new ProgramAuthForm( ).ShowDialog( );
			new NaverLoginForm( ).ShowDialog( );
			new MemberActivityStopForm( ).ShowDialog( );

			if ( this.Disposing || this.IsDisposed ) return;

			MainInitialize( );

			TopProgressMessage.Set( "프로그램 시작 하는 중 ..." );

			Thread preWorkAll = new Thread( ( ) =>
			{
				TopProgressMessage.Set( "업데이트를 확인하고 있습니다 ..." );

				if ( Lib.Update.Check() )
				{
					GlobalVar.UPDATE_AVAILABLE = true;
					UpdateAvailable( );
				}
				else
				{
					GlobalVar.UPDATE_AVAILABLE = false;
				}

				TopProgressMessage.Set( "계정 정보를 불러오고 있습니다 ..." );

				if ( NaverAccountInitialize( ) && !string.IsNullOrEmpty( GlobalVar.COOKIES ) && GlobalVar.COOKIES_LIST.Count != 0 )
				{
					TopProgressMessage.Set( "데이터를 불러오고 있습니다 ..." );

					ThreadDataStore.Initialize( );

					Thread.Sleep( 2000 );

					TopProgressMessage.End( );

					Observer.Start( );
				}
				else
				{
					//Utility.WriteErrorLog( res.ToString( ) + " / " + ( string.IsNullOrEmpty( GlobalVar.COOKIES ).ToString( ) ) + " / " + ( GlobalVar.COOKIES_LIST.Count != 0 ).ToString( ) );
					TopProgressMessage.End( );

					NotifyBox.Show( this, "오류", "죄송합니다, 네이버 계정 인증을 실패했습니다, 프로그램을 다시 시작하면 해결될 수 있습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
					Application.Exit( );
				}
			} )
			{
				IsBackground = true
			};
			preWorkAll.Start( );
		}

		private void UpdateAvailable( )
		{
			if ( this.InvokeRequired )
			{
				this.Invoke( new Action( ( ) =>
				{
					this.UPDATE_AVAILABLE.Visible = true;
					this.APP_NOTIFY_ICON.ShowBalloonTip( 5000, "우윳빛깔 카페스탭", "새로운 프로그램 업데이트가 있습니다, 카페 페이지를 참고하세요.", ToolTipIcon.None );
				} ) );
			}
			else
			{
				this.UPDATE_AVAILABLE.Visible = true;
				this.APP_NOTIFY_ICON.ShowBalloonTip( 5000, "우윳빛깔 카페스탭", "새로운 프로그램 업데이트가 있습니다, 카페 페이지를 참고하세요.", ToolTipIcon.None );
			}
		}

		private void MainInitialize( )
		{
			IS_NOTIFY_CHILD_PANEL_SELECTED_MODE = false;

			this.LOADING_GIFIMAGE.DocumentText = "0";
			this.LOADING_GIFIMAGE.Document.OpenNew( true );
			this.LOADING_GIFIMAGE.Document.Write( @"<html>
				<head>
					<style>
						html, body {
							margin: 0;
							width: 100%;
							height: 100%;
						}
					</style>
				</head>
				<body>
					<img src='data:image/gif;base64,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' width=45px height=40px/>
				</body>
			</html>" );
			this.LOADING_GIFIMAGE.Refresh( );
			this.LOADING_GIFIMAGE.Visible = false;

			if ( !string.IsNullOrEmpty( GlobalVar.COOKIES ) && GlobalVar.COOKIES_LIST.Count != 0 )
			{
				Utility.SetUriCookieContainerToNaverCookies( "http://cafe.naver.com" );

				this.STEP_CHATBOX.Navigate( new Uri( GlobalVar.CAFE_CHAT_URL ) );
			}
			else
			{
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
			{
				this.BELL_STATUS_BUTTON.Image = Properties.Resources.BELL_IGNORE;
			}

			Theme.Apply( this.BACKGROUND_SPLASH, "main_*.png" );
		}

		private bool NaverAccountInitialize( )
		{
			NaverAccountInformation? accountInformation = NaverRequest.AccountRequest( );
			Action<NaverAccountInformation> callBack = ( NaverAccountInformation info ) =>
			{
				GlobalVar.NAVER_USER_ID = info.email;

				if ( info.iconURL != "N" ) // 프로필 이미지가 설정되지 않으면 이미지 URL 이 N임
				{
					try
					{
						if ( !Directory.Exists( GlobalVar.DATA_DIR ) )
							Directory.CreateDirectory( GlobalVar.DATA_DIR );

						MemoryStream profileImageX80 = Utility.URLFileToMemoryStream( info.iconURL.Replace( "?type=s160", "?type=s80" ) );

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
				this.Close( );
		}

		private void Main_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // 위
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // 왼쪽
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // 오른쪽
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
		}

		private void NOTIFY_PANEL_Paint( object sender, PaintEventArgs e )
		{
			int w = this.NOTIFY_PANEL.Width, h = this.NOTIFY_PANEL.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // 위
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // 왼쪽
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // 오른쪽
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
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

		private void NOTIFY_PANEL_Scroll( object sender, ScrollEventArgs e )
		{
			this.NOTIFY_PANEL.Invalidate( );
		}

		private void NOTIFY_PANEL_MouseWheel( object sender, MouseEventArgs e )
		{
			this.NOTIFY_PANEL.Invalidate( );
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
				Observer.ForceProgress( );

				this.FORCE_SYNC_DELAY_TIMER.Start( );
			}
		}

		private void UTIL_BUTTON1_Click( object sender, EventArgs e )
		{
			try
			{
				Process.Start( GlobalVar.CAFE_RULE_URL );
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				NotifyBox.Show( this, "오류", "죄송합니다, 웹 페이지를 여는 도중 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
			}
		}

		private void UTIL_BUTTON2_Click( object sender, EventArgs e )
		{
			try
			{
				Process.Start( GlobalVar.CAFE_TOTAL_ARTICLE_URL );
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				NotifyBox.Show( this, "오류", "죄송합니다, 웹 페이지를 여는 도중 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
			}
		}

		private void UTIL_BUTTON3_Click( object sender, EventArgs e )
		{
			try
			{
				Process.Start( GlobalVar.CAFE_MANAGE_HOME_URL );
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				NotifyBox.Show( this, "오류", "죄송합니다, 웹 페이지를 여는 도중 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
			}
		}

		private void UTIL_BUTTON4_Click( object sender, EventArgs e )
		{
			try
			{
				Process.Start( GlobalVar.CAFE_MANAGE_JOINMANAGE_URL );
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				NotifyBox.Show( this, "오류", "죄송합니다, 웹 페이지를 여는 도중 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
			}
		}

		private void UPDATE_AVAILABLE_Click( object sender, EventArgs e )
		{
			NotifyBox.Show( this, "업데이트 가능", "새로운 버전의 '우윳빛깔 카페스탭' 을 사용하실 수 있습니다, 카페 페이지를 참고하세요.", NotifyBoxType.OK, NotifyBoxIcon.Information );
		}

		private void OPTION_BUTTON_Click( object sender, EventArgs e )
		{
			( new OptionForm( ) ).ShowDialog( );
		}

		private bool CHILD_PANEL_UTIL_ALL_SELECT_privClicked;

		private void CHILD_PANEL_UTIL_ALL_SELECT_Click( object sender, EventArgs e )
		{
			if ( !this.IS_NOTIFY_CHILD_PANEL_SELECTED_MODE ) return;

			if ( CHILD_PANEL_UTIL_ALL_SELECT_privClicked )
			{
				CHILD_PANEL_UTIL_ALL_SELECT_privClicked = false;

				foreach ( Control i in this.NOTIFY_PANEL.Controls )
				{
					if ( i.Name != "NotifyChildPanel" ) continue;

					( ( NotifyChildPanel ) i ).ExternalSelectChange( false );
				}
			}
			else
			{
				CHILD_PANEL_UTIL_ALL_SELECT_privClicked = true;

				foreach ( Control i in this.NOTIFY_PANEL.Controls )
				{
					if ( i.Name != "NotifyChildPanel" ) continue;

					( ( NotifyChildPanel ) i ).ExternalSelectChange( true );
				}
			}
		}

		private void CHILD_PANEL_UTIL_DELETE_Click( object sender, EventArgs e )
		{
			if ( NotifyBox.Show( this, "삭제 확인", "선택한 새 게시물 알림을 모두 삭제하시겠습니까?", NotifyBoxType.YesNo, NotifyBoxIcon.Warning ) != NotifyBoxResult.Yes ) return;

			CHILD_PANEL_UTIL_ALL_SELECT_privClicked = false;

			int count = 0;
			foreach ( Control i in this.NOTIFY_PANEL.Controls )
			{
				if ( i.Name != "NotifyChildPanel" ) continue;
				NotifyChildPanel panel = i as NotifyChildPanel;

				if ( !panel.CHECKED ) continue;

				Notify.Remove( panel.THREAD_ID, true, true );
				count++;
			}

			RefreshNotifyPanel( );
			Notify.Save( );

			NotifyBox.Show( this, "삭제 완료", "선택한 " + count + " 개의 새 게시물 알림을 삭제했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Information );
		}

		private void NOTIFY_PANEL_ControlRemoved( object sender, ControlEventArgs e )
		{
			if ( this.NOTIFY_PANEL.Controls.Count == 0 )
			{
				this.NOTIFYBOX_EMPTY_ICON.Visible = true;
				this.NOTIFYBOX_EMPTY_TITLE.Visible = true;
				this.NOTIFYBOX_EMPTY_DESC.Visible = true;

				this.IS_NOTIFY_CHILD_PANEL_SELECTED_MODE = false;
			}
		}

		private void NOTIFY_PANEL_ControlAdded( object sender, ControlEventArgs e )
		{
			this.NOTIFYBOX_EMPTY_ICON.Visible = false;
			this.NOTIFYBOX_EMPTY_TITLE.Visible = false;
			this.NOTIFYBOX_EMPTY_DESC.Visible = false;
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
			Notify.Save( );
			Config.Save( );
		}

		private void APP_NOTIFY_ICON_MENU_ITEM_1_Click( object sender, EventArgs e )
		{
			this.Close( );
		}

		private void NOTIFICATION_BUTTON_Click( object sender, EventArgs e )
		{

		}
	}
}
