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
    public partial class FrmSalonAtama : Form
    {
        public FrmSalonAtama()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=Umut;Initial Catalog=sinema;Integrated Security=True");
        private void FrmSalonAtama_Load(object sender, EventArgs e)
        {
            bugununTarihi();
            filmAdiGetir();
            SalonAdiGetir();
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

        void SalonAdiGetir()
        {
            string sorgu = "select * from Tbl_Salonlar ORDER BY SALONADI ASC";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cbSalon.Items.Add(oku["SALONADI"].ToString());



            }
            baglanti.Close();
        }

        void bugununTarihi()
        {
            nGun.Value = DateTime.Today.Day;
            nAy.Value = DateTime.Today.Month;
            nYil.Value = DateTime.Today.Year;



        }

        private void nAy_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (btnOlustur.Text == "TAMAMLA")
            {
                string sorgu = "select DISTINCT SAAT from Tbl_Kontrol WHERE TARIH=@tarih AND SALONADI=@salonadi";
                string tarih = nGun.Value + "-" + nAy.Value + "-" + nYil.Value;
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@tarih", tarih);
                komut.Parameters.AddWithValue("@salonadi", cbSalon.Text.ToString());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    cbDoluSaatler.Items.Add(oku["SAAT"].ToString());

                }

                baglanti.Close();

                seansKONTROL();

                btnOlustur.Text = "OLUŞTUR";
                btnOlustur.BackColor = Color.FromArgb(249, 164, 26);

            }
            else
            {
                kaydet();
                temizle();
                btnOlustur.Text = "TAMAMLA";
                btnOlustur.BackColor = Color.Red;
            }
        }

        void kaydet ()
        {
            string sorgu = "INSERT INTO Tbl_Kontrol (FILMADI, TARIH, SAAT, SALONADI) VALUES (@filmadi, @tarih, @saat, @salonadi)";
            string tarih = nGun.Value + "-" + nAy.Value + "-" + nYil.Value;
            baglanti.Open();
            SqlCommand ekle = new SqlCommand(sorgu, baglanti);

            // ComboBox ve Label kontrollerinin Text özelliklerini kullanıyoruz
            ekle.Parameters.AddWithValue("@filmadi", cbFlimAdi.Text);
            ekle.Parameters.AddWithValue("@tarih", tarih);
            ekle.Parameters.AddWithValue("@saat", lblSecilen.Text);
            ekle.Parameters.AddWithValue("@salonadi", cbSalon.Text);

            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Salon atama işlemi gerçekleşti.");

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
           
            temizle();
            
        }

        void temizle ()
        {
            cbFlimAdi.Items.Clear();
            cbSalon.Items.Clear();
            cbDoluSaatler.Items.Clear();
            lblSecilen.Text = "";
            bugununTarihi();
            filmAdiGetir();
            SalonAdiGetir();
            panelSeans.Controls.Clear();
            btnOlustur.Text = "TAMAMLA";
        }

        void SeansSaatler(object sender,EventArgs e)
        {
            foreach (RadioButton item in panelSeans.Controls)
            {
                if (item.Checked)// şeçili ise
                {
                    lblSecilen.Text = item.Text.ToString();
                }
            }
        }
        void seansKONTROL()
        {
            panelSeans.Controls.Clear(); //saat 10.00
            for (int i = 10; i <= 22; i++)
            {
                for (int j = 0; j <= 30; j += 30) // dakika 10.30
                {
                    RadioButton rdn = new RadioButton();
                    rdn.Font = new System.Drawing.Font("Segoe UI Semibold", 9);
                    rdn.CheckedChanged += new EventHandler(SeansSaatler);
                    if (j == 0) // sonuna sıfır eklmediği için yapıyoz
                    {
                        rdn.Text = i.ToString() + ":" + j.ToString() + "0";
                    }
                    else
                    {
                        rdn.Text = i.ToString() + ":" + j.ToString();
                    }
                    if (cbDoluSaatler.Items.Contains(rdn.Text)) // kullanılmış olan saati kaldır
                    {
                        rdn.Visible = false;

                    }

                    rdn.Text = i.ToString() + ":" + j.ToString();
                    panelSeans.Controls.Add(rdn);
                }
            }
        }
    }
}
