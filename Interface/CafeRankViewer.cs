using System;
using System.Drawing;
using System.Windows.Forms;
using CafeMaster_UI.Lib;

namespace CafeMaster_UI.Interface
{
	public partial class CafeRankViewer : Form
	{
		private Point startPoint;
		private Pen lineDrawer = new Pen( GlobalVar.MasterColor )
		{
			Width = 1
		};

		public CafeRankViewer( )
		{
			InitializeComponent( );

			this.SetStyle( ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true );
			this.UpdateStyles( );
			this.Opacity = 0;
		}
		
		private void CafeRankViewer_Load( object sender, EventArgs e )
		{
			Animation.UI.FadeIn( this );

			string html = @"<html lang='ko'>
	<head>
		<meta http-equiv='Content-type' content='text/html; charset=utf8'>
		<link rel='stylesheet' href='http://cafe.naver.com/static/css/main/css/manage/cafe_admin_pop-1481850300000-39820.css'>
		<style type='text/css'>
			/* Font override */
			
			body,input,textarea,select,button,table {
				font-family: '나눔고딕', '맑은고딕', '맑은 고딕', sans-serif;
				font-size: 12px
			}
		</style>
	</head>
<body style='margin:0; padding:15'>
	<div class='txt_top'>
		<strong>회원 등급</strong>
	</div>
	<table border='1' cellspacing='0' class='tbl_role'>
	<caption><span class='blind'>등급 목록</span></caption>
	<colgroup>
	<col width='155'>
	<col width='*'>
	</colgroup>
		<tbody>
			<tr>
			<th><strong><img src='http://cafeimgs.naver.net//levelicon/1/8_1.gif' alt='' width='11' height='11'>새싹멤버</strong></th>
			<td>
				<div class='txt_cont'>
					<p>처음 활동 시작을 한 새싹멤버</p>
				</div>
			</td>
			</tr>
			<tr>
			<th><strong><img src='http://cafeimgs.naver.net//levelicon/1/8_110.gif' alt='' width='11' height='11'>일반멤버</strong></th>
			<td>
				<div class='txt_cont'>
					<p>카페 일반 멤버</p>
					<ul>
						<li><span class='c_gn'>자동등업 :</span> 게시글수 <em>30</em>개, 댓글수 <em>100</em>개, 출석수 <em>30</em>회, 가입 <em>4</em>주 후 만족 시 등업 신청 가능</li>
					</ul>
				</div>
			</td>
			</tr>
			<tr>
			<th><strong><img src='http://cafeimgs.naver.net//levelicon/1/8_120.gif' alt='' width='11' height='11'>성실멤버</strong></th>
			<td>
				<div class='txt_cont'>
					<p>카페 성실 멤버</p>
					<ul>
						<li><span class='c_gn'>자동등업 :</span> 게시글수 <em>100</em>개, 댓글수 <em>500</em>개, 출석수 <em>300</em>회, 가입 <em>12</em>주 후 만족 시 등업 신청 가능</li>
					</ul>
				</div>
			</td>
			</tr>
			<tr>
			<th><strong><img src='http://cafeimgs.naver.net//levelicon/1/8_130.gif' alt='' width='11' height='11'>열심멤버</strong></th>
			<td>
				<div class='txt_cont'>
					<p>카페 열심 멤버</p>
					<ul>
						<li><span class='c_gn'>자동등업 :</span> 게시글수 <em>300</em>개, 댓글수 <em>1,000</em>개, 출석수 <em>700</em>회, 가입 <em>30</em>주 후 만족 시 등업 신청 가능</li>
					</ul>
				</div>
			</td>
			</tr>
			<tr>
			<th><strong><img src='http://cafeimgs.naver.net//levelicon/1/8_140.gif' alt='' width='11' height='11'>우수멤버</strong></th>
			<td>
				<div class='txt_cont'>
					<p>이전 스탭분들과 연애혁명 BGM 작곡가님들, 웹툰샵 전용 VIP 멤버</p>
				</div>
			</td>
			</tr>
			<tr class='last'>
			<th><strong><img src='http://cafeimgs.naver.net//levelicon/1/8_150.gif' alt='' width='11' height='11'>작가님</strong></th>
			<td>
				<div class='txt_cont'>
					<p>232 작가님 >.<</p>
				</div>
			</td>
			</tr>
		</tbody>
	</table>
</body>
</html>";

			this.WEB_BROWSER.DocumentText = "0";
			this.WEB_BROWSER.Document.OpenNew( true );
			this.WEB_BROWSER.Document.Write( html );
			this.WEB_BROWSER.Refresh( );
		}

		private void CLOSE_BUTTON_Click( object sender, EventArgs e )
		{
			this.Close( );
		}

		private void WEB_BROWSER_DocumentCompleted( object sender, WebBrowserDocumentCompletedEventArgs e )
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

		private void CafeRankViewer_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // 위
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // 왼쪽
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // 오른쪽
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
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
	}
}
