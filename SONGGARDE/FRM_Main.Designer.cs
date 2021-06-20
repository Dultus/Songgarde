namespace SONGGARDE
{
    partial class FRM_Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Main));
            this.LBL_Preview = new System.Windows.Forms.Label();
            this.CB_STAM = new Guna.UI2.WinForms.Guna2ComboBox();
            this.BTN_ExportSTAM = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_ChangeBackgroundimage = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_ChangeTitleMusic = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_ChangeDirectory = new Guna.UI2.WinForms.Guna2Button();
            this.TB_SkyrimPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.PNL_TopWindow = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.LBL_Titlebar = new System.Windows.Forms.Label();
            this.BTN_Close = new Guna.UI2.WinForms.Guna2Button();
            this.FRM_Shadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.CMS_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nexuswebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LBL_TitleMusic = new System.Windows.Forms.Label();
            this.LBL_Backgroundimage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkFog = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkSkyrimLogo = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbNotifications = new System.Windows.Forms.TextBox();
            this.btnRemoveMusic = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemoveImage = new Guna.UI2.WinForms.Guna2Button();
            this.pbFog = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbSkyrimLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PB_Icon = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PB_Play = new System.Windows.Forms.PictureBox();
            this.PB_Preview = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PNL_TopWindow.SuspendLayout();
            this.CMS_Main.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkyrimLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Preview
            // 
            this.LBL_Preview.AutoSize = true;
            this.LBL_Preview.Location = new System.Drawing.Point(406, 213);
            this.LBL_Preview.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_Preview.Name = "LBL_Preview";
            this.LBL_Preview.Size = new System.Drawing.Size(45, 13);
            this.LBL_Preview.TabIndex = 3;
            this.LBL_Preview.Text = "Preview";
            this.LBL_Preview.Visible = false;
            // 
            // CB_STAM
            // 
            this.CB_STAM.BackColor = System.Drawing.Color.Transparent;
            this.CB_STAM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_STAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_STAM.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_STAM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_STAM.FocusedState.Parent = this.CB_STAM;
            this.CB_STAM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_STAM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CB_STAM.HoverState.Parent = this.CB_STAM;
            this.CB_STAM.IntegralHeight = false;
            this.CB_STAM.ItemHeight = 30;
            this.CB_STAM.ItemsAppearance.Parent = this.CB_STAM;
            this.CB_STAM.Location = new System.Drawing.Point(22, 310);
            this.CB_STAM.Name = "CB_STAM";
            this.CB_STAM.ShadowDecoration.Parent = this.CB_STAM;
            this.CB_STAM.Size = new System.Drawing.Size(308, 36);
            this.CB_STAM.TabIndex = 22;
            this.CB_STAM.Visible = false;
            // 
            // BTN_ExportSTAM
            // 
            this.BTN_ExportSTAM.Animated = true;
            this.BTN_ExportSTAM.AutoRoundedCorners = true;
            this.BTN_ExportSTAM.BorderRadius = 13;
            this.BTN_ExportSTAM.CheckedState.Parent = this.BTN_ExportSTAM;
            this.BTN_ExportSTAM.CustomImages.Parent = this.BTN_ExportSTAM;
            this.BTN_ExportSTAM.DisabledState.Parent = this.BTN_ExportSTAM;
            this.BTN_ExportSTAM.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(69)))));
            this.BTN_ExportSTAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ExportSTAM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_ExportSTAM.HoverState.Parent = this.BTN_ExportSTAM;
            this.BTN_ExportSTAM.Location = new System.Drawing.Point(22, 275);
            this.BTN_ExportSTAM.Name = "BTN_ExportSTAM";
            this.BTN_ExportSTAM.ShadowDecoration.Parent = this.BTN_ExportSTAM;
            this.BTN_ExportSTAM.Size = new System.Drawing.Size(86, 29);
            this.BTN_ExportSTAM.TabIndex = 24;
            this.BTN_ExportSTAM.Text = "Export";
            this.BTN_ExportSTAM.Click += new System.EventHandler(this.BTN_ExportSTAM_Click);
            // 
            // BTN_ChangeBackgroundimage
            // 
            this.BTN_ChangeBackgroundimage.Animated = true;
            this.BTN_ChangeBackgroundimage.AutoRoundedCorners = true;
            this.BTN_ChangeBackgroundimage.BorderRadius = 13;
            this.BTN_ChangeBackgroundimage.CheckedState.Parent = this.BTN_ChangeBackgroundimage;
            this.BTN_ChangeBackgroundimage.CustomImages.Parent = this.BTN_ChangeBackgroundimage;
            this.BTN_ChangeBackgroundimage.DisabledState.Parent = this.BTN_ChangeBackgroundimage;
            this.BTN_ChangeBackgroundimage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(69)))));
            this.BTN_ChangeBackgroundimage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ChangeBackgroundimage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_ChangeBackgroundimage.HoverState.Parent = this.BTN_ChangeBackgroundimage;
            this.BTN_ChangeBackgroundimage.Location = new System.Drawing.Point(12, 96);
            this.BTN_ChangeBackgroundimage.Name = "BTN_ChangeBackgroundimage";
            this.BTN_ChangeBackgroundimage.ShadowDecoration.Parent = this.BTN_ChangeBackgroundimage;
            this.BTN_ChangeBackgroundimage.Size = new System.Drawing.Size(154, 29);
            this.BTN_ChangeBackgroundimage.TabIndex = 25;
            this.BTN_ChangeBackgroundimage.Text = "Change Image";
            this.BTN_ChangeBackgroundimage.Click += new System.EventHandler(this.ChangeBackgroundImage_Click);
            this.BTN_ChangeBackgroundimage.DragDrop += new System.Windows.Forms.DragEventHandler(this.ChangeBackgroundImage_DragDrop);
            this.BTN_ChangeBackgroundimage.DragEnter += new System.Windows.Forms.DragEventHandler(this.ChangeBackgroundImage_DragEnter);
            // 
            // BTN_ChangeTitleMusic
            // 
            this.BTN_ChangeTitleMusic.Animated = true;
            this.BTN_ChangeTitleMusic.AutoRoundedCorners = true;
            this.BTN_ChangeTitleMusic.BorderRadius = 13;
            this.BTN_ChangeTitleMusic.CheckedState.Parent = this.BTN_ChangeTitleMusic;
            this.BTN_ChangeTitleMusic.CustomImages.Parent = this.BTN_ChangeTitleMusic;
            this.BTN_ChangeTitleMusic.DisabledState.Parent = this.BTN_ChangeTitleMusic;
            this.BTN_ChangeTitleMusic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(69)))));
            this.BTN_ChangeTitleMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ChangeTitleMusic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_ChangeTitleMusic.HoverState.Parent = this.BTN_ChangeTitleMusic;
            this.BTN_ChangeTitleMusic.Location = new System.Drawing.Point(12, 152);
            this.BTN_ChangeTitleMusic.Name = "BTN_ChangeTitleMusic";
            this.BTN_ChangeTitleMusic.ShadowDecoration.Parent = this.BTN_ChangeTitleMusic;
            this.BTN_ChangeTitleMusic.Size = new System.Drawing.Size(154, 29);
            this.BTN_ChangeTitleMusic.TabIndex = 26;
            this.BTN_ChangeTitleMusic.Text = "Change Music";
            this.BTN_ChangeTitleMusic.Click += new System.EventHandler(this.ChangeTitleMusic_Click);
            this.BTN_ChangeTitleMusic.DragDrop += new System.Windows.Forms.DragEventHandler(this.ChangeTitleMusic_DragDrop);
            this.BTN_ChangeTitleMusic.DragEnter += new System.Windows.Forms.DragEventHandler(this.ChangeTitleMusic_DragEnter);
            // 
            // BTN_ChangeDirectory
            // 
            this.BTN_ChangeDirectory.Animated = true;
            this.BTN_ChangeDirectory.AutoRoundedCorners = true;
            this.BTN_ChangeDirectory.BorderRadius = 13;
            this.BTN_ChangeDirectory.CheckedState.Parent = this.BTN_ChangeDirectory;
            this.BTN_ChangeDirectory.CustomImages.Parent = this.BTN_ChangeDirectory;
            this.BTN_ChangeDirectory.DisabledState.Parent = this.BTN_ChangeDirectory;
            this.BTN_ChangeDirectory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(69)))));
            this.BTN_ChangeDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ChangeDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_ChangeDirectory.HoverState.Parent = this.BTN_ChangeDirectory;
            this.BTN_ChangeDirectory.Location = new System.Drawing.Point(521, 40);
            this.BTN_ChangeDirectory.Name = "BTN_ChangeDirectory";
            this.BTN_ChangeDirectory.ShadowDecoration.Parent = this.BTN_ChangeDirectory;
            this.BTN_ChangeDirectory.Size = new System.Drawing.Size(132, 29);
            this.BTN_ChangeDirectory.TabIndex = 27;
            this.BTN_ChangeDirectory.Text = "Set Root Directory";
            this.BTN_ChangeDirectory.Click += new System.EventHandler(this.BTN_ChangeDirectory_Click);
            // 
            // TB_SkyrimPath
            // 
            this.TB_SkyrimPath.Animated = true;
            this.TB_SkyrimPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_SkyrimPath.DefaultText = "";
            this.TB_SkyrimPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TB_SkyrimPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TB_SkyrimPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB_SkyrimPath.DisabledState.Parent = this.TB_SkyrimPath;
            this.TB_SkyrimPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB_SkyrimPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB_SkyrimPath.FocusedState.Parent = this.TB_SkyrimPath;
            this.TB_SkyrimPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TB_SkyrimPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB_SkyrimPath.HoverState.Parent = this.TB_SkyrimPath;
            this.TB_SkyrimPath.Location = new System.Drawing.Point(12, 40);
            this.TB_SkyrimPath.Name = "TB_SkyrimPath";
            this.TB_SkyrimPath.PasswordChar = '\0';
            this.TB_SkyrimPath.PlaceholderText = "";
            this.TB_SkyrimPath.ReadOnly = true;
            this.TB_SkyrimPath.SelectedText = "";
            this.TB_SkyrimPath.ShadowDecoration.Parent = this.TB_SkyrimPath;
            this.TB_SkyrimPath.Size = new System.Drawing.Size(503, 29);
            this.TB_SkyrimPath.TabIndex = 28;
            // 
            // PNL_TopWindow
            // 
            this.PNL_TopWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.PNL_TopWindow.Controls.Add(this.guna2Button1);
            this.PNL_TopWindow.Controls.Add(this.LBL_Titlebar);
            this.PNL_TopWindow.Controls.Add(this.PB_Icon);
            this.PNL_TopWindow.Controls.Add(this.BTN_Close);
            this.PNL_TopWindow.Controls.Add(this.pictureBox2);
            this.PNL_TopWindow.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_TopWindow.Location = new System.Drawing.Point(0, 0);
            this.PNL_TopWindow.Name = "PNL_TopWindow";
            this.PNL_TopWindow.Size = new System.Drawing.Size(665, 34);
            this.PNL_TopWindow.TabIndex = 29;
            this.PNL_TopWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PNL_TopWindow_MouseMove);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 13;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Blue;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(604, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(29, 29);
            this.guna2Button1.TabIndex = 34;
            this.guna2Button1.Text = "?";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // LBL_Titlebar
            // 
            this.LBL_Titlebar.AutoSize = true;
            this.LBL_Titlebar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Titlebar.Location = new System.Drawing.Point(33, 8);
            this.LBL_Titlebar.Name = "LBL_Titlebar";
            this.LBL_Titlebar.Size = new System.Drawing.Size(115, 20);
            this.LBL_Titlebar.TabIndex = 33;
            this.LBL_Titlebar.Text = "SONGGARDE";
            this.LBL_Titlebar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PNL_TopWindow_MouseMove);
            // 
            // BTN_Close
            // 
            this.BTN_Close.Animated = true;
            this.BTN_Close.AutoRoundedCorners = true;
            this.BTN_Close.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Close.BorderRadius = 13;
            this.BTN_Close.CheckedState.Parent = this.BTN_Close;
            this.BTN_Close.CustomImages.Parent = this.BTN_Close;
            this.BTN_Close.DisabledState.Parent = this.BTN_Close;
            this.BTN_Close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BTN_Close.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_Close.HoverState.Parent = this.BTN_Close;
            this.BTN_Close.Location = new System.Drawing.Point(635, 2);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.ShadowDecoration.Parent = this.BTN_Close;
            this.BTN_Close.Size = new System.Drawing.Size(29, 29);
            this.BTN_Close.TabIndex = 31;
            this.BTN_Close.Text = "X";
            this.BTN_Close.UseTransparentBackground = true;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // FRM_Shadow
            // 
            this.FRM_Shadow.TargetForm = this;
            // 
            // CMS_Main
            // 
            this.CMS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changelogToolStripMenuItem,
            this.plansToolStripMenuItem,
            this.nexuswebsiteToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.CMS_Main.Name = "CMS_Main";
            this.CMS_Main.Size = new System.Drawing.Size(183, 120);
            // 
            // changelogToolStripMenuItem
            // 
            this.changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
            this.changelogToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.changelogToolStripMenuItem.Text = "Changelog";
            // 
            // plansToolStripMenuItem
            // 
            this.plansToolStripMenuItem.Name = "plansToolStripMenuItem";
            this.plansToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.plansToolStripMenuItem.Text = "Future Plans";
            // 
            // nexuswebsiteToolStripMenuItem
            // 
            this.nexuswebsiteToolStripMenuItem.Name = "nexuswebsiteToolStripMenuItem";
            this.nexuswebsiteToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.nexuswebsiteToolStripMenuItem.Text = "Nexusmods Website";
            this.nexuswebsiteToolStripMenuItem.Click += new System.EventHandler(this.nexuswebsiteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupFormToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // setupFormToolStripMenuItem
            // 
            this.setupFormToolStripMenuItem.Name = "setupFormToolStripMenuItem";
            this.setupFormToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.setupFormToolStripMenuItem.Text = "Setup Form";
            this.setupFormToolStripMenuItem.Click += new System.EventHandler(this.setupFormToolStripMenuItem_Click);
            // 
            // LBL_TitleMusic
            // 
            this.LBL_TitleMusic.AllowDrop = true;
            this.LBL_TitleMusic.AutoSize = true;
            this.LBL_TitleMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.LBL_TitleMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TitleMusic.Location = new System.Drawing.Point(259, 160);
            this.LBL_TitleMusic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_TitleMusic.Name = "LBL_TitleMusic";
            this.LBL_TitleMusic.Size = new System.Drawing.Size(86, 13);
            this.LBL_TitleMusic.TabIndex = 5;
            this.LBL_TitleMusic.Text = "PLACEHOLDER";
            this.LBL_TitleMusic.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LBL_TitleMusic.UseMnemonic = false;
            this.LBL_TitleMusic.Visible = false;
            this.LBL_TitleMusic.DragDrop += new System.Windows.Forms.DragEventHandler(this.ChangeTitleMusic_DragDrop);
            this.LBL_TitleMusic.DragEnter += new System.Windows.Forms.DragEventHandler(this.ChangeTitleMusic_DragEnter);
            this.LBL_TitleMusic.Resize += new System.EventHandler(this.LBL_Backgroundimage_Resize);
            // 
            // LBL_Backgroundimage
            // 
            this.LBL_Backgroundimage.AllowDrop = true;
            this.LBL_Backgroundimage.AutoSize = true;
            this.LBL_Backgroundimage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.LBL_Backgroundimage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Backgroundimage.Location = new System.Drawing.Point(259, 104);
            this.LBL_Backgroundimage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_Backgroundimage.Name = "LBL_Backgroundimage";
            this.LBL_Backgroundimage.Size = new System.Drawing.Size(86, 13);
            this.LBL_Backgroundimage.TabIndex = 6;
            this.LBL_Backgroundimage.Text = "PLACEHOLDER";
            this.LBL_Backgroundimage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LBL_Backgroundimage.UseMnemonic = false;
            this.LBL_Backgroundimage.Visible = false;
            this.LBL_Backgroundimage.DragDrop += new System.Windows.Forms.DragEventHandler(this.ChangeBackgroundImage_DragDrop);
            this.LBL_Backgroundimage.DragEnter += new System.Windows.Forms.DragEventHandler(this.ChangeBackgroundImage_DragEnter);
            this.LBL_Backgroundimage.Resize += new System.EventHandler(this.LBL_Backgroundimage_Resize);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(25)))));
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 10);
            this.panel1.TabIndex = 35;
            // 
            // chkFog
            // 
            this.chkFog.Animated = true;
            this.chkFog.AutoSize = true;
            this.chkFog.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkFog.CheckedState.BorderRadius = 0;
            this.chkFog.CheckedState.BorderThickness = 0;
            this.chkFog.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkFog.Location = new System.Drawing.Point(22, 196);
            this.chkFog.Name = "chkFog";
            this.chkFog.Size = new System.Drawing.Size(80, 17);
            this.chkFog.TabIndex = 36;
            this.chkFog.Text = "Enable Fog";
            this.chkFog.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkFog.UncheckedState.BorderRadius = 0;
            this.chkFog.UncheckedState.BorderThickness = 0;
            this.chkFog.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkFog.CheckedChanged += new System.EventHandler(this.chkFog_CheckedChanged);
            // 
            // chkSkyrimLogo
            // 
            this.chkSkyrimLogo.Animated = true;
            this.chkSkyrimLogo.AutoSize = true;
            this.chkSkyrimLogo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkSkyrimLogo.CheckedState.BorderRadius = 0;
            this.chkSkyrimLogo.CheckedState.BorderThickness = 0;
            this.chkSkyrimLogo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkSkyrimLogo.Location = new System.Drawing.Point(22, 230);
            this.chkSkyrimLogo.Name = "chkSkyrimLogo";
            this.chkSkyrimLogo.Size = new System.Drawing.Size(120, 17);
            this.chkSkyrimLogo.TabIndex = 37;
            this.chkSkyrimLogo.Text = "Enable Skyrim Logo";
            this.chkSkyrimLogo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkSkyrimLogo.UncheckedState.BorderRadius = 0;
            this.chkSkyrimLogo.UncheckedState.BorderThickness = 0;
            this.chkSkyrimLogo.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkSkyrimLogo.CheckedChanged += new System.EventHandler(this.chkSkyrimLogo_CheckedChanged);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 13;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.DisabledState.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(22, 357);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(308, 29);
            this.guna2Button2.TabIndex = 38;
            this.guna2Button2.Text = "Disable Replacers";
            this.guna2Button2.UseTransparentBackground = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tbNotifications);
            this.panel2.Location = new System.Drawing.Point(0, 390);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 62);
            this.panel2.TabIndex = 39;
            // 
            // tbNotifications
            // 
            this.tbNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNotifications.Location = new System.Drawing.Point(0, 0);
            this.tbNotifications.Multiline = true;
            this.tbNotifications.Name = "tbNotifications";
            this.tbNotifications.ReadOnly = true;
            this.tbNotifications.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNotifications.Size = new System.Drawing.Size(665, 62);
            this.tbNotifications.TabIndex = 0;
            // 
            // btnRemoveMusic
            // 
            this.btnRemoveMusic.Animated = true;
            this.btnRemoveMusic.AutoRoundedCorners = true;
            this.btnRemoveMusic.BorderRadius = 13;
            this.btnRemoveMusic.CheckedState.Parent = this.btnRemoveMusic;
            this.btnRemoveMusic.CustomImages.Parent = this.btnRemoveMusic;
            this.btnRemoveMusic.DisabledState.Parent = this.btnRemoveMusic;
            this.btnRemoveMusic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveMusic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnRemoveMusic.HoverState.Parent = this.btnRemoveMusic;
            this.btnRemoveMusic.Location = new System.Drawing.Point(172, 152);
            this.btnRemoveMusic.Name = "btnRemoveMusic";
            this.btnRemoveMusic.ShadowDecoration.Parent = this.btnRemoveMusic;
            this.btnRemoveMusic.Size = new System.Drawing.Size(79, 29);
            this.btnRemoveMusic.TabIndex = 41;
            this.btnRemoveMusic.Text = "Remove";
            this.btnRemoveMusic.Click += new System.EventHandler(this.btnRemoveMusic_Click);
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.Animated = true;
            this.btnRemoveImage.AutoRoundedCorners = true;
            this.btnRemoveImage.BorderRadius = 13;
            this.btnRemoveImage.CheckedState.Parent = this.btnRemoveImage;
            this.btnRemoveImage.CustomImages.Parent = this.btnRemoveImage;
            this.btnRemoveImage.DisabledState.Parent = this.btnRemoveImage;
            this.btnRemoveImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnRemoveImage.HoverState.Parent = this.btnRemoveImage;
            this.btnRemoveImage.Location = new System.Drawing.Point(172, 96);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.ShadowDecoration.Parent = this.btnRemoveImage;
            this.btnRemoveImage.Size = new System.Drawing.Size(79, 29);
            this.btnRemoveImage.TabIndex = 40;
            this.btnRemoveImage.Text = "Remove";
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // pbFog
            // 
            this.pbFog.BackColor = System.Drawing.Color.Transparent;
            this.pbFog.Image = global::SONGGARDE.Properties.Resources.fog;
            this.pbFog.ImageRotate = 0F;
            this.pbFog.Location = new System.Drawing.Point(409, 234);
            this.pbFog.Name = "pbFog";
            this.pbFog.ShadowDecoration.Parent = this.pbFog;
            this.pbFog.Size = new System.Drawing.Size(224, 140);
            this.pbFog.TabIndex = 43;
            this.pbFog.TabStop = false;
            this.pbFog.UseTransparentBackground = true;
            this.pbFog.Visible = false;
            // 
            // pbSkyrimLogo
            // 
            this.pbSkyrimLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbSkyrimLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSkyrimLogo.Image = global::SONGGARDE.Properties.Resources.SkyrimSymbol;
            this.pbSkyrimLogo.ImageRotate = 0F;
            this.pbSkyrimLogo.Location = new System.Drawing.Point(460, 244);
            this.pbSkyrimLogo.Name = "pbSkyrimLogo";
            this.pbSkyrimLogo.ShadowDecoration.Parent = this.pbSkyrimLogo;
            this.pbSkyrimLogo.Size = new System.Drawing.Size(66, 83);
            this.pbSkyrimLogo.TabIndex = 42;
            this.pbSkyrimLogo.TabStop = false;
            this.pbSkyrimLogo.UseTransparentBackground = true;
            this.pbSkyrimLogo.Visible = false;
            // 
            // PB_Icon
            // 
            this.PB_Icon.BackColor = System.Drawing.Color.Transparent;
            this.PB_Icon.BackgroundImage = global::SONGGARDE.Properties.Resources.SONGGARDE;
            this.PB_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_Icon.Location = new System.Drawing.Point(2, 2);
            this.PB_Icon.Margin = new System.Windows.Forms.Padding(10);
            this.PB_Icon.Name = "PB_Icon";
            this.PB_Icon.Padding = new System.Windows.Forms.Padding(10);
            this.PB_Icon.Size = new System.Drawing.Size(30, 30);
            this.PB_Icon.TabIndex = 32;
            this.PB_Icon.TabStop = false;
            this.PB_Icon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PNL_TopWindow_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::SONGGARDE.Properties.Resources.SONGGARDE_Image_SchwungObenLang;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(190, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(475, 34);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PNL_TopWindow_MouseMove);
            // 
            // PB_Play
            // 
            this.PB_Play.BackColor = System.Drawing.Color.Transparent;
            this.PB_Play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB_Play.BackgroundImage")));
            this.PB_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB_Play.Location = new System.Drawing.Point(469, 256);
            this.PB_Play.Margin = new System.Windows.Forms.Padding(23, 20, 23, 20);
            this.PB_Play.Name = "PB_Play";
            this.PB_Play.Padding = new System.Windows.Forms.Padding(23, 20, 23, 20);
            this.PB_Play.Size = new System.Drawing.Size(113, 58);
            this.PB_Play.TabIndex = 4;
            this.PB_Play.TabStop = false;
            this.PB_Play.Visible = false;
            this.PB_Play.Click += new System.EventHandler(this.PB_Play_Click);
            // 
            // PB_Preview
            // 
            this.PB_Preview.BackColor = System.Drawing.Color.Transparent;
            this.PB_Preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PB_Preview.Location = new System.Drawing.Point(409, 230);
            this.PB_Preview.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PB_Preview.Name = "PB_Preview";
            this.PB_Preview.Padding = new System.Windows.Forms.Padding(23, 20, 23, 20);
            this.PB_Preview.Size = new System.Drawing.Size(224, 116);
            this.PB_Preview.TabIndex = 2;
            this.PB_Preview.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SONGGARDE.Properties.Resources.SONGGARDE_Image_Schwung;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 81);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(665, 452);
            this.ContextMenuStrip = this.CMS_Main;
            this.Controls.Add(this.pbFog);
            this.Controls.Add(this.pbSkyrimLogo);
            this.Controls.Add(this.btnRemoveMusic);
            this.Controls.Add(this.btnRemoveImage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.chkSkyrimLogo);
            this.Controls.Add(this.chkFog);
            this.Controls.Add(this.PNL_TopWindow);
            this.Controls.Add(this.TB_SkyrimPath);
            this.Controls.Add(this.BTN_ChangeDirectory);
            this.Controls.Add(this.BTN_ChangeTitleMusic);
            this.Controls.Add(this.BTN_ChangeBackgroundimage);
            this.Controls.Add(this.BTN_ExportSTAM);
            this.Controls.Add(this.CB_STAM);
            this.Controls.Add(this.LBL_Backgroundimage);
            this.Controls.Add(this.LBL_TitleMusic);
            this.Controls.Add(this.PB_Play);
            this.Controls.Add(this.LBL_Preview);
            this.Controls.Add(this.PB_Preview);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FRM_Main";
            this.Text = "SONGGARDE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Main_FormClosing);
            this.Load += new System.EventHandler(this.FRM_Main_Load);
            this.PNL_TopWindow.ResumeLayout(false);
            this.PNL_TopWindow.PerformLayout();
            this.CMS_Main.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkyrimLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Preview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PB_Preview;
        private System.Windows.Forms.Label LBL_Preview;
        private System.Windows.Forms.PictureBox PB_Play;
        private Guna.UI2.WinForms.Guna2ComboBox CB_STAM;
        private Guna.UI2.WinForms.Guna2Button BTN_ExportSTAM;
        private Guna.UI2.WinForms.Guna2Button BTN_ChangeBackgroundimage;
        private Guna.UI2.WinForms.Guna2Button BTN_ChangeTitleMusic;
        private Guna.UI2.WinForms.Guna2Button BTN_ChangeDirectory;
        private Guna.UI2.WinForms.Guna2TextBox TB_SkyrimPath;
        private System.Windows.Forms.Panel PNL_TopWindow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2ShadowForm FRM_Shadow;
        private Guna.UI2.WinForms.Guna2Button BTN_Close;
        private System.Windows.Forms.PictureBox PB_Icon;
        private System.Windows.Forms.Label LBL_Titlebar;
        private System.Windows.Forms.ContextMenuStrip CMS_Main;
        private System.Windows.Forms.ToolStripMenuItem changelogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nexuswebsiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label LBL_TitleMusic;
        private System.Windows.Forms.Label LBL_Backgroundimage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupFormToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2CheckBox chkSkyrimLogo;
        private Guna.UI2.WinForms.Guna2CheckBox chkFog;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnRemoveMusic;
        private Guna.UI2.WinForms.Guna2Button btnRemoveImage;
        public System.Windows.Forms.TextBox tbNotifications;
        private Guna.UI2.WinForms.Guna2PictureBox pbSkyrimLogo;
        private Guna.UI2.WinForms.Guna2PictureBox pbFog;
    }
}

