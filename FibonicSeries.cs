using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    internal class FibonicSeries
    {
        public void Series()
        {
            int firstNum = 0;
            int secondNum = 1;
            int thirdNum;

            Console.WriteLine(firstNum + "\t" + secondNum);
            for (int i = 3; i <= 10; i++)
            {
                thirdNum = firstNum + secondNum;

                Console.Write("\t" + thirdNum);
                firstNum = secondNum;
                secondNum = thirdNum;
            }
            Console.ReadKey();
        }
    }
}

