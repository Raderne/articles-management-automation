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
    public partial class FrmTumMakaleler : Form
    {
        public FrmTumMakaleler()
        {
            InitializeComponent();
        }

        public Kullanicilar kullanici;

        public FrmTumMakaleler(Kullanicilar loginOlanKullanici)
        {
            InitializeComponent();
            kullanici = loginOlanKullanici;
        }

        private void FrmTumMakaleler_Load(object sender, EventArgs e)
        {
            using (MakalelerManagerEntities db = new MakalelerManagerEntities())
            {
                Personeller personel = db.Personellers.Where(x => x.PersonelID == kullanici.KullaniciID).FirstOrDefault();
                lblMakaleYazar.Text = personel.PersonelAd + " " + personel.PersonelSoyad;

                List<Makaleler> makaleler = db.Makalelers.ToList();
                dgvTumMakaleler.DataSource = makaleler;
                dgvTumMakaleler.Columns["MakaleID"].Visible = false;
                dgvTumMakaleler.Columns["PersonelID"].Visible = false;
                dgvTumMakaleler.Columns["Personeller"].Visible = false;
            }
        }

        private void dgvTumMakaleler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblMakaleID.Text = dgvTumMakaleler.CurrentRow.Cells["MakaleID"].Value.ToString();
        }

        private void btnMakaleSorgula_Click(object sender, EventArgs e)
        {
            int makaleID = Convert.ToInt32(lblMakaleID.Text);
            FrmMakaleDuzenle frm = new FrmMakaleDuzenle(makaleID);
            frm.MdiParent = this.MdiParent;
            frm.Show();

            this.Close();
        }
    }
}
