using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            double s = 0;

            for (int j = 1 ; j <= 50 ; j++)
            {
                s = ((double)i / j) + s;
                i += 2;
            }
            

            Console.WriteLine("A soma da seguinte expressao S = 1 / 1 + 3 / 2 + 5 / 3 + 7 / 4 + ... + 99 / 50. é =" +s);
        }
    }
}
