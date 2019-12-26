namespace SOHATS
{
    partial class Taburcu
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
            this.txtbox_dosyano = new System.Windows.Forms.TextBox();
            this.cmbbox_odemesekli = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_cikis = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_sevk = new System.Windows.Forms.DateTimePicker();
            this.txtbox_toplamtutar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbox_dosyano
            // 
            this.txtbox_dosyano.Enabled = false;
            this.txtbox_dosyano.Location = new System.Drawing.Point(94, 11);
            this.txtbox_dosyano.Multiline = true;
            this.txtbox_dosyano.Name = "txtbox_dosyano";
            this.txtbox_dosyano.Size = new System.Drawing.Size(163, 21);
            this.txtbox_dosyano.TabIndex = 0;
            this.txtbox_dosyano.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbbox_odemesekli
            // 
            this.cmbbox_odemesekli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbox_odemesekli.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbbox_odemesekli.FormattingEnabled = true;
            this.cmbbox_odemesekli.Location = new System.Drawing.Point(94, 90);
            this.cmbbox_odemesekli.Name = "cmbbox_odemesekli";
            this.cmbbox_odemesekli.Size = new System.Drawing.Size(163, 21);
            this.cmbbox_odemesekli.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dosya No :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Vazgeç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_cikis);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker_sevk);
            this.groupBox1.Controls.Add(this.txtbox_dosyano);
            this.groupBox1.Controls.Add(this.txtbox_toplamtutar);
            this.groupBox1.Controls.Add(this.cmbbox_odemesekli);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 145);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker_cikis
            // 
            this.dateTimePicker_cikis.Enabled = false;
            this.dateTimePicker_cikis.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_cikis.Location = new System.Drawing.Point(94, 64);
            this.dateTimePicker_cikis.Name = "dateTimePicker_cikis";
            this.dateTimePicker_cikis.Size = new System.Drawing.Size(163, 20);
            this.dateTimePicker_cikis.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Toplam Tutar :";
            // 
            // dateTimePicker_sevk
            // 
            this.dateTimePicker_sevk.Enabled = false;
            this.dateTimePicker_sevk.Location = new System.Drawing.Point(94, 38);
            this.dateTimePicker_sevk.Name = "dateTimePicker_sevk";
            this.dateTimePicker_sevk.Size = new System.Drawing.Size(163, 20);
            this.dateTimePicker_sevk.TabIndex = 5;
            this.dateTimePicker_sevk.ValueChanged += new System.EventHandler(this.dateTimePicker_sevk_ValueChanged);
            // 
            // txtbox_toplamtutar
            // 
            this.txtbox_toplamtutar.Enabled = false;
            this.txtbox_toplamtutar.Location = new System.Drawing.Point(94, 117);
            this.txtbox_toplamtutar.Multiline = true;
            this.txtbox_toplamtutar.Name = "txtbox_toplamtutar";
            this.txtbox_toplamtutar.Size = new System.Drawing.Size(163, 21);
            this.txtbox_toplamtutar.TabIndex = 0;
            this.txtbox_toplamtutar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ödeme Şekli :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sevk Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Çıkış Saati :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Taburcu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 189);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Taburcu";
            this.Text = "Taburcu";
            this.Load += new System.EventHandler(this.Taburcu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_dosyano;
        private System.Windows.Forms.ComboBox cmbbox_odemesekli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_sevk;
        private System.Windows.Forms.TextBox txtbox_toplamtutar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_cikis;
    }
}