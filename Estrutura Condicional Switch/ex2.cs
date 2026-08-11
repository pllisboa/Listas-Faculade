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
            Console.WriteLine("Digite um numero representando um mes do ano (Exemplo: 1- janeiro, 2- fevereiro ... )");
            int op = int.Parse(Console.ReadLine());

            switch(op)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;

                case 2:
                    Console.WriteLine("Fevereiro");
                    break;

                case 3:
                    Console.WriteLine("Março");
                    break;

                case 4:
                    Console.WriteLine("Abril");
                    break;

                case 5:
                    Console.WriteLine("Maio");
                    break;

                case 6:
                    Console.WriteLine("Junho");
                    break;

                case 7:
                    Console.WriteLine("Julho");
                    break;

                case 8:
                    Console.WriteLine("Agosto");
                    break;

                case 9:
                    Console.WriteLine("Setembro");
                    break;

                case 10:
                    Console.WriteLine("Outubro");
                    break;

                case 11:
                    Console.WriteLine("Novembro");
                    break;

                case 12:
                    Console.WriteLine("Dezembro");
                    break;

                default:
                    Console.WriteLine("Numero Invalido");
                        break;


            }
        }
    }
}
