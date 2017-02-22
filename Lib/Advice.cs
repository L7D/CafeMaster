using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using HtmlAgilityPack;

namespace CafeMaster_UI.Lib
{
	//static class Advice
	//{
	//	struct RuleMaster
	//	{
	//		public AdviceRuleType ruleType;
	//		public List<Func<string, bool>> checkes;
	//	}

	//	public enum AdviceRuleType
	//	{
	//		Nickname
	//	}

	//	static Advice( )
	//	{
	//		//CreateRule( AdviceRuleType.Nickname );
	//		//AddRuleCodes( AdviceRuleType.Nickname, new Func<string, bool>( ( string text ) =>
	//		//	 {

	//		//		 return true;
	//		//	 } ) );
	//	}

	//	private static Hashtable rules = new Hashtable( );

	//	public static void CheckThread( NotifyData data )
	//	{
	//		lock ( typeof( Advice ) )
	//		{
	//			string url = "http://cafe.naver.com/ArticleRead.nhn?clubid=" + GlobalVar.CAFE_ID + "&articleid=" + data.threadNumber;

	//			try
	//			{
	//				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( url );
	//				request.Method = "GET";
	//				request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";
	//				request.CookieContainer = new CookieContainer( );

	//				foreach ( CookieTable i in GlobalVar.COOKIES_LIST )
	//				{
	//					request.CookieContainer.Add( new Cookie( i.id, i.value, "/", request.Host ) );
	//				}

	//				using ( WebResponse res = request.GetResponse( ) )
	//				{
	//					using ( Stream responseStream = res.GetResponseStream( ) )
	//					{
	//						using ( StreamReader reader = new StreamReader( responseStream, Encoding.Default ) )
	//						{
	//							string html = reader.ReadToEnd( );

	//							HtmlDocument document = new HtmlDocument( );
	//							document.LoadHtml( html );

	//							string threadText = "";

	//							foreach ( HtmlNode i in document.DocumentNode.SelectNodes( "//div" ) )
	//							{
	//								if ( i.GetAttributeValue( "id", "" ) == "tbody" )
	//								{
	//									threadText = HttpUtility.HtmlDecode( i.InnerText.Trim( ) );
	//									//File.WriteAllText( "test.txt", );

	//									break;
	//								}
	//							}

	//							//bool success = RunRuleChecker( AdviceRuleType.Nickname, data.threadAuthor );

	//							//if ( !success )
	//							//{

	//							//}
	//							//RunRuleChecker( threadText );
	//						}
	//					}
	//				}
	//			}
	//			catch ( Exception )
	//			{

	//			}
	//		}
	//	}

	//	public static void CreateRule( AdviceRuleType type )
	//	{
	//		RuleMaster data = new RuleMaster( );
	//		data.ruleType = type;

	//		rules.Add( type, data );
	//	}

	//	public static void AddRuleCodes( AdviceRuleType type, Func<string, bool> func )
	//	{
	//		if ( rules[ type ] != null )
	//		{
	//			RuleMaster dataFinder = ( RuleMaster ) rules[ type ];

	//			dataFinder.checkes.Add( func );
	//		}
	//	}

	//	private static bool RunRuleChecker( AdviceRuleType type, string value )
	//	{
	//		if ( rules[ type ] != null )
	//		{
	//			RuleMaster dataFinder = ( RuleMaster ) rules[ type ];

	//			foreach ( var i in dataFinder.checkes )
	//			{
	//				bool successCheck = i.Invoke( value );

	//				if ( !successCheck )
	//				{
	//					return false;
	//				}
	//			}

	//			return true;
	//		}
	//		else
	//		{
	//			return false;
	//		}
	//	}
	//}
}