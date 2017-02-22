using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CafeMaster_UI.Lib
{
	struct ThreadDetailStruct
	{
		public string threadTime;
		public string threadAuthor;
		public string personaconURL;
		public string articleName;
	}

	struct NaverAccountInformation
	{
		public string nickName;
		public string email;
		public string iconURL;
		public bool isOnline;

		public NaverAccountInformation( string nickName, string email, string iconURL, bool isOnline )
		{
			this.nickName = nickName;
			this.email = email;
			this.iconURL = iconURL;
			this.isOnline = isOnline;
		}
	}

	static class NaverRequest
	{
		public enum RequestMethod
		{
			GET,
			POST
		}

		public enum NaverLoginResult
		{
			Success,
			IDorPWDError,
			SecurityBlocked,
			RequestError
		}

		//[Obsolete( "이 메소드는 사용할 수 없습니다." )]
		//public static int WarnCountRequest( string id )
		//{
		//	string url = "http://cafe.naver.com/ArticleSearchList.nhn?search.clubid=" + GlobalVar.CAFE_ID + "&search.searchdate=all&search.searchBy=0&search.query=" + id + "&search.menuid=20";

		//	try
		//	{
		//		HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( url );
		//		request.Method = "GET";
		//		request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";
		//		request.CookieContainer = new CookieContainer( );

		//		foreach ( CookieStruct i in GlobalVar.COOKIES_LIST )
		//		{
		//			request.CookieContainer.Add( new Cookie( i.id, i.value, "/", request.Host ) );
		//		}

		//		using ( WebResponse res = request.GetResponse( ) )
		//		{
		//			using ( Stream responseStream = res.GetResponseStream( ) )
		//			{
		//				using ( StreamReader reader = new StreamReader( responseStream, Encoding.Default ) )
		//				{
		//					string html = reader.ReadToEnd( );

		//					HtmlDocument document = new HtmlDocument( );
		//					document.LoadHtml( html );

		//					int count = 0;
		//					foreach ( HtmlNode i in document.DocumentNode.SelectNodes( "//tr" ) )
		//					{
		//						if ( i.GetAttributeValue( "align", "" ) == "center" && i.GetAttributeValue( "class", "" ) != "bg-color" )
		//						{
		//							count++;
		//						}
		//					}

		//					return count;
		//				}
		//			}
		//		}
		//	}
		//	catch ( Exception )
		//	{
		//		return 0;
		//	}
		//}

		private static string GetPersonaconID( )
		{
			string url = "http://cafe.naver.com/ArticleWrite.nhn?clubid=25430492&menuid=&boardtype=L&m=write";

			try
			{
				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( url );
				request.Method = "GET";
				request.KeepAlive = true;
				request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";
				request.CookieContainer = new CookieContainer( );

				foreach ( CookieTable i in GlobalVar.COOKIES_LIST )
				{
					request.CookieContainer.Add( new System.Net.Cookie( i.id, i.value, "/", request.Host ) );
				}

				using ( WebResponse res = request.GetResponse( ) )
				{
					using ( Stream responseStream = res.GetResponseStream( ) )
					{
						using ( StreamReader reader = new StreamReader( responseStream, Encoding.Default ) )
						{
							string html = reader.ReadToEnd( );

							HtmlDocument document = new HtmlDocument( );
							document.LoadHtml( html );

							//string cafeTempId = "";
							//string branchCode = "";
							string personacon = "";

							int count = 0;
							foreach ( HtmlNode i in document.DocumentNode.SelectNodes( "//input" ) )
							{
								if ( i.GetAttributeValue( "type", "" ) == "hidden" )
								{
									switch ( count )
									{
										//case 3: // cafeTempId
										//	cafeTempId = i.GetAttributeValue( "value", "" );
										//	break;
										//case 4: // branchCode
										//	branchCode = i.GetAttributeValue( "value", "" );
										//	break;
										case 7: // personacon
											personacon = i.GetAttributeValue( "value", "" );
											break;
									}

									count++;
								}
							}

							return personacon;
						}
					}
				}
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				return "";
			}
		}

		public static bool WarnThreadRequest( string nickName, int warnCount, string reason )
		{
			string personacon = GetPersonaconID( );

			string data = @"clubid=" + GlobalVar.CAFE_ID + "&menuidForList=20&type=&typeOriginal=&personacon=" + personacon + "&boardtype=L&page=1&m=write&attachpollyn=&attachPollids=&attachfileyn=&attachimageyn=&attachfiles=&attachsizerealsum=0&attachmodifylist=&attachsizes=&attachimagesizesum=0&attachfilesizesum=0&scrapedyn=&attachinfolist=&attachinfo=0&attachmaplist=&attachmovie=&attachmovielist=&article.leveragecode=0&article.attachCalendarList=&attachCalendar=&attachedCalendar=&tempsaveid=5&owfs=false&ndriveid=0&hadNaverPoll=&article.attachMusic=&appPost=&parameterString=&representImagePath=&menuid=20&headid=&tagnames=&openyn=N&replyyn=N&scrapyn=N&metoo=false&rclick=0&videoLink=false&autosourcing=0&ccl=0&rows_val=4&cols_val=4&border_val=1&borderColorCode=%23B7BBB5&backColorCode=%23FFFFFF&keyword=&keyword_re=&replace=&article.templatecode=0&subject=#SUBJECT&content=#CONTENT";
			string url = "http://m.cafe.naver.com/ArticlePost.nhn";

			try
			{
				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( url );
				request.Method = "POST";
				request.Host = "m.cafe.naver.com";
				request.ProtocolVersion = HttpVersion.Version11;
				request.ContentType = "application/x-www-form-urlencoded";
				request.Headers.Add( HttpRequestHeader.CacheControl, "max-age=0" );
				request.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2785.116 Safari/537.36";
				request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
				request.Headers.Add( "Origin", "http://m.cafe.naver.com" );
				request.Headers.Add( "DNT", "1" );
				request.Headers.Add( "Upgrade-Insecure-Requests", "1" );
				request.Headers.Add( HttpRequestHeader.AcceptLanguage, "ko-KR,ko;q=0.8,en-US;q=0.6,en;q=0.4" );
				request.Referer = "http://m.cafe.naver.com/ArticleWrite.nhn?m=write&clubid=" + GlobalVar.CAFE_ID + "&menuid=";
				request.CookieContainer = new CookieContainer( );
				request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";

				foreach ( CookieTable i in GlobalVar.COOKIES_LIST )
				{
					request.CookieContainer.Add( new Cookie( i.id, i.value, "/", request.Host ) );
				}

				data = data.Replace( "#SUBJECT", HttpUtility.UrlEncode(
					nickName + "님 경고 (총 " + warnCount + "회)",
					Encoding.UTF8 )
				);
				data = data.Replace( "#CONTENT", HttpUtility.UrlEncode( @"<div class='NHN_Writeform_Main'><p></p><p>용의자 닉네임 : " + nickName + "</p><p></p><p></p><p><br></p><p>진술 : " + reason + "</p></div>", Encoding.UTF8 ) );

				byte[ ] byteArray = Encoding.UTF8.GetBytes( data );

				request.ContentLength = byteArray.Length;

				Stream dataStream = request.GetRequestStream( );
				dataStream.Write( byteArray, 0, byteArray.Length );
				dataStream.Close( );

				using ( WebResponse res = request.GetResponse( ) )
				{
					using ( Stream responseStream = res.GetResponseStream( ) )
					{
						using ( StreamReader reader = new StreamReader( responseStream, Encoding.UTF8 ) )
						{
							string html = reader.ReadToEnd( );

							if ( html.IndexOf( "<title>페이지를 찾을 수 없습니다." ) > -1 )
							{
								return false;
							}
							else if ( html.IndexOf( "frmNIDLogin" ) > -1 )
							{
								return false;
							}
							else
							{
								return true;
							}
						}
					}
				}
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				return false;
			}
		}

		public static ThreadDetailStruct ThreadDetailRequest( string threadNumber )
		{
			try
			{
				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( "http://cafe.naver.com/ArticleRead.nhn?clubid=" + GlobalVar.CAFE_ID + "&articleid=" + threadNumber );
				request.Method = "GET";
				request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";
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

							HtmlDocument document = new HtmlDocument( );
							document.LoadHtml( html );

							bool foundCategory = false;
							bool foundDetailNick = false;

							ThreadDetailStruct data = new ThreadDetailStruct( );

							foreach ( HtmlNode i in document.DocumentNode.SelectNodes( "//img" ) )
							{
								if ( i.GetAttributeValue( "src", "" ).StartsWith( "http://itemimgs.naver.net/personacon/" ) && i.GetAttributeValue( "width", "" ) == "19" && i.GetAttributeValue( "height", "" ) == "19" )
								{
									data.personaconURL = i.GetAttributeValue( "src", "" );

									break;
								}
							}

							foreach ( HtmlNode i in document.DocumentNode.SelectNodes( "//td" ) )
							{
								if ( i.GetAttributeValue( "class", "" ) == "m-tcol-c date" )
								{
									data.threadTime = i.InnerText.Trim( );
								}
								else if ( !foundDetailNick && i.GetAttributeValue( "class", "" ) == "p-nick" )
								{
									foreach ( HtmlNode i2 in i.ChildNodes )
									{
										if ( i2.Name == "a" )
										{
											string[ ] valTable = i2.GetAttributeValue( "onclick", "" ).Split( new string[ ] { "'" }, StringSplitOptions.RemoveEmptyEntries );

											data.threadAuthor = valTable[ 3 ] + "(" + valTable[ 1 ] + ")";
											break;
										}
									}

									foundDetailNick = true;
								}
								else if ( !foundCategory && i.GetAttributeValue( "class", "" ) == "m-tcol-c" )
								{
									data.articleName = i.InnerText.Trim( );
									foundCategory = true;
								}
							}

							return data;
						}
					}
				}
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				return new ThreadDetailStruct( );
			}
		}

		public static bool IsDeletedThread( string threadNumber, out bool isNetError )
		{
			string url = "http://cafe.naver.com/ArticleRead.nhn?clubid=" + GlobalVar.CAFE_ID + "&articleid=" + threadNumber;

			try
			{
				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( url );
				request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";

				using ( WebResponse res = request.GetResponse( ) )
				{
					using ( Stream responseStream = res.GetResponseStream( ) )
					{
						using ( StreamReader reader = new StreamReader( responseStream, Encoding.Default ) )
						{
							string value = reader.ReadToEnd( );

							isNetError = false;

							return value.IndexOf( "삭제되었거나 없는 게시글입니다." ) > -1;
						}
					}
				}
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				isNetError = true;
				return false;
			}
		}

		public static NaverAccountInformation? AccountRequest( )
		{
			try
			{
				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( "http://gn.naver.com/getLoginStatus.nhn?charset=utf-8&svc=section.cafe&template=gnb_utf8&one_naver=1" );
				request.Method = "GET";
				request.Host = "gn.naver.com";
				request.ProtocolVersion = HttpVersion.Version11;
				request.Referer = "http://section.cafe.naver.com/";
				request.KeepAlive = true;
				request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";
				request.Accept = "*/*";
				request.Headers.Add( "DNT", "1" );
				request.Headers.Add( HttpRequestHeader.AcceptLanguage, "ko-KR,ko;q=0.8,en-US;q=0.6,en;q=0.4" );
				request.CookieContainer = new CookieContainer( );

				foreach ( CookieTable i in GlobalVar.COOKIES_LIST )
				{
					request.CookieContainer.Add( new Cookie( i.id, i.value, "/", request.Host ) );
				}

				using ( HttpWebResponse response = ( HttpWebResponse ) request.GetResponse( ) )
				{
					using ( Stream responseStream = response.GetResponseStream( ) )
					{
						using ( StreamReader reader = new StreamReader( responseStream, Encoding.UTF8 ) )
						{
							string htmlString = reader.ReadToEnd( );

							JsonObjectCollection jsonCollection = ( JsonObjectCollection ) ( new JsonTextParser( ) ).Parse( htmlString );

							File.WriteAllText( "tt.txt", htmlString, Encoding.UTF8 );

							return new NaverAccountInformation(
								jsonCollection[ "nickName" ].GetValue( ).ToString( ),
								jsonCollection[ "loginId" ].GetValue( ).ToString( ),
								jsonCollection[ "imageUrl" ].GetValue( ).ToString( ),
								jsonCollection[ "loginStatus" ].GetValue( ).ToString( ) == "Y" ? true : false
							);
						}
					}
				}
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				return null;
			}
		}

		// http://lstar2397.tistory.com/1
		public static NaverLoginResult LoginHttp( string id, string pwd, out CookieCollection cookies )
		{
			try
			{
				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( "https://nid.naver.com/nidlogin.login" );
				request.Method = "POST";
				request.ContentType = "application/x-www-form-urlencoded";
				request.Referer = "https://nid.naver.com/nidlogin.login?svctype=262144&url=http://naver.com";
				request.CookieContainer = new CookieContainer( );

				using ( StreamWriter requestStream = new StreamWriter( request.GetRequestStream( ) ) )
				{
					requestStream.Write( "id=" + id + "&pw=" + pwd + "&saveID=0&enctp=2&smart_LEVEL=1&svctype=0&locale=ko_KR&url=http://naver.com" );
				}

				using ( HttpWebResponse res = ( HttpWebResponse ) request.GetResponse( ) )
				{
					if ( res.StatusCode == HttpStatusCode.OK )
					{
						using ( Stream responseStream = res.GetResponseStream( ) )
						{
							using ( StreamReader reader = new StreamReader( responseStream, Encoding.UTF8 ) )
							{
								string result = reader.ReadToEnd( );

								if ( result.Contains( ">새로운 기기 등록</" ) ) // 새로운 기기 로그인 알림 설정됨.
								{
									cookies = null;
									return NaverLoginResult.SecurityBlocked;
								}
								else if ( result.Contains( "https://nid.naver.com/login/sso/finalize.nhn?url" ) ) // 로그인 성공
								{
									cookies = request.CookieContainer.GetCookies( request.RequestUri );
									return NaverLoginResult.Success;
								}
								else // 아이디 또는 암호 또는 기타 오류
								{
									cookies = null;
									return NaverLoginResult.IDorPWDError;
								}
							}
						}
					}
					else
					{
						Utility.WriteErrorLog( ( ( int ) res.StatusCode ) + " - " + res.StatusCode.ToString( ), Utility.LogSeverity.EXCEPTION );
						cookies = null;
						return NaverLoginResult.RequestError;
					}
				}
			}
			catch ( WebException ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				cookies = null;
				return NaverLoginResult.RequestError;
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				cookies = null;
				return NaverLoginResult.RequestError;
			}
		}

		public static void New(
			string url,
			RequestMethod method,
			Encoding encoding,
			Action<string> RequestCallBack,
			Action ErrorCallBack = null
		)
		{
			try
			{
				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( url );
				request.Method = method.ToString( );
				using ( HttpWebResponse response = ( HttpWebResponse ) request.GetResponse( ) )
				{
					using ( Stream responseStream = response.GetResponseStream( ) )
					{
						using ( StreamReader reader = new StreamReader( responseStream, encoding ) )
						{
							RequestCallBack.Invoke( reader.ReadToEnd( ) );
						}
					}
				}
			}
			catch ( WebException ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				ErrorCallBack?.Invoke( );
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				ErrorCallBack?.Invoke( );
			}
		}
	}
}
