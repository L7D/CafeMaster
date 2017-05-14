namespace CafeMaster_UI.Interface
{
	partial class NotifyBoxInterface
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifyBoxInterface));
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel();
			this.TITLE_LABEL = new CafeMaster_UI.Interface.CustomLabel();
			this.MESSAGE_LABEL = new System.Windows.Forms.Label();
			this.TYPE_ICON = new System.Windows.Forms.PictureBox();
			this.centerNotifyImageBox = new System.Windows.Forms.PictureBox();
			this.OK_Button = new CafeMaster_UI.Interface.FlatButton();
			this.NO_Button = new CafeMaster_UI.Interface.FlatButton();
			this.Yes_Button = new CafeMaster_UI.Interface.FlatButton();
			this.COPY_TEXT_BUTTON = new System.Windows.Forms.PictureBox();
			this.TOOL_TIP = new System.Windows.Forms.ToolTip(this.components);
			this.APP_TITLE_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TYPE_ICON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.centerNotifyImageBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.COPY_TEXT_BUTTON)).BeginInit();
			this.SuspendLayout();
			// 
			// APP_TITLE_BAR
			// 
			this.APP_TITLE_BAR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.APP_TITLE_BAR.BackColor = System.Drawing.Color.White;
			this.APP_TITLE_BAR.Controls.Add(this.TITLE_LABEL);
			this.APP_TITLE_BAR.Location = new System.Drawing.Point(0, 0);
			this.APP_TITLE_BAR.Name = "APP_TITLE_BAR";
			this.APP_TITLE_BAR.Size = new System.Drawing.Size(600, 45);
			this.APP_TITLE_BAR.TabIndex = 10;
			this.APP_TITLE_BAR.Paint += new System.Windows.Forms.PaintEventHandler(this.APP_TITLE_BAR_Paint);
			this.APP_TITLE_BAR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseDown);
			this.APP_TITLE_BAR.MouseMove += new System.Windows.Forms.MouseEventHandler(this.APP_TITLE_BAR_MouseMove);
			// 
			// TITLE_LABEL
			// 
			this.TITLE_LABEL.AutoSize = true;
			this.TITLE_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.TITLE_LABEL.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.TITLE_LABEL.Location = new System.Drawing.Point(10, 16);
			this.TITLE_LABEL.Name = "TITLE_LABEL";
			this.TITLE_LABEL.Size = new System.Drawing.Size(29, 14);
			this.TITLE_LABEL.TabIndex = 0;
			this.TITLE_LABEL.Text = "안내";
			this.TITLE_LABEL.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			// 
			// MESSAGE_LABEL
			// 
			this.MESSAGE_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.MESSAGE_LABEL.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.MESSAGE_LABEL.Location = new System.Drawing.Point(86, 50);
			this.MESSAGE_LABEL.Name = "MESSAGE_LABEL";
			this.MESSAGE_LABEL.Size = new System.Drawing.Size(500, 105);
			this.MESSAGE_LABEL.TabIndex = 11;
			this.MESSAGE_LABEL.Text = "메세지";
			this.MESSAGE_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TYPE_ICON
			// 
			this.TYPE_ICON.BackColor = System.Drawing.Color.Transparent;
			this.TYPE_ICON.Image = global::CafeMaster_UI.Properties.Resources.WARNING_ICON;
			this.TYPE_ICON.Location = new System.Drawing.Point(20, 75);
			this.TYPE_ICON.Name = "TYPE_ICON";
			this.TYPE_ICON.Size = new System.Drawing.Size(50, 50);
			this.TYPE_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.TYPE_ICON.TabIndex = 15;
			this.TYPE_ICON.TabStop = false;
			// 
			// centerNotifyImageBox
			// 
			this.centerNotifyImageBox.BackColor = System.Drawing.Color.Transparent;
			this.centerNotifyImageBox.Location = new System.Drawing.Point(1, 1);
			this.centerNotifyImageBox.Name = "centerNotifyImageBox";
			this.centerNotifyImageBox.Size = new System.Drawing.Size(598, 198);
			this.centerNotifyImageBox.TabIndex = 19;
			this.centerNotifyImageBox.TabStop = false;
			// 
			// OK_Button
			// 
			this.OK_Button.AnimationLerpP = 0.8F;
			this.OK_Button.BackColor = System.Drawing.Color.Transparent;
			this.OK_Button.ButtonText = "확인";
			this.OK_Button.ButtonTextColor = System.Drawing.Color.Black;
			this.OK_Button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.OK_Button.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.OK_Button.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.OK_Button.Location = new System.Drawing.Point(382, 158);
			this.OK_Button.Name = "OK_Button";
			this.OK_Button.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.OK_Button.Size = new System.Drawing.Size(206, 30);
			this.OK_Button.TabIndex = 18;
			this.OK_Button.TabStop = false;
			this.OK_Button.Text = "확인";
			this.OK_Button.UseVisualStyleBackColor = false;
			this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
			// 
			// NO_Button
			// 
			this.NO_Button.AnimationLerpP = 0.8F;
			this.NO_Button.BackColor = System.Drawing.Color.Transparent;
			this.NO_Button.ButtonText = "취소";
			this.NO_Button.ButtonTextColor = System.Drawing.Color.Black;
			this.NO_Button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NO_Button.EnterStateBackgroundColor = System.Drawing.Color.Gainsboro;
			this.NO_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.NO_Button.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.NO_Button.Location = new System.Drawing.Point(488, 158);
			this.NO_Button.Name = "NO_Button";
			this.NO_Button.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.NO_Button.Size = new System.Drawing.Size(100, 30);
			this.NO_Button.TabIndex = 17;
			this.NO_Button.TabStop = false;
			this.NO_Button.Text = "취소";
			this.NO_Button.UseVisualStyleBackColor = false;
			this.NO_Button.Click += new System.EventHandler(this.NO_Button_Click);
			// 
			// Yes_Button
			// 
			this.Yes_Button.AnimationLerpP = 0.8F;
			this.Yes_Button.BackColor = System.Drawing.Color.Transparent;
			this.Yes_Button.ButtonText = "확인";
			this.Yes_Button.ButtonTextColor = System.Drawing.Color.White;
			this.Yes_Button.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Yes_Button.EnterStateBackgroundColor = System.Drawing.Color.Red;
			this.Yes_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Yes_Button.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Yes_Button.Location = new System.Drawing.Point(382, 158);
			this.Yes_Button.Name = "Yes_Button";
			this.Yes_Button.NormalStateBackgroundColor = System.Drawing.Color.Crimson;
			this.Yes_Button.Size = new System.Drawing.Size(100, 30);
			this.Yes_Button.TabIndex = 16;
			this.Yes_Button.TabStop = false;
			this.Yes_Button.Text = "확인";
			this.Yes_Button.UseVisualStyleBackColor = false;
			this.Yes_Button.Click += new System.EventHandler(this.Yes_Button_Click);
			// 
			// COPY_TEXT_BUTTON
			// 
			this.COPY_TEXT_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.COPY_TEXT_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.COPY_TEXT_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.CLIPBOARD;
			this.COPY_TEXT_BUTTON.Location = new System.Drawing.Point(12, 173);
			this.COPY_TEXT_BUTTON.Name = "COPY_TEXT_BUTTON";
			this.COPY_TEXT_BUTTON.Size = new System.Drawing.Size(15, 15);
			this.COPY_TEXT_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.COPY_TEXT_BUTTON.TabIndex = 20;
			this.COPY_TEXT_BUTTON.TabStop = false;
			this.TOOL_TIP.SetToolTip(this.COPY_TEXT_BUTTON, "텍스트를 클립보드에 복사합니다.");
			this.COPY_TEXT_BUTTON.Click += new System.EventHandler(this.COPY_TEXT_BUTTON_Click);
			// 
			// NotifyBoxInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(600, 200);
			this.Controls.Add(this.COPY_TEXT_BUTTON);
			this.Controls.Add(this.OK_Button);
			this.Controls.Add(this.NO_Button);
			this.Controls.Add(this.Yes_Button);
			this.Controls.Add(this.TYPE_ICON);
			this.Controls.Add(this.MESSAGE_LABEL);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.Controls.Add(this.centerNotifyImageBox);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "NotifyBoxInterface";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "우윳빛깔 카페스탭";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.NotifyBoxInterface_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.NotifyBoxInterface_Paint);
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TYPE_ICON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.centerNotifyImageBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.COPY_TEXT_BUTTON)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private System.Windows.Forms.Label MESSAGE_LABEL;
		private System.Windows.Forms.PictureBox TYPE_ICON;
		private CustomLabel TITLE_LABEL;
		private FlatButton Yes_Button;
		private FlatButton NO_Button;
		private FlatButton OK_Button;
		private System.Windows.Forms.PictureBox centerNotifyImageBox;
		private System.Windows.Forms.PictureBox COPY_TEXT_BUTTON;
		private System.Windows.Forms.ToolTip TOOL_TIP;
	}
}