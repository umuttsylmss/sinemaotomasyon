using Microsoft.VisualBasic;
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
    public partial class FrmBiletOlustur : Form
    {
        public FrmBiletOlustur()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=Umut;Initial Catalog=sinema;Integrated Security=True");
        private void FrmBiletOlustur_Load(object sender, EventArgs e)
        {
            filmAdiGetir();
            biletNolustur();
        }

        void biletNolustur()
        {
            Random rastgele = new Random();
            string karakterler = "12345678987654321";
            string kod = "";

            for (int i = 0; i < 11; i++)
            {
                kod += karakterler[rastgele.Next(karakterler.Length)];
            }
            txtBiletNo.Text = kod.ToString();
        }


        void filmAdiGetir()
        {
            string sorgu = "select * from Tbl_Filmler ORDER BY ADI ASC";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                string gelenTarih = oku["TARIH"].ToString();

                DateTime fTarih = Convert.ToDateTime(gelenTarih);
                DateTime bugun = DateTime.Today;

                TimeSpan timeSpan = fTarih - bugun;
                if (timeSpan.TotalDays <= 0)
                {
                    cbFlimAdi.Items.Add(oku["ADI"].ToString());
                }


            }
            baglanti.Close();
        }

        private void cbFlimAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DISTINCT --> VERİ TABANINDA KAYITLI OLAN AYNI TÜRDEN VERİLERDEN SADECE BİRTANESİNİ GÖSTERİR
            cbTarih.Items.Clear();
            string sorgu = "select DISTINCT TARIH from Tbl_Kontrol WHERE FILMADI =@filmadi";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@filmadi", cbFlimAdi.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cbTarih.Items.Add(oku["TARIH"].ToString());
            }
            baglanti.Close();
        }
        void biletNoSorgula()
        {
            string sorgu = "select * from Tbl_Biletler where BKOD=@no";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@no", txtBiletNo.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            if (!oku.Read())
            {
                kaydetMETODU();
            }
            else
            {
                biletNolustur();
                baglanti.Close();
                biletNoSorgula();
            }
            baglanti.Close();

        }
        void kaydetMETODU()
        {
            string sorgu = "insert into Tbl_Biletler (BKOD,ADSOYAD,TELNO,KOLTUKNO,FILMADI,TARIH,SAAT,SALON,TUR,ISLEMSAAT) Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)";
            baglanti.Close();
            baglanti.Open();
            SqlCommand kayit = new SqlCommand(sorgu, baglanti);
            kayit.Parameters.AddWithValue("@p1", txtBiletNo.Text.ToString());
            kayit.Parameters.AddWithValue("@p2", txtAdSoyad.Text.ToUpper().ToString());
            kayit.Parameters.AddWithValue("@p3", txtTelNo.Text.ToString());
            kayit.Parameters.AddWithValue("@p4", txtKoltuklar.Text.ToString());
            kayit.Parameters.AddWithValue("@p5", cbFlimAdi.Text.ToString());
            kayit.Parameters.AddWithValue("@p6", cbTarih.Text.ToString());
            kayit.Parameters.AddWithValue("@p7", lblSeansSec.Text.ToString());
            kayit.Parameters.AddWithValue("@p8", cbSalon.Text.ToString());
            kayit.Parameters.AddWithValue("@p9", cbBiletTuru.Text.ToString());
            kayit.Parameters.AddWithValue("@p10", DateTime.Now.ToString());
            kayit.ExecuteNonQuery();
            baglanti.Close();

            string sorgu2 = "UPDATE Tbl_Kontrol SET KOLTUKLAR=@numara WHERE FILMADI=@filmadi AND TARIH=@tarih AND SAAT=@saat AND SALONADI=@salonadi";
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand(sorgu2, baglanti);

            if (lblGelenKoltuk.Text.ToString() == "")
            {
                guncelle.Parameters.AddWithValue("@numara", lblGelenKoltuk.Text.ToString());
            }
            else
            {
                guncelle.Parameters.AddWithValue("@numara", lblGelenKoltuk.Text.ToString() + "," + txtKoltuklar.Text.ToString());
            }

            guncelle.Parameters.AddWithValue("@filmadi", cbFlimAdi.Text.ToString());
            guncelle.Parameters.AddWithValue("@tarih", cbTarih.Text.ToString());
            guncelle.Parameters.AddWithValue("@saat", lblSeansSec.Text.ToString());
            guncelle.Parameters.AddWithValue("@salonadi", cbSalon.Text.ToString());
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            //GÜNCELEME KOMUTU


            MessageBox.Show("BİLET SATIŞI GERÇEKLEŞTİ");
            salonDurumGeldi();

            lblGelenKoltuk.Text = "";
            listeGelenKoltuk.Items.Clear();
            lblBelirlenen.Items.Clear();
            txtKoltuklar.Text = "";

        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text != "" && txtBiletNo.Text != "" && txtKoltuklar.Text != "" && txtTelNo.Text != "" && cbBiletTuru.Text != "" && cbFlimAdi.Text != "" && cbSalon.Text != "" && cbTarih.Text != "")
            {
                //kayıt işlemleri
                biletNoSorgula(); // SORGULAMA SONUCUNDA VAR OLAN NUMARA VERİTABANINDA KAYITLI DEĞİL İSE KAYIT - EKLEME İŞLEMİ OLACAK

            }

            else
            {

            }

        }
        void Sectiklerimiz()
        {
            txtKoltuklar.Text = "";
            foreach (string item in lblBelirlenen.Items)
            {
                txtKoltuklar.Text += "," + item;
            }
            if (txtKoltuklar.Text.Length > 1)
            {
                txtKoltuklar.Text = txtKoltuklar.Text.Substring(1);
            }
        }
        private void btn_Click(object sender, EventArgs e)
        {
            //tıklama
            Button btn = (Button)sender;
            if (btn.ForeColor == Color.Black) //arka plan kırmızı yani dolu
            {
                MessageBox.Show("BU KOLTUK DOLUDUR!");

            }
            else
            {
                if (btn.ForeColor == Color.Red)
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.mavi);
                    btn.ForeColor = Color.Blue;
                    lblBelirlenen.Items.Add(btn.Text);
                    Sectiklerimiz();

                }
                else
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.sari);
                    btn.ForeColor = Color.Red;
                    lblBelirlenen.Items.Remove(btn.Text);
                    Sectiklerimiz();
                }
            }


        }

        private void cbTarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DISTINCT --> VERİ TABANINDA KAYITLI OLAN AYNI TÜRDEN VERİLERDEN SADECE BİRTANESİNİ GÖSTERİR
            panelSeans.Controls.Clear();
            string saatler = "";
            string sorgu = "select DISTINCT SAAT from Tbl_Kontrol WHERE FILMADI=@filmadi AND TARIH=@tarih";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@filmadi", cbFlimAdi.Text.ToString());
            komut.Parameters.AddWithValue("@tarih", cbTarih.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                saatler = oku["SAAT"].ToString();
                RadioButton rnd = new RadioButton();
                rnd.Text = saatler;
                rnd.ForeColor = Color.Red;

                rnd.CheckedChanged += new EventHandler(SeansSaatler);
                rnd.FlatStyle = FlatStyle.Flat;
                panelSeans.Controls.Add(rnd);

            }
            baglanti.Close();
        }
        void SeansSaatler(object sender, EventArgs e)
        {
            foreach (RadioButton item in panelSeans.Controls)
            {
                if (item.Checked)// bu format şeçili yani true demek oluyo
                {
                    lblSeansSec.Text = item.Text;
                    cbSalon.Items.Clear();
                    //DISTINCT --> VERİ TABANINDA KAYITLI OLAN AYNI TÜRDEN VERİLERDEN SADECE BİRTANESİNİ GÖSTERİR


                    string sorgu = "select DISTINCT SALONADI from Tbl_Kontrol WHERE FILMADI=@filmadi AND TARIH=@tarih AND SAAT=@saat";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@filmadi", cbFlimAdi.Text.ToString());
                    komut.Parameters.AddWithValue("@tarih", cbTarih.Text.ToString());
                    komut.Parameters.AddWithValue("@saat", lblSeansSec.Text.ToString());
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        cbSalon.Items.Add(oku["SALONADI"].ToString());


                    }
                    baglanti.Close();
                }
            }


        }



        private void cbSalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            salonDurumGeldi();
        }
        void salonDurumGeldi()
        {
            string sorgu = "select * from Tbl_Salonlar WHERE SALONADI=@salonadi";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@salonadi", cbSalon.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblKoltukSayisi.Text = oku["KOLTUKSAYISI"].ToString();


            }
            baglanti.Close();
            KoltukGetir();
            Doldur();
        }
        void Doldur()
        {
            KoltukPaneli.Controls.Clear();
            int sayi = Convert.ToInt16(lblKoltukSayisi.Text);
            for (int i = 1; i <= sayi; i++)
            {
                Button btn = new Button();
                if (i <= 8)
                {
                    btn.Text = "A" + i.ToString();
                    btn.Name = "A" + i.ToString();
                }
                else if (i <= 16)
                {
                    btn.Text = "B" + i.ToString();
                    btn.Name = "B" + i.ToString();
                }
                else if (i <= 24)
                {
                    btn.Text = "C" + i.ToString();
                    btn.Name = "C" + i.ToString();
                }
                else if (i <= 32)
                {
                    btn.Text = "D" + i.ToString();
                    btn.Name = "D" + i.ToString();
                }
                else if (i <= 40)
                {
                    btn.Text = "E" + i.ToString();
                    btn.Name = "E" + i.ToString();
                }
                else if (i <= 48)
                {
                    btn.Text = "F" + i.ToString();
                    btn.Name = "F" + i.ToString();
                }
                else if (i <= 56)
                {
                    btn.Text = "G" + i.ToString();
                    btn.Name = "G" + i.ToString();
                }
                else if (i <= 64)
                {
                    btn.Text = "H" + i.ToString();
                    btn.Name = "H" + i.ToString();
                }
                else if (i <= 72)
                {
                    btn.Text = "I" + i.ToString();
                    btn.Name = "I" + i.ToString();
                }

                btn.Width = 50;
                btn.Height = 50;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0; // çerçeve kaldır
                btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9);

                btn.Click += btn_Click;
                if (listeGelenKoltuk.Items.Contains(btn.Text))
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.kir);

                    btn.ForeColor = Color.Black;


                }

                else
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.sari);
                    btn.ForeColor = Color.Red;

                }




                KoltukPaneli.Controls.Add(btn);


            }
        }

        void KoltukGetir()
        {
            //DISTINCT --> VERİ TABANINDA KAYITLI OLAN AYNI TÜRDEN VERİLERDEN SADECE BİRTANESİNİ GÖSTERİR

            lblGelenKoltuk.Text = "";
            string sorgu = "select * from Tbl_Kontrol WHERE FILMADI=@filmadi AND TARIH=@tarih AND SAAT=@saat AND SALONADI=@salonadi";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@filmadi", cbFlimAdi.Text.ToString());
            komut.Parameters.AddWithValue("@tarih", cbTarih.Text.ToString());
            komut.Parameters.AddWithValue("@saat", lblSeansSec.Text.ToString());
            komut.Parameters.AddWithValue("@salonadi", cbSalon.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblGelenKoltuk.Text += " ," + oku["KOLTUKLAR"].ToString();

                if (lblGelenKoltuk.Text.Length > 2)
                {
                    lblGelenKoltuk.Text = lblGelenKoltuk.Text.Substring(2);
                }
                else
                {
                    lblGelenKoltuk.Text = "";
                }

            }
            baglanti.Close();
            koltukAyirma();

        }
        void koltukAyirma()
        {
            listeGelenKoltuk.Items.Clear();
            string no = "";
            string[] sec;
            no = lblGelenKoltuk.Text.ToString();
            sec = no.Split(',');//hangi karakteri belirttiysek o karakterde ayırma işlemi yapar
            foreach (string bulunan in sec)
            {
                listeGelenKoltuk.Items.Add(bulunan);
            }
        }

        private void txtBiletNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox13_Enter(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Text = "";
            txtTelNo.Text = "";
            txtKoltuklar.Text = "";
            cbBiletTuru.Text = "";
            cbSalon.Text = "";
            cbTarih.Text = "";
            txtBiletNo.Text = "";
            lblGelenKoltuk.Text = "";
            lblKoltukSayisi.Text = "";
            lblSeansSec.Text = "";
            cbSalon.Items.Clear();
            cbTarih.Items.Clear();
            cbBiletTuru.Items.Clear();
            cbBiletTuru.Items.Add("YETİŞKİN");
            cbBiletTuru.Items.Add("İNDİRİMLİ");
            biletNolustur();
            panelSeans.Controls.Clear();
            KoltukPaneli.Controls.Clear();
            lblBelirlenen.Items.Clear();
            cbFlimAdi.Items.Clear();
            listeGelenKoltuk.Items.Clear();
            filmAdiGetir();
            txtAdSoyad.Focus();







        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
