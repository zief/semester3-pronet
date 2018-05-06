using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ngitung_suhu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            double celc, fahr, ream;

            double suhu;
            suhu = int.Parse(txtawal.Text);

            if (cmbpil1.Text == "Celcius")
            {
                celc = suhu;
                if (cmbpilhasil.Text == "Celcius")
                {
                    txthasil.Text = txtawal.Text;
                }
                else if (cmbpilhasil.Text == "Fahrenheit")
                {
                    fahr = celc * 1.8 + 32;
                    txthasil.Text = fahr.ToString();
                }
                else
                {
                    ream = celc * 0.8;
                    txthasil.Text = ream.ToString();
                }
            }
            else if (cmbpil1.Text == "Fahrenheit")
            {
                fahr = suhu;
                if (cmbpilhasil.Text == "Fahrenheit")
                {
                    txthasil.Text = txtawal.Text;
                }
                else if (cmbpilhasil.Text == "Celcius")
                {
                    celc = fahr - 32 / 1.8;
                    txthasil.Text = celc.ToString();
                }
                else
                {
                    ream = fahr - 32 / 2.25;
                    txthasil.Text = ream.ToString();
                }
            }
            else
            {
                ream = suhu;
                if (cmbpilhasil.Text == "Reamur")
                {
                    txthasil.Text = txtawal.Text;
                }
                else if (cmbpilhasil.Text == "Celcius")
                {

                    celc = ream / 1.8;
                    txthasil.Text = celc.ToString();
                }
                else
                {
                    fahr = ream * 2.25 + 32;
                    txthasil.Text = fahr.ToString();
                }

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
