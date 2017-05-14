using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeMaster_UI.Lib;

namespace CafeMaster_UI.Interface
{
	public partial class MemberActivityStopListChild : UserControl
	{
		private Pen lineDrawer = new Pen( GlobalVar.MasterColor );
		private MemberActivityStopListStruct tempData;
		//private string id;

		public MemberActivityStopListChild( MemberActivityStopListStruct data )
		{
			InitializeComponent( );

			this.NICKNAME_LABEL.Text = data.nickname;
			this.REASON_LABEL.Text = data.reason;
			this.BEGIN_END_DATE_LABEL.Text = "정지 기간 : " + data.startDate + " ~ " + data.endDate.Replace( "*", "무기한" );
			this.WORK_STAFF_INFORMATION.Text = "활동 정지 by " + data.doStaffNickname;

			this.tempData = data;

			if ( data.profileImage.Contains( "cafe_profile3_45x45.gif" ) ) // 수정 필요
			{
				this.PROFILE_IMAGE.Image = Properties.Resources.PROFILE_UNKNOWN_V2_120x120;
			}
			else
			{
				try
				{
					this.PROFILE_IMAGE.Load( data.profileImage );
				}
				catch ( Exception ex )
				{
					//수정필요;
					//Utility.WriteErrorLog( ex );
				}
			}

		}

		private void MemberActivityStopListChild_Paint( object sender, PaintEventArgs e )
		{
			int w = this.Width, h = this.Height;

			e.Graphics.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
		}

		private void OPEN_MEMBER_INFORMATION_Click( object sender, EventArgs e )
		{
			Utility.OpenWebPage( GlobalVar.CAFE_MEMBER_NETWORK_VIEW_URL + this.tempData.id );
		}

		private void WORK_STAFF_INFORMATION_Click( object sender, EventArgs e )
		{
			//this.tempData.doStaffNickname.Substring( this.tempData.doStaffNickname.IndexOf( '(' ) + 1, this.tempData.doStaffNickname.Length - this.tempData.doStaffNickname.IndexOf( '(' ) - 2 );
			Utility.OpenWebPage( GlobalVar.CAFE_MEMBER_NETWORK_VIEW_URL + Utility.GetNaverIDFromNicknameString( this.tempData.doStaffNickname ) );
		}

		private void MEMBER_ACTIVITY_STOP_REMOVE_BUTTON_Click( object sender, EventArgs e )
		{
			if ( NotifyBox.Show( null, "경고", "닉네임 : " + this.tempData.nickname + "\n사유 : " +this.tempData.reason + "\n정지 기간 : " + this.tempData.startDate + " ~ " + this.tempData.endDate.Replace( "*", "무기한" ) + "\n활동 정지 처리한 스탭 : " + this.tempData.doStaffNickname + "\n\n모든 정보를 다시 확인하시고 확인 버튼을 눌러주세요 ^.^", NotifyBoxType.YesNo, NotifyBoxIcon.Danger ) == NotifyBoxResult.Yes )
			{
				if ( NotifyBox.Show( null, "경고", "정말로 정말로!!! " + this.tempData.nickname + " 회원의 활동 정지를 해제하시길 원하십니까?", NotifyBoxType.YesNo, NotifyBoxIcon.Danger ) == NotifyBoxResult.Yes )
				{
					Tuple<bool, string> result = NaverRequest.RemoveMemberActivityStop( this.tempData.id );

					if ( result.Item1 )
					{
						NotifyBox.Show( null, "활동 정지 해제 완료", "활동 정지를 성공적으로 해제했습니다, 활동 정지 리스트가 표시됩니다, 변경 내역을 확인해주세요.", NotifyBoxType.OK, NotifyBoxIcon.Danger );
						( this.ParentForm as MemberActivityStopListForm ).BuildList( );

						Utility.OpenWebPage( GlobalVar.CAFE_STOP_ACTIVITY_LIST_URL );
					}
					else
					{
						NotifyBox.Show( null, "오류", "죄송합니다, 활동 정지를 해제 하는 도중 오류가 발생했습니다.\n\n" + result.Item2, NotifyBoxType.OK, NotifyBoxIcon.Error );
					}
				}
			}
		}
	}
}
