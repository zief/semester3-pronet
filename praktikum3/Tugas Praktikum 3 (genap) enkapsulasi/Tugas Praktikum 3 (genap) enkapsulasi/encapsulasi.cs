using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Praktikum_3__genap__enkapsulasi
{
    class encapsulasi
    {
        public String nama;
        public String nim;
        private int nilaiku;
        public void setnilai(int nilai)
        {
            nilaiku = nilai;
        }
        public int getnilai()
        {
            return nilaiku;
        }
    }
}
