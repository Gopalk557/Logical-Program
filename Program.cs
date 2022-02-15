using System;
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
            ReverseNumber number = new ReverseNumber();
            number.Reverse();
            Console.ReadKey();
        }
    }
}
