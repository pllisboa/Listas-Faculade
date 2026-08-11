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
            Console.WriteLine("Digite o primeiro cateto do triangulo retangulo ");
            double cat1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo cateto do triangulo retangulo ");
            double cat2 = int.Parse(Console.ReadLine());

            double hip = Math.Sqrt(Math.Pow(cat1, 2) + Math.Pow(cat2, 2));

            Console.WriteLine("O valor da hipotenusa é " + hip);


        }
    }
}
