using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.Win32;

namespace krnlss
{
	// Token: 0x02000028 RID: 40
	internal static class Program
	{
		// Token: 0x060000BB RID: 187 RVA: 0x0001DC24 File Offset: 0x0001BE24
		public static void pc(bool start = false, bool urlPassed = false, int key = -1)
		{
			if (Program.<>o__9.<>p__0 == null)
			{
				Program.<>o__9.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Program.<>o__9.<>p__0.Target(Program.<>o__9.<>p__0, Program.debugme))
			{
				if (Program.<>o__9.<>p__1 == null)
				{
					Program.<>o__9.<>p__1 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (Program.<>o__9.<>p__1.Target(Program.<>o__9.<>p__1, start))
				{
					File.WriteAllText("pass check.txt", "");
				}
				File.AppendAllText("pass check.txt", Convert.ToString(Program.__i++) + ((key == 0) ? " No Key" : ((key == 1) ? " Key" : "")) + (urlPassed ? " Url Passed" : "") + "\n");
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0001DD34 File Offset: 0x0001BF34
		public static bool hasFolder(string name, string path)
		{
			DirectoryInfo[] directories = new DirectoryInfo(path).GetDirectories();
			for (int i = 0; i < directories.Length; i++)
			{
				if (Program.<>o__11.<>p__1 == null)
				{
					Program.<>o__11.<>p__1 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target = Program.<>o__11.<>p__1.Target;
				CallSite <>p__ = Program.<>o__11.<>p__1;
				if (Program.<>o__11.<>p__0 == null)
				{
					Program.<>o__11.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Program), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				if (target(<>p__, Program.<>o__11.<>p__0.Target(Program.<>o__11.<>p__0, directories[i].Name, name)))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0001DE08 File Offset: 0x0001C008
		public static bool hasFile(string name, string path)
		{
			FileInfo[] files = new DirectoryInfo(path).GetFiles();
			for (int i = 0; i < files.Length; i++)
			{
				if (Program.<>o__12.<>p__1 == null)
				{
					Program.<>o__12.<>p__1 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target = Program.<>o__12.<>p__1.Target;
				CallSite <>p__ = Program.<>o__12.<>p__1;
				if (Program.<>o__12.<>p__0 == null)
				{
					Program.<>o__12.<>p__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Program), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				if (target(<>p__, Program.<>o__12.<>p__0.Target(Program.<>o__12.<>p__0, files[i].Name, name)))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0001DEDC File Offset: 0x0001C0DC
		[STAThread]
		private static void Main()
		{
			ServicePointManager.Expect100Continue = true;
			if (Program.<>o__13.<>p__0 == null)
			{
				Program.<>o__13.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Program.<>o__13.<>p__0.Target(Program.<>o__13.<>p__0, !Program.isCompatible()))
			{
				MessageBox.Show("You do not have Windows 8.1 or Windows 10!");
				Environment.Exit(1);
				return;
			}
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i < processes.Length; i++)
			{
				if (processes[i] != Process.GetCurrentProcess() && new string[]
				{
					"krnl",
					"krnlss"
				}.ToList<string>().IndexOf(processes[i].ProcessName.Split(new char[]
				{
					'.'
				})[0].ToLower()) != -1)
				{
					try
					{
						processes[i].CloseMainWindow();
					}
					catch
					{
					}
				}
			}
			if (Program.<>o__13.<>p__1 == null)
			{
				Program.<>o__13.<>p__1 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Program.<>o__13.<>p__1.Target(Program.<>o__13.<>p__1, !Directory.Exists("workspace")))
			{
				Directory.CreateDirectory("workspace");
			}
			if (Program.<>o__13.<>p__2 == null)
			{
				Program.<>o__13.<>p__2 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Program.<>o__13.<>p__2.Target(Program.<>o__13.<>p__2, !Directory.Exists("scripts")))
			{
				Directory.CreateDirectory("scripts");
			}
			if (Program.<>o__13.<>p__3 == null)
			{
				Program.<>o__13.<>p__3 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Program.<>o__13.<>p__3.Target(Program.<>o__13.<>p__3, !Directory.Exists("autoexec")))
			{
				Directory.CreateDirectory("autoexec");
			}
			Program.writerblx();
			if (Program.<>o__13.<>p__4 == null)
			{
				Program.<>o__13.<>p__4 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Program.<>o__13.<>p__4.Target(Program.<>o__13.<>p__4, File.Exists("krnl.exe.bak")))
			{
				File.Delete("krnl.exe.bak");
			}
			Stack<string> stack = new Stack<string>(Environment.CurrentDirectory.Split(new char[]
			{
				'\\'
			}));
			bool flag = false;
			stack.Reverse<string>();
			while (stack.Count != 0)
			{
				if (Program.<>o__13.<>p__7 == null)
				{
					Program.<>o__13.<>p__7 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target = Program.<>o__13.<>p__7.Target;
				CallSite <>p__ = Program.<>o__13.<>p__7;
				if (Program.<>o__13.<>p__6 == null)
				{
					Program.<>o__13.<>p__6 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Program), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				Func<CallSite, object, string, object> target2 = Program.<>o__13.<>p__6.Target;
				CallSite <>p__2 = Program.<>o__13.<>p__6;
				if (Program.<>o__13.<>p__5 == null)
				{
					Program.<>o__13.<>p__5 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Program), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (target(<>p__, target2(<>p__2, Program.<>o__13.<>p__5.Target(Program.<>o__13.<>p__5, string.Join("\\", stack.ToArray().Reverse<string>()), "\\"), Path.GetTempPath())))
				{
					flag = true;
					break;
				}
				stack.Pop();
			}
			if (Program.<>o__13.<>p__8 == null)
			{
				Program.<>o__13.<>p__8 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (Program.<>o__13.<>p__8.Target(Program.<>o__13.<>p__8, flag))
			{
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				if (Program.<>o__13.<>p__9 == null)
				{
					Program.<>o__13.<>p__9 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (Program.<>o__13.<>p__9.Target(Program.<>o__13.<>p__9, !Directory.Exists(folderPath + "\\krnl")))
				{
					Directory.CreateDirectory(folderPath + "\\krnl");
				}
				string text = folderPath + "\\krnl";
				DirectoryInfo directoryInfo = new DirectoryInfo(text);
				DirectoryInfo directoryInfo2 = new DirectoryInfo(Environment.CurrentDirectory);
				DirectoryInfo[] directories = directoryInfo2.GetDirectories();
				FileInfo[] files = directoryInfo2.GetFiles();
				MessageBox.Show("You cannot run this here!\nExtracting the zip file to your Desktop.", "Zip file detected.");
				for (int j = 0; j < directories.Length; j++)
				{
					if (Program.<>o__13.<>p__10 == null)
					{
						Program.<>o__13.<>p__10 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					if (Program.<>o__13.<>p__10.Target(Program.<>o__13.<>p__10, !Program.hasFolder(directories[j].Name, text)))
					{
						directoryInfo.CreateSubdirectory(directories[j].Name);
					}
				}
				for (int k = 0; k < files.Length; k++)
				{
					if (Program.<>o__13.<>p__11 == null)
					{
						Program.<>o__13.<>p__11 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					if (Program.<>o__13.<>p__11.Target(Program.<>o__13.<>p__11, !Program.hasFile(files[k].Name, text)))
					{
						files[k].CopyTo(files[k].FullName.Replace(Environment.CurrentDirectory, text), true);
					}
				}
				Process.Start(text);
				Process.Start(new ProcessStartInfo
				{
					WorkingDirectory = text,
					FileName = "krnl.exe",
					CreateNoWindow = true
				});
				Environment.Exit(1);
				return;
			}
			Application.Run(Program.form);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0001E52C File Offset: 0x0001C72C
		// Note: this type is marked as 'beforefieldinit'.
		static Program()
		{
			Program.__i = 0;
			Program.debugme = false;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0001E5E4 File Offset: 0x0001C7E4
		[STAThread]
		public static void writerblx()
		{
			Registry.CurrentUser.OpenSubKey("Software", false);
			int[] array = new int[]
			{
				0,
				48,
				192,
				768,
				3072,
				12288
			};
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			do
			{
				num3 = 0;
				while (num3 < Program.urls.Length && num != array.Length - 1)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("[" + Program.urls[num3] + "]");
					Console.ResetColor();
					try
					{
						ServicePointManager.SecurityProtocol = (SecurityProtocolType)array[num];
						ServicePointManager.ServerCertificateValidationCallback = ((object sender2, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true);
						new WebClient().DownloadString(Program.urls[num3]) == "false";
						Program.num = array[num];
						num2 = num3;
						num = array.Length - 1;
					}
					catch (WebException ex)
					{
						Console.WriteLine("Failed to access the bootstrapper's need with the code of " + array[num]);
						Console.WriteLine(ex.Message);
						Console.WriteLine();
					}
					num3++;
				}
				num++;
			}
			while (array.Length != num);
			DialogResult dialogResult = DialogResult.No;
			if (Program.<>o__6.<>p__1 == null)
			{
				Program.<>o__6.<>p__1 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target = Program.<>o__6.<>p__1.Target;
			CallSite <>p__ = Program.<>o__6.<>p__1;
			if (Program.<>o__6.<>p__0 == null)
			{
				Program.<>o__6.<>p__0 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Program), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target(<>p__, Program.<>o__6.<>p__0.Target(Program.<>o__6.<>p__0, Program.num, -1)))
			{
				MessageBox.Show("Failed to check if krnl is up-to-date.\nTry using a VPN.", "Connection is being intercepted.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				dialogResult = MessageBox.Show("Do you want to skip the checks?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
				if (Program.<>o__6.<>p__3 == null)
				{
					Program.<>o__6.<>p__3 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target2 = Program.<>o__6.<>p__3.Target;
				CallSite <>p__2 = Program.<>o__6.<>p__3;
				if (Program.<>o__6.<>p__2 == null)
				{
					Program.<>o__6.<>p__2 = CallSite<Func<CallSite, object, DialogResult, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Program), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (target2(<>p__2, Program.<>o__6.<>p__2.Target(Program.<>o__6.<>p__2, dialogResult, DialogResult.No)))
				{
					Environment.Exit(1);
				}
			}
			Program.num = num2;
			string environmentVariable = Environment.GetEnvironmentVariable("localappdata");
			if (Directory.Exists(Path.Combine(environmentVariable, "Roblox")))
			{
				if (Program.<>o__6.<>p__5 == null)
				{
					Program.<>o__6.<>p__5 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target3 = Program.<>o__6.<>p__5.Target;
				CallSite <>p__3 = Program.<>o__6.<>p__5;
				if (Program.<>o__6.<>p__4 == null)
				{
					Program.<>o__6.<>p__4 = CallSite<Func<CallSite, object, DialogResult, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Program), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (target3(<>p__3, Program.<>o__6.<>p__4.Target(Program.<>o__6.<>p__4, dialogResult, DialogResult.No)))
				{
					try
					{
						string text = new WebClient().DownloadString(Program.vUrls[Program.num]);
						File.WriteAllText(Path.Combine(new string[]
						{
							environmentVariable,
							"Roblox",
							"Versions",
							text,
							"autoexecpath.dat"
						}), Environment.CurrentDirectory + "\\autoexec");
						File.WriteAllText(Path.Combine(new string[]
						{
							environmentVariable,
							"Roblox",
							"Versions",
							text,
							"workspacepath.dat"
						}), Environment.CurrentDirectory + "\\workspace");
					}
					catch
					{
						DialogResult dialogResult2 = MessageBox.Show("Do you still want to continue?", "ROBLOX is not up-to-date!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
						if (Program.<>o__6.<>p__7 == null)
						{
							Program.<>o__6.<>p__7 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, bool> target4 = Program.<>o__6.<>p__7.Target;
						CallSite <>p__4 = Program.<>o__6.<>p__7;
						if (Program.<>o__6.<>p__6 == null)
						{
							Program.<>o__6.<>p__6 = CallSite<Func<CallSite, object, DialogResult, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(Program), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						if (target4(<>p__4, Program.<>o__6.<>p__6.Target(Program.<>o__6.<>p__6, dialogResult2, DialogResult.No)))
						{
							Environment.Exit(1);
						}
					}
				}
				return;
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0001EAB4 File Offset: 0x0001CCB4
		public static bool isCompatible()
		{
			string text = (string)Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion").GetValue("ProductName");
			return text.StartsWith("Windows 8.1") || text.StartsWith("Windows 10");
		}

		// Token: 0x04000412 RID: 1042
		public static int __i;

		// Token: 0x04000413 RID: 1043
		public static bool debugme;

		// Token: 0x04000414 RID: 1044
		public static Form form = new krnl();

		// Token: 0x04000415 RID: 1045
		public static string[] urls = new string[]
		{
			"https://pastebin.com/raw/xNCHZ6Sy",
			"https://raw.githubusercontent.com/Bi-nz/krnl-bootstrapper/master/patched.txt",
			"https://ukiyooo.net/krnl/patched.php"
		};

		// Token: 0x04000416 RID: 1046
		public static string[] vUrls = new string[]
		{
			"https://pastebin.com/raw/WBxiKre5",
			"https://raw.githubusercontent.com/Bi-nz/krnl-bootstrapper/master/version.txt",
			"https://ukiyooo.net/krnl"
		};

		// Token: 0x04000417 RID: 1047
		public static string[] hUrls = new string[]
		{
			"https://pastebin.com/raw/dXbJAUTi",
			"https://raw.githubusercontent.com/Bi-nz/krnl-bootstrapper/master/hash.txt",
			"https://ukiyooo.net/krnl/bootstrapper.php"
		};

		// Token: 0x04000418 RID: 1048
		public static string[] bUrls = new string[]
		{
			"https://pastebin.com/raw/JU8Acz1c",
			"https://github.com/Bi-nz/krnl-bootstrapper/blob/master/krnl%20bootstrapper.exe?raw=true",
			"https://ukiyooo.net/krnl/krnl%20bootstrapper.exe"
		};

		// Token: 0x04000419 RID: 1049
		public static int num = -1;
	}
}
