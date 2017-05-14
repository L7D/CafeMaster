using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeMaster_UI.Lib;

namespace CafeMaster_UI.Interface
{
	public partial class MemberWarningForm : Form
	{
		private Point startPoint;
		private Pen lineDrawer = new Pen( GlobalVar.MasterColor )
		{
			Width = 1
		};
		private MemberInformationStruct selectedMemberInformation;

		private int warnCount;
		private string nickName;
		private string onlyID;

		private string externalSearchString;
		private bool userSelected_private;
		private bool userSelected
		{
			get
			{
				return userSelected_private;
			}
			set
			{
				userSelected_private = value;

				if ( value )
				{
					this.USER_SEARCH_TEXTBOX.Text = "";
					this.USER_SEARCH_TEXTBOX.Visible = false;
					this.USER_SEARCH_TEXTBOX.Enabled = false;
					this.USER_SEARCH_BUTTON.Visible = false;
					this.USER_SEARCH_DESC.Visible = false;
					this.USER_SEARCH_TITLE.Visible = false;

					this.WARN_INFORMATION_PANEL.Visible = true;

					this.USER_SEARCH_BUTTON.Text = "ID 검색";
					this.USER_SEARCH_BUTTON.Enabled = true;

					this.USER_INFORMATION_PANEL.Visible = true;
					this.USER_INFORMATION_PANEL_TITLE.Text = "선택된 회원";

					this.USERNAME_LABEL.Text = selectedMemberInformation.nickName + "(" + selectedMemberInformation.memberID + ")";
					this.RANK_LABEL.Text = selectedMemberInformation.rank;

					this.WARN_RUN_BUTTON.Enabled = true;
					this.WARNING_COUNT.Enabled = true;

					this.WARNING_COUNT_AFTERDESC.Text = "";

					try
					{
						this.PROFILE_IMAGE_ICON.Load( selectedMemberInformation.profileImageURL );

						if ( string.IsNullOrEmpty( selectedMemberInformation.personaconImageURL ) )
							this.PERSONACON_IMAGE_ICON.Image = Properties.Resources.USER_ICON;
						else
							this.PERSONACON_IMAGE_ICON.Load( selectedMemberInformation.personaconImageURL );
					}
					catch
					{
						NotifyBox.Show( this, "오류", "죄송합니다, 회원 프로필 사진을 불러올 수 없었습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
					}
				}
				else
				{
					this.USER_SEARCH_TEXTBOX.Text = "";
					this.USER_SEARCH_TEXTBOX.Visible = true;
					this.USER_SEARCH_BUTTON.Visible = true;
					this.USER_SEARCH_TEXTBOX.Enabled = true;
					this.USER_SEARCH_DESC.Visible = true;
					this.USER_SEARCH_TITLE.Visible = true;

					this.USER_SEARCH_BUTTON.Text = "회원 검색";
					this.USER_SEARCH_BUTTON.Enabled = true;

					this.WARN_INFORMATION_PANEL.Visible = false;

					this.USER_INFORMATION_PANEL.Visible = false;
					this.USER_INFORMATION_PANEL_TITLE.Text = "회원 선택";

					this.USERNAME_LABEL.Text = "NULL(NULL)";
					this.RANK_LABEL.Text = "NULL";

					this.PROFILE_IMAGE_ICON.Image = null;
					this.PERSONACON_IMAGE_ICON.Image = null;

					this.WARN_RUN_BUTTON.Enabled = false;
					this.WARNING_COUNT.Enabled = false;

					this.WARNING_COUNT_AFTERDESC.Text = "";
				}
			}
		}

		public MemberWarningForm( )
		{
			InitializeComponent( );

			this.SetStyle( ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true );
			this.UpdateStyles( );
			this.Opacity = 0;
		}

		public MemberWarningForm( string nickName )
		{
			InitializeComponent( );

			this.SetStyle( ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true );
			this.UpdateStyles( );
			this.Opacity = 0;

			this.externalSearchString = nickName.Substring( nickName.IndexOf( '(' ) + 1, nickName.Length - nickName.IndexOf( '(' ) - 2 ); ;
		}

		private void UserWarnOptionForm_Load( object sender, EventArgs e )
		{
			Animation.UI.FadeIn( this );

			Utility.SetUriCookieContainerToNaverCookies( "http://cafe.naver.com" );

			this.USER_SEARCH_TEXTBOX.Focus( );

			userSelected = false;

			this.WARN_INFORMATION_PANEL.Parent = BACKGROUND_SPLASH;
			this.USER_INFORMATION_PANEL.Parent = BACKGROUND_SPLASH;

			this.WARN_RUN_BUTTON.Enabled = false;
			this.WARNING_COUNT.Enabled = false;

			if ( !string.IsNullOrEmpty( externalSearchString ) )
			{
				this.USER_SEARCH_TEXTBOX.Text = externalSearchString;
				this.USER_SEARCH_BUTTON_Click( null, EventArgs.Empty );
			}
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

		private void CLOSE_BUTTON_Click( object sender, EventArgs e )
		{
			this.Close( );
		}

		private void UserWarnOptionForm_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // 위
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // 왼쪽
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // 오른쪽
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
		}

		private void REASON_TEXTBOX_TextChanged( object sender, EventArgs e )
		{
			this.REASON_EXAMPLE.Text = this.REASON_TEXTBOX.Text;
		}

		private void APP_TITLE_BAR_Paint( object sender, PaintEventArgs e )
		{
			int w = this.APP_TITLE_BAR.Width, h = this.APP_TITLE_BAR.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // 위
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // 왼쪽
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // 오른쪽
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
		}

		private void WARNING_COUNT_ValueChanged( object sender, EventArgs e )
		{
			warnCount = ( int ) this.WARNING_COUNT.Value;
			this.THREAD_TITLE_EXAMPLE.Text = nickName + "님 경고 (총 " + warnCount + "회)";

			switch ( warnCount )
			{
				case 3:
					this.WARNING_COUNT_AFTERDESC.Text = "경고 3회를 부여할 시 '활동정지 7일' 처리를 해야 합니다.";
					break;
				case 6:
					this.WARNING_COUNT_AFTERDESC.Text = "경고 6회를 부여할 시 '활동정지 30일' 처리를 해야 합니다.";
					break;
				case 10:
					this.WARNING_COUNT_AFTERDESC.Text = "경고 10회를 부여할 시 이 사용자는 강제탈퇴 해야 합니다.";
					break;
				default:
					this.WARNING_COUNT_AFTERDESC.Text = "";
					break;
			}
			//연혁덕후초키랑(jang8575)님 경고 (총 1회)
		}

		private void CANCEL_BUTTON_Click( object sender, EventArgs e )
		{
			this.Close( );
		}

		private void SELECT_RESET_BUTTON_Click( object sender, EventArgs e )
		{
			//selectedMemberInformation = null;
			userSelected = false;
		}

		private void USER_SEARCH_BUTTON_Click( object sender, EventArgs e )
		{
			string id = this.USER_SEARCH_TEXTBOX.Text.Trim( );

			if ( id.Length <= 0 )
			{
				NotifyBox.Show( this, "오류", "회원 ID를 입력하세요.", NotifyBoxType.OK, NotifyBoxIcon.Warning );
				return;
			}

			if ( id == GlobalVar.NAVER_USER_ID )
			{
				NotifyBox.Show( this, "오류", "셀프 경고는 불가능합니다!", NotifyBoxType.OK, NotifyBoxIcon.Warning );
				return;
			}

			if ( GlobalVar.ADMINS[ id ] != null )
			{
				NotifyBox.Show( this, "오류", "다른 스탭분들께 경고를 주는 행위는 불가능합니다!", NotifyBoxType.OK, NotifyBoxIcon.Warning );
				return;
			}

			this.USER_SEARCH_TEXTBOX.Enabled = false;

			this.USER_SEARCH_BUTTON.Text = "서버에 요청하는 중 ...";
			this.USER_SEARCH_BUTTON.Enabled = false;

			this.WARN_RUN_BUTTON.Enabled = false;
			this.WARNING_COUNT.Enabled = false;
			this.WARNING_COUNT_AFTERDESC.Text = "경고 횟수를 서버에서 가져오고 있습니다 ...";

			Task.Factory.StartNew( ( ) =>
			{
				if ( NaverRequest.CheckMemberExistsSimple( id ) )
				{
					MemberInformationStruct? info = NaverRequest.GetMemberInformation( id );
					Tuple<bool, int, string> countData = NaverRequest.GetMemberWarningCount( id );

					if ( countData.Item1 )
					{
						warnCount = countData.Item2 + 1;
						Utility.SetUriCookieContainerToNaverCookies( "http://cafe.naver.com" );

						if ( info.HasValue )
						{
							if ( this.InvokeRequired )
							{
								this.Invoke( new Action( ( ) =>
								{
									selectedMemberInformation = info.Value;
									userSelected = true;

									this.nickName = selectedMemberInformation.nickName + "(" + selectedMemberInformation.memberID + ")";
									this.onlyID = this.nickName.Substring( this.nickName.IndexOf( '(' ) + 1, this.nickName.Length - this.nickName.IndexOf( '(' ) - 2 );

									this.WARNING_COUNT.Value = warnCount;
									this.USERNICK_EXAMPLE.Text = nickName;
									this.THREAD_TITLE_EXAMPLE.Text = nickName + "님 경고 (총 " + warnCount + "회)";
									//this.chatSendHelper.Navigate( new Uri( GlobalVar.CAFE_CHAT_URL ) );
								} ) );
							}
							else
							{
								selectedMemberInformation = info.Value;
								userSelected = true;

								this.nickName = selectedMemberInformation.nickName + "(" + selectedMemberInformation.memberID + ")";
								this.onlyID = this.nickName.Substring( this.nickName.IndexOf( '(' ) + 1, this.nickName.Length - this.nickName.IndexOf( '(' ) - 2 );

								this.WARNING_COUNT.Value = warnCount;
								this.USERNICK_EXAMPLE.Text = nickName;
								this.THREAD_TITLE_EXAMPLE.Text = nickName + "님 경고 (총 " + warnCount + "회)";
								//this.chatSendHelper.Navigate( new Uri( GlobalVar.CAFE_CHAT_URL ) );
							}
						}
						else
						{
							NotifyBox.Show( this, "오류", "죄송합니다, 회원 데이터를 불러올 수 없었습니다, 다시 시도하세요.", NotifyBoxType.OK, NotifyBoxIcon.Error );
						}
					}
					else
					{
						NotifyBox.Show( this, "오류", "입력하신 아이디는 존재하지 않는 카페 회원입니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
					}

					if ( this.InvokeRequired )
					{
						this.Invoke( new Action( ( ) =>
						{
							this.USER_SEARCH_BUTTON.Text = "회원 검색";
							this.USER_SEARCH_BUTTON.Enabled = true;
							this.USER_SEARCH_TEXTBOX.Enabled = true;
						} ) );
					}
					else
					{
						this.USER_SEARCH_BUTTON.Text = "회원 검색";
						this.USER_SEARCH_BUTTON.Enabled = true;
						this.USER_SEARCH_TEXTBOX.Enabled = true;
					}
				}
			} );
		}

		private void USER_SEARCH_TEXTBOX_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyCode == Keys.Enter )
			{
				this.USER_SEARCH_BUTTON_Click( null, EventArgs.Empty );
				e.Handled = true;
			}
		}

