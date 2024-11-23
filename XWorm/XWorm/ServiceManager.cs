#define DEBUG
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm;

[DesignerGenerated]
public class ServiceManager : Form
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__R76_002D4
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R76_002D4(_Closure_0024__R76_002D4 arg0)
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
	internal sealed class _Closure_0024__R77_002D6
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R77_002D6(_Closure_0024__R77_002D6 arg0)
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
	internal sealed class _Closure_0024__R78_002D8
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R78_002D8(_Closure_0024__R78_002D8 arg0)
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
	[AccessedThroughProperty("RunningToolStripMenuItem")]
	private ToolStripMenuItem _RunningToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("StoppedToolStripMenuItem")]
	private ToolStripMenuItem _StoppedToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PauseToolStripMenuItem1")]
	private ToolStripMenuItem _PauseToolStripMenuItem1;

	public GClass5 gclass5_0;

	public ListView ListView1
	;

	[field: AccessedThroughProperty("ImageList1")]
	public ImageList ImageList1
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

	[field: AccessedThroughProperty("ColumnHeader1")]
	public ColumnHeader ColumnHeader1
	;

	[field: AccessedThroughProperty("ColumnHeader2")]
	public ColumnHeader ColumnHeader2
	;

	[field: AccessedThroughProperty("ColumnHeader7")]
	public ColumnHeader ColumnHeader7
	;

	[field: AccessedThroughProperty("ColumnHeader8")]
	public ColumnHeader ColumnHeader8
	;
	[field: AccessedThroughProperty("ColumnHeader9")]
	public ColumnHeader ColumnHeader9
	;

	[field: AccessedThroughProperty("Guna2ContextMenuStrip1")]
	public Guna2ContextMenuStrip Guna2ContextMenuStrip2
	;

	public ToolStripMenuItem ToolStripMenuItem4
	;

	public ToolStripMenuItem RunningToolStripMenuItem
	;
	public ToolStripMenuItem StoppedToolStripMenuItem
	;

	public ToolStripMenuItem PauseToolStripMenuItem1
	;

	public ServiceManager()
	{
		base.Load += ServiceManager_Load;
		base.FormClosing += ServiceManager_FormClosing;
		InitializeComponent();


		var resources = new ResourceManager("XWorm.ServiceManager", typeof(ServiceManager).Assembly);
		this.ToolStripMenuItem4.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem4.Image");
		this.RunningToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("RunningToolStripMenuItem.Image");
		this.StoppedToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("StoppedToolStripMenuItem.Image");
		this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
		this.PauseToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("PauseToolStripMenuItem1.Image");
		this.ImageList1.Images.SetKeyName(0, "icons8-settings-20 (1).png");
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");

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
		this.ListView1 = new System.Windows.Forms.ListView();
		this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
		this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
		this.ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
		this.ColumnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
		this.ColumnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
		this.Guna2ContextMenuStrip2 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
		this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
		this.RunningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.StoppedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.PauseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.Guna2ContextMenuStrip2.SuspendLayout();
		this.StatusStrip1.SuspendLayout();
		this.SuspendLayout();
		// 
		// ListView1
		// 
		this.ListView1.BackColor = System.Drawing.Color.White;
		this.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.ColumnHeader1,
			this.ColumnHeader2,
			this.ColumnHeader7,
			this.ColumnHeader8,
			this.ColumnHeader9});
		this.ListView1.ContextMenuStrip = this.Guna2ContextMenuStrip2;
		this.ListView1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ListView1.Font = new System.Drawing.Font("Tahoma", 8F);
		this.ListView1.ForeColor = System.Drawing.Color.Black;
		this.ListView1.FullRowSelect = true;
		this.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
		this.ListView1.HideSelection = false;
		this.ListView1.Location = new System.Drawing.Point(0, 0);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(469, 285);
		this.ListView1.SmallImageList = this.ImageList1;
		this.ListView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
		this.ListView1.TabIndex = 5;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.ListView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
		this.ListView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListView1_KeyDown);
		// 
		// ColumnHeader1
		// 
		this.ColumnHeader1.Text = "[ Name ]";
		this.ColumnHeader1.Width = 125;
		// 
		// ColumnHeader2
		// 
		this.ColumnHeader2.Text = "[ DisplayName ]";
		this.ColumnHeader2.Width = 118;
		// 
		// ColumnHeader7
		// 
		this.ColumnHeader7.Text = "[ ServiceType ]";
		this.ColumnHeader7.Width = 107;
		// 
		// ColumnHeader8
		// 
		this.ColumnHeader8.Text = "[ Status ]";
		this.ColumnHeader8.Width = 89;
		// 
		// ColumnHeader9
		// 
		this.ColumnHeader9.Text = "[ CanStop? ]";
		this.ColumnHeader9.Width = 99;
		// 
		// Guna2ContextMenuStrip2
		// 
		this.Guna2ContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.ToolStripMenuItem4,
			this.RunningToolStripMenuItem,
			this.StoppedToolStripMenuItem,
			this.PauseToolStripMenuItem1});
		this.Guna2ContextMenuStrip2.Name = "Guna2ContextMenuStrip2";
		this.Guna2ContextMenuStrip2.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
		this.Guna2ContextMenuStrip2.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
		this.Guna2ContextMenuStrip2.RenderStyle.ColorTable = null;
		this.Guna2ContextMenuStrip2.RenderStyle.RoundedEdges = true;
		this.Guna2ContextMenuStrip2.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
		this.Guna2ContextMenuStrip2.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(74)))), ((int)(((byte)(250)))));
		this.Guna2ContextMenuStrip2.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
		this.Guna2ContextMenuStrip2.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
		this.Guna2ContextMenuStrip2.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
		this.Guna2ContextMenuStrip2.Size = new System.Drawing.Size(134, 92);
		// 
		// ToolStripMenuItem4
		// 
		this.ToolStripMenuItem4.BackColor = System.Drawing.Color.White;
		this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
		this.ToolStripMenuItem4.Size = new System.Drawing.Size(133, 22);
		this.ToolStripMenuItem4.Text = "[ Refresh ]";
		this.ToolStripMenuItem4.Click += new System.EventHandler(this.ToolStripMenuItem4_Click);
		// 
		// RunningToolStripMenuItem
		// 
		this.RunningToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.RunningToolStripMenuItem.Name = "RunningToolStripMenuItem";
		this.RunningToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
		this.RunningToolStripMenuItem.Text = "[ Running ]";
		this.RunningToolStripMenuItem.Click += new System.EventHandler(this.RunningToolStripMenuItem_Click);
		// 
		// StoppedToolStripMenuItem
		// 
		this.StoppedToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.StoppedToolStripMenuItem.Name = "StoppedToolStripMenuItem";
		this.StoppedToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
		this.StoppedToolStripMenuItem.Text = "[ Stopped ]";
		this.StoppedToolStripMenuItem.Click += new System.EventHandler(this.StoppedToolStripMenuItem_Click);
		// 
		// PauseToolStripMenuItem1
		// 
		this.PauseToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.PauseToolStripMenuItem1.Name = "PauseToolStripMenuItem1";
		this.PauseToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
		this.PauseToolStripMenuItem1.Text = "[ Pause ]";
		this.PauseToolStripMenuItem1.Click += new System.EventHandler(this.PauseToolStripMenuItem1_Click);
		// 
		// ImageList1
		// 

		this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
		this.ImageList1.ImageSize = new System.Drawing.Size(16, 16);
		this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
		// 
		// StatusStrip1
		// 
		this.StatusStrip1.BackColor = System.Drawing.Color.White;
		this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.ToolStripStatusLabel1,
			this.ToolStripStatusLabel2});
		this.StatusStrip1.Location = new System.Drawing.Point(0, 285);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
		this.StatusStrip1.Size = new System.Drawing.Size(469, 22);
		this.StatusStrip1.TabIndex = 6;
		this.StatusStrip1.Text = "StatusStrip1";
		// 
		// ToolStripStatusLabel1
		// 
		this.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
		this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
		this.ToolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
		this.ToolStripStatusLabel1.Text = "Selected [0]";
		// 
		// ToolStripStatusLabel2
		// 
		this.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.Black;
		this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
		this.ToolStripStatusLabel2.Size = new System.Drawing.Size(13, 17);
		this.ToolStripStatusLabel2.Text = "..";
		// 
		// Timer1
		// 
		this.Timer1.Enabled = true;
		this.Timer1.Interval = 1000;
		this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
		// 
		// ServiceManager
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		this.ClientSize = new System.Drawing.Size(469, 307);
		this.Controls.Add(this.ListView1);
		this.Controls.Add(this.StatusStrip1);
		this.Name = "ServiceManager";
		this.Text = "Service Manager";
		this.Guna2ContextMenuStrip2.ResumeLayout(false);
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		this.ResumeLayout(false);
		this.PerformLayout();

	}

	private void ServiceManager_Load(object sender, EventArgs e)
	{
		method_0();
	}

	public void method_0()
	{
		ListView1.Items.Clear();
		ToolStripStatusLabel2.Text = "Wait..";
		byte[] array = Module0.smethod_6("GetService");
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

	private void ServiceManager_FormClosing(object sender, FormClosingEventArgs e)
	{
		byte[] array = Module0.smethod_6("CloseServiceManager");
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

	private void RunningToolStripMenuItem_Click(object sender, EventArgs e)
	{
		string text = null;
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			text = text + "-=>" + selectedItem.SubItems[0].Text;
		}
		byte[] array = Module0.smethod_6("RunService" + GClass19.string_0 + text);
		_Closure_0024__R76_002D4 arg = default(_Closure_0024__R76_002D4);
		_Closure_0024__R76_002D4 CS_0024_003C_003E8__locals0 = new _Closure_0024__R76_002D4(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2 = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2.method_1((byte[])a0);
		}, array);
	}

	private void StoppedToolStripMenuItem_Click(object sender, EventArgs e)
	{
		string text = null;
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			text = text + "-=>" + selectedItem.SubItems[0].Text;
		}
		byte[] array = Module0.smethod_6("StopService" + GClass19.string_0 + text);
		_Closure_0024__R77_002D6 arg = default(_Closure_0024__R77_002D6);
		_Closure_0024__R77_002D6 CS_0024_003C_003E8__locals0 = new _Closure_0024__R77_002D6(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2 = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2.method_1((byte[])a0);
		}, array);
	}

	private void PauseToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		string text = null;
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			text = text + "-=>" + selectedItem.SubItems[0].Text;
		}
		byte[] array = Module0.smethod_6("PauseService" + GClass19.string_0 + text);
		_Closure_0024__R78_002D8 arg = default(_Closure_0024__R78_002D8);
		_Closure_0024__R78_002D8 CS_0024_003C_003E8__locals0 = new _Closure_0024__R78_002D8(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2 = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2.method_1((byte[])a0);
		}, array);
	}
}