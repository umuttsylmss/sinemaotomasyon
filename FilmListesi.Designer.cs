namespace SinemaOtomasyon
{
    partial class FilmListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmListesi));
            groupBox17 = new GroupBox();
            lblFlimAdi = new Label();
            btnFilm = new Button();
            pBResim = new PictureBox();
            groupBox18 = new GroupBox();
            groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBResim).BeginInit();
            SuspendLayout();
            // 
            // groupBox17
            // 
            groupBox17.Controls.Add(lblFlimAdi);
            groupBox17.Controls.Add(btnFilm);
            groupBox17.Controls.Add(pBResim);
            groupBox17.Controls.Add(groupBox18);
            groupBox17.Font = new Font("Segoe UI Semibold", 11.8F, FontStyle.Bold);
            groupBox17.ForeColor = Color.FromArgb(84, 110, 122);
            groupBox17.Location = new Point(3, 3);
            groupBox17.Name = "groupBox17";
            groupBox17.Padding = new Padding(10, 3, 3, 3);
            groupBox17.Size = new Size(209, 301);
            groupBox17.TabIndex = 13;
            groupBox17.TabStop = false;
            // 
            // lblFlimAdi
            // 
            lblFlimAdi.AutoSize = true;
            lblFlimAdi.Location = new Point(0, 1);
            lblFlimAdi.Name = "lblFlimAdi";
            lblFlimAdi.Size = new Size(63, 28);
            lblFlimAdi.TabIndex = 22;
            lblFlimAdi.Text = "label1";
            lblFlimAdi.Click += lblFlimAdi_Click;
            // 
            // btnFilm
            // 
            btnFilm.BackColor = Color.FromArgb(229, 57, 53);
            btnFilm.FlatAppearance.BorderSize = 0;
            btnFilm.FlatStyle = FlatStyle.Flat;
            btnFilm.ForeColor = Color.White;
            btnFilm.Location = new Point(29, 244);
            btnFilm.Name = "btnFilm";
            btnFilm.Size = new Size(151, 44);
            btnFilm.TabIndex = 20;
            btnFilm.Text = "DETAY";
            btnFilm.UseVisualStyleBackColor = false;
            btnFilm.Click += btnFilm_Click;
            // 
            // pBResim
            // 
            pBResim.Image = (Image)resources.GetObject("pBResim.Image");
            pBResim.Location = new Point(11, 32);
            pBResim.Name = "pBResim";
            pBResim.Size = new Size(190, 206);
            pBResim.SizeMode = PictureBoxSizeMode.CenterImage;
            pBResim.TabIndex = 21;
            pBResim.TabStop = false;
            // 
            // groupBox18
            // 
            groupBox18.Location = new Point(136, 53);
            groupBox18.Name = "groupBox18";
            groupBox18.Size = new Size(8, 8);
            groupBox18.TabIndex = 0;
            groupBox18.TabStop = false;
            groupBox18.Text = "groupBox18";
            // 
            // FilmListesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox17);
            Name = "FilmListesi";
            Size = new Size(216, 304);
            groupBox17.ResumeLayout(false);
            groupBox17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBResim).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox18;
        public GroupBox groupBox17;
        public Button btnFilm;
        public PictureBox pBResim;
        public Label lblFlimAdi;
    }
}
