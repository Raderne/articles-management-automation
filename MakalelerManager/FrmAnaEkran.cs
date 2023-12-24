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
    public partial class FrmAnaEkran : Form
    {
        public FrmAnaEkran()
        {
            InitializeComponent();
        }

        public Kullanicilar kullanici;
        public FrmAnaEkran(Kullanicilar loginOlanKullanici)
        {
            InitializeComponent();
            menuAdmin.Visible = false;
            menuKullanici.Visible = false;

            kullanici = loginOlanKullanici;

            if (kullanici.role == "manager")
            {
                menuAdmin.Visible = true;
            }
            else
            {
                menuKullanici.Visible = true;
            }
        }

        private void kişiselToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullaniciSifreDegistirme frm = new frmKullaniciSifreDegistirme(kullanici);
            frm.MdiParent = this;
            frm.Show();
        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKullaniciSifreDegistirme frm = new frmKullaniciSifreDegistirme(kullanici);
            frm.MdiParent = this;
            frm.Show();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kullanici = null;
            this.Close();
            FrmGirisEkran frm = new FrmGirisEkran();
            frm.Show();
        }

        private void çıkışYapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            kullanici = null;
            this.Close();
            FrmGirisEkran frm = new FrmGirisEkran();
            frm.Show();
        }

        private void personelListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonelListele frm = new FrmPersonelListele();
            frm.MdiParent = this;
            frm.Show();
        }

        private void personelKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonelEkle frm = new FrmPersonelEkle();
            frm.MdiParent = this;
            frm.Show();
        }

        private void makaleEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMakaleEkleme frm = new FrmMakaleEkleme(kullanici);
            frm.MdiParent = this;
            frm.Show();
        }

        private void makaleEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMakaleEkleme frm = new FrmMakaleEkleme(kullanici);
            frm.MdiParent = this;
            frm.Show();
        }

        private void makaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTumMakaleler frm = new FrmTumMakaleler(kullanici);
            frm.MdiParent = this;
            frm.Show();
        }

        private void makalelerimListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalisanMakalelerListe frm = new FrmCalisanMakalelerListe(kullanici);
            frm.MdiParent = this;
            frm.Show();
        }

        private void makaleİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalisanMakalelerListe frm = new FrmCalisanMakalelerListe(kullanici);
            frm.MdiParent = this;
            frm.Show();
        }

        private void makaleEkleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmMakaleEkleme frm = new FrmMakaleEkleme(kullanici);
            frm.MdiParent = this;
            frm.Show();
        }

        private void personellerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonelReport frm = new FrmPersonelReport();
            frm.MdiParent = this;
            frm.Show();
        }

        private void makalelerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMakaleReport frm = new FrmMakaleReport();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
