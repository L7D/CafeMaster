using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace CafeMaster_UI.Lib
{
	static class SoundNotify
	{
		static SoundNotify( )
		{

		}

		public static void PlayWelcome( )
		{
			if ( !File.Exists( GlobalVar.APP_DIR + @"\sound\welcome.wav" ) )
			{
				return;
			}

			try
			{
				using ( SoundPlayer player = new SoundPlayer( GlobalVar.APP_DIR + @"\sound\welcome.wav" ) )
				{
					player.Play( );
				}
			}
			catch ( Exception ) { }
		}

		public static void PlayNotify( )
		{
			if ( !File.Exists( GlobalVar.APP_DIR + @"\sound\notify.wav" ) )
			{
				return;
			}

			try
			{
				using ( SoundPlayer player = new SoundPlayer( GlobalVar.APP_DIR + @"\sound\notify.wav" ) )
				{
					player.Play( );
				}
			}
			catch ( Exception ) { }
		}
	}
}
