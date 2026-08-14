using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qnt = 0;
            int maior = -9999;

            for (int i =1; i <=500; i++)
            {
                Console.WriteLine("Digite o " +i + "º numero inteiro");
                int num = int.Parse(Console.ReadLine());

                if (num >= 50 && num <= 500) 
                {
                    qnt = qnt + 1;
                }

                if (num > maior)
                {
                    maior = num;
                }

            }

            Console.WriteLine("A quabtidade de nuneros no intervalo de 50 e 500 é = " +qnt);
            Console.WriteLine("O maior numero lido é = " +maior);
        }
    }
}
