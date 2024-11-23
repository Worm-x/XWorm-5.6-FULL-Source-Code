using System.Reflection;
using System.Windows.Forms;

namespace XWorm;

public class GClass4
{
	public static void smethod_0(ListView listView)
	{
		typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(listView, true, null);
	}
}