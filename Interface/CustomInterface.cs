using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeMaster_UI.Lib;

namespace CafeMaster_UI.Interface
{
	// http://stackoverflow.com/questions/17752970/how-to-programmatically-scroll-a-panel
	public static class PanelExtension
	{
		public static void ScrollDown( this Panel p, int pos )
		{
			// pos passed in should be positive
			using ( Control c = new Control( ) { Parent = p, Height = 1, Top = p.ClientSize.Height + pos } )
			{
				p.ScrollControlIntoView( c );
			}
		}
		public static void ScrollUp( this Panel p, int pos )
		{
			// pos passed in should be negative
			using ( Control c = new Control( ) { Parent = p, Height = 1, Top = pos } )
			{
				p.ScrollControlIntoView( c );
			}
		}
	}

	public class FlatCheckBox : PictureBox
	{
		private bool Status_private;
		public event EventHandler StatusChanged;
		public bool Status
		{
			set
			{
				Status_private = value;

				this.Image = value ? Properties.Resources.FLATCHECKBOX_ON : Properties.Resources.FLATCHECKBOX_OFF;
				this.Refresh( );

				StatusChanged?.Invoke( this, EventArgs.Empty );
			}
			get
			{
				return Status_private;
			}
		}

		public FlatCheckBox( )
		{
			this.Size = new Size( 30, 30 );
			this.Status = false;
			this.SizeMode = PictureBoxSizeMode.StretchImage;
			this.BackColor = Color.Transparent;
			this.Cursor = Cursors.Hand;

			this.Image = Properties.Resources.FLATCHECKBOX_OFF;
		}

		protected override void OnClick( EventArgs e )
		{
			base.OnClick( e );
			this.Status = !this.Status;
		}
	}

	// http://stackoverflow.com/questions/818415/how-do-i-double-buffer-a-panel-in-c
	public class DoubleBufferPanel : Panel
	{
		public DoubleBufferPanel( )
		{
			this.SetStyle( ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true );
			this.UpdateStyles( );
		}
	}

	// http://stackoverflow.com/questions/16989957/drawing-over-richtextbox
	class RichBox : RichTextBox
	{
		private const int WM_PAINT = 15;

		public RichBox( )
		{
			//VScrollBar bar = new VScrollBar( );
			//bar.Height = 200;
			//bar.Width = 10;
			//bar.Value = 0;
			//bar.Dock = DockStyle.Right;
			//bar.Name = "VScrollBar1";
			////bar.Scroll += new ScrollEventHandler()
			//this.Controls.Add( bar );
		}

		protected override void WndProc( ref Message m )
		{
			if ( m.Msg == WM_PAINT )
			{
				this.Invalidate( );
				base.WndProc( ref m );

				using ( Graphics g = Graphics.FromHwnd( this.Handle ) )
				{
					using ( Pen lineDrawer = new Pen( GlobalVar.MasterColor )
					{
						Width = 1
					} )
					{
						int w = this.Width, h = this.Height;

						//g.DrawLine( lineDrawer, 0, 0, w, 0 ); // 위
						//g.DrawLine( lineDrawer, 0, 0, 0, h ); // 왼쪽
						//g.DrawLine( lineDrawer, w - lineDrawer.Width, 0, w - lineDrawer.Width, h ); // 오른쪽
						g.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // 아래
					}
				}
			}
			else
			{
				base.WndProc( ref m );
			}
		}
	}

	// http://stackoverflow.com/questions/566245/how-to-draw-smooth-images-with-c
	public class HighQualitySmoothPictureBox : PictureBox
	{
		protected override void OnPaint( PaintEventArgs pe )
		{
			// This is the only line needed for anti-aliasing to be turned on.
			pe.Graphics.SmoothingMode = SmoothingMode.HighQuality;

			// the next two lines of code (not comments) are needed to get the highest 
			// possible quiality of anti-aliasing. Remove them if you want the image to render faster.
			pe.Graphics.CompositingQuality = CompositingQuality.HighQuality;
			pe.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			// this line is needed for .net to draw the contents.
			base.OnPaint( pe );
		}
	}

	//public class FlatTextBox : TextBox
	//{
	//	public FlatTextBox( )
	//	{
	//		base.BackColor = Color.White;
	//		base.BorderStyle = BorderStyle.None;
	//		base.Font = new Font( "나눔 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );

	//		this.SetStyle( ControlStyles.OptimizedDoubleBuffer, true );
	//	}

	//	private const int WM_PAINT = 15;

