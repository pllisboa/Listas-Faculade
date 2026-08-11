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
            Console.WriteLine("Digite o valor do primeiro numero numerico");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do segundo numero numerico");
            double num2 = double.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Os numeros são iguais ");
            }

            else
            {
                if (num1 > num2)
                {
                    double valor = num1 - num2;
                    Console.WriteLine(num1+ " - " +num2 + " = " +valor);
                }

                else
                {
                    double valor = num2 - num1;
                    Console.WriteLine(num2 + " - " + num1 + " = " + valor);

                }
            }

        }
    }
}
