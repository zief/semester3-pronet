using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rsp1_converter_mata_uang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dollar, rupiah;
            double uang = int.Parse(txtuang.Text);

            if (cmbpil1.Text == "Rupiah")
            {
                if (cmbpil2.Text == "Rupiah")
                {
                    txthasil.Text = txtuang.Text;
                    label6.Text = "Rp";
                }
                else
                {
                    dollar = uang / 15000;
                    txthasil.Text = dollar.ToString();
                    label6.Text = "$";
                }
            }
            else
            {
                if(cmbpil2.Text == "Dollar")
                {
                    txthasil.Text = txtuang.Text;
                    label6.Text = "$";
                }
                else
                {
                    rupiah = uang * 15000;
                    txthasil.Text = rupiah.ToString();
                    label6.Text = "Rp";
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
