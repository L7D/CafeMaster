namespace CafeMaster_UI.Interface
{
	partial class AutoLoginManagerForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoLoginManagerForm));
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel();
			this.APP_TITLE = new CafeMaster_UI.Interface.CustomLabel();
			this.CLOSE_BUTTON = new System.Windows.Forms.PictureBox();
			this.USERID_VALUE = new System.Windows.Forms.Label();
			this.PWD_VALUE = new System.Windows.Forms.Label();
			this.RESET_AUTOLOGIN_BUTTON = new CafeMaster_UI.Interface.FlatButton();
			this.USERID_TITLE = new System.Windows.Forms.Label();
			this.PWD_TITLE = new System.Windows.Forms.Label();
			this.PROFILE_IMAGE = new System.Windows.Forms.PictureBox();
			this.TIP_LABEL = new System.Windows.Forms.Label();
			this.TIP_IMAGE = new System.Windows.Forms.PictureBox();
			this.DISABLE_AUTOLOGIN_BUTTON = new CafeMaster_UI.Interface.FlatButton();
			this.APP_TITLE_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PROFILE_IMAGE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TIP_IMAGE)).BeginInit();
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
			this.APP_TITLE.Size = new System.Drawing.Size(90, 14);
			this.APP_TITLE.TabIndex = 3;
			this.APP_TITLE.Text = "자동 로그인 설정";
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
			// USERID_VALUE
			// 
			this.USERID_VALUE.BackColor = System.Drawing.Color.Transparent;
			this.USERID_VALUE.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.USERID_VALUE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.USERID_VALUE.Location = new System.Drawing.Point(181, 75);
			this.USERID_VALUE.Name = "USERID_VALUE";
			this.USERID_VALUE.Size = new System.Drawing.Size(402, 20);
			this.USERID_VALUE.TabIndex = 6;
			this.USERID_VALUE.Text = "ACCOUNT ID";
			this.USERID_VALUE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PWD_VALUE
			// 
			this.PWD_VALUE.BackColor = System.Drawing.Color.Transparent;
			this.PWD_VALUE.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.PWD_VALUE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.PWD_VALUE.Location = new System.Drawing.Point(181, 134);
			this.PWD_VALUE.Name = "PWD_VALUE";
			this.PWD_VALUE.Size = new System.Drawing.Size(402, 20);
			this.PWD_VALUE.TabIndex = 7;
			this.PWD_VALUE.Text = "ACCOUNT PWD";
			this.PWD_VALUE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// RESET_AUTOLOGIN_BUTTON
			// 
			this.RESET_AUTOLOGIN_BUTTON.AnimationLerpP = 0.8F;
			this.RESET_AUTOLOGIN_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.RESET_AUTOLOGIN_BUTTON.ButtonText = "자동 로그인 다시 설정";
			this.RESET_AUTOLOGIN_BUTTON.ButtonTextColor = System.Drawing.Color.Black;
			this.RESET_AUTOLOGIN_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.RESET_AUTOLOGIN_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.Silver;
			this.RESET_AUTOLOGIN_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RESET_AUTOLOGIN_BUTTON.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.RESET_AUTOLOGIN_BUTTON.Location = new System.Drawing.Point(403, 190);
			this.RESET_AUTOLOGIN_BUTTON.Name = "RESET_AUTOLOGIN_BUTTON";
			this.RESET_AUTOLOGIN_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.RESET_AUTOLOGIN_BUTTON.Size = new System.Drawing.Size(180, 25);
			this.RESET_AUTOLOGIN_BUTTON.TabIndex = 45;
			this.RESET_AUTOLOGIN_BUTTON.Text = "자동 로그인 다시 설정";
			this.RESET_AUTOLOGIN_BUTTON.UseVisualStyleBackColor = false;
			this.RESET_AUTOLOGIN_BUTTON.Click += new System.EventHandler(this.RESET_AUTOLOGIN_BUTTON_Click);
			// 
			// USERID_TITLE
			// 
			this.USERID_TITLE.AutoSize = true;
			this.USERID_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.USERID_TITLE.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.USERID_TITLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.USERID_TITLE.Location = new System.Drawing.Point(181, 55);
			this.USERID_TITLE.Name = "USERID_TITLE";
			this.USERID_TITLE.Size = new System.Drawing.Size(43, 15);
			this.USERID_TITLE.TabIndex = 46;
			this.USERID_TITLE.Text = "아이디";
			// 
			// PWD_TITLE
			// 
			this.PWD_TITLE.AutoSize = true;
			this.PWD_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.PWD_TITLE.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.PWD_TITLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.PWD_TITLE.Location = new System.Drawing.Point(182, 114);
			this.PWD_TITLE.Name = "PWD_TITLE";
			this.PWD_TITLE.Size = new System.Drawing.Size(31, 15);
			this.PWD_TITLE.TabIndex = 47;
			this.PWD_TITLE.Text = "암호";
			// 
			// PROFILE_IMAGE
			// 
			this.PROFILE_IMAGE.BackColor = System.Drawing.Color.Transparent;
			this.PROFILE_IMAGE.BackgroundImage = global::CafeMaster_UI.Properties.Resources.PROFILE_UNKNOWN_V2_120x120;
			this.PROFILE_IMAGE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PROFILE_IMAGE.Image = global::CafeMaster_UI.Properties.Resources.PROFILE_IMAGE_CIRCLE_160x160;
			this.PROFILE_IMAGE.Location = new System.Drawing.Point(10, 55);
			this.PROFILE_IMAGE.Name = "PROFILE_IMAGE";
			this.PROFILE_IMAGE.Size = new System.Drawing.Size(160, 160);
			this.PROFILE_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PROFILE_IMAGE.TabIndex = 48;
			this.PROFILE_IMAGE.TabStop = false;
			// 
			// TIP_LABEL
			// 
			this.TIP_LABEL.AutoSize = true;
			this.TIP_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.TIP_LABEL.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.TIP_LABEL.ForeColor = System.Drawing.SystemColors.ControlText;
			this.TIP_LABEL.Location = new System.Drawing.Point(40, 231);
			this.TIP_LABEL.Name = "TIP_LABEL";
			this.TIP_LABEL.Size = new System.Drawing.Size(435, 15);
			this.TIP_LABEL.TabIndex = 49;
			this.TIP_LABEL.Text = "귀하의 계정 정보는 로컬 드라이브에 AES-128bit 암호화 처리되어 저장됩니다.";
			// 
			// TIP_IMAGE
			// 
			this.TIP_IMAGE.BackColor = System.Drawing.Color.Transparent;
			this.TIP_IMAGE.Image = global::CafeMaster_UI.Properties.Resources.ADMIN_SHIELD;
			this.TIP_IMAGE.Location = new System.Drawing.Point(10, 228);
			this.TIP_IMAGE.Name = "TIP_IMAGE";
			this.TIP_IMAGE.Size = new System.Drawing.Size(20, 20);
			this.TIP_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.TIP_IMAGE.TabIndex = 50;
			this.TIP_IMAGE.TabStop = false;
			// 
			// DISABLE_AUTOLOGIN_BUTTON
			// 
			this.DISABLE_AUTOLOGIN_BUTTON.AnimationLerpP = 0.8F;
			this.DISABLE_AUTOLOGIN_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.DISABLE_AUTOLOGIN_BUTTON.ButtonText = "자동 로그인 해제";
			this.DISABLE_AUTOLOGIN_BUTTON.ButtonTextColor = System.Drawing.Color.Black;
			this.DISABLE_AUTOLOGIN_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DISABLE_AUTOLOGIN_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.DarkOrange;
			this.DISABLE_AUTOLOGIN_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DISABLE_AUTOLOGIN_BUTTON.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.DISABLE_AUTOLOGIN_BUTTON.Location = new System.Drawing.Point(217, 190);
			this.DISABLE_AUTOLOGIN_BUTTON.Name = "DISABLE_AUTOLOGIN_BUTTON";
			this.DISABLE_AUTOLOGIN_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.Orange;
			this.DISABLE_AUTOLOGIN_BUTTON.Size = new System.Drawing.Size(180, 25);
			this.DISABLE_AUTOLOGIN_BUTTON.TabIndex = 51;
			this.DISABLE_AUTOLOGIN_BUTTON.Text = "자동 로그인 해제";
			this.DISABLE_AUTOLOGIN_BUTTON.UseVisualStyleBackColor = false;
			this.DISABLE_AUTOLOGIN_BUTTON.Click += new System.EventHandler(this.DISABLE_AUTOLOGIN_BUTTON_Click);
			// 
			// AutoLoginManagerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(595, 260);
			this.Controls.Add(this.DISABLE_AUTOLOGIN_BUTTON);
			this.Controls.Add(this.TIP_IMAGE);
			this.Controls.Add(this.TIP_LABEL);
			this.Controls.Add(this.PROFILE_IMAGE);
			this.Controls.Add(this.PWD_TITLE);
			this.Controls.Add(this.USERID_TITLE);
			this.Controls.Add(this.RESET_AUTOLOGIN_BUTTON);
			this.Controls.Add(this.PWD_VALUE);
			this.Controls.Add(this.USERID_VALUE);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AutoLoginManagerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "자동 로그인 설정";
			this.Load += new System.EventHandler(this.AutoLoginManagerForm_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.AutoLoginManagerForm_Paint);
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PROFILE_IMAGE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TIP_IMAGE)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private CustomLabel APP_TITLE;
		private System.Windows.Forms.PictureBox CLOSE_BUTTON;
		private System.Windows.Forms.Label USERID_VALUE;
		private System.Windows.Forms.Label PWD_VALUE;
		private FlatButton RESET_AUTOLOGIN_BUTTON;
		private System.Windows.Forms.Label USERID_TITLE;
		private System.Windows.Forms.Label PWD_TITLE;
		private System.Windows.Forms.PictureBox PROFILE_IMAGE;
		private System.Windows.Forms.Label TIP_LABEL;
		private System.Windows.Forms.PictureBox TIP_IMAGE;
		private FlatButton DISABLE_AUTOLOGIN_BUTTON;
	}
}