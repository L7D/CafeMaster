﻿namespace CafeMaster_UI.Interface
{
	partial class MemberWarningForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( )
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberWarningForm));
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel();
			this.APP_TITLE = new CafeMaster_UI.Interface.CustomLabel();
			this.CLOSE_BUTTON = new System.Windows.Forms.PictureBox();
			this.USER_INFORMATION_PANEL = new System.Windows.Forms.Panel();
			this.MEMBER_INFO_OPEN_BUTTON = new CafeMaster_UI.Interface.FlatButton();
			this.RANK_LABEL = new System.Windows.Forms.Label();
			this.SELECT_RESET_BUTTON = new CafeMaster_UI.Interface.FlatButton();
			this.PERSONACON_IMAGE_ICON = new System.Windows.Forms.PictureBox();
			this.USERNAME_LABEL = new System.Windows.Forms.Label();
			this.PROFILE_IMAGE_ICON = new System.Windows.Forms.PictureBox();
			this.USER_INFORMATION_PANEL_TITLE = new System.Windows.Forms.Label();
			this.USER_SEARCH_TEXTBOX = new System.Windows.Forms.TextBox();
			this.USER_SEARCH_DESC = new System.Windows.Forms.Label();
			this.USER_SEARCH_TITLE = new System.Windows.Forms.Label();
			this.WARN_TEXT = new System.Windows.Forms.Label();
			this.WARN_ICON = new System.Windows.Forms.PictureBox();
			this.USER_SEARCH_BUTTON = new CafeMaster_UI.Interface.FlatButton();
			this.CANCEL_BUTTON = new CafeMaster_UI.Interface.FlatButton();
			this.WARN_RUN_BUTTON = new CafeMaster_UI.Interface.FlatButton();
			this.WARNING_COUNT_AFTERDESC = new System.Windows.Forms.Label();
			this.WARN_INFORMATION_PANEL = new System.Windows.Forms.Panel();
			this.REASON_EXAMPLE = new System.Windows.Forms.Label();
			this.COUNT_DESC = new System.Windows.Forms.Label();
			this.COUNT_TITLE = new System.Windows.Forms.Label();
			this.WARNING_COUNT = new System.Windows.Forms.NumericUpDown();
			this.THREAD_TITLE_EXAMPLE = new System.Windows.Forms.Label();
			this.REASON_DESC = new System.Windows.Forms.Label();
			this.WARN_EXAMPLE_IMAGE_TITLE = new System.Windows.Forms.Label();
			this.USERNICK_EXAMPLE = new System.Windows.Forms.Label();
			this.WARN_EXAMPLE = new System.Windows.Forms.PictureBox();
			this.REASON_TEXTBOX = new System.Windows.Forms.TextBox();
			this.REASON_TITLE = new System.Windows.Forms.Label();
			this.APP_TITLE_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).BeginInit();
			this.USER_INFORMATION_PANEL.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PERSONACON_IMAGE_ICON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PROFILE_IMAGE_ICON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WARN_ICON)).BeginInit();
			this.WARN_INFORMATION_PANEL.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.WARNING_COUNT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WARN_EXAMPLE)).BeginInit();
			this.SuspendLayout();
			// 
			// APP_TITLE_BAR
			// 
			this.APP_TITLE_BAR.BackColor = System.Drawing.Color.White;
			this.APP_TITLE_BAR.Controls.Add(this.APP_TITLE);
			this.APP_TITLE_BAR.Controls.Add(this.CLOSE_BUTTON);
			this.APP_TITLE_BAR.Cursor = System.Windows.Forms.Cursors.Default;
			this.APP_TITLE_BAR.Location = new System.Drawing.Point(0, 0);
			this.APP_TITLE_BAR.Name = "APP_TITLE_BAR";
			this.APP_TITLE_BAR.Size = new System.Drawing.Size(600, 45);
			this.APP_TITLE_BAR.TabIndex = 3;
			this.APP_TITLE_BAR.Paint += new System.Windows.Forms.PaintEventHandler(this.APP_TITLE_BAR_Paint);
			this.APP_TITLE_BAR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseDown);
			this.APP_TITLE_BAR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseMove);
			// 
			// APP_TITLE
			// 
			this.APP_TITLE.AutoSize = true;
			this.APP_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.APP_TITLE.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold);
			this.APP_TITLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.APP_TITLE.Location = new System.Drawing.Point(10, 16);
			this.APP_TITLE.Name = "APP_TITLE";
			this.APP_TITLE.Size = new System.Drawing.Size(54, 14);
			this.APP_TITLE.TabIndex = 3;
			this.APP_TITLE.Text = "회원 경고";
			this.APP_TITLE.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			// 
			// CLOSE_BUTTON
			// 
			this.CLOSE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.CLOSE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CLOSE_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.CLOSE;
			this.CLOSE_BUTTON.Location = new System.Drawing.Point(565, 10);
			this.CLOSE_BUTTON.Name = "CLOSE_BUTTON";
			this.CLOSE_BUTTON.Size = new System.Drawing.Size(25, 25);
			this.CLOSE_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.CLOSE_BUTTON.TabIndex = 4;
			this.CLOSE_BUTTON.TabStop = false;
			this.CLOSE_BUTTON.Click += new System.EventHandler(this.CLOSE_BUTTON_Click);
			// 
			// USER_INFORMATION_PANEL
			// 
			this.USER_INFORMATION_PANEL.BackColor = System.Drawing.Color.Transparent;
			this.USER_INFORMATION_PANEL.Controls.Add(this.MEMBER_INFO_OPEN_BUTTON);
			this.USER_INFORMATION_PANEL.Controls.Add(this.RANK_LABEL);
			this.USER_INFORMATION_PANEL.Controls.Add(this.SELECT_RESET_BUTTON);
			this.USER_INFORMATION_PANEL.Controls.Add(this.PERSONACON_IMAGE_ICON);
			this.USER_INFORMATION_PANEL.Controls.Add(this.USERNAME_LABEL);
			this.USER_INFORMATION_PANEL.Controls.Add(this.PROFILE_IMAGE_ICON);
			this.USER_INFORMATION_PANEL.Location = new System.Drawing.Point(34, 126);
			this.USER_INFORMATION_PANEL.Name = "USER_INFORMATION_PANEL";
			this.USER_INFORMATION_PANEL.Size = new System.Drawing.Size(531, 95);
			this.USER_INFORMATION_PANEL.TabIndex = 26;
			this.USER_INFORMATION_PANEL.Paint += new System.Windows.Forms.PaintEventHandler(this.USER_INFORMATION_PANEL_Paint);
			// 
			// MEMBER_INFO_OPEN_BUTTON
			// 
			this.MEMBER_INFO_OPEN_BUTTON.AnimationLerpP = 0.8F;
			this.MEMBER_INFO_OPEN_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.MEMBER_INFO_OPEN_BUTTON.ButtonText = "회원 정보 열기";
			this.MEMBER_INFO_OPEN_BUTTON.ButtonTextColor = System.Drawing.Color.Black;
			this.MEMBER_INFO_OPEN_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.MEMBER_INFO_OPEN_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.MEMBER_INFO_OPEN_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.MEMBER_INFO_OPEN_BUTTON.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.MEMBER_INFO_OPEN_BUTTON.Location = new System.Drawing.Point(240, 63);
			this.MEMBER_INFO_OPEN_BUTTON.Name = "MEMBER_INFO_OPEN_BUTTON";
			this.MEMBER_INFO_OPEN_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.MEMBER_INFO_OPEN_BUTTON.Size = new System.Drawing.Size(140, 27);
			this.MEMBER_INFO_OPEN_BUTTON.TabIndex = 28;
			this.MEMBER_INFO_OPEN_BUTTON.Text = "회원 정보 열기";
			this.MEMBER_INFO_OPEN_BUTTON.UseVisualStyleBackColor = false;
			this.MEMBER_INFO_OPEN_BUTTON.Click += new System.EventHandler(this.MEMBER_INFO_OPEN_BUTTON_Click);
			// 
			// RANK_LABEL
			// 
			this.RANK_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.RANK_LABEL.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.RANK_LABEL.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RANK_LABEL.Location = new System.Drawing.Point(96, 27);
			this.RANK_LABEL.Name = "RANK_LABEL";
			this.RANK_LABEL.Size = new System.Drawing.Size(302, 19);
			this.RANK_LABEL.TabIndex = 27;
			this.RANK_LABEL.Text = "NULL";
			this.RANK_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SELECT_RESET_BUTTON
			// 
			this.SELECT_RESET_BUTTON.AnimationLerpP = 0.8F;
			this.SELECT_RESET_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.SELECT_RESET_BUTTON.ButtonText = "다른 회원 선택";
			this.SELECT_RESET_BUTTON.ButtonTextColor = System.Drawing.Color.Black;
			this.SELECT_RESET_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SELECT_RESET_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.SELECT_RESET_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SELECT_RESET_BUTTON.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.SELECT_RESET_BUTTON.Location = new System.Drawing.Point(386, 63);
			this.SELECT_RESET_BUTTON.Name = "SELECT_RESET_BUTTON";
			this.SELECT_RESET_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.SELECT_RESET_BUTTON.Size = new System.Drawing.Size(140, 27);
			this.SELECT_RESET_BUTTON.TabIndex = 26;
			this.SELECT_RESET_BUTTON.Text = "다른 회원 선택";
			this.SELECT_RESET_BUTTON.UseVisualStyleBackColor = false;
			this.SELECT_RESET_BUTTON.Click += new System.EventHandler(this.SELECT_RESET_BUTTON_Click);
			// 
			// PERSONACON_IMAGE_ICON
			// 
			this.PERSONACON_IMAGE_ICON.BackColor = System.Drawing.Color.Transparent;
			this.PERSONACON_IMAGE_ICON.Location = new System.Drawing.Point(96, 5);
			this.PERSONACON_IMAGE_ICON.Name = "PERSONACON_IMAGE_ICON";
			this.PERSONACON_IMAGE_ICON.Size = new System.Drawing.Size(19, 19);
			this.PERSONACON_IMAGE_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PERSONACON_IMAGE_ICON.TabIndex = 14;
			this.PERSONACON_IMAGE_ICON.TabStop = false;
			// 
			// USERNAME_LABEL
			// 
			this.USERNAME_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.USERNAME_LABEL.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.USERNAME_LABEL.ForeColor = System.Drawing.SystemColors.ControlText;
			this.USERNAME_LABEL.Location = new System.Drawing.Point(121, 5);
			this.USERNAME_LABEL.Name = "USERNAME_LABEL";
			this.USERNAME_LABEL.Size = new System.Drawing.Size(405, 19);
			this.USERNAME_LABEL.TabIndex = 13;
			this.USERNAME_LABEL.Text = "NULL(NULL)";
			this.USERNAME_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PROFILE_IMAGE_ICON
			// 
			this.PROFILE_IMAGE_ICON.Image = global::CafeMaster_UI.Properties.Resources.PROFILE_UNKNOWN_160x160;
			this.PROFILE_IMAGE_ICON.Location = new System.Drawing.Point(5, 5);
			this.PROFILE_IMAGE_ICON.Name = "PROFILE_IMAGE_ICON";
			this.PROFILE_IMAGE_ICON.Size = new System.Drawing.Size(85, 85);
			this.PROFILE_IMAGE_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PROFILE_IMAGE_ICON.TabIndex = 0;
			this.PROFILE_IMAGE_ICON.TabStop = false;
			// 
			// USER_INFORMATION_PANEL_TITLE
			// 
			this.USER_INFORMATION_PANEL_TITLE.AutoSize = true;
			this.USER_INFORMATION_PANEL_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.USER_INFORMATION_PANEL_TITLE.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.USER_INFORMATION_PANEL_TITLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.USER_INFORMATION_PANEL_TITLE.Location = new System.Drawing.Point(31, 101);
			this.USER_INFORMATION_PANEL_TITLE.Name = "USER_INFORMATION_PANEL_TITLE";
			this.USER_INFORMATION_PANEL_TITLE.Size = new System.Drawing.Size(68, 17);
			this.USER_INFORMATION_PANEL_TITLE.TabIndex = 27;
			this.USER_INFORMATION_PANEL_TITLE.Text = "회원 선택";
			// 
			// USER_SEARCH_TEXTBOX
			// 
			this.USER_SEARCH_TEXTBOX.BackColor = System.Drawing.Color.White;
			this.USER_SEARCH_TEXTBOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.USER_SEARCH_TEXTBOX.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.USER_SEARCH_TEXTBOX.Location = new System.Drawing.Point(82, 129);
			this.USER_SEARCH_TEXTBOX.MaxLength = 200;
			this.USER_SEARCH_TEXTBOX.Name = "USER_SEARCH_TEXTBOX";
			this.USER_SEARCH_TEXTBOX.Size = new System.Drawing.Size(312, 22);
			this.USER_SEARCH_TEXTBOX.TabIndex = 29;
			this.USER_SEARCH_TEXTBOX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.USER_SEARCH_TEXTBOX_KeyDown);
			// 
			// USER_SEARCH_DESC
			// 
			this.USER_SEARCH_DESC.AutoSize = true;
			this.USER_SEARCH_DESC.BackColor = System.Drawing.Color.Transparent;
			this.USER_SEARCH_DESC.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.USER_SEARCH_DESC.ForeColor = System.Drawing.SystemColors.ControlText;
			this.USER_SEARCH_DESC.Location = new System.Drawing.Point(32, 158);
			this.USER_SEARCH_DESC.Name = "USER_SEARCH_DESC";
			this.USER_SEARCH_DESC.Size = new System.Drawing.Size(184, 14);
			this.USER_SEARCH_DESC.TabIndex = 32;
			this.USER_SEARCH_DESC.Text = "활동 정지 처리할 회원을 선택하세요";
			// 
			// USER_SEARCH_TITLE
			// 
			this.USER_SEARCH_TITLE.AutoSize = true;
			this.USER_SEARCH_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.USER_SEARCH_TITLE.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.USER_SEARCH_TITLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.USER_SEARCH_TITLE.Location = new System.Drawing.Point(32, 132);
			this.USER_SEARCH_TITLE.Name = "USER_SEARCH_TITLE";
			this.USER_SEARCH_TITLE.Size = new System.Drawing.Size(44, 14);
			this.USER_SEARCH_TITLE.TabIndex = 34;
			this.USER_SEARCH_TITLE.Text = "회원 ID";
			// 
			// WARN_TEXT
			// 
			this.WARN_TEXT.AutoSize = true;
			this.WARN_TEXT.BackColor = System.Drawing.Color.Transparent;
			this.WARN_TEXT.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.WARN_TEXT.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WARN_TEXT.Location = new System.Drawing.Point(85, 63);
			this.WARN_TEXT.Name = "WARN_TEXT";
			this.WARN_TEXT.Size = new System.Drawing.Size(441, 15);
			this.WARN_TEXT.TabIndex = 34;
			this.WARN_TEXT.Text = "경고 처리하기 전 모든 작성사항을 다시 확인하시고 규정을 꼭! 다시 확인하세요.";
			// 
			// WARN_ICON
			// 
			this.WARN_ICON.BackColor = System.Drawing.Color.Transparent;
			this.WARN_ICON.Image = global::CafeMaster_UI.Properties.Resources.DANGER_ICON;
			this.WARN_ICON.Location = new System.Drawing.Point(34, 58);
			this.WARN_ICON.Name = "WARN_ICON";
			this.WARN_ICON.Size = new System.Drawing.Size(25, 25);
			this.WARN_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.WARN_ICON.TabIndex = 33;
			this.WARN_ICON.TabStop = false;
			// 
			// USER_SEARCH_BUTTON
			// 
			this.USER_SEARCH_BUTTON.AnimationLerpP = 0.8F;
			this.USER_SEARCH_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.USER_SEARCH_BUTTON.ButtonText = "회원 검색";
			this.USER_SEARCH_BUTTON.ButtonTextColor = System.Drawing.Color.Black;
			this.USER_SEARCH_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.USER_SEARCH_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.USER_SEARCH_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.USER_SEARCH_BUTTON.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.USER_SEARCH_BUTTON.Location = new System.Drawing.Point(400, 129);
			this.USER_SEARCH_BUTTON.Name = "USER_SEARCH_BUTTON";
			this.USER_SEARCH_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.USER_SEARCH_BUTTON.Size = new System.Drawing.Size(160, 43);
			this.USER_SEARCH_BUTTON.TabIndex = 28;
			this.USER_SEARCH_BUTTON.Text = "회원 검색";
			this.USER_SEARCH_BUTTON.UseVisualStyleBackColor = false;
			this.USER_SEARCH_BUTTON.Click += new System.EventHandler(this.USER_SEARCH_BUTTON_Click);
			// 
			// CANCEL_BUTTON
			// 
			this.CANCEL_BUTTON.AnimationLerpP = 0.8F;
			this.CANCEL_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.CANCEL_BUTTON.ButtonText = "취소";
			this.CANCEL_BUTTON.ButtonTextColor = System.Drawing.Color.Black;
			this.CANCEL_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CANCEL_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.CANCEL_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CANCEL_BUTTON.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.CANCEL_BUTTON.Location = new System.Drawing.Point(238, 611);
			this.CANCEL_BUTTON.Name = "CANCEL_BUTTON";
			this.CANCEL_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.CANCEL_BUTTON.Size = new System.Drawing.Size(102, 27);
			this.CANCEL_BUTTON.TabIndex = 25;
			this.CANCEL_BUTTON.Text = "취소";
			this.CANCEL_BUTTON.UseVisualStyleBackColor = false;
			this.CANCEL_BUTTON.Click += new System.EventHandler(this.CANCEL_BUTTON_Click);
			// 
			// WARN_RUN_BUTTON
			// 
			this.WARN_RUN_BUTTON.AnimationLerpP = 0.8F;
			this.WARN_RUN_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.WARN_RUN_BUTTON.ButtonText = "경고 처리";
			this.WARN_RUN_BUTTON.ButtonTextColor = System.Drawing.Color.White;
			this.WARN_RUN_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.WARN_RUN_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.Red;
			this.WARN_RUN_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.WARN_RUN_BUTTON.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.WARN_RUN_BUTTON.Location = new System.Drawing.Point(34, 603);
			this.WARN_RUN_BUTTON.Name = "WARN_RUN_BUTTON";
			this.WARN_RUN_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.Crimson;
			this.WARN_RUN_BUTTON.Size = new System.Drawing.Size(195, 35);
			this.WARN_RUN_BUTTON.TabIndex = 7;
			this.WARN_RUN_BUTTON.Text = "경고 처리";
			this.WARN_RUN_BUTTON.UseVisualStyleBackColor = false;
			this.WARN_RUN_BUTTON.Click += new System.EventHandler(this.WARN_RUN_BUTTON_Click);
			// 
			// WARNING_COUNT_AFTERDESC
			// 
			this.WARNING_COUNT_AFTERDESC.BackColor = System.Drawing.Color.Transparent;
			this.WARNING_COUNT_AFTERDESC.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.WARNING_COUNT_AFTERDESC.ForeColor = System.Drawing.Color.Red;
			this.WARNING_COUNT_AFTERDESC.Location = new System.Drawing.Point(168, 121);
			this.WARNING_COUNT_AFTERDESC.Name = "WARNING_COUNT_AFTERDESC";
			this.WARNING_COUNT_AFTERDESC.Size = new System.Drawing.Size(344, 15);
			this.WARNING_COUNT_AFTERDESC.TabIndex = 23;
			this.WARNING_COUNT_AFTERDESC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// WARN_INFORMATION_PANEL
			// 
			this.WARN_INFORMATION_PANEL.BackColor = System.Drawing.Color.Transparent;
			this.WARN_INFORMATION_PANEL.Controls.Add(this.REASON_EXAMPLE);
			this.WARN_INFORMATION_PANEL.Controls.Add(this.COUNT_DESC);
			this.WARN_INFORMATION_PANEL.Controls.Add(this.COUNT_TITLE);
			this.WARN_INFORMATION_PANEL.Controls.Add(this.WARNING_COUNT);
			this.WARN_INFORMATION_PANEL.Controls.Add(this.THREAD_TITLE_EXAMPLE);
			this.WARN_INFORMATION_PANEL.Controls.Add(this.REASON_DESC);
			this.WARN_INFORMATION_PANEL.Controls.Add(this.WARN_EXAMPLE_IMAGE_TITLE);
			this.WARN_INFORMATION_PANEL.Controls.Add(this.USERNICK_EXAMPLE);
			this.WARN_INFORMATION_PANEL.Controls.Add(this.WARN_EXAMPLE);
			this.WARN_INFORMATION_PANEL.Controls.Add(this.REASON_TEXTBOX);
			this.WARN_INFORMATION_PANEL.Controls.Add(this.REASON_TITLE);
			this.WARN_INFORMATION_PANEL.Controls.Add(this.WARNING_COUNT_AFTERDESC);
			this.WARN_INFORMATION_PANEL.Location = new System.Drawing.Point(34, 237);
			this.WARN_INFORMATION_PANEL.Name = "WARN_INFORMATION_PANEL";
			this.WARN_INFORMATION_PANEL.Size = new System.Drawing.Size(531, 360);
			this.WARN_INFORMATION_PANEL.TabIndex = 33;
			this.WARN_INFORMATION_PANEL.Visible = false;
			// 
			// REASON_EXAMPLE
			// 
			this.REASON_EXAMPLE.AutoEllipsis = true;
			this.REASON_EXAMPLE.BackColor = System.Drawing.Color.White;
			this.REASON_EXAMPLE.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.REASON_EXAMPLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.REASON_EXAMPLE.Location = new System.Drawing.Point(49, 307);
			this.REASON_EXAMPLE.Name = "REASON_EXAMPLE";
			this.REASON_EXAMPLE.Size = new System.Drawing.Size(353, 15);
			this.REASON_EXAMPLE.TabIndex = 34;
			this.REASON_EXAMPLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// COUNT_DESC
			// 
			this.COUNT_DESC.AutoSize = true;
			this.COUNT_DESC.BackColor = System.Drawing.Color.Transparent;
			this.COUNT_DESC.Font = new System.Drawing.Font("나눔고딕", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.COUNT_DESC.ForeColor = System.Drawing.SystemColors.ControlText;
			this.COUNT_DESC.Location = new System.Drawing.Point(168, 92);
			this.COUNT_DESC.Name = "COUNT_DESC";
			this.COUNT_DESC.Size = new System.Drawing.Size(258, 13);
			this.COUNT_DESC.TabIndex = 33;
			this.COUNT_DESC.Text = "기본 경고 횟수는 서버에서 정보를 가져와서 설정됩니다.";
			// 
			// COUNT_TITLE
			// 
			this.COUNT_TITLE.AutoSize = true;
			this.COUNT_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.COUNT_TITLE.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.COUNT_TITLE.ForeColor = System.Drawing.Color.Red;
			this.COUNT_TITLE.Location = new System.Drawing.Point(2, 106);
			this.COUNT_TITLE.Name = "COUNT_TITLE";
			this.COUNT_TITLE.Size = new System.Drawing.Size(68, 17);
			this.COUNT_TITLE.TabIndex = 32;
			this.COUNT_TITLE.Text = "경고 횟수";
			// 
			// WARNING_COUNT
			// 
			this.WARNING_COUNT.BackColor = System.Drawing.Color.White;
			this.WARNING_COUNT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.WARNING_COUNT.Font = new System.Drawing.Font("나눔고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.WARNING_COUNT.ForeColor = System.Drawing.Color.Red;
			this.WARNING_COUNT.Location = new System.Drawing.Point(75, 92);
			this.WARNING_COUNT.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.WARNING_COUNT.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.WARNING_COUNT.Name = "WARNING_COUNT";
			this.WARNING_COUNT.Size = new System.Drawing.Size(83, 44);
			this.WARNING_COUNT.TabIndex = 31;
			this.WARNING_COUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.WARNING_COUNT.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.WARNING_COUNT.ValueChanged += new System.EventHandler(this.WARNING_COUNT_ValueChanged);
			// 
			// THREAD_TITLE_EXAMPLE
			// 
			this.THREAD_TITLE_EXAMPLE.AutoEllipsis = true;
			this.THREAD_TITLE_EXAMPLE.BackColor = System.Drawing.Color.White;
			this.THREAD_TITLE_EXAMPLE.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.THREAD_TITLE_EXAMPLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.THREAD_TITLE_EXAMPLE.Location = new System.Drawing.Point(11, 236);
			this.THREAD_TITLE_EXAMPLE.Name = "THREAD_TITLE_EXAMPLE";
			this.THREAD_TITLE_EXAMPLE.Size = new System.Drawing.Size(294, 13);
			this.THREAD_TITLE_EXAMPLE.TabIndex = 30;
			this.THREAD_TITLE_EXAMPLE.Text = "제목";
			this.THREAD_TITLE_EXAMPLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// REASON_DESC
			// 
			this.REASON_DESC.AutoSize = true;
			this.REASON_DESC.BackColor = System.Drawing.Color.Transparent;
			this.REASON_DESC.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.REASON_DESC.ForeColor = System.Drawing.SystemColors.ControlText;
			this.REASON_DESC.Location = new System.Drawing.Point(3, 57);
			this.REASON_DESC.Name = "REASON_DESC";
			this.REASON_DESC.Size = new System.Drawing.Size(127, 14);
			this.REASON_DESC.TabIndex = 29;
			this.REASON_DESC.Text = "경고 진술을 작성하세요.";
			// 
			// WARN_EXAMPLE_IMAGE_TITLE
			// 
			this.WARN_EXAMPLE_IMAGE_TITLE.AutoSize = true;
			this.WARN_EXAMPLE_IMAGE_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.WARN_EXAMPLE_IMAGE_TITLE.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.WARN_EXAMPLE_IMAGE_TITLE.ForeColor = System.Drawing.Color.DimGray;
			this.WARN_EXAMPLE_IMAGE_TITLE.Location = new System.Drawing.Point(-1, 195);
			this.WARN_EXAMPLE_IMAGE_TITLE.Name = "WARN_EXAMPLE_IMAGE_TITLE";
			this.WARN_EXAMPLE_IMAGE_TITLE.Size = new System.Drawing.Size(148, 14);
			this.WARN_EXAMPLE_IMAGE_TITLE.TabIndex = 28;
			this.WARN_EXAMPLE_IMAGE_TITLE.Text = "실제 게시글에 작성되는 내용";
			// 
			// USERNICK_EXAMPLE
			// 
			this.USERNICK_EXAMPLE.BackColor = System.Drawing.Color.White;
			this.USERNICK_EXAMPLE.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.USERNICK_EXAMPLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.USERNICK_EXAMPLE.Location = new System.Drawing.Point(97, 274);
			this.USERNICK_EXAMPLE.Name = "USERNICK_EXAMPLE";
			this.USERNICK_EXAMPLE.Size = new System.Drawing.Size(305, 17);
			this.USERNICK_EXAMPLE.TabIndex = 27;
			this.USERNICK_EXAMPLE.Text = "닉네임";
			this.USERNICK_EXAMPLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// WARN_EXAMPLE
			// 
			this.WARN_EXAMPLE.BackColor = System.Drawing.Color.Transparent;
			this.WARN_EXAMPLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.WARN_EXAMPLE.Image = global::CafeMaster_UI.Properties.Resources.WARN_EXAMPLE;
			this.WARN_EXAMPLE.Location = new System.Drawing.Point(1, 216);
			this.WARN_EXAMPLE.Name = "WARN_EXAMPLE";
			this.WARN_EXAMPLE.Size = new System.Drawing.Size(411, 118);
			this.WARN_EXAMPLE.TabIndex = 26;
			this.WARN_EXAMPLE.TabStop = false;
			// 
			// REASON_TEXTBOX
			// 
			this.REASON_TEXTBOX.BackColor = System.Drawing.Color.White;
			this.REASON_TEXTBOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.REASON_TEXTBOX.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.REASON_TEXTBOX.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.REASON_TEXTBOX.Location = new System.Drawing.Point(5, 29);
			this.REASON_TEXTBOX.MaxLength = 200;
			this.REASON_TEXTBOX.Name = "REASON_TEXTBOX";
			this.REASON_TEXTBOX.Size = new System.Drawing.Size(502, 22);
			this.REASON_TEXTBOX.TabIndex = 25;
			this.REASON_TEXTBOX.TextChanged += new System.EventHandler(this.REASON_TEXTBOX_TextChanged);
			// 
			// REASON_TITLE
			// 
			this.REASON_TITLE.AutoSize = true;
			this.REASON_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.REASON_TITLE.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.REASON_TITLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.REASON_TITLE.Location = new System.Drawing.Point(2, 4);
			this.REASON_TITLE.Name = "REASON_TITLE";
			this.REASON_TITLE.Size = new System.Drawing.Size(36, 17);
			this.REASON_TITLE.TabIndex = 24;
			this.REASON_TITLE.Text = "진술";
			// 
			// MemberWarningForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(600, 650);
			this.Controls.Add(this.USER_INFORMATION_PANEL);
			this.Controls.Add(this.WARN_TEXT);
			this.Controls.Add(this.USER_SEARCH_TITLE);
			this.Controls.Add(this.WARN_ICON);
			this.Controls.Add(this.WARN_INFORMATION_PANEL);
			this.Controls.Add(this.USER_SEARCH_DESC);
			this.Controls.Add(this.USER_SEARCH_BUTTON);
			this.Controls.Add(this.USER_INFORMATION_PANEL_TITLE);
			this.Controls.Add(this.CANCEL_BUTTON);
			this.Controls.Add(this.WARN_RUN_BUTTON);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.Controls.Add(this.USER_SEARCH_TEXTBOX);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MemberWarningForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "회원 경고";
			this.Load += new System.EventHandler(this.UserWarnOptionForm_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserWarnOptionForm_Paint);
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).EndInit();
			this.USER_INFORMATION_PANEL.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PERSONACON_IMAGE_ICON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PROFILE_IMAGE_ICON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WARN_ICON)).EndInit();
			this.WARN_INFORMATION_PANEL.ResumeLayout(false);
			this.WARN_INFORMATION_PANEL.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.WARNING_COUNT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WARN_EXAMPLE)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private CustomLabel APP_TITLE;
		private System.Windows.Forms.PictureBox CLOSE_BUTTON;
		private FlatButton WARN_RUN_BUTTON;
		private FlatButton CANCEL_BUTTON;
		private System.Windows.Forms.Panel USER_INFORMATION_PANEL;
		private System.Windows.Forms.PictureBox PROFILE_IMAGE_ICON;
		private System.Windows.Forms.Label USERNAME_LABEL;
		private System.Windows.Forms.PictureBox PERSONACON_IMAGE_ICON;
		private System.Windows.Forms.Label RANK_LABEL;
		private FlatButton SELECT_RESET_BUTTON;
		private System.Windows.Forms.Label USER_INFORMATION_PANEL_TITLE;
		private FlatButton USER_SEARCH_BUTTON;
		private System.Windows.Forms.TextBox USER_SEARCH_TEXTBOX;
		private System.Windows.Forms.Label USER_SEARCH_DESC;
		private System.Windows.Forms.Label USER_SEARCH_TITLE;
		private System.Windows.Forms.Label WARN_TEXT;
		private System.Windows.Forms.PictureBox WARN_ICON;
		private FlatButton MEMBER_INFO_OPEN_BUTTON;
		private System.Windows.Forms.Label WARNING_COUNT_AFTERDESC;
		private System.Windows.Forms.Panel WARN_INFORMATION_PANEL;
		private System.Windows.Forms.Label COUNT_DESC;
		private System.Windows.Forms.NumericUpDown WARNING_COUNT;
		private System.Windows.Forms.Label THREAD_TITLE_EXAMPLE;
		private System.Windows.Forms.Label REASON_DESC;
		private System.Windows.Forms.Label WARN_EXAMPLE_IMAGE_TITLE;
		private System.Windows.Forms.Label USERNICK_EXAMPLE;
		private System.Windows.Forms.PictureBox WARN_EXAMPLE;
		private System.Windows.Forms.TextBox REASON_TEXTBOX;
		private System.Windows.Forms.Label REASON_TITLE;
		private System.Windows.Forms.Label REASON_EXAMPLE;
		private System.Windows.Forms.Label COUNT_TITLE;
	}
}