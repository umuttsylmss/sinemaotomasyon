namespace SinemaOtomasyon
{
    partial class YonetmenListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YonetmenListesi));
            panel1 = new Panel();
            lblAdSoyad = new Label();
            lblId = new Label();
            pbResimDetay = new PictureBox();
            btnResimYukle = new Button();
            pbCinsiyet = new PictureBox();
            lblCinsiyet = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbResimDetay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCinsiyet).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(84, 110, 122);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 110);
            panel1.TabIndex = 0;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AllowDrop = true;
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.BackColor = SystemColors.Window;
            lblAdSoyad.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAdSoyad.ForeColor = Color.FromArgb(84, 110, 122);
            lblAdSoyad.Location = new Point(128, 3);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(73, 31);
            lblAdSoyad.TabIndex = 1;
            lblAdSoyad.Text = "label1";
            lblAdSoyad.Click += lblAdSoyad_Click;
            // 
            // lblId
            // 
            lblId.AllowDrop = true;
            lblId.AutoSize = true;
            lblId.BackColor = SystemColors.Window;
            lblId.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblId.ForeColor = Color.FromArgb(84, 110, 122);
            lblId.Location = new Point(96, 48);
            lblId.Name = "lblId";
            lblId.Size = new Size(73, 31);
            lblId.TabIndex = 2;
            lblId.Text = "label1";
            lblId.Visible = false;
            lblId.Click += lblId_Click;
            // 
            // pbResimDetay
            // 
            pbResimDetay.Image = (Image)resources.GetObject("pbResimDetay.Image");
            pbResimDetay.Location = new Point(16, 0);
            pbResimDetay.Name = "pbResimDetay";
            pbResimDetay.Size = new Size(74, 79);
            pbResimDetay.SizeMode = PictureBoxSizeMode.Zoom;
            pbResimDetay.TabIndex = 3;
            pbResimDetay.TabStop = false;
            pbResimDetay.Click += pbResimDetay_Click;
            // 
            // btnResimYukle
            // 
            btnResimYukle.BackColor = Color.FromArgb(229, 57, 53);
            btnResimYukle.FlatAppearance.BorderSize = 0;
            btnResimYukle.FlatStyle = FlatStyle.Flat;
            btnResimYukle.ForeColor = Color.White;
            btnResimYukle.Location = new Point(346, 18);
            btnResimYukle.Name = "btnResimYukle";
            btnResimYukle.Size = new Size(104, 43);
            btnResimYukle.TabIndex = 4;
            btnResimYukle.Text = "DETAY";
            btnResimYukle.UseVisualStyleBackColor = false;
            btnResimYukle.Click += btnResimYukle_Click;
            // 
            // pbCinsiyet
            // 
            pbCinsiyet.Image = (Image)resources.GetObject("pbCinsiyet.Image");
            pbCinsiyet.Location = new Point(96, 3);
            pbCinsiyet.Name = "pbCinsiyet";
            pbCinsiyet.Size = new Size(36, 31);
            pbCinsiyet.SizeMode = PictureBoxSizeMode.Zoom;
            pbCinsiyet.TabIndex = 5;
            pbCinsiyet.TabStop = false;
            pbCinsiyet.Click += pbCinsiyet_Click;
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.AllowDrop = true;
            lblCinsiyet.AutoSize = true;
            lblCinsiyet.BackColor = SystemColors.Window;
            lblCinsiyet.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCinsiyet.ForeColor = Color.FromArgb(84, 110, 122);
            lblCinsiyet.Location = new Point(175, 48);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(73, 31);
            lblCinsiyet.TabIndex = 6;
            lblCinsiyet.Text = "label1";
            lblCinsiyet.Visible = false;
            lblCinsiyet.Click += lblCinsiyet_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(456, 18);
            button1.Name = "button1";
            button1.Size = new Size(63, 43);
            button1.TabIndex = 7;
            button1.Text = "SİL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // YonetmenListesi
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
            Name = "YonetmenListesi";
            Size = new Size(550, 110);
            Load += YonetmenListesi_Load;
            ((System.ComponentModel.ISupportInitialize)pbResimDetay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCinsiyet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        public Label lblAdSoyad;
        public Label lblId;
        public PictureBox pbResimDetay;
        private Button btnResimYukle;
        private PictureBox pbCinsiyet;
        public Label lblCinsiyet;
        private Button button1;
    }
}
