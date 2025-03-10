using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double res = 0;

            for (double k = 1;  k <= 10; k ++) {
                for (double n = 1; n <= k; n++)
                {
                    res =  res + Math.Tan(n * k)/k;
                }
            }
            Console.WriteLine("Полученный результат: {0}", res);
        }
    }
}
