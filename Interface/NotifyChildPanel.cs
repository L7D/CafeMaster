using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using CafeMaster_UI.Lib;

namespace CafeMaster_UI.Interface
{
	public enum NotifyChildPanelColorAnimation
	{
		None,
		Selected
	}

	public partial class NotifyChildPanel : UserControl
	{
		private SolidBrush BackgroundDrawer = new SolidBrush( Color.FromArgb( 0, Color.LightCoral ) );
		private Pen lineDrawer = new Pen( GlobalVar.MasterColor )
		{
			Width = 1
		};
		private Timer colorAnimationTimer;

		private NotifyData dataTemp;
		private string accountID;

		public string THREAD_ID;
		public bool CHECKED
		{
			get;
			set;
		}

		public NotifyChildPanel( NotifyData data )
		{
			InitializeComponent( );

			this.THREAD_ID = data.threadID;
			this.accountID = data.threadAuthor.Substring( data.threadAuthor.IndexOf( '(' ) + 1, data.threadAuthor.Length - data.threadAuthor.IndexOf( '(' ) - 2 );
			this.NUMBER_LABEL.Text = "#" + data.threadID;
			this.BOARD_NAME_LABEL.Text = string.IsNullOrEmpty( data.articleName ) ? "Q&A 또는 기타 게시판" : data.articleName;

			this.TITLE_LABEL.Text = data.threadTitle;
			this.AUTHOR_LABEL.Text = data.threadAuthor;
			this.TIME_LABEL.Text = data.threadTime;
			this.HIT_LABEL.Text = data.threadHit + " V";

			if ( data.personaconURL == "" )
				this.AUTHOR_ICON.Image = Properties.Resources.USER_ICON;
			else
				this.AUTHOR_ICON.ImageLocation = data.personaconURL;

			if ( GlobalVar.ADMINS[ this.accountID ] != null )
			{
				this.ADMIN_ICON.Visible = true;
				this.RANK_LABEL.Visible = false;

				//switch ( ( AdminRanks ) GlobalVar.ADMINS[ this.accountID ] )
				//{
				//	case AdminRanks.Manager:
				//		//this.RANK_LABEL.Text = "매니저 게시글";
				//		break;
				//	case AdminRanks.SubManager:
				//		//this.RANK_LABEL.Text = "부매니저 게시글";
				//		break;
				//	case AdminRanks.Staff:
				//		//this.RANK_LABEL.Text = "스탭 게시글";
				//		break;
				//	default:
				//		this.RANK_LABEL.Visible = false;
				//		this.ADMIN_ICON.Visible = false;
				//		break;
				//}
			}
			else
			{
				this.RANK_LABEL.Visible = false;
				this.ADMIN_ICON.Visible = false;
			}

			this.dataTemp = data;

			if ( this.dataTemp.focused )
			{
				this.FOCUS_BUTTON.NormalStateBackgroundColor = Color.Gold;
				this.FOCUS_BUTTON.EnterStateBackgroundColor = Color.Gray;
			}
			else
			{
				this.FOCUS_BUTTON.NormalStateBackgroundColor = Color.Gray;
				this.FOCUS_BUTTON.EnterStateBackgroundColor = Color.Gold;
			}
		}

		private void ColorAnimation( NotifyChildPanelColorAnimation type, bool enable )
		{
			if ( colorAnimationTimer != null )
			{
				colorAnimationTimer.Stop( );
				colorAnimationTimer.Dispose( );
				colorAnimationTimer = null;
			}

			BackgroundDrawer = new SolidBrush( Color.FromArgb( BackgroundDrawer.Color.A, Color.Tomato ) );

			colorAnimationTimer = new Timer( )
			{
				Interval = 50
			};
			colorAnimationTimer.Tick += delegate ( object sender, EventArgs e )
			{
				if ( BackgroundDrawer.Color.A == ( enable ? 50 : 0 ) )
				{
					colorAnimationTimer.Stop( );
					colorAnimationTimer.Dispose( );
					colorAnimationTimer = null;
					return;
				}

				float a = BackgroundDrawer.Color.A;

				a = Utility.Lerp( a, ( enable ? a + 5 : a - 5 ), 0.1F );

				BackgroundDrawer.Color = Color.FromArgb( Utility.Clamp( ( int ) a, 50, 0 ), BackgroundDrawer.Color );
				this.Invalidate( );
			};

			colorAnimationTimer.Start( );
		}

		private void REMOVE_BUTTON_Click( object sender, EventArgs e )
		{
			if ( NotifyBox.Show( null, "삭제 확인", "게시물 #" + this.THREAD_ID + " 알림을 삭제하시겠습니까?", NotifyBoxType.YesNo, NotifyBoxIcon.Warning ) == NotifyBoxResult.Yes )
				Notify.Remove( this.THREAD_ID );
		}

		private void NotifyChildPanel_Load( object sender, EventArgs e )
		{
			this.SetStyle( ControlStyles.OptimizedDoubleBuffer, true );
			this.SetStyle( ControlStyles.ResizeRedraw, true );
		}

