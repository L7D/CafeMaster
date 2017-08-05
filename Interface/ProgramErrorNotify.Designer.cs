namespace CafeMaster_UI.Interface
{
	partial class ProgramErrorNotify
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramErrorNotify));
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel();
			this.APP_TITLE = new CafeMaster_UI.Interface.CustomLabel();
			this.CLOSE_BUTTON = new System.Windows.Forms.PictureBox();
			this.ERROR_LIST = new System.Windows.Forms.Panel();
			this.TITLE_1_LABEL = new System.Windows.Forms.Label();
			this.ERROR_ICON = new System.Windows.Forms.PictureBox();
			this.TITLE_2_LABEL = new System.Windows.Forms.Label();
			this.APP_TITLE_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ERROR_ICON)).BeginInit();
			this.SuspendLayout();
			// 
			// APP_TITLE_BAR
			// 
			this.APP_TITLE_BAR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.APP_TITLE_BAR.BackColor = System.Drawing.Color.White;
			this.APP_TITLE_BAR.Controls.Add(this.APP_TITLE);
			this.APP_TITLE_BAR.Controls.Add(this.CLOSE_BUTTON);
			this.APP_TITLE_BAR.Cursor = System.Windows.Forms.Cursors.Default;
			this.APP_TITLE_BAR.Location = new System.Drawing.Point(0, 0);
			this.APP_TITLE_BAR.Name = "APP_TITLE_BAR";
			this.APP_TITLE_BAR.Size = new System.Drawing.Size(800, 45);
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
			this.APP_TITLE.Size = new System.Drawing.Size(148, 14);
			this.APP_TITLE.TabIndex = 3;
			this.APP_TITLE.Text = "처리되지 않은 프로그램 오류";
			this.APP_TITLE.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			// 
			// CLOSE_BUTTON
			// 
			this.CLOSE_BUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CLOSE_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.CLOSE_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CLOSE_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.CLOSE;
			this.CLOSE_BUTTON.Location = new System.Drawing.Point(765, 10);
			this.CLOSE_BUTTON.Name = "CLOSE_BUTTON";
			this.CLOSE_BUTTON.Size = new System.Drawing.Size(25, 25);
			this.CLOSE_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.CLOSE_BUTTON.TabIndex = 4;
			this.CLOSE_BUTTON.TabStop = false;
			this.CLOSE_BUTTON.Click += new System.EventHandler(this.CLOSE_BUTTON_Click);
			// 
			// ERROR_LIST
			// 
			this.ERROR_LIST.AutoScroll = true;
			this.ERROR_LIST.Location = new System.Drawing.Point(12, 116);
			this.ERROR_LIST.Name = "ERROR_LIST";
			this.ERROR_LIST.Size = new System.Drawing.Size(778, 572);
			this.ERROR_LIST.TabIndex = 3;
			// 
			// TITLE_1_LABEL
			// 
			this.TITLE_1_LABEL.AutoSize = true;
			this.TITLE_1_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.TITLE_1_LABEL.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.TITLE_1_LABEL.ForeColor = System.Drawing.SystemColors.ControlText;
			this.TITLE_1_LABEL.Location = new System.Drawing.Point(69, 59);
			this.TITLE_1_LABEL.Name = "TITLE_1_LABEL";
			this.TITLE_1_LABEL.Size = new System.Drawing.Size(369, 17);
			this.TITLE_1_LABEL.TabIndex = 24;
			this.TITLE_1_LABEL.Text = "응용 프로그램에서 처리되지 않은 예외가 발생하였습니다.";
			// 
			// ERROR_ICON
			// 
			this.ERROR_ICON.BackColor = System.Drawing.Color.Transparent;
			this.ERROR_ICON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ERROR_ICON.Image = global::CafeMaster_UI.Properties.Resources.ERROR_ICON;
			this.ERROR_ICON.Location = new System.Drawing.Point(13, 54);
			this.ERROR_ICON.Name = "ERROR_ICON";
			this.ERROR_ICON.Size = new System.Drawing.Size(50, 50);
			this.ERROR_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ERROR_ICON.TabIndex = 25;
			this.ERROR_ICON.TabStop = false;
			// 
			// TITLE_2_LABEL
			// 
			this.TITLE_2_LABEL.AutoSize = true;
			this.TITLE_2_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.TITLE_2_LABEL.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.TITLE_2_LABEL.ForeColor = System.Drawing.SystemColors.ControlText;
			this.TITLE_2_LABEL.Location = new System.Drawing.Point(70, 86);
			this.TITLE_2_LABEL.Name = "TITLE_2_LABEL";
			this.TITLE_2_LABEL.Size = new System.Drawing.Size(687, 14);
			this.TITLE_2_LABEL.TabIndex = 26;
			this.TITLE_2_LABEL.Text = "프로그램의 심각한 오류는 카페로 제보해주세요, 오류 정보 복사 버튼을 눌러 자세한 정보를 첨부해주시거나 증상을 말씀해주시면 좋습니다.";
			// 
			// ProgramErrorNotify
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 700);
			this.Controls.Add(this.TITLE_2_LABEL);
			this.Controls.Add(this.ERROR_ICON);
			this.Controls.Add(this.TITLE_1_LABEL);
			this.Controls.Add(this.ERROR_LIST);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ProgramErrorNotify";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "프로그램 오류";
			this.Load += new System.EventHandler(this.ProgramErrorNotify_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.ProgramErrorNotify_Paint);
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ERROR_ICON)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private CustomLabel APP_TITLE;
		private System.Windows.Forms.PictureBox CLOSE_BUTTON;
		private System.Windows.Forms.Panel ERROR_LIST;
		private System.Windows.Forms.Label TITLE_1_LABEL;
		private System.Windows.Forms.PictureBox ERROR_ICON;
		private System.Windows.Forms.Label TITLE_2_LABEL;
	}
}