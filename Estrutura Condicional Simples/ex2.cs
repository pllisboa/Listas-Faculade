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
            double num1, num2, dif;

            Console.WriteLine("Digite o primeiro valor numerico: ");
            num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor numerico: ");
            num2 = Double.Parse(Console.ReadLine());


            if(num1 > num2)
            {
                dif = num1 - num2;
                Console.WriteLine("A diferença do valor " + num1 + " e o valor " + num2 + " é igual a " + dif);
            }

            if (num2 > num1)
            {
                dif = num2 - num1;
                Console.WriteLine("A diferença do valor " + num2 + " e o valor " + num1 + " é igual a " + dif);
            }

            if (num1 == num2)
            {
                Console.WriteLine("Os valores numericos são iguais");
            }


        }
    }
}
