using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikum2__void__vs__fungsi
{
    public partial class method_parameter : Form
    {
        public method_parameter()
        {
            InitializeComponent();
        }

        //listing program parameter nilai
        int kali(int a, int b)
        {
            return a * b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(txtbil1.Text);
            b = int.Parse(txtbil2.Text);
            c = kali(a, b);
            txthasilnilai.Text = c.ToString(); 
        }
        //parameter ref
        void tambahlima(ref int a)
        {
            a += 5;
        }
        private void method_parameter_Load(object sender, EventArgs e)
        {
        }
        //parameter ref
        private void btnref_Click(object sender, EventArgs e)
        {
            int c;
            c = int.Parse(txtangka1.Text);
            tambahlima(ref c);
            txthasilref.Text = c.ToString();
        }

        //listing program parameter2
        void bagidua(float a, out float b)
        {
            b = a / 2;
        }

        private void btnout_Click(object sender, EventArgs e)
        {
            float c;
            float hasil;

            c = float.Parse(txtangka2.Text);
            bagidua(c, out hasil);
            txthasilout.Text = hasil.ToString();
        }
    }
}
