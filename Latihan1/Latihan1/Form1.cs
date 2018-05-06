using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbya_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtnama.Focus();
            txtsopayam.Visible = false ;
            txtayamrica2.Visible = false ;
            txtestehmanis.Visible = false ;
            labeltotal.Visible = true;

        }

        private void cbsopayam_CheckedChanged(object sender, EventArgs e)
        {
            if (cbsopayam.Checked == true )
            {
                txtsopayam.Visible = true;
                txtsopayam.Focus();
            }
            else
            {
                txtsopayam.Visible = false;
            }
        }

        private void cbayamrica2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbayamrica2.Checked == true)
            {
                txtayamrica2.Visible = true;
                txtayamrica2.Focus();
            }
            else
            {
                txtayamrica2.Visible = false;
            }
        }

        private void cbestehmanis_CheckedChanged(object sender, EventArgs e)
        {
            if (cbestehmanis.Checked == true)
            {
                txtestehmanis.Visible = true;
                txtestehmanis.Focus();
            }
            else
            {
                txtestehmanis.Visible = false;
            }
        }

        private void btnhitung_Click(object sender, EventArgs e)
        {
            double total = 0;
            int sop, rica, teh;

            if (cbsopayam.Checked)
            {
                sop = int.Parse(txtsopayam.Text);
                total = total + 9000 * sop;
            }
            
            if (cbayamrica2.Checked)
            {
                rica = int.Parse(txtayamrica2.Text);
                total = total + 8500 * rica;
            }
            
            if (cbestehmanis.Checked)
            {
                teh = int.Parse(txtestehmanis.Text);
                total = total + 2000 * teh;
            }

            if (rbya.Checked == true)
            {
                total = total - 0.25 * total;
                txttotal.Text = total.ToString();
            }
            else
            {
                txttotal.Text = total.ToString();
            }

        }




    }
}
