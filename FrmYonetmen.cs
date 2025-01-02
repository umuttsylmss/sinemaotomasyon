using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace SinemaOtomasyon
{
    public partial class FrmYonetmen : Form
    {
        public FrmYonetmen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "1";
        }

        public string cinsiyet = "0";

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
        public string resimYolu = "";
        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESİM ŞEÇME EKRANI";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *.jpg;*.jpeg | All Files |*.*";
            ofd.FilterIndex = 3;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //resim alma işlemi bu kısımda 
                pBResim.Image = new Bitmap(ofd.FileName);
                resimYolu = ofd.FileName.ToString();
            }
        }

        private void rBErkek_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "0";
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=Umut;Initial Catalog=sinema;Integrated Security=True");
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtSoyad.Text != "" && txtBiyografi.Text != "" && txtBiyografi.Text != "" && resimYolu != "")
            {
                string adSoyad = txtAd.Text.ToString().ToUpper() + "  " + txtSoyad.Text.ToString().ToUpper();
                //toupper : var olan karakterlerin tümünü büyük harf yapar
                baglanti.Open();
                SqlCommand kayit = new SqlCommand("insert into Tbl_Yonetmenler(ADSOYAD,CINSIYET,YAS,BIYOGRAFI,RESİM) VALUES (@p1,@p2,@p3,@p4,@p5)", baglanti);
                kayit.Parameters.AddWithValue("@p1", adSoyad);
                kayit.Parameters.AddWithValue("@p2", cinsiyet);
                kayit.Parameters.AddWithValue("@p3", bYas);
                kayit.Parameters.AddWithValue("@p4", txtBiyografi.Text.ToString().ToUpper());
                kayit.Parameters.AddWithValue("@p5", resimYolu);
                kayit.ExecuteNonQuery();
                MessageBox.Show("YÖNETMEN KAYIT İŞLEMİNİZ BAŞARILI BİR ŞEKİLDE GERÇEKLEŞTİ");
                AracTemizle();
                baglanti.Close();
            }

            else
            {

                MessageBox.Show("Önemli Alanlar Boş!!");

            }


            void AracTemizle()
            {
                txtAd.Text = "";
                txtSoyad.Text = "";
                txtBiyografi.Text = "";
                nGun.Value = 1;
                nAy.Value = 1;
                nYil.Value = 2024;
                rBErkek.Checked = true;
                rBKadin.Checked = false;
                lblKarakter.Text = "300";
                cinsiyet = "0";
                bYas = "00";
                txtAd.Focus();







            }



            yasHesaplama();


        }

        public string bYas = "0";


        void yasHesaplama()
        {

            string dogum = nGun.Value.ToString() + "-" + nAy.Value.ToString() + "-" + nYil.Value.ToString();
            DateTime dogumTarihi = Convert.ToDateTime(dogum);
            DateTime bugun = DateTime.Today;
            int yas = bugun.Year - dogumTarihi.Year;



            bYas = yas.ToString();

        }

        private void lblKarakter_Click(object sender, EventArgs e)
        {

        }

        private void txtBiyografi_TextChanged(object sender, EventArgs e)
        {
            int karakteSayisi = txtBiyografi.Text.Length;
            int geri = 300 - karakteSayisi;
            lblKarakter.Text = geri.ToString();
            if (geri > 50)

            {
                lblKarakter.ForeColor = Color.FromArgb(84, 110, 122);

            }
            if (geri <= 50)

            {
                lblKarakter.ForeColor = Color.Orange;

            }

            if (geri <= 20)

            {
                lblKarakter.ForeColor = Color.Red;

            }
        }

        private void FrmYonetmen_Load(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nGun_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pBResim_Click(object sender, EventArgs e)
        {

        }

        private void nYil_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
