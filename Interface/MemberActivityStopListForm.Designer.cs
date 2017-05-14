namespace CafeMaster_UI.Interface
{
	partial class MemberActivityStopListForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberActivityStopListForm));
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel();
			this.APP_TITLE = new CafeMaster_UI.Interface.CustomLabel();
			this.CLOSE_BUTTON = new System.Windows.Forms.PictureBox();
			this.MEMBER_ACTIVITY_STOP_LIST_PANEL = new CafeMaster_UI.Interface.DoubleBufferPanel();
			this.MEMBER_ACTIVITY_STOP_LIST_TITLE = new System.Windows.Forms.Label();
			this.ACTIVITY_STOP_RUN_BUTTON = new CafeMaster_UI.Interface.FlatButton();
			this.DotAnimationTimer = new System.Windows.Forms.Timer(this.components);
			this.LOADING_LABEL = new System.Windows.Forms.Label();
			this.MEMBER_ACTIVITY_STOP_LIST_COUNT_LABEL = new System.Windows.Forms.Label();
			this.APP_TITLE_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).BeginInit();
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
			this.APP_TITLE.Text = "활동 정지";
			this.APP_TITLE.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
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
			// MEMBER_ACTIVITY_STOP_LIST_PANEL
			// 
			this.MEMBER_ACTIVITY_STOP_LIST_PANEL.AutoScroll = true;
			this.MEMBER_ACTIVITY_STOP_LIST_PANEL.BackColor = System.Drawing.Color.Transparent;
			this.MEMBER_ACTIVITY_STOP_LIST_PANEL.Location = new System.Drawing.Point(10, 77);
			this.MEMBER_ACTIVITY_STOP_LIST_PANEL.Name = "MEMBER_ACTIVITY_STOP_LIST_PANEL";
			this.MEMBER_ACTIVITY_STOP_LIST_PANEL.Size = new System.Drawing.Size(580, 470);
			this.MEMBER_ACTIVITY_STOP_LIST_PANEL.TabIndex = 21;
			// 
			// MEMBER_ACTIVITY_STOP_LIST_TITLE
			// 
			this.MEMBER_ACTIVITY_STOP_LIST_TITLE.AutoSize = true;
			this.MEMBER_ACTIVITY_STOP_LIST_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.MEMBER_ACTIVITY_STOP_LIST_TITLE.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.MEMBER_ACTIVITY_STOP_LIST_TITLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.MEMBER_ACTIVITY_STOP_LIST_TITLE.Location = new System.Drawing.Point(7, 54);
			this.MEMBER_ACTIVITY_STOP_LIST_TITLE.Name = "MEMBER_ACTIVITY_STOP_LIST_TITLE";
			this.MEMBER_ACTIVITY_STOP_LIST_TITLE.Size = new System.Drawing.Size(90, 14);
			this.MEMBER_ACTIVITY_STOP_LIST_TITLE.TabIndex = 22;
			this.MEMBER_ACTIVITY_STOP_LIST_TITLE.Text = "활동 정지된 회원";
			// 
			// ACTIVITY_STOP_RUN_BUTTON
			// 
			this.ACTIVITY_STOP_RUN_BUTTON.AnimationLerpP = 0.8F;
			this.ACTIVITY_STOP_RUN_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.ACTIVITY_STOP_RUN_BUTTON.ButtonText = "활동 정지 추가";
			this.ACTIVITY_STOP_RUN_BUTTON.ButtonTextColor = System.Drawing.Color.White;
			this.ACTIVITY_STOP_RUN_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ACTIVITY_STOP_RUN_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.Red;
			this.ACTIVITY_STOP_RUN_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ACTIVITY_STOP_RUN_BUTTON.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.ACTIVITY_STOP_RUN_BUTTON.Location = new System.Drawing.Point(10, 553);
			this.ACTIVITY_STOP_RUN_BUTTON.Name = "ACTIVITY_STOP_RUN_BUTTON";
			this.ACTIVITY_STOP_RUN_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.Crimson;
			this.ACTIVITY_STOP_RUN_BUTTON.Size = new System.Drawing.Size(195, 35);
			this.ACTIVITY_STOP_RUN_BUTTON.TabIndex = 23;
			this.ACTIVITY_STOP_RUN_BUTTON.Text = "활동 정지 추가";
			this.ACTIVITY_STOP_RUN_BUTTON.UseVisualStyleBackColor = false;
			this.ACTIVITY_STOP_RUN_BUTTON.Click += new System.EventHandler(this.ACTIVITY_STOP_RUN_BUTTON_Click);
			// 
			// DotAnimationTimer
			// 
			this.DotAnimationTimer.Tick += new System.EventHandler(this.DotAnimationTimer_Tick);
			// 
			// LOADING_LABEL
			// 
			this.LOADING_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.LOADING_LABEL.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.LOADING_LABEL.ForeColor = System.Drawing.SystemColors.ControlText;
			this.LOADING_LABEL.Location = new System.Drawing.Point(11, 300);
			this.LOADING_LABEL.Name = "LOADING_LABEL";
			this.LOADING_LABEL.Size = new System.Drawing.Size(578, 20);
			this.LOADING_LABEL.TabIndex = 6;
			this.LOADING_LABEL.Text = "서버에서 데이터를 불러오는 중 ";
			this.LOADING_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.LOADING_LABEL.Visible = false;
			// 
			// MEMBER_ACTIVITY_STOP_LIST_COUNT_LABEL
			// 
			this.MEMBER_ACTIVITY_STOP_LIST_COUNT_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.MEMBER_ACTIVITY_STOP_LIST_COUNT_LABEL.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.MEMBER_ACTIVITY_STOP_LIST_COUNT_LABEL.ForeColor = System.Drawing.SystemColors.ControlText;
			this.MEMBER_ACTIVITY_STOP_LIST_COUNT_LABEL.Location = new System.Drawing.Point(234, 54);
			this.MEMBER_ACTIVITY_STOP_LIST_COUNT_LABEL.Name = "MEMBER_ACTIVITY_STOP_LIST_COUNT_LABEL";
			this.MEMBER_ACTIVITY_STOP_LIST_COUNT_LABEL.Size = new System.Drawing.Size(356, 14);
			this.MEMBER_ACTIVITY_STOP_LIST_COUNT_LABEL.TabIndex = 24;
			this.MEMBER_ACTIVITY_STOP_LIST_COUNT_LABEL.Text = "0명의 활동 정지된 회원이 있습니다.";
			this.MEMBER_ACTIVITY_STOP_LIST_COUNT_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MemberActivityStopListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(600, 600);
			this.Controls.Add(this.MEMBER_ACTIVITY_STOP_LIST_COUNT_LABEL);
			this.Controls.Add(this.LOADING_LABEL);
			this.Controls.Add(this.ACTIVITY_STOP_RUN_BUTTON);
			this.Controls.Add(this.MEMBER_ACTIVITY_STOP_LIST_TITLE);
			this.Controls.Add(this.MEMBER_ACTIVITY_STOP_LIST_PANEL);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MemberActivityStopListForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "활동 정지";
			this.Load += new System.EventHandler(this.UserWarnOptionForm_Load);
			this.Shown += new System.EventHandler(this.MemberActivityStopListForm_Shown);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserWarnOptionForm_Paint);
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private CustomLabel APP_TITLE;
		private System.Windows.Forms.PictureBox CLOSE_BUTTON;
		private DoubleBufferPanel MEMBER_ACTIVITY_STOP_LIST_PANEL;
		private System.Windows.Forms.Label MEMBER_ACTIVITY_STOP_LIST_TITLE;
		private FlatButton ACTIVITY_STOP_RUN_BUTTON;
		private System.Windows.Forms.Timer DotAnimationTimer;
		private System.Windows.Forms.Label LOADING_LABEL;
		private System.Windows.Forms.Label MEMBER_ACTIVITY_STOP_LIST_COUNT_LABEL;
	}
}