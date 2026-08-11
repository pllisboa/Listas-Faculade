using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma letra para verificar se é uma vogal ou consoante");
            string L = Console.ReadLine().ToLower();

            if (L == "a" || L == "e" || L == "i" || L == "o" || L == "u")
            {
                Console.WriteLine("A letra digitada é uma vogal");
            }
            else
            {
                Console.WriteLine("A letra digitada é uma consoante");
            }
        }
    }
}
