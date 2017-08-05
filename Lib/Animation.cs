using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormAnimation;
using System.Windows.Forms;

namespace CafeMaster_UI.Lib
{
	static class Animation
	{
		//public static class UI
		//{
		//	public static void FadeIn( Form form )
		//	{
		//		Animation.NumberSmoothEffect( 0, 10, ( float alpha ) =>
		//		{
		//			if ( form == null || form.IsDisposed || form.Disposing ) return;

		//			form.Opacity = alpha / 10;
		//			form.Invalidate( );
		//		}, ( float alpha ) =>
		//		{
		//			if ( form == null || form.IsDisposed || form.Disposing ) return;

		//			form.Opacity = 1;
		//			form.Invalidate( );
		//		}  );
		//	}

		//	public static void FadeOut( Form form, bool closeAfterFadeOut )
		//	{
		//		Animation.NumberSmoothEffect( 10, 0, ( float alpha ) =>
		//		{
		//			if ( form == null || form.IsDisposed || form.Disposing ) return;

		//			form.Opacity = alpha / 10;
		//			form.Invalidate( );


		//		}, ( float alpha ) =>
		//		{
		//			if ( form == null || form.IsDisposed || form.Disposing ) return;

		//			if ( closeAfterFadeOut && ( int ) alpha == 0 )
		//			{
		//				form.Close( );
		//			}
		//		} );
		//	}

		//	public static void FadeOutShutdown( Form form )
		//	{
		//		Animation.NumberSmoothEffect( 100, 0, ( float alpha ) =>
		//		{
		//			if ( form == null || form.IsDisposed || form.Disposing ) return;

		//			form.Opacity = alpha / 100;
		//			form.Invalidate( );

		//			if ( ( int ) alpha == 0 )
		//			{
		//				Application.Exit( );
		//			}
		//		} );
		//	}
		//}

		public static class UI
		{
			public static void FadeIn( Form form, Action callBack = null )
			{
				form.Opacity = 0;
				//callBack?.Invoke( );
				Action<float> CustomSetMethod = ( float yes ) =>
				{
					form.Opacity = yes;
				};

				var animator = new Animator( new Path( 0, 1, 250 ), FPSLimiterKnownValues.LimitSixty );
				animator.Play( new SafeInvoker<float>( CustomSetMethod ), new SafeInvoker( ( ) =>
				{
					callBack?.Invoke( );
				} ) );

				//Animation.NumberSmoothEffect( 0, heightTemp, ( float newHeight ) =>
				//{
				//	if ( form == null || form.IsDisposed || form.Disposing ) return;

				//	form.Height = ( int ) newHeight;
				//	form.Refresh( );
				//}, ( float newHeight ) =>
				//{
				//	form.Height = heightTemp;
				//	form.Refresh( );
				//} );

				//Animation.NumberSmoothEffect( 0, 10, ( float alpha ) =>
				//{
				//	if ( form == null || form.IsDisposed || form.Disposing ) return;

				//	form.Opacity = alpha / 10;
				//	form.Invalidate( );
				//}, ( float alpha ) =>
				//{
				//	if ( form == null || form.IsDisposed || form.Disposing ) return;

				//	form.Opacity = 1;
				//	form.Invalidate( );
				//} );
			}

			public static void FadeOut( Form form, bool closeAfterFadeOut )
			{
				Action<float> CustomSetMethod = ( float yes ) =>
				{
					form.Opacity = yes;
				};

				var animator = new Animator( new Path( ( float ) form.Opacity, 0, 250 ), FPSLimiterKnownValues.LimitSixty );
				animator.Play( new SafeInvoker<float>( CustomSetMethod ), new SafeInvoker( ( ) =>
				{
					if ( form == null || form.IsDisposed || form.Disposing ) return;

					if ( closeAfterFadeOut )
						form.Close( );
				} ) );
			}

			public static void FadeOutShutdown( Form form )
			{
				Animation.NumberSmoothEffect( 100, 0, ( float alpha ) =>
				{
					if ( form == null || form.IsDisposed || form.Disposing ) return;

					form.Opacity = alpha / 100;
					form.Invalidate( );

					if ( ( int ) alpha == 0 )
					{
						Application.Exit( );
					}
				} );
			}
		}


		public static void NumberSmoothEffect( int start, int end, Action<float> Callback, Action<float> AnimationEnd = null )
		{
			float val = start;

			System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer( )
			{
				Interval = 10
			};
			animationTimer.Tick += ( object sender, EventArgs e ) =>
			{
				if ( Math.Round( val ) == end )
				{
					animationTimer.Stop( );
					AnimationEnd?.Invoke( end );
					return;
				}

				val = Utility.Lerp( val, end, 0.8F );
				Callback.Invoke( val );
			};

			animationTimer.Start( );
		}
	}
}
