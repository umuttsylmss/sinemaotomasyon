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
    public partial class OyuncuListesi : UserControl
    {
        public OyuncuListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=Umut;Initial Catalog=sinema;Integrated Security=True");
        private void pbResimDetay_Click(object sender, EventArgs e)
        {

        }

        private void lblAdSoyad_Click(object sender, EventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void pbCinsiyet_Click(object sender, EventArgs e)
        {

        }

        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from Tbl_Oyuncular WHERE ID=@p1";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@p1", lblId.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {

                MessageBox.Show("BİYOGRAFİ:  " + oku["BIYOGRAFI"].ToString(), oku["ADSOYAD"].ToString());

            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from Tbl_Oyuncular Where ID=@p1", baglanti);
            sil.Parameters.AddWithValue("@p1", lblId.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();



            MessageBox.Show(lblAdSoyad.Text + "Kişisine Ait Kayıt Silinmiştir.");
            this.Hide();//usercontrol aracımızı gizlemiş oluyoruz
        }

        private void OyuncuListesi_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from Tbl_Oyuncular WHERE ID=@p1";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@p1", lblId.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {

                lblCinsiyet.Text = oku["CINSIYET"].ToString();

            }
            baglanti.Close();
            if (lblCinsiyet.Text == "0")
            {
                pbCinsiyet.ImageLocation = @"C:\\Users\\umuts\\OneDrive\\Desktop\\İconlar\\m.png";

            }

            else
            {

                pbCinsiyet.ImageLocation = @"C:\\Users\\umuts\\OneDrive\\Desktop\\İconlar\\fm.png";

            }
        }
    }
    }
