using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DiscordRPC;
using Guna.UI2.AnimatorNS;
using JiayiLauncherRemake.Properties;

namespace JiayiLauncherRemake
{
	// Token: 0x02000002 RID: 2
	public partial class Jiayi
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002048 File Offset: 0x00000248
		public Jiayi()
		{
			InitializeComponent();
			Directory.CreateDirectory("c:\\Jiayi");
			Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Packages\\Microsoft.MinecraftUWP_8wekyb3d8bbwe\\RoamingState\\OnixClient\\Launcher");
			var flag = !File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Packages\\Microsoft.MinecraftUWP_8wekyb3d8bbwe\\RoamingState\\OnixClient\\Launcher\\server.txt");
			if (flag)
			{
				File.Create(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Packages\\Microsoft.MinecraftUWP_8wekyb3d8bbwe\\RoamingState\\OnixClient\\Launcher\\server.txt");
			}
			InstallFonts();
			XboxInfo();
			InitializeDiscord();
			LoadNews();
			LoadSettings();
			LoadTexturePacks();
		}

		// Token: 0x06000002 RID: 2
		

		// Token: 0x06000003 RID: 3
		[DllImport("gdi32.dll")]
		private static extern int AddFontResource(string lpszFilename);

		// Token: 0x06000004 RID: 4 RVA: 0x00002130 File Offset: 0x00000330
		private static void InstallFonts()
		{
			var webClient = new WebClient();
			var flag = !File.Exists("c:\\Jiayi\\Montserrat.zip");
			if (!flag) return;
			webClient.DownloadFile("https://github.com/notcarlton/jiayi/raw/master/Montserrat.zip", "c:\\Jiayi\\Montserrat.zip");
			ZipFile.ExtractToDirectory("c:\\Jiayi\\Montserrat.zip", "c:\\Jiayi\\Montserrat");
			var files = Directory.GetFiles("c:\\Jiayi\\Montserrat");
			foreach (var text in files)
			{
				var flag2 = text.EndsWith(".ttf");
				if (flag2)
				{
					AddFontResource(text);
				}
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021BA File Offset: 0x000003BA
		private void CloseBtn_Click(object sender, EventArgs e)
		{
			Opacity = 0.0;
			_client.Dispose();
			Close();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021E0 File Offset: 0x000003E0
		private void MinimizeBtn_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000021EC File Offset: 0x000003EC
		private void HomeTabBtn_Click(object sender, EventArgs e)
		{
			Animation.AddToQueue(Tabs, AnimateMode.Hide);
			Animation.AddToQueue(Title, AnimateMode.Hide);
			Animation.WaitAllAnimations();
			Tabs.SelectTab(0);
			HomeTabBtn.Checked = true;
			SettingsTabBtn.Checked = false;
			NewsfeedTabBtn.Checked = false;
			AppearanceTabBtn.Checked = false;
			Title.Image = HomeTabBtn.CheckedState.Image;
			Title.Text = "Home";
			var flag = Process.GetProcessesByName("Minecraft.Windows").Length == 0;
			if (flag)
			{
				PresenceForBtns("Ready to play");
			}
			Animation.AddToQueue(Tabs, AnimateMode.Show);
			Animation.AddToQueue(Title, AnimateMode.Show);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000230C File Offset: 0x0000050C
		private void SettingsTabBtn_Click(object sender, EventArgs e)
		{
			Animation.AddToQueue(Tabs, AnimateMode.Hide);
			Animation.AddToQueue(Title, AnimateMode.Hide);
			Animation.WaitAllAnimations();
			Tabs.SelectTab(1);
			HomeTabBtn.Checked = false;
			SettingsTabBtn.Checked = true;
			NewsfeedTabBtn.Checked = false;
			AppearanceTabBtn.Checked = false;
			Title.Image = SettingsTabBtn.CheckedState.Image;
			Title.Text = "Launch Settings";
			var flag = Process.GetProcessesByName("Minecraft.Windows").Length == 0;
			if (flag)
			{
				PresenceForBtns("Configuring settings");
			}
			Animation.AddToQueue(Tabs, AnimateMode.Show);
			Animation.AddToQueue(Title, AnimateMode.Show);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000242C File Offset: 0x0000062C
		private void AppearanceTabBtn_Click(object sender, EventArgs e)
		{
			Animation.AddToQueue(Tabs, AnimateMode.Hide);
			Animation.AddToQueue(Title, AnimateMode.Hide);
			Animation.WaitAllAnimations();
			Tabs.SelectTab(2);
			HomeTabBtn.Checked = false;
			SettingsTabBtn.Checked = false;
			NewsfeedTabBtn.Checked = false;
			AppearanceTabBtn.Checked = true;
			Title.Image = AppearanceTabBtn.CheckedState.Image;
			Title.Text = "Appearance";
			var flag = Process.GetProcessesByName("Minecraft.Windows").Length == 0;
			if (flag)
			{
				PresenceForBtns("Changing appearance");
			}
			Animation.AddToQueue(Tabs, AnimateMode.Show);
			Animation.AddToQueue(Title, AnimateMode.Show);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000254C File Offset: 0x0000074C
		private void NewsfeedTabBtn_Click(object sender, EventArgs e)
		{
			Animation.AddToQueue(Tabs, AnimateMode.Hide);
			Animation.AddToQueue(Title, AnimateMode.Hide);
			Animation.WaitAllAnimations();
			Tabs.SelectTab(3);
			HomeTabBtn.Checked = false;
			SettingsTabBtn.Checked = false;
			NewsfeedTabBtn.Checked = true;
			AppearanceTabBtn.Checked = false;
			Title.Image = NewsfeedTabBtn.CheckedState.Image;
			Title.Text = "Newsfeed";
			var flag = Process.GetProcessesByName("Minecraft.Windows").Length == 0;
			if (flag)
			{
				PresenceForBtns("Reading latest news");
			}
			Animation.AddToQueue(Tabs, AnimateMode.Show);
			Animation.AddToQueue(Title, AnimateMode.Show);
		}

		// Token: 0x0600000B RID: 11
		[DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x0600000C RID: 12
		[DllImport("user32.dll")]
		private static extern bool ReleaseCapture();

		// Token: 0x0600000D RID: 13 RVA: 0x0000266A File Offset: 0x0000086A
		private void Title_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(Handle, 161, 2, 0);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002688 File Offset: 0x00000888
		private void XboxInfo()
		{
			var environmentVariable = Environment.GetEnvironmentVariable("LocalAppData");
			var flag = File.Exists("C:\\Jiayi\\XboxLiveGamer.xml.txt");
			if (flag)
			{
				File.Delete("C:\\Jiayi\\XboxLiveGamer.xml.txt");
			}
			var flag2 = File.Exists(environmentVariable + "\\Packages\\Microsoft.XboxApp_8wekyb3d8bbwe\\LocalState\\XboxLiveGamer.xml");
			if (!flag2) return;
			try
			{
				File.Copy(environmentVariable + "\\Packages\\Microsoft.XboxApp_8wekyb3d8bbwe\\LocalState\\XboxLiveGamer.xml", "C:\\Jiayi\\XboxLiveGamer.xml.txt");
				foreach (var text in File.ReadAllLines("C:\\Jiayi\\XboxLiveGamer.xml.txt"))
				{
					var flag3 = text.Contains("Gamertag");
					if (flag3)
					{
						_xboxName = text;
					}
					else
					{
						var flag4 = text.Contains("DisplayPic");
						if (flag4)
						{
							_xboxIconLink = text;
						}
					}
				}
				_xboxName = _xboxName.Replace("\"Gamertag\"", "");
				_xboxName = _xboxName.Replace("\"", "");
				_xboxName = _xboxName.Replace(": ", "");
				_xboxName = _xboxName.Replace(",", "");
				_xboxName = _xboxName.Trim();
				GamertagLabel.Text = _xboxName;
				_xboxIconLink = _xboxIconLink.Replace("\"DisplayPic\"", "");
				_xboxIconLink = _xboxIconLink.Replace("\"", "");
				_xboxIconLink = _xboxIconLink.Replace(": ", "");
				_xboxIconLink = _xboxIconLink.Replace(",", "");
				var webClient = new WebClient();
				webClient.DownloadFileCompleted += XboxIconCompleted;
				webClient.DownloadFileAsync(new Uri(_xboxIconLink), "C:\\jiayi\\icon.png");
				LoginStatusLabel.Text = "Logged in";
			}
			catch (ArgumentException)
			{
				var flag5 = File.Exists(environmentVariable + "\\Packages\\Microsoft.XboxApp_8wekyb3d8bbwe\\LocalState\\XboxLiveGamer.xml");
				MessageBox.Show(
					flag5
						? "Xbox info is unavailable at this time. Try again in an hour or so."
						: "Couldn't get your Xbox gamertag. Make sure you're signed in to Xbox Live.", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000028EC File Offset: 0x00000AEC
		private void XboxIconCompleted(object sender, AsyncCompletedEventArgs e)
		{
			GamerpicBox.Image = new Bitmap("C:\\jiayi\\icon.png");
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002908 File Offset: 0x00000B08
		private static string TrimFileName(string file)
		{
			Console.WriteLine(file);
			file = file.Replace("c:\\jiayi\\Texture Pack Profiles\\", "");
			file = file.Replace(".json", "");
			return file;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002948 File Offset: 0x00000B48
		private void LoadTexturePacks()
		{
			Directory.CreateDirectory("c:\\jiayi\\Texture Pack Profiles");
			_profiles = Directory.GetFiles("c:\\jiayi\\Texture Pack Profiles").ToList();
			var flag = _profiles.Count != 0;
			if (!flag) return;
			TextureList.Items.Clear();
			foreach (var file in _profiles)
			{
				TextureList.Items.Add(TrimFileName(file));
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000029F8 File Offset: 0x00000BF8
		private void LoadNews()
		{
			try
			{
				var webClient = new WebClient();
				NewsTitle.Text = webClient.DownloadString("https://raw.githubusercontent.com/notcarlton/jiayi/master/Feed/BlurbTitle.txt");
				NewsText.Text = webClient.DownloadString("https://raw.githubusercontent.com/notcarlton/jiayi/master/Feed/BlurbText.txt");
				var text = webClient.DownloadString("https://raw.githubusercontent.com/notcarlton/jiayi/master/Feed/FeedData1.txt");
				FeedData1.Text = text;
				var text2 = webClient.DownloadString("https://raw.githubusercontent.com/notcarlton/jiayi/master/Feed/FeedData2.txt");
				FeedData2.Text = text2;
				var text3 = webClient.DownloadString("https://raw.githubusercontent.com/notcarlton/jiayi/master/Feed/FeedData3.txt");
				FeedData3.Text = text3;
				var webRequest = WebRequest.Create("https://github.com/notcarlton/jiayi/raw/master/Images/FeedPic1.png");
				var responseStream = webRequest.GetResponse().GetResponseStream();
				if (responseStream != null)
				{
					var image = Image.FromStream(responseStream);
					FeedPic1.Image = image;
				}

				var webRequest2 = WebRequest.Create("https://github.com/notcarlton/jiayi/raw/master/Images/FeedPic2.png");
				var responseStream2 = webRequest2.GetResponse().GetResponseStream();
				if (responseStream2 != null)
				{
					var image2 = Image.FromStream(responseStream2);
					FeedPic2.Image = image2;
				}

				var webRequest3 = WebRequest.Create("https://github.com/notcarlton/jiayi/raw/master/Images/FeedPic3.png");
				var responseStream3 = webRequest3.GetResponse().GetResponseStream();
				if (responseStream3 != null)
				{
					var image3 = Image.FromStream(responseStream3);
					FeedPic3.Image = image3;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Failed to load current news. Check your internet connection.", "News Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002B50 File Offset: 0x00000D50
		private void InitializeDiscord()
		{
			dynamic dateTimestampEnd = null;

			if (_discordTime != "" && int.TryParse(_discordTime, out var timestampEnd))
				dateTimestampEnd = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(timestampEnd);

			_client = new DiscordRpcClient("858033874264260658");
			_client.Initialize();
			_client.SetPresence(new RichPresence
			{
				Details = "Ready to play",

				Assets = new Assets
				{

					LargeImageKey = "logonewdiscord",
					LargeImageText = "Jiayi Launcher"
				},
				Timestamps = new Timestamps
				{
					Start = _discordTime != "" && int.TryParse(_discordTime, out var timestampStart)
						? new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(timestampStart)
						: DateTime.UtcNow,
					End = dateTimestampEnd
				}


			});
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002CBC File Offset: 0x00000EBC
		private void PresenceForBtns(string status)
		{
			dynamic dateTimestampEnd = null;

			if (_discordTime != "" && int.TryParse(_discordTime, out var timestampEnd))
				dateTimestampEnd = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(timestampEnd);

			_client.SetPresence(new RichPresence
			{
				Details = status,

				Assets = new Assets
				{

					LargeImageKey = "logonewdiscord",
					LargeImageText = "Jiayi Launcher"
				},
				Timestamps = new Timestamps
				{
					Start = _discordTime != "" && int.TryParse(_discordTime, out var timestampStart)
						? new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(timestampStart)
						: DateTime.UtcNow,
					End = dateTimestampEnd
				}

			});
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002E08 File Offset: 0x00001008
		private void PresenceInGame(string server)
		{
			dynamic dateTimestampEnd = null;

            if (_discordTime != "" && int.TryParse(_discordTime, out var timestampEnd))
                dateTimestampEnd = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(timestampEnd);

            var smallImage = "minecraft";
            if (!server.Contains("In a world:") || server != "In the menus")
            {
                if (server.Contains("The Hive"))
                {
                    smallImage = "hive";
                }
                else if (server.Contains("Mineville"))
                {
                    smallImage = "mineville";
                }
                else if (server.Contains("CubeCraft"))
                {
                    smallImage = "cubecraft";
                }
                else if (server.Contains("Mineplex"))
                {
                    smallImage = "mineplex";
                }
                else if (server.Contains("Galaxite"))
                {
                    smallImage = "galaxite";
                }
                else if (server.Contains("Lifeboat"))
                {
                    smallImage = "lifeboat";
                }
                else if (server.Contains("NetherGames"))
                {
                    smallImage = "nethergames";
                }
                else if (server.Contains("HyperLands"))
                {
                    smallImage = "hyperlands";
                }
            }

            _client.SetPresence(new RichPresence
            {
                Details = server,
                State = "as " + _xboxName,

                Assets = new Assets
                {

                    LargeImageKey = "logonewdiscord",
                    LargeImageText = "Jiayi Launcher",
                    SmallImageKey = smallImage,
                    SmallImageText = "Minecraft: Bedrock Edition"
                },
                Timestamps = new Timestamps
                {
                    Start = _discordTime != "" && int.TryParse(_discordTime, out var timestampStart)
	                    ? new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(timestampStart)
	                    : DateTime.UtcNow,
                    End = dateTimestampEnd
                }

            });
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000308C File Offset: 0x0000128C
		private void DontInjectCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			DelayTrackBar.Enabled = !DontInjectCheckBox.Checked;
			SelectDLLButton.Enabled = !DontInjectCheckBox.Checked;
			Settings.Default.NoInject = DontInjectCheckBox.Checked;
			Settings.Default.Save();
			var @checked = DontInjectCheckBox.Checked;
			StatusText.Text = @checked ? "You chose not to inject a DLL." : Settings.Default.SafeDLLName;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003128 File Offset: 0x00001328
		private void BackgroundComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			Settings.Default.BGMode = BackgroundComboBox.SelectedIndex;
			Settings.Default.Save();
			var flag = BackgroundComboBox.SelectedItem.ToString() == "Image";
			if (flag)
			{
				SelectBackgroundBtn.Enabled = false;
				SelectBackgroundBtn.Text = "Not yet!";
			}
			else
			{
				SelectBackgroundBtn.Text = "Select";
				SelectBackgroundBtn.Enabled = false;
				var flag2 = BackgroundComboBox.SelectedItem.ToString() == "Solid Color";
				if (flag2)
				{
					SelectBackgroundBtn.Enabled = true;
				}
				else
				{
					Settings.Default.BGColor = Color.FromArgb(15, 15, 15);
					Settings.Default.Save();
					SetBackground(Settings.Default.BGColor);
				}
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003220 File Offset: 0x00001420
		private void RGBCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			var @checked = RGBCheckBox.Checked;
			if (@checked)
			{
				MessageBox.Show("RGB is currently broken and will return in a later update.", "RGB", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			RGBCheckBox.Checked = false;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003260 File Offset: 0x00001460
		private void LoadSettings()
		{
			LaunchComboBox.SelectedIndex = Settings.Default.AfterLaunch;
			DelayTrackBar.Value = Settings.Default.InjectDelay;
			DontInjectCheckBox.Checked = Settings.Default.NoInject;
			PriorityComboBox.SelectedIndex = Settings.Default.Priority;
			ColorPickerBtn.FillColor = Settings.Default.AccentColor;
			ChangeAccentColor(Settings.Default.AccentColor);
			BackgroundComboBox.SelectedIndex = Settings.Default.BGMode;
			SetBackground(Settings.Default.BGColor);
			var flag = !Settings.Default.NoInject;
			if (flag)
			{
				var flag2 = Settings.Default.DLLPath != "";
				if (flag2)
				{
					StatusText.Text = Settings.Default.SafeDLLName;
				}
			}
			else
			{
				StatusText.Text = "You chose not to inject a DLL.";
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003368 File Offset: 0x00001568
		private void LaunchComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			Settings.Default.AfterLaunch = LaunchComboBox.SelectedIndex;
			Settings.Default.Save();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000338C File Offset: 0x0000158C
		private void DelayTrackBar_Scroll(object sender, ScrollEventArgs e)
		{
			Settings.Default.InjectDelay = DelayTrackBar.Value;
			Settings.Default.Save();
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000033B0 File Offset: 0x000015B0
		private void PriorityComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			Settings.Default.Priority = PriorityComboBox.SelectedIndex;
			Settings.Default.Save();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000033D4 File Offset: 0x000015D4
		private void ResetBtn_Click(object sender, EventArgs e)
		{
			var flag = MessageBox.Show("Are you sure you want to reset the launcher's settings?", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
			if (!flag) return;
			Settings.Default.Reset();
			Process.Start(Application.ExecutablePath);
			CloseBtn_Click(ResetBtn, EventArgs.Empty);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003425 File Offset: 0x00001625
		private void RestartButton_Click(object sender, EventArgs e)
		{
			Process.Start(Application.ExecutablePath);
			CloseBtn_Click(RestartButton, EventArgs.Empty);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003448 File Offset: 0x00001648
		private void ChangeAccentColor(Color color)
		{
			LogoLabel.ForeColor = color;
			HomeTabBtn.CheckedState.CustomBorderColor = color;
			SettingsTabBtn.CheckedState.CustomBorderColor = color;
			AppearanceTabBtn.CheckedState.CustomBorderColor = color;
			NewsfeedTabBtn.CheckedState.CustomBorderColor = color;
			LaunchBtn.FillColor = color;
			SelectDLLButton.FillColor = color;
			ResetBtn.FillColor = color;
			RestartButton.FillColor = color;
			SelectBackgroundBtn.FillColor = color;
			ManagerButton.FillColor = color;
			LoadButton.FillColor = color;
			SavePacksButton.FillColor = color;
			DeleteButton.FillColor = color;
			EnterButton.FillColor = color;
			DelayTrackBar.ThumbColor = color;
			RGBTrackBar.ThumbColor = color;
			BackgroundComboBox.BorderColor = color;
			LaunchComboBox.BorderColor = color;
			PriorityComboBox.BorderColor = color;
			BackgroundComboBox.FocusedState.BorderColor = color;
			LaunchComboBox.FocusedState.BorderColor = color;
			PriorityComboBox.FocusedState.BorderColor = color;
			DontInjectCheckBox.CheckedState.FillColor = color;
			RGBCheckBox.CheckedState.FillColor = color;
			StatusText.BackColor = color;
			PackNameBox.HoverState.BorderColor = color;
			PackNameBox.FocusedState.BorderColor = color;
			ColorPickerBtn.ForeColor = color;
			ColorCodeLabel.Text = string.Concat(color.R.ToString(), ", ", color.G.ToString(), ", ", color.B.ToString());
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003664 File Offset: 0x00001864
		private void SetBackground(Color color)
		{
			BackColor = color;
			Title.FillColor = color;
			Title.HoverState.FillColor = color;
			HomeTab.BackColor = color;
			SettingsTab.BackColor = color;
			AppearanceTab.BackColor = color;
			NewsfeedTab.BackColor = color;
			ManagerTab.BackColor = color;
			CloseBtn.FillColor = color;
			MinimizeBtn.FillColor = color;
			TextureList.BackColor = color;
			var flag = color == Color.FromArgb(15, 15, 15);
			PackInfoPanel.BackColor = flag ? Color.FromArgb(25, 24, 26) : color;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000373C File Offset: 0x0000193C

		// Token: 0x06000022 RID: 34 RVA: 0x00003740 File Offset: 0x00001940
		private void ColorPickerBtn_Click(object sender, EventArgs e)
		{
			var flag = ColorPickerDialog.ShowDialog() == DialogResult.OK;
			if (!flag) return;
			Settings.Default.AccentColor = ColorPickerDialog.Color;
			Settings.Default.Save();
			ChangeAccentColor(Settings.Default.AccentColor);
			MessageBox.Show("Restart Jiayi to fully apply your changes.", "Accent Color", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000037A8 File Offset: 0x000019A8
		private void SelectBackgroundBtn_Click(object sender, EventArgs e)
		{
			var flag = Settings.Default.BGMode == 1;
			if (!flag) return;
			var flag2 = ColorPickerDialog.ShowDialog() == DialogResult.OK;
			if (!flag2) return;
			Settings.Default.BGColor = ColorPickerDialog.Color;
			Settings.Default.Save();
			SetBackground(Settings.Default.BGColor);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003814 File Offset: 0x00001A14
		private void SelectDLLButton_Click(object sender, EventArgs e)
		{
			var flag = FileDialog.ShowDialog() == DialogResult.OK;
			if (!flag) return;
			Settings.Default.DLLPath = FileDialog.FileName;
			Settings.Default.SafeDLLName = FileDialog.SafeFileName;
			Settings.Default.Save();
			StatusText.Text = Settings.Default.SafeDLLName;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003884 File Offset: 0x00001A84
		private void LaunchBtn_Click(object sender, EventArgs e)
		{
			var noInject = Settings.Default.NoInject;
			if (noInject)
			{
				Process.Start("minecraft://");
				StatusText.Text = "Minecraft was opened without injecting.";
			}
			else
			{
				LaunchMinecraft(Settings.Default.DLLPath);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000038D4 File Offset: 0x00001AD4
		private void LaunchMinecraft(string dllPath)
		{
			var flag = dllPath == "";
			if (flag)
			{
				StatusText.Text = "Select a DLL first, or disable injection.";
			}
			else
			{
				Cursor = Cursors.WaitCursor;
				Process.Start("minecraft://");
				StatusText.Text = "Launching Minecraft...";
				var flag2 = Settings.Default.AfterLaunch == 0;
				if (flag2)
				{
					Inject(dllPath);
					Close();
				}
				else
				{
					var flag3 = Settings.Default.AfterLaunch == 1;
					if (flag3)
					{
						NotifyIcon.Visible = true;
						Inject(dllPath);
						Cursor = Cursors.Default;
						StatusText.Text = Settings.Default.SafeDLLName + " was injected.";
						Hide();
					}
					else
					{
						Inject(dllPath);
						Cursor = Cursors.Default;
						StatusText.Text = Settings.Default.SafeDLLName + " was injected.";
					}
				}
				PresenceInGame("In the menus");
				RPCTimer.Start();
				var processesByName = Process.GetProcessesByName("Minecraft.Windows");
				foreach (var process in processesByName)
				{
					var flag4 = Settings.Default.Priority == 0;
					if (flag4)
					{
						process.PriorityClass = ProcessPriorityClass.High;
					}
					else
					{
						var flag5 = Settings.Default.Priority == 1;
						process.PriorityClass = flag5 ? ProcessPriorityClass.Normal : ProcessPriorityClass.BelowNormal;
					}
				}
			}
		}

		// Token: 0x06000027 RID: 39
		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

		// Token: 0x06000028 RID: 40
		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		private static extern IntPtr GetModuleHandle(string lpModuleName);

		// Token: 0x06000029 RID: 41
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

		// Token: 0x0600002A RID: 42
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

		// Token: 0x0600002B RID: 43
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

		// Token: 0x0600002C RID: 44
		[DllImport("kernel32.dll")]
		private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

		// Token: 0x0600002D RID: 45 RVA: 0x00003A80 File Offset: 0x00001C80
		private static void Inject(string dllPath)
		{
			Thread.Sleep(TimeSpan.FromSeconds(Settings.Default.InjectDelay));
			var processesByName = Process.GetProcessesByName("Minecraft.Windows");
			var flag = processesByName.Length != 0;
			if (!flag) return;
			ApplyAppPackages(dllPath);
			var process = Process.GetProcessesByName("Minecraft.Windows")[0];
			var hProcess = OpenProcess(1082, false, process.Id);
			var procAddress = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");
			var intPtr = VirtualAllocEx(hProcess, IntPtr.Zero, (uint)((dllPath.Length + 1) * Marshal.SizeOf(typeof(char))), 12288U, 4U);
			WriteProcessMemory(hProcess, intPtr, Encoding.Default.GetBytes(dllPath), (uint)((dllPath.Length + 1) * Marshal.SizeOf(typeof(char))), out _);
			CreateRemoteThread(hProcess, IntPtr.Zero, 0U, procAddress, intPtr, 0U, IntPtr.Zero);
			Console.WriteLine("injected");
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003B74 File Offset: 0x00001D74
		private static void ApplyAppPackages(string dllPath)
		{
			var fileInfo = new FileInfo(dllPath);
			var accessControl = fileInfo.GetAccessControl();
			accessControl.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier("S-1-15-2-1"), FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
			fileInfo.SetAccessControl(accessControl);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003BB6 File Offset: 0x00001DB6
		private void NotifyIcon_Click(object sender, EventArgs e)
		{
			base.Show();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003BC0 File Offset: 0x00001DC0
		private void RPCTimer_Tick(object sender, EventArgs e)
		{
			var processesByName = Process.GetProcessesByName("Minecraft.Windows");
			var flag = processesByName.Length == 0;
			if (flag)
			{
				var @checked = HomeTabBtn.Checked;
				if (@checked)
				{
					PresenceForBtns("Ready to play");
					RPCTimer.Stop();
				}
				else
				{
					var checked2 = SettingsTabBtn.Checked;
					if (checked2)
					{
						PresenceForBtns("Configuring settings");
						RPCTimer.Stop();
					}
					else
					{
						var checked3 = AppearanceTabBtn.Checked;
						if (checked3)
						{
							PresenceForBtns("Changing appearance");
							RPCTimer.Stop();
						}
						else
						{
							var checked4 = NewsfeedTabBtn.Checked;
							if (checked4)
							{
								PresenceForBtns("Reading latest news");
								RPCTimer.Stop();
							}
						}
					}
				}
			}
			else
			{
				var text = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Packages\\Microsoft.MinecraftUWP_8wekyb3d8bbwe\\RoamingState\\OnixClient\\Launcher\\server.txt");
				var flag2 = text != _previousText;
				if (flag2)
				{
					_previousText = text;
					var flag3 = text == "";
					if (flag3)
					{
						PresenceInGame("In the menus");
					}
					else
					{
						var flag4 = text.Contains("In a World, ");
						if (flag4)
						{
							PresenceInGame("In a world: " + text.Remove(0, 12));
						}
						else
						{
							var flag5 = text == "geo.hivebedrock.network" || text == "fr.hivebedrock.network" || text == "ca.hivebedrock.network" || text == "sg.hivebedrock.network" || text == "jp.hivebedrock.network";
							if (flag5)
							{
								PresenceInGame("Playing on The Hive");
							}
							else
							{
								var flag6 = text == "play.inpvp.net";
								if (flag6)
								{
									PresenceInGame("Playing on Mineville");
								}
								else
								{
									var flag7 = text == "mco.cubecraft.net";
									if (flag7)
									{
										PresenceInGame("Playing on CubeCraft");
									}
									else
									{
										var flag8 = text == "mco.mineplex.com";
										if (flag8)
										{
											PresenceInGame("Playing on Mineplex");
										}
										else
										{
											var flag9 = text == "play.galaxite.net";
											if (flag9)
											{
												PresenceInGame("Playing on Galaxite");
											}
											else
											{
												var flag10 = text == "mco.lbsg.net";
												if (flag10)
												{
													PresenceInGame("Playing on Lifeboat");
												}
												else
												{
													var flag11 = text == "play.nethergames.org";
													if (flag11)
													{
														PresenceInGame("Playing on NetherGames");
													}
													else
													{
														var flag12 = text == "play.hyperlandsmc.net";
														if (flag12)
														{
															PresenceInGame("Playing on HyperLands");
														}
														else
														{
															PresenceInGame("Playing on " + text);
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003E9E File Offset: 0x0000209E
		private void StatusText_Click(object sender, EventArgs e)
		{
			LaunchBtn.PerformClick();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003EB0 File Offset: 0x000020B0
		private void ManagerButton_Click(object sender, EventArgs e)
		{
			Animation.AddToQueue(Tabs, AnimateMode.Hide);
			Animation.WaitAllAnimations();
			Tabs.SelectTab(4);
			Animation.AddToQueue(Tabs, AnimateMode.Show);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00003F14 File Offset: 0x00002114
		private static Image[] GetPackIcons(string path)
		{
			var list = new List<Image>();
			var path2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) +
			            "\\Packages\\Microsoft.MinecraftUWP_8wekyb3d8bbwe\\LocalState\\games\\com.mojang\\resource_packs";
			foreach (var text in Directory.GetDirectories(path2))
			{
				var text2 = "";
				var flag = !File.Exists(text + "\\manifest.json");
				if (flag)
				{
					var flag2 = File.Exists(text + "\\pack_manifest.json");
					if (flag2)
					{
						text2 = text;
					}
					else
					{
						var flag3 = Directory.GetDirectories(text).Length != 0;
						if (flag3)
						{
							text2 = Directory.GetDirectories(text)[0];
						}
					}
				}
				else
				{
					text2 = text;
				}
				var flag4 = File.Exists(text2 + "\\pack_manifest.json");
				string text3;
				if (flag4)
				{
					text3 = text2 + "\\pack_manifest.json";
				}
				else
				{
					text3 = text2 + "\\manifest.json";
				}
				var list2 = new List<string>();
				foreach (var text4 in File.ReadAllLines(path))
				{
					var flag5 = text4.Contains("pack_id");
					if (flag5)
					{
						var text5 = text4;
						text5 = text5.Replace("\"pack_id\" : ", "");
						text5 = text5.Replace("\"", "");
						text5 = text5.Trim();
						text5 = text5.Replace(",", "");
						list2.Add(text5);
					}
				}
				foreach (var value in list2)
				{
					Console.WriteLine(value);
					Console.WriteLine(text3);
					var flag6 = text2 != "";
					if (flag6)
					{
						var flag7 = File.ReadAllText(text3).Contains(value) && File.Exists(text2 + "\\pack_icon.png");
						if (flag7)
						{
							list.Add(Image.FromFile(text2 + "\\pack_icon.png"));
						}
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004144 File Offset: 0x00002344
		private void TextureList_SelectedIndexChanged(object sender, EventArgs e)
		{
			var flag = _profiles.Count != 0;
			if (flag)
			{
				LoadButton.Enabled = true;
				DeleteButton.Enabled = true;
				ProfileName.Text = TextureList.SelectedItem.ToString();
				_packIcons = GetPackIcons(_profiles[TextureList.SelectedIndex]);
				PackIconTimer.Start();
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000041CA File Offset: 0x000023CA
		private void SavePacksButton_Click(object sender, EventArgs e)
		{
			PackNameBox.Visible = true;
			PackNameShadow.Visible = true;
			EnterButton.Visible = true;
			PackNameBox.Focus();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004200 File Offset: 0x00002400
		private void EnterButton_Click(object sender, EventArgs e)
		{
			var sourceFileName = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Packages\\Microsoft.MinecraftUWP_8wekyb3d8bbwe\\LocalState\\games\\com.mojang\\minecraftpe\\global_resource_packs.json";
			var text = "c:\\jiayi\\Texture Pack Profiles\\" + PackNameBox.Text + ".json";
			var flag = !File.Exists(text);
			if (flag)
			{
				File.Copy(sourceFileName, text);
				_profiles.Append(text);
				LoadTexturePacks();
				PackNameBox.Visible = false;
				PackNameShadow.Visible = false;
				EnterButton.Visible = false;
				ProfileName.Text = PackNameBox.Text + " was added.";
				LoadButton.Enabled = false;
				DeleteButton.Enabled = false;
			}
			else
			{
				MessageBox.Show("This profile already exists.", "Texture Pack Profiles", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000042E2 File Offset: 0x000024E2
		private void PackNameBox_TextChanged(object sender, EventArgs e)
		{
			EnterButton.Enabled = PackNameBox.Text != "";
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004308 File Offset: 0x00002508
		private void PackIconTimer_Tick(object sender, EventArgs e)
		{
			var flag = _packIndex != _packIcons.Length - 1 && _packIcons.Length != 0;
			if (flag)
			{
				_packIndex++;
				PackIconBox.Image = _packIcons[_packIndex];
			}
			else
			{
				_packIndex = 0;
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004370 File Offset: 0x00002570
		private void LoadButton_Click(object sender, EventArgs e)
		{
			var text = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Packages\\Microsoft.MinecraftUWP_8wekyb3d8bbwe\\LocalState\\games\\com.mojang\\minecraftpe\\global_resource_packs.json";
			var flag = File.Exists(text);
			if (flag)
			{
				File.Delete(text);
			}
			File.Copy(_profiles[TextureList.SelectedIndex], text);
			ProfileName.Text = TextureList.SelectedItem + " was loaded.";
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000043E4 File Offset: 0x000025E4
		private void DeleteButton_Click(object sender, EventArgs e)
		{
			var dialogResult = MessageBox.Show("Are you sure you want to delete this profile?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
			var flag = dialogResult == DialogResult.Yes;
			if (!flag) return;
			ProfileName.Text = TextureList.SelectedItem + " was deleted.";
			File.Delete(_profiles[TextureList.SelectedIndex]);
			_profiles.RemoveAt(TextureList.SelectedIndex);
			TextureList.Items.Clear();
			LoadTexturePacks();
			LoadButton.Enabled = false;
			DeleteButton.Enabled = false;
			PackIconTimer.Stop();
		}

		// Token: 0x04000001 RID: 1
		private DiscordRpcClient _client;

		// Token: 0x04000002 RID: 2
		private readonly string _discordTime = "";

		// Token: 0x04000003 RID: 3

		// Token: 0x04000004 RID: 4

		// Token: 0x04000005 RID: 5
		private string _xboxName;

		// Token: 0x04000006 RID: 6
		private string _xboxIconLink;

		// Token: 0x04000007 RID: 7
		private List<string> _profiles = new List<string>();

		// Token: 0x04000008 RID: 8

		// Token: 0x04000009 RID: 9

		// Token: 0x0400000A RID: 10

		// Token: 0x0400000B RID: 11

		// Token: 0x0400000C RID: 12

		// Token: 0x0400000D RID: 13

		// Token: 0x0400000E RID: 14

		// Token: 0x0400000F RID: 15

		// Token: 0x04000010 RID: 16
		private string _previousText =
			File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) +
			                 "\\Packages\\Microsoft.MinecraftUWP_8wekyb3d8bbwe\\RoamingState\\OnixClient\\Launcher\\server.txt");

		// Token: 0x04000011 RID: 17
		private int _packIndex;

		// Token: 0x04000012 RID: 18
		private Image[] _packIcons;
	}
}
