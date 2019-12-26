using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;

namespace SOHATS
{
    public partial class HastaProces : Form
    {
        SqlCommand cmd;
        SqlDataReader sdr;
        public int raporsay = 0;
        public string dosyano = "";
        public int toplamtutar = 0;
        public int ttoplam = 0;
        public string tsaat = "";
        public string ttarih = "";
        public HastaProces()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private string[] xmloku()
        {
            string[] db = new string[3];
            XmlTextReader oku = new XmlTextReader("app.xml");
            while (oku.Read())
            {
                if (oku.NodeType == XmlNodeType.Element)
                {
                    if (oku.Name == "server")
                    {
                        db[0] = oku.ReadString();

                    }
                    if (oku.Name == "ISecurity")
                    {
                        db[1] = oku.ReadString();

                    }
                    if (oku.Name == "database")
                    {
                        db[2] = oku.ReadString();
                    }
                }

            }
            oku.Close();
            return db;
        }
        public string dosyanoduzelt(string dosyano)
        {
            for (int i = 0; i < 5; i++)
            {
                if (dosyano.Length<5)
                {
                    dosyano = "0" + dosyano;
                }
            }


            return dosyano;
        }
        private void button_dosyabul_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            if (txtbox_dosyabul.Text=="")
            {
                DosyaBul dob = new DosyaBul();
                dob.MdiParent = HastaIslem.ActiveForm;
                dob.StartPosition = FormStartPosition.CenterScreen;
                dob.Show();
            }
            else
            {
                btn_hastabilgileri.Enabled = true;
                if (txtbox_dosyabul.Text == "" || txtbox_dosyabul.Text.Length == 0)
                {
                    MessageBox.Show("Lütfen dosya numarası giriniz...");
                }
                else
                {
                    txtbox_dosyabul.Text = dosyanoduzelt(txtbox_dosyabul.Text);
                    string[] db = new string[3];
                    db = xmloku();
                    SqlConnection con = new SqlConnection("server=" + db[0] + ";Integrated Security=" + db[1] + ";database=" + db[2]);
                    cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM hasta where dosyano='" + txtbox_dosyabul.Text + "'";
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {

                        txtbox_hastaadi.Text = sdr["ad"].ToString();
                        txtbox_hastasoyadi.Text = sdr["soyad"].ToString();
                        txtbox_hastakurumadi.Text = sdr["kurumadı"].ToString();

                    }
                    sdr.Close();
                    cmd.CommandText = "SELECT * FROM sevk where dosyano='" + txtbox_dosyabul.Text + "'";
                    sdr = cmd.ExecuteReader();
                    comboBox1.Items.Clear();
                    comboBox1.Text = "";
                    while (sdr.Read())
                    {
                        int count = 0;
                        if (comboBox1.Items.Count == 0)
                        {
                            comboBox1.Items.Add(sdr["sevktarihi"].ToString());
                        }
                        for (int i = 0; i < comboBox1.Items.Count; i++)
                        {
                            if (comboBox1.Items[i].ToString() == sdr["sevktarihi"].ToString())
                            {
                                count++;
                            }
                        }
                        if (count == 0)
                        {
                            comboBox1.Items.Add(sdr["sevktarihi"].ToString());
                        }
                    }
                }
            }
            
        }
        private void comboboxdodur()
        {
            string[] db = xmloku();
            SqlConnection con = new SqlConnection("server=" + db[0] + ";Integrated Security=" + db[1] + ";database=" + db[2]);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from poliklinik ";
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                cmbbox_poliklinik.Items.Add(sdr["poliklinikadi"].ToString());
            }
            sdr.Close();
            cmd.CommandText = "select * from islem";
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                cmbbox_yapilanislem.Items.Add(sdr["islemAdi"].ToString());
            }
            cmbbox_yapilanislem.SelectedIndex = 0;
            sdr.Close();
            cmd.CommandText = "select * from sevk";
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                cmbbox_drkodu.Items.Add(sdr["drkod"].ToString());
            }
            con.Close();
        }
        private void HastaProces_Load(object sender, EventArgs e)
        {
            comboboxdodur();
        }
        private void refresh()
        {
            string[] db = xmloku();
            string connectstring = "server=" + db[0] + ";Integrated Security=" + db[1] + ";database=" + db[2];
            string sql = "SELECT * FROM sevk WHERE sevktarihi='" + comboBox1.Text + "' and dosyano='"+txtbox_dosyabul.Text+"'";
            SqlConnection con = new SqlConnection(connectstring);
            con.Open();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;
            cmd2.CommandText = sql;
            sdr = cmd2.ExecuteReader();
            while (sdr.Read())
            {
                if (sdr["taburcu"].ToString() == "True")
                {
                    MessageBox.Show("Hasta bu sevkten Taburcu edilmiş");
                }
            }
            sdr.Close();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter sqladap = new SqlDataAdapter(cmd);
            DataSet sDs = new DataSet();
            sqladap.Fill(sDs, "dosyano");
            DataTable dTable = sDs.Tables["dosyano"];
            if (sDs.Tables["dosyano"].ToString() == "True")
            {
                MessageBox.Show("Hasta bu sevkten Taburcu edilmiş");
            }
            con.Close();
            dataGridView1.DataSource = sDs.Tables["dosyano"];
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void btn_git_Click(object sender, EventArgs e)
        {
            refresh();
            int toplamtutar = 0;
            string birinci = "";
            string ikinci = "";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i!= dataGridView1.Rows.Count-1)
                {
                    if (dataGridView1.Rows[i].Cells[10].Value.ToString() != "True")
                    {
                        birinci = dataGridView1.Rows[i].Cells[6].Value.ToString();
                        ikinci = dataGridView1.Rows[i].Cells[7].Value.ToString();
                        toplamtutar += Convert.ToInt32(birinci) * Convert.ToInt32(ikinci);
                    }
                }
            }
            lbl_toplamtutar.Text = toplamtutar + " YTL";
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbox_dosyabul.Text.Length!=0 && txtbox_sirano.Text.Length!=0 && cmbbox_poliklinik.Text.Length!=0 &&  cmbbox_drkodu.Text.Length!=0)
                {
                    string[] db = xmloku();
                    string sqlkod = "server=" + db[0] + "; Integrated Security=" + db[1] + "; database=" + db[2];
                    SqlConnection baglanti = new SqlConnection(sqlkod);
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    string kayıt = "INSERT INTO sevk(sevktarihi,dosyano,poliklinik,saat,yapilanislem,drkod,miktar,birimFiyat,sira,toplamtutar,taburcu) " +
                                            "values(@sevktarihi,@dosyano,@poliklinik,@saat,@yapilanislem,@drkod,@miktar,@birimFiyat,@sira,@toplamtutar,@taburcu)";
                    cmd = new SqlCommand(kayıt, baglanti);
                    cmd.Parameters.AddWithValue("@sevktarihi", dateTimePicker1.Value.Day.ToString() + "." + dateTimePicker1.Value.Month.ToString() + "." + dateTimePicker1.Value.Year.ToString());
                    cmd.Parameters.AddWithValue("@dosyano", txtbox_dosyabul.Text);
                    cmd.Parameters.AddWithValue("@poliklinik", cmbbox_poliklinik.Text);
                    cmd.Parameters.AddWithValue("@saat", dateTimePicker1.Value.Hour.ToString() + ":" + dateTimePicker1.Value.Minute.ToString());
                    cmd.Parameters.AddWithValue("@yapilanislem", cmbbox_yapilanislem.Text);
                    cmd.Parameters.AddWithValue("@drkod", cmbbox_drkodu.Text);
                    cmd.Parameters.AddWithValue("@miktar", Convert.ToChar(numericUpDown_miktar.Value.ToString()));
                    cmd.Parameters.AddWithValue("@birimFiyat", txtbox_birimfiyat.Text);
                    cmd.Parameters.AddWithValue("@sira", txtbox_sirano.Text);
                    cmd.Parameters.AddWithValue("@toplamtutar", (int.Parse(numericUpDown_miktar.Value.ToString()) * int.Parse(txtbox_birimfiyat.Text)).ToString());
                    cmd.Parameters.AddWithValue("@taburcu", "False");
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    if (dataGridView1.Rows != null)
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            if (dataGridView1.Rows[i].Cells[10].Value.ToString() != "True")
                            {
                                toplamtutar += int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()) * int.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                            }
                        }
                    }
                    if (txtbox_dosyabul.Text.Length != 0)
                    {
                        button_dosyabul_Click(this, new EventArgs());
                    }
                    comboBox1.Text = comboBox1.Items[0].ToString();
                    refresh();



                    lbl_toplamtutar.Text = toplamtutar + " YTL";
                    MessageBox.Show("İşlem eklendi...");
                }
                else
                {
                    MessageBox.Show("Gerekli alanları eksik");
                }
                
            }
            catch (Exception )
            {

                MessageBox.Show("Gerekli alanları doldurunuz...");
            }
            
        }

        private void btn_yeni_Click(object sender, EventArgs e)
        {
            raporsay=2;
            Rapor rpr = new Rapor();
            rpr.btn_kaydet.Enabled = false;
            rpr.Show();
        }
        private void btn_hastabilgileri_Click(object sender, EventArgs e)
        {

            raporsay = 1;
            dosyano = txtbox_dosyabul.Text;
            Rapor rpr = new Rapor();
            rpr.MdiParent = HastaIslem.ActiveForm;
            rpr.StartPosition = FormStartPosition.CenterScreen;
            rpr.txtbox_tckimlik.Enabled = false;
            rpr.btn_yeni.Enabled = false;
            rpr.Show();
            rpr = (Rapor)Application.OpenForms["Rapor"];
            if (rpr.txtbox_dosyano.Text=="")
            {
                MessageBox.Show("Böyle bir dosya numarası bulunmamaktadır...");
                rpr.Close();
            }
        }
        private void txtbox_dosyabul_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)Keys.Enter)
            {
                
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows != null)
                {
                    if (dataGridView1.SelectedRows[0].Cells[10].Value.ToString() == "False")
                    {
                        tsaat = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        ttarih = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        ttoplam = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[9].Value);
                        dosyano = txtbox_dosyabul.Text;
                        Taburcu tbr = new Taburcu();

                        tbr.MdiParent = HastaIslem.ActiveForm;
                        tbr.StartPosition = FormStartPosition.CenterScreen;
                        dataGridView1.Columns.Clear();
                        tbr.Show();
                    }
                    else
                    {
                        MessageBox.Show("Bu işlem tamamlandı. Lütfen başka bir işlem seçiniz...");
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen bir satır seçiniz...");
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Gerekli işlemi yapınız...");
            }
            
        }
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string[] db = xmloku();
                string saat = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string sqlkod = "server=" + db[0] + "; Integrated Security=" + db[1] + ";database=" + db[2];
                SqlConnection baglanti = new SqlConnection(sqlkod);
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                string kayıt = "delete  from sevk where dosyano='" + dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + "'" + "and sevktarihi='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "' and saat='" + saat + "' and poliklinik='" + dataGridView1.SelectedRows[0].Cells[2].Value.ToString() + "'";
                cmd = new SqlCommand(kayıt, baglanti);
                cmd.ExecuteNonQuery();
                SqlDataReader sdr = cmd.ExecuteReader();
                int count = 0;
                while (sdr.Read())
                {
                    count++;
                }
                if (count == 0)
                {
                    comboBox1.Text = "";
                    comboBox1.Items.Clear();
                }
                if (txtbox_dosyabul.Text.Length != 0)
                {
                    button_dosyabul_Click(this, new EventArgs());
                }
                if (comboBox1.Text.Length != 0)
                {
                    comboBox1.Text = comboBox1.Items[0].ToString();
                }
                refresh();
                if (dataGridView1.Rows == null)
                {
                    lbl_toplamtutar.Text = "YTL";
                }
                MessageBox.Show("İşlem silindi...");
            }
            catch (Exception )
            {
                MessageBox.Show("Gerekli işlemi yapınız...");
            }
            
        }
        private void cmbbox_yapilanislem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] db = xmloku();
            SqlConnection con = new SqlConnection("server=" + db[0] + "; Integrated Security=" + db[1] + "; database=" + db[2]);
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from islem where islemAdi='"+cmbbox_yapilanislem.Text+"'";
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                txtbox_birimfiyat.Text = sdr["birimFiyat"].ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
            pdYazici.Print();
            }
            catch (Exception)
            {

                MessageBox.Show("Kritik durum oluştu...");
            }
        }
        
        private void btn_baslionizleme_Click(object sender, EventArgs e)
        {
            ppdDiyalog.ShowDialog();

        }
        Font baslik = new Font("Times New Roman", 20, FontStyle.Bold);
        Font govde = new Font("Verdana", 10,FontStyle.Bold);
        SolidBrush sb = new SolidBrush(Color.Black);

        private void pdYazici_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                StringFormat sFormat = new StringFormat();
                sFormat.Alignment = StringAlignment.Far;
                tsaat = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                string POLİKLİNİK = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string SIRANO = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                string SAAT = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string YAPILANISLEM = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string DRKODU = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                string MİKTAR = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                string BirimFiyat = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                e.Graphics.DrawString("Hasta Sevk İşlemleri :" + txtbox_hastaadi.Text + " " + txtbox_hastasoyadi.Text, baslik, sb, 150, 200);
                e.Graphics.DrawString("POLİKLİNİK | SIRA NO | SAAT | YAPILAN İŞLEM | DR.KODU | MİKTAR | BİRİM FİYATI", govde, sb, 120, 240);
                e.Graphics.DrawString(POLİKLİNİK + "         " + SIRANO + "           " + SAAT + "          " + YAPILANISLEM + "                 " + DRKODU + "      " + MİKTAR + "              " + BirimFiyat, govde, sb, 120, 260);

            }
            catch (Exception )
            {
                MessageBox.Show("Gerekli işlemleri yapınız...");
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            HastaIslem hi = (HastaIslem)Application.OpenForms["HastaIslem"];
            hi.hp = null;
            this.Hide();
        }
        private void HastaProces_FormClosing(object sender, FormClosingEventArgs e)
        {
            HastaIslem hi = (HastaIslem)Application.OpenForms["HastaIslem"];
            hi.hp = null;
            this.Hide();
        }
    }
}
