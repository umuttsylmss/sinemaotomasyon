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
    public partial class FrmSalonKayit : Form
    {
        public FrmSalonKayit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=Umut;Initial Catalog=sinema;Integrated Security=True");
        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            if (txtSalonAdi.Text != "" && cbKoltukSayisi.Text != "")
            {
                baglanti.Open();
                SqlCommand kaydet = new SqlCommand("insert into Tbl_Salonlar (SALONADI,KOLTUKSAYISI) Values(@p1,@p2)", baglanti);
                kaydet.Parameters.AddWithValue("@p1", txtSalonAdi.Text.ToUpper());
                kaydet.Parameters.AddWithValue("@p2", cbKoltukSayisi.Text);
                kaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("SALON KAYIT EDİLDİ");
                txtSalonAdi.Text = "";
                cbKoltukSayisi.Text = "";
                txtSalonAdi.Focus();
                listegetir();


            }

            else
            {
                MessageBox.Show("Lütfen Bir Değer Giriniz!");

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmSalonKayit_Load(object sender, EventArgs e)
        {
            listegetir();
            kOlustur();
            
        }
        void kOlustur()
        { 
        for (int i = 1; i <=200;i++)
            {
                cbKoltukSayisi.Items.Add(i);

            }
        
        
        }

        void listegetir()
        {

            panelSalon.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Salonlar ORDER BY SALONADI ASC", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                SalonListesi arac = new SalonListesi();
                arac.lblSalonAdi.Text = oku["SALONADI"].ToString();
                arac.lblKoltukSayisi.Text = oku["KOLTUKSAYISI"].ToString();
                panelSalon.Controls.Add(arac);

            }
            baglanti.Close();


        }
    }
}
