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
            Console.WriteLine("Digite um dia da semana");
            string dia = Console.ReadLine().ToLower();

            if (dia == "sabado" || dia == "domingo")
            {
                Console.WriteLine("FINAL DE SEMANA");
            }

            else
            {
                Console.WriteLine("NAO É FINAL DE SEMANA");
            }
        }
    }
}
