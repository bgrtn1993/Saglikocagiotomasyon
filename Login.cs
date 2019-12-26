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
    public partial class Login : Form
    {
        public Login()
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
        private void giris()
        {
            if (txtBox_kullanici.Text == null || txtBox_kullanici.Text == "" || txtbox_sifre.Text == "" || txtbox_sifre.Text == null)
            {
                MessageBox.Show("Gerekli alanları doldurunuz.");
            }
            else
            {
                string[] db = new string[3];
                db = xmloku();
                string giris = txtBox_kullanici.Text;
                string sifre = txtbox_sifre.Text;
                SqlConnection con = new SqlConnection("server=" + db[0] + ";Integrated Security=" + db[1] + ";database="+db[2]);
                SqlCommand cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM kullanici WHERE username='" + txtBox_kullanici.Text + "' and sifre='" + txtbox_sifre.Text + "'";
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    HastaIslem hi = (HastaIslem)Application.OpenForms["HastaIslem"];
                    hi.toolac();
                    hi.yetki = sdr["yetki"].ToString();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Yanlış kullanıcı adı ve/veya şifre");
                }
                
            }
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            giris();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txtBox_kullanici.Text = "";
            txtbox_sifre.Text = "";
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giris_btn_cagir_click(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                btn_giris_Click(this, new EventArgs());
            }
        }
    }
}
