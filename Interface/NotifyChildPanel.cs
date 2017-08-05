using System;
using System.Drawing;
using System.Windows.Forms;
using CafeMaster_UI.Lib;

namespace CafeMaster_UI.Interface
{
	//public enum NotifyChildPanelColorAnimation
	//{
	//	None,
	//	Selected
	//}

	public partial class NotifyChildPanel : UserControl
	{
		private Pen lineDrawer = new Pen( GlobalVar.MasterColor )
		{
			Width = 1
		};
		private NotifyData dataTemp;
		private string authorID;

		public delegate void NotifyChildPanelSelectedEvent( NotifyChildPanel i );
		public event NotifyChildPanelSelectedEvent NotifyChildPanelSelectedChanged;

		public string THREAD_ID; // 외부 접근용
		public bool CHECKED // 외부 접근용
		{
			get;
			set;
		}

		public NotifyChildPanel( NotifyData data )
		{
			InitializeComponent( );

			this.SetStyle( ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.SupportsTransparentBackColor, true );
			this.UpdateStyles( );

			this.BackColor = Color.FromArgb( 100, Color.White );

			// 데이터 설정
			this.THREAD_ID = data.threadID;
			try
			{
				this.authorID = data.threadAuthor.Substring( data.threadAuthor.IndexOf( '(' ) + 1, data.threadAuthor.Length - data.threadAuthor.IndexOf( '(' ) - 2 );
			}
			catch { }

			// 인터페이스 설정
			this.NUMBER_LABEL.Text = "#" + data.threadID;
			this.BOARD_NAME_LABEL.Text = string.IsNullOrEmpty( data.articleName ) ? "Q&A 또는 기타 게시판" : data.articleName;
			this.TITLE_LABEL.Text = data.threadTitle;
			this.AUTHOR_LABEL.Text = data.threadAuthor;
			this.TIME_LABEL.Text = data.threadTime;
			this.HIT_LABEL.Text = data.threadHit + " V";

			if ( string.IsNullOrEmpty( data.personaconURL ) )
				this.AUTHOR_ICON.Image = Properties.Resources.USER_ICON;
			else
				this.AUTHOR_ICON.ImageLocation = data.personaconURL;

			if ( GlobalVar.ADMINS[ this.authorID ] != null )
			{
				this.ADMIN_ICON.Visible = true;
				this.RANK_LABEL.Visible = false;
				this.ADMIN_ICON.Location = new Point( this.AUTHOR_LABEL.Location.X + this.AUTHOR_LABEL.Width + 5, this.ADMIN_ICON.Location.Y );

				switch ( ( AdminRanks ) GlobalVar.ADMINS[ this.authorID ] )
				{
					case AdminRanks.Manager:
						this.TOOL_TIP.SetToolTip( this.ADMIN_ICON, "매니저 게시물" );
						break;
					case AdminRanks.SubManager:
						this.TOOL_TIP.SetToolTip( this.ADMIN_ICON, "부매니저 게시물" );
						break;
					case AdminRanks.Staff:
						this.TOOL_TIP.SetToolTip( this.ADMIN_ICON, "스탭 게시물" );
						break;
					default:
						this.ADMIN_ICON.Visible = false;
						break;
				}
			}
			else
			{
				this.RANK_LABEL.Visible = true;
				this.RANK_LABEL.Location = new Point( this.AUTHOR_LABEL.Location.X + this.AUTHOR_LABEL.Width, this.RANK_LABEL.Location.Y );
				this.RANK_LABEL.Text = data.authorRank;
				this.ADMIN_ICON.Visible = false;
			}

			this.dataTemp = data;
		}

		//private void ColorAnimation( NotifyChildPanelColorAnimation type, bool enable )
		//{
		//if ( colorAnimationTimer != null )
		//{
		//	colorAnimationTimer.Stop( );
		//	colorAnimationTimer.Dispose( );
		//	colorAnimationTimer = null;
		//}

		//BackgroundDrawer = new SolidBrush( Color.FromArgb( BackgroundDrawer.Color.A, Color.Gold ) );

		//colorAnimationTimer = new Timer( )
		//{
		//	Interval = 10
		//};
		//colorAnimationTimer.Tick += delegate ( object sender, EventArgs e )
		//{
		//	if ( BackgroundDrawer.Color.A == ( enable ? 50 : 0 ) )
		//	{
		//		colorAnimationTimer.Stop( );
		//		colorAnimationTimer.Dispose( );
		//		colorAnimationTimer = null;
		//		return;
		//	}

		//	float a = BackgroundDrawer.Color.A;

		//	a = Utility.Lerp( a, ( enable ? a + 10 : a - 10 ), 0.1F );

		//	BackgroundDrawer.Color = Color.FromArgb( Utility.Clamp( ( int ) a, 50, 0 ), BackgroundDrawer.Color );
		//	this.Invalidate( );
		//};

		//colorAnimationTimer.Start( );
		//}

