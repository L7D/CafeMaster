namespace CafeMaster_UI
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
			this.LOADING_GIFIMAGE = new System.Windows.Forms.WebBrowser();
			this.APP_TITLE = new CafeMaster_UI.Interface.CustomLabel();
			this.CURRENT_PROGRESS_LABEL = new CafeMaster_UI.Interface.CustomLabel();
			this.STEP_CHATBOX_TITLE = new System.Windows.Forms.Label();
			this.APP_NOTIFY_ICON = new System.Windows.Forms.NotifyIcon(this.components);
			this.PROGRAM_LOCK_TITLE_LABEL = new System.Windows.Forms.Label();
			this.PROGRAM_LOCK_DESC_LABEL = new System.Windows.Forms.Label();
			this.TOOL_TIP = new System.Windows.Forms.ToolTip(this.components);
			this.CHILD_PANEL_UTIL_DELETE = new CafeMaster_UI.Interface.FlatButton();
			this.CHILD_PANEL_UTIL_ALL_SELECT = new CafeMaster_UI.Interface.FlatButton();
			this.UTIL_BUTTON4 = new CafeMaster_UI.Interface.FlatButton();
			this.UTIL_BUTTON3 = new CafeMaster_UI.Interface.FlatButton();
			this.UTIL_BUTTON2 = new CafeMaster_UI.Interface.FlatButton();
			this.NOTIFYBOX_EMPTY_TITLE = new System.Windows.Forms.Label();
			this.NOTIFYBOX_EMPTY_DESC = new System.Windows.Forms.Label();
			this.NOTIFY_PANEL_TITLE = new System.Windows.Forms.Label();
			this.UTIL_BUTTON1 = new CafeMaster_UI.Interface.FlatButton();
			this.STEP_CHATBOX = new System.Windows.Forms.WebBrowser();
			this.NOTIFY_PANEL = new CafeMaster_UI.Interface.DoubleBufferPanel();
			this.FORCE_SYNC_DELAY_TIMER = new System.Windows.Forms.Timer(this.components);
			this.NOTIFY_PANEL_ICON = new System.Windows.Forms.PictureBox();
			this.STEP_CHATBOX_ICON = new System.Windows.Forms.PictureBox();
			this.UPDATE_AVAILABLE = new System.Windows.Forms.PictureBox();
			this.NOTIFYBOX_EMPTY_ICON = new System.Windows.Forms.PictureBox();
			this.NAVER_ICON_IMAGE = new System.Windows.Forms.PictureBox();
			this.INFO_BUTTON = new System.Windows.Forms.PictureBox();
			this.OPTION_BUTTON = new System.Windows.Forms.PictureBox();
			this.FORCE_REFRESH_BUTTON = new System.Windows.Forms.PictureBox();
			this.PROGRAM_LOCK_BUTTON = new System.Windows.Forms.PictureBox();
			this.BELL_STATUS_BUTTON = new System.Windows.Forms.PictureBox();
			this.HIDE_BUTTON = new System.Windows.Forms.PictureBox();
			this.CLOSE_BUTTON = new System.Windows.Forms.PictureBox();
			this.BACKGROUND_SPLASH = new System.Windows.Forms.PictureBox();
			this.PROGRAM_LOCK_ICON = new System.Windows.Forms.PictureBox();
			this.APP_TITLE_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NOTIFY_PANEL_ICON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.STEP_CHATBOX_ICON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UPDATE_AVAILABLE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NOTIFYBOX_EMPTY_ICON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NAVER_ICON_IMAGE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.INFO_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OPTION_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FORCE_REFRESH_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PROGRAM_LOCK_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BELL_STATUS_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.HIDE_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BACKGROUND_SPLASH)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PROGRAM_LOCK_ICON)).BeginInit();
			this.SuspendLayout();
			// 
			// APP_TITLE_BAR
			// 
			this.APP_TITLE_BAR.BackColor = System.Drawing.Color.Transparent;
			this.APP_TITLE_BAR.Controls.Add(this.INFO_BUTTON);
			this.APP_TITLE_BAR.Controls.Add(this.LOADING_GIFIMAGE);
			this.APP_TITLE_BAR.Controls.Add(this.OPTION_BUTTON);
			this.APP_TITLE_BAR.Controls.Add(this.FORCE_REFRESH_BUTTON);
			this.APP_TITLE_BAR.Controls.Add(this.PROGRAM_LOCK_BUTTON);
			this.APP_TITLE_BAR.Controls.Add(this.BELL_STATUS_BUTTON);
			this.APP_TITLE_BAR.Controls.Add(this.HIDE_BUTTON);
			this.APP_TITLE_BAR.Controls.Add(this.APP_TITLE);
			this.APP_TITLE_BAR.Controls.Add(this.CLOSE_BUTTON);
			this.APP_TITLE_BAR.Controls.Add(this.CURRENT_PROGRESS_LABEL);
			this.APP_TITLE_BAR.Cursor = System.Windows.Forms.Cursors.Default;
			this.APP_TITLE_BAR.Location = new System.Drawing.Point(0, 0);
			this.APP_TITLE_BAR.Name = "APP_TITLE_BAR";
			this.APP_TITLE_BAR.Size = new System.Drawing.Size(1200, 45);
			this.APP_TITLE_BAR.TabIndex = 17;
			this.APP_TITLE_BAR.Paint += new System.Windows.Forms.PaintEventHandler(this.APP_TITLE_BAR_Paint);
			this.APP_TITLE_BAR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseDown);
			this.APP_TITLE_BAR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseMove);
			// 
			// LOADING_GIFIMAGE
			// 
			this.LOADING_GIFIMAGE.AllowNavigation = false;
			this.LOADING_GIFIMAGE.AllowWebBrowserDrop = false;
			this.LOADING_GIFIMAGE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LOADING_GIFIMAGE.IsWebBrowserContextMenuEnabled = false;
			this.LOADING_GIFIMAGE.Location = new System.Drawing.Point(905, 2);
			this.LOADING_GIFIMAGE.MinimumSize = new System.Drawing.Size(20, 20);
			this.LOADING_GIFIMAGE.Name = "LOADING_GIFIMAGE";
			this.LOADING_GIFIMAGE.ScriptErrorsSuppressed = true;
			this.LOADING_GIFIMAGE.ScrollBarsEnabled = false;
			this.LOADING_GIFIMAGE.Size = new System.Drawing.Size(45, 40);
			this.LOADING_GIFIMAGE.TabIndex = 15;
			this.LOADING_GIFIMAGE.Visible = false;
			this.LOADING_GIFIMAGE.WebBrowserShortcutsEnabled = false;
			// 
			// APP_TITLE
			// 
			this.APP_TITLE.AutoSize = true;
			this.APP_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.APP_TITLE.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.APP_TITLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.APP_TITLE.Location = new System.Drawing.Point(10, 16);
			this.APP_TITLE.Name = "APP_TITLE";
			this.APP_TITLE.Size = new System.Drawing.Size(143, 14);
			this.APP_TITLE.TabIndex = 3;
			this.APP_TITLE.Text = "우윳빛깔 카페스탭 - © L7D";
			this.APP_TITLE.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			// 
			// CURRENT_PROGRESS_LABEL
			// 
			this.CURRENT_PROGRESS_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.CURRENT_PROGRESS_LABEL.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.CURRENT_PROGRESS_LABEL.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CURRENT_PROGRESS_LABEL.Location = new System.Drawing.Point(469, 16);
			this.CURRENT_PROGRESS_LABEL.Name = "CURRENT_PROGRESS_LABEL";
			this.CURRENT_PROGRESS_LABEL.Size = new System.Drawing.Size(428, 16);
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
			this.APP_NOTIFY_ICON.Icon = ((System.Drawing.Icon)(resources.GetObject("APP_NOTIFY_ICON.Icon")));
			this.APP_NOTIFY_ICON.Text = "우윳빛깔 카페스탭";
			this.APP_NOTIFY_ICON.Visible = true;
			// 
			// PROGRAM_LOCK_TITLE_LABEL
			// 
			this.PROGRAM_LOCK_TITLE_LABEL.AutoSize = true;
			this.PROGRAM_LOCK_TITLE_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.PROGRAM_LOCK_TITLE_LABEL.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.PROGRAM_LOCK_TITLE_LABEL.ForeColor = System.Drawing.SystemColors.ControlText;
			this.PROGRAM_LOCK_TITLE_LABEL.Location = new System.Drawing.Point(539, 375);
			this.PROGRAM_LOCK_TITLE_LABEL.Name = "PROGRAM_LOCK_TITLE_LABEL";
			this.PROGRAM_LOCK_TITLE_LABEL.Size = new System.Drawing.Size(123, 21);
			this.PROGRAM_LOCK_TITLE_LABEL.TabIndex = 28;
			this.PROGRAM_LOCK_TITLE_LABEL.Text = "프로그램 잠김";
			this.PROGRAM_LOCK_TITLE_LABEL.Visible = false;
			// 
			// PROGRAM_LOCK_DESC_LABEL
			// 
			this.PROGRAM_LOCK_DESC_LABEL.AutoSize = true;
			this.PROGRAM_LOCK_DESC_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.PROGRAM_LOCK_DESC_LABEL.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.PROGRAM_LOCK_DESC_LABEL.ForeColor = System.Drawing.SystemColors.ControlText;
			this.PROGRAM_LOCK_DESC_LABEL.Location = new System.Drawing.Point(439, 410);
			this.PROGRAM_LOCK_DESC_LABEL.Name = "PROGRAM_LOCK_DESC_LABEL";
			this.PROGRAM_LOCK_DESC_LABEL.Size = new System.Drawing.Size(323, 15);
			this.PROGRAM_LOCK_DESC_LABEL.TabIndex = 29;
			this.PROGRAM_LOCK_DESC_LABEL.Text = "프로그램 잠금을 해제해야 프로그램을 사용할 수 있습니다.";
			this.PROGRAM_LOCK_DESC_LABEL.Visible = false;
			// 
			// CHILD_PANEL_UTIL_DELETE
			// 
			this.CHILD_PANEL_UTIL_DELETE.AnimationLerpP = 0.8F;
			this.CHILD_PANEL_UTIL_DELETE.BackColor = System.Drawing.Color.Transparent;
			this.CHILD_PANEL_UTIL_DELETE.ButtonText = "삭제";
			this.CHILD_PANEL_UTIL_DELETE.ButtonTextColor = System.Drawing.Color.Black;
			this.CHILD_PANEL_UTIL_DELETE.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CHILD_PANEL_UTIL_DELETE.EnterStateBackgroundColor = System.Drawing.Color.Tomato;
			this.CHILD_PANEL_UTIL_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CHILD_PANEL_UTIL_DELETE.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.CHILD_PANEL_UTIL_DELETE.Location = new System.Drawing.Point(929, 51);
			this.CHILD_PANEL_UTIL_DELETE.Name = "CHILD_PANEL_UTIL_DELETE";
			this.CHILD_PANEL_UTIL_DELETE.NormalStateBackgroundColor = System.Drawing.Color.Salmon;
			this.CHILD_PANEL_UTIL_DELETE.Size = new System.Drawing.Size(100, 28);
			this.CHILD_PANEL_UTIL_DELETE.TabIndex = 40;
			this.CHILD_PANEL_UTIL_DELETE.Text = "삭제";
			this.TOOL_TIP.SetToolTip(this.CHILD_PANEL_UTIL_DELETE, "선택한 게시물 알림을 모두 삭제합니다.");
			this.CHILD_PANEL_UTIL_DELETE.UseVisualStyleBackColor = false;
			this.CHILD_PANEL_UTIL_DELETE.Click += new System.EventHandler(this.CHILD_PANEL_UTIL_DELETE_Click);
			// 
			// CHILD_PANEL_UTIL_ALL_SELECT
			// 
			this.CHILD_PANEL_UTIL_ALL_SELECT.AnimationLerpP = 0.8F;
			this.CHILD_PANEL_UTIL_ALL_SELECT.BackColor = System.Drawing.Color.Transparent;
			this.CHILD_PANEL_UTIL_ALL_SELECT.ButtonText = "전체 선택";
			this.CHILD_PANEL_UTIL_ALL_SELECT.ButtonTextColor = System.Drawing.Color.Black;
			this.CHILD_PANEL_UTIL_ALL_SELECT.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CHILD_PANEL_UTIL_ALL_SELECT.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.CHILD_PANEL_UTIL_ALL_SELECT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CHILD_PANEL_UTIL_ALL_SELECT.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold);
			this.CHILD_PANEL_UTIL_ALL_SELECT.Location = new System.Drawing.Point(823, 51);
			this.CHILD_PANEL_UTIL_ALL_SELECT.Name = "CHILD_PANEL_UTIL_ALL_SELECT";
			this.CHILD_PANEL_UTIL_ALL_SELECT.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.CHILD_PANEL_UTIL_ALL_SELECT.Size = new System.Drawing.Size(100, 28);
			this.CHILD_PANEL_UTIL_ALL_SELECT.TabIndex = 39;
			this.CHILD_PANEL_UTIL_ALL_SELECT.Text = "전체 선택";
			this.TOOL_TIP.SetToolTip(this.CHILD_PANEL_UTIL_ALL_SELECT, "게시물 전체를 선택하거나 해제합니다.");
			this.CHILD_PANEL_UTIL_ALL_SELECT.UseVisualStyleBackColor = false;
			this.CHILD_PANEL_UTIL_ALL_SELECT.Click += new System.EventHandler(this.CHILD_PANEL_UTIL_ALL_SELECT_Click);
			// 
			// UTIL_BUTTON4
			// 
			this.UTIL_BUTTON4.AnimationLerpP = 0.8F;
			this.UTIL_BUTTON4.BackColor = System.Drawing.Color.Transparent;
			this.UTIL_BUTTON4.ButtonText = "카페 가입 신청 관리";
			this.UTIL_BUTTON4.ButtonTextColor = System.Drawing.Color.Black;
			this.UTIL_BUTTON4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.UTIL_BUTTON4.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.UTIL_BUTTON4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UTIL_BUTTON4.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.UTIL_BUTTON4.Location = new System.Drawing.Point(1035, 275);
			this.UTIL_BUTTON4.Name = "UTIL_BUTTON4";
			this.UTIL_BUTTON4.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.UTIL_BUTTON4.Size = new System.Drawing.Size(159, 40);
			this.UTIL_BUTTON4.TabIndex = 38;
			this.UTIL_BUTTON4.Text = "카페 가입 신청 관리";
			this.TOOL_TIP.SetToolTip(this.UTIL_BUTTON4, "카페 가입 신청 관리 페이지를 엽니다.");
			this.UTIL_BUTTON4.UseVisualStyleBackColor = false;
			this.UTIL_BUTTON4.Click += new System.EventHandler(this.UTIL_BUTTON4_Click);
			// 
			// UTIL_BUTTON3
			// 
			this.UTIL_BUTTON3.AnimationLerpP = 0.8F;
			this.UTIL_BUTTON3.BackColor = System.Drawing.Color.Transparent;
			this.UTIL_BUTTON3.ButtonText = "카페 관리";
			this.UTIL_BUTTON3.ButtonTextColor = System.Drawing.Color.Black;
			this.UTIL_BUTTON3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.UTIL_BUTTON3.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.UTIL_BUTTON3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UTIL_BUTTON3.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.UTIL_BUTTON3.Location = new System.Drawing.Point(1035, 229);
			this.UTIL_BUTTON3.Name = "UTIL_BUTTON3";
			this.UTIL_BUTTON3.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.UTIL_BUTTON3.Size = new System.Drawing.Size(159, 40);
			this.UTIL_BUTTON3.TabIndex = 30;
			this.UTIL_BUTTON3.Text = "카페 관리";
			this.TOOL_TIP.SetToolTip(this.UTIL_BUTTON3, "카페 관리 페이지를 엽니다.");
			this.UTIL_BUTTON3.UseVisualStyleBackColor = false;
			this.UTIL_BUTTON3.Click += new System.EventHandler(this.UTIL_BUTTON3_Click);
			// 
			// UTIL_BUTTON2
			// 
			this.UTIL_BUTTON2.AnimationLerpP = 0.8F;
			this.UTIL_BUTTON2.BackColor = System.Drawing.Color.Transparent;
			this.UTIL_BUTTON2.ButtonText = "전체 글 보기";
			this.UTIL_BUTTON2.ButtonTextColor = System.Drawing.Color.Black;
			this.UTIL_BUTTON2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.UTIL_BUTTON2.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.UTIL_BUTTON2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UTIL_BUTTON2.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.UTIL_BUTTON2.Location = new System.Drawing.Point(1035, 183);
			this.UTIL_BUTTON2.Name = "UTIL_BUTTON2";
			this.UTIL_BUTTON2.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.UTIL_BUTTON2.Size = new System.Drawing.Size(159, 40);
			this.UTIL_BUTTON2.TabIndex = 26;
			this.UTIL_BUTTON2.Text = "전체 글 보기";
			this.TOOL_TIP.SetToolTip(this.UTIL_BUTTON2, "카페 전체 글 보기 게시판을 엽니다.");
			this.UTIL_BUTTON2.UseVisualStyleBackColor = false;
			this.UTIL_BUTTON2.Click += new System.EventHandler(this.UTIL_BUTTON2_Click);
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
			this.NOTIFYBOX_EMPTY_DESC.Location = new System.Drawing.Point(630, 405);
			this.NOTIFYBOX_EMPTY_DESC.Name = "NOTIFYBOX_EMPTY_DESC";
			this.NOTIFYBOX_EMPTY_DESC.Size = new System.Drawing.Size(240, 15);
			this.NOTIFYBOX_EMPTY_DESC.TabIndex = 38;
			this.NOTIFYBOX_EMPTY_DESC.Text = "와우~ 새 게시물이 없어요! 당신은 능력자!";
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
			// UTIL_BUTTON1
			// 
			this.UTIL_BUTTON1.AnimationLerpP = 0.8F;
			this.UTIL_BUTTON1.BackColor = System.Drawing.Color.Transparent;
			this.UTIL_BUTTON1.ButtonText = "카페 전체 규칙 보기";
			this.UTIL_BUTTON1.ButtonTextColor = System.Drawing.Color.Black;
			this.UTIL_BUTTON1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.UTIL_BUTTON1.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.UTIL_BUTTON1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UTIL_BUTTON1.Font = new System.Drawing.Font("나눔고딕", 8.999999F);
			this.UTIL_BUTTON1.Location = new System.Drawing.Point(1035, 137);
			this.UTIL_BUTTON1.Name = "UTIL_BUTTON1";
			this.UTIL_BUTTON1.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.UTIL_BUTTON1.Size = new System.Drawing.Size(159, 40);
			this.UTIL_BUTTON1.TabIndex = 35;
			this.UTIL_BUTTON1.Text = "카페 전체 규칙 보기";
			this.UTIL_BUTTON1.UseVisualStyleBackColor = false;
			this.UTIL_BUTTON1.Click += new System.EventHandler(this.UTIL_BUTTON1_Click);
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
			// FORCE_SYNC_DELAY_TIMER
			// 
			this.FORCE_SYNC_DELAY_TIMER.Interval = 10000;
			this.FORCE_SYNC_DELAY_TIMER.Tick += new System.EventHandler(this.FORCE_SYNC_DELAY_TIMER_Tick);
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
			this.TOOL_TIP.SetToolTip(this.NOTIFY_PANEL_ICON, "지금 동기화");
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
			this.TOOL_TIP.SetToolTip(this.STEP_CHATBOX_ICON, "지금 동기화");
			// 
			// UPDATE_AVAILABLE
			// 
			this.UPDATE_AVAILABLE.BackColor = System.Drawing.Color.Transparent;
			this.UPDATE_AVAILABLE.Cursor = System.Windows.Forms.Cursors.Hand;
			this.UPDATE_AVAILABLE.Image = global::CafeMaster_UI.Properties.Resources.UPDATE_HAVE;
			this.UPDATE_AVAILABLE.Location = new System.Drawing.Point(1169, 652);
			this.UPDATE_AVAILABLE.Name = "UPDATE_AVAILABLE";
			this.UPDATE_AVAILABLE.Size = new System.Drawing.Size(25, 25);
			this.UPDATE_AVAILABLE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.UPDATE_AVAILABLE.TabIndex = 21;
			this.UPDATE_AVAILABLE.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.UPDATE_AVAILABLE, "새로운 프로그램 버전이 있습니다.");
			this.UPDATE_AVAILABLE.Visible = false;
			this.UPDATE_AVAILABLE.Click += new System.EventHandler(this.UPDATE_AVAILABLE_Click);
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
			this.NAVER_ICON_IMAGE.BackgroundImage = global::CafeMaster_UI.Properties.Resources.PROFILE_UNKNOWN;
			this.NAVER_ICON_IMAGE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.NAVER_ICON_IMAGE.Image = global::CafeMaster_UI.Properties.Resources.PROFILE_IMAGE_CIRCLE;
			this.NAVER_ICON_IMAGE.Location = new System.Drawing.Point(1114, 51);
			this.NAVER_ICON_IMAGE.Name = "NAVER_ICON_IMAGE";
			this.NAVER_ICON_IMAGE.Size = new System.Drawing.Size(80, 80);
			this.NAVER_ICON_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.NAVER_ICON_IMAGE.TabIndex = 19;
			this.NAVER_ICON_IMAGE.TabStop = false;
			// 
			// INFO_BUTTON
			// 
			this.INFO_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.INFO_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.INFO_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.HELP;
			this.INFO_BUTTON.Location = new System.Drawing.Point(1095, 10);
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
			this.OPTION_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.OPTION_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.OPTION_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.OPTION;
			this.OPTION_BUTTON.Location = new System.Drawing.Point(955, 10);
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
			this.FORCE_REFRESH_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.FORCE_REFRESH_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.FORCE_REFRESH_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.REFRESH;
			this.FORCE_REFRESH_BUTTON.Location = new System.Drawing.Point(990, 10);
			this.FORCE_REFRESH_BUTTON.Name = "FORCE_REFRESH_BUTTON";
			this.FORCE_REFRESH_BUTTON.Size = new System.Drawing.Size(25, 25);
			this.FORCE_REFRESH_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.FORCE_REFRESH_BUTTON.TabIndex = 20;
			this.FORCE_REFRESH_BUTTON.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.FORCE_REFRESH_BUTTON, "지금 동기화");
			this.FORCE_REFRESH_BUTTON.Click += new System.EventHandler(this.FORCE_REFRESH_BUTTON_Click);
			// 
			// PROGRAM_LOCK_BUTTON
			// 
			this.PROGRAM_LOCK_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.PROGRAM_LOCK_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.PROGRAM_LOCK_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.unlocked;
			this.PROGRAM_LOCK_BUTTON.Location = new System.Drawing.Point(1025, 10);
			this.PROGRAM_LOCK_BUTTON.Name = "PROGRAM_LOCK_BUTTON";
			this.PROGRAM_LOCK_BUTTON.Size = new System.Drawing.Size(25, 25);
			this.PROGRAM_LOCK_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PROGRAM_LOCK_BUTTON.TabIndex = 19;
			this.PROGRAM_LOCK_BUTTON.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.PROGRAM_LOCK_BUTTON, "프로그램 잠금 / 잠금해제");
			// 
			// BELL_STATUS_BUTTON
			// 
			this.BELL_STATUS_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.BELL_STATUS_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BELL_STATUS_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.BELL_NORMAL;
			this.BELL_STATUS_BUTTON.Location = new System.Drawing.Point(1060, 10);
			this.BELL_STATUS_BUTTON.Name = "BELL_STATUS_BUTTON";
			this.BELL_STATUS_BUTTON.Size = new System.Drawing.Size(25, 25);
			this.BELL_STATUS_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.BELL_STATUS_BUTTON.TabIndex = 18;
			this.BELL_STATUS_BUTTON.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.BELL_STATUS_BUTTON, "알림 설정 / 해제");
			this.BELL_STATUS_BUTTON.Click += new System.EventHandler(this.BELL_STATUS_BUTTON_Click);
			// 
			// HIDE_BUTTON
			// 
			this.HIDE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.HIDE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.HIDE_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.HIDE;
			this.HIDE_BUTTON.Location = new System.Drawing.Point(1130, 10);
			this.HIDE_BUTTON.Name = "HIDE_BUTTON";
			this.HIDE_BUTTON.Size = new System.Drawing.Size(25, 25);
			this.HIDE_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.HIDE_BUTTON.TabIndex = 17;
			this.HIDE_BUTTON.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.HIDE_BUTTON, "최소화");
			this.HIDE_BUTTON.Click += new System.EventHandler(this.HIDE_BUTTON_Click);
			// 
			// CLOSE_BUTTON
			// 
			this.CLOSE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.CLOSE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CLOSE_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.CLOSE;
			this.CLOSE_BUTTON.Location = new System.Drawing.Point(1165, 10);
			this.CLOSE_BUTTON.Name = "CLOSE_BUTTON";
			this.CLOSE_BUTTON.Size = new System.Drawing.Size(25, 25);
			this.CLOSE_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.CLOSE_BUTTON.TabIndex = 4;
			this.CLOSE_BUTTON.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.CLOSE_BUTTON, "프로그램 종료");
			this.CLOSE_BUTTON.Click += new System.EventHandler(this.CLOSE_BUTTON_Click);
			// 
			// BACKGROUND_SPLASH
			// 
			this.BACKGROUND_SPLASH.BackColor = System.Drawing.Color.Transparent;
			this.BACKGROUND_SPLASH.Location = new System.Drawing.Point(1034, 259);
			this.BACKGROUND_SPLASH.Name = "BACKGROUND_SPLASH";
			this.BACKGROUND_SPLASH.Size = new System.Drawing.Size(165, 425);
			this.BACKGROUND_SPLASH.TabIndex = 37;
			this.BACKGROUND_SPLASH.TabStop = false;
			// 
			// PROGRAM_LOCK_ICON
			// 
			this.PROGRAM_LOCK_ICON.BackColor = System.Drawing.Color.Transparent;
			this.PROGRAM_LOCK_ICON.Image = global::CafeMaster_UI.Properties.Resources.PROGRAM_LOCKED;
			this.PROGRAM_LOCK_ICON.Location = new System.Drawing.Point(550, 250);
			this.PROGRAM_LOCK_ICON.Name = "PROGRAM_LOCK_ICON";
			this.PROGRAM_LOCK_ICON.Size = new System.Drawing.Size(100, 100);
			this.PROGRAM_LOCK_ICON.TabIndex = 36;
			this.PROGRAM_LOCK_ICON.TabStop = false;
			this.PROGRAM_LOCK_ICON.Visible = false;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1200, 685);
			this.Controls.Add(this.NOTIFY_PANEL_ICON);
			this.Controls.Add(this.NOTIFY_PANEL_TITLE);
			this.Controls.Add(this.STEP_CHATBOX_ICON);
			this.Controls.Add(this.UPDATE_AVAILABLE);
			this.Controls.Add(this.NOTIFYBOX_EMPTY_ICON);
			this.Controls.Add(this.NOTIFYBOX_EMPTY_TITLE);
			this.Controls.Add(this.NOTIFYBOX_EMPTY_DESC);
			this.Controls.Add(this.CHILD_PANEL_UTIL_DELETE);
			this.Controls.Add(this.CHILD_PANEL_UTIL_ALL_SELECT);
			this.Controls.Add(this.UTIL_BUTTON4);
			this.Controls.Add(this.NAVER_ICON_IMAGE);
			this.Controls.Add(this.UTIL_BUTTON1);
			this.Controls.Add(this.UTIL_BUTTON3);
			this.Controls.Add(this.UTIL_BUTTON2);
			this.Controls.Add(this.STEP_CHATBOX_TITLE);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.Controls.Add(this.BACKGROUND_SPLASH);
			this.Controls.Add(this.PROGRAM_LOCK_ICON);
			this.Controls.Add(this.PROGRAM_LOCK_DESC_LABEL);
			this.Controls.Add(this.PROGRAM_LOCK_TITLE_LABEL);
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
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NOTIFY_PANEL_ICON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.STEP_CHATBOX_ICON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UPDATE_AVAILABLE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NOTIFYBOX_EMPTY_ICON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NAVER_ICON_IMAGE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.INFO_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OPTION_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FORCE_REFRESH_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PROGRAM_LOCK_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BELL_STATUS_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.HIDE_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BACKGROUND_SPLASH)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PROGRAM_LOCK_ICON)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.WebBrowser LOADING_GIFIMAGE;
		private CafeMaster_UI.Interface.CustomLabel CURRENT_PROGRESS_LABEL;
		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private CafeMaster_UI.Interface.CustomLabel APP_TITLE;
		private System.Windows.Forms.PictureBox CLOSE_BUTTON;
		private Interface.DoubleBufferPanel NOTIFY_PANEL;
		private System.Windows.Forms.WebBrowser STEP_CHATBOX;
		private System.Windows.Forms.Label STEP_CHATBOX_TITLE;
		private System.Windows.Forms.PictureBox NAVER_ICON_IMAGE;
		private Interface.FlatButton UTIL_BUTTON2;
		private System.Windows.Forms.PictureBox HIDE_BUTTON;
		private System.Windows.Forms.NotifyIcon APP_NOTIFY_ICON;
		private System.Windows.Forms.PictureBox BELL_STATUS_BUTTON;
		private System.Windows.Forms.PictureBox PROGRAM_LOCK_BUTTON;
		private System.Windows.Forms.Label PROGRAM_LOCK_TITLE_LABEL;
		private System.Windows.Forms.Label PROGRAM_LOCK_DESC_LABEL;
		private Interface.FlatButton UTIL_BUTTON3;
		private Interface.FlatButton UTIL_BUTTON1;
		private System.Windows.Forms.PictureBox FORCE_REFRESH_BUTTON;
		private System.Windows.Forms.PictureBox PROGRAM_LOCK_ICON;
        private System.Windows.Forms.ToolTip TOOL_TIP;
		private System.Windows.Forms.PictureBox BACKGROUND_SPLASH;
		private System.Windows.Forms.PictureBox UPDATE_AVAILABLE;
		private Interface.FlatButton UTIL_BUTTON4;
		private System.Windows.Forms.PictureBox OPTION_BUTTON;
		private Interface.FlatButton CHILD_PANEL_UTIL_ALL_SELECT;
		private Interface.FlatButton CHILD_PANEL_UTIL_DELETE;
		private System.Windows.Forms.PictureBox NOTIFYBOX_EMPTY_ICON;
		private System.Windows.Forms.Label NOTIFYBOX_EMPTY_DESC;
		private System.Windows.Forms.Label NOTIFYBOX_EMPTY_TITLE;
		private System.Windows.Forms.PictureBox STEP_CHATBOX_ICON;
		private System.Windows.Forms.PictureBox NOTIFY_PANEL_ICON;
		private System.Windows.Forms.Label NOTIFY_PANEL_TITLE;
		private System.Windows.Forms.PictureBox INFO_BUTTON;
		private System.Windows.Forms.Timer FORCE_SYNC_DELAY_TIMER;
	}
}

