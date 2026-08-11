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
            string let;

            Console.WriteLine("Digite uma letra do alfabeto: ");
            let = Console.ReadLine();

            if (let == "a" || let == "e" || let == "i" || let == "o" || let == "u")
            {
                Console.WriteLine("A letra é uma vogal");
            }

            else
            {
                Console.WriteLine("A letra é uma consoante");
            }

        }
    }
}
