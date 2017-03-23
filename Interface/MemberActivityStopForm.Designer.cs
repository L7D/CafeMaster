namespace CafeMaster_UI.Interface
{
	partial class MemberActivityStopForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberActivityStopForm));
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel();
			this.APP_TITLE = new System.Windows.Forms.Label();
			this.CLOSE_BUTTON = new System.Windows.Forms.PictureBox();
			this.REASON_TITLE = new System.Windows.Forms.Label();
			this.REASON_TEXTBOX = new System.Windows.Forms.TextBox();
			this.REASON_DESC = new System.Windows.Forms.Label();
			this.STOP_LENGTH = new System.Windows.Forms.NumericUpDown();
			this.COUNT_TITLE = new System.Windows.Forms.Label();
			this.WARNING_COUNT_AFTERDESC = new System.Windows.Forms.Label();
			this.USER_INFORMATION_PANEL = new System.Windows.Forms.Panel();
			this.MEMBER_INFO_OPEN_BUTTON = new CafeMaster_UI.Interface.FlatButton();
			this.RANK_LABEL = new System.Windows.Forms.Label();
			this.SELECT_RESET_BUTTON = new CafeMaster_UI.Interface.FlatButton();
			this.PERSONACON_IMAGE_ICON = new System.Windows.Forms.PictureBox();
			this.USERNAME_LABEL = new System.Windows.Forms.Label();
			this.PROFILE_IMAGE_ICON = new System.Windows.Forms.PictureBox();
			this.USER_INFORMATION_PANEL_TITLE = new System.Windows.Forms.Label();
			this.USER_SEARCH_TEXTBOX = new System.Windows.Forms.TextBox();
			this.STOP_LENGTH_TITLE = new System.Windows.Forms.Label();
			this.STOP_LENGTH_DAY_LABEL = new System.Windows.Forms.Label();
			this.USER_SEARCH_DESC = new System.Windows.Forms.Label();
			this.STOP_INFORMATION_PANEL = new System.Windows.Forms.Panel();
			this.UNLIMITED_LENGTH_CHECKBOX = new System.Windows.Forms.CheckBox();
			this.USER_SEARCH_TITLE = new System.Windows.Forms.Label();
			this.BACKGROUND_SPLASH = new System.Windows.Forms.PictureBox();
			this.WARN_TEXT = new System.Windows.Forms.Label();
			this.WARN_ICON = new System.Windows.Forms.PictureBox();
			this.USER_SEARCH_BUTTON = new CafeMaster_UI.Interface.FlatButton();
			this.CANCEL_BUTTON = new CafeMaster_UI.Interface.FlatButton();
			this.ACTIVITY_STOP_RUN_BUTTON = new CafeMaster_UI.Interface.FlatButton();
			this.APP_TITLE_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.STOP_LENGTH)).BeginInit();
			this.USER_INFORMATION_PANEL.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PERSONACON_IMAGE_ICON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PROFILE_IMAGE_ICON)).BeginInit();
			this.STOP_INFORMATION_PANEL.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BACKGROUND_SPLASH)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WARN_ICON)).BeginInit();
			this.SuspendLayout();
			// 
			// APP_TITLE_BAR
			// 
			this.APP_TITLE_BAR.BackColor = System.Drawing.Color.Transparent;
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
			this.APP_TITLE.Text = "활동 정지";
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
			// REASON_TITLE
			// 
			this.REASON_TITLE.AutoSize = true;
			this.REASON_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.REASON_TITLE.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.REASON_TITLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.REASON_TITLE.Location = new System.Drawing.Point(0, 0);
			this.REASON_TITLE.Name = "REASON_TITLE";
			this.REASON_TITLE.Size = new System.Drawing.Size(36, 17);
			this.REASON_TITLE.TabIndex = 5;
			this.REASON_TITLE.Text = "사유";
			// 
			// REASON_TEXTBOX
			// 
			this.REASON_TEXTBOX.BackColor = System.Drawing.Color.White;
			this.REASON_TEXTBOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.REASON_TEXTBOX.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.REASON_TEXTBOX.Location = new System.Drawing.Point(3, 25);
			this.REASON_TEXTBOX.MaxLength = 25;
			this.REASON_TEXTBOX.Name = "REASON_TEXTBOX";
			this.REASON_TEXTBOX.Size = new System.Drawing.Size(528, 22);
			this.REASON_TEXTBOX.TabIndex = 6;
			this.REASON_TEXTBOX.TextChanged += new System.EventHandler(this.REASON_TEXTBOX_TextChanged);
			// 
			// REASON_DESC
			// 
			this.REASON_DESC.AutoSize = true;
			this.REASON_DESC.BackColor = System.Drawing.Color.Transparent;
			this.REASON_DESC.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.REASON_DESC.ForeColor = System.Drawing.SystemColors.ControlText;
			this.REASON_DESC.Location = new System.Drawing.Point(1, 54);
			this.REASON_DESC.Name = "REASON_DESC";
			this.REASON_DESC.Size = new System.Drawing.Size(212, 14);
			this.REASON_DESC.TabIndex = 12;
			this.REASON_DESC.Text = "25자 이내로 활동 정지 사유를 작성하세요";
			// 
			// STOP_LENGTH
			// 
			this.STOP_LENGTH.BackColor = System.Drawing.Color.White;
			this.STOP_LENGTH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.STOP_LENGTH.Font = new System.Drawing.Font("나눔고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.STOP_LENGTH.ForeColor = System.Drawing.Color.Red;
			this.STOP_LENGTH.Location = new System.Drawing.Point(73, 88);
			this.STOP_LENGTH.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.STOP_LENGTH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.STOP_LENGTH.Name = "STOP_LENGTH";
			this.STOP_LENGTH.Size = new System.Drawing.Size(83, 44);
			this.STOP_LENGTH.TabIndex = 19;
			this.STOP_LENGTH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.STOP_LENGTH.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.STOP_LENGTH.ValueChanged += new System.EventHandler(this.WARNING_COUNT_ValueChanged);
			// 
			// COUNT_TITLE
			// 
			this.COUNT_TITLE.AutoSize = true;
			this.COUNT_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.COUNT_TITLE.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.COUNT_TITLE.ForeColor = System.Drawing.Color.Red;
			this.COUNT_TITLE.Location = new System.Drawing.Point(6, 11);
			this.COUNT_TITLE.Name = "COUNT_TITLE";
			this.COUNT_TITLE.Size = new System.Drawing.Size(0, 17);
			this.COUNT_TITLE.TabIndex = 20;
			// 
			// WARNING_COUNT_AFTERDESC
			// 
			this.WARNING_COUNT_AFTERDESC.BackColor = System.Drawing.Color.Transparent;
			this.WARNING_COUNT_AFTERDESC.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.WARNING_COUNT_AFTERDESC.ForeColor = System.Drawing.Color.Red;
			this.WARNING_COUNT_AFTERDESC.Location = new System.Drawing.Point(190, 104);
			this.WARNING_COUNT_AFTERDESC.Name = "WARNING_COUNT_AFTERDESC";
			this.WARNING_COUNT_AFTERDESC.Size = new System.Drawing.Size(344, 15);
			this.WARNING_COUNT_AFTERDESC.TabIndex = 23;
			this.WARNING_COUNT_AFTERDESC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.USER_INFORMATION_PANEL.Visible = false;
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
			// STOP_LENGTH_TITLE
			// 
			this.STOP_LENGTH_TITLE.AutoSize = true;
			this.STOP_LENGTH_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.STOP_LENGTH_TITLE.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.STOP_LENGTH_TITLE.ForeColor = System.Drawing.Color.Red;
			this.STOP_LENGTH_TITLE.Location = new System.Drawing.Point(0, 102);
			this.STOP_LENGTH_TITLE.Name = "STOP_LENGTH_TITLE";
			this.STOP_LENGTH_TITLE.Size = new System.Drawing.Size(68, 17);
			this.STOP_LENGTH_TITLE.TabIndex = 30;
			this.STOP_LENGTH_TITLE.Text = "정지 기간";
			// 
			// STOP_LENGTH_DAY_LABEL
			// 
			this.STOP_LENGTH_DAY_LABEL.AutoSize = true;
			this.STOP_LENGTH_DAY_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.STOP_LENGTH_DAY_LABEL.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.STOP_LENGTH_DAY_LABEL.ForeColor = System.Drawing.Color.Red;
			this.STOP_LENGTH_DAY_LABEL.Location = new System.Drawing.Point(162, 102);
			this.STOP_LENGTH_DAY_LABEL.Name = "STOP_LENGTH_DAY_LABEL";
			this.STOP_LENGTH_DAY_LABEL.Size = new System.Drawing.Size(22, 17);
			this.STOP_LENGTH_DAY_LABEL.TabIndex = 31;
			this.STOP_LENGTH_DAY_LABEL.Text = "일";
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
			// STOP_INFORMATION_PANEL
			// 
			this.STOP_INFORMATION_PANEL.BackColor = System.Drawing.Color.Transparent;
			this.STOP_INFORMATION_PANEL.Controls.Add(this.UNLIMITED_LENGTH_CHECKBOX);
			this.STOP_INFORMATION_PANEL.Controls.Add(this.REASON_TEXTBOX);
			this.STOP_INFORMATION_PANEL.Controls.Add(this.REASON_TITLE);
			this.STOP_INFORMATION_PANEL.Controls.Add(this.REASON_DESC);
			this.STOP_INFORMATION_PANEL.Controls.Add(this.STOP_LENGTH_DAY_LABEL);
			this.STOP_INFORMATION_PANEL.Controls.Add(this.STOP_LENGTH);
			this.STOP_INFORMATION_PANEL.Controls.Add(this.STOP_LENGTH_TITLE);
			this.STOP_INFORMATION_PANEL.Controls.Add(this.COUNT_TITLE);
			this.STOP_INFORMATION_PANEL.Controls.Add(this.WARNING_COUNT_AFTERDESC);
			this.STOP_INFORMATION_PANEL.Location = new System.Drawing.Point(34, 237);
			this.STOP_INFORMATION_PANEL.Name = "STOP_INFORMATION_PANEL";
			this.STOP_INFORMATION_PANEL.Size = new System.Drawing.Size(531, 251);
			this.STOP_INFORMATION_PANEL.TabIndex = 33;
			this.STOP_INFORMATION_PANEL.Visible = false;
			// 
			// UNLIMITED_LENGTH_CHECKBOX
			// 
			this.UNLIMITED_LENGTH_CHECKBOX.AutoSize = true;
			this.UNLIMITED_LENGTH_CHECKBOX.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.UNLIMITED_LENGTH_CHECKBOX.ForeColor = System.Drawing.Color.Red;
			this.UNLIMITED_LENGTH_CHECKBOX.Location = new System.Drawing.Point(73, 138);
			this.UNLIMITED_LENGTH_CHECKBOX.Name = "UNLIMITED_LENGTH_CHECKBOX";
			this.UNLIMITED_LENGTH_CHECKBOX.Size = new System.Drawing.Size(62, 19);
			this.UNLIMITED_LENGTH_CHECKBOX.TabIndex = 32;
			this.UNLIMITED_LENGTH_CHECKBOX.Text = "무기한";
			this.UNLIMITED_LENGTH_CHECKBOX.UseVisualStyleBackColor = true;
			this.UNLIMITED_LENGTH_CHECKBOX.CheckedChanged += new System.EventHandler(this.UNLIMITED_LENGTH_CHECKBOX_CheckedChanged);
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
			// BACKGROUND_SPLASH
			// 
			this.BACKGROUND_SPLASH.BackColor = System.Drawing.Color.Transparent;
			this.BACKGROUND_SPLASH.Image = global::CafeMaster_UI.Properties.Resources.Background04;
			this.BACKGROUND_SPLASH.Location = new System.Drawing.Point(1, 1);
			this.BACKGROUND_SPLASH.Name = "BACKGROUND_SPLASH";
			this.BACKGROUND_SPLASH.Size = new System.Drawing.Size(598, 548);
			this.BACKGROUND_SPLASH.TabIndex = 35;
			this.BACKGROUND_SPLASH.TabStop = false;
			// 
			// WARN_TEXT
			// 
			this.WARN_TEXT.AutoSize = true;
			this.WARN_TEXT.BackColor = System.Drawing.Color.Transparent;
			this.WARN_TEXT.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.WARN_TEXT.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WARN_TEXT.Location = new System.Drawing.Point(85, 63);
			this.WARN_TEXT.Name = "WARN_TEXT";
			this.WARN_TEXT.Size = new System.Drawing.Size(469, 15);
			this.WARN_TEXT.TabIndex = 34;
			this.WARN_TEXT.Text = "활동 정지 처리하기 전 모든 작성사항을 다시 확인하시고 규정을 꼭! 다시 확인하세요.";
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
			this.CANCEL_BUTTON.Location = new System.Drawing.Point(238, 502);
			this.CANCEL_BUTTON.Name = "CANCEL_BUTTON";
			this.CANCEL_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.CANCEL_BUTTON.Size = new System.Drawing.Size(102, 27);
			this.CANCEL_BUTTON.TabIndex = 25;
			this.CANCEL_BUTTON.Text = "취소";
			this.CANCEL_BUTTON.UseVisualStyleBackColor = false;
			this.CANCEL_BUTTON.Click += new System.EventHandler(this.CANCEL_BUTTON_Click);
			// 
			// ACTIVITY_STOP_RUN_BUTTON
			// 
			this.ACTIVITY_STOP_RUN_BUTTON.AnimationLerpP = 0.8F;
			this.ACTIVITY_STOP_RUN_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.ACTIVITY_STOP_RUN_BUTTON.ButtonText = "활동 정지";
			this.ACTIVITY_STOP_RUN_BUTTON.ButtonTextColor = System.Drawing.Color.White;
			this.ACTIVITY_STOP_RUN_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ACTIVITY_STOP_RUN_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.Red;
			this.ACTIVITY_STOP_RUN_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ACTIVITY_STOP_RUN_BUTTON.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.ACTIVITY_STOP_RUN_BUTTON.Location = new System.Drawing.Point(34, 494);
			this.ACTIVITY_STOP_RUN_BUTTON.Name = "ACTIVITY_STOP_RUN_BUTTON";
			this.ACTIVITY_STOP_RUN_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.Crimson;
			this.ACTIVITY_STOP_RUN_BUTTON.Size = new System.Drawing.Size(195, 35);
			this.ACTIVITY_STOP_RUN_BUTTON.TabIndex = 7;
			this.ACTIVITY_STOP_RUN_BUTTON.Text = "활동 정지";
			this.ACTIVITY_STOP_RUN_BUTTON.UseVisualStyleBackColor = false;
			this.ACTIVITY_STOP_RUN_BUTTON.Click += new System.EventHandler(this.ACTIVITY_STOP_RUN_BUTTON_Click);
			// 
			// MemberActivityStopForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(600, 550);
			this.Controls.Add(this.USER_INFORMATION_PANEL);
			this.Controls.Add(this.WARN_TEXT);
			this.Controls.Add(this.USER_SEARCH_TITLE);
			this.Controls.Add(this.WARN_ICON);
			this.Controls.Add(this.STOP_INFORMATION_PANEL);
			this.Controls.Add(this.USER_SEARCH_DESC);
			this.Controls.Add(this.USER_SEARCH_BUTTON);
			this.Controls.Add(this.USER_INFORMATION_PANEL_TITLE);
			this.Controls.Add(this.CANCEL_BUTTON);
			this.Controls.Add(this.ACTIVITY_STOP_RUN_BUTTON);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.Controls.Add(this.USER_SEARCH_TEXTBOX);
			this.Controls.Add(this.BACKGROUND_SPLASH);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MemberActivityStopForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "활동 정지";
			this.Load += new System.EventHandler(this.UserWarnOptionForm_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserWarnOptionForm_Paint);
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.STOP_LENGTH)).EndInit();
			this.USER_INFORMATION_PANEL.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PERSONACON_IMAGE_ICON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PROFILE_IMAGE_ICON)).EndInit();
			this.STOP_INFORMATION_PANEL.ResumeLayout(false);
			this.STOP_INFORMATION_PANEL.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.BACKGROUND_SPLASH)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WARN_ICON)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private System.Windows.Forms.Label APP_TITLE;
		private System.Windows.Forms.PictureBox CLOSE_BUTTON;
		private System.Windows.Forms.Label REASON_TITLE;
		private System.Windows.Forms.TextBox REASON_TEXTBOX;
		private FlatButton ACTIVITY_STOP_RUN_BUTTON;
		private System.Windows.Forms.Label REASON_DESC;
		private System.Windows.Forms.NumericUpDown STOP_LENGTH;
		private System.Windows.Forms.Label COUNT_TITLE;
		private System.Windows.Forms.Label WARNING_COUNT_AFTERDESC;
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
		private System.Windows.Forms.Label STOP_LENGTH_TITLE;
		private System.Windows.Forms.Label STOP_LENGTH_DAY_LABEL;
		private System.Windows.Forms.Label USER_SEARCH_DESC;
		private System.Windows.Forms.Panel STOP_INFORMATION_PANEL;
		private System.Windows.Forms.CheckBox UNLIMITED_LENGTH_CHECKBOX;
		private System.Windows.Forms.Label USER_SEARCH_TITLE;
		private System.Windows.Forms.PictureBox BACKGROUND_SPLASH;
		private System.Windows.Forms.Label WARN_TEXT;
		private System.Windows.Forms.PictureBox WARN_ICON;
		private FlatButton MEMBER_INFO_OPEN_BUTTON;
	}
}