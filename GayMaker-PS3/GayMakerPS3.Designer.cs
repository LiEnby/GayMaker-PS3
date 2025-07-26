namespace GayMaker_PS3
{
    partial class GayMakerPS3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GayMakerPS3));
            this.xmbScreen = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.GameSettings = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.VersionSelect = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GlobalGameSettings = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.titleName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.titleID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contentID = new System.Windows.Forms.TextBox();
            this.browsePic = new System.Windows.Forms.Button();
            this.picPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.browseIcon = new System.Windows.Forms.Button();
            this.iconPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.browseProject = new System.Windows.Forms.Button();
            this.projectPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CreatePKG = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GmacOut = new System.Windows.Forms.TextBox();
            this.xmbPreview = new System.Windows.Forms.Panel();
            this.ps3Icon = new System.Windows.Forms.PictureBox();
            this.gameIcon = new System.Windows.Forms.PictureBox();
            this.IconPreview2 = new System.Windows.Forms.PictureBox();
            this.IconPreview = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.folderIcon = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.GameSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.xmbPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ps3Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPreview2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // xmbScreen
            // 
            this.xmbScreen.AutoSize = true;
            this.xmbScreen.Location = new System.Drawing.Point(69, 4);
            this.xmbScreen.Name = "xmbScreen";
            this.xmbScreen.Size = new System.Drawing.Size(48, 17);
            this.xmbScreen.TabIndex = 0;
            this.xmbScreen.TabStop = true;
            this.xmbScreen.Text = "XMB";
            this.xmbScreen.UseVisualStyleBackColor = true;
            this.xmbScreen.CheckedChanged += new System.EventHandler(this.homeScreen_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Preview:";
            // 
            // GameSettings
            // 
            this.GameSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GameSettings.Controls.Add(this.label8);
            this.GameSettings.Controls.Add(this.VersionSelect);
            this.GameSettings.Controls.Add(this.pictureBox1);
            this.GameSettings.Controls.Add(this.GlobalGameSettings);
            this.GameSettings.Controls.Add(this.label7);
            this.GameSettings.Controls.Add(this.titleName);
            this.GameSettings.Controls.Add(this.label6);
            this.GameSettings.Controls.Add(this.titleID);
            this.GameSettings.Controls.Add(this.label5);
            this.GameSettings.Controls.Add(this.contentID);
            this.GameSettings.Controls.Add(this.browsePic);
            this.GameSettings.Controls.Add(this.picPath);
            this.GameSettings.Controls.Add(this.label4);
            this.GameSettings.Controls.Add(this.browseIcon);
            this.GameSettings.Controls.Add(this.iconPath);
            this.GameSettings.Controls.Add(this.label3);
            this.GameSettings.Controls.Add(this.browseProject);
            this.GameSettings.Controls.Add(this.projectPath);
            this.GameSettings.Controls.Add(this.label2);
            this.GameSettings.Location = new System.Drawing.Point(981, 25);
            this.GameSettings.Name = "GameSettings";
            this.GameSettings.Size = new System.Drawing.Size(355, 301);
            this.GameSettings.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "GM Version:";
            // 
            // VersionSelect
            // 
            this.VersionSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VersionSelect.FormattingEnabled = true;
            this.VersionSelect.Items.AddRange(new object[] {
            "1.4.9999"});
            this.VersionSelect.Location = new System.Drawing.Point(253, 270);
            this.VersionSelect.Name = "VersionSelect";
            this.VersionSelect.Size = new System.Drawing.Size(103, 21);
            this.VersionSelect.TabIndex = 17;
            this.VersionSelect.SelectedIndexChanged += new System.EventHandler(this.VersionSelect_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(6, 272);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 18);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // GlobalGameSettings
            // 
            this.GlobalGameSettings.AutoSize = true;
            this.GlobalGameSettings.Enabled = false;
            this.GlobalGameSettings.Location = new System.Drawing.Point(29, 276);
            this.GlobalGameSettings.Name = "GlobalGameSettings";
            this.GlobalGameSettings.Size = new System.Drawing.Size(109, 13);
            this.GlobalGameSettings.TabIndex = 15;
            this.GlobalGameSettings.Text = "Global Game Settings";
            this.GlobalGameSettings.DoubleClick += new System.EventHandler(this.GlobalGameSettings_DoubleClick);
            this.GlobalGameSettings.MouseEnter += new System.EventHandler(this.GlobalGameSettings_MouseEnter);
            this.GlobalGameSettings.MouseLeave += new System.EventHandler(this.GlobalGameSettings_MouseLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Title:";
            // 
            // titleName
            // 
            this.titleName.Location = new System.Drawing.Point(6, 186);
            this.titleName.MaxLength = 40;
            this.titleName.Multiline = true;
            this.titleName.Name = "titleName";
            this.titleName.Size = new System.Drawing.Size(355, 78);
            this.titleName.TabIndex = 13;
            this.titleName.Text = "GameMaker: Studio";
            this.titleName.TextChanged += new System.EventHandler(this.titleName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Title ID:";
            // 
            // titleID
            // 
            this.titleID.Location = new System.Drawing.Point(262, 147);
            this.titleID.Name = "titleID";
            this.titleID.ReadOnly = true;
            this.titleID.Size = new System.Drawing.Size(100, 20);
            this.titleID.TabIndex = 11;
            this.titleID.Text = "NPXS00020";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Content ID:";
            // 
            // contentID
            // 
            this.contentID.Location = new System.Drawing.Point(3, 147);
            this.contentID.MaxLength = 36;
            this.contentID.Name = "contentID";
            this.contentID.Size = new System.Drawing.Size(253, 20);
            this.contentID.TabIndex = 9;
            this.contentID.Text = "IV0000-NPXS00020_00-GAMEMAKERSTUDIO0";
            this.contentID.TextChanged += new System.EventHandler(this.contentID_TextChanged);
            // 
            // browsePic
            // 
            this.browsePic.Location = new System.Drawing.Point(280, 108);
            this.browsePic.Name = "browsePic";
            this.browsePic.Size = new System.Drawing.Size(75, 23);
            this.browsePic.TabIndex = 8;
            this.browsePic.Text = "Browse";
            this.browsePic.UseVisualStyleBackColor = true;
            this.browsePic.Click += new System.EventHandler(this.browsePic_Click);
            // 
            // picPath
            // 
            this.picPath.Location = new System.Drawing.Point(6, 108);
            this.picPath.Name = "picPath";
            this.picPath.ReadOnly = true;
            this.picPath.Size = new System.Drawing.Size(268, 20);
            this.picPath.TabIndex = 7;
            this.picPath.Text = "img\\pic1.png";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "PIC1.PNG (PNG 1920x1080):";
            // 
            // browseIcon
            // 
            this.browseIcon.Location = new System.Drawing.Point(280, 66);
            this.browseIcon.Name = "browseIcon";
            this.browseIcon.Size = new System.Drawing.Size(75, 23);
            this.browseIcon.TabIndex = 5;
            this.browseIcon.Text = "Browse";
            this.browseIcon.UseVisualStyleBackColor = true;
            this.browseIcon.Click += new System.EventHandler(this.browseIcon_Click);
            // 
            // iconPath
            // 
            this.iconPath.Location = new System.Drawing.Point(6, 69);
            this.iconPath.Name = "iconPath";
            this.iconPath.ReadOnly = true;
            this.iconPath.Size = new System.Drawing.Size(268, 20);
            this.iconPath.TabIndex = 4;
            this.iconPath.Text = "img\\icon0.png";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ICON0.PNG (PNG 320x176):";
            // 
            // browseProject
            // 
            this.browseProject.Location = new System.Drawing.Point(280, 28);
            this.browseProject.Name = "browseProject";
            this.browseProject.Size = new System.Drawing.Size(75, 23);
            this.browseProject.TabIndex = 2;
            this.browseProject.Text = "Browse";
            this.browseProject.UseVisualStyleBackColor = true;
            this.browseProject.Click += new System.EventHandler(this.browseProject_Click);
            // 
            // projectPath
            // 
            this.projectPath.Location = new System.Drawing.Point(6, 30);
            this.projectPath.Name = "projectPath";
            this.projectPath.ReadOnly = true;
            this.projectPath.Size = new System.Drawing.Size(268, 20);
            this.projectPath.TabIndex = 1;
            this.projectPath.Text = "(none)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Project File (.gmx):";
            // 
            // CreatePKG
            // 
            this.CreatePKG.Enabled = false;
            this.CreatePKG.Location = new System.Drawing.Point(1022, 544);
            this.CreatePKG.Name = "CreatePKG";
            this.CreatePKG.Size = new System.Drawing.Size(257, 23);
            this.CreatePKG.TabIndex = 9;
            this.CreatePKG.Text = "Make PKG";
            this.CreatePKG.UseVisualStyleBackColor = true;
            this.CreatePKG.Click += new System.EventHandler(this.CreatePKG_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.GmacOut);
            this.panel1.Location = new System.Drawing.Point(3, 573);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 107);
            this.panel1.TabIndex = 10;
            // 
            // GmacOut
            // 
            this.GmacOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GmacOut.Location = new System.Drawing.Point(0, 0);
            this.GmacOut.Multiline = true;
            this.GmacOut.Name = "GmacOut";
            this.GmacOut.ReadOnly = true;
            this.GmacOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GmacOut.Size = new System.Drawing.Size(1329, 103);
            this.GmacOut.TabIndex = 0;
            // 
            // xmbPreview
            // 
            this.xmbPreview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xmbPreview.BackgroundImage")));
            this.xmbPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.xmbPreview.Controls.Add(this.ps3Icon);
            this.xmbPreview.Controls.Add(this.gameIcon);
            this.xmbPreview.Controls.Add(this.IconPreview2);
            this.xmbPreview.Controls.Add(this.IconPreview);
            this.xmbPreview.Controls.Add(this.Title);
            this.xmbPreview.Controls.Add(this.folderIcon);
            this.xmbPreview.Location = new System.Drawing.Point(15, 20);
            this.xmbPreview.Name = "xmbPreview";
            this.xmbPreview.Size = new System.Drawing.Size(960, 544);
            this.xmbPreview.TabIndex = 6;
            // 
            // ps3Icon
            // 
            this.ps3Icon.BackColor = System.Drawing.Color.Transparent;
            this.ps3Icon.Image = global::GayMaker_PS3.Properties.Resources.ps3Logo;
            this.ps3Icon.Location = new System.Drawing.Point(662, 267);
            this.ps3Icon.Name = "ps3Icon";
            this.ps3Icon.Size = new System.Drawing.Size(58, 13);
            this.ps3Icon.TabIndex = 14;
            this.ps3Icon.TabStop = false;
            // 
            // gameIcon
            // 
            this.gameIcon.BackColor = System.Drawing.Color.Transparent;
            this.gameIcon.Image = global::GayMaker_PS3.Properties.Resources.gameIcon;
            this.gameIcon.Location = new System.Drawing.Point(86, 125);
            this.gameIcon.Name = "gameIcon";
            this.gameIcon.Size = new System.Drawing.Size(61, 40);
            this.gameIcon.TabIndex = 13;
            this.gameIcon.TabStop = false;
            // 
            // IconPreview2
            // 
            this.IconPreview2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IconPreview2.BackgroundImage")));
            this.IconPreview2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IconPreview2.Location = new System.Drawing.Point(209, 203);
            this.IconPreview2.Name = "IconPreview2";
            this.IconPreview2.Size = new System.Drawing.Size(169, 97);
            this.IconPreview2.TabIndex = 12;
            this.IconPreview2.TabStop = false;
            // 
            // IconPreview
            // 
            this.IconPreview.BackColor = System.Drawing.Color.Transparent;
            this.IconPreview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IconPreview.BackgroundImage")));
            this.IconPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IconPreview.Location = new System.Drawing.Point(67, 228);
            this.IconPreview.Name = "IconPreview";
            this.IconPreview.Size = new System.Drawing.Size(97, 56);
            this.IconPreview.TabIndex = 10;
            this.IconPreview.TabStop = false;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(392, 227);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(309, 23);
            this.Title.TabIndex = 11;
            this.Title.Text = "GameMaker: Studio";
            // 
            // folderIcon
            // 
            this.folderIcon.BackColor = System.Drawing.Color.Transparent;
            this.folderIcon.Image = global::GayMaker_PS3.Properties.Resources.folderIcon;
            this.folderIcon.Location = new System.Drawing.Point(64, 216);
            this.folderIcon.Name = "folderIcon";
            this.folderIcon.Size = new System.Drawing.Size(111, 72);
            this.folderIcon.TabIndex = 15;
            this.folderIcon.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(1022, 332);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(257, 206);
            this.Logo.TabIndex = 8;
            this.Logo.TabStop = false;
            // 
            // GayMakerPS3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1344, 691);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CreatePKG);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.GameSettings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xmbScreen);
            this.Controls.Add(this.xmbPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GayMakerPS3";
            this.Text = "GayMaker: PS3 v";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GayMakerPs3_FormClosing);
            this.Load += new System.EventHandler(this.GayMakerPs3_Load);
            this.GameSettings.ResumeLayout(false);
            this.GameSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.xmbPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ps3Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPreview2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton xmbScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel GameSettings;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button CreatePKG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox GmacOut;
        private System.Windows.Forms.Button browseProject;
        private System.Windows.Forms.TextBox projectPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseIcon;
        private System.Windows.Forms.TextBox iconPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox titleName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox titleID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox contentID;
        private System.Windows.Forms.Button browsePic;
        private System.Windows.Forms.TextBox picPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel xmbPreview;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label GlobalGameSettings;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox VersionSelect;
        private System.Windows.Forms.PictureBox ps3Icon;
        private System.Windows.Forms.PictureBox gameIcon;
        private System.Windows.Forms.PictureBox IconPreview2;
        private System.Windows.Forms.PictureBox IconPreview;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox folderIcon;
    }
}