		private void MEMBER_INFO_OPEN_BUTTON_Click( object sender, EventArgs e )
		{
			if ( !userSelected ) return;

			try
			{
				System.Diagnostics.Process.Start( "http://cafe.naver.com/CafeMemberNetworkView.nhn?m=view&clubid=" + GlobalVar.CAFE_ID + "&memberid=" + selectedMemberInformation.memberID );
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				NotifyBox.Show( this, "오류", "죄송합니다, 웹 페이지를 여는 도중 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
			}
		}

		private void WARN_RUN_BUTTON_Click( object sender, EventArgs e )
		{
			if ( !userSelected )
			{
				NotifyBox.Show( this, "오류", "활동 정지 처리할 회원을 선택하세요.", NotifyBoxType.OK, NotifyBoxIcon.Warning );
				return;
			}

			if ( warnCount <= 0 || warnCount > 10 )
			{
				NotifyBox.Show( this, "오류", "경고 횟수는 1~10 사이여야 합니다.", NotifyBoxType.OK, NotifyBoxIcon.Warning );
				return;
			}

			if ( this.REASON_TEXTBOX.Text.Trim( ).Length == 0 )
			{
				NotifyBox.Show( this, "오류", "경고 진술을 작성해야 합니다.", NotifyBoxType.OK, NotifyBoxIcon.Warning );
				return;
			}

			if ( NotifyBox.Show( this, "경고", "닉네임 : " + this.nickName + "\n경고 횟수 : " + this.warnCount + "회\n진술 : " + this.REASON_TEXTBOX.Text + "\n\n모든 정보를 다시 확인하시고 확인 버튼을 눌러주세요 ^.^", NotifyBoxType.YesNo, NotifyBoxIcon.Danger ) == NotifyBoxResult.Yes )
			{
				if ( NotifyBox.Show( this, "경고", "정말로 정말로!!! " + this.nickName + " 회원에게 경고를 부여하시길 원하십니까?", NotifyBoxType.YesNo, NotifyBoxIcon.Danger ) == NotifyBoxResult.Yes )
				{
					this.WARN_RUN_BUTTON.ButtonText = "서버와 통신하는 중 ...";

					// Item1 : Success boolean;
					// Item2 : Error reason string;
					Tuple<bool, string> result = NaverRequest.WriteMemberWarningThread( nickName, warnCount, this.REASON_TEXTBOX.Text.Trim( ) );

					if ( result.Item1 )
					{
						//switch ( warnCount )
						//{
						//	case 3:
						//		ChatSendUsingHelper( "<우윳빛깔 카페스탭 경고 안내>\r\n\r\n용의자 닉네임 : " + this.nickName + "\r\n경고 횟수 : " + this.warnCount + "회\r\n진술 : " + this.REASON_TEXTBOX.Text + "\r\n\r\n경고 처리했습니다, 지정된 규정에 따라 <활동정지 7일> 처리 바랍니다. >.<~" );
						//		break;
						//	case 6:
						//		ChatSendUsingHelper( "<우윳빛깔 카페스탭 경고 안내>\r\n\r\n용의자 닉네임 : " + this.nickName + "\r\n경고 횟수 : " + this.warnCount + "회\r\n진술 : " + this.REASON_TEXTBOX.Text + "\r\n\r\n경고 처리했습니다, 지정된 규정에 따라 <활동정지 30일> 처리 바랍니다. >.o~" );
						//		break;
						//	case 10:
						//		ChatSendUsingHelper( "<우윳빛깔 카페스탭 경고 안내>\r\n\r\n용의자 닉네임 : " + this.nickName + "\r\n경고 횟수 : " + this.warnCount + "회\r\n진술 : " + this.REASON_TEXTBOX.Text + "\r\n\r\n경고 처리했습니다, 지정된 규정에 따라 <강제탈퇴> 처리 바랍니다. -.-;;" );
						//		break;
						//}

						NotifyBox.Show( this, "경고 부여 완료", "경고 부여를 성공적으로 완료했습니다, 경고 게시판 페이지가 열립니다, 아래 사항을 꼭 확인해주세요!\n\n> 다른 스탭 분들이 이미 경고를 부여했는지 여부\n> 게시물 알림을 뒤늦게 확인한 후 경고를 부여할 시 용의자 닉네임이 다를 수 있으니 닉네임 변경 여부 확인", NotifyBoxType.OK, NotifyBoxIcon.Danger );

						//ReleaseAllControls( );

						try
						{
							System.Diagnostics.Process.Start( GlobalVar.CAFE_WARNING_ARTICLE_URL );
						}
						catch ( Exception ex )
						{
							Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
							NotifyBox.Show( this, "오류", "죄송합니다, 웹 페이지를 여는 도중 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
						}

						this.Close( );
					}
					else
					{
						NotifyBox.Show( this, "오류", "죄송합니다, 경고 부여를 하는 도중 오류가 발생했습니다.\n\n" + result.Item2, NotifyBoxType.OK, NotifyBoxIcon.Error );

						//ReleaseAllControls( );

						this.WARN_RUN_BUTTON.ButtonText = "경고 부여";
					}
				}
			}
		}
	}
}
