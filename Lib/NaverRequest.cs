using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Json;
using System.Text;
using System.Web;
using HtmlAgilityPack;

namespace CafeMaster_UI.Lib
{
	struct MemberInformationStruct
	{
		public string nickName;
		public string memberID;
		public string profileImageURL;
		public string personaconImageURL;
		public string rank;
	}

	struct SignUpRequestStruct
	{
		public string id;
		public string age;
		public string gender;
		public string time;
	}

	struct ThreadDetailStruct
	{
		public string threadTime;
		public string threadAuthor;
		public string authorRank;
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

	public struct MemberActivityStopListStruct
	{
		public string nickname; // 닉네임
		public string id; // 아이디
		public string reason; // 사유
		public string startDate; // 시작일
		public string endDate; // 끝나는 일
		public string doStaffNickname; // 작업한 스탭 정보
		public string profileImage;
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
			RequestError,
			ChptchaRequired
		}

		public static bool IsCafeErrorPage( string html )
		{
			return html.ContainsMultiple(
				"<title>네이버 카페</title>",
				"<p>등록된 네이버 카페가 아닙니다.<br />"
			);
		}

		public static Tuple<bool, string> RemoveMemberActivityStop( string memberID )
		{
			try
			{
				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( "http://cafe.naver.com/ManageActivityStopRelease.nhn" );
				request.Method = "POST";
				request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";
				request.KeepAlive = true;
				request.Referer = "http://cafe.naver.com/ManageActivityStopMemberView.nhn?search.clubid=" + GlobalVar.CAFE_ID;
				request.ContentType = "application/x-www-form-urlencoded";
				request.Headers.Add( HttpRequestHeader.CacheControl, "max-age=0" );
				request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
				request.Headers.Add( "Origin", "http://m.cafe.naver.com" );
				request.Headers.Add( "DNT", "1" );
				request.Headers.Add( "Upgrade-Insecure-Requests", "1" );
				request.Headers.Add( HttpRequestHeader.AcceptLanguage, "ko-KR,ko;q=0.8,en-US;q=0.6,en;q=0.4" );
				request.CookieContainer = new CookieContainer( );

				string dataString = "clubid=" + GlobalVar.CAFE_ID + "&memberids=" + memberID + "&callback=reload";

				foreach ( CookieTable i in GlobalVar.COOKIES_LIST )
				{
					request.CookieContainer.Add( new Cookie( i.id, i.value, "/", request.Host ) );
				}

				byte[ ] byteArray = Encoding.Default.GetBytes( dataString );

				request.ContentLength = byteArray.Length;

				using ( Stream requestStream = request.GetRequestStream( ) )
				{
					requestStream.Write( byteArray, 0, byteArray.Length );
				}

				using ( WebResponse res = request.GetResponse( ) )
				{
					using ( Stream responseStream = res.GetResponseStream( ) )
					{
						using ( StreamReader reader = new StreamReader( responseStream, Encoding.Default ) )
						{
							string html = reader.ReadToEnd( );

							if ( html.ContainsMultiple(
								"var msg = '활동이 가능한 멤버로 변경하였습니다.';",
								"alert(msg);"
								) )
								return Tuple.Create<bool, string>( true, null );
							else
								return Tuple.Create<bool, string>( false, "API 서버에서 형식 오류를 반환했습니다, 개발자에게 문의하세요." );
						}
					}
				}
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				return Tuple.Create<bool, string>( false, ex.Message + " (0x" + ( ex.HResult > 0 ? ex.HResult : 0 ) + ")" );
			}
		}

