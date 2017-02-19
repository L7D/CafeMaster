namespace CafeMaster_UI.Interface
{
	partial class ProgramAuthForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramAuthForm));
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel();
			this.APP_TITLE = new System.Windows.Forms.Label();
			this.CLOSE_BUTTON = new System.Windows.Forms.PictureBox();
			this.PASSCODE_TEXTBOX = new System.Windows.Forms.TextBox();
			this.PASSCODE_LABEL = new System.Windows.Forms.Label();
			this.NOTIFY_MESSAGE = new System.Windows.Forms.Label();
			this.VERSION_LABEL = new System.Windows.Forms.Label();
			this.USER_AUTH_BUTTON = new CafeMaster_UI.Interface.FlatButton();
			this.PROGRAM_LOGO = new System.Windows.Forms.PictureBox();
			this.APP_TITLE_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PROGRAM_LOGO)).BeginInit();
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
			this.APP_TITLE_BAR.Size = new System.Drawing.Size(500, 45);
			this.APP_TITLE_BAR.TabIndex = 2;
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
			this.APP_TITLE.Size = new System.Drawing.Size(159, 14);
			this.APP_TITLE.TabIndex = 3;
			this.APP_TITLE.Text = "우윳빛깔 카페스탭 사용자 인증";
			// 
			// CLOSE_BUTTON
			// 
			this.CLOSE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.CLOSE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CLOSE_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.CLOSE;
			this.CLOSE_BUTTON.Location = new System.Drawing.Point(465, 10);
			this.CLOSE_BUTTON.Name = "CLOSE_BUTTON";
			this.CLOSE_BUTTON.Size = new System.Drawing.Size(25, 25);
			this.CLOSE_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.CLOSE_BUTTON.TabIndex = 4;
			this.CLOSE_BUTTON.TabStop = false;
			this.CLOSE_BUTTON.Click += new System.EventHandler(this.CLOSE_BUTTON_Click);
			// 
			// PASSCODE_TEXTBOX
			// 
			this.PASSCODE_TEXTBOX.BackColor = System.Drawing.Color.White;
			this.PASSCODE_TEXTBOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PASSCODE_TEXTBOX.Font = new System.Drawing.Font("나눔고딕", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.PASSCODE_TEXTBOX.Location = new System.Drawing.Point(25, 201);
			this.PASSCODE_TEXTBOX.Name = "PASSCODE_TEXTBOX";
			this.PASSCODE_TEXTBOX.PasswordChar = '*';
			this.PASSCODE_TEXTBOX.Size = new System.Drawing.Size(450, 20);
			this.PASSCODE_TEXTBOX.TabIndex = 4;
			this.PASSCODE_TEXTBOX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PASSCODE_TEXTBOX_KeyPress);
			// 
			// PASSCODE_LABEL
			// 
			this.PASSCODE_LABEL.AutoSize = true;
			this.PASSCODE_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.PASSCODE_LABEL.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.PASSCODE_LABEL.ForeColor = System.Drawing.SystemColors.ControlText;
			this.PASSCODE_LABEL.Location = new System.Drawing.Point(22, 173);
			this.PASSCODE_LABEL.Name = "PASSCODE_LABEL";
			this.PASSCODE_LABEL.Size = new System.Drawing.Size(54, 14);
			this.PASSCODE_LABEL.TabIndex = 5;
			this.PASSCODE_LABEL.Text = "인증 코드";
			// 
			// NOTIFY_MESSAGE
			// 
			this.NOTIFY_MESSAGE.AutoSize = true;
			this.NOTIFY_MESSAGE.BackColor = System.Drawing.Color.Transparent;
			this.NOTIFY_MESSAGE.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.NOTIFY_MESSAGE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.NOTIFY_MESSAGE.Location = new System.Drawing.Point(22, 238);
			this.NOTIFY_MESSAGE.Name = "NOTIFY_MESSAGE";
			this.NOTIFY_MESSAGE.Size = new System.Drawing.Size(243, 14);
			this.NOTIFY_MESSAGE.TabIndex = 7;
			this.NOTIFY_MESSAGE.Text = "프로그램을 사용하기 위해서 인증이 필요합니다.";
			this.NOTIFY_MESSAGE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// VERSION_LABEL
			// 
			this.VERSION_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.VERSION_LABEL.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.VERSION_LABEL.ForeColor = System.Drawing.SystemColors.ControlText;
			this.VERSION_LABEL.Location = new System.Drawing.Point(12, 277);
			this.VERSION_LABEL.Name = "VERSION_LABEL";
			this.VERSION_LABEL.Size = new System.Drawing.Size(463, 14);
			this.VERSION_LABEL.TabIndex = 8;
			this.VERSION_LABEL.Text = "버전 1.0.0.0";
			// 
			// USER_AUTH_BUTTON
			// 
			this.USER_AUTH_BUTTON.AnimationLerpP = 0.8F;
			this.USER_AUTH_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.USER_AUTH_BUTTON.ButtonText = "사용자 인증 >";
			this.USER_AUTH_BUTTON.ButtonTextColor = System.Drawing.Color.Black;
			this.USER_AUTH_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.USER_AUTH_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.USER_AUTH_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.USER_AUTH_BUTTON.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.USER_AUTH_BUTTON.Location = new System.Drawing.Point(345, 230);
			this.USER_AUTH_BUTTON.Name = "USER_AUTH_BUTTON";
			this.USER_AUTH_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.USER_AUTH_BUTTON.Size = new System.Drawing.Size(130, 30);
			this.USER_AUTH_BUTTON.TabIndex = 6;
			this.USER_AUTH_BUTTON.Text = "사용자 인증 >";
			this.USER_AUTH_BUTTON.UseVisualStyleBackColor = false;
			this.USER_AUTH_BUTTON.Click += new System.EventHandler(this.USER_AUTH_BUTTON_Click);
			// 
			// PROGRAM_LOGO
			// 
			this.PROGRAM_LOGO.BackColor = System.Drawing.Color.Transparent;
			this.PROGRAM_LOGO.Image = global::CafeMaster_UI.Properties.Resources.PROGRAM_LOGO;
			this.PROGRAM_LOGO.Location = new System.Drawing.Point(25, 55);
			this.PROGRAM_LOGO.Name = "PROGRAM_LOGO";
			this.PROGRAM_LOGO.Size = new System.Drawing.Size(450, 100);
			this.PROGRAM_LOGO.TabIndex = 3;
			this.PROGRAM_LOGO.TabStop = false;
			// 
			// ProgramAuthForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(500, 300);
			this.Controls.Add(this.VERSION_LABEL);
			this.Controls.Add(this.NOTIFY_MESSAGE);
			this.Controls.Add(this.USER_AUTH_BUTTON);
			this.Controls.Add(this.PASSCODE_LABEL);
			this.Controls.Add(this.PASSCODE_TEXTBOX);
			this.Controls.Add(this.PROGRAM_LOGO);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ProgramAuthForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "우윳빛깔 카페스탭";
			this.Load += new System.EventHandler(this.ProgramAuthForm_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.ProgramAuthForm_Paint);
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PROGRAM_LOGO)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private System.Windows.Forms.Label APP_TITLE;
		private System.Windows.Forms.PictureBox CLOSE_BUTTON;
		private System.Windows.Forms.PictureBox PROGRAM_LOGO;
		private System.Windows.Forms.TextBox PASSCODE_TEXTBOX;
		private System.Windows.Forms.Label PASSCODE_LABEL;
		private FlatButton USER_AUTH_BUTTON;
		private System.Windows.Forms.Label NOTIFY_MESSAGE;
		private System.Windows.Forms.Label VERSION_LABEL;
	}
}