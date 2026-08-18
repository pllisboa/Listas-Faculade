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
            Console.WriteLine("Digite o saldo:");
            double saldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do deposito:");
            double deposito = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser descontado:");
            double desconto = double.Parse(Console.ReadLine());

            double NovoSaldo = saldo + deposito - desconto;

            if (NovoSaldo > 0)
            {
                Console.WriteLine("Seu saldo é positivo = " + NovoSaldo);
            }

            else if (NovoSaldo < 0)
            {
                Console.WriteLine("Seu saldo é negativo = " + NovoSaldo);
            }

            else
            {
                Console.WriteLine("Seu saldo é Nulo = " + NovoSaldo);
            }
        }
    }
}
