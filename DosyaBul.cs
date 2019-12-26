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
    public partial class DosyaBul : Form
    {
        public DosyaBul()
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

        private void cmbbox_arama_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbox_arama.Text== "Hasta Adı Soyadı")
            {
                textBox1.Width = 100;
                textBox2.Visible = true;
                checkBox1.Visible = true;
            }
            else
            {
                textBox1.Width = 250;
                textBox2.Visible = false;
                checkBox1.Visible = false;
            }
        }

        private void btn_bul_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                if (textBox1.Text.Length != 0)
                {


                    string[] db = xmloku();
                    string connectstring = "server=" + db[0] + ";Integrated Security=" + db[1] + ";database=" + db[2];
                    SqlConnection con = new SqlConnection(connectstring);
                    con.Open();
                    if (cmbbox_arama.Text == "Kimlik No")
                    {
                        checkBox1.Visible = false;
                        textBox2.Visible = false;
                        textBox1.Width = 250;
                        string sql = "SELECT * FROM hasta WHERE tckimlikno='" + textBox1.Text + "'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        SqlDataAdapter sqladap = new SqlDataAdapter(cmd);
                        DataSet sDs = new DataSet();
                        sqladap.Fill(sDs, "tckimlikno");
                        DataTable dTable = sDs.Tables["tckimlikno"];
                        if (sDs.Tables["tckimlikno"].ToString() == "True")
                        {
                            MessageBox.Show("Hasta bu sevkten Taburcu edilmiş");
                        }
                        con.Close();
                        dataGridView1.DataSource = sDs.Tables["tckimlikno"];
                        dataGridView1.ReadOnly = true;
                        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                    }
                    else if (cmbbox_arama.Text == "Hasta Adı Soyadı")
                    {
                        if (textBox2.Text.Length != 0)
                        {
                            string sql = "";
                            checkBox1.Visible = true;
                            textBox2.Visible = true;
                            textBox1.Width = 100;
                            if (checkBox1.Checked == true)
                            {
                                sql = "SELECT * FROM hasta WHERE ad='" + textBox1.Text + "'and soyad='" + textBox2.Text + "'";
                            }
                            else
                            {
                                sql = "SELECT * FROM hasta WHERE ad='" + textBox1.Text + "'";
                            }
                            SqlCommand cmd = new SqlCommand(sql, con);
                            SqlDataAdapter sqladap = new SqlDataAdapter(cmd);
                            DataSet sDs = new DataSet();
                            sqladap.Fill(sDs, "tckimlikno");
                            DataTable dTable = sDs.Tables["tckimlikno"];
                            if (sDs.Tables["tckimlikno"].ToString() == "True")
                            {
                                MessageBox.Show("Hasta bu sevkten Taburcu edilmiş");
                            }
                            con.Close();
                            dataGridView1.DataSource = sDs.Tables["tckimlikno"];
                            dataGridView1.ReadOnly = true;
                            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        }
                        else
                        {
                            MessageBox.Show("Arama yerine geçerli bir değer giriniz...");
                        }
                    }
                    else if (cmbbox_arama.Text == "Kurum Sicil No")
                    {
                        checkBox1.Visible = false;
                        textBox2.Visible = false;
                        textBox1.Width = 250;
                        string sql = "SELECT * FROM hasta WHERE kurumsicilno='" + textBox1.Text + "'";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        SqlDataAdapter sqladap = new SqlDataAdapter(cmd);
                        DataSet sDs = new DataSet();
                        sqladap.Fill(sDs, "kurumsicilno");
                        DataTable dTable = sDs.Tables["kurumsicilno"];
                        if (sDs.Tables["kurumsicilno"].ToString() == "True")
                        {
                            MessageBox.Show("Hasta bu sevkten Taburcu edilmiş");
                        }
                        con.Close();
                        dataGridView1.DataSource = sDs.Tables["kurumsicilno"];
                        dataGridView1.ReadOnly = true;
                        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                    else if (cmbbox_arama.Text == "Dosya No")
                    {
                        checkBox1.Visible = false;
                        textBox2.Visible = false;
                        textBox1.Width = 250;
                        string sql = "SELECT * FROM hasta WHERE dosyano='" + textBox1.Text + "'";
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
                    else
                    {
                        MessageBox.Show("Arama yerine geçerli bir değer giriniz...");
                    }
                }
                else
                {
                    MessageBox.Show("Arama yerine geçerli bir değer giriniz...");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Gerekli alanları doldurunuz...");
            }
            
        }

        private void DosyaBul_Load(object sender, EventArgs e)
        {
            cmbbox_arama.SelectedIndex = 0;
        }
    }
}
