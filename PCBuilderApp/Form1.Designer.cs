namespace PCBuilderApp
{
    partial class Form1
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
            label1 = new Label();
            cmbCpu = new ComboBox();
            label2 = new Label();
            cmbAnakart = new ComboBox();
            cmbRam = new ComboBox();
            label3 = new Label();
            cmbGpu = new ComboBox();
            label4 = new Label();
            cmbPsu = new ComboBox();
            label5 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            lblWattDurumu = new Label();
            lblToplamFiyat = new Label();
            lstSepet = new ListBox();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(97, 19);
            label1.TabIndex = 0;
            label1.Text = "İşlemci Seçiniz:";
            // 
            // cmbCpu
            // 
            cmbCpu.FormattingEnabled = true;
            cmbCpu.Location = new Point(24, 42);
            cmbCpu.Name = "cmbCpu";
            cmbCpu.Size = new Size(279, 25);
            cmbCpu.TabIndex = 1;
            cmbCpu.SelectedIndexChanged += cmbCpu_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 76);
            label2.Name = "label2";
            label2.Size = new Size(127, 19);
            label2.TabIndex = 2;
            label2.Text = "Uyumlu Anakartlar:";
            // 
            // cmbAnakart
            // 
            cmbAnakart.FormattingEnabled = true;
            cmbAnakart.Location = new Point(24, 97);
            cmbAnakart.Name = "cmbAnakart";
            cmbAnakart.Size = new Size(279, 25);
            cmbAnakart.TabIndex = 3;
            cmbAnakart.SelectedIndexChanged += cmbAnakart_SelectedIndexChanged;
            // 
            // cmbRam
            // 
            cmbRam.FormattingEnabled = true;
            cmbRam.Location = new Point(23, 164);
            cmbRam.Name = "cmbRam";
            cmbRam.Size = new Size(280, 25);
            cmbRam.TabIndex = 4;
            cmbRam.SelectedIndexChanged += cmbRam_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 143);
            label3.Name = "label3";
            label3.Size = new Size(91, 19);
            label3.TabIndex = 5;
            label3.Text = "Uyumlu Ram:";
            // 
            // cmbGpu
            // 
            cmbGpu.FormattingEnabled = true;
            cmbGpu.Location = new Point(23, 223);
            cmbGpu.Name = "cmbGpu";
            cmbGpu.Size = new Size(280, 25);
            cmbGpu.TabIndex = 6;
            cmbGpu.SelectedIndexChanged += cmbGpu_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 202);
            label4.Name = "label4";
            label4.Size = new Size(130, 19);
            label4.TabIndex = 7;
            label4.Text = "Uyumlu Ekran Kartı:";
            // 
            // cmbPsu
            // 
            cmbPsu.FormattingEnabled = true;
            cmbPsu.Location = new Point(23, 288);
            cmbPsu.Name = "cmbPsu";
            cmbPsu.Size = new Size(280, 25);
            cmbPsu.TabIndex = 8;
            cmbPsu.SelectedIndexChanged += cmbPsu_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 263);
            label5.Name = "label5";
            label5.Size = new Size(88, 19);
            label5.TabIndex = 9;
            label5.Text = "Güç Kaynağı:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(40, 40, 40);
            panel1.Controls.Add(cmbRam);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbCpu);
            panel1.Controls.Add(cmbPsu);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(cmbAnakart);
            panel1.Controls.Add(cmbGpu);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(400, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 561);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblWattDurumu);
            panel2.Controls.Add(lblToplamFiyat);
            panel2.Controls.Add(lstSepet);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            panel2.ForeColor = Color.Orange;
            panel2.Location = new Point(400, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(565, 561);
            panel2.TabIndex = 12;
            // 
            // lblWattDurumu
            // 
            lblWattDurumu.AutoSize = true;
            lblWattDurumu.ForeColor = Color.Gray;
            lblWattDurumu.Location = new Point(16, 499);
            lblWattDurumu.Name = "lblWattDurumu";
            lblWattDurumu.Size = new Size(169, 25);
            lblWattDurumu.TabIndex = 3;
            lblWattDurumu.Text = "Güç Tüketimi: 0W";
            lblWattDurumu.Click += lblWattDurumu_Click;
            // 
            // lblToplamFiyat
            // 
            lblToplamFiyat.AutoSize = true;
            lblToplamFiyat.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblToplamFiyat.ForeColor = Color.Gold;
            lblToplamFiyat.Location = new Point(147, 431);
            lblToplamFiyat.Name = "lblToplamFiyat";
            lblToplamFiyat.Size = new Size(182, 32);
            lblToplamFiyat.TabIndex = 2;
            lblToplamFiyat.Text = "Toplam: 0,00 ₺";
            lblToplamFiyat.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lstSepet
            // 
            lstSepet.BackColor = Color.FromArgb(32, 32, 32);
            lstSepet.BorderStyle = BorderStyle.None;
            lstSepet.Font = new Font("Lucida Console", 11F);
            lstSepet.ForeColor = Color.LightGreen;
            lstSepet.FormattingEnabled = true;
            lstSepet.ItemHeight = 15;
            lstSepet.Location = new Point(3, 42);
            lstSepet.Name = "lstSepet";
            lstSepet.Size = new Size(559, 300);
            lstSepet.TabIndex = 1;
            lstSepet.SelectedIndexChanged += lstSepet_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(147, 14);
            label6.Name = "label6";
            label6.Size = new Size(210, 25);
            label6.TabIndex = 0;
            label6.Text = "SİSTEM ÖZETİ (SEPET)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(965, 561);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "PC Builder 2026";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox cmbCpu;
        private Label label2;
        private ComboBox cmbAnakart;
        private Label label3;
        private ComboBox cmbGpu;
        private Label label4;
        private ComboBox cmbRam;
        private ComboBox cmbPsu;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
        private Label lblToplamFiyat;
        private ListBox lstSepet;
        private Label label6;
        private Label lblWattDurumu;
    }
}
