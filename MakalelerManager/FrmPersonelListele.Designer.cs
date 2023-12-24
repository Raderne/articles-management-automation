namespace MakalelerManager
{
    partial class FrmPersonelListele
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
            this.DGVPersonelListele = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersonelTcNo = new System.Windows.Forms.TextBox();
            this.btnPersonelSorgu = new System.Windows.Forms.Button();
            this.PersonelResim = new System.Windows.Forms.DataGridViewImageColumn();
            this.PersonelTcNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelDogumYılı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelCinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersonelListele)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPersonelListele
            // 
            this.DGVPersonelListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPersonelListele.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DGVPersonelListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPersonelListele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PersonelResim,
            this.PersonelTcNo,
            this.PersonelAd,
            this.PersonelSoyad,
            this.PersonelDogumYılı,
            this.PersonelCinsiyet});
            this.DGVPersonelListele.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGVPersonelListele.Location = new System.Drawing.Point(0, 106);
            this.DGVPersonelListele.Name = "DGVPersonelListele";
            this.DGVPersonelListele.RowHeadersWidth = 51;
            this.DGVPersonelListele.RowTemplate.Height = 40;
            this.DGVPersonelListele.Size = new System.Drawing.Size(1082, 547);
            this.DGVPersonelListele.TabIndex = 0;
            this.DGVPersonelListele.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPersonelListele_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC No :";
            // 
            // txtPersonelTcNo
            // 
            this.txtPersonelTcNo.Location = new System.Drawing.Point(129, 32);
            this.txtPersonelTcNo.Name = "txtPersonelTcNo";
            this.txtPersonelTcNo.Size = new System.Drawing.Size(211, 22);
            this.txtPersonelTcNo.TabIndex = 2;
            // 
            // btnPersonelSorgu
            // 
            this.btnPersonelSorgu.Location = new System.Drawing.Point(376, 24);
            this.btnPersonelSorgu.Name = "btnPersonelSorgu";
            this.btnPersonelSorgu.Size = new System.Drawing.Size(180, 39);
            this.btnPersonelSorgu.TabIndex = 3;
            this.btnPersonelSorgu.Text = "Personel Sorgulama";
            this.btnPersonelSorgu.UseVisualStyleBackColor = true;
            this.btnPersonelSorgu.Click += new System.EventHandler(this.btnPersonelSorgu_Click);
            // 
            // PersonelResim
            // 
            this.PersonelResim.DataPropertyName = "PersonelResim";
            this.PersonelResim.FillWeight = 12F;
            this.PersonelResim.HeaderText = "Personel Resim";
            this.PersonelResim.MinimumWidth = 6;
            this.PersonelResim.Name = "PersonelResim";
            // 
            // PersonelTcNo
            // 
            this.PersonelTcNo.DataPropertyName = "PersonelTcNo";
            this.PersonelTcNo.FillWeight = 20.07483F;
            this.PersonelTcNo.HeaderText = "Personel TC No";
            this.PersonelTcNo.MinimumWidth = 6;
            this.PersonelTcNo.Name = "PersonelTcNo";
            // 
            // PersonelAd
            // 
            this.PersonelAd.DataPropertyName = "PersonelAd";
            this.PersonelAd.FillWeight = 20.07483F;
            this.PersonelAd.HeaderText = "Personel Adı";
            this.PersonelAd.MinimumWidth = 6;
            this.PersonelAd.Name = "PersonelAd";
            // 
            // PersonelSoyad
            // 
            this.PersonelSoyad.DataPropertyName = "PersonelSoyad";
            this.PersonelSoyad.FillWeight = 20.07483F;
            this.PersonelSoyad.HeaderText = "Personel Soyadı";
            this.PersonelSoyad.MinimumWidth = 6;
            this.PersonelSoyad.Name = "PersonelSoyad";
            // 
            // PersonelDogumYılı
            // 
            this.PersonelDogumYılı.DataPropertyName = "PersonelDogumYil";
            this.PersonelDogumYılı.FillWeight = 20.07483F;
            this.PersonelDogumYılı.HeaderText = "Personel Doğum Yılı";
            this.PersonelDogumYılı.MinimumWidth = 6;
            this.PersonelDogumYılı.Name = "PersonelDogumYılı";
            // 
            // PersonelCinsiyet
            // 
            this.PersonelCinsiyet.DataPropertyName = "PersonelCinsiyet";
            this.PersonelCinsiyet.FillWeight = 20.07483F;
            this.PersonelCinsiyet.HeaderText = "Personel Cinsiyet";
            this.PersonelCinsiyet.MinimumWidth = 6;
            this.PersonelCinsiyet.Name = "PersonelCinsiyet";
            // 
            // FrmPersonelListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.btnPersonelSorgu);
            this.Controls.Add(this.txtPersonelTcNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVPersonelListele);
            this.Name = "FrmPersonelListele";
            this.Text = "FrmPersonelListele";
            this.Load += new System.EventHandler(this.FrmPersonelListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersonelListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVPersonelListele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersonelTcNo;
        private System.Windows.Forms.Button btnPersonelSorgu;
        private System.Windows.Forms.DataGridViewImageColumn PersonelResim;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelTcNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelDogumYılı;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelCinsiyet;
    }
}