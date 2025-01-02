namespace SinemaOtomasyon
{
    partial class FrmSalonKayit
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
            groupBox1 = new GroupBox();
            btnResimYukle = new Button();
            cbKoltukSayisi = new ComboBox();
            label3 = new Label();
            txtSalonAdi = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            panelSalon = new FlowLayoutPanel();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            panel1.TabIndex = 3;
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
            label1.Size = new Size(200, 31);
            label1.TabIndex = 1;
            label1.Text = "Salon Kayıt Ekranı";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnResimYukle);
            groupBox1.Controls.Add(cbKoltukSayisi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSalonAdi);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.FromArgb(84, 110, 122);
            groupBox1.Location = new Point(12, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(700, 206);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // btnResimYukle
            // 
            btnResimYukle.BackColor = Color.FromArgb(229, 57, 53);
            btnResimYukle.FlatAppearance.BorderSize = 0;
            btnResimYukle.FlatStyle = FlatStyle.Flat;
            btnResimYukle.ForeColor = Color.White;
            btnResimYukle.Location = new Point(243, 134);
            btnResimYukle.Name = "btnResimYukle";
            btnResimYukle.Size = new Size(170, 44);
            btnResimYukle.TabIndex = 9;
            btnResimYukle.Text = "KAYDET";
            btnResimYukle.UseVisualStyleBackColor = false;
            btnResimYukle.Click += btnResimYukle_Click;
            // 
            // cbKoltukSayisi
            // 
            cbKoltukSayisi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            cbKoltukSayisi.ForeColor = Color.FromArgb(84, 110, 122);
            cbKoltukSayisi.FormattingEnabled = true;
            cbKoltukSayisi.Location = new Point(349, 65);
            cbKoltukSayisi.Name = "cbKoltukSayisi";
            cbKoltukSayisi.Size = new Size(211, 31);
            cbKoltukSayisi.TabIndex = 8;
            cbKoltukSayisi.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 19);
            label3.Name = "label3";
            label3.Size = new Size(147, 28);
            label3.TabIndex = 7;
            label3.Text = "KOLTUK SAYISI";
            // 
            // txtSalonAdi
            // 
            txtSalonAdi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtSalonAdi.ForeColor = Color.FromArgb(84, 110, 122);
            txtSalonAdi.Location = new Point(50, 66);
            txtSalonAdi.Name = "txtSalonAdi";
            txtSalonAdi.Size = new Size(211, 30);
            txtSalonAdi.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 19);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 5;
            label2.Text = "SALON ADI";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panelSalon);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.ForeColor = Color.FromArgb(84, 110, 122);
            groupBox2.Location = new Point(11, 274);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(712, 480);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // panelSalon
            // 
            panelSalon.AutoScroll = true;
            panelSalon.Dock = DockStyle.Fill;
            panelSalon.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            panelSalon.Location = new Point(3, 30);
            panelSalon.Name = "panelSalon";
            panelSalon.Size = new Size(706, 447);
            panelSalon.TabIndex = 6;
            // 
            // FrmSalonKayit
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(724, 755);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(500, 110);
            Margin = new Padding(5);
            Name = "FrmSalonKayit";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmSalonKayit";
            Load += FrmSalonKayit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtSalonAdi;
        private Label label2;
        private ComboBox cbKoltukSayisi;
        private Button btnResimYukle;
        private GroupBox groupBox2;
        private FlowLayoutPanel panelSalon;
    }
}