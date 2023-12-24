namespace MakalelerManager
{
    partial class FrmAnaEkran
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
            this.menuAdmin = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kişiselToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKullanici = new System.Windows.Forms.MenuStrip();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makaleİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makaleEkleToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.personellerReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makalelerReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdmin.SuspendLayout();
            this.menuKullanici.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuAdmin
            // 
            this.menuAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.personelİşlemleriToolStripMenuItem,
            this.çıkışYapToolStripMenuItem1,
            this.kişiselToolStripMenuItem,
            this.raporlamaToolStripMenuItem1});
            this.menuAdmin.Location = new System.Drawing.Point(0, 28);
            this.menuAdmin.Name = "menuAdmin";
            this.menuAdmin.Size = new System.Drawing.Size(1144, 28);
            this.menuAdmin.TabIndex = 1;
            this.menuAdmin.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makaleToolStripMenuItem});
            this.testToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.testToolStripMenuItem.Text = "Makale İşlemleri";
            // 
            // makaleToolStripMenuItem
            // 
            this.makaleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.makaleToolStripMenuItem.Name = "makaleToolStripMenuItem";
            this.makaleToolStripMenuItem.Size = new System.Drawing.Size(272, 32);
            this.makaleToolStripMenuItem.Text = "Tüm Makaleleri Liste";
            this.makaleToolStripMenuItem.Click += new System.EventHandler(this.makaleToolStripMenuItem_Click);
            // 
            // personelİşlemleriToolStripMenuItem
            // 
            this.personelİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelListeleToolStripMenuItem,
            this.personelKayıtToolStripMenuItem});
            this.personelİşlemleriToolStripMenuItem.Name = "personelİşlemleriToolStripMenuItem";
            this.personelİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.personelİşlemleriToolStripMenuItem.Text = "Personel İşlemleri";
            // 
            // personelListeleToolStripMenuItem
            // 
            this.personelListeleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.personelListeleToolStripMenuItem.Name = "personelListeleToolStripMenuItem";
            this.personelListeleToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.personelListeleToolStripMenuItem.Text = "Personel Listele";
            this.personelListeleToolStripMenuItem.Click += new System.EventHandler(this.personelListeleToolStripMenuItem_Click);
            // 
            // personelKayıtToolStripMenuItem
            // 
            this.personelKayıtToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.personelKayıtToolStripMenuItem.Name = "personelKayıtToolStripMenuItem";
            this.personelKayıtToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.personelKayıtToolStripMenuItem.Text = "Yeni Personel Ekle";
            this.personelKayıtToolStripMenuItem.Click += new System.EventHandler(this.personelKayıtToolStripMenuItem_Click);
            // 
            // çıkışYapToolStripMenuItem1
            // 
            this.çıkışYapToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.çıkışYapToolStripMenuItem1.Name = "çıkışYapToolStripMenuItem1";
            this.çıkışYapToolStripMenuItem1.Size = new System.Drawing.Size(81, 24);
            this.çıkışYapToolStripMenuItem1.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem1.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem1_Click);
            // 
            // kişiselToolStripMenuItem
            // 
            this.kişiselToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.kişiselToolStripMenuItem.Name = "kişiselToolStripMenuItem";
            this.kişiselToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.kişiselToolStripMenuItem.Text = "Şifre Değiştir";
            this.kişiselToolStripMenuItem.Click += new System.EventHandler(this.kişiselToolStripMenuItem_Click);
            // 
            // raporlamaToolStripMenuItem1
            // 
            this.raporlamaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personellerReportToolStripMenuItem,
            this.makalelerReportToolStripMenuItem});
            this.raporlamaToolStripMenuItem1.Name = "raporlamaToolStripMenuItem1";
            this.raporlamaToolStripMenuItem1.Size = new System.Drawing.Size(96, 24);
            this.raporlamaToolStripMenuItem1.Text = "Raporlama";
            // 
            // menuKullanici
            // 
            this.menuKullanici.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuKullanici.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışYapToolStripMenuItem,
            this.şifreDeğiştirToolStripMenuItem,
            this.makaleİşlemleriToolStripMenuItem,
            this.makaleEkleToolStripMenuItem2});
            this.menuKullanici.Location = new System.Drawing.Point(0, 0);
            this.menuKullanici.Name = "menuKullanici";
            this.menuKullanici.Size = new System.Drawing.Size(1144, 28);
            this.menuKullanici.TabIndex = 3;
            this.menuKullanici.Text = "menuStrip1";
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // şifreDeğiştirToolStripMenuItem
            // 
            this.şifreDeğiştirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.şifreDeğiştirToolStripMenuItem.Name = "şifreDeğiştirToolStripMenuItem";
            this.şifreDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.şifreDeğiştirToolStripMenuItem.Text = "Şifre Değiştir";
            this.şifreDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.şifreDeğiştirToolStripMenuItem_Click);
            // 
            // makaleİşlemleriToolStripMenuItem
            // 
            this.makaleİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.makaleİşlemleriToolStripMenuItem.Name = "makaleİşlemleriToolStripMenuItem";
            this.makaleİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.makaleİşlemleriToolStripMenuItem.Text = "Makalelerim Liste";
            this.makaleİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.makaleİşlemleriToolStripMenuItem_Click);
            // 
            // makaleEkleToolStripMenuItem2
            // 
            this.makaleEkleToolStripMenuItem2.Name = "makaleEkleToolStripMenuItem2";
            this.makaleEkleToolStripMenuItem2.Size = new System.Drawing.Size(102, 24);
            this.makaleEkleToolStripMenuItem2.Text = "Makale Ekle";
            this.makaleEkleToolStripMenuItem2.Click += new System.EventHandler(this.makaleEkleToolStripMenuItem2_Click);
            // 
            // personellerReportToolStripMenuItem
            // 
            this.personellerReportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.personellerReportToolStripMenuItem.Name = "personellerReportToolStripMenuItem";
            this.personellerReportToolStripMenuItem.Size = new System.Drawing.Size(232, 28);
            this.personellerReportToolStripMenuItem.Text = "Personeller Report";
            this.personellerReportToolStripMenuItem.Click += new System.EventHandler(this.personellerReportToolStripMenuItem_Click);
            // 
            // makalelerReportToolStripMenuItem
            // 
            this.makalelerReportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.makalelerReportToolStripMenuItem.Name = "makalelerReportToolStripMenuItem";
            this.makalelerReportToolStripMenuItem.Size = new System.Drawing.Size(232, 28);
            this.makalelerReportToolStripMenuItem.Text = "Makaleler Report";
            this.makalelerReportToolStripMenuItem.Click += new System.EventHandler(this.makalelerReportToolStripMenuItem_Click);
            // 
            // FrmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 629);
            this.Controls.Add(this.menuAdmin);
            this.Controls.Add(this.menuKullanici);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuAdmin;
            this.MinimizeBox = false;
            this.Name = "FrmAnaEkran";
            this.ShowInTaskbar = false;
            this.Text = "Makaleler Yöneticisi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuAdmin.ResumeLayout(false);
            this.menuAdmin.PerformLayout();
            this.menuKullanici.ResumeLayout(false);
            this.menuKullanici.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuAdmin;
        private System.Windows.Forms.ToolStripMenuItem personelİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kişiselToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makaleToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuKullanici;
        private System.Windows.Forms.ToolStripMenuItem şifreDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makaleİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makaleEkleToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personellerReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makalelerReportToolStripMenuItem;
    }
}

