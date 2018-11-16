using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_11_16_OraiMunka_Binaris_fa
{
    class BiFaelem
    {
        BiFaelem bal;
        BiFaelem jobb;
        string ertek;

        public BiFaelem(string ertek)
        {
            this.ertek = ertek;
        }

        public void Kiir(BiFaelem e)
        {
            if (e.bal != null)
            {
                Kiir(e.bal);
            }
            Console.WriteLine(e.ertek);
            if (e.jobb != null)
            {
                Kiir(e.jobb);
            }
        }
    }
}