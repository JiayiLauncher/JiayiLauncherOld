using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace JiayiLauncherRemake.Properties
{
	// Token: 0x02000005 RID: 5
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000057 RID: 87 RVA: 0x0000B89C File Offset: 0x00009A9C
		internal Resources()
		{
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000B8A8 File Offset: 0x00009AA8
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("JiayiLauncherRemake.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000059 RID: 89 RVA: 0x0000B8F0 File Offset: 0x00009AF0
		// (set) Token: 0x0600005A RID: 90 RVA: 0x0000B907 File Offset: 0x00009B07
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x04000076 RID: 118
		private static ResourceManager resourceMan;

		// Token: 0x04000077 RID: 119
		private static CultureInfo resourceCulture;
	}
}
