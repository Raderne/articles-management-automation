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
    public partial class FrmCalisanMakalelerListe : Form
    {
        public FrmCalisanMakalelerListe()
        {
            InitializeComponent();
        }

        private Kullanicilar kullanici;

        public FrmCalisanMakalelerListe(Kullanicilar loginOlanKullanici)
        {
            InitializeComponent();
            kullanici = loginOlanKullanici;
        }

        private void FrmCalisanMakalelerListe_Load(object sender, EventArgs e)
        {
            using (MakalelerManagerEntities db = new MakalelerManagerEntities())
            {
                Personeller personel = db.Personellers.Where(x => x.PersonelID == kullanici.KullaniciID).FirstOrDefault();
                lblMakaleYazar.Text = personel.PersonelAd + " " + personel.PersonelSoyad;

                List<Makaleler> makaleler = db.Makalelers.Where(x => x.PersonelID == personel.PersonelID).ToList();
                dgvCalisanMakaleler.DataSource = makaleler;
                dgvCalisanMakaleler.Columns["MakaleID"].Visible = false;
                dgvCalisanMakaleler.Columns["PersonelID"].Visible = false;
                dgvCalisanMakaleler.Columns["Personeller"].Visible = false;
            }
        }

        private void dgvCalisanMakaleler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblMakaleID.Text = dgvCalisanMakaleler.CurrentRow.Cells["MakaleID"].Value.ToString();
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
