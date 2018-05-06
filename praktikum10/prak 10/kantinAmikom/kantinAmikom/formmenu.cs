using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kantinAmikom
{
    public partial class formmenu : Form
    {
        public formmenu()
        {
            InitializeComponent();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Yakin akan keluar ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK){
                Application.Exit();
            }
        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trigger frm_trigger = new trigger();
            frm_trigger.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void penggunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datapengguna frm_user = new datapengguna();
            frm_user.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm_cust = new Form1();
            frm_cust.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datamenu frm_menu = new datamenu();
            frm_menu.Show();
        }

        private void formmenu_Load(object sender, EventArgs e)
        {

        }
    }
}
