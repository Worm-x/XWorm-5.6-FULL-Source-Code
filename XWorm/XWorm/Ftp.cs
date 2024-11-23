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
public class Ftp : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2GradientButton1")]
	private Guna2GradientButton _Guna2GradientButton1;

	[field: AccessedThroughProperty("label4")]
	public Label label4
	;

	[field: AccessedThroughProperty("label3")]
	public Label label3
	;

	[field: AccessedThroughProperty("label2")]
	public Label label2
	;

	[field: AccessedThroughProperty("label1")]
	public Label label1
	;

	[field: AccessedThroughProperty("Guna2TextBox3")]
	public Guna2TextBox Guna2TextBox3
	;

	[field: AccessedThroughProperty("Guna2TextBox2")]
	public Guna2TextBox Guna2TextBox2
	;

	[field: AccessedThroughProperty("Guna2TextBox1")]
	public Guna2TextBox Guna2TextBox1
	;

	[field: AccessedThroughProperty("Guna2NumericUpDown1")]
	public Guna2NumericUpDown Guna2NumericUpDown1
	;

	public Guna2GradientButton Guna2GradientButton1
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
	// b y  @c o d e 2 r e v e r s e
	[System.Diagnostics.DebuggerStepThrough]
	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.Ftp));
		this.label4 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.Guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2NumericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
		this.Guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
		((System.ComponentModel.ISupportInitialize)this.Guna2NumericUpDown1).BeginInit();
		base.SuspendLayout();
		this.Guna2GradientButton1.Click += new EventHandler(Guna2GradientButton1_Click);
		this.label4.AutoSize = true;
		this.label4.ForeColor = System.Drawing.Color.Black;
		this.label4.Location = new System.Drawing.Point(13, 49);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(36, 13);
		this.label4.TabIndex = 37;
		this.label4.Text = "User :";
		this.label3.AutoSize = true;
		this.label3.ForeColor = System.Drawing.Color.Black;
		this.label3.Location = new System.Drawing.Point(15, 105);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(34, 13);
		this.label3.TabIndex = 36;
		this.label3.Text = "Port :";
		this.label2.AutoSize = true;
		this.label2.ForeColor = System.Drawing.Color.Black;
		this.label2.Location = new System.Drawing.Point(13, 76);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(36, 13);
		this.label2.TabIndex = 35;
		this.label2.Text = "Pass :";
		this.label1.AutoSize = true;
		this.label1.ForeColor = System.Drawing.Color.Black;
		this.label1.Location = new System.Drawing.Point(13, 22);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(36, 13);
		this.label1.TabIndex = 34;
		this.label1.Text = "Host :";
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
		this.Guna2TextBox3.Location = new System.Drawing.Point(55, 73);
		this.Guna2TextBox3.Name = "Guna2TextBox3";
		this.Guna2TextBox3.PasswordChar = '\0';
		this.Guna2TextBox3.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox3.PlaceholderText = "";
		this.Guna2TextBox3.SelectedText = "";
		this.Guna2TextBox3.Size = new System.Drawing.Size(259, 21);
		this.Guna2TextBox3.TabIndex = 59;
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
		this.Guna2TextBox2.Location = new System.Drawing.Point(55, 46);
		this.Guna2TextBox2.Name = "Guna2TextBox2";
		this.Guna2TextBox2.PasswordChar = '\0';
		this.Guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox2.PlaceholderText = "";
		this.Guna2TextBox2.SelectedText = "";
		this.Guna2TextBox2.Size = new System.Drawing.Size(259, 21);
		this.Guna2TextBox2.TabIndex = 57;
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
		this.Guna2TextBox1.Location = new System.Drawing.Point(55, 19);
		this.Guna2TextBox1.Name = "Guna2TextBox1";
		this.Guna2TextBox1.PasswordChar = '\0';
		this.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox1.PlaceholderText = "";
		this.Guna2TextBox1.SelectedText = "";
		this.Guna2TextBox1.Size = new System.Drawing.Size(259, 21);
		this.Guna2TextBox1.TabIndex = 58;
		this.Guna2NumericUpDown1.BackColor = System.Drawing.Color.Transparent;
		this.Guna2NumericUpDown1.BorderRadius = 3;
		this.Guna2NumericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2NumericUpDown1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2NumericUpDown1.Location = new System.Drawing.Point(55, 100);
		this.Guna2NumericUpDown1.Maximum = new decimal(new int[4] { 65534, 0, 0, 0 });
		this.Guna2NumericUpDown1.Name = "Guna2NumericUpDown1";
		this.Guna2NumericUpDown1.Size = new System.Drawing.Size(76, 25);
		this.Guna2NumericUpDown1.TabIndex = 74;
		this.Guna2NumericUpDown1.UpDownButtonFillColor = System.Drawing.Color.FromArgb(136, 200, 236);
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
		this.Guna2GradientButton1.ImageSize = new System.Drawing.Size(15, 15);
		this.Guna2GradientButton1.Location = new System.Drawing.Point(55, 131);
		this.Guna2GradientButton1.Name = "Guna2GradientButton1";
		this.Guna2GradientButton1.Size = new System.Drawing.Size(259, 26);
		this.Guna2GradientButton1.TabIndex = 75;
		this.Guna2GradientButton1.Text = "Save";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(333, 172);
		base.Controls.Add(this.Guna2GradientButton1);
		base.Controls.Add(this.Guna2NumericUpDown1);
		base.Controls.Add(this.Guna2TextBox3);
		base.Controls.Add(this.Guna2TextBox2);
		base.Controls.Add(this.Guna2TextBox1);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Ftp";
		base.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
		this.Text = "Ftp Settings";
		((System.ComponentModel.ISupportInitialize)this.Guna2NumericUpDown1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	public Ftp()
	{
		base.Load += Ftp_Load;
		InitializeComponent();
		base.Opacity = 0.0;
		Module0.smethod_18(this, 20);
		Guna2TextBox1.Select();
	}

	private void Ftp_Load(object sender, EventArgs e)
	{
		try
		{
			if (Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Ftphost", null), null, TextCompare: false))
			{
				Guna2TextBox1.Text = "ftp.exmple.com";
			}
			else
			{
				Guna2TextBox1.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Ftphost", null));
			}
			if (Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Ftpuser", null), null, TextCompare: false))
			{
				Guna2TextBox2.Text = "ftp-username";
			}
			else
			{
				Guna2TextBox2.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Ftpuser", null));
			}
			if (Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Ftppass", null), null, TextCompare: false))
			{
				Guna2TextBox3.Text = "ftp-password";
			}
			else
			{
				Guna2TextBox3.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Ftppass", null));
			}
			if (Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Ftpport", null), null, TextCompare: false))
			{
				Guna2NumericUpDown1.Value = 21m;
			}
			else
			{
				Guna2NumericUpDown1.Value = new decimal(Convert.ToInt32(RuntimeHelpers.GetObjectValue(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Ftpport", null))));
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
			MyProject.Computer.Registry.SetValue(GClass19.string_4, "Ftphost", Guna2TextBox1.Text);
			MyProject.Computer.Registry.SetValue(GClass19.string_4, "Ftpuser", Guna2TextBox2.Text);
			MyProject.Computer.Registry.SetValue(GClass19.string_4, "Ftppass", Guna2TextBox3.Text);
			MyProject.Computer.Registry.SetValue(GClass19.string_4, "Ftpport", Guna2NumericUpDown1.Value.ToString());
			Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}
}