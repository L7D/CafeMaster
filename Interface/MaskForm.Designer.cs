namespace CafeMaster_UI.Interface
{
	partial class MaskForm
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
			this.TITLE_LABEL = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// TITLE_LABEL
			// 
			this.TITLE_LABEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.TITLE_LABEL.AutoEllipsis = true;
			this.TITLE_LABEL.BackColor = System.Drawing.Color.Transparent;
			this.TITLE_LABEL.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.TITLE_LABEL.ForeColor = System.Drawing.Color.White;
			this.TITLE_LABEL.Location = new System.Drawing.Point(0, 387);
			this.TITLE_LABEL.Name = "TITLE_LABEL";
			this.TITLE_LABEL.Size = new System.Drawing.Size(1131, 20);
			this.TITLE_LABEL.TabIndex = 1;
			this.TITLE_LABEL.Text = "작업을 열심히 하고 있습니다 ... 잠시만 기다려 주세요!";
			this.TITLE_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TITLE_LABEL.UseMnemonic = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::CafeMaster_UI.Properties.Resources.MASK_PROGRESS_ICON;
			this.pictureBox1.Location = new System.Drawing.Point(515, 254);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 100);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// MaskForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1130, 685);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.TITLE_LABEL);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MaskForm";
			this.Opacity = 0.7D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "MaskForm";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label TITLE_LABEL;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}