using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o preço do Quilo: ");
            double PQ = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o peso em Quilos da refeição");
            double Q = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double T = PQ * Q;

            Console.WriteLine("O total a se pagar por essa refeição é R$" + T.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
