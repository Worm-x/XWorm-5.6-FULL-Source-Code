#define DEBUG
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;


namespace XWorm;

[DesignerGenerated]
public class FilesSearcher : Form
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__R74_002D0
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R74_002D0(_Closure_0024__R74_002D0 arg0)
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
	[AccessedThroughProperty("Timer1")]
	private System.Windows.Forms.Timer _Timer1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2GradientButton1")]
	private Guna2GradientButton _Guna2GradientButton1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem7")]
	private ToolStripMenuItem _ToolStripMenuItem7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("AddToolStripMenuItem1")]
	private ToolStripMenuItem _AddToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RemoveToolStripMenuItem1")]
	private ToolStripMenuItem _RemoveToolStripMenuItem1;

	public GClass5 gclass5_0;
	[field: AccessedThroughProperty("ListBox1")]
	public ListBox ListBox1
	;


	[field: AccessedThroughProperty("Panel1")]
	public Panel Panel1
	;

	[field: AccessedThroughProperty("Label2")]
	public Label Label2
	;

	[field: AccessedThroughProperty("Label1")]
	public Label Label1
	;

	[field: AccessedThroughProperty("ToolStripStatusLabel1")]
	public ToolStripStatusLabel ToolStripStatusLabel1
	;

	[field: AccessedThroughProperty("StatusStrip1")]
	public StatusStrip StatusStrip1
	;

	public System.Windows.Forms.Timer Timer1
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

	[field: AccessedThroughProperty("Guna2NumericUpDown1")]
	public Guna2NumericUpDown Guna2NumericUpDown1
	;

	[field: AccessedThroughProperty("Guna2ContextMenuStrip2")]
	public Guna2ContextMenuStrip Guna2ContextMenuStrip2
	;

	public ToolStripMenuItem ToolStripMenuItem7
	;


	public ToolStripMenuItem AddToolStripMenuItem1
	;

	public ToolStripMenuItem RemoveToolStripMenuItem1
	;

	public FilesSearcher()
	{
		base.FormClosing += FilesSearcher_FormClosing;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.FilesSearcher));
		this.ListBox1 = new System.Windows.Forms.ListBox();
		this.Guna2ContextMenuStrip2 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
		this.AddToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.RemoveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
		this.Panel1 = new System.Windows.Forms.Panel();
		this.Guna2NumericUpDown1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
		this.Label2 = new System.Windows.Forms.Label();
		this.Label1 = new System.Windows.Forms.Label();
		this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.Panel5 = new System.Windows.Forms.Panel();
		this.Guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
		this.Guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.Guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
		this.Guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
		this.Guna2ContextMenuStrip2.SuspendLayout();
		this.Panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.Guna2NumericUpDown1).BeginInit();
		this.StatusStrip1.SuspendLayout();
		this.Panel5.SuspendLayout();
		this.Guna2Panel1.SuspendLayout();
		base.SuspendLayout();
		this.Timer1.Tick += new System.EventHandler(Timer1_Tick);
		this.Guna2GradientButton1.Click += new System.EventHandler(Guna2GradientButton1_Click);
		this.ToolStripMenuItem7.Click += new System.EventHandler(ToolStripMenuItem7_Click);
		this.AddToolStripMenuItem1.Click += new System.EventHandler(AddToolStripMenuItem1_Click);
		this.RemoveToolStripMenuItem1.Click += new System.EventHandler(RemoveToolStripMenuItem1_Click);
		this.ListBox1.BackColor = System.Drawing.Color.White;
		this.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.ListBox1.ContextMenuStrip = this.Guna2ContextMenuStrip2;
		this.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ListBox1.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ListBox1.ForeColor = System.Drawing.Color.Black;
		this.ListBox1.FormattingEnabled = true;
		this.ListBox1.ItemHeight = 14;
		this.ListBox1.Items.AddRange(new object[3] { ".txt", ".pdf", ".doc" });
		this.ListBox1.Location = new System.Drawing.Point(0, 32);
		this.ListBox1.Name = "ListBox1";
		this.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
		this.ListBox1.Size = new System.Drawing.Size(400, 149);
		this.ListBox1.TabIndex = 0;
		this.Guna2ContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.AddToolStripMenuItem1, this.RemoveToolStripMenuItem1, this.ToolStripMenuItem7 });
		this.Guna2ContextMenuStrip2.Name = "Guna2ContextMenuStrip2";
		this.Guna2ContextMenuStrip2.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(151, 143, 255);
		this.Guna2ContextMenuStrip2.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
		this.Guna2ContextMenuStrip2.RenderStyle.ColorTable = null;
		this.Guna2ContextMenuStrip2.RenderStyle.RoundedEdges = true;
		this.Guna2ContextMenuStrip2.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
		this.Guna2ContextMenuStrip2.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(113, 74, 250);
		this.Guna2ContextMenuStrip2.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
		this.Guna2ContextMenuStrip2.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
		this.Guna2ContextMenuStrip2.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
		this.Guna2ContextMenuStrip2.Size = new System.Drawing.Size(132, 70);
		this.AddToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.AddToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("AddToolStripMenuItem1.Image");
		this.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1";
		this.AddToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
		this.AddToolStripMenuItem1.Text = "[ Add ]";
		this.RemoveToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.RemoveToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("RemoveToolStripMenuItem1.Image");
		this.RemoveToolStripMenuItem1.Name = "RemoveToolStripMenuItem1";
		this.RemoveToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
		this.RemoveToolStripMenuItem1.Text = "[ Remove ]";
		this.ToolStripMenuItem7.BackColor = System.Drawing.Color.White;
		this.ToolStripMenuItem7.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem7.Image");
		this.ToolStripMenuItem7.Name = "ToolStripMenuItem7";
		this.ToolStripMenuItem7.Size = new System.Drawing.Size(131, 22);
		this.ToolStripMenuItem7.Text = "[ Clear ]";
		this.Panel1.Controls.Add(this.Label2);
		this.Panel1.Controls.Add(this.Guna2NumericUpDown1);
		this.Panel1.Controls.Add(this.Label1);
		this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Panel1.Location = new System.Drawing.Point(0, 181);
		this.Panel1.Name = "Panel1";
		this.Panel1.Size = new System.Drawing.Size(400, 36);
		this.Panel1.TabIndex = 8;
		this.Guna2NumericUpDown1.BackColor = System.Drawing.Color.Transparent;
		this.Guna2NumericUpDown1.BorderRadius = 3;
		this.Guna2NumericUpDown1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2NumericUpDown1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2NumericUpDown1.Location = new System.Drawing.Point(76, 6);
		this.Guna2NumericUpDown1.Name = "Guna2NumericUpDown1";
		this.Guna2NumericUpDown1.Size = new System.Drawing.Size(80, 24);
		this.Guna2NumericUpDown1.TabIndex = 74;
		this.Guna2NumericUpDown1.UpDownButtonFillColor = System.Drawing.Color.FromArgb(136, 200, 236);
		this.Guna2NumericUpDown1.Value = new decimal(new int[4] { 3, 0, 0, 0 });
		this.Label2.AutoSize = true;
		this.Label2.ForeColor = System.Drawing.Color.Black;
		this.Label2.Location = new System.Drawing.Point(162, 12);
		this.Label2.Name = "Label2";
		this.Label2.Size = new System.Drawing.Size(21, 13);
		this.Label2.TabIndex = 2;
		this.Label2.Text = "MB";
		this.Label1.AutoSize = true;
		this.Label1.ForeColor = System.Drawing.Color.Black;
		this.Label1.Location = new System.Drawing.Point(18, 11);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(56, 13);
		this.Label1.TabIndex = 0;
		this.Label1.Text = "MaxSize : ";
		this.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
		this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
		this.ToolStripStatusLabel1.Size = new System.Drawing.Size(13, 17);
		this.ToolStripStatusLabel1.Text = "..";
		this.StatusStrip1.BackColor = System.Drawing.Color.White;
		this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.ToolStripStatusLabel1 });
		this.StatusStrip1.Location = new System.Drawing.Point(0, 217);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
		this.StatusStrip1.Size = new System.Drawing.Size(400, 22);
		this.StatusStrip1.TabIndex = 7;
		this.StatusStrip1.Text = "StatusStrip1";
		this.Timer1.Enabled = true;
		this.Timer1.Interval = 1000;
		this.Panel5.Controls.Add(this.Guna2Panel1);
		this.Panel5.Controls.Add(this.Guna2Panel3);
		this.Panel5.Controls.Add(this.Guna2Panel2);
		this.Panel5.Dock = System.Windows.Forms.DockStyle.Top;
		this.Panel5.Location = new System.Drawing.Point(0, 0);
		this.Panel5.Name = "Panel5";
		this.Panel5.Size = new System.Drawing.Size(400, 32);
		this.Panel5.TabIndex = 31;
		this.Guna2Panel1.Controls.Add(this.Guna2GradientButton1);
		this.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Guna2Panel1.Location = new System.Drawing.Point(33, 0);
		this.Guna2Panel1.Name = "Guna2Panel1";
		this.Guna2Panel1.Size = new System.Drawing.Size(334, 21);
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
		this.Guna2GradientButton1.Image = XWorm_Resources.Play;
		this.Guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
		this.Guna2GradientButton1.ImageSize = new System.Drawing.Size(15, 15);
		this.Guna2GradientButton1.Location = new System.Drawing.Point(0, 0);
		this.Guna2GradientButton1.Name = "Guna2GradientButton1";
		this.Guna2GradientButton1.Size = new System.Drawing.Size(334, 21);
		this.Guna2GradientButton1.TabIndex = 34;
		this.Guna2GradientButton1.Text = "Run";
		this.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left;
		this.Guna2Panel3.Location = new System.Drawing.Point(0, 0);
		this.Guna2Panel3.Name = "Guna2Panel3";
		this.Guna2Panel3.Size = new System.Drawing.Size(33, 32);
		this.Guna2Panel3.TabIndex = 37;
		this.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
		this.Guna2Panel2.Location = new System.Drawing.Point(367, 0);
		this.Guna2Panel2.Name = "Guna2Panel2";
		this.Guna2Panel2.Size = new System.Drawing.Size(33, 32);
		this.Guna2Panel2.TabIndex = 36;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(400, 239);
		base.Controls.Add(this.ListBox1);
		base.Controls.Add(this.Panel5);
		base.Controls.Add(this.Panel1);
		base.Controls.Add(this.StatusStrip1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "FilesSearcher";
		this.Text = "Files Searcher";
		this.Guna2ContextMenuStrip2.ResumeLayout(false);
		this.Panel1.ResumeLayout(false);
		this.Panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.Guna2NumericUpDown1).EndInit();
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		this.Panel5.ResumeLayout(false);
		this.Guna2Panel1.ResumeLayout(false);
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

	private void Guna2GradientButton1_Click(object sender, EventArgs e)
	{
		if (!((ListBox1.Items.Count > 0) & (Guna2NumericUpDown1.Text.Length > 0)))
		{
			return;
		}
		Guna2GradientButton1.Enabled = false;
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Clear();
		foreach (object item in ListBox1.Items)
		{
			string text = Conversions.ToString(item);
			stringBuilder.Append("-=>" + text);
		}
		byte[] array = Module0.smethod_6("StartFilesSearcher" + GClass19.string_0 + Guna2NumericUpDown1.Value + "000000" + GClass19.string_0 + stringBuilder.ToString());
		_Closure_0024__R74_002D0 arg = default(_Closure_0024__R74_002D0);
		_Closure_0024__R74_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__R74_002D0(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2 = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2.method_1((byte[])a0);
		}, array);
	}

	private void ToolStripMenuItem7_Click(object sender, EventArgs e)
	{
		ListBox1.Items.Clear();
	}

	private void AddToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		string defaultResponse = ".jpg";
		string text = Interaction.InputBox("Add Extension", "Files Searcher", defaultResponse);
		if (text.Length != 0 && !ListBox1.Items.Contains(text))
		{
			ListBox1.Items.Add(text);
		}
	}

	private void RemoveToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			while (ListBox1.SelectedItems.Count > 0)
			{
				ListBox1.Items.Remove(RuntimeHelpers.GetObjectValue(ListBox1.SelectedItem));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void FilesSearcher_FormClosing(object sender, FormClosingEventArgs e)
	{
		byte[] array = Module0.smethod_6("CloseFilesSearcher");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}
}