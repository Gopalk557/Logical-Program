﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Logical Prgram");
            FibonicSeries fibonic = new FibonicSeries();
            fibonic.Series();
        }
    }
}
