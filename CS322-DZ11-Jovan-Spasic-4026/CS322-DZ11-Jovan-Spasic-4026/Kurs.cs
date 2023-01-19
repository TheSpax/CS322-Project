using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_DZ11_Jovan_Spasic_4026
{
    internal class Kurs : IComparable<Kurs>
    {
        public string ImeKursa { get; set; }
        public int FondCasova { get; set; }
        public int MaksimalnoPrijava { get; set; }

        public Kurs(string imeKursa, int fondCasova, int maksimalnoPrijava)
        {
            ImeKursa = imeKursa;
            FondCasova = fondCasova;
            MaksimalnoPrijava = maksimalnoPrijava;
        }

        public int CompareTo(Kurs? other)
        {
            if(other == null)
            {
                return 1;
            }
            Kurs k = other as Kurs;
            return this.MaksimalnoPrijava.CompareTo(k.MaksimalnoPrijava);
        }
    }
}
