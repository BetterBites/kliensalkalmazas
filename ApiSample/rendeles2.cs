using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ApiSample
{
    public class rendeles2
    {
        public string bvin;
        public string vevo;
        public string rendelesi_ido;
        public decimal? osszeg;
        public string statusz;

        public string Bvin
        {
            get { return bvin ?? ""; }
            set { bvin = value; }
        }

        public string Vevo
        {
            get { return vevo ?? ""; }
            set { vevo = value; }
        }

        public string RendelesiIdo
        {
            get { return rendelesi_ido ?? ""; }
            set { rendelesi_ido = value; }
        }

        public decimal? Osszeg
        {
            get { return osszeg; }
            set { osszeg = value; }
        }

        public string Statusz
        {
            get { return statusz ?? ""; }
            set { statusz = value; }
        }

        public override string ToString()
        {
            return RendelesiIdo;
        }
    }
}
