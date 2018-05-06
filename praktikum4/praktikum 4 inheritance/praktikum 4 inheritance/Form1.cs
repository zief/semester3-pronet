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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmanusia_Click(object sender, EventArgs e)
        {
            Manusia mn1;
            mn1 = new Manusia();

            mn1.nama = "Susanti";
            mn1.gender = 'P';
            mn1.tinggibadan = 158;

            txtlabel1.Text = "-";
            txtnama.Text = mn1.nama;
            txtlabel3.Text = "-";
            txttinggibadan.Text = mn1.tinggibadan.ToString();
            txtgender.Text = mn1.gender.ToString();

            label1.Text = "label1";
            label3.Text = "label3";

        }

        private void btnpegawai_Click(object sender, EventArgs e)
        {
            Pegawai pg1;
            pg1 = new Pegawai();

            pg1.nip = "12345";
            pg1.nama = "Gilang";
            pg1.jabatan = "Manager";
            pg1.gender = 'L';
            pg1.tinggibadan = 170;


            txtlabel1.Text = pg1.nip;
            txtnama.Text = pg1.nama;
            txtlabel3.Text = pg1.jabatan;
            txttinggibadan.Text = pg1.tinggibadan.ToString();
            txtgender.Text = pg1.gender.ToString();

            label1.Text = "Nip";
            label3.Text = "Jabatan";
        }

        private void btnmahasiswa_Click(object sender, EventArgs e)
        {
            Mahasiswa mhs1;
            mhs1 = new Mahasiswa();

            mhs1.nim = "14.11.0185";
            mhs1.nama = "Ni'am Habibiy Sahid";
            mhs1.jurusan = "Teknik Informatika";
            mhs1.gender = 'L';
            mhs1.tinggibadan = 160;

            txtlabel1.Text = mhs1.nim;
            txtnama.Text = mhs1.nama;
            txtlabel3.Text = mhs1.jurusan;
            txttinggibadan.Text = mhs1.tinggibadan.ToString();
            txtgender.Text = mhs1.gender.ToString();

            label1.Text = "Nim";
            label3.Text = "Jurusan";
        }
    }
}
