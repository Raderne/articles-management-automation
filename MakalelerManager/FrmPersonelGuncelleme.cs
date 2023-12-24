using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakalelerManager
{
    public partial class FrmPersonelGuncelleme : Form
    {
        public FrmPersonelGuncelleme()
        {
            InitializeComponent();
        }

        public Personeller personel;

        public FrmPersonelGuncelleme(Personeller GuncellecekPersonel)
        {
            InitializeComponent();
            personel = GuncellecekPersonel;
        }

        private void FrmPersonelGuncelleme_Load(object sender, EventArgs e)
        {
            txtPersonelAd.Text = personel.PersonelAd;
            txtPersonelSoyad.Text = personel.PersonelSoyad;
            txtTcNo.Text = personel.PersonelTcNo.ToString();
            txtPersonelDogumYil.Text = personel.PersonelDogumYil.ToString();
            if (personel.PersonelResim != null)
            {
                picResim.Image = Image.FromStream(new MemoryStream(personel.PersonelResim));
            }
            if (personel.PersonelCinsiyet == "Erkek")
            {
                rbErkek.Checked = true;
            }
            else
            {
                rbKadin.Checked = true;
            }
        }

        public event EventHandler PersonelGuncellendi;

        private void btnPersonelGuncelleme_Click(object sender, EventArgs e)
        {
            string personelAd = txtPersonelAd.Text;
            string personelSoyad = txtPersonelSoyad.Text;
            long personelTcNo = Convert.ToInt64(txtTcNo.Text);
            int personelDogumYil = Convert.ToInt32(txtPersonelDogumYil.Text);

            if (txtPersonelAd.Text == "" || txtPersonelSoyad.Text == "" || txtTcNo.Text == "" || txtPersonelDogumYil.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }
            else
            {
                using (MakalelerManagerEntities db = new MakalelerManagerEntities())
                {
                    Personeller personelGuncelleme = db.Personellers.Where(x => x.PersonelID == personel.PersonelID).FirstOrDefault();
                    personelGuncelleme.PersonelAd = personelAd;
                    personelGuncelleme.PersonelSoyad = personelSoyad;
                    personelGuncelleme.PersonelTcNo = personelTcNo;
                    personelGuncelleme.PersonelDogumYil = personelDogumYil;
                    personelGuncelleme.PersonelCinsiyet = rbErkek.Checked ? "Erkek" : "Kadın";
                    if (picResim.Image != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        picResim.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        personelGuncelleme.PersonelResim = ms.ToArray();
                    }

                    int sonuc = db.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Personel güncellendi.");
                        //FrmPersonelListele frm = new FrmPersonelListele();
                        //frm.MdiParent = this.MdiParent;
                        //frm.Show();

                        PersonelGuncellendi(personelGuncelleme, null);
                    }
                    else
                    {
                        MessageBox.Show("Personel güncellenemedi.", "Hata");
                    }
                }
            }
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            using (MakalelerManagerEntities db = new MakalelerManagerEntities())
            {
                Personeller personelSil = db.Personellers.Where(x => x.PersonelID == personel.PersonelID).FirstOrDefault();
                Kullanicilar kullaniciSil = db.Kullanicilars.Where(x => x.PersonelID == personel.PersonelID).FirstOrDefault();
                db.Kullanicilars.Remove(kullaniciSil);
                db.Personellers.Remove(personelSil);
                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Personel silindi.");
                    FrmPersonelListele frm = new FrmPersonelListele();
                    frm.MdiParent = this.MdiParent;
                    frm.Show();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Personel silinemedi.");
                }
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpeg resimleri|*.jpg|png resimleri|*.png";
            ofd.ShowDialog();
            if (ofd.CheckFileExists)
                picResim.Image = Image.FromFile(ofd.FileName);
        }
    }
}
