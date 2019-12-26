using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOHATS
{
    public partial class HastaIslem : Form
    {
        public HastaIslem()
        {
            InitializeComponent();
        }
        public string yetki = "";
        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {

        }
        private void HastaIslem_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            toolStrip1.Enabled = false;
            Login lgn = new Login();
            lgn.MdiParent = this;
            lgn.StartPosition = FormStartPosition.CenterScreen;
            lgn.Show();
        }
        public void toolac()
        {
            toolStrip1.Enabled = true;
        }
        private void kullanıcıTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KulTanit kt = new KulTanit();
            kt.MdiParent = this;
            kt.StartPosition = FormStartPosition.CenterScreen;
            kt.Show();
        }
        private void hastaİşlemlerF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaProces hp = new HastaProces();
            hp.MdiParent = this;
            hp.StartPosition = FormStartPosition.CenterScreen;
            hp.Show();
        }
        private void poliklinikTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PoliTanit pt = new PoliTanit();
            pt.MdiParent = this;
            pt.StartPosition = FormStartPosition.CenterScreen;
            pt.Show();
        }
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Enabled = false;
            Login lgn = new Login();
            lgn.MdiParent = this;
            lgn.StartPosition = FormStartPosition.CenterScreen;
            lgn.Show();
            yetki = "False";
        }
        public HastaProces hp;
        private void HastaIslem_Load_1(object sender, EventArgs e)
        {

        }
        private void HastaIslem_KeyDown(object sender, KeyEventArgs e)
        {
        
            if (toolStrip1.Enabled ==true)
            {
                if (hp == null)
                {
                    if (e.KeyData == Keys.F2)
                    {
                        hp = new HastaProces();

                        hp.MdiParent = this;
                        hp.StartPosition = FormStartPosition.CenterScreen;
                        hp.Show();
                    }
                }
            }
        }
    }
}
