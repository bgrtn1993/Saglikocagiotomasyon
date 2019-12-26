namespace SOHATS
{
    partial class Poliklinik
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
            this.txtbox_polinikad = new System.Windows.Forms.TextBox();
            this.checkBox_gecerli = new System.Windows.Forms.CheckBox();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_aciklama = new System.Windows.Forms.TextBox();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poliklinik Adı";
            // 
            // txtbox_polinikad
            // 
            this.txtbox_polinikad.Location = new System.Drawing.Point(84, 6);
            this.txtbox_polinikad.Name = "txtbox_polinikad";
            this.txtbox_polinikad.Size = new System.Drawing.Size(208, 20);
            this.txtbox_polinikad.TabIndex = 1;
            // 
            // checkBox_gecerli
            // 
            this.checkBox_gecerli.AutoSize = true;
            this.checkBox_gecerli.Location = new System.Drawing.Point(84, 32);
            this.checkBox_gecerli.Name = "checkBox_gecerli";
            this.checkBox_gecerli.Size = new System.Drawing.Size(111, 17);
            this.checkBox_gecerli.TabIndex = 2;
            this.checkBox_gecerli.Text = "Geçerli / Geçersiz";
            this.checkBox_gecerli.UseVisualStyleBackColor = true;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(15, 237);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(72, 39);
            this.btn_guncelle.TabIndex = 3;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Açıklama";
            // 
            // txtbox_aciklama
            // 
            this.txtbox_aciklama.Location = new System.Drawing.Point(15, 100);
            this.txtbox_aciklama.Multiline = true;
            this.txtbox_aciklama.Name = "txtbox_aciklama";
            this.txtbox_aciklama.Size = new System.Drawing.Size(277, 131);
            this.txtbox_aciklama.TabIndex = 1;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(93, 237);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(72, 39);
            this.btn_sil.TabIndex = 3;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(220, 237);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(72, 39);
            this.btn_cikis.TabIndex = 3;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // Poliklinik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 291);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.checkBox_gecerli);
            this.Controls.Add(this.txtbox_aciklama);
            this.Controls.Add(this.txtbox_polinikad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Poliklinik";
            this.Text = "Poliklinik";
            this.Load += new System.EventHandler(this.Poliklinik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_polinikad;
        private System.Windows.Forms.CheckBox checkBox_gecerli;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_aciklama;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_cikis;
    }
}