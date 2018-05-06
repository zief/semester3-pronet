using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum3
{
    class mahasiswa
    {
        //daftar field
        public string nama, nim;
        public int nilaiInggris, nilaiManajemen, nilaiBahasa, totalnilai;
        public double rataRata;

        //method-method
        public void hitungTotalNilai()
        {
            totalnilai = nilaiBahasa + nilaiInggris + nilaiManajemen;
        }
        public void hitungRataRata()
        {
            rataRata = (double)totalnilai / 3; 
        }
    }
}
