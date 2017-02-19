namespace CafeMaster_UI.Interface
{
	partial class UserWarnOptionForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserWarnOptionForm));
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel();
			this.APP_TITLE = new System.Windows.Forms.Label();
			this.USERNICK_TITLE = new System.Windows.Forms.Label();
			this.REASON_TITLE = new System.Windows.Forms.Label();
			this.REASON_TEXTBOX = new System.Windows.Forms.TextBox();
			this.USERNICK_EXAMPLE = new System.Windows.Forms.Label();
			this.REASON_EXAMPLE = new System.Windows.Forms.Label();
			this.WARN_EXAMPLE_IMAGE_TITLE = new System.Windows.Forms.Label();
			this.REASON_DESC = new System.Windows.Forms.Label();
			this.THREAD_TITLE_EXAMPLE = new System.Windows.Forms.Label();
			this.WARN_TEXT = new System.Windows.Forms.Label();
			this.WARNING_COUNT = new System.Windows.Forms.NumericUpDown();
			this.COUNT_TITLE = new System.Windows.Forms.Label();
			this.COUNT_DESC = new System.Windows.Forms.Label();
			this.SEARCH_COUNT_BUTTON = new CafeMaster_UI.Interface.FlatButton();
			this.WARN_RUN_BUTTON = new CafeMaster_UI.Interface.FlatButton();
			this.WARN_ICON = new System.Windows.Forms.PictureBox();
			this.WARN_EXAMPLE = new System.Windows.Forms.PictureBox();
			this.CLOSE_BUTTON = new System.Windows.Forms.PictureBox();
			this.BACKGROUND_SPLASH = new System.Windows.Forms.PictureBox();
			this.APP_TITLE_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.WARNING_COUNT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WARN_ICON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.WARN_EXAMPLE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BACKGROUND_SPLASH)).BeginInit();
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
			this.APP_TITLE.Text = "경고 부여";
			// 
			// USERNICK_TITLE
			// 
			this.USERNICK_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.USERNICK_TITLE.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.USERNICK_TITLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.USERNICK_TITLE.Location = new System.Drawing.Point(37, 100);
			this.USERNICK_TITLE.Name = "USERNICK_TITLE";
			this.USERNICK_TITLE.Size = new System.Drawing.Size(551, 35);
			this.USERNICK_TITLE.TabIndex = 4;
			this.USERNICK_TITLE.Text = "L7D(smhjyh2007)";
			this.USERNICK_TITLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// REASON_TITLE
			// 
			this.REASON_TITLE.AutoSize = true;
			this.REASON_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.REASON_TITLE.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.REASON_TITLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.REASON_TITLE.Location = new System.Drawing.Point(37, 142);
			this.REASON_TITLE.Name = "REASON_TITLE";
			this.REASON_TITLE.Size = new System.Drawing.Size(36, 17);
			this.REASON_TITLE.TabIndex = 5;
			this.REASON_TITLE.Text = "진술";
			// 
			// REASON_TEXTBOX
			// 
			this.REASON_TEXTBOX.BackColor = System.Drawing.Color.White;
			this.REASON_TEXTBOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.REASON_TEXTBOX.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.REASON_TEXTBOX.Location = new System.Drawing.Point(40, 167);
			this.REASON_TEXTBOX.MaxLength = 200;
			this.REASON_TEXTBOX.Name = "REASON_TEXTBOX";
			this.REASON_TEXTBOX.Size = new System.Drawing.Size(411, 22);
			this.REASON_TEXTBOX.TabIndex = 6;
			this.REASON_TEXTBOX.TextChanged += new System.EventHandler(this.REASON_TEXTBOX_TextChanged);
			// 
			// USERNICK_EXAMPLE
			// 
			this.USERNICK_EXAMPLE.BackColor = System.Drawing.Color.Transparent;
			this.USERNICK_EXAMPLE.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.USERNICK_EXAMPLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.USERNICK_EXAMPLE.Location = new System.Drawing.Point(132, 412);
			this.USERNICK_EXAMPLE.Name = "USERNICK_EXAMPLE";
			this.USERNICK_EXAMPLE.Size = new System.Drawing.Size(305, 17);
			this.USERNICK_EXAMPLE.TabIndex = 9;
			this.USERNICK_EXAMPLE.Text = "닉네임";
			this.USERNICK_EXAMPLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// REASON_EXAMPLE
			// 
			this.REASON_EXAMPLE.BackColor = System.Drawing.Color.Transparent;
			this.REASON_EXAMPLE.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.REASON_EXAMPLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.REASON_EXAMPLE.Location = new System.Drawing.Point(81, 444);
			this.REASON_EXAMPLE.Name = "REASON_EXAMPLE";
			this.REASON_EXAMPLE.Size = new System.Drawing.Size(356, 17);
			this.REASON_EXAMPLE.TabIndex = 10;
			this.REASON_EXAMPLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// WARN_EXAMPLE_IMAGE_TITLE
			// 
			this.WARN_EXAMPLE_IMAGE_TITLE.AutoSize = true;
			this.WARN_EXAMPLE_IMAGE_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.WARN_EXAMPLE_IMAGE_TITLE.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.WARN_EXAMPLE_IMAGE_TITLE.ForeColor = System.Drawing.Color.DimGray;
			this.WARN_EXAMPLE_IMAGE_TITLE.Location = new System.Drawing.Point(34, 333);
			this.WARN_EXAMPLE_IMAGE_TITLE.Name = "WARN_EXAMPLE_IMAGE_TITLE";
			this.WARN_EXAMPLE_IMAGE_TITLE.Size = new System.Drawing.Size(148, 14);
			this.WARN_EXAMPLE_IMAGE_TITLE.TabIndex = 11;
			this.WARN_EXAMPLE_IMAGE_TITLE.Text = "실제 게시글에 작성되는 내용";
			// 
			// REASON_DESC
			// 
			this.REASON_DESC.AutoSize = true;
			this.REASON_DESC.BackColor = System.Drawing.Color.Transparent;
			this.REASON_DESC.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.REASON_DESC.ForeColor = System.Drawing.SystemColors.ControlText;
			this.REASON_DESC.Location = new System.Drawing.Point(38, 194);
			this.REASON_DESC.Name = "REASON_DESC";
			this.REASON_DESC.Size = new System.Drawing.Size(127, 14);
			this.REASON_DESC.TabIndex = 12;
			this.REASON_DESC.Text = "경고 사유를 작성하세요.";
			// 
			// THREAD_TITLE_EXAMPLE
			// 
			this.THREAD_TITLE_EXAMPLE.BackColor = System.Drawing.Color.Transparent;
			this.THREAD_TITLE_EXAMPLE.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.THREAD_TITLE_EXAMPLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.THREAD_TITLE_EXAMPLE.Location = new System.Drawing.Point(46, 372);
			this.THREAD_TITLE_EXAMPLE.Name = "THREAD_TITLE_EXAMPLE";
			this.THREAD_TITLE_EXAMPLE.Size = new System.Drawing.Size(294, 17);
			this.THREAD_TITLE_EXAMPLE.TabIndex = 15;
			this.THREAD_TITLE_EXAMPLE.Text = "제목";
			this.THREAD_TITLE_EXAMPLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// WARN_TEXT
			// 
			this.WARN_TEXT.AutoSize = true;
			this.WARN_TEXT.BackColor = System.Drawing.Color.Transparent;
			this.WARN_TEXT.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.WARN_TEXT.ForeColor = System.Drawing.SystemColors.ControlText;
			this.WARN_TEXT.Location = new System.Drawing.Point(90, 65);
			this.WARN_TEXT.Name = "WARN_TEXT";
			this.WARN_TEXT.Size = new System.Drawing.Size(453, 15);
			this.WARN_TEXT.TabIndex = 18;
			this.WARN_TEXT.Text = "경고를 부여하기 전 모든 작성사항을 다시 확인하시고 규정을 꼭! 다시 확인하세요.";
			// 
			// WARNING_COUNT
			// 
			this.WARNING_COUNT.BackColor = System.Drawing.Color.White;
			this.WARNING_COUNT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.WARNING_COUNT.Font = new System.Drawing.Font("나눔고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.WARNING_COUNT.ForeColor = System.Drawing.Color.Red;
			this.WARNING_COUNT.Location = new System.Drawing.Point(111, 230);
			this.WARNING_COUNT.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.WARNING_COUNT.Name = "WARNING_COUNT";
			this.WARNING_COUNT.Size = new System.Drawing.Size(83, 44);
			this.WARNING_COUNT.TabIndex = 19;
			this.WARNING_COUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.WARNING_COUNT.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.WARNING_COUNT.ValueChanged += new System.EventHandler(this.WARNING_COUNT_ValueChanged);
			// 
			// COUNT_TITLE
			// 
			this.COUNT_TITLE.AutoSize = true;
			this.COUNT_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.COUNT_TITLE.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.COUNT_TITLE.ForeColor = System.Drawing.Color.Red;
			this.COUNT_TITLE.Location = new System.Drawing.Point(37, 241);
			this.COUNT_TITLE.Name = "COUNT_TITLE";
			this.COUNT_TITLE.Size = new System.Drawing.Size(68, 17);
			this.COUNT_TITLE.TabIndex = 20;
			this.COUNT_TITLE.Text = "경고 횟수";
			// 
			// COUNT_DESC
			// 
			this.COUNT_DESC.AutoSize = true;
			this.COUNT_DESC.BackColor = System.Drawing.Color.Transparent;
			this.COUNT_DESC.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.COUNT_DESC.ForeColor = System.Drawing.SystemColors.ControlText;
			this.COUNT_DESC.Location = new System.Drawing.Point(203, 230);
			this.COUNT_DESC.Name = "COUNT_DESC";
			this.COUNT_DESC.Size = new System.Drawing.Size(318, 14);
			this.COUNT_DESC.TabIndex = 21;
			this.COUNT_DESC.Text = "경고 횟수를 설정하기 전 꼭 경고게시판을 검색해서 확인하세요.";
			// 
			// SEARCH_COUNT_BUTTON
			// 
			this.SEARCH_COUNT_BUTTON.AnimationLerpP = 0.8F;
			this.SEARCH_COUNT_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.SEARCH_COUNT_BUTTON.ButtonText = "횟수 확인하기";
			this.SEARCH_COUNT_BUTTON.ButtonTextColor = System.Drawing.Color.Black;
			this.SEARCH_COUNT_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SEARCH_COUNT_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.Silver;
			this.SEARCH_COUNT_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SEARCH_COUNT_BUTTON.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.SEARCH_COUNT_BUTTON.Location = new System.Drawing.Point(407, 250);
			this.SEARCH_COUNT_BUTTON.Name = "SEARCH_COUNT_BUTTON";
			this.SEARCH_COUNT_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.SEARCH_COUNT_BUTTON.Size = new System.Drawing.Size(111, 24);
			this.SEARCH_COUNT_BUTTON.TabIndex = 22;
			this.SEARCH_COUNT_BUTTON.Text = "횟수 확인하기";
			this.SEARCH_COUNT_BUTTON.UseVisualStyleBackColor = false;
			this.SEARCH_COUNT_BUTTON.Click += new System.EventHandler(this.SEARCH_COUNT_BUTTON_Click);
			// 
			// WARN_RUN_BUTTON
			// 
			this.WARN_RUN_BUTTON.AnimationLerpP = 0.8F;
			this.WARN_RUN_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.WARN_RUN_BUTTON.ButtonText = "경고 부여";
			this.WARN_RUN_BUTTON.ButtonTextColor = System.Drawing.Color.Black;
			this.WARN_RUN_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.WARN_RUN_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.DarkOrange;
			this.WARN_RUN_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.WARN_RUN_BUTTON.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.WARN_RUN_BUTTON.Location = new System.Drawing.Point(393, 488);
			this.WARN_RUN_BUTTON.Name = "WARN_RUN_BUTTON";
			this.WARN_RUN_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.Orange;
			this.WARN_RUN_BUTTON.Size = new System.Drawing.Size(195, 50);
			this.WARN_RUN_BUTTON.TabIndex = 7;
			this.WARN_RUN_BUTTON.Text = "경고 부여";
			this.WARN_RUN_BUTTON.UseVisualStyleBackColor = false;
			this.WARN_RUN_BUTTON.Click += new System.EventHandler(this.WARN_RUN_BUTTON_Click);
			// 
			// WARN_ICON
			// 
			this.WARN_ICON.BackColor = System.Drawing.Color.Transparent;
			this.WARN_ICON.Image = global::CafeMaster_UI.Properties.Resources.WARNING_ICON;
			this.WARN_ICON.Location = new System.Drawing.Point(40, 60);
			this.WARN_ICON.Name = "WARN_ICON";
			this.WARN_ICON.Size = new System.Drawing.Size(25, 25);
			this.WARN_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.WARN_ICON.TabIndex = 17;
			this.WARN_ICON.TabStop = false;
			// 
			// WARN_EXAMPLE
			// 
			this.WARN_EXAMPLE.BackColor = System.Drawing.Color.Transparent;
			this.WARN_EXAMPLE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.WARN_EXAMPLE.Image = global::CafeMaster_UI.Properties.Resources.WARN_EXAMPLE;
			this.WARN_EXAMPLE.Location = new System.Drawing.Point(36, 354);
			this.WARN_EXAMPLE.Name = "WARN_EXAMPLE";
			this.WARN_EXAMPLE.Size = new System.Drawing.Size(411, 118);
			this.WARN_EXAMPLE.TabIndex = 8;
			this.WARN_EXAMPLE.TabStop = false;
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
			// BACKGROUND_SPLASH
			// 
			this.BACKGROUND_SPLASH.BackColor = System.Drawing.Color.Transparent;
			this.BACKGROUND_SPLASH.Image = global::CafeMaster_UI.Properties.Resources.Background03;
			this.BACKGROUND_SPLASH.Location = new System.Drawing.Point(1, 99);
			this.BACKGROUND_SPLASH.Name = "BACKGROUND_SPLASH";
			this.BACKGROUND_SPLASH.Size = new System.Drawing.Size(598, 448);
			this.BACKGROUND_SPLASH.TabIndex = 16;
			this.BACKGROUND_SPLASH.TabStop = false;
			// 
			// UserWarnOptionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(600, 550);
			this.Controls.Add(this.SEARCH_COUNT_BUTTON);
			this.Controls.Add(this.COUNT_DESC);
			this.Controls.Add(this.COUNT_TITLE);
			this.Controls.Add(this.WARNING_COUNT);
			this.Controls.Add(this.WARN_TEXT);
			this.Controls.Add(this.WARN_ICON);
			this.Controls.Add(this.THREAD_TITLE_EXAMPLE);
			this.Controls.Add(this.REASON_DESC);
			this.Controls.Add(this.WARN_EXAMPLE_IMAGE_TITLE);
			this.Controls.Add(this.REASON_EXAMPLE);
			this.Controls.Add(this.USERNICK_EXAMPLE);
			this.Controls.Add(this.WARN_EXAMPLE);
			this.Controls.Add(this.WARN_RUN_BUTTON);
			this.Controls.Add(this.REASON_TEXTBOX);
			this.Controls.Add(this.REASON_TITLE);
			this.Controls.Add(this.USERNICK_TITLE);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.Controls.Add(this.BACKGROUND_SPLASH);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "UserWarnOptionForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "경고 부여";
			this.Load += new System.EventHandler(this.UserWarnOptionForm_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserWarnOptionForm_Paint);
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.WARNING_COUNT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WARN_ICON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.WARN_EXAMPLE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BACKGROUND_SPLASH)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private System.Windows.Forms.Label APP_TITLE;
		private System.Windows.Forms.PictureBox CLOSE_BUTTON;
		private System.Windows.Forms.Label USERNICK_TITLE;
		private System.Windows.Forms.Label REASON_TITLE;
		private System.Windows.Forms.TextBox REASON_TEXTBOX;
		private FlatButton WARN_RUN_BUTTON;
		private System.Windows.Forms.PictureBox WARN_EXAMPLE;
		private System.Windows.Forms.Label USERNICK_EXAMPLE;
		private System.Windows.Forms.Label REASON_EXAMPLE;
		private System.Windows.Forms.Label WARN_EXAMPLE_IMAGE_TITLE;
		private System.Windows.Forms.Label REASON_DESC;
		private System.Windows.Forms.Label THREAD_TITLE_EXAMPLE;
		private System.Windows.Forms.PictureBox BACKGROUND_SPLASH;
		private System.Windows.Forms.PictureBox WARN_ICON;
		private System.Windows.Forms.Label WARN_TEXT;
		private System.Windows.Forms.NumericUpDown WARNING_COUNT;
		private System.Windows.Forms.Label COUNT_TITLE;
		private System.Windows.Forms.Label COUNT_DESC;
		private FlatButton SEARCH_COUNT_BUTTON;
	}
}