using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hitung_sgitiga
{
    class segitiga
    {
          int x, y;

        //constructor
        public segitiga(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //method luas persegi
        public virtual int Luas()
        {
            return x * y / 2;
        }
    }
}
