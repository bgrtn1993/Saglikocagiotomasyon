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
    public partial class Poliklinik : Form
    {
        public string polinikadi="";
        public Poliklinik()
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

        private void Poliklinik_Load(object sender, EventArgs e)
        {
            try
            {
                HastaIslem hi = (HastaIslem)Application.OpenForms["HastaISlem"];
                if (hi.yetki=="False")
                {
                    btn_guncelle.Enabled = false;
                    btn_sil.Enabled = false;
                    txtbox_aciklama.Enabled = false;
                    txtbox_polinikad.Enabled = false;
                    checkBox_gecerli.Enabled = false;
                }
                string[] db = new string[3];
                db = xmloku();
                PoliTanit pt = (PoliTanit)Application.OpenForms["PoliTanit"];
                txtbox_polinikad.Text = pt.polinikadi;
                polinikadi = txtbox_polinikad.Text;
                SqlConnection con = new SqlConnection("server=" + db[0] + ";Integrated Security="+db[1]+";database="+db[2]);
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM poliklinik WHERE poliklinikadi='" + pt.polinikadi + "'";
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                if (sdr["durum"].ToString() == "True")
                {
                    checkBox_gecerli.Checked = true;
                }
                else
                {
                    checkBox_gecerli.Checked = false;
                }
                txtbox_aciklama.Text = sdr["aciklama"].ToString();
                con.Close();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            string ad = txtbox_polinikad.Text;
            deleteRow("poliklinik","poliklinikadi",ad);
            txtbox_aciklama.Text = "";
            checkBox_gecerli.Checked = false;

        }
        public  void deleteRow(string table, string columnName, string IDNumber)
        {
            string[] db = new string[3];
            db = xmloku();
            string connectionString = "server=" + db[0] + ";Integrated Security=" + db[1] + ";database=" + db[2];
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM " + table + " WHERE " + columnName + " = '" + IDNumber+"'", con))
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                PoliTanit pt = (PoliTanit)Application.OpenForms["PoliTanit"];
                string durum = "";
                if (checkBox_gecerli.Checked==true)
                {
                    durum = "True";
                }
                else
                {
                    durum = "False";
                }
                string[] db = xmloku();
                string connectionString = "server=" + db[0] + ";Integrated Security=" + db[1] + ";database=" + db[2];
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("UPDATE  poliklinik SET poliklinikadi=@poliklinikadi, durum=@durum, aciklama=@aciklama where poliklinikadi=@poliklinikadi2", con);
                    {
                        command.Parameters.AddWithValue("@poliklinikadi2", polinikadi);
                        command.Parameters.AddWithValue("@poliklinikadi", txtbox_polinikad.Text);
                        command.Parameters.AddWithValue("@durum", durum);
                        command.Parameters.AddWithValue("@aciklama", txtbox_aciklama.Text);
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
            

        }
    }
}

