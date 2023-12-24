using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakalelerManager
{
    public partial class frmKullaniciSifreDegistirme : Form
    {
        public frmKullaniciSifreDegistirme()
        {
            InitializeComponent();
        }

        public Kullanicilar kullanici;

        public frmKullaniciSifreDegistirme(Kullanicilar loginOlanKullanici)
        {
            InitializeComponent();
            kullanici = loginOlanKullanici;
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            string eskiSifre = txtEskiSifre.Text;
            string yeniSifre = txtYeniSifre.Text;
            string yeniSifreTekrar = txtYeniSifreTekrar.Text;

            if (eskiSifre == "" || yeniSifre == "" || yeniSifreTekrar == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            if (eskiSifre == kullanici.KullaniciSifre)
            {
                if (yeniSifre == yeniSifreTekrar)
                {
                    kullanici.KullaniciSifre = yeniSifre;
                    MakalelerManagerEntities db = new MakalelerManagerEntities();
                    db.Kullanicilars.AddOrUpdate(kullanici);
                    int sonuc = db.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Şifreniz başarıyla değiştirildi.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Şifreniz değiştirilemedi.");
                    }
                }
                else
                {
                    MessageBox.Show("Yeni şifreler uyuşmuyor.");
                }
            }
            else
            {
                MessageBox.Show("Eski şifrenizi yanlış girdiniz.");
            }
        }
    }
}
