﻿using System;
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
            Console.ReadKey();
        }
    }
}