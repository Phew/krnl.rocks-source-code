using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace injection
{
	// Token: 0x02000033 RID: 51
	public class krnlgay
	{
		// Token: 0x0400044F RID: 1103
		public static IntPtr INTPTR_ZERO = IntPtr.Zero;

		// Token: 0x02000034 RID: 52
		public enum krnlgayResult
		{
			// Token: 0x04000451 RID: 1105
			DllNotFound,
			// Token: 0x04000452 RID: 1106
			ProcessNotFound,
			// Token: 0x04000453 RID: 1107
			Failed,
			// Token: 0x04000454 RID: 1108
			Success,
			// Token: 0x04000455 RID: 1109
			threaderr
		}

		// Token: 0x02000035 RID: 53
		public sealed class DllInjector
		{
			// Token: 0x1700001D RID: 29
			// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000271A File Offset: 0x0000091A
			public static krnlgay.DllInjector GetInstance
			{
				get
				{
					if (krnlgay.DllInjector._instance == null)
					{
						krnlgay.DllInjector._instance = new krnlgay.DllInjector();
					}
					return krnlgay.DllInjector._instance;
				}
			}

			// Token: 0x060000F6 RID: 246
			[DllImport("kernel32.dll")]
			private static extern int ResumeThread(IntPtr hThread);

			// Token: 0x060000F7 RID: 247
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern int CloseHandle(IntPtr hObject);

			// Token: 0x060000F8 RID: 248
			[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
			private static extern bool WaitNamedPipe(string name, int timeout);

			// Token: 0x060000F9 RID: 249
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttribute, IntPtr dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

			// Token: 0x060000FA RID: 250
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern IntPtr GetModuleHandle(string lpModuleName);

			// Token: 0x060000FB RID: 251
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

			// Token: 0x060000FC RID: 252
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

			// Token: 0x060000FD RID: 253
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect);

			// Token: 0x060000FE RID: 254
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, int lpNumberOfBytesWritten);

			// Token: 0x060000FF RID: 255 RVA: 0x0000214F File Offset: 0x0000034F
			private DllInjector()
			{
			}

			// Token: 0x06000100 RID: 256 RVA: 0x0001FCE4 File Offset: 0x0001DEE4
			private bool dllinject(uint pToBeInjected, string sDllPath)
			{
				IntPtr intPtr = krnlgay.DllInjector.OpenProcess(1082U, 1, pToBeInjected);
				bool result;
				if (intPtr != krnlgay.INTPTR_ZERO)
				{
					IntPtr procAddress = krnlgay.DllInjector.GetProcAddress(krnlgay.DllInjector.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
					if (procAddress != krnlgay.INTPTR_ZERO)
					{
						IntPtr intPtr2 = krnlgay.DllInjector.VirtualAllocEx(intPtr, (IntPtr)0, (IntPtr)sDllPath.Length, 12288U, 64U);
						IntPtr value = krnlgay.DllInjector.CreateRemoteThread(intPtr, (IntPtr)0, krnlgay.INTPTR_ZERO, procAddress, intPtr2, 0U, (IntPtr)0);
						if (intPtr2 != krnlgay.INTPTR_ZERO)
						{
							if (krnlgay.DllInjector.WriteProcessMemory(intPtr, intPtr2, Encoding.ASCII.GetBytes(sDllPath), (uint)Encoding.ASCII.GetBytes(sDllPath).Length, 0) == 0)
							{
								result = false;
							}
							else if (value != krnlgay.INTPTR_ZERO)
							{
								krnlgay.DllInjector.CloseHandle(intPtr);
								result = true;
							}
							else
							{
								result = false;
							}
						}
						else
						{
							result = false;
						}
					}
					else
					{
						result = false;
					}
				}
				else
				{
					result = false;
				}
				return result;
			}

			// Token: 0x06000101 RID: 257 RVA: 0x0001FDCC File Offset: 0x0001DFCC
			public krnlgay.krnlgayResult Inject(string sDllPath, int PID, bool threadject = false)
			{
				if (!File.Exists(sDllPath))
				{
					return krnlgay.krnlgayResult.DllNotFound;
				}
				if (threadject)
				{
					return krnlgay.krnlgayResult.threaderr;
				}
				Process[] processes = Process.GetProcesses();
				int i = 0;
				uint num = 0U;
				while (i < processes.Length)
				{
					if (processes[i].Id == PID)
					{
						num = (uint)PID;
						break;
					}
					i++;
				}
				if (num == 0U)
				{
					return krnlgay.krnlgayResult.ProcessNotFound;
				}
				if (!this.dllinject(num, sDllPath))
				{
					return krnlgay.krnlgayResult.Failed;
				}
				return krnlgay.krnlgayResult.Success;
			}

			// Token: 0x04000456 RID: 1110
			private static krnlgay.DllInjector _instance;
		}
	}
}
