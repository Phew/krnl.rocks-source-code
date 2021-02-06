using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace krnlss
{
	// Token: 0x02000007 RID: 7
	public partial class About : Form
	{
		// Token: 0x0600001E RID: 30
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x0600001F RID: 31
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000020 RID: 32 RVA: 0x00002166 File Offset: 0x00000366
		public About()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002174 File Offset: 0x00000374
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000020EC File Offset: 0x000002EC
		private void panel1_Move(object sender, EventArgs e)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000020EC File Offset: 0x000002EC
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000217C File Offset: 0x0000037C
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				About.ReleaseCapture();
				About.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000020EC File Offset: 0x000002EC
		private void About_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0400000F RID: 15
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000010 RID: 16
		public const int HT_CAPTION = 2;
	}
}
