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
            int i = 1;
            double soma = 0;

            while (i <= 40)
            {
                Console.WriteLine("Digite o valor da "+i + " nota");
                double nota = double.Parse(Console.ReadLine());

                soma = soma + nota;

                i++;
            }

            double media = soma / 40;

            Console.WriteLine("A media das nota é = " + media);
        }
    }
}
