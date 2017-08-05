using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CafeMaster_UI.Lib
{
	static class Analysis
	{

		private static string GetThreadHTML( string threadID )
		{
			HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( "http://cafe.naver.com/ArticleRead.nhn?clubid=" + GlobalVar.CAFE_ID + "&articleid=" + threadID + "&referrerAllArticles=true" );
			request.Method = "GET";
			request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";
			request.KeepAlive = true;
			request.Referer = "http://cafe.naver.com/ArticleRead.nhn?clubid=25430492&page=1&boardtype=L&articleid=110270&referrerAllArticles=true";
			request.CookieContainer = new CookieContainer( );

			foreach ( CookieTable i in GlobalVar.COOKIES_LIST )
			{
				request.CookieContainer.Add( new Cookie( i.id, i.value, "/", request.Host ) );
			}

			using ( WebResponse res = request.GetResponse( ) )
			{
				using ( Stream responseStream = res.GetResponseStream( ) )
				{
					using ( StreamReader reader = new StreamReader( responseStream, Encoding.Default ) )
					{
						string html = reader.ReadToEnd( );

						return html;
					}
				}
			}
		}

		public static void Run( string threadID )
		{
			string html = GetThreadHTML( threadID );

			File.WriteAllText( "test.html", html, Encoding.Default );
		}
	}
}
