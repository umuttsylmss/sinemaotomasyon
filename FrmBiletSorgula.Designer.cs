namespace SinemaOtomasyon
{
    partial class FrmBiletSorgula
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
            label2 = new Label();
            txtBiletNo = new TextBox();
            btnSorgula = new Button();
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
            panel1.Size = new Size(511, 65);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(229, 57, 53);
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(466, 0);
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
            label1.Size = new Size(302, 31);
            label1.TabIndex = 1;
            label1.Text = "BİLET SORGULAMA EKRANI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(84, 110, 122);
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(196, 31);
            label2.TabIndex = 3;
            label2.Text = "BİLET NUMARASI";
            // 
            // txtBiletNo
            // 
            txtBiletNo.BorderStyle = BorderStyle.FixedSingle;
            txtBiletNo.ForeColor = Color.FromArgb(84, 110, 122);
            txtBiletNo.Location = new Point(205, 94);
            txtBiletNo.Name = "txtBiletNo";
            txtBiletNo.Size = new Size(267, 38);
            txtBiletNo.TabIndex = 4;
            // 
            // btnSorgula
            // 
            btnSorgula.BackColor = Color.FromArgb(84, 110, 122);
            btnSorgula.FlatAppearance.BorderSize = 0;
            btnSorgula.FlatStyle = FlatStyle.Flat;
            btnSorgula.ForeColor = Color.White;
            btnSorgula.Location = new Point(205, 138);
            btnSorgula.Name = "btnSorgula";
            btnSorgula.Size = new Size(267, 44);
            btnSorgula.TabIndex = 5;
            btnSorgula.Text = "SORGULA";
            btnSorgula.UseVisualStyleBackColor = false;
            btnSorgula.Click += btnSorgula_Click;
            // 
            // FrmBiletSorgula
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(511, 209);
            Controls.Add(btnSorgula);
            Controls.Add(txtBiletNo);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(500, 110);
            Margin = new Padding(5);
            Name = "FrmBiletSorgula";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmBiletSorgula";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox txtBiletNo;
        private Button btnSorgula;
    }
}