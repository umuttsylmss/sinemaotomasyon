namespace SinemaOtomasyon
{
    partial class FrmSalonAtama
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
            panel1 = new Panel();
            button2 = new Button();
            label1 = new Label();
            btnOlustur = new Button();
            groupBox13 = new GroupBox();
            cbSalon = new ComboBox();
            groupBox14 = new GroupBox();
            lblSecilen = new Label();
            groupBox11 = new GroupBox();
            panelSeans = new FlowLayoutPanel();
            groupBox12 = new GroupBox();
            groupBox9 = new GroupBox();
            nYil = new NumericUpDown();
            nAy = new NumericUpDown();
            nGun = new NumericUpDown();
            lblYonetmenAra = new Label();
            groupBox10 = new GroupBox();
            groupBox7 = new GroupBox();
            cbFlimAdi = new ComboBox();
            groupBox8 = new GroupBox();
            btnTemizle = new Button();
            lbldenem = new GroupBox();
            cbDoluSaatler = new ComboBox();
            groupBox2 = new GroupBox();
            panel1.SuspendLayout();
            groupBox13.SuspendLayout();
            groupBox11.SuspendLayout();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nYil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nAy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nGun).BeginInit();
            groupBox7.SuspendLayout();
            lbldenem.SuspendLayout();
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
            panel1.Size = new Size(795, 65);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(229, 57, 53);
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(750, 0);
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
            label1.Size = new Size(254, 31);
            label1.TabIndex = 1;
            label1.Text = "SALON ATAMA EKRANI";
            // 
            // btnOlustur
            // 
            btnOlustur.BackColor = Color.FromArgb(229, 57, 53);
            btnOlustur.FlatAppearance.BorderSize = 0;
            btnOlustur.FlatStyle = FlatStyle.Flat;
            btnOlustur.ForeColor = Color.White;
            btnOlustur.Location = new Point(29, 290);
            btnOlustur.Name = "btnOlustur";
            btnOlustur.Size = new Size(247, 45);
            btnOlustur.TabIndex = 26;
            btnOlustur.Text = "TAMAMLA";
            btnOlustur.UseVisualStyleBackColor = false;
            btnOlustur.Click += btnOlustur_Click;
            // 
            // groupBox13
            // 
            groupBox13.Controls.Add(cbSalon);
            groupBox13.Controls.Add(groupBox14);
            groupBox13.Font = new Font("Segoe UI Semibold", 11.8F, FontStyle.Bold);
            groupBox13.ForeColor = Color.FromArgb(84, 110, 122);
            groupBox13.Location = new Point(26, 150);
            groupBox13.Name = "groupBox13";
            groupBox13.Padding = new Padding(10, 3, 3, 3);
            groupBox13.Size = new Size(250, 57);
            groupBox13.TabIndex = 25;
            groupBox13.TabStop = false;
            groupBox13.Text = "SALON ADI";
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
            // lblSecilen
            // 
            lblSecilen.AutoSize = true;
            lblSecilen.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSecilen.ForeColor = Color.Red;
            lblSecilen.Location = new Point(405, 409);
            lblSecilen.Name = "lblSecilen";
            lblSecilen.Size = new Size(175, 31);
            lblSecilen.TabIndex = 23;
            lblSecilen.Text = "lblKoltukSayisi";
            lblSecilen.Visible = false;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(panelSeans);
            groupBox11.Controls.Add(groupBox12);
            groupBox11.Font = new Font("Segoe UI Semibold", 11.8F, FontStyle.Bold);
            groupBox11.ForeColor = Color.FromArgb(84, 110, 122);
            groupBox11.Location = new Point(289, 74);
            groupBox11.Name = "groupBox11";
            groupBox11.Padding = new Padding(10, 3, 3, 3);
            groupBox11.Size = new Size(487, 313);
            groupBox11.TabIndex = 24;
            groupBox11.TabStop = false;
            groupBox11.Text = "SAAT";
            // 
            // panelSeans
            // 
            panelSeans.AutoScroll = true;
            panelSeans.Dock = DockStyle.Fill;
            panelSeans.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold);
            panelSeans.Location = new Point(10, 30);
            panelSeans.Name = "panelSeans";
            panelSeans.Size = new Size(474, 280);
            panelSeans.TabIndex = 22;
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
            // groupBox9
            // 
            groupBox9.Controls.Add(nYil);
            groupBox9.Controls.Add(nAy);
            groupBox9.Controls.Add(nGun);
            groupBox9.Controls.Add(lblYonetmenAra);
            groupBox9.Controls.Add(groupBox10);
            groupBox9.Font = new Font("Segoe UI Semibold", 11.8F, FontStyle.Bold);
            groupBox9.ForeColor = Color.FromArgb(84, 110, 122);
            groupBox9.Location = new Point(26, 217);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(10, 3, 3, 3);
            groupBox9.Size = new Size(250, 57);
            groupBox9.TabIndex = 22;
            groupBox9.TabStop = false;
            groupBox9.Text = "TARİH";
            // 
            // nYil
            // 
            nYil.BorderStyle = BorderStyle.None;
            nYil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            nYil.ForeColor = Color.FromArgb(84, 110, 122);
            nYil.Location = new Point(172, 27);
            nYil.Maximum = new decimal(new int[] { 2300, 0, 0, 0 });
            nYil.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            nYil.Name = "nYil";
            nYil.Size = new Size(68, 23);
            nYil.TabIndex = 20;
            nYil.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            // 
            // nAy
            // 
            nAy.BorderStyle = BorderStyle.None;
            nAy.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            nAy.ForeColor = Color.FromArgb(84, 110, 122);
            nAy.Location = new Point(94, 28);
            nAy.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nAy.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nAy.Name = "nAy";
            nAy.Size = new Size(68, 23);
            nAy.TabIndex = 19;
            nAy.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nAy.ValueChanged += nAy_ValueChanged;
            // 
            // nGun
            // 
            nGun.BorderStyle = BorderStyle.None;
            nGun.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            nGun.ForeColor = Color.FromArgb(84, 110, 122);
            nGun.Location = new Point(19, 28);
            nGun.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            nGun.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nGun.Name = "nGun";
            nGun.Size = new Size(68, 23);
            nGun.TabIndex = 18;
            nGun.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblYonetmenAra
            // 
            lblYonetmenAra.AutoSize = true;
            lblYonetmenAra.Font = new Font("Segoe UI Semibold", 6.8F, FontStyle.Bold);
            lblYonetmenAra.ForeColor = Color.Red;
            lblYonetmenAra.Location = new Point(180, 0);
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
            // groupBox7
            // 
            groupBox7.Controls.Add(cbFlimAdi);
            groupBox7.Controls.Add(groupBox8);
            groupBox7.Font = new Font("Segoe UI Semibold", 11.8F, FontStyle.Bold);
            groupBox7.ForeColor = Color.FromArgb(84, 110, 122);
            groupBox7.Location = new Point(26, 83);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(10, 3, 3, 3);
            groupBox7.Size = new Size(250, 57);
            groupBox7.TabIndex = 23;
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
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(84, 110, 122);
            btnTemizle.FlatAppearance.BorderSize = 0;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.ForeColor = Color.White;
            btnTemizle.Location = new Point(50, 341);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(197, 36);
            btnTemizle.TabIndex = 37;
            btnTemizle.Text = "TEMİZLE";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // lbldenem
            // 
            lbldenem.Controls.Add(cbDoluSaatler);
            lbldenem.Controls.Add(groupBox2);
            lbldenem.Font = new Font("Segoe UI Semibold", 11.8F, FontStyle.Bold);
            lbldenem.ForeColor = Color.FromArgb(84, 110, 122);
            lbldenem.Location = new Point(36, 388);
            lbldenem.Name = "lbldenem";
            lbldenem.Padding = new Padding(10, 3, 3, 3);
            lbldenem.Size = new Size(250, 57);
            lbldenem.TabIndex = 38;
            lbldenem.TabStop = false;
            lbldenem.Text = "DOLU SAATLER";
            // 
            // cbDoluSaatler
            // 
            cbDoluSaatler.Dock = DockStyle.Bottom;
            cbDoluSaatler.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDoluSaatler.FlatStyle = FlatStyle.Flat;
            cbDoluSaatler.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold);
            cbDoluSaatler.ForeColor = Color.FromArgb(84, 110, 122);
            cbDoluSaatler.FormattingEnabled = true;
            cbDoluSaatler.Location = new Point(10, 29);
            cbDoluSaatler.Name = "cbDoluSaatler";
            cbDoluSaatler.Size = new Size(237, 25);
            cbDoluSaatler.TabIndex = 1;
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
            // FrmSalonAtama
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(795, 457);
            Controls.Add(lblSecilen);
            Controls.Add(lbldenem);
            Controls.Add(btnTemizle);
            Controls.Add(btnOlustur);
            Controls.Add(groupBox13);
            Controls.Add(groupBox11);
            Controls.Add(groupBox9);
            Controls.Add(groupBox7);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(500, 110);
            Margin = new Padding(5);
            Name = "FrmSalonAtama";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmSalonAtama";
            Load += FrmSalonAtama_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox13.ResumeLayout(false);
            groupBox11.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nYil).EndInit();
            ((System.ComponentModel.ISupportInitialize)nAy).EndInit();
            ((System.ComponentModel.ISupportInitialize)nGun).EndInit();
            groupBox7.ResumeLayout(false);
            lbldenem.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Label label1;
        private Button btnOlustur;
        private GroupBox groupBox13;
        private Label lblSecilen;
        private ComboBox cbSalon;
        private GroupBox groupBox14;
        private GroupBox groupBox11;
        private FlowLayoutPanel panelSeans;
        private GroupBox groupBox12;
        private GroupBox groupBox9;
        private Label lblYonetmenAra;
        private GroupBox groupBox10;
        private GroupBox groupBox7;
        private ComboBox cbFlimAdi;
        private GroupBox groupBox8;
        private Button btnTemizle;
        private NumericUpDown nYil;
        private NumericUpDown nAy;
        private NumericUpDown nGun;
        private GroupBox lbldenem;
        private ComboBox cbDoluSaatler;
        private GroupBox groupBox2;
    }
}