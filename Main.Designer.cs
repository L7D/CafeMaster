﻿namespace CafeMaster_UI
{
	partial class Main
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

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent( )
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel();
			this.NETWORK_STATUS_ICON = new System.Windows.Forms.PictureBox();
			this.INFO_BUTTON = new System.Windows.Forms.PictureBox();
			this.OPTION_BUTTON = new System.Windows.Forms.PictureBox();
			this.FORCE_REFRESH_BUTTON = new System.Windows.Forms.PictureBox();
			this.BELL_STATUS_BUTTON = new System.Windows.Forms.PictureBox();
			this.HIDE_BUTTON = new System.Windows.Forms.PictureBox();
			this.APP_TITLE = new CafeMaster_UI.Interface.CustomLabel();
			this.CLOSE_BUTTON = new System.Windows.Forms.PictureBox();
			this.CURRENT_PROGRESS_LABEL = new CafeMaster_UI.Interface.CustomLabel();
			this.STEP_CHATBOX_TITLE = new System.Windows.Forms.Label();
			this.APP_NOTIFY_ICON = new System.Windows.Forms.NotifyIcon(this.components);
			this.APP_NOTIFY_ICON_MENU = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.APP_NOTIFY_ICON_MENU_ITEM_1 = new System.Windows.Forms.ToolStripMenuItem();
			this.TOOL_TIP = new System.Windows.Forms.ToolTip(this.components);
			this.UTIL_ICON_BUTTON7 = new CafeMaster_UI.Interface.FlatImageButton();
			this.CHILD_PANEL_UTIL_ALL_SELECT = new CafeMaster_UI.Interface.FlatImageButton();
			this.CHILD_PANEL_UTIL_DELETE = new CafeMaster_UI.Interface.FlatImageButton();
			this.UTIL_ICON_BUTTON6 = new CafeMaster_UI.Interface.FlatImageButton();
			this.UTIL_ICON_BUTTON5 = new CafeMaster_UI.Interface.FlatImageButton();
			this.UTIL_ICON_BUTTON4 = new CafeMaster_UI.Interface.FlatImageButton();
			this.UTIL_ICON_BUTTON2 = new CafeMaster_UI.Interface.FlatImageButton();
			this.UTIL_ICON_BUTTON1 = new CafeMaster_UI.Interface.FlatImageButton();
			this.UPDATE_AVAILABLE = new System.Windows.Forms.PictureBox();
			this.UTIL_ICON_BUTTON8 = new CafeMaster_UI.Interface.FlatImageButton();
			this.NOTIFYBOX_EMPTY_TITLE = new System.Windows.Forms.Label();
			this.NOTIFYBOX_EMPTY_DESC = new System.Windows.Forms.Label();
			this.NOTIFY_PANEL_TITLE = new System.Windows.Forms.Label();
			this.STEP_CHATBOX = new System.Windows.Forms.WebBrowser();
			this.FORCE_SYNC_DELAY_TIMER = new System.Windows.Forms.Timer(this.components);
			this.NOTIFY_PANEL = new CafeMaster_UI.Interface.DoubleBufferPanel();
			this.NETWORK_SYNC_ANIMATION_TIMER = new System.Windows.Forms.Timer(this.components);
			this.PROGRAM_CLOSE_ANIMATION = new System.Windows.Forms.Timer(this.components);
			this.CHILD_PANEL_LABEL_SELECTED_COUNT = new System.Windows.Forms.Label();
			this.NOTIFY_PANEL_ICON = new System.Windows.Forms.PictureBox();
			this.STEP_CHATBOX_ICON = new System.Windows.Forms.PictureBox();
			this.NOTIFYBOX_EMPTY_ICON = new System.Windows.Forms.PictureBox();
			this.NAVER_ICON_IMAGE = new System.Windows.Forms.PictureBox();
			this.APP_TITLE_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NETWORK_STATUS_ICON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.INFO_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OPTION_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FORCE_REFRESH_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BELL_STATUS_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HIDE_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).BeginInit();
			this.APP_NOTIFY_ICON_MENU.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.UTIL_ICON_BUTTON7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CHILD_PANEL_UTIL_ALL_SELECT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CHILD_PANEL_UTIL_DELETE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UTIL_ICON_BUTTON6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UTIL_ICON_BUTTON5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UTIL_ICON_BUTTON4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UTIL_ICON_BUTTON2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UTIL_ICON_BUTTON1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UPDATE_AVAILABLE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UTIL_ICON_BUTTON8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NOTIFY_PANEL_ICON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.STEP_CHATBOX_ICON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NOTIFYBOX_EMPTY_ICON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NAVER_ICON_IMAGE)).BeginInit();
			this.SuspendLayout();
			// 
			// APP_TITLE_BAR
			// 
			this.APP_TITLE_BAR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.APP_TITLE_BAR.BackColor = System.Drawing.Color.White;
			this.APP_TITLE_BAR.Controls.Add(this.NETWORK_STATUS_ICON);
			this.APP_TITLE_BAR.Controls.Add(this.INFO_BUTTON);
			this.APP_TITLE_BAR.Controls.Add(this.OPTION_BUTTON);
			this.APP_TITLE_BAR.Controls.Add(this.FORCE_REFRESH_BUTTON);
			this.APP_TITLE_BAR.Controls.Add(this.BELL_STATUS_BUTTON);
			this.APP_TITLE_BAR.Controls.Add(this.HIDE_BUTTON);
			this.APP_TITLE_BAR.Controls.Add(this.APP_TITLE);
			this.APP_TITLE_BAR.Controls.Add(this.CLOSE_BUTTON);
			this.APP_TITLE_BAR.Controls.Add(this.CURRENT_PROGRESS_LABEL);
			this.APP_TITLE_BAR.Cursor = System.Windows.Forms.Cursors.Default;
			this.APP_TITLE_BAR.Location = new System.Drawing.Point(0, 0);
			this.APP_TITLE_BAR.Name = "APP_TITLE_BAR";
			this.APP_TITLE_BAR.Size = new System.Drawing.Size(1125, 45);
			this.APP_TITLE_BAR.TabIndex = 17;
			this.APP_TITLE_BAR.Paint += new System.Windows.Forms.PaintEventHandler(this.APP_TITLE_BAR_Paint);
			this.APP_TITLE_BAR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseDown);
			this.APP_TITLE_BAR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseMove);
			// 
			// NETWORK_STATUS_ICON
			// 
			this.NETWORK_STATUS_ICON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NETWORK_STATUS_ICON.BackColor = System.Drawing.Color.Transparent;
			this.NETWORK_STATUS_ICON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NETWORK_STATUS_ICON.Image = global::CafeMaster_UI.Properties.Resources.NETWORK_INIT_NOT;
			this.NETWORK_STATUS_ICON.Location = new System.Drawing.Point(915, 10);
			this.NETWORK_STATUS_ICON.Name = "NETWORK_STATUS_ICON";
			this.NETWORK_STATUS_ICON.Size = new System.Drawing.Size(25, 25);
			this.NETWORK_STATUS_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.NETWORK_STATUS_ICON.TabIndex = 44;
			this.NETWORK_STATUS_ICON.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.NETWORK_STATUS_ICON, "우유 서버 연결 상태 : 초기화 하는 중 ...");
			// 
			// INFO_BUTTON
			// 
			this.INFO_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.INFO_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.INFO_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.APP_ICON_v2_25x25;
			this.INFO_BUTTON.Location = new System.Drawing.Point(10, 10);
			this.INFO_BUTTON.Name = "INFO_BUTTON";
			this.INFO_BUTTON.Size = new System.Drawing.Size(25, 25);
			this.INFO_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.INFO_BUTTON.TabIndex = 23;
			this.INFO_BUTTON.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.INFO_BUTTON, "프로그램 정보");
			this.INFO_BUTTON.Click += new System.EventHandler(this.INFO_BUTTON_Click);
			// 
			// OPTION_BUTTON
			// 
			this.OPTION_BUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.OPTION_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.OPTION_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.OPTION_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.OPTION;
			this.OPTION_BUTTON.Location = new System.Drawing.Point(1020, 10);
			this.OPTION_BUTTON.Name = "OPTION_BUTTON";
			this.OPTION_BUTTON.Size = new System.Drawing.Size(25, 25);
			this.OPTION_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.OPTION_BUTTON.TabIndex = 22;
			this.OPTION_BUTTON.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.OPTION_BUTTON, "설정");
			this.OPTION_BUTTON.Click += new System.EventHandler(this.OPTION_BUTTON_Click);
			// 
			// FORCE_REFRESH_BUTTON
			// 
			this.FORCE_REFRESH_BUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.FORCE_REFRESH_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.FORCE_REFRESH_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.FORCE_REFRESH_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.REFRESH;
			this.FORCE_REFRESH_BUTTON.Location = new System.Drawing.Point(950, 10);
			this.FORCE_REFRESH_BUTTON.Name = "FORCE_REFRESH_BUTTON";
			this.FORCE_REFRESH_BUTTON.Size = new System.Drawing.Size(25, 25);
			this.FORCE_REFRESH_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.FORCE_REFRESH_BUTTON.TabIndex = 20;
			this.FORCE_REFRESH_BUTTON.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.FORCE_REFRESH_BUTTON, "지금 동기화");
			this.FORCE_REFRESH_BUTTON.Click += new System.EventHandler(this.FORCE_REFRESH_BUTTON_Click);
			// 
			// BELL_STATUS_BUTTON
			// 
			this.BELL_STATUS_BUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BELL_STATUS_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.BELL_STATUS_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BELL_STATUS_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.BELL_NORMAL;
			this.BELL_STATUS_BUTTON.Location = new System.Drawing.Point(985, 10);
			this.BELL_STATUS_BUTTON.Name = "BELL_STATUS_BUTTON";
			this.BELL_STATUS_BUTTON.Size = new System.Drawing.Size(25, 25);
			this.BELL_STATUS_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.BELL_STATUS_BUTTON.TabIndex = 18;
			this.BELL_STATUS_BUTTON.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.BELL_STATUS_BUTTON, "알림 소리 재생 / 재생하지 않음");
			this.BELL_STATUS_BUTTON.Click += new System.EventHandler(this.BELL_STATUS_BUTTON_Click);
			// 
			// HIDE_BUTTON
			// 
			this.HIDE_BUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.HIDE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.HIDE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.HIDE_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.HIDE;
			this.HIDE_BUTTON.Location = new System.Drawing.Point(1055, 10);
			this.HIDE_BUTTON.Name = "HIDE_BUTTON";
			this.HIDE_BUTTON.Size = new System.Drawing.Size(25, 25);
			this.HIDE_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.HIDE_BUTTON.TabIndex = 17;
			this.HIDE_BUTTON.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.HIDE_BUTTON, "프로그램 최소화");
			this.HIDE_BUTTON.Click += new System.EventHandler(this.HIDE_BUTTON_Click);
			// 
			// APP_TITLE
			// 
			this.APP_TITLE.AutoSize = true;
			this.APP_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.APP_TITLE.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.APP_TITLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.APP_TITLE.Location = new System.Drawing.Point(40, 15);
			this.APP_TITLE.Name = "APP_TITLE";
			this.APP_TITLE.Size = new System.Drawing.Size(143, 14);
			this.APP_TITLE.TabIndex = 3;
			this.APP_TITLE.Text = "우윳빛깔 카페스탭 - © L7D";
			this.APP_TITLE.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			// 
			// CLOSE_BUTTON
			// 
			this.CLOSE_BUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CLOSE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.CLOSE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CLOSE_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.CLOSE;
			this.CLOSE_BUTTON.Location = new System.Drawing.Point(1090, 10);
			this.CLOSE_BUTTON.Name = "CLOSE_BUTTON";
			this.CLOSE_BUTTON.Size = new System.Drawing.Size(25, 25);
			this.CLOSE_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.CLOSE_BUTTON.TabIndex = 4;
			this.CLOSE_BUTTON.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.CLOSE_BUTTON, "프로그램 종료");
			this.CLOSE_BUTTON.Click += new System.EventHandler(this.CLOSE_BUTTON_Click);
			// 
			// CURRENT_PROGRESS_LABEL
			// 
			this.CURRENT_PROGRESS_LABEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CURRENT_PROGRESS_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.CURRENT_PROGRESS_LABEL.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.CURRENT_PROGRESS_LABEL.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CURRENT_PROGRESS_LABEL.Location = new System.Drawing.Point(480, 16);
			this.CURRENT_PROGRESS_LABEL.Name = "CURRENT_PROGRESS_LABEL";
			this.CURRENT_PROGRESS_LABEL.Size = new System.Drawing.Size(428, 13);
			this.CURRENT_PROGRESS_LABEL.TabIndex = 16;
			this.CURRENT_PROGRESS_LABEL.Text = "가입 정보 불러오는 중 ...";
			this.CURRENT_PROGRESS_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.CURRENT_PROGRESS_LABEL.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			// 
			// STEP_CHATBOX_TITLE
			// 
			this.STEP_CHATBOX_TITLE.AutoSize = true;
			this.STEP_CHATBOX_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.STEP_CHATBOX_TITLE.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.STEP_CHATBOX_TITLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.STEP_CHATBOX_TITLE.Location = new System.Drawing.Point(40, 57);
			this.STEP_CHATBOX_TITLE.Name = "STEP_CHATBOX_TITLE";
			this.STEP_CHATBOX_TITLE.Size = new System.Drawing.Size(82, 17);
			this.STEP_CHATBOX_TITLE.TabIndex = 22;
			this.STEP_CHATBOX_TITLE.Text = "스탭 채팅방";
			// 
			// APP_NOTIFY_ICON
			// 
			this.APP_NOTIFY_ICON.BalloonTipTitle = "우윳빛깔 카페스탭";
			this.APP_NOTIFY_ICON.ContextMenuStrip = this.APP_NOTIFY_ICON_MENU;
			this.APP_NOTIFY_ICON.Icon = ((System.Drawing.Icon)(resources.GetObject("APP_NOTIFY_ICON.Icon")));
			this.APP_NOTIFY_ICON.Text = "우윳빛깔 카페스탭";
			this.APP_NOTIFY_ICON.Visible = true;
			// 
			// APP_NOTIFY_ICON_MENU
			// 
			this.APP_NOTIFY_ICON_MENU.BackColor = System.Drawing.Color.White;
			this.APP_NOTIFY_ICON_MENU.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.APP_NOTIFY_ICON_MENU_ITEM_1});
			this.APP_NOTIFY_ICON_MENU.Name = "APP_NOTIFY_ICON_MENU";
			this.APP_NOTIFY_ICON_MENU.Size = new System.Drawing.Size(191, 26);
			// 
			// APP_NOTIFY_ICON_MENU_ITEM_1
			// 
			this.APP_NOTIFY_ICON_MENU_ITEM_1.BackColor = System.Drawing.Color.White;
			this.APP_NOTIFY_ICON_MENU_ITEM_1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.APP_NOTIFY_ICON_MENU_ITEM_1.Name = "APP_NOTIFY_ICON_MENU_ITEM_1";
			this.APP_NOTIFY_ICON_MENU_ITEM_1.Size = new System.Drawing.Size(190, 22);
			this.APP_NOTIFY_ICON_MENU_ITEM_1.Text = "우윳빛깔 카페스탭 종료";
			this.APP_NOTIFY_ICON_MENU_ITEM_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.APP_NOTIFY_ICON_MENU_ITEM_1.ToolTipText = "우윳빛깔 카페스탭을 종료합니다.";
			this.APP_NOTIFY_ICON_MENU_ITEM_1.Click += new System.EventHandler(this.APP_NOTIFY_ICON_MENU_ITEM_1_Click);
			// 
			// UTIL_ICON_BUTTON7
			// 
			this.UTIL_ICON_BUTTON7.AnimationLerpP = 0.8F;
			this.UTIL_ICON_BUTTON7.BackColor = System.Drawing.Color.Transparent;
			this.UTIL_ICON_BUTTON7.Cursor = System.Windows.Forms.Cursors.Hand;
			this.UTIL_ICON_BUTTON7.EnterStateBackgroundColor = System.Drawing.Color.Red;
			this.UTIL_ICON_BUTTON7.Image = global::CafeMaster_UI.Properties.Resources.UTIL_ICON_6;
			this.UTIL_ICON_BUTTON7.Location = new System.Drawing.Point(1034, 229);
			this.UTIL_ICON_BUTTON7.Name = "UTIL_ICON_BUTTON7";
			this.UTIL_ICON_BUTTON7.NormalStateBackgroundColor = System.Drawing.Color.Crimson;
			this.UTIL_ICON_BUTTON7.Size = new System.Drawing.Size(40, 40);
			this.UTIL_ICON_BUTTON7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.UTIL_ICON_BUTTON7.TabIndex = 56;
			this.UTIL_ICON_BUTTON7.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.UTIL_ICON_BUTTON7, "회원 경고");
			this.UTIL_ICON_BUTTON7.Click += new System.EventHandler(this.UTIL_ICON_BUTTON7_Click);
			// 
			// CHILD_PANEL_UTIL_ALL_SELECT
			// 
			this.CHILD_PANEL_UTIL_ALL_SELECT.AnimationLerpP = 0.8F;
			this.CHILD_PANEL_UTIL_ALL_SELECT.BackColor = System.Drawing.Color.Transparent;
			this.CHILD_PANEL_UTIL_ALL_SELECT.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CHILD_PANEL_UTIL_ALL_SELECT.EnterStateBackgroundColor = System.Drawing.Color.Blue;
			this.CHILD_PANEL_UTIL_ALL_SELECT.Image = global::CafeMaster_UI.Properties.Resources.SELECT_ALL;
			this.CHILD_PANEL_UTIL_ALL_SELECT.Location = new System.Drawing.Point(963, 50);
			this.CHILD_PANEL_UTIL_ALL_SELECT.Name = "CHILD_PANEL_UTIL_ALL_SELECT";
			this.CHILD_PANEL_UTIL_ALL_SELECT.NormalStateBackgroundColor = System.Drawing.Color.RoyalBlue;
			this.CHILD_PANEL_UTIL_ALL_SELECT.Size = new System.Drawing.Size(30, 30);
			this.CHILD_PANEL_UTIL_ALL_SELECT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.CHILD_PANEL_UTIL_ALL_SELECT.TabIndex = 53;
			this.CHILD_PANEL_UTIL_ALL_SELECT.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.CHILD_PANEL_UTIL_ALL_SELECT, "새 게시물 알림 전체 선택");
			this.CHILD_PANEL_UTIL_ALL_SELECT.Click += new System.EventHandler(this.CHILD_PANEL_UTIL_ALL_SELECT_Click);
			// 
			// CHILD_PANEL_UTIL_DELETE
			// 
			this.CHILD_PANEL_UTIL_DELETE.AnimationLerpP = 0.8F;
			this.CHILD_PANEL_UTIL_DELETE.BackColor = System.Drawing.Color.Transparent;
			this.CHILD_PANEL_UTIL_DELETE.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CHILD_PANEL_UTIL_DELETE.EnterStateBackgroundColor = System.Drawing.Color.Red;
			this.CHILD_PANEL_UTIL_DELETE.Image = global::CafeMaster_UI.Properties.Resources.NOTIFY_REMOVE;
			this.CHILD_PANEL_UTIL_DELETE.Location = new System.Drawing.Point(999, 50);
			this.CHILD_PANEL_UTIL_DELETE.Name = "CHILD_PANEL_UTIL_DELETE";
			this.CHILD_PANEL_UTIL_DELETE.NormalStateBackgroundColor = System.Drawing.Color.Crimson;
			this.CHILD_PANEL_UTIL_DELETE.Size = new System.Drawing.Size(30, 30);
			this.CHILD_PANEL_UTIL_DELETE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.CHILD_PANEL_UTIL_DELETE.TabIndex = 52;
			this.CHILD_PANEL_UTIL_DELETE.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.CHILD_PANEL_UTIL_DELETE, "선택한 새 게시물 알림 일괄 삭제");
			this.CHILD_PANEL_UTIL_DELETE.Click += new System.EventHandler(this.CHILD_PANEL_UTIL_DELETE_Click);
			// 
			// UTIL_ICON_BUTTON6
			// 
			this.UTIL_ICON_BUTTON6.AnimationLerpP = 0.8F;
			this.UTIL_ICON_BUTTON6.BackColor = System.Drawing.Color.Transparent;
			this.UTIL_ICON_BUTTON6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.UTIL_ICON_BUTTON6.EnterStateBackgroundColor = System.Drawing.Color.DimGray;
			this.UTIL_ICON_BUTTON6.Image = global::CafeMaster_UI.Properties.Resources.MEMBER_RANK;
			this.UTIL_ICON_BUTTON6.Location = new System.Drawing.Point(1034, 137);
			this.UTIL_ICON_BUTTON6.Name = "UTIL_ICON_BUTTON6";
			this.UTIL_ICON_BUTTON6.NormalStateBackgroundColor = System.Drawing.Color.Gray;
			this.UTIL_ICON_BUTTON6.Size = new System.Drawing.Size(40, 40);
			this.UTIL_ICON_BUTTON6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.UTIL_ICON_BUTTON6.TabIndex = 51;
			this.UTIL_ICON_BUTTON6.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.UTIL_ICON_BUTTON6, "카페 회원 등급 보기");
			this.UTIL_ICON_BUTTON6.Click += new System.EventHandler(this.UTIL_ICON_BUTTON6_Click);
			// 
			// UTIL_ICON_BUTTON5
			// 
			this.UTIL_ICON_BUTTON5.AnimationLerpP = 0.8F;
			this.UTIL_ICON_BUTTON5.BackColor = System.Drawing.Color.Transparent;
			this.UTIL_ICON_BUTTON5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.UTIL_ICON_BUTTON5.EnterStateBackgroundColor = System.Drawing.Color.DimGray;
			this.UTIL_ICON_BUTTON5.Image = global::CafeMaster_UI.Properties.Resources.UTIL_ICON_5;
			this.UTIL_ICON_BUTTON5.Location = new System.Drawing.Point(1080, 321);
			this.UTIL_ICON_BUTTON5.Name = "UTIL_ICON_BUTTON5";
			this.UTIL_ICON_BUTTON5.NormalStateBackgroundColor = System.Drawing.Color.Gray;
			this.UTIL_ICON_BUTTON5.Size = new System.Drawing.Size(40, 40);
			this.UTIL_ICON_BUTTON5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.UTIL_ICON_BUTTON5.TabIndex = 50;
			this.UTIL_ICON_BUTTON5.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.UTIL_ICON_BUTTON5, "맞춤법 검사");
			this.UTIL_ICON_BUTTON5.Visible = false;
			this.UTIL_ICON_BUTTON5.Click += new System.EventHandler(this.UTIL_ICON_BUTTON5_Click);
			// 
			// UTIL_ICON_BUTTON4
			// 
			this.UTIL_ICON_BUTTON4.AnimationLerpP = 0.8F;
			this.UTIL_ICON_BUTTON4.BackColor = System.Drawing.Color.Transparent;
			this.UTIL_ICON_BUTTON4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.UTIL_ICON_BUTTON4.EnterStateBackgroundColor = System.Drawing.Color.LightGreen;
			this.UTIL_ICON_BUTTON4.Image = global::CafeMaster_UI.Properties.Resources.UTIL_ICON_4;
			this.UTIL_ICON_BUTTON4.Location = new System.Drawing.Point(1034, 183);
			this.UTIL_ICON_BUTTON4.Name = "UTIL_ICON_BUTTON4";
			this.UTIL_ICON_BUTTON4.NormalStateBackgroundColor = System.Drawing.Color.YellowGreen;
			this.UTIL_ICON_BUTTON4.Size = new System.Drawing.Size(40, 40);
			this.UTIL_ICON_BUTTON4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.UTIL_ICON_BUTTON4.TabIndex = 49;
			this.UTIL_ICON_BUTTON4.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.UTIL_ICON_BUTTON4, "카페 가입 신청 관리");
			this.UTIL_ICON_BUTTON4.Click += new System.EventHandler(this.UTIL_ICON_BUTTON4_Click);
			// 
			// UTIL_ICON_BUTTON2
			// 
			this.UTIL_ICON_BUTTON2.AnimationLerpP = 0.8F;
			this.UTIL_ICON_BUTTON2.BackColor = System.Drawing.Color.Transparent;
			this.UTIL_ICON_BUTTON2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.UTIL_ICON_BUTTON2.EnterStateBackgroundColor = System.Drawing.Color.LightGreen;
			this.UTIL_ICON_BUTTON2.Image = global::CafeMaster_UI.Properties.Resources.UTIL_ICON_2;
			this.UTIL_ICON_BUTTON2.Location = new System.Drawing.Point(1080, 183);
			this.UTIL_ICON_BUTTON2.Name = "UTIL_ICON_BUTTON2";
			this.UTIL_ICON_BUTTON2.NormalStateBackgroundColor = System.Drawing.Color.YellowGreen;
			this.UTIL_ICON_BUTTON2.Size = new System.Drawing.Size(40, 40);
			this.UTIL_ICON_BUTTON2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.UTIL_ICON_BUTTON2.TabIndex = 47;
			this.UTIL_ICON_BUTTON2.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.UTIL_ICON_BUTTON2, "카페 관리");
			this.UTIL_ICON_BUTTON2.Click += new System.EventHandler(this.UTIL_ICON_BUTTON2_Click);
			// 
			// UTIL_ICON_BUTTON1
			// 
			this.UTIL_ICON_BUTTON1.AnimationLerpP = 0.8F;
			this.UTIL_ICON_BUTTON1.BackColor = System.Drawing.Color.Transparent;
			this.UTIL_ICON_BUTTON1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.UTIL_ICON_BUTTON1.EnterStateBackgroundColor = System.Drawing.Color.DimGray;
			this.UTIL_ICON_BUTTON1.Image = global::CafeMaster_UI.Properties.Resources.UTIL_ICON_1;
			this.UTIL_ICON_BUTTON1.Location = new System.Drawing.Point(1080, 137);
			this.UTIL_ICON_BUTTON1.Name = "UTIL_ICON_BUTTON1";
			this.UTIL_ICON_BUTTON1.NormalStateBackgroundColor = System.Drawing.Color.Gray;
			this.UTIL_ICON_BUTTON1.Size = new System.Drawing.Size(40, 40);
			this.UTIL_ICON_BUTTON1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.UTIL_ICON_BUTTON1.TabIndex = 46;
			this.UTIL_ICON_BUTTON1.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.UTIL_ICON_BUTTON1, "카페 전체 규칙");
			this.UTIL_ICON_BUTTON1.Click += new System.EventHandler(this.UTIL_ICON_BUTTON1_Click);
			// 
			// UPDATE_AVAILABLE
			// 
			this.UPDATE_AVAILABLE.BackColor = System.Drawing.Color.Transparent;
			this.UPDATE_AVAILABLE.Cursor = System.Windows.Forms.Cursors.Hand;
			this.UPDATE_AVAILABLE.Image = global::CafeMaster_UI.Properties.Resources.UPDATE_HAVE;
			this.UPDATE_AVAILABLE.Location = new System.Drawing.Point(1080, 640);
			this.UPDATE_AVAILABLE.Name = "UPDATE_AVAILABLE";
			this.UPDATE_AVAILABLE.Size = new System.Drawing.Size(40, 40);
			this.UPDATE_AVAILABLE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.UPDATE_AVAILABLE.TabIndex = 21;
			this.UPDATE_AVAILABLE.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.UPDATE_AVAILABLE, "새로운 프로그램 버전이 있습니다.");
			this.UPDATE_AVAILABLE.Visible = false;
			this.UPDATE_AVAILABLE.Click += new System.EventHandler(this.UPDATE_AVAILABLE_Click);
			// 
			// UTIL_ICON_BUTTON8
			// 
			this.UTIL_ICON_BUTTON8.AnimationLerpP = 0.8F;
			this.UTIL_ICON_BUTTON8.BackColor = System.Drawing.Color.Transparent;
			this.UTIL_ICON_BUTTON8.Cursor = System.Windows.Forms.Cursors.Hand;
			this.UTIL_ICON_BUTTON8.EnterStateBackgroundColor = System.Drawing.Color.Red;
			this.UTIL_ICON_BUTTON8.Image = global::CafeMaster_UI.Properties.Resources.UTIL_ICON_3;
			this.UTIL_ICON_BUTTON8.Location = new System.Drawing.Point(1080, 229);
			this.UTIL_ICON_BUTTON8.Name = "UTIL_ICON_BUTTON8";
			this.UTIL_ICON_BUTTON8.NormalStateBackgroundColor = System.Drawing.Color.Crimson;
			this.UTIL_ICON_BUTTON8.Size = new System.Drawing.Size(40, 40);
			this.UTIL_ICON_BUTTON8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.UTIL_ICON_BUTTON8.TabIndex = 57;
			this.UTIL_ICON_BUTTON8.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.UTIL_ICON_BUTTON8, "활동 정지");
			this.UTIL_ICON_BUTTON8.Click += new System.EventHandler(this.UTIL_ICON_BUTTON8_Click);
			// 
			// NOTIFYBOX_EMPTY_TITLE
			// 
			this.NOTIFYBOX_EMPTY_TITLE.AutoSize = true;
			this.NOTIFYBOX_EMPTY_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.NOTIFYBOX_EMPTY_TITLE.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.NOTIFYBOX_EMPTY_TITLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.NOTIFYBOX_EMPTY_TITLE.Location = new System.Drawing.Point(686, 370);
			this.NOTIFYBOX_EMPTY_TITLE.Name = "NOTIFYBOX_EMPTY_TITLE";
			this.NOTIFYBOX_EMPTY_TITLE.Size = new System.Drawing.Size(128, 21);
			this.NOTIFYBOX_EMPTY_TITLE.TabIndex = 37;
			this.NOTIFYBOX_EMPTY_TITLE.Text = "새 게시물 없음";
			this.NOTIFYBOX_EMPTY_TITLE.Visible = false;
			// 
			// NOTIFYBOX_EMPTY_DESC
			// 
			this.NOTIFYBOX_EMPTY_DESC.AutoSize = true;
			this.NOTIFYBOX_EMPTY_DESC.BackColor = System.Drawing.Color.Transparent;
			this.NOTIFYBOX_EMPTY_DESC.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.NOTIFYBOX_EMPTY_DESC.ForeColor = System.Drawing.SystemColors.ControlText;
			this.NOTIFYBOX_EMPTY_DESC.Location = new System.Drawing.Point(631, 405);
			this.NOTIFYBOX_EMPTY_DESC.Name = "NOTIFYBOX_EMPTY_DESC";
			this.NOTIFYBOX_EMPTY_DESC.Size = new System.Drawing.Size(239, 15);
			this.NOTIFYBOX_EMPTY_DESC.TabIndex = 38;
			this.NOTIFYBOX_EMPTY_DESC.Text = "새 게시물이 없어요! 수고하셨습니다 ^ㅇ^";
			this.NOTIFYBOX_EMPTY_DESC.Visible = false;
			// 
			// NOTIFY_PANEL_TITLE
			// 
			this.NOTIFY_PANEL_TITLE.AutoSize = true;
			this.NOTIFY_PANEL_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.NOTIFY_PANEL_TITLE.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.NOTIFY_PANEL_TITLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.NOTIFY_PANEL_TITLE.Location = new System.Drawing.Point(500, 57);
			this.NOTIFY_PANEL_TITLE.Name = "NOTIFY_PANEL_TITLE";
			this.NOTIFY_PANEL_TITLE.Size = new System.Drawing.Size(68, 17);
			this.NOTIFY_PANEL_TITLE.TabIndex = 42;
			this.NOTIFY_PANEL_TITLE.Text = "새 게시물";
			// 
			// STEP_CHATBOX
			// 
			this.STEP_CHATBOX.AllowWebBrowserDrop = false;
			this.STEP_CHATBOX.Location = new System.Drawing.Point(10, 85);
			this.STEP_CHATBOX.MinimumSize = new System.Drawing.Size(20, 20);
			this.STEP_CHATBOX.Name = "STEP_CHATBOX";
			this.STEP_CHATBOX.ScrollBarsEnabled = false;
			this.STEP_CHATBOX.Size = new System.Drawing.Size(450, 590);
			this.STEP_CHATBOX.TabIndex = 21;
			this.STEP_CHATBOX.Url = new System.Uri("", System.UriKind.Relative);
			// 
			// FORCE_SYNC_DELAY_TIMER
			// 
			this.FORCE_SYNC_DELAY_TIMER.Interval = 10000;
			this.FORCE_SYNC_DELAY_TIMER.Tick += new System.EventHandler(this.FORCE_SYNC_DELAY_TIMER_Tick);
			// 
			// NOTIFY_PANEL
			// 
			this.NOTIFY_PANEL.AutoScroll = true;
			this.NOTIFY_PANEL.BackColor = System.Drawing.Color.Transparent;
			this.NOTIFY_PANEL.Location = new System.Drawing.Point(469, 85);
			this.NOTIFY_PANEL.Name = "NOTIFY_PANEL";
			this.NOTIFY_PANEL.Size = new System.Drawing.Size(560, 590);
			this.NOTIFY_PANEL.TabIndex = 20;
			this.NOTIFY_PANEL.Scroll += new System.Windows.Forms.ScrollEventHandler(this.NOTIFY_PANEL_Scroll);
			this.NOTIFY_PANEL.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.NOTIFY_PANEL_ControlAdded);
			this.NOTIFY_PANEL.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.NOTIFY_PANEL_ControlRemoved);
			this.NOTIFY_PANEL.Paint += new System.Windows.Forms.PaintEventHandler(this.NOTIFY_PANEL_Paint);
			this.NOTIFY_PANEL.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.NOTIFY_PANEL_MouseWheel);
			// 
			// NETWORK_SYNC_ANIMATION_TIMER
			// 
			this.NETWORK_SYNC_ANIMATION_TIMER.Interval = 200;
			this.NETWORK_SYNC_ANIMATION_TIMER.Tick += new System.EventHandler(this.NETWORK_SYNC_ANIMATION_TIMER_Tick);
			// 
			// CHILD_PANEL_LABEL_SELECTED_COUNT
			// 
			this.CHILD_PANEL_LABEL_SELECTED_COUNT.BackColor = System.Drawing.Color.Transparent;
			this.CHILD_PANEL_LABEL_SELECTED_COUNT.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.CHILD_PANEL_LABEL_SELECTED_COUNT.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CHILD_PANEL_LABEL_SELECTED_COUNT.Location = new System.Drawing.Point(574, 58);
			this.CHILD_PANEL_LABEL_SELECTED_COUNT.Name = "CHILD_PANEL_LABEL_SELECTED_COUNT";
			this.CHILD_PANEL_LABEL_SELECTED_COUNT.Size = new System.Drawing.Size(383, 15);
			this.CHILD_PANEL_LABEL_SELECTED_COUNT.TabIndex = 55;
			this.CHILD_PANEL_LABEL_SELECTED_COUNT.Text = "전체 0개 중 0개 선택함";
			this.CHILD_PANEL_LABEL_SELECTED_COUNT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.CHILD_PANEL_LABEL_SELECTED_COUNT.Visible = false;
			// 
			// NOTIFY_PANEL_ICON
			// 
			this.NOTIFY_PANEL_ICON.BackColor = System.Drawing.Color.Transparent;
			this.NOTIFY_PANEL_ICON.Cursor = System.Windows.Forms.Cursors.Default;
			this.NOTIFY_PANEL_ICON.Image = global::CafeMaster_UI.Properties.Resources.NEW_ARTICLE;
			this.NOTIFY_PANEL_ICON.Location = new System.Drawing.Point(469, 53);
			this.NOTIFY_PANEL_ICON.Name = "NOTIFY_PANEL_ICON";
			this.NOTIFY_PANEL_ICON.Size = new System.Drawing.Size(25, 25);
			this.NOTIFY_PANEL_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.NOTIFY_PANEL_ICON.TabIndex = 43;
			this.NOTIFY_PANEL_ICON.TabStop = false;
			// 
			// STEP_CHATBOX_ICON
			// 
			this.STEP_CHATBOX_ICON.BackColor = System.Drawing.Color.Transparent;
			this.STEP_CHATBOX_ICON.Cursor = System.Windows.Forms.Cursors.Default;
			this.STEP_CHATBOX_ICON.Image = global::CafeMaster_UI.Properties.Resources.CHAT;
			this.STEP_CHATBOX_ICON.Location = new System.Drawing.Point(10, 53);
			this.STEP_CHATBOX_ICON.Name = "STEP_CHATBOX_ICON";
			this.STEP_CHATBOX_ICON.Size = new System.Drawing.Size(25, 25);
			this.STEP_CHATBOX_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.STEP_CHATBOX_ICON.TabIndex = 41;
			this.STEP_CHATBOX_ICON.TabStop = false;
			// 
			// NOTIFYBOX_EMPTY_ICON
			// 
			this.NOTIFYBOX_EMPTY_ICON.BackColor = System.Drawing.Color.Transparent;
			this.NOTIFYBOX_EMPTY_ICON.Image = global::CafeMaster_UI.Properties.Resources.EMPTY;
			this.NOTIFYBOX_EMPTY_ICON.Location = new System.Drawing.Point(700, 245);
			this.NOTIFYBOX_EMPTY_ICON.Name = "NOTIFYBOX_EMPTY_ICON";
			this.NOTIFYBOX_EMPTY_ICON.Size = new System.Drawing.Size(100, 100);
			this.NOTIFYBOX_EMPTY_ICON.TabIndex = 39;
			this.NOTIFYBOX_EMPTY_ICON.TabStop = false;
			this.NOTIFYBOX_EMPTY_ICON.Visible = false;
			// 
			// NAVER_ICON_IMAGE
			// 
			this.NAVER_ICON_IMAGE.BackgroundImage = global::CafeMaster_UI.Properties.Resources.PROFILE_UNKNOWN_V2_120x120;
			this.NAVER_ICON_IMAGE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.NAVER_ICON_IMAGE.Image = global::CafeMaster_UI.Properties.Resources.PROFILE_IMAGE_CIRCLE;
			this.NAVER_ICON_IMAGE.Location = new System.Drawing.Point(1037, 51);
			this.NAVER_ICON_IMAGE.Name = "NAVER_ICON_IMAGE";
			this.NAVER_ICON_IMAGE.Size = new System.Drawing.Size(80, 80);
			this.NAVER_ICON_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.NAVER_ICON_IMAGE.TabIndex = 19;
			this.NAVER_ICON_IMAGE.TabStop = false;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1125, 685);
			this.Controls.Add(this.UTIL_ICON_BUTTON8);
			this.Controls.Add(this.UTIL_ICON_BUTTON7);
			this.Controls.Add(this.CHILD_PANEL_LABEL_SELECTED_COUNT);
			this.Controls.Add(this.CHILD_PANEL_UTIL_ALL_SELECT);
			this.Controls.Add(this.CHILD_PANEL_UTIL_DELETE);
			this.Controls.Add(this.UTIL_ICON_BUTTON6);
			this.Controls.Add(this.UTIL_ICON_BUTTON5);
			this.Controls.Add(this.UTIL_ICON_BUTTON4);
			this.Controls.Add(this.UTIL_ICON_BUTTON2);
			this.Controls.Add(this.UTIL_ICON_BUTTON1);
			this.Controls.Add(this.NOTIFY_PANEL_ICON);
			this.Controls.Add(this.NOTIFY_PANEL_TITLE);
			this.Controls.Add(this.STEP_CHATBOX_ICON);
			this.Controls.Add(this.UPDATE_AVAILABLE);
			this.Controls.Add(this.NOTIFYBOX_EMPTY_ICON);
			this.Controls.Add(this.NOTIFYBOX_EMPTY_TITLE);
			this.Controls.Add(this.NOTIFYBOX_EMPTY_DESC);
			this.Controls.Add(this.NAVER_ICON_IMAGE);
			this.Controls.Add(this.STEP_CHATBOX_TITLE);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.Controls.Add(this.STEP_CHATBOX);
			this.Controls.Add(this.NOTIFY_PANEL);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "우윳빛깔 카페스탭";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.Load += new System.EventHandler(this.Main_Load);
			this.Shown += new System.EventHandler(this.Main_Shown);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NETWORK_STATUS_ICON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.INFO_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OPTION_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FORCE_REFRESH_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BELL_STATUS_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HIDE_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).EndInit();
			this.APP_NOTIFY_ICON_MENU.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.UTIL_ICON_BUTTON7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CHILD_PANEL_UTIL_ALL_SELECT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CHILD_PANEL_UTIL_DELETE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UTIL_ICON_BUTTON6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UTIL_ICON_BUTTON5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UTIL_ICON_BUTTON4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UTIL_ICON_BUTTON2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UTIL_ICON_BUTTON1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UPDATE_AVAILABLE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UTIL_ICON_BUTTON8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NOTIFY_PANEL_ICON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.STEP_CHATBOX_ICON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NOTIFYBOX_EMPTY_ICON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NAVER_ICON_IMAGE)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private CafeMaster_UI.Interface.CustomLabel CURRENT_PROGRESS_LABEL;
		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private CafeMaster_UI.Interface.CustomLabel APP_TITLE;
		private System.Windows.Forms.PictureBox CLOSE_BUTTON;
		private Interface.DoubleBufferPanel NOTIFY_PANEL;
		private System.Windows.Forms.WebBrowser STEP_CHATBOX;
		private System.Windows.Forms.Label STEP_CHATBOX_TITLE;
		private System.Windows.Forms.PictureBox NAVER_ICON_IMAGE;
		private System.Windows.Forms.PictureBox HIDE_BUTTON;
		private System.Windows.Forms.NotifyIcon APP_NOTIFY_ICON;
		private System.Windows.Forms.PictureBox BELL_STATUS_BUTTON;
		private System.Windows.Forms.PictureBox FORCE_REFRESH_BUTTON;
        private System.Windows.Forms.ToolTip TOOL_TIP;
		private System.Windows.Forms.PictureBox UPDATE_AVAILABLE;
		private System.Windows.Forms.PictureBox OPTION_BUTTON;
		private System.Windows.Forms.PictureBox NOTIFYBOX_EMPTY_ICON;
		private System.Windows.Forms.Label NOTIFYBOX_EMPTY_DESC;
		private System.Windows.Forms.Label NOTIFYBOX_EMPTY_TITLE;
		private System.Windows.Forms.PictureBox STEP_CHATBOX_ICON;
		private System.Windows.Forms.PictureBox NOTIFY_PANEL_ICON;
		private System.Windows.Forms.Label NOTIFY_PANEL_TITLE;
		private System.Windows.Forms.PictureBox INFO_BUTTON;
		private System.Windows.Forms.Timer FORCE_SYNC_DELAY_TIMER;
		private System.Windows.Forms.PictureBox NETWORK_STATUS_ICON;
		private System.Windows.Forms.ContextMenuStrip APP_NOTIFY_ICON_MENU;
		private System.Windows.Forms.ToolStripMenuItem APP_NOTIFY_ICON_MENU_ITEM_1;
		private System.Windows.Forms.Timer NETWORK_SYNC_ANIMATION_TIMER;
		private Interface.FlatImageButton UTIL_ICON_BUTTON1;
		private Interface.FlatImageButton UTIL_ICON_BUTTON2;
		private Interface.FlatImageButton UTIL_ICON_BUTTON4;
		private Interface.FlatImageButton UTIL_ICON_BUTTON5;
		private Interface.FlatImageButton UTIL_ICON_BUTTON6;
		private Interface.FlatImageButton CHILD_PANEL_UTIL_DELETE;
		private Interface.FlatImageButton CHILD_PANEL_UTIL_ALL_SELECT;
		private System.Windows.Forms.Timer PROGRAM_CLOSE_ANIMATION;
		private System.Windows.Forms.Label CHILD_PANEL_LABEL_SELECTED_COUNT;
		private Interface.FlatImageButton UTIL_ICON_BUTTON7;
		private Interface.FlatImageButton UTIL_ICON_BUTTON8;
	}
}

