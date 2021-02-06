using System;
using System.Windows.Forms;

namespace SirhurtUI.Controls
{
	// Token: 0x02000005 RID: 5
	public class TabPanelControl : UserControl
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002115 File Offset: 0x00000315
		public TabPanelControl()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002123 File Offset: 0x00000323
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.Name = "TabPanelControl";
			base.Load += this.TabPanelControl_Load;
			base.ResumeLayout(false);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000020EC File Offset: 0x000002EC
		private void TabPanelControl_Load(object sender, EventArgs e)
		{
		}
	}
}
