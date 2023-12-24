namespace MakalelerManager
{
    partial class FrmPersonelGuncelleme
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
            this.txtPersonelDogumYil = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPersonelSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPersonelAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPersonelGuncelleme = new System.Windows.Forms.Button();
            this.btnPersonelSil = new System.Windows.Forms.Button();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.picResim = new System.Windows.Forms.PictureBox();
            this.gbCinsiyet = new System.Windows.Forms.GroupBox();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picResim)).BeginInit();
            this.gbCinsiyet.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPersonelDogumYil
            // 
            this.txtPersonelDogumYil.Location = new System.Drawing.Point(166, 124);
            this.txtPersonelDogumYil.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonelDogumYil.Name = "txtPersonelDogumYil";
            this.txtPersonelDogumYil.Size = new System.Drawing.Size(205, 22);
            this.txtPersonelDogumYil.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 47;
            this.label7.Text = "Doğum Yılı:";
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(166, 165);
            this.txtTcNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(205, 22);
            this.txtTcNo.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "TC No:";
            // 
            // txtPersonelSoyad
            // 
            this.txtPersonelSoyad.Location = new System.Drawing.Point(166, 77);
            this.txtPersonelSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonelSoyad.Name = "txtPersonelSoyad";
            this.txtPersonelSoyad.Size = new System.Drawing.Size(205, 22);
            this.txtPersonelSoyad.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Personel Soyad:";
            // 
            // txtPersonelAd
            // 
            this.txtPersonelAd.Location = new System.Drawing.Point(166, 37);
            this.txtPersonelAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonelAd.Name = "txtPersonelAd";
            this.txtPersonelAd.Size = new System.Drawing.Size(205, 22);
            this.txtPersonelAd.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Personel Ad:";
            // 
            // btnPersonelGuncelleme
            // 
            this.btnPersonelGuncelleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonelGuncelleme.Location = new System.Drawing.Point(166, 314);
            this.btnPersonelGuncelleme.Name = "btnPersonelGuncelleme";
            this.btnPersonelGuncelleme.Size = new System.Drawing.Size(205, 60);
            this.btnPersonelGuncelleme.TabIndex = 48;
            this.btnPersonelGuncelleme.Text = "Personel Güncelleme";
            this.btnPersonelGuncelleme.UseVisualStyleBackColor = true;
            this.btnPersonelGuncelleme.Click += new System.EventHandler(this.btnPersonelGuncelleme_Click);
            // 
            // btnPersonelSil
            // 
            this.btnPersonelSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonelSil.ForeColor = System.Drawing.Color.Red;
            this.btnPersonelSil.Location = new System.Drawing.Point(414, 314);
            this.btnPersonelSil.Name = "btnPersonelSil";
            this.btnPersonelSil.Size = new System.Drawing.Size(205, 60);
            this.btnPersonelSil.TabIndex = 49;
            this.btnPersonelSil.Text = "Personel Sil";
            this.btnPersonelSil.UseVisualStyleBackColor = true;
            this.btnPersonelSil.Click += new System.EventHandler(this.btnPersonelSil_Click);
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(472, 227);
            this.btnResimSec.Margin = new System.Windows.Forms.Padding(4);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(100, 28);
            this.btnResimSec.TabIndex = 51;
            this.btnResimSec.Text = "Resim Seç";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // picResim
            // 
            this.picResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResim.Location = new System.Drawing.Point(443, 37);
            this.picResim.Margin = new System.Windows.Forms.Padding(4);
            this.picResim.Name = "picResim";
            this.picResim.Size = new System.Drawing.Size(151, 182);
            this.picResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResim.TabIndex = 50;
            this.picResim.TabStop = false;
            // 
            // gbCinsiyet
            // 
            this.gbCinsiyet.Controls.Add(this.rbErkek);
            this.gbCinsiyet.Controls.Add(this.rbKadin);
            this.gbCinsiyet.Location = new System.Drawing.Point(46, 227);
            this.gbCinsiyet.Margin = new System.Windows.Forms.Padding(4);
            this.gbCinsiyet.Name = "gbCinsiyet";
            this.gbCinsiyet.Padding = new System.Windows.Forms.Padding(4);
            this.gbCinsiyet.Size = new System.Drawing.Size(171, 54);
            this.gbCinsiyet.TabIndex = 52;
            this.gbCinsiyet.TabStop = false;
            this.gbCinsiyet.Text = "Cinsiyet";
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(85, 23);
            this.rbErkek.Margin = new System.Windows.Forms.Padding(4);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(63, 20);
            this.rbErkek.TabIndex = 1;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Location = new System.Drawing.Point(8, 23);
            this.rbKadin.Margin = new System.Windows.Forms.Padding(4);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(62, 20);
            this.rbKadin.TabIndex = 0;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // FrmPersonelGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 413);
            this.Controls.Add(this.gbCinsiyet);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.picResim);
            this.Controls.Add(this.btnPersonelSil);
            this.Controls.Add(this.btnPersonelGuncelleme);
            this.Controls.Add(this.txtPersonelDogumYil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPersonelSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPersonelAd);
            this.Controls.Add(this.label1);
            this.Name = "FrmPersonelGuncelleme";
            this.Text = "Personel Detayları";
            this.Load += new System.EventHandler(this.FrmPersonelGuncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picResim)).EndInit();
            this.gbCinsiyet.ResumeLayout(false);
            this.gbCinsiyet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPersonelDogumYil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPersonelSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPersonelAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPersonelGuncelleme;
        private System.Windows.Forms.Button btnPersonelSil;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.PictureBox picResim;
        private System.Windows.Forms.GroupBox gbCinsiyet;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.RadioButton rbKadin;
    }
}