namespace CafeMaster_UI.Interface
{
	partial class UpdateNotifyForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateNotifyForm));
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel();
			this.CLOSE_BUTTON = new System.Windows.Forms.PictureBox();
			this.PATCH_NOTE_BROWSER = new System.Windows.Forms.WebBrowser();
			this.TITLE_1_LABEL = new System.Windows.Forms.Label();
			this.STEP_CHATBOX_ICON = new System.Windows.Forms.PictureBox();
			this.UPDATE_URL_OPEN_BUTTON = new CafeMaster_UI.Interface.FlatButton();
			this.IGNORE_NOTIFY_CHECKBOX = new CafeMaster_UI.Interface.FlatCheckBox();
			this.IGNORE_NOTIFY_LABEL = new System.Windows.Forms.Label();
			this.CLOSE_BUTTON_TWO = new CafeMaster_UI.Interface.FlatButton();
			this.TITLE_2_LABEL = new System.Windows.Forms.Label();
			this.APP_TITLE_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.STEP_CHATBOX_ICON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.IGNORE_NOTIFY_CHECKBOX)).BeginInit();
			this.SuspendLayout();
			// 
			// APP_TITLE_BAR
			// 
			this.APP_TITLE_BAR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.APP_TITLE_BAR.BackColor = System.Drawing.Color.White;
			this.APP_TITLE_BAR.Controls.Add(this.CLOSE_BUTTON);
			this.APP_TITLE_BAR.Cursor = System.Windows.Forms.Cursors.Default;
			this.APP_TITLE_BAR.Location = new System.Drawing.Point(0, 0);
			this.APP_TITLE_BAR.Name = "APP_TITLE_BAR";
			this.APP_TITLE_BAR.Size = new System.Drawing.Size(650, 45);
			this.APP_TITLE_BAR.TabIndex = 2;
			this.APP_TITLE_BAR.Paint += new System.Windows.Forms.PaintEventHandler(this.APP_TITLE_BAR_Paint);
			this.APP_TITLE_BAR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseDown);
			this.APP_TITLE_BAR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseMove);
			// 
			// CLOSE_BUTTON
			// 
			this.CLOSE_BUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CLOSE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.CLOSE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CLOSE_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.CLOSE;
			this.CLOSE_BUTTON.Location = new System.Drawing.Point(615, 10);
			this.CLOSE_BUTTON.Name = "CLOSE_BUTTON";
			this.CLOSE_BUTTON.Size = new System.Drawing.Size(25, 25);
			this.CLOSE_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.CLOSE_BUTTON.TabIndex = 4;
			this.CLOSE_BUTTON.TabStop = false;
			this.CLOSE_BUTTON.Click += new System.EventHandler(this.CLOSE_BUTTON_Click);
			// 
			// PATCH_NOTE_BROWSER
			// 
			this.PATCH_NOTE_BROWSER.AllowNavigation = false;
			this.PATCH_NOTE_BROWSER.AllowWebBrowserDrop = false;
			this.PATCH_NOTE_BROWSER.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PATCH_NOTE_BROWSER.IsWebBrowserContextMenuEnabled = false;
			this.PATCH_NOTE_BROWSER.Location = new System.Drawing.Point(12, 160);
			this.PATCH_NOTE_BROWSER.MinimumSize = new System.Drawing.Size(20, 20);
			this.PATCH_NOTE_BROWSER.Name = "PATCH_NOTE_BROWSER";
			this.PATCH_NOTE_BROWSER.ScriptErrorsSuppressed = true;
			this.PATCH_NOTE_BROWSER.Size = new System.Drawing.Size(625, 270);
			this.PATCH_NOTE_BROWSER.TabIndex = 0;
			this.PATCH_NOTE_BROWSER.Url = new System.Uri("", System.UriKind.Relative);
			this.PATCH_NOTE_BROWSER.WebBrowserShortcutsEnabled = false;
			this.PATCH_NOTE_BROWSER.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.PATCH_NOTE_BROWSER_DocumentCompleted);
			// 
			// TITLE_1_LABEL
			// 
			this.TITLE_1_LABEL.AutoSize = true;
			this.TITLE_1_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.TITLE_1_LABEL.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.TITLE_1_LABEL.ForeColor = System.Drawing.SystemColors.ControlText;
			this.TITLE_1_LABEL.Location = new System.Drawing.Point(180, 96);
			this.TITLE_1_LABEL.Name = "TITLE_1_LABEL";
			this.TITLE_1_LABEL.Size = new System.Drawing.Size(291, 17);
			this.TITLE_1_LABEL.TabIndex = 23;
			this.TITLE_1_LABEL.Text = "새로운 프로그램 업데이트가 출시되었습니다.";
			// 
			// STEP_CHATBOX_ICON
			// 
			this.STEP_CHATBOX_ICON.BackColor = System.Drawing.Color.Transparent;
			this.STEP_CHATBOX_ICON.Cursor = System.Windows.Forms.Cursors.Default;
			this.STEP_CHATBOX_ICON.Image = global::CafeMaster_UI.Properties.Resources.UPDATE_35x35;
			this.STEP_CHATBOX_ICON.Location = new System.Drawing.Point(308, 50);
			this.STEP_CHATBOX_ICON.Name = "STEP_CHATBOX_ICON";
			this.STEP_CHATBOX_ICON.Size = new System.Drawing.Size(35, 35);
			this.STEP_CHATBOX_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.STEP_CHATBOX_ICON.TabIndex = 42;
			this.STEP_CHATBOX_ICON.TabStop = false;
			// 
			// UPDATE_URL_OPEN_BUTTON
			// 
			this.UPDATE_URL_OPEN_BUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UPDATE_URL_OPEN_BUTTON.AnimationLerpP = 0.8F;
			this.UPDATE_URL_OPEN_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.UPDATE_URL_OPEN_BUTTON.ButtonText = "업데이트 다운로드";
			this.UPDATE_URL_OPEN_BUTTON.ButtonTextColor = System.Drawing.Color.Black;
			this.UPDATE_URL_OPEN_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.UPDATE_URL_OPEN_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.UPDATE_URL_OPEN_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UPDATE_URL_OPEN_BUTTON.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.UPDATE_URL_OPEN_BUTTON.Location = new System.Drawing.Point(432, 438);
			this.UPDATE_URL_OPEN_BUTTON.Name = "UPDATE_URL_OPEN_BUTTON";
			this.UPDATE_URL_OPEN_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.UPDATE_URL_OPEN_BUTTON.Size = new System.Drawing.Size(206, 50);
			this.UPDATE_URL_OPEN_BUTTON.TabIndex = 43;
			this.UPDATE_URL_OPEN_BUTTON.TabStop = false;
			this.UPDATE_URL_OPEN_BUTTON.Text = "업데이트 다운로드";
			this.UPDATE_URL_OPEN_BUTTON.UseVisualStyleBackColor = false;
			this.UPDATE_URL_OPEN_BUTTON.Click += new System.EventHandler(this.UPDATE_URL_OPEN_BUTTON_Click);
			// 
			// IGNORE_NOTIFY_CHECKBOX
			// 
			this.IGNORE_NOTIFY_CHECKBOX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.IGNORE_NOTIFY_CHECKBOX.BackColor = System.Drawing.Color.Transparent;
			this.IGNORE_NOTIFY_CHECKBOX.Cursor = System.Windows.Forms.Cursors.Hand;
			this.IGNORE_NOTIFY_CHECKBOX.Image = ((System.Drawing.Image)(resources.GetObject("IGNORE_NOTIFY_CHECKBOX.Image")));
			this.IGNORE_NOTIFY_CHECKBOX.Location = new System.Drawing.Point(12, 458);
			this.IGNORE_NOTIFY_CHECKBOX.Name = "IGNORE_NOTIFY_CHECKBOX";
			this.IGNORE_NOTIFY_CHECKBOX.Size = new System.Drawing.Size(30, 30);
			this.IGNORE_NOTIFY_CHECKBOX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.IGNORE_NOTIFY_CHECKBOX.Status = false;
			this.IGNORE_NOTIFY_CHECKBOX.TabIndex = 44;
			this.IGNORE_NOTIFY_CHECKBOX.TabStop = false;
			this.IGNORE_NOTIFY_CHECKBOX.StatusChanged += new System.EventHandler(this.IGNORE_NOTIFY_CHECKBOX_StatusChanged);
			// 
			// IGNORE_NOTIFY_LABEL
			// 
			this.IGNORE_NOTIFY_LABEL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.IGNORE_NOTIFY_LABEL.AutoSize = true;
			this.IGNORE_NOTIFY_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.IGNORE_NOTIFY_LABEL.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.IGNORE_NOTIFY_LABEL.ForeColor = System.Drawing.SystemColors.ControlText;
			this.IGNORE_NOTIFY_LABEL.Location = new System.Drawing.Point(48, 466);
			this.IGNORE_NOTIFY_LABEL.Name = "IGNORE_NOTIFY_LABEL";
			this.IGNORE_NOTIFY_LABEL.Size = new System.Drawing.Size(112, 14);
			this.IGNORE_NOTIFY_LABEL.TabIndex = 45;
			this.IGNORE_NOTIFY_LABEL.Text = "하루동안 알리지 않기";
			// 
			// CLOSE_BUTTON_TWO
			// 
			this.CLOSE_BUTTON_TWO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CLOSE_BUTTON_TWO.AnimationLerpP = 0.8F;
			this.CLOSE_BUTTON_TWO.BackColor = System.Drawing.Color.Transparent;
			this.CLOSE_BUTTON_TWO.ButtonText = "취소";
			this.CLOSE_BUTTON_TWO.ButtonTextColor = System.Drawing.Color.White;
			this.CLOSE_BUTTON_TWO.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CLOSE_BUTTON_TWO.EnterStateBackgroundColor = System.Drawing.Color.Red;
			this.CLOSE_BUTTON_TWO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CLOSE_BUTTON_TWO.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.CLOSE_BUTTON_TWO.Location = new System.Drawing.Point(351, 458);
			this.CLOSE_BUTTON_TWO.Name = "CLOSE_BUTTON_TWO";
			this.CLOSE_BUTTON_TWO.NormalStateBackgroundColor = System.Drawing.Color.Crimson;
			this.CLOSE_BUTTON_TWO.Size = new System.Drawing.Size(75, 30);
			this.CLOSE_BUTTON_TWO.TabIndex = 46;
			this.CLOSE_BUTTON_TWO.TabStop = false;
			this.CLOSE_BUTTON_TWO.Text = "취소";
			this.CLOSE_BUTTON_TWO.UseVisualStyleBackColor = false;
			this.CLOSE_BUTTON_TWO.Click += new System.EventHandler(this.CLOSE_BUTTON_TWO_Click);
			// 
			// TITLE_2_LABEL
			// 
			this.TITLE_2_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.TITLE_2_LABEL.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.TITLE_2_LABEL.ForeColor = System.Drawing.SystemColors.ControlText;
			this.TITLE_2_LABEL.Location = new System.Drawing.Point(12, 119);
			this.TITLE_2_LABEL.Name = "TITLE_2_LABEL";
			this.TITLE_2_LABEL.Size = new System.Drawing.Size(625, 17);
			this.TITLE_2_LABEL.TabIndex = 47;
			this.TITLE_2_LABEL.Text = "1.0.0.0 버전으로 지금 바로 업데이트 하세요.";
			this.TITLE_2_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// UpdateNotifyForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(650, 500);
			this.Controls.Add(this.TITLE_2_LABEL);
			this.Controls.Add(this.CLOSE_BUTTON_TWO);
			this.Controls.Add(this.IGNORE_NOTIFY_LABEL);
			this.Controls.Add(this.IGNORE_NOTIFY_CHECKBOX);
			this.Controls.Add(this.UPDATE_URL_OPEN_BUTTON);
			this.Controls.Add(this.STEP_CHATBOX_ICON);
			this.Controls.Add(this.TITLE_1_LABEL);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.Controls.Add(this.PATCH_NOTE_BROWSER);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "UpdateNotifyForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "업데이트 알림";
			this.Load += new System.EventHandler(this.UpdateNotifyForm_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateNotifyForm_Paint);
			this.APP_TITLE_BAR.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.STEP_CHATBOX_ICON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.IGNORE_NOTIFY_CHECKBOX)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.WebBrowser PATCH_NOTE_BROWSER;
		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private System.Windows.Forms.PictureBox CLOSE_BUTTON;
		private System.Windows.Forms.Label TITLE_1_LABEL;
		private System.Windows.Forms.PictureBox STEP_CHATBOX_ICON;
		private FlatButton UPDATE_URL_OPEN_BUTTON;
		private FlatCheckBox IGNORE_NOTIFY_CHECKBOX;
		private System.Windows.Forms.Label IGNORE_NOTIFY_LABEL;
		private FlatButton CLOSE_BUTTON_TWO;
		private System.Windows.Forms.Label TITLE_2_LABEL;
	}
}