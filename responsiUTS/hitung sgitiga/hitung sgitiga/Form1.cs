using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hitung_sgitiga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hitung_Click(object sender, EventArgs e)
        {
           // segitiga sgtg = new segitiga(int.Parse(txtalas.Text), int.Parse(txttinggi));

           // MessageBox.Show("Luas Segitiga = " + sgtg.Luas(), "Hasil");
            // maaf nggak jadi pake pbo :)
            double a, b, c;
            a = int.Parse(txtalas.Text);
            b = int.Parse(txttinggi.Text);
            c = a * b / 2;
            txthasil.Text = c.ToString();
        }
    }
}
