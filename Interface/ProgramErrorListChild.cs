using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMaster_UI.Interface
{
	public partial class ProgramErrorListChild : UserControl
	{
		private Pen lineDrawer = new Pen( Color.OrangeRed )
		{
			Width = 1
		};

		public ProgramErrorListChild( Exception ex )
		{
			InitializeComponent( );

			this.SetStyle( ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true );
			this.UpdateStyles( );

			this.ERROR_TITLE.Text = ex.Message;
			this.ERROR_STACK.Text = ex.StackTrace;
			this.ERROR_CODE.Text = "0x" + ex.HResult;

			MessageBox.Show( 	ex.StackTrace );

			this.Height = this.ERROR_TITLE.Bottom + this.ERROR_STACK.Height + 20;
		}

		private void ProgramErrorListChild_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			//e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // 위
			//e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // 왼쪽
			//e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // 오른쪽
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
		}

		private void COPY_TEXT_BUTTON_Click( object sender, EventArgs e )
		{
			// 수정 바람
			Clipboard.SetText( "TEST" );
		}
	}
}
