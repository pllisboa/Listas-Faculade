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
            Console.WriteLine("Seguindo o modelo de equação (Ax2+Bx+C) \n");

            Console.WriteLine("Digite o valor de A:");
            double A = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            double B = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C:");
            double C = double.Parse(Console.ReadLine());

            double delta = Math.Pow(B, 2) - (4 * B * C);

            if (delta < 0)
            {
                Console.WriteLine("Não existem raizes reais");
            }

            else if (A == 0)
            {
                Console.WriteLine("Não é uma equação do 2 grau");
            }

            else
            {
                double x1 = (-B + Math.Sqrt(delta)) / 2 * A;
                double x2 = (-B + Math.Sqrt(delta)) / 2 * A;

                Console.WriteLine("As raizes da equação são X1 = " +x1 + " X2 = " +x2);
            }

        }
    }
}
