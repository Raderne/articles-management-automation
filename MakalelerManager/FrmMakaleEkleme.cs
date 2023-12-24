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
    public partial class FrmMakaleEkleme : Form
    {
        public FrmMakaleEkleme()
        {
            InitializeComponent();
        }

        Kullanicilar kullanici;

        public FrmMakaleEkleme(Kullanicilar loginOlanKullanici)
        {
            InitializeComponent();
            kullanici = loginOlanKullanici;
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg resimleri|*.jpg|png resimleri|*.png|jpeg resimleri|*.jpeg";
            ofd.ShowDialog();
            if (ofd.CheckFileExists)
                picResim.Image = Image.FromFile(ofd.FileName);
        }

        private void FrmMakaleEkleme_Load(object sender, EventArgs e)
        {
            using (MakalelerManagerEntities db = new MakalelerManagerEntities())
            {
                Personeller personel = db.Personellers.Where(x => x.PersonelID == kullanici.PersonelID).FirstOrDefault();
                lblMakaleYazar.Text = personel.PersonelAd + " " + personel.PersonelSoyad;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string makaleBaslik = txtMakaleBaslik.Text;
            string makaleIcerik = txtMakaleIcerik.Text;
            int makaleYazarID = (int)kullanici.PersonelID;
            string makaleKategori = cbMakaleKategori.SelectedItem.ToString();

            if (string.IsNullOrEmpty(makaleBaslik) || string.IsNullOrEmpty(makaleIcerik) || string.IsNullOrEmpty(makaleKategori))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MakalelerManagerEntities db = new MakalelerManagerEntities())
            {
                Makaleler makale = new Makaleler();
                makale.MakaleYazar = lblMakaleYazar.Text;
                makale.MakaleBaslik = makaleBaslik;
                makale.MakaleIcerik = makaleIcerik;
                makale.PersonelID = makaleYazarID;
                makale.MakaleKategori = makaleKategori;

                if (picResim.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    picResim.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    makale.MakaleResim = ms.ToArray();
                }

                db.Makalelers.Add(makale);
                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Makale başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMakaleBaslik.Text = "";
                    txtMakaleIcerik.Text = "";
                    cbMakaleKategori.SelectedIndex = -1;
                    picResim.Image = null;
                }
                else
                {
                    MessageBox.Show("Makale eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
