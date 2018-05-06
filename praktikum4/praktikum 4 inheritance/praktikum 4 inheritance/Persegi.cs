using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum_4_inheritance
{
    class Persegi
    {
        //field
        int x;

        //constructor
        public Persegi(int x)
        {
            this.x = x;
        }

        //method luas persegi
        public virtual int Luas()
        {
            return x * x;
        }

    }
}
