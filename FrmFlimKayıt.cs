using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyon
{
    public partial class FrmFlimKayıt : Form
    {
        public FrmFlimKayıt()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            verileriSil();

        }

        void verileriSil()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Tbl_Secilenler", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rB1_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "1";

        }

        private void rB2_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "2";
        }

        private void rB3_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "3";
        }

        private void rB4_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "4";
        }

        private void rB5_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "5";
        }

        private void rB6_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "6";
        }

        private void rB7_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "7";
        }

        private void rB8_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "8";
        }

        private void rB9_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "9";
        }

        private void rB10_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "10";
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

        private void lblKarakter_Click(object sender, EventArgs e)
        {
            int karakteSayisi = txtFlimDetay.Text.Length;
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

        private void txtOyuncuAra_TextChanged(object sender, EventArgs e)
        {
            OyuncuAra();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=Umut;Initial Catalog=sinema;Integrated Security=True");
        private void FrmFlimKayıt_Load(object sender, EventArgs e)
        {
            yListesiGetir();
            oListesiGetir();
            bugununTarihi();
            txtFlimAdi.Focus();


        }
        void bugununTarihi()
        {
            nGun.Value = DateTime.Today.Day;
            nAy.Value = DateTime.Today.Month;
            nYil.Value = DateTime.Today.Year;



        }
        void yListesiGetir()
        {
            string sorgu = "select * from Tbl_Yonetmenler ORDER BY ADSOYAD ASC";
            fYonetmenPaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                yListeAracı arac = new yListeAracı();
                arac.lblAdi.Text = oku["ADSOYAD"].ToString();
                fYonetmenPaneli.Controls.Add(arac);

            }
            baglanti.Close();

        }
        void oListesiGetir()
        {
            string sorgu = "select * from Tbl_Oyuncular ORDER BY ADSOYAD ASC";
            fOyuncuPaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                oListePaneli arac = new oListePaneli();
                arac.lblAdi.Text = oku["ADSOYAD"].ToString();
                fOyuncuPaneli.Controls.Add(arac);

            }
            baglanti.Close();
        }

        private void txtYonetmenAra_TextChanged(object sender, EventArgs e)
        {
            YonetmenAra();
        }
        void YonetmenAra()
        {


            string sorgu = "select * from Tbl_Yonetmenler Where ADSOYAD LIKE'%" + txtOyuncuAra.Text + "%'collate Turkish_CI_AS ORDER BY ADSOYAD ASC";
            fYonetmenPaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                yListeAracı arac = new yListeAracı();
                arac.lblAdi.Text = oku["ADSOYAD"].ToString();
                fYonetmenPaneli.Controls.Add(arac);

            }
            baglanti.Close();


        }
        void OyuncuAra()
        {

            string sorgu = "select * from Tbl_Oyuncular Where ADSOYAD LIKE'%" + txtYonetmenAra.Text + "%'collate Turkish_CI_AS ORDER BY ADSOYAD ASC";
            fOyuncuPaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                oListePaneli arac = new oListePaneli();
                arac.lblAdi.Text = oku["ADSOYAD"].ToString();
                fOyuncuPaneli.Controls.Add(arac);

            }
            baglanti.Close();

        }

        private void lblAksiyon_Click(object sender, EventArgs e)
        {
            if (lblAksiyon.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblAksiyon.ForeColor = Color.Red;
            }
            else
            {
                lblAksiyon.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lblKorku_Click(object sender, EventArgs e)
        {
            if (lblKorku.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblKorku.ForeColor = Color.Red;
            }
            else
            {
                lblKorku.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lblDrama_Click(object sender, EventArgs e)
        {
            if (lblDrama.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblDrama.ForeColor = Color.Red;
            }
            else
            {
                lblDrama.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lblAsk_Click(object sender, EventArgs e)
        {
            if (lblAsk.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblAsk.ForeColor = Color.Red;
            }
            else
            {
                lblAsk.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lblGerilim_Click(object sender, EventArgs e)
        {
            if (lblGerilim.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblGerilim.ForeColor = Color.Red;
            }
            else
            {
                lblGerilim.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lblKomedi_Click(object sender, EventArgs e)
        {
            if (lblKomedi.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblKomedi.ForeColor = Color.Red;
            }
            else
            {
                lblKomedi.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }



        private void lblTurkce_Click(object sender, EventArgs e)
        {
            if (lblTurkce.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblTurkce.ForeColor = Color.Red;
            }
            else
            {
                lblTurkce.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lbl_İngilizce_Click(object sender, EventArgs e)
        {
            if (lbl_İngilizce.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lbl_İngilizce.ForeColor = Color.Red;
            }
            else
            {
                lbl_İngilizce.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lblAltYazı_Click(object sender, EventArgs e)
        {
            if (lblAltYazi.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblAltYazi.ForeColor = Color.Red;
            }
            else
            {
                lblAltYazi.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }



        private void lblGenelİz_Click(object sender, EventArgs e)
        {
            if (lblGenelİz.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblGenelİz.ForeColor = Color.Red;
                pB1.ImageLocation = @"C:\Users\umuts\OneDrive\Desktop\İconlar\unlock.png";
            }
            else
            {
                lblGenelİz.ForeColor = Color.FromArgb(84, 110, 122);
                pB1.ImageLocation = @"C:\Users\umuts\OneDrive\Desktop\İconlar\unlock.png";
            }
        }

        private void lblKorkuS_Click(object sender, EventArgs e)
        {
            if (lblKorkuS.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblKorkuS.ForeColor = Color.Red;
                pB2.ImageLocation = @"C:\Users\umuts\OneDrive\Desktop\İconlar\unlock.png";
            }
            else
            {
                lblKorkuS.ForeColor = Color.FromArgb(84, 110, 122);
                pB2.ImageLocation = @"C:\Users\umuts\OneDrive\Desktop\İconlar\unlock.png";
            }
        }

        private void lblOlumsuzİ_Click(object sender, EventArgs e)
        {
            if (lblOlumsuzİ.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblOlumsuzİ.ForeColor = Color.Red;
                pB3.ImageLocation = @"C:\Users\umuts\OneDrive\Desktop\İconlar\unlock.png";
            }
            else
            {
                lblOlumsuzİ.ForeColor = Color.FromArgb(84, 110, 122);
                pB3.ImageLocation = @"C:\Users\umuts\OneDrive\Desktop\İconlar\unlock.png";
            }
        }

        private void lblCinsellik_Click(object sender, EventArgs e)
        {
            if (lblCinsellik.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblCinsellik.ForeColor = Color.Red;
                pB4.ImageLocation = @"C:\Users\umuts\OneDrive\Desktop\İconlar\unlock.png";
            }
            else
            {
                lblCinsellik.ForeColor = Color.FromArgb(84, 110, 122);
                pB4.ImageLocation = @"C:\Users\umuts\OneDrive\Desktop\İconlar\unlock.png";
            }
        }

        private void lblYedi_Click(object sender, EventArgs e)
        {
            if (lblYedi.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblYedi.ForeColor = Color.Red;
                pB5.ImageLocation = @"C:\Users\umuts\OneDrive\Desktop\İconlar\unlock.png";
            }
            else
            {
                lblYedi.ForeColor = Color.FromArgb(84, 110, 122);
                pB5.ImageLocation = @"C:\Users\umuts\OneDrive\Desktop\İconlar\unlock.png";
            }
        }

        private void lblOnüc_Click(object sender, EventArgs e)
        {
            if (lblOnuc.ForeColor == Color.FromArgb(84, 110, 122))
            {
                lblOnuc.ForeColor = Color.Red;
                pB6.ImageLocation = @"C:\Users\umuts\OneDrive\Desktop\İconlar\unlock.png";
            }
            else
            {
                lblOnuc.ForeColor = Color.FromArgb(84, 110, 122);
                pB6.ImageLocation = @"C:\Users\umuts\OneDrive\Desktop\İconlar\unlock.png";
            }
        }



        private void button5_Click(object sender, EventArgs e)
        {
            vizyonTarihiHesapla();
        }
        string vTarih = "";
        string durum = "0";
        void vizyonTarihiHesapla()
        {
            vTarih = nGun.Value + "-" + nAy.Value + "-" + nYil.Value;
            DateTime dVTarih = Convert.ToDateTime(vTarih);
            DateTime bugunTarihi = DateTime.Today;

            //timespan--> var olan iki tarih arasında gün yıl ay saati belirler

            TimeSpan tSpan = dVTarih - bugunTarihi;
            if (tSpan.TotalDays < 0)
            {
                //iki tarih arasında bulunan negatif ise
                MessageBox.Show("Geçmiş Tarihler Arası Film Eklenmesi Yapılamaz!");
                bugununTarihi();

            }
            else if (tSpan.TotalDays == 0)
            {
                durum = "1";
                MessageBox.Show(txtFlimAdi.Text.ToUpper() + "FİLMİ BUGÜN VİZYONDA");

            }

            else
            {
                durum = "0";
                MessageBox.Show(txtFlimAdi.Text.ToUpper() + " " + tSpan.TotalDays.ToString() + "GÜN SONRA VİZYONA GİRECEK!");

            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToShortDateString();
            lblSaat.Text = DateTime.Now.ToShortTimeString();
        }

        string yonetmen = "";
        string oyuncu = "";

        void secilenYonetmen()
        {
            yonetmen = "";
            string sorgu = "select * from Tbl_Secilenler Where TUR='YÖNETMEN'";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();


            while (oku.Read())// burası if olursa tek bir şeçim yapar o yüzden while
            {

                yonetmen += " ," + oku["KISI"].ToString();

            }


            baglanti.Close();



        }

        void secilenOyuncu()
        {
            oyuncu = "";
            string sorgu = "select * from Tbl_Secilenler Where TUR='OYUNCU'";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();


            while (oku.Read())// burası if olursa tek bir şeçim yapar o yüzden while
            {

                oyuncu += " ," + oku["KISI"].ToString();

            }


            baglanti.Close();



        }

        void temizlemeMetodu()
        {

            this.Controls.Clear();
            this.InitializeComponent();
            txtFlimAdi.Focus();
            verileriSil();
            yListesiGetir();
            oListesiGetir();
            bugununTarihi();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            secilenOyuncu();
            secilenYonetmen();
            vizyonTarihiHesapla();
            tur();
            ozellik();
            bicim();





            //insert intro kullanarak verileri veritabanına kaydetme işlemi
            //input kontrolü sağlama

            if (txtFlimAdi.Text != "" && txtFlimDetay.Text != "" && yonetmen != "" && oyuncu != "" && resimYolu != "" && vTarih != "" && secilenBicim != "" && secilenOzellik != "" && secilenTur != "")
            {
                //alanlarımız dolu ise

                string sorgu = "insert into Tbl_Filmler (ADI,TURU,OZELLIKLERI,BICIMI,YONETMEN,OYUNCU,DETAY,PUAN,AFIS,TARIH,DURUM) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)";
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", txtFlimAdi.Text.ToUpper());


                if (secilenTur.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p2", secilenTur.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p2", secilenTur);
                }


                if (secilenOzellik.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p3", secilenOzellik.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p3", secilenOzellik);
                }


                if (secilenBicim.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p4", secilenBicim.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p4", secilenBicim);
                }



                if (yonetmen.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p5", yonetmen.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p5", yonetmen);
                }


                if (oyuncu.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p6", oyuncu.Substring(2));
                }
                else
                {
                    komut.Parameters.AddWithValue("@p6", oyuncu);
                }





                komut.Parameters.AddWithValue("@p7", txtFlimDetay.Text.ToUpper());
                komut.Parameters.AddWithValue("@p8", lblRating.Text);
                komut.Parameters.AddWithValue("@p9", resimYolu);
                komut.Parameters.AddWithValue("@p10", vTarih);
                komut.Parameters.AddWithValue("@p11", durum);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("FİLM KAYDI BAŞARILI BİR ŞEKİLDE EKLENMİŞTİR");
                temizlemeMetodu();

            }

            else
            {
                //alanlar boş ise
                MessageBox.Show("LÜTFEN İLGİLİ SEÇİMLERİ YAPINIZ!!");

            }






        }
        string secilenTur = "";
        string secilenOzellik = "";
        string secilenBicim = "";
        void tur()
        {

            foreach (Control arac in grBTur.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(84, 110, 122))
                    {

                    }
                    else
                    {
                        secilenTur += " ," + arac.Text.ToString();
                    }
                }
            }

        }
        void ozellik()
        {

            foreach (Control arac in grBOzellik.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(84, 110, 122))
                    {

                    }
                    else
                    {
                        secilenOzellik += " ," + arac.Text.ToString();
                    }
                }
            }

        }
        void bicim()
        {

            foreach (Control arac in grBbicim.Controls)
            {
                if (arac is Label)
                {
                    if (arac.ForeColor == Color.FromArgb(84, 110, 122))
                    {

                    }
                    else
                    {
                        secilenBicim += " ," + arac.Text.ToString();
                    }
                }
            }

        }

        private void pB1_Click(object sender, EventArgs e)
        {

        }
    }
}
