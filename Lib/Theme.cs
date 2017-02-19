using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeMaster_UI.Lib
{
	static class Theme
	{
		public static void Apply( Control imageForm, string layoutFileFormat )
		{
			if ( Directory.Exists( GlobalVar.LAYOUT_DIR ) )
			{
				try
				{
					string[ ] files = Directory.GetFiles( GlobalVar.LAYOUT_DIR, layoutFileFormat );

					if ( files.Length > 0 )
					{
						( ( PictureBox ) imageForm ).Image = new System.Drawing.Bitmap(
							Utility.FileToMemoryStream(
								files[ new Random( DateTime.Now.Second ).Next( 0, files.Length ) ]
							)
						);
					}
				}
				catch ( Exception ) { }
			}
		}
	}
}
