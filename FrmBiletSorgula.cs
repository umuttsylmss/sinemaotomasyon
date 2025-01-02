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
    public partial class FrmBiletSorgula : Form
    {
        public FrmBiletSorgula()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=Umut;Initial Catalog=sinema;Integrated Security=True");
        private void btnSorgula_Click(object sender, EventArgs e)
        {
          if (txtBiletNo.Text!="")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Tbl_Biletler WHERE BKOD=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", txtBiletNo.Text.ToString());
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    FrmBiletDetay frm = new FrmBiletDetay();
                    frm.biletNo = txtBiletNo.Text;
                    txtBiletNo.Text = "";
                    frm.ShowDialog();
                }

                else
                {
                    MessageBox.Show("KAYITLI BİLET BULUNAMADI!");
                }
                baglanti.Close();
            }
          else
            {
                MessageBox.Show("LÜTFEN BİLET NUMARASI GİRİNİZ!");
            }


            
        }
    }
}
