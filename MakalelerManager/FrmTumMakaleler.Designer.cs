namespace MakalelerManager
{
    partial class FrmTumMakaleler
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
            this.lblMakaleYazar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTumMakaleler = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMakaleID = new System.Windows.Forms.Label();
            this.btnMakaleSorgula = new System.Windows.Forms.Button();
            this.MakaleResim = new System.Windows.Forms.DataGridViewImageColumn();
            this.MakaleBaslik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MakaleIcerik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MakaleKategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTumMakaleler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMakaleYazar
            // 
            this.lblMakaleYazar.AutoSize = true;
            this.lblMakaleYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakaleYazar.Location = new System.Drawing.Point(147, 20);
            this.lblMakaleYazar.Name = "lblMakaleYazar";
            this.lblMakaleYazar.Size = new System.Drawing.Size(47, 24);
            this.lblMakaleYazar.TabIndex = 3;
            this.lblMakaleYazar.Text = "isim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Makale Yazar :";
            // 
            // dgvTumMakaleler
            // 
            this.dgvTumMakaleler.AllowUserToAddRows = false;
            this.dgvTumMakaleler.AllowUserToDeleteRows = false;
            this.dgvTumMakaleler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTumMakaleler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTumMakaleler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MakaleResim,
            this.MakaleBaslik,
            this.MakaleIcerik,
            this.MakaleKategori});
            this.dgvTumMakaleler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTumMakaleler.Location = new System.Drawing.Point(0, 126);
            this.dgvTumMakaleler.Name = "dgvTumMakaleler";
            this.dgvTumMakaleler.ReadOnly = true;
            this.dgvTumMakaleler.RowHeadersWidth = 51;
            this.dgvTumMakaleler.RowTemplate.Height = 24;
            this.dgvTumMakaleler.Size = new System.Drawing.Size(1124, 495);
            this.dgvTumMakaleler.TabIndex = 4;
            this.dgvTumMakaleler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTumMakaleler_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(901, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Makale ID :";
            // 
            // lblMakaleID
            // 
            this.lblMakaleID.AutoSize = true;
            this.lblMakaleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakaleID.Location = new System.Drawing.Point(1032, 22);
            this.lblMakaleID.Name = "lblMakaleID";
            this.lblMakaleID.Size = new System.Drawing.Size(19, 20);
            this.lblMakaleID.TabIndex = 6;
            this.lblMakaleID.Text = "?";
            // 
            // btnMakaleSorgula
            // 
            this.btnMakaleSorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakaleSorgula.Location = new System.Drawing.Point(905, 59);
            this.btnMakaleSorgula.Name = "btnMakaleSorgula";
            this.btnMakaleSorgula.Size = new System.Drawing.Size(146, 51);
            this.btnMakaleSorgula.TabIndex = 7;
            this.btnMakaleSorgula.Text = "Sorgulama";
            this.btnMakaleSorgula.UseVisualStyleBackColor = true;
            this.btnMakaleSorgula.Click += new System.EventHandler(this.btnMakaleSorgula_Click);
            // 
            // MakaleResim
            // 
            this.MakaleResim.DataPropertyName = "MakaleResim";
            this.MakaleResim.HeaderText = "Makale Resim";
            this.MakaleResim.MinimumWidth = 6;
            this.MakaleResim.Name = "MakaleResim";
            this.MakaleResim.ReadOnly = true;
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
            // 
            // MakaleKategori
            // 
            this.MakaleKategori.DataPropertyName = "MakaleKategori";
            this.MakaleKategori.HeaderText = "Makale kategori";
            this.MakaleKategori.MinimumWidth = 6;
            this.MakaleKategori.Name = "MakaleKategori";
            this.MakaleKategori.ReadOnly = true;
            // 
            // FrmTumMakaleler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 621);
            this.Controls.Add(this.btnMakaleSorgula);
            this.Controls.Add(this.lblMakaleID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTumMakaleler);
            this.Controls.Add(this.lblMakaleYazar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTumMakaleler";
            this.Text = "Tüm Makaleler";
            this.Load += new System.EventHandler(this.FrmTumMakaleler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTumMakaleler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMakaleYazar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTumMakaleler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMakaleID;
        private System.Windows.Forms.Button btnMakaleSorgula;
        private System.Windows.Forms.DataGridViewImageColumn MakaleResim;
        private System.Windows.Forms.DataGridViewTextBoxColumn MakaleBaslik;
        private System.Windows.Forms.DataGridViewTextBoxColumn MakaleIcerik;
        private System.Windows.Forms.DataGridViewTextBoxColumn MakaleKategori;
    }
}