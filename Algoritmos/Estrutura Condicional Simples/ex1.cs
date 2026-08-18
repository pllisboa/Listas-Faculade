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
            double num1, num2;

            Console.WriteLine("Digite o valor do primeiro numero: ");
            num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo numero: ");
            num2 = Double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("O " + num1 + " é maior que o numero " + num2);
            }

            if (num2 > num1)
            {
                Console.WriteLine("O " + num2 + " é maior que o numero " + num1);
            }

            if (num1 == num2)
            {
                Console.WriteLine("O " + num1 + " é igual o numero " + num2);
            }

        }
    }
}
