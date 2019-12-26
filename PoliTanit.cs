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

namespace SOHATS
{
    public partial class PoliTanit : Form
    {
        public PoliTanit()
        {
            InitializeComponent();
        }
        public string polinikadi;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-RV0PQQA;Integrated Security=SSPI;database=SOHATS");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM poliklinik WHERE poliklinikadi='"+cmbbox_poliklinikad.Text+"'";
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            if (sdr["durum"].ToString()=="True")
            {
                checkBox_polidurum.Checked = true;
            }
            else
            {
                checkBox_polidurum.Checked = false;
            }
        }

        private void PoliTanit_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-RV0PQQA;Integrated Security=SSPI;database=SOHATS");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM poliklinik";
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                cmbbox_poliklinikad.Items.Add(sdr["poliklinikadi"].ToString());
            }
        }

        private void cmbbox_poliklinikad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter)
            {
                polinikadi = cmbbox_poliklinikad.Text;
                Poliklinik plk = new Poliklinik();
                plk.MdiParent = HastaIslem.ActiveForm;
                plk.StartPosition = FormStartPosition.CenterScreen;
                plk.Show();
                this.Hide();
            }
        }
    }
}