	//	protected override void WndProc( ref Message m )
	//	{
	//		if ( m.Msg == WM_PAINT )
	//		{
	//			this.Invalidate( );
	//			base.WndProc( ref m );

	//			using ( Graphics g = Graphics.FromHwnd( this.Handle ) )
	//			{
	//				int w = this.Width, h = this.Height;

	//				Pen lineDrawer = new Pen( Color.Red ); // Line Color is same as Title bar
	//				lineDrawer.Width = 5; // Line width set to 10px

	//				g.DrawLine( lineDrawer, 0, h - lineDrawer.Width, w, h - lineDrawer.Width ); // Bottom line drawing
	//			}
	//		}
	//		else
	//		{
	//			base.WndProc( ref m );
	//		}
	//	}
	//}

	// http://stackoverflow.com/questions/778678/how-to-change-the-color-of-progressbar-in-c-sharp-net-3-5
	public class FlatProgressBar : ProgressBar
	{
		private Timer valueAnimationTimer;
		private float Progress_Animation_private;
		private int Progress_Target_private;
		public int Progress
		{
			set
			{
				Progress_Target_private = value;

				if ( valueAnimationTimer == null )
					TimerCreate( );

				valueAnimationTimer.Start( );
			}
			get
			{
				return Progress_Target_private;
			}
		}

		public FlatProgressBar( )
		{
			this.SetStyle( ControlStyles.UserPaint, true );
			this.Progress_Animation_private = this.Minimum;

			this.SetStyle( ControlStyles.OptimizedDoubleBuffer, true );
		}

		private void TimerCreate( )
		{
			valueAnimationTimer = new Timer( )
			{
				Interval = 10
			};
			valueAnimationTimer.Tick += ( object sender, EventArgs e ) =>
			{
				if ( this.Progress_Animation_private.Equals( this.Progress_Target_private ) )
				{
					valueAnimationTimer.Stop( );
					return;
				}

				float curr = this.Progress_Animation_private;

				curr = Utility.Lerp( curr, ( float ) this.Progress_Target_private, 0.8F );

				this.Progress_Animation_private = curr;
				this.Invalidate( );
			};
		}

		protected override void OnPaint( PaintEventArgs e )
		{
			Rectangle rec = e.ClipRectangle;

			rec.Width = Math.Min( ( int ) ( this.Width * ( ( float ) Progress_Animation_private / ( float ) Maximum ) ) - 4, rec.Width );
			if ( ProgressBarRenderer.IsSupported )
				ProgressBarRenderer.DrawHorizontalBar( e.Graphics, e.ClipRectangle );
			rec.Height = rec.Height - 4;
			e.Graphics.FillRectangle( Brushes.DimGray, 2, 2, rec.Width, rec.Height );
		}
	}

	public class CustomComboBox : ComboBox
	{
		public CustomComboBox( )
		{
			base.DropDownStyle = ComboBoxStyle.DropDownList;
			base.DrawMode = DrawMode.OwnerDrawFixed;
		}

		protected override void OnDrawItem( DrawItemEventArgs e )
		{
			if ( e.Index < 0 ) return; // 아이템이 없으면 그리지 않음;

			if ( ( e.State & DrawItemState.Selected ) == DrawItemState.Selected ) // 선택 되면;
				e.Graphics.FillRectangle( new SolidBrush( Color.Gainsboro ), e.Bounds ); // 하이라이트 배경 렌더링;
			else
				e.Graphics.FillRectangle( new SolidBrush( this.BackColor ), e.Bounds ); // 하이라이트 배경 렌더링;

			e.Graphics.DrawString( this.Items[ e.Index ].ToString( ), e.Font, new SolidBrush( Color.Black ), new Point( e.Bounds.X, e.Bounds.Y ) ); // 텍스트 렌더링;
			e.DrawFocusRectangle( );
		}
	}

	public class FlatButton : Button
	{
		private Timer backgroundAnimationTimer;
		private bool mouseJoin;
		public float AnimationLerpP
		{
			set;
			get;
		}
		private Color NormalStateBackgroundColor_private;
		public Color NormalStateBackgroundColor
		{
			set
			{
				NormalStateBackgroundColor_private = value;
				this.BackgroundDrawer = new SolidBrush( value );
			}
			get
			{
				return NormalStateBackgroundColor_private;
			}
		}
		private Color EnterStateBackgroundColor_private;
		public Color EnterStateBackgroundColor
		{
			set
			{
				EnterStateBackgroundColor_private = value;
			}
			get
			{
				return EnterStateBackgroundColor_private;
			}
		}
		private SolidBrush BackgroundDrawer;
		private string Text_private;
		public string ButtonText
		{
			set
			{
				Text_private = value;

				this.Invalidate( );
			}
			get
			{
				return Text_private;
			}
		}
		public override string Text
		{
			set
			{
				ButtonText = value;
			}
			get
			{
				return ButtonText;
			}
		}
		public SolidBrush TextDrawer;
		private Color ButtonTextColor_private;
		public Color ButtonTextColor
		{
			set
			{
				ButtonTextColor_private = value;
				this.TextDrawer = new SolidBrush( value );
			}
			get
			{
				return ButtonTextColor_private;
			}
		}
		public override Color ForeColor
		{
			set
			{
				ButtonTextColor = value;

			}
			get
			{
				return ButtonTextColor;
			}
		}

