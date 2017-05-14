namespace CafeMaster_UI.Interface
{
	partial class NaverLoginForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NaverLoginForm));
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel();
			this.APP_TITLE = new CafeMaster_UI.Interface.CustomLabel();
			this.CLOSE_BUTTON = new System.Windows.Forms.PictureBox();
			this.AUTOLOGIN_DESC = new System.Windows.Forms.Label();
			this.browserBehind = new System.Windows.Forms.WebBrowser();
			this.DotAnimationTimer = new System.Windows.Forms.Timer(this.components);
			this.AUTOLOGIN_TITLE = new System.Windows.Forms.Label();
			this.PROFILE_IMAGE = new System.Windows.Forms.PictureBox();
			this.BACKGROUND_SPLASH = new System.Windows.Forms.PictureBox();
			this.APP_TITLE_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PROFILE_IMAGE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BACKGROUND_SPLASH)).BeginInit();
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
			this.APP_TITLE_BAR.Size = new System.Drawing.Size(595, 45);
			this.APP_TITLE_BAR.TabIndex = 1;
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
			this.APP_TITLE.Size = new System.Drawing.Size(76, 14);
			this.APP_TITLE.TabIndex = 3;
			this.APP_TITLE.Text = "네이버 로그인";
			this.APP_TITLE.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			// 
			// CLOSE_BUTTON
			// 
			this.CLOSE_BUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CLOSE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.CLOSE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CLOSE_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.CLOSE;
			this.CLOSE_BUTTON.Location = new System.Drawing.Point(560, 10);
			this.CLOSE_BUTTON.Name = "CLOSE_BUTTON";
			this.CLOSE_BUTTON.Size = new System.Drawing.Size(25, 25);
			this.CLOSE_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.CLOSE_BUTTON.TabIndex = 4;
			this.CLOSE_BUTTON.TabStop = false;
			this.CLOSE_BUTTON.Click += new System.EventHandler(this.CLOSE_BUTTON_Click);
			// 
			// AUTOLOGIN_DESC
			// 
			this.AUTOLOGIN_DESC.BackColor = System.Drawing.Color.Transparent;
			this.AUTOLOGIN_DESC.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.AUTOLOGIN_DESC.ForeColor = System.Drawing.SystemColors.ControlText;
			this.AUTOLOGIN_DESC.Location = new System.Drawing.Point(0, 300);
			this.AUTOLOGIN_DESC.Name = "AUTOLOGIN_DESC";
			this.AUTOLOGIN_DESC.Size = new System.Drawing.Size(595, 20);
			this.AUTOLOGIN_DESC.TabIndex = 5;
			this.AUTOLOGIN_DESC.Text = "자동 로그인을 시도하는 중 ...";
			this.AUTOLOGIN_DESC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.AUTOLOGIN_DESC.Visible = false;
			// 
			// browserBehind
			// 
			this.browserBehind.AllowWebBrowserDrop = false;
			this.browserBehind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.browserBehind.IsWebBrowserContextMenuEnabled = false;
			this.browserBehind.Location = new System.Drawing.Point(1, 46);
			this.browserBehind.MinimumSize = new System.Drawing.Size(20, 20);
			this.browserBehind.Name = "browserBehind";
			this.browserBehind.ScriptErrorsSuppressed = true;
			this.browserBehind.ScrollBarsEnabled = false;
			this.browserBehind.Size = new System.Drawing.Size(593, 423);
			this.browserBehind.TabIndex = 0;
			this.browserBehind.TabStop = false;
			this.browserBehind.Url = new System.Uri("", System.UriKind.Relative);
			this.browserBehind.WebBrowserShortcutsEnabled = false;
			this.browserBehind.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.browserBehind_DocumentCompleted);
			this.browserBehind.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.browserBehind_Navigating);
			this.browserBehind.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.browserBehind_ProgressChanged);
			// 
			// DotAnimationTimer
			// 
			this.DotAnimationTimer.Tick += new System.EventHandler(this.DotAnimationTimer_Tick);
			// 
			// AUTOLOGIN_TITLE
			// 
			this.AUTOLOGIN_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.AUTOLOGIN_TITLE.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.AUTOLOGIN_TITLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.AUTOLOGIN_TITLE.Location = new System.Drawing.Point(0, 250);
			this.AUTOLOGIN_TITLE.Name = "AUTOLOGIN_TITLE";
			this.AUTOLOGIN_TITLE.Size = new System.Drawing.Size(595, 46);
			this.AUTOLOGIN_TITLE.TabIndex = 50;
			this.AUTOLOGIN_TITLE.Text = "USER";
			this.AUTOLOGIN_TITLE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.AUTOLOGIN_TITLE.Visible = false;
			// 
			// PROFILE_IMAGE
			// 
			this.PROFILE_IMAGE.BackColor = System.Drawing.Color.Transparent;
			this.PROFILE_IMAGE.BackgroundImage = global::CafeMaster_UI.Properties.Resources.PROFILE_UNKNOWN_V2_120x120;
			this.PROFILE_IMAGE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PROFILE_IMAGE.Image = global::CafeMaster_UI.Properties.Resources.PROFILE_IMAGE_CIRCLE_160x160;
			this.PROFILE_IMAGE.Location = new System.Drawing.Point(217, 80);
			this.PROFILE_IMAGE.Name = "PROFILE_IMAGE";
			this.PROFILE_IMAGE.Size = new System.Drawing.Size(160, 160);
			this.PROFILE_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PROFILE_IMAGE.TabIndex = 49;
			this.PROFILE_IMAGE.TabStop = false;
			this.PROFILE_IMAGE.Visible = false;
			// 
			// BACKGROUND_SPLASH
			// 
			this.BACKGROUND_SPLASH.BackColor = System.Drawing.Color.Transparent;
			this.BACKGROUND_SPLASH.Image = global::CafeMaster_UI.Properties.Resources.Background05;
			this.BACKGROUND_SPLASH.Location = new System.Drawing.Point(1, 1);
			this.BACKGROUND_SPLASH.Name = "BACKGROUND_SPLASH";
			this.BACKGROUND_SPLASH.Size = new System.Drawing.Size(593, 468);
			this.BACKGROUND_SPLASH.TabIndex = 51;
			this.BACKGROUND_SPLASH.TabStop = false;
			// 
			// NaverLoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(595, 470);
			this.Controls.Add(this.AUTOLOGIN_TITLE);
			this.Controls.Add(this.AUTOLOGIN_DESC);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.Controls.Add(this.PROFILE_IMAGE);
			this.Controls.Add(this.browserBehind);
			this.Controls.Add(this.BACKGROUND_SPLASH);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "NaverLoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "네이버 로그인";
			this.Load += new System.EventHandler(this.NaverLoginForm_Load);
			this.Shown += new System.EventHandler(this.NaverLoginForm_Shown);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.NaverLoginForm_Paint);
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PROFILE_IMAGE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BACKGROUND_SPLASH)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.WebBrowser browserBehind;
		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private CustomLabel APP_TITLE;
		private System.Windows.Forms.PictureBox CLOSE_BUTTON;
		private System.Windows.Forms.Label AUTOLOGIN_DESC;
		private System.Windows.Forms.PictureBox PROFILE_IMAGE;
		private System.Windows.Forms.Timer DotAnimationTimer;
		private System.Windows.Forms.Label AUTOLOGIN_TITLE;
		private System.Windows.Forms.PictureBox BACKGROUND_SPLASH;
	}
}