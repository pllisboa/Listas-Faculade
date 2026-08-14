using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            double s = 0;

            for (int j = 1; j <= 30; j++) 
            {
                s = s + (i / Math.Pow(j,2));
                i *=2; 
            }

             Console.WriteLine("O valor para a equação S= 1/1 ^2 + 2/2 ^2 + 4/3 ^2 ... para 30 termos é= " +s);
        }
    }
}



