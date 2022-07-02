using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace JiayiLauncherRemake.Properties
{
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000041 RID: 65 RVA: 0x0000B648 File Offset: 0x00009848
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000042 RID: 66 RVA: 0x0000B660 File Offset: 0x00009860
		// (set) Token: 0x06000043 RID: 67 RVA: 0x0000B682 File Offset: 0x00009882
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("1")]
		public int AfterLaunch
		{
			get
			{
				return (int)this["AfterLaunch"];
			}
			set
			{
				this["AfterLaunch"] = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0000B698 File Offset: 0x00009898
		// (set) Token: 0x06000045 RID: 69 RVA: 0x0000B6BA File Offset: 0x000098BA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("15")]
		public int InjectDelay
		{
			get
			{
				return (int)this["InjectDelay"];
			}
			set
			{
				this["InjectDelay"] = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0000B6D0 File Offset: 0x000098D0
		// (set) Token: 0x06000047 RID: 71 RVA: 0x0000B6F2 File Offset: 0x000098F2
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool NoInject
		{
			get
			{
				return (bool)this["NoInject"];
			}
			set
			{
				this["NoInject"] = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000048 RID: 72 RVA: 0x0000B708 File Offset: 0x00009908
		// (set) Token: 0x06000049 RID: 73 RVA: 0x0000B72A File Offset: 0x0000992A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("1")]
		public int Priority
		{
			get
			{
				return (int)this["Priority"];
			}
			set
			{
				this["Priority"] = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600004A RID: 74 RVA: 0x0000B740 File Offset: 0x00009940
		// (set) Token: 0x0600004B RID: 75 RVA: 0x0000B762 File Offset: 0x00009962
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool ServerRpc
		{
			get
			{
				return (bool)this["ServerRpc"];
			}
			set
			{
				this["ServerRpc"] = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600004C RID: 76 RVA: 0x0000B778 File Offset: 0x00009978
		// (set) Token: 0x0600004D RID: 77 RVA: 0x0000B79A File Offset: 0x0000999A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Red")]
		public Color AccentColor
		{
			get
			{
				return (Color)this["AccentColor"];
			}
			set
			{
				this["AccentColor"] = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600004E RID: 78 RVA: 0x0000B7B0 File Offset: 0x000099B0
		// (set) Token: 0x0600004F RID: 79 RVA: 0x0000B7D2 File Offset: 0x000099D2
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public int BGMode
		{
			get
			{
				return (int)this["BGMode"];
			}
			set
			{
				this["BGMode"] = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000050 RID: 80 RVA: 0x0000B7E8 File Offset: 0x000099E8
		// (set) Token: 0x06000051 RID: 81 RVA: 0x0000B80A File Offset: 0x00009A0A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("15, 15, 15")]
		public Color BGColor
		{
			get
			{
				return (Color)this["BGColor"];
			}
			set
			{
				this["BGColor"] = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000052 RID: 82 RVA: 0x0000B820 File Offset: 0x00009A20
		// (set) Token: 0x06000053 RID: 83 RVA: 0x0000B842 File Offset: 0x00009A42
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string DLLPath
		{
			get
			{
				return (string)this["DLLPath"];
			}
			set
			{
				this["DLLPath"] = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000054 RID: 84 RVA: 0x0000B854 File Offset: 0x00009A54
		// (set) Token: 0x06000055 RID: 85 RVA: 0x0000B876 File Offset: 0x00009A76
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("No DLL selected.")]
		public string SafeDLLName
		{
			get
			{
				return (string)this["SafeDLLName"];
			}
			set
			{
				this["SafeDLLName"] = value;
			}
		}

		// Token: 0x04000075 RID: 117
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
