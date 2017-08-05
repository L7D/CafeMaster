namespace CafeMaster_UI.Interface
{
	partial class ProgramErrorListChild
	{
		/// <summary> 
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region 구성 요소 디자이너에서 생성한 코드

		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent( )
		{
			this.ERROR_TITLE = new System.Windows.Forms.Label();
			this.ERROR_STACK = new System.Windows.Forms.Label();
			this.ERROR_ICON = new System.Windows.Forms.PictureBox();
			this.ERROR_CODE = new System.Windows.Forms.Label();
			this.COPY_TEXT_BUTTON = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.ERROR_ICON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.COPY_TEXT_BUTTON)).BeginInit();
			this.SuspendLayout();
			// 
			// ERROR_TITLE
			// 
			this.ERROR_TITLE.AutoEllipsis = true;
			this.ERROR_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.ERROR_TITLE.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.ERROR_TITLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.ERROR_TITLE.Location = new System.Drawing.Point(59, 3);
			this.ERROR_TITLE.Name = "ERROR_TITLE";
			this.ERROR_TITLE.Size = new System.Drawing.Size(492, 20);
			this.ERROR_TITLE.TabIndex = 56;
			this.ERROR_TITLE.Text = "전체 0개 중 0개 선택함";
			this.ERROR_TITLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ERROR_STACK
			// 
			this.ERROR_STACK.AutoEllipsis = true;
			this.ERROR_STACK.AutoSize = true;
			this.ERROR_STACK.BackColor = System.Drawing.Color.Transparent;
			this.ERROR_STACK.Font = new System.Drawing.Font("나눔고딕", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.ERROR_STACK.ForeColor = System.Drawing.SystemColors.ControlText;
			this.ERROR_STACK.Location = new System.Drawing.Point(60, 29);
			this.ERROR_STACK.Name = "ERROR_STACK";
			this.ERROR_STACK.Size = new System.Drawing.Size(113, 13);
			this.ERROR_STACK.TabIndex = 57;
			this.ERROR_STACK.Text = "전체 0개 중 0개 선택함";
			// 
			// ERROR_ICON
			// 
			this.ERROR_ICON.BackColor = System.Drawing.Color.Transparent;
			this.ERROR_ICON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ERROR_ICON.Image = global::CafeMaster_UI.Properties.Resources.ERROR_ICON_50x50;
			this.ERROR_ICON.Location = new System.Drawing.Point(3, 3);
			this.ERROR_ICON.Name = "ERROR_ICON";
			this.ERROR_ICON.Size = new System.Drawing.Size(50, 50);
			this.ERROR_ICON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ERROR_ICON.TabIndex = 24;
			this.ERROR_ICON.TabStop = false;
			// 
			// ERROR_CODE
			// 
			this.ERROR_CODE.AutoEllipsis = true;
			this.ERROR_CODE.BackColor = System.Drawing.Color.Transparent;
			this.ERROR_CODE.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.ERROR_CODE.ForeColor = System.Drawing.Color.Red;
			this.ERROR_CODE.Location = new System.Drawing.Point(557, 3);
			this.ERROR_CODE.Name = "ERROR_CODE";
			this.ERROR_CODE.Size = new System.Drawing.Size(190, 20);
			this.ERROR_CODE.TabIndex = 58;
			this.ERROR_CODE.Text = "0x00000";
			this.ERROR_CODE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// COPY_TEXT_BUTTON
			// 
			this.COPY_TEXT_BUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.COPY_TEXT_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.COPY_TEXT_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.COPY_TEXT_BUTTON.Image = global::CafeMaster_UI.Properties.Resources.CLIPBOARD;
			this.COPY_TEXT_BUTTON.Location = new System.Drawing.Point(3, 77);
			this.COPY_TEXT_BUTTON.Name = "COPY_TEXT_BUTTON";
			this.COPY_TEXT_BUTTON.Size = new System.Drawing.Size(20, 20);
			this.COPY_TEXT_BUTTON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.COPY_TEXT_BUTTON.TabIndex = 59;
			this.COPY_TEXT_BUTTON.TabStop = false;
			this.COPY_TEXT_BUTTON.Click += new System.EventHandler(this.COPY_TEXT_BUTTON_Click);
			// 
			// ProgramErrorListChild
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.COPY_TEXT_BUTTON);
			this.Controls.Add(this.ERROR_CODE);
			this.Controls.Add(this.ERROR_STACK);
			this.Controls.Add(this.ERROR_TITLE);
			this.Controls.Add(this.ERROR_ICON);
			this.Name = "ProgramErrorListChild";
			this.Size = new System.Drawing.Size(750, 100);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.ProgramErrorListChild_Paint);
			((System.ComponentModel.ISupportInitialize)(this.ERROR_ICON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.COPY_TEXT_BUTTON)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox ERROR_ICON;
		private System.Windows.Forms.Label ERROR_TITLE;
		private System.Windows.Forms.Label ERROR_STACK;
		private System.Windows.Forms.Label ERROR_CODE;
		private System.Windows.Forms.PictureBox COPY_TEXT_BUTTON;
	}
}
