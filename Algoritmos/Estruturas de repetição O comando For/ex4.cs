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
            int menor = 9999;

            for (int i=1; i<=50 ; i++)
            {
                Console.WriteLine("Digite a " +i +" nota");
                int nota = int.Parse(Console.ReadLine());

                if (nota < menor) 
                {
                    menor = nota;
                }
            }

            Console.WriteLine("A menor nota das 50 = " +menor);
        }
    }
}
