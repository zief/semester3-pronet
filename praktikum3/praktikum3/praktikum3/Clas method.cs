using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktikum3
{
    public partial class Clas_method : Form
    {
        public Clas_method()
        {
            InitializeComponent();
        }

        private void Clas_method_Load(object sender, EventArgs e)
        {
            

        }

        private void btnhitung_Click(object sender, EventArgs e)
        {
            mahasiswa mhs = new mahasiswa();

            mhs.nim = txtnim.Text;
            mhs.nama = txtnama.Text;
            mhs.nilaiBahasa = int.Parse(txtindo.Text);
            mhs.nilaiInggris = int.Parse(txtinggris.Text);
            mhs.nilaiManajemen = int.Parse(txtmanajemen.Text);

            //pemanggilan method
            mhs.hitungTotalNilai();
            mhs.hitungRataRata();

            MessageBox.Show("Mahasiswa dengan NIM : " + mhs.nim +
                " dan Nama : " + mhs.nama +
                " \nMendapat Total Nilai : " + mhs.totalnilai +
                " dan Nilai Rata-Rata : " + mhs.rataRata, "Hasil Perhitungan");
        }
    }
}
