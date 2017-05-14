﻿using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using CafeMaster_UI.Lib;

namespace CafeMaster_UI.Interface
{
	public partial class MemberActivityStopForm : Form
	{
		private Point startPoint;
		private Pen lineDrawer = new Pen( GlobalVar.MasterColor )
		{
			Width = 1
		};
		private MemberInformationStruct selectedMemberInformation;

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
					this.USER_SEARCH_BUTTON.Visible = false;
					this.USER_SEARCH_DESC.Visible = false;
					this.USER_SEARCH_TITLE.Visible = false;

					this.STOP_INFORMATION_PANEL.Visible = true;

					this.USER_SEARCH_BUTTON.Text = "ID 검색";
					this.USER_SEARCH_BUTTON.Enabled = true;

					this.ACTIVITY_STOP_RUN_BUTTON.Enabled = true;

					this.USER_INFORMATION_PANEL.Visible = true;
					this.USER_INFORMATION_PANEL_TITLE.Text = "선택된 회원";

					this.USERNAME_LABEL.Text = selectedMemberInformation.nickName + "(" + selectedMemberInformation.memberID + ")";
					this.RANK_LABEL.Text = selectedMemberInformation.rank;

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
					this.USER_SEARCH_DESC.Visible = true;
					this.USER_SEARCH_TITLE.Visible = true;

					this.USER_SEARCH_BUTTON.Text = "회원 검색";
					this.USER_SEARCH_BUTTON.Enabled = true;

					this.ACTIVITY_STOP_RUN_BUTTON.Enabled = false;

					this.STOP_INFORMATION_PANEL.Visible = false;

					this.USER_INFORMATION_PANEL.Visible = false;
					this.USER_INFORMATION_PANEL_TITLE.Text = "회원 선택";

					this.USERNAME_LABEL.Text = "NULL(NULL)";
					this.RANK_LABEL.Text = "NULL";