		public static Tuple<bool, List<MemberActivityStopListStruct>, string> GetMemberActivityStopList( )
		{
			try
			{
				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( "http://cafe.naver.com/ManageActivityStopMemberView.nhn?search.clubid=" + GlobalVar.CAFE_ID );
				request.Method = "GET";
				request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";
				request.KeepAlive = true;
				request.Referer = "http://cafe.naver.com/" + GlobalVar.CAFE_ID;
				request.CookieContainer = new CookieContainer( );

				foreach ( CookieTable i in GlobalVar.COOKIES_LIST )
				{
					request.CookieContainer.Add( new Cookie( i.id, i.value, "/", request.Host ) );
				}

				using ( WebResponse res = request.GetResponse( ) )
				{
					using ( Stream responseStream = res.GetResponseStream( ) )
					{
						HtmlDocument document = new HtmlDocument( );
						document.Load( responseStream, Encoding.Default );

						List<MemberActivityStopListStruct> dataList = new List<MemberActivityStopListStruct>( );

						for ( int i = 1; i <= document.DocumentNode.SelectNodes( "//tbody/tr[@id != \"\"]" ).Count; i++ )
						{
							MemberActivityStopListStruct data = new MemberActivityStopListStruct( );

							HtmlNode userNickNameNode = document.DocumentNode.SelectSingleNode( "//tbody/tr[" + i + "]/td/div" );
							HtmlNode reasonNode = document.DocumentNode.SelectSingleNode( "//tbody/tr[" + i + "]/td[@class=\"tl\"]/div" );
							HtmlNode startDateNode = document.DocumentNode.SelectSingleNode( "//tbody/tr[" + i + "]/td[@class=\"tc\"]/span" );
							HtmlNode endDateNode = document.DocumentNode.SelectSingleNode( "//tbody/tr[" + i + "]/td[@class=\"tr\"]/span" );
							HtmlNode doStaffNickNameNode = document.DocumentNode.SelectSingleNode( "//tbody/tr[" + i + "]/td[@class=\"tl\"][2]/div" );
							HtmlNode profileImageNode = document.DocumentNode.SelectSingleNode( "//tbody/tr[" + i + "]/td[2]/div[@class=\"pers_nick_area\"]/span/img" );


							data.nickname = userNickNameNode.InnerText.Trim( );
							data.id = data.nickname.Substring( data.nickname.IndexOf( '(' ) + 1, data.nickname.Length - data.nickname.IndexOf( '(' ) - 2 );
							data.reason = reasonNode.InnerText.Trim( );
							data.startDate = startDateNode.InnerText.Trim( );
							data.profileImage = profileImageNode.GetAttributeValue( "src", "" ).Replace( "?type=s40", "?type=c120_120" );

							if ( endDateNode != null ) // 종료일 노드가 없는지 체크
								data.endDate = endDateNode.InnerText.Trim( );
							else
								data.endDate = "*"; // 종료일 노드가 없으면 무기한 활동정지임

							data.doStaffNickname = doStaffNickNameNode.InnerText.Trim( );

							//Console.WriteLine( userNickNameNode.InnerText.Trim( ) );
							//Console.WriteLine( reasonNode.InnerText.Trim( ) );
							//Console.WriteLine( startDateNode.InnerText.Trim( ) );
							//Console.WriteLine( doStaffNickNameNode.InnerText.Trim( ) );

							dataList.Add( data );
						}

						return Tuple.Create<bool, List<MemberActivityStopListStruct>, string>( true, dataList, null );
					}
				}
			}
			catch ( WebException ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );

				if ( ex.Response == null )
				{
					return Tuple.Create<bool, List<MemberActivityStopListStruct>, string>( false, null, "인터넷에 연결되지 않았습니다." );
				}
				else
				{
					return Tuple.Create<bool, List<MemberActivityStopListStruct>, string>( false, null, ex.Message );
				}
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				return Tuple.Create<bool, List<MemberActivityStopListStruct>, string>( false, null, ex.Message );
			}
		}

