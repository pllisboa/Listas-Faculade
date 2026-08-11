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
            Console.WriteLine("Digite o primeiro numero inteiro");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero inteiro");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("O numero " + num1 + " é igual ao numero " + num2);
            }

            else
            {
                if (num1 > num2)
                {
                    Console.WriteLine("O numero " + num1 + " é maior");
                }

                else
                {
                    Console.WriteLine("O numero " + num2 + " é maior");

                }
            }
        }
    }
}
