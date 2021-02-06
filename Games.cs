using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace krnlss
{
	// Token: 0x02000008 RID: 8
	public partial class Games : Form
	{
		// Token: 0x06000028 RID: 40
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000029 RID: 41
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x0600002A RID: 42 RVA: 0x000021C3 File Offset: 0x000003C3
		public Games()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002174 File Offset: 0x00000374
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000375C File Offset: 0x0000195C
		private void Games_Load(object sender, EventArgs e)
		{
			this.panel2.Visible = false;
			this.panel3.Visible = false;
			this.listPanel.Add(this.panel2);
			this.listPanel.Add(this.panel3);
			this.listPanel[this.i].BringToFront();
			this.listPanel[this.i].Visible = true;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000021DC File Offset: 0x000003DC
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Games.ReleaseCapture();
				Games.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002204 File Offset: 0x00000404
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Jxnt Scripts", "Credits");
			krnl.Pipe("loadstring(game:HttpGet('https://system-exodus.com/scripts/ninjalegends/NinjaLegendsV2.lua', true))()");
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002220 File Offset: 0x00000420
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/rT3UCQRs', true))();");
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000222C File Offset: 0x0000042C
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/cE6kQe1G', true))();");
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002238 File Offset: 0x00000438
		private void pictureBox4_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/J420Y71u', true))();");
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002244 File Offset: 0x00000444
		private void pictureBox5_Click(object sender, EventArgs e)
		{
			krnl.Pipe("\r\n                while wait(0.5) do\r\n                local stuff = workspace:getDescendants()\r\n                for i=1,#stuff do\r\n                if stuff[i].Name == 'Hitbox' then\r\n                if stuff[i].Parent.Name ~= game.Players.LocalPlayer.Name then\r\n                stuff[i].Massless = true\r\n                stuff[i].Size = Vector3.new (100,100,100)\r\n                stuff[i].Transparency = 0.5\r\n                end\r\n                end\r\n                end\r\n                end\r\n            ");
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002250 File Offset: 0x00000450
		private void pictureBox7_Click(object sender, EventArgs e)
		{
			krnl.Pipe("\r\n                _G.ServerHop = false\r\n                _G.PercentageToHop = 25\r\n                _G.AutoEquipMask = false\r\n                _G.RepFarm = false\r\n                _G.AogiriFarm = false\r\n                _G.CCGFarm = false\r\n                _G.HumanFarm = false\r\n                _G.FarmAll = false\r\n                _G.PlayAsGhoul = false\r\n                _G.PlayAsCCG = false\r\n\r\n                loadstring(game:HttpGet(('https://pastebin.com/raw/x9She8BF'),true))()\r\n            ");
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000225C File Offset: 0x0000045C
		private void pictureBox9_Click(object sender, EventArgs e)
		{
			krnl.Pipe("\r\n                local player = game.Players.LocalPlayer\r\n                local library = loadstring(game:HttpGet('https://pastebin.com/raw/JsdM2jiP',true))()\r\n                library.options.underlinecolor = 'rainbow'\r\n\r\n                -- Ranch Tab\r\n                local Ranch = library:CreateWindow('Ranch')\r\n                Ranch: Section('- Ranch -')\r\n                local Upgrade = Ranch:Toggle('Auto Upgrade Ranch', { flag = 'RU'})\r\n                local EquipBest = Ranch:Toggle('Auto Equip Pets', { flag = 'EP'})\r\n\r\n                --Auto Upgrade\r\n                spawn(function()\r\n                while wait(.01) do\r\n                                    if Ranch.flags.RU then\r\n                                    game:GetService('ReplicatedStorage').RemoteFunctions.MainRemoteFunction:InvokeServer('UpgradeRanch', false)\r\n                end\r\n                end\r\n                end)\r\n\r\n                --Auto Equip\r\n                spawn(function()\r\n                while wait(.01) do\r\n                                    if Ranch.flags.EP then\r\n                                    game:GetService('ReplicatedStorage').RemoteFunctions.MainRemoteFunction:InvokeServer('EquipTopPets')\r\n                end\r\n                end\r\n                end)\r\n            ");
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002268 File Offset: 0x00000468
		private void pictureBox8_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/bCYBdgTD', true))();");
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002274 File Offset: 0x00000474
		private void pictureBox6_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/ecVs72us', true))()");
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002280 File Offset: 0x00000480
		private void pictureBox10_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/p2wJy279', true))()");
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000228C File Offset: 0x0000048C
		private void pictureBox12_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/WBfWy8Md', true))()");
			MessageBox.Show("This script was created by Jxnt#9946!");
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000022A3 File Offset: 0x000004A3
		private void pictureBox11_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/Rge4t3Sh', true))()");
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000037D0 File Offset: 0x000019D0
		private void button2_Click(object sender, EventArgs e)
		{
			if (this.i < this.listPanel.Count - 1)
			{
				this.listPanel[this.i].Visible = false;
				List<Panel> list = this.listPanel;
				int index = this.i + 1;
				this.i = index;
				list[index].BringToFront();
				this.listPanel[this.i].Visible = true;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003844 File Offset: 0x00001A44
		private void button3_Click(object sender, EventArgs e)
		{
			if (this.i > 0)
			{
				this.listPanel[this.i].Visible = false;
				List<Panel> list = this.listPanel;
				int index = this.i - 1;
				this.i = index;
				list[index].BringToFront();
				this.listPanel[this.i].Visible = true;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000020EC File Offset: 0x000002EC
		private void pictureBox1_MouseHover(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000020EC File Offset: 0x000002EC
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0400001F RID: 31
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000020 RID: 32
		public const int HT_CAPTION = 2;

		// Token: 0x04000021 RID: 33
		private List<Panel> listPanel = new List<Panel>();

		// Token: 0x04000022 RID: 34
		private int i;
	}
}