		//[Obsolete( "이 메소드는 사용할 수 없습니다." )]
		public static Tuple<bool, int, string> GetMemberWarningCount( string id )
		{
			string url = "http://cafe.naver.com/ArticleSearchList.nhn?search.clubid=" + GlobalVar.CAFE_ID + "&search.searchdate=all&search.searchBy=0&search.query=" + id + "&search.menuid=20";

			try
			{
				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( url );
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
						HtmlDocument document = new HtmlDocument( );
						document.Load( responseStream, Encoding.Default );

						int count = 0;
						foreach ( HtmlNode i in document.DocumentNode.SelectNodes( "//tr[@align=\"center\"]" ) )
						{
							if ( i.GetAttributeValue( "class", "" ) != "bg-color" && i.ChildNodes.Count == 13 )
								count++;
						}

						return Tuple.Create<bool, int, string>( true, count, null );
					}
				}
			}
			catch ( WebException ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );

				if ( ex.Response == null )
				{
					return Tuple.Create<bool, int, string>( false, 0, "인터넷에 연결되지 않았습니다." );
				}
				else
				{
					return Tuple.Create<bool, int, string>( false, 0, ex.Message );
				}
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				return Tuple.Create<bool, int, string>( false, 0, ex.Message );
			}
		}

		public static string GetMemberPersonaconID( )
		{
			try
			{
				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( "http://cafe.naver.com/ArticleWrite.nhn?clubid=" + GlobalVar.CAFE_ID + "&menuid=&boardtype=L&m=write" );
				request.Method = "GET";
				request.KeepAlive = true;
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
						HtmlDocument document = new HtmlDocument( );
						document.Load( responseStream, Encoding.Default );

						//string cafeTempId = "";
						//string branchCode = "";

						HtmlNode personaconNode = document.DocumentNode.SelectSingleNode( "//input[@name=\"personacon\"]" );

						if ( personaconNode != null )
						{
							return personaconNode.GetAttributeValue( "value", "" ).Trim( );
						}
						else
							return "";

						//int count = 0;
						//foreach ( HtmlNode i in  )
						//{
						//switch ( ++count )
						//{
						//case 3: // cafeTempId
						//	cafeTempId = i.GetAttributeValue( "value", "" );
						//	break;
						//case 4: // branchCode
						//	branchCode = i.GetAttributeValue( "value", "" );
						//	break;
						//case 7: // personacon
						//	personacon = i.GetAttributeValue( "value", "" );
						//	break;
						//}
						//if ( ++count == 7 ) // personacon
						//{

						//	//personacon = i.GetAttributeValue( "value", "" );
						//	return i.GetAttributeValue( "value", "" ).Trim( );
						//}
						//}
					}
				}
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				return "";
			}
		}

		public static Tuple<bool, string> WriteMemberWarningThread( string nickName, int warnCount, string reason )
		{
			string dataString = @"clubid=" + GlobalVar.CAFE_ID + "&menuidForList=20&type=&typeOriginal=&personacon=" + NaverRequest.GetMemberPersonaconID( ) + "&boardtype=L&page=1&m=write&attachpollyn=&attachPollids=&attachfileyn=&attachimageyn=&attachfiles=&attachsizerealsum=0&attachmodifylist=&attachsizes=&attachimagesizesum=0&attachfilesizesum=0&scrapedyn=&attachinfolist=&attachinfo=0&attachmaplist=&attachmovie=&attachmovielist=&article.leveragecode=0&article.attachCalendarList=&attachCalendar=&attachedCalendar=&tempsaveid=5&owfs=false&ndriveid=0&hadNaverPoll=&article.attachMusic=&appPost=&parameterString=&representImagePath=&menuid=20&headid=&tagnames=&openyn=N&replyyn=N&scrapyn=N&metoo=false&rclick=0&videoLink=false&autosourcing=0&ccl=0&rows_val=4&cols_val=4&border_val=1&borderColorCode=%23B7BBB5&backColorCode=%23FFFFFF&keyword=&keyword_re=&replace=&article.templatecode=0";

			try
			{
				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( "http://m.cafe.naver.com/ArticlePost.nhn" );
				request.Method = "POST";
				request.Host = "m.cafe.naver.com";
				request.ProtocolVersion = HttpVersion.Version11;
				request.ContentType = "application/x-www-form-urlencoded";
				request.Headers.Add( HttpRequestHeader.CacheControl, "max-age=0" );
				request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
				request.Headers.Add( "Origin", "http://m.cafe.naver.com" );
				request.Headers.Add( "DNT", "1" );
				request.Headers.Add( "Upgrade-Insecure-Requests", "1" );
				request.Headers.Add( HttpRequestHeader.AcceptLanguage, "ko-KR,ko;q=0.8,en-US;q=0.6,en;q=0.4" );
				request.Referer = "http://m.cafe.naver.com/ArticleWrite.nhn?m=write&clubid=" + GlobalVar.CAFE_ID + "&menuid=";
				request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";
				request.CookieContainer = new CookieContainer( );

				foreach ( CookieTable i in GlobalVar.COOKIES_LIST )
				{
					request.CookieContainer.Add( new Cookie( i.id, i.value, "/", request.Host ) );
				}

				//subject=#SUBJECT&content=#CONTENT

				dataString += "&subject=" + HttpUtility.UrlEncode( nickName + "님 경고 (총 " + warnCount + "회)", Encoding.UTF8 );
				dataString += "&content=" + HttpUtility.UrlEncode(
					@"<div class='NHN_Writeform_Main'><p></p><p>용의자 닉네임 : " + nickName + "</p><p></p><p></p><p><br></p><p>진술 : " + reason + "</p></div>",
				Encoding.UTF8 );

				byte[ ] byteArray = Encoding.UTF8.GetBytes( dataString );

				request.ContentLength = byteArray.Length;

				using ( Stream requestStream = request.GetRequestStream( ) )
				{
					requestStream.Write( byteArray, 0, byteArray.Length );
				}

				using ( WebResponse res = request.GetResponse( ) )
				{
					using ( Stream responseStream = res.GetResponseStream( ) )
					{
						using ( StreamReader reader = new StreamReader( responseStream, Encoding.UTF8 ) )
						{
							string html = reader.ReadToEnd( );

							if ( html.ContainsMultiple(
								"<title>페이지를 찾을 수 없습니다.",
								"frmNIDLogin"
								) )
								return Tuple.Create<bool, string>( false, "API 서버에서 형식 오류를 반환했습니다, 개발자에게 문의하세요." );
							else
								return Tuple.Create<bool, string>( true, null );
						}
					}
				}
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				return Tuple.Create<bool, string>( false, ex.Message + " (0x" + ( ex.HResult > 0 ? ex.HResult : 0 ) + ")" );
			}
		}

		public static bool ThreadDelete( string threadNumber )
		{
			try
			{
				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( "http://cafe.naver.com/ArticleDelete.nhn" );
				request.Method = "POST";
				request.Referer = "http://cafe.naver.com/ArticleRead.nhn?articleid=109979&clubid=25430492";
				request.Headers.Add( HttpRequestHeader.CacheControl, "max-age=0" );
				request.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2785.116 Safari/537.36";
				request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
				request.ContentType = "application/x-www-form-urlencoded";
				request.Headers.Add( "Origin", "http:/cafe.naver.com" );
				request.Headers.Add( "DNT", "1" );
				request.Headers.Add( "Upgrade-Insecure-Requests", "1" );
				request.Headers.Add( HttpRequestHeader.AcceptLanguage, "ko-KR,ko;q=0.8,en-US;q=0.6,en;q=0.4" );
				request.CookieContainer = new CookieContainer( );

				foreach ( CookieTable i in GlobalVar.COOKIES_LIST )
				{
					request.CookieContainer.Add( new Cookie( i.id, i.value, "/", request.Host ) );
				}

				byte[ ] byteArray = Encoding.Default.GetBytes( "articleid=" + threadNumber + "&clubid=" + GlobalVar.CAFE_ID );

				request.ContentLength = byteArray.Length;

				using ( Stream requestStream = request.GetRequestStream( ) )
				{
					requestStream.Write( byteArray, 0, byteArray.Length );
				}

				using ( WebResponse res = request.GetResponse( ) )
				{
					using ( Stream responseStream = res.GetResponseStream( ) )
					{
						using ( StreamReader reader = new StreamReader( responseStream, Encoding.Default ) )
						{
							string html = reader.ReadToEnd( );

							if ( IsCafeErrorPage( html ) )
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

		public static bool ExecuteMemberStopActivity( string memberID, int length, string reason, out bool alreadyStopped )
		{
			try
			{
				string dataString = "clubid=" + GlobalVar.CAFE_ID + "&activityStop.executorId=" + GlobalVar.NAVER_USER_ID + "&callback=close&memberids=" + memberID + "&activityStop.violationCode=2&activityStop.reason=" + reason + "&duration=" + length;

				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( "http://cafe.naver.com/ManageActivityStopProcess.nhn" );
				request.Method = "POST";
				request.Referer = "http://cafe.naver.com/ManageActivityStopPopupView.nhn";
				request.Headers.Add( HttpRequestHeader.CacheControl, "max-age=0" );
				request.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2785.116 Safari/537.36";
				request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
				request.ContentType = "application/x-www-form-urlencoded";
				request.Headers.Add( "Origin", "http://cafe.naver.com" );
				request.Headers.Add( "DNT", "1" );
				request.Headers.Add( "Upgrade-Insecure-Requests", "1" );
				request.Headers.Add( HttpRequestHeader.AcceptLanguage, "ko-KR,ko;q=0.8,en-US;q=0.6,en;q=0.4" );
				request.KeepAlive = true;
				request.CookieContainer = new CookieContainer( );

				foreach ( CookieTable i in GlobalVar.COOKIES_LIST )
				{
					request.CookieContainer.Add( new Cookie( i.id, i.value, "/", request.Host ) );
				}

				byte[ ] byteArray = Encoding.Default.GetBytes( dataString );

				request.ContentLength = byteArray.Length;

				using ( Stream requestStream = request.GetRequestStream( ) )
				{
					requestStream.Write( byteArray, 0, byteArray.Length );
				}

				using ( WebResponse res = request.GetResponse( ) )
				{
					using ( Stream responseStream = res.GetResponseStream( ) )
					{
						using ( StreamReader reader = new StreamReader( responseStream, Encoding.Default ) )
						{
							string html = reader.ReadToEnd( );
							
							if ( html.Contains( "alert('이미 활동정지되었습니다.');" ) )
							{
								alreadyStopped = true;
								return true;
							}
							else
							{
								alreadyStopped = false;
								return html.Contains( "alert('성공적으로 반영 되었습니다.');" );
							}
						}
					}
				}
			}
			catch ( Exception ex )
			{
				alreadyStopped = false;
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				return false;
			}
		}

		public static ThreadDetailStruct GetSpecificThreadDetail( string threadNumber )
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
						HtmlDocument document = new HtmlDocument( );
						document.Load( responseStream, Encoding.Default );

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
							// authorRank null check 안할 시 Q&A 게시물에서 m-tcol-c step class element 가 최소 2개 이므로 2번째 것으로 오류남 (질문과 답변 게시글이 있기 때문에 최소 2개 이상임)
							if ( data.authorRank == null && i.GetAttributeValue( "class", "" ) == "m-tcol-c step" )
							{
								foreach ( HtmlNode i2 in i.ChildNodes )
								{
									if ( i2.GetAttributeValue( "class", "" ) == "filter-50" )
									{
										data.authorRank = i2.InnerText.Trim( );
										break;
									}
								}
							}
							else if ( i.GetAttributeValue( "class", "" ) == "m-tcol-c date" )
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
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				return new ThreadDetailStruct( );
			}
		}

		public static bool IsDeletedThread( string threadNumber, out bool isNetworkError )
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
							string value = reader.ReadToEnd( );

							isNetworkError = false;

							return value.Contains( "삭제되었거나 없는 게시글입니다." );
						}
					}
				}
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				isNetworkError = true;
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
			catch ( FormatException ex ) // Debug required;
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				return null;
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				return null;
			}
		}

		public static List<SignUpRequestStruct> SignUpListRequest( )
		{
			try
			{
				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( "http://cafe.naver.com/ManageJoinApplication.nhn?search.clubid=25430492" );
				request.Method = "GET";
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
						List<SignUpRequestStruct> signUpList = new List<SignUpRequestStruct>( );

						HtmlDocument document = new HtmlDocument( );
						document.Load( responseStream, Encoding.Default );

						//"//input[@type=\"hidden\"]"
						foreach ( HtmlNode i in document.DocumentNode.SelectNodes( "//tbody[@id=\"applymemberList\"]" ) )
						{
							foreach ( HtmlNode i2 in i.ChildNodes )
							{
								if ( i2.Name == "tr" )
								{
									int count = 0;
									SignUpRequestStruct data = new SignUpRequestStruct( );

									foreach ( HtmlNode i3 in i2.ChildNodes )
									{
										if ( i3.Name == "td" )
										{
											count++;

											switch ( count )
											{
												case 2:
													data.id = i3.InnerText.Trim( );
													break;
												case 3:
													data.age = i3.InnerText.Trim( );
													break;
												case 4:
													data.gender = i3.InnerText.Trim( );
													break;
												case 5:
													data.time = i3.InnerText.Trim( );
													break;

											}
										}
									}

									signUpList.Add( data );
								}
							}
						}

						return signUpList;
					}
				}
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );

				return null;
			}
		}

		public static bool AccountPermissionCheck( )
		{
			try
			{
				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( GlobalVar.CAFE_MANAGE_HOME_URL );
				request.Method = "GET";
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
						using ( StreamReader reader = new StreamReader( responseStream, Encoding.Default ) )
						{
							string html = reader.ReadToEnd( );

							if ( html.ContainsMultiple(
								"top.location.href = '/soulmatetour.cafe';",
								"top.location.href = '/" + GlobalVar.CAFE_URL_ID + ".cafe';"
								) )
								return false;
							else
								return true;
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

		public static MemberInformationStruct? GetMemberInformation( string memberID )
		{
			try
			{
				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( "http://cafe.naver.com/CafeMemberNetworkView.nhn?m=view&clubid=" + GlobalVar.CAFE_ID + "&memberid=" + memberID );
				request.Method = "GET";
				request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";
				request.KeepAlive = true;
				request.Referer = "http://cafe.naver.com/" + GlobalVar.CAFE_URL_ID;
				request.CookieContainer = new CookieContainer( );

				foreach ( CookieTable i in GlobalVar.COOKIES_LIST )
				{
					request.CookieContainer.Add( new Cookie( i.id, i.value, "/", request.Host ) );
				}

				using ( WebResponse res = request.GetResponse( ) )
				{
					using ( Stream responseStream = res.GetResponseStream( ) )
					{
						HtmlDocument document = new HtmlDocument( );
						document.Load( responseStream, Encoding.Default );

						MemberInformationStruct data = new MemberInformationStruct( );

						foreach ( HtmlNode i in document.DocumentNode.SelectNodes( "//a[@class=\"m-tcol-c\"]" ) )
						{
							if ( i.GetAttributeValue( "onclick", "" ).StartsWith( "ui(event," ) )
							{
								string[ ] valTable = i.GetAttributeValue( "onclick", "" ).Split( new string[ 1 ] { "'" }, StringSplitOptions.RemoveEmptyEntries );

								data.nickName = valTable[ 3 ].Trim( );
								data.memberID = valTable[ 1 ].Trim( );

								break;
							}
						}

						// 변경이 필요함;
						foreach ( HtmlNode i in document.DocumentNode.SelectNodes( "//td[@class=\"m-tcol-c\"]" ) )
						{
							data.rank = i.InnerText.Trim( );
							break;
						}

						foreach ( HtmlNode i in document.DocumentNode.SelectNodes( "//img" ) )
						{
							if ( i.GetAttributeValue( "src", "" ).StartsWith( "http://itemimgs.naver.net/personacon/" ) && i.GetAttributeValue( "width", "" ) == "19" && i.GetAttributeValue( "height", "" ) == "19" )
							{
								data.personaconImageURL = i.GetAttributeValue( "src", "" ).Trim( );
							}

							if ( i.GetAttributeValue( "class", "" ) == "border-sub" )
							{
								data.profileImageURL = i.GetAttributeValue( "src", "" ).Trim( );
							}
						}
						
						return data;
					}
				}
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				return null;
			}
		}

		public static Tuple<bool, bool, string> CheckMemberExists( string id )
		{
			try
			{
				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( "http://cafe.naver.com/CafeMemberExistCheck.nhn?clubid=" + GlobalVar.CAFE_ID + "&memberid=" + id );
				request.Method = "GET";
				request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";
				request.KeepAlive = true;
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

							JsonObjectCollection col = ( JsonObjectCollection ) ( new JsonTextParser( ) ).Parse( html );

							if ( col[ "exist" ].GetValue( ).ToString( ).ToLower( ) == "true" ) // 멤버 잇음
							{
								return Tuple.Create<bool, bool, string>( true, true, null );
								//if ( col[ "activityStop" ].GetValue( ).ToString( ) == "true" ) // 이미 활동정지 된 멤버
								//{

								//}
							}
							else
								return Tuple.Create<bool,bool,string>(true,false,null);
						}
					}
				}
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				return Tuple.Create<bool, bool, string>( false, false, ex.Message );
			}
		}

		public static bool CheckMemberExistsSimple( string id )
		{
			try
			{
				HttpWebRequest request = ( HttpWebRequest ) WebRequest.Create( "http://cafe.naver.com/CafeMemberExistCheck.nhn?clubid=" + GlobalVar.CAFE_ID + "&memberid=" + id );
				request.Method = "GET";
				request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";
				request.KeepAlive = true;
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

							JsonObjectCollection col = ( JsonObjectCollection ) ( new JsonTextParser( ) ).Parse( html );

							if ( col[ "exist" ].GetValue( ).ToString( ).ToLower( ) == "true" ) // 멤버 잇음
							{
								return true;
								//if ( col[ "activityStop" ].GetValue( ).ToString( ) == "true" ) // 이미 활동정지 된 멤버
								//{

								//}
							}
							else
								return false;
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

		// http://lstar2397.tistory.com/1
		public static NaverLoginResult NaverAccountLogin( string id, string pwd, out CookieCollection cookies )
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
								string html = reader.ReadToEnd( );

								//captcha_txt

								if ( html.Contains( ">새로운 기기 등록</" ) ) // 새로운 기기 로그인 알림 설정됨.
								{
									cookies = null;
									return NaverLoginResult.SecurityBlocked;
								}
								if ( html.Contains( "<p class=\"captcha_txt\" id=\"captcha_info\">아래 이미지를 보이는 대로 입력해주세요.</p>" ) ) // 자동 입력 방지 문자를 입력해야함 (암호를 많이 틀림)
								{
									cookies = null;
									return NaverLoginResult.ChptchaRequired;
								}
								else if ( html.Contains( "https://nid.naver.com/login/sso/finalize.nhn?url" ) ) // 로그인 성공
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
			Action<Exception> ErrorCallBack = null
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
				ErrorCallBack?.Invoke( ex );
			}
			catch ( Exception ex )
			{
				Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
				ErrorCallBack?.Invoke( ex );
			}
		}
	}
}
