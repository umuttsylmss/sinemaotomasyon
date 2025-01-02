namespace SinemaOtomasyon
{
    partial class OyuncuListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OyuncuListesi));
            button1 = new Button();
            lblCinsiyet = new Label();
            pbCinsiyet = new PictureBox();
            btnResimYukle = new Button();
            pbResimDetay = new PictureBox();
            lblId = new Label();
            lblAdSoyad = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbCinsiyet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbResimDetay).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(472, 18);
            button1.Name = "button1";
            button1.Size = new Size(63, 43);
            button1.TabIndex = 15;
            button1.Text = "SİL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.AllowDrop = true;
            lblCinsiyet.AutoSize = true;
            lblCinsiyet.BackColor = SystemColors.Window;
            lblCinsiyet.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCinsiyet.ForeColor = Color.FromArgb(84, 110, 122);
            lblCinsiyet.Location = new Point(191, 48);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(73, 31);
            lblCinsiyet.TabIndex = 14;
            lblCinsiyet.Text = "label1";
            lblCinsiyet.Visible = false;
            // 
            // pbCinsiyet
            // 
            pbCinsiyet.Image = (Image)resources.GetObject("pbCinsiyet.Image");
            pbCinsiyet.Location = new Point(112, 3);
            pbCinsiyet.Name = "pbCinsiyet";
            pbCinsiyet.Size = new Size(36, 31);
            pbCinsiyet.SizeMode = PictureBoxSizeMode.Zoom;
            pbCinsiyet.TabIndex = 13;
            pbCinsiyet.TabStop = false;
            pbCinsiyet.Click += pbCinsiyet_Click;
            // 
            // btnResimYukle
            // 
            btnResimYukle.BackColor = Color.FromArgb(229, 57, 53);
            btnResimYukle.FlatAppearance.BorderSize = 0;
            btnResimYukle.FlatStyle = FlatStyle.Flat;
            btnResimYukle.ForeColor = Color.White;
            btnResimYukle.Location = new Point(362, 18);
            btnResimYukle.Name = "btnResimYukle";
            btnResimYukle.Size = new Size(104, 43);
            btnResimYukle.TabIndex = 12;
            btnResimYukle.Text = "DETAY";
            btnResimYukle.UseVisualStyleBackColor = false;
            btnResimYukle.Click += btnResimYukle_Click;
            // 
            // pbResimDetay
            // 
            pbResimDetay.Image = (Image)resources.GetObject("pbResimDetay.Image");
            pbResimDetay.Location = new Point(32, 0);
            pbResimDetay.Name = "pbResimDetay";
            pbResimDetay.Size = new Size(74, 79);
            pbResimDetay.SizeMode = PictureBoxSizeMode.Zoom;
            pbResimDetay.TabIndex = 11;
            pbResimDetay.TabStop = false;
            pbResimDetay.Click += pbResimDetay_Click;
            // 
            // lblId
            // 
            lblId.AllowDrop = true;
            lblId.AutoSize = true;
            lblId.BackColor = SystemColors.Window;
            lblId.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblId.ForeColor = Color.FromArgb(84, 110, 122);
            lblId.Location = new Point(112, 48);
            lblId.Name = "lblId";
            lblId.Size = new Size(73, 31);
            lblId.TabIndex = 10;
            lblId.Text = "label1";
            lblId.Visible = false;
            lblId.Click += lblId_Click;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AllowDrop = true;
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.BackColor = SystemColors.Window;
            lblAdSoyad.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAdSoyad.ForeColor = Color.FromArgb(84, 110, 122);
            lblAdSoyad.Location = new Point(144, 3);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(73, 31);
            lblAdSoyad.TabIndex = 9;
            lblAdSoyad.Text = "label1";
            lblAdSoyad.Click += lblAdSoyad_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(84, 110, 122);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 110);
            panel1.TabIndex = 8;
            // 
            // OyuncuListesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(button1);
            Controls.Add(lblCinsiyet);
            Controls.Add(pbCinsiyet);
            Controls.Add(btnResimYukle);
            Controls.Add(pbResimDetay);
            Controls.Add(lblId);
            Controls.Add(lblAdSoyad);
            Controls.Add(panel1);
            Name = "OyuncuListesi";
            Size = new Size(550, 110);
            Load += OyuncuListesi_Load;
            ((System.ComponentModel.ISupportInitialize)pbCinsiyet).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbResimDetay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        public Label lblCinsiyet;
        private PictureBox pbCinsiyet;
        private Button btnResimYukle;
        public PictureBox pbResimDetay;
        public Label lblId;
        public Label lblAdSoyad;
        private Panel panel1;
    }
}
