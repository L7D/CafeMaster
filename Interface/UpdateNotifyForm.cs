using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CafeMaster_UI.Lib;
using static CafeMaster_UI.Lib.ProgramValidation;

namespace CafeMaster_UI.Interface
{
	public partial class UpdateNotifyForm : Form
	{
		private Point startPoint;
		private Pen lineDrawer = new Pen( GlobalVar.MasterColor )
		{
			Width = 1
		};
		private UpdateResultStruct versionInfo;

		public UpdateNotifyForm( UpdateResultStruct versionInfo )
		{
			InitializeComponent( );

			this.SetStyle( ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true );
			this.UpdateStyles( );
			this.Opacity = 0;
			this.versionInfo = versionInfo;
		}

		private void UpdateNotifyForm_Load( object sender, EventArgs e )
		{
			Animation.UI.FadeIn( this );
			string[ ] base64IconString =
			{
				"data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAMAAABEpIrGAAAAA3NCSVQICAjb4U/gAAAACXBIWXMAAAjcAAAI3AGf6F88AAAAGXRFWHRTb2Z0d2FyZQB3d3cuaW5rc2NhcGUub3Jnm+48GgAAAFRQTFRF////SbZtQL9gQLVgR61cRLBbQq9bRLBdRLBbQ7BcQ7BcRLBcQ69cQ7BcQ7BcQ7BcQ7BcQ7BcVbdrVbhsdsWId8aJm9WontarteC+t+HAueLC5fToOJhbZQAAABF0Uk5TAAcIGBktSYSXmMHI2uPy8/XVqDFbAAAAuUlEQVQ4y4WT1wKDIAxF42ILptUO/f//rBVXHOQ+ATlAJsCqTGjjQnBGiwzOKpXHVV6VB3MuGyRqZL63FxZPssVmr2q8UF2t9y/tIzG/kVu8kY1+yP3Z47nfySk+4v/3Q2L5R6vIq31PtmrMn08BPgOBKQAF6DSgwaQBAy4NOAhx0fZRwzAvungeFqA7Au0CsF+wTrJhsoliU80W61BuCkzlpg3zep8ahm85tmn5tucHhx89fnjvx/8HcSQ3Aor/FTcAAAAASUVORK5CYII=",
				"data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAMAAABEpIrGAAAAA3NCSVQICAjb4U/gAAAACXBIWXMAAADhAAAA4QFwGBwuAAAAGXRFWHRTb2Z0d2FyZQB3d3cuaW5rc2NhcGUub3Jnm+48GgAAAN5QTFRF/////9tJ/99g/9Vg/8xc/9Jb/9Jb/9Fb/9Bb/9Bb/89b/9Bb/9Bb/9Bb/9Bb/9Bb/9Bbi4RdjoZdlYtdmI1dqphcxIRaz7Bc0LFc0LJc2Ldc5HhZ56la7MNb8VQ/8YlZ8shb88hb9Mlb9XlH94pL+HNL+q58+q59+s1b+39R+65T/cJY/n9X/rdY/3BY/3VY/3ZY/31Y/39Y/4Vx/4ZZ/4xZ/45Z/499/5ZZ/7la/8Bm/8Zb/8hb/8tb/81b/89b/9Bb/9Fd/9Fe/9Ff/9Rq/9Vs/9Zw/9dy/+Od/+SgH77DTgAAABF0Uk5TAAcIGBktSYSXmMHI2uPy8/XVqDFbAAABW0lEQVQ4y41T53rCMAw0K4tACHsGymiZYRNGAEH3+79QU2PLLrQfvT+2pbMtnSRCECFFN0zLMg1dCZFbRLUkIJJa9ModVlPwAyk1LPsjcbhBPCL8sQT8gkQM7zP/+f1Ml7cTY7A3wvj+6fMF4PXjhL9c4lDFq8+PrdbTWZxVmp8Uf9sJ0JZy+c5WE+eBQzEQFi3QT9Kn73R6vY7TlxQLEUVKbDR0AwxHkkkhOtvlmrCfuRSzPTRzzKwTg+3sGqxchhXUbGY2iMl26UzeReQzaWY2icV2D+W6INTLDWa2kAAwFYQpGi38Anzqms/p4gN+wYOEDfV4Hl02gEHyNGEnE3bcqktCTQRhIgnFpS5lK4JQyZZQal4su1AVhGrBxmLxcgdKLjlhyZWk5WYNU+yCv7gQFj50i6JhpJY7rMeeN14frloOmzbAcbs94iER+W/b3x+c+6N3f3j/Hv8v2dSobBQwOzEAAAAASUVORK5CYII="
			};
			string baseListHTML = @"<tr>
			<th><strong><img src='&base64ImageCode' alt='' width='32' height='32'>&updateTypeString</strong></th>
			<td>
				<div class='txt_cont'>
					<p>&updateText</p>
				</div>
			</td>
			</tr>
			<tr>
			<tr>";

			string baseHTML = @"<html lang='ko'>
	<head>
		<meta http-equiv='Content-type' content='text/html; charset=utf8'>
		<link rel='stylesheet' href='http://cafe.naver.com/static/css/main/css/manage/cafe_admin_pop-1481850300000-39820.css'>
		<style type='text/css'>
			/* CSS 스타일 오버라이드 */
			
			body,input,textarea,select,button,table {
				font-family: '나눔고딕', '맑은고딕', '맑은 고딕', sans-serif;
				font-size: 12px
			}
			
			.txt_top {
				font-size: 15px;
			}
			
			.tbl_role {
				margin-top: 10px;
			}
			
			.tbl_role th {
				height: 50px;
			}
		</style>
	</head>
<body style='margin:0; padding:15'>
	<div class='txt_top'>
		<strong>업데이트 내역</strong>
	</div>
	<table border='1' cellspacing='0' class='tbl_role'>
	<caption><span class='blind'>업데이트 내역 목록</span></caption>
	<colgroup>
	<col width='155'>
	<col width='*'>
	</colgroup>
		<tbody>
				&updateListHTML
		</tbody>
	</table>
</body>
</html>";

			StringBuilder sb = new StringBuilder( );

			foreach ( PatchNoteNode i in this.versionInfo.patchNote )
			{
				StringBuilder sbChild = new StringBuilder( baseListHTML );

				if ( base64IconString.Length > i.patchType )
				{
					sbChild.Replace( "&base64ImageCode", base64IconString[ i.patchType ] );

					switch ( i.patchType )
					{
						case 0:
							sbChild.Replace( "&updateTypeString", "기능 추가" );
							break;
						case 1:
							sbChild.Replace( "&updateTypeString", "버그 수정" );
							break;
					}
				}
				else
				{
					sbChild.Replace( "&base64ImageCode", "" );
					sbChild.Replace( "&updateTypeString", "기타" );
				}

				sbChild.Replace( "&updateText", i.text );

				sb.Append( sbChild );
			}

			baseHTML = baseHTML.Replace( "&updateListHTML", sb.ToString( ) );

			this.PATCH_NOTE_BROWSER.DocumentText = "0";
			this.PATCH_NOTE_BROWSER.Document.OpenNew( true );
			this.PATCH_NOTE_BROWSER.Document.Write( baseHTML );
			this.PATCH_NOTE_BROWSER.Refresh( );

			this.TITLE_2_LABEL.Text = this.versionInfo.latestVersion + " 버전으로 지금 바로 업데이트 하세요.";

			this.CenterToParent( );
		}