		private void NOTIFY_DELETE_BUTTON_Click( object sender, EventArgs e )
		{
			if ( NotifyBox.Show( null, "삭제 확인", "이 알림을 삭제하시겠습니까?", NotifyBoxType.YesNo, NotifyBoxIcon.Warning ) == NotifyBoxResult.Yes )
				Notify.Remove( this.THREAD_ID );
		}

		private void NotifyChildPanel_Load( object sender, EventArgs e )
		{
			if ( !BrowserCapture.FileAvailable( this.THREAD_ID ) )
				this.IMAGE_VIEW_BUTTON.Visible = false;
		}

		private void NotifyChildPanel_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			//e.Graphics.FillRectangle( this.BackgroundDrawer, e.ClipRectangle );
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
		}

		private void RefreshData( )
		{
			NotifyData? data = Notify.GetDataByID( this.THREAD_ID );

			if ( data.HasValue )
				this.dataTemp = data.Value;

			this.Refresh( );
		}

		private void FOCUS_BUTTON_Click( object sender, EventArgs e )
		{
			//Notify.SetData( this.THREAD_ID, new Notify.DataSettingDelegate( ( ref NotifyData data ) =>
			//{
			//	data.focused = !this.dataTemp.focused;
			//} ) );

			//RefreshData( );
		}

