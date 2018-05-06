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
    public partial class datapedagang : Form
    {
        public datapedagang()
        {
            InitializeComponent();
        }

        private void tampildata()
        {
            System.Data.Linq.Table<pedagang> pdg = accesor.Getpedagangtable();
            dgvpedagang.DataSource = pdg;
        }

        private void datapedagang_Load(object sender, EventArgs e)
        {
            tampildata();
            
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                accesor.insertorupdatepedagang(int.Parse(txtid.Text), txnama.Text, txtalamat.Text);
                tampildata();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                accesor.deletepedagang(int.Parse(txtid.Text));
                tampildata();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }
        }


        
    }
}
