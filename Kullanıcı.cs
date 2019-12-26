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
    public partial class Kullanıcı : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader sdr;
        public Kullanıcı()
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
        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                string[] db = xmloku();
                string sqlkod = "server=" + db[0] + "; Integrated Security=" + db[1] + ";database=" + db[2];

                string isebaslama = dateTimePicker_isebaslama.Value.Month.ToString() + "." + dateTimePicker_isebaslama.Value.Date.Day.ToString() + "." + dateTimePicker_isebaslama.Value.Year.ToString();
                string dogumtarihi = dateTimePicker_dogumtarihi.Value.Month.ToString() + "." + dateTimePicker_dogumtarihi.Value.Date.Day.ToString() + "." + dateTimePicker_dogumtarihi.Value.Year.ToString();
                SqlConnection baglanti = new SqlConnection(sqlkod);
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                if (btn_Guncelle.Text =="Güncelle")
                {
                    /*Burada kullanıcı güncellemek için gerekli sql kodu girilmiştir @baslayan 
                    kelime parametre olarak görev alır. Bu parametrelere değer girildikçe 
                    cmd.ExecuteNonQuerry() metoduyla veritabanına yazdırılır*/
                    string kayıt = "UPDATE kullanici set ad=@ad,soyad=@soyad,sifre=@sifre,yetki=@yetki,evtel=@evtel,ceptel=@ceptel,adres=@adres,unvan=@unvan,maas=@maas,dogumyeri=@dogumyeri,annead=@annead,babaad=@babaad,cinsiyet=@cinsiyet,kangrubu=@kangrubu,medenihal=@medenihal,tckimlikno=@tckimlikno,username=@username,isebaslama=@isebaslama where kodu='" + txtbox_kullanicikodu.Text + "'";
                    cmd = new SqlCommand(kayıt, baglanti);
                    cmd.Parameters.AddWithValue("@ad", txtbox_ad.Text);
                    cmd.Parameters.AddWithValue("@soyad", txtbox_soyad.Text);
                    cmd.Parameters.AddWithValue("@sifre", txtbox_sifre.Text);
                    cmd.Parameters.AddWithValue("@evtel", txtbox_telefonno.Text);
                    cmd.Parameters.AddWithValue("@ceptel", txtbox_gsm.Text);
                    cmd.Parameters.AddWithValue("@adres", txtbox_adres.Text);
                    cmd.Parameters.AddWithValue("@unvan", cmbbox_unvan.Text);
                    cmd.Parameters.AddWithValue("@maas", txtbox_maas.Text);
                    cmd.Parameters.AddWithValue("@dogumyeri", txtbox_dogumyeri.Text);
                    cmd.Parameters.AddWithValue("@annead", txtbox_anneadi.Text);
                    cmd.Parameters.AddWithValue("@babaad", txtbox_babaadi.Text);
                    cmd.Parameters.AddWithValue("@cinsiyet", cmbbox_cinsiyet.Text);
                    cmd.Parameters.AddWithValue("@kangrubu", cmbbox_kangrubu.Text);
                    cmd.Parameters.AddWithValue("@medenihal", cmbbox_medenihal.Text);
                    cmd.Parameters.AddWithValue("@tckimlikno", txtbox_kimlikno.Text);
                    cmd.Parameters.AddWithValue("@username", txtbox_kullaniciad.Text);
                    cmd.Parameters.AddWithValue("@isebaslama", isebaslama);
                    cmd.Parameters.AddWithValue("@dogumtarihi", dogumtarihi);
                    if (checkBox_yetkili.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@yetki", "True");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@yetki", "False");
                    }
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kullanıcı güncellendi...");
                }
                else
                {
                    /*Burada insert komutu sqle yeni bir kullanıcı eklemek için kullanılmıştır.*/
                    string yetki;
                    if (checkBox_yetkili.Checked ==true)
                    {
                        yetki = "True";
                    }
                    else
                    {
                        yetki = "False";
                    }
                    string kayit = "insert into kullanici(kodu,ad,soyad,sifre,yetki,evtel,ceptel,adres,unvan,isebaslama,maas,dogumyeri,annead,babaad,cinsiyet,kangrubu,medenihal,dogumtarihi,tckimlikno,username) values(@kodu,@ad,@soyad,@sifre,@yetki,@evtel,@ceptel,@adres,@unvan,@isebaslama,@maas,@dogumyeri,@annead,@babaad,@cinsiyet,@kangrubu,@medenihal,@dogumtarihi,@tckimlikno,@username)";
                    //cmd = new SqlCommand(kayıt, baglanti);
                    string ks = "insert into kullanici(kodu,ad,soyad,sifre,yetki,evtel,ceptel,adres,unvan,isebaslama,maas,dogumyeri,annead,babaad,cinsiyet,kangrubu,medenihal,dogumtarihi,tckimlikno,username) values('"+txtbox_kullanicikodu.Text+"','"+txtbox_ad.Text+"','"+txtbox_soyad.Text+"','"+txtbox_sifre.Text+"','"+yetki+"','"+txtbox_telefonno.Text+"','"+txtbox_gsm.Text+"','"+txtbox_adres.Text+"','"+cmbbox_unvan.Text+"','"+isebaslama+"','"+txtbox_maas.Text+"','"+txtbox_dogumyeri.Text+"','"+txtbox_anneadi.Text+"','"+txtbox_babaadi.Text+"','"+cmbbox_cinsiyet.Text+"','"+cmbbox_kangrubu.Text+"','"+cmbbox_medenihal.Text+"','"+dogumtarihi+"','"+txtbox_kimlikno.Text+"','"+txtbox_kullaniciad+"')";
                    cmd = new SqlCommand();
                    cmd.Connection = baglanti;
                    cmd.CommandText = ks;
                    
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Yeni Kullanıcı eklendi...");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void boxdoldur()
        {
            cmbbox_unvan.Items.Add("Sağlık Personeli");
            cmbbox_unvan.Items.Add("Doktor");
            cmbbox_unvan.Items.Add("Doçent");
            cmbbox_unvan.SelectedIndex = 0;
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
        private void Kullanıcı_Load(object sender, EventArgs e)
        {
            KulTanit kt = (KulTanit)Application.OpenForms["KulTanit"];
            HastaIslem hi = (HastaIslem)Application.OpenForms["HastaIslem"];
            if (hi.yetki=="False")
            {
                
                foreach (Control item in this.Controls)
                {
                    if (item!=groupBox1)
                    {
                        item.Enabled = false;
                    }
                    btn_Guncelle.Enabled = false;
                    btn_Sil.Enabled = false;
                    btn_Temizle.Enabled = false;
                }
                txtbox_kimlikno.Enabled = false;
                btn_Cikis.Enabled = true;
            }
            else
            {
                txtbox_kimlikno.Enabled = true;
            }
            if (kt!=null)
            {
                if (kt.kullanici2 != null)
                {
                    sqlkullanicicek();
                }
            }
            else
            {
                string[] db = xmloku();
                string connectstring = "server=" + db[0] + ";Integrated Security=" + db[1] + ";database=" + db[2];
                string sql = "SELECT * FROM kullanici";
                SqlConnection con = new SqlConnection(connectstring);
                con.Open();
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = con;
                cmd2.CommandText = sql;
                sdr = cmd2.ExecuteReader();
                int count = 0;
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
                txtbox_kullanicikodu.Text = sıfıryaz;
            }
            btn_Cikis.Enabled = true;
        }
        public void sqlkullanicicek()
        {
            string kullaniciadi = "";
            KulTanit kt = (KulTanit)Application.OpenForms["KulTanit"];
            string sıfıryaz = kt.yeniid.ToString();
            kullaniciadi = kt.kullanici2;
            for (int i = 0; i < 5; i++)
            {
                if (sıfıryaz.Length != 5)
                {
                    sıfıryaz = "0" + sıfıryaz;
                }
            }
            txtbox_kullanicikodu.Text = sıfıryaz;
            boxdoldur();

            int count = kt.count;
            if (count == 1)
            {
                string[] db = xmloku();
                con = new SqlConnection("server=" + db[0] + "; Integrated Security=" + db[1] + ";database=" + db[2]);
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM kullanici";
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    if (sdr["username"].ToString() == kullaniciadi)
                    {
                        txtbox_kullanicikodu.Text = sdr["kodu"].ToString();
                        txtbox_ad.Text = sdr["ad"].ToString();
                        txtbox_soyad.Text = sdr["soyad"].ToString();
                        txtbox_sifre.Text = sdr["sifre"].ToString();
                        txtbox_telefonno.Text = sdr["evtel"].ToString();
                        txtbox_gsm.Text = sdr["ceptel"].ToString();
                        txtbox_adres.Text = sdr["adres"].ToString();
                        txtbox_maas.Text = sdr["maas"].ToString();
                        txtbox_dogumyeri.Text = sdr["dogumyeri"].ToString();
                        txtbox_anneadi.Text = sdr["annead"].ToString();
                        txtbox_babaadi.Text = sdr["babaad"].ToString();
                        txtbox_kimlikno.Text = sdr["tckimlikno"].ToString();
                        txtbox_kullaniciad.Text = sdr["username"].ToString();
                        cmbbox_cinsiyet.SelectedItem = sdr["cinsiyet"].ToString();
                        cmbbox_kangrubu.SelectedItem = sdr["kangrubu"].ToString();
                        cmbbox_medenihal.SelectedItem = sdr["medenihal"].ToString();
                        cmbbox_unvan.SelectedItem = sdr["unvan"].ToString();
                        dateTimePicker_dogumtarihi.Text = sdr["dogumtarihi"].ToString();
                        dateTimePicker_isebaslama.Text = sdr["isebaslama"].ToString();
                        if (sdr["yetki"].ToString() == "True")
                        {
                            checkBox_yetkili.Checked = true;
                        }
                        else
                        {
                            checkBox_yetkili.Checked = false;
                        }
                    }

                }
            }
            else
            {
                txtbox_kimlikno.Enabled = true;
                btn_Guncelle.Text = "Yeni Kullanıcı Ekle";

            }
        }
        
        private void btn_Sil_Click(object sender, EventArgs e)
        {
            string[] db = xmloku();
            string conString = "server=" + db[0] + "; Integrated Security=" + db[1] + ";database=" + db[2];
            SqlConnection baglanti = new SqlConnection(conString);
            baglanti.Open();
            string secmeSorgusu = "SELECT * from kullanici where kodu=@kodu";
            //musterino parametresine bağlı olarak müşteri bilgilerini çeken sql kodu
            SqlCommand secmeKomutu = new SqlCommand(secmeSorgusu, baglanti);
            secmeKomutu.Parameters.AddWithValue("@kodu", txtbox_kullanicikodu.Text);
            //musterino parametremize textbox'dan girilen değeri aktarıyoruz.
            SqlDataAdapter da = new SqlDataAdapter(secmeKomutu);
            SqlDataReader dr = secmeKomutu.ExecuteReader();
            //DataReader ile müşteri verilerini veritabanından belleğe aktardık.
            if (dr.Read()) //Datareader herhangi bir okuma yapabiliyorsa aşağıdaki kodlar çalışır.
            {
                string isim = dr["ad"].ToString() + " " + dr["soyad"].ToString();
                dr.Close();
                //Datareader ile okunan müşteri ad ve soyadını isim değişkenine atadım.
                //Datareader açık olduğu sürece başka bir sorgu çalıştıramayacağımız için dr nesnesini kapatıyoruz.
                DialogResult durum = MessageBox.Show(isim + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                //Kullanıcıya silme onayı penceresi açıp, verdiği cevabı durum değişkenine aktardık.
                if (DialogResult.Yes == durum) // Eğer kullanıcı Evet seçeneğini seçmişse, veritabanından kaydı silecek kodlar çalışır.
                {
                    string silmeSorgusu = "DELETE from kullanici where kodu=@kodu";
                    //musterino parametresine bağlı olarak müşteri kaydını silen sql sorgusu
                    SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglanti);
                    silKomutu.Parameters.AddWithValue("@kodu", txtbox_kullanicikodu.Text);
                    silKomutu.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi...");
                    //Silme işlemini gerçekleştirdikten sonra kullanıcıya mesaj verdik.
                }
            }
            else
                MessageBox.Show("Kullanıcı Bulunamadı.");
            baglanti.Close();
            this.Close();
        }
        public void paneltemizle()
        {
            txtbox_kimlikno.Enabled = true;
            txtbox_ad.Text = "";
            txtbox_soyad.Text = "";
            txtbox_sifre.Text = "";
            txtbox_telefonno.Text = "";
            txtbox_gsm.Text = "";
            txtbox_adres.Text = "";
            txtbox_maas.Text = "";
            txtbox_dogumyeri.Text = "";
            txtbox_anneadi.Text = "";
            txtbox_babaadi.Text = "";
            txtbox_kimlikno.Text = "";
            txtbox_kullaniciad.Text = "";
            cmbbox_cinsiyet.Text = "";
            cmbbox_kangrubu.Text = "";
            cmbbox_medenihal.Text = "";
            cmbbox_unvan.Text = "";
            checkBox_yetkili.Checked = false;
            dateTimePicker_isebaslama.Value = System.DateTime.Now;
            dateTimePicker_dogumtarihi.Value = System.DateTime.Now;
        }
        private void btn_Temizle_Click(object sender, EventArgs e)
        {
            paneltemizle();
        }

        private void txtbox_kimlikno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_anneadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_telefonno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
