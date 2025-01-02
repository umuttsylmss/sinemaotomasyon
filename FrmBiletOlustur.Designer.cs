namespace SinemaOtomasyon
{
    partial class FrmBiletOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBiletOlustur));
            panel1 = new Panel();
            button2 = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtBiletNo = new TextBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            txtAdSoyad = new TextBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            txtTelNo = new TextBox();
            groupBox6 = new GroupBox();
            groupBox7 = new GroupBox();
            cbFlimAdi = new ComboBox();
            groupBox8 = new GroupBox();
            groupBox9 = new GroupBox();
            cbTarih = new ComboBox();
            lblYonetmenAra = new Label();
            groupBox10 = new GroupBox();
            groupBox11 = new GroupBox();
            lblSeansSec = new Label();
            panelSeans = new FlowLayoutPanel();
            groupBox12 = new GroupBox();
            groupBox13 = new GroupBox();
            lblKoltukSayisi = new Label();
            cbSalon = new ComboBox();
            groupBox14 = new GroupBox();
            groupBox15 = new GroupBox();
            cbBiletTuru = new ComboBox();
            groupBox16 = new GroupBox();
            groupBox17 = new GroupBox();
            txtKoltuklar = new TextBox();
            groupBox18 = new GroupBox();
            btnOlustur = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            KoltukPaneli = new FlowLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblGelenKoltuk = new Label();
            listeGelenKoltuk = new ListBox();
            pictureBox2 = new PictureBox();
            lblBelirlenen = new ListBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnTemizle = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox11.SuspendLayout();
            groupBox13.SuspendLayout();
            groupBox15.SuspendLayout();
            groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            panel1.Size = new Size(939, 65);
            panel1.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(229, 57, 53);
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(894, 0);
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
            label1.Size = new Size(244, 31);
            label1.TabIndex = 1;
            label1.Text = "Bilet Oluşturma Ekranı";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBiletNo);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Segoe UI Semibold", 11.8F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(84, 110, 122);
            groupBox1.Location = new Point(26, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10, 3, 3, 3);
            groupBox1.Size = new Size(250, 57);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "BİLET NO";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtBiletNo
            // 
            txtBiletNo.BorderStyle = BorderStyle.None;
            txtBiletNo.Dock = DockStyle.Bottom;
            txtBiletNo.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold);
            txtBiletNo.ForeColor = Color.FromArgb(84, 110, 122);
            txtBiletNo.HideSelection = false;
            txtBiletNo.Location = new Point(10, 32);
            txtBiletNo.Name = "txtBiletNo";
            txtBiletNo.Size = new Size(237, 22);
            txtBiletNo.TabIndex = 1;
            txtBiletNo.TextChanged += txtBiletNo_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(136, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(8, 8);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtAdSoyad);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Font = new Font("Segoe UI Semibold", 11.8F, FontStyle.Bold);
            groupBox3.ForeColor = Color.FromArgb(84, 110, 122);
            groupBox3.Location = new Point(26, 158);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(10, 3, 3, 3);
            groupBox3.Size = new Size(250, 57);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "AD SOYAD";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.BorderStyle = BorderStyle.None;
            txtAdSoyad.Dock = DockStyle.Bottom;
            txtAdSoyad.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold);
            txtAdSoyad.ForeColor = Color.FromArgb(84, 110, 122);
            txtAdSoyad.HideSelection = false;
            txtAdSoyad.Location = new Point(10, 32);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(237, 22);
            txtAdSoyad.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Location = new Point(136, 53);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(8, 8);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtTelNo);
            groupBox5.Controls.Add(groupBox6);
            groupBox5.Font = new Font("Segoe UI Semibold", 11.8F, FontStyle.Bold);
            groupBox5.ForeColor = Color.FromArgb(84, 110, 122);
            groupBox5.Location = new Point(26, 225);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(10, 3, 3, 3);
            groupBox5.Size = new Size(250, 57);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "TELEFON NUMARASI";
            // 
            // txtTelNo
            // 
            txtTelNo.BorderStyle = BorderStyle.None;
            txtTelNo.Dock = DockStyle.Bottom;
            txtTelNo.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold);
            txtTelNo.ForeColor = Color.FromArgb(84, 110, 122);
            txtTelNo.HideSelection = false;
            txtTelNo.Location = new Point(10, 32);
            txtTelNo.Name = "txtTelNo";
            txtTelNo.Size = new Size(237, 22);
            txtTelNo.TabIndex = 1;
            // 
            // groupBox6
            // 
            groupBox6.Location = new Point(136, 53);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(8, 8);
            groupBox6.TabIndex = 0;
            groupBox6.TabStop = false;
            groupBox6.Text = "groupBox6";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(cbFlimAdi);
            groupBox7.Controls.Add(groupBox8);
            groupBox7.Font = new Font("Segoe UI Semibold", 11.8F, FontStyle.Bold);
            groupBox7.ForeColor = Color.FromArgb(84, 110, 122);
            groupBox7.Location = new Point(26, 292);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(10, 3, 3, 3);
            groupBox7.Size = new Size(250, 57);
            groupBox7.TabIndex = 8;
            groupBox7.TabStop = false;
            groupBox7.Text = "FİLM ADI";
            // 
            // cbFlimAdi
            // 
            cbFlimAdi.Dock = DockStyle.Bottom;
            cbFlimAdi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFlimAdi.FlatStyle = FlatStyle.Flat;
            cbFlimAdi.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold);
            cbFlimAdi.ForeColor = Color.FromArgb(84, 110, 122);
            cbFlimAdi.FormattingEnabled = true;
            cbFlimAdi.Location = new Point(10, 29);
            cbFlimAdi.Name = "cbFlimAdi";
            cbFlimAdi.Size = new Size(237, 25);
            cbFlimAdi.TabIndex = 1;
            cbFlimAdi.SelectedIndexChanged += cbFlimAdi_SelectedIndexChanged;
            // 
            // groupBox8
            // 
            groupBox8.Location = new Point(136, 53);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(8, 8);
            groupBox8.TabIndex = 0;
            groupBox8.TabStop = false;
            groupBox8.Text = "groupBox8";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(cbTarih);
            groupBox9.Controls.Add(lblYonetmenAra);
            groupBox9.Controls.Add(groupBox10);
            groupBox9.Font = new Font("Segoe UI Semibold", 11.8F, FontStyle.Bold);
            groupBox9.ForeColor = Color.FromArgb(84, 110, 122);
            groupBox9.Location = new Point(26, 359);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(10, 3, 3, 3);
            groupBox9.Size = new Size(250, 57);
            groupBox9.TabIndex = 8;
            groupBox9.TabStop = false;
            groupBox9.Text = "TARİH";
            // 
            // cbTarih
            // 
            cbTarih.Dock = DockStyle.Bottom;
            cbTarih.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTarih.FlatStyle = FlatStyle.Flat;
            cbTarih.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold);
            cbTarih.ForeColor = Color.FromArgb(84, 110, 122);
            cbTarih.FormattingEnabled = true;
            cbTarih.Location = new Point(10, 29);
            cbTarih.Name = "cbTarih";
            cbTarih.Size = new Size(237, 25);
            cbTarih.TabIndex = 10;
            cbTarih.SelectedIndexChanged += cbTarih_SelectedIndexChanged;
            // 
            // lblYonetmenAra
            // 
            lblYonetmenAra.AutoSize = true;
            lblYonetmenAra.Font = new Font("Segoe UI Semibold", 6.8F, FontStyle.Bold);
            lblYonetmenAra.ForeColor = Color.Red;
            lblYonetmenAra.Location = new Point(173, 0);
            lblYonetmenAra.Name = "lblYonetmenAra";
            lblYonetmenAra.Size = new Size(77, 15);
            lblYonetmenAra.TabIndex = 9;
            lblYonetmenAra.Text = "GG/AA/YYYY";
            // 
            // groupBox10
            // 
            groupBox10.Location = new Point(136, 53);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(8, 8);
            groupBox10.TabIndex = 0;
            groupBox10.TabStop = false;
            groupBox10.Text = "groupBox10";
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(lblSeansSec);
            groupBox11.Controls.Add(panelSeans);
            groupBox11.Controls.Add(groupBox12);
            groupBox11.Font = new Font("Segoe UI Semibold", 11.8F, FontStyle.Bold);
            groupBox11.ForeColor = Color.FromArgb(84, 110, 122);
            groupBox11.Location = new Point(23, 419);
            groupBox11.Name = "groupBox11";
            groupBox11.Padding = new Padding(10, 3, 3, 3);
            groupBox11.Size = new Size(250, 107);
            groupBox11.TabIndex = 9;
            groupBox11.TabStop = false;
            groupBox11.Text = "SAAT";
            // 
            // lblSeansSec
            // 
            lblSeansSec.AutoSize = true;
            lblSeansSec.Font = new Font("Segoe UI Semibold", 6.8F, FontStyle.Bold);
            lblSeansSec.ForeColor = Color.Red;
            lblSeansSec.Location = new Point(183, 12);
            lblSeansSec.Name = "lblSeansSec";
            lblSeansSec.Size = new Size(70, 15);
            lblSeansSec.TabIndex = 22;
            lblSeansSec.Text = "lblSeansSec";
            lblSeansSec.Visible = false;
            // 
            // panelSeans
            // 
            panelSeans.AutoScroll = true;
            panelSeans.Dock = DockStyle.Fill;
            panelSeans.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold);
            panelSeans.Location = new Point(10, 30);
            panelSeans.Name = "panelSeans";
            panelSeans.Size = new Size(237, 74);
            panelSeans.TabIndex = 22;
            panelSeans.WrapContents = false;
            // 
            // groupBox12
            // 
            groupBox12.Location = new Point(136, 53);
            groupBox12.Name = "groupBox12";
            groupBox12.Size = new Size(8, 8);
            groupBox12.TabIndex = 0;
            groupBox12.TabStop = false;
            groupBox12.Text = "groupBox12";
            // 
            // groupBox13
            // 
            groupBox13.Controls.Add(lblKoltukSayisi);
            groupBox13.Controls.Add(cbSalon);
            groupBox13.Controls.Add(groupBox14);
            groupBox13.Font = new Font("Segoe UI Semibold", 11.8F, FontStyle.Bold);
            groupBox13.ForeColor = Color.FromArgb(84, 110, 122);
            groupBox13.Location = new Point(26, 520);
            groupBox13.Name = "groupBox13";
            groupBox13.Padding = new Padding(10, 3, 3, 3);
            groupBox13.Size = new Size(250, 57);
            groupBox13.TabIndex = 10;
            groupBox13.TabStop = false;
            groupBox13.Text = "SALON ADI";
            groupBox13.Enter += groupBox13_Enter;
            // 
            // lblKoltukSayisi
            // 
            lblKoltukSayisi.AutoSize = true;
            lblKoltukSayisi.Font = new Font("Segoe UI Semibold", 6.8F, FontStyle.Bold);
            lblKoltukSayisi.ForeColor = Color.Red;
            lblKoltukSayisi.Location = new Point(163, 11);
            lblKoltukSayisi.Name = "lblKoltukSayisi";
            lblKoltukSayisi.Size = new Size(84, 15);
            lblKoltukSayisi.TabIndex = 23;
            lblKoltukSayisi.Text = "lblKoltukSayisi";
            lblKoltukSayisi.Visible = false;
            // 
            // cbSalon
            // 
            cbSalon.Dock = DockStyle.Bottom;
            cbSalon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSalon.FlatStyle = FlatStyle.Flat;
            cbSalon.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold);
            cbSalon.ForeColor = Color.FromArgb(84, 110, 122);
            cbSalon.FormattingEnabled = true;
            cbSalon.Location = new Point(10, 29);
            cbSalon.Name = "cbSalon";
            cbSalon.Size = new Size(237, 25);
            cbSalon.TabIndex = 1;
            cbSalon.SelectedIndexChanged += cbSalon_SelectedIndexChanged;
            // 
            // groupBox14
            // 
            groupBox14.Location = new Point(136, 53);
            groupBox14.Name = "groupBox14";
            groupBox14.Size = new Size(8, 8);
            groupBox14.TabIndex = 0;
            groupBox14.TabStop = false;
            groupBox14.Text = "groupBox14";
            // 
            // groupBox15
            // 
            groupBox15.Controls.Add(cbBiletTuru);
            groupBox15.Controls.Add(groupBox16);
            groupBox15.Font = new Font("Segoe UI Semibold", 11.8F, FontStyle.Bold);
            groupBox15.ForeColor = Color.FromArgb(84, 110, 122);
            groupBox15.Location = new Point(26, 587);
            groupBox15.Name = "groupBox15";
            groupBox15.Padding = new Padding(10, 3, 3, 3);
            groupBox15.Size = new Size(250, 57);
            groupBox15.TabIndex = 9;
            groupBox15.TabStop = false;
            groupBox15.Text = "BİLET TÜRÜ";
            // 
            // cbBiletTuru
            // 
            cbBiletTuru.Dock = DockStyle.Bottom;
            cbBiletTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBiletTuru.FlatStyle = FlatStyle.Flat;
            cbBiletTuru.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold);
            cbBiletTuru.ForeColor = Color.FromArgb(84, 110, 122);
            cbBiletTuru.FormattingEnabled = true;
            cbBiletTuru.Items.AddRange(new object[] { "YETİŞKİN", "İNDİRİMLİ" });
            cbBiletTuru.Location = new Point(10, 29);
            cbBiletTuru.Name = "cbBiletTuru";
            cbBiletTuru.Size = new Size(237, 25);
            cbBiletTuru.TabIndex = 1;
            // 
            // groupBox16
            // 
            groupBox16.Location = new Point(136, 53);
            groupBox16.Name = "groupBox16";
            groupBox16.Size = new Size(8, 8);
            groupBox16.TabIndex = 0;
            groupBox16.TabStop = false;
            groupBox16.Text = "groupBox16";
            // 
            // groupBox17
            // 
            groupBox17.Controls.Add(txtKoltuklar);
            groupBox17.Controls.Add(groupBox18);
            groupBox17.Font = new Font("Segoe UI Semibold", 11.8F, FontStyle.Bold);
            groupBox17.ForeColor = Color.FromArgb(84, 110, 122);
            groupBox17.Location = new Point(26, 654);
            groupBox17.Name = "groupBox17";
            groupBox17.Padding = new Padding(10, 3, 3, 3);
            groupBox17.Size = new Size(250, 57);
            groupBox17.TabIndex = 11;
            groupBox17.TabStop = false;
            groupBox17.Text = "ŞEÇİLEN KOLTUKLAR";
            // 
            // txtKoltuklar
            // 
            txtKoltuklar.BorderStyle = BorderStyle.None;
            txtKoltuklar.Dock = DockStyle.Bottom;
            txtKoltuklar.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold);
            txtKoltuklar.ForeColor = Color.FromArgb(84, 110, 122);
            txtKoltuklar.HideSelection = false;
            txtKoltuklar.Location = new Point(10, 32);
            txtKoltuklar.Name = "txtKoltuklar";
            txtKoltuklar.Size = new Size(237, 22);
            txtKoltuklar.TabIndex = 1;
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
            // btnOlustur
            // 
            btnOlustur.BackColor = Color.FromArgb(229, 57, 53);
            btnOlustur.FlatAppearance.BorderSize = 0;
            btnOlustur.FlatStyle = FlatStyle.Flat;
            btnOlustur.ForeColor = Color.White;
            btnOlustur.Location = new Point(26, 721);
            btnOlustur.Name = "btnOlustur";
            btnOlustur.Size = new Size(247, 45);
            btnOlustur.TabIndex = 21;
            btnOlustur.Text = "OLUŞTUR";
            btnOlustur.UseVisualStyleBackColor = false;
            btnOlustur.Click += btnOlustur_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(299, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(628, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.White;
            label2.Location = new Point(563, 91);
            label2.Name = "label2";
            label2.Size = new Size(82, 31);
            label2.TabIndex = 23;
            label2.Text = "PERDE";
            // 
            // KoltukPaneli
            // 
            KoltukPaneli.AutoScroll = true;
            KoltukPaneli.Location = new Point(299, 151);
            KoltukPaneli.Name = "KoltukPaneli";
            KoltukPaneli.Size = new Size(628, 573);
            KoltukPaneli.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold);
            label3.ForeColor = Color.Aqua;
            label3.Location = new Point(454, 785);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 25;
            label3.Text = "Boş Koltuk";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(551, 785);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 27;
            label4.Text = "Dolu Koltuk";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold);
            label5.ForeColor = Color.Khaki;
            label5.Location = new Point(657, 785);
            label5.Name = "label5";
            label5.Size = new Size(117, 23);
            label5.TabIndex = 29;
            label5.Text = "Şeçilen Koltuk";
            // 
            // lblGelenKoltuk
            // 
            lblGelenKoltuk.AutoSize = true;
            lblGelenKoltuk.Location = new Point(817, 267);
            lblGelenKoltuk.Name = "lblGelenKoltuk";
            lblGelenKoltuk.Size = new Size(77, 31);
            lblGelenKoltuk.TabIndex = 30;
            lblGelenKoltuk.Text = "label6";
            // 
            // listeGelenKoltuk
            // 
            listeGelenKoltuk.FormattingEnabled = true;
            listeGelenKoltuk.ItemHeight = 31;
            listeGelenKoltuk.Location = new Point(788, 158);
            listeGelenKoltuk.Name = "listeGelenKoltuk";
            listeGelenKoltuk.Size = new Size(139, 97);
            listeGelenKoltuk.TabIndex = 31;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.sari;
            pictureBox2.Location = new Point(470, 730);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 55);
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // lblBelirlenen
            // 
            lblBelirlenen.FormattingEnabled = true;
            lblBelirlenen.ItemHeight = 31;
            lblBelirlenen.Location = new Point(788, 323);
            lblBelirlenen.Name = "lblBelirlenen";
            lblBelirlenen.Size = new Size(139, 97);
            lblBelirlenen.TabIndex = 33;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.kir;
            pictureBox3.Location = new Point(574, 727);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(55, 55);
            pictureBox3.TabIndex = 34;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.mavi;
            pictureBox4.Location = new Point(691, 727);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(55, 55);
            pictureBox4.TabIndex = 35;
            pictureBox4.TabStop = false;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(84, 110, 122);
            btnTemizle.FlatAppearance.BorderSize = 0;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Location = new Point(49, 772);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(197, 36);
            btnTemizle.TabIndex = 36;
            btnTemizle.Text = "TEMİZLE";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // FrmBiletOlustur
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(939, 814);
            Controls.Add(btnTemizle);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(KoltukPaneli);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(btnOlustur);
            Controls.Add(groupBox17);
            Controls.Add(groupBox15);
            Controls.Add(groupBox13);
            Controls.Add(groupBox11);
            Controls.Add(groupBox9);
            Controls.Add(groupBox7);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(lblBelirlenen);
            Controls.Add(listeGelenKoltuk);
            Controls.Add(lblGelenKoltuk);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(500, 110);
            Margin = new Padding(5);
            Name = "FrmBiletOlustur";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmBiletOlustur";
            Load += FrmBiletOlustur_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            groupBox13.ResumeLayout(false);
            groupBox13.PerformLayout();
            groupBox15.ResumeLayout(false);
            groupBox17.ResumeLayout(false);
            groupBox17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtBiletNo;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txtAdSoyad;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TextBox txtTelNo;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private GroupBox groupBox8;
        private ComboBox cbFlimAdi;
        private GroupBox groupBox9;
        private GroupBox groupBox10;
        private Label lblYonetmenAra;
        private GroupBox groupBox11;
        private GroupBox groupBox12;
        private GroupBox groupBox13;
        private ComboBox cbSalon;
        private GroupBox groupBox14;
        private GroupBox groupBox15;
        private ComboBox cbBiletTuru;
        private GroupBox groupBox16;
        private GroupBox groupBox17;
        private TextBox txtKoltuklar;
        private GroupBox groupBox18;
        private Button btnOlustur;
        private ComboBox cbTarih;
        private FlowLayoutPanel panelSeans;
        private Label lblSeansSec;
        private Label lblKoltukSayisi;
        private PictureBox pictureBox1;
        private Label label2;
        private FlowLayoutPanel KoltukPaneli;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblGelenKoltuk;
        private ListBox listeGelenKoltuk;
        private PictureBox pictureBox2;
        private ListBox lblBelirlenen;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btnTemizle;
    }
}