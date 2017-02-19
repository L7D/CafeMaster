using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CafeMaster_UI.Lib
{
	static class Update
	{
		public static bool Check( )
		{
			try
			{
				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( "http://textuploader.com/d1tuo/raw" );
				request.Method = "GET";

				using ( HttpWebResponse response = ( HttpWebResponse ) request.GetResponse( ) )
				{
					using ( Stream responseStream = response.GetResponseStream( ) )
					{
						using ( StreamReader reader = new StreamReader( responseStream ) )
						{
							string currentVersion = reader.ReadToEnd( );
							Version version = System.Reflection.Assembly.GetExecutingAssembly( ).GetName( ).Version;

							return currentVersion != ( version.Major + "." + version.Minor + "." + version.Build + "." + version.Revision );
						}
					}
				}
			}
			catch ( Exception )
			{
				return false;
			}
		}
	}
}
