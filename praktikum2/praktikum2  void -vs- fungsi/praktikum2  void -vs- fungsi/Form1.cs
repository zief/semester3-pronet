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
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private string luaspersegi()
        {
            int p,l, luas;
            p = int.Parse(txtpanjang.Text);
            l = int.Parse(txtlebar.Text);
            luas = p*l;
            return luas.ToString();
        }
        private void hitungluas()
        {
            int p,l, luas;
            p = int.Parse(txtpanjang.Text);
            l = int.Parse(txtlebar.Text);
            luas = p*l;
            txthasilvoid.Text = luas.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
             txthasilfungsi.Text = luaspersegi();
        }

        private void btnluasvoid_Click(object sender, EventArgs e)
        {
            hitungluas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
