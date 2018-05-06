using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikum_4_inheritance
{
    public partial class Polymorphism : Form
    {
        public Polymorphism()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persegi prsg = new Persegi(int.Parse(textBox1.Text));
            Kubus kbs = new Kubus(int.Parse(textBox1.Text));

            MessageBox.Show("Luas Persegi = " + prsg.Luas() +
                "\n Luas Permukaan Kubus = " + kbs.Luas(), "Hasil");
        }
    }
}
