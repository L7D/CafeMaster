using System.IO;
using System.Media;

namespace CafeMaster_UI.Lib
{
	static class SoundNotify
	{
		public static void PlayWelcome( )
		{
			if ( !File.Exists( GlobalVar.APP_DIR + @"\sound\welcome_v2.wav" ) ) return;

			try
			{
				using ( SoundPlayer player = new SoundPlayer( GlobalVar.APP_DIR + @"\sound\welcome_v2.wav" ) )
				{
					player.Play( );
				}
			}
			catch { }
		}

		public static void PlayNotify( )
		{
			if ( !File.Exists( GlobalVar.APP_DIR + @"\sound\notify_v2.wav" ) ) return;

			try
			{
				using ( SoundPlayer player = new SoundPlayer( GlobalVar.APP_DIR + @"\sound\notify_v2.wav" ) )
				{
					player.Play( );
				}
			}
			catch { }
		}
	}
}
