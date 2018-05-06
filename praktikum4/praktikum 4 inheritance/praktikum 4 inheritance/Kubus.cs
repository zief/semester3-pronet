using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum_4_inheritance
{
    class Kubus:Persegi
    {
        
        //constructor
        public Kubus(int x)
            : base(x)
        {

        }
        //method menghitung luas permukaan kubus
        public override int Luas()
        {
            return (6*base.Luas());
        }
    }
}
