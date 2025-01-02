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
    public partial class oListePaneli : UserControl
    {
        public oListePaneli()
        {
            InitializeComponent();
        }

        private void oListePaneli_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from Tbl_Secilenler Where KISI=@kisi AND TUR=@tur ", baglanti);
            komut.Parameters.AddWithValue("@kisi", lblAdi.Text);
            komut.Parameters.AddWithValue("@tur", "OYUNCU");
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {

                lblAdi.ForeColor = Color.FromArgb(249, 164, 26);
                pictureBox1.ImageLocation = @"C:\Users\umuts\OneDrive\Desktop\İconlar\PLUS.png";
            }

            else
            {
                lblAdi.ForeColor = Color.FromArgb(17, 28, 43);
                pictureBox1.ImageLocation = @"C:\Users\umuts\OneDrive\Desktop\İconlar\PLUS.png";

            }

            baglanti.Close();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=Umut;Initial Catalog=sinema;Integrated Security=True");
        private void lblAdi_Click(object sender, EventArgs e)
        {
            if (lblAdi.ForeColor == Color.FromArgb(17, 28, 43))
            {
                lblAdi.ForeColor = Color.FromArgb(249, 164, 26);
                pictureBox1.ImageLocation = @"C:\Users\umuts\OneDrive\Desktop\İconlar\PLUS.png";
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Tbl_Secilenler (KISI,TUR) values (@kisi,@tur)", baglanti);
                komut.Parameters.AddWithValue("@kisi", lblAdi.Text);
                komut.Parameters.AddWithValue("@tur", "OYUNCU");
                komut.ExecuteNonQuery();
                baglanti.Close();

            }
            else
            {
                lblAdi.ForeColor = Color.FromArgb(17, 28, 43);
                pictureBox1.ImageLocation = @"C:\Users\umuts\OneDrive\Desktop\İconlar\PLUS.png";
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Tbl_Secilenler where KISI=@kisi AND TUR=@tur", baglanti);
                komut.Parameters.AddWithValue("@kisi", lblAdi.Text);
                komut.Parameters.AddWithValue("@tur", "OYUNCU");
                komut.ExecuteNonQuery();
                baglanti.Close();

            }


        }
    }
}
