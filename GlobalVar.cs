using System;
using System.Collections;
using System.Collections.Generic;
using CafeMaster_UI.Lib;

namespace CafeMaster_UI
{
	public enum AdminRanks
	{
		Manager, // 매니저
		SubManager, // 부매니저
		Staff // 스탭
	}

	static class GlobalVar
	{
		public static readonly System.Drawing.Color MasterColor = System.Drawing.Color.Silver; // 메인 색

		public const string CAFE_ID = "25430492"; // 카페 숫자 아이디 // 25016505 // 25430492
		public const string CAFE_URL_ID = "revolution232"; // 카페 문자열 아이디
														   //http://cafe.naver.com/left7deadhalflife
														   //revolution232

		public static ProgramValidation.UpdateResultStruct VERSION_INFO;
		public static List<ProgramErrorStruct> PROGRAM_UNCATCHED_ERRORS = new List<ProgramErrorStruct>( );

		public const string CAFE_RULE_URL = "http://cafe.naver.com/revolution232/6894"; // 카페 공지사항 링크
		public const string CAFE_CHAT_URL = "https://chat.cafe.naver.com/room/25430492/lolori_:1484751066552?ssId=2"; // 카페 채팅 링크
		public const string CAFE_TOTAL_ARTICLE_URL = "http://cafe.naver.com/ArticleList.nhn?search.clubid=25430492&search.boardtype=L"; // 전체 글 보기 링크
		public const string CAFE_MANAGE_HOME_URL = "http://cafe.naver.com/ManageHome.nhn?clubid=25430492"; // 카페 관리 링크
		public const string CAFE_MANAGE_JOINMANAGE_URL = "http://cafe.naver.com/ManageJoinApplication.nhn?search.clubid=25430492"; // 카페 가입 신청 관리 링크
		public const string CAFE_WARNING_ARTICLE_URL = "http://cafe.naver.com/ArticleList.nhn?search.clubid=25430492&search.menuid=20&search.boardtype=L"; // 카페 경고 게시판 주소
		public const string CAFE_MEMBER_NETWORK_VIEW_URL = "http://cafe.naver.com/CafeMemberNetworkView.nhn?m=view&clubid=25430492&memberid="; // 
		public const string CAFE_STOP_ACTIVITY_LIST_URL = "http://cafe.naver.com/ManageActivityStopMemberView.nhn?search.clubid=25430492"; // 카페 활동정지 리스트 주소
		public const string NAVER_SPELL_CHECKER_URL = "https://search.naver.com/search.naver?ie=utf8&query=%EB%A7%9E%EC%B6%A4%EB%B2%95%EA%B2%80%EC%82%AC"; // 네이버 맞춤법 검사기 주소

		public static bool NoCloseSave = false;
		public static bool CRCCheckFailed = false;
		public static bool UPDATE_AVAILABLE = false; // 새로운 버전 있음
		//public static bool OFFLINE_MODE = true; // 우유서버 연결 불가 -> 오프라인 모드 여부
		public static string COOKIES = ""; // 네이버 계정 쿠키
		public static List<Lib.CookieTable> COOKIES_LIST = new List<Lib.CookieTable>( ); // 네이버 계정 쿠키 리스트


		public const string NOTIFY_ARTICLE_CREATE_SQLITE = @"
		CREATE TABLE IF NOT EXISTS ArticleNotification(
			threadID INTEGER PRIMARY KEY,
			threadTitle TEXT,
			threadAuthor TEXT,
			threadURL TEXT,
			threadTime TEXT,
			threadHit INTEGER,
			focused INTEGER,
			personaconURL TEXT,
			articleName TEXT,
			authorRank TEXT
		);";
		public const string THREAD_DATA_CREATE_SQLITE = @"
		CREATE TABLE IF NOT EXISTS ThreadIDStored(
			id INTEGER
		);";

		public static string NAVER_USER_ID; // 네이버 아이디

		public static bool notPermissionAccount = false;

		public static Hashtable ADMINS = new Hashtable( ); // 스탭 리스트

		public static readonly string APP_DIR; // 프로그램 exe 경로
		public static readonly string CURRENT_VERSION; // 프로그램 현재 버전

		public static readonly string DATA_DIR; // DATA 폴더 경로 (아래의 경로들과 상속됨)
		public static readonly string CONFIG_DIR; // 설정값 파일 경로
		public static readonly string LAYOUT_DIR; // 테마 폴더 경로
		public static readonly string CAPTURE_DIR; // 캡처 폴더 경로

		public static readonly string PROFILE_TEMP_DIR; // 프로필 이미지 TEMP 파일 경로

		public static readonly string CUSTOM_STYLESHEET_DIR; // 카페채팅 커스텀 스타일시트 파일 경로

		static GlobalVar( )
		{
			Version version = System.Reflection.Assembly.GetExecutingAssembly( ).GetName( ).Version;

			APP_DIR = System.Windows.Forms.Application.StartupPath;

			DATA_DIR = APP_DIR + @"\data";
			CONFIG_DIR = APP_DIR + @"\data\config.dat";
			LAYOUT_DIR = APP_DIR + @"\layout";
			CAPTURE_DIR = APP_DIR + @"\captures";

			PROFILE_TEMP_DIR = DATA_DIR + @"\profileImage.jpg";

			CUSTOM_STYLESHEET_DIR = APP_DIR + @"\cafeChat.css";

			CURRENT_VERSION = version.Major + "." + version.Minor + "." + version.Build + "." + version.Revision;

			ADMINS.Add( "nana_98", AdminRanks.Manager ); // 어린이님
			ADMINS.Add( "lolori_", AdminRanks.SubManager ); // 뀨닝겐님

			ADMINS.Add( "dbxhvldk7896", AdminRanks.Staff ); // on님
			ADMINS.Add( "conypipi", AdminRanks.Staff ); // 잰님
			ADMINS.Add( "hwanjun1032", AdminRanks.Staff ); // 최멋짐님
			ADMINS.Add( "0404239", AdminRanks.Staff ); // 혜무리님
			ADMINS.Add( "jwon5366", AdminRanks.Staff ); // 꼼푸님
			//ADMINS.Add( "wldn824", AdminRanks.Staff ); // 레알님 (그분은 갔슴다ㅠ)
			ADMINS.Add( "smhjyh2007", AdminRanks.Staff ); // 나
		}
	}
}
