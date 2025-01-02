namespace SinemaOtomasyon
{
    partial class FrmOyuncuListesi
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
            panel2 = new Panel();
            txtAramaYap = new TextBox();
            label2 = new Label();
            ListePaneli = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.TabIndex = 4;
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
            label1.Size = new Size(216, 31);
            label1.TabIndex = 1;
            label1.Text = "Oyuncu Liste Ekranı";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(txtAramaYap);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(724, 65);
            panel2.TabIndex = 5;
            // 
            // txtAramaYap
            // 
            txtAramaYap.BorderStyle = BorderStyle.None;
            txtAramaYap.ForeColor = Color.FromArgb(84, 110, 122);
            txtAramaYap.Location = new Point(215, 18);
            txtAramaYap.Name = "txtAramaYap";
            txtAramaYap.Size = new Size(221, 31);
            txtAramaYap.TabIndex = 0;
            txtAramaYap.TextChanged += txtAramaYap_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(84, 110, 122);
            label2.Location = new Point(26, 18);
            label2.Name = "label2";
            label2.Size = new Size(173, 31);
            label2.TabIndex = 5;
            label2.Text = "AD VE SOYAD :";
            // 
            // ListePaneli
            // 
            ListePaneli.AutoScroll = true;
            ListePaneli.Dock = DockStyle.Fill;
            ListePaneli.Location = new Point(0, 130);
            ListePaneli.Name = "ListePaneli";
            ListePaneli.Size = new Size(724, 495);
            ListePaneli.TabIndex = 6;
            ListePaneli.Paint += ListePaneli_Paint;
            // 
            // FrmOyuncuListesi
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(724, 625);
            Controls.Add(ListePaneli);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(550, 110);
            Margin = new Padding(5);
            Name = "FrmOyuncuListesi";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmOyuncuListesi";
            Load += FrmOyuncuListesi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Label label1;
        private Panel panel2;
        private TextBox txtAramaYap;
        private Label label2;
        private FlowLayoutPanel ListePaneli;
    }
}