		private void NotifyChildPanel_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.FillRectangle( this.BackgroundDrawer, e.ClipRectangle );
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
		}

		private void RefreshData( )
		{
			NotifyData? data = Notify.GetDataByID( this.THREAD_ID );

			if ( data.HasValue )
			{
				this.dataTemp = data.Value;
			}

			if ( this.dataTemp.focused )
			{
				this.FOCUS_BUTTON.NormalStateBackgroundColor = Color.Gold;
				this.FOCUS_BUTTON.EnterStateBackgroundColor = Color.Gray;
			}
			else
			{
				this.FOCUS_BUTTON.NormalStateBackgroundColor = Color.Gray;
				this.FOCUS_BUTTON.EnterStateBackgroundColor = Color.Gold;
			}

			this.Refresh( );
		}

		private void FOCUS_BUTTON_Click( object sender, EventArgs e )
		{
			Notify.SetFocused( this.dataTemp.threadID, !this.dataTemp.focused );

			RefreshData( );
		}

		private void OPEN_BUTTON_Click( object sender, EventArgs e )
		{
			bool isNetError;

			if ( NaverRequest.IsDeletedThread( this.THREAD_ID, out isNetError ) )
			{
				if ( isNetError )
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

		private void WARN_BUTTON_Click( object sender, EventArgs e )
		{
			if ( this.accountID == "NULL" )
			{
				NotifyBox.Show( null, "오류", "죄송합니다, 올바르지 않은 회원 아이디인 것 같습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
				return;
			}

			if ( this.accountID == GlobalVar.NAVER_USER_ID )
			{
				NotifyBox.Show( null, "오류", "자신에게 경고를 줄 순 없죠~ 푸하하핫!", NotifyBoxType.OK, NotifyBoxIcon.Warning );
				return;
			}

			if ( GlobalVar.ADMINS[ this.accountID ] != null )
			{
				NotifyBox.Show( null, "오류", "어머 지금 다른 스탭분들 경고 주시려고요? 안되죠!~ 푸핳하하핫!", NotifyBoxType.OK, NotifyBoxIcon.Warning );
				return;
			}

			( new UserWarnOptionForm( this.dataTemp.threadAuthor ) ).ShowDialog( );
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
				this.THIS_SELECT_BUTTON.NormalStateBackgroundColor = Color.Tomato;
				this.THIS_SELECT_BUTTON.EnterStateBackgroundColor = Color.DimGray;
			}
			else
			{
				this.THIS_SELECT_BUTTON.NormalStateBackgroundColor = Color.DimGray;
				this.THIS_SELECT_BUTTON.EnterStateBackgroundColor = Color.Tomato;
			}

			Main main = Utility.GetMainForm( );

			if ( main != null )
			{
				main.IS_NOTIFY_CHILD_PANEL_SELECTED_MODE = status;

				ColorAnimation( NotifyChildPanelColorAnimation.Selected, this.CHECKED );

				main.NotifyChildSelectedChanged( this );
			}
		}

		private void THIS_SELECT_BUTTON_Click( object sender, EventArgs e )
		{
			this.CHECKED = !this.CHECKED;

			if ( this.CHECKED )
			{
				this.THIS_SELECT_BUTTON.NormalStateBackgroundColor = Color.Tomato;
				this.THIS_SELECT_BUTTON.EnterStateBackgroundColor = Color.DimGray;
			}
			else
			{
				this.THIS_SELECT_BUTTON.NormalStateBackgroundColor = Color.DimGray;
				this.THIS_SELECT_BUTTON.EnterStateBackgroundColor = Color.Tomato;
			}

			Main main = Utility.GetMainForm( );

			if ( main != null )
			{
				main.IS_NOTIFY_CHILD_PANEL_SELECTED_MODE = true;

				ColorAnimation( NotifyChildPanelColorAnimation.Selected, this.CHECKED );

				main.NotifyChildSelectedChanged( this );
			}
		}

		private void ONLY_COMMENT_BUTTON_Click( object sender, EventArgs e )
		{
			bool isNetError;

			if ( NaverRequest.IsDeletedThread( this.THREAD_ID, out isNetError ) )
			{
				if ( isNetError )
					NotifyBox.Show( null, "오류", "죄송합니다, 네트워크 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
				else
				{
					NotifyBox.Show( null, "삭제된 글", "이 게시물은 삭제되었습니다.", NotifyBoxType.OK, NotifyBoxIcon.Warning );
				}
			}
			else
			{
				try
				{
					System.Diagnostics.Process.Start( "http://cafe.naver.com/" + GlobalVar.CAFE_URL_ID + "/" + this.THREAD_ID + "/comment?refferAllArticles=true" );
				}
				catch ( Exception ex )
				{
					Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
					NotifyBox.Show( null, "오류", "죄송합니다, 웹 페이지를 여는 도중 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
				}
			}
		}
	}
}
