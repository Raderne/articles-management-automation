using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakalelerManager
{
    public partial class FrmPersonelReport : Form
    {
        public FrmPersonelReport()
        {
            InitializeComponent();
        }

        private void FrmPersonelReport_Load(object sender, EventArgs e)
        {
            MakalelerManagerEntities db = new MakalelerManagerEntities();
            List<Personeller> personel = db.Personellers.ToList();
            reportViewerPersonel.LocalReport.DataSources.Clear();
            reportViewerPersonel.LocalReport.ReportEmbeddedResource = "MakalelerManager.TableReport.rdlc";
            ReportDataSource rds = new ReportDataSource("DataSetPersonel", personel);
            reportViewerPersonel.LocalReport.DataSources.Add(rds);
            reportViewerPersonel.RefreshReport();
        }
    }
}
