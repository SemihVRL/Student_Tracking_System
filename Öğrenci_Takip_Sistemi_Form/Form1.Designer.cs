using System;

namespace Turkcell_Temel_FormProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxDers = new System.Windows.Forms.ComboBox();
            this.tbxSınav1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxSınav2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxOrt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.ÖğrenciBilgileri = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtbxNumara = new System.Windows.Forms.MaskedTextBox();
            this.tbxDurum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblVeri = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSifirlama = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(409, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖĞRENCİ NOT KAYIT SİSTEMİ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad:";
            // 
            // tbxAdSoyad
            // 
            this.tbxAdSoyad.Location = new System.Drawing.Point(174, 83);
            this.tbxAdSoyad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxAdSoyad.Name = "tbxAdSoyad";
            this.tbxAdSoyad.Size = new System.Drawing.Size(215, 43);
            this.tbxAdSoyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ders:";
            // 
            // cbxDers
            // 
            this.cbxDers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDers.FormattingEnabled = true;
            this.cbxDers.Items.AddRange(new object[] {
            "Matematik",
            "Türkçe",
            "İngilizce",
            "Edebiyat",
            "Fizik",
            "Kimya"});
            this.cbxDers.Location = new System.Drawing.Point(174, 148);
            this.cbxDers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxDers.Name = "cbxDers";
            this.cbxDers.Size = new System.Drawing.Size(215, 45);
            this.cbxDers.TabIndex = 5;
            // 
            // tbxSınav1
            // 
            this.tbxSınav1.Location = new System.Drawing.Point(555, 125);
            this.tbxSınav1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxSınav1.Name = "tbxSınav1";
            this.tbxSınav1.Size = new System.Drawing.Size(106, 43);
            this.tbxSınav1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sınav 1:";
            // 
            // tbxSınav2
            // 
            this.tbxSınav2.Location = new System.Drawing.Point(555, 185);
            this.tbxSınav2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxSınav2.Name = "tbxSınav2";
            this.tbxSınav2.Size = new System.Drawing.Size(106, 43);
            this.tbxSınav2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sınav 2:";
            // 
            // tbxOrt
            // 
            this.tbxOrt.Location = new System.Drawing.Point(851, 125);
            this.tbxOrt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxOrt.Name = "tbxOrt";
            this.tbxOrt.Size = new System.Drawing.Size(122, 43);
            this.tbxOrt.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(708, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 37);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ortalama:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(24, 290);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(258, 60);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            this.btnKaydet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnKaydet_MouseClick);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(362, 288);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(267, 60);
            this.btnHesapla.TabIndex = 15;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(714, 288);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(235, 60);
            this.btnTemizle.TabIndex = 16;
            this.btnTemizle.Text = "Kayıt Sil";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // ÖğrenciBilgileri
            // 
            this.ÖğrenciBilgileri.FormattingEnabled = true;
            this.ÖğrenciBilgileri.ItemHeight = 37;
            this.ÖğrenciBilgileri.Location = new System.Drawing.Point(24, 443);
            this.ÖğrenciBilgileri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ÖğrenciBilgileri.Name = "ÖğrenciBilgileri";
            this.ÖğrenciBilgileri.ScrollAlwaysVisible = true;
            this.ÖğrenciBilgileri.Size = new System.Drawing.Size(1327, 337);
            this.ÖğrenciBilgileri.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 214);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 37);
            this.label8.TabIndex = 18;
            this.label8.Text = "Numara:";
            // 
            // mtbxNumara
            // 
            this.mtbxNumara.Location = new System.Drawing.Point(174, 208);
            this.mtbxNumara.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbxNumara.Mask = "0000";
            this.mtbxNumara.Name = "mtbxNumara";
            this.mtbxNumara.Size = new System.Drawing.Size(215, 43);
            this.mtbxNumara.TabIndex = 19;
            this.mtbxNumara.ValidatingType = typeof(int);
            // 
            // tbxDurum
            // 
            this.tbxDurum.Location = new System.Drawing.Point(851, 185);
            this.tbxDurum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxDurum.Name = "tbxDurum";
            this.tbxDurum.Size = new System.Drawing.Size(122, 43);
            this.tbxDurum.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(725, 185);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 37);
            this.label7.TabIndex = 20;
            this.label7.Text = "Durum";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(992, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 224);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 384);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 37);
            this.label9.TabIndex = 23;
            this.label9.Text = "Öğrenci Listesi";
            // 
            // lblVeri
            // 
            this.lblVeri.AutoSize = true;
            this.lblVeri.Location = new System.Drawing.Point(985, 375);
            this.lblVeri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVeri.Name = "lblVeri";
            this.lblVeri.Size = new System.Drawing.Size(0, 37);
            this.lblVeri.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(809, 375);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(256, 37);
            this.label10.TabIndex = 26;
            this.label10.Text = "Kayıt Edilen Öğrenci";
            // 
            // btnSifirlama
            // 
            this.btnSifirlama.Location = new System.Drawing.Point(1064, 290);
            this.btnSifirlama.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSifirlama.Name = "btnSifirlama";
            this.btnSifirlama.Size = new System.Drawing.Size(212, 60);
            this.btnSifirlama.TabIndex = 27;
            this.btnSifirlama.Text = "Sayaç Sıfırlama";
            this.btnSifirlama.UseVisualStyleBackColor = true;
            this.btnSifirlama.Click += new System.EventHandler(this.btnSifirlama_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1066, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 846);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSifirlama);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblVeri);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxDurum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mtbxNumara);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ÖğrenciBilgileri);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.tbxOrt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxSınav2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxSınav1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxDers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenciler Not Sistemi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnSayac_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxDers;
        private System.Windows.Forms.TextBox tbxSınav1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxSınav2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxOrt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ListBox ÖğrenciBilgileri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtbxNumara;
        private System.Windows.Forms.TextBox tbxDurum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblVeri;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSifirlama;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

