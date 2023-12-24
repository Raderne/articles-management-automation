namespace MakalelerManager
{
    partial class FrmCalisanMakalelerListe
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
            this.btnMakaleSorgula = new System.Windows.Forms.Button();
            this.lblMakaleID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMakaleYazar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCalisanMakaleler = new System.Windows.Forms.DataGridView();
            this.MakaleResim = new System.Windows.Forms.DataGridViewImageColumn();
            this.MakaleYazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MakaleBaslik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MakaleIcerik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MakaleKategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanMakaleler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMakaleSorgula
            // 
            this.btnMakaleSorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakaleSorgula.Location = new System.Drawing.Point(917, 65);
            this.btnMakaleSorgula.Name = "btnMakaleSorgula";
            this.btnMakaleSorgula.Size = new System.Drawing.Size(146, 51);
            this.btnMakaleSorgula.TabIndex = 12;
            this.btnMakaleSorgula.Text = "Sorgulama";
            this.btnMakaleSorgula.UseVisualStyleBackColor = true;
            this.btnMakaleSorgula.Click += new System.EventHandler(this.btnMakaleSorgula_Click);
            // 
            // lblMakaleID
            // 
            this.lblMakaleID.AutoSize = true;
            this.lblMakaleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakaleID.Location = new System.Drawing.Point(1044, 28);
            this.lblMakaleID.Name = "lblMakaleID";
            this.lblMakaleID.Size = new System.Drawing.Size(19, 20);
            this.lblMakaleID.TabIndex = 11;
            this.lblMakaleID.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(913, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Makale ID :";
            // 
            // lblMakaleYazar
            // 
            this.lblMakaleYazar.AutoSize = true;
            this.lblMakaleYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakaleYazar.Location = new System.Drawing.Point(159, 26);
            this.lblMakaleYazar.Name = "lblMakaleYazar";
            this.lblMakaleYazar.Size = new System.Drawing.Size(47, 24);
            this.lblMakaleYazar.TabIndex = 9;
            this.lblMakaleYazar.Text = "isim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Makale Yazar :";
            // 
            // dgvCalisanMakaleler
            // 
            this.dgvCalisanMakaleler.AllowUserToAddRows = false;
            this.dgvCalisanMakaleler.AllowUserToDeleteRows = false;
            this.dgvCalisanMakaleler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalisanMakaleler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalisanMakaleler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MakaleResim,
            this.MakaleYazar,
            this.MakaleBaslik,
            this.MakaleIcerik,
            this.MakaleKategori});
            this.dgvCalisanMakaleler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCalisanMakaleler.Location = new System.Drawing.Point(0, 152);
            this.dgvCalisanMakaleler.Name = "dgvCalisanMakaleler";
            this.dgvCalisanMakaleler.ReadOnly = true;
            this.dgvCalisanMakaleler.RowHeadersWidth = 51;
            this.dgvCalisanMakaleler.RowTemplate.Height = 24;
            this.dgvCalisanMakaleler.Size = new System.Drawing.Size(1100, 489);
            this.dgvCalisanMakaleler.TabIndex = 13;
            this.dgvCalisanMakaleler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalisanMakaleler_CellClick);
            // 
            // MakaleResim
            // 
            this.MakaleResim.DataPropertyName = "MakaleResim";
            this.MakaleResim.HeaderText = "Makale Resim";
            this.MakaleResim.MinimumWidth = 6;
            this.MakaleResim.Name = "MakaleResim";
            this.MakaleResim.ReadOnly = true;
            // 
            // MakaleYazar
            // 
            this.MakaleYazar.DataPropertyName = "MakaleYazar";
            this.MakaleYazar.HeaderText = "Makale Yazar";
            this.MakaleYazar.MinimumWidth = 6;
            this.MakaleYazar.Name = "MakaleYazar";
            this.MakaleYazar.ReadOnly = true;
            this.MakaleYazar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MakaleYazar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MakaleBaslik
            // 
            this.MakaleBaslik.DataPropertyName = "MakaleBaslik";
            this.MakaleBaslik.HeaderText = "Makale Başlığı";
            this.MakaleBaslik.MinimumWidth = 6;
            this.MakaleBaslik.Name = "MakaleBaslik";
            this.MakaleBaslik.ReadOnly = true;
            this.MakaleBaslik.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MakaleBaslik.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MakaleIcerik
            // 
            this.MakaleIcerik.DataPropertyName = "MakaleIcerik";
            this.MakaleIcerik.HeaderText = "Makale İçeriği";
            this.MakaleIcerik.MinimumWidth = 6;
            this.MakaleIcerik.Name = "MakaleIcerik";
            this.MakaleIcerik.ReadOnly = true;
            this.MakaleIcerik.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MakaleIcerik.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MakaleKategori
            // 
            this.MakaleKategori.DataPropertyName = "MakaleKategori";
            this.MakaleKategori.HeaderText = "Makale Kategori";
            this.MakaleKategori.MinimumWidth = 6;
            this.MakaleKategori.Name = "MakaleKategori";
            this.MakaleKategori.ReadOnly = true;
            this.MakaleKategori.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MakaleKategori.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmCalisanMakalelerListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 641);
            this.Controls.Add(this.dgvCalisanMakaleler);
            this.Controls.Add(this.btnMakaleSorgula);
            this.Controls.Add(this.lblMakaleID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMakaleYazar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCalisanMakalelerListe";
            this.Text = "FrmCalisanMakalelerListe";
            this.Load += new System.EventHandler(this.FrmCalisanMakalelerListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanMakaleler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakaleSorgula;
        private System.Windows.Forms.Label lblMakaleID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMakaleYazar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCalisanMakaleler;
        private System.Windows.Forms.DataGridViewImageColumn MakaleResim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MakaleYazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn MakaleBaslik;
        private System.Windows.Forms.DataGridViewTextBoxColumn MakaleIcerik;
        private System.Windows.Forms.DataGridViewTextBoxColumn MakaleKategori;
    }
}