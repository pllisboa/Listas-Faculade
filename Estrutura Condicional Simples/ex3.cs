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
            string dia;

            Console.WriteLine("Qual é o dia da semana ?");
            dia = Console.ReadLine();

            if (dia == "sabado" || dia == "domingo")
            {
                Console.WriteLine("Final de semana");
            }

            if (dia == "segunda" || dia == "terça" || dia == "quarta" || dia == "quinta" || dia == "sexta") ;
            {
                Console.WriteLine("Dia util");
            }
        }
    }
}
