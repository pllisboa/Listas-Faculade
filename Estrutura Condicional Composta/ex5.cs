using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;

            Console.WriteLine("Digite um numero:");
            num = Double.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("O numero é par");
            }
            else
            {
                Console.WriteLine("O numero é impar");
            }
        }
    }
}
