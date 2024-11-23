using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm;

public class GClass3
{
	private DataContractJsonSerializer dataContractJsonSerializer_0;

	private object object_0;

	public static bool smethod_0(Type to_check)
	{
		return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), inherit: true);
	}

	public GClass3(object obj_to_work_with)
	{
		object_0 = RuntimeHelpers.GetObjectValue(obj_to_work_with);
		Type type = object_0.GetType();
		dataContractJsonSerializer_0 = new DataContractJsonSerializer(type);
		if (!smethod_0(type))
		{
			throw new Exception($"the object {RuntimeHelpers.GetObjectValue(object_0)} isn't a serializable");
		}
	}

	public object method_0(string json)
	{
		using MemoryStream stream = new MemoryStream(Encoding.Default.GetBytes(json));
		return dataContractJsonSerializer_0.ReadObject((Stream)stream);
	}

	public T method_1<T>(string json)
	{
		return Conversions.ToGenericParameter<T>(method_0(json));
	}
}