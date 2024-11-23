using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm;

public class GClass2
{
	[DataContract]
	private class response_structure
	{
		[DataMember]
		public bool success { get; set; }

		[DataMember]
		public bool newSession { get; set; }

		[DataMember]
		public string sessionid { get; set; }

		[DataMember]
		public string contents { get; set; }

		[DataMember]
		public string response { get; set; }

		[DataMember]
		public string message { get; set; }

		[DataMember]
		public string download { get; set; }

		[DataMember(IsRequired = false, EmitDefaultValue = false)]
		public user_data_structure info { get; set; }

		[DataMember(IsRequired = false, EmitDefaultValue = false)]
		public app_data_structure appinfo { get; set; }

		[DataMember]
		public List<msg> messages { get; set; }

		[DataMember]
		public List<users> users { get; set; }
	}

	public class msg
	{
		public string message { get; set; }

		public string author { get; set; }

		public string timestamp { get; set; }
	}

	public class users
	{
		public string credential { get; set; }
	}

	[DataContract]
	private class user_data_structure
	{
		[DataMember]
		public string username { get; set; }

		[DataMember]
		public string ip { get; set; }

		[DataMember]
		public string hwid { get; set; }

		[DataMember]
		public string createdate { get; set; }

		[DataMember]
		public string lastlogin { get; set; }

		[DataMember]
		public List<Data> subscriptions { get; set; }
	}

	[DataContract]
	private class app_data_structure
	{
		[DataMember]
		public string numUsers { get; set; }

		[DataMember]
		public string numOnlineUsers { get; set; }

		[DataMember]
		public string numKeys { get; set; }

		[DataMember]
		public string version { get; set; }

		[DataMember]
		public string customerPanelLink { get; set; }

		[DataMember]
		public string downloadLink { get; set; }
	}

	public class app_data_class
	{
		public string numUsers { get; set; }

		public string numOnlineUsers { get; set; }

		public string numKeys { get; set; }

		public string version { get; set; }

		public string customerPanelLink { get; set; }

		public string downloadLink { get; set; }
	}

	public class user_data_class
	{
		public string username { get; set; }

		public string ip { get; set; }

		public string hwid { get; set; }

		public string createdate { get; set; }

		public string lastlogin { get; set; }

		public List<Data> subscriptions { get; set; }
	}

	public class Data
	{
		public string subscription { get; set; }

		public string expiry { get; set; }

		public string timeleft { get; set; }
	}

	public class response_class
	{
		public bool success { get; set; }

		public string message { get; set; }
	}

	public string name;

	public string ownerid;

	public string secret;

	public string version;

	public static long long_0;

	private static string string_0;

	private static string string_1;

	private bool bool_0;

	public app_data_class app_data_class_0;

	public user_data_class user_data_class_0;

	public response_class response_class_0;

	private GClass3 gclass3_0;

	public GClass2(string name, string ownerid, string secret, string version)
	{
		app_data_class_0 = new app_data_class();
		user_data_class_0 = new user_data_class();
		response_class_0 = new response_class();
		gclass3_0 = new GClass3(new response_structure());
		if (ownerid.Length != 10 || secret.Length != 64)
		{
			Process.Start("https://youtube.com/watch?v=RfDTdiBq4_o");
			Process.Start("https://keyauth.cc/app/");
			Thread.Sleep(2000);
			smethod_1("Application not setup correctly. Please watch the YouTube video for setup.");
			Environment.Exit(0);
		}
		this.name = name;
		this.ownerid = ownerid;
		this.secret = secret;
		this.version = version;
	}

	public void method_0()
	{
		string text = GModule0.smethod_4();
		string_1 = text + "-" + secret;
		string text2 = smethod_2(new NameValueCollection
		{
			{ "type", "init" },
			{ "ver", version },
			{
				"hash",
				smethod_0(Process.GetCurrentProcess().MainModule.FileName)
			},
			{ "enckey", text },
			{ "name", name },
			{ "ownerid", ownerid }
		});
		if (object.Equals(text2, "KeyAuth_Invalid"))
		{
			smethod_1("Application not found");
			Environment.Exit(0);
		}
		response_structure response_structure = gclass3_0.method_1<response_structure>(text2);
		method_27(response_structure);
		if (response_structure.success)
		{
			if (response_structure.newSession)
			{
				Thread.Sleep(100);
			}
			string_0 = response_structure.sessionid;
			bool_0 = true;
		}
		else if (object.Equals(response_structure.message, "invalidver"))
		{
			app_data_class_0.downloadLink = response_structure.download;
		}
	}

