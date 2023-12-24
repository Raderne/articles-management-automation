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
    public partial class FrmGirisEkran : Form
    {
        public FrmGirisEkran()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAd.Text.ToUpper();
            string kullaniciSifre = txtKullaniciSifre.Text;

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(kullaniciSifre))
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş geçilemez.");
                return;
            }
            else
            {
                MakalelerManagerEntities db = new MakalelerManagerEntities();
                Kullanicilar kullanici = db.Kullanicilars.FirstOrDefault(x => x.KullaniciAd == kullaniciAdi && x.KullaniciSifre == kullaniciSifre);
                if (kullanici != null)
                {
                    FrmAnaEkran frmAnaEkran = new FrmAnaEkran(kullanici);
                    frmAnaEkran.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                    return;
                }
            }
        }
    }
}
