namespace CafeMaster_UI.Interface
{
	partial class MemberActivityStopListChild
	{
		/// <summary> 
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region 구성 요소 디자이너에서 생성한 코드

		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent( )
		{
			this.components = new System.ComponentModel.Container();
			this.PROFILE_IMAGE = new System.Windows.Forms.PictureBox();
			this.NICKNAME_LABEL = new System.Windows.Forms.Label();
			this.REASON_LABEL = new System.Windows.Forms.Label();
			this.BEGIN_END_DATE_LABEL = new System.Windows.Forms.Label();
			this.WORK_STAFF_INFORMATION = new System.Windows.Forms.Label();
			this.OPEN_MEMBER_INFORMATION = new CafeMaster_UI.Interface.FlatButton();
			this.TOOL_TIP = new System.Windows.Forms.ToolTip(this.components);
			this.MEMBER_ACTIVITY_STOP_REMOVE_BUTTON = new CafeMaster_UI.Interface.FlatImageButton();
			((System.ComponentModel.ISupportInitialize)(this.PROFILE_IMAGE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MEMBER_ACTIVITY_STOP_REMOVE_BUTTON)).BeginInit();
			this.SuspendLayout();
			// 
			// PROFILE_IMAGE
			// 
			this.PROFILE_IMAGE.BackColor = System.Drawing.Color.Transparent;
			this.PROFILE_IMAGE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.PROFILE_IMAGE.Image = global::CafeMaster_UI.Properties.Resources.PROFILE_UNKNOWN_V2_120x120;
			this.PROFILE_IMAGE.Location = new System.Drawing.Point(0, 0);
			this.PROFILE_IMAGE.Name = "PROFILE_IMAGE";
			this.PROFILE_IMAGE.Size = new System.Drawing.Size(85, 85);
			this.PROFILE_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PROFILE_IMAGE.TabIndex = 20;
			this.PROFILE_IMAGE.TabStop = false;
			// 
			// NICKNAME_LABEL
			// 
			this.NICKNAME_LABEL.AutoEllipsis = true;
			this.NICKNAME_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.NICKNAME_LABEL.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.NICKNAME_LABEL.ForeColor = System.Drawing.SystemColors.ControlText;
			this.NICKNAME_LABEL.Location = new System.Drawing.Point(99, 6);
			this.NICKNAME_LABEL.Name = "NICKNAME_LABEL";
			this.NICKNAME_LABEL.Size = new System.Drawing.Size(412, 20);
			this.NICKNAME_LABEL.TabIndex = 21;
			this.NICKNAME_LABEL.Text = "NICKNAME";
			// 
			// REASON_LABEL
			// 
			this.REASON_LABEL.AutoEllipsis = true;
			this.REASON_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.REASON_LABEL.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.REASON_LABEL.ForeColor = System.Drawing.SystemColors.ControlText;
			this.REASON_LABEL.Location = new System.Drawing.Point(99, 26);
			this.REASON_LABEL.Name = "REASON_LABEL";
			this.REASON_LABEL.Size = new System.Drawing.Size(340, 34);
			this.REASON_LABEL.TabIndex = 22;
			this.REASON_LABEL.Text = "NICKNAME";
			// 
			// BEGIN_END_DATE_LABEL
			// 
			this.BEGIN_END_DATE_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.BEGIN_END_DATE_LABEL.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.BEGIN_END_DATE_LABEL.ForeColor = System.Drawing.Color.Red;
			this.BEGIN_END_DATE_LABEL.Location = new System.Drawing.Point(327, 63);
			this.BEGIN_END_DATE_LABEL.Name = "BEGIN_END_DATE_LABEL";
			this.BEGIN_END_DATE_LABEL.Size = new System.Drawing.Size(220, 15);
			this.BEGIN_END_DATE_LABEL.TabIndex = 23;
			this.BEGIN_END_DATE_LABEL.Text = "1990.01.01 ~ 2017.05.01";
			this.BEGIN_END_DATE_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// WORK_STAFF_INFORMATION
			// 
			this.WORK_STAFF_INFORMATION.BackColor = System.Drawing.Color.Transparent;
			this.WORK_STAFF_INFORMATION.Cursor = System.Windows.Forms.Cursors.Hand;
			this.WORK_STAFF_INFORMATION.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.WORK_STAFF_INFORMATION.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WORK_STAFF_INFORMATION.Location = new System.Drawing.Point(99, 63);
			this.WORK_STAFF_INFORMATION.Name = "WORK_STAFF_INFORMATION";
			this.WORK_STAFF_INFORMATION.Size = new System.Drawing.Size(222, 15);
			this.WORK_STAFF_INFORMATION.TabIndex = 24;
			this.WORK_STAFF_INFORMATION.Text = "활동 정지 by NULL(NULL)";
			this.WORK_STAFF_INFORMATION.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.TOOL_TIP.SetToolTip(this.WORK_STAFF_INFORMATION, "활동 정지 처리한 스탭의 정보 보기");
			this.WORK_STAFF_INFORMATION.Click += new System.EventHandler(this.WORK_STAFF_INFORMATION_Click);
			// 
			// OPEN_MEMBER_INFORMATION
			// 
			this.OPEN_MEMBER_INFORMATION.AnimationLerpP = 0.8F;
			this.OPEN_MEMBER_INFORMATION.BackColor = System.Drawing.Color.Transparent;
			this.OPEN_MEMBER_INFORMATION.ButtonText = "멤버 정보 열기";
			this.OPEN_MEMBER_INFORMATION.ButtonTextColor = System.Drawing.Color.Black;
			this.OPEN_MEMBER_INFORMATION.Cursor = System.Windows.Forms.Cursors.Hand;
			this.OPEN_MEMBER_INFORMATION.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.OPEN_MEMBER_INFORMATION.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.OPEN_MEMBER_INFORMATION.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.OPEN_MEMBER_INFORMATION.Location = new System.Drawing.Point(445, 41);
			this.OPEN_MEMBER_INFORMATION.Name = "OPEN_MEMBER_INFORMATION";
			this.OPEN_MEMBER_INFORMATION.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.OPEN_MEMBER_INFORMATION.Size = new System.Drawing.Size(102, 19);
			this.OPEN_MEMBER_INFORMATION.TabIndex = 26;
			this.OPEN_MEMBER_INFORMATION.Text = "멤버 정보 열기";
			this.OPEN_MEMBER_INFORMATION.UseVisualStyleBackColor = false;
			this.OPEN_MEMBER_INFORMATION.Click += new System.EventHandler(this.OPEN_MEMBER_INFORMATION_Click);
			// 
			// MEMBER_ACTIVITY_STOP_REMOVE_BUTTON
			// 
			this.MEMBER_ACTIVITY_STOP_REMOVE_BUTTON.AnimationLerpP = 0.8F;
			this.MEMBER_ACTIVITY_STOP_REMOVE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.MEMBER_ACTIVITY_STOP_REMOVE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.MEMBER_ACTIVITY_STOP_REMOVE_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.Red;
			this.MEMBER_ACTIVITY_STOP_REMOVE_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.MEMBER_ACTIVITY_STOP_ICON;
			this.MEMBER_ACTIVITY_STOP_REMOVE_BUTTON.Location = new System.Drawing.Point(517, 3);
			this.MEMBER_ACTIVITY_STOP_REMOVE_BUTTON.Name = "MEMBER_ACTIVITY_STOP_REMOVE_BUTTON";
			this.MEMBER_ACTIVITY_STOP_REMOVE_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.Crimson;
			this.MEMBER_ACTIVITY_STOP_REMOVE_BUTTON.Size = new System.Drawing.Size(30, 25);
			this.MEMBER_ACTIVITY_STOP_REMOVE_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.MEMBER_ACTIVITY_STOP_REMOVE_BUTTON.TabIndex = 27;
			this.MEMBER_ACTIVITY_STOP_REMOVE_BUTTON.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.MEMBER_ACTIVITY_STOP_REMOVE_BUTTON, "활동 정지 해제");
			this.MEMBER_ACTIVITY_STOP_REMOVE_BUTTON.Click += new System.EventHandler(this.MEMBER_ACTIVITY_STOP_REMOVE_BUTTON_Click);
			// 
			// MemberActivityStopListChild
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.MEMBER_ACTIVITY_STOP_REMOVE_BUTTON);
			this.Controls.Add(this.OPEN_MEMBER_INFORMATION);
			this.Controls.Add(this.WORK_STAFF_INFORMATION);
			this.Controls.Add(this.BEGIN_END_DATE_LABEL);
			this.Controls.Add(this.REASON_LABEL);
			this.Controls.Add(this.NICKNAME_LABEL);
			this.Controls.Add(this.PROFILE_IMAGE);
			this.Name = "MemberActivityStopListChild";
			this.Size = new System.Drawing.Size(550, 85);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MemberActivityStopListChild_Paint);
			((System.ComponentModel.ISupportInitialize)(this.PROFILE_IMAGE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MEMBER_ACTIVITY_STOP_REMOVE_BUTTON)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox PROFILE_IMAGE;
		private System.Windows.Forms.Label NICKNAME_LABEL;
		private System.Windows.Forms.Label REASON_LABEL;
		private System.Windows.Forms.Label BEGIN_END_DATE_LABEL;
		private System.Windows.Forms.Label WORK_STAFF_INFORMATION;
		private FlatButton OPEN_MEMBER_INFORMATION;
		private System.Windows.Forms.ToolTip TOOL_TIP;
		private FlatImageButton MEMBER_ACTIVITY_STOP_REMOVE_BUTTON;
	}
}
