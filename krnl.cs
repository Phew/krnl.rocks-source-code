using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Controls;
using injection;
using krnlss.Properties;
using Microsoft.CSharp.RuntimeBinder;
using ScintillaNET;
using SirhurtUI.Controls;

namespace krnlss
{
	// Token: 0x0200000D RID: 13
	public partial class krnl : Form
	{
		// Token: 0x06000053 RID: 83
		[DllImport("user32.dll", SetLastError = true)]
		internal static extern IntPtr FindWindowA(string lpClassName, string lpWindowName);

		// Token: 0x06000054 RID: 84
		[DllImport("user32.dll", SetLastError = true)]
		private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

		// Token: 0x06000055 RID: 85
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000056 RID: 86
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000057 RID: 87 RVA: 0x00016F08 File Offset: 0x00015108
		public void PopulateTree(dynamic dir, TreeNode node)
		{
			try
			{
				if (krnl.<>o__60.<>p__0 == null)
				{
					krnl.<>o__60.<>p__0 = CallSite<Func<CallSite, Type, object, DirectoryInfo>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				object arg = krnl.<>o__60.<>p__0.Target(krnl.<>o__60.<>p__0, typeof(DirectoryInfo), dir);
				if (krnl.<>o__60.<>p__8 == null)
				{
					krnl.<>o__60.<>p__8 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(krnl)));
				}
				Func<CallSite, object, IEnumerable> target = krnl.<>o__60.<>p__8.Target;
				CallSite <>p__ = krnl.<>o__60.<>p__8;
				if (krnl.<>o__60.<>p__1 == null)
				{
					krnl.<>o__60.<>p__1 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "GetDirectories", null, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				foreach (object arg2 in target(<>p__, krnl.<>o__60.<>p__1.Target(krnl.<>o__60.<>p__1, arg)))
				{
					if (krnl.<>o__60.<>p__3 == null)
					{
						krnl.<>o__60.<>p__3 = CallSite<Func<CallSite, Type, object, TreeNode>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(krnl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, Type, object, TreeNode> target2 = krnl.<>o__60.<>p__3.Target;
					CallSite <>p__2 = krnl.<>o__60.<>p__3;
					Type typeFromHandle = typeof(TreeNode);
					if (krnl.<>o__60.<>p__2 == null)
					{
						krnl.<>o__60.<>p__2 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Name", typeof(krnl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					object obj = target2(<>p__2, typeFromHandle, krnl.<>o__60.<>p__2.Target(krnl.<>o__60.<>p__2, arg2));
					if (node == null)
					{
						if (krnl.<>o__60.<>p__4 == null)
						{
							krnl.<>o__60.<>p__4 = CallSite<Action<CallSite, TreeNodeCollection, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Add", null, typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						krnl.<>o__60.<>p__4.Target(krnl.<>o__60.<>p__4, this.ScriptView.Nodes, obj);
					}
					else
					{
						if (krnl.<>o__60.<>p__5 == null)
						{
							krnl.<>o__60.<>p__5 = CallSite<Action<CallSite, TreeNodeCollection, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Add", null, typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						krnl.<>o__60.<>p__5.Target(krnl.<>o__60.<>p__5, node.Nodes, obj);
					}
					if (krnl.<>o__60.<>p__7 == null)
					{
						krnl.<>o__60.<>p__7 = CallSite<Action<CallSite, krnl, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "PopulateTree", null, typeof(krnl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Action<CallSite, krnl, object, object> target3 = krnl.<>o__60.<>p__7.Target;
					CallSite <>p__3 = krnl.<>o__60.<>p__7;
					if (krnl.<>o__60.<>p__6 == null)
					{
						krnl.<>o__60.<>p__6 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "FullName", typeof(krnl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					target3(<>p__3, this, krnl.<>o__60.<>p__6.Target(krnl.<>o__60.<>p__6, arg2), obj);
				}
				if (krnl.<>o__60.<>p__14 == null)
				{
					krnl.<>o__60.<>p__14 = CallSite<Func<CallSite, object, IEnumerable>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(IEnumerable), typeof(krnl)));
				}
				Func<CallSite, object, IEnumerable> target4 = krnl.<>o__60.<>p__14.Target;
				CallSite <>p__4 = krnl.<>o__60.<>p__14;
				if (krnl.<>o__60.<>p__9 == null)
				{
					krnl.<>o__60.<>p__9 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "GetFiles", null, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				foreach (object arg3 in target4(<>p__4, krnl.<>o__60.<>p__9.Target(krnl.<>o__60.<>p__9, arg)))
				{
					if (krnl.<>o__60.<>p__11 == null)
					{
						krnl.<>o__60.<>p__11 = CallSite<Func<CallSite, Type, object, TreeNode>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(krnl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, Type, object, TreeNode> target5 = krnl.<>o__60.<>p__11.Target;
					CallSite <>p__5 = krnl.<>o__60.<>p__11;
					Type typeFromHandle2 = typeof(TreeNode);
					if (krnl.<>o__60.<>p__10 == null)
					{
						krnl.<>o__60.<>p__10 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Name", typeof(krnl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					object arg4 = target5(<>p__5, typeFromHandle2, krnl.<>o__60.<>p__10.Target(krnl.<>o__60.<>p__10, arg3));
					if (node != null)
					{
						if (krnl.<>o__60.<>p__12 == null)
						{
							krnl.<>o__60.<>p__12 = CallSite<Action<CallSite, TreeNodeCollection, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Add", null, typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						krnl.<>o__60.<>p__12.Target(krnl.<>o__60.<>p__12, node.Nodes, arg4);
					}
					else
					{
						if (krnl.<>o__60.<>p__13 == null)
						{
							krnl.<>o__60.<>p__13 = CallSite<Action<CallSite, TreeNodeCollection, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Add", null, typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						krnl.<>o__60.<>p__13.Target(krnl.<>o__60.<>p__13, this.ScriptView.Nodes, arg4);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000174E0 File Offset: 0x000156E0
		private void ScriptLoading()
		{
			try
			{
				object arg = Directory.Exists(Settings.Default.ScriptPath);
				if (krnl.<>o__61.<>p__1 == null)
				{
					krnl.<>o__61.<>p__1 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target = krnl.<>o__61.<>p__1.Target;
				CallSite <>p__ = krnl.<>o__61.<>p__1;
				if (krnl.<>o__61.<>p__0 == null)
				{
					krnl.<>o__61.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.Not, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (target(<>p__, krnl.<>o__61.<>p__0.Target(krnl.<>o__61.<>p__0, arg)))
				{
					if (krnl.<>o__61.<>p__2 == null)
					{
						krnl.<>o__61.<>p__2 = CallSite<Action<CallSite, Type, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "CreateDirectory", null, typeof(krnl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					krnl.<>o__61.<>p__2.Target(krnl.<>o__61.<>p__2, typeof(Directory), Settings.Default.ScriptPath);
				}
			}
			catch
			{
			}
			if (krnl.<>o__61.<>p__3 == null)
			{
				krnl.<>o__61.<>p__3 = CallSite<Action<CallSite, krnl, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "PopulateTree", null, typeof(krnl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			krnl.<>o__61.<>p__3.Target(krnl.<>o__61.<>p__3, this, Settings.Default.ScriptPath, null);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00017694 File Offset: 0x00015894
		public krnl()
		{
			if (krnl.<>o__62.<>p__0 == null)
			{
				krnl.<>o__62.<>p__0 = CallSite<Func<CallSite, object, TabPanelControl>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(TabPanelControl), typeof(krnl)));
			}
			this.tpc = krnl.<>o__62.<>p__0.Target(krnl.<>o__62.<>p__0, new TabPanelControl());
			this.mWidth = 20;
			base..ctor();
			AppDomain.CurrentDomain.UnhandledException += this.CurrentDomain_UnhandledException;
			this.InitializeComponent();
			if (krnl.<>o__62.<>p__0 == null)
			{
				krnl.<>o__62.<>p__0 = CallSite<Func<CallSite, object, krnl>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(krnl), typeof(krnl)));
			}
			CustomTabControl.Form1 = krnl.<>o__62.<>p__0.Target(krnl.<>o__62.<>p__0, this);
			this.customTabControl1.ShowClosingButton = true;
			if (krnl.<>o__62.<>p__2 == null)
			{
				krnl.<>o__62.<>p__2 = CallSite<Action<CallSite, Control.ControlCollection, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Add", null, typeof(krnl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Action<CallSite, Control.ControlCollection, object> target = krnl.<>o__62.<>p__2.Target;
			CallSite <>p__ = krnl.<>o__62.<>p__2;
			Control.ControlCollection controls = this.customTabControl1.TabPages[0].Controls;
			if (krnl.<>o__62.<>p__1 == null)
			{
				krnl.<>o__62.<>p__1 = CallSite<Func<CallSite, CustomTabControl, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "NewEditor", null, typeof(krnl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			target(<>p__, controls, krnl.<>o__62.<>p__1.Target(krnl.<>o__62.<>p__1, this.customTabControl1, ""));
			if (krnl.<>o__62.<>p__3 == null)
			{
				krnl.<>o__62.<>p__3 = CallSite<Func<CallSite, Type, object, object, Thread>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(krnl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Thread thread = krnl.<>o__62.<>p__3.Target(krnl.<>o__62.<>p__3, typeof(Thread), new ThreadStart(this.shit), 1024);
			if (krnl.<>o__62.<>p__4 == null)
			{
				krnl.<>o__62.<>p__4 = CallSite<Func<CallSite, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "IsBackground", typeof(krnl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			krnl.<>o__62.<>p__4.Target(krnl.<>o__62.<>p__4, thread, true);
			thread.ApartmentState = ApartmentState.MTA;
			if (krnl.<>o__62.<>p__5 == null)
			{
				krnl.<>o__62.<>p__5 = CallSite<Action<CallSite, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Start", null, typeof(krnl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			krnl.<>o__62.<>p__5.Target(krnl.<>o__62.<>p__5, thread);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00017974 File Offset: 0x00015B74
		private void shit()
		{
			for (;;)
			{
				Process[] processes = Process.GetProcesses();
				for (int i = 0; i < processes.Length; i++)
				{
					try
					{
						Process process = processes[i];
						if (krnl.<>o__63.<>p__0 == null)
						{
							krnl.<>o__63.<>p__0 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(krnl)));
						}
						string text = krnl.<>o__63.<>p__0.Target(krnl.<>o__63.<>p__0, "");
						if (krnl.<>o__63.<>p__1 == null)
						{
							krnl.<>o__63.<>p__1 = CallSite<Func<CallSite, object, Type>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(Type), typeof(krnl)));
						}
						Type arg = krnl.<>o__63.<>p__1.Target(krnl.<>o__63.<>p__1, null);
						if (krnl.<>o__63.<>p__3 == null)
						{
							krnl.<>o__63.<>p__3 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, bool> target = krnl.<>o__63.<>p__3.Target;
						CallSite <>p__ = krnl.<>o__63.<>p__3;
						if (krnl.<>o__63.<>p__2 == null)
						{
							krnl.<>o__63.<>p__2 = CallSite<Func<CallSite, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						if (target(<>p__, krnl.<>o__63.<>p__2.Target(krnl.<>o__63.<>p__2, arg, null)) && !File.Exists(process.MainModule.FileName) && process.Id != Process.GetCurrentProcess().Id)
						{
							process.Kill();
							return;
						}
						if (krnl.<>o__63.<>p__5 == null)
						{
							krnl.<>o__63.<>p__5 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, bool> target2 = krnl.<>o__63.<>p__5.Target;
						CallSite <>p__2 = krnl.<>o__63.<>p__5;
						if (krnl.<>o__63.<>p__4 == null)
						{
							krnl.<>o__63.<>p__4 = CallSite<Func<CallSite, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						if (target2(<>p__2, krnl.<>o__63.<>p__4.Target(krnl.<>o__63.<>p__4, arg, null)))
						{
							try
							{
								if (krnl.<>o__63.<>p__10 == null)
								{
									krnl.<>o__63.<>p__10 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(krnl)));
								}
								Func<CallSite, object, string> target3 = krnl.<>o__63.<>p__10.Target;
								CallSite <>p__3 = krnl.<>o__63.<>p__10;
								if (krnl.<>o__63.<>p__9 == null)
								{
									krnl.<>o__63.<>p__9 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "ToLower", null, typeof(krnl), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								Func<CallSite, object, object> target4 = krnl.<>o__63.<>p__9.Target;
								CallSite <>p__4 = krnl.<>o__63.<>p__9;
								if (krnl.<>o__63.<>p__8 == null)
								{
									krnl.<>o__63.<>p__8 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "FileDescription", typeof(krnl), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								Func<CallSite, object, object> target5 = krnl.<>o__63.<>p__8.Target;
								CallSite <>p__5 = krnl.<>o__63.<>p__8;
								if (krnl.<>o__63.<>p__7 == null)
								{
									krnl.<>o__63.<>p__7 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "FileVersionInfo", typeof(krnl), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								Func<CallSite, object, object> target6 = krnl.<>o__63.<>p__7.Target;
								CallSite <>p__6 = krnl.<>o__63.<>p__7;
								if (krnl.<>o__63.<>p__6 == null)
								{
									krnl.<>o__63.<>p__6 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "MainModule", typeof(krnl), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								text = target3(<>p__3, target4(<>p__4, target5(<>p__5, target6(<>p__6, krnl.<>o__63.<>p__6.Target(krnl.<>o__63.<>p__6, process)))));
								if (krnl.<>o__63.<>p__14 == null)
								{
									krnl.<>o__63.<>p__14 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(krnl), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								Func<CallSite, object, bool> target7 = krnl.<>o__63.<>p__14.Target;
								CallSite <>p__7 = krnl.<>o__63.<>p__14;
								if (krnl.<>o__63.<>p__11 == null)
								{
									krnl.<>o__63.<>p__11 = CallSite<Func<CallSite, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(krnl), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								object obj = krnl.<>o__63.<>p__11.Target(krnl.<>o__63.<>p__11, text, "");
								if (krnl.<>o__63.<>p__13 == null)
								{
									krnl.<>o__63.<>p__13 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsFalse, typeof(krnl), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								object arg2;
								if (!krnl.<>o__63.<>p__13.Target(krnl.<>o__63.<>p__13, obj))
								{
									if (krnl.<>o__63.<>p__12 == null)
									{
										krnl.<>o__63.<>p__12 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.And, typeof(krnl), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
										}));
									}
									arg2 = krnl.<>o__63.<>p__12.Target(krnl.<>o__63.<>p__12, obj, "windowsformsapp107".IndexOf(text) != -1 || (text.IndexOf("krnl") != -1 && (text.IndexOf("bypass") != -1 || text.IndexOf("keygen") != -1)));
								}
								else
								{
									arg2 = obj;
								}
								if (target7(<>p__7, arg2))
								{
									process.Kill();
								}
							}
							catch (Win32Exception arg3)
							{
								if (krnl.<>o__63.<>p__16 == null)
								{
									krnl.<>o__63.<>p__16 = CallSite<Func<CallSite, object, Type>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(Type), typeof(krnl)));
								}
								Func<CallSite, object, Type> target8 = krnl.<>o__63.<>p__16.Target;
								CallSite <>p__8 = krnl.<>o__63.<>p__16;
								if (krnl.<>o__63.<>p__15 == null)
								{
									krnl.<>o__63.<>p__15 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "GetType", null, typeof(krnl), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								arg = target8(<>p__8, krnl.<>o__63.<>p__15.Target(krnl.<>o__63.<>p__15, arg3));
							}
						}
						if (krnl.<>o__63.<>p__18 == null)
						{
							krnl.<>o__63.<>p__18 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, bool> target9 = krnl.<>o__63.<>p__18.Target;
						CallSite <>p__9 = krnl.<>o__63.<>p__18;
						if (krnl.<>o__63.<>p__17 == null)
						{
							krnl.<>o__63.<>p__17 = CallSite<Func<CallSite, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						if (target9(<>p__9, krnl.<>o__63.<>p__17.Target(krnl.<>o__63.<>p__17, arg, null)))
						{
							try
							{
								if (krnl.<>o__63.<>p__23 == null)
								{
									krnl.<>o__63.<>p__23 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(krnl)));
								}
								Func<CallSite, object, string> target10 = krnl.<>o__63.<>p__23.Target;
								CallSite <>p__10 = krnl.<>o__63.<>p__23;
								if (krnl.<>o__63.<>p__22 == null)
								{
									krnl.<>o__63.<>p__22 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "ToLower", null, typeof(krnl), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								Func<CallSite, object, object> target11 = krnl.<>o__63.<>p__22.Target;
								CallSite <>p__11 = krnl.<>o__63.<>p__22;
								if (krnl.<>o__63.<>p__21 == null)
								{
									krnl.<>o__63.<>p__21 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "FileDescription", typeof(krnl), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								Func<CallSite, object, object> target12 = krnl.<>o__63.<>p__21.Target;
								CallSite <>p__12 = krnl.<>o__63.<>p__21;
								if (krnl.<>o__63.<>p__20 == null)
								{
									krnl.<>o__63.<>p__20 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "FileVersionInfo", typeof(krnl), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								Func<CallSite, object, object> target13 = krnl.<>o__63.<>p__20.Target;
								CallSite <>p__13 = krnl.<>o__63.<>p__20;
								if (krnl.<>o__63.<>p__19 == null)
								{
									krnl.<>o__63.<>p__19 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "MainModule", typeof(krnl), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								text = target10(<>p__10, target11(<>p__11, target12(<>p__12, target13(<>p__13, krnl.<>o__63.<>p__19.Target(krnl.<>o__63.<>p__19, process)))));
								if (krnl.<>o__63.<>p__27 == null)
								{
									krnl.<>o__63.<>p__27 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(krnl), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								Func<CallSite, object, bool> target14 = krnl.<>o__63.<>p__27.Target;
								CallSite <>p__14 = krnl.<>o__63.<>p__27;
								if (krnl.<>o__63.<>p__24 == null)
								{
									krnl.<>o__63.<>p__24 = CallSite<Func<CallSite, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(krnl), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								object obj = krnl.<>o__63.<>p__24.Target(krnl.<>o__63.<>p__24, text, "");
								if (krnl.<>o__63.<>p__26 == null)
								{
									krnl.<>o__63.<>p__26 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsFalse, typeof(krnl), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								object arg4;
								if (!krnl.<>o__63.<>p__26.Target(krnl.<>o__63.<>p__26, obj))
								{
									if (krnl.<>o__63.<>p__25 == null)
									{
										krnl.<>o__63.<>p__25 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.And, typeof(krnl), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
										}));
									}
									arg4 = krnl.<>o__63.<>p__25.Target(krnl.<>o__63.<>p__25, obj, "windowsformsapp107".IndexOf(text) != -1 || (text.IndexOf("krnl") != -1 && (text.IndexOf("bypass") != -1 || text.IndexOf("keygen") != -1)));
								}
								else
								{
									arg4 = obj;
								}
								if (target14(<>p__14, arg4))
								{
									process.Kill();
								}
							}
							catch (InvalidOperationException arg5)
							{
								if (krnl.<>o__63.<>p__29 == null)
								{
									krnl.<>o__63.<>p__29 = CallSite<Func<CallSite, object, Type>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(Type), typeof(krnl)));
								}
								Func<CallSite, object, Type> target15 = krnl.<>o__63.<>p__29.Target;
								CallSite <>p__15 = krnl.<>o__63.<>p__29;
								if (krnl.<>o__63.<>p__28 == null)
								{
									krnl.<>o__63.<>p__28 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "GetType", null, typeof(krnl), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
									}));
								}
								arg = target15(<>p__15, krnl.<>o__63.<>p__28.Target(krnl.<>o__63.<>p__28, arg5));
							}
						}
					}
					catch
					{
					}
				}
				if (krnl.<>o__63.<>p__32 == null)
				{
					krnl.<>o__63.<>p__32 = CallSite<Action<CallSite, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "GetResult", null, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Action<CallSite, object> target16 = krnl.<>o__63.<>p__32.Target;
				CallSite <>p__16 = krnl.<>o__63.<>p__32;
				if (krnl.<>o__63.<>p__31 == null)
				{
					krnl.<>o__63.<>p__31 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "GetAwaiter", null, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object> target17 = krnl.<>o__63.<>p__31.Target;
				CallSite <>p__17 = krnl.<>o__63.<>p__31;
				if (krnl.<>o__63.<>p__30 == null)
				{
					krnl.<>o__63.<>p__30 = CallSite<Func<CallSite, Type, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "Delay", null, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				target16(<>p__16, target17(<>p__17, krnl.<>o__63.<>p__30.Target(krnl.<>o__63.<>p__30, typeof(Task), 1000)));
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000184B0 File Offset: 0x000166B0
		private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			Exception ex = (Exception)e.ExceptionObject;
			string path = "error.txt";
			string separator = "\n";
			string[] array = new string[7];
			array[0] = "Message: " + ex.Message;
			array[1] = "StackTrace: " + ex.StackTrace;
			array[2] = "Source: " + ex.Source;
			int num = 3;
			string str = "TargetSite: ";
			MethodBase targetSite = ex.TargetSite;
			array[num] = str + ((targetSite != null) ? targetSite.ToString() : null);
			array[4] = "HResult: " + ex.HResult.ToString();
			array[5] = "HelpLink: " + ex.HelpLink;
			array[6] = "Values: [ " + string.Join("\n", new object[]
			{
				ex.Data.Values
			}) + " ]";
			File.WriteAllText(path, string.Join(separator, array));
			MessageBox.Show("Send `error.txt` to krnl server", "Caught an oopsies!");
			DialogResult dialogResult = MessageBox.Show("Click `Yes` if you want to get an invite to krnl discord server.", "Krnl Prompt", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				Process.Start("https://discord.gg/pHShx9M");
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000185CC File Offset: 0x000167CC
		private void Form1_Load(object sender, EventArgs e)
		{
			this.bunifuFlatButton7.Click += delegate(object se, EventArgs m)
			{
				Process.Start("https://wearedevs.net");
			};
			if (!Directory.Exists(Settings.Default.ScriptPath))
			{
				Settings @default = Settings.Default;
				if (krnl.<>o__65.<>p__1 == null)
				{
					krnl.<>o__65.<>p__1 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(krnl)));
				}
				Func<CallSite, object, string> target = krnl.<>o__65.<>p__1.Target;
				CallSite <>p__ = krnl.<>o__65.<>p__1;
				if (krnl.<>o__65.<>p__0 == null)
				{
					krnl.<>o__65.<>p__0 = CallSite<Func<CallSite, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				@default.ScriptPath = target(<>p__, krnl.<>o__65.<>p__0.Target(krnl.<>o__65.<>p__0, Environment.CurrentDirectory, "\\scripts"));
			}
			this.menuStrip1.Renderer = new ToolStripProfessionalRenderer(new krnl.BrowserColors());
			this.customTabControl1.AddEvent("Script.lua", "");
			this.ScriptLoading();
			this.Anim_ATF_break = true;
			this.anim_AwaitingTaskFinish();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000186F8 File Offset: 0x000168F8
		private async void button1_Click(object sender, EventArgs e)
		{
			while (base.Opacity > 0.0)
			{
				await Task.Delay(10);
				base.Opacity -= 0.1;
			}
			Environment.Exit(Environment.ExitCode);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002340 File Offset: 0x00000540
		private void button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000020EC File Offset: 0x000002EC
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002349 File Offset: 0x00000549
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				krnl.ReleaseCapture();
				krnl.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000020EC File Offset: 0x000002EC
		private void tabPage1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00018734 File Offset: 0x00016934
		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (krnl.<>o__71.<>p__0 == null)
			{
				krnl.<>o__71.<>p__0 = CallSite<Func<CallSite, object, TabPage>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(TabPage), typeof(krnl)));
			}
			TabPage tab = krnl.<>o__71.<>p__0.Target(krnl.<>o__71.<>p__0, this.customTabControl1.contextTab);
			this.customTabControl1.CloseTab(tab);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00018798 File Offset: 0x00016998
		private void clearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Scintilla scintilla = this.customTabControl1.contextTab.Controls[0] as Scintilla;
			Control control = scintilla;
			if (krnl.<>o__72.<>p__0 == null)
			{
				krnl.<>o__72.<>p__0 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(krnl)));
			}
			control.Text = krnl.<>o__72.<>p__0.Target(krnl.<>o__72.<>p__0, "");
			scintilla.Refresh();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00018814 File Offset: 0x00016A14
		private void openIntoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (krnl.<>o__73.<>p__0 == null)
			{
				krnl.<>o__73.<>p__0 = CallSite<Func<CallSite, object, TabPage>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(TabPage), typeof(krnl)));
			}
			TabPage tabPage = krnl.<>o__73.<>p__0.Target(krnl.<>o__73.<>p__0, this.customTabControl1.contextTab);
			if (tabPage == null)
			{
				throw new Exception("SELECTED TAB NOT FOUND");
			}
			if (krnl.<>o__73.<>p__8 == null)
			{
				krnl.<>o__73.<>p__8 = CallSite<Func<CallSite, object, OpenFileDialog>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(OpenFileDialog), typeof(krnl)));
			}
			using (OpenFileDialog openFileDialog = krnl.<>o__73.<>p__8.Target(krnl.<>o__73.<>p__8, new OpenFileDialog()))
			{
				FileDialog fileDialog = openFileDialog;
				if (krnl.<>o__73.<>p__1 == null)
				{
					krnl.<>o__73.<>p__1 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(bool), typeof(krnl)));
				}
				fileDialog.CheckFileExists = krnl.<>o__73.<>p__1.Target(krnl.<>o__73.<>p__1, true);
				FileDialog fileDialog2 = openFileDialog;
				if (krnl.<>o__73.<>p__2 == null)
				{
					krnl.<>o__73.<>p__2 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(krnl)));
				}
				fileDialog2.Filter = krnl.<>o__73.<>p__2.Target(krnl.<>o__73.<>p__2, "Script Files (*.txt, *.lua)|*.txt;*.lua|All Files (*.*)|*.*");
				FileDialog fileDialog3 = openFileDialog;
				if (krnl.<>o__73.<>p__3 == null)
				{
					krnl.<>o__73.<>p__3 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(bool), typeof(krnl)));
				}
				fileDialog3.RestoreDirectory = krnl.<>o__73.<>p__3.Target(krnl.<>o__73.<>p__3, true);
				if (krnl.<>o__73.<>p__5 == null)
				{
					krnl.<>o__73.<>p__5 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target = krnl.<>o__73.<>p__5.Target;
				CallSite <>p__ = krnl.<>o__73.<>p__5;
				if (krnl.<>o__73.<>p__4 == null)
				{
					krnl.<>o__73.<>p__4 = CallSite<Func<CallSite, DialogResult, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (target(<>p__, krnl.<>o__73.<>p__4.Target(krnl.<>o__73.<>p__4, openFileDialog.ShowDialog(), DialogResult.OK)))
				{
					Control control = tabPage;
					if (krnl.<>o__73.<>p__6 == null)
					{
						krnl.<>o__73.<>p__6 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(krnl)));
					}
					control.Text = krnl.<>o__73.<>p__6.Target(krnl.<>o__73.<>p__6, Path.GetFileNameWithoutExtension(openFileDialog.SafeFileName));
					object arg = File.ReadAllText(openFileDialog.FileName);
					Scintilla scintilla = tabPage.Controls[0] as Scintilla;
					Control control2 = scintilla;
					if (krnl.<>o__73.<>p__7 == null)
					{
						krnl.<>o__73.<>p__7 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(krnl)));
					}
					control2.Text = krnl.<>o__73.<>p__7.Target(krnl.<>o__73.<>p__7, arg);
					scintilla.Refresh();
				}
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00018B2C File Offset: 0x00016D2C
		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (krnl.<>o__74.<>p__0 == null)
			{
				krnl.<>o__74.<>p__0 = CallSite<Func<CallSite, object, TabPage>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(TabPage), typeof(krnl)));
			}
			TabPage tabPage = krnl.<>o__74.<>p__0.Target(krnl.<>o__74.<>p__0, this.customTabControl1.contextTab);
			if (tabPage == null)
			{
				throw new Exception("TAB NOT FOUND");
			}
			Control control = tabPage;
			if (krnl.<>o__74.<>p__2 == null)
			{
				krnl.<>o__74.<>p__2 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(krnl)));
			}
			Func<CallSite, object, string> target = krnl.<>o__74.<>p__2.Target;
			CallSite <>p__ = krnl.<>o__74.<>p__2;
			if (krnl.<>o__74.<>p__1 == null)
			{
				krnl.<>o__74.<>p__1 = CallSite<Func<CallSite, CustomTabControl, TabPage, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "OpenSaveDialog", null, typeof(krnl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			control.Text = target(<>p__, krnl.<>o__74.<>p__1.Target(krnl.<>o__74.<>p__1, this.customTabControl1, tabPage, tabPage.Controls[0].Text));
		}

		// Token: 0x06000066 RID: 102
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool WaitNamedPipe(string name, int timeout);

		// Token: 0x06000067 RID: 103 RVA: 0x00002371 File Offset: 0x00000571
		private static bool findpipe(string pipeName)
		{
			return krnl.WaitNamedPipe(Path.GetFullPath("\\\\.\\pipe\\" + pipeName), 0) || (Marshal.GetLastWin32Error() != 0 && Marshal.GetLastWin32Error() != 2);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00018C50 File Offset: 0x00016E50
		public static void pipeshit(string script)
		{
			try
			{
				if (krnl.findpipe("krnlpipe"))
				{
					using (NamedPipeClientStream namedPipeClientStream = new NamedPipeClientStream(".", "krnlpipe", PipeDirection.Out))
					{
						namedPipeClientStream.Connect();
						if (!namedPipeClientStream.IsConnected)
						{
							throw new IOException("Failed To Connect To Pipe....");
						}
						StreamWriter streamWriter = new StreamWriter(namedPipeClientStream, Encoding.Default, 999999);
						streamWriter.Write(script);
						streamWriter.Dispose();
						goto IL_70;
					}
				}
				MessageBox.Show("Please Inject To Execute Scripts", "krnl");
				IL_70:;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000239D File Offset: 0x0000059D
		public static void Pipe(string script)
		{
			if (krnl.findpipe("krnlpipe"))
			{
				krnl.pipeshit(script);
				return;
			}
			MessageBox.Show("Please Inject To Execute Scripts", "krnl");
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00018CF0 File Offset: 0x00016EF0
		private void bunifuFlatButton1_Click(object sender, EventArgs e)
		{
			try
			{
				krnl.Pipe(this.customTabControl1.GetWorkingTextEditor().Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000023C2 File Offset: 0x000005C2
		private void bunifuFlatButton2_Click(object sender, EventArgs e)
		{
			this.customTabControl1.GetWorkingTextEditor().Text = "";
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00018D34 File Offset: 0x00016F34
		private void bunifuFlatButton3_Click(object sender, EventArgs e)
		{
			if (krnl.<>o__81.<>p__0 == null)
			{
				krnl.<>o__81.<>p__0 = CallSite<Action<CallSite, CustomTabControl, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "OpenFileDialog", null, typeof(krnl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			krnl.<>o__81.<>p__0.Target(krnl.<>o__81.<>p__0, this.customTabControl1, this.customTabControl1.SelectedTab);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00018DAC File Offset: 0x00016FAC
		private void bunifuFlatButton4_Click(object sender, EventArgs e)
		{
			this.ScriptView.Nodes.Clear();
			this.ScriptLoading();
			if (krnl.<>o__82.<>p__0 == null)
			{
				krnl.<>o__82.<>p__0 = CallSite<Action<CallSite, CustomTabControl, TabPage, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "OpenSaveDialog", null, typeof(krnl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			krnl.<>o__82.<>p__0.Target(krnl.<>o__82.<>p__0, this.customTabControl1, this.customTabControl1.SelectedTab, this.customTabControl1.GetWorkingTextEditor().Text);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000020EC File Offset: 0x000002EC
		private void injectToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00018E54 File Offset: 0x00017054
		private bool injectdll(dynamic filename, int PID)
		{
			krnlgay.krnlgayResult krnlgayResult = krnlgay.DllInjector.GetInstance.Inject(Application.StartupPath + string.Format("\\\\{0}", filename), PID, false);
			string text = "";
			string text2 = "";
			if (krnlgayResult == krnlgay.krnlgayResult.DllNotFound)
			{
				text = string.Format("{0} is missing!", filename);
			}
			if (krnlgayResult == krnlgay.krnlgayResult.Failed)
			{
				text = "Failed to inject for unknown reason.";
			}
			if (krnlgayResult == krnlgay.krnlgayResult.Success)
			{
				krnl.injectedPID = PID;
			}
			if (krnlgayResult == krnlgay.krnlgayResult.threaderr)
			{
				text = "Caught Thread Error";
				text2 = "Unknown Error";
			}
			if (!string.IsNullOrEmpty(text))
			{
				MessageBox.Show(text, (text2 != "") ? text2 : "Krnl Error");
				return false;
			}
			return true;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000023D9 File Offset: 0x000005D9
		private void bunifuFlatButton5_Click(object sender, EventArgs e)
		{
			new Thread(delegate(object d)
			{
				IntPtr intPtr = krnl.FindWindowA("WINDOWSCLIENT", "Roblox");
				Process[] processesByName = Process.GetProcessesByName("RobloxPlayerBeta");
				int pid = 0;
				krnl.GetWindowThreadProcessId(intPtr, out pid);
				if (intPtr != IntPtr.Zero)
				{
					string[] array = new string[]
					{
						"Indicium-Supra",
						"krnl"
					};
					for (int i = 0; i < array.Length; i++)
					{
						if (!this.injectdll(array[i] + ".dll", pid))
						{
							return;
						}
						Task.Delay(10).GetAwaiter().GetResult();
						this.anim_CompletedTask();
					}
					return;
				}
				MessageBox.Show("Roblox Process Not Found", "Krnl");
			}).Start();
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00018EEC File Offset: 0x000170EC
		private void executeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				object fullPath = this.ScriptView.SelectedNode.FullPath;
				if (krnl.<>o__86.<>p__2 == null)
				{
					krnl.<>o__86.<>p__2 = CallSite<Func<CallSite, Type, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "ReadAllText", null, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, Type, object, object> target = krnl.<>o__86.<>p__2.Target;
				CallSite <>p__ = krnl.<>o__86.<>p__2;
				Type typeFromHandle = typeof(File);
				if (krnl.<>o__86.<>p__1 == null)
				{
					krnl.<>o__86.<>p__1 = CallSite<Func<CallSite, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object, object> target2 = krnl.<>o__86.<>p__1.Target;
				CallSite <>p__2 = krnl.<>o__86.<>p__1;
				if (krnl.<>o__86.<>p__0 == null)
				{
					krnl.<>o__86.<>p__0 = CallSite<Func<CallSite, string, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				object arg = target(<>p__, typeFromHandle, target2(<>p__2, krnl.<>o__86.<>p__0.Target(krnl.<>o__86.<>p__0, Settings.Default.ScriptPath, "//"), fullPath));
				if (krnl.<>o__86.<>p__3 == null)
				{
					krnl.<>o__86.<>p__3 = CallSite<Action<CallSite, krnl, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName | CSharpBinderFlags.ResultDiscarded, "Pipe", null, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				krnl.<>o__86.<>p__3.Target(krnl.<>o__86.<>p__3, this, arg);
			}
			catch
			{
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00019098 File Offset: 0x00017298
		private void loadIntoEditorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				object fullPath = this.ScriptView.SelectedNode.FullPath;
				if (krnl.<>o__87.<>p__2 == null)
				{
					krnl.<>o__87.<>p__2 = CallSite<Func<CallSite, Type, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "ReadAllText", null, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, Type, object, object> target = krnl.<>o__87.<>p__2.Target;
				CallSite <>p__ = krnl.<>o__87.<>p__2;
				Type typeFromHandle = typeof(File);
				if (krnl.<>o__87.<>p__1 == null)
				{
					krnl.<>o__87.<>p__1 = CallSite<Func<CallSite, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object, object> target2 = krnl.<>o__87.<>p__1.Target;
				CallSite <>p__2 = krnl.<>o__87.<>p__1;
				if (krnl.<>o__87.<>p__0 == null)
				{
					krnl.<>o__87.<>p__0 = CallSite<Func<CallSite, string, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				object arg = target(<>p__, typeFromHandle, target2(<>p__2, krnl.<>o__87.<>p__0.Target(krnl.<>o__87.<>p__0, Settings.Default.ScriptPath, "//"), fullPath));
				Control workingTextEditor = this.customTabControl1.GetWorkingTextEditor();
				if (krnl.<>o__87.<>p__3 == null)
				{
					krnl.<>o__87.<>p__3 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(krnl)));
				}
				workingTextEditor.Text = krnl.<>o__87.<>p__3.Target(krnl.<>o__87.<>p__3, arg);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00019238 File Offset: 0x00017438
		private void deleteFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				object fullPath = this.ScriptView.SelectedNode.FullPath;
				if (krnl.<>o__88.<>p__2 == null)
				{
					krnl.<>o__88.<>p__2 = CallSite<Action<CallSite, Type, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Delete", null, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Action<CallSite, Type, object> target = krnl.<>o__88.<>p__2.Target;
				CallSite <>p__ = krnl.<>o__88.<>p__2;
				Type typeFromHandle = typeof(File);
				if (krnl.<>o__88.<>p__1 == null)
				{
					krnl.<>o__88.<>p__1 = CallSite<Func<CallSite, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object, object> target2 = krnl.<>o__88.<>p__1.Target;
				CallSite <>p__2 = krnl.<>o__88.<>p__1;
				if (krnl.<>o__88.<>p__0 == null)
				{
					krnl.<>o__88.<>p__0 = CallSite<Func<CallSite, string, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				target(<>p__, typeFromHandle, target2(<>p__2, krnl.<>o__88.<>p__0.Target(krnl.<>o__88.<>p__0, Settings.Default.ScriptPath, "//"), fullPath));
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0001938C File Offset: 0x0001758C
		private void changePathToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				object arg = new FolderBrowserDialog();
				if (krnl.<>o__89.<>p__11 == null)
				{
					krnl.<>o__89.<>p__11 = CallSite<Func<CallSite, object, IDisposable>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(IDisposable), typeof(krnl)));
				}
				using (krnl.<>o__89.<>p__11.Target(krnl.<>o__89.<>p__11, arg))
				{
					if (krnl.<>o__89.<>p__1 == null)
					{
						krnl.<>o__89.<>p__1 = CallSite<Func<CallSite, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(krnl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, object, object> target = krnl.<>o__89.<>p__1.Target;
					CallSite <>p__ = krnl.<>o__89.<>p__1;
					if (krnl.<>o__89.<>p__0 == null)
					{
						krnl.<>o__89.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "ShowDialog", null, typeof(krnl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					object obj = target(<>p__, krnl.<>o__89.<>p__0.Target(krnl.<>o__89.<>p__0, arg), DialogResult.OK);
					if (krnl.<>o__89.<>p__6 == null)
					{
						krnl.<>o__89.<>p__6 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsFalse, typeof(krnl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					object obj2;
					if (!krnl.<>o__89.<>p__6.Target(krnl.<>o__89.<>p__6, obj))
					{
						if (krnl.<>o__89.<>p__5 == null)
						{
							krnl.<>o__89.<>p__5 = CallSite<Func<CallSite, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.And, typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, object, object> target2 = krnl.<>o__89.<>p__5.Target;
						CallSite <>p__2 = krnl.<>o__89.<>p__5;
						object arg2 = obj;
						if (krnl.<>o__89.<>p__4 == null)
						{
							krnl.<>o__89.<>p__4 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.Not, typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, object> target3 = krnl.<>o__89.<>p__4.Target;
						CallSite <>p__3 = krnl.<>o__89.<>p__4;
						if (krnl.<>o__89.<>p__3 == null)
						{
							krnl.<>o__89.<>p__3 = CallSite<Func<CallSite, Type, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "IsNullOrWhiteSpace", null, typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, Type, object, object> target4 = krnl.<>o__89.<>p__3.Target;
						CallSite <>p__4 = krnl.<>o__89.<>p__3;
						Type typeFromHandle = typeof(string);
						if (krnl.<>o__89.<>p__2 == null)
						{
							krnl.<>o__89.<>p__2 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "SelectedPath", typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						obj2 = target2(<>p__2, arg2, target3(<>p__3, target4(<>p__4, typeFromHandle, krnl.<>o__89.<>p__2.Target(krnl.<>o__89.<>p__2, arg))));
					}
					else
					{
						obj2 = obj;
					}
					object arg3 = obj2;
					if (krnl.<>o__89.<>p__7 == null)
					{
						krnl.<>o__89.<>p__7 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(krnl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					if (krnl.<>o__89.<>p__7.Target(krnl.<>o__89.<>p__7, arg3))
					{
						if (krnl.<>o__89.<>p__8 == null)
						{
							krnl.<>o__89.<>p__8 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "SelectedPath", typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						this.ScriptPath = krnl.<>o__89.<>p__8.Target(krnl.<>o__89.<>p__8, arg);
						Settings @default = Settings.Default;
						if (krnl.<>o__89.<>p__10 == null)
						{
							krnl.<>o__89.<>p__10 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(krnl)));
						}
						Func<CallSite, object, string> target5 = krnl.<>o__89.<>p__10.Target;
						CallSite <>p__5 = krnl.<>o__89.<>p__10;
						if (krnl.<>o__89.<>p__9 == null)
						{
							krnl.<>o__89.<>p__9 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "SelectedPath", typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						@default.ScriptPath = target5(<>p__5, krnl.<>o__89.<>p__9.Target(krnl.<>o__89.<>p__9, arg));
						Settings.Default.Save();
					}
				}
				this.ScriptView.Nodes.Clear();
				this.ScriptLoading();
			}
			catch
			{
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000023F1 File Offset: 0x000005F1
		private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.ScriptView.Nodes.Clear();
			this.ScriptLoading();
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000020EC File Offset: 0x000002EC
		private void ScriptView_AfterSelect(object sender, TreeViewEventArgs e)
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000020EC File Offset: 0x000002EC
		private void customTabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000020EC File Offset: 0x000002EC
		private void renameToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002409 File Offset: 0x00000609
		private void openGuiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/UXmbai5q', true))()");
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002415 File Offset: 0x00000615
		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://raw.githubusercontent.com/CriShoux/OwlHub/master/OwlHub.txt'))();");
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002421 File Offset: 0x00000621
		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			krnl.Pipe("if game:GetService'CoreGui':FindFirstChild'Dex'then game:GetService'CoreGui'.Dex:Destroy()end;math.randomseed(tick())local a={}for b=48,57 do table.insert(a,string.char(b))end;for b=65,90 do table.insert(a,string.char(b))end;for b=97,122 do table.insert(a,string.char(b))end;function RandomCharacters(c)if c>0 then return RandomCharacters(c-1)..a[math.random(1,#a)]else return''end end;local d=game:GetObjects('rbxassetid://3567096419')[1]d.Name=RandomCharacters(math.random(5,20))d.Parent=game:GetService('CoreGui')local function e(f,g)local function h(i,j)local k={}local l={script=j}local m={}m.__index=function(n,o)if l[o]==nil then return getfenv()[o]else return l[o]end end;m.__newindex=function(n,o,p)if l[o]==nil then getfenv()[o]=p else l[o]=p end end;setmetatable(k,m)setfenv(i,k)return i end;local function q(j)if j.ClassName=='Script'or j.ClassName=='LocalScript'then spawn(function()h(loadstring(j.Source,'='..j:GetFullName()),j)()end)end;for b,r in pairs(j:GetChildren())do q(r)end end;q(f)end;e(d)");
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000020EC File Offset: 0x000002EC
		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000197B0 File Offset: 0x000179B0
		private void bunifuFlatButton6_Click(object sender, EventArgs e)
		{
			if (Application.OpenForms.OfType<settings>().Count<settings>() != 1)
			{
				new settings(this).Show();
				Application.OpenForms.OfType<settings>().First<settings>().SetDesktopLocation(base.Location.X + base.Size.Width + 5, base.Location.Y);
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0001981C File Offset: 0x00017A1C
		private void gamesToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			if (Application.OpenForms.OfType<Games>().Count<Games>() != 1)
			{
				new Games().Show();
				Application.OpenForms.OfType<Games>().First<Games>().SetDesktopLocation(base.Location.X + base.Size.Width + 5, base.Location.Y);
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00019888 File Offset: 0x00017A88
		private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			if (Application.OpenForms.OfType<About>().Count<About>() != 1)
			{
				new About().Show();
				Application.OpenForms.OfType<About>().First<About>().SetDesktopLocation(base.Location.X + base.Size.Width + 5, base.Location.Y);
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000198F4 File Offset: 0x00017AF4
		private void injectToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			IntPtr intPtr = krnl.FindWindowA("WINDOWSCLIENT", "Roblox");
			Process[] processesByName = Process.GetProcessesByName("RobloxPlayerBeta");
			int num = 0;
			krnl.GetWindowThreadProcessId(intPtr, out num);
			for (int i = 0; i < processesByName.Length; i++)
			{
				if (processesByName[i].Id != num)
				{
					processesByName[i].Kill();
				}
			}
			if (intPtr != IntPtr.Zero)
			{
				this.injectdll("Indicium-Supra.dll", num);
				Task.Delay(1000).GetAwaiter().GetResult();
				this.injectdll("krnl.dll", num);
				return;
			}
			MessageBox.Show("Roblox Process Not Found", "Krnl");
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002409 File Offset: 0x00000609
		private void openGuiToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/UXmbai5q', true))()");
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002415 File Offset: 0x00000615
		private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://raw.githubusercontent.com/CriShoux/OwlHub/master/OwlHub.txt'))();");
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00019998 File Offset: 0x00017B98
		private void killRobloxToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("RobloxPlayerBeta");
			int num = 0;
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
				num++;
			}
			MessageBox.Show(string.Format("Terminated {0} Process", num), "krnl");
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000242D File Offset: 0x0000062D
		private void krnl_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(Environment.ExitCode);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000199E8 File Offset: 0x00017BE8
		private async void krnl_Deactivate(object sender, EventArgs e)
		{
			if (Settings.Default.fadein_out_opacity)
			{
				while (base.Opacity > 0.5)
				{
					await Task.Delay(10);
					base.Opacity -= 0.05;
				}
			}
			else
			{
				base.Opacity = 1.0;
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00019A24 File Offset: 0x00017C24
		private async void krnl_Activated(object sender, EventArgs e)
		{
			if (Settings.Default.fadein_out_opacity)
			{
				while (base.Opacity < 1.0)
				{
					await Task.Delay(10);
					base.Opacity += 0.05;
				}
			}
			else
			{
				base.Opacity = 1.0;
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002439 File Offset: 0x00000639
		private void gameSenseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/rPnPiYZV'))();");
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002445 File Offset: 0x00000645
		private void remoteSpyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://pastebin.com/raw/JZaJe9Sg'))();");
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002470 File Offset: 0x00000670
		private void unnamedESPToolStripMenuItem_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://ic3w0lf.xyz/rblx/protoesp.lua', true))()");
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0001C410 File Offset: 0x0001A610
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (krnl.<>o__115.<>p__1 == null)
			{
				krnl.<>o__115.<>p__1 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(krnl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target = krnl.<>o__115.<>p__1.Target;
			CallSite <>p__ = krnl.<>o__115.<>p__1;
			if (krnl.<>o__115.<>p__0 == null)
			{
				krnl.<>o__115.<>p__0 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "autoinject", typeof(krnl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (target(<>p__, krnl.<>o__115.<>p__0.Target(krnl.<>o__115.<>p__0, Settings.Default)))
			{
				if (krnl.<>o__115.<>p__5 == null)
				{
					krnl.<>o__115.<>p__5 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target2 = krnl.<>o__115.<>p__5.Target;
				CallSite <>p__2 = krnl.<>o__115.<>p__5;
				if (krnl.<>o__115.<>p__4 == null)
				{
					krnl.<>o__115.<>p__4 = CallSite<Func<CallSite, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.GreaterThan, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object, object> target3 = krnl.<>o__115.<>p__4.Target;
				CallSite <>p__3 = krnl.<>o__115.<>p__4;
				if (krnl.<>o__115.<>p__3 == null)
				{
					krnl.<>o__115.<>p__3 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Length", typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object> target4 = krnl.<>o__115.<>p__3.Target;
				CallSite <>p__4 = krnl.<>o__115.<>p__3;
				if (krnl.<>o__115.<>p__2 == null)
				{
					krnl.<>o__115.<>p__2 = CallSite<Func<CallSite, Type, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "GetProcessesByName", null, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (target2(<>p__2, target3(<>p__3, target4(<>p__4, krnl.<>o__115.<>p__2.Target(krnl.<>o__115.<>p__2, typeof(Process), "RobloxPlayerLauncher")), 0)))
				{
					krnl.launcherDetected = true;
				}
				if (krnl.<>o__115.<>p__6 == null)
				{
					krnl.<>o__115.<>p__6 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (krnl.<>o__115.<>p__6.Target(krnl.<>o__115.<>p__6, krnl.launcherDetected))
				{
					try
					{
						try
						{
							if (krnl.<>o__115.<>p__7 == null)
							{
								krnl.<>o__115.<>p__7 = CallSite<Func<CallSite, object, int>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(krnl)));
							}
							krnl.injectedPID = krnl.<>o__115.<>p__7.Target(krnl.<>o__115.<>p__7, 0);
						}
						catch (ArgumentException)
						{
						}
					}
					catch (Win32Exception)
					{
					}
					if (krnl.<>o__115.<>p__16 == null)
					{
						krnl.<>o__115.<>p__16 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(krnl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, bool> target5 = krnl.<>o__115.<>p__16.Target;
					CallSite <>p__5 = krnl.<>o__115.<>p__16;
					if (krnl.<>o__115.<>p__10 == null)
					{
						krnl.<>o__115.<>p__10 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(krnl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, int, object> target6 = krnl.<>o__115.<>p__10.Target;
					CallSite <>p__6 = krnl.<>o__115.<>p__10;
					if (krnl.<>o__115.<>p__9 == null)
					{
						krnl.<>o__115.<>p__9 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Length", typeof(krnl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, object> target7 = krnl.<>o__115.<>p__9.Target;
					CallSite <>p__7 = krnl.<>o__115.<>p__9;
					if (krnl.<>o__115.<>p__8 == null)
					{
						krnl.<>o__115.<>p__8 = CallSite<Func<CallSite, Type, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "GetProcessesByName", null, typeof(krnl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					object obj = target6(<>p__6, target7(<>p__7, krnl.<>o__115.<>p__8.Target(krnl.<>o__115.<>p__8, typeof(Process), "RobloxPlayerLauncher")), 0);
					if (krnl.<>o__115.<>p__15 == null)
					{
						krnl.<>o__115.<>p__15 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsFalse, typeof(krnl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					object arg2;
					if (!krnl.<>o__115.<>p__15.Target(krnl.<>o__115.<>p__15, obj))
					{
						if (krnl.<>o__115.<>p__14 == null)
						{
							krnl.<>o__115.<>p__14 = CallSite<Func<CallSite, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.And, typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, object, object> target8 = krnl.<>o__115.<>p__14.Target;
						CallSite <>p__8 = krnl.<>o__115.<>p__14;
						object arg = obj;
						if (krnl.<>o__115.<>p__13 == null)
						{
							krnl.<>o__115.<>p__13 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.GreaterThan, typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						Func<CallSite, object, int, object> target9 = krnl.<>o__115.<>p__13.Target;
						CallSite <>p__9 = krnl.<>o__115.<>p__13;
						if (krnl.<>o__115.<>p__12 == null)
						{
							krnl.<>o__115.<>p__12 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "Length", typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, object> target10 = krnl.<>o__115.<>p__12.Target;
						CallSite <>p__10 = krnl.<>o__115.<>p__12;
						if (krnl.<>o__115.<>p__11 == null)
						{
							krnl.<>o__115.<>p__11 = CallSite<Func<CallSite, Type, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "GetProcessesByName", null, typeof(krnl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						arg2 = target8(<>p__8, arg, target9(<>p__9, target10(<>p__10, krnl.<>o__115.<>p__11.Target(krnl.<>o__115.<>p__11, typeof(Process), "RobloxPlayerBeta")), 0));
					}
					else
					{
						arg2 = obj;
					}
					if (target5(<>p__5, arg2))
					{
						if (krnl.<>o__115.<>p__17 == null)
						{
							krnl.<>o__115.<>p__17 = CallSite<Func<CallSite, object, int>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(krnl)));
						}
						krnl.injectedPID = krnl.<>o__115.<>p__17.Target(krnl.<>o__115.<>p__17, 0);
						if (krnl.<>o__115.<>p__18 == null)
						{
							krnl.<>o__115.<>p__18 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(bool), typeof(krnl)));
						}
						krnl.launcherDetected = krnl.<>o__115.<>p__18.Target(krnl.<>o__115.<>p__18, false);
						if (krnl.<>o__115.<>p__19 == null)
						{
							krnl.<>o__115.<>p__19 = CallSite<Func<CallSite, object, double>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(double), typeof(krnl)));
						}
						krnl.timeout = krnl.<>o__115.<>p__19.Target(krnl.<>o__115.<>p__19, 6);
						new Thread(delegate()
						{
							if (krnl.<>o__115.<>p__21 == null)
							{
								krnl.<>o__115.<>p__21 = CallSite<Func<CallSite, object, Process[]>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(Process[]), typeof(krnl)));
							}
							Func<CallSite, object, Process[]> target13 = krnl.<>o__115.<>p__21.Target;
							CallSite <>p__13 = krnl.<>o__115.<>p__21;
							if (krnl.<>o__115.<>p__20 == null)
							{
								krnl.<>o__115.<>p__20 = CallSite<Func<CallSite, Type, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "GetProcessesByName", null, typeof(krnl), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Process[] array = target13(<>p__13, krnl.<>o__115.<>p__20.Target(krnl.<>o__115.<>p__20, typeof(Process), "RobloxPlayerBeta"));
							if (krnl.<>o__115.<>p__23 == null)
							{
								krnl.<>o__115.<>p__23 = CallSite<Func<CallSite, object, IntPtr>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(IntPtr), typeof(krnl)));
							}
							Func<CallSite, object, IntPtr> target14 = krnl.<>o__115.<>p__23.Target;
							CallSite <>p__14 = krnl.<>o__115.<>p__23;
							if (krnl.<>o__115.<>p__22 == null)
							{
								krnl.<>o__115.<>p__22 = CallSite<Func<CallSite, krnl, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName, "FindWindowA", null, typeof(krnl), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							IntPtr intPtr = target14(<>p__14, krnl.<>o__115.<>p__22.Target(krnl.<>o__115.<>p__22, this, "WINDOWSCLIENT", "Roblox"));
							if (krnl.<>o__115.<>p__24 == null)
							{
								krnl.<>o__115.<>p__24 = CallSite<Func<CallSite, object, int>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(krnl)));
							}
							int num = krnl.<>o__115.<>p__24.Target(krnl.<>o__115.<>p__24, 0);
							if (krnl.<>o__115.<>p__25 == null)
							{
								krnl.<>o__115.<>p__25 = CallSite<<>A{00000008}<CallSite, krnl, object, int>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName | CSharpBinderFlags.ResultDiscarded, "GetWindowThreadProcessId", null, typeof(krnl), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsOut, null)
								}));
							}
							krnl.<>o__115.<>p__25.Target(krnl.<>o__115.<>p__25, this, intPtr, ref num);
							if (krnl.<>o__115.<>p__27 == null)
							{
								krnl.<>o__115.<>p__27 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(krnl), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							Func<CallSite, object, bool> target15 = krnl.<>o__115.<>p__27.Target;
							CallSite <>p__15 = krnl.<>o__115.<>p__27;
							if (krnl.<>o__115.<>p__26 == null)
							{
								krnl.<>o__115.<>p__26 = CallSite<Func<CallSite, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(krnl), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							if (target15(<>p__15, krnl.<>o__115.<>p__26.Target(krnl.<>o__115.<>p__26, intPtr, IntPtr.Zero)))
							{
								if (krnl.<>o__115.<>p__30 == null)
								{
									krnl.<>o__115.<>p__30 = CallSite<Func<CallSite, object, string[]>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(string[]), typeof(krnl)));
								}
								Func<CallSite, object, string[]> target16 = krnl.<>o__115.<>p__30.Target;
								CallSite <>p__16 = krnl.<>o__115.<>p__30;
								string[] array2 = new string[2];
								int num2 = 0;
								if (krnl.<>o__115.<>p__28 == null)
								{
									krnl.<>o__115.<>p__28 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(krnl)));
								}
								array2[num2] = krnl.<>o__115.<>p__28.Target(krnl.<>o__115.<>p__28, "Indicium-Supra");
								int num3 = 1;
								if (krnl.<>o__115.<>p__29 == null)
								{
									krnl.<>o__115.<>p__29 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(krnl)));
								}
								array2[num3] = krnl.<>o__115.<>p__29.Target(krnl.<>o__115.<>p__29, "krnl");
								string[] array3 = target16(<>p__16, array2);
								if (krnl.<>o__115.<>p__31 == null)
								{
									krnl.<>o__115.<>p__31 = CallSite<Func<CallSite, object, int>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(krnl)));
								}
								int num4 = krnl.<>o__115.<>p__31.Target(krnl.<>o__115.<>p__31, 0);
								for (;;)
								{
									if (krnl.<>o__115.<>p__33 == null)
									{
										krnl.<>o__115.<>p__33 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(krnl), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									Func<CallSite, object, bool> target17 = krnl.<>o__115.<>p__33.Target;
									CallSite <>p__17 = krnl.<>o__115.<>p__33;
									if (krnl.<>o__115.<>p__32 == null)
									{
										krnl.<>o__115.<>p__32 = CallSite<Func<CallSite, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.LessThan, typeof(krnl), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									if (!target17(<>p__17, krnl.<>o__115.<>p__32.Target(krnl.<>o__115.<>p__32, num4, array3.Length)))
									{
										break;
									}
									if (krnl.<>o__115.<>p__36 == null)
									{
										krnl.<>o__115.<>p__36 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(krnl), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									Func<CallSite, object, bool> target18 = krnl.<>o__115.<>p__36.Target;
									CallSite <>p__18 = krnl.<>o__115.<>p__36;
									if (krnl.<>o__115.<>p__35 == null)
									{
										krnl.<>o__115.<>p__35 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.Not, typeof(krnl), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									Func<CallSite, object, object> target19 = krnl.<>o__115.<>p__35.Target;
									CallSite <>p__19 = krnl.<>o__115.<>p__35;
									if (krnl.<>o__115.<>p__34 == null)
									{
										krnl.<>o__115.<>p__34 = CallSite<Func<CallSite, krnl, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName, "injectdll", null, typeof(krnl), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									if (target18(<>p__18, target19(<>p__19, krnl.<>o__115.<>p__34.Target(krnl.<>o__115.<>p__34, this, array3[num4] + ".dll", num))))
									{
										break;
									}
									if (krnl.<>o__115.<>p__39 == null)
									{
										krnl.<>o__115.<>p__39 = CallSite<Action<CallSite, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "GetResult", null, typeof(krnl), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									Action<CallSite, object> target20 = krnl.<>o__115.<>p__39.Target;
									CallSite <>p__20 = krnl.<>o__115.<>p__39;
									if (krnl.<>o__115.<>p__38 == null)
									{
										krnl.<>o__115.<>p__38 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "GetAwaiter", null, typeof(krnl), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									Func<CallSite, object, object> target21 = krnl.<>o__115.<>p__38.Target;
									CallSite <>p__21 = krnl.<>o__115.<>p__38;
									if (krnl.<>o__115.<>p__37 == null)
									{
										krnl.<>o__115.<>p__37 = CallSite<Func<CallSite, Type, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.None, "Delay", null, typeof(krnl), new CSharpArgumentInfo[]
										{
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
											CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
										}));
									}
									target20(<>p__20, target21(<>p__21, krnl.<>o__115.<>p__37.Target(krnl.<>o__115.<>p__37, typeof(Task), 2000)));
									num4++;
								}
							}
						}).Start();
						return;
					}
					if (krnl.<>o__115.<>p__41 == null)
					{
						krnl.<>o__115.<>p__41 = CallSite<Func<CallSite, object, double>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(double), typeof(krnl)));
					}
					Func<CallSite, object, double> target11 = krnl.<>o__115.<>p__41.Target;
					CallSite <>p__11 = krnl.<>o__115.<>p__41;
					if (krnl.<>o__115.<>p__40 == null)
					{
						krnl.<>o__115.<>p__40 = CallSite<Func<CallSite, double, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.SubtractAssign, typeof(krnl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					krnl.timeout = target11(<>p__11, krnl.<>o__115.<>p__40.Target(krnl.<>o__115.<>p__40, krnl.timeout, 0.0001));
				}
				if (krnl.<>o__115.<>p__43 == null)
				{
					krnl.<>o__115.<>p__43 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target12 = krnl.<>o__115.<>p__43.Target;
				CallSite <>p__12 = krnl.<>o__115.<>p__43;
				if (krnl.<>o__115.<>p__42 == null)
				{
					krnl.<>o__115.<>p__42 = CallSite<Func<CallSite, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(krnl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (target12(<>p__12, krnl.<>o__115.<>p__42.Target(krnl.<>o__115.<>p__42, krnl.timeout, 0)))
				{
					if (krnl.<>o__115.<>p__44 == null)
					{
						krnl.<>o__115.<>p__44 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(bool), typeof(krnl)));
					}
					krnl.launcherDetected = krnl.<>o__115.<>p__44.Target(krnl.<>o__115.<>p__44, false);
					if (krnl.<>o__115.<>p__45 == null)
					{
						krnl.<>o__115.<>p__45 = CallSite<Func<CallSite, object, double>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.None, typeof(double), typeof(krnl)));
					}
					krnl.timeout = krnl.<>o__115.<>p__45.Target(krnl.<>o__115.<>p__45, 6);
				}
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000247C File Offset: 0x0000067C
		private void toolStripMenuItem1_Click_2(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://raw.githubusercontent.com/LaziestBoy/Krnl-Hub/master/Krnl-Hub.lua', true))()");
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002415 File Offset: 0x00000615
		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			krnl.Pipe("loadstring(game:HttpGet('https://raw.githubusercontent.com/CriShoux/OwlHub/master/OwlHub.txt'))();");
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002488 File Offset: 0x00000688
		private void pictureBox2_MouseEnter(object sender, EventArgs e)
		{
			this.toolTip1.SetToolTip((PictureBox)sender, "Click to join the server");
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000024A0 File Offset: 0x000006A0
		private void pictureBox2_MouseLeave(object sender, EventArgs e)
		{
			this.toolTip1.Hide((PictureBox)sender);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000024B3 File Offset: 0x000006B3
		private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
		{
			Process.Start("https://discord.gg/pHShx9M");
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000024C0 File Offset: 0x000006C0
		private void bunifuFlatButton8_Click(object sender, EventArgs e)
		{
			Process.Start("https://krnl.rocks/api/getkey");
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000024B3 File Offset: 0x000006B3
		private void toolStripMenuItem7_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/pHShx9M");
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0001CCA4 File Offset: 0x0001AEA4
		private void krnl_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.mMouseDown)
			{
				this.Refresh();
				base.SuspendLayout();
				if (this.isonEdge)
				{
					if (base.Width > 679)
					{
						base.SetBounds(base.Left, base.Top, base.Width - (base.Width - e.X), base.Height - (base.Height - e.Y));
					}
					else
					{
						base.Width = 690;
						this.mMouseDown = false;
					}
				}
				base.ResumeLayout();
				return;
			}
			if (e.X > base.Width - (this.mWidth + 1) && e.Y > base.Height - (this.mWidth + 1))
			{
				this.Cursor = Cursors.PanSE;
				this.isonEdge = true;
				return;
			}
			this.Cursor = Cursors.Default;
			this.isonEdge = false;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000024CD File Offset: 0x000006CD
		private void krnl_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.mMouseDown = true;
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000024E3 File Offset: 0x000006E3
		private void krnl_MouseUp(object sender, MouseEventArgs e)
		{
			this.mMouseDown = false;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000020EC File Offset: 0x000002EC
		private void bunifuFlatButton7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0001CD84 File Offset: 0x0001AF84
		private async void anim_CompletedTask()
		{
			for (int i = 0; i < 70; i += 5)
			{
				await Task.Delay(1);
				this.panel3.BackColor = Color.FromArgb(30, 144 - i, 255 - i);
			}
			for (int i = 0; i < 69; i += 5)
			{
				await Task.Delay(1);
				this.panel3.BackColor = Color.FromArgb(30, 74 + i, 185 + i);
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0001CDC0 File Offset: 0x0001AFC0
		private async void anim_AwaitingTaskFinish()
		{
			while (this.Anim_ATF_break)
			{
				for (int i = 0; i < 70; i++)
				{
					if (!this.Anim_ATF_break)
					{
						this.panel3.BackColor = Color.FromArgb(30, 144, 255);
						break;
					}
					await Task.Delay(3);
					this.panel3.BackColor = Color.FromArgb(30, 144 - i, 255 - i);
				}
				for (int i = 0; i < 69; i++)
				{
					if (!this.Anim_ATF_break)
					{
						this.panel3.BackColor = Color.FromArgb(30, 144, 255);
						break;
					}
					await Task.Delay(3);
					this.panel3.BackColor = Color.FromArgb(30, 74 + i, 185 + i);
				}
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000024EC File Offset: 0x000006EC
		private void bunifuFlatButton8_Click_1(object sender, EventArgs e)
		{
			this.Anim_ATF_break = true;
			this.anim_AwaitingTaskFinish();
			this.Anim_ATF_break = false;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000020EC File Offset: 0x000002EC
		private void bunifuFlatButton10_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000323 RID: 803
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000324 RID: 804
		public const int HT_CAPTION = 2;

		// Token: 0x04000325 RID: 805
		[Dynamic]
		private dynamic ScriptPath = Settings.Default.ScriptPath;

		// Token: 0x04000326 RID: 806
		public TabPanelControl tpc;

		// Token: 0x04000327 RID: 807
		public bool changed;

		// Token: 0x04000358 RID: 856
		public static int injectedPID = 0;

		// Token: 0x04000359 RID: 857
		public static bool launcherDetected = false;

		// Token: 0x0400035A RID: 858
		public static double timeout = 6.0;

		// Token: 0x0400035B RID: 859
		private krnl.EdgeEnum mEdge;

		// Token: 0x0400035C RID: 860
		private bool isonEdge;

		// Token: 0x0400035D RID: 861
		private int mWidth;

		// Token: 0x0400035E RID: 862
		private bool mMouseDown;

		// Token: 0x0400035F RID: 863
		private bool Anim_ATF_break;

		// Token: 0x0200000E RID: 14
		public class BrowserMenuRenderer : ToolStripProfessionalRenderer
		{
			// Token: 0x0600009F RID: 159 RVA: 0x0000251E File Offset: 0x0000071E
			public BrowserMenuRenderer() : base(new krnl.BrowserColors())
			{
			}
		}

		// Token: 0x0200000F RID: 15
		public class BrowserColors : ProfessionalColorTable
		{
			// Token: 0x17000007 RID: 7
			// (get) Token: 0x060000A0 RID: 160 RVA: 0x0000252B File Offset: 0x0000072B
			public override Color ToolStripDropDownBackground
			{
				get
				{
					return Color.FromArgb(40, 40, 40);
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000252B File Offset: 0x0000072B
			public override Color ImageMarginGradientBegin
			{
				get
				{
					return Color.FromArgb(40, 40, 40);
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000252B File Offset: 0x0000072B
			public override Color ImageMarginGradientMiddle
			{
				get
				{
					return Color.FromArgb(40, 40, 40);
				}
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000252B File Offset: 0x0000072B
			public override Color ImageMarginGradientEnd
			{
				get
				{
					return Color.FromArgb(40, 40, 40);
				}
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x060000A4 RID: 164 RVA: 0x00002538 File Offset: 0x00000738
			public override Color MenuBorder
			{
				get
				{
					return Color.FromArgb(45, 45, 45);
				}
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x060000A5 RID: 165 RVA: 0x00002538 File Offset: 0x00000738
			public override Color MenuItemBorder
			{
				get
				{
					return Color.FromArgb(45, 45, 45);
				}
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x060000A6 RID: 166 RVA: 0x00002538 File Offset: 0x00000738
			public override Color MenuItemSelected
			{
				get
				{
					return Color.FromArgb(45, 45, 45);
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x060000A7 RID: 167 RVA: 0x0000252B File Offset: 0x0000072B
			public override Color MenuStripGradientBegin
			{
				get
				{
					return Color.FromArgb(40, 40, 40);
				}
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x060000A8 RID: 168 RVA: 0x00002538 File Offset: 0x00000738
			public override Color MenuStripGradientEnd
			{
				get
				{
					return Color.FromArgb(45, 45, 45);
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000252B File Offset: 0x0000072B
			public override Color MenuItemSelectedGradientBegin
			{
				get
				{
					return Color.FromArgb(40, 40, 40);
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x060000AA RID: 170 RVA: 0x0000252B File Offset: 0x0000072B
			public override Color MenuItemSelectedGradientEnd
			{
				get
				{
					return Color.FromArgb(40, 40, 40);
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x060000AB RID: 171 RVA: 0x0000252B File Offset: 0x0000072B
			public override Color MenuItemPressedGradientBegin
			{
				get
				{
					return Color.FromArgb(40, 40, 40);
				}
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x060000AC RID: 172 RVA: 0x0000252B File Offset: 0x0000072B
			public override Color MenuItemPressedGradientEnd
			{
				get
				{
					return Color.FromArgb(40, 40, 40);
				}
			}
		}

		// Token: 0x02000010 RID: 16
		private enum EdgeEnum
		{
			// Token: 0x04000361 RID: 865
			None,
			// Token: 0x04000362 RID: 866
			Right,
			// Token: 0x04000363 RID: 867
			Left,
			// Token: 0x04000364 RID: 868
			Top,
			// Token: 0x04000365 RID: 869
			Bottom,
			// Token: 0x04000366 RID: 870
			TopLeft,
			// Token: 0x04000367 RID: 871
			BottomRight
		}
	}
}
