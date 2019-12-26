namespace SOHATS
{
    partial class Login
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
            this.txtBox_kullanici = new System.Windows.Forms.TextBox();
            this.txtbox_sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_giris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_kullanici
            // 
            this.txtBox_kullanici.Location = new System.Drawing.Point(88, 6);
            this.txtBox_kullanici.Name = "txtBox_kullanici";
            this.txtBox_kullanici.Size = new System.Drawing.Size(197, 20);
            this.txtBox_kullanici.TabIndex = 1;
            this.txtBox_kullanici.KeyDown += new System.Windows.Forms.KeyEventHandler(this.giris_btn_cagir_click);
            // 
            // txtbox_sifre
            // 
            this.txtbox_sifre.Location = new System.Drawing.Point(88, 32);
            this.txtbox_sifre.Name = "txtbox_sifre";
            this.txtbox_sifre.PasswordChar = '*';
            this.txtbox_sifre.Size = new System.Drawing.Size(197, 20);
            this.txtbox_sifre.TabIndex = 2;
            this.txtbox_sifre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.giris_btn_cagir_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(7, 60);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(75, 45);
            this.btn_giris.TabIndex = 3;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(88, 60);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(75, 45);
            this.btn_temizle.TabIndex = 4;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cikis.Location = new System.Drawing.Point(210, 60);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(75, 45);
            this.btn_cikis.TabIndex = 5;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(297, 117);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_sifre);
            this.Controls.Add(this.txtBox_kullanici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_kullanici;
        private System.Windows.Forms.TextBox txtbox_sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_cikis;
    }
}