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
    public partial class FrmYonetmenListesi : Form
    {
        public FrmYonetmenListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=Umut;Initial Catalog=sinema;Integrated Security=True");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListePaneli_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmYonetmenListesi_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from Tbl_Yonetmenler ORDER BY ADSOYAD ASC ";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                OyuncuListesi arac = new OyuncuListesi();
                arac.lblId.Text = oku["ID"].ToString();
                arac.pbResimDetay.ImageLocation = oku["RESİM"].ToString();
                arac.lblAdSoyad.Text = oku["ADSOYAD"].ToString();
                ListePaneli.Controls.Add(arac);

            }
            baglanti.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListePaneli_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtAramaYap_TextChanged(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand ara = new SqlCommand("select * from Tbl_Oyuncular Where ADSOYAD LIKE'%"+txtAramaYap.Text+"%'",baglanti);
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read()) 
            {
                OyuncuListesi arac = new OyuncuListesi();
                arac.lblId.Text = oku["ID"].ToString();
                arac.pbResimDetay.ImageLocation = oku["RESİM"].ToString();
                arac.lblAdSoyad.Text = oku["ADSOYAD"].ToString();
                ListePaneli.Controls.Add(arac);

            }
            baglanti.Close();
        }
    }
}
