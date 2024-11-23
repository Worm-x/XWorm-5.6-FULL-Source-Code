#define DEBUG
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm;

[DesignerGenerated]
public class Chat : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private System.Windows.Forms.Timer _Timer1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2TextBox1")]
	private Guna2TextBox _Guna2TextBox1;

	public GClass5 gclass5_0;

	public bool bool_0;

	public string string_0;

	public System.Windows.Forms.Timer Timer1
	;

	[field: AccessedThroughProperty("Guna2TextBox2")]
	public Guna2TextBox Guna2TextBox2
	;

	public Guna2TextBox Guna2TextBox1
	;

	public Chat()
	{
		base.Load += Chat_Load;
		base.FormClosing += Chat_FormClosing;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.Chat));
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.Guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
		base.SuspendLayout();
		this.Timer1.Tick += new System.EventHandler(Timer1_Tick);
		this.Guna2TextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(Guna2TextBox1_KeyDown);
		this.Timer1.Interval = 1000;
		this.Guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox2.DefaultText = "";
		this.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox2.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox2.Location = new System.Drawing.Point(0, 0);
		this.Guna2TextBox2.Multiline = true;
		this.Guna2TextBox2.Name = "Guna2TextBox2";
		this.Guna2TextBox2.PasswordChar = '\0';
		this.Guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox2.PlaceholderText = "";
		this.Guna2TextBox2.ReadOnly = true;
		this.Guna2TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.Guna2TextBox2.SelectedText = "";
		this.Guna2TextBox2.Size = new System.Drawing.Size(460, 268);
		this.Guna2TextBox2.TabIndex = 53;
		this.Guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox1.DefaultText = "";
		this.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox1.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox1.Location = new System.Drawing.Point(0, 268);
		this.Guna2TextBox1.Name = "Guna2TextBox1";
		this.Guna2TextBox1.PasswordChar = '\0';
		this.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox1.PlaceholderText = "";
		this.Guna2TextBox1.SelectedText = "";
		this.Guna2TextBox1.Size = new System.Drawing.Size(460, 21);
		this.Guna2TextBox1.TabIndex = 52;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(460, 289);
		base.Controls.Add(this.Guna2TextBox2);
		base.Controls.Add(this.Guna2TextBox1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Chat";
		this.Text = "Chat";
		base.ResumeLayout(false);
	}

	private void Chat_Load(object sender, EventArgs e)
	{
		string value = Interaction.InputBox("NICKNAME", "CLIENT CHAT", "Admin");
		if (string.IsNullOrEmpty(value))
		{
			Close();
			return;
		}
		string_0 = value;
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Chat.dll"));
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

	private void Chat_FormClosing(object sender, FormClosingEventArgs e)
	{
		byte[] array = Module0.smethod_6("ENDChat");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
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

	private void Guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
	{
		if (bool_0 && e.KeyData == Keys.Return && !string.IsNullOrWhiteSpace(Guna2TextBox1.Text))
		{
			e.SuppressKeyPress = true;
			Guna2TextBox guna2TextBox = Guna2TextBox2;
			guna2TextBox.Text = guna2TextBox.Text + "ME: " + Guna2TextBox1.Text + Environment.NewLine;
			byte[] array = Module0.smethod_6("GETChat" + GClass19.string_0 + string_0 + ": " + Guna2TextBox1.Text);
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
			Guna2TextBox2.SelectionStart = Guna2TextBox2.Text.Length;
			Guna2TextBox2.ScrollToCaret();
			Guna2TextBox2.Refresh();
			Guna2TextBox1.Clear();
		}
	}
}
