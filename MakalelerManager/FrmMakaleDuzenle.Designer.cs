namespace MakalelerManager
{
    partial class FrmMakaleDuzenle
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
            this.btnMakaleGuncelle = new System.Windows.Forms.Button();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.picResim = new System.Windows.Forms.PictureBox();
            this.txtMakaleIcerik = new System.Windows.Forms.TextBox();
            this.cbMakaleKategori = new System.Windows.Forms.ComboBox();
            this.txtMakaleBaslik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMakaleID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMakaleSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picResim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMakaleGuncelle
            // 
            this.btnMakaleGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakaleGuncelle.Location = new System.Drawing.Point(217, 392);
            this.btnMakaleGuncelle.Name = "btnMakaleGuncelle";
            this.btnMakaleGuncelle.Size = new System.Drawing.Size(277, 48);
            this.btnMakaleGuncelle.TabIndex = 53;
            this.btnMakaleGuncelle.Text = "Makale Güncelle";
            this.btnMakaleGuncelle.UseVisualStyleBackColor = true;
            this.btnMakaleGuncelle.Click += new System.EventHandler(this.btnMakaleGuncelle_Click);
            // 
            // btnResimSec
            // 
            this.btnResimSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResimSec.Location = new System.Drawing.Point(699, 300);
            this.btnResimSec.Margin = new System.Windows.Forms.Padding(4);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(161, 46);
            this.btnResimSec.TabIndex = 51;
            this.btnResimSec.Text = "Resim Seç";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // picResim
            // 
            this.picResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResim.Location = new System.Drawing.Point(542, 33);
            this.picResim.Margin = new System.Windows.Forms.Padding(4);
            this.picResim.Name = "picResim";
            this.picResim.Size = new System.Drawing.Size(458, 259);
            this.picResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResim.TabIndex = 54;
            this.picResim.TabStop = false;
            // 
            // txtMakaleIcerik
            // 
            this.txtMakaleIcerik.Location = new System.Drawing.Point(217, 204);
            this.txtMakaleIcerik.Multiline = true;
            this.txtMakaleIcerik.Name = "txtMakaleIcerik";
            this.txtMakaleIcerik.Size = new System.Drawing.Size(277, 142);
            this.txtMakaleIcerik.TabIndex = 49;
            // 
            // cbMakaleKategori
            // 
            this.cbMakaleKategori.FormattingEnabled = true;
            this.cbMakaleKategori.Items.AddRange(new object[] {
            "Spor",
            "entertainment",
            "Politics",
            "Tektoloji"});
            this.cbMakaleKategori.Location = new System.Drawing.Point(217, 149);
            this.cbMakaleKategori.Name = "cbMakaleKategori";
            this.cbMakaleKategori.Size = new System.Drawing.Size(277, 26);
            this.cbMakaleKategori.TabIndex = 47;
            // 
            // txtMakaleBaslik
            // 
            this.txtMakaleBaslik.Location = new System.Drawing.Point(217, 100);
            this.txtMakaleBaslik.Name = "txtMakaleBaslik";
            this.txtMakaleBaslik.Size = new System.Drawing.Size(277, 24);
            this.txtMakaleBaslik.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 52;
            this.label4.Text = "Makale Kategori :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "Makale İçeriği :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 48;
            this.label2.Text = "Makale Başlığı :";
            // 
            // lblMakaleID
            // 
            this.lblMakaleID.AutoSize = true;
            this.lblMakaleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakaleID.Location = new System.Drawing.Point(213, 33);
            this.lblMakaleID.Name = "lblMakaleID";
            this.lblMakaleID.Size = new System.Drawing.Size(29, 24);
            this.lblMakaleID.TabIndex = 46;
            this.lblMakaleID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 44;
            this.label1.Text = "Makale ID :";
            // 
            // btnMakaleSil
            // 
            this.btnMakaleSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakaleSil.ForeColor = System.Drawing.Color.Red;
            this.btnMakaleSil.Location = new System.Drawing.Point(217, 461);
            this.btnMakaleSil.Name = "btnMakaleSil";
            this.btnMakaleSil.Size = new System.Drawing.Size(277, 64);
            this.btnMakaleSil.TabIndex = 55;
            this.btnMakaleSil.Text = "Makale Sil";
            this.btnMakaleSil.UseVisualStyleBackColor = true;
            this.btnMakaleSil.Click += new System.EventHandler(this.btnMakaleSil_Click);
            // 
            // FrmMakaleDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 573);
            this.Controls.Add(this.btnMakaleSil);
            this.Controls.Add(this.btnMakaleGuncelle);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.picResim);
            this.Controls.Add(this.txtMakaleIcerik);
            this.Controls.Add(this.cbMakaleKategori);
            this.Controls.Add(this.txtMakaleBaslik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMakaleID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmMakaleDuzenle";
            this.Text = "FrmMakaleDuzenle";
            this.Load += new System.EventHandler(this.FrmMakaleDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakaleGuncelle;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.PictureBox picResim;
        private System.Windows.Forms.TextBox txtMakaleIcerik;
        private System.Windows.Forms.ComboBox cbMakaleKategori;
        private System.Windows.Forms.TextBox txtMakaleBaslik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMakaleID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMakaleSil;
    }
}