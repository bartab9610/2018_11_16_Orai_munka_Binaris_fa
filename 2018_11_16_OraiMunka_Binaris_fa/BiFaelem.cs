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
        public void Beszur(BiFaelem e, string ujErtek)
        {
            if (e.ertek.CompareTo(ujErtek) > 0)
            {
                if (e.bal != null)
                {
                    Beszur(e.bal, ujErtek);
                }
                else
                {
                    e.bal = new BiFaelem(ujErtek);
                }
            }
            else if (e.ertek.CompareTo(ujErtek) < 0) 
            {
                if (e.jobb != null)
                {
                    Beszur(e.jobb, ujErtek);
                }
                else
                {
                    e.jobb = new BiFaelem(ujErtek);
                }
            }
            else { }
        }
    }
}