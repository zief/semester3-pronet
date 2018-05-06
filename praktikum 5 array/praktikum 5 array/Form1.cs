using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikum_5_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnfarray_Click(object sender, EventArgs e)
        {
            txtmasuk.Text = "";
            listBox1.Items.Clear();
            int[] bilangan = { 1, 3, 5, 7, 9, 11 };
            foreach (int x in bilangan)
            {
                listBox1.Items.Add(x);
            }
        }

        private void btnfstring_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string nama = txtmasuk.Text;
            foreach (char karakter in nama)
            {
                listBox1.Items.Add(karakter);
            }
        }


    }
}
