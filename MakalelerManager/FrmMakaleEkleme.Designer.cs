namespace MakalelerManager
{
    partial class FrmMakaleEkleme
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblMakaleYazar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMakaleBaslik = new System.Windows.Forms.TextBox();
            this.cbMakaleKategori = new System.Windows.Forms.ComboBox();
            this.txtMakaleIcerik = new System.Windows.Forms.TextBox();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.picResim = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picResim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Makale Yazar :";
            // 
            // lblMakaleYazar
            // 
            this.lblMakaleYazar.AutoSize = true;
            this.lblMakaleYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakaleYazar.Location = new System.Drawing.Point(191, 26);
            this.lblMakaleYazar.Name = "lblMakaleYazar";
            this.lblMakaleYazar.Size = new System.Drawing.Size(47, 24);
            this.lblMakaleYazar.TabIndex = 1;
            this.lblMakaleYazar.Text = "isim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Makale Başlığı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Makale İçeriği :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Makale Kategori :";
            // 
            // txtMakaleBaslik
            // 
            this.txtMakaleBaslik.Location = new System.Drawing.Point(195, 93);
            this.txtMakaleBaslik.Name = "txtMakaleBaslik";
            this.txtMakaleBaslik.Size = new System.Drawing.Size(277, 26);
            this.txtMakaleBaslik.TabIndex = 1;
            // 
            // cbMakaleKategori
            // 
            this.cbMakaleKategori.FormattingEnabled = true;
            this.cbMakaleKategori.Items.AddRange(new object[] {
            "Spor",
            "entertainment",
            "Politics",
            "Tektoloji"});
            this.cbMakaleKategori.Location = new System.Drawing.Point(195, 142);
            this.cbMakaleKategori.Name = "cbMakaleKategori";
            this.cbMakaleKategori.Size = new System.Drawing.Size(277, 28);
            this.cbMakaleKategori.TabIndex = 2;
            // 
            // txtMakaleIcerik
            // 
            this.txtMakaleIcerik.Location = new System.Drawing.Point(195, 197);
            this.txtMakaleIcerik.Multiline = true;
            this.txtMakaleIcerik.Name = "txtMakaleIcerik";
            this.txtMakaleIcerik.Size = new System.Drawing.Size(277, 142);
            this.txtMakaleIcerik.TabIndex = 3;
            // 
            // btnResimSec
            // 
            this.btnResimSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResimSec.Location = new System.Drawing.Point(617, 293);
            this.btnResimSec.Margin = new System.Windows.Forms.Padding(4);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(161, 46);
            this.btnResimSec.TabIndex = 4;
            this.btnResimSec.Text = "Resim Seç";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // picResim
            // 
            this.picResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResim.Location = new System.Drawing.Point(525, 93);
            this.picResim.Margin = new System.Windows.Forms.Padding(4);
            this.picResim.Name = "picResim";
            this.picResim.Size = new System.Drawing.Size(329, 182);
            this.picResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResim.TabIndex = 43;
            this.picResim.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(195, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Makale Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMakaleEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.picResim);
            this.Controls.Add(this.txtMakaleIcerik);
            this.Controls.Add(this.cbMakaleKategori);
            this.Controls.Add(this.txtMakaleBaslik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMakaleYazar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMakaleEkleme";
            this.Text = "FrmMakaleEkleme";
            this.Load += new System.EventHandler(this.FrmMakaleEkleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMakaleYazar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMakaleBaslik;
        private System.Windows.Forms.ComboBox cbMakaleKategori;
        private System.Windows.Forms.TextBox txtMakaleIcerik;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.PictureBox picResim;
        private System.Windows.Forms.Button button1;
    }
}