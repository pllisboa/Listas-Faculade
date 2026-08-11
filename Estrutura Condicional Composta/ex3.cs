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
            double idade;

            Console.WriteLine("Digite sua idade? ");
            idade = Double.Parse(Console.ReadLine());

            if(idade >= 18)
            {
                Console.WriteLine("Você é de maior");
            }
            else 
            {
                Console.WriteLine("Você é de menor");
            }

        }
    }
}
