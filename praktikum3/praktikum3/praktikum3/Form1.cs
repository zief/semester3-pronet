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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // cara pengisian variabel langsung
            //ke dalam suatu object yang telah dibuat
            // dan bukan melalui inputn
            Kendaraan mobilPertamaku;
            mobilPertamaku = new Kendaraan();

            produksi YearProduct = new produksi();
            YearProduct.tahunProduksi = 2004;
            mobilPertamaku.keteranganMobil = YearProduct;

            mobilPertamaku.PlatNomor = "R 41 SA";
            mobilPertamaku.Model = "Toyota Fortuner";
            mobilPertamaku.SpeedMax = 200;
            mobilPertamaku.Manufaktur = "Toyota";

            txtplat.Text = mobilPertamaku.PlatNomor;
            txtmodel.Text = mobilPertamaku.Model;
            txtmanufaktur.Text = mobilPertamaku.Manufaktur;
            txtspeed.Text = mobilPertamaku.SpeedMax.ToString();
            txttahun.Text = mobilPertamaku.keteranganMobil.tahunProduksi.ToString(); 

        }

        private void btntampil_Click(object sender, EventArgs e)
        {
            // cara pengisian variabel langsung
            //ke dalam suatu object yang telah dibuat
            // dan bukan melalui inputn
            Kendaraan mobilPertamaku;
            mobilPertamaku = new Kendaraan();

            produksi YearProduct = new produksi();
            YearProduct.tahunProduksi = 2004;
            mobilPertamaku.keteranganMobil = YearProduct;

            mobilPertamaku.PlatNomor = txtplat.Text;
            mobilPertamaku.Model = txtmodel.Text;
            mobilPertamaku.Manufaktur = txtmanufaktur.Text;
            mobilPertamaku.SpeedMax = int.Parse(txtspeed.Text);
            mobilPertamaku.keteranganMobil.tahunProduksi = int.Parse(txttahun.Text);

            MessageBox.Show("Mobilku : " + mobilPertamaku.Model + 
                "\nBuatan : " + mobilPertamaku.Manufaktur +
                "\nDiproduksi Tahun : "+mobilPertamaku.keteranganMobil.tahunProduksi+ 
                "\nMemiliki Kecepatan maksimal : "+mobilPertamaku.SpeedMax+ 
                "\nDan memiliki Plat Nomor : " + mobilPertamaku.PlatNomor, "Hasil" );


        }
    }
}
