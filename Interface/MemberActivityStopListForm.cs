using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeMaster_UI.Lib;

namespace CafeMaster_UI.Interface
{
	public partial class MemberActivityStopListForm : Form
	{
		private Point startPoint;
		private Pen lineDrawer = new Pen( GlobalVar.MasterColor )
		{
			Width = 1
		};

		public MemberActivityStopListForm( )
		{
			InitializeComponent( );

			this.SetStyle( ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true );
			this.UpdateStyles( );
			this.Opacity = 0;
		}

		private void UserWarnOptionForm_Load( object sender, EventArgs e )
		{
			Animation.UI.FadeIn( this );
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

		private void CLOSE_BUTTON_Click( object sender, EventArgs e )
		{
			this.Close( );
		}

		private void UserWarnOptionForm_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // 위
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // 왼쪽
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // 오른쪽
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
		}

		private void APP_TITLE_BAR_Paint( object sender, PaintEventArgs e )
		{
			int w = this.APP_TITLE_BAR.Width, h = this.APP_TITLE_BAR.Height;

			e.Graphics.DrawLine( lineDrawer, 0, 0, w, 0 ); // 위
			e.Graphics.DrawLine( lineDrawer, 0, 0, 0, h ); // 왼쪽
			e.Graphics.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // 오른쪽
			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
		}

		private void MemberActivityStopListForm_Shown( object sender, EventArgs e )
		{
			BuildList( );
		}

		public void BuildList( )
		{
			this.MEMBER_ACTIVITY_STOP_LIST_PANEL.Controls.Clear( );

			ChangeUIStatus( true );

			Task.Factory.StartNew( async ( ) =>
			{
				Tuple<bool, List<MemberActivityStopListStruct>, string> data = NaverRequest.GetMemberActivityStopList( );

				await Task.Delay( 1000 );

				if ( data.Item1 )
				{
					int y = 10;

					if ( this.InvokeRequired )
					{
						this.Invoke( new Action( ( ) =>
						{
							this.MEMBER_ACTIVITY_STOP_LIST_COUNT_LABEL.Text = data.Item2.Count + "명의 활동 정지된 회원이 있습니다.";

							foreach ( MemberActivityStopListStruct i in data.Item2 )
							{
								MemberActivityStopListChild panel = new MemberActivityStopListChild( i );
								panel.Location = new Point( 10, y );

								y += panel.Height + 5;

								this.MEMBER_ACTIVITY_STOP_LIST_PANEL.Controls.Add( panel );
							}

							ChangeUIStatus( false );
						} ) );
					}
					else
					{
						this.MEMBER_ACTIVITY_STOP_LIST_COUNT_LABEL.Text = data.Item2.Count + "명의 활동 정지된 회원이 있습니다.";

						foreach ( MemberActivityStopListStruct i in data.Item2 )
						{
							MemberActivityStopListChild panel = new MemberActivityStopListChild( i );
							panel.Location = new Point( 10, y );

							y += panel.Height + 5;

							this.MEMBER_ACTIVITY_STOP_LIST_PANEL.Controls.Add( panel );
						}

						ChangeUIStatus( false );
					}
				}
				else
				{
					NotifyBox.Show( this, "오류", "죄송합니다, 활동 정지 데이터를 불러올 수 없습니다,\n\n" + data.Item3, NotifyBoxType.OK, NotifyBoxIcon.Error );
				}
			} );
		}

		private void ChangeUIStatus( bool value )
		{
			this.MEMBER_ACTIVITY_STOP_LIST_PANEL.Enabled = !value;
			this.LOADING_LABEL.Visible = value;

			if ( value )
				this.DotAnimationTimer.Start( );
			else
				this.DotAnimationTimer.Stop( );
		}

		private void ACTIVITY_STOP_RUN_BUTTON_Click( object sender, EventArgs e )
		{
			this.Opacity = 0;

			( new MemberActivityStopForm( ) ).ShowDialog( );

			this.Opacity = 1;
			BuildList( );
		}

		byte dotCount = 0;
		private void DotAnimationTimer_Tick( object sender, EventArgs e )
		{
			if ( dotCount > 2 )
			{
				dotCount = 0;
				if ( this.LOADING_LABEL.Text.Length > 3 )
					this.LOADING_LABEL.Text = this.LOADING_LABEL.Text.Substring( 0, this.LOADING_LABEL.Text.Length - 3 );
			}
			else
			{
				this.LOADING_LABEL.Text = this.LOADING_LABEL.Text + ".";
				dotCount++;
			}
		}
	}
}
