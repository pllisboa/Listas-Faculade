using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 2;
            int den = 2;
            double s = 0;

            for (int i = 1; i <= 20; i++)
            {
                double termo = Math.Pow(num, 2) / den;

                if (i % 2 == 1)
                    s = s + termo;
                else
                    s = s - termo;

                num = num + 3;
                den = den * 3;
            }

            Console.WriteLine("O valor de S com 20 termos é: " + s);
        }
    }
}
