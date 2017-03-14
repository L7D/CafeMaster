/*
	우윳빛깔 카페스탭
	Copyright © 'L7D(너디)' 2017
*/
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using CafeMaster_UI.Lib;

namespace CafeMaster_UI
{
	static class Program
	{
		/// <summary>
		/// 해당 응용 프로그램의 주 진입점입니다.
		/// </summary>

		// http://stackoverflow.com/questions/19147/what-is-the-correct-way-to-create-a-single-instance-application
		private static Mutex mutex = new Mutex( true, "{c088e97c-9102-4f16-aa5b-5a32b4358f5f}" );
		[STAThread]
		static void Main( )
		{
			// TODO : 폰트 exists 체크문 추가바람

			if ( mutex.WaitOne( TimeSpan.Zero, true ) )
			{
				foreach ( System.Drawing.FontFamily ix in ( new System.Drawing.Text.InstalledFontCollection( )).Families )
				{
					if ( ix.Name == "나눔고딕" & ix.IsStyleAvailable( System.Drawing.FontStyle.Bold ) )
					{
						goto fontFinded;
					}
				}

				Utility.WriteErrorLog( "FontNotFound", Utility.LogSeverity.ERROR );
				NotifyBox.Show( null, "오류", "죄송합니다, 프로그램 실행에 필요한 폰트가 설치되지 않았습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
				Process.GetCurrentProcess( ).Kill( );
				return;

				fontFinded:

				try
				{
					System.Reflection.Assembly.Load( "HtmlAgilityPack" ).GetName( );
					System.Reflection.Assembly.Load( "System.Net.Json" ).GetName( );
					//System.Reflection.Assembly.Load( "Freezer" ).GetName( );
				}
				catch ( Exception )
				{
					Utility.WriteErrorLog( "DLLNotFound", Utility.LogSeverity.ERROR );
					NotifyBox.Show( null, "오류", "죄송합니다, 프로그램 실행에 필요한 파일을 불러오는 중 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
					Process.GetCurrentProcess( ).Kill( );
					return;
				}

				Application.EnableVisualStyles( );
				Application.SetCompatibleTextRenderingDefault( false );
				Application.Run( new Main( ) );
				mutex.ReleaseMutex( );
			}
			else
			{
				NotifyBox.Show( null, "오류", "죄송합니다, 우윳빛깔 카페스탭이 이미 실행 중 입니다.", NotifyBoxType.OK, NotifyBoxIcon.Warning );
			}
		}
	}
}
