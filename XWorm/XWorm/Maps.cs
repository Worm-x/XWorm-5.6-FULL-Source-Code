#define DEBUG
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm;

[DesignerGenerated]
public class Maps : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer1")]
	private System.Windows.Forms.Timer _Timer1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("GPSToolStripMenuItem1")]
	private ToolStripMenuItem _GPSToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("IPAPIToolStripMenuItem")]
	private ToolStripMenuItem _IPAPIToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BrowserToolStripMenuItem")]
	private ToolStripMenuItem _BrowserToolStripMenuItem;

	public GClass5 gclass5_0;

	[field: AccessedThroughProperty("GMapControl1")]
	public GMapControl GMapControl1
		;

	public System.Windows.Forms.Timer Timer1
	;

	[field: AccessedThroughProperty("StatusStrip1")]
	public StatusStrip StatusStrip1
	;

	[field: AccessedThroughProperty("ToolStripStatusLabel1")]
	public ToolStripStatusLabel ToolStripStatusLabel1
	;

	[field: AccessedThroughProperty("Guna2ContextMenuStrip2")]
	public Guna2ContextMenuStrip Guna2ContextMenuStrip2
	;

	public ToolStripMenuItem GPSToolStripMenuItem1
	;

	public ToolStripMenuItem IPAPIToolStripMenuItem
	;

	public ToolStripMenuItem BrowserToolStripMenuItem
	;

	public Maps()
	{
		base.FormClosing += Maps_FormClosing;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.Maps));
		this.GMapControl1 = new GMap.NET.WindowsForms.GMapControl();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.Guna2ContextMenuStrip2 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
		this.GPSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.IPAPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.BrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.StatusStrip1.SuspendLayout();
		this.Guna2ContextMenuStrip2.SuspendLayout();
		base.SuspendLayout();
		this.Timer1.Tick += new System.EventHandler(Timer1_Tick);
		this.GPSToolStripMenuItem1.Click += new System.EventHandler(GPSToolStripMenuItem1_Click);
		this.IPAPIToolStripMenuItem.Click += new System.EventHandler(IPAPIToolStripMenuItem_Click);
		this.BrowserToolStripMenuItem.Click += new System.EventHandler(BrowserToolStripMenuItem_Click);
		this.GMapControl1.Bearing = 0f;
		this.GMapControl1.CanDragMap = true;
		this.GMapControl1.ContextMenuStrip = this.Guna2ContextMenuStrip2;
		this.GMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.GMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
		this.GMapControl1.GrayScaleMode = false;
		this.GMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
		this.GMapControl1.LevelsKeepInMemmory = 5;
		this.GMapControl1.Location = new System.Drawing.Point(0, 0);
		this.GMapControl1.MarkersEnabled = true;
		this.GMapControl1.MaxZoom = 16;
		this.GMapControl1.MinZoom = 0;
		this.GMapControl1.MouseWheelZoomEnabled = true;
		this.GMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
		this.GMapControl1.Name = "GMapControl1";
		this.GMapControl1.NegativeMode = false;
		this.GMapControl1.PolygonsEnabled = true;
		this.GMapControl1.RetryLoadTile = 0;
		this.GMapControl1.RoutesEnabled = true;
		this.GMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
		this.GMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(33, 65, 105, 225);
		this.GMapControl1.ShowTileGridLines = false;
		this.GMapControl1.Size = new System.Drawing.Size(492, 270);
		this.GMapControl1.TabIndex = 11;
		this.GMapControl1.Zoom = 5.0;
		this.Timer1.Enabled = true;
		this.Timer1.Interval = 1000;
		this.StatusStrip1.BackColor = System.Drawing.Color.White;
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.ToolStripStatusLabel1 });
		this.StatusStrip1.Location = new System.Drawing.Point(0, 270);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Size = new System.Drawing.Size(492, 22);
		this.StatusStrip1.TabIndex = 12;
		this.StatusStrip1.Text = "StatusStrip1";
		this.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
		this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
		this.ToolStripStatusLabel1.Size = new System.Drawing.Size(13, 17);
		this.ToolStripStatusLabel1.Text = "..";
		this.Guna2ContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.GPSToolStripMenuItem1, this.IPAPIToolStripMenuItem, this.BrowserToolStripMenuItem });
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
		this.Guna2ContextMenuStrip2.Size = new System.Drawing.Size(181, 92);
		this.GPSToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.GPSToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("GPSToolStripMenuItem1.Image");
		this.GPSToolStripMenuItem1.Name = "GPSToolStripMenuItem1";
		this.GPSToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
		this.GPSToolStripMenuItem1.Text = "[ GPS ]";
		this.IPAPIToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.IPAPIToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("IPAPIToolStripMenuItem.Image");
		this.IPAPIToolStripMenuItem.Name = "IPAPIToolStripMenuItem";
		this.IPAPIToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		this.IPAPIToolStripMenuItem.Text = "[ IP-API ]";
		this.BrowserToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.BrowserToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("BrowserToolStripMenuItem.Image");
		this.BrowserToolStripMenuItem.Name = "BrowserToolStripMenuItem";
		this.BrowserToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		this.BrowserToolStripMenuItem.Text = "[ Browser ]";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(492, 292);
		base.Controls.Add(this.GMapControl1);
		base.Controls.Add(this.StatusStrip1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Maps";
		this.Text = "Maps";
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		this.Guna2ContextMenuStrip2.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void Maps_FormClosing(object sender, FormClosingEventArgs e)
	{
		byte[] array = Module0.smethod_6("Clmaps");
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

	private void GPSToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		GMapControl1.Overlays.Clear();
		byte[] array = Module0.smethod_6("GBS");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void IPAPIToolStripMenuItem_Click(object sender, EventArgs e)
	{
		GMapControl1.Overlays.Clear();
		byte[] array = Module0.smethod_6("api");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void BrowserToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			if (!((Operators.CompareString(ToolStripStatusLabel1.Text, "Error!", TextCompare: false) == 0) | (Operators.CompareString(ToolStripStatusLabel1.Text, "..", TextCompare: false) == 0) | (Operators.CompareString(ToolStripStatusLabel1.Text, null, TextCompare: false) == 0)))
			{
				Process.Start("https://www.google.com/maps/place/" + ToolStripStatusLabel1.Text);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}
}