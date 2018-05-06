using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Praktikum_3__genap__enkapsulasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntampil_Click(object sender, EventArgs e)
        {
            encapsulasi datadiri = new encapsulasi();
            datadiri.nama = "Yuliani Dwi Asih";
            datadiri.nim = "14.11.0194";
            datadiri.setnilai(90);
            tbnama.Text = datadiri.nama;
            tbnim.Text = datadiri.nim;
            tbnilai.Text = datadiri.getnilai().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