	public void method_1()
	{
		if (!bool_0)
		{
			smethod_1("You must run the function KeyAuthApp.init(); first");
			Environment.Exit(0);
		}
	}

	public string method_2(string Type, int subscription)
	{
		method_1();
		DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local).AddSeconds(long.Parse(user_data_class_0.subscriptions[subscription].expiry)).ToLocalTime();
		TimeSpan timeSpan = dateTime - DateTime.Now;
		return Type.ToLower() switch
		{
			"hours" => Convert.ToString(timeSpan.Hours),
			"days" => Convert.ToString(timeSpan.Days),
			"months" => Convert.ToString((double)timeSpan.Days / 30.0),
			_ => null,
		};
	}

	public void method_3(string username, string pass, string key, string email = "")
	{
		method_1();
		string value = WindowsIdentity.GetCurrent().User.Value;
		string json = smethod_2(new NameValueCollection
		{
			{ "type", "register" },
			{ "username", username },
			{ "pass", pass },
			{ "key", key },
			{ "email", email },
			{ "hwid", value },
			{ "sessionid", string_0 },
			{ "name", name },
			{ "ownerid", ownerid }
		});
		response_structure response_structure = gclass3_0.method_1<response_structure>(json);
		method_27(response_structure);
		if (response_structure.success)
		{
			method_26(response_structure.info);
		}
	}

	public void method_4(string username, string email)
	{
		method_1();
		string json = smethod_2(new NameValueCollection
		{
			{ "type", "forgot" },
			{ "username", username },
			{ "email", email },
			{ "sessionid", string_0 },
			{ "name", name },
			{ "ownerid", ownerid }
		});
		response_structure data = gclass3_0.method_1<response_structure>(json);
		method_27(data);
	}

	public void method_5(string username, string pass)
	{
		method_1();
		string value = WindowsIdentity.GetCurrent().User.Value;
		string json = smethod_2(new NameValueCollection
		{
			{ "type", "login" },
			{ "username", username },
			{ "pass", pass },
			{ "hwid", value },
			{ "sessionid", string_0 },
			{ "name", name },
			{ "ownerid", ownerid }
		});
		response_structure response_structure = gclass3_0.method_1<response_structure>(json);
		method_27(response_structure);
		if (response_structure.success)
		{
			method_26(response_structure.info);
		}
	}

	public void method_6()
	{
		method_1();
		string json = smethod_2(new NameValueCollection
		{
			{ "type", "logout" },
			{ "sessionid", string_0 },
			{ "name", name },
			{ "ownerid", ownerid }
		});
		response_structure data = gclass3_0.method_1<response_structure>(json);
		method_27(data);
	}

	public void method_7()
	{
		method_1();
		string value = WindowsIdentity.GetCurrent().User.Value;
		HttpListener httpListener;
		HttpListenerRequest request;
		HttpListenerResponse response;
		while (true)
		{
			httpListener = new HttpListener();
			string text = "handshake";
			text = "http://localhost:1337/" + text + "/";
			httpListener.Prefixes.Add(text);
			httpListener.Start();
			HttpListenerContext context = httpListener.GetContext();
			request = context.Request;
			response = context.Response;
			response.AddHeader("Access-Control-Allow-Methods", "GET, POST");
			response.AddHeader("Access-Control-Allow-Origin", "*");
			response.AddHeader("Via", "hugzho's big brain");
			response.AddHeader("Location", "your kernel ;)");
			response.AddHeader("Retry-After", "never lmao");
			response.Headers.Add("Server", "\r\n\r\n");
			if ((object)request.HttpMethod != "OPTIONS")
			{
				break;
			}
			response.StatusCode = 200;
			Thread.Sleep(1);
			httpListener.Stop();
		}
		httpListener.AuthenticationSchemes = AuthenticationSchemes.Negotiate;
		httpListener.UnsafeConnectionNtlmAuthentication = true;
		httpListener.IgnoreWriteExceptions = true;
		string text2 = request.RawUrl.Replace("/handshake?user=", "");
		text2 = text2.Replace("&token=", " ");
		string text3 = text2;
		string value2 = text3.Split()[0];
		string value3 = text3.Split(' ')[1];
		string json = smethod_2(new NameValueCollection
		{
			{ "type", "login" },
			{ "username", value2 },
			{ "token", value3 },
			{ "hwid", value },
			{ "sessionid", string_0 },
			{ "name", name },
			{ "ownerid", ownerid }
		});
		response_structure response_structure = gclass3_0.method_1<response_structure>(json);
		method_27(response_structure);
		bool flag = true;
		if (response_structure.success)
		{
			method_26(response_structure.info);
			response.StatusCode = 420;
			response.StatusDescription = "SHEESH";
		}
		else
		{
			Console.WriteLine(response_structure.message);
			response.StatusCode = 200;
			response.StatusDescription = response_structure.message;
			flag = false;
		}
		byte[] bytes = Encoding.UTF8.GetBytes("Whats up?");
		response.ContentLength64 = bytes.Length;
		response.OutputStream.Write(bytes, 0, bytes.Length);
		Thread.Sleep(1);
		httpListener.Stop();
		if (!flag)
		{
			Environment.Exit(0);
		}
	}

	public void method_8(string pButton)
	{
		method_1();
		HttpListener httpListener = new HttpListener();
		string text = pButton;
		text = "http://localhost:1337/" + text + "/";
		httpListener.Prefixes.Add(text);
		httpListener.Start();
		HttpListenerContext context = httpListener.GetContext();
		_ = context.Request;
		HttpListenerResponse response = context.Response;
		response.AddHeader("Access-Control-Allow-Methods", "GET, POST");
		response.AddHeader("Access-Control-Allow-Origin", "*");
		response.AddHeader("Via", "hugzho's big brain");
		response.AddHeader("Location", "your kernel ;)");
		response.AddHeader("Retry-After", "never lmao");
		response.Headers.Add("Server", "\r\n\r\n");
		response.StatusCode = 420;
		response.StatusDescription = "SHEESH";
		httpListener.AuthenticationSchemes = AuthenticationSchemes.Negotiate;
		httpListener.UnsafeConnectionNtlmAuthentication = true;
		httpListener.IgnoreWriteExceptions = true;
		httpListener.Stop();
	}

	public void method_9(string username, string key)
	{
		method_1();
		string json = smethod_2(new NameValueCollection
		{
			{ "type", "upgrade" },
			{ "username", username },
			{ "key", key },
			{ "sessionid", string_0 },
			{ "name", name },
			{ "ownerid", ownerid }
		});
		response_structure response_structure = gclass3_0.method_1<response_structure>(json);
		response_structure.success = false;
		method_27(response_structure);
	}

	public void method_10(string key)
	{
		method_1();
		string value = WindowsIdentity.GetCurrent().User.Value;
		string json = smethod_2(new NameValueCollection
		{
			{ "type", "license" },
			{ "key", key },
			{ "hwid", value },
			{ "sessionid", string_0 },
			{ "name", name },
			{ "ownerid", ownerid }
		});
		response_structure response_structure = gclass3_0.method_1<response_structure>(json);
		method_27(response_structure);
		if (response_structure.success)
		{
			method_26(response_structure.info);
		}
	}

	public void method_11()
	{
		method_1();
		string json = smethod_2(new NameValueCollection
		{
			{ "type", "check" },
			{ "sessionid", string_0 },
			{ "name", name },
			{ "ownerid", ownerid }
		});
		response_structure data = gclass3_0.method_1<response_structure>(json);
		method_27(data);
	}

	public void method_12(string var, string data)
	{
		method_1();
		string json = smethod_2(new NameValueCollection
		{
			{ "type", "setvar" },
			{ "var", var },
			{ "data", data },
			{ "sessionid", string_0 },
			{ "name", name },
			{ "ownerid", ownerid }
		});
		response_structure data2 = gclass3_0.method_1<response_structure>(json);
		method_27(data2);
	}

	public string method_13(string var)
	{
		method_1();
		string json = smethod_2(new NameValueCollection
		{
			{ "type", "getvar" },
			{ "var", var },
			{ "sessionid", string_0 },
			{ "name", name },
			{ "ownerid", ownerid }
		});
		response_structure response_structure = gclass3_0.method_1<response_structure>(json);
		method_27(response_structure);
		if (response_structure.success)
		{
			return response_structure.response;
		}
		return null;
	}

	public void method_14(string reason = null)
	{
		method_1();
		string json = smethod_2(new NameValueCollection
		{
			{ "type", "ban" },
			{ "reason", reason },
			{ "sessionid", string_0 },
			{ "name", name },
			{ "ownerid", ownerid }
		});
		response_structure data = gclass3_0.method_1<response_structure>(json);
		method_27(data);
	}

	public string method_15(string varid)
	{
		method_1();
		string json = smethod_2(new NameValueCollection
		{
			{ "type", "var" },
			{ "varid", varid },
			{ "sessionid", string_0 },
			{ "name", name },
			{ "ownerid", ownerid }
		});
		response_structure response_structure = gclass3_0.method_1<response_structure>(json);
		method_27(response_structure);
		if (response_structure.success)
		{
			return response_structure.message;
		}
		return null;
	}

	public List<users> method_16()
	{
		method_1();
		string json = smethod_2(new NameValueCollection
		{
			{ "type", "fetchOnline" },
			{ "sessionid", string_0 },
			{ "name", name },
			{ "ownerid", ownerid }
		});
		response_structure response_structure = gclass3_0.method_1<response_structure>(json);
		method_27(response_structure);
		if (response_structure.success)
		{
			return response_structure.users;
		}
		return null;
	}

	public void method_17()
	{
		method_1();
		string json = smethod_2(new NameValueCollection
		{
			{ "type", "fetchStats" },
			{ "sessionid", string_0 },
			{ "name", name },
			{ "ownerid", ownerid }
		});
		response_structure response_structure = gclass3_0.method_1<response_structure>(json);
		method_27(response_structure);
		if (response_structure.success)
		{
			method_25(response_structure.appinfo);
		}
	}

	public List<msg> method_18(string channelname)
	{
		method_1();
		string json = smethod_2(new NameValueCollection
		{
			{ "type", "chatget" },
			{ "channel", channelname },
			{ "sessionid", string_0 },
			{ "name", name },
			{ "ownerid", ownerid }
		});
		response_structure response_structure = gclass3_0.method_1<response_structure>(json);
		method_27(response_structure);
		if (response_structure.success)
		{
			return response_structure.messages;
		}
		return null;
	}

	public bool method_19(string msg, string channelname)
	{
		method_1();
		string json = smethod_2(new NameValueCollection
		{
			{ "type", "chatsend" },
			{ "message", msg },
			{ "channel", channelname },
			{ "sessionid", string_0 },
			{ "name", name },
			{ "ownerid", ownerid }
		});
		response_structure response_structure = gclass3_0.method_1<response_structure>(json);
		method_27(response_structure);
		if (response_structure.success)
		{
			return true;
		}
		return false;
	}

	public bool method_20()
	{
		method_1();
		string value = WindowsIdentity.GetCurrent().User.Value;
		string json = smethod_2(new NameValueCollection
		{
			{ "type", "checkblacklist" },
			{ "hwid", value },
			{ "sessionid", string_0 },
			{ "name", name },
			{ "ownerid", ownerid }
		});
		response_structure response_structure = gclass3_0.method_1<response_structure>(json);
		method_27(response_structure);
		if (response_structure.success)
		{
			return true;
		}
		return false;
	}

	public string method_21(string webid, string param, string body = "", string conttype = "")
	{
		method_1();
		string json = smethod_2(new NameValueCollection
		{
			{ "type", "webhook" },
			{ "webid", webid },
			{ "params", param },
			{ "body", body },
			{ "conttype", conttype },
			{ "sessionid", string_0 },
			{ "name", name },
			{ "ownerid", ownerid }
		});
		response_structure response_structure = gclass3_0.method_1<response_structure>(json);
		method_27(response_structure);
		if (response_structure.success)
		{
			return response_structure.response;
		}
		return null;
	}

	public byte[] method_22(string fileid)
	{
		method_1();
		string json = smethod_2(new NameValueCollection
		{
			{ "type", "file" },
			{ "fileid", fileid },
			{ "sessionid", string_0 },
			{ "name", name },
			{ "ownerid", ownerid }
		});
		response_structure response_structure = gclass3_0.method_1<response_structure>(json);
		method_27(response_structure);
		if (response_structure.success)
		{
			return GModule0.smethod_2(response_structure.contents);
		}
		return null;
	}

	public void method_23(string message)
	{
		method_1();
		smethod_2(new NameValueCollection
		{
			{ "type", "log" },
			{
				"pcuser",
				Environment.UserName
			},
			{ "message", message },
			{ "sessionid", string_0 },
			{ "name", name },
			{ "ownerid", ownerid }
		});
	}

	public void method_24(string username)
	{
		method_1();
		string json = smethod_2(new NameValueCollection
		{
			{ "type", "changeUsername" },
			{ "newUsername", username },
			{ "sessionid", string_0 },
			{ "name", name },
			{ "ownerid", ownerid }
		});
		response_structure data = gclass3_0.method_1<response_structure>(json);
		method_27(data);
	}

	public static string smethod_0(string filename)
	{
		using MD5 mD = MD5.Create();
		using FileStream inputStream = File.OpenRead(filename);
		return BitConverter.ToString(mD.ComputeHash(inputStream)).Replace("-", "").ToLowerInvariant();
	}

	public static void smethod_1(string message)
	{
		string text = "Logs";
		string path = Path.Combine(text, "ErrorLogs.txt");
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		if (!File.Exists(path))
		{
			using (File.Create(path))
			{
				File.AppendAllText(path, DateTime.Now.ToString() + " > This is the start of your error logs file");
			}
		}
		File.AppendAllText(path, DateTime.Now.ToString() + $" > {message}" + Environment.NewLine);
		Process.Start(new ProcessStartInfo("cmd.exe", $"/c start cmd /C \"color b && title Error && echo {message} && timeout /t 5\"")
		{
			CreateNoWindow = true,
			RedirectStandardOutput = true,
			RedirectStandardError = true,
			UseShellExecute = false
		});
		Environment.Exit(0);
	}

	private static string smethod_2(NameValueCollection postData)
	{
		string result;
		try
		{
			using WebClient webClient = new WebClient();
			webClient.Proxy = null;
			ServicePointManager.ServerCertificateValidationCallback = smethod_3;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.2/", postData);
			stopwatch.Stop();
			long_0 = stopwatch.ElapsedMilliseconds;
			ServicePointManager.ServerCertificateValidationCallback = [SpecialName][DebuggerHidden] (object a0, X509Certificate a1, X509Chain a2, SslPolicyErrors a3) => ((Delegate1<bool>)([SpecialName] () => true))();
			smethod_4(Encoding.Default.GetString(bytes), webClient.ResponseHeaders["signature"], postData.Get(0));
			result = Encoding.Default.GetString(bytes);
		}
		catch (WebException ex)
		{
			ProjectData.SetProjectError(ex);
			if (((HttpWebResponse)ex.Response).StatusCode != (HttpStatusCode)429)
			{
				smethod_1("Connection failure. Please try again, or contact us for help.");
				Environment.Exit(0);
				result = "";
				ProjectData.ClearProjectError();
			}
			else
			{
				smethod_1("You're connecting too fast to loader, slow down.");
				Environment.Exit(0);
				result = "";
				ProjectData.ClearProjectError();
			}
		}
		return result;
	}

	private static bool smethod_3(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		if ((!certificate.Issuer.Contains("Cloudflare Inc") && !certificate.Issuer.Contains("Google Trust Services") && !certificate.Issuer.Contains("Let's Encrypt")) || sslPolicyErrors != 0)
		{
			smethod_1("SSL assertion fail, make sure you're not debugging Network. Disable internet firewall on router if possible. & echo: & echo If not, ask the developer of the program to use custom domains to fix this.");
			return false;
		}
		return true;
	}

	private static void smethod_4(string resp, string signature, string type)
	{
		if (Operators.CompareString(type, "log", TextCompare: false) == 0 || Operators.CompareString(type, "file", TextCompare: false) == 0)
		{
			return;
		}
		try
		{
			if (!GModule0.smethod_3(GModule0.smethod_0((Operators.CompareString(type, "init", TextCompare: false) == 0) ? string_1.Substring(17, 64) : string_1, resp), signature))
			{
				smethod_1("Signature checksum failed. Request was tampered with or session ended most likely. & echo: & echo Response: " + resp);
				Environment.Exit(0);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			smethod_1("Signature checksum failed. Request was tampered with or session ended most likely. & echo: & echo Response: " + resp);
			Environment.Exit(0);
			ProjectData.ClearProjectError();
		}
	}

	private void method_25(app_data_structure data)
	{
		app_data_class_0.numUsers = data.numUsers;
		app_data_class_0.numOnlineUsers = data.numOnlineUsers;
		app_data_class_0.numKeys = data.numKeys;
		app_data_class_0.version = data.version;
		app_data_class_0.customerPanelLink = data.customerPanelLink;
	}

	private void method_26(user_data_structure data)
	{
		user_data_class_0.username = data.username;
		user_data_class_0.ip = data.ip;
		user_data_class_0.hwid = data.hwid;
		user_data_class_0.createdate = data.createdate;
		user_data_class_0.lastlogin = data.lastlogin;
		user_data_class_0.subscriptions = data.subscriptions;
	}

	private void method_27(response_structure data)
	{
		response_class_0.success = data.success;
		response_class_0.message = data.message;
	}
}