		public override Color BackColor
		{
			set
			{
				base.BackColor = Color.Transparent;
			}
			get
			{
				return base.BackColor;
			}
		}

		public FlatButton( )
		{
			base.Font = new Font( "나눔 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point, ( ( byte ) ( 129 ) ) );
			base.FlatStyle = FlatStyle.Flat;
			base.BackColor = Color.Transparent;
			base.Cursor = Cursors.Hand;

			this.ButtonTextColor = Color.Black;
			this.AnimationLerpP = 0.8F;
			this.NormalStateBackgroundColor = Color.WhiteSmoke;
			this.EnterStateBackgroundColor = Color.Gainsboro;
			this.BackgroundDrawer = new SolidBrush( this.NormalStateBackgroundColor );
			this.TextDrawer = new SolidBrush( this.ForeColor );
		}

		private void TimerCreate( )
		{
			backgroundAnimationTimer = new Timer( )
			{
				Interval = 50
			};
			backgroundAnimationTimer.Tick += ( object sender, EventArgs e ) =>
			{
				Color currentColor = this.BackgroundDrawer.Color;

				currentColor = Utility.LerpColor( currentColor, mouseJoin ? this.EnterStateBackgroundColor : this.NormalStateBackgroundColor, this.AnimationLerpP );

				if ( this.BackgroundDrawer.Color.Equals( currentColor ) )
				{
					backgroundAnimationTimer.Stop( );
				}
				else
				{
					this.BackgroundDrawer.Color = currentColor;
					this.Invalidate( );
				}
			};
		}

		protected override void OnMouseEnter( EventArgs e )
		{
			if ( backgroundAnimationTimer == null )
				TimerCreate( );

			if ( !backgroundAnimationTimer.Enabled )
				backgroundAnimationTimer.Start( );

			mouseJoin = true;

			base.OnMouseEnter( e );
		}

		protected override void OnMouseLeave( EventArgs e )
		{
			if ( backgroundAnimationTimer == null )
				TimerCreate( );

			if ( !backgroundAnimationTimer.Enabled )
				backgroundAnimationTimer.Start( );

			mouseJoin = false;

			base.OnMouseLeave( e );
		}

		protected override void OnPaint( PaintEventArgs e )
		{
			//base.OnPaint( e );

			e.Graphics.FillRectangle( this.BackgroundDrawer, e.ClipRectangle );

			// http://stackoverflow.com/questions/10427069/painting-text-on-button-difference-in-look
			SizeF textSize = e.Graphics.MeasureString( this.ButtonText, this.Font, this.Width );
			Point location = new Point(
				( int ) ( ( this.Width / 2 ) - ( textSize.Width / 2 ) ),
				( int ) ( ( this.Height / 2 ) - ( textSize.Height / 2 ) )
			);

			e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
			e.Graphics.DrawString( this.ButtonText, this.Font, this.TextDrawer, location );
		}
	}

	public class FlatImageButton : PictureBox
	{
		private Timer backgroundAnimationTimer;
		private bool mouseJoin;
		public float AnimationLerpP
		{
			set;
			get;
		}
		private Color NormalStateBackgroundColor_private;
		public Color NormalStateBackgroundColor
		{
			set
			{
				NormalStateBackgroundColor_private = value;
				this.BackgroundDrawer = new SolidBrush( value );
			}
			get
			{
				return NormalStateBackgroundColor_private;
			}
		}
		private Color EnterStateBackgroundColor_private;
		public Color EnterStateBackgroundColor
		{
			set
			{
				EnterStateBackgroundColor_private = value;
			}
			get
			{
				return EnterStateBackgroundColor_private;
			}
		}
		private SolidBrush BackgroundDrawer;

