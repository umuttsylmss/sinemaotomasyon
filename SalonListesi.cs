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
    public partial class SalonListesi : UserControl
    {
        public SalonListesi()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gel(object sender, MouseEventArgs e)
        {
            lblSalonAdi.ForeColor = Color.Red;
            this.BackColor = Color.DarkSlateGray;
        }

        private void ayril(object sender, EventArgs e)
        {
            lblSalonAdi.ForeColor= Color.FromArgb(84,110,122);
            this.BackColor = Color.White;
        }
    }
}
