using CafeMaster_UI.Lib;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CafeMaster_UI.Interface
{
	public partial class OptionForm : Form
	{
		private Point startPoint;
		private Pen lineDrawer = new Pen( GlobalVar.MasterColor )
		{
			Width = 1
		};
		private bool isInitialize = false;

		public OptionForm( )
		{
			InitializeComponent( );

			this.SetStyle( ControlStyles.ResizeRedraw, true );
			this.SetStyle( ControlStyles.OptimizedDoubleBuffer, true );
		}

		private void OptionForm_Load( object sender, EventArgs e )
		{
			isInitialize = true;

			try
			{
				// http://blog.suromind.com/85
				Microsoft.Win32.RegistryKey registryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey( @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run" );

				if ( registryKey.GetValue( "MilkPowerCafeStaff" ) == null )
				{
					this.OPTION_1_OBJECT.Status = false;
				}
				else
				{
					if ( registryKey.GetValue( "MilkPowerCafeStaff" ).ToString( ).ToLower( ) == ( Application.ExecutablePath.ToString( ).Replace( "/", "\\" ) + " -winstart" ).ToLower( ) )
					{
						this.OPTION_1_OBJECT.Status = true;
					}
					else
					{
						this.OPTION_1_OBJECT.Status = false;
					}
				}

				int option1Result = 30;

				if ( int.TryParse( Config.Get( "SyncInterval", "30" ), out option1Result ) )
				{
					this.OPTION_2_OBJECT_1.Value = option1Result;
				}
				else
				{
					this.OPTION_2_OBJECT_1.Value = 30;
					Config.Set( "SyncInterval", "30" );
				}

				this.OPTION_3_OBJECT.Status = Config.Get( "CaptureEnable", "1" ) == "1";
				this.OPTION_4_OBJECT.Status = Config.Get( "UXSendEnable", "1" ) == "1";
			}
			catch { }

			isInitialize = false;
		}

		private void APP_TITLE_BAR_MouseMove( object sender, MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Left )
			{
				this.Location = new Point(
					this.Left - ( startPoint.X - e.X ),
					Math.Max( this.Top - ( startPoint.Y - e.Y ), Screen.FromHandle( this.Handle ).WorkingArea.Top )
				);
			}
		}

		private void APP_TITLE_BAR_MouseDown( object sender, MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Left )
				startPoint = e.Location;
		}

		private void APP_TITLE_BAR_Paint( object sender, PaintEventArgs e )
		{
			int w = this.APP_TITLE_BAR.Width, h = this.APP_TITLE_BAR.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // 위
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // 왼쪽
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // 오른쪽
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
		}

		private void CLOSE_BUTTON_Click( object sender, EventArgs e )
		{
			this.Close( );
		}

		private void OptionForm_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // 위
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // 왼쪽
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // 오른쪽
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
		}

		private void INIT_DB_BUTTON_Click( object sender, EventArgs e )
		{
			if ( NotifyBox.Show( this, "데이터 초기화", "모든 설정, 계정 정보, 캡처된 이미지, 데이터를 초기화합니다.", NotifyBoxType.YesNo, NotifyBoxIcon.Question ) == NotifyBoxResult.Yes )
			{
				if ( NotifyBox.Show( this, "데이터 초기화", "이 작업을 실행하면 되돌릴 수 없습니다, 정.말.로 하시겠습니까?", NotifyBoxType.YesNo, NotifyBoxIcon.Warning ) == NotifyBoxResult.Yes )
				{
					try
					{
						Microsoft.Win32.RegistryKey registryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey( @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true );

						if ( registryKey.GetValue( "MilkPowerCafeStaff" ) != null )
						{
							registryKey.DeleteValue( "MilkPowerCafeStaff", false );
						}

						System.IO.Directory.Delete( GlobalVar.CAPTURE_DIR, true );
						System.IO.Directory.Delete( GlobalVar.DATA_DIR, true );

						NotifyBox.Show( this, "데이터 초기화 완료", "모든 데이터를 초기화했습니다, 프로그램을 다시 시작하세요.", NotifyBoxType.OK, NotifyBoxIcon.Information );
						Application.Exit( );
					}
					catch ( Exception ex )
					{
						Utility.WriteErrorLog( ex.Message, Utility.LogSeverity.EXCEPTION );
						NotifyBox.Show( this, "오류", "죄송합니다, 데이터를 초기화하는 중 오류가 발생했습니다.", NotifyBoxType.OK, NotifyBoxIcon.Error );
					}
				}
			}
		}

		private void OPTION_1_OBJECT_StatusChanged( object sender, EventArgs e )
		{
			if ( isInitialize ) return;

			// http://blog.suromind.com/85
			Microsoft.Win32.RegistryKey registryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey( @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true );

			if ( registryKey.GetValue( "MilkPowerCafeStaff" ) == null )
			{
				registryKey.SetValue( "MilkPowerCafeStaff", Application.ExecutablePath.ToString( ).Replace( "/", "\\" ) + " -winstart" );
			}
			else
			{
				registryKey.DeleteValue( "MilkPowerCafeStaff", false );
			}
		}

		private void OPTION_2_OBJECT_1_ValueChanged( object sender, EventArgs e )
		{
			if ( isInitialize ) return;

			short sec = ( short ) this.OPTION_2_OBJECT_1.Value;

			Config.Set( "SyncInterval", sec.ToString( ) );
			Observer.ChangeInterval( sec );
		}

		private void OPTION_3_OBJECT_StatusChanged( object sender, EventArgs e )
		{
			if ( isInitialize ) return;

			Config.Set( "CaptureEnable", this.OPTION_3_OBJECT.Status == true ? "1" : "0" );
		}

		private void OPTION_4_OBJECT_StatusChanged( object sender, EventArgs e )
		{
			if ( isInitialize ) return;

			if ( this.OPTION_4_OBJECT.Status )
			{
				if ( NotifyBox.Show( this, "사용자 환경 개선 서비스 안내", "사용자 환경 개선 서비스에 가입하면 자동으로 정보를 서버에 전송합니다.\n예를 들어 윈도우 버전 정보, 프로그램 버전 등의 정보를 전송할 수 있습니다, 이 정보를 이용하여 프로그램과 서비스 환경을 개선합니다, 서버에 전송하는 정보에 개인 정보는 포함되지 않습니다.\n가입하시겠습니까?", NotifyBoxType.YesNo, NotifyBoxIcon.Question ) == NotifyBoxResult.No )
				{
					this.OPTION_4_OBJECT.Status = false;
					return;
				}
			}

			Config.Set( "UXSendEnable", this.OPTION_4_OBJECT.Status == true ? "1" : "0" );
		}

		private void OPTION_5_OBJECT_Click( object sender, EventArgs e )
		{
			if ( AutoLogin.IsEnabled( ) )
			{
				( new AutoLoginManagerForm( ) ).ShowDialog( );
			}
			else
			{
				( new AutoLoginSettingForm( ) ).ShowDialog( );
			}
		}
	}
}
