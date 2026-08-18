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
            int totalp = 0;
            int totaln = 0;
            int totali = 0;

            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine("Digite o " + i + " numero inteiro");
                int num = int.Parse(Console.ReadLine());

                if (num % 2  == 0)
                {
                    totalp = totalp + 1;
                }

                else if (num == 0)
                {
                    totaln = totaln + 1;
                }

                else
                {
                    totali = totali + 1;
                }
            }

            Console.WriteLine("O total de numeros pares é: " + totalp);
            Console.WriteLine("O total de numeros impares é: " + totali);
            Console.WriteLine("O total de numeros nulos é: " + totaln);
        }
    }
}
