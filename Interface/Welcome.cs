using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMaster_UI.Interface
{
	public partial class Welcome : Form
	{
		public Welcome( )
		{
			InitializeComponent( );
		}

		private void Welcome_Load( object sender, EventArgs e )
		{
			System.Threading.Thread close = new System.Threading.Thread( ( ) =>
			{
				System.Threading.Thread.Sleep( 2000 );

				if ( this.InvokeRequired )
				{
					this.Invoke( new Action( ( ) => this.Close( ) ) );
				}
				else
					this.Close( );
			} )
			{
				IsBackground = true
			};
			close.Start( );
		}
	}
}
