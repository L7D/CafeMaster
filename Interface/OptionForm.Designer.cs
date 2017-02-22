namespace CafeMaster_UI.Interface
{
	partial class OptionForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionForm));
			this.APP_TITLE_BAR = new System.Windows.Forms.Panel();
			this.APP_TITLE = new CafeMaster_UI.Interface.CustomLabel();
			this.CLOSE_BUTTON = new System.Windows.Forms.PictureBox();
			this.OPTION_1_TITLE = new System.Windows.Forms.Label();
			this.OPTION_1_DESC = new System.Windows.Forms.Label();
			this.OPTION_2_DESC = new System.Windows.Forms.Label();
			this.OPTION_2_TITLE = new System.Windows.Forms.Label();
			this.OPTION_2_OBJECT_2 = new System.Windows.Forms.Label();
			this.OPTION_3_DESC = new System.Windows.Forms.Label();
			this.OPTION_3_TITLE = new System.Windows.Forms.Label();
			this.OPTION_4_DESC = new System.Windows.Forms.Label();
			this.OPTION_4_TITLE = new System.Windows.Forms.Label();
			this.INIT_DB_BUTTON = new CafeMaster_UI.Interface.FlatButton();
			this.OPTION_5_DESC = new System.Windows.Forms.Label();
			this.OPTION_5_TITLE = new System.Windows.Forms.Label();
			this.OPTION_5_OBJECT = new CafeMaster_UI.Interface.FlatButton();
			this.INIT_DB_TIP = new System.Windows.Forms.Label();
			this.OPTION_1_OBJECT = new CafeMaster_UI.Interface.FlatCheckBox();
			this.OPTION_3_OBJECT = new CafeMaster_UI.Interface.FlatCheckBox();
			this.OPTION_4_OBJECT = new CafeMaster_UI.Interface.FlatCheckBox();
			this.OPTION_2_OBJECT_1 = new System.Windows.Forms.NumericUpDown();
			this.APP_TITLE_BAR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OPTION_1_OBJECT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OPTION_3_OBJECT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OPTION_4_OBJECT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OPTION_2_OBJECT_1)).BeginInit();
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
			this.APP_TITLE_BAR.TabIndex = 4;
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
			this.APP_TITLE.Size = new System.Drawing.Size(29, 14);
			this.APP_TITLE.TabIndex = 3;
			this.APP_TITLE.Text = "설정";
			this.APP_TITLE.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
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
			// OPTION_1_TITLE
			// 
			this.OPTION_1_TITLE.AutoSize = true;
			this.OPTION_1_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.OPTION_1_TITLE.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.OPTION_1_TITLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.OPTION_1_TITLE.Location = new System.Drawing.Point(12, 66);
			this.OPTION_1_TITLE.Name = "OPTION_1_TITLE";
			this.OPTION_1_TITLE.Size = new System.Drawing.Size(164, 17);
			this.OPTION_1_TITLE.TabIndex = 5;
			this.OPTION_1_TITLE.Text = "윈도우 시작 시 자동 실행";
			// 
			// OPTION_1_DESC
			// 
			this.OPTION_1_DESC.AutoSize = true;
			this.OPTION_1_DESC.BackColor = System.Drawing.Color.Transparent;
			this.OPTION_1_DESC.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.OPTION_1_DESC.ForeColor = System.Drawing.SystemColors.ControlText;
			this.OPTION_1_DESC.Location = new System.Drawing.Point(12, 90);
			this.OPTION_1_DESC.Name = "OPTION_1_DESC";
			this.OPTION_1_DESC.Size = new System.Drawing.Size(246, 14);
			this.OPTION_1_DESC.TabIndex = 7;
			this.OPTION_1_DESC.Text = "윈도우 시작 시 프로그램을 자동으로 실행합니다.";
			// 
			// OPTION_2_DESC
			// 
			this.OPTION_2_DESC.AutoSize = true;
			this.OPTION_2_DESC.BackColor = System.Drawing.Color.Transparent;
			this.OPTION_2_DESC.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.OPTION_2_DESC.ForeColor = System.Drawing.SystemColors.ControlText;
			this.OPTION_2_DESC.Location = new System.Drawing.Point(12, 158);
			this.OPTION_2_DESC.Name = "OPTION_2_DESC";
			this.OPTION_2_DESC.Size = new System.Drawing.Size(271, 14);
			this.OPTION_2_DESC.TabIndex = 9;
			this.OPTION_2_DESC.Text = "카페 게시판과 동기화를 하는 시간 간격을 설정합니다.";
			// 
			// OPTION_2_TITLE
			// 
			this.OPTION_2_TITLE.AutoSize = true;
			this.OPTION_2_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.OPTION_2_TITLE.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.OPTION_2_TITLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.OPTION_2_TITLE.Location = new System.Drawing.Point(12, 134);
			this.OPTION_2_TITLE.Name = "OPTION_2_TITLE";
			this.OPTION_2_TITLE.Size = new System.Drawing.Size(82, 17);
			this.OPTION_2_TITLE.TabIndex = 8;
			this.OPTION_2_TITLE.Text = "동기화 간격";
			// 
			// OPTION_2_OBJECT_2
			// 
			this.OPTION_2_OBJECT_2.AutoSize = true;
			this.OPTION_2_OBJECT_2.BackColor = System.Drawing.Color.Transparent;
			this.OPTION_2_OBJECT_2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.OPTION_2_OBJECT_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.OPTION_2_OBJECT_2.Location = new System.Drawing.Point(451, 137);
			this.OPTION_2_OBJECT_2.Name = "OPTION_2_OBJECT_2";
			this.OPTION_2_OBJECT_2.Size = new System.Drawing.Size(22, 17);
			this.OPTION_2_OBJECT_2.TabIndex = 11;
			this.OPTION_2_OBJECT_2.Text = "초";
			this.OPTION_2_OBJECT_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// OPTION_3_DESC
			// 
			this.OPTION_3_DESC.AutoSize = true;
			this.OPTION_3_DESC.BackColor = System.Drawing.Color.Transparent;
			this.OPTION_3_DESC.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.OPTION_3_DESC.ForeColor = System.Drawing.SystemColors.ControlText;
			this.OPTION_3_DESC.Location = new System.Drawing.Point(12, 227);
			this.OPTION_3_DESC.Name = "OPTION_3_DESC";
			this.OPTION_3_DESC.Size = new System.Drawing.Size(279, 28);
			this.OPTION_3_DESC.TabIndex = 13;
			this.OPTION_3_DESC.Text = "자동으로 증거물을 남기기 위해 스크린샷을 촬영합니다,\r\n데이터를 불러오는데 시간이 많이 걸릴 수 있습니다.";
			// 
			// OPTION_3_TITLE
			// 
			this.OPTION_3_TITLE.AutoSize = true;
			this.OPTION_3_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.OPTION_3_TITLE.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.OPTION_3_TITLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.OPTION_3_TITLE.Location = new System.Drawing.Point(12, 203);
			this.OPTION_3_TITLE.Name = "OPTION_3_TITLE";
			this.OPTION_3_TITLE.Size = new System.Drawing.Size(96, 17);
			this.OPTION_3_TITLE.TabIndex = 12;
			this.OPTION_3_TITLE.Text = "스크린샷 촬영";
			// 
			// OPTION_4_DESC
			// 
			this.OPTION_4_DESC.AutoSize = true;
			this.OPTION_4_DESC.BackColor = System.Drawing.Color.Transparent;
			this.OPTION_4_DESC.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.OPTION_4_DESC.ForeColor = System.Drawing.SystemColors.ControlText;
			this.OPTION_4_DESC.Location = new System.Drawing.Point(12, 309);
			this.OPTION_4_DESC.Name = "OPTION_4_DESC";
			this.OPTION_4_DESC.Size = new System.Drawing.Size(329, 14);
			this.OPTION_4_DESC.TabIndex = 16;
			this.OPTION_4_DESC.Text = "프로그램과 서비스 환경을 개선하기 위해 진단 정보를 전송합니다.";
			// 
			// OPTION_4_TITLE
			// 
			this.OPTION_4_TITLE.AutoSize = true;
			this.OPTION_4_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.OPTION_4_TITLE.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.OPTION_4_TITLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.OPTION_4_TITLE.Location = new System.Drawing.Point(12, 285);
			this.OPTION_4_TITLE.Name = "OPTION_4_TITLE";
			this.OPTION_4_TITLE.Size = new System.Drawing.Size(192, 17);
			this.OPTION_4_TITLE.TabIndex = 15;
			this.OPTION_4_TITLE.Text = "사용자 환경 개선 서비스 가입";
			// 
			// INIT_DB_BUTTON
			// 
			this.INIT_DB_BUTTON.AnimationLerpP = 0.8F;
			this.INIT_DB_BUTTON.BackColor = System.Drawing.Color.Transparent;
			this.INIT_DB_BUTTON.ButtonText = "데이터 초기화";
			this.INIT_DB_BUTTON.ButtonTextColor = System.Drawing.Color.Black;
			this.INIT_DB_BUTTON.Cursor = System.Windows.Forms.Cursors.Hand;
			this.INIT_DB_BUTTON.EnterStateBackgroundColor = System.Drawing.Color.Tomato;
			this.INIT_DB_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.INIT_DB_BUTTON.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.INIT_DB_BUTTON.Location = new System.Drawing.Point(238, 448);
			this.INIT_DB_BUTTON.Name = "INIT_DB_BUTTON";
			this.INIT_DB_BUTTON.NormalStateBackgroundColor = System.Drawing.Color.Salmon;
			this.INIT_DB_BUTTON.Size = new System.Drawing.Size(250, 40);
			this.INIT_DB_BUTTON.TabIndex = 41;
			this.INIT_DB_BUTTON.Text = "데이터 초기화";
			this.INIT_DB_BUTTON.UseVisualStyleBackColor = false;
			this.INIT_DB_BUTTON.Click += new System.EventHandler(this.INIT_DB_BUTTON_Click);
			// 
			// OPTION_5_DESC
			// 
			this.OPTION_5_DESC.AutoSize = true;
			this.OPTION_5_DESC.BackColor = System.Drawing.Color.Transparent;
			this.OPTION_5_DESC.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.OPTION_5_DESC.ForeColor = System.Drawing.SystemColors.ControlText;
			this.OPTION_5_DESC.Location = new System.Drawing.Point(10, 382);
			this.OPTION_5_DESC.Name = "OPTION_5_DESC";
			this.OPTION_5_DESC.Size = new System.Drawing.Size(238, 28);
			this.OPTION_5_DESC.TabIndex = 43;
			this.OPTION_5_DESC.Text = "편의를 위해 자동 로그인을 설정할 수 있습니다,\r\n공용 PC에서는 사용하지 마십시오.";
			// 
			// OPTION_5_TITLE
			// 
			this.OPTION_5_TITLE.AutoSize = true;
			this.OPTION_5_TITLE.BackColor = System.Drawing.Color.Transparent;
			this.OPTION_5_TITLE.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.OPTION_5_TITLE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.OPTION_5_TITLE.Location = new System.Drawing.Point(10, 358);
			this.OPTION_5_TITLE.Name = "OPTION_5_TITLE";
			this.OPTION_5_TITLE.Size = new System.Drawing.Size(82, 17);
			this.OPTION_5_TITLE.TabIndex = 42;
			this.OPTION_5_TITLE.Text = "자동 로그인";
			// 
			// OPTION_5_OBJECT
			// 
			this.OPTION_5_OBJECT.AnimationLerpP = 0.8F;
			this.OPTION_5_OBJECT.BackColor = System.Drawing.Color.Transparent;
			this.OPTION_5_OBJECT.ButtonText = "자동 로그인 설정";
			this.OPTION_5_OBJECT.ButtonTextColor = System.Drawing.Color.Black;
			this.OPTION_5_OBJECT.Cursor = System.Windows.Forms.Cursors.Hand;
			this.OPTION_5_OBJECT.EnterStateBackgroundColor = System.Drawing.Color.Silver;
			this.OPTION_5_OBJECT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.OPTION_5_OBJECT.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.OPTION_5_OBJECT.Location = new System.Drawing.Point(291, 356);
			this.OPTION_5_OBJECT.Name = "OPTION_5_OBJECT";
			this.OPTION_5_OBJECT.NormalStateBackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.OPTION_5_OBJECT.Size = new System.Drawing.Size(197, 64);
			this.OPTION_5_OBJECT.TabIndex = 44;
			this.OPTION_5_OBJECT.Text = "자동 로그인 설정";
			this.OPTION_5_OBJECT.UseVisualStyleBackColor = false;
			this.OPTION_5_OBJECT.Click += new System.EventHandler(this.OPTION_5_OBJECT_Click);
			// 
			// INIT_DB_TIP
			// 
			this.INIT_DB_TIP.AutoSize = true;
			this.INIT_DB_TIP.BackColor = System.Drawing.Color.Transparent;
			this.INIT_DB_TIP.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.INIT_DB_TIP.ForeColor = System.Drawing.Color.Red;
			this.INIT_DB_TIP.Location = new System.Drawing.Point(25, 461);
			this.INIT_DB_TIP.Name = "INIT_DB_TIP";
			this.INIT_DB_TIP.Size = new System.Drawing.Size(185, 14);
			this.INIT_DB_TIP.TabIndex = 45;
			this.INIT_DB_TIP.Text = "모든 설정과 데이터를 초기화합니다.";
			// 
			// OPTION_1_OBJECT
			// 
			this.OPTION_1_OBJECT.BackColor = System.Drawing.Color.Transparent;
			this.OPTION_1_OBJECT.Cursor = System.Windows.Forms.Cursors.Hand;
			this.OPTION_1_OBJECT.Image = ((System.Drawing.Image)(resources.GetObject("OPTION_1_OBJECT.Image")));
			this.OPTION_1_OBJECT.Location = new System.Drawing.Point(443, 66);
			this.OPTION_1_OBJECT.Name = "OPTION_1_OBJECT";
			this.OPTION_1_OBJECT.Size = new System.Drawing.Size(30, 30);
			this.OPTION_1_OBJECT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.OPTION_1_OBJECT.Status = false;
			this.OPTION_1_OBJECT.TabIndex = 46;
			this.OPTION_1_OBJECT.TabStop = false;
			this.OPTION_1_OBJECT.StatusChanged += new System.EventHandler(this.OPTION_1_OBJECT_StatusChanged);
			// 
			// OPTION_3_OBJECT
			// 
			this.OPTION_3_OBJECT.BackColor = System.Drawing.Color.Transparent;
			this.OPTION_3_OBJECT.Cursor = System.Windows.Forms.Cursors.Hand;
			this.OPTION_3_OBJECT.Image = ((System.Drawing.Image)(resources.GetObject("OPTION_3_OBJECT.Image")));
			this.OPTION_3_OBJECT.Location = new System.Drawing.Point(443, 225);
			this.OPTION_3_OBJECT.Name = "OPTION_3_OBJECT";
			this.OPTION_3_OBJECT.Size = new System.Drawing.Size(30, 30);
			this.OPTION_3_OBJECT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.OPTION_3_OBJECT.Status = false;
			this.OPTION_3_OBJECT.TabIndex = 47;
			this.OPTION_3_OBJECT.TabStop = false;
			this.OPTION_3_OBJECT.StatusChanged += new System.EventHandler(this.OPTION_3_OBJECT_StatusChanged);
			// 
			// OPTION_4_OBJECT
			// 
			this.OPTION_4_OBJECT.BackColor = System.Drawing.Color.Transparent;
			this.OPTION_4_OBJECT.Cursor = System.Windows.Forms.Cursors.Hand;
			this.OPTION_4_OBJECT.Image = ((System.Drawing.Image)(resources.GetObject("OPTION_4_OBJECT.Image")));
			this.OPTION_4_OBJECT.Location = new System.Drawing.Point(443, 285);
			this.OPTION_4_OBJECT.Name = "OPTION_4_OBJECT";
			this.OPTION_4_OBJECT.Size = new System.Drawing.Size(30, 30);
			this.OPTION_4_OBJECT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.OPTION_4_OBJECT.Status = false;
			this.OPTION_4_OBJECT.TabIndex = 48;
			this.OPTION_4_OBJECT.TabStop = false;
			this.OPTION_4_OBJECT.StatusChanged += new System.EventHandler(this.OPTION_4_OBJECT_StatusChanged);
			// 
			// OPTION_2_OBJECT_1
			// 
			this.OPTION_2_OBJECT_1.BackColor = System.Drawing.Color.White;
			this.OPTION_2_OBJECT_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.OPTION_2_OBJECT_1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.OPTION_2_OBJECT_1.Location = new System.Drawing.Point(369, 132);
			this.OPTION_2_OBJECT_1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.OPTION_2_OBJECT_1.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.OPTION_2_OBJECT_1.Name = "OPTION_2_OBJECT_1";
			this.OPTION_2_OBJECT_1.Size = new System.Drawing.Size(75, 26);
			this.OPTION_2_OBJECT_1.TabIndex = 49;
			this.OPTION_2_OBJECT_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.OPTION_2_OBJECT_1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
			this.OPTION_2_OBJECT_1.ValueChanged += new System.EventHandler(this.OPTION_2_OBJECT_1_ValueChanged);
			// 
			// OptionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(500, 500);
			this.Controls.Add(this.OPTION_2_OBJECT_1);
			this.Controls.Add(this.OPTION_4_OBJECT);
			this.Controls.Add(this.OPTION_3_OBJECT);
			this.Controls.Add(this.OPTION_1_OBJECT);
			this.Controls.Add(this.INIT_DB_TIP);
			this.Controls.Add(this.OPTION_5_OBJECT);
			this.Controls.Add(this.OPTION_5_DESC);
			this.Controls.Add(this.OPTION_5_TITLE);
			this.Controls.Add(this.INIT_DB_BUTTON);
			this.Controls.Add(this.OPTION_4_DESC);
			this.Controls.Add(this.OPTION_4_TITLE);
			this.Controls.Add(this.OPTION_3_DESC);
			this.Controls.Add(this.OPTION_3_TITLE);
			this.Controls.Add(this.OPTION_2_OBJECT_2);
			this.Controls.Add(this.OPTION_2_DESC);
			this.Controls.Add(this.OPTION_2_TITLE);
			this.Controls.Add(this.OPTION_1_DESC);
			this.Controls.Add(this.OPTION_1_TITLE);
			this.Controls.Add(this.APP_TITLE_BAR);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "OptionForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "우윳빛깔 카페스탭";
			this.Load += new System.EventHandler(this.OptionForm_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.OptionForm_Paint);
			this.APP_TITLE_BAR.ResumeLayout(false);
			this.APP_TITLE_BAR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CLOSE_BUTTON)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OPTION_1_OBJECT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OPTION_3_OBJECT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OPTION_4_OBJECT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OPTION_2_OBJECT_1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel APP_TITLE_BAR;
		private CustomLabel APP_TITLE;
		private System.Windows.Forms.PictureBox CLOSE_BUTTON;
		private System.Windows.Forms.Label OPTION_1_TITLE;
		private System.Windows.Forms.Label OPTION_1_DESC;
		private System.Windows.Forms.Label OPTION_2_DESC;
		private System.Windows.Forms.Label OPTION_2_TITLE;
		private System.Windows.Forms.Label OPTION_2_OBJECT_2;
		private System.Windows.Forms.Label OPTION_3_DESC;
		private System.Windows.Forms.Label OPTION_3_TITLE;
		private System.Windows.Forms.Label OPTION_4_DESC;
		private System.Windows.Forms.Label OPTION_4_TITLE;
		private FlatButton INIT_DB_BUTTON;
		private System.Windows.Forms.Label OPTION_5_DESC;
		private System.Windows.Forms.Label OPTION_5_TITLE;
		private FlatButton OPTION_5_OBJECT;
		private System.Windows.Forms.Label INIT_DB_TIP;
		private FlatCheckBox OPTION_1_OBJECT;
		private FlatCheckBox OPTION_3_OBJECT;
		private FlatCheckBox OPTION_4_OBJECT;
		private System.Windows.Forms.NumericUpDown OPTION_2_OBJECT_1;
	}
}