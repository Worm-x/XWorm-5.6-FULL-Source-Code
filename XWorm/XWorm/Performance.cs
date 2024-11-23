#define DEBUG
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Microsoft.VisualBasic.CompilerServices;


namespace XWorm;

[DesignerGenerated]
public class Performance : Form
{
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
	[AccessedThroughProperty("Guna2GradientButton1")]
	private Guna2GradientButton _Guna2GradientButton1;

	public GClass5 gclass5_0;

	[field: AccessedThroughProperty("Label1")]
	public Label Label1
	;


	[field: AccessedThroughProperty("Label2")]
	public Label Label2
	;

	public System.Windows.Forms.Timer Timer1
	;

	public System.Windows.Forms.Timer Timer2
	;

	[field: AccessedThroughProperty("Label4")]
	public Label Label4
	;

	[field: AccessedThroughProperty("Label3")]
	public Label Label3
	;

	[field: AccessedThroughProperty("Label5")]
	public Label Label5
	;

	[field: AccessedThroughProperty("Panel1")]
	public Panel Panel1
	;

	[field: AccessedThroughProperty("Label6")]
	public Label Label6
	;

	[field: AccessedThroughProperty("Label7")]
	public Label Label7
	;

	[field: AccessedThroughProperty("Panel2")]
	public Panel Panel2
	;

	[field: AccessedThroughProperty("Label8")]
	public Label Label8
	;

	[field: AccessedThroughProperty("Label9")]
	public Label Label9
	;

	[field: AccessedThroughProperty("Panel3")]
	public Panel Panel3
	;

	[field: AccessedThroughProperty("Label10")]
	public Label Label10
	;

	[field: AccessedThroughProperty("Panel4")]
	public Panel Panel4
	;

	[field: AccessedThroughProperty("Label11")]
	public Label Label11
	;

	[field: AccessedThroughProperty("Label12")]
	public Label Label12
	;

	[field: AccessedThroughProperty("Panel5")]
	public Panel Panel5
	;

	[field: AccessedThroughProperty("Guna2Panel1")]
	public Guna2Panel Guna2Panel1
	;

	public Guna2GradientButton Guna2GradientButton1
	;

	[field: AccessedThroughProperty("Guna2Panel3")]
	public Guna2Panel Guna2Panel3
	;

	[field: AccessedThroughProperty("Guna2Panel2")]
	public Guna2Panel Guna2Panel2
	;

	[field: AccessedThroughProperty("Guna2CircleProgressBar1")]
	public Guna2CircleProgressBar Guna2CircleProgressBar1
	;

	[field: AccessedThroughProperty("Guna2CircleProgressBar2")]
	public Guna2CircleProgressBar Guna2CircleProgressBar2
	;

	[field: AccessedThroughProperty("Label13")]
	public Label Label13
	;

	[field: AccessedThroughProperty("Label14")]
	public Label Label14
	;

