using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//sql veritabaný kütüphanesi
namespace SinemaOtomasyon
{
    public partial class frmAcilis : Form
    {
        public frmAcilis()
        {
            
            InitializeComponent();
        }
        //SqlConnection baglanti = new SqlConnection("Data Source=Veritabanýmýzýn_Yolu;Initial Catalog= Veritabanýmýzýn_Adý;Integrated Security=True");
        //connectionstring dediðimiz veritabanýnýn yolunu projeye eklememiz gerekiyor
        SqlConnection baglanti = new SqlConnection(@"Data Source=Umut;Initial Catalog=sinema;Integrated Security=True");



        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            //Kullanýcý Giriþ Ýþlemleri
            //Sorgulamak için "Select" 
            //Eklemek için "insert"
            //Güncellemek için "uptade"
            //Silmek için "Delete"
            // þart yada koþul için "WHERE" 
            baglanti.Open();
            
           SqlCommand sorgula = new SqlCommand("select * from Tbl_Kullanicilar WHERE KADI=@username AND KSÝFRE=@password ",baglanti);
            sorgula.Parameters.AddWithValue("@username",txtKullaniciAdi.Text);
            sorgula.Parameters.AddWithValue("@password", txtSifre.Text);
            SqlDataReader oku = sorgula.ExecuteReader();
            if (oku.Read()) // okuma iþlemi baþarýlý ise  girmiþ olduðumuz veriler veri tabanýnda mevcut ise veya bilgiler doðru ise yapýlacak iþlem
            {

                //MessageBox.Show("Kullanýcý Verileri Eþleþti (GÝRÝÞ BAÞARILI)");
                frmAnaForm frm = new frmAnaForm();
                frm.kisiAdiSoyadi = oku["ADSOYAD"].ToString();
                frm.Show();
                this.Hide();
            }
            else 
            {

                MessageBox.Show("Kullanýcý Verileri Bulunamadý!!!!");
            
            }
            baglanti.Close();

            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            txtKullaniciAdi.Focus();//ÝMLECÝ KONUMLANDIR


            ////VERÝTABANINA BAÐLANMA SORGULA
            //baglanti.Open();
            //if (baglanti.State == ConnectionState.Open) 
            //{

            //    MessageBox.Show("Baþarýlý");
            
            //}
            //baglanti.Close();
        }
    }
}
