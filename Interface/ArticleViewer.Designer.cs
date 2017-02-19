namespace CafeMaster_UI.Interface
{
	partial class ArticleViewer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( ArticleViewer ) );
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel( );
			this.APP_TITLE = new System.Windows.Forms.Label( );
			this.CLOSE_BUTTON = new System.Windows.Forms.PictureBox( );
			this.WEB_BROWSER = new System.Windows.Forms.WebBrowser( );
			this.APP_TITLE_BAR.SuspendLayout( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.CLOSE_BUTTON ) ).BeginInit( );
			this.SuspendLayout( );
			// 
			// APP_TITLE_BAR
			// 
			this.APP_TITLE_BAR.BackColor = System.Drawing.Color.Transparent;
			this.APP_TITLE_BAR.Controls.Add( this.APP_TITLE );
			this.APP_TITLE_BAR.Controls.Add( this.CLOSE_BUTTON );
			this.APP_TITLE_BAR.Cursor = System.Windows.Forms.Cursors.Default;
			this.APP_TITLE_BAR.Location = new System.Drawing.Point( 0, 0 );
			this.APP_TITLE_BAR.Name = "APP_TITLE_BAR";
			this.APP_TITLE_BAR.Size = new System.Drawing.Size( 1000, 45 );
			this.APP_TITLE_BAR.TabIndex = 2;
			// 
			// APP_TITLE
			// 
			this.APP_TITLE.AutoSize = true;
			this.APP_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.APP_TITLE.Font = new System.Drawing.Font( "나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			this.APP_TITLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.APP_TITLE.Location = new System.Drawing.Point( 12, 14 );
			this.APP_TITLE.Name = "APP_TITLE";
			this.APP_TITLE.Size = new System.Drawing.Size( 174, 17 );
			this.APP_TITLE.TabIndex = 3;
			this.APP_TITLE.Text = "우윳빛깔 카페스탭 글 보기";
			// 
			// CLOSE_BUTTON
			// 
			this.CLOSE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.CLOSE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CLOSE_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.CLOSE;
			this.CLOSE_BUTTON.Location = new System.Drawing.Point( 965, 10 );
			this.CLOSE_BUTTON.Name = "CLOSE_BUTTON";
			this.CLOSE_BUTTON.Size = new System.Drawing.Size( 25, 25 );
			this.CLOSE_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.CLOSE_BUTTON.TabIndex = 4;
			this.CLOSE_BUTTON.TabStop = false;
			this.CLOSE_BUTTON.Click += new System.EventHandler( this.CLOSE_BUTTON_Click );
			// 
			// WEB_BROWSER
			// 
			this.WEB_BROWSER.Location = new System.Drawing.Point( 0, 51 );
			this.WEB_BROWSER.MinimumSize = new System.Drawing.Size( 20, 20 );
			this.WEB_BROWSER.Name = "WEB_BROWSER";
			this.WEB_BROWSER.Size = new System.Drawing.Size( 999, 732 );
			this.WEB_BROWSER.TabIndex = 0;
			this.WEB_BROWSER.Url = new System.Uri( "http://cafe.naver.com/" + GlobalVar.CAFE_URL_ID, System.UriKind.Absolute );
			this.WEB_BROWSER.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler( this.WEB_BROWSER_DocumentCompleted );
			this.WEB_BROWSER.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler( this.WEB_BROWSER_Navigated );
			this.WEB_BROWSER.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler( this.WEB_BROWSER_Navigating );
			this.WEB_BROWSER.NewWindow += new System.ComponentModel.CancelEventHandler( this.WEB_BROWSER_NewWindow );
			// 
			// ArticleViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 7F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size( 1000, 785 );
			this.Controls.Add( this.APP_TITLE_BAR );
			this.Controls.Add( this.WEB_BROWSER );
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ( ( System.Drawing.Icon ) ( resources.GetObject( "$this.Icon" ) ) );
			this.Name = "ArticleViewer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "우윳빛깔 카페스탭";
			this.Load += new System.EventHandler( this.ArticleViewer_Load );
			this.APP_TITLE_BAR.ResumeLayout( false );
			this.APP_TITLE_BAR.PerformLayout( );
			( ( System.ComponentModel.ISupportInitialize ) ( this.CLOSE_BUTTON ) ).EndInit( );
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.WebBrowser WEB_BROWSER;
		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private System.Windows.Forms.Label APP_TITLE;
		private System.Windows.Forms.PictureBox CLOSE_BUTTON;
	}
}