﻿namespace MakalelerManager
{
    partial class FrmPersonelReport
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
            this.reportViewerPersonel = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPersonel
            // 
            this.reportViewerPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerPersonel.Location = new System.Drawing.Point(0, 0);
            this.reportViewerPersonel.Name = "reportViewerPersonel";
            this.reportViewerPersonel.ServerReport.BearerToken = null;
            this.reportViewerPersonel.Size = new System.Drawing.Size(1064, 589);
            this.reportViewerPersonel.TabIndex = 0;
            // 
            // FrmPersonelReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 589);
            this.Controls.Add(this.reportViewerPersonel);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmPersonelReport";
            this.Text = "FrmPersonelReport";
            this.Load += new System.EventHandler(this.FrmPersonelReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPersonel;
    }
}