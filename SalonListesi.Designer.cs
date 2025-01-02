namespace SinemaOtomasyon
{
    partial class SalonListesi
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalonListesi));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblSalonAdi = new Label();
            lblKoltukSayisi = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(84, 110, 122);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 93);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblSalonAdi
            // 
            lblSalonAdi.AutoSize = true;
            lblSalonAdi.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSalonAdi.ForeColor = Color.FromArgb(84, 110, 122);
            lblSalonAdi.Location = new Point(143, 12);
            lblSalonAdi.Name = "lblSalonAdi";
            lblSalonAdi.Size = new Size(73, 31);
            lblSalonAdi.TabIndex = 1;
            lblSalonAdi.Text = "label1";
            // 
            // lblKoltukSayisi
            // 
            lblKoltukSayisi.AutoSize = true;
            lblKoltukSayisi.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold);
            lblKoltukSayisi.ForeColor = Color.Red;
            lblKoltukSayisi.Location = new Point(244, 56);
            lblKoltukSayisi.Name = "lblKoltukSayisi";
            lblKoltukSayisi.Size = new Size(55, 23);
            lblKoltukSayisi.TabIndex = 2;
            lblKoltukSayisi.Text = "label2";
            lblKoltukSayisi.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(133, 56);
            label1.Name = "label1";
            label1.Size = new Size(115, 23);
            label1.TabIndex = 3;
            label1.Text = "Koltuk Sayısı :";
            // 
            // SalonListesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(label1);
            Controls.Add(lblKoltukSayisi);
            Controls.Add(lblSalonAdi);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "SalonListesi";
            Size = new Size(308, 93);
            MouseLeave += ayril;
            MouseMove += gel;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        public Label lblSalonAdi;
        public Label lblKoltukSayisi;
        public Label label1;
    }
}