	[field: AccessedThroughProperty("PictureBox1")]
	public PictureBox PictureBox1
	;
	public Performance()
	{
		base.Load += Performance_Load;
		base.FormClosing += Performance_FormClosing;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.Performance));
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.Timer2 = new System.Windows.Forms.Timer(this.components);
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label5 = new System.Windows.Forms.Label();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.Label8 = new System.Windows.Forms.Label();
		this.Label9 = new System.Windows.Forms.Label();
		this.Panel3 = new System.Windows.Forms.Panel();
		this.Label10 = new System.Windows.Forms.Label();
		this.Panel4 = new System.Windows.Forms.Panel();
		this.Label11 = new System.Windows.Forms.Label();
		this.Label12 = new System.Windows.Forms.Label();
		this.Panel5 = new System.Windows.Forms.Panel();
		this.Guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
		this.Guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.Guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
		this.Guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
		this.Guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
		this.Guna2CircleProgressBar2 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
		this.Label13 = new System.Windows.Forms.Label();
		this.Label14 = new System.Windows.Forms.Label();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.Panel5.SuspendLayout();
		this.Guna2Panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		base.SuspendLayout();
		this.Timer1.Tick += new EventHandler(Timer1_Tick);
		this.Timer2.Tick += new EventHandler(Timer2_Tick);
		this.Guna2GradientButton1.Click += new EventHandler(Guna2GradientButton1_Click);
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.ForeColor = System.Drawing.Color.Black;
		this.Label1.Location = new System.Drawing.Point(20, 53);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(34, 13);
		this.Label1.TabIndex = 4;
		this.Label1.Text = "CPU :";
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.ForeColor = System.Drawing.Color.Black;
		this.Label2.Location = new System.Drawing.Point(137, 103);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(36, 13);
		this.Label2.TabIndex = 5;
		this.Label2.Text = "RAM :";
		this.Timer1.Enabled = true;
		this.Timer1.Interval = 1000;
		this.Timer2.Interval = 2000;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.ForeColor = System.Drawing.Color.Black;
		this.Label4.Location = new System.Drawing.Point(179, 102);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(15, 13);
		this.Label4.TabIndex = 9;
		this.Label4.Text = "..";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.ForeColor = System.Drawing.Color.Black;
		this.Label3.Location = new System.Drawing.Point(60, 53);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(15, 13);
		this.Label3.TabIndex = 8;
		this.Label3.Text = "..";
		this.Label5.AutoSize = true;
		this.Label5.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label5.ForeColor = System.Drawing.Color.Black;
		this.Label5.Location = new System.Drawing.Point(300, 120);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(44, 13);
		this.Label5.TabIndex = 14;
		this.Label5.Text = "Speed :";
		this.Panel1.BackColor = System.Drawing.Color.FromArgb(139, 201, 77);
		this.Panel1.Location = new System.Drawing.Point(282, 169);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(10, 10);
		this.Panel1.TabIndex = 15;
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.ForeColor = System.Drawing.Color.Black;
		this.Label6.Location = new System.Drawing.Point(350, 120);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(15, 13);
		this.Label6.TabIndex = 16;
		this.Label6.Text = "..";
		this.Label7.AutoSize = true;
		this.Label7.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label7.ForeColor = System.Drawing.Color.Black;
		this.Label7.Location = new System.Drawing.Point(350, 169);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(15, 13);
		this.Label7.TabIndex = 19;
		this.Label7.Text = "..";
		this.Panel2.BackColor = System.Drawing.Color.FromArgb(139, 201, 77);
		this.Panel2.Location = new System.Drawing.Point(282, 145);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(10, 10);
		this.Panel2.TabIndex = 18;
		this.Label8.AutoSize = true;
		this.Label8.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label8.ForeColor = System.Drawing.Color.Black;
		this.Label8.Location = new System.Drawing.Point(302, 145);
		this.Label8.Name = "Label8";
		this.Label8.Size = new System.Drawing.Size(42, 13);
		this.Label8.TabIndex = 17;
		this.Label8.Text = "Cores :";
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.ForeColor = System.Drawing.Color.Black;
		this.Label9.Location = new System.Drawing.Point(350, 145);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(15, 13);
		this.Label9.TabIndex = 22;
		this.Label9.Text = "..";
		this.Panel3.BackColor = System.Drawing.Color.FromArgb(139, 201, 77);
		this.Panel3.Location = new System.Drawing.Point(282, 120);
		this.Panel3.Name = "Panel3";
		this.Panel3.Size = new System.Drawing.Size(10, 10);
		this.Panel3.TabIndex = 21;
		this.Label10.AutoSize = true;
		this.Label10.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label10.ForeColor = System.Drawing.Color.Black;
		this.Label10.Location = new System.Drawing.Point(298, 169);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(46, 13);
		this.Label10.TabIndex = 20;
		this.Label10.Text = "Logical :";
		this.Panel4.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
		this.Panel4.Location = new System.Drawing.Point(282, 206);
		this.Panel4.Name = "Panel4";
		this.Panel4.Size = new System.Drawing.Size(10, 10);
		this.Panel4.TabIndex = 23;
		this.Label11.AutoSize = true;
		this.Label11.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label11.ForeColor = System.Drawing.Color.Black;
		this.Label11.Location = new System.Drawing.Point(300, 206);
		this.Label11.Name = "Label11";
		this.Label11.Size = new System.Drawing.Size(44, 13);
		this.Label11.TabIndex = 24;
		this.Label11.Text = "Speed :";
		this.Label12.AutoSize = true;
		this.Label12.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label12.ForeColor = System.Drawing.Color.Black;
		this.Label12.Location = new System.Drawing.Point(350, 206);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(15, 13);
		this.Label12.TabIndex = 25;
		this.Label12.Text = "..";
		this.Panel5.Controls.Add(this.Guna2Panel1);
		this.Panel5.Controls.Add(this.Guna2Panel3);
		this.Panel5.Controls.Add(this.Guna2Panel2);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel5.Location = new System.Drawing.Point(0, 0);
		this.Panel5.Name = "Panel5";
		this.Panel5.Size = new System.Drawing.Size(452, 38);
		this.Panel5.TabIndex = 30;
		this.Guna2Panel1.Controls.Add(this.Guna2GradientButton1);
		this.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Guna2Panel1.Location = new System.Drawing.Point(68, 0);
		this.Guna2Panel1.Name = "Guna2Panel1";
		this.Guna2Panel1.Size = new System.Drawing.Size(316, 21);
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
		this.Guna2GradientButton1.Image = XWorm_Resources.Play;
		this.Guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
		this.Guna2GradientButton1.ImageSize = new System.Drawing.Size(15, 15);
		this.Guna2GradientButton1.Location = new System.Drawing.Point(0, 0);
		this.Guna2GradientButton1.Name = "Guna2GradientButton1";
		this.Guna2GradientButton1.Size = new System.Drawing.Size(316, 21);
		this.Guna2GradientButton1.TabIndex = 34;
		this.Guna2GradientButton1.Text = "Start";
		this.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left;
		this.Guna2Panel3.Location = new System.Drawing.Point(0, 0);
		this.Guna2Panel3.Name = "Guna2Panel3";
		this.Guna2Panel3.Size = new System.Drawing.Size(68, 38);
		this.Guna2Panel3.TabIndex = 37;
		this.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
		this.Guna2Panel2.Location = new System.Drawing.Point(384, 0);
		this.Guna2Panel2.Name = "Guna2Panel2";
		this.Guna2Panel2.Size = new System.Drawing.Size(68, 38);
		this.Guna2Panel2.TabIndex = 36;
		this.Guna2CircleProgressBar1.BackColor = System.Drawing.Color.Transparent;
		this.Guna2CircleProgressBar1.FillColor = System.Drawing.Color.FromArgb(200, 213, 218, 223);
		this.Guna2CircleProgressBar1.FillThickness = 7;
		this.Guna2CircleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Guna2CircleProgressBar1.ForeColor = System.Drawing.Color.Black;
		this.Guna2CircleProgressBar1.Location = new System.Drawing.Point(23, 72);
		this.Guna2CircleProgressBar1.Minimum = 0;
		this.Guna2CircleProgressBar1.Name = "Guna2CircleProgressBar1";
		this.Guna2CircleProgressBar1.ProgressThickness = 7;
		this.Guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
		this.Guna2CircleProgressBar1.ShowText = true;
		this.Guna2CircleProgressBar1.Size = new System.Drawing.Size(67, 67);
		this.Guna2CircleProgressBar1.TabIndex = 31;
		this.Guna2CircleProgressBar2.BackColor = System.Drawing.Color.Transparent;
		this.Guna2CircleProgressBar2.FillColor = System.Drawing.Color.FromArgb(200, 213, 218, 223);
		this.Guna2CircleProgressBar2.FillThickness = 7;
		this.Guna2CircleProgressBar2.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Guna2CircleProgressBar2.ForeColor = System.Drawing.Color.Black;
		this.Guna2CircleProgressBar2.Location = new System.Drawing.Point(140, 120);
		this.Guna2CircleProgressBar2.Minimum = 0;
		this.Guna2CircleProgressBar2.Name = "Guna2CircleProgressBar2";
		this.Guna2CircleProgressBar2.ProgressColor = System.Drawing.Color.FromArgb(255, 128, 0);
		this.Guna2CircleProgressBar2.ProgressColor2 = System.Drawing.Color.FromArgb(255, 128, 0);
		this.Guna2CircleProgressBar2.ProgressThickness = 7;
		this.Guna2CircleProgressBar2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
		this.Guna2CircleProgressBar2.ShowText = true;
		this.Guna2CircleProgressBar2.Size = new System.Drawing.Size(67, 67);
		this.Guna2CircleProgressBar2.TabIndex = 32;
		this.Label13.AutoSize = true;
		this.Label13.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label13.ForeColor = System.Drawing.Color.Black;
		this.Label13.Location = new System.Drawing.Point(150, 225);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(15, 13);
		this.Label13.TabIndex = 34;
		this.Label13.Text = "..";
		this.Label14.AutoSize = true;
		this.Label14.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label14.ForeColor = System.Drawing.Color.Black;
		this.Label14.Location = new System.Drawing.Point(60, 225);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(84, 13);
		this.Label14.TabIndex = 33;
		this.Label14.Text = "SystemUpTime :";
		this.PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
		this.PictureBox1.Location = new System.Drawing.Point(23, 216);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(30, 29);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox1.TabIndex = 35;
		this.PictureBox1.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(452, 266);
		base.Controls.Add(this.PictureBox1);
		base.Controls.Add(this.Label13);
		base.Controls.Add(this.Label14);
		base.Controls.Add(this.Guna2CircleProgressBar2);
		base.Controls.Add(this.Guna2CircleProgressBar1);
		base.Controls.Add(this.Panel5);
		base.Controls.Add(this.Label12);
		base.Controls.Add(this.Label11);
		base.Controls.Add(this.Panel4);
		base.Controls.Add(this.Label9);
		base.Controls.Add(this.Panel3);
		base.Controls.Add(this.Label10);
		base.Controls.Add(this.Label7);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.Label8);
		base.Controls.Add(this.Label6);
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.Label5);
		base.Controls.Add(this.Label4);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Performance";
		this.Text = "Performance";
		this.Panel5.ResumeLayout(false);
		this.Guna2Panel1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Performance_Load(object sender, EventArgs e)
	{
		Guna2GradientButton1.PerformClick();
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

	private void Performance_FormClosing(object sender, FormClosingEventArgs e)
	{
		byte[] array = Module0.smethod_6("ClosePerformance");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		byte[] array = Module0.smethod_6("GetPerformance");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void Guna2GradientButton1_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Guna2GradientButton1.Text, "Start", TextCompare: false) == 0)
		{
			Timer2.Enabled = true;
			Timer2.Start();
			Guna2GradientButton1.Text = "Stop";
			Guna2GradientButton1.Image = XWorm_Resources._Stop;
			return;
		}
		try
		{
			Timer2.Dispose();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Guna2GradientButton1.Text = "Start";
		Guna2GradientButton1.Image = XWorm_Resources.Play;
	}
}