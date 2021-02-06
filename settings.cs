using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using injection;
using krnlss.Properties;
using ToggleSlider;

namespace krnlss
{
	// Token: 0x0200002F RID: 47
	public partial class settings : Form
	{
		// Token: 0x060000C5 RID: 197
		[DllImport("user32.dll")]
		private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

		// Token: 0x060000C6 RID: 198 RVA: 0x000025B8 File Offset: 0x000007B8
		public settings(Form parentt)
		{
			this.InitializeComponent();
			this.parent = parentt;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0001EAFC File Offset: 0x0001CCFC
		private void krnl_Load(object sender, EventArgs e)
		{
			if (Settings.Default.autoinject)
			{
				this.toggleSliderComponent1.Checked = true;
			}
			if (Settings.Default.topmostchecked)
			{
				this.toggleSliderComponent2.Checked = true;
			}
			if (Settings.Default.fadein_out_opacity)
			{
				this.toggleSliderComponent3.Checked = true;
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000022CE File Offset: 0x000004CE
		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000020EC File Offset: 0x000002EC
		private void button2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000020EC File Offset: 0x000002EC
		private void button3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000020EC File Offset: 0x000002EC
		private void OPACITYASSS_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002174 File Offset: 0x00000374
		private void button1_Click_1(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000020EC File Offset: 0x000002EC
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002349 File Offset: 0x00000549
		private void panel1_MouseDown_1(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				krnl.ReleaseCapture();
				krnl.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000020EC File Offset: 0x000002EC
		private void toggleSliderComponent2_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002174 File Offset: 0x00000374
		private void button4_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002340 File Offset: 0x00000540
		private void button3_Click_1(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0001EB54 File Offset: 0x0001CD54
		private void injectdll(dynamic filename, int PID)
		{
			krnlgay.krnlgayResult krnlgayResult = krnlgay.DllInjector.GetInstance.Inject(Application.StartupPath + string.Format("\\\\{0}", filename), PID, false);
			if (krnlgayResult == krnlgay.krnlgayResult.DllNotFound)
			{
				MessageBox.Show(string.Format("Dll Named {0} Not Found!", filename));
				return;
			}
			if (krnlgayResult != krnlgay.krnlgayResult.Failed)
			{
				return;
			}
			MessageBox.Show("Injection Failed For Unspecified Reason");
		}

		// Token: 0x060000D3 RID: 211
		[DllImport("user32.dll", SetLastError = true)]
		private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

		// Token: 0x060000D4 RID: 212
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool WaitNamedPipe(string name, int timeout);

		// Token: 0x060000D5 RID: 213 RVA: 0x0001EBA8 File Offset: 0x0001CDA8
		private static bool findpipe(string pipeName)
		{
			bool result;
			try
			{
				if (settings.WaitNamedPipe(Path.GetFullPath("\\\\.\\pipe\\" + pipeName), 0) && (Marshal.GetLastWin32Error() == 0 || Marshal.GetLastWin32Error() == 2))
				{
					result = false;
				}
				else
				{
					result = true;
				}
			}
			catch (Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000020EC File Offset: 0x000002EC
		private void autoinjectbruh()
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000020EC File Offset: 0x000002EC
		private void toggleSliderComponent1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0001EBFC File Offset: 0x0001CDFC
		private void toggleSliderComponent1_CheckChanged(object sender, EventArgs e)
		{
			if (this.toggleSliderComponent1.Checked)
			{
				this.autoinjectiont = new Thread(new ThreadStart(this.autoinjectbruh));
				this.autoinjectiont.IsBackground = true;
				this.autoinjectiont.Start();
				Settings.Default.autoinject = true;
				Settings.Default.Save();
				return;
			}
			if (this.autoinjectiont != null)
			{
				this.autoinjectiont.Abort();
				this.autoinjectiont = null;
			}
			Settings.Default.autoinject = false;
			Settings.Default.Save();
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0001EC8C File Offset: 0x0001CE8C
		private void toggleSliderComponent2_CheckChanged(object sender, EventArgs e)
		{
			if (this.toggleSliderComponent2.Checked)
			{
				base.TopMost = true;
				this.parent.TopMost = true;
				Settings.Default.topmostchecked = true;
				Settings.Default.Save();
				return;
			}
			base.TopMost = false;
			this.parent.TopMost = false;
			Settings.Default.topmostchecked = false;
			Settings.Default.Save();
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000020EC File Offset: 0x000002EC
		private void settings_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000020EC File Offset: 0x000002EC
		private void toggleSliderComponent3_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0001F884 File Offset: 0x0001DA84
		private void toggleSliderComponent3_CheckChanged(object sender, EventArgs e)
		{
			Settings.Default.fadein_out_opacity = this.toggleSliderComponent3.Checked;
			if (Settings.Default.fadein_out_opacity)
			{
				while (this.parent.Opacity > 0.5)
				{
					Task.Delay(10).GetAwaiter().GetResult();
					this.parent.Opacity -= 0.05;
				}
			}
			else
			{
				while (this.parent.Opacity < 1.0)
				{
					Task.Delay(10).GetAwaiter().GetResult();
					this.parent.Opacity += 0.05;
				}
			}
			Settings.Default.Save();
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0001F94C File Offset: 0x0001DB4C
		private void button1_Click_2(object sender, EventArgs e)
		{
			try
			{
				WebClient webClient = new WebClient();
				string[] array = webClient.DownloadString("https://gist.githubusercontent.com/Bi-nz/634f1dffea429053af1db665adee2233/raw").Split(new char[]
				{
					','
				});
				string[] array2 = new string[]
				{
					"ScintillaNET",
					"Indicium-Supra",
					"Bunifu_UI_v1.5.3",
					"krnl"
				};
				for (int i = 0; i < array2.Length; i++)
				{
					try
					{
						File.SetAttributes(array2[i] + ".dll", FileAttributes.Archive);
						File.Delete(array2[i] + ".dll");
					}
					catch
					{
					}
				}
				try
				{
					File.Move(Process.GetCurrentProcess().MainModule.FileName.Split(new char[]
					{
						'\\'
					}).ToList<string>().Last<string>(), "krnl.exe.bak");
				}
				catch (Exception)
				{
				}
				for (int j = 0; j < array.Length; j++)
				{
					try
					{
						File.WriteAllBytes(array[j].Split(new char[]
						{
							'/'
						}).ToList<string>().Last<string>(), new WebClient().DownloadData(array[j]));
					}
					catch
					{
					}
				}
				Task.Delay(50).GetAwaiter().GetResult();
				Process.Start("krnl.exe");
				Process.GetCurrentProcess().Kill();
			}
			catch (WebException ex)
			{
				MessageBox.Show(ex.Message + "\n\n" + ex.ToString(), "Caught web exception - krnl");
			}
		}

		// Token: 0x04000436 RID: 1078
		private Form parent;

		// Token: 0x04000437 RID: 1079
		private Thread autoinjectiont;
	}
}
