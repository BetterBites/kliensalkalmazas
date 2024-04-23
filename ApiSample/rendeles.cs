using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSample
{
    public class rendeles
    {
        public string bvin;
        public string vevo;
        public string rendelesi_ido;
        public decimal? osszeg;
        public string statusz;

        public override string ToString()
        {
            return rendelesi_ido; 
        }
    }
}
