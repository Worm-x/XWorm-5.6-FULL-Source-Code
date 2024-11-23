using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace XWorm;

[DesignerGenerated]
public class EditReg : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2GradientButton1")]
	private Guna2GradientButton _Guna2GradientButton1;

	public GClass5 gclass5_0;

	public string string_0;

	[field: AccessedThroughProperty("Panel1")]
	public Panel Panel1
	;

	[field: AccessedThroughProperty("Label1")]
	public Label Label1


	;
	[field: AccessedThroughProperty("Label3")]
	public Label Label3
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
	[field: AccessedThroughProperty("Guna2ComboBox1")]
	public Guna2ComboBox Guna2ComboBox1
	;

	[field: AccessedThroughProperty("Guna2TextBox1")]
	public Guna2TextBox Guna2TextBox1
	;
	[field: AccessedThroughProperty("Guna2TextBox3")]
	public Guna2TextBox Guna2TextBox3
	;

	public EditReg()
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.EditReg));
		this.Panel1 = new System.Windows.Forms.Panel();
		this.Guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.Panel5 = new System.Windows.Forms.Panel();
		this.Guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
		this.Guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.Guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
		this.Guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
		this.Guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Panel1.SuspendLayout();
		this.Panel5.SuspendLayout();
		this.Guna2Panel1.SuspendLayout();
		base.SuspendLayout();
		this.Guna2GradientButton1.Click += new System.EventHandler(Guna2GradientButton1_Click);
		this.Panel1.Controls.Add(this.Guna2TextBox1);
		this.Panel1.Controls.Add(this.Guna2ComboBox1);
		this.Panel1.Controls.Add(this.Label3);
		this.Panel1.Controls.Add(this.Label1);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel1.Location = new System.Drawing.Point(0, 32);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(359, 53);
		this.Panel1.TabIndex = 0;
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
		this.Guna2TextBox1.Location = new System.Drawing.Point(156, 26);
		this.Guna2TextBox1.Name = "Guna2TextBox1";
		this.Guna2TextBox1.PasswordChar = '\0';
		this.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox1.PlaceholderText = "";
		this.Guna2TextBox1.SelectedText = "";
		this.Guna2TextBox1.Size = new System.Drawing.Size(192, 21);
		this.Guna2TextBox1.TabIndex = 50;
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
		this.Guna2ComboBox1.Items.AddRange(new object[6] { "Binary", "DWord", "ExpandString", "MultiString", "QWord", "String" });
		this.Guna2ComboBox1.Location = new System.Drawing.Point(12, 26);
		this.Guna2ComboBox1.Name = "Guna2ComboBox1";
		this.Guna2ComboBox1.Size = new System.Drawing.Size(138, 21);
		this.Guna2ComboBox1.TabIndex = 94;
		this.Label3.AutoSize = true;
		this.Label3.ForeColor = System.Drawing.Color.Black;
		this.Label3.Location = new System.Drawing.Point(153, 10);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(43, 13);
		this.Label3.TabIndex = 31;
		this.Label3.Text = "Name _";
		this.Label1.AutoSize = true;
		this.Label1.ForeColor = System.Drawing.Color.Black;
		this.Label1.Location = new System.Drawing.Point(9, 10);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(40, 13);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "Type _";
		this.Panel5.Controls.Add(this.Guna2Panel1);
		this.Panel5.Controls.Add(this.Guna2Panel3);
		this.Panel5.Controls.Add(this.Guna2Panel2);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel5.Location = new System.Drawing.Point(0, 0);
		this.Panel5.Name = "Panel5";
		this.Panel5.Size = new System.Drawing.Size(359, 32);
		this.Panel5.TabIndex = 35;
		this.Guna2Panel1.Controls.Add(this.Guna2GradientButton1);
		this.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Guna2Panel1.Location = new System.Drawing.Point(27, 0);
		this.Guna2Panel1.Name = "Guna2Panel1";
		this.Guna2Panel1.Size = new System.Drawing.Size(305, 21);
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
		this.Guna2GradientButton1.Image = (System.Drawing.Image)resources.GetObject("Guna2GradientButton1.Image");
		this.Guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
		this.Guna2GradientButton1.ImageSize = new System.Drawing.Size(15, 15);
		this.Guna2GradientButton1.Location = new System.Drawing.Point(0, 0);
		this.Guna2GradientButton1.Name = "Guna2GradientButton1";
		this.Guna2GradientButton1.Size = new System.Drawing.Size(305, 21);
		this.Guna2GradientButton1.TabIndex = 34;
		this.Guna2GradientButton1.Text = "Save";
		this.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left;
		this.Guna2Panel3.Location = new System.Drawing.Point(0, 0);
		this.Guna2Panel3.Name = "Guna2Panel3";
		this.Guna2Panel3.Size = new System.Drawing.Size(27, 32);
		this.Guna2Panel3.TabIndex = 37;
		this.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
		this.Guna2Panel2.Location = new System.Drawing.Point(332, 0);
		this.Guna2Panel2.Name = "Guna2Panel2";
		this.Guna2Panel2.Size = new System.Drawing.Size(27, 32);
		this.Guna2Panel2.TabIndex = 36;
		this.Guna2TextBox3.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox3.BorderRadius = 3;
		this.Guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox3.DefaultText = "";
		this.Guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox3.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox3.Location = new System.Drawing.Point(0, 85);
		this.Guna2TextBox3.Multiline = true;
		this.Guna2TextBox3.Name = "Guna2TextBox3";
		this.Guna2TextBox3.PasswordChar = '\0';
		this.Guna2TextBox3.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox3.PlaceholderText = "";
		this.Guna2TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.Guna2TextBox3.SelectedText = "";
		this.Guna2TextBox3.Size = new System.Drawing.Size(359, 155);
		this.Guna2TextBox3.TabIndex = 51;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(359, 240);
		base.Controls.Add(this.Guna2TextBox3);
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.Panel5);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "EditReg";
		this.Text = "EditReg";
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		this.Panel5.ResumeLayout(false);
		this.Guna2Panel1.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	public int method_0(string t)
	{
		string left = t.ToLower();
		if (Operators.CompareString(left, RegistryValueKind.Binary.ToString().ToLower(), TextCompare: false) == 0)
		{
			return 3;
		}
		if (Operators.CompareString(left, RegistryValueKind.DWord.ToString().ToLower(), TextCompare: false) == 0)
		{
			return 4;
		}
		if (Operators.CompareString(left, RegistryValueKind.ExpandString.ToString().ToLower(), TextCompare: false) == 0)
		{
			return 2;
		}
		if (Operators.CompareString(left, RegistryValueKind.MultiString.ToString().ToLower(), TextCompare: false) == 0)
		{
			return 7;
		}
		if (Operators.CompareString(left, RegistryValueKind.QWord.ToString().ToLower(), TextCompare: false) == 0)
		{
			return 11;
		}
		if (Operators.CompareString(left, RegistryValueKind.String.ToString().ToLower(), TextCompare: false) == 0)
		{
			return 1;
		}
		int result = default(int);
		return result;
	}

	private void Guna2GradientButton1_Click(object sender, EventArgs e)
	{
		byte[] array = Module0.smethod_6("RG" + GClass19.string_0 + "!" + GClass19.string_0 + string_0 + GClass19.string_0 + Guna2TextBox1.Text + GClass19.string_0 + Guna2TextBox3.Text + GClass19.string_0 + Conversions.ToString(method_0(Guna2ComboBox1.Text)));
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
		Close();
	}
}