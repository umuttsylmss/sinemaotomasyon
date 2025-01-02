using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//sql veritaban� k�t�phanesi
namespace SinemaOtomasyon
{
    public partial class frmAcilis : Form
    {
        public frmAcilis()
        {
            
            InitializeComponent();
        }
        //SqlConnection baglanti = new SqlConnection("Data Source=Veritaban�m�z�n_Yolu;Initial Catalog= Veritaban�m�z�n_Ad�;Integrated Security=True");
        //connectionstring dedi�imiz veritaban�n�n yolunu projeye eklememiz gerekiyor
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
            //Kullan�c� Giri� ��lemleri
            //Sorgulamak i�in "Select" 
            //Eklemek i�in "insert"
            //G�ncellemek i�in "uptade"
            //Silmek i�in "Delete"
            // �art yada ko�ul i�in "WHERE" 
            baglanti.Open();
            
           SqlCommand sorgula = new SqlCommand("select * from Tbl_Kullanicilar WHERE KADI=@username AND KS�FRE=@password ",baglanti);
            sorgula.Parameters.AddWithValue("@username",txtKullaniciAdi.Text);
            sorgula.Parameters.AddWithValue("@password", txtSifre.Text);
            SqlDataReader oku = sorgula.ExecuteReader();
            if (oku.Read()) // okuma i�lemi ba�ar�l� ise  girmi� oldu�umuz veriler veri taban�nda mevcut ise veya bilgiler do�ru ise yap�lacak i�lem
            {

                //MessageBox.Show("Kullan�c� Verileri E�le�ti (G�R�� BA�ARILI)");
                frmAnaForm frm = new frmAnaForm();
                frm.kisiAdiSoyadi = oku["ADSOYAD"].ToString();
                frm.Show();
                this.Hide();
            }
            else 
            {

                MessageBox.Show("Kullan�c� Verileri Bulunamad�!!!!");
            
            }
            baglanti.Close();

            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            txtKullaniciAdi.Focus();//�MLEC� KONUMLANDIR


            ////VER�TABANINA BA�LANMA SORGULA
            //baglanti.Open();
            //if (baglanti.State == ConnectionState.Open) 
            //{

            //    MessageBox.Show("Ba�ar�l�");
            
            //}
            //baglanti.Close();
        }
    }
}
