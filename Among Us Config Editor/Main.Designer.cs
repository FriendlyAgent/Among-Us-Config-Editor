namespace Among_Us_Config_Editor
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnSave = new System.Windows.Forms.Button();
            this.tpCosmetics = new System.Windows.Forms.TabPage();
            this.cbInvisible = new System.Windows.Forms.CheckBox();
            this.lblCostume = new System.Windows.Forms.Label();
            this.lblHat = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPet = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pbHat = new System.Windows.Forms.PictureBox();
            this.pbCostume = new System.Windows.Forms.PictureBox();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.pbPet = new System.Windows.Forms.PictureBox();
            this.cbCostume = new System.Windows.Forms.ComboBox();
            this.cbHat = new System.Windows.Forms.ComboBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbPet = new System.Windows.Forms.ComboBox();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblMusicVolume = new System.Windows.Forms.Label();
            this.lblSfcVolume = new System.Windows.Forms.Label();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.rbMouseAndKeyboard = new System.Windows.Forms.RadioButton();
            this.rbMouse = new System.Windows.Forms.RadioButton();
            this.cbCensorChat = new System.Windows.Forms.CheckBox();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.cbVSync = new System.Windows.Forms.CheckBox();
            this.tbMusicVolume = new System.Windows.Forms.TrackBar();
            this.tbSfxVolume = new System.Windows.Forms.TrackBar();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.lblVersionCurrent = new System.Windows.Forms.Label();
            this.lblCreatedName = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.llbSourceRepository = new System.Windows.Forms.LinkLabel();
            this.lblUrls = new System.Windows.Forms.Label();
            this.llbProjectSite = new System.Windows.Forms.LinkLabel();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.tpCosmetics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCostume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPet)).BeginInit();
            this.tcMain.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.gbControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMusicVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSfxVolume)).BeginInit();
            this.tpAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(310, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tpCosmetics
            // 
            this.tpCosmetics.Controls.Add(this.cbInvisible);
            this.tpCosmetics.Controls.Add(this.lblCostume);
            this.tpCosmetics.Controls.Add(this.lblHat);
            this.tpCosmetics.Controls.Add(this.lblColor);
            this.tpCosmetics.Controls.Add(this.lblPet);
            this.tpCosmetics.Controls.Add(this.lblName);
            this.tpCosmetics.Controls.Add(this.pbHat);
            this.tpCosmetics.Controls.Add(this.pbCostume);
            this.tpCosmetics.Controls.Add(this.pbColor);
            this.tpCosmetics.Controls.Add(this.pbPet);
            this.tpCosmetics.Controls.Add(this.cbCostume);
            this.tpCosmetics.Controls.Add(this.cbHat);
            this.tpCosmetics.Controls.Add(this.cbColor);
            this.tpCosmetics.Controls.Add(this.txtName);
            this.tpCosmetics.Controls.Add(this.cbPet);
            this.tpCosmetics.Location = new System.Drawing.Point(4, 24);
            this.tpCosmetics.Name = "tpCosmetics";
            this.tpCosmetics.Padding = new System.Windows.Forms.Padding(3);
            this.tpCosmetics.Size = new System.Drawing.Size(365, 367);
            this.tpCosmetics.TabIndex = 0;
            this.tpCosmetics.Text = "Cosmetics";
            this.tpCosmetics.UseVisualStyleBackColor = true;
            // 
            // cbInvisible
            // 
            this.cbInvisible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbInvisible.AutoSize = true;
            this.cbInvisible.Location = new System.Drawing.Point(291, 6);
            this.cbInvisible.Name = "cbInvisible";
            this.cbInvisible.Size = new System.Drawing.Size(69, 19);
            this.cbInvisible.TabIndex = 14;
            this.cbInvisible.Text = "Invisible";
            this.cbInvisible.UseVisualStyleBackColor = true;
            this.cbInvisible.CheckStateChanged += new System.EventHandler(this.cbInvisible_CheckStateChanged);
            // 
            // lblCostume
            // 
            this.lblCostume.AutoSize = true;
            this.lblCostume.Location = new System.Drawing.Point(3, 122);
            this.lblCostume.Name = "lblCostume";
            this.lblCostume.Size = new System.Drawing.Size(58, 15);
            this.lblCostume.TabIndex = 12;
            this.lblCostume.Text = "Costume:";
            // 
            // lblHat
            // 
            this.lblHat.AutoSize = true;
            this.lblHat.Location = new System.Drawing.Point(3, 93);
            this.lblHat.Name = "lblHat";
            this.lblHat.Size = new System.Drawing.Size(29, 15);
            this.lblHat.TabIndex = 11;
            this.lblHat.Text = "Hat:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(3, 64);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(39, 15);
            this.lblColor.TabIndex = 10;
            this.lblColor.Text = "Color:";
            // 
            // lblPet
            // 
            this.lblPet.AutoSize = true;
            this.lblPet.Location = new System.Drawing.Point(3, 35);
            this.lblPet.Name = "lblPet";
            this.lblPet.Size = new System.Drawing.Size(27, 15);
            this.lblPet.TabIndex = 9;
            this.lblPet.Text = "Pet:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 15);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name:";
            // 
            // pbHat
            // 
            this.pbHat.Location = new System.Drawing.Point(267, 148);
            this.pbHat.Name = "pbHat";
            this.pbHat.Size = new System.Drawing.Size(95, 105);
            this.pbHat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbHat.TabIndex = 7;
            this.pbHat.TabStop = false;
            // 
            // pbCostume
            // 
            this.pbCostume.Location = new System.Drawing.Point(267, 259);
            this.pbCostume.Name = "pbCostume";
            this.pbCostume.Size = new System.Drawing.Size(95, 105);
            this.pbCostume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCostume.TabIndex = 7;
            this.pbCostume.TabStop = false;
            // 
            // pbColor
            // 
            this.pbColor.Location = new System.Drawing.Point(104, 148);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(157, 216);
            this.pbColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbColor.TabIndex = 6;
            this.pbColor.TabStop = false;
            // 
            // pbPet
            // 
            this.pbPet.Location = new System.Drawing.Point(3, 259);
            this.pbPet.Name = "pbPet";
            this.pbPet.Size = new System.Drawing.Size(95, 105);
            this.pbPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPet.TabIndex = 5;
            this.pbPet.TabStop = false;
            // 
            // cbCostume
            // 
            this.cbCostume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCostume.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCostume.FormattingEnabled = true;
            this.cbCostume.Location = new System.Drawing.Point(66, 119);
            this.cbCostume.Name = "cbCostume";
            this.cbCostume.Size = new System.Drawing.Size(294, 23);
            this.cbCostume.TabIndex = 4;
            this.cbCostume.SelectionChangeCommitted += new System.EventHandler(this.cbCostume_SelectionChangeCommitted);
            // 
            // cbHat
            // 
            this.cbHat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbHat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHat.FormattingEnabled = true;
            this.cbHat.Location = new System.Drawing.Point(66, 90);
            this.cbHat.Name = "cbHat";
            this.cbHat.Size = new System.Drawing.Size(294, 23);
            this.cbHat.TabIndex = 4;
            this.cbHat.SelectionChangeCommitted += new System.EventHandler(this.cbHat_SelectionChangeCommitted);
            // 
            // cbColor
            // 
            this.cbColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(66, 61);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(294, 23);
            this.cbColor.TabIndex = 4;
            this.cbColor.SelectionChangeCommitted += new System.EventHandler(this.cbColor_SelectionChangeCommitted);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(66, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 23);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // cbPet
            // 
            this.cbPet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPet.FormattingEnabled = true;
            this.cbPet.Location = new System.Drawing.Point(66, 33);
            this.cbPet.Name = "cbPet";
            this.cbPet.Size = new System.Drawing.Size(294, 23);
            this.cbPet.TabIndex = 4;
            this.cbPet.SelectionChangeCommitted += new System.EventHandler(this.cbPet_SelectionChangeCommitted);
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tpCosmetics);
            this.tcMain.Controls.Add(this.tpSettings);
            this.tcMain.Controls.Add(this.tpAbout);
            this.tcMain.Location = new System.Drawing.Point(12, 12);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(373, 395);
            this.tcMain.TabIndex = 1;
            this.tcMain.TabStop = false;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.lblLanguage);
            this.tpSettings.Controls.Add(this.lblMusicVolume);
            this.tpSettings.Controls.Add(this.lblSfcVolume);
            this.tpSettings.Controls.Add(this.gbControls);
            this.tpSettings.Controls.Add(this.cbCensorChat);
            this.tpSettings.Controls.Add(this.cbLanguage);
            this.tpSettings.Controls.Add(this.cbVSync);
            this.tpSettings.Controls.Add(this.tbMusicVolume);
            this.tpSettings.Controls.Add(this.tbSfxVolume);
            this.tpSettings.Location = new System.Drawing.Point(4, 24);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(365, 367);
            this.tpSettings.TabIndex = 3;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(3, 6);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(62, 15);
            this.lblLanguage.TabIndex = 8;
            this.lblLanguage.Text = "Language:";
            // 
            // lblMusicVolume
            // 
            this.lblMusicVolume.AutoSize = true;
            this.lblMusicVolume.Location = new System.Drawing.Point(3, 160);
            this.lblMusicVolume.Name = "lblMusicVolume";
            this.lblMusicVolume.Size = new System.Drawing.Size(85, 15);
            this.lblMusicVolume.TabIndex = 7;
            this.lblMusicVolume.Text = "Music Volume:";
            // 
            // lblSfcVolume
            // 
            this.lblSfcVolume.AutoSize = true;
            this.lblSfcVolume.Location = new System.Drawing.Point(3, 109);
            this.lblSfcVolume.Name = "lblSfcVolume";
            this.lblSfcVolume.Size = new System.Drawing.Size(72, 15);
            this.lblSfcVolume.TabIndex = 6;
            this.lblSfcVolume.Text = "SFX Volume:";
            // 
            // gbControls
            // 
            this.gbControls.Controls.Add(this.rbMouseAndKeyboard);
            this.gbControls.Controls.Add(this.rbMouse);
            this.gbControls.Location = new System.Drawing.Point(100, 32);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(262, 71);
            this.gbControls.TabIndex = 5;
            this.gbControls.TabStop = false;
            this.gbControls.Text = "Controls";
            // 
            // rbMouseAndKeyboard
            // 
            this.rbMouseAndKeyboard.AutoSize = true;
            this.rbMouseAndKeyboard.Location = new System.Drawing.Point(14, 47);
            this.rbMouseAndKeyboard.Name = "rbMouseAndKeyboard";
            this.rbMouseAndKeyboard.Size = new System.Drawing.Size(137, 19);
            this.rbMouseAndKeyboard.TabIndex = 1;
            this.rbMouseAndKeyboard.TabStop = true;
            this.rbMouseAndKeyboard.Text = "Mouse and Keyboard";
            this.rbMouseAndKeyboard.UseVisualStyleBackColor = true;
            this.rbMouseAndKeyboard.CheckedChanged += new System.EventHandler(this.rbControls_CheckedChanged);
            // 
            // rbMouse
            // 
            this.rbMouse.AutoSize = true;
            this.rbMouse.Location = new System.Drawing.Point(14, 22);
            this.rbMouse.Name = "rbMouse";
            this.rbMouse.Size = new System.Drawing.Size(61, 19);
            this.rbMouse.TabIndex = 0;
            this.rbMouse.TabStop = true;
            this.rbMouse.Text = "Mouse";
            this.rbMouse.UseVisualStyleBackColor = true;
            this.rbMouse.CheckedChanged += new System.EventHandler(this.rbControls_CheckedChanged);
            // 
            // cbCensorChat
            // 
            this.cbCensorChat.AutoSize = true;
            this.cbCensorChat.Location = new System.Drawing.Point(3, 32);
            this.cbCensorChat.Name = "cbCensorChat";
            this.cbCensorChat.Size = new System.Drawing.Size(91, 19);
            this.cbCensorChat.TabIndex = 4;
            this.cbCensorChat.Text = "Censor Chat";
            this.cbCensorChat.UseVisualStyleBackColor = true;
            this.cbCensorChat.CheckStateChanged += new System.EventHandler(this.cbCensorChat_CheckStateChanged);
            // 
            // cbLanguage
            // 
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(94, 3);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(268, 23);
            this.cbLanguage.TabIndex = 3;
            this.cbLanguage.SelectionChangeCommitted += new System.EventHandler(this.cbLanguage_SelectionChangeCommitted);
            // 
            // cbVSync
            // 
            this.cbVSync.AutoSize = true;
            this.cbVSync.Location = new System.Drawing.Point(3, 57);
            this.cbVSync.Name = "cbVSync";
            this.cbVSync.Size = new System.Drawing.Size(63, 19);
            this.cbVSync.TabIndex = 2;
            this.cbVSync.Text = "V-Sync";
            this.cbVSync.UseVisualStyleBackColor = true;
            this.cbVSync.CheckStateChanged += new System.EventHandler(this.cbVSync_CheckStateChanged);
            // 
            // tbMusicVolume
            // 
            this.tbMusicVolume.BackColor = System.Drawing.SystemColors.Window;
            this.tbMusicVolume.Location = new System.Drawing.Point(94, 160);
            this.tbMusicVolume.Maximum = 100;
            this.tbMusicVolume.Name = "tbMusicVolume";
            this.tbMusicVolume.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbMusicVolume.Size = new System.Drawing.Size(268, 45);
            this.tbMusicVolume.TabIndex = 0;
            this.tbMusicVolume.TickFrequency = 10;
            this.tbMusicVolume.Value = 100;
            this.tbMusicVolume.ValueChanged += new System.EventHandler(this.tbMusicVolume_ValueChanged);
            // 
            // tbSfxVolume
            // 
            this.tbSfxVolume.BackColor = System.Drawing.SystemColors.Window;
            this.tbSfxVolume.Location = new System.Drawing.Point(94, 109);
            this.tbSfxVolume.Maximum = 100;
            this.tbSfxVolume.Name = "tbSfxVolume";
            this.tbSfxVolume.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbSfxVolume.Size = new System.Drawing.Size(268, 45);
            this.tbSfxVolume.TabIndex = 0;
            this.tbSfxVolume.TickFrequency = 10;
            this.tbSfxVolume.Value = 100;
            this.tbSfxVolume.ValueChanged += new System.EventHandler(this.tbSfxVolume_ValueChanged);
            // 
            // tpAbout
            // 
            this.tpAbout.Controls.Add(this.lblVersionCurrent);
            this.tpAbout.Controls.Add(this.lblCreatedName);
            this.tpAbout.Controls.Add(this.lblVersion);
            this.tpAbout.Controls.Add(this.llbSourceRepository);
            this.tpAbout.Controls.Add(this.lblUrls);
            this.tpAbout.Controls.Add(this.llbProjectSite);
            this.tpAbout.Controls.Add(this.lblCreatedBy);
            this.tpAbout.Location = new System.Drawing.Point(4, 24);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tpAbout.Size = new System.Drawing.Size(365, 367);
            this.tpAbout.TabIndex = 2;
            this.tpAbout.Text = "About";
            this.tpAbout.UseVisualStyleBackColor = true;
            // 
            // lblVersionCurrent
            // 
            this.lblVersionCurrent.AutoSize = true;
            this.lblVersionCurrent.Location = new System.Drawing.Point(79, 22);
            this.lblVersionCurrent.Name = "lblVersionCurrent";
            this.lblVersionCurrent.Size = new System.Drawing.Size(40, 15);
            this.lblVersionCurrent.TabIndex = 4;
            this.lblVersionCurrent.Text = "1.0.0.0";
            // 
            // lblCreatedName
            // 
            this.lblCreatedName.AutoSize = true;
            this.lblCreatedName.Location = new System.Drawing.Point(79, 7);
            this.lblCreatedName.Name = "lblCreatedName";
            this.lblCreatedName.Size = new System.Drawing.Size(81, 15);
            this.lblCreatedName.TabIndex = 3;
            this.lblCreatedName.Text = "FriendlyAgent";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(3, 22);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(48, 15);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version:";
            // 
            // llbSourceRepository
            // 
            this.llbSourceRepository.AutoSize = true;
            this.llbSourceRepository.Location = new System.Drawing.Point(79, 52);
            this.llbSourceRepository.Name = "llbSourceRepository";
            this.llbSourceRepository.Size = new System.Drawing.Size(102, 15);
            this.llbSourceRepository.TabIndex = 1;
            this.llbSourceRepository.TabStop = true;
            this.llbSourceRepository.Text = "Source Repository";
            this.llbSourceRepository.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSourceRepository_LinkClicked);
            // 
            // lblUrls
            // 
            this.lblUrls.AutoSize = true;
            this.lblUrls.Location = new System.Drawing.Point(3, 37);
            this.lblUrls.Name = "lblUrls";
            this.lblUrls.Size = new System.Drawing.Size(70, 15);
            this.lblUrls.TabIndex = 0;
            this.lblUrls.Text = "Project Urls:";
            // 
            // llbProjectSite
            // 
            this.llbProjectSite.AutoSize = true;
            this.llbProjectSite.Location = new System.Drawing.Point(79, 37);
            this.llbProjectSite.Name = "llbProjectSite";
            this.llbProjectSite.Size = new System.Drawing.Size(66, 15);
            this.llbProjectSite.TabIndex = 1;
            this.llbProjectSite.TabStop = true;
            this.llbProjectSite.Text = "Project Site";
            this.llbProjectSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbProjectSite_LinkClicked);
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Location = new System.Drawing.Point(3, 7);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(67, 15);
            this.lblCreatedBy.TabIndex = 0;
            this.lblCreatedBy.Text = "Created By:";
            // 
            // btnLaunch
            // 
            this.btnLaunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLaunch.Location = new System.Drawing.Point(226, 415);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(75, 23);
            this.btnLaunch.TabIndex = 6;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 450);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Among Us Config Editor";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tpCosmetics.ResumeLayout(false);
            this.tpCosmetics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCostume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPet)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.tpSettings.ResumeLayout(false);
            this.tpSettings.PerformLayout();
            this.gbControls.ResumeLayout(false);
            this.gbControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMusicVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSfxVolume)).EndInit();
            this.tpAbout.ResumeLayout(false);
            this.tpAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tpCosmetics;
        private System.Windows.Forms.ComboBox cbCostume;
        private System.Windows.Forms.ComboBox cbHat;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbPet;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.PictureBox pbPet;
        private System.Windows.Forms.PictureBox pbColor;
        private System.Windows.Forms.PictureBox pbCostume;
        private System.Windows.Forms.PictureBox pbHat;
        private System.Windows.Forms.Label lblHat;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblPet;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCostume;
        private System.Windows.Forms.CheckBox cbInvisible;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.TabPage tpAbout;
        private System.Windows.Forms.LinkLabel llbProjectSite;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.LinkLabel llbSourceRepository;
        private System.Windows.Forms.Label lblUrls;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblCreatedName;
        private System.Windows.Forms.Label lblVersionCurrent;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.TrackBar tbSfxVolume;
        private System.Windows.Forms.TrackBar tbMusicVolume;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.CheckBox cbVSync;
        private System.Windows.Forms.CheckBox cbCensorChat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMouseAndKeyboard;
        private System.Windows.Forms.RadioButton rbMouse;
        private System.Windows.Forms.Label lblSfcVolume;
        private System.Windows.Forms.Label lblMusicVolume;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.GroupBox gbControls;
    }
}

