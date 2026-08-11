using System;
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
            double anonas, ano, idade;
            ano = 2012;

            Console.WriteLine("Qual o ano de nascimento? ");
            anonas = Double.Parse(Console.ReadLine());

            idade = ano - anonas;

            Console.WriteLine("Sua idade é de " + idade + " anos");

            if (idade >= 18 && idade <= 65)
            {
                Console.WriteLine("A idade está no intervalo");
            }

        }
    }
}
