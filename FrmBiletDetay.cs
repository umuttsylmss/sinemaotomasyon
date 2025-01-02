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
    public partial class FrmBiletDetay : Form
    {
        public FrmBiletDetay()
        {
            InitializeComponent();
        }
        public string biletNo = "";
        private void FrmBiletDetay_Load(object sender, EventArgs e)
        {
            lblBiletNo.Text = biletNo;
            lblBiletNo2.Text = biletNo;
            barkodNolustur();
            bilgiGetir();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=Umut;Initial Catalog=sinema;Integrated Security=True");
        void bilgiGetir()
        {
            string sorgu = "select * from Tbl_Biletler where BKOD=@kod";
            baglanti.Open();
            SqlCommand getir = new SqlCommand(sorgu, baglanti);
            getir.Parameters.AddWithValue("@kod", biletNo);
            SqlDataReader oku = getir.ExecuteReader();
            if (oku.Read())
            {
                lblFlimAdi.Text = oku["FILMADI"].ToString();
                lblFlimAdi2.Text = oku["FILMADI"].ToString();
                lblTelNo.Text = oku["TELNO"].ToString();
                lblAdSoyad.Text = oku["ADSOYAD"].ToString();
                lblBiletTuru.Text = oku["TUR"].ToString();
                lblSalonAdi.Text = oku["SALON"].ToString();
                lblSalon2.Text = oku["SALON"].ToString();
                lblTarih2.Text = oku["TARIH"].ToString() + " " + oku["SAAT"].ToString();
                lblTarihSaat.Text = oku["TARIH"].ToString() + " " + oku["SAAT"].ToString();
                lblBugunTarih.Text = oku["ISLEMSAAT"].ToString();
                lblKoltuklar.Text = oku["KOLTUKNO"].ToString();
                lblKoltuk2.Text = oku["KOLTUKNO"].ToString();

            }
            baglanti.Close();


        }

        void barkodNolustur()
        {
            Random rastgele = new Random();
            string karakterler = "12345678987654321";
            string kod = "";

            for (int i = 0; i < 11; i++)
            {
                kod += karakterler[rastgele.Next(karakterler.Length)];
            }
            lblBarkod1.Text = kod.ToString();
            lblBarkod2.Text = kod.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSalon2_Click(object sender, EventArgs e)
        {

        }
    }
}
