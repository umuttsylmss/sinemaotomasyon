using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyon
{
    public partial class FilmListesi : UserControl
    {
        public FilmListesi()
        {
            InitializeComponent();
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            FrmFlimDetay frm = new FrmFlimDetay();

            frm.ShowDialog();

        }

        private void lblFlimAdi_Click(object sender, EventArgs e)
        {

        }
    }
}
