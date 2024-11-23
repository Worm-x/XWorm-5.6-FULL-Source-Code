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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm;

[DesignerGenerated]
public class INFO : Form
{
	private IContainer components;

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
	[AccessedThroughProperty("SaveToolStripMenuItem1")]
	private ToolStripMenuItem _SaveToolStripMenuItem1;

	public GClass5 gclass5_0;

	public string string_0;

	[field: AccessedThroughProperty("StatusStrip1")]
	public StatusStrip StatusStrip1
;

	[field: AccessedThroughProperty("ToolStripStatusLabel1")]
	public ToolStripStatusLabel ToolStripStatusLabel1
	;

	public System.Windows.Forms.Timer Timer1
	;

	[field: AccessedThroughProperty("ImageList1")]
	public ImageList ImageList1
	;

	[field: AccessedThroughProperty("ListView1")]
	public ListView ListView1
	;

	[field: AccessedThroughProperty("ColumnHeader1")]
	public ColumnHeader ColumnHeader1
	;

	[field: AccessedThroughProperty("Guna2ContextMenuStrip1")]
	public Guna2ContextMenuStrip Guna2ContextMenuStrip2
	;

	public ToolStripMenuItem ToolStripMenuItem4
;
	public ToolStripMenuItem SaveToolStripMenuItem1
	;

	public INFO()
	{
		base.Load += INFO_Load;
		base.FormClosing += INFO_FormClosing;
		InitializeComponent();
		this.ImageList1.Images.SetKeyName(0, "battery.png");
		this.ImageList1.Images.SetKeyName(1, "cpu.png");
		this.ImageList1.Images.SetKeyName(2, "gpu.png");
		this.ImageList1.Images.SetKeyName(3, "listdrivers.png");
		this.ImageList1.Images.SetKeyName(4, "listusb.png");
		this.ImageList1.Images.SetKeyName(5, "ram.png");
		this.ImageList1.Images.SetKeyName(6, "client.png");
		this.ImageList1.Images.SetKeyName(7, "process.png");
		this.ImageList1.Images.SetKeyName(8, "firewall.png");
		this.ImageList1.Images.SetKeyName(9, "biosreleasedate.png");
		this.ImageList1.Images.SetKeyName(10, "biosversion.png");
		this.ImageList1.Images.SetKeyName(11, "antivirus.png");
		this.ImageList1.Images.SetKeyName(12, "platform.png");
		this.ImageList1.Images.SetKeyName(13, "ver.png");
		this.ImageList1.Images.SetKeyName(14, "os.png");
		this.ImageList1.Images.SetKeyName(15, "datetime.png");
		this.ImageList1.Images.SetKeyName(16, "identifier.png");
		this.ImageList1.Images.SetKeyName(17, ".net.png");
		this.ImageList1.Images.SetKeyName(18, "systemproductname.png");
		this.ImageList1.Images.SetKeyName(19, "defaultbrowser.png");
		this.ImageList1.Images.SetKeyName(20, "currentlang.png");
		this.ImageList1.Images.SetKeyName(21, "macaddress.png");
		this.ImageList1.Images.SetKeyName(22, "hddserial.png");
		this.ImageList1.Images.SetKeyName(23, "lastreboot.png");
		this.ImageList1.Images.SetKeyName(24, "pcname.png");
		this.ImageList1.Images.SetKeyName(25, "username.png");
		this.ImageList1.Images.SetKeyName(26, "machinetype.png");
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.INFO));
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
		this.ListView1 = new System.Windows.Forms.ListView();
		this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
		this.Guna2ContextMenuStrip2 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
		this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
		this.SaveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.StatusStrip1.SuspendLayout();
		this.Guna2ContextMenuStrip2.SuspendLayout();
		base.SuspendLayout();
		this.Timer1.Tick += new System.EventHandler(Timer1_Tick);
		this.ToolStripMenuItem4.Click += new System.EventHandler(ToolStripMenuItem4_Click);
		this.SaveToolStripMenuItem1.Click += new System.EventHandler(SaveToolStripMenuItem1_Click);
		this.StatusStrip1.BackColor = System.Drawing.Color.White;
		this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.ToolStripStatusLabel1 });
		this.StatusStrip1.Location = new System.Drawing.Point(0, 324);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
		this.StatusStrip1.Size = new System.Drawing.Size(407, 22);
		this.StatusStrip1.TabIndex = 8;
		this.StatusStrip1.Text = "StatusStrip1";
		this.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
		this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
		this.ToolStripStatusLabel1.Size = new System.Drawing.Size(13, 17);
		this.ToolStripStatusLabel1.Text = "..";
		this.Timer1.Enabled = true;
		this.Timer1.Interval = 1000;
		this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImageList1.ImageStream");
		this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
		this.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1] { this.ColumnHeader1 });
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
		this.ListView1.Size = new System.Drawing.Size(407, 324);
		this.ListView1.SmallImageList = this.ImageList1;
		this.ListView1.TabIndex = 9;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.ColumnHeader1.Text = "[ Information ]";
		this.ColumnHeader1.Width = 380;
		this.Guna2ContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.ToolStripMenuItem4, this.SaveToolStripMenuItem1 });
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
		this.ToolStripMenuItem4.BackColor = System.Drawing.Color.White;
		this.ToolStripMenuItem4.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem4.Image");
		this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
		this.ToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
		this.ToolStripMenuItem4.Text = "[ Refresh ]";
		this.SaveToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.SaveToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("SaveToolStripMenuItem1.Image");
		this.SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1";
		this.SaveToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
		this.SaveToolStripMenuItem1.Text = "[ Save ]";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(407, 346);
		base.Controls.Add(this.ListView1);
		base.Controls.Add(this.StatusStrip1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "INFO";
		this.Text = "Information";
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		this.Guna2ContextMenuStrip2.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void INFO_Load(object sender, EventArgs e)
	{
		method_0();
	}

	public void method_0()
	{
		ListView1.Items.Clear();
		ToolStripStatusLabel1.ForeColor = Color.Black;
		ToolStripStatusLabel1.Text = "Wait..";
		byte[] array = Module0.smethod_6("GetInformations");
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

	private void INFO_FormClosing(object sender, FormClosingEventArgs e)
	{
		byte[] array = Module0.smethod_6("CloseInformations");
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

	private void SaveToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			if (ListView1.Items.Count <= 0)
			{
				return;
			}
			string text = Path.Combine(Application.StartupPath, "ClientsFolder", string_0, "Information");
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (ListViewItem item in ListView1.Items)
			{
				stringBuilder.Append(item.SubItems[0].Text);
				stringBuilder.Append(Environment.NewLine);
			}
			StreamWriter streamWriter = new StreamWriter(text + "\\Information_" + DateAndTime.Now.ToString("MM-dd-yyyy HH;mm;ss;fff") + ".txt", append: false);
			streamWriter.WriteLine(stringBuilder.ToString());
			streamWriter.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}
}