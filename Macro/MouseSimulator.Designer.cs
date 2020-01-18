namespace Macro
{
    partial class J3m_Macro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(J3m_Macro));
            this.InfoLabel = new System.Windows.Forms.Label();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.ValuePanel = new DevExpress.Utils.Layout.StackPanel();
            this.FromIncreasePanel = new DevExpress.Utils.Layout.StackPanel();
            this.ToIncreasePanel = new DevExpress.Utils.Layout.StackPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.gunLabel = new System.Windows.Forms.Label();
            this.gunInfoLabel = new System.Windows.Forms.Label();
            this.infolbl = new System.Windows.Forms.Label();
            this.SingleMode = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValuePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromIncreasePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToIncreasePanel)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.InfoLabel.Location = new System.Drawing.Point(12, 9);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(206, 17);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "Aktifleştirmek İçin F2\'ye basınız.";
            // 
            // stackPanel1
            // 
            this.stackPanel1.Location = new System.Drawing.Point(12, 29);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(881, 33);
            this.stackPanel1.TabIndex = 1;
            // 
            // ValuePanel
            // 
            this.ValuePanel.Location = new System.Drawing.Point(12, 68);
            this.ValuePanel.Name = "ValuePanel";
            this.ValuePanel.Size = new System.Drawing.Size(881, 30);
            this.ValuePanel.TabIndex = 2;
            // 
            // FromIncreasePanel
            // 
            this.FromIncreasePanel.Location = new System.Drawing.Point(12, 104);
            this.FromIncreasePanel.Name = "FromIncreasePanel";
            this.FromIncreasePanel.Size = new System.Drawing.Size(881, 31);
            this.FromIncreasePanel.TabIndex = 3;
            // 
            // ToIncreasePanel
            // 
            this.ToIncreasePanel.Location = new System.Drawing.Point(12, 141);
            this.ToIncreasePanel.Name = "ToIncreasePanel";
            this.ToIncreasePanel.Size = new System.Drawing.Size(881, 29);
            this.ToIncreasePanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seçili Silah : ";
            // 
            // gunLabel
            // 
            this.gunLabel.AutoSize = true;
            this.gunLabel.Location = new System.Drawing.Point(587, 8);
            this.gunLabel.Name = "gunLabel";
            this.gunLabel.Size = new System.Drawing.Size(10, 13);
            this.gunLabel.TabIndex = 6;
            this.gunLabel.Text = "-";
            // 
            // gunInfoLabel
            // 
            this.gunInfoLabel.AutoSize = true;
            this.gunInfoLabel.Location = new System.Drawing.Point(689, 8);
            this.gunInfoLabel.Name = "gunInfoLabel";
            this.gunInfoLabel.Size = new System.Drawing.Size(78, 13);
            this.gunInfoLabel.TabIndex = 7;
            this.gunInfoLabel.Text = "Macro Bilgileri :";
            // 
            // infolbl
            // 
            this.infolbl.AutoSize = true;
            this.infolbl.Location = new System.Drawing.Point(773, 8);
            this.infolbl.Name = "infolbl";
            this.infolbl.Size = new System.Drawing.Size(13, 13);
            this.infolbl.TabIndex = 8;
            this.infolbl.Text = " -";
            // 
            // SingleMode
            // 
            this.SingleMode.AutoSize = true;
            this.SingleMode.Location = new System.Drawing.Point(251, 11);
            this.SingleMode.Name = "SingleMode";
            this.SingleMode.Size = new System.Drawing.Size(103, 17);
            this.SingleMode.TabIndex = 9;
            this.SingleMode.Text = "Tekli Ateş Modu";
            this.SingleMode.UseVisualStyleBackColor = true;
            // 
            // J3m_Macro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 189);
            this.Controls.Add(this.SingleMode);
            this.Controls.Add(this.infolbl);
            this.Controls.Add(this.gunInfoLabel);
            this.Controls.Add(this.gunLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ToIncreasePanel);
            this.Controls.Add(this.FromIncreasePanel);
            this.Controls.Add(this.ValuePanel);
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.InfoLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "J3m_Macro";
            this.Text = "j3m Macro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValuePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromIncreasePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToIncreasePanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DevExpress.Utils.Layout.StackPanel stackPanel1;
        public DevExpress.Utils.Layout.StackPanel ValuePanel;
        public DevExpress.Utils.Layout.StackPanel FromIncreasePanel;
        public DevExpress.Utils.Layout.StackPanel ToIncreasePanel;
        public System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gunInfoLabel;
        public System.Windows.Forms.Label gunLabel;
        public System.Windows.Forms.Label infolbl;
        public System.Windows.Forms.CheckBox SingleMode;
    }
}

