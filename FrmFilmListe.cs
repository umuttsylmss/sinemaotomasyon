﻿using System;
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
    public partial class FrmFilmListe : Form
    {
        public FrmFilmListe()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=Umut;Initial Catalog=sinema;Integrated Security=True");
        private void FrmFilmListe_Load(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            string sorgu = "select * from Tbl_Filmler ORDER BY ADI ASC";
            baglanti.Open();

            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                //verileri getir
                FilmListesi arac = new FilmListesi();
                arac.lblFlimAdi.Text = oku["ADI"].ToString();
                arac.pBResim.ImageLocation = oku["AFIS"].ToString();
                arac.lblFlimAdi.Text = oku["ID"].ToString();
                ListePaneli.Controls.Add(arac);

            }

            baglanti.Close();
        }

        private void ListePaneli_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAramaYap_TextChanged(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand ara = new SqlCommand("select * from Tbl_Filmler Where ADI LIKE'%" + txtAramaYap.Text + "%'collate Turkish_CI_AS ORDER BY ADI ASC", baglanti);
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {
                FilmListesi arac = new FilmListesi();
                arac.lblFlimAdi.Text = oku["ADI"].ToString();
                arac.pBResim.ImageLocation = oku["AFIS"].ToString();
                arac.lblFlimAdi.Text = oku["ID"].ToString();
                ListePaneli.Controls.Add(arac);

            }
            baglanti.Close();
        }
    }
}
