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
            string dia;

            Console.WriteLine("Qual é o dia da semana ?");
            dia = Console.ReadLine();

            if (dia == "sabado" || dia == "domingo")
            {
                Console.WriteLine("Fim de semana");
            }
            else
            {
                Console.WriteLine("Dia util");
            }
        }
    }
}