		private void CLOSE_BUTTON_Click( object sender, EventArgs e )
		{
			if ( NotifyBox.Show( this, "업데이트 권장", "우윳빛깔 카페스탭을 지금 업데이트 하는 것을 권장합니다, 정말로 취소하시겠습니까?", NotifyBoxType.YesNo, NotifyBoxIcon.Question ) == NotifyBoxResult.Yes )
			{
				Animation.UI.FadeOut( this, true );
			}
		}

		private void APP_TITLE_BAR_Paint( object sender, PaintEventArgs e )
		{
			int w = this.APP_TITLE_BAR.Width, h = this.APP_TITLE_BAR.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // 위
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // 왼쪽
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // 오른쪽
			//e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
		}

		private void UpdateNotifyForm_Paint( object sender, PaintEventArgs e )
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

		private void PATCH_NOTE_BROWSER_DocumentCompleted( object sender, WebBrowserDocumentCompletedEventArgs e )
		{

		}

		private void IGNORE_NOTIFY_CHECKBOX_StatusChanged( object sender, EventArgs e )
		{

		}

		private void CLOSE_BUTTON_TWO_Click( object sender, EventArgs e )
		{
			Animation.UI.FadeOut( this, true );
			//if ( NotifyBox.Show( this, "업데이트 권장", "우윳빛깔 카페스탭을 지금 업데이트 하는 것을 권장합니다, 정말로 취소하시겠습니까?", NotifyBoxType.YesNo, NotifyBoxIcon.Question ) == NotifyBoxResult.Yes )
			//{
			//	Animation.UI.FadeOut( this, true );
			//}
		}

		private void UPDATE_URL_OPEN_BUTTON_Click( object sender, EventArgs e )
		{
			Utility.OpenWebPage( this.versionInfo.updateURL, this );
			Animation.UI.FadeOut( this, true );
		}
	}
}
