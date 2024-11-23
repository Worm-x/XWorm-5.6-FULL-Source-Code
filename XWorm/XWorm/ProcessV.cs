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
public class ProcessV : Form
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__R84_002D4
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R84_002D4(_Closure_0024__R84_002D4 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R6(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R85_002D6
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R85_002D6(_Closure_0024__R85_002D6 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R8(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R86_002D8
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R86_002D8(_Closure_0024__R86_002D8 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R10(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R87_002D10
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R87_002D10(_Closure_0024__R87_002D10 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R12(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private System.Windows.Forms.Timer _Timer1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem4")]
	private ToolStripMenuItem _ToolStripMenuItem4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem6")]
	private ToolStripMenuItem _ToolStripMenuItem6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RestartToolStripMenuItem1")]
	private ToolStripMenuItem _RestartToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem2")]
	private ToolStripMenuItem _ToolStripMenuItem2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ResumeToolStripMenuItem")]
	private ToolStripMenuItem _ResumeToolStripMenuItem;

	public GClass5 gclass5_0;

	public ListView ListView1
	;

	[field: AccessedThroughProperty("ColumnHeader1")]
	public ColumnHeader ColumnHeader1
	;

	[field: AccessedThroughProperty("ColumnHeader2")]
	public ColumnHeader ColumnHeader2
	;

	public System.Windows.Forms.Timer Timer1
	;

	[field: AccessedThroughProperty("ToolStripStatusLabel1")]
	public ToolStripStatusLabel ToolStripStatusLabel1
	;

	[field: AccessedThroughProperty("ToolStripStatusLabel2")]
	public ToolStripStatusLabel ToolStripStatusLabel2
	;

	[field: AccessedThroughProperty("ImageList1")]
	public ImageList ImageList1
	;

	[field: AccessedThroughProperty("StatusStrip1")]
	public StatusStrip StatusStrip1
	;

	[field: AccessedThroughProperty("ToolStripStatusLabel3")]
	public ToolStripStatusLabel ToolStripStatusLabel3
	;

	[field: AccessedThroughProperty("ToolStripStatusLabel4")]
	public ToolStripStatusLabel ToolStripStatusLabel4
	;

	[field: AccessedThroughProperty("ToolStripSeparator1")]
	public ToolStripSeparator ToolStripSeparator1
	;

	[field: AccessedThroughProperty("Guna2ContextMenuStrip1")]
	public Guna2ContextMenuStrip Guna2ContextMenuStrip2
	;

	public ToolStripMenuItem ToolStripMenuItem4
	;

	public ToolStripMenuItem ToolStripMenuItem6
	;

	public ToolStripMenuItem RestartToolStripMenuItem1
	;

	public ToolStripMenuItem ToolStripMenuItem2
	;

	public ToolStripMenuItem ResumeToolStripMenuItem
	;

	[field: AccessedThroughProperty("ColumnHeader3")]
	public ColumnHeader ColumnHeader3
	;

	public ProcessV()
	{
		base.Load += ProcessV_Load;
		base.FormClosing += ProcessV_FormClosing;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.ProcessV));
		this.ListView1 = new System.Windows.Forms.ListView();
		this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
		this.Guna2ContextMenuStrip2 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
		this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
		this.RestartToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
		this.ToolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
		this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
		this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.ResumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
		this.Guna2ContextMenuStrip2.SuspendLayout();
		this.StatusStrip1.SuspendLayout();
		base.SuspendLayout();
		this.ListView1.SelectedIndexChanged += new System.EventHandler(ListView1_SelectedIndexChanged);
		this.ListView1.KeyDown += new System.Windows.Forms.KeyEventHandler(ListView1_KeyDown);
		this.Timer1.Tick += new System.EventHandler(Timer1_Tick);
		this.ToolStripMenuItem4.Click += new System.EventHandler(ToolStripMenuItem4_Click);
		this.ToolStripMenuItem6.Click += new System.EventHandler(ToolStripMenuItem6_Click);
		this.RestartToolStripMenuItem1.Click += new System.EventHandler(RestartToolStripMenuItem1_Click);
		this.ToolStripMenuItem2.Click += new System.EventHandler(ToolStripMenuItem2_Click);
		this.ResumeToolStripMenuItem.Click += new System.EventHandler(ResumeToolStripMenuItem_Click);
		this.ListView1.BackColor = System.Drawing.Color.White;
		this.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[3] { this.ColumnHeader1, this.ColumnHeader2, this.ColumnHeader3 });
		this.ListView1.ContextMenuStrip = this.Guna2ContextMenuStrip2;
		this.ListView1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ListView1.Font = new System.Drawing.Font("Tahoma", 8f);
		this.ListView1.ForeColor = System.Drawing.Color.Black;
		this.ListView1.FullRowSelect = true;
		this.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
		this.ListView1.HideSelection = false;
		this.ListView1.Location = new System.Drawing.Point(0, 0);
		this.ListView1.Name = "ListView1";
		this.ListView1.ShowGroups = false;
		this.ListView1.ShowItemToolTips = true;
		this.ListView1.Size = new System.Drawing.Size(522, 320);
		this.ListView1.SmallImageList = this.ImageList1;
		this.ListView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
		this.ListView1.TabIndex = 1;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.ColumnHeader1.Text = "[ Name ]";
		this.ColumnHeader1.Width = 273;
		this.ColumnHeader2.Text = "[ PID ]";
		this.ColumnHeader2.Width = 125;
		this.Guna2ContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[5] { this.ToolStripMenuItem4, this.ToolStripMenuItem6, this.RestartToolStripMenuItem1, this.ToolStripMenuItem2, this.ResumeToolStripMenuItem });
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
		this.Guna2ContextMenuStrip2.Size = new System.Drawing.Size(134, 114);
		this.ToolStripMenuItem4.BackColor = System.Drawing.Color.White;
		this.ToolStripMenuItem4.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem4.Image");
		this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
		this.ToolStripMenuItem4.Size = new System.Drawing.Size(133, 22);
		this.ToolStripMenuItem4.Text = "[ Refresh ]";
		this.ToolStripMenuItem6.BackColor = System.Drawing.Color.White;
		this.ToolStripMenuItem6.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem6.Image");
		this.ToolStripMenuItem6.Name = "ToolStripMenuItem6";
		this.ToolStripMenuItem6.Size = new System.Drawing.Size(133, 22);
		this.ToolStripMenuItem6.Text = "[ Close ]";
		this.RestartToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.RestartToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("RestartToolStripMenuItem1.Image");
		this.RestartToolStripMenuItem1.Name = "RestartToolStripMenuItem1";
		this.RestartToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
		this.RestartToolStripMenuItem1.Text = "[ Restart ]";
		this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
		this.ImageList1.ImageSize = new System.Drawing.Size(20, 20);
		this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
		this.Timer1.Enabled = true;
		this.Timer1.Interval = 1000;
		this.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
		this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
		this.ToolStripStatusLabel1.Size = new System.Drawing.Size(13, 17);
		this.ToolStripStatusLabel1.Text = "..";
		this.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.White;
		this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
		this.ToolStripStatusLabel2.Size = new System.Drawing.Size(13, 17);
		this.ToolStripStatusLabel2.Text = "..";
		this.StatusStrip1.BackColor = System.Drawing.Color.White;
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.ToolStripStatusLabel3, this.ToolStripStatusLabel4 });
		this.StatusStrip1.Location = new System.Drawing.Point(0, 320);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Size = new System.Drawing.Size(522, 22);
		this.StatusStrip1.TabIndex = 2;
		this.StatusStrip1.Text = "StatusStrip1";
		this.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.Black;
		this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
		this.ToolStripStatusLabel3.Size = new System.Drawing.Size(68, 17);
		this.ToolStripStatusLabel3.Text = "Selected [0]";
		this.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.Black;
		this.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4";
		this.ToolStripStatusLabel4.Size = new System.Drawing.Size(13, 17);
		this.ToolStripStatusLabel4.Text = "..";
		this.ToolStripSeparator1.Name = "ToolStripSeparator1";
		this.ToolStripSeparator1.Size = new System.Drawing.Size(177, 6);
		this.ToolStripMenuItem2.BackColor = System.Drawing.Color.White;
		this.ToolStripMenuItem2.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem2.Image");
		this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
		this.ToolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
		this.ToolStripMenuItem2.Text = "[ Suspend ]";
		this.ResumeToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.ResumeToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("ResumeToolStripMenuItem.Image");
		this.ResumeToolStripMenuItem.Name = "ResumeToolStripMenuItem";
		this.ResumeToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
		this.ResumeToolStripMenuItem.Text = "[ Resume ]";
		this.ColumnHeader3.Text = "[ Description ]";
		this.ColumnHeader3.Width = 96;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(522, 342);
		base.Controls.Add(this.ListView1);
		base.Controls.Add(this.StatusStrip1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "ProcessV";
		this.Text = "Process Manager";
		this.Guna2ContextMenuStrip2.ResumeLayout(false);
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void ProcessV_Load(object sender, EventArgs e)
	{
		method_0();
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

	public void method_0()
	{
		ListView1.Items.Clear();
		ToolStripStatusLabel4.Text = "Wait..";
		byte[] array = Module0.smethod_6("R#");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void ProcessV_FormClosing(object sender, FormClosingEventArgs e)
	{
		byte[] array = Module0.smethod_6("CloseProcess");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			ToolStripStatusLabel3.Text = "Selected [" + ListView1.SelectedItems.Count + "]";
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void ListView1_KeyDown(object sender, KeyEventArgs e)
	{
		try
		{
			if (e.Modifiers != Keys.Control || e.KeyCode != Keys.A || ListView1.Items.Count <= 0)
			{
				return;
			}
			foreach (ListViewItem item in ListView1.Items)
			{
				item.Selected = true;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void ToolStripMenuItem4_Click(object sender, EventArgs e)
	{
		method_0();
	}

	private void ToolStripMenuItem6_Click(object sender, EventArgs e)
	{
		string text = null;
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			text = text + "-=>" + selectedItem.SubItems[1].Text;
		}
		byte[] array = Module0.smethod_6("kill" + GClass19.string_0 + text);
		_Closure_0024__R84_002D4 arg = default(_Closure_0024__R84_002D4);
		_Closure_0024__R84_002D4 CS_0024_003C_003E8__locals0 = new _Closure_0024__R84_002D4(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2 = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2.method_1((byte[])a0);
		}, array);
	}

	private void RestartToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		string text = null;
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			text = text + "-=>" + selectedItem.SubItems[1].Text;
		}
		byte[] array = Module0.smethod_6("RestartProcess" + GClass19.string_0 + text);
		_Closure_0024__R85_002D6 arg = default(_Closure_0024__R85_002D6);
		_Closure_0024__R85_002D6 CS_0024_003C_003E8__locals0 = new _Closure_0024__R85_002D6(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2 = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2.method_1((byte[])a0);
		}, array);
	}

	private void ToolStripMenuItem2_Click(object sender, EventArgs e)
	{
		string text = null;
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			text = text + "-=>" + selectedItem.SubItems[1].Text;
		}
		byte[] array = Module0.smethod_6("SuspendProcess" + GClass19.string_0 + text);
		_Closure_0024__R86_002D8 arg = default(_Closure_0024__R86_002D8);
		_Closure_0024__R86_002D8 CS_0024_003C_003E8__locals0 = new _Closure_0024__R86_002D8(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2 = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2.method_1((byte[])a0);
		}, array);
	}

	private void ResumeToolStripMenuItem_Click(object sender, EventArgs e)
	{
		string text = null;
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			text = text + "-=>" + selectedItem.SubItems[1].Text;
		}
		byte[] array = Module0.smethod_6("ResumeProcess" + GClass19.string_0 + text);
		_Closure_0024__R87_002D10 arg = default(_Closure_0024__R87_002D10);
		_Closure_0024__R87_002D10 CS_0024_003C_003E8__locals0 = new _Closure_0024__R87_002D10(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2 = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2.method_1((byte[])a0);
		}, array);
	}
}