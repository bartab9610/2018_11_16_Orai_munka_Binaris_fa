using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_11_16_OraiMunka_Binaris_fa
{
    class Program
    {
        static void Main(string[] args)
        {
            BiFaelem peldany = new BiFaelem("köcsög");
            peldany.Kiir(peldany);
            Console.WriteLine();
            peldany.Beszur(peldany, "Váza");
            peldany.Beszur(peldany, "Csésze");
            peldany.Kiir(peldany);
            Console.WriteLine();
            Console.WriteLine(peldany.Tartalmaz_e(peldany, "Váza"));
            Console.WriteLine(peldany.Tartalmaz_e(peldany, "Köcsögök"));

            /*
            Console.WriteLine("Hibakezelés");
            BiFaelem gyoker = new BiFaelem(null);
            gyoker.Kiir(gyoker);
            */
            Console.ReadKey();
        }
    }
}