		public FlatImageButton( )
		{
			base.Cursor = Cursors.Hand;
			base.SizeMode = PictureBoxSizeMode.StretchImage;
			base.BackColor = Color.Transparent;

			this.AnimationLerpP = 0.8F;
			this.NormalStateBackgroundColor = Color.WhiteSmoke;
			this.EnterStateBackgroundColor = Color.Gainsboro;

			this.BackgroundDrawer = new SolidBrush( this.NormalStateBackgroundColor );
		}

		private void TimerCreate( )
		{
			backgroundAnimationTimer = new Timer( )
			{
				Interval = 10
			};
			backgroundAnimationTimer.Tick += ( object sender, EventArgs e ) =>
			{
				Color currentColor = this.BackgroundDrawer.Color;

				if ( mouseJoin )
				{
					currentColor = Utility.LerpColor( currentColor, this.EnterStateBackgroundColor, this.AnimationLerpP );
				}
				else
				{
					currentColor = Utility.LerpColor( currentColor, this.NormalStateBackgroundColor, this.AnimationLerpP );
				}

				if ( this.BackgroundDrawer.Color.Equals( currentColor ) )
				{
					backgroundAnimationTimer.Stop( );
				}
				else
				{
					this.BackgroundDrawer.Color = currentColor;
					this.Invalidate( );
				}
			};
		}

		protected override void OnMouseEnter( EventArgs e )
		{
			if ( backgroundAnimationTimer == null )
			{
				TimerCreate( );
			}

			if ( !backgroundAnimationTimer.Enabled )
				backgroundAnimationTimer.Start( );

			mouseJoin = true;

			base.OnMouseEnter( e );
		}

		protected override void OnMouseLeave( EventArgs e )
		{
			if ( backgroundAnimationTimer == null )
			{
				TimerCreate( );
			}

			if ( !backgroundAnimationTimer.Enabled )
				backgroundAnimationTimer.Start( );

			mouseJoin = false;

			base.OnMouseLeave( e );
		}

		protected override void OnPaint( PaintEventArgs e )
		{
			e.Graphics.FillRectangle( this.BackgroundDrawer, e.ClipRectangle );

			base.OnPaint( e );
		}
	}


	public class CustomLabel : Label
	{
		private const int WM_NCHITTEST = 0x84; // 현재 마우스 커서의 위치가 윈도우의 어떤 부분에 있는지 조사할 때 먼저 보내는 메시지;
		private const int HTTRANSPARENT = -1;

		protected override void WndProc( ref Message message )
		{
			if ( message.Msg == ( int ) WM_NCHITTEST ) // 만약 이 라벨에 메시지가 전달되면;
				message.Result = ( IntPtr ) HTTRANSPARENT; // 그대로 통과시킴;
			else
				base.WndProc( ref message );
		}

		// http://stackoverflow.com/questions/2609520/how-to-make-text-labels-smooth
		private TextRenderingHint _hint = TextRenderingHint.SystemDefault;
		public TextRenderingHint TextRenderingHint
		{
			set { this._hint = value; }
			get { return this._hint; }
		}

		protected override void OnPaint( PaintEventArgs pe )
		{
			try
			{
				pe.Graphics.TextRenderingHint = TextRenderingHint;
				base.OnPaint( pe );
			}
			catch ( ArgumentException )
			{
				Application.Exit( );
			}
		}

		/*
        ---------------------- DefwindowProc 의 리턴값 -------------------------------------
        HTBORDER 크기 조절이 불가능한 경계선 18
        HTBOTTOM 아래쪽 경계선 15
        HTTOP  위쪽 경계선
        HTBOTTOMLEFT 아래 왼쪽 경계선 16
        HTBOTTOMRIGHT 아래 오른쪽 경계선 17
        HTTOPLEFT 위 왼쪽  경계선 13
        HTTOPRIGHT 위 오른쪽 경계선 14
        HTLEFT  왼쪽 경계선 10
        HTRIGHT  오른쪽 경계선 11
        HTCAPTION 타이틀 바 2
        HTCLIENT  작업영역 1
        HTCLOSE  닫기 버튼 20
        HTSIZE  크기 변경 박스 4
        HTHELP  도움말 버튼 21
        HTHSCROLL 수평 스크롤 바 6
        HTVSCROLL 수직 스크롤바 7 
        HTMENU  메뉴 5
        HTMAXBUTTON 최대화 버튼 9
        HTMINBUTTON 최소화 버튼 8
        HTSYSMENU 시스템 메뉴 3
        HTTRANSPARENT 같은 스레드의 다른 윈도우에 가려진 부분 -1
        --------------------------------------------------------------------------------------
        */
	}
}