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
            Console.WriteLine("Digite o ano que voce nasceu");
            int ano = int.Parse(Console.ReadLine());

            if (2026 - ano >= 18 & 2026 - ano <= 65)
            {
                Console.WriteLine("A idade está no intervalo");
            }

            else
            {
                Console.WriteLine("A idade não está no intervalo");
            }
        }
    }
}
