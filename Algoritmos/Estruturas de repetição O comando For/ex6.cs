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
            int menor = 9999;
            int maior = -9999;

            for (int i = 1; i<=40; i++)
            {
                Console.WriteLine("Digte o valor da " +i+ "º nota");
                int num = int.Parse(Console.ReadLine());

                if (num > maior)
                {
                    maior = num;
                }

                else if (num < menor)
                {
                    menor = num;
                }
            }

            Console.WriteLine("A maior nota lida é = " + maior);
            Console.WriteLine("A menor nota lida é = " + menor);
        }
    }
}
