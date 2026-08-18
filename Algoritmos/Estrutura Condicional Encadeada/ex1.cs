using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o peso da mochila em KG");
            double peso = double.Parse(Console.ReadLine());

            if (peso <5)
            {
                Console.WriteLine("Mochila Leve");
            }

            else if ( peso >= 5 &&  peso <= 10)
            {
                Console.WriteLine("Mochila pesada");

            }

            else
            {
                Console.WriteLine("Mocila muito pesada");
            }
        }
    }
}
