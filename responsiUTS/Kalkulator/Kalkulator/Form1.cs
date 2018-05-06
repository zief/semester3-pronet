using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = int.Parse(txtangka1.Text);
            b = int.Parse(txtangka2.Text);
            c = a + b;
            txthasil.Text = c.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = int.Parse(txtangka1.Text);
            b = int.Parse(txtangka2.Text);
            c = a - b;
            txthasil.Text = c.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = int.Parse(txtangka1.Text);
            b = int.Parse(txtangka2.Text);
            c = a * b;
            txthasil.Text = c.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = int.Parse(txtangka1.Text);
            b = int.Parse(txtangka2.Text);
            c = a  b;
            txthasil.Text = c.ToString();
        }
    }
}
