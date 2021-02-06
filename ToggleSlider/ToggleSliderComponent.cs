using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ToggleSlider
{
	// Token: 0x02000003 RID: 3
	public class ToggleSliderComponent : UserControl
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002070 File Offset: 0x00000270
		public bool Checked
		{
			get
			{
				return this.Checked_bool;
			}
			set
			{
				this.Checked_bool = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000207F File Offset: 0x0000027F
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002087 File Offset: 0x00000287
		public Color ToggleCircleColor
		{
			get
			{
				return this.ToggleColorDisabled_Color;
			}
			set
			{
				this.ToggleColorDisabled_Color = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x06000008 RID: 8 RVA: 0x0000209E File Offset: 0x0000029E
		public Color ToggleColorBar
		{
			get
			{
				return this.Bar_Color;
			}
			set
			{
				this.Bar_Color = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000020AD File Offset: 0x000002AD
		// (set) Token: 0x0600000A RID: 10 RVA: 0x000020B5 File Offset: 0x000002B5
		public string ToggleBarText
		{
			get
			{
				return this.Text;
			}
			set
			{
				this.Text = value;
				base.Invalidate();
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600000B RID: 11 RVA: 0x0000286C File Offset: 0x00000A6C
		// (remove) Token: 0x0600000C RID: 12 RVA: 0x000028A4 File Offset: 0x00000AA4
		public event EventHandler CheckChanged;

		// Token: 0x0600000D RID: 13 RVA: 0x000028DC File Offset: 0x00000ADC
		public ToggleSliderComponent()
		{
			this.InitializeComponent();
			this.DoubleBuffered = true;
			base.Click += this.ToggleSlider_Click;
			this.timer1.Tick += this.Timer1_Tick;
			this.AutoSize = true;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002960 File Offset: 0x00000B60
		protected override void OnPaint(PaintEventArgs pevent)
		{
			if (this.init_)
			{
				this.circlecolor_ = this.ToggleColorDisabled_Color;
			}
			pevent.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			Size size = new Size(Convert.ToInt32(this.Font.SizeInPoints * 5f), Convert.ToInt32(this.Font.SizeInPoints * 5f));
			ToggleSliderComponent.RoundedRect(this.Bar_Color, pevent.Graphics, new Rectangle(size.Width / 4, size.Height / 5 / 2, size.Width / 2, 3 * (size.Height / 5) / 2), 5);
			new LinearGradientBrush(new Point(size.Width / 4, size.Height / 5 / 2), new Point(size.Width / 2, size.Height / 2), this.ToggleColorDisabled_Color, this.ToggleColorDisabled_Color);
			if (!this.animating_)
			{
				if (!this.Checked_bool)
				{
					this.posx = 0;
				}
				else
				{
					this.posx = size.Width / 2;
				}
			}
			pevent.Graphics.FillEllipse(new SolidBrush(this.ToggleColorDisabled_Color), this.posx, this.posy, size.Width / 2, size.Height / 2);
			TextRenderer.DrawText(pevent.Graphics, this.ToggleBarText, this.Font, new Point(size.Width, size.Height / 10), this.ForeColor);
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020C4 File Offset: 0x000002C4
		private void ToggleSlider_Click(object sender, EventArgs e)
		{
			this.Animate();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020CC File Offset: 0x000002CC
		private void Animate()
		{
			this.timer1.Interval = 1;
			this.timer1.Start();
			this.animating_ = true;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002AE0 File Offset: 0x00000CE0
		private void Timer1_Tick(object sender, EventArgs e)
		{
			Size size = new Size(Convert.ToInt32(this.Font.SizeInPoints * 5f), Convert.ToInt32(this.Font.SizeInPoints * 5f));
			if (this.Checked_bool)
			{
				if (this.posx > 0)
				{
					this.posx -= 3;
					base.Invalidate();
					return;
				}
				this.Checked_bool = false;
				this.animating_ = false;
				if (this.CheckChanged != null)
				{
					this.CheckChanged(this, e);
				}
				this.timer1.Stop();
				return;
			}
			else
			{
				this.init_ = false;
				if (this.posx < size.Width / 2)
				{
					this.posx += 3;
					base.Invalidate();
					return;
				}
				this.Checked_bool = true;
				this.animating_ = false;
				if (this.CheckChanged != null)
				{
					this.CheckChanged(this, e);
				}
				this.timer1.Stop();
				return;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002BD0 File Offset: 0x00000DD0
		public static GraphicsPath RoundedRect(Color c, Graphics g, Rectangle bounds, int radius)
		{
			int num = radius * 2;
			Size size = new Size(num, num);
			Rectangle rect = new Rectangle(bounds.Location, size);
			GraphicsPath graphicsPath = new GraphicsPath();
			if (radius == 0)
			{
				graphicsPath.AddRectangle(bounds);
				return graphicsPath;
			}
			graphicsPath.AddArc(rect, 180f, 90f);
			rect.X = bounds.Right - num;
			graphicsPath.AddArc(rect, 270f, 90f);
			rect.Y = bounds.Bottom - num;
			graphicsPath.AddArc(rect, 0f, 90f);
			rect.X = bounds.Left;
			graphicsPath.AddArc(rect, 90f, 90f);
			g.FillPath(new SolidBrush(c), graphicsPath);
			graphicsPath.CloseFigure();
			return graphicsPath;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000020EC File Offset: 0x000002EC
		private void ToggleSliderComponent_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000020EE File Offset: 0x000002EE
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002C90 File Offset: 0x00000E90
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(8f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Margin = new Padding(4, 4, 4, 4);
			base.Name = "ToggleSliderComponent";
			base.Size = new Size(308, 52);
			base.Load += this.ToggleSliderComponent_Load;
			base.ResumeLayout(false);
		}

		// Token: 0x04000001 RID: 1
		private bool Checked_bool;

		// Token: 0x04000002 RID: 2
		private Color ToggleColorDisabled_Color = Color.Green;

		// Token: 0x04000003 RID: 3
		private Color Bar_Color = Color.Gray;

		// Token: 0x04000004 RID: 4
		private new string Text = "toggleSlider1";

		// Token: 0x04000005 RID: 5
		private int posx;

		// Token: 0x04000006 RID: 6
		private int posy;

		// Token: 0x04000007 RID: 7
		private bool init_ = true;

		// Token: 0x04000008 RID: 8
		private Color circlecolor_;

		// Token: 0x04000009 RID: 9
		private bool animating_;

		// Token: 0x0400000A RID: 10
		private Timer timer1 = new Timer();

		// Token: 0x0400000B RID: 11
		private IContainer components;
	}
}
