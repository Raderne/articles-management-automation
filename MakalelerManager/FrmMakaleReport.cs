using MakalelerManager.DataSetMakalelerTableAdapters;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakalelerManager
{
    public partial class FrmMakaleReport : Form
    {
        public FrmMakaleReport()
        {
            InitializeComponent();
        }

        private void FrmMakaleReport_Load(object sender, EventArgs e)
        {
            DataSetMakaleler ds = new DataSetMakaleler();
            MakalelerTableAdapter adapter = new MakalelerTableAdapter();
            adapter.Fill(ds.Makaleler);

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Makaleler;

            reportViewerMakale.LocalReport.DataSources.Clear();
            reportViewerMakale.LocalReport.ReportEmbeddedResource = "MakalelerManager.ChartReport.rdlc";
            reportViewerMakale.LocalReport.DataSources.Add(rds);
            reportViewerMakale.RefreshReport();
        }
    }
}