					this.PROFILE_IMAGE_ICON.Image = null;
					this.PERSONACON_IMAGE_ICON.Image = null;
				}
			}
		}

		public MemberActivityStopForm( )
		{
			InitializeComponent( );

			this.SetStyle( ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true );
			this.UpdateStyles( );
			this.Opacity = 0;
		}

		public MemberActivityStopForm( string id )
		{
			InitializeComponent( );

			this.SetStyle( ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true );
			this.UpdateStyles( );
			this.Opacity = 0;

			this.externalSearchString = id;
		}

		private void UserWarnOptionForm_Load( object sender, EventArgs e )
		{
			Animation.UI.FadeIn( this );

			Utility.SetUriCookieContainerToNaverCookies( "http://cafe.naver.com" );

			this.USER_SEARCH_TEXTBOX.Focus( );

			userSelected = false;

			this.STOP_INFORMATION_PANEL.Parent = BACKGROUND_SPLASH;
			this.USER_INFORMATION_PANEL.Parent = BACKGROUND_SPLASH;

			if ( !string.IsNullOrEmpty( externalSearchString ) )
			{
				this.USER_SEARCH_TEXTBOX.Text = externalSearchString;
				this.USER_SEARCH_BUTTON_Click( null, EventArgs.Empty );
			}
		}

		public void ExternalSearch( string id )
		{

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
				NotifyBox.Show( this, "오류", "셀프 활동 정지는 불가능합니다!", NotifyBoxType.OK, NotifyBoxIcon.Warning );
				return;
			}

			if ( GlobalVar.ADMINS[ id ] != null )
			{
				NotifyBox.Show( this, "오류", "다른 스탭분들께 활동 정지를 주는 행위는 불가능합니다!", NotifyBoxType.OK, NotifyBoxIcon.Warning );
				return;
			}

			this.USER_SEARCH_TEXTBOX.Enabled = false;
			this.USER_SEARCH_BUTTON.Text = "서버에 요청하는 중 ...";
			this.USER_SEARCH_BUTTON.Enabled = false;

			Thread thread = new Thread( ( ) =>
			{
				if ( NaverRequest.CheckMemberExistsSimple( id ) )
				{
					MemberInformationStruct? info = NaverRequest.GetMemberInformation( id );

					if ( info.HasValue )
					{
						if ( this.InvokeRequired )
						{
							this.Invoke( new Action( ( ) =>
							{
								selectedMemberInformation = info.Value;
								userSelected = true;
							} ) );
						}
						else
						{
							selectedMemberInformation = info.Value;
							userSelected = true;
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
			} )
			{
				IsBackground = true
			};
			thread.Start( );
		}

		private void ACTIVITY_STOP_RUN_BUTTON_Click( object sender, EventArgs e )
		{
			if ( !userSelected )
			{
				NotifyBox.Show( this, "오류", "활동 정지 처리할 회원을 선택하세요.", NotifyBoxType.OK, NotifyBoxIcon.Warning );
				return;
			}

			if ( this.REASON_TEXTBOX.Text.Trim( ).Length <= 0 )
			{
				NotifyBox.Show( this, "오류", "활동 정지 처리하는 사유를 입력하세요.", NotifyBoxType.OK, NotifyBoxIcon.Warning );
				return;
			}

			if ( NotifyBox.Show( this, "경고", selectedMemberInformation.nickName + "( " + selectedMemberInformation.memberID + " ) 회원을 " + ( this.UNLIMITED_LENGTH_CHECKBOX.Checked == true ? "영구적으로" : ( ( ( int ) this.STOP_LENGTH.Value ) + "일 간" ) ) + " 활동 정지 처리하시겠습니까?\n\n모든 정보를 다시 확인하시고 확인 버튼을 눌러주세요 ^.^", NotifyBoxType.YesNo, NotifyBoxIcon.Danger ) == NotifyBoxResult.Yes )
			{
				if ( NotifyBox.Show( this, "경고", "정말로 정말로!!! " + selectedMemberInformation.nickName + "(" + selectedMemberInformation.memberID + ") 회원을 활동 정지하시길 원하십니까?", NotifyBoxType.YesNo, NotifyBoxIcon.Danger ) == NotifyBoxResult.Yes )
				{
					this.SELECT_RESET_BUTTON.Enabled = false;
					this.REASON_TEXTBOX.Enabled = false;
					this.STOP_LENGTH.Enabled = false;
					this.UNLIMITED_LENGTH_CHECKBOX.Enabled = false;
					this.CANCEL_BUTTON.Enabled = false;

					Thread thread = new Thread( ( ) =>
					{
						bool alreadyStopped;

						if ( NaverRequest.ExecuteMemberStopActivity( selectedMemberInformation.memberID,
							this.UNLIMITED_LENGTH_CHECKBOX.Checked == true ? 0 : ( ( int ) this.STOP_LENGTH.Value ),
							this.REASON_TEXTBOX.Text.Trim( ),
							out alreadyStopped
						) )
						{
							Utility.OpenWebPage( GlobalVar.CAFE_STOP_ACTIVITY_LIST_URL, this );
							if ( alreadyStopped )
								NotifyBox.Show( this, "활동 정지 불가", "활동 정지 처리를 할 수 없습니다, 이미 활동 정지 처리된 회원입니다.", NotifyBoxType.OK, NotifyBoxIcon.Warning );
							else
								NotifyBox.Show( this, "활동 정지 완료", "활동 정지 처리를 성공적으로 완료했습니다, 활동 정지 회원 목록 페이지가 열립니다, 꼭 처리사항을 다시 확인하세요.", NotifyBoxType.OK, NotifyBoxIcon.Danger );

							if ( this.InvokeRequired )
							{
								this.Invoke( new Action( ( ) =>
								{
									this.Close( );
								} ) );
							}
							else
							{
								this.Close( );
							}
						}
						else
						{
							if ( this.InvokeRequired )
							{
								this.Invoke( new Action( ( ) =>
								{
									this.SELECT_RESET_BUTTON.Enabled = true;
									this.REASON_TEXTBOX.Enabled = true;
									this.STOP_LENGTH.Enabled = true;
									this.UNLIMITED_LENGTH_CHECKBOX.Enabled = true;
									this.CANCEL_BUTTON.Enabled = true;
								} ) );
							}
							else
							{
								this.SELECT_RESET_BUTTON.Enabled = true;
								this.REASON_TEXTBOX.Enabled = true;
								this.STOP_LENGTH.Enabled = true;
								this.UNLIMITED_LENGTH_CHECKBOX.Enabled = true;
								this.CANCEL_BUTTON.Enabled = true;
							}

							NotifyBox.Show( this, "오류", "죄송합니다, 활동 정지 처리를 하는 도중 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
						}
					} )
					{
						IsBackground = true
					};
					thread.Start( );
				}
			}
		}

		private void USER_SEARCH_TEXTBOX_KeyDown( object sender, KeyEventArgs e )
		{
			if ( e.KeyCode == Keys.Enter )
			{
				this.USER_SEARCH_BUTTON_Click( null, EventArgs.Empty );
				e.Handled = true;
			}
		}

		private void UNLIMITED_LENGTH_CHECKBOX_CheckedChanged( object sender, EventArgs e )
		{
			if ( this.UNLIMITED_LENGTH_CHECKBOX.Checked )
			{
				this.STOP_LENGTH.Enabled = false;
			}
			else
			{
				this.STOP_LENGTH.Enabled = true;
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
	}
}
