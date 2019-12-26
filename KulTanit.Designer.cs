namespace SOHATS
{
    partial class KulTanit
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
            this.cmbbox_kullanicilar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kullanici_ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbbox_kullanicilar
            // 
            this.cmbbox_kullanicilar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbox_kullanicilar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbbox_kullanicilar.FormattingEnabled = true;
            this.cmbbox_kullanicilar.Location = new System.Drawing.Point(92, 6);
            this.cmbbox_kullanicilar.Name = "cmbbox_kullanicilar";
            this.cmbbox_kullanicilar.Size = new System.Drawing.Size(121, 21);
            this.cmbbox_kullanicilar.TabIndex = 1;
            this.cmbbox_kullanicilar.SelectedIndexChanged += new System.EventHandler(this.cmbbox_kullanicilar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Kodu";
            // 
            // btn_kullanici_ekle
            // 
            this.btn_kullanici_ekle.Location = new System.Drawing.Point(44, 33);
            this.btn_kullanici_ekle.Name = "btn_kullanici_ekle";
            this.btn_kullanici_ekle.Size = new System.Drawing.Size(143, 23);
            this.btn_kullanici_ekle.TabIndex = 2;
            this.btn_kullanici_ekle.Text = "Yeni Kullanıcı Ekle";
            this.btn_kullanici_ekle.UseVisualStyleBackColor = true;
            this.btn_kullanici_ekle.Click += new System.EventHandler(this.btn_kullanici_ekle_Click);
            // 
            // KulTanit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 63);
            this.Controls.Add(this.btn_kullanici_ekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbbox_kullanicilar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "KulTanit";
            this.Text = "SOHATS - Kullanıcı Tanıtma";
            this.Load += new System.EventHandler(this.KulTanit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbbox_kullanicilar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kullanici_ekle;
    }
}