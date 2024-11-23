#define DEBUG
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm;

[DesignerGenerated]
public class Clipboard : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox _RichTextBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private System.Windows.Forms.Timer _Timer1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("GetTextToolStripMenuItem")]
	private ToolStripMenuItem _GetTextToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SetTextToolStripMenuItem")]
	private ToolStripMenuItem _SetTextToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CopyToolStripMenuItem1")]
	private ToolStripMenuItem _CopyToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem7")]
	private ToolStripMenuItem _ToolStripMenuItem7;

	public GClass5 gclass5_0;

	public RichTextBox RichTextBox1;

	public System.Windows.Forms.Timer Timer1
	;


	[field: AccessedThroughProperty("Guna2ContextMenuStrip2")]
	public Guna2ContextMenuStrip Guna2ContextMenuStrip2
;

	public ToolStripMenuItem GetTextToolStripMenuItem
	;

	public ToolStripMenuItem SetTextToolStripMenuItem
	;

	public ToolStripMenuItem CopyToolStripMenuItem1
;

	public ToolStripMenuItem ToolStripMenuItem7
	;

	public Clipboard()
	{
		base.Load += Clipboard_Load;
		base.FormClosing += Clipboard_FormClosing;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.Clipboard));
		this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
		this.Guna2ContextMenuStrip2 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
		this.GetTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.SetTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.CopyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.Guna2ContextMenuStrip2.SuspendLayout();
		base.SuspendLayout();
		this.ToolStripMenuItem7.Click += new System.EventHandler(ToolStripMenuItem7_Click);
		this.CopyToolStripMenuItem1.Click += new System.EventHandler(CopyToolStripMenuItem1_Click);
		this.SetTextToolStripMenuItem.Click += new System.EventHandler(SetTextToolStripMenuItem_Click);
		this.GetTextToolStripMenuItem.Click += new System.EventHandler(GetTextToolStripMenuItem_Click);
		this.Timer1.Tick += new System.EventHandler(Timer1_Tick);
		this.RichTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(RichTextBox1_LinkClicked);
		this.RichTextBox1.BackColor = System.Drawing.Color.White;
		this.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.RichTextBox1.ContextMenuStrip = this.Guna2ContextMenuStrip2;
		this.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.RichTextBox1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.RichTextBox1.ForeColor = System.Drawing.Color.Black;
		this.RichTextBox1.Location = new System.Drawing.Point(0, 0);
		this.RichTextBox1.Name = "RichTextBox1";
		this.RichTextBox1.Size = new System.Drawing.Size(412, 256);
		this.RichTextBox1.TabIndex = 1;
		this.RichTextBox1.Text = "";
		this.Guna2ContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.GetTextToolStripMenuItem, this.SetTextToolStripMenuItem, this.CopyToolStripMenuItem1, this.ToolStripMenuItem7 });
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
		this.Guna2ContextMenuStrip2.Size = new System.Drawing.Size(181, 114);
		this.GetTextToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.GetTextToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("GetTextToolStripMenuItem.Image");
		this.GetTextToolStripMenuItem.Name = "GetTextToolStripMenuItem";
		this.GetTextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		this.GetTextToolStripMenuItem.Text = "[ Get Text ]";
		this.SetTextToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.SetTextToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("SetTextToolStripMenuItem.Image");
		this.SetTextToolStripMenuItem.Name = "SetTextToolStripMenuItem";
		this.SetTextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		this.SetTextToolStripMenuItem.Text = "[ Set Text ]";
		this.CopyToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.CopyToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("CopyToolStripMenuItem1.Image");
		this.CopyToolStripMenuItem1.Name = "CopyToolStripMenuItem1";
		this.CopyToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
		this.CopyToolStripMenuItem1.Text = "[ Copy ]";
		this.ToolStripMenuItem7.BackColor = System.Drawing.Color.White;
		this.ToolStripMenuItem7.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem7.Image");
		this.ToolStripMenuItem7.Name = "ToolStripMenuItem7";
		this.ToolStripMenuItem7.Size = new System.Drawing.Size(180, 22);
		this.ToolStripMenuItem7.Text = "[ Clear ]";
		this.Timer1.Enabled = true;
		this.Timer1.Interval = 1000;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(412, 256);
		base.Controls.Add(this.RichTextBox1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Clipboard";
		this.Text = "Clipboard";
		this.Guna2ContextMenuStrip2.ResumeLayout(false);
		base.ResumeLayout(false);
	}

	private void Clipboard_Load(object sender, EventArgs e)
	{
		method_0();
	}

	public void method_0()
	{
		byte[] array = Module0.smethod_6("GetClipboard");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
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

	private void RichTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
	{
		try
		{
			Process.Start(e.LinkText);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Clipboard_FormClosing(object sender, FormClosingEventArgs e)
	{
		byte[] array = Module0.smethod_6("CloseClipboard");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void GetTextToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_0();
	}

	private void SetTextToolStripMenuItem_Click(object sender, EventArgs e)
	{
		byte[] array = Module0.smethod_6("SetClipboard" + GClass19.string_0 + RichTextBox1.Text);
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void CopyToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			System.Windows.Forms.Clipboard.SetText(RichTextBox1.SelectedText);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void ToolStripMenuItem7_Click(object sender, EventArgs e)
	{
		RichTextBox1.Clear();
		byte[] array = Module0.smethod_6("ClearClipboard");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}
}
