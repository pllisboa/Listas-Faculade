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
            double pretv, predvd;

            Console.WriteLine("Digite o preço da televisao: ");
            pretv = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço do DvVD: ");
            predvd = Double.Parse(Console.ReadLine());

            if (pretv + predvd == 1300)
            {
                Console.WriteLine("Promoção");
            }
            else
            {
                Console.WriteLine("Sem promoção");
            }

        }
    }
}
