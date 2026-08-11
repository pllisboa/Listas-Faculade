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
            Console.WriteLine("Digite o numero equivalente a um dia da semana: Exemplo: 1- domingo, 2- Segunda-feira ... ");
            int op = int.Parse(Console.ReadLine());

            switch(op)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;

                case 2:
                    Console.WriteLine("Segunda Feira");
                    break;

                case 3:
                    Console.WriteLine("Terça Feira");
                    break;

                case 4:
                    Console.WriteLine("Quarta Feira");
                    break;

                case 5:
                    Console.WriteLine("Quinta Feira");
                    break;

                case 6:
                    Console.WriteLine("Sexta Feira");
                    break;

                case 7:
                    Console.WriteLine("Sabado");
                    break;

                default:
                    Console.WriteLine("Numero Invalido");
                    break;

            }
        }
    }
}
