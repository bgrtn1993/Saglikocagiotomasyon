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
    public partial class KulTanit : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader sdr;
        public string kullanici2;
        public int count;
        public int yeniid;
        public KulTanit()
        {
            InitializeComponent();
        }
        Kullanıcı kln = new Kullanıcı();
        private void cmbbox_kullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            count = 1;
            kullanici2 = cmbbox_kullanicilar.SelectedItem.ToString();
            kln.MdiParent = HastaIslem.ActiveForm;
            kln.StartPosition = FormStartPosition.CenterScreen;
            kln.Show();
            this.Hide();

        }
       
        private void KulTanit_Load(object sender, EventArgs e)
        {
            HastaIslem hi = (HastaIslem)Application.OpenForms["HastaIslem"];
            if (hi.yetki=="False")
            {
                btn_kullanici_ekle.Enabled = false;
            }
            con = new SqlConnection("server=DESKTOP-RV0PQQA;Integrated Security=SSPI;database=SOHATS");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM kullanici";
            sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                cmbbox_kullanicilar.Items.Add(sdr["username"].ToString());
                yeniid = int.Parse(sdr["kodu"].ToString()) + 1;
            }
        }

        private void btn_kullanici_ekle_Click(object sender, EventArgs e)
        {
            count = 0;
            kullanici2 = "deneme";
            kln.MdiParent = HastaIslem.ActiveForm;
            kln.StartPosition = FormStartPosition.CenterScreen;
            kln.Show();
            this.Hide();

        }
    }
}
