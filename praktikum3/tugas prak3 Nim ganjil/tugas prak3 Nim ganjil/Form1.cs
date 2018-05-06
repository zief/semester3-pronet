using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugas_prak3_Nim_ganjil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void pertambahan(int a, int b)
        {
            int x = 0;
            x = Convert.ToInt32(a + b);
            txttambah1.Text = x.ToString();
        }

        public void pertambahan(int a, int b, int c)
        {
            int x = 0;
            x = Convert.ToInt32(a + b) + c;
            txttambah1overload.Text = x.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pertambahan(10, 90);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pertambahan(11, 99, 88);
        }

    } 
}
