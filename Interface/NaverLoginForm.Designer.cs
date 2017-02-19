﻿namespace CafeMaster_UI.Interface
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NaverLoginForm));
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel();
			this.APP_TITLE = new System.Windows.Forms.Label();
			this.CLOSE_BUTTON = new System.Windows.Forms.PictureBox();
			this.AUTOLOGIN_DESC = new System.Windows.Forms.Label();
			this.LOADING_GIFIMAGE = new System.Windows.Forms.WebBrowser();
			this.browserBehind = new System.Windows.Forms.WebBrowser();
			this.APP_TITLE_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).BeginInit();
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
			this.AUTOLOGIN_DESC.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.AUTOLOGIN_DESC.ForeColor = System.Drawing.SystemColors.ControlText;
			this.AUTOLOGIN_DESC.Location = new System.Drawing.Point(0, 250);
			this.AUTOLOGIN_DESC.Name = "AUTOLOGIN_DESC";
			this.AUTOLOGIN_DESC.Size = new System.Drawing.Size(595, 20);
			this.AUTOLOGIN_DESC.TabIndex = 5;
			this.AUTOLOGIN_DESC.Text = "자동 로그인을 시도하는 중 ...";
			this.AUTOLOGIN_DESC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.AUTOLOGIN_DESC.Visible = false;
			// 
			// LOADING_GIFIMAGE
			// 
			this.LOADING_GIFIMAGE.AllowNavigation = false;
			this.LOADING_GIFIMAGE.AllowWebBrowserDrop = false;
			this.LOADING_GIFIMAGE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LOADING_GIFIMAGE.IsWebBrowserContextMenuEnabled = false;
			this.LOADING_GIFIMAGE.Location = new System.Drawing.Point(272, 175);
			this.LOADING_GIFIMAGE.MinimumSize = new System.Drawing.Size(20, 20);
			this.LOADING_GIFIMAGE.Name = "LOADING_GIFIMAGE";
			this.LOADING_GIFIMAGE.ScriptErrorsSuppressed = true;
			this.LOADING_GIFIMAGE.ScrollBarsEnabled = false;
			this.LOADING_GIFIMAGE.Size = new System.Drawing.Size(50, 50);
			this.LOADING_GIFIMAGE.TabIndex = 16;
			this.LOADING_GIFIMAGE.Visible = false;
			this.LOADING_GIFIMAGE.WebBrowserShortcutsEnabled = false;
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
			this.browserBehind.Url = new System.Uri("https://nid.naver.com/nidlogin.login?svctype=64", System.UriKind.Absolute);
			this.browserBehind.WebBrowserShortcutsEnabled = false;
			this.browserBehind.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.browserBehind_Navigating);
			// 
			// NaverLoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(595, 470);
			this.Controls.Add(this.LOADING_GIFIMAGE);
			this.Controls.Add(this.AUTOLOGIN_DESC);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.Controls.Add(this.browserBehind);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "NaverLoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "네이버 로그인";
			this.Load += new System.EventHandler(this.NaverLoginForm_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.NaverLoginForm_Paint);
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.WebBrowser browserBehind;
		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private System.Windows.Forms.Label APP_TITLE;
		private System.Windows.Forms.PictureBox CLOSE_BUTTON;
		private System.Windows.Forms.Label AUTOLOGIN_DESC;
		private System.Windows.Forms.WebBrowser LOADING_GIFIMAGE;
	}
}