		private void OPEN_BUTTON_Click( object sender, EventArgs e )
		{
			bool isNetworkError;

			if ( NaverRequest.IsDeletedThread( this.THREAD_ID, out isNetworkError ) )
			{
				if ( isNetworkError )
				{
					NotifyBox.Show( null, "오류", "죄송합니다, 네트워크 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
				}
				else
				{
					if ( BrowserCapture.FileAvailable( this.THREAD_ID ) )
					{
						if ( NotifyBox.Show( null, "삭제된 글", "이 게시물은 삭제되었습니다, 캡처된 이미지를 보시겠습니까?", NotifyBoxType.YesNo, NotifyBoxIcon.Warning ) == NotifyBoxResult.Yes )
						{
							BrowserCapture.OpenImage( this.THREAD_ID );
						}
					}
					else
					{
						NotifyBox.Show( null, "삭제된 글", "이 게시물은 삭제되었습니다.", NotifyBoxType.OK, NotifyBoxIcon.Warning );
					}
				}
			}
			else
			{
				try
				{
					System.Diagnostics.Process.Start( this.dataTemp.threadURL );
				}
				catch ( Exception ex )
				{
					Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
					NotifyBox.Show( null, "오류", "죄송합니다, 웹 페이지를 여는 도중 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
				}
			}
		}
		
		private void IMAGE_VIEW_BUTTON_Click( object sender, EventArgs e )
		{
			if ( BrowserCapture.FileAvailable( this.THREAD_ID ) )
			{
				if ( NotifyBox.Show( null, "질문", "캡처된 게시물 이미지를 보시겠습니까?", NotifyBoxType.YesNo, NotifyBoxIcon.Question ) == NotifyBoxResult.Yes )
					BrowserCapture.OpenImage( this.THREAD_ID );
			}
			else
				NotifyBox.Show( null, "이미지 없음", "이 게시물에 대한 캡처된 이미지가 없습니다.", NotifyBoxType.OK, NotifyBoxIcon.Warning );
		}

		// 외부 접근 용 THIS_SELECT_BUTTON_Click 메소드 복제품 (Main 호출)
		public void ExternalSelectChange( bool status )
		{
			this.CHECKED = status;

			if ( this.CHECKED )
			{
				this.lineDrawer = new Pen( Color.FromArgb( 35, 144, 237 ) )
				{
					Width = 2,
					DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot
				};
				this.THIS_SELECT_BUTTON.Image = Properties.Resources.NOTIFY_SELECT_YES_ICON;
			}
			else
			{
				this.lineDrawer = new Pen( GlobalVar.MasterColor )
				{
					Width = 1
				};
				this.THIS_SELECT_BUTTON.Image = Properties.Resources.NOTIFY_SELECT_NOPE_ICON;
			}
			
			this.Invalidate( );

			Main main = Utility.GetMainForm( );

			if ( main != null )
			{
				main.IS_NOTIFY_CHILD_PANEL_SELECTED_MODE = status;
				NotifyChildPanelSelectedChanged.Invoke( this );
			}
		}

		private void THIS_SELECT_BUTTON_Click( object sender, EventArgs e )
		{
			this.CHECKED = !this.CHECKED;

			if ( this.CHECKED )
			{
				this.lineDrawer = new Pen( Color.FromArgb( 35, 144, 237 ) )
				{
					Width = 2,
					DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot
				};
				this.THIS_SELECT_BUTTON.Image = Properties.Resources.NOTIFY_SELECT_YES_ICON;
			}
			else
			{
				this.lineDrawer = new Pen( GlobalVar.MasterColor )
				{
					Width = 1
				};
				this.THIS_SELECT_BUTTON.Image = Properties.Resources.NOTIFY_SELECT_NOPE_ICON;
			}

			this.Invalidate( );

			Main main = Utility.GetMainForm( );

			if ( main != null )
			{
				main.IS_NOTIFY_CHILD_PANEL_SELECTED_MODE = true;
				NotifyChildPanelSelectedChanged.Invoke( this );
			}
		}

		private void ONLY_COMMENT_BUTTON_Click( object sender, EventArgs e )
		{
			bool isNetworkError;

			if ( NaverRequest.IsDeletedThread( this.THREAD_ID, out isNetworkError ) )
			{
				if ( isNetworkError )
					NotifyBox.Show( null, "오류", "죄송합니다, 네트워크 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
				else
				{
					NotifyBox.Show( null, "삭제된 글", "이 게시물은 삭제되었습니다.", NotifyBoxType.OK, NotifyBoxIcon.Warning );
				}
			}
			else
			{
				Utility.OpenWebPage( "http://cafe.naver.com/" + GlobalVar.CAFE_URL_ID + "/" + this.THREAD_ID + "/comment?refferAllArticles=true" );
			}
		}

		private void ADMIN_ICON_Click( object sender, EventArgs e )
		{
			//try
			//{
			//	System.Diagnostics.Process.Start( GlobalVar.CAFE_MEMBER_NETWORK_VIEW_URL + this.accountID );
			//}
			//catch ( Exception ex )
			//{
			//	Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
			//	NotifyBox.Show( null, "오류", "죄송합니다, 웹 페이지를 여는 도중 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
			//}
		}

		private void THREAD_DELETE_BUTTON_Click( object sender, EventArgs e )
		{
			if ( NotifyBox.Show( null, "삭제 확인", "이 알림에 대한 '실제 게시물'과 알림을 삭제하시겠습니까?", NotifyBoxType.YesNo, NotifyBoxIcon.Danger ) == NotifyBoxResult.Yes )
			{
				if ( NotifyBox.Show( null, "삭제 확인", "이 작업을 하면 이 알림과 실제로 게시물이 지워집니다, 정말로 하시겠습니까???", NotifyBoxType.YesNo, NotifyBoxIcon.Danger ) == NotifyBoxResult.Yes )
				{
					Notify.Remove( this.THREAD_ID );

					if ( NaverRequest.ThreadDelete( this.THREAD_ID ) )
					{
						NotifyBox.Show( null, "삭제 완료", "'실제 게시물'과 알림이 삭제되었습니다.", NotifyBoxType.OK, NotifyBoxIcon.Warning );
					}
					else
					{
						NotifyBox.Show( null, "오류", "죄송합니다, '실제 게시물'을 삭제할 수 없었습니다, 알림만 삭제되었습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
					}
				}
			}
		}

		private void AUTHOR_LABEL_Click( object sender, EventArgs e )
		{
			Utility.OpenWebPage( GlobalVar.CAFE_MEMBER_NETWORK_VIEW_URL + this.authorID );
		}

		private void MEMBER_ACTIVITY_STOP_BUTTON_Click( object sender, EventArgs e )
		{
			if ( this.authorID == "NULL" )
			{
				NotifyBox.Show( null, "오류", "죄송합니다, 올바르지 않은 회원 아이디인 것 같습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
				return;
			}

			if ( this.authorID == GlobalVar.NAVER_USER_ID )
			{
				NotifyBox.Show( null, "오류", "셀프 활동 정지는 불가능합니다!", NotifyBoxType.OK, NotifyBoxIcon.Warning );
				return;
			}

			if ( GlobalVar.ADMINS.ContainsKey( this.authorID ) )
			{
				NotifyBox.Show( null, "오류", "다른 스탭분들께 활동 정지를 주는 행위는 불가능합니다!", NotifyBoxType.OK, NotifyBoxIcon.Warning );
				return;
			}

			MemberActivityStopForm Form = new MemberActivityStopForm( this.authorID );
			Form.ShowDialog( );
		}

		private void MEMBER_WARN_BUTTON_Click( object sender, EventArgs e )
		{
			if ( this.authorID == "NULL" )
			{
				NotifyBox.Show( null, "오류", "죄송합니다, 올바르지 않은 회원 아이디인 것 같습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
				return;
			}

			if ( this.authorID == GlobalVar.NAVER_USER_ID )
			{
				NotifyBox.Show( null, "오류", "셀프 경고는 불가능합니다!", NotifyBoxType.OK, NotifyBoxIcon.Warning );
				return;
			}

			if ( GlobalVar.ADMINS.ContainsKey( this.authorID ) )
			{
				NotifyBox.Show( null, "오류", "다른 스탭분들께 경고를 주는 행위는 불가능합니다!", NotifyBoxType.OK, NotifyBoxIcon.Warning );
				return;
			}

			( new MemberWarningForm( this.dataTemp.threadAuthor ) ).ShowDialog( );
			//( new UserWarnOptionForm( this.dataTemp.threadAuthor ) ).ShowDialog( );
		}
	}
}
