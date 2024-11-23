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
public class Hosts : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private System.Windows.Forms.Timer _Timer1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem1")]
	private ToolStripMenuItem _ToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2TextBox1")]
	private Guna2TextBox _Guna2TextBox1;

	public GClass5 gclass5_0;

	[field: AccessedThroughProperty("StatusStrip1")]
	public StatusStrip StatusStrip1
	;

	[field: AccessedThroughProperty("ToolStripStatusLabel1")]
	public ToolStripStatusLabel ToolStripStatusLabel1
;

	public System.Windows.Forms.Timer Timer1
	;

	public ToolStripMenuItem ToolStripMenuItem1
	;

	[field: AccessedThroughProperty("MenuStrip1")]
	public MenuStrip MenuStrip1
	;
	public Guna2TextBox Guna2TextBox1
	;

	[field: AccessedThroughProperty("Guna2TextBox2")]
	public Guna2TextBox Guna2TextBox2
	;

	public Hosts()
	{
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.Hosts));
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
		this.Guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
		this.StatusStrip1.SuspendLayout();
		this.MenuStrip1.SuspendLayout();
		base.SuspendLayout();
		this.Timer1.Tick += new System.EventHandler(Timer1_Tick);
		this.ToolStripMenuItem1.Click += new System.EventHandler(ToolStripMenuItem1_Click);
		this.Guna2TextBox1.TextChanged += new System.EventHandler(Guna2TextBox1_TextChanged);
		this.StatusStrip1.BackColor = System.Drawing.Color.White;
		this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.ToolStripStatusLabel1 });
		this.StatusStrip1.Location = new System.Drawing.Point(0, 276);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
		this.StatusStrip1.Size = new System.Drawing.Size(480, 22);
		this.StatusStrip1.TabIndex = 9;
		this.StatusStrip1.Text = "StatusStrip1";
		this.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
		this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
		this.ToolStripStatusLabel1.Size = new System.Drawing.Size(13, 17);
		this.ToolStripStatusLabel1.Text = "..";
		this.Timer1.Enabled = true;
		this.Timer1.Interval = 1000;
		this.ToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
		this.ToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem1.Image");
		this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
		this.ToolStripMenuItem1.Size = new System.Drawing.Size(108, 20);
		this.ToolStripMenuItem1.Text = "Save Changes";
		this.MenuStrip1.BackColor = System.Drawing.Color.White;
		this.MenuStrip1.Font = new System.Drawing.Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.ToolStripMenuItem1 });
		this.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
		this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
		this.MenuStrip1.Name = "MenuStrip1";
		this.MenuStrip1.Size = new System.Drawing.Size(480, 24);
		this.MenuStrip1.TabIndex = 5;
		this.MenuStrip1.Text = "MenuStrip1";
		this.Guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox1.DefaultText = "";
		this.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox1.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox1.Location = new System.Drawing.Point(0, 24);
		this.Guna2TextBox1.Multiline = true;
		this.Guna2TextBox1.Name = "Guna2TextBox1";
		this.Guna2TextBox1.PasswordChar = '\0';
		this.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox1.PlaceholderText = "";
		this.Guna2TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.Guna2TextBox1.SelectedText = "";
		this.Guna2TextBox1.Size = new System.Drawing.Size(480, 231);
		this.Guna2TextBox1.TabIndex = 51;
		this.Guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox2.DefaultText = "";
		this.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox2.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox2.Location = new System.Drawing.Point(0, 255);
		this.Guna2TextBox2.Name = "Guna2TextBox2";
		this.Guna2TextBox2.PasswordChar = '\0';
		this.Guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox2.PlaceholderText = "";
		this.Guna2TextBox2.ReadOnly = true;
		this.Guna2TextBox2.SelectedText = "";
		this.Guna2TextBox2.Size = new System.Drawing.Size(480, 21);
		this.Guna2TextBox2.TabIndex = 52;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(480, 298);
		base.Controls.Add(this.Guna2TextBox1);
		base.Controls.Add(this.Guna2TextBox2);
		base.Controls.Add(this.StatusStrip1);
		base.Controls.Add(this.MenuStrip1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Hosts";
		this.Text = "Edit Hosts";
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		this.MenuStrip1.ResumeLayout(false);
		this.MenuStrip1.PerformLayout();
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

	private void ToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		byte[] array = Module0.smethod_6("Shosts" + GClass19.string_0 + Guna2TextBox2.Text + GClass19.string_0 + Guna2TextBox1.Text);
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
		ToolStripMenuItem1.Enabled = false;
	}

	private void Guna2TextBox1_TextChanged(object sender, EventArgs e)
	{
		ToolStripMenuItem1.Enabled = true;
	}
}