namespace SOHATS
{
    partial class Rapor
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
            this.txtbox_dosyano = new System.Windows.Forms.TextBox();
            this.dateTimePicker_gun = new System.Windows.Forms.DateTimePicker();
            this.cmbbox_cinsiyet = new System.Windows.Forms.ComboBox();
            this.btn_yeni = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtbox_ad = new System.Windows.Forms.TextBox();
            this.txtbox_tckimlik = new System.Windows.Forms.TextBox();
            this.txtbox_soyadi = new System.Windows.Forms.TextBox();
            this.txtbox_dogumyeri = new System.Windows.Forms.TextBox();
            this.cmbbox_kangrubu = new System.Windows.Forms.ComboBox();
            this.cmbbox_medenihal = new System.Windows.Forms.ComboBox();
            this.txtbox_babaadi = new System.Windows.Forms.TextBox();
            this.txtbox_anneadı = new System.Windows.Forms.TextBox();
            this.txtbox_adres = new System.Windows.Forms.TextBox();
            this.txtbox_telefonno = new System.Windows.Forms.TextBox();
            this.txtbox_kurumsicilno = new System.Windows.Forms.TextBox();
            this.txtbox_kurumad = new System.Windows.Forms.TextBox();
            this.txtbox_yakintel = new System.Windows.Forms.TextBox();
            this.txtbox_yakinsicil = new System.Windows.Forms.TextBox();
            this.txtbox_ykurumad = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dosya No";
            // 
            // txtbox_dosyano
            // 
            this.txtbox_dosyano.Enabled = false;
            this.txtbox_dosyano.Location = new System.Drawing.Point(101, 12);
            this.txtbox_dosyano.MaxLength = 10;
            this.txtbox_dosyano.Name = "txtbox_dosyano";
            this.txtbox_dosyano.Size = new System.Drawing.Size(174, 20);
            this.txtbox_dosyano.TabIndex = 1;
            this.txtbox_dosyano.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker_gun
            // 
            this.dateTimePicker_gun.Location = new System.Drawing.Point(380, 86);
            this.dateTimePicker_gun.Name = "dateTimePicker_gun";
            this.dateTimePicker_gun.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_gun.TabIndex = 8;
            // 
            // cmbbox_cinsiyet
            // 
            this.cmbbox_cinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbox_cinsiyet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbbox_cinsiyet.FormattingEnabled = true;
            this.cmbbox_cinsiyet.Location = new System.Drawing.Point(380, 114);
            this.cmbbox_cinsiyet.Name = "cmbbox_cinsiyet";
            this.cmbbox_cinsiyet.Size = new System.Drawing.Size(53, 21);
            this.cmbbox_cinsiyet.TabIndex = 9;
            // 
            // btn_yeni
            // 
            this.btn_yeni.Location = new System.Drawing.Point(9, 19);
            this.btn_yeni.Name = "btn_yeni";
            this.btn_yeni.Size = new System.Drawing.Size(75, 36);
            this.btn_yeni.TabIndex = 19;
            this.btn_yeni.Text = "Yeni";
            this.btn_yeni.UseVisualStyleBackColor = true;
            this.btn_yeni.Click += new System.EventHandler(this.btn_yeni_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cikis);
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Controls.Add(this.btn_yeni);
            this.groupBox1.Location = new System.Drawing.Point(12, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 72);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(493, 19);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(75, 36);
            this.btn_cikis.TabIndex = 21;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(90, 19);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 36);
            this.btn_kaydet.TabIndex = 20;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Doğum Yeri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Baba Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Anne Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Adres";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "T.C. Kimlik Numarası";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Soyadı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Doğum Tarihi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cinsiyet";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(316, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Kan Grubu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(439, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Medeni Hali";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Telefon No";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 271);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Kurum Sicil No";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(41, 297);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Kurum Adı";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(294, 245);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Yakınının Telefon No";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(324, 271);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Kurum Sicil No";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(332, 297);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Y. Kurum Adı";
            // 
            // txtbox_ad
            // 
            this.txtbox_ad.Location = new System.Drawing.Point(101, 38);
            this.txtbox_ad.MaxLength = 15;
            this.txtbox_ad.Name = "txtbox_ad";
            this.txtbox_ad.Size = new System.Drawing.Size(174, 20);
            this.txtbox_ad.TabIndex = 3;
            this.txtbox_ad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbox_tckimlik
            // 
            this.txtbox_tckimlik.Location = new System.Drawing.Point(406, 12);
            this.txtbox_tckimlik.MaxLength = 10;
            this.txtbox_tckimlik.Name = "txtbox_tckimlik";
            this.txtbox_tckimlik.Size = new System.Drawing.Size(174, 20);
            this.txtbox_tckimlik.TabIndex = 2;
            this.txtbox_tckimlik.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbox_soyadi
            // 
            this.txtbox_soyadi.Location = new System.Drawing.Point(406, 38);
            this.txtbox_soyadi.MaxLength = 15;
            this.txtbox_soyadi.Name = "txtbox_soyadi";
            this.txtbox_soyadi.Size = new System.Drawing.Size(174, 20);
            this.txtbox_soyadi.TabIndex = 4;
            this.txtbox_soyadi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbox_dogumyeri
            // 
            this.txtbox_dogumyeri.Location = new System.Drawing.Point(101, 86);
            this.txtbox_dogumyeri.MaxLength = 15;
            this.txtbox_dogumyeri.Name = "txtbox_dogumyeri";
            this.txtbox_dogumyeri.Size = new System.Drawing.Size(174, 20);
            this.txtbox_dogumyeri.TabIndex = 5;
            this.txtbox_dogumyeri.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbbox_kangrubu
            // 
            this.cmbbox_kangrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbox_kangrubu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbbox_kangrubu.FormattingEnabled = true;
            this.cmbbox_kangrubu.Location = new System.Drawing.Point(380, 141);
            this.cmbbox_kangrubu.Name = "cmbbox_kangrubu";
            this.cmbbox_kangrubu.Size = new System.Drawing.Size(53, 21);
            this.cmbbox_kangrubu.TabIndex = 10;
            // 
            // cmbbox_medenihal
            // 
            this.cmbbox_medenihal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbox_medenihal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbbox_medenihal.FormattingEnabled = true;
            this.cmbbox_medenihal.Location = new System.Drawing.Point(504, 128);
            this.cmbbox_medenihal.Name = "cmbbox_medenihal";
            this.cmbbox_medenihal.Size = new System.Drawing.Size(76, 21);
            this.cmbbox_medenihal.TabIndex = 11;
            // 
            // txtbox_babaadi
            // 
            this.txtbox_babaadi.Location = new System.Drawing.Point(101, 112);
            this.txtbox_babaadi.Name = "txtbox_babaadi";
            this.txtbox_babaadi.Size = new System.Drawing.Size(174, 20);
            this.txtbox_babaadi.TabIndex = 6;
            this.txtbox_babaadi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbox_anneadı
            // 
            this.txtbox_anneadı.Location = new System.Drawing.Point(101, 138);
            this.txtbox_anneadı.Name = "txtbox_anneadı";
            this.txtbox_anneadı.Size = new System.Drawing.Size(174, 20);
            this.txtbox_anneadı.TabIndex = 7;
            this.txtbox_anneadı.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbox_adres
            // 
            this.txtbox_adres.Location = new System.Drawing.Point(101, 164);
            this.txtbox_adres.Multiline = true;
            this.txtbox_adres.Name = "txtbox_adres";
            this.txtbox_adres.Size = new System.Drawing.Size(479, 72);
            this.txtbox_adres.TabIndex = 12;
            this.txtbox_adres.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbox_telefonno
            // 
            this.txtbox_telefonno.Location = new System.Drawing.Point(101, 242);
            this.txtbox_telefonno.Name = "txtbox_telefonno";
            this.txtbox_telefonno.Size = new System.Drawing.Size(174, 20);
            this.txtbox_telefonno.TabIndex = 13;
            this.txtbox_telefonno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbox_kurumsicilno
            // 
            this.txtbox_kurumsicilno.Location = new System.Drawing.Point(101, 268);
            this.txtbox_kurumsicilno.Name = "txtbox_kurumsicilno";
            this.txtbox_kurumsicilno.Size = new System.Drawing.Size(174, 20);
            this.txtbox_kurumsicilno.TabIndex = 14;
            this.txtbox_kurumsicilno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbox_kurumad
            // 
            this.txtbox_kurumad.Location = new System.Drawing.Point(101, 294);
            this.txtbox_kurumad.Name = "txtbox_kurumad";
            this.txtbox_kurumad.Size = new System.Drawing.Size(174, 20);
            this.txtbox_kurumad.TabIndex = 15;
            this.txtbox_kurumad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbox_yakintel
            // 
            this.txtbox_yakintel.Location = new System.Drawing.Point(406, 242);
            this.txtbox_yakintel.Name = "txtbox_yakintel";
            this.txtbox_yakintel.Size = new System.Drawing.Size(174, 20);
            this.txtbox_yakintel.TabIndex = 16;
            this.txtbox_yakintel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbox_yakinsicil
            // 
            this.txtbox_yakinsicil.Location = new System.Drawing.Point(406, 268);
            this.txtbox_yakinsicil.Name = "txtbox_yakinsicil";
            this.txtbox_yakinsicil.Size = new System.Drawing.Size(174, 20);
            this.txtbox_yakinsicil.TabIndex = 17;
            this.txtbox_yakinsicil.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbox_ykurumad
            // 
            this.txtbox_ykurumad.Location = new System.Drawing.Point(406, 294);
            this.txtbox_ykurumad.Name = "txtbox_ykurumad";
            this.txtbox_ykurumad.Size = new System.Drawing.Size(174, 20);
            this.txtbox_ykurumad.TabIndex = 18;
            this.txtbox_ykurumad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 396);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbbox_medenihal);
            this.Controls.Add(this.cmbbox_kangrubu);
            this.Controls.Add(this.cmbbox_cinsiyet);
            this.Controls.Add(this.dateTimePicker_gun);
            this.Controls.Add(this.txtbox_adres);
            this.Controls.Add(this.txtbox_ykurumad);
            this.Controls.Add(this.txtbox_kurumad);
            this.Controls.Add(this.txtbox_yakinsicil);
            this.Controls.Add(this.txtbox_kurumsicilno);
            this.Controls.Add(this.txtbox_yakintel);
            this.Controls.Add(this.txtbox_telefonno);
            this.Controls.Add(this.txtbox_anneadı);
            this.Controls.Add(this.txtbox_babaadi);
            this.Controls.Add(this.txtbox_dogumyeri);
            this.Controls.Add(this.txtbox_ad);
            this.Controls.Add(this.txtbox_soyadi);
            this.Controls.Add(this.txtbox_tckimlik);
            this.Controls.Add(this.txtbox_dosyano);
            this.Controls.Add(this.label18);
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
            this.Name = "Rapor";
            this.Text = "< Hasta Bilgileri >";
            this.Load += new System.EventHandler(this.Rapor_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_gun;
        private System.Windows.Forms.ComboBox cmbbox_cinsiyet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtbox_ad;
        private System.Windows.Forms.TextBox txtbox_soyadi;
        private System.Windows.Forms.TextBox txtbox_dogumyeri;
        private System.Windows.Forms.ComboBox cmbbox_kangrubu;
        private System.Windows.Forms.ComboBox cmbbox_medenihal;
        private System.Windows.Forms.TextBox txtbox_babaadi;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.TextBox txtbox_anneadı;
        private System.Windows.Forms.TextBox txtbox_adres;
        private System.Windows.Forms.TextBox txtbox_telefonno;
        private System.Windows.Forms.TextBox txtbox_kurumsicilno;
        private System.Windows.Forms.TextBox txtbox_kurumad;
        private System.Windows.Forms.TextBox txtbox_yakintel;
        private System.Windows.Forms.TextBox txtbox_yakinsicil;
        private System.Windows.Forms.TextBox txtbox_ykurumad;
        public System.Windows.Forms.Button btn_kaydet;
        public System.Windows.Forms.TextBox txtbox_dosyano;
        public System.Windows.Forms.Button btn_yeni;
        public System.Windows.Forms.TextBox txtbox_tckimlik;
    }
}