using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeMaster_UI.Lib;
using WinFormAnimation;

namespace CafeMaster_UI.Interface
{
	public partial class Welcome : Form
	{
		int size = 0;

		public Welcome( )
		{
			InitializeComponent( );

			this.SetStyle( ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true );
			this.UpdateStyles( );
			this.Opacity = 0;
		}

		private void Welcome_Load( object sender, EventArgs e )
		{
			
		}

		private void Welcome_Paint( object sender, PaintEventArgs e )
		{
			using ( Brush brush = new SolidBrush( Color.FromArgb( 255, 255, 130, 130 ) ) )
			{
				e.Graphics.FillRectangle( brush, 254, 236, size, 45 );
				e.Graphics.DrawImage( Properties.Resources.ResourceManager.GetObject( "WELCOME_SPLASH_V3" ) as Bitmap, 0, 0, 512, 312 );
			}
		}

		private void Welcome_Shown( object sender, EventArgs e )
		{
			Animation.UI.FadeIn( this );

			Action<float> CustomSetMethod = ( float yes ) =>
			{
				size = ( int ) yes;
				this.Invalidate( );
			};

			var animator = new Animator( new Path( 0, 123, 600 ), FPSLimiterKnownValues.LimitSixty );
			animator.Play( new SafeInvoker<float>( CustomSetMethod ), new SafeInvoker( ( ) =>
			{
				Task.Factory.StartNew( async ( ) =>
				{
					await Task.Delay( 300 );

					if ( this.InvokeRequired )
					{
						this.Invoke( new Action( ( ) => Animation.UI.FadeOut( this, true ) ) );
					}
					else
						Animation.UI.FadeOut( this, true );
				} );
			} ) );

			
		}
	}
}
