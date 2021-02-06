using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using krnlss;
using Microsoft.CSharp.RuntimeBinder;
using ScintillaNET;

namespace Controls
{
	// Token: 0x02000036 RID: 54
	public class CustomTabControl : TabControl
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00002732 File Offset: 0x00000932
		// (set) Token: 0x06000103 RID: 259 RVA: 0x0000273A File Offset: 0x0000093A
		public bool ShowClosingButton { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000104 RID: 260 RVA: 0x0001FE20 File Offset: 0x0001E020
		// (set) Token: 0x06000105 RID: 261 RVA: 0x00002743 File Offset: 0x00000943
		[Category("Colors")]
		[Browsable(true)]
		[Description("The color of the selected page")]
		public Color ActiveColor
		{
			get
			{
				if (CustomTabControl.<>o__19.<>p__0 == null)
				{
					CustomTabControl.<>o__19.<>p__0 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
				}
				return CustomTabControl.<>o__19.<>p__0.Target(CustomTabControl.<>o__19.<>p__0, this.activeColor);
			}
			set
			{
				this.activeColor = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000106 RID: 262 RVA: 0x0001FE78 File Offset: 0x0001E078
		// (set) Token: 0x06000107 RID: 263 RVA: 0x0000274C File Offset: 0x0000094C
		[Category("Colors")]
		[Browsable(true)]
		[Description("The color of the background of the tab")]
		public Color BackTabColor
		{
			get
			{
				if (CustomTabControl.<>o__22.<>p__0 == null)
				{
					CustomTabControl.<>o__22.<>p__0 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
				}
				return CustomTabControl.<>o__22.<>p__0.Target(CustomTabControl.<>o__22.<>p__0, this.backTabColor);
			}
			set
			{
				this.backTabColor = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000108 RID: 264 RVA: 0x0001FED0 File Offset: 0x0001E0D0
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00002755 File Offset: 0x00000955
		[Category("Colors")]
		[Browsable(true)]
		[Description("The color of the border of the control")]
		public Color BorderColor
		{
			get
			{
				if (CustomTabControl.<>o__25.<>p__0 == null)
				{
					CustomTabControl.<>o__25.<>p__0 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
				}
				return CustomTabControl.<>o__25.<>p__0.Target(CustomTabControl.<>o__25.<>p__0, this.borderColor);
			}
			set
			{
				this.borderColor = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600010A RID: 266 RVA: 0x0001FF28 File Offset: 0x0001E128
		// (set) Token: 0x0600010B RID: 267 RVA: 0x0000275E File Offset: 0x0000095E
		[Category("Colors")]
		[Browsable(true)]
		[Description("The color of the closing button")]
		public Color ClosingButtonColor
		{
			get
			{
				if (CustomTabControl.<>o__28.<>p__0 == null)
				{
					CustomTabControl.<>o__28.<>p__0 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
				}
				return CustomTabControl.<>o__28.<>p__0.Target(CustomTabControl.<>o__28.<>p__0, this.closingButtonColor);
			}
			set
			{
				this.closingButtonColor = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600010C RID: 268 RVA: 0x0001FF80 File Offset: 0x0001E180
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00002767 File Offset: 0x00000967
		[Category("Options")]
		[Browsable(true)]
		[Description("The message that will be shown before closing.")]
		public string ClosingMessage
		{
			get
			{
				if (CustomTabControl.<>o__31.<>p__0 == null)
				{
					CustomTabControl.<>o__31.<>p__0 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(CustomTabControl)));
				}
				return CustomTabControl.<>o__31.<>p__0.Target(CustomTabControl.<>o__31.<>p__0, this.closingMessage);
			}
			set
			{
				this.closingMessage = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600010E RID: 270 RVA: 0x0001FFD4 File Offset: 0x0001E1D4
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00002770 File Offset: 0x00000970
		[Category("Colors")]
		[Browsable(true)]
		[Description("The color of the header.")]
		public Color HeaderColor
		{
			get
			{
				if (CustomTabControl.<>o__34.<>p__0 == null)
				{
					CustomTabControl.<>o__34.<>p__0 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
				}
				return CustomTabControl.<>o__34.<>p__0.Target(CustomTabControl.<>o__34.<>p__0, this.headerColor);
			}
			set
			{
				this.headerColor = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000110 RID: 272 RVA: 0x0002002C File Offset: 0x0001E22C
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00002779 File Offset: 0x00000979
		[Category("Colors")]
		[Browsable(true)]
		[Description("The color of the horizontal line which is located under the headers of the pages.")]
		public Color HorizontalLineColor
		{
			get
			{
				if (CustomTabControl.<>o__37.<>p__0 == null)
				{
					CustomTabControl.<>o__37.<>p__0 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
				}
				return CustomTabControl.<>o__37.<>p__0.Target(CustomTabControl.<>o__37.<>p__0, this.horizLineColor);
			}
			set
			{
				this.horizLineColor = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00002782 File Offset: 0x00000982
		// (set) Token: 0x06000113 RID: 275 RVA: 0x0000278A File Offset: 0x0000098A
		[Category("Options")]
		[Browsable(true)]
		[Description("Show a Yes/No message before closing?")]
		public bool ShowClosingMessage { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00020084 File Offset: 0x0001E284
		// (set) Token: 0x06000115 RID: 277 RVA: 0x00002793 File Offset: 0x00000993
		[Category("Colors")]
		[Browsable(true)]
		[Description("The color of the title of the page")]
		public Color SelectedTextColor
		{
			get
			{
				if (CustomTabControl.<>o__44.<>p__0 == null)
				{
					CustomTabControl.<>o__44.<>p__0 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
				}
				return CustomTabControl.<>o__44.<>p__0.Target(CustomTabControl.<>o__44.<>p__0, this.selectedTextColor);
			}
			set
			{
				this.selectedTextColor = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000116 RID: 278 RVA: 0x000200DC File Offset: 0x0001E2DC
		// (set) Token: 0x06000117 RID: 279 RVA: 0x0000279C File Offset: 0x0000099C
		[Category("Colors")]
		[Browsable(true)]
		[Description("The color of the title of the page")]
		public Color TextColor
		{
			get
			{
				if (CustomTabControl.<>o__47.<>p__0 == null)
				{
					CustomTabControl.<>o__47.<>p__0 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
				}
				return CustomTabControl.<>o__47.<>p__0.Target(CustomTabControl.<>o__47.<>p__0, this.textColor);
			}
			set
			{
				this.textColor = value;
			}
		}

		// Token: 0x06000118 RID: 280
		[DllImport("user32.dll")]
		private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x06000119 RID: 281 RVA: 0x00020134 File Offset: 0x0001E334
		public CustomTabControl()
		{
			StringFormat stringFormat = new StringFormat();
			StringFormat stringFormat2 = stringFormat;
			if (CustomTabControl.<>o__50.<>p__0 == null)
			{
				CustomTabControl.<>o__50.<>p__0 = CallSite<Func<CallSite, object, StringAlignment>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(StringAlignment), typeof(CustomTabControl)));
			}
			stringFormat2.Alignment = CustomTabControl.<>o__50.<>p__0.Target(CustomTabControl.<>o__50.<>p__0, StringAlignment.Near);
			StringFormat stringFormat3 = stringFormat;
			if (CustomTabControl.<>o__50.<>p__1 == null)
			{
				CustomTabControl.<>o__50.<>p__1 = CallSite<Func<CallSite, object, StringAlignment>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(StringAlignment), typeof(CustomTabControl)));
			}
			stringFormat3.LineAlignment = CustomTabControl.<>o__50.<>p__1.Target(CustomTabControl.<>o__50.<>p__1, StringAlignment.Center);
			this.CenterSringFormat = stringFormat;
			if (CustomTabControl.<>o__50.<>p__2 == null)
			{
				CustomTabControl.<>o__50.<>p__2 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
			}
			this.activeColor = CustomTabControl.<>o__50.<>p__2.Target(CustomTabControl.<>o__50.<>p__2, Color.FromArgb(36, 36, 36));
			if (CustomTabControl.<>o__50.<>p__3 == null)
			{
				CustomTabControl.<>o__50.<>p__3 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
			}
			this.backTabColor = CustomTabControl.<>o__50.<>p__3.Target(CustomTabControl.<>o__50.<>p__3, Color.FromArgb(0, 0, 0));
			if (CustomTabControl.<>o__50.<>p__4 == null)
			{
				CustomTabControl.<>o__50.<>p__4 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
			}
			this.borderColor = CustomTabControl.<>o__50.<>p__4.Target(CustomTabControl.<>o__50.<>p__4, Color.FromArgb(30, 30, 30));
			if (CustomTabControl.<>o__50.<>p__5 == null)
			{
				CustomTabControl.<>o__50.<>p__5 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
			}
			this.closingButtonColor = CustomTabControl.<>o__50.<>p__5.Target(CustomTabControl.<>o__50.<>p__5, Color.WhiteSmoke);
			if (CustomTabControl.<>o__50.<>p__6 == null)
			{
				CustomTabControl.<>o__50.<>p__6 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
			}
			this.headerColor = CustomTabControl.<>o__50.<>p__6.Target(CustomTabControl.<>o__50.<>p__6, Color.FromArgb(45, 45, 48));
			if (CustomTabControl.<>o__50.<>p__7 == null)
			{
				CustomTabControl.<>o__50.<>p__7 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
			}
			this.horizLineColor = CustomTabControl.<>o__50.<>p__7.Target(CustomTabControl.<>o__50.<>p__7, Color.FromArgb(36, 36, 36));
			this.textColor = Color.FromArgb(255, 255, 255);
			this.selectedTextColor = Color.FromArgb(255, 255, 255);
			this.count = 1;
			base..ctor();
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.DoubleBuffered = true;
			base.SizeMode = TabSizeMode.Normal;
			base.ItemSize = new Size(240, 16);
			this.AllowDrop = true;
			base.Selecting += this.TabChanging;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000027A5 File Offset: 0x000009A5
		protected override void CreateHandle()
		{
			base.CreateHandle();
			base.Alignment = TabAlignment.Top;
			CustomTabControl.SendMessage(base.Handle, 4913, IntPtr.Zero, (IntPtr)16);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00020460 File Offset: 0x0001E660
		protected override void OnDragOver(DragEventArgs drgevent)
		{
			if (this.predraggedTab != null)
			{
				TabPage tabPage = (TabPage)drgevent.Data.GetData(typeof(TabPage));
				TabPage pointedTab = this.GetPointedTab();
				int num = base.TabPages.IndexOf(tabPage);
				if (tabPage != null && num != base.TabCount)
				{
					TabPage tabPage2 = base.TabPages[base.TabCount - 1];
					if (tabPage != tabPage2 && tabPage == this.predraggedTab && pointedTab != null)
					{
						drgevent.Effect = DragDropEffects.Move;
						if (pointedTab != tabPage2 && pointedTab != tabPage)
						{
							this.ReplaceTabPages(tabPage, pointedTab);
						}
					}
				}
			}
			base.OnDragOver(drgevent);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000204F4 File Offset: 0x0001E6F4
		protected override void OnMouseDown(MouseEventArgs e)
		{
			this.predraggedTab = this.GetPointedTab();
			Point location = e.Location;
			int num = 0;
			TabPage tabPage;
			for (;;)
			{
				if (CustomTabControl.<>o__53.<>p__1 == null)
				{
					CustomTabControl.<>o__53.<>p__1 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target = CustomTabControl.<>o__53.<>p__1.Target;
				CallSite <>p__ = CustomTabControl.<>o__53.<>p__1;
				if (CustomTabControl.<>o__53.<>p__0 == null)
				{
					CustomTabControl.<>o__53.<>p__0 = CallSite<Func<CallSite, int, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.LessThan, typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (!target(<>p__, CustomTabControl.<>o__53.<>p__0.Target(CustomTabControl.<>o__53.<>p__0, num, base.TabCount)))
				{
					goto IL_515;
				}
				object obj = base.GetTabRect(num);
				if (CustomTabControl.<>o__53.<>p__4 == null)
				{
					CustomTabControl.<>o__53.<>p__4 = CallSite<Action<CallSite, object, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Offset", null, typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Action<CallSite, object, object, int> target2 = CustomTabControl.<>o__53.<>p__4.Target;
				CallSite <>p__2 = CustomTabControl.<>o__53.<>p__4;
				object arg = obj;
				if (CustomTabControl.<>o__53.<>p__3 == null)
				{
					CustomTabControl.<>o__53.<>p__3 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Subtract, typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				Func<CallSite, object, int, object> target3 = CustomTabControl.<>o__53.<>p__3.Target;
				CallSite <>p__3 = CustomTabControl.<>o__53.<>p__3;
				if (CustomTabControl.<>o__53.<>p__2 == null)
				{
					CustomTabControl.<>o__53.<>p__2 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, "Width", typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				target2(<>p__2, arg, target3(<>p__3, CustomTabControl.<>o__53.<>p__2.Target(CustomTabControl.<>o__53.<>p__2, obj), 15), 2);
				if (CustomTabControl.<>o__53.<>p__5 == null)
				{
					CustomTabControl.<>o__53.<>p__5 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "Width", typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				CustomTabControl.<>o__53.<>p__5.Target(CustomTabControl.<>o__53.<>p__5, obj, 10);
				if (CustomTabControl.<>o__53.<>p__6 == null)
				{
					CustomTabControl.<>o__53.<>p__6 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "Height", typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				CustomTabControl.<>o__53.<>p__6.Target(CustomTabControl.<>o__53.<>p__6, obj, 10);
				if (CustomTabControl.<>o__53.<>p__8 == null)
				{
					CustomTabControl.<>o__53.<>p__8 = CallSite<Func<CallSite, object, object>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.Not, typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object> target4 = CustomTabControl.<>o__53.<>p__8.Target;
				CallSite <>p__4 = CustomTabControl.<>o__53.<>p__8;
				if (CustomTabControl.<>o__53.<>p__7 == null)
				{
					CustomTabControl.<>o__53.<>p__7 = CallSite<Func<CallSite, object, Point, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Contains", null, typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
					}));
				}
				object arg2 = target4(<>p__4, CustomTabControl.<>o__53.<>p__7.Target(CustomTabControl.<>o__53.<>p__7, obj, location));
				if (CustomTabControl.<>o__53.<>p__11 == null)
				{
					CustomTabControl.<>o__53.<>p__11 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (!CustomTabControl.<>o__53.<>p__11.Target(CustomTabControl.<>o__53.<>p__11, arg2))
				{
					if (CustomTabControl.<>o__53.<>p__10 == null)
					{
						CustomTabControl.<>o__53.<>p__10 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(CustomTabControl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, bool> target5 = CustomTabControl.<>o__53.<>p__10.Target;
					CallSite <>p__5 = CustomTabControl.<>o__53.<>p__10;
					if (CustomTabControl.<>o__53.<>p__9 == null)
					{
						CustomTabControl.<>o__53.<>p__9 = CallSite<Func<CallSite, object, bool, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.BinaryOperationLogical, ExpressionType.Or, typeof(CustomTabControl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					if (!target5(<>p__5, CustomTabControl.<>o__53.<>p__9.Target(CustomTabControl.<>o__53.<>p__9, arg2, e.Button != MouseButtons.Left)))
					{
						if (num != base.TabCount - 1)
						{
							this.predraggedTab = null;
							tabPage = base.TabPages[num];
							if (CustomTabControl.<>o__53.<>p__12 == null)
							{
								CustomTabControl.<>o__53.<>p__12 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(CustomTabControl), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							if (!CustomTabControl.<>o__53.<>p__12.Target(CustomTabControl.<>o__53.<>p__12, this.ShowClosingMessage))
							{
								break;
							}
							this.CloseTab(tabPage);
						}
						else if (base.GetTabRect(base.TabCount - 1).Contains(e.Location))
						{
							goto Block_18;
						}
					}
				}
				num++;
			}
			if (tabPage.Controls.Count > 0)
			{
				tabPage.Controls[0].Dispose();
			}
			base.TabPages.RemoveAt(num);
			goto IL_515;
			Block_18:
			this.AddEvent("Script.lua", "");
			this.predraggedTab = null;
			IL_515:
			base.OnMouseDown(e);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000027D1 File Offset: 0x000009D1
		protected override void OnMouseMove(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && this.predraggedTab != null)
			{
				base.DoDragDrop(this.predraggedTab, DragDropEffects.Move);
			}
			base.OnMouseMove(e);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000027FD File Offset: 0x000009FD
		protected override void OnMouseUp(MouseEventArgs e)
		{
			this.predraggedTab = null;
			if (e.Button == MouseButtons.Right)
			{
				CustomTabControl.Form1.TabContextMenu.Show(Cursor.Position);
			}
			base.OnMouseUp(e);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00020A20 File Offset: 0x0001EC20
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			if (CustomTabControl.<>o__56.<>p__0 == null)
			{
				CustomTabControl.<>o__56.<>p__0 = CallSite<Action<CallSite, Graphics, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Clear", null, typeof(CustomTabControl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			CustomTabControl.<>o__56.<>p__0.Target(CustomTabControl.<>o__56.<>p__0, graphics, this.headerColor);
			try
			{
				Control selectedTab = base.SelectedTab;
				if (CustomTabControl.<>o__56.<>p__1 == null)
				{
					CustomTabControl.<>o__56.<>p__1 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
				}
				selectedTab.BackColor = CustomTabControl.<>o__56.<>p__1.Target(CustomTabControl.<>o__56.<>p__1, this.backTabColor);
			}
			catch
			{
			}
			try
			{
				base.SelectedTab.BorderStyle = BorderStyle.None;
			}
			catch
			{
			}
			for (int i = 0; i <= base.TabCount - 1; i++)
			{
				TabPage tabPage = base.TabPages[i];
				int num = tabPage.Width = (int)e.Graphics.MeasureString(tabPage.Text, this.Font).Width + 16;
				Rectangle rectangle = new Rectangle(new Point(base.GetTabRect(i).Location.X + 2, base.GetTabRect(i).Location.Y), new Size(base.GetTabRect(i).Width, base.GetTabRect(i).Height));
				Rectangle rectangle2 = new Rectangle(rectangle.Location, new Size(rectangle.Width, rectangle.Height));
				if (CustomTabControl.<>o__56.<>p__2 == null)
				{
					CustomTabControl.<>o__56.<>p__2 = CallSite<Func<CallSite, Type, object, SolidBrush>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Brush brush = CustomTabControl.<>o__56.<>p__2.Target(CustomTabControl.<>o__56.<>p__2, typeof(SolidBrush), this.closingButtonColor);
				if (i != base.SelectedIndex)
				{
					if (CustomTabControl.<>o__56.<>p__4 == null)
					{
						CustomTabControl.<>o__56.<>p__4 = CallSite<Action<CallSite, Graphics, string, Font, SolidBrush, Rectangle, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "DrawString", null, typeof(CustomTabControl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Action<CallSite, Graphics, string, Font, SolidBrush, Rectangle, object> target = CustomTabControl.<>o__56.<>p__4.Target;
					CallSite <>p__ = CustomTabControl.<>o__56.<>p__4;
					Graphics arg = graphics;
					string text = tabPage.Text;
					Font font = this.Font;
					if (CustomTabControl.<>o__56.<>p__3 == null)
					{
						CustomTabControl.<>o__56.<>p__3 = CallSite<Func<CallSite, Type, object, SolidBrush>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(CustomTabControl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					target(<>p__, arg, text, font, CustomTabControl.<>o__56.<>p__3.Target(CustomTabControl.<>o__56.<>p__3, typeof(SolidBrush), this.textColor), rectangle2, this.CenterSringFormat);
				}
				else
				{
					Graphics graphics2 = graphics;
					if (CustomTabControl.<>o__56.<>p__5 == null)
					{
						CustomTabControl.<>o__56.<>p__5 = CallSite<Func<CallSite, Type, object, SolidBrush>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(CustomTabControl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					graphics2.FillRectangle(CustomTabControl.<>o__56.<>p__5.Target(CustomTabControl.<>o__56.<>p__5, typeof(SolidBrush), this.headerColor), rectangle2);
					graphics.FillRectangle(new SolidBrush(Color.FromArgb(36, 36, 36)), new Rectangle(rectangle.X - 5, rectangle.Y - 3, rectangle.Width, rectangle.Height + 5));
					if (CustomTabControl.<>o__56.<>p__7 == null)
					{
						CustomTabControl.<>o__56.<>p__7 = CallSite<Action<CallSite, Graphics, string, Font, SolidBrush, Rectangle, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "DrawString", null, typeof(CustomTabControl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Action<CallSite, Graphics, string, Font, SolidBrush, Rectangle, object> target2 = CustomTabControl.<>o__56.<>p__7.Target;
					CallSite <>p__2 = CustomTabControl.<>o__56.<>p__7;
					Graphics arg2 = graphics;
					string text2 = tabPage.Text;
					Font font2 = this.Font;
					if (CustomTabControl.<>o__56.<>p__6 == null)
					{
						CustomTabControl.<>o__56.<>p__6 = CallSite<Func<CallSite, Type, object, SolidBrush>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(CustomTabControl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					target2(<>p__2, arg2, text2, font2, CustomTabControl.<>o__56.<>p__6.Target(CustomTabControl.<>o__56.<>p__6, typeof(SolidBrush), this.selectedTextColor), rectangle2, this.CenterSringFormat);
				}
				if (i != base.TabCount - 1)
				{
					if (CustomTabControl.<>o__56.<>p__8 == null)
					{
						CustomTabControl.<>o__56.<>p__8 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(CustomTabControl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					if (CustomTabControl.<>o__56.<>p__8.Target(CustomTabControl.<>o__56.<>p__8, this.ShowClosingButton))
					{
						e.Graphics.DrawString("X", this.Font, brush, (float)(rectangle2.Right - 17), 3f);
					}
				}
				else
				{
					using (Font font3 = new Font(SystemFonts.DefaultFont.FontFamily, 14f, FontStyle.Bold))
					{
						e.Graphics.DrawString("+", font3, brush, (float)(rectangle2.Right - 22), (float)(rectangle2.Top / 2 - 4));
					}
				}
				brush.Dispose();
			}
			graphics.DrawLine(new Pen(Color.FromArgb(36, 36, 36), 5f), new Point(0, 19), new Point(base.Width, 19));
			Graphics graphics3 = graphics;
			if (CustomTabControl.<>o__56.<>p__9 == null)
			{
				CustomTabControl.<>o__56.<>p__9 = CallSite<Func<CallSite, Type, object, SolidBrush>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(CustomTabControl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			graphics3.FillRectangle(CustomTabControl.<>o__56.<>p__9.Target(CustomTabControl.<>o__56.<>p__9, typeof(SolidBrush), this.backTabColor), new Rectangle(0, 20, base.Width, base.Height - 20));
			Graphics graphics4 = graphics;
			if (CustomTabControl.<>o__56.<>p__10 == null)
			{
				CustomTabControl.<>o__56.<>p__10 = CallSite<Func<CallSite, Type, object, int, Pen>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(CustomTabControl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			graphics4.DrawRectangle(CustomTabControl.<>o__56.<>p__10.Target(CustomTabControl.<>o__56.<>p__10, typeof(Pen), this.borderColor, 2), new Rectangle(0, 0, base.Width, base.Height));
			graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00021158 File Offset: 0x0001F358
		private TabPage GetPointedTab()
		{
			int num = 0;
			for (;;)
			{
				if (CustomTabControl.<>o__57.<>p__2 == null)
				{
					CustomTabControl.<>o__57.<>p__2 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target = CustomTabControl.<>o__57.<>p__2.Target;
				CallSite <>p__ = CustomTabControl.<>o__57.<>p__2;
				if (CustomTabControl.<>o__57.<>p__1 == null)
				{
					CustomTabControl.<>o__57.<>p__1 = CallSite<Func<CallSite, int, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.LessThanOrEqual, typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, int, object, object> target2 = CustomTabControl.<>o__57.<>p__1.Target;
				CallSite <>p__2 = CustomTabControl.<>o__57.<>p__1;
				int arg = num;
				if (CustomTabControl.<>o__57.<>p__0 == null)
				{
					CustomTabControl.<>o__57.<>p__0 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Subtract, typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (!target(<>p__, target2(<>p__2, arg, CustomTabControl.<>o__57.<>p__0.Target(CustomTabControl.<>o__57.<>p__0, base.TabPages.Count, 1))))
				{
					goto Block_9;
				}
				if (CustomTabControl.<>o__57.<>p__5 == null)
				{
					CustomTabControl.<>o__57.<>p__5 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target3 = CustomTabControl.<>o__57.<>p__5.Target;
				CallSite <>p__3 = CustomTabControl.<>o__57.<>p__5;
				if (CustomTabControl.<>o__57.<>p__4 == null)
				{
					CustomTabControl.<>o__57.<>p__4 = CallSite<Func<CallSite, Rectangle, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Contains", null, typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, Rectangle, object, object> target4 = CustomTabControl.<>o__57.<>p__4.Target;
				CallSite <>p__4 = CustomTabControl.<>o__57.<>p__4;
				Rectangle tabRect = base.GetTabRect(num);
				if (CustomTabControl.<>o__57.<>p__3 == null)
				{
					CustomTabControl.<>o__57.<>p__3 = CallSite<Func<CallSite, CustomTabControl, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "PointToClient", null, typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				if (target3(<>p__3, target4(<>p__4, tabRect, CustomTabControl.<>o__57.<>p__3.Target(CustomTabControl.<>o__57.<>p__3, this, Cursor.Position))))
				{
					break;
				}
				num++;
			}
			if (CustomTabControl.<>o__57.<>p__6 == null)
			{
				CustomTabControl.<>o__57.<>p__6 = CallSite<Func<CallSite, object, TabPage>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(TabPage), typeof(CustomTabControl)));
			}
			return CustomTabControl.<>o__57.<>p__6.Target(CustomTabControl.<>o__57.<>p__6, base.TabPages[num]);
			Block_9:
			return null;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000213C4 File Offset: 0x0001F5C4
		private void ReplaceTabPages(TabPage Source, TabPage Destination)
		{
			object obj = base.TabPages.IndexOf(Source);
			object obj2 = base.TabPages.IndexOf(Destination);
			if (CustomTabControl.<>o__58.<>p__0 == null)
			{
				CustomTabControl.<>o__58.<>p__0 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(CustomTabControl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			object obj3 = CustomTabControl.<>o__58.<>p__0.Target(CustomTabControl.<>o__58.<>p__0, obj, -1);
			if (CustomTabControl.<>o__58.<>p__1 == null)
			{
				CustomTabControl.<>o__58.<>p__1 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(CustomTabControl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			if (!CustomTabControl.<>o__58.<>p__1.Target(CustomTabControl.<>o__58.<>p__1, obj3))
			{
				if (CustomTabControl.<>o__58.<>p__4 == null)
				{
					CustomTabControl.<>o__58.<>p__4 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target = CustomTabControl.<>o__58.<>p__4.Target;
				CallSite <>p__ = CustomTabControl.<>o__58.<>p__4;
				if (CustomTabControl.<>o__58.<>p__3 == null)
				{
					CustomTabControl.<>o__58.<>p__3 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Or, typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, object, object> target2 = CustomTabControl.<>o__58.<>p__3.Target;
				CallSite <>p__2 = CustomTabControl.<>o__58.<>p__3;
				object arg = obj3;
				if (CustomTabControl.<>o__58.<>p__2 == null)
				{
					CustomTabControl.<>o__58.<>p__2 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (!target(<>p__, target2(<>p__2, arg, CustomTabControl.<>o__58.<>p__2.Target(CustomTabControl.<>o__58.<>p__2, obj2, -1))))
				{
					if (CustomTabControl.<>o__58.<>p__5 == null)
					{
						CustomTabControl.<>o__58.<>p__5 = CallSite<Func<CallSite, TabControl.TabPageCollection, object, TabPage, object>>.Create(Binder.SetIndex(CSharpBinderFlags.None, typeof(CustomTabControl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					CustomTabControl.<>o__58.<>p__5.Target(CustomTabControl.<>o__58.<>p__5, base.TabPages, obj2, Source);
					if (CustomTabControl.<>o__58.<>p__6 == null)
					{
						CustomTabControl.<>o__58.<>p__6 = CallSite<Func<CallSite, TabControl.TabPageCollection, object, TabPage, object>>.Create(Binder.SetIndex(CSharpBinderFlags.None, typeof(CustomTabControl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
						}));
					}
					CustomTabControl.<>o__58.<>p__6.Target(CustomTabControl.<>o__58.<>p__6, base.TabPages, obj, Destination);
					if (CustomTabControl.<>o__58.<>p__8 == null)
					{
						CustomTabControl.<>o__58.<>p__8 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(CustomTabControl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, bool> target3 = CustomTabControl.<>o__58.<>p__8.Target;
					CallSite <>p__3 = CustomTabControl.<>o__58.<>p__8;
					if (CustomTabControl.<>o__58.<>p__7 == null)
					{
						CustomTabControl.<>o__58.<>p__7 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(CustomTabControl), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					if (target3(<>p__3, CustomTabControl.<>o__58.<>p__7.Target(CustomTabControl.<>o__58.<>p__7, base.SelectedIndex, obj)))
					{
						if (CustomTabControl.<>o__58.<>p__9 == null)
						{
							CustomTabControl.<>o__58.<>p__9 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(CustomTabControl)));
						}
						base.SelectedIndex = CustomTabControl.<>o__58.<>p__9.Target(CustomTabControl.<>o__58.<>p__9, obj2);
					}
					else
					{
						if (CustomTabControl.<>o__58.<>p__11 == null)
						{
							CustomTabControl.<>o__58.<>p__11 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(CustomTabControl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, bool> target4 = CustomTabControl.<>o__58.<>p__11.Target;
						CallSite <>p__4 = CustomTabControl.<>o__58.<>p__11;
						if (CustomTabControl.<>o__58.<>p__10 == null)
						{
							CustomTabControl.<>o__58.<>p__10 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(CustomTabControl), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						if (target4(<>p__4, CustomTabControl.<>o__58.<>p__10.Target(CustomTabControl.<>o__58.<>p__10, base.SelectedIndex, obj2)))
						{
							if (CustomTabControl.<>o__58.<>p__12 == null)
							{
								CustomTabControl.<>o__58.<>p__12 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(CustomTabControl)));
							}
							base.SelectedIndex = CustomTabControl.<>o__58.<>p__12.Target(CustomTabControl.<>o__58.<>p__12, obj);
						}
					}
					this.Refresh();
				}
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0002183C File Offset: 0x0001FA3C
		public void CloseTab(TabPage tab)
		{
			Scintilla scintilla = tab.Controls[0] as Scintilla;
			if (CustomTabControl.<>o__59.<>p__0 == null)
			{
				CustomTabControl.<>o__59.<>p__0 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(CustomTabControl)));
			}
			int num = CustomTabControl.<>o__59.<>p__0.Target(CustomTabControl.<>o__59.<>p__0, base.TabPages.IndexOf(tab));
			if (num != 0 || base.TabCount > 2)
			{
				base.TabPages.RemoveAt(num);
				this.count--;
				return;
			}
			TabPage tabPage = base.TabPages[0];
			if (CustomTabControl.<>o__59.<>p__1 == null)
			{
				CustomTabControl.<>o__59.<>p__1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(CustomTabControl)));
			}
			tab.Text = CustomTabControl.<>o__59.<>p__1.Target(CustomTabControl.<>o__59.<>p__1, "Untitled.lua");
			scintilla.Text = "";
			scintilla.Refresh();
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0002193C File Offset: 0x0001FB3C
		private void DragOverEnterHandler(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				if (CustomTabControl.<>o__60.<>p__0 == null)
				{
					CustomTabControl.<>o__60.<>p__0 = CallSite<Func<CallSite, object, DragDropEffects>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(DragDropEffects), typeof(CustomTabControl)));
				}
				e.Effect = CustomTabControl.<>o__60.<>p__0.Target(CustomTabControl.<>o__60.<>p__0, DragDropEffects.Copy);
				return;
			}
			e.Effect = DragDropEffects.None;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000219B0 File Offset: 0x0001FBB0
		private void DragDropHandler(object sender, DragEventArgs e)
		{
			string[] array = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			foreach (string text in array)
			{
				if (CustomTabControl.<>o__61.<>p__1 == null)
				{
					CustomTabControl.<>o__61.<>p__1 = CallSite<Action<CallSite, CustomTabControl, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "AddEvent", null, typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Action<CallSite, CustomTabControl, string, object> target = CustomTabControl.<>o__61.<>p__1.Target;
				CallSite <>p__ = CustomTabControl.<>o__61.<>p__1;
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
				if (CustomTabControl.<>o__61.<>p__0 == null)
				{
					CustomTabControl.<>o__61.<>p__0 = CallSite<Func<CallSite, Type, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ReadAllText", null, typeof(CustomTabControl), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				target(<>p__, this, fileNameWithoutExtension, CustomTabControl.<>o__61.<>p__0.Target(CustomTabControl.<>o__61.<>p__0, typeof(File), text));
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00021ABC File Offset: 0x0001FCBC
		public Scintilla NewEditor(string script)
		{
			Scintilla scintilla = new Scintilla();
			scintilla.AllowDrop = true;
			Scintilla scintilla2 = scintilla;
			if (CustomTabControl.<>o__62.<>p__2 == null)
			{
				CustomTabControl.<>o__62.<>p__2 = CallSite<Func<CallSite, object, AutomaticFold>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(AutomaticFold), typeof(CustomTabControl)));
			}
			Func<CallSite, object, AutomaticFold> target = CustomTabControl.<>o__62.<>p__2.Target;
			CallSite <>p__ = CustomTabControl.<>o__62.<>p__2;
			if (CustomTabControl.<>o__62.<>p__1 == null)
			{
				CustomTabControl.<>o__62.<>p__1 = CallSite<Func<CallSite, object, AutomaticFold, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Or, typeof(CustomTabControl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, AutomaticFold, object> target2 = CustomTabControl.<>o__62.<>p__1.Target;
			CallSite <>p__2 = CustomTabControl.<>o__62.<>p__1;
			if (CustomTabControl.<>o__62.<>p__0 == null)
			{
				CustomTabControl.<>o__62.<>p__0 = CallSite<Func<CallSite, object, AutomaticFold, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Or, typeof(CustomTabControl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			scintilla2.AutomaticFold = target(<>p__, target2(<>p__2, CustomTabControl.<>o__62.<>p__0.Target(CustomTabControl.<>o__62.<>p__0, AutomaticFold.Show, AutomaticFold.Click), AutomaticFold.Change));
			scintilla.BackColor = Color.Black;
			scintilla.BorderStyle = BorderStyle.None;
			scintilla.Lexer = Lexer.Lua;
			scintilla.Name = "scintilla";
			scintilla.Dock = DockStyle.Fill;
			scintilla.ScrollWidth = 1;
			scintilla.TabIndex = 0;
			scintilla.Styles[32].Size = 15;
			scintilla.Styles[32].Size = 15;
			scintilla.Styles[32].Size = 15;
			if (CustomTabControl.<>o__62.<>p__3 == null)
			{
				CustomTabControl.<>o__62.<>p__3 = CallSite<Action<CallSite, Scintilla, bool, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "SetSelectionBackColor", null, typeof(CustomTabControl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			CustomTabControl.<>o__62.<>p__3.Target(CustomTabControl.<>o__62.<>p__3, scintilla, true, Color.FromArgb(17, 177, 255));
			if (CustomTabControl.<>o__62.<>p__4 == null)
			{
				CustomTabControl.<>o__62.<>p__4 = CallSite<Action<CallSite, Scintilla, bool, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "SetSelectionForeColor", null, typeof(CustomTabControl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			CustomTabControl.<>o__62.<>p__4.Target(CustomTabControl.<>o__62.<>p__4, scintilla, true, Color.Black);
			scintilla.Margins[1].Width = 0;
			scintilla.StyleResetDefault();
			Style style = scintilla.Styles[32];
			if (CustomTabControl.<>o__62.<>p__5 == null)
			{
				CustomTabControl.<>o__62.<>p__5 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(CustomTabControl)));
			}
			style.Font = CustomTabControl.<>o__62.<>p__5.Target(CustomTabControl.<>o__62.<>p__5, "Consolas");
			scintilla.Styles[32].Size = 10;
			Style style2 = scintilla.Styles[32];
			if (CustomTabControl.<>o__62.<>p__6 == null)
			{
				CustomTabControl.<>o__62.<>p__6 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
			}
			style2.BackColor = CustomTabControl.<>o__62.<>p__6.Target(CustomTabControl.<>o__62.<>p__6, Color.FromArgb(40, 40, 40));
			Style style3 = scintilla.Styles[32];
			if (CustomTabControl.<>o__62.<>p__7 == null)
			{
				CustomTabControl.<>o__62.<>p__7 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
			}
			style3.ForeColor = CustomTabControl.<>o__62.<>p__7.Target(CustomTabControl.<>o__62.<>p__7, Color.White);
			scintilla.StyleClearAll();
			Style style4 = scintilla.Styles[11];
			if (CustomTabControl.<>o__62.<>p__8 == null)
			{
				CustomTabControl.<>o__62.<>p__8 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
			}
			style4.ForeColor = CustomTabControl.<>o__62.<>p__8.Target(CustomTabControl.<>o__62.<>p__8, Color.White);
			Style style5 = scintilla.Styles[1];
			if (CustomTabControl.<>o__62.<>p__9 == null)
			{
				CustomTabControl.<>o__62.<>p__9 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
			}
			style5.ForeColor = CustomTabControl.<>o__62.<>p__9.Target(CustomTabControl.<>o__62.<>p__9, Color.FromArgb(79, 81, 98));
			Style style6 = scintilla.Styles[2];
			if (CustomTabControl.<>o__62.<>p__10 == null)
			{
				CustomTabControl.<>o__62.<>p__10 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
			}
			style6.ForeColor = CustomTabControl.<>o__62.<>p__10.Target(CustomTabControl.<>o__62.<>p__10, Color.FromArgb(79, 81, 98));
			Style style7 = scintilla.Styles[3];
			if (CustomTabControl.<>o__62.<>p__11 == null)
			{
				CustomTabControl.<>o__62.<>p__11 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
			}
			style7.ForeColor = CustomTabControl.<>o__62.<>p__11.Target(CustomTabControl.<>o__62.<>p__11, Color.FromArgb(58, 64, 34));
			Style style8 = scintilla.Styles[4];
			if (CustomTabControl.<>o__62.<>p__12 == null)
			{
				CustomTabControl.<>o__62.<>p__12 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
			}
			style8.ForeColor = CustomTabControl.<>o__62.<>p__12.Target(CustomTabControl.<>o__62.<>p__12, Color.FromArgb(165, 112, 255));
			Style style9 = scintilla.Styles[6];
			if (CustomTabControl.<>o__62.<>p__13 == null)
			{
				CustomTabControl.<>o__62.<>p__13 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
			}
			style9.ForeColor = CustomTabControl.<>o__62.<>p__13.Target(CustomTabControl.<>o__62.<>p__13, Color.FromArgb(255, 192, 115));
			Style style10 = scintilla.Styles[7];
			if (CustomTabControl.<>o__62.<>p__14 == null)
			{
				CustomTabControl.<>o__62.<>p__14 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
			}
			style10.ForeColor = CustomTabControl.<>o__62.<>p__14.Target(CustomTabControl.<>o__62.<>p__14, Color.FromArgb(255, 192, 115));
			Style style11 = scintilla.Styles[8];
			if (CustomTabControl.<>o__62.<>p__15 == null)
			{
				CustomTabControl.<>o__62.<>p__15 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
			}
			style11.ForeColor = CustomTabControl.<>o__62.<>p__15.Target(CustomTabControl.<>o__62.<>p__15, Color.FromArgb(255, 192, 115));
			Style style12 = scintilla.Styles[9];
			if (CustomTabControl.<>o__62.<>p__16 == null)
			{
				CustomTabControl.<>o__62.<>p__16 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
			}
			style12.ForeColor = CustomTabControl.<>o__62.<>p__16.Target(CustomTabControl.<>o__62.<>p__16, Color.FromArgb(138, 175, 238));
			Style style13 = scintilla.Styles[10];
			if (CustomTabControl.<>o__62.<>p__17 == null)
			{
				CustomTabControl.<>o__62.<>p__17 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
			}
			style13.ForeColor = CustomTabControl.<>o__62.<>p__17.Target(CustomTabControl.<>o__62.<>p__17, Color.White);
			Style style14 = scintilla.Styles[5];
			if (CustomTabControl.<>o__62.<>p__18 == null)
			{
				CustomTabControl.<>o__62.<>p__18 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
			}
			style14.ForeColor = CustomTabControl.<>o__62.<>p__18.Target(CustomTabControl.<>o__62.<>p__18, Color.FromArgb(255, 60, 122));
			Style style15 = scintilla.Styles[13];
			if (CustomTabControl.<>o__62.<>p__19 == null)
			{
				CustomTabControl.<>o__62.<>p__19 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
			}
			style15.ForeColor = CustomTabControl.<>o__62.<>p__19.Target(CustomTabControl.<>o__62.<>p__19, Color.FromArgb(89, 255, 172));
			scintilla.Styles[13].Bold = true;
			Style style16 = scintilla.Styles[14];
			if (CustomTabControl.<>o__62.<>p__20 == null)
			{
				CustomTabControl.<>o__62.<>p__20 = CallSite<Func<CallSite, object, Color>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Color), typeof(CustomTabControl)));
			}
			style16.ForeColor = CustomTabControl.<>o__62.<>p__20.Target(CustomTabControl.<>o__62.<>p__20, Color.FromArgb(89, 255, 172));
			scintilla.Styles[14].Bold = true;
			scintilla.Lexer = Lexer.Lua;
			scintilla.SetProperty("fold", "1");
			scintilla.SetProperty("fold.compact", "1");
			scintilla.Margins[0].Width = 15;
			scintilla.Margins[0].Type = MarginType.Number;
			scintilla.Margins[1].Type = MarginType.Symbol;
			scintilla.Margins[1].Mask = 4261412864U;
			scintilla.Margins[1].Sensitive = true;
			scintilla.Margins[1].Width = 8;
			for (int i = 25; i <= 31; i++)
			{
				scintilla.Markers[i].SetForeColor(Color.White);
				scintilla.Markers[i].SetBackColor(Color.White);
			}
			scintilla.Markers[30].Symbol = MarkerSymbol.BoxPlus;
			scintilla.Markers[31].Symbol = MarkerSymbol.BoxMinus;
			scintilla.Markers[25].Symbol = MarkerSymbol.BoxPlusConnected;
			scintilla.Markers[27].Symbol = MarkerSymbol.TCorner;
			scintilla.Markers[26].Symbol = MarkerSymbol.BoxMinusConnected;
			scintilla.Markers[29].Symbol = MarkerSymbol.VLine;
			scintilla.Markers[28].Symbol = MarkerSymbol.LCorner;
			scintilla.Styles[33].BackColor = Color.FromArgb(40, 40, 40);
			scintilla.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);
			scintilla.SetFoldMarginColor(true, Color.FromArgb(40, 40, 40));
			scintilla.SetFoldMarginHighlightColor(true, Color.FromArgb(40, 40, 40));
			if (CustomTabControl.<>o__62.<>p__21 == null)
			{
				CustomTabControl.<>o__62.<>p__21 = CallSite<Action<CallSite, Scintilla, int, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "SetKeywords", null, typeof(CustomTabControl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			CustomTabControl.<>o__62.<>p__21.Target(CustomTabControl.<>o__62.<>p__21, scintilla, 0, "and break do else elseif end false for function if in local nil not or repeat return then true until while");
			if (CustomTabControl.<>o__62.<>p__22 == null)
			{
				CustomTabControl.<>o__62.<>p__22 = CallSite<Action<CallSite, Scintilla, int, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "SetKeywords", null, typeof(CustomTabControl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			CustomTabControl.<>o__62.<>p__22.Target(CustomTabControl.<>o__62.<>p__22, scintilla, 1, "warn CFrame CFrame.fromEulerAnglesXYZ Synapse Decompile Synapse Copy Synapse Write CFrame.Angles CFrame.fromAxisAngle CFrame.new gcinfo os os.difftime os.time tick UDim UDim.new Instance Instance.Lock Instance.Unlock Instance.new pairs NumberSequence NumberSequence.new assert tonumber getmetatable Color3 Color3.fromHSV Color3.toHSV Color3.fromRGB Color3.new load Stats _G UserSettings Ray Ray.new coroutine coroutine.resume coroutine.yield coroutine.status coroutine.wrap coroutine.create coroutine.running NumberRange NumberRange.new PhysicalProperties Physicalnew printidentity PluginManager loadstring NumberSequenceKeypoint NumberSequenceKeypoint.new Version Vector2 Vector2.new wait game. game.Players game.ReplicatedStorage Game delay spawn string string.sub string.upper string.len string.gfind string.rep string.find string.match string.char string.dump string.gmatch string.reverse string.byte string.format string.gsub string.lower CellId CellId.new Delay version stats typeof UDim2 UDim2.new table table.setn table.insert table.getn table.foreachi table.maxn table.foreach table.concat table.sort table.remove settings LoadLibrary require Vector3 Vector3.FromNormalId Vector3.FromAxis Vector3.new Vector3int16 Vector3int16.new setmetatable next ypcall ipairs Wait rawequal Region3int16 Region3int16.new collectgarbage game newproxy Spawn elapsedTime Region3 Region3.new time xpcall shared rawset tostring print Workspace Vector2int16 Vector2int16.new workspace unpack math math.log math.noise math.acos math.huge math.ldexp math.pi math.cos math.tanh math.pow math.deg math.tan math.cosh math.sinh math.random math.randomseed math.frexp math.ceil math.floor math.rad math.abs math.sqrt math.modf math.asin math.min math.max math.fmod math.log10 math.atan2 math.exp math.sin math.atan ColorSequenceKeypoint ColorSequenceKeypoint.new pcall getfenv ColorSequence ColorSequence.new type ElapsedTime select Faces Faces.new rawget debug debug.traceback debug.profileend debug.profilebegin Rect Rect.new BrickColor BrickColor.Blue BrickColor.White BrickColor.Yellow BrickColor.Red BrickColor.Gray BrickColor.palette BrickColor.New BrickColor.Black BrickColor.Green BrickColor.Random BrickColor.DarkGray BrickColor.random BrickColor.new setfenv dofile Axes Axes.new error loadfile ");
			if (CustomTabControl.<>o__62.<>p__23 == null)
			{
				CustomTabControl.<>o__62.<>p__23 = CallSite<Action<CallSite, Scintilla, int, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "SetKeywords", null, typeof(CustomTabControl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			CustomTabControl.<>o__62.<>p__23.Target(CustomTabControl.<>o__62.<>p__23, scintilla, 2, "getrawmetatable loadstring getnamecallmethod setreadonly islclosure getgenv unlockModule lockModule mousemoverel debug.getupvalue debug.getupvalues debug.setupvalue debug.getmetatable debug.getregistry setclipboard setthreadcontext getthreadcontext checkcaller getgc debug.getconstant getrenv getreg ");
			scintilla.ScrollWidth = 1;
			scintilla.ScrollWidthTracking = true;
			scintilla.CaretForeColor = Color.White;
			scintilla.BackColor = Color.White;
			scintilla.BorderStyle = BorderStyle.None;
			scintilla.TextChanged += this.scintilla1_TextChanged;
			scintilla.WrapIndentMode = WrapIndentMode.Indent;
			scintilla.WrapVisualFlagLocation = WrapVisualFlagLocation.EndByText;
			scintilla.BorderStyle = BorderStyle.None;
			scintilla.Text = script;
			return scintilla;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000226D8 File Offset: 0x000208D8
		private void scintilla1_TextChanged(object sender, EventArgs e)
		{
			Scintilla scintilla = (Scintilla)sender;
			int length = scintilla.Lines.Count.ToString().Length;
			Margin margin = scintilla.Margins[0];
			if (CustomTabControl.<>o__63.<>p__2 == null)
			{
				CustomTabControl.<>o__63.<>p__2 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(CustomTabControl)));
			}
			Func<CallSite, object, int> target = CustomTabControl.<>o__63.<>p__2.Target;
			CallSite <>p__ = CustomTabControl.<>o__63.<>p__2;
			if (CustomTabControl.<>o__63.<>p__1 == null)
			{
				CustomTabControl.<>o__63.<>p__1 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(CustomTabControl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			Func<CallSite, object, int, object> target2 = CustomTabControl.<>o__63.<>p__1.Target;
			CallSite <>p__2 = CustomTabControl.<>o__63.<>p__1;
			if (CustomTabControl.<>o__63.<>p__0 == null)
			{
				CustomTabControl.<>o__63.<>p__0 = CallSite<Func<CallSite, Scintilla, int, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "TextWidth", null, typeof(CustomTabControl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			margin.Width = target(<>p__, target2(<>p__2, CustomTabControl.<>o__63.<>p__0.Target(CustomTabControl.<>o__63.<>p__0, scintilla, 10, new string('9', length + 1)), 2));
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00022814 File Offset: 0x00020A14
		public void addnewtab()
		{
			int num = base.TabCount - 1;
			base.TabPages.Insert(num, string.Format("Script{0}.lua", base.TabCount));
			base.TabPages[num].Controls.Add(this.NewEditor(""));
			base.SelectedIndex = num;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000282E File Offset: 0x00000A2E
		public Scintilla GetWorkingTextEditor()
		{
			if (base.SelectedTab == null)
			{
				this.addnewtab();
				return base.SelectedTab.Controls[0] as Scintilla;
			}
			return base.SelectedTab.Controls[0] as Scintilla;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00022874 File Offset: 0x00020A74
		public void AddEvent(string name = "Script.lua", string content = "")
		{
			if (string.IsNullOrEmpty(this.GetWorkingTextEditor().Text) && !string.IsNullOrEmpty(content))
			{
				this.addnewtab();
				Control selectedTab = base.SelectedTab;
				if (CustomTabControl.<>o__66.<>p__0 == null)
				{
					CustomTabControl.<>o__66.<>p__0 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(CustomTabControl)));
				}
				selectedTab.Text = CustomTabControl.<>o__66.<>p__0.Target(CustomTabControl.<>o__66.<>p__0, "Script " + this.count.ToString() + ".lua");
				base.SelectedTab.Controls[0].Text = content;
				base.SelectedTab.Controls[0].Refresh();
			}
			else
			{
				this.addnewtab();
				if (name.Contains("Script" + this.count.ToString() + ".lua"))
				{
					Control selectedTab2 = base.SelectedTab;
					if (CustomTabControl.<>o__66.<>p__1 == null)
					{
						CustomTabControl.<>o__66.<>p__1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(CustomTabControl)));
					}
					selectedTab2.Text = CustomTabControl.<>o__66.<>p__1.Target(CustomTabControl.<>o__66.<>p__1, "Script " + this.count.ToString() + ".lua");
				}
			}
			this.count++;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000229D8 File Offset: 0x00020BD8
		public void TabChanging(object sender, TabControlCancelEventArgs e)
		{
			if (CustomTabControl.<>o__67.<>p__2 == null)
			{
				CustomTabControl.<>o__67.<>p__2 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(CustomTabControl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, object, bool> target = CustomTabControl.<>o__67.<>p__2.Target;
			CallSite <>p__ = CustomTabControl.<>o__67.<>p__2;
			if (CustomTabControl.<>o__67.<>p__1 == null)
			{
				CustomTabControl.<>o__67.<>p__1 = CallSite<Func<CallSite, int, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Equal, typeof(CustomTabControl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
				}));
			}
			Func<CallSite, int, object, object> target2 = CustomTabControl.<>o__67.<>p__1.Target;
			CallSite <>p__2 = CustomTabControl.<>o__67.<>p__1;
			int tabPageIndex = e.TabPageIndex;
			if (CustomTabControl.<>o__67.<>p__0 == null)
			{
				CustomTabControl.<>o__67.<>p__0 = CallSite<Func<CallSite, object, int, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Subtract, typeof(CustomTabControl), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			if (target(<>p__, target2(<>p__2, tabPageIndex, CustomTabControl.<>o__67.<>p__0.Target(CustomTabControl.<>o__67.<>p__0, base.TabCount, 1))))
			{
				e.Cancel = true;
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00022AEC File Offset: 0x00020CEC
		public string OpenSaveDialog(TabPage tab, string text)
		{
			string result;
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				FileDialog fileDialog = saveFileDialog;
				if (CustomTabControl.<>o__68.<>p__0 == null)
				{
					CustomTabControl.<>o__68.<>p__0 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(CustomTabControl)));
				}
				fileDialog.Filter = CustomTabControl.<>o__68.<>p__0.Target(CustomTabControl.<>o__68.<>p__0, "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt|All Files (*.*)|*.*");
				saveFileDialog.RestoreDirectory = true;
				saveFileDialog.FileName = tab.Text;
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					File.WriteAllText(saveFileDialog.FileName, text);
					result = new FileInfo(saveFileDialog.FileName).Name;
				}
				else
				{
					result = tab.Text;
				}
			}
			return result;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00022BA8 File Offset: 0x00020DA8
		public bool OpenFileDialog(TabPage tab)
		{
			bool result;
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				FileDialog fileDialog = openFileDialog;
				if (CustomTabControl.<>o__69.<>p__0 == null)
				{
					CustomTabControl.<>o__69.<>p__0 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(CustomTabControl)));
				}
				fileDialog.Filter = CustomTabControl.<>o__69.<>p__0.Target(CustomTabControl.<>o__69.<>p__0, "Lua Files (*.lua)|*.lua|Text Files (*.txt)|*.txt|All Files (*.*)|*.*");
				openFileDialog.RestoreDirectory = true;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.GetWorkingTextEditor().Text = File.ReadAllText(openFileDialog.FileName);
					if (CustomTabControl.<>o__69.<>p__1 == null)
					{
						CustomTabControl.<>o__69.<>p__1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(CustomTabControl)));
					}
					tab.Text = CustomTabControl.<>o__69.<>p__1.Target(CustomTabControl.<>o__69.<>p__1, Path.GetFileName(openFileDialog.FileName));
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x04000457 RID: 1111
		private readonly StringFormat CenterSringFormat;

		// Token: 0x04000458 RID: 1112
		private Color activeColor;

		// Token: 0x04000459 RID: 1113
		private Color backTabColor;

		// Token: 0x0400045A RID: 1114
		private Color borderColor;

		// Token: 0x0400045B RID: 1115
		private Color closingButtonColor;

		// Token: 0x0400045C RID: 1116
		private string closingMessage;

		// Token: 0x0400045D RID: 1117
		private Color headerColor;

		// Token: 0x0400045E RID: 1118
		private Color horizLineColor;

		// Token: 0x0400045F RID: 1119
		private TabPage predraggedTab;

		// Token: 0x04000460 RID: 1120
		public TabPage contextTab;

		// Token: 0x04000461 RID: 1121
		private Color textColor;

		// Token: 0x04000462 RID: 1122
		public Color selectedTextColor;

		// Token: 0x04000463 RID: 1123
		public static krnl Form1;

		// Token: 0x04000464 RID: 1124
		private int count;
	}
}
