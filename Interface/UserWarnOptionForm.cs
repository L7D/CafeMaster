using CafeMaster_UI.Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMaster_UI.Interface
{
	public partial class UserWarnOptionForm : Form
	{
		private Point startPoint;
		private Pen lineDrawer = new Pen( GlobalVar.MasterColor )
		{
			Width = 1
		};

		private string nickName;
		private string onlyID;
		private int warnCount = 1;

		public UserWarnOptionForm( string nickName )
		{
			InitializeComponent( );

			this.nickName = nickName;
			this.onlyID = nickName.Substring( nickName.IndexOf( '(' ) + 1, nickName.Length - nickName.IndexOf( '(' ) - 2 );

			this.USERNICK_EXAMPLE.Text = nickName;
			this.USERNICK_TITLE.Text = "용의자 닉네임 : " + nickName;

			this.SetStyle( ControlStyles.ResizeRedraw, true );
			this.SetStyle( ControlStyles.OptimizedDoubleBuffer, true );
		}

		private void UserWarnOptionForm_Load( object sender, EventArgs e )
		{
			this.WARN_RUN_BUTTON.Enabled = false;
			this.WARNING_COUNT.Enabled = false;
			this.WARNING_COUNT_AFTERDESC.Text = "경고 횟수를 서버에서 가져오고 있습니다 ...";

			Thread thread = new Thread( ( ) =>
			  {
				  int countFetch = NaverRequest.WarnCountRequest( this.onlyID );

				  warnCount = ++countFetch;

				  Utility.SetUriCookieContainerToNaverCookies( "http://cafe.naver.com" );

				  if ( this.InvokeRequired )
				  {
					  this.Invoke( new Action( ( ) =>
					  {
						  this.WARNING_COUNT.Enabled = true;
						  this.WARNING_COUNT_AFTERDESC.Text = "";
						  this.WARNING_COUNT.Value = warnCount;
						  this.THREAD_TITLE_EXAMPLE.Text = nickName + "님 경고 (총 " + warnCount + "회)";
						  this.chatSendHelper.Navigate( new Uri( GlobalVar.CAFE_CHAT_URL ) );
						  this.WARN_RUN_BUTTON.Enabled = true;
					  } ) );
				  }
				  else
				  {
					  this.WARNING_COUNT.Enabled = true;
					  this.WARNING_COUNT_AFTERDESC.Text = "";
					  this.WARNING_COUNT.Value = warnCount;
					  this.THREAD_TITLE_EXAMPLE.Text = nickName + "님 경고 (총 " + warnCount + "회)";
					  this.chatSendHelper.Navigate( new Uri( GlobalVar.CAFE_CHAT_URL ) );
					  this.WARN_RUN_BUTTON.Enabled = true;
				  }
			  } )
			{
				IsBackground = true
			};
			thread.Start( );
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

		private void BlockAllControls( )
		{
			this.CANCEL_BUTTON.Enabled = false;
			this.REASON_TEXTBOX.Enabled = false;
			this.WARN_RUN_BUTTON.Enabled = false;
		}

		private void ReleaseAllControls( )
		{
			//nope
			//this.CANCEL_BUTTON.Enabled = false;
			//this.REASON_TEXTBOX.Enabled = false;
			//this.WARN_RUN_BUTTON.Enabled = false;
		}

		private void ChatSendUsingHelper( string message )
		{
			HtmlElement chatbox = this.chatSendHelper.Document.GetElementById( "msgInputArea" );

			if ( chatbox != null )
			{
				chatbox.InnerText = message;

				HtmlElementCollection buttons = this.chatSendHelper.Document.GetElementsByTagName( "button" );

				foreach ( HtmlElement i in buttons )
				{
					if ( i.GetAttribute( "type" ) == "button" && i.InnerText.Trim( ) == "전송" )
					{
						i.InvokeMember( "Click" );
					}
				}
			}
		}

		private void WARN_RUN_BUTTON_Click( object sender, EventArgs e )
		{
			if ( warnCount == 0 )
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

					bool success = NaverRequest.WarnThreadRequest( nickName, warnCount, this.REASON_TEXTBOX.Text.Trim( ) );

					if ( success )
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

						ReleaseAllControls( );

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
						NotifyBox.Show( this, "오류", "죄송합니다, 경고 부여를 하는 도중 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );

						ReleaseAllControls( );

						this.WARN_RUN_BUTTON.ButtonText = "경고 부여";
					}
				}
			}
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

		private void SEARCH_COUNT_BUTTON_Click( object sender, EventArgs e )
		{
			try
			{
				System.Diagnostics.Process.Start( "http://cafe.naver.com/ArticleSearchList.nhn?search.clubid=" + GlobalVar.CAFE_ID + "&search.searchdate=all&search.searchBy=0&search.query=" + onlyID + "&search.menuid=20" );
			}
			catch ( Exception ) { }
		}

		private void CANCEL_BUTTON_Click( object sender, EventArgs e )
		{
			this.Close( );
		}
	}
}
