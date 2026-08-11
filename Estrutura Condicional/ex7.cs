using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro");
            int num = int.Parse(Console.ReadLine());

            if (num %2 == 0)
            {
                Console.WriteLine("O numero digitado é par");
            }

            else
            {
                Console.WriteLine("O numero digitado é impar");
            }
        }
    }
}
