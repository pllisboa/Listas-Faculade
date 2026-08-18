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
            Console.WriteLine("Escolha uma das opçoes abaixo: \n");
            Console.WriteLine("1 - Biscoito\n 2 - Chocolate\n 3 - Pizza\n 4 - Refrigerante\n 5 - Agua mineral\n 6 - vinho\n");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Produto: Biscoito | Valor unitario: R$ 2,50 | Estoque: 50");
                    break;

                case 2:
                    Console.WriteLine("Produto: Chocolate | Valor unitario: R$ 4,20 | Estoque: 30");
                    break;

                case 3:
                    Console.WriteLine("Produto: Pizza | Valor unitario: R$ 25,90 | Estoque: 80");
                    break;

                case 4:
                    Console.WriteLine("Produto: Refrigerante | Valor unitario: R$ 3,00 | Estoque: 60");
                    break;

                case 5:
                    Console.WriteLine("Produto: Agua mineral | Valor unitario: R$ 1,80 | Estoque: 100");
                    break;

                case 6:
                    Console.WriteLine("Produto: Vinho | Valor unitario: R$ 23,10 | Estoque: 19");
                    break;

                default:
                    Console.WriteLine("Opção Invalida");
                    break;
            }
        }
    }
}
