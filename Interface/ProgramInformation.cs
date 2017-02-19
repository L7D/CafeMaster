﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeMaster_UI.Lib;

namespace CafeMaster_UI.Interface
{
	public partial class ProgramInformation : Form
	{
		private Point startPoint;
		private Pen lineDrawer = new Pen( GlobalVar.MasterColor )
		{
			Width = 1
		};

		public ProgramInformation( )
		{
			InitializeComponent( );
		}

		private void ProgramInformation_Load( object sender, EventArgs e )
		{
			Version version = System.Reflection.Assembly.GetExecutingAssembly( ).GetName( ).Version;

			this.VERSION.Text = "버전 " + version.Major + "." + version.Minor + "." + version.Build + "." + version.Revision;
			this.COPYRIGHT_2.Text = "자른이미지 by 잰(cony****)님, on(dbxh****)님";
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
			this.Close( );
		}

		private void ProgramInformation_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // 위
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // 왼쪽
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // 오른쪽
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
		}

		private void UTIL_BUTTON1_Click( object sender, EventArgs e )
		{
			try
			{
				System.Diagnostics.Process.Start( "http://cafe.naver.com/revolution232" );
			}
			catch ( Exception )
			{
				NotifyBox.Show( null, "오류", "죄송합니다, 웹 페이지를 여는 도중 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
			}
		}
	}
}
