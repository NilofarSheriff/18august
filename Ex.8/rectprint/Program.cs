﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectprint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}", n);
            Console.WriteLine("{0} {0}", n);
            Console.WriteLine("{0} {0}", n);
            Console.WriteLine("{0} {0}", n);
            Console.WriteLine("{0}{0}{0}", n);

            Console.ReadLine();
        }
    }
}
