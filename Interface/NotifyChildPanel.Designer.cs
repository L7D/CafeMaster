namespace CafeMaster_UI.Interface
{
	partial class NotifyChildPanel
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
			this.TITLE_LABEL = new System.Windows.Forms.Label();
			this.NUMBER_LABEL = new System.Windows.Forms.Label();
			this.AUTHOR_LABEL = new System.Windows.Forms.Label();
			this.HIT_LABEL = new System.Windows.Forms.Label();
			this.TIME_LABEL = new System.Windows.Forms.Label();
			this.TOOL_TIP = new System.Windows.Forms.ToolTip(this.components);
			this.BOARD_NAME_LABEL = new System.Windows.Forms.Label();
			this.OPEN_BUTTON = new CafeMaster_UI.Interface.FlatButton();
			this.RANK_LABEL = new System.Windows.Forms.Label();
			this.THIS_SELECT_BUTTON = new System.Windows.Forms.PictureBox();
			this.IMAGE_VIEW_BUTTON = new System.Windows.Forms.PictureBox();
			this.MEMBER_ACTIVITY_STOP_BUTTON = new System.Windows.Forms.PictureBox();
			this.MEMBER_WARN_BUTTON = new System.Windows.Forms.PictureBox();
			this.NOTIFY_DELETE_BUTTON = new System.Windows.Forms.PictureBox();
			this.THREAD_DELETE_BUTTON = new System.Windows.Forms.PictureBox();
			this.ADMIN_ICON = new System.Windows.Forms.PictureBox();
			this.FOCUS_BUTTON = new CafeMaster_UI.Interface.FlatImageButton();
			this.TIME_ICON = new System.Windows.Forms.PictureBox();
			this.AUTHOR_ICON = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.THIS_SELECT_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.IMAGE_VIEW_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MEMBER_ACTIVITY_STOP_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MEMBER_WARN_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NOTIFY_DELETE_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.THREAD_DELETE_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ADMIN_ICON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FOCUS_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TIME_ICON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AUTHOR_ICON)).BeginInit();
			this.SuspendLayout();
			// 
			// TITLE_LABEL
			// 
			this.TITLE_LABEL.AutoEllipsis = true;
			this.TITLE_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.TITLE_LABEL.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.TITLE_LABEL.Location = new System.Drawing.Point(59, 32);
			this.TITLE_LABEL.Name = "TITLE_LABEL";
			this.TITLE_LABEL.Size = new System.Drawing.Size(362, 19);
			this.TITLE_LABEL.TabIndex = 0;
			this.TITLE_LABEL.Text = "TEST";
			this.TITLE_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.TITLE_LABEL.UseMnemonic = false;
			// 
			// NUMBER_LABEL
			// 
			this.NUMBER_LABEL.AutoSize = true;
			this.NUMBER_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.NUMBER_LABEL.Font = new System.Drawing.Font("나눔고딕", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.NUMBER_LABEL.Location = new System.Drawing.Point(468, 101);
			this.NUMBER_LABEL.Name = "NUMBER_LABEL";
			this.NUMBER_LABEL.Size = new System.Drawing.Size(56, 13);
			this.NUMBER_LABEL.TabIndex = 1;
			this.NUMBER_LABEL.Text = "#000000";
			this.NUMBER_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.TOOL_TIP.SetToolTip(this.NUMBER_LABEL, "게시물 고유번호");
			// 
			// AUTHOR_LABEL
			// 
			this.AUTHOR_LABEL.AutoSize = true;
			this.AUTHOR_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.AUTHOR_LABEL.Cursor = System.Windows.Forms.Cursors.Hand;
			this.AUTHOR_LABEL.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.AUTHOR_LABEL.Location = new System.Drawing.Point(34, 64);
			this.AUTHOR_LABEL.Name = "AUTHOR_LABEL";
			this.AUTHOR_LABEL.Size = new System.Drawing.Size(37, 14);
			this.AUTHOR_LABEL.TabIndex = 2;
			this.AUTHOR_LABEL.Text = "USER";
			this.AUTHOR_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.TOOL_TIP.SetToolTip(this.AUTHOR_LABEL, "해당 멤버 정보 보기");
			this.AUTHOR_LABEL.Click += new System.EventHandler(this.AUTHOR_LABEL_Click);
			// 
			// HIT_LABEL
			// 
			this.HIT_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.HIT_LABEL.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.HIT_LABEL.Location = new System.Drawing.Point(385, 72);
			this.HIT_LABEL.Name = "HIT_LABEL";
			this.HIT_LABEL.Size = new System.Drawing.Size(142, 29);
			this.HIT_LABEL.TabIndex = 5;
			this.HIT_LABEL.Text = "1 V";
			this.HIT_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.TOOL_TIP.SetToolTip(this.HIT_LABEL, "조회수");
			// 
			// TIME_LABEL
			// 
			this.TIME_LABEL.AutoSize = true;
			this.TIME_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.TIME_LABEL.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.TIME_LABEL.Location = new System.Drawing.Point(34, 94);
			this.TIME_LABEL.Name = "TIME_LABEL";
			this.TIME_LABEL.Size = new System.Drawing.Size(36, 14);
			this.TIME_LABEL.TabIndex = 8;
			this.TIME_LABEL.Text = "TIME";
			this.TIME_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TOOL_TIP
			// 
			this.TOOL_TIP.BackColor = System.Drawing.Color.White;
			// 
			// BOARD_NAME_LABEL
			// 
			this.BOARD_NAME_LABEL.AutoEllipsis = true;
			this.BOARD_NAME_LABEL.AutoSize = true;
			this.BOARD_NAME_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.BOARD_NAME_LABEL.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.BOARD_NAME_LABEL.Location = new System.Drawing.Point(59, 9);
			this.BOARD_NAME_LABEL.Name = "BOARD_NAME_LABEL";
			this.BOARD_NAME_LABEL.Size = new System.Drawing.Size(35, 14);
			this.BOARD_NAME_LABEL.TabIndex = 20;
			this.BOARD_NAME_LABEL.Text = "TEST";
			this.BOARD_NAME_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.TOOL_TIP.SetToolTip(this.BOARD_NAME_LABEL, "게시판 이름");
			this.BOARD_NAME_LABEL.UseMnemonic = false;
			// 
			// OPEN_BUTTON
			// 
			this.OPEN_BUTTON.AnimationLerpP = 0.8F;
			this.OPEN_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.OPEN_BUTTON.ButtonText = "게시글 열기";
			this.OPEN_BUTTON.ButtonTextColor = System.Drawing.Color.Black;
			this.OPEN_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.OPEN_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.LightGray;
			this.OPEN_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.OPEN_BUTTON.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.OPEN_BUTTON.Location = new System.Drawing.Point(427, 34);
			this.OPEN_BUTTON.Name = "OPEN_BUTTON";
			this.OPEN_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.OPEN_BUTTON.Size = new System.Drawing.Size(100, 35);
			this.OPEN_BUTTON.TabIndex = 13;
			this.OPEN_BUTTON.Text = "게시글 열기";
			this.TOOL_TIP.SetToolTip(this.OPEN_BUTTON, "게시글을 엽니다.");
			this.OPEN_BUTTON.UseVisualStyleBackColor = false;
			this.OPEN_BUTTON.Click += new System.EventHandler(this.OPEN_BUTTON_Click);
			// 
			// RANK_LABEL
			// 
			this.RANK_LABEL.AutoSize = true;
			this.RANK_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.RANK_LABEL.Cursor = System.Windows.Forms.Cursors.Default;
			this.RANK_LABEL.Font = new System.Drawing.Font("나눔고딕", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.RANK_LABEL.ForeColor = System.Drawing.Color.SteelBlue;
			this.RANK_LABEL.Location = new System.Drawing.Point(77, 64);
			this.RANK_LABEL.Name = "RANK_LABEL";
			this.RANK_LABEL.Size = new System.Drawing.Size(47, 13);
			this.RANK_LABEL.TabIndex = 27;
			this.RANK_LABEL.Text = "새싹멤버";
			this.RANK_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// THIS_SELECT_BUTTON
			// 
			this.THIS_SELECT_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.THIS_SELECT_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.THIS_SELECT_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.NOTIFY_SELECT_NOPE_ICON;
			this.THIS_SELECT_BUTTON.Location = new System.Drawing.Point(3, 3);
			this.THIS_SELECT_BUTTON.Name = "THIS_SELECT_BUTTON";
			this.THIS_SELECT_BUTTON.Size = new System.Drawing.Size(50, 50);
			this.THIS_SELECT_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.THIS_SELECT_BUTTON.TabIndex = 33;
			this.THIS_SELECT_BUTTON.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.THIS_SELECT_BUTTON, "이 알림 선택 / 선택 해제");
			this.THIS_SELECT_BUTTON.Click += new System.EventHandler(this.THIS_SELECT_BUTTON_Click);
			// 
			// IMAGE_VIEW_BUTTON
			// 
			this.IMAGE_VIEW_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.IMAGE_VIEW_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.IMAGE_VIEW_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.IMAGE_VIEW_ICON;
			this.IMAGE_VIEW_BUTTON.Location = new System.Drawing.Point(378, 3);
			this.IMAGE_VIEW_BUTTON.Name = "IMAGE_VIEW_BUTTON";
			this.IMAGE_VIEW_BUTTON.Size = new System.Drawing.Size(25, 25);
			this.IMAGE_VIEW_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.IMAGE_VIEW_BUTTON.TabIndex = 32;
			this.IMAGE_VIEW_BUTTON.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.IMAGE_VIEW_BUTTON, "캡처된 이미지 열기");
			this.IMAGE_VIEW_BUTTON.Click += new System.EventHandler(this.IMAGE_VIEW_BUTTON_Click);
			// 
			// MEMBER_ACTIVITY_STOP_BUTTON
			// 
			this.MEMBER_ACTIVITY_STOP_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.MEMBER_ACTIVITY_STOP_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.MEMBER_ACTIVITY_STOP_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.MEMBER_ACTIVITY_STOP_ICON;
			this.MEMBER_ACTIVITY_STOP_BUTTON.Location = new System.Drawing.Point(440, 3);
			this.MEMBER_ACTIVITY_STOP_BUTTON.Name = "MEMBER_ACTIVITY_STOP_BUTTON";
			this.MEMBER_ACTIVITY_STOP_BUTTON.Size = new System.Drawing.Size(25, 25);
			this.MEMBER_ACTIVITY_STOP_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.MEMBER_ACTIVITY_STOP_BUTTON.TabIndex = 31;
			this.MEMBER_ACTIVITY_STOP_BUTTON.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.MEMBER_ACTIVITY_STOP_BUTTON, "회원 활동 정지");
			this.MEMBER_ACTIVITY_STOP_BUTTON.Click += new System.EventHandler(this.MEMBER_ACTIVITY_STOP_BUTTON_Click);
			// 
			// MEMBER_WARN_BUTTON
			// 
			this.MEMBER_WARN_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.MEMBER_WARN_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.MEMBER_WARN_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.USER_WARN_ICON;
			this.MEMBER_WARN_BUTTON.Location = new System.Drawing.Point(409, 3);
			this.MEMBER_WARN_BUTTON.Name = "MEMBER_WARN_BUTTON";
			this.MEMBER_WARN_BUTTON.Size = new System.Drawing.Size(25, 25);
			this.MEMBER_WARN_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.MEMBER_WARN_BUTTON.TabIndex = 30;
			this.MEMBER_WARN_BUTTON.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.MEMBER_WARN_BUTTON, "회원 경고");
			this.MEMBER_WARN_BUTTON.Click += new System.EventHandler(this.MEMBER_WARN_BUTTON_Click);
			// 
			// NOTIFY_DELETE_BUTTON
			// 
			this.NOTIFY_DELETE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.NOTIFY_DELETE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NOTIFY_DELETE_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.NOTIFY_REMOVE;
			this.NOTIFY_DELETE_BUTTON.Location = new System.Drawing.Point(471, 3);
			this.NOTIFY_DELETE_BUTTON.Name = "NOTIFY_DELETE_BUTTON";
			this.NOTIFY_DELETE_BUTTON.Size = new System.Drawing.Size(25, 25);
			this.NOTIFY_DELETE_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.NOTIFY_DELETE_BUTTON.TabIndex = 29;
			this.NOTIFY_DELETE_BUTTON.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.NOTIFY_DELETE_BUTTON, "알림 삭제");
			this.NOTIFY_DELETE_BUTTON.Click += new System.EventHandler(this.NOTIFY_DELETE_BUTTON_Click);
			// 
			// THREAD_DELETE_BUTTON
			// 
			this.THREAD_DELETE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.THREAD_DELETE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.THREAD_DELETE_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.REMOVE_ICON;
			this.THREAD_DELETE_BUTTON.Location = new System.Drawing.Point(502, 3);
			this.THREAD_DELETE_BUTTON.Name = "THREAD_DELETE_BUTTON";
			this.THREAD_DELETE_BUTTON.Size = new System.Drawing.Size(25, 25);
			this.THREAD_DELETE_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.THREAD_DELETE_BUTTON.TabIndex = 28;
			this.THREAD_DELETE_BUTTON.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.THREAD_DELETE_BUTTON, "실제 게시물과 알림 삭제");
			this.THREAD_DELETE_BUTTON.Click += new System.EventHandler(this.THREAD_DELETE_BUTTON_Click);
			// 
			// ADMIN_ICON
			// 
			this.ADMIN_ICON.BackColor = System.Drawing.Color.Transparent;
			this.ADMIN_ICON.Image = global::CafeMaster_UI.Properties.Resources.ADMIN_SHIELD;
			this.ADMIN_ICON.Location = new System.Drawing.Point(77, 61);
			this.ADMIN_ICON.Name = "ADMIN_ICON";
			this.ADMIN_ICON.Size = new System.Drawing.Size(20, 20);
			this.ADMIN_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ADMIN_ICON.TabIndex = 21;
			this.ADMIN_ICON.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.ADMIN_ICON, "스탭 게시물");
			this.ADMIN_ICON.Visible = false;
			this.ADMIN_ICON.Click += new System.EventHandler(this.ADMIN_ICON_Click);
			// 
			// FOCUS_BUTTON
			// 
			this.FOCUS_BUTTON.AnimationLerpP = 0.8F;
			this.FOCUS_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.FOCUS_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.FOCUS_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.Gold;
			this.FOCUS_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.THUNDER;
			this.FOCUS_BUTTON.Location = new System.Drawing.Point(349, 86);
			this.FOCUS_BUTTON.Name = "FOCUS_BUTTON";
			this.FOCUS_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.Gray;
			this.FOCUS_BUTTON.Size = new System.Drawing.Size(30, 30);
			this.FOCUS_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.FOCUS_BUTTON.TabIndex = 11;
			this.FOCUS_BUTTON.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.FOCUS_BUTTON, "주시 활성화 / 비활성화");
			this.FOCUS_BUTTON.Visible = false;
			this.FOCUS_BUTTON.Click += new System.EventHandler(this.FOCUS_BUTTON_Click);
			// 
			// TIME_ICON
			// 
			this.TIME_ICON.BackColor = System.Drawing.Color.Transparent;
			this.TIME_ICON.Image = global::CafeMaster_UI.Properties.Resources.TIME_ICON;
			this.TIME_ICON.Location = new System.Drawing.Point(3, 89);
			this.TIME_ICON.Name = "TIME_ICON";
			this.TIME_ICON.Size = new System.Drawing.Size(25, 25);
			this.TIME_ICON.TabIndex = 7;
			this.TIME_ICON.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.TIME_ICON, "게시물을 올린 시간");
			// 
			// AUTHOR_ICON
			// 
			this.AUTHOR_ICON.BackColor = System.Drawing.Color.Transparent;
			this.AUTHOR_ICON.Image = global::CafeMaster_UI.Properties.Resources.USER_ICON;
			this.AUTHOR_ICON.Location = new System.Drawing.Point(3, 59);
			this.AUTHOR_ICON.Name = "AUTHOR_ICON";
			this.AUTHOR_ICON.Size = new System.Drawing.Size(25, 25);
			this.AUTHOR_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.AUTHOR_ICON.TabIndex = 6;
			this.AUTHOR_ICON.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.AUTHOR_ICON, "게시물을 올린 회원");
			// 
			// NotifyChildPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.THIS_SELECT_BUTTON);
			this.Controls.Add(this.IMAGE_VIEW_BUTTON);
			this.Controls.Add(this.MEMBER_ACTIVITY_STOP_BUTTON);
			this.Controls.Add(this.MEMBER_WARN_BUTTON);
			this.Controls.Add(this.NOTIFY_DELETE_BUTTON);
			this.Controls.Add(this.THREAD_DELETE_BUTTON);
			this.Controls.Add(this.RANK_LABEL);
			this.Controls.Add(this.ADMIN_ICON);
			this.Controls.Add(this.BOARD_NAME_LABEL);
			this.Controls.Add(this.OPEN_BUTTON);
			this.Controls.Add(this.FOCUS_BUTTON);
			this.Controls.Add(this.TIME_LABEL);
			this.Controls.Add(this.TIME_ICON);
			this.Controls.Add(this.AUTHOR_ICON);
			this.Controls.Add(this.HIT_LABEL);
			this.Controls.Add(this.AUTHOR_LABEL);
			this.Controls.Add(this.NUMBER_LABEL);
			this.Controls.Add(this.TITLE_LABEL);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Name = "NotifyChildPanel";
			this.Size = new System.Drawing.Size(530, 125);
			this.Load += new System.EventHandler(this.NotifyChildPanel_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.NotifyChildPanel_Paint);
			((System.ComponentModel.ISupportInitialize)(this.THIS_SELECT_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.IMAGE_VIEW_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MEMBER_ACTIVITY_STOP_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MEMBER_WARN_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NOTIFY_DELETE_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.THREAD_DELETE_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ADMIN_ICON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FOCUS_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TIME_ICON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AUTHOR_ICON)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TITLE_LABEL;
		private System.Windows.Forms.Label NUMBER_LABEL;
		private System.Windows.Forms.Label AUTHOR_LABEL;
		private System.Windows.Forms.Label HIT_LABEL;
		private System.Windows.Forms.PictureBox AUTHOR_ICON;
		private System.Windows.Forms.PictureBox TIME_ICON;
		private System.Windows.Forms.Label TIME_LABEL;
		private FlatImageButton FOCUS_BUTTON;
		private System.Windows.Forms.ToolTip TOOL_TIP;
		private System.Windows.Forms.Label BOARD_NAME_LABEL;
		private System.Windows.Forms.PictureBox ADMIN_ICON;
		private System.Windows.Forms.Label RANK_LABEL;
		private System.Windows.Forms.PictureBox THREAD_DELETE_BUTTON;
		private System.Windows.Forms.PictureBox NOTIFY_DELETE_BUTTON;
		private System.Windows.Forms.PictureBox MEMBER_WARN_BUTTON;
		private System.Windows.Forms.PictureBox MEMBER_ACTIVITY_STOP_BUTTON;
		private System.Windows.Forms.PictureBox IMAGE_VIEW_BUTTON;
		private FlatButton OPEN_BUTTON;
		private System.Windows.Forms.PictureBox THIS_SELECT_BUTTON;
	}
}
