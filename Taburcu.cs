using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;

namespace SOHATS
{
    public partial class Taburcu : Form
    {
        public Taburcu()
        {
            InitializeComponent();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Taburcu_Load(object sender, EventArgs e)
        {
            cmbbox_odemesekli.Items.Add("Nakit");
            cmbbox_odemesekli.Items.Add("Kredi Kartı - taksit");
            cmbbox_odemesekli.Items.Add("Kredi Kartı - tek çekim");
            cmbbox_odemesekli.Items.Add("Çek");
            cmbbox_odemesekli.Items.Add("Senet");
            cmbbox_odemesekli.SelectedIndex = 0;
            HastaProces hp = (HastaProces)Application.OpenForms["HastaProces"];
            txtbox_dosyano.Text =hp.dosyano  ;
            string[] db = new string[3];
            
            dateTimePicker_cikis.Value =Convert.ToDateTime(hp.tsaat) ;
            dateTimePicker_sevk.Value = Convert.ToDateTime(hp.ttarih);
            txtbox_toplamtutar.Text = hp.ttoplam.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string saat;
            string tarih = dateTimePicker_sevk.Value.Day.ToString() + "." + dateTimePicker_sevk.Value.Month.ToString() + "." + dateTimePicker_sevk.Value.Year.ToString();
            if (dateTimePicker_cikis.Value.Minute.ToString().Length == 1)
            {
                saat = "0" + dateTimePicker_cikis.Value.Minute.ToString();
            }
            else
            {
                saat = dateTimePicker_cikis.Value.Minute.ToString();
            }
            if (dateTimePicker_cikis.Value.Hour.ToString().Length == 1)
            {
                saat = 0 + dateTimePicker_cikis.Value.Hour.ToString() + ":" + saat;
            }
            else
            {
                saat = dateTimePicker_cikis.Value.Hour.ToString() + ":" + saat;
            }
            HastaProces hp = (HastaProces)Application.OpenForms["HastaPreces"];
            string[] db = xmloku();
            string connectionString = "server=" + db[0] + ";Integrated Security=" + db[1] + ";database=" + db[2];
            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand("INSERT INTO cikis(dosyano,sevktarihi,cikissaati,odeme,toplamtutar) values(@dosyano,@sevktarihi,@cikissaati,@odeme,@toplamtutar)", con);
                {
                    command.Parameters.AddWithValue("@dosyano", txtbox_dosyano.Text);
                    command.Parameters.AddWithValue("@sevktarihi", tarih);
                    command.Parameters.AddWithValue("@cikissaati",saat);
                    command.Parameters.AddWithValue("@odeme", cmbbox_odemesekli.Text);
                    command.Parameters.AddWithValue("@toplamtutar", txtbox_toplamtutar.Text);
                    command.ExecuteNonQuery();
                    con.Close();
                }
                sevkguncelle();
                
                con.Close();
                MessageBox.Show("Hastamızın taburcu işlemi tamamlanmıştır...");
                this.Close();
            }
        }
        private void sevkguncelle()
        {
            string saat;
            string tarih = dateTimePicker_sevk.Value.Day.ToString() + "." + dateTimePicker_sevk.Value.Month.ToString() + "." + dateTimePicker_sevk.Value.Year.ToString();
            if (dateTimePicker_cikis.Value.Minute.ToString().Length == 1)
            {
                saat = "0" + dateTimePicker_cikis.Value.Minute.ToString();
            }
            else
            {
                saat = dateTimePicker_cikis.Value.Minute.ToString();
            }
            if (dateTimePicker_cikis.Value.Hour.ToString().Length == 1)
            {
                saat = 0 + dateTimePicker_cikis.Value.Hour.ToString() + ":" + saat;
            }
            else
            {
                saat = dateTimePicker_cikis.Value.Hour.ToString() + ":" + saat;
            }
            string[] db = xmloku();
            string sqlkod = "server=" + db[0] + "; Integrated Security=" + db[1] + ";database=" + db[2];

            SqlConnection baglanti = new SqlConnection(sqlkod);
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            {

                string kayıt = "UPDATE sevk set taburcu=@taburcu where dosyano='" + txtbox_dosyano.Text + "'and saat='" + saat + "' and sevktarihi='" + tarih + "'";
                SqlCommand cmd = new SqlCommand(kayıt, baglanti);
                cmd.Parameters.AddWithValue("@taburcu", "True");
                cmd.ExecuteNonQuery();
                baglanti.Close();
            }
        }
        private void dateTimePicker_sevk_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
