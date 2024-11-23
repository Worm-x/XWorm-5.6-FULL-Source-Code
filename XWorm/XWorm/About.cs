#define DEBUG
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm;

[DesignerGenerated]
public class About : Form
{
	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("LinkLabel4")]
	private LinkLabel _LinkLabel4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("LinkLabel2")]
	private LinkLabel _LinkLabel2;

	public LinkLabel LinkLabel4
	;

	[field: AccessedThroughProperty("Label7")]
	public Label Label7
	;

	[field: AccessedThroughProperty("Label1")]
	public Label Label1
	;

	public LinkLabel LinkLabel2
	;
	[field: AccessedThroughProperty("Label3")]
	public Label Label3
	;

	[field: AccessedThroughProperty("Label4")]
	public Label Label4
	;
	[field: AccessedThroughProperty("Label2")]
	public Label Label2
	;

	[field: AccessedThroughProperty("PictureBox3")]
	public PictureBox PictureBox3
	;

	[field: AccessedThroughProperty("PictureBox2")]
	public PictureBox PictureBox2
;

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
            this.LinkLabel4 = new System.Windows.Forms.LinkLabel();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.LinkLabel2 = new System.Windows.Forms.LinkLabel();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.PictureBox3 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LinkLabel4
            // 
            this.LinkLabel4.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(74)))), ((int)(((byte)(250)))));
            this.LinkLabel4.AutoSize = true;
            this.LinkLabel4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel4.ForeColor = System.Drawing.Color.Black;
            this.LinkLabel4.LinkColor = System.Drawing.Color.Black;
            this.LinkLabel4.Location = new System.Drawing.Point(223, 97);
            this.LinkLabel4.Name = "LinkLabel4";
            this.LinkLabel4.Size = new System.Drawing.Size(134, 13);
            this.LinkLabel4.TabIndex = 73;
            this.LinkLabel4.TabStop = true;
            this.LinkLabel4.Text = "https://t.me/XCoderGroup";
            this.LinkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel4_LinkClicked);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Black;
            this.Label7.Location = new System.Drawing.Point(174, 97);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(43, 13);
            this.Label7.TabIndex = 72;
            this.Label7.Text = "Group :";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Red;
            this.Label1.Location = new System.Drawing.Point(183, 138);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(187, 13);
            this.Label1.TabIndex = 71;
            this.Label1.Text = "I am not responsible for your actions!";
            // 
            // LinkLabel2
            // 
            this.LinkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(74)))), ((int)(((byte)(250)))));
            this.LinkLabel2.AutoSize = true;
            this.LinkLabel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabel2.ForeColor = System.Drawing.Color.Black;
            this.LinkLabel2.LinkColor = System.Drawing.Color.Black;
            this.LinkLabel2.Location = new System.Drawing.Point(223, 76);
            this.LinkLabel2.Name = "LinkLabel2";
            this.LinkLabel2.Size = new System.Drawing.Size(144, 13);
            this.LinkLabel2.TabIndex = 70;
            this.LinkLabel2.TabStop = true;
            this.LinkLabel2.Text = "https://evilcoder.mysellix.io/";
            this.LinkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2_LinkClicked);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(179, 76);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(38, 13);
            this.Label3.TabIndex = 69;
            this.Label3.Text = "Shop :";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(161, 51);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(77, 16);
            this.Label4.TabIndex = 68;
            this.Label4.Text = "Contect Us :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(192, 23);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(127, 16);
            this.Label2.TabIndex = 67;
            this.Label2.Text = "Coded By : XCoder";
            // 
            // PictureBox3
            // 
            this.PictureBox3.Location = new System.Drawing.Point(164, 21);
            this.PictureBox3.Name = "PictureBox3";
            this.PictureBox3.Size = new System.Drawing.Size(22, 20);
            this.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox3.TabIndex = 66;
            this.PictureBox3.TabStop = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Location = new System.Drawing.Point(12, 12);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(140, 136);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 65;
            this.PictureBox2.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(382, 160);
            this.Controls.Add(this.LinkLabel4);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LinkLabel2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.PictureBox3);
            this.Controls.Add(this.PictureBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "XWorm V5.6 Edition | About";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

	}

	public About()
	{
		InitializeComponent();
		base.Opacity = 0.0;
		Module0.smethod_18(this, 20);
	}

	private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process.Start(LinkLabel2.Text);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process.Start(LinkLabel4.Text);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}
}