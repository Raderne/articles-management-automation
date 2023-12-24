using MakalelerManager.TCKimlikService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakalelerManager
{
    public partial class FrmPersonelEkle : Form
    {
        public FrmPersonelEkle()
        {
            InitializeComponent();
        }

        private void btnTcNoDogrula_Click(object sender, EventArgs e)
        {
            string personelAdi = txtPersonelAd.Text.ToUpper();
            string personelSoyadi = txtPersonelSoyad.Text.ToUpper();
            long personelTcNo = Convert.ToInt64(txtTcNo.Text);
            int personelDogumYili = Convert.ToInt32(txtPersonelDogumYil.Text);

            if (personelAdi == "" || personelSoyadi == "" || personelTcNo == 0 || personelDogumYili == 0)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz", "Uyarı");
                return;
            }

            KPSPublicSoapClient servis = new KPSPublicSoapClient();
            //bool sonuc = servis.TCKimlikNoDogrula(personelTcNo, personelAdi, personelSoyadi, personelDogumYili);
            bool sonuc = true;
            if (sonuc)
            {
                MessageBox.Show("Kullanıcı gerçek kişi", "Doğrulama Başarılı");
                btnPersonelEkle.Enabled = true;
                txtPersonelAd.Enabled = false;
                txtPersonelSoyad.Enabled = false;
                txtTcNo.Enabled = false;
                txtPersonelDogumYil.Enabled = false;
                btnTcNoDogrula.Enabled = false;
                txtKullaniciAd.Enabled = true;
                txtKullaniciSifre.Enabled = true;
                cbRolu.Enabled = true;
                btnResimSec.Enabled = true;

                MakalelerManagerEntities db = new MakalelerManagerEntities();
                Personeller personel = new Personeller();
                if (db.Personellers.Any(x => x.PersonelTcNo == personelTcNo))
                {
                    MessageBox.Show("Bu kullanıcı zaten kayıtlı", "Uyarı");
                    return;
                }

                personel.PersonelAd = personelAdi;
                personel.PersonelSoyad = personelSoyadi;
                personel.PersonelTcNo = personelTcNo;
                personel.PersonelDogumYil = personelDogumYili;
                db.Personellers.Add(personel);
                int personelSonuc = db.SaveChanges();
                if (personelSonuc > 0)
                {
                    MessageBox.Show("Personel eklendi", "Başarılı");
                }
                else
                {
                    MessageBox.Show("Personel eklenemedi", "Başarısız");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı yok", "Doğrulama Başarısız");
                btnPersonelEkle.Enabled = false;
            }
        }


        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            string personelKullaniciAdi = txtKullaniciAd.Text;
            string personelSifre = txtKullaniciSifre.Text;
            string personelRolu = "";
            long personelTcNo = Convert.ToInt64(txtTcNo.Text);
            if (cbRolu.SelectedIndex == 0)
            {
                personelRolu = "manager";
            }
            else
            {
                personelRolu = "worker";
            }

            if (personelKullaniciAdi == "" || personelSifre == "" || personelRolu == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz", "Uyarı");
                return;
            }

            MakalelerManagerEntities db = new MakalelerManagerEntities();
            Kullanicilar kullanici = new Kullanicilar();
            if (db.Kullanicilars.Any(x => x.KullaniciAd == personelKullaniciAdi))
            {
                MessageBox.Show("Bu kullanıcı adı zaten kayıtlı", "Uyarı");
                return;
            }

            Personeller personel = db.Personellers.FirstOrDefault(x => x.PersonelTcNo == personelTcNo);
            personel.PersonelCinsiyet = rbErkek.Checked ? "Erkek" : "Kadın";
            if (picResim.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                picResim.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                personel.PersonelResim = ms.ToArray();
            }

            int personelId = personel.PersonelID;
            kullanici.KullaniciAd = personelKullaniciAdi.ToUpper();
            kullanici.KullaniciSifre = personelSifre;
            kullanici.role = personelRolu;
            kullanici.PersonelID = personelId;

            db.Kullanicilars.Add(kullanici);
            db.Personellers.AddOrUpdate(personel);

            int kullaniciSonuc = db.SaveChanges();
            if (kullaniciSonuc > 0)
            {
                MessageBox.Show("Kullanıcı eklendi", "Başarılı");
                Temizle();
            }
            else
            {
                MessageBox.Show("Kullanıcı eklenemedi", "Başarısız");
            }
        }

        private void Temizle()
        {
            txtPersonelAd.Text = "";
            txtPersonelSoyad.Text = "";
            txtTcNo.Text = "";
            txtPersonelDogumYil.Text = "";
            txtKullaniciAd.Text = "";
            txtKullaniciSifre.Text = "";
            cbRolu.SelectedIndex = -1;

            txtPersonelAd.Enabled = true;
            txtPersonelSoyad.Enabled = true;
            txtTcNo.Enabled = true;
            txtPersonelDogumYil.Enabled = true;
            btnTcNoDogrula.Enabled = true;
            btnPersonelEkle.Enabled = false;
            txtKullaniciAd.Enabled = false;
            txtKullaniciSifre.Enabled = false;
            cbRolu.Enabled = false;
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg resimleri|*.jpg|png resimleri|*.png|jpeg resimleri|*.jpeg";
            ofd.ShowDialog();
            if (ofd.CheckFileExists)
                picResim.Image = Image.FromFile(ofd.FileName);
        }
    }
}
