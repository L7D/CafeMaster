using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CafeMaster_UI.Lib
{
	//static class Gate
	//{
	//	public static bool Access( string authKey )
	//	{
	//		try
	//		{
	//			//http://textuploader.com/dd3ns/raw
	//			HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( "http://textuploader.com/dd3ns/raw" );
	//			request.Method = "GET";
	//			using ( HttpWebResponse response = ( HttpWebResponse ) request.GetResponse( ) )
	//			{
	//				using ( Stream responseStream = response.GetResponseStream( ) )
	//				{
	//					using ( StreamReader reader = new StreamReader( responseStream, Encoding.Default ) )
	//					{
	//						if ( reader.ReadToEnd( ).Trim( ) == authKey )
	//						{
	//							return true;
	//						}

	//						return false;
	//					}
	//				}
	//			}
	//		}
	//		catch ( Exception )
	//		{
	//			return false;
	//		}
	//	}
	//}
}
