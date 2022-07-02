namespace JiayiLauncherRemake
{
	// Token: 0x02000002 RID: 2
	public partial class Jiayi : global::System.Windows.Forms.Form
	{
		// Token: 0x0600003B RID: 59 RVA: 0x000044AC File Offset: 0x000026AC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000044E4 File Offset: 0x000026E4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Guna.UI2.AnimatorNS.Animation animation = new global::Guna.UI2.AnimatorNS.Animation();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::JiayiLauncherRemake.Jiayi));
			this.BorderlessForm = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.Buttons = new global::Guna.UI2.WinForms.Guna2Panel();
			this.GamerpicBox = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.GamerpicShadow = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.LoginStatusLabel = new global::System.Windows.Forms.Label();
			this.GamertagLabel = new global::System.Windows.Forms.Label();
			this.AppearanceTabBtn = new global::Guna.UI2.WinForms.Guna2Button();
			this.NewsfeedTabBtn = new global::Guna.UI2.WinForms.Guna2Button();
			this.SettingsTabBtn = new global::Guna.UI2.WinForms.Guna2Button();
			this.HomeTabBtn = new global::Guna.UI2.WinForms.Guna2Button();
			this.LogoLabel = new global::System.Windows.Forms.Label();
			this.Title = new global::Guna.UI2.WinForms.Guna2Button();
			this.Tabs = new global::Guna.UI2.WinForms.Guna2TabControl();
			this.HomeTab = new global::System.Windows.Forms.TabPage();
			this.StatusText = new global::System.Windows.Forms.Label();
			this.SelectDLLButton = new global::Guna.UI2.WinForms.Guna2Button();
			this.SelectDLLShadow = new global::Guna.UI2.WinForms.Guna2Panel();
			this.LaunchBtn = new global::Guna.UI2.WinForms.Guna2Button();
			this.LaunchShadow = new global::Guna.UI2.WinForms.Guna2Panel();
			this.LaunchNewsPanel = new global::Guna.UI2.WinForms.Guna2Panel();
			this.NewsText = new global::System.Windows.Forms.Label();
			this.NewsTitle = new global::System.Windows.Forms.Label();
			this.LaunchNewsShadow = new global::Guna.UI2.WinForms.Guna2Panel();
			this.SettingsTab = new global::System.Windows.Forms.TabPage();
			this.ManagerButton = new global::Guna.UI2.WinForms.Guna2Button();
			this.ManagerShadow = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.ManagerDescription = new global::System.Windows.Forms.Label();
			this.ManagerTitle = new global::System.Windows.Forms.Label();
			this.RestartDescription = new global::System.Windows.Forms.Label();
			this.RestartTitle = new global::System.Windows.Forms.Label();
			this.RestartButton = new global::Guna.UI2.WinForms.Guna2Button();
			this.RestartShadow = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.ResetBtn = new global::Guna.UI2.WinForms.Guna2Button();
			this.ResetShadow = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.ResetDescription = new global::System.Windows.Forms.Label();
			this.ResetTitle = new global::System.Windows.Forms.Label();
			this.PriorityComboBox = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.PriorityDescription = new global::System.Windows.Forms.Label();
			this.PriorityTitle = new global::System.Windows.Forms.Label();
			this.DontInjectCheckBox = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.DelayTrackBar = new global::Guna.UI2.WinForms.Guna2TrackBar();
			this.DelayDescription = new global::System.Windows.Forms.Label();
			this.DelayTitle = new global::System.Windows.Forms.Label();
			this.LaunchComboBox = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.LaunchDescription = new global::System.Windows.Forms.Label();
			this.LaunchSettingsLabel = new global::System.Windows.Forms.Label();
			this.AppearanceTab = new global::System.Windows.Forms.TabPage();
			this.ThemesSoon = new global::System.Windows.Forms.Label();
			this.ThemesCover = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.ThemesLabel = new global::System.Windows.Forms.Label();
			this.RGBDescription = new global::System.Windows.Forms.Label();
			this.RGBCheckBox = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.RGBTrackBar = new global::Guna.UI2.WinForms.Guna2TrackBar();
			this.SelectBackgroundBtn = new global::Guna.UI2.WinForms.Guna2Button();
			this.SelectBackgroundShadow = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.BackgroundTitle = new global::System.Windows.Forms.Label();
			this.ColorPickerBtn = new global::Guna.UI2.WinForms.Guna2Button();
			this.ColorPickerShadow = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.BackgroundComboBox = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.ColorCodeLabel = new global::System.Windows.Forms.Label();
			this.ColorTitle = new global::System.Windows.Forms.Label();
			this.NewsfeedTab = new global::System.Windows.Forms.TabPage();
			this.FeedData3 = new global::System.Windows.Forms.Label();
			this.FeedPic3 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.FeedShadow3 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.FeedData2 = new global::System.Windows.Forms.Label();
			this.FeedPic2 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.FeedShadow2 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.FeedData1 = new global::System.Windows.Forms.Label();
			this.FeedPic1 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.FeedShadow1 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.ManagerTab = new global::System.Windows.Forms.TabPage();
			this.PackInfoPanel = new global::Guna.UI2.WinForms.Guna2Panel();
			this.EnterButton = new global::Guna.UI2.WinForms.Guna2Button();
			this.PackNameBox = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.DeleteButton = new global::Guna.UI2.WinForms.Guna2Button();
			this.DeleteShadow = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.LoadButton = new global::Guna.UI2.WinForms.Guna2Button();
			this.LoadShadow = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.SavePacksButton = new global::Guna.UI2.WinForms.Guna2Button();
			this.SavePacksShadow = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.PackIconBox = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.PackIconShadow = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.ProfileName = new global::System.Windows.Forms.Label();
			this.PackNameShadow = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.TextureList = new global::System.Windows.Forms.ListBox();
			this.TextureMenuStrip = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.loadToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CloseBtn = new global::Guna.UI2.WinForms.Guna2Button();
			this.MinimizeBtn = new global::Guna.UI2.WinForms.Guna2Button();
			this.ColorPickerDialog = new global::System.Windows.Forms.ColorDialog();
			this.FileDialog = new global::System.Windows.Forms.OpenFileDialog();
			this.NotifyIcon = new global::System.Windows.Forms.NotifyIcon(this.components);
			this.RPCTimer = new global::System.Windows.Forms.Timer(this.components);
			this.Animation = new global::Guna.UI2.WinForms.Guna2Transition();
			this.PackIconTimer = new global::System.Windows.Forms.Timer(this.components);
			this.Buttons.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GamerpicBox).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GamerpicShadow).BeginInit();
			this.Tabs.SuspendLayout();
			this.HomeTab.SuspendLayout();
			this.LaunchNewsPanel.SuspendLayout();
			this.SettingsTab.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ManagerShadow).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.RestartShadow).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ResetShadow).BeginInit();
			this.AppearanceTab.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ThemesCover).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SelectBackgroundShadow).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ColorPickerShadow).BeginInit();
			this.NewsfeedTab.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.FeedPic3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FeedShadow3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FeedPic2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FeedShadow2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FeedPic1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FeedShadow1).BeginInit();
			this.ManagerTab.SuspendLayout();
			this.PackInfoPanel.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DeleteShadow).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.LoadShadow).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SavePacksShadow).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.PackIconBox).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.PackIconShadow).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.PackNameShadow).BeginInit();
			this.TextureMenuStrip.SuspendLayout();
			base.SuspendLayout();
			this.BorderlessForm.AnimateWindow = true;
			this.BorderlessForm.AnimationInterval = 300;
			this.BorderlessForm.ContainerControl = this;
			this.BorderlessForm.DockForm = false;
			this.BorderlessForm.DragForm = false;
			this.BorderlessForm.ResizeForm = false;
			this.Buttons.BackColor = global::System.Drawing.Color.FromArgb(25, 24, 26);
			this.Buttons.Controls.Add(this.GamerpicBox);
			this.Buttons.Controls.Add(this.GamerpicShadow);
			this.Buttons.Controls.Add(this.LoginStatusLabel);
			this.Buttons.Controls.Add(this.GamertagLabel);
			this.Buttons.Controls.Add(this.AppearanceTabBtn);
			this.Buttons.Controls.Add(this.NewsfeedTabBtn);
			this.Buttons.Controls.Add(this.SettingsTabBtn);
			this.Buttons.Controls.Add(this.HomeTabBtn);
			this.Buttons.Controls.Add(this.LogoLabel);
			this.Animation.SetDecoration(this.Buttons, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.Buttons.Location = new global::System.Drawing.Point(0, 0);
			this.Buttons.Name = "Buttons";
			this.Buttons.ShadowDecoration.Parent = this.Buttons;
			this.Buttons.Size = new global::System.Drawing.Size(200, 550);
			this.Buttons.TabIndex = 0;
			this.GamerpicBox.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.Animation.SetDecoration(this.GamerpicBox, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.GamerpicBox.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("GamerpicBox.Image");
			this.GamerpicBox.ImageRotate = 0f;
			this.GamerpicBox.Location = new global::System.Drawing.Point(12, 493);
			this.GamerpicBox.Name = "GamerpicBox";
			this.GamerpicBox.ShadowDecoration.Parent = this.GamerpicBox;
			this.GamerpicBox.Size = new global::System.Drawing.Size(45, 45);
			this.GamerpicBox.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.GamerpicBox.TabIndex = 5;
			this.GamerpicBox.TabStop = false;
			this.Animation.SetDecoration(this.GamerpicShadow, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.GamerpicShadow.FillColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.GamerpicShadow.ImageRotate = 0f;
			this.GamerpicShadow.Location = new global::System.Drawing.Point(17, 498);
			this.GamerpicShadow.Name = "GamerpicShadow";
			this.GamerpicShadow.ShadowDecoration.Parent = this.GamerpicShadow;
			this.GamerpicShadow.Size = new global::System.Drawing.Size(45, 45);
			this.GamerpicShadow.TabIndex = 8;
			this.GamerpicShadow.TabStop = false;
			this.LoginStatusLabel.AutoSize = true;
			this.Animation.SetDecoration(this.LoginStatusLabel, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.LoginStatusLabel.Font = new global::System.Drawing.Font("Montserrat ExtraBold", 9.749999f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LoginStatusLabel.ForeColor = global::System.Drawing.Color.DimGray;
			this.LoginStatusLabel.Location = new global::System.Drawing.Point(63, 511);
			this.LoginStatusLabel.Name = "LoginStatusLabel";
			this.LoginStatusLabel.Size = new global::System.Drawing.Size(102, 18);
			this.LoginStatusLabel.TabIndex = 7;
			this.LoginStatusLabel.Text = "Not logged in";
			this.LoginStatusLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.GamertagLabel.AutoSize = true;
			this.Animation.SetDecoration(this.GamertagLabel, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.GamertagLabel.Font = new global::System.Drawing.Font("Montserrat ExtraBold", 9.749999f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.GamertagLabel.Location = new global::System.Drawing.Point(63, 493);
			this.GamertagLabel.Name = "GamertagLabel";
			this.GamertagLabel.Size = new global::System.Drawing.Size(77, 18);
			this.GamertagLabel.TabIndex = 6;
			this.GamertagLabel.Text = "Gamertag";
			this.GamertagLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.AppearanceTabBtn.Animated = true;
			this.AppearanceTabBtn.CheckedState.CustomBorderColor = global::System.Drawing.Color.Red;
			this.AppearanceTabBtn.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.AppearanceTabBtn.CheckedState.ForeColor = global::System.Drawing.Color.White;
			this.AppearanceTabBtn.CheckedState.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("resource.Image");
			this.AppearanceTabBtn.CheckedState.Parent = this.AppearanceTabBtn;
			this.AppearanceTabBtn.CustomBorderColor = global::System.Drawing.Color.FromArgb(25, 24, 26);
			this.AppearanceTabBtn.CustomBorderThickness = new global::System.Windows.Forms.Padding(5, 0, 0, 0);
			this.AppearanceTabBtn.CustomImages.Parent = this.AppearanceTabBtn;
			this.Animation.SetDecoration(this.AppearanceTabBtn, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.AppearanceTabBtn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.AppearanceTabBtn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.AppearanceTabBtn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.AppearanceTabBtn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.AppearanceTabBtn.DisabledState.Parent = this.AppearanceTabBtn;
			this.AppearanceTabBtn.FillColor = global::System.Drawing.Color.FromArgb(25, 24, 26);
			this.AppearanceTabBtn.Font = new global::System.Drawing.Font("Montserrat Black", 15f, global::System.Drawing.FontStyle.Bold);
			this.AppearanceTabBtn.ForeColor = global::System.Drawing.Color.Gray;
			this.AppearanceTabBtn.HoverState.Parent = this.AppearanceTabBtn;
			this.AppearanceTabBtn.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("AppearanceTabBtn.Image");
			this.AppearanceTabBtn.ImageSize = new global::System.Drawing.Size(30, 30);
			this.AppearanceTabBtn.Location = new global::System.Drawing.Point(0, 295);
			this.AppearanceTabBtn.Name = "AppearanceTabBtn";
			this.AppearanceTabBtn.ShadowDecoration.Parent = this.AppearanceTabBtn;
			this.AppearanceTabBtn.Size = new global::System.Drawing.Size(200, 60);
			this.AppearanceTabBtn.TabIndex = 4;
			this.AppearanceTabBtn.Text = "Appearance";
			this.AppearanceTabBtn.Click += new global::System.EventHandler(this.AppearanceTabBtn_Click);
			this.NewsfeedTabBtn.Animated = true;
			this.NewsfeedTabBtn.CheckedState.CustomBorderColor = global::System.Drawing.Color.Red;
			this.NewsfeedTabBtn.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.NewsfeedTabBtn.CheckedState.ForeColor = global::System.Drawing.Color.White;
			this.NewsfeedTabBtn.CheckedState.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("resource.Image1");
			this.NewsfeedTabBtn.CheckedState.Parent = this.NewsfeedTabBtn;
			this.NewsfeedTabBtn.CustomBorderColor = global::System.Drawing.Color.FromArgb(25, 24, 26);
			this.NewsfeedTabBtn.CustomBorderThickness = new global::System.Windows.Forms.Padding(5, 0, 0, 0);
			this.NewsfeedTabBtn.CustomImages.Parent = this.NewsfeedTabBtn;
			this.Animation.SetDecoration(this.NewsfeedTabBtn, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.NewsfeedTabBtn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.NewsfeedTabBtn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.NewsfeedTabBtn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.NewsfeedTabBtn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.NewsfeedTabBtn.DisabledState.Parent = this.NewsfeedTabBtn;
			this.NewsfeedTabBtn.FillColor = global::System.Drawing.Color.FromArgb(25, 24, 26);
			this.NewsfeedTabBtn.Font = new global::System.Drawing.Font("Montserrat Black", 15f, global::System.Drawing.FontStyle.Bold);
			this.NewsfeedTabBtn.ForeColor = global::System.Drawing.Color.Gray;
			this.NewsfeedTabBtn.HoverState.Parent = this.NewsfeedTabBtn;
			this.NewsfeedTabBtn.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("NewsfeedTabBtn.Image");
			this.NewsfeedTabBtn.ImageSize = new global::System.Drawing.Size(30, 30);
			this.NewsfeedTabBtn.Location = new global::System.Drawing.Point(0, 355);
			this.NewsfeedTabBtn.Name = "NewsfeedTabBtn";
			this.NewsfeedTabBtn.ShadowDecoration.Parent = this.NewsfeedTabBtn;
			this.NewsfeedTabBtn.Size = new global::System.Drawing.Size(200, 60);
			this.NewsfeedTabBtn.TabIndex = 3;
			this.NewsfeedTabBtn.Text = "Newsfeed";
			this.NewsfeedTabBtn.Click += new global::System.EventHandler(this.NewsfeedTabBtn_Click);
			this.SettingsTabBtn.Animated = true;
			this.SettingsTabBtn.CheckedState.CustomBorderColor = global::System.Drawing.Color.Red;
			this.SettingsTabBtn.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.SettingsTabBtn.CheckedState.ForeColor = global::System.Drawing.Color.White;
			this.SettingsTabBtn.CheckedState.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("resource.Image2");
			this.SettingsTabBtn.CheckedState.Parent = this.SettingsTabBtn;
			this.SettingsTabBtn.CustomBorderColor = global::System.Drawing.Color.FromArgb(25, 24, 26);
			this.SettingsTabBtn.CustomBorderThickness = new global::System.Windows.Forms.Padding(5, 0, 0, 0);
			this.SettingsTabBtn.CustomImages.Parent = this.SettingsTabBtn;
			this.Animation.SetDecoration(this.SettingsTabBtn, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.SettingsTabBtn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.SettingsTabBtn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.SettingsTabBtn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.SettingsTabBtn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.SettingsTabBtn.DisabledState.Parent = this.SettingsTabBtn;
			this.SettingsTabBtn.FillColor = global::System.Drawing.Color.FromArgb(25, 24, 26);
			this.SettingsTabBtn.Font = new global::System.Drawing.Font("Montserrat Black", 15f, global::System.Drawing.FontStyle.Bold);
			this.SettingsTabBtn.ForeColor = global::System.Drawing.Color.Gray;
			this.SettingsTabBtn.HoverState.Parent = this.SettingsTabBtn;
			this.SettingsTabBtn.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("SettingsTabBtn.Image");
			this.SettingsTabBtn.ImageSize = new global::System.Drawing.Size(30, 30);
			this.SettingsTabBtn.Location = new global::System.Drawing.Point(0, 235);
			this.SettingsTabBtn.Name = "SettingsTabBtn";
			this.SettingsTabBtn.ShadowDecoration.Parent = this.SettingsTabBtn;
			this.SettingsTabBtn.Size = new global::System.Drawing.Size(200, 60);
			this.SettingsTabBtn.TabIndex = 2;
			this.SettingsTabBtn.Text = "Settings";
			this.SettingsTabBtn.Click += new global::System.EventHandler(this.SettingsTabBtn_Click);
			this.HomeTabBtn.Animated = true;
			this.HomeTabBtn.Checked = true;
			this.HomeTabBtn.CheckedState.CustomBorderColor = global::System.Drawing.Color.Red;
			this.HomeTabBtn.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.HomeTabBtn.CheckedState.ForeColor = global::System.Drawing.Color.White;
			this.HomeTabBtn.CheckedState.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("resource.Image3");
			this.HomeTabBtn.CheckedState.Parent = this.HomeTabBtn;
			this.HomeTabBtn.CustomBorderColor = global::System.Drawing.Color.FromArgb(25, 24, 26);
			this.HomeTabBtn.CustomBorderThickness = new global::System.Windows.Forms.Padding(5, 0, 0, 0);
			this.HomeTabBtn.CustomImages.Parent = this.HomeTabBtn;
			this.Animation.SetDecoration(this.HomeTabBtn, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.HomeTabBtn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.HomeTabBtn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.HomeTabBtn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.HomeTabBtn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.HomeTabBtn.DisabledState.Parent = this.HomeTabBtn;
			this.HomeTabBtn.FillColor = global::System.Drawing.Color.FromArgb(25, 24, 26);
			this.HomeTabBtn.Font = new global::System.Drawing.Font("Montserrat Black", 15f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.HomeTabBtn.ForeColor = global::System.Drawing.Color.Gray;
			this.HomeTabBtn.HoverState.Parent = this.HomeTabBtn;
			this.HomeTabBtn.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("HomeTabBtn.Image");
			this.HomeTabBtn.ImageSize = new global::System.Drawing.Size(30, 30);
			this.HomeTabBtn.Location = new global::System.Drawing.Point(0, 175);
			this.HomeTabBtn.Name = "HomeTabBtn";
			this.HomeTabBtn.ShadowDecoration.Parent = this.HomeTabBtn;
			this.HomeTabBtn.Size = new global::System.Drawing.Size(200, 60);
			this.HomeTabBtn.TabIndex = 1;
			this.HomeTabBtn.Text = "Home";
			this.HomeTabBtn.Click += new global::System.EventHandler(this.HomeTabBtn_Click);
			this.LogoLabel.AutoSize = true;
			this.Animation.SetDecoration(this.LogoLabel, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.LogoLabel.Font = new global::System.Drawing.Font("Montserrat", 71.99999f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LogoLabel.ForeColor = global::System.Drawing.Color.Red;
			this.LogoLabel.Location = new global::System.Drawing.Point(9, 20);
			this.LogoLabel.Name = "LogoLabel";
			this.LogoLabel.Size = new global::System.Drawing.Size(171, 132);
			this.LogoLabel.TabIndex = 0;
			this.LogoLabel.Text = "嘉";
			this.Title.BackColor = global::System.Drawing.Color.Transparent;
			this.Title.CheckedState.CustomBorderColor = global::System.Drawing.Color.Red;
			this.Title.CheckedState.Parent = this.Title;
			this.Title.CustomImages.Parent = this.Title;
			this.Animation.SetDecoration(this.Title, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.Title.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.Title.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.Title.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Title.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.Title.DisabledState.Parent = this.Title;
			this.Title.FillColor = global::System.Drawing.Color.Transparent;
			this.Title.Font = new global::System.Drawing.Font("Montserrat Black", 24f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Title.ForeColor = global::System.Drawing.Color.White;
			this.Title.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.Title.HoverState.Parent = this.Title;
			this.Title.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("Title.Image");
			this.Title.ImageOffset = new global::System.Drawing.Point(-2, 0);
			this.Title.ImageSize = new global::System.Drawing.Size(40, 40);
			this.Title.Location = new global::System.Drawing.Point(200, 0);
			this.Title.Name = "Title";
			this.Title.PressedColor = global::System.Drawing.Color.Transparent;
			this.Title.PressedDepth = 0;
			this.Title.ShadowDecoration.Parent = this.Title;
			this.Title.Size = new global::System.Drawing.Size(700, 100);
			this.Title.TabIndex = 1;
			this.Title.Text = "Home";
			this.Title.UseTransparentBackground = true;
			this.Title.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
			this.Tabs.Alignment = global::System.Windows.Forms.TabAlignment.Left;
			this.Tabs.Controls.Add(this.HomeTab);
			this.Tabs.Controls.Add(this.SettingsTab);
			this.Tabs.Controls.Add(this.AppearanceTab);
			this.Tabs.Controls.Add(this.NewsfeedTab);
			this.Tabs.Controls.Add(this.ManagerTab);
			this.Animation.SetDecoration(this.Tabs, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.Tabs.ItemSize = new global::System.Drawing.Size(200, 40);
			this.Tabs.Location = new global::System.Drawing.Point(0, 100);
			this.Tabs.Name = "Tabs";
			this.Tabs.SelectedIndex = 0;
			this.Tabs.Size = new global::System.Drawing.Size(900, 450);
			this.Tabs.TabButtonHoverState.BorderColor = global::System.Drawing.Color.Empty;
			this.Tabs.TabButtonHoverState.FillColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.Tabs.TabButtonHoverState.Font = new global::System.Drawing.Font("Segoe UI Semibold", 10f);
			this.Tabs.TabButtonHoverState.ForeColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.Tabs.TabButtonHoverState.InnerColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.Tabs.TabButtonIdleState.BorderColor = global::System.Drawing.Color.Empty;
			this.Tabs.TabButtonIdleState.FillColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.Tabs.TabButtonIdleState.Font = new global::System.Drawing.Font("Segoe UI Semibold", 10f);
			this.Tabs.TabButtonIdleState.ForeColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.Tabs.TabButtonIdleState.InnerColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.Tabs.TabButtonSelectedState.BorderColor = global::System.Drawing.Color.Empty;
			this.Tabs.TabButtonSelectedState.FillColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.Tabs.TabButtonSelectedState.Font = new global::System.Drawing.Font("Segoe UI Semibold", 10f);
			this.Tabs.TabButtonSelectedState.ForeColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.Tabs.TabButtonSelectedState.InnerColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.Tabs.TabButtonSize = new global::System.Drawing.Size(200, 40);
			this.Tabs.TabIndex = 2;
			this.Tabs.TabMenuBackColor = global::System.Drawing.Color.Transparent;
			this.HomeTab.BackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.HomeTab.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.HomeTab.Controls.Add(this.StatusText);
			this.HomeTab.Controls.Add(this.SelectDLLButton);
			this.HomeTab.Controls.Add(this.SelectDLLShadow);
			this.HomeTab.Controls.Add(this.LaunchBtn);
			this.HomeTab.Controls.Add(this.LaunchShadow);
			this.HomeTab.Controls.Add(this.LaunchNewsPanel);
			this.HomeTab.Controls.Add(this.LaunchNewsShadow);
			this.Animation.SetDecoration(this.HomeTab, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.HomeTab.ForeColor = global::System.Drawing.Color.White;
			this.HomeTab.Location = new global::System.Drawing.Point(204, 4);
			this.HomeTab.Name = "HomeTab";
			this.HomeTab.Padding = new global::System.Windows.Forms.Padding(3);
			this.HomeTab.Size = new global::System.Drawing.Size(692, 442);
			this.HomeTab.TabIndex = 0;
			this.HomeTab.Text = "Home";
			this.StatusText.BackColor = global::System.Drawing.Color.Red;
			this.Animation.SetDecoration(this.StatusText, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.StatusText.Font = new global::System.Drawing.Font("Montserrat ExtraBold", 9.749999f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.StatusText.Location = new global::System.Drawing.Point(241, 364);
			this.StatusText.Name = "StatusText";
			this.StatusText.Size = new global::System.Drawing.Size(305, 18);
			this.StatusText.TabIndex = 9;
			this.StatusText.Text = "Launch status will appear here.";
			this.StatusText.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.StatusText.Click += new global::System.EventHandler(this.StatusText_Click);
			this.SelectDLLButton.Animated = true;
			this.SelectDLLButton.CheckedState.Parent = this.SelectDLLButton;
			this.SelectDLLButton.CustomImages.Parent = this.SelectDLLButton;
			this.Animation.SetDecoration(this.SelectDLLButton, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.SelectDLLButton.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.SelectDLLButton.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.SelectDLLButton.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.SelectDLLButton.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.SelectDLLButton.DisabledState.Parent = this.SelectDLLButton;
			this.SelectDLLButton.FillColor = global::System.Drawing.Color.Red;
			this.SelectDLLButton.Font = new global::System.Drawing.Font("Montserrat Black", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.SelectDLLButton.ForeColor = global::System.Drawing.Color.White;
			this.SelectDLLButton.HoverState.Parent = this.SelectDLLButton;
			this.SelectDLLButton.Location = new global::System.Drawing.Point(146, 316);
			this.SelectDLLButton.Name = "SelectDLLButton";
			this.SelectDLLButton.ShadowDecoration.Parent = this.SelectDLLButton;
			this.SelectDLLButton.Size = new global::System.Drawing.Size(80, 80);
			this.SelectDLLButton.TabIndex = 3;
			this.SelectDLLButton.Text = "DLL";
			this.SelectDLLButton.Click += new global::System.EventHandler(this.SelectDLLButton_Click);
			this.SelectDLLShadow.BackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.Animation.SetDecoration(this.SelectDLLShadow, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.SelectDLLShadow.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.SelectDLLShadow.Location = new global::System.Drawing.Point(151, 321);
			this.SelectDLLShadow.Name = "SelectDLLShadow";
			this.SelectDLLShadow.ShadowDecoration.Parent = this.SelectDLLShadow;
			this.SelectDLLShadow.Size = new global::System.Drawing.Size(80, 80);
			this.SelectDLLShadow.TabIndex = 3;
			this.LaunchBtn.Animated = true;
			this.LaunchBtn.CheckedState.Parent = this.LaunchBtn;
			this.LaunchBtn.CustomImages.Parent = this.LaunchBtn;
			this.Animation.SetDecoration(this.LaunchBtn, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.LaunchBtn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.LaunchBtn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.LaunchBtn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.LaunchBtn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.LaunchBtn.DisabledState.Parent = this.LaunchBtn;
			this.LaunchBtn.FillColor = global::System.Drawing.Color.Red;
			this.LaunchBtn.Font = new global::System.Drawing.Font("Montserrat Black", 20.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LaunchBtn.ForeColor = global::System.Drawing.Color.White;
			this.LaunchBtn.HoverState.Parent = this.LaunchBtn;
			this.LaunchBtn.Location = new global::System.Drawing.Point(241, 316);
			this.LaunchBtn.Name = "LaunchBtn";
			this.LaunchBtn.ShadowDecoration.Parent = this.LaunchBtn;
			this.LaunchBtn.Size = new global::System.Drawing.Size(305, 80);
			this.LaunchBtn.TabIndex = 2;
			this.LaunchBtn.Text = "Launch Minecraft";
			this.LaunchBtn.TextOffset = new global::System.Drawing.Point(0, -10);
			this.LaunchBtn.Click += new global::System.EventHandler(this.LaunchBtn_Click);
			this.LaunchShadow.BackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.Animation.SetDecoration(this.LaunchShadow, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.LaunchShadow.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.LaunchShadow.Location = new global::System.Drawing.Point(246, 321);
			this.LaunchShadow.Name = "LaunchShadow";
			this.LaunchShadow.ShadowDecoration.Parent = this.LaunchShadow;
			this.LaunchShadow.Size = new global::System.Drawing.Size(305, 80);
			this.LaunchShadow.TabIndex = 2;
			this.LaunchNewsPanel.BackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.LaunchNewsPanel.Controls.Add(this.NewsText);
			this.LaunchNewsPanel.Controls.Add(this.NewsTitle);
			this.Animation.SetDecoration(this.LaunchNewsPanel, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.LaunchNewsPanel.FillColor = global::System.Drawing.Color.FromArgb(25, 24, 26);
			this.LaunchNewsPanel.Location = new global::System.Drawing.Point(146, 50);
			this.LaunchNewsPanel.Name = "LaunchNewsPanel";
			this.LaunchNewsPanel.ShadowDecoration.Parent = this.LaunchNewsPanel;
			this.LaunchNewsPanel.Size = new global::System.Drawing.Size(400, 250);
			this.LaunchNewsPanel.TabIndex = 0;
			this.NewsText.BackColor = global::System.Drawing.Color.Transparent;
			this.Animation.SetDecoration(this.NewsText, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.NewsText.Font = new global::System.Drawing.Font("Montserrat ExtraBold", 9.749999f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.NewsText.Location = new global::System.Drawing.Point(0, 53);
			this.NewsText.Name = "NewsText";
			this.NewsText.Size = new global::System.Drawing.Size(400, 187);
			this.NewsText.TabIndex = 1;
			this.NewsText.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.NewsTitle.BackColor = global::System.Drawing.Color.Transparent;
			this.Animation.SetDecoration(this.NewsTitle, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.NewsTitle.Font = new global::System.Drawing.Font("Montserrat Black", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.NewsTitle.Location = new global::System.Drawing.Point(0, 5);
			this.NewsTitle.Name = "NewsTitle";
			this.NewsTitle.Size = new global::System.Drawing.Size(400, 40);
			this.NewsTitle.TabIndex = 0;
			this.NewsTitle.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.LaunchNewsShadow.BackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.Animation.SetDecoration(this.LaunchNewsShadow, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.LaunchNewsShadow.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.LaunchNewsShadow.Location = new global::System.Drawing.Point(151, 55);
			this.LaunchNewsShadow.Name = "LaunchNewsShadow";
			this.LaunchNewsShadow.ShadowDecoration.Parent = this.LaunchNewsShadow;
			this.LaunchNewsShadow.Size = new global::System.Drawing.Size(400, 250);
			this.LaunchNewsShadow.TabIndex = 1;
			this.SettingsTab.BackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.SettingsTab.Controls.Add(this.ManagerButton);
			this.SettingsTab.Controls.Add(this.ManagerShadow);
			this.SettingsTab.Controls.Add(this.ManagerDescription);
			this.SettingsTab.Controls.Add(this.ManagerTitle);
			this.SettingsTab.Controls.Add(this.RestartDescription);
			this.SettingsTab.Controls.Add(this.RestartTitle);
			this.SettingsTab.Controls.Add(this.RestartButton);
			this.SettingsTab.Controls.Add(this.RestartShadow);
			this.SettingsTab.Controls.Add(this.ResetBtn);
			this.SettingsTab.Controls.Add(this.ResetShadow);
			this.SettingsTab.Controls.Add(this.ResetDescription);
			this.SettingsTab.Controls.Add(this.ResetTitle);
			this.SettingsTab.Controls.Add(this.PriorityComboBox);
			this.SettingsTab.Controls.Add(this.PriorityDescription);
			this.SettingsTab.Controls.Add(this.PriorityTitle);
			this.SettingsTab.Controls.Add(this.DontInjectCheckBox);
			this.SettingsTab.Controls.Add(this.DelayTrackBar);
			this.SettingsTab.Controls.Add(this.DelayDescription);
			this.SettingsTab.Controls.Add(this.DelayTitle);
			this.SettingsTab.Controls.Add(this.LaunchComboBox);
			this.SettingsTab.Controls.Add(this.LaunchDescription);
			this.SettingsTab.Controls.Add(this.LaunchSettingsLabel);
			this.Animation.SetDecoration(this.SettingsTab, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.SettingsTab.Location = new global::System.Drawing.Point(204, 4);
			this.SettingsTab.Name = "SettingsTab";
			this.SettingsTab.Padding = new global::System.Windows.Forms.Padding(3);
			this.SettingsTab.Size = new global::System.Drawing.Size(692, 442);
			this.SettingsTab.TabIndex = 1;
			this.SettingsTab.Text = "Settings";
			this.ManagerButton.Animated = true;
			this.ManagerButton.CheckedState.Parent = this.ManagerButton;
			this.ManagerButton.CustomImages.Parent = this.ManagerButton;
			this.Animation.SetDecoration(this.ManagerButton, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.ManagerButton.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.ManagerButton.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.ManagerButton.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.ManagerButton.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.ManagerButton.DisabledState.Parent = this.ManagerButton;
			this.ManagerButton.FillColor = global::System.Drawing.Color.Red;
			this.ManagerButton.Font = new global::System.Drawing.Font("Montserrat Black", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ManagerButton.ForeColor = global::System.Drawing.Color.White;
			this.ManagerButton.HoverState.Parent = this.ManagerButton;
			this.ManagerButton.Location = new global::System.Drawing.Point(265, 360);
			this.ManagerButton.Name = "ManagerButton";
			this.ManagerButton.ShadowDecoration.Parent = this.ManagerButton;
			this.ManagerButton.Size = new global::System.Drawing.Size(162, 36);
			this.ManagerButton.TabIndex = 36;
			this.ManagerButton.Text = "Open";
			this.ManagerButton.Click += new global::System.EventHandler(this.ManagerButton_Click);
			this.Animation.SetDecoration(this.ManagerShadow, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.ManagerShadow.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.ManagerShadow.ImageRotate = 0f;
			this.ManagerShadow.Location = new global::System.Drawing.Point(270, 365);
			this.ManagerShadow.Name = "ManagerShadow";
			this.ManagerShadow.ShadowDecoration.Parent = this.ManagerShadow;
			this.ManagerShadow.Size = new global::System.Drawing.Size(162, 36);
			this.ManagerShadow.TabIndex = 35;
			this.ManagerShadow.TabStop = false;
			this.Animation.SetDecoration(this.ManagerDescription, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.ManagerDescription.Font = new global::System.Drawing.Font("Montserrat ExtraBold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ManagerDescription.Location = new global::System.Drawing.Point(258, 249);
			this.ManagerDescription.Name = "ManagerDescription";
			this.ManagerDescription.Size = new global::System.Drawing.Size(177, 102);
			this.ManagerDescription.TabIndex = 34;
			this.ManagerDescription.Text = "Save the texture packs you have applied so you can use them later.";
			this.ManagerDescription.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ManagerTitle.AutoSize = true;
			this.Animation.SetDecoration(this.ManagerTitle, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.ManagerTitle.Font = new global::System.Drawing.Font("Montserrat Black", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ManagerTitle.Location = new global::System.Drawing.Point(263, 222);
			this.ManagerTitle.Name = "ManagerTitle";
			this.ManagerTitle.Size = new global::System.Drawing.Size(166, 29);
			this.ManagerTitle.TabIndex = 33;
			this.ManagerTitle.Text = "Pack Profiles";
			this.ManagerTitle.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.Animation.SetDecoration(this.RestartDescription, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.RestartDescription.Font = new global::System.Drawing.Font("Montserrat ExtraBold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.RestartDescription.Location = new global::System.Drawing.Point(475, 278);
			this.RestartDescription.Name = "RestartDescription";
			this.RestartDescription.Size = new global::System.Drawing.Size(189, 71);
			this.RestartDescription.TabIndex = 32;
			this.RestartDescription.Text = "Close and reopen the launcher to fix most problems.";
			this.RestartDescription.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.RestartTitle.AutoSize = true;
			this.Animation.SetDecoration(this.RestartTitle, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.RestartTitle.Font = new global::System.Drawing.Font("Montserrat Black", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.RestartTitle.Location = new global::System.Drawing.Point(491, 243);
			this.RestartTitle.Name = "RestartTitle";
			this.RestartTitle.Size = new global::System.Drawing.Size(157, 29);
			this.RestartTitle.TabIndex = 31;
			this.RestartTitle.Text = "Restart Jiayi";
			this.RestartTitle.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.RestartButton.Animated = true;
			this.RestartButton.CheckedState.Parent = this.RestartButton;
			this.RestartButton.CustomImages.Parent = this.RestartButton;
			this.Animation.SetDecoration(this.RestartButton, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.RestartButton.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.RestartButton.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.RestartButton.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.RestartButton.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.RestartButton.DisabledState.Parent = this.RestartButton;
			this.RestartButton.FillColor = global::System.Drawing.Color.Red;
			this.RestartButton.Font = new global::System.Drawing.Font("Montserrat Black", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.RestartButton.ForeColor = global::System.Drawing.Color.White;
			this.RestartButton.HoverState.Parent = this.RestartButton;
			this.RestartButton.Location = new global::System.Drawing.Point(488, 360);
			this.RestartButton.Name = "RestartButton";
			this.RestartButton.ShadowDecoration.Parent = this.RestartButton;
			this.RestartButton.Size = new global::System.Drawing.Size(162, 36);
			this.RestartButton.TabIndex = 24;
			this.RestartButton.Text = "Restart";
			this.RestartButton.Click += new global::System.EventHandler(this.RestartButton_Click);
			this.Animation.SetDecoration(this.RestartShadow, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.RestartShadow.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.RestartShadow.ImageRotate = 0f;
			this.RestartShadow.Location = new global::System.Drawing.Point(493, 365);
			this.RestartShadow.Name = "RestartShadow";
			this.RestartShadow.ShadowDecoration.Parent = this.RestartShadow;
			this.RestartShadow.Size = new global::System.Drawing.Size(162, 36);
			this.RestartShadow.TabIndex = 23;
			this.RestartShadow.TabStop = false;
			this.ResetBtn.Animated = true;
			this.ResetBtn.CheckedState.Parent = this.ResetBtn;
			this.ResetBtn.CustomImages.Parent = this.ResetBtn;
			this.Animation.SetDecoration(this.ResetBtn, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.ResetBtn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.ResetBtn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.ResetBtn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.ResetBtn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.ResetBtn.DisabledState.Parent = this.ResetBtn;
			this.ResetBtn.FillColor = global::System.Drawing.Color.Red;
			this.ResetBtn.Font = new global::System.Drawing.Font("Montserrat Black", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ResetBtn.ForeColor = global::System.Drawing.Color.White;
			this.ResetBtn.HoverState.Parent = this.ResetBtn;
			this.ResetBtn.Location = new global::System.Drawing.Point(488, 178);
			this.ResetBtn.Name = "ResetBtn";
			this.ResetBtn.ShadowDecoration.Parent = this.ResetBtn;
			this.ResetBtn.Size = new global::System.Drawing.Size(162, 36);
			this.ResetBtn.TabIndex = 20;
			this.ResetBtn.Text = "Reset";
			this.ResetBtn.Click += new global::System.EventHandler(this.ResetBtn_Click);
			this.Animation.SetDecoration(this.ResetShadow, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.ResetShadow.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.ResetShadow.ImageRotate = 0f;
			this.ResetShadow.Location = new global::System.Drawing.Point(493, 183);
			this.ResetShadow.Name = "ResetShadow";
			this.ResetShadow.ShadowDecoration.Parent = this.ResetShadow;
			this.ResetShadow.Size = new global::System.Drawing.Size(162, 36);
			this.ResetShadow.TabIndex = 9;
			this.ResetShadow.TabStop = false;
			this.Animation.SetDecoration(this.ResetDescription, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.ResetDescription.Font = new global::System.Drawing.Font("Montserrat ExtraBold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ResetDescription.Location = new global::System.Drawing.Point(481, 69);
			this.ResetDescription.Name = "ResetDescription";
			this.ResetDescription.Size = new global::System.Drawing.Size(177, 97);
			this.ResetDescription.TabIndex = 19;
			this.ResetDescription.Text = "Restores the default settings. Includes current appearance.";
			this.ResetDescription.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ResetTitle.AutoSize = true;
			this.Animation.SetDecoration(this.ResetTitle, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.ResetTitle.Font = new global::System.Drawing.Font("Montserrat Black", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ResetTitle.Location = new global::System.Drawing.Point(473, 40);
			this.ResetTitle.Name = "ResetTitle";
			this.ResetTitle.Size = new global::System.Drawing.Size(193, 29);
			this.ResetTitle.TabIndex = 18;
			this.ResetTitle.Text = "Reset Launcher";
			this.ResetTitle.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.PriorityComboBox.BackColor = global::System.Drawing.Color.Transparent;
			this.PriorityComboBox.BorderColor = global::System.Drawing.Color.Red;
			this.PriorityComboBox.BorderThickness = 0;
			this.Animation.SetDecoration(this.PriorityComboBox, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.PriorityComboBox.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.PriorityComboBox.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PriorityComboBox.FillColor = global::System.Drawing.Color.FromArgb(25, 24, 26);
			this.PriorityComboBox.FocusedColor = global::System.Drawing.Color.Red;
			this.PriorityComboBox.FocusedState.BorderColor = global::System.Drawing.Color.Red;
			this.PriorityComboBox.FocusedState.Parent = this.PriorityComboBox;
			this.PriorityComboBox.Font = new global::System.Drawing.Font("Montserrat ExtraBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.PriorityComboBox.ForeColor = global::System.Drawing.Color.White;
			this.PriorityComboBox.HoverState.Parent = this.PriorityComboBox;
			this.PriorityComboBox.ItemHeight = 30;
			this.PriorityComboBox.Items.AddRange(new object[]
			{
				"High",
				"Normal",
				"Low"
			});
			this.PriorityComboBox.ItemsAppearance.ForeColor = global::System.Drawing.Color.White;
			this.PriorityComboBox.ItemsAppearance.Parent = this.PriorityComboBox;
			this.PriorityComboBox.Location = new global::System.Drawing.Point(265, 155);
			this.PriorityComboBox.Name = "PriorityComboBox";
			this.PriorityComboBox.ShadowDecoration.Depth = 1;
			this.PriorityComboBox.ShadowDecoration.Parent = this.PriorityComboBox;
			this.PriorityComboBox.Size = new global::System.Drawing.Size(162, 36);
			this.PriorityComboBox.Style = global::Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.PriorityComboBox.TabIndex = 17;
			this.PriorityComboBox.SelectedIndexChanged += new global::System.EventHandler(this.PriorityComboBox_SelectedIndexChanged);
			this.Animation.SetDecoration(this.PriorityDescription, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.PriorityDescription.Font = new global::System.Drawing.Font("Montserrat ExtraBold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.PriorityDescription.Location = new global::System.Drawing.Point(240, 69);
			this.PriorityDescription.Name = "PriorityDescription";
			this.PriorityDescription.Size = new global::System.Drawing.Size(213, 83);
			this.PriorityDescription.TabIndex = 15;
			this.PriorityDescription.Text = "Raising Minecraft's process priority can (slightly!) increase FPS.";
			this.PriorityDescription.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.PriorityTitle.AutoSize = true;
			this.Animation.SetDecoration(this.PriorityTitle, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.PriorityTitle.Font = new global::System.Drawing.Font("Montserrat Black", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.PriorityTitle.Location = new global::System.Drawing.Point(247, 40);
			this.PriorityTitle.Name = "PriorityTitle";
			this.PriorityTitle.Size = new global::System.Drawing.Size(198, 29);
			this.PriorityTitle.TabIndex = 16;
			this.PriorityTitle.Text = "Process Priority";
			this.PriorityTitle.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.DontInjectCheckBox.Animated = true;
			this.DontInjectCheckBox.CheckedState.BorderColor = global::System.Drawing.Color.Red;
			this.DontInjectCheckBox.CheckedState.BorderRadius = 0;
			this.DontInjectCheckBox.CheckedState.BorderThickness = 0;
			this.DontInjectCheckBox.CheckedState.FillColor = global::System.Drawing.Color.Red;
			this.Animation.SetDecoration(this.DontInjectCheckBox, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.DontInjectCheckBox.Font = new global::System.Drawing.Font("Montserrat Black", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.DontInjectCheckBox.Location = new global::System.Drawing.Point(45, 366);
			this.DontInjectCheckBox.Name = "DontInjectCheckBox";
			this.DontInjectCheckBox.Size = new global::System.Drawing.Size(169, 30);
			this.DontInjectCheckBox.TabIndex = 14;
			this.DontInjectCheckBox.Text = "Don't Inject";
			this.DontInjectCheckBox.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.DontInjectCheckBox.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(25, 24, 26);
			this.DontInjectCheckBox.UncheckedState.BorderRadius = 0;
			this.DontInjectCheckBox.UncheckedState.BorderThickness = 0;
			this.DontInjectCheckBox.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(25, 24, 26);
			this.DontInjectCheckBox.CheckedChanged += new global::System.EventHandler(this.DontInjectCheckBox_CheckedChanged);
			this.Animation.SetDecoration(this.DelayTrackBar, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.DelayTrackBar.FillColor = global::System.Drawing.Color.FromArgb(25, 24, 26);
			this.DelayTrackBar.HoverState.Parent = this.DelayTrackBar;
			this.DelayTrackBar.Location = new global::System.Drawing.Point(31, 337);
			this.DelayTrackBar.Maximum = 30;
			this.DelayTrackBar.Name = "DelayTrackBar";
			this.DelayTrackBar.Size = new global::System.Drawing.Size(181, 23);
			this.DelayTrackBar.Style = global::Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
			this.DelayTrackBar.TabIndex = 13;
			this.DelayTrackBar.ThumbColor = global::System.Drawing.Color.Red;
			this.DelayTrackBar.Value = 15;
			this.DelayTrackBar.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.DelayTrackBar_Scroll);
			this.Animation.SetDecoration(this.DelayDescription, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.DelayDescription.Font = new global::System.Drawing.Font("Montserrat ExtraBold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.DelayDescription.Location = new global::System.Drawing.Point(37, 238);
			this.DelayDescription.Name = "DelayDescription";
			this.DelayDescription.Size = new global::System.Drawing.Size(168, 93);
			this.DelayDescription.TabIndex = 12;
			this.DelayDescription.Text = "Set how long the launcher waits before injecting. (0-30 seconds)";
			this.DelayDescription.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.DelayTitle.AutoSize = true;
			this.Animation.SetDecoration(this.DelayTitle, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.DelayTitle.Font = new global::System.Drawing.Font("Montserrat Black", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.DelayTitle.Location = new global::System.Drawing.Point(28, 203);
			this.DelayTitle.Name = "DelayTitle";
			this.DelayTitle.Size = new global::System.Drawing.Size(186, 29);
			this.DelayTitle.TabIndex = 11;
			this.DelayTitle.Text = "Injection Delay";
			this.DelayTitle.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.LaunchComboBox.BackColor = global::System.Drawing.Color.Transparent;
			this.LaunchComboBox.BorderColor = global::System.Drawing.Color.Red;
			this.LaunchComboBox.BorderThickness = 0;
			this.Animation.SetDecoration(this.LaunchComboBox, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.LaunchComboBox.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.LaunchComboBox.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.LaunchComboBox.FillColor = global::System.Drawing.Color.FromArgb(25, 24, 26);
			this.LaunchComboBox.FocusedColor = global::System.Drawing.Color.Red;
			this.LaunchComboBox.FocusedState.BorderColor = global::System.Drawing.Color.Red;
			this.LaunchComboBox.FocusedState.Parent = this.LaunchComboBox;
			this.LaunchComboBox.Font = new global::System.Drawing.Font("Montserrat ExtraBold", 11.25f, global::System.Drawing.FontStyle.Bold);
			this.LaunchComboBox.ForeColor = global::System.Drawing.Color.White;
			this.LaunchComboBox.HoverState.Parent = this.LaunchComboBox;
			this.LaunchComboBox.ItemHeight = 30;
			this.LaunchComboBox.Items.AddRange(new object[]
			{
				"Close",
				"Hide",
				"Keep Open"
			});
			this.LaunchComboBox.ItemsAppearance.ForeColor = global::System.Drawing.Color.White;
			this.LaunchComboBox.ItemsAppearance.Parent = this.LaunchComboBox;
			this.LaunchComboBox.Location = new global::System.Drawing.Point(40, 132);
			this.LaunchComboBox.Name = "LaunchComboBox";
			this.LaunchComboBox.ShadowDecoration.Depth = 1;
			this.LaunchComboBox.ShadowDecoration.Parent = this.LaunchComboBox;
			this.LaunchComboBox.Size = new global::System.Drawing.Size(162, 36);
			this.LaunchComboBox.Style = global::Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.LaunchComboBox.TabIndex = 10;
			this.LaunchComboBox.SelectedIndexChanged += new global::System.EventHandler(this.LaunchComboBox_SelectedIndexChanged);
			this.Animation.SetDecoration(this.LaunchDescription, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.LaunchDescription.Font = new global::System.Drawing.Font("Montserrat ExtraBold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LaunchDescription.Location = new global::System.Drawing.Point(37, 69);
			this.LaunchDescription.Name = "LaunchDescription";
			this.LaunchDescription.Size = new global::System.Drawing.Size(168, 60);
			this.LaunchDescription.TabIndex = 9;
			this.LaunchDescription.Text = "Choose what Jiayi does after launch.";
			this.LaunchDescription.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.LaunchSettingsLabel.AutoSize = true;
			this.Animation.SetDecoration(this.LaunchSettingsLabel, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.LaunchSettingsLabel.Font = new global::System.Drawing.Font("Montserrat Black", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LaunchSettingsLabel.Location = new global::System.Drawing.Point(40, 40);
			this.LaunchSettingsLabel.Name = "LaunchSettingsLabel";
			this.LaunchSettingsLabel.Size = new global::System.Drawing.Size(163, 29);
			this.LaunchSettingsLabel.TabIndex = 9;
			this.LaunchSettingsLabel.Text = "After Launch";
			this.LaunchSettingsLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.AppearanceTab.BackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.AppearanceTab.Controls.Add(this.ThemesSoon);
			this.AppearanceTab.Controls.Add(this.ThemesCover);
			this.AppearanceTab.Controls.Add(this.ThemesLabel);
			this.AppearanceTab.Controls.Add(this.RGBDescription);
			this.AppearanceTab.Controls.Add(this.RGBCheckBox);
			this.AppearanceTab.Controls.Add(this.RGBTrackBar);
			this.AppearanceTab.Controls.Add(this.SelectBackgroundBtn);
			this.AppearanceTab.Controls.Add(this.SelectBackgroundShadow);
			this.AppearanceTab.Controls.Add(this.BackgroundTitle);
			this.AppearanceTab.Controls.Add(this.ColorPickerBtn);
			this.AppearanceTab.Controls.Add(this.ColorPickerShadow);
			this.AppearanceTab.Controls.Add(this.BackgroundComboBox);
			this.AppearanceTab.Controls.Add(this.ColorCodeLabel);
			this.AppearanceTab.Controls.Add(this.ColorTitle);
			this.Animation.SetDecoration(this.AppearanceTab, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.AppearanceTab.ForeColor = global::System.Drawing.Color.Transparent;
			this.AppearanceTab.Location = new global::System.Drawing.Point(204, 4);
			this.AppearanceTab.Name = "AppearanceTab";
			this.AppearanceTab.Padding = new global::System.Windows.Forms.Padding(3);
			this.AppearanceTab.Size = new global::System.Drawing.Size(692, 442);
			this.AppearanceTab.TabIndex = 3;
			this.AppearanceTab.Text = "Appearance";
			this.ThemesSoon.AutoSize = true;
			this.ThemesSoon.BackColor = global::System.Drawing.Color.Transparent;
			this.Animation.SetDecoration(this.ThemesSoon, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.ThemesSoon.Font = new global::System.Drawing.Font("Montserrat Black", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ThemesSoon.ForeColor = global::System.Drawing.Color.White;
			this.ThemesSoon.Location = new global::System.Drawing.Point(218, 280);
			this.ThemesSoon.Name = "ThemesSoon";
			this.ThemesSoon.Size = new global::System.Drawing.Size(254, 29);
			this.ThemesSoon.TabIndex = 34;
			this.ThemesSoon.Text = "They'll be back soon!";
			this.ThemesSoon.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ThemesCover.BackColor = global::System.Drawing.Color.Transparent;
			this.Animation.SetDecoration(this.ThemesCover, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.ThemesCover.FillColor = global::System.Drawing.Color.Transparent;
			this.ThemesCover.ImageRotate = 0f;
			this.ThemesCover.Location = new global::System.Drawing.Point(40, 184);
			this.ThemesCover.Name = "ThemesCover";
			this.ThemesCover.ShadowDecoration.BorderRadius = 0;
			this.ThemesCover.ShadowDecoration.Color = global::System.Drawing.Color.Gray;
			this.ThemesCover.ShadowDecoration.CustomizableEdges.BottomLeft = false;
			this.ThemesCover.ShadowDecoration.Depth = 10;
			this.ThemesCover.ShadowDecoration.Enabled = true;
			this.ThemesCover.ShadowDecoration.Parent = this.ThemesCover;
			this.ThemesCover.Size = new global::System.Drawing.Size(610, 220);
			this.ThemesCover.TabIndex = 33;
			this.ThemesCover.TabStop = false;
			this.ThemesCover.UseTransparentBackground = true;
			this.ThemesLabel.AutoSize = true;
			this.ThemesLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.Animation.SetDecoration(this.ThemesLabel, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.ThemesLabel.Font = new global::System.Drawing.Font("Montserrat Black", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ThemesLabel.ForeColor = global::System.Drawing.Color.Gray;
			this.ThemesLabel.Location = new global::System.Drawing.Point(289, 191);
			this.ThemesLabel.Name = "ThemesLabel";
			this.ThemesLabel.Size = new global::System.Drawing.Size(104, 29);
			this.ThemesLabel.TabIndex = 32;
			this.ThemesLabel.Text = "Themes";
			this.ThemesLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.Animation.SetDecoration(this.RGBDescription, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.RGBDescription.Font = new global::System.Drawing.Font("Montserrat ExtraBold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.RGBDescription.Location = new global::System.Drawing.Point(470, 72);
			this.RGBDescription.Name = "RGBDescription";
			this.RGBDescription.Size = new global::System.Drawing.Size(181, 69);
			this.RGBDescription.TabIndex = 31;
			this.RGBDescription.Text = "Set your RGB speed from 1-100 milliseconds.";
			this.RGBDescription.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.RGBCheckBox.Animated = true;
			this.RGBCheckBox.CheckedState.BorderColor = global::System.Drawing.Color.Red;
			this.RGBCheckBox.CheckedState.BorderRadius = 0;
			this.RGBCheckBox.CheckedState.BorderThickness = 0;
			this.RGBCheckBox.CheckedState.FillColor = global::System.Drawing.Color.Red;
			this.Animation.SetDecoration(this.RGBCheckBox, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.RGBCheckBox.Font = new global::System.Drawing.Font("Montserrat Black", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.RGBCheckBox.ForeColor = global::System.Drawing.Color.White;
			this.RGBCheckBox.Location = new global::System.Drawing.Point(523, 39);
			this.RGBCheckBox.Name = "RGBCheckBox";
			this.RGBCheckBox.Size = new global::System.Drawing.Size(80, 30);
			this.RGBCheckBox.TabIndex = 30;
			this.RGBCheckBox.Text = "RGB";
			this.RGBCheckBox.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.RGBCheckBox.UncheckedState.BorderColor = global::System.Drawing.Color.FromArgb(25, 24, 26);
			this.RGBCheckBox.UncheckedState.BorderRadius = 0;
			this.RGBCheckBox.UncheckedState.BorderThickness = 0;
			this.RGBCheckBox.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(25, 24, 26);
			this.RGBCheckBox.CheckedChanged += new global::System.EventHandler(this.RGBCheckBox_CheckedChanged);
			this.Animation.SetDecoration(this.RGBTrackBar, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.RGBTrackBar.Enabled = false;
			this.RGBTrackBar.FillColor = global::System.Drawing.Color.FromArgb(25, 24, 26);
			this.RGBTrackBar.HoverState.Parent = this.RGBTrackBar;
			this.RGBTrackBar.Location = new global::System.Drawing.Point(470, 144);
			this.RGBTrackBar.Minimum = 1;
			this.RGBTrackBar.Name = "RGBTrackBar";
			this.RGBTrackBar.Size = new global::System.Drawing.Size(181, 23);
			this.RGBTrackBar.Style = global::Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
			this.RGBTrackBar.TabIndex = 29;
			this.RGBTrackBar.ThumbColor = global::System.Drawing.Color.Red;
			this.SelectBackgroundBtn.Animated = true;
			this.SelectBackgroundBtn.CheckedState.Parent = this.SelectBackgroundBtn;
			this.SelectBackgroundBtn.CustomImages.Parent = this.SelectBackgroundBtn;
			this.Animation.SetDecoration(this.SelectBackgroundBtn, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.SelectBackgroundBtn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.SelectBackgroundBtn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.SelectBackgroundBtn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.SelectBackgroundBtn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.SelectBackgroundBtn.DisabledState.Parent = this.SelectBackgroundBtn;
			this.SelectBackgroundBtn.FillColor = global::System.Drawing.Color.Red;
			this.SelectBackgroundBtn.Font = new global::System.Drawing.Font("Montserrat Black", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.SelectBackgroundBtn.ForeColor = global::System.Drawing.Color.White;
			this.SelectBackgroundBtn.HoverState.Parent = this.SelectBackgroundBtn;
			this.SelectBackgroundBtn.Location = new global::System.Drawing.Point(260, 131);
			this.SelectBackgroundBtn.Name = "SelectBackgroundBtn";
			this.SelectBackgroundBtn.ShadowDecoration.Parent = this.SelectBackgroundBtn;
			this.SelectBackgroundBtn.Size = new global::System.Drawing.Size(162, 36);
			this.SelectBackgroundBtn.TabIndex = 28;
			this.SelectBackgroundBtn.Text = "Select";
			this.SelectBackgroundBtn.Click += new global::System.EventHandler(this.SelectBackgroundBtn_Click);
			this.Animation.SetDecoration(this.SelectBackgroundShadow, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.SelectBackgroundShadow.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.SelectBackgroundShadow.ImageRotate = 0f;
			this.SelectBackgroundShadow.Location = new global::System.Drawing.Point(265, 136);
			this.SelectBackgroundShadow.Name = "SelectBackgroundShadow";
			this.SelectBackgroundShadow.ShadowDecoration.Parent = this.SelectBackgroundShadow;
			this.SelectBackgroundShadow.Size = new global::System.Drawing.Size(162, 36);
			this.SelectBackgroundShadow.TabIndex = 27;
			this.SelectBackgroundShadow.TabStop = false;
			this.BackgroundTitle.AutoSize = true;
			this.Animation.SetDecoration(this.BackgroundTitle, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.BackgroundTitle.Font = new global::System.Drawing.Font("Montserrat Black", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.BackgroundTitle.Location = new global::System.Drawing.Point(265, 40);
			this.BackgroundTitle.Name = "BackgroundTitle";
			this.BackgroundTitle.Size = new global::System.Drawing.Size(153, 29);
			this.BackgroundTitle.TabIndex = 26;
			this.BackgroundTitle.Text = "Background";
			this.BackgroundTitle.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ColorPickerBtn.Animated = true;
			this.ColorPickerBtn.CheckedState.Parent = this.ColorPickerBtn;
			this.ColorPickerBtn.CustomImages.Parent = this.ColorPickerBtn;
			this.Animation.SetDecoration(this.ColorPickerBtn, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.ColorPickerBtn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.ColorPickerBtn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.ColorPickerBtn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.ColorPickerBtn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.ColorPickerBtn.DisabledState.Parent = this.ColorPickerBtn;
			this.ColorPickerBtn.FillColor = global::System.Drawing.Color.Red;
			this.ColorPickerBtn.Font = new global::System.Drawing.Font("Montserrat Black", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ColorPickerBtn.ForeColor = global::System.Drawing.Color.White;
			this.ColorPickerBtn.HoverState.Parent = this.ColorPickerBtn;
			this.ColorPickerBtn.Location = new global::System.Drawing.Point(40, 83);
			this.ColorPickerBtn.Name = "ColorPickerBtn";
			this.ColorPickerBtn.ShadowDecoration.Parent = this.ColorPickerBtn;
			this.ColorPickerBtn.Size = new global::System.Drawing.Size(40, 40);
			this.ColorPickerBtn.TabIndex = 25;
			this.ColorPickerBtn.Click += new global::System.EventHandler(this.ColorPickerBtn_Click);
			this.Animation.SetDecoration(this.ColorPickerShadow, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.ColorPickerShadow.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.ColorPickerShadow.ImageRotate = 0f;
			this.ColorPickerShadow.Location = new global::System.Drawing.Point(45, 88);
			this.ColorPickerShadow.Name = "ColorPickerShadow";
			this.ColorPickerShadow.ShadowDecoration.Parent = this.ColorPickerShadow;
			this.ColorPickerShadow.Size = new global::System.Drawing.Size(40, 40);
			this.ColorPickerShadow.TabIndex = 21;
			this.ColorPickerShadow.TabStop = false;
			this.BackgroundComboBox.BackColor = global::System.Drawing.Color.Transparent;
			this.BackgroundComboBox.BorderColor = global::System.Drawing.Color.Red;
			this.BackgroundComboBox.BorderThickness = 0;
			this.Animation.SetDecoration(this.BackgroundComboBox, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.BackgroundComboBox.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.BackgroundComboBox.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BackgroundComboBox.FillColor = global::System.Drawing.Color.FromArgb(25, 24, 26);
			this.BackgroundComboBox.FocusedColor = global::System.Drawing.Color.Red;
			this.BackgroundComboBox.FocusedState.BorderColor = global::System.Drawing.Color.Red;
			this.BackgroundComboBox.FocusedState.Parent = this.BackgroundComboBox;
			this.BackgroundComboBox.Font = new global::System.Drawing.Font("Montserrat ExtraBold", 11.25f, global::System.Drawing.FontStyle.Bold);
			this.BackgroundComboBox.ForeColor = global::System.Drawing.Color.White;
			this.BackgroundComboBox.HoverState.Parent = this.BackgroundComboBox;
			this.BackgroundComboBox.ItemHeight = 30;
			this.BackgroundComboBox.Items.AddRange(new object[]
			{
				"None",
				"Solid Color",
				"Image"
			});
			this.BackgroundComboBox.ItemsAppearance.ForeColor = global::System.Drawing.Color.White;
			this.BackgroundComboBox.ItemsAppearance.Parent = this.BackgroundComboBox;
			this.BackgroundComboBox.Location = new global::System.Drawing.Point(260, 83);
			this.BackgroundComboBox.Name = "BackgroundComboBox";
			this.BackgroundComboBox.ShadowDecoration.Depth = 1;
			this.BackgroundComboBox.ShadowDecoration.Parent = this.BackgroundComboBox;
			this.BackgroundComboBox.Size = new global::System.Drawing.Size(162, 36);
			this.BackgroundComboBox.Style = global::Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.BackgroundComboBox.TabIndex = 24;
			this.BackgroundComboBox.SelectedIndexChanged += new global::System.EventHandler(this.BackgroundComboBox_SelectedIndexChanged);
			this.Animation.SetDecoration(this.ColorCodeLabel, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.ColorCodeLabel.Font = new global::System.Drawing.Font("Montserrat ExtraBold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ColorCodeLabel.Location = new global::System.Drawing.Point(86, 83);
			this.ColorCodeLabel.Name = "ColorCodeLabel";
			this.ColorCodeLabel.Size = new global::System.Drawing.Size(116, 40);
			this.ColorCodeLabel.TabIndex = 22;
			this.ColorCodeLabel.Text = "255, 0, 0";
			this.ColorCodeLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.ColorTitle.AutoSize = true;
			this.Animation.SetDecoration(this.ColorTitle, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.ColorTitle.Font = new global::System.Drawing.Font("Montserrat Black", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ColorTitle.Location = new global::System.Drawing.Point(40, 40);
			this.ColorTitle.Name = "ColorTitle";
			this.ColorTitle.Size = new global::System.Drawing.Size(162, 29);
			this.ColorTitle.TabIndex = 23;
			this.ColorTitle.Text = "Accent Color";
			this.ColorTitle.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.NewsfeedTab.BackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.NewsfeedTab.Controls.Add(this.FeedData3);
			this.NewsfeedTab.Controls.Add(this.FeedPic3);
			this.NewsfeedTab.Controls.Add(this.FeedShadow3);
			this.NewsfeedTab.Controls.Add(this.FeedData2);
			this.NewsfeedTab.Controls.Add(this.FeedPic2);
			this.NewsfeedTab.Controls.Add(this.FeedShadow2);
			this.NewsfeedTab.Controls.Add(this.FeedData1);
			this.NewsfeedTab.Controls.Add(this.FeedPic1);
			this.NewsfeedTab.Controls.Add(this.FeedShadow1);
			this.Animation.SetDecoration(this.NewsfeedTab, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.NewsfeedTab.Location = new global::System.Drawing.Point(204, 4);
			this.NewsfeedTab.Name = "NewsfeedTab";
			this.NewsfeedTab.Padding = new global::System.Windows.Forms.Padding(3);
			this.NewsfeedTab.Size = new global::System.Drawing.Size(692, 442);
			this.NewsfeedTab.TabIndex = 2;
			this.NewsfeedTab.Text = "Newsfeed";
			this.FeedData3.BackColor = global::System.Drawing.Color.FromArgb(25, 24, 26);
			this.Animation.SetDecoration(this.FeedData3, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.FeedData3.Font = new global::System.Drawing.Font("Montserrat SemiBold", 8.249999f, global::System.Drawing.FontStyle.Bold);
			this.FeedData3.Location = new global::System.Drawing.Point(458, 251);
			this.FeedData3.Name = "FeedData3";
			this.FeedData3.Size = new global::System.Drawing.Size(200, 100);
			this.FeedData3.TabIndex = 16;
			this.FeedPic3.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.Animation.SetDecoration(this.FeedPic3, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.FeedPic3.FillColor = global::System.Drawing.Color.FromArgb(25, 24, 26);
			this.FeedPic3.ImageRotate = 0f;
			this.FeedPic3.Location = new global::System.Drawing.Point(458, 86);
			this.FeedPic3.Name = "FeedPic3";
			this.FeedPic3.ShadowDecoration.Parent = this.FeedPic3;
			this.FeedPic3.Size = new global::System.Drawing.Size(200, 165);
			this.FeedPic3.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.FeedPic3.TabIndex = 15;
			this.FeedPic3.TabStop = false;
			this.FeedShadow3.BackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.FeedShadow3.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.Animation.SetDecoration(this.FeedShadow3, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.FeedShadow3.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.FeedShadow3.ImageRotate = 0f;
			this.FeedShadow3.Location = new global::System.Drawing.Point(463, 91);
			this.FeedShadow3.Name = "FeedShadow3";
			this.FeedShadow3.ShadowDecoration.Parent = this.FeedShadow3;
			this.FeedShadow3.Size = new global::System.Drawing.Size(200, 265);
			this.FeedShadow3.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.FeedShadow3.TabIndex = 17;
			this.FeedShadow3.TabStop = false;
			this.FeedData2.BackColor = global::System.Drawing.Color.FromArgb(25, 24, 26);
			this.Animation.SetDecoration(this.FeedData2, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.FeedData2.Font = new global::System.Drawing.Font("Montserrat SemiBold", 8.249999f, global::System.Drawing.FontStyle.Bold);
			this.FeedData2.Location = new global::System.Drawing.Point(244, 251);
			this.FeedData2.Name = "FeedData2";
			this.FeedData2.Size = new global::System.Drawing.Size(200, 100);
			this.FeedData2.TabIndex = 13;
			this.FeedPic2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.Animation.SetDecoration(this.FeedPic2, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.FeedPic2.FillColor = global::System.Drawing.Color.FromArgb(25, 24, 26);
			this.FeedPic2.ImageRotate = 0f;
			this.FeedPic2.Location = new global::System.Drawing.Point(244, 86);
			this.FeedPic2.Name = "FeedPic2";
			this.FeedPic2.ShadowDecoration.Parent = this.FeedPic2;
			this.FeedPic2.Size = new global::System.Drawing.Size(200, 165);
			this.FeedPic2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.FeedPic2.TabIndex = 12;
			this.FeedPic2.TabStop = false;
			this.FeedShadow2.BackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.FeedShadow2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.Animation.SetDecoration(this.FeedShadow2, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.FeedShadow2.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.FeedShadow2.ImageRotate = 0f;
			this.FeedShadow2.Location = new global::System.Drawing.Point(249, 91);
			this.FeedShadow2.Name = "FeedShadow2";
			this.FeedShadow2.ShadowDecoration.Parent = this.FeedShadow2;
			this.FeedShadow2.Size = new global::System.Drawing.Size(200, 265);
			this.FeedShadow2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.FeedShadow2.TabIndex = 14;
			this.FeedShadow2.TabStop = false;
			this.FeedData1.BackColor = global::System.Drawing.Color.FromArgb(25, 24, 26);
			this.Animation.SetDecoration(this.FeedData1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.FeedData1.Font = new global::System.Drawing.Font("Montserrat SemiBold", 8.249999f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.FeedData1.Location = new global::System.Drawing.Point(30, 251);
			this.FeedData1.Name = "FeedData1";
			this.FeedData1.Size = new global::System.Drawing.Size(200, 100);
			this.FeedData1.TabIndex = 10;
			this.FeedPic1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.Animation.SetDecoration(this.FeedPic1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.FeedPic1.FillColor = global::System.Drawing.Color.FromArgb(25, 24, 26);
			this.FeedPic1.ImageRotate = 0f;
			this.FeedPic1.Location = new global::System.Drawing.Point(30, 86);
			this.FeedPic1.Name = "FeedPic1";
			this.FeedPic1.ShadowDecoration.Parent = this.FeedPic1;
			this.FeedPic1.Size = new global::System.Drawing.Size(200, 165);
			this.FeedPic1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.FeedPic1.TabIndex = 9;
			this.FeedPic1.TabStop = false;
			this.FeedShadow1.BackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.FeedShadow1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.Animation.SetDecoration(this.FeedShadow1, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.FeedShadow1.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.FeedShadow1.ImageRotate = 0f;
			this.FeedShadow1.Location = new global::System.Drawing.Point(35, 91);
			this.FeedShadow1.Name = "FeedShadow1";
			this.FeedShadow1.ShadowDecoration.Parent = this.FeedShadow1;
			this.FeedShadow1.Size = new global::System.Drawing.Size(200, 265);
			this.FeedShadow1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.FeedShadow1.TabIndex = 11;
			this.FeedShadow1.TabStop = false;
			this.ManagerTab.BackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.ManagerTab.Controls.Add(this.PackInfoPanel);
			this.ManagerTab.Controls.Add(this.TextureList);
			this.Animation.SetDecoration(this.ManagerTab, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.ManagerTab.Location = new global::System.Drawing.Point(204, 4);
			this.ManagerTab.Name = "ManagerTab";
			this.ManagerTab.Size = new global::System.Drawing.Size(692, 442);
			this.ManagerTab.TabIndex = 4;
			this.ManagerTab.Text = "ManagerTab";
			this.PackInfoPanel.BackColor = global::System.Drawing.Color.FromArgb(25, 24, 26);
			this.PackInfoPanel.Controls.Add(this.EnterButton);
			this.PackInfoPanel.Controls.Add(this.PackNameBox);
			this.PackInfoPanel.Controls.Add(this.DeleteButton);
			this.PackInfoPanel.Controls.Add(this.DeleteShadow);
			this.PackInfoPanel.Controls.Add(this.LoadButton);
			this.PackInfoPanel.Controls.Add(this.LoadShadow);
			this.PackInfoPanel.Controls.Add(this.SavePacksButton);
			this.PackInfoPanel.Controls.Add(this.SavePacksShadow);
			this.PackInfoPanel.Controls.Add(this.PackIconBox);
			this.PackInfoPanel.Controls.Add(this.PackIconShadow);
			this.PackInfoPanel.Controls.Add(this.ProfileName);
			this.PackInfoPanel.Controls.Add(this.PackNameShadow);
			this.Animation.SetDecoration(this.PackInfoPanel, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.PackInfoPanel.Location = new global::System.Drawing.Point(325, 0);
			this.PackInfoPanel.Name = "PackInfoPanel";
			this.PackInfoPanel.ShadowDecoration.Parent = this.PackInfoPanel;
			this.PackInfoPanel.Size = new global::System.Drawing.Size(367, 442);
			this.PackInfoPanel.TabIndex = 9;
			this.EnterButton.Animated = true;
			this.EnterButton.CheckedState.Parent = this.EnterButton;
			this.EnterButton.CustomImages.Parent = this.EnterButton;
			this.Animation.SetDecoration(this.EnterButton, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.EnterButton.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.EnterButton.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.EnterButton.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.EnterButton.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.EnterButton.DisabledState.Parent = this.EnterButton;
			this.EnterButton.Enabled = false;
			this.EnterButton.FillColor = global::System.Drawing.Color.Red;
			this.EnterButton.Font = new global::System.Drawing.Font("Montserrat Black", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.EnterButton.ForeColor = global::System.Drawing.Color.White;
			this.EnterButton.HoverState.Parent = this.EnterButton;
			this.EnterButton.Location = new global::System.Drawing.Point(268, 375);
			this.EnterButton.Name = "EnterButton";
			this.EnterButton.ShadowDecoration.Parent = this.EnterButton;
			this.EnterButton.Size = new global::System.Drawing.Size(36, 36);
			this.EnterButton.TabIndex = 45;
			this.EnterButton.Text = "➔";
			this.EnterButton.TextOffset = new global::System.Drawing.Point(0, -1);
			this.EnterButton.Visible = false;
			this.EnterButton.Click += new global::System.EventHandler(this.EnterButton_Click);
			this.PackNameBox.AcceptsReturn = true;
			this.PackNameBox.Animated = true;
			this.PackNameBox.BorderColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.PackNameBox.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.Animation.SetDecoration(this.PackNameBox, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.PackNameBox.DefaultText = "";
			this.PackNameBox.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.PackNameBox.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.PackNameBox.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.PackNameBox.DisabledState.Parent = this.PackNameBox;
			this.PackNameBox.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.PackNameBox.FillColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.PackNameBox.FocusedState.BorderColor = global::System.Drawing.Color.Red;
			this.PackNameBox.FocusedState.Parent = this.PackNameBox;
			this.PackNameBox.Font = new global::System.Drawing.Font("Montserrat Black", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.PackNameBox.ForeColor = global::System.Drawing.Color.White;
			this.PackNameBox.HoverState.BorderColor = global::System.Drawing.Color.Red;
			this.PackNameBox.HoverState.Parent = this.PackNameBox;
			this.PackNameBox.Location = new global::System.Drawing.Point(59, 375);
			this.PackNameBox.Margin = new global::System.Windows.Forms.Padding(5, 4, 5, 4);
			this.PackNameBox.Name = "PackNameBox";
			this.PackNameBox.PasswordChar = '\0';
			this.PackNameBox.PlaceholderForeColor = global::System.Drawing.Color.DimGray;
			this.PackNameBox.PlaceholderText = "Name your profile!";
			this.PackNameBox.SelectedText = "";
			this.PackNameBox.ShadowDecoration.Parent = this.PackNameBox;
			this.PackNameBox.Size = new global::System.Drawing.Size(209, 36);
			this.PackNameBox.Style = global::Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.PackNameBox.TabIndex = 43;
			this.PackNameBox.TextOffset = new global::System.Drawing.Point(0, -2);
			this.PackNameBox.Visible = false;
			this.PackNameBox.TextChanged += new global::System.EventHandler(this.PackNameBox_TextChanged);
			this.DeleteButton.Animated = true;
			this.DeleteButton.CheckedState.Parent = this.DeleteButton;
			this.DeleteButton.CustomImages.Parent = this.DeleteButton;
			this.Animation.SetDecoration(this.DeleteButton, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.DeleteButton.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.DeleteButton.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.DeleteButton.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.DeleteButton.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.DeleteButton.DisabledState.Parent = this.DeleteButton;
			this.DeleteButton.Enabled = false;
			this.DeleteButton.FillColor = global::System.Drawing.Color.Red;
			this.DeleteButton.Font = new global::System.Drawing.Font("Montserrat Black", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.DeleteButton.ForeColor = global::System.Drawing.Color.White;
			this.DeleteButton.HoverState.Parent = this.DeleteButton;
			this.DeleteButton.Location = new global::System.Drawing.Point(185, 320);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.ShadowDecoration.Parent = this.DeleteButton;
			this.DeleteButton.Size = new global::System.Drawing.Size(162, 36);
			this.DeleteButton.TabIndex = 42;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.Click += new global::System.EventHandler(this.DeleteButton_Click);
			this.Animation.SetDecoration(this.DeleteShadow, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.DeleteShadow.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.DeleteShadow.ImageRotate = 0f;
			this.DeleteShadow.Location = new global::System.Drawing.Point(190, 325);
			this.DeleteShadow.Name = "DeleteShadow";
			this.DeleteShadow.ShadowDecoration.Parent = this.DeleteShadow;
			this.DeleteShadow.Size = new global::System.Drawing.Size(162, 36);
			this.DeleteShadow.TabIndex = 41;
			this.DeleteShadow.TabStop = false;
			this.LoadButton.Animated = true;
			this.LoadButton.CheckedState.Parent = this.LoadButton;
			this.LoadButton.CustomImages.Parent = this.LoadButton;
			this.Animation.SetDecoration(this.LoadButton, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.LoadButton.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.LoadButton.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.LoadButton.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.LoadButton.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.LoadButton.DisabledState.Parent = this.LoadButton;
			this.LoadButton.Enabled = false;
			this.LoadButton.FillColor = global::System.Drawing.Color.Red;
			this.LoadButton.Font = new global::System.Drawing.Font("Montserrat Black", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LoadButton.ForeColor = global::System.Drawing.Color.White;
			this.LoadButton.HoverState.Parent = this.LoadButton;
			this.LoadButton.Location = new global::System.Drawing.Point(17, 320);
			this.LoadButton.Name = "LoadButton";
			this.LoadButton.ShadowDecoration.Parent = this.LoadButton;
			this.LoadButton.Size = new global::System.Drawing.Size(162, 36);
			this.LoadButton.TabIndex = 40;
			this.LoadButton.Text = "Load Profile";
			this.LoadButton.Click += new global::System.EventHandler(this.LoadButton_Click);
			this.Animation.SetDecoration(this.LoadShadow, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.LoadShadow.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.LoadShadow.ImageRotate = 0f;
			this.LoadShadow.Location = new global::System.Drawing.Point(22, 325);
			this.LoadShadow.Name = "LoadShadow";
			this.LoadShadow.ShadowDecoration.Parent = this.LoadShadow;
			this.LoadShadow.Size = new global::System.Drawing.Size(162, 36);
			this.LoadShadow.TabIndex = 39;
			this.LoadShadow.TabStop = false;
			this.SavePacksButton.Animated = true;
			this.SavePacksButton.CheckedState.Parent = this.SavePacksButton;
			this.SavePacksButton.CustomImages.Parent = this.SavePacksButton;
			this.Animation.SetDecoration(this.SavePacksButton, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.SavePacksButton.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.SavePacksButton.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.SavePacksButton.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.SavePacksButton.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.SavePacksButton.DisabledState.Parent = this.SavePacksButton;
			this.SavePacksButton.FillColor = global::System.Drawing.Color.Red;
			this.SavePacksButton.Font = new global::System.Drawing.Font("Montserrat Black", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.SavePacksButton.ForeColor = global::System.Drawing.Color.White;
			this.SavePacksButton.HoverState.Parent = this.SavePacksButton;
			this.SavePacksButton.Location = new global::System.Drawing.Point(17, 269);
			this.SavePacksButton.Name = "SavePacksButton";
			this.SavePacksButton.ShadowDecoration.Parent = this.SavePacksButton;
			this.SavePacksButton.Size = new global::System.Drawing.Size(330, 36);
			this.SavePacksButton.TabIndex = 38;
			this.SavePacksButton.Text = "Save Current Packs";
			this.SavePacksButton.Click += new global::System.EventHandler(this.SavePacksButton_Click);
			this.Animation.SetDecoration(this.SavePacksShadow, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.SavePacksShadow.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.SavePacksShadow.ImageRotate = 0f;
			this.SavePacksShadow.Location = new global::System.Drawing.Point(22, 274);
			this.SavePacksShadow.Name = "SavePacksShadow";
			this.SavePacksShadow.ShadowDecoration.Parent = this.SavePacksShadow;
			this.SavePacksShadow.Size = new global::System.Drawing.Size(330, 36);
			this.SavePacksShadow.TabIndex = 37;
			this.SavePacksShadow.TabStop = false;
			this.PackIconBox.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.Animation.SetDecoration(this.PackIconBox, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.PackIconBox.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PackIconBox.Image");
			this.PackIconBox.ImageRotate = 0f;
			this.PackIconBox.Location = new global::System.Drawing.Point(100, 32);
			this.PackIconBox.Name = "PackIconBox";
			this.PackIconBox.ShadowDecoration.Parent = this.PackIconBox;
			this.PackIconBox.Size = new global::System.Drawing.Size(167, 167);
			this.PackIconBox.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.PackIconBox.TabIndex = 5;
			this.PackIconBox.TabStop = false;
			this.Animation.SetDecoration(this.PackIconShadow, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.PackIconShadow.FillColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.PackIconShadow.ImageRotate = 0f;
			this.PackIconShadow.Location = new global::System.Drawing.Point(105, 37);
			this.PackIconShadow.Name = "PackIconShadow";
			this.PackIconShadow.ShadowDecoration.Parent = this.PackIconShadow;
			this.PackIconShadow.Size = new global::System.Drawing.Size(167, 167);
			this.PackIconShadow.TabIndex = 8;
			this.PackIconShadow.TabStop = false;
			this.Animation.SetDecoration(this.ProfileName, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.ProfileName.Font = new global::System.Drawing.Font("Montserrat Black", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ProfileName.Location = new global::System.Drawing.Point(0, 219);
			this.ProfileName.Name = "ProfileName";
			this.ProfileName.Size = new global::System.Drawing.Size(367, 34);
			this.ProfileName.TabIndex = 6;
			this.ProfileName.Text = "Profile Name";
			this.ProfileName.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.Animation.SetDecoration(this.PackNameShadow, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.PackNameShadow.FillColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.PackNameShadow.ImageRotate = 0f;
			this.PackNameShadow.Location = new global::System.Drawing.Point(64, 380);
			this.PackNameShadow.Name = "PackNameShadow";
			this.PackNameShadow.ShadowDecoration.Parent = this.PackNameShadow;
			this.PackNameShadow.Size = new global::System.Drawing.Size(245, 36);
			this.PackNameShadow.TabIndex = 44;
			this.PackNameShadow.TabStop = false;
			this.PackNameShadow.Visible = false;
			this.TextureList.BackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.TextureList.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.TextureList.ContextMenuStrip = this.TextureMenuStrip;
			this.Animation.SetDecoration(this.TextureList, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.TextureList.Font = new global::System.Drawing.Font("Montserrat Black", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.TextureList.ForeColor = global::System.Drawing.Color.White;
			this.TextureList.FormattingEnabled = true;
			this.TextureList.ItemHeight = 22;
			this.TextureList.Items.AddRange(new object[]
			{
				"Welcome to Pack Profiles!",
				"",
				"Clicking \"Save\" will save the packs ",
				"you currently have applied.",
				"",
				"Give it a name too, so you can come ",
				"back to it if you want later."
			});
			this.TextureList.Location = new global::System.Drawing.Point(0, 0);
			this.TextureList.Name = "TextureList";
			this.TextureList.Size = new global::System.Drawing.Size(325, 440);
			this.TextureList.TabIndex = 0;
			this.TextureList.SelectedIndexChanged += new global::System.EventHandler(this.TextureList_SelectedIndexChanged);
			this.TextureMenuStrip.BackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.Animation.SetDecoration(this.TextureMenuStrip, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.TextureMenuStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.loadToolStripMenuItem,
				this.deleteToolStripMenuItem
			});
			this.TextureMenuStrip.Name = "TextureMenuStrip";
			this.TextureMenuStrip.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.System;
			this.TextureMenuStrip.ShowImageMargin = false;
			this.TextureMenuStrip.ShowItemToolTips = false;
			this.TextureMenuStrip.Size = new global::System.Drawing.Size(83, 48);
			this.loadToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new global::System.Drawing.Size(82, 22);
			this.loadToolStripMenuItem.Text = "Load";
			this.deleteToolStripMenuItem.ForeColor = global::System.Drawing.Color.White;
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new global::System.Drawing.Size(82, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			this.CloseBtn.Animated = true;
			this.CloseBtn.BackColor = global::System.Drawing.Color.Transparent;
			this.CloseBtn.CheckedState.Parent = this.CloseBtn;
			this.CloseBtn.CustomImages.Parent = this.CloseBtn;
			this.Animation.SetDecoration(this.CloseBtn, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.CloseBtn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.CloseBtn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.CloseBtn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.CloseBtn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.CloseBtn.DisabledState.Parent = this.CloseBtn;
			this.CloseBtn.FillColor = global::System.Drawing.Color.Transparent;
			this.CloseBtn.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.CloseBtn.ForeColor = global::System.Drawing.Color.White;
			this.CloseBtn.HoverState.Parent = this.CloseBtn;
			this.CloseBtn.Location = new global::System.Drawing.Point(870, 0);
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.ShadowDecoration.Parent = this.CloseBtn;
			this.CloseBtn.Size = new global::System.Drawing.Size(30, 30);
			this.CloseBtn.TabIndex = 4;
			this.CloseBtn.Text = "X";
			this.CloseBtn.UseTransparentBackground = true;
			this.CloseBtn.Click += new global::System.EventHandler(this.CloseBtn_Click);
			this.MinimizeBtn.Animated = true;
			this.MinimizeBtn.BackColor = global::System.Drawing.Color.Transparent;
			this.MinimizeBtn.CheckedState.Parent = this.MinimizeBtn;
			this.MinimizeBtn.CustomImages.Parent = this.MinimizeBtn;
			this.Animation.SetDecoration(this.MinimizeBtn, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.MinimizeBtn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.MinimizeBtn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.MinimizeBtn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.MinimizeBtn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.MinimizeBtn.DisabledState.Parent = this.MinimizeBtn;
			this.MinimizeBtn.FillColor = global::System.Drawing.Color.Transparent;
			this.MinimizeBtn.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.MinimizeBtn.ForeColor = global::System.Drawing.Color.White;
			this.MinimizeBtn.HoverState.Parent = this.MinimizeBtn;
			this.MinimizeBtn.Location = new global::System.Drawing.Point(840, 0);
			this.MinimizeBtn.Name = "MinimizeBtn";
			this.MinimizeBtn.ShadowDecoration.Parent = this.MinimizeBtn;
			this.MinimizeBtn.Size = new global::System.Drawing.Size(30, 30);
			this.MinimizeBtn.TabIndex = 5;
			this.MinimizeBtn.Text = "_";
			this.MinimizeBtn.TextOffset = new global::System.Drawing.Point(0, -8);
			this.MinimizeBtn.UseTransparentBackground = true;
			this.MinimizeBtn.Click += new global::System.EventHandler(this.MinimizeBtn_Click);
			this.FileDialog.DefaultExt = "dll";
			this.FileDialog.Filter = "DLL files|*.dll";
			this.FileDialog.Title = "Select DLL";
			this.NotifyIcon.BalloonTipIcon = global::System.Windows.Forms.ToolTipIcon.Info;
			this.NotifyIcon.BalloonTipText = "You can click the Jiayi logo in the tray to show the launcher.";
			this.NotifyIcon.BalloonTipTitle = "Jiayi was hidden!";
			this.NotifyIcon.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("NotifyIcon.Icon");
			this.NotifyIcon.Text = "Jiayi Launcher";
			this.NotifyIcon.Visible = true;
			this.NotifyIcon.BalloonTipClicked += new global::System.EventHandler(this.NotifyIcon_Click);
			this.NotifyIcon.Click += new global::System.EventHandler(this.NotifyIcon_Click);
			this.RPCTimer.Interval = 2000;
			this.RPCTimer.Tick += new global::System.EventHandler(this.RPCTimer_Tick);
			this.Animation.AnimationType = global::Guna.UI2.AnimatorNS.AnimationType.Transparent;
			this.Animation.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation3.BlindCoeff");
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation3.MosaicCoeff");
			animation.MosaicShift = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation3.MosaicShift");
			animation.MosaicSize = 0;
			animation.Padding = new global::System.Windows.Forms.Padding(0);
			animation.RotateCoeff = 0f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation3.ScaleCoeff");
			animation.SlideCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation3.SlideCoeff");
			animation.TimeCoeff = 0f;
			animation.TransparencyCoeff = 1f;
			this.Animation.DefaultAnimation = animation;
			this.Animation.Interval = 1;
			this.Animation.TimeStep = 0.08f;
			this.PackIconTimer.Interval = 1000;
			this.PackIconTimer.Tick += new global::System.EventHandler(this.PackIconTimer_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(15, 15, 15);
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(900, 550);
			base.Controls.Add(this.MinimizeBtn);
			base.Controls.Add(this.CloseBtn);
			base.Controls.Add(this.Buttons);
			base.Controls.Add(this.Title);
			base.Controls.Add(this.Tabs);
			this.Animation.SetDecoration(this, global::Guna.UI2.AnimatorNS.DecorationType.None);
			this.DoubleBuffered = true;
			this.ForeColor = global::System.Drawing.Color.White;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Jiayi";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Jiayi Launcher";
			this.Buttons.ResumeLayout(false);
			this.Buttons.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GamerpicBox).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GamerpicShadow).EndInit();
			this.Tabs.ResumeLayout(false);
			this.HomeTab.ResumeLayout(false);
			this.LaunchNewsPanel.ResumeLayout(false);
			this.SettingsTab.ResumeLayout(false);
			this.SettingsTab.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ManagerShadow).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.RestartShadow).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ResetShadow).EndInit();
			this.AppearanceTab.ResumeLayout(false);
			this.AppearanceTab.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ThemesCover).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SelectBackgroundShadow).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ColorPickerShadow).EndInit();
			this.NewsfeedTab.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.FeedPic3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FeedShadow3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FeedPic2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FeedShadow2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FeedPic1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FeedShadow1).EndInit();
			this.ManagerTab.ResumeLayout(false);
			this.PackInfoPanel.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.DeleteShadow).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.LoadShadow).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SavePacksShadow).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.PackIconBox).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.PackIconShadow).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.PackNameShadow).EndInit();
			this.TextureMenuStrip.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000013 RID: 19
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000014 RID: 20
		private global::Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;

		// Token: 0x04000015 RID: 21
		private global::Guna.UI2.WinForms.Guna2Panel Buttons;

		// Token: 0x04000016 RID: 22
		private global::Guna.UI2.WinForms.Guna2Button HomeTabBtn;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.Label LogoLabel;

		// Token: 0x04000018 RID: 24
		private global::Guna.UI2.WinForms.Guna2Button SettingsTabBtn;

		// Token: 0x04000019 RID: 25
		private global::Guna.UI2.WinForms.Guna2Button NewsfeedTabBtn;

		// Token: 0x0400001A RID: 26
		private global::Guna.UI2.WinForms.Guna2Button AppearanceTabBtn;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.Label GamertagLabel;

		// Token: 0x0400001C RID: 28
		private global::Guna.UI2.WinForms.Guna2PictureBox GamerpicBox;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Label LoginStatusLabel;

		// Token: 0x0400001E RID: 30
		private global::Guna.UI2.WinForms.Guna2Button Title;

		// Token: 0x0400001F RID: 31
		private global::Guna.UI2.WinForms.Guna2PictureBox GamerpicShadow;

		// Token: 0x04000020 RID: 32
		private global::Guna.UI2.WinForms.Guna2TabControl Tabs;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.TabPage HomeTab;

		// Token: 0x04000022 RID: 34
		private global::Guna.UI2.WinForms.Guna2Panel LaunchNewsPanel;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.TabPage SettingsTab;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.TabPage NewsfeedTab;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.TabPage AppearanceTab;

		// Token: 0x04000026 RID: 38
		private global::Guna.UI2.WinForms.Guna2Panel LaunchNewsShadow;

		// Token: 0x04000027 RID: 39
		private global::Guna.UI2.WinForms.Guna2Button SelectDLLButton;

		// Token: 0x04000028 RID: 40
		private global::Guna.UI2.WinForms.Guna2Button LaunchBtn;

		// Token: 0x04000029 RID: 41
		private global::Guna.UI2.WinForms.Guna2Panel SelectDLLShadow;

		// Token: 0x0400002A RID: 42
		private global::Guna.UI2.WinForms.Guna2Panel LaunchShadow;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Label NewsText;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Label NewsTitle;

		// Token: 0x0400002D RID: 45
		private global::Guna.UI2.WinForms.Guna2Button CloseBtn;

		// Token: 0x0400002E RID: 46
		private global::Guna.UI2.WinForms.Guna2Button MinimizeBtn;

		// Token: 0x0400002F RID: 47
		private global::Guna.UI2.WinForms.Guna2ComboBox LaunchComboBox;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Label LaunchDescription;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Label LaunchSettingsLabel;

		// Token: 0x04000032 RID: 50
		private global::Guna.UI2.WinForms.Guna2TrackBar DelayTrackBar;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.Label DelayDescription;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.Label DelayTitle;

		// Token: 0x04000035 RID: 53
		private global::Guna.UI2.WinForms.Guna2CheckBox DontInjectCheckBox;

		// Token: 0x04000036 RID: 54
		private global::Guna.UI2.WinForms.Guna2ComboBox PriorityComboBox;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.Label PriorityDescription;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.Label PriorityTitle;

		// Token: 0x04000039 RID: 57
		private global::Guna.UI2.WinForms.Guna2Button ResetBtn;

		// Token: 0x0400003A RID: 58
		private global::Guna.UI2.WinForms.Guna2PictureBox ResetShadow;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.Label ResetDescription;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.Label ResetTitle;

		// Token: 0x0400003D RID: 61
		private global::Guna.UI2.WinForms.Guna2Button RestartButton;

		// Token: 0x0400003E RID: 62
		private global::Guna.UI2.WinForms.Guna2PictureBox RestartShadow;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.Label RestartDescription;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.Label RestartTitle;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.Label BackgroundTitle;

		// Token: 0x04000042 RID: 66
		private global::Guna.UI2.WinForms.Guna2Button ColorPickerBtn;

		// Token: 0x04000043 RID: 67
		private global::Guna.UI2.WinForms.Guna2PictureBox ColorPickerShadow;

		// Token: 0x04000044 RID: 68
		private global::Guna.UI2.WinForms.Guna2ComboBox BackgroundComboBox;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.Label ColorCodeLabel;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.Label ColorTitle;

		// Token: 0x04000047 RID: 71
		private global::Guna.UI2.WinForms.Guna2Button SelectBackgroundBtn;

		// Token: 0x04000048 RID: 72
		private global::Guna.UI2.WinForms.Guna2PictureBox SelectBackgroundShadow;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.Label RGBDescription;

		// Token: 0x0400004A RID: 74
		private global::Guna.UI2.WinForms.Guna2CheckBox RGBCheckBox;

		// Token: 0x0400004B RID: 75
		private global::Guna.UI2.WinForms.Guna2TrackBar RGBTrackBar;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.Label ThemesSoon;

		// Token: 0x0400004D RID: 77
		private global::Guna.UI2.WinForms.Guna2PictureBox ThemesCover;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Label ThemesLabel;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.Label FeedData3;

		// Token: 0x04000050 RID: 80
		private global::Guna.UI2.WinForms.Guna2PictureBox FeedPic3;

		// Token: 0x04000051 RID: 81
		private global::Guna.UI2.WinForms.Guna2PictureBox FeedShadow3;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.Label FeedData2;

		// Token: 0x04000053 RID: 83
		private global::Guna.UI2.WinForms.Guna2PictureBox FeedPic2;

		// Token: 0x04000054 RID: 84
		private global::Guna.UI2.WinForms.Guna2PictureBox FeedShadow2;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.Label FeedData1;

		// Token: 0x04000056 RID: 86
		private global::Guna.UI2.WinForms.Guna2PictureBox FeedPic1;

		// Token: 0x04000057 RID: 87
		private global::Guna.UI2.WinForms.Guna2PictureBox FeedShadow1;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.ColorDialog ColorPickerDialog;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.OpenFileDialog FileDialog;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.Label StatusText;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.NotifyIcon NotifyIcon;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.Timer RPCTimer;

		// Token: 0x0400005D RID: 93
		private global::Guna.UI2.WinForms.Guna2Transition Animation;

		// Token: 0x0400005E RID: 94
		private global::Guna.UI2.WinForms.Guna2Button ManagerButton;

		// Token: 0x0400005F RID: 95
		private global::Guna.UI2.WinForms.Guna2PictureBox ManagerShadow;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.Label ManagerDescription;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.Label ManagerTitle;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.TabPage ManagerTab;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.ListBox TextureList;

		// Token: 0x04000064 RID: 100
		private global::Guna.UI2.WinForms.Guna2Panel PackInfoPanel;

		// Token: 0x04000065 RID: 101
		private global::Guna.UI2.WinForms.Guna2PictureBox PackIconBox;

		// Token: 0x04000066 RID: 102
		private global::Guna.UI2.WinForms.Guna2PictureBox PackIconShadow;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.Label ProfileName;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.ContextMenuStrip TextureMenuStrip;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;

		// Token: 0x0400006B RID: 107
		private global::Guna.UI2.WinForms.Guna2TextBox PackNameBox;

		// Token: 0x0400006C RID: 108
		private global::Guna.UI2.WinForms.Guna2Button DeleteButton;

		// Token: 0x0400006D RID: 109
		private global::Guna.UI2.WinForms.Guna2PictureBox DeleteShadow;

		// Token: 0x0400006E RID: 110
		private global::Guna.UI2.WinForms.Guna2Button LoadButton;

		// Token: 0x0400006F RID: 111
		private global::Guna.UI2.WinForms.Guna2PictureBox LoadShadow;

		// Token: 0x04000070 RID: 112
		private global::Guna.UI2.WinForms.Guna2Button SavePacksButton;

		// Token: 0x04000071 RID: 113
		private global::Guna.UI2.WinForms.Guna2PictureBox SavePacksShadow;

		// Token: 0x04000072 RID: 114
		private global::Guna.UI2.WinForms.Guna2PictureBox PackNameShadow;

		// Token: 0x04000073 RID: 115
		private global::Guna.UI2.WinForms.Guna2Button EnterButton;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.Timer PackIconTimer;
	}
}
