using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Microsoft.CSharp.RuntimeBinder;

namespace krnlss.Properties
{
	// Token: 0x02000031 RID: 49
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00002627 File Offset: 0x00000827
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000262E File Offset: 0x0000082E
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00002640 File Offset: 0x00000840
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Environment.CurrentDirectory + \"\\\\scripts\"")]
		public string ScriptPath
		{
			get
			{
				return (string)this["ScriptPath"];
			}
			set
			{
				this["ScriptPath"] = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000264E File Offset: 0x0000084E
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00002660 File Offset: 0x00000860
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("false")]
		public bool autoinject
		{
			get
			{
				return (bool)this["autoinject"];
			}
			set
			{
				this["autoinject"] = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00002673 File Offset: 0x00000873
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00002685 File Offset: 0x00000885
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("false")]
		public bool topmostchecked
		{
			get
			{
				return (bool)this["topmostchecked"];
			}
			set
			{
				this["topmostchecked"] = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00002698 File Offset: 0x00000898
		// (set) Token: 0x060000EC RID: 236 RVA: 0x000026AA File Offset: 0x000008AA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("true")]
		public bool fadein_out_opacity
		{
			get
			{
				return (bool)this["fadein_out_opacity"];
			}
			set
			{
				this["fadein_out_opacity"] = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000ED RID: 237 RVA: 0x000026BD File Offset: 0x000008BD
		// (set) Token: 0x060000EE RID: 238 RVA: 0x000026CF File Offset: 0x000008CF
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string cachedkey
		{
			get
			{
				return (string)this["cachedkey"];
			}
			set
			{
				this["cachedkey"] = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0001FB18 File Offset: 0x0001DD18
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x000026DD File Offset: 0x000008DD
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public DateTime timer
		{
			get
			{
				if (Settings.<>o__19.<>p__4 == null)
				{
					Settings.<>o__19.<>p__4 = CallSite<Func<CallSite, object, DateTime>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(DateTime), typeof(Settings)));
				}
				Func<CallSite, object, DateTime> target = Settings.<>o__19.<>p__4.Target;
				CallSite <>p__ = Settings.<>o__19.<>p__4;
				if (Settings.<>o__19.<>p__1 == null)
				{
					Settings.<>o__19.<>p__1 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Settings), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target2 = Settings.<>o__19.<>p__1.Target;
				CallSite <>p__2 = Settings.<>o__19.<>p__1;
				if (Settings.<>o__19.<>p__0 == null)
				{
					Settings.<>o__19.<>p__0 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Settings), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				object arg;
				if (!target2(<>p__2, Settings.<>o__19.<>p__0.Target(Settings.<>o__19.<>p__0, this["timer"], null)))
				{
					if (Settings.<>o__19.<>p__3 == null)
					{
						Settings.<>o__19.<>p__3 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToDateTime", null, typeof(Settings), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					arg = Settings.<>o__19.<>p__3.Target(Settings.<>o__19.<>p__3, typeof(Convert), this["timer"]);
				}
				else
				{
					if (Settings.<>o__19.<>p__2 == null)
					{
						Settings.<>o__19.<>p__2 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToDateTime", null, typeof(Settings), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					arg = Settings.<>o__19.<>p__2.Target(Settings.<>o__19.<>p__2, typeof(Convert), DateTime.Now);
				}
				return target(<>p__, arg);
			}
			set
			{
				this["timer"] = value;
			}
		}

		// Token: 0x04000449 RID: 1097
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
