namespace SinemaOtomasyon
{
    partial class frmAcilis
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            label3 = new Label();
            btnGirisYap = new Button();
            panel1.SuspendLayout();
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
            panel1.Size = new Size(526, 65);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(229, 57, 53);
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(481, 0);
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
            label1.Size = new Size(216, 31);
            label1.TabIndex = 1;
            label1.Text = "Sinema Otomasyon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(84, 110, 122);
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(138, 31);
            label2.TabIndex = 3;
            label2.Text = "YETKİLİ KİŞİ";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtKullaniciAdi.ForeColor = Color.FromArgb(84, 110, 122);
            txtKullaniciAdi.Location = new Point(170, 113);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(221, 30);
            txtKullaniciAdi.TabIndex = 4;
            txtKullaniciAdi.TextChanged += textBox1_TextChanged;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtSifre.ForeColor = Color.FromArgb(84, 110, 122);
            txtSifre.Location = new Point(170, 167);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(221, 30);
            txtSifre.TabIndex = 6;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(84, 110, 122);
            label3.Location = new Point(78, 167);
            label3.Name = "label3";
            label3.Size = new Size(72, 31);
            label3.TabIndex = 5;
            label3.Text = "ŞİFRE";
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = Color.FromArgb(84, 110, 122);
            btnGirisYap.ForeColor = Color.White;
            btnGirisYap.Location = new Point(170, 203);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(221, 54);
            btnGirisYap.TabIndex = 7;
            btnGirisYap.Text = "GİRİŞ YAP";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // frmAcilis
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(526, 324);
            Controls.Add(btnGirisYap);
            Controls.Add(txtSifre);
            Controls.Add(label3);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "frmAcilis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button2;
        private Label label2;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Label label3;
        private Button btnGirisYap;
    }
}
