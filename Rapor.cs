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
    public partial class Rapor : Form
    {
        SqlDataReader sdr;
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
        public Rapor()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rapor_Load(object sender, EventArgs e)
        {
            HastaProces hp = (HastaProces)Application.OpenForms["HastaProces"];
            string[] db = xmloku();
            string connectstring = "server=" + db[0] + ";Integrated Security=" + db[1] + ";database=" + db[2];
            
            if (hp.raporsay==2)
            {
                string sql = "SELECT * FROM hasta ";
                SqlConnection con = new SqlConnection(connectstring);
                con.Open();
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = con;
                cmd2.CommandText = sql;
                int count = 0;
                sdr = cmd2.ExecuteReader();
                while (sdr.Read())
                {
                    count++;
                }
                string sıfıryaz = (count + 1).ToString();
                for (int i = 0; i < 5; i++)
                {
                    if (sıfıryaz.Length != 5)
                    {
                        sıfıryaz = "0" + sıfıryaz;
                    }
                }
                sdr.Close();
                txtbox_dosyano.Text = sıfıryaz;
            }
            else if(hp.raporsay==1)
            {
                string sql = "SELECT * FROM hasta where dosyano='" + hp.dosyano + "'";
                SqlConnection con = new SqlConnection(connectstring);
                con.Open();
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = con;
                cmd2.CommandText = sql;
                sdr = cmd2.ExecuteReader();
                while (sdr.Read())
                {
                    
                    txtbox_dosyano.Text = sdr["dosyano"].ToString();
                    txtbox_ad.Text = sdr["ad"].ToString();
                    txtbox_soyadi.Text = sdr["soyad"].ToString();
                    txtbox_dogumyeri.Text = sdr["dogumyeri"].ToString();
                    txtbox_tckimlik.Text = sdr["tckimlikno"].ToString();
                    //dateTimePicker_gun.Value. = sdr["dogumtarihi"].ToString();
                    txtbox_babaadi.Text = sdr["babaadi"].ToString();
                    txtbox_anneadı.Text = sdr["anneadi"].ToString();
                    cmbbox_cinsiyet.Text = sdr["cinsiyet"].ToString();
                    cmbbox_kangrubu.Text = sdr["kangrubu"].ToString();
                    cmbbox_medenihal.Text = sdr["medenihal"].ToString();
                    txtbox_adres.Text = sdr["adres"].ToString();
                    txtbox_telefonno.Text = sdr["tel"].ToString();
                    txtbox_kurumsicilno.Text = sdr["kurumsicilno"].ToString();
                    txtbox_kurumad.Text = sdr["kurumadı"].ToString();
                    txtbox_yakintel.Text = sdr["yakintel"].ToString();
                    txtbox_yakinsicil.Text = sdr["yakinkurumsicilno"].ToString();
                    txtbox_ykurumad.Text = sdr["yakinkurumadı"].ToString();

                }
            }
            Kullanıcı kln = new Kullanıcı();
            cmbbox_cinsiyet.Items.Add("BAY");
            cmbbox_cinsiyet.Items.Add("BAYAN");
            cmbbox_cinsiyet.SelectedIndex = 0;
            cmbbox_kangrubu.Items.Add("0 RH+");
            cmbbox_kangrubu.Items.Add("0 RH-");
            cmbbox_kangrubu.Items.Add("A RH+");
            cmbbox_kangrubu.Items.Add("A RH-");
            cmbbox_kangrubu.Items.Add("B RH+");
            cmbbox_kangrubu.Items.Add("B RH-");
            cmbbox_kangrubu.Items.Add("AB RH+");
            cmbbox_kangrubu.Items.Add("AB RH-");
            cmbbox_kangrubu.SelectedIndex = 0;
            cmbbox_medenihal.Items.Add("EVLİ");
            cmbbox_medenihal.Items.Add("BEKAR");
            cmbbox_medenihal.SelectedIndex = 0;
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_yeni_Click(object sender, EventArgs e)
        {
            HastaProces hp = (HastaProces)Application.OpenForms["HastaProces"];
            string[] db = xmloku();
            string connectstring = "server=" + db[0] + ";Integrated Security=" + db[1] + ";database=" + db[2];
            SqlConnection baglanti = new SqlConnection(connectstring);
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            string sql = "INSERT INTO hasta(tckimlikno,dosyano,ad,soyad,dogumyeri,babaadi,anneadi,cinsiyet,kangrubu,medenihal,adres,tel,kurumsicilno,kurumadı,yakintel,yakinkurumsicilno,yakinkurumadı) " +
                                        "values(@tckimlikno,@dosyano,@ad,@soyad,@dogumyeri,@babaadi,@anneadi,@cinsiyet,@kangrubu,@medenihal,@adres,@tel,@kurumsicilno,@kurumadı,@yakintel,@yakinkurumsicilno,@yakinkurumadı)";
            SqlCommand cmd = new SqlCommand(sql,baglanti);
            cmd.Parameters.AddWithValue("@tckimlikno",txtbox_tckimlik.Text);
            cmd.Parameters.AddWithValue("@dosyano",txtbox_dosyano.Text);
            cmd.Parameters.AddWithValue("@ad",txtbox_ad.Text);
            cmd.Parameters.AddWithValue("@soyad",txtbox_soyadi.Text);
            cmd.Parameters.AddWithValue("@dogumyeri",txtbox_dogumyeri.Text);
            //cmd.Parameters.AddWithValue("@dogumtarihi",dateTimePicker_gun.Value.Date.ToString()+"."+dateTimePicker_gun.Value.Month.ToString()+"."+dateTimePicker_gun.Value.Year.ToString());
            cmd.Parameters.AddWithValue("@babaadi",txtbox_babaadi.Text);
            cmd.Parameters.AddWithValue("@anneadi",txtbox_anneadı.Text);
            cmd.Parameters.AddWithValue("@cinsiyet",cmbbox_cinsiyet.Text);
            cmd.Parameters.AddWithValue("@kangrubu",cmbbox_kangrubu.Text);
            cmd.Parameters.AddWithValue("@medenihal",cmbbox_medenihal.Text);
            cmd.Parameters.AddWithValue("@adres",txtbox_adres.Text);
            cmd.Parameters.AddWithValue("@tel",txtbox_telefonno.Text);
            cmd.Parameters.AddWithValue("@kurumsicilno",txtbox_kurumsicilno.Text);
            cmd.Parameters.AddWithValue("@kurumadı",txtbox_kurumad.Text);
            cmd.Parameters.AddWithValue("@yakintel",txtbox_yakintel.Text);
            cmd.Parameters.AddWithValue("@yakinkurumsicilno",txtbox_yakinsicil.Text);
            cmd.Parameters.AddWithValue("@yakinkurumadı",txtbox_ykurumad.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni Hasta Eklendi...");
        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            string[] db = xmloku();
            string connectionString = "server=" + db[0] + ";Integrated Security=" + db[1] + ";database=" + db[2];
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand("UPDATE  hasta SET ad=@ad,soyad=@soyad,dogumyeri=@dogumyeri,babaadi=@babaadi,anneadi=@anneadi,cinsiyet=@cinsiyet,kangrubu=@kangrubu,medenihal=@medenihal,adres=@adres,tel=@tel,kurumsicilno=@kurumsicilno,kurumadı=@kurumadı,yakintel=@yakintel,yakinkurumsicilno=@yakinkurumsicilno,yakinkurumadı=@yakinkurumadı  where tckimlikno=@tckimlikno2", con);
                {
                    command.Parameters.AddWithValue("@tckimlikno2", txtbox_tckimlik.Text);
                    command.Parameters.AddWithValue("@ad", txtbox_ad.Text);
                    command.Parameters.AddWithValue("@soyad", txtbox_soyadi.Text);
                    command.Parameters.AddWithValue("@babaadi", txtbox_babaadi.Text);
                    command.Parameters.AddWithValue("@anneadi", txtbox_anneadı.Text);
                    command.Parameters.AddWithValue("@cinsiyet", cmbbox_cinsiyet.Text);
                    command.Parameters.AddWithValue("@kangrubu", cmbbox_kangrubu.Text);
                    command.Parameters.AddWithValue("@medenihal", cmbbox_medenihal.Text);
                    command.Parameters.AddWithValue("@dogumyeri", txtbox_dogumyeri.Text);
                    command.Parameters.AddWithValue("@adres", txtbox_adres.Text);
                    command.Parameters.AddWithValue("@tel", txtbox_telefonno.Text);
                    command.Parameters.AddWithValue("@kurumsicilno", txtbox_kurumsicilno.Text);
                    command.Parameters.AddWithValue("@kurumadı", txtbox_kurumad.Text);
                    command.Parameters.AddWithValue("@yakintel", txtbox_yakintel.Text);
                    command.Parameters.AddWithValue("@yakinkurumsicilno", txtbox_yakinsicil.Text);
                    command.Parameters.AddWithValue("@yakinkurumadı", txtbox_ykurumad.Text);
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
            MessageBox.Show("Hasta bilgileri güncellendi...");
        }
    }
}
