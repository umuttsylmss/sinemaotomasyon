using System.Data.SqlClient;

namespace SinemaOtomasyon
{
    public partial class FrmFlimDetay : Form
    {
        public FrmFlimDetay()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=Umut;Initial Catalog=sinema;Integrated Security=True");

        private void FrmFlimDetay_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "SELECT TOP 1 * FROM Tbl_Filmler"; // Sorguyu değiştirerek filtrelemeyi kaldırdık
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                pBResim.ImageLocation = oku["AFIS"].ToString();
                lblFilmAdi.Text = oku["ADI"].ToString();
                lblFilmBicimi.Text = oku["BICIMI"].ToString();
                lblOzellik.Text = oku["OZELLIKLERI"].ToString();
                lblFilmTuru.Text = oku["TURU"].ToString();
                lblOyuncu.Text = oku["OYUNCU"].ToString();
                lblYonetmen.Text = oku["YONETMEN"].ToString();
                lblVizyonDetay.Text = oku["TARIH"].ToString();
                lblFilmDurumu.Text = oku["DURUM"].ToString();
                lblFilmDetay.Text = oku["DETAY"].ToString();
                lblFilmPuani.Text = oku["PUAN"].ToString();
            }
            else
            {
                MessageBox.Show("Kayıt bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
            if(lblFilmDurumu.Text=="1")
            {
                lblFilmDurumu.Text = "FİLM VİZYONDA";
            }
            else
            {
                lblFilmDurumu.Text = "FİLM VİZYONA GİRECEK";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
