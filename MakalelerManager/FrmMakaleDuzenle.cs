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
    public partial class FrmMakaleDuzenle : Form
    {
        public FrmMakaleDuzenle()
        {
            InitializeComponent();
        }

        public int MakaleID;
        Kullanicilar kullanici;

        public FrmMakaleDuzenle(int makaleID)
        {
            InitializeComponent();
            MakaleID = makaleID;
        }

        private void FrmMakaleDuzenle_Load(object sender, EventArgs e)
        {
            using (MakalelerManagerEntities db = new MakalelerManagerEntities())
            {
                Makaleler makale = db.Makalelers.Where(x => x.MakaleID == MakaleID).FirstOrDefault();
                lblMakaleID.Text = MakaleID.ToString();
                txtMakaleBaslik.Text = makale.MakaleBaslik;
                txtMakaleIcerik.Text = makale.MakaleIcerik;
                cbMakaleKategori.SelectedItem = makale.MakaleKategori;
                if (makale.MakaleResim != null)
                {
                    picResim.Image = Image.FromStream(new MemoryStream(makale.MakaleResim));
                }

                kullanici = db.Kullanicilars.Where(x => x.PersonelID == makale.PersonelID).FirstOrDefault();
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg resimleri|*.jpg|png resimleri|*.png|jpeg resimleri|*.jpeg";
            ofd.ShowDialog();
            if (ofd.CheckFileExists)
                picResim.Image = Image.FromFile(ofd.FileName);
        }

        private void btnMakaleGuncelle_Click(object sender, EventArgs e)
        {
            string makaleBaslik = txtMakaleBaslik.Text;
            string makaleIcerik = txtMakaleIcerik.Text;
            string makaleKategori = cbMakaleKategori.SelectedItem.ToString();
            byte[] makaleResim = null;
            if (picResim.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                picResim.Image.Save(ms, picResim.Image.RawFormat);
                makaleResim = ms.ToArray();
            }

            using (MakalelerManagerEntities db = new MakalelerManagerEntities())
            {
                Makaleler makale = db.Makalelers.Where(x => x.MakaleID == MakaleID).FirstOrDefault();
                makale.MakaleBaslik = makaleBaslik;
                makale.MakaleIcerik = makaleIcerik;
                makale.MakaleKategori = makaleKategori;
                makale.MakaleResim = makaleResim;
                
                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Makale güncellendi.");
                    this.Close();

                    RedirectForm();
                }
                else
                {
                    MessageBox.Show("Makale güncellenemedi.");
                }
            }
        }

        private void RedirectForm()
        {
            if (kullanici.role == "manager")
            {
                FrmTumMakaleler frm = new FrmTumMakaleler(kullanici);
                frm.MdiParent = Application.OpenForms["FrmAnaEkran"];
                frm.Show();
            }
            else
            {
                FrmCalisanMakalelerListe frm = new FrmCalisanMakalelerListe(kullanici);
                frm.MdiParent = Application.OpenForms["FrmAnaEkran"];
                frm.Show();
            }
        }

        private void btnMakaleSil_Click(object sender, EventArgs e)
        {
            using (MakalelerManagerEntities db = new MakalelerManagerEntities())
            {
                Makaleler makale = db.Makalelers.Where(x => x.MakaleID == MakaleID).FirstOrDefault();
                db.Makalelers.Remove(makale);
                int sonuc = db.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Makale silindi.");
                    this.Close();

                    RedirectForm();
                }
                else
                {
                    MessageBox.Show("Makale silinemedi.");
                }
            }
        }
    }
}
