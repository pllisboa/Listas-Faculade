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
            Console.WriteLine("Digite o preço da TV 32");
            double tv = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço do DVD");
            double dvd = double.Parse(Console.ReadLine());

            if (tv + dvd < 1.300)
            {
                Console.WriteLine("Itens em promoção");
            }

            else
            {

                Console.WriteLine("Itens sem promoção");
            }

        }
    }
}
