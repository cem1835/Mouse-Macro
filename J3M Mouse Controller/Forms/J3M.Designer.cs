namespace J3M_Mouse_Controller
{
    partial class J3M
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
            this.LeftPanel = new DevExpress.XtraEditors.SidePanel();
            this.SilentCheckBox = new System.Windows.Forms.CheckBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SettingMs = new DevExpress.XtraEditors.LabelControl();
            this.MsLabel = new DevExpress.XtraEditors.LabelControl();
            this.infolbl = new DevExpress.XtraEditors.LabelControl();
            this.MacroInfoLabel = new DevExpress.XtraEditors.LabelControl();
            this.gunLabel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.adver = new DevExpress.XtraEditors.LabelControl();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ScrollablePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.InfoLabel = new DevExpress.XtraEditors.LabelControl();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SingleBurst = new System.Windows.Forms.CheckBox();
            this.LeftPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.SingleBurst);
            this.LeftPanel.Controls.Add(this.SilentCheckBox);
            this.LeftPanel.Controls.Add(this.simpleButton1);
            this.LeftPanel.Controls.Add(this.SettingMs);
            this.LeftPanel.Controls.Add(this.MsLabel);
            this.LeftPanel.Controls.Add(this.infolbl);
            this.LeftPanel.Controls.Add(this.MacroInfoLabel);
            this.LeftPanel.Controls.Add(this.gunLabel);
            this.LeftPanel.Controls.Add(this.labelControl1);
            this.LeftPanel.Controls.Add(this.adver);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(225, 754);
            this.LeftPanel.TabIndex = 0;
            this.LeftPanel.Text = "Left Panel";
            // 
            // SilentCheckBox
            // 
            this.SilentCheckBox.AutoSize = true;
            this.SilentCheckBox.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.SilentCheckBox.ForeColor = System.Drawing.Color.White;
            this.SilentCheckBox.Location = new System.Drawing.Point(44, 709);
            this.SilentCheckBox.Name = "SilentCheckBox";
            this.SilentCheckBox.Size = new System.Drawing.Size(127, 21);
            this.SilentCheckBox.TabIndex = 10;
            this.SilentCheckBox.Text = "Sesleri Kapat";
            this.SilentCheckBox.UseVisualStyleBackColor = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(22, 626);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(171, 61);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Yeni Silah Ekle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // SettingMs
            // 
            this.SettingMs.Appearance.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.SettingMs.Appearance.ForeColor = System.Drawing.Color.White;
            this.SettingMs.Appearance.Options.UseFont = true;
            this.SettingMs.Appearance.Options.UseForeColor = true;
            this.SettingMs.Location = new System.Drawing.Point(26, 345);
            this.SettingMs.Name = "SettingMs";
            this.SettingMs.Size = new System.Drawing.Size(109, 16);
            this.SettingMs.TabIndex = 7;
            this.SettingMs.Text = "Makro Kapalı ..";
            // 
            // MsLabel
            // 
            this.MsLabel.Appearance.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.MsLabel.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.MsLabel.Appearance.Options.UseFont = true;
            this.MsLabel.Appearance.Options.UseForeColor = true;
            this.MsLabel.Location = new System.Drawing.Point(22, 323);
            this.MsLabel.Name = "MsLabel";
            this.MsLabel.Size = new System.Drawing.Size(149, 16);
            this.MsLabel.TabIndex = 6;
            this.MsLabel.Text = "Ayar Değiştirme Hızı";
            // 
            // infolbl
            // 
            this.infolbl.Appearance.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.infolbl.Appearance.ForeColor = System.Drawing.Color.White;
            this.infolbl.Appearance.Options.UseFont = true;
            this.infolbl.Appearance.Options.UseForeColor = true;
            this.infolbl.Location = new System.Drawing.Point(26, 270);
            this.infolbl.Name = "infolbl";
            this.infolbl.Size = new System.Drawing.Size(109, 16);
            this.infolbl.TabIndex = 5;
            this.infolbl.Text = "Makro Kapalı ..";
            // 
            // MacroInfoLabel
            // 
            this.MacroInfoLabel.Appearance.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.MacroInfoLabel.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.MacroInfoLabel.Appearance.Options.UseFont = true;
            this.MacroInfoLabel.Appearance.Options.UseForeColor = true;
            this.MacroInfoLabel.Location = new System.Drawing.Point(26, 248);
            this.MacroInfoLabel.Name = "MacroInfoLabel";
            this.MacroInfoLabel.Size = new System.Drawing.Size(145, 16);
            this.MacroInfoLabel.TabIndex = 4;
            this.MacroInfoLabel.Text = "Aktif Macro Bilgileri";
            // 
            // gunLabel
            // 
            this.gunLabel.Appearance.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.gunLabel.Appearance.ForeColor = System.Drawing.Color.White;
            this.gunLabel.Appearance.Options.UseFont = true;
            this.gunLabel.Appearance.Options.UseForeColor = true;
            this.gunLabel.Location = new System.Drawing.Point(26, 196);
            this.gunLabel.Name = "gunLabel";
            this.gunLabel.Size = new System.Drawing.Size(166, 16);
            this.gunLabel.TabIndex = 2;
            this.gunLabel.Text = "Henüz Silah Seçilmedi..";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(26, 174);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Seçili Silah ";
            // 
            // adver
            // 
            this.adver.Appearance.Font = new System.Drawing.Font("Chiller", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adver.Appearance.ForeColor = System.Drawing.Color.White;
            this.adver.Appearance.Options.UseFont = true;
            this.adver.Appearance.Options.UseForeColor = true;
            this.adver.Location = new System.Drawing.Point(58, 12);
            this.adver.Name = "adver";
            this.adver.Size = new System.Drawing.Size(78, 56);
            this.adver.TabIndex = 0;
            this.adver.Text = "J3M";
            // 
            // MainPanel
            // 
            this.MainPanel.AllowDrop = true;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.ScrollablePanel);
            this.MainPanel.Controls.Add(this.separatorControl1);
            this.MainPanel.Controls.Add(this.InfoLabel);
            this.MainPanel.Controls.Add(this.MinimizeButton);
            this.MainPanel.Controls.Add(this.ExitButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(225, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(760, 754);
            this.MainPanel.TabIndex = 1;
            // 
            // ScrollablePanel
            // 
            this.ScrollablePanel.AutoScroll = true;
            this.ScrollablePanel.Location = new System.Drawing.Point(17, 111);
            this.ScrollablePanel.Name = "ScrollablePanel";
            this.ScrollablePanel.Size = new System.Drawing.Size(731, 631);
            this.ScrollablePanel.TabIndex = 3;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(0, 72);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(760, 23);
            this.separatorControl1.TabIndex = 2;
            // 
            // InfoLabel
            // 
            this.InfoLabel.Appearance.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InfoLabel.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.InfoLabel.Appearance.Options.UseFont = true;
            this.InfoLabel.Appearance.Options.UseForeColor = true;
            this.InfoLabel.Location = new System.Drawing.Point(17, 28);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(278, 20);
            this.InfoLabel.TabIndex = 1;
            this.InfoLabel.Text = "Aktifleştirmek İçin F2\'ye basınız.";
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.DimGray;
            this.MinimizeButton.Location = new System.Drawing.Point(589, 9);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(91, 23);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.Text = "Minimize";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExitButton.ForeColor = System.Drawing.Color.DimGray;
            this.ExitButton.Location = new System.Drawing.Point(673, 9);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Kapat";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SingleBurst
            // 
            this.SingleBurst.AutoSize = true;
            this.SingleBurst.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Bold);
            this.SingleBurst.ForeColor = System.Drawing.Color.White;
            this.SingleBurst.Location = new System.Drawing.Point(26, 396);
            this.SingleBurst.Name = "SingleBurst";
            this.SingleBurst.Size = new System.Drawing.Size(147, 21);
            this.SingleBurst.TabIndex = 11;
            this.SingleBurst.Text = "Tekli Ateş Modu";
            this.SingleBurst.UseVisualStyleBackColor = true;
            // 
            // J3M
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 754);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "J3M";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "J3M";
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel LeftPanel;
        private System.Windows.Forms.Panel MainPanel;
        private DevExpress.XtraEditors.LabelControl adver;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MinimizeButton;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.LabelControl InfoLabel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl gunLabel;
        private DevExpress.XtraEditors.LabelControl infolbl;
        private DevExpress.XtraEditors.LabelControl MacroInfoLabel;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.FlowLayoutPanel ScrollablePanel;
        private DevExpress.XtraEditors.LabelControl SettingMs;
        private DevExpress.XtraEditors.LabelControl MsLabel;
        private System.Windows.Forms.CheckBox SilentCheckBox;
        private System.Windows.Forms.CheckBox SingleBurst;
    }
}