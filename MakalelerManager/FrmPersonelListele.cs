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
    public partial class FrmPersonelListele : Form
    {
        public FrmPersonelListele()
        {
            InitializeComponent();
        }

        private void FrmPersonelListele_Load(object sender, EventArgs e)
        {
            using (MakalelerManagerEntities db = new MakalelerManagerEntities())
            {
                var personeller = db.Personellers.ToList();
                DGVPersonelListele.DataSource = personeller;
                DGVPersonelListele.Columns["PersonelID"].Visible = false;
                DGVPersonelListele.Columns["Kullanicilars"].Visible = false;
                DGVPersonelListele.Columns["Makalelers"].Visible = false;
            }
        }


        private void btnPersonelSorgu_Click(object sender, EventArgs e)
        {
            long personelTcNo = Convert.ToInt64(txtPersonelTcNo.Text);

            if (txtPersonelTcNo.Text == "")
            {
                MessageBox.Show("Lütfen TC No giriniz.");
            }
            else
            {
                using (MakalelerManagerEntities db = new MakalelerManagerEntities())
                {
                    Personeller personeller = db.Personellers.Where(x => x.PersonelTcNo == personelTcNo).FirstOrDefault();
                    if (personeller == null)
                    {
                        MessageBox.Show("Personel bulunamadı.");
                    }
                    else
                    {
                        FrmPersonelGuncelleme frm = new FrmPersonelGuncelleme(personeller);
                        frm.PersonelGuncellendi += Frm_PersonelGuncellendi;
                        frm.MdiParent = this.MdiParent;
                        frm.Show();
                    }
                }
            }
        }

        private void Frm_PersonelGuncellendi(object sender, EventArgs e)
        {
            using (MakalelerManagerEntities db = new MakalelerManagerEntities())
            {
                DGVPersonelListele.DataSource = db.Personellers.ToList();
            }

            DGVPersonelListele.Columns["PersonelID"].Visible = false;
            DGVPersonelListele.Columns["Kullanicilars"].Visible = false;
            DGVPersonelListele.Columns["Makalelers"].Visible = false;
        }

        private void DGVPersonelListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonelTcNo.Text = DGVPersonelListele.CurrentRow.Cells["PersonelTcNo"].Value.ToString();
        }
    }
}
