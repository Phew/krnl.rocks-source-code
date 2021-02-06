using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace krnlss.Properties
{
	// Token: 0x02000030 RID: 48
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x000025EC File Offset: 0x000007EC
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceMan == null)
				{
					Resources.resourceMan = new ResourceManager("krnlss.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00002618 File Offset: 0x00000818
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x0000261F File Offset: 0x0000081F
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000214F File Offset: 0x0000034F
		internal Resources()
		{
		}

		// Token: 0x04000447 RID: 1095
		private static ResourceManager resourceMan;

		// Token: 0x04000448 RID: 1096
		private static CultureInfo resourceCulture;
	}
}
