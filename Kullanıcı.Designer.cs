namespace SOHATS
{
    partial class Kullanıcı
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_kullanicikodu = new System.Windows.Forms.TextBox();
            this.cmbbox_unvan = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_isebaslama = new System.Windows.Forms.DateTimePicker();
            this.checkBox_yetkili = new System.Windows.Forms.CheckBox();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbox_kimlikno = new System.Windows.Forms.TextBox();
            this.txtbox_dogumyeri = new System.Windows.Forms.TextBox();
            this.txtbox_anneadi = new System.Windows.Forms.TextBox();
            this.txtbox_babaadi = new System.Windows.Forms.TextBox();
            this.txtbox_telefonno = new System.Windows.Forms.TextBox();
            this.txtbox_gsm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtbox_ad = new System.Windows.Forms.TextBox();
            this.txtbox_soyad = new System.Windows.Forms.TextBox();
            this.txtbox_maas = new System.Windows.Forms.TextBox();
            this.dateTimePicker_dogumtarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbbox_cinsiyet = new System.Windows.Forms.ComboBox();
            this.cmbbox_medenihal = new System.Windows.Forms.ComboBox();
            this.cmbbox_kangrubu = new System.Windows.Forms.ComboBox();
            this.txtbox_adres = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbox_sifre = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtbox_kullaniciad = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Kodu";
            // 
            // txtbox_kullanicikodu
            // 
            this.txtbox_kullanicikodu.Enabled = false;
            this.txtbox_kullanicikodu.Location = new System.Drawing.Point(118, 12);
            this.txtbox_kullanicikodu.Name = "txtbox_kullanicikodu";
            this.txtbox_kullanicikodu.Size = new System.Drawing.Size(206, 20);
            this.txtbox_kullanicikodu.TabIndex = 1;
            // 
            // cmbbox_unvan
            // 
            this.cmbbox_unvan.FormattingEnabled = true;
            this.cmbbox_unvan.Location = new System.Drawing.Point(454, 11);
            this.cmbbox_unvan.Name = "cmbbox_unvan";
            this.cmbbox_unvan.Size = new System.Drawing.Size(206, 21);
            this.cmbbox_unvan.TabIndex = 8;
            // 
            // dateTimePicker_isebaslama
            // 
            this.dateTimePicker_isebaslama.Location = new System.Drawing.Point(454, 116);
            this.dateTimePicker_isebaslama.Name = "dateTimePicker_isebaslama";
            this.dateTimePicker_isebaslama.Size = new System.Drawing.Size(206, 20);
            this.dateTimePicker_isebaslama.TabIndex = 12;
            // 
            // checkBox_yetkili
            // 
            this.checkBox_yetkili.AutoSize = true;
            this.checkBox_yetkili.Location = new System.Drawing.Point(228, 197);
            this.checkBox_yetkili.Name = "checkBox_yetkili";
            this.checkBox_yetkili.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_yetkili.Size = new System.Drawing.Size(96, 17);
            this.checkBox_yetkili.TabIndex = 17;
            this.checkBox_yetkili.Text = "Yetkili Kullanıcı";
            this.checkBox_yetkili.UseVisualStyleBackColor = true;
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Location = new System.Drawing.Point(6, 19);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(82, 41);
            this.btn_Temizle.TabIndex = 21;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.btn_Temizle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Cikis);
            this.groupBox1.Controls.Add(this.btn_Sil);
            this.groupBox1.Controls.Add(this.btn_Guncelle);
            this.groupBox1.Controls.Add(this.btn_Temizle);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.groupBox1.Location = new System.Drawing.Point(0, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 72);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.Location = new System.Drawing.Point(561, 19);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(82, 41);
            this.btn_Cikis.TabIndex = 24;
            this.btn_Cikis.Text = "Çıkış";
            this.btn_Cikis.UseVisualStyleBackColor = true;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(182, 19);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(82, 41);
            this.btn_Sil.TabIndex = 23;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(94, 19);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(82, 41);
            this.btn_Guncelle.TabIndex = 22;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "T.C. Kimlik Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Doğum Yeri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Anne Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Baba Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Telefon No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "GSM";
            // 
            // txtbox_kimlikno
            // 
            this.txtbox_kimlikno.Enabled = false;
            this.txtbox_kimlikno.Location = new System.Drawing.Point(118, 38);
            this.txtbox_kimlikno.Name = "txtbox_kimlikno";
            this.txtbox_kimlikno.Size = new System.Drawing.Size(206, 20);
            this.txtbox_kimlikno.TabIndex = 2;
            this.txtbox_kimlikno.TextChanged += new System.EventHandler(this.txtbox_kimlikno_TextChanged);
            // 
            // txtbox_dogumyeri
            // 
            this.txtbox_dogumyeri.Location = new System.Drawing.Point(118, 64);
            this.txtbox_dogumyeri.Name = "txtbox_dogumyeri";
            this.txtbox_dogumyeri.Size = new System.Drawing.Size(206, 20);
            this.txtbox_dogumyeri.TabIndex = 3;
            // 
            // txtbox_anneadi
            // 
            this.txtbox_anneadi.Location = new System.Drawing.Point(118, 90);
            this.txtbox_anneadi.Name = "txtbox_anneadi";
            this.txtbox_anneadi.Size = new System.Drawing.Size(206, 20);
            this.txtbox_anneadi.TabIndex = 4;
            this.txtbox_anneadi.TextChanged += new System.EventHandler(this.txtbox_anneadi_TextChanged);
            // 
            // txtbox_babaadi
            // 
            this.txtbox_babaadi.Location = new System.Drawing.Point(118, 116);
            this.txtbox_babaadi.Name = "txtbox_babaadi";
            this.txtbox_babaadi.Size = new System.Drawing.Size(206, 20);
            this.txtbox_babaadi.TabIndex = 5;
            // 
            // txtbox_telefonno
            // 
            this.txtbox_telefonno.Location = new System.Drawing.Point(118, 142);
            this.txtbox_telefonno.Name = "txtbox_telefonno";
            this.txtbox_telefonno.Size = new System.Drawing.Size(206, 20);
            this.txtbox_telefonno.TabIndex = 6;
            this.txtbox_telefonno.TextChanged += new System.EventHandler(this.txtbox_telefonno_TextChanged);
            // 
            // txtbox_gsm
            // 
            this.txtbox_gsm.Location = new System.Drawing.Point(118, 168);
            this.txtbox_gsm.Name = "txtbox_gsm";
            this.txtbox_gsm.Size = new System.Drawing.Size(206, 20);
            this.txtbox_gsm.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Unvanı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(426, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Adı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(409, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Soyadı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(415, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Maaş";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(384, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "İşe Başlama";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(378, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Doğum Tarihi";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(405, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Cinsiyet";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(526, 171);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Medeni Hali";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(390, 198);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Kan Grubu";
            // 
            // txtbox_ad
            // 
            this.txtbox_ad.Location = new System.Drawing.Point(454, 38);
            this.txtbox_ad.Name = "txtbox_ad";
            this.txtbox_ad.Size = new System.Drawing.Size(206, 20);
            this.txtbox_ad.TabIndex = 9;
            this.txtbox_ad.Tag = "";
            // 
            // txtbox_soyad
            // 
            this.txtbox_soyad.Location = new System.Drawing.Point(454, 64);
            this.txtbox_soyad.Name = "txtbox_soyad";
            this.txtbox_soyad.Size = new System.Drawing.Size(206, 20);
            this.txtbox_soyad.TabIndex = 10;
            // 
            // txtbox_maas
            // 
            this.txtbox_maas.Location = new System.Drawing.Point(454, 90);
            this.txtbox_maas.Name = "txtbox_maas";
            this.txtbox_maas.Size = new System.Drawing.Size(206, 20);
            this.txtbox_maas.TabIndex = 11;
            // 
            // dateTimePicker_dogumtarihi
            // 
            this.dateTimePicker_dogumtarihi.Location = new System.Drawing.Point(454, 142);
            this.dateTimePicker_dogumtarihi.Name = "dateTimePicker_dogumtarihi";
            this.dateTimePicker_dogumtarihi.Size = new System.Drawing.Size(206, 20);
            this.dateTimePicker_dogumtarihi.TabIndex = 13;
            // 
            // cmbbox_cinsiyet
            // 
            this.cmbbox_cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbox_cinsiyet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbbox_cinsiyet.FormattingEnabled = true;
            this.cmbbox_cinsiyet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbbox_cinsiyet.Location = new System.Drawing.Point(454, 168);
            this.cmbbox_cinsiyet.Name = "cmbbox_cinsiyet";
            this.cmbbox_cinsiyet.Size = new System.Drawing.Size(66, 21);
            this.cmbbox_cinsiyet.TabIndex = 14;
            // 
            // cmbbox_medenihal
            // 
            this.cmbbox_medenihal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbox_medenihal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbbox_medenihal.FormattingEnabled = true;
            this.cmbbox_medenihal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbbox_medenihal.Location = new System.Drawing.Point(594, 167);
            this.cmbbox_medenihal.Name = "cmbbox_medenihal";
            this.cmbbox_medenihal.Size = new System.Drawing.Size(66, 21);
            this.cmbbox_medenihal.TabIndex = 15;
            // 
            // cmbbox_kangrubu
            // 
            this.cmbbox_kangrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbox_kangrubu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbbox_kangrubu.FormattingEnabled = true;
            this.cmbbox_kangrubu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbbox_kangrubu.Location = new System.Drawing.Point(454, 195);
            this.cmbbox_kangrubu.Name = "cmbbox_kangrubu";
            this.cmbbox_kangrubu.Size = new System.Drawing.Size(66, 21);
            this.cmbbox_kangrubu.TabIndex = 16;
            // 
            // txtbox_adres
            // 
            this.txtbox_adres.Location = new System.Drawing.Point(154, 220);
            this.txtbox_adres.Multiline = true;
            this.txtbox_adres.Name = "txtbox_adres";
            this.txtbox_adres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbox_adres.Size = new System.Drawing.Size(506, 104);
            this.txtbox_adres.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(114, 265);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Adres";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbox_sifre);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtbox_kullaniciad);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(155, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 48);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // txtbox_sifre
            // 
            this.txtbox_sifre.Location = new System.Drawing.Point(325, 19);
            this.txtbox_sifre.Name = "txtbox_sifre";
            this.txtbox_sifre.Size = new System.Drawing.Size(175, 20);
            this.txtbox_sifre.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(291, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(28, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Şifre";
            // 
            // txtbox_kullaniciad
            // 
            this.txtbox_kullaniciad.Location = new System.Drawing.Point(81, 19);
            this.txtbox_kullaniciad.Name = "txtbox_kullaniciad";
            this.txtbox_kullaniciad.Size = new System.Drawing.Size(175, 20);
            this.txtbox_kullaniciad.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(11, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Kullanıcı Adı";
            // 
            // Kullanıcı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 453);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox_yetkili);
            this.Controls.Add(this.dateTimePicker_dogumtarihi);
            this.Controls.Add(this.dateTimePicker_isebaslama);
            this.Controls.Add(this.cmbbox_medenihal);
            this.Controls.Add(this.cmbbox_kangrubu);
            this.Controls.Add(this.cmbbox_cinsiyet);
            this.Controls.Add(this.cmbbox_unvan);
            this.Controls.Add(this.txtbox_maas);
            this.Controls.Add(this.txtbox_soyad);
            this.Controls.Add(this.txtbox_ad);
            this.Controls.Add(this.txtbox_adres);
            this.Controls.Add(this.txtbox_gsm);
            this.Controls.Add(this.txtbox_telefonno);
            this.Controls.Add(this.txtbox_babaadi);
            this.Controls.Add(this.txtbox_anneadi);
            this.Controls.Add(this.txtbox_dogumyeri);
            this.Controls.Add(this.txtbox_kimlikno);
            this.Controls.Add(this.txtbox_kullanicikodu);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Kullanıcı";
            this.Text = "Kullanıcı";
            this.Load += new System.EventHandler(this.Kullanıcı_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_kullanicikodu;
        private System.Windows.Forms.ComboBox cmbbox_unvan;
        private System.Windows.Forms.DateTimePicker dateTimePicker_isebaslama;
        private System.Windows.Forms.CheckBox checkBox_yetkili;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbox_kimlikno;
        private System.Windows.Forms.TextBox txtbox_dogumyeri;
        private System.Windows.Forms.TextBox txtbox_anneadi;
        private System.Windows.Forms.TextBox txtbox_babaadi;
        private System.Windows.Forms.TextBox txtbox_telefonno;
        private System.Windows.Forms.TextBox txtbox_gsm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtbox_ad;
        private System.Windows.Forms.TextBox txtbox_soyad;
        private System.Windows.Forms.TextBox txtbox_maas;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dogumtarihi;
        private System.Windows.Forms.ComboBox cmbbox_cinsiyet;
        private System.Windows.Forms.ComboBox cmbbox_medenihal;
        private System.Windows.Forms.ComboBox cmbbox_kangrubu;
        private System.Windows.Forms.TextBox txtbox_adres;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_Cikis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbox_sifre;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtbox_kullaniciad;
        private System.Windows.Forms.Label label18;
    }
}