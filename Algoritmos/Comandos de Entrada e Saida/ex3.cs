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
            Console.WriteLine("Digite o valor do raio de um circulo");
            double R = double.Parse(Console.ReadLine());

            double A = 3.14159 * Math.Pow(R, 2);

            Console.WriteLine("A area do circulo é " + A);
        }
    }
}
