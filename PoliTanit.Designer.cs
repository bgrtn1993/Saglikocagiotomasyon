namespace SOHATS
{
    partial class PoliTanit
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
            this.cmbbox_poliklinikad = new System.Windows.Forms.ComboBox();
            this.checkBox_polidurum = new System.Windows.Forms.CheckBox();
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
            // cmbbox_poliklinikad
            // 
            this.cmbbox_poliklinikad.FormattingEnabled = true;
            this.cmbbox_poliklinikad.Location = new System.Drawing.Point(84, 6);
            this.cmbbox_poliklinikad.Name = "cmbbox_poliklinikad";
            this.cmbbox_poliklinikad.Size = new System.Drawing.Size(121, 21);
            this.cmbbox_poliklinikad.TabIndex = 1;
            this.cmbbox_poliklinikad.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbbox_poliklinikad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbbox_poliklinikad_KeyDown);
            // 
            // checkBox_polidurum
            // 
            this.checkBox_polidurum.AutoSize = true;
            this.checkBox_polidurum.Location = new System.Drawing.Point(84, 34);
            this.checkBox_polidurum.Name = "checkBox_polidurum";
            this.checkBox_polidurum.Size = new System.Drawing.Size(111, 17);
            this.checkBox_polidurum.TabIndex = 2;
            this.checkBox_polidurum.Text = "Geçerli / Geçersiz";
            this.checkBox_polidurum.UseVisualStyleBackColor = true;
            // 
            // PoliTanit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 63);
            this.Controls.Add(this.checkBox_polidurum);
            this.Controls.Add(this.cmbbox_poliklinikad);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "PoliTanit";
            this.Text = "Poliklinik Tanıtma";
            this.Load += new System.EventHandler(this.PoliTanit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbox_poliklinikad;
        private System.Windows.Forms.CheckBox checkBox_polidurum;
    }
}