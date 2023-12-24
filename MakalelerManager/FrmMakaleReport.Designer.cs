namespace MakalelerManager
{
    partial class FrmMakaleReport
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
            this.reportViewerMakale = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerMakale
            // 
            this.reportViewerMakale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerMakale.Location = new System.Drawing.Point(0, 0);
            this.reportViewerMakale.Name = "reportViewerMakale";
            this.reportViewerMakale.ServerReport.BearerToken = null;
            this.reportViewerMakale.Size = new System.Drawing.Size(1000, 619);
            this.reportViewerMakale.TabIndex = 0;
            // 
            // FrmMakaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.reportViewerMakale);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMakaleReport";
            this.Text = "FrmMakaleReport";
            this.Load += new System.EventHandler(this.FrmMakaleReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerMakale;
    }
}