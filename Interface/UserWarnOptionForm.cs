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

		string nickName;
		string onlyID;
		int warnCount = 1;

		public UserWarnOptionForm( string nickName )
		{
			InitializeComponent( );

			this.nickName = nickName;
			this.onlyID = nickName.Substring( nickName.IndexOf( '(' ) + 1, nickName.Length - nickName.IndexOf( '(' ) - 2 );

			this.USERNICK_EXAMPLE.Text = nickName;
			this.USERNICK_TITLE.Text = "용의자 닉네임 : " + nickName;
		}

		private void UserWarnOptionForm_Load( object sender, EventArgs e )
		{
			this.THREAD_TITLE_EXAMPLE.Text = nickName + "님 경고 (총 " + warnCount + "회)";
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
			this.REASON_TEXTBOX.Enabled = false;
			this.WARN_RUN_BUTTON.Enabled = false;
		}

		private void ReleaseAllControls( )
		{
			this.REASON_TEXTBOX.Enabled = false;
			this.WARN_RUN_BUTTON.Enabled = false;
		}

		private void WARN_RUN_BUTTON_Click( object sender, EventArgs e )
		{
			if ( this.WARNING_COUNT.Value == 0 )
			{
				NotifyBox.Show( this, "오류", "경고 횟수는 0이 될 수 없습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
				return;
			}

			if ( this.REASON_TEXTBOX.Text.Trim( ).Length == 0 )
			{
				NotifyBox.Show( this, "오류", "경고 사유를 작성하세요.", NotifyBoxType.OK, NotifyBoxIcon.Error );
				return;
			}

			if ( NotifyBox.Show( this, "경고", "경고를 부여하기 전 모든 정보를 다시 확인하십시오, 확인을 하셨으면 확인 버튼을 눌러주세요.", NotifyBoxType.YesNo, NotifyBoxIcon.Warning ) == NotifyBoxResult.Yes )
			{
				if ( NotifyBox.Show( this, "경고", "정말로 really 혼또니 경고를 부여하시겠습니까 ???", NotifyBoxType.YesNo, NotifyBoxIcon.Warning ) == NotifyBoxResult.Yes )
				{

					this.WARN_RUN_BUTTON.ButtonText = "서버에 요청하는 중 ...";

					bool success = NaverRequest.WarnThreadRequest( nickName, warnCount, this.REASON_TEXTBOX.Text.Trim( ) );

					if ( success )
					{
						NotifyBox.Show( this, "완료", "경고 부여를 성공적으로 완료했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Information );

						ReleaseAllControls( );

						try
						{
							System.Diagnostics.Process.Start( "http://cafe.naver.com/ArticleList.nhn?search.clubid=" + GlobalVar.CAFE_ID + "&search.menuid=20&search.boardtype=L" );
						}
						catch ( Exception ) { }

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
	}
}
