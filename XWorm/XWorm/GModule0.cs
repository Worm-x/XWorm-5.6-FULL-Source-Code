using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm;

[StandardModule]
public sealed class GModule0
{
	public static string smethod_0(string enckey, string resp)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(enckey);
		byte[] bytes2 = Encoding.ASCII.GetBytes(resp);
		return smethod_1(new HMACSHA256(bytes).ComputeHash(bytes2));
	}

	public static string smethod_1(byte[] ba)
	{
		StringBuilder stringBuilder = new StringBuilder(checked(ba.Length * 2));
		foreach (byte b in ba)
		{
			stringBuilder.AppendFormat("{0:x2}", b);
		}
		return stringBuilder.ToString();
	}

	public static byte[] smethod_2(string hex)
	{
		checked
		{
			byte[] result;
			try
			{
				int length = hex.Length;
				byte[] array = new byte[(int)Math.Round((double)length / 2.0 - 1.0) + 1];
				int num = length - 1;
				for (int i = 0; i <= num; i += 2)
				{
					array[(int)Math.Round((double)i / 2.0)] = Convert.ToByte(hex.Substring(i, 2), 16);
				}
				result = array;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				GClass2.smethod_1("The session has ended, open program again.");
				Environment.Exit(0);
				result = null;
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_3(string str1, string str2)
	{
		if (str1.Length != str2.Length)
		{
			return false;
		}
		int num = 0;
		checked
		{
			int num2 = str1.Length - 1;
			for (int i = 0; i <= num2; i++)
			{
				num = (num | str1[i]) ^ str2[i];
			}
			return num == 0;
		}
	}

	public static string smethod_4()
	{
		return Guid.NewGuid().ToString().Substring(0, 16);
	}
}