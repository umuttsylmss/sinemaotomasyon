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
    public partial class FrmOyuncuListesi : Form
    {
        public FrmOyuncuListesi()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=Umut;Initial Catalog=sinema;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListePaneli_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmOyuncuListesi_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from Tbl_Oyuncular ORDER BY ADSOYAD ASC ";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                YonetmenListesi arac = new YonetmenListesi();
                arac.lblId.Text = oku["ID"].ToString();
                arac.pbResimDetay.ImageLocation = oku["RESİM"].ToString();
                arac.lblAdSoyad.Text = oku["ADSOYAD"].ToString();
                ListePaneli.Controls.Add(arac);

            }
            baglanti.Close();
        }

        private void txtAramaYap_TextChanged(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand ara = new SqlCommand("select * from Tbl_Yonetmenler Where ADSOYAD LIKE'%" + txtAramaYap.Text + "%'", baglanti);
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {
                YonetmenListesi arac = new YonetmenListesi();
                arac.lblId.Text = oku["ID"].ToString();
                arac.pbResimDetay.ImageLocation = oku["RESİM"].ToString();
                arac.lblAdSoyad.Text = oku["ADSOYAD"].ToString();
                ListePaneli.Controls.Add(arac);

            }
            baglanti.Close();
        }
    }
}
