using System;
using System.Windows.Forms;

namespace JiayiLauncherRemake
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x0600003D RID: 61 RVA: 0x0000B61A File Offset: 0x0000981A
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Jiayi());
		}
	}
}
