namespace SinemaOtomasyon
{
    partial class FrmYonetmen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYonetmen));
            panel1 = new Panel();
            button2 = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            rBKadin = new RadioButton();
            rBErkek = new RadioButton();
            nYil = new NumericUpDown();
            nAy = new NumericUpDown();
            nGun = new NumericUpDown();
            label4 = new Label();
            txtSoyad = new TextBox();
            label3 = new Label();
            txtAd = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnResimYukle = new Button();
            pBResim = new PictureBox();
            label6 = new Label();
            groupBox3 = new GroupBox();
            lblKarakter = new Label();
            label7 = new Label();
            txtBiyografi = new TextBox();
            label10 = new Label();
            btnKaydet = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nYil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nAy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nGun).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBResim).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(84, 110, 122);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(724, 65);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(229, 57, 53);
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(679, 0);
            button2.Name = "button2";
            button2.Size = new Size(45, 65);
            button2.TabIndex = 2;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 18);
            label1.Name = "label1";
            label1.Size = new Size(245, 31);
            label1.TabIndex = 1;
            label1.Text = "Yönetmen Kayıt Ekranı";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(rBKadin);
            groupBox1.Controls.Add(rBErkek);
            groupBox1.Controls.Add(nYil);
            groupBox1.Controls.Add(nAy);
            groupBox1.Controls.Add(nGun);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.FromArgb(84, 110, 122);
            groupBox1.Location = new Point(12, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 399);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 275);
            label5.Name = "label5";
            label5.Size = new Size(95, 28);
            label5.TabIndex = 21;
            label5.Text = "CİNSİYET";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(276, 314);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(135, 314);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // rBKadin
            // 
            rBKadin.AutoSize = true;
            rBKadin.FlatStyle = FlatStyle.Flat;
            rBKadin.Location = new Point(178, 306);
            rBKadin.Name = "rBKadin";
            rBKadin.Size = new Size(92, 32);
            rBKadin.TabIndex = 17;
            rBKadin.Text = "KADIN";
            rBKadin.UseVisualStyleBackColor = true;
            rBKadin.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rBErkek
            // 
            rBErkek.AutoSize = true;
            rBErkek.Checked = true;
            rBErkek.FlatStyle = FlatStyle.Flat;
            rBErkek.Location = new Point(50, 306);
            rBErkek.Name = "rBErkek";
            rBErkek.Size = new Size(88, 32);
            rBErkek.TabIndex = 16;
            rBErkek.TabStop = true;
            rBErkek.Text = "ERKEK";
            rBErkek.UseVisualStyleBackColor = true;
            rBErkek.CheckedChanged += rBErkek_CheckedChanged;
            // 
            // nYil
            // 
            nYil.ForeColor = Color.FromArgb(84, 110, 122);
            nYil.Location = new Point(196, 207);
            nYil.Maximum = new decimal(new int[] { 2300, 0, 0, 0 });
            nYil.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            nYil.Name = "nYil";
            nYil.Size = new Size(68, 34);
            nYil.TabIndex = 13;
            nYil.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            nYil.ValueChanged += nYil_ValueChanged;
            // 
            // nAy
            // 
            nAy.ForeColor = Color.FromArgb(84, 110, 122);
            nAy.Location = new Point(124, 207);
            nAy.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nAy.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nAy.Name = "nAy";
            nAy.Size = new Size(68, 34);
            nAy.TabIndex = 12;
            nAy.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nAy.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // nGun
            // 
            nGun.ForeColor = Color.FromArgb(84, 110, 122);
            nGun.Location = new Point(50, 207);
            nGun.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            nGun.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nGun.Name = "nGun";
            nGun.Size = new Size(68, 34);
            nGun.TabIndex = 11;
            nGun.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nGun.ValueChanged += nGun_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 176);
            label4.Name = "label4";
            label4.Size = new Size(155, 28);
            label4.TabIndex = 9;
            label4.Text = "DOĞUM TARİHİ";
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtSoyad.ForeColor = Color.FromArgb(84, 110, 122);
            txtSoyad.Location = new Point(50, 143);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(211, 30);
            txtSoyad.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 101);
            label3.Name = "label3";
            label3.Size = new Size(75, 28);
            label3.TabIndex = 7;
            label3.Text = "SOYAD";
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtAd.ForeColor = Color.FromArgb(84, 110, 122);
            txtAd.Location = new Point(50, 66);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(211, 30);
            txtAd.TabIndex = 6;
            txtAd.TextChanged += txtAd_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 19);
            label2.Name = "label2";
            label2.Size = new Size(45, 28);
            label2.TabIndex = 5;
            label2.Text = "AD ";
            label2.Click += label2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnResimYukle);
            groupBox2.Controls.Add(pBResim);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.FromArgb(84, 110, 122);
            groupBox2.Location = new Point(368, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(340, 265);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btnResimYukle
            // 
            btnResimYukle.BackColor = Color.FromArgb(229, 57, 53);
            btnResimYukle.FlatAppearance.BorderSize = 0;
            btnResimYukle.FlatStyle = FlatStyle.Flat;
            btnResimYukle.ForeColor = Color.White;
            btnResimYukle.Location = new Point(89, 215);
            btnResimYukle.Name = "btnResimYukle";
            btnResimYukle.Size = new Size(170, 44);
            btnResimYukle.TabIndex = 3;
            btnResimYukle.Text = "YÜKLE";
            btnResimYukle.UseVisualStyleBackColor = false;
            btnResimYukle.Click += btnResimYukle_Click;
            // 
            // pBResim
            // 
            pBResim.Image = (Image)resources.GetObject("pBResim.Image");
            pBResim.Location = new Point(56, 63);
            pBResim.Name = "pBResim";
            pBResim.Size = new Size(218, 146);
            pBResim.SizeMode = PictureBoxSizeMode.CenterImage;
            pBResim.TabIndex = 19;
            pBResim.TabStop = false;
            pBResim.Click += pBResim_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 19);
            label6.Name = "label6";
            label6.Size = new Size(69, 28);
            label6.TabIndex = 18;
            label6.Text = "RESİM";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblKarakter);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtBiyografi);
            groupBox3.Controls.Add(label10);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.ForeColor = Color.FromArgb(84, 110, 122);
            groupBox3.Location = new Point(12, 476);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(561, 226);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            // 
            // lblKarakter
            // 
            lblKarakter.Location = new Point(510, 184);
            lblKarakter.Name = "lblKarakter";
            lblKarakter.RightToLeft = RightToLeft.Yes;
            lblKarakter.Size = new Size(45, 28);
            lblKarakter.TabIndex = 8;
            lblKarakter.Text = "300";
            lblKarakter.Click += lblKarakter_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(84, 110, 122);
            label7.Location = new Point(405, 4);
            label7.Name = "label7";
            label7.Size = new Size(150, 23);
            label7.TabIndex = 7;
            label7.Text = "(max)300 karakter";
            label7.Click += label7_Click;
            // 
            // txtBiyografi
            // 
            txtBiyografi.Dock = DockStyle.Fill;
            txtBiyografi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtBiyografi.ForeColor = Color.FromArgb(84, 110, 122);
            txtBiyografi.Location = new Point(3, 30);
            txtBiyografi.MaxLength = 300;
            txtBiyografi.Multiline = true;
            txtBiyografi.Name = "txtBiyografi";
            txtBiyografi.Size = new Size(555, 193);
            txtBiyografi.TabIndex = 6;
            txtBiyografi.TextChanged += txtBiyografi_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(0, 4);
            label10.Name = "label10";
            label10.Size = new Size(112, 28);
            label10.TabIndex = 5;
            label10.Text = "BİYOGRAFİ";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(229, 57, 53);
            btnKaydet.Dock = DockStyle.Bottom;
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(0, 711);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(724, 44);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "KAYIT TAMAMLA";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // FrmYonetmen
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(724, 755);
            Controls.Add(btnKaydet);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(500, 110);
            Margin = new Padding(5);
            Name = "FrmYonetmen";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmYonetmen";
            Load += FrmYonetmen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nYil).EndInit();
            ((System.ComponentModel.ISupportInitialize)nAy).EndInit();
            ((System.ComponentModel.ISupportInitialize)nGun).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBResim).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private NumericUpDown nGun;
        private Label label4;
        private TextBox txtSoyad;
        private Label label3;
        private TextBox txtAd;
        private NumericUpDown nYil;
        private NumericUpDown nAy;
        private RadioButton rBErkek;
        private RadioButton rBKadin;
        private PictureBox pictureBox1;
        private Label label6;
        private Button btnResimYukle;
        private PictureBox pictureBox2;
        private PictureBox pBResim;
        private GroupBox groupBox3;
        private TextBox txtBiyografi;
        private Label label10;
        private Label label7;
        private Label lblKarakter;
        private Button btnKaydet;
        private Label label5;
    }
}