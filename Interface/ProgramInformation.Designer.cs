namespace CafeMaster_UI.Interface
{
	partial class ProgramInformation
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramInformation));
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel();
			this.APP_TITLE = new CustomLabel( );
			this.CLOSE_BUTTON = new System.Windows.Forms.PictureBox();
			this.TITLE = new System.Windows.Forms.Label();
			this.TITLE_ENG = new System.Windows.Forms.Label();
			this.VERSION = new System.Windows.Forms.Label();
			this.LOGO = new System.Windows.Forms.PictureBox();
			this.COPYRIGHT = new System.Windows.Forms.Label();
			this.UTIL_BUTTON1 = new CafeMaster_UI.Interface.FlatButton();
			this.COPYRIGHT_2 = new System.Windows.Forms.Label();
			this.APP_TITLE_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LOGO)).BeginInit();
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
			this.APP_TITLE_BAR.Size = new System.Drawing.Size(480, 45);
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
			this.APP_TITLE.Size = new System.Drawing.Size(123, 14);
			this.APP_TITLE.TabIndex = 3;
			this.APP_TITLE.Text = "우윳빛깔 카페스탭 정보";
			// 
			// CLOSE_BUTTON
			// 
			this.CLOSE_BUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CLOSE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.CLOSE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CLOSE_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.CLOSE;
			this.CLOSE_BUTTON.Location = new System.Drawing.Point(445, 10);
			this.CLOSE_BUTTON.Name = "CLOSE_BUTTON";
			this.CLOSE_BUTTON.Size = new System.Drawing.Size(25, 25);
			this.CLOSE_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.CLOSE_BUTTON.TabIndex = 4;
			this.CLOSE_BUTTON.TabStop = false;
			this.CLOSE_BUTTON.Click += new System.EventHandler(this.CLOSE_BUTTON_Click);
			// 
			// TITLE
			// 
			this.TITLE.AutoSize = true;
			this.TITLE.BackColor = System.Drawing.Color.Transparent;
			this.TITLE.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.TITLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.TITLE.Location = new System.Drawing.Point(180, 60);
			this.TITLE.Name = "TITLE";
			this.TITLE.Size = new System.Drawing.Size(159, 21);
			this.TITLE.TabIndex = 4;
			this.TITLE.Text = "우윳빛깔 카페스탭";
			// 
			// TITLE_ENG
			// 
			this.TITLE_ENG.AutoSize = true;
			this.TITLE_ENG.BackColor = System.Drawing.Color.Transparent;
			this.TITLE_ENG.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.TITLE_ENG.ForeColor = System.Drawing.SystemColors.ControlText;
			this.TITLE_ENG.Location = new System.Drawing.Point(181, 86);
			this.TITLE_ENG.Name = "TITLE_ENG";
			this.TITLE_ENG.Size = new System.Drawing.Size(141, 15);
			this.TITLE_ENG.TabIndex = 5;
			this.TITLE_ENG.Text = "Milk Power Cafe Staff";
			// 
			// VERSION
			// 
			this.VERSION.BackColor = System.Drawing.Color.Transparent;
			this.VERSION.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.VERSION.ForeColor = System.Drawing.SystemColors.ControlText;
			this.VERSION.Location = new System.Drawing.Point(183, 195);
			this.VERSION.Name = "VERSION";
			this.VERSION.Size = new System.Drawing.Size(287, 15);
			this.VERSION.TabIndex = 6;
			this.VERSION.Text = "버전 1.0.0.0";
			this.VERSION.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LOGO
			// 
			this.LOGO.BackColor = System.Drawing.Color.Transparent;
			this.LOGO.Image = global::CafeMaster_UI.Properties.Resources.PROGRAM_ICON_150x150;
			this.LOGO.Location = new System.Drawing.Point(15, 60);
			this.LOGO.Name = "LOGO";
			this.LOGO.Size = new System.Drawing.Size(150, 150);
			this.LOGO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.LOGO.TabIndex = 3;
			this.LOGO.TabStop = false;
			// 
			// COPYRIGHT
			// 
			this.COPYRIGHT.AutoSize = true;
			this.COPYRIGHT.BackColor = System.Drawing.Color.Transparent;
			this.COPYRIGHT.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.COPYRIGHT.ForeColor = System.Drawing.SystemColors.ControlText;
			this.COPYRIGHT.Location = new System.Drawing.Point(12, 226);
			this.COPYRIGHT.Name = "COPYRIGHT";
			this.COPYRIGHT.Size = new System.Drawing.Size(247, 14);
			this.COPYRIGHT.TabIndex = 7;
			this.COPYRIGHT.Text = "Copyright © \'DeveloFOX Studio - L7D\' 2017";
			this.COPYRIGHT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// UTIL_BUTTON1
			// 
			this.UTIL_BUTTON1.AnimationLerpP = 0.8F;
			this.UTIL_BUTTON1.BackColor = System.Drawing.Color.Transparent;
			this.UTIL_BUTTON1.ButtonText = "카페혁명 우윳빛깔 232";
			this.UTIL_BUTTON1.ButtonTextColor = System.Drawing.Color.Black;
			this.UTIL_BUTTON1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.UTIL_BUTTON1.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.UTIL_BUTTON1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UTIL_BUTTON1.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.UTIL_BUTTON1.Location = new System.Drawing.Point(280, 223);
			this.UTIL_BUTTON1.Name = "UTIL_BUTTON1";
			this.UTIL_BUTTON1.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.UTIL_BUTTON1.Size = new System.Drawing.Size(188, 21);
			this.UTIL_BUTTON1.TabIndex = 36;
			this.UTIL_BUTTON1.Text = "카페혁명 우윳빛깔 232";
			this.UTIL_BUTTON1.UseVisualStyleBackColor = false;
			this.UTIL_BUTTON1.Click += new System.EventHandler(this.UTIL_BUTTON1_Click);
			// 
			// COPYRIGHT_2
			// 
			this.COPYRIGHT_2.BackColor = System.Drawing.Color.Transparent;
			this.COPYRIGHT_2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.COPYRIGHT_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.COPYRIGHT_2.Location = new System.Drawing.Point(183, 175);
			this.COPYRIGHT_2.Name = "COPYRIGHT_2";
			this.COPYRIGHT_2.Size = new System.Drawing.Size(287, 15);
			this.COPYRIGHT_2.TabIndex = 37;
			this.COPYRIGHT_2.Text = "자이 ...";
			this.COPYRIGHT_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ProgramInformation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(480, 250);
			this.Controls.Add(this.COPYRIGHT_2);
			this.Controls.Add(this.UTIL_BUTTON1);
			this.Controls.Add(this.COPYRIGHT);
			this.Controls.Add(this.VERSION);
			this.Controls.Add(this.TITLE_ENG);
			this.Controls.Add(this.TITLE);
			this.Controls.Add(this.LOGO);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ProgramInformation";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "우윳빛깔 카페스탭";
			this.Load += new System.EventHandler(this.ProgramInformation_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.ProgramInformation_Paint);
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LOGO)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private CustomLabel APP_TITLE;
		private System.Windows.Forms.PictureBox CLOSE_BUTTON;
		private System.Windows.Forms.PictureBox LOGO;
		private System.Windows.Forms.Label TITLE;
		private System.Windows.Forms.Label TITLE_ENG;
		private System.Windows.Forms.Label VERSION;
		private System.Windows.Forms.Label COPYRIGHT;
		private FlatButton UTIL_BUTTON1;
		private System.Windows.Forms.Label COPYRIGHT_2;
	}
}