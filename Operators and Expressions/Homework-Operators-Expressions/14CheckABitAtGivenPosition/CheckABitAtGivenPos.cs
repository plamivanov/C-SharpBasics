﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14CheckABitAtGivenPosition
{
    class CheckABitAtGivenPos
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            bool isOne = (n >> p) % 2 != 0;
            Console.WriteLine(isOne);
        }
    }
}
