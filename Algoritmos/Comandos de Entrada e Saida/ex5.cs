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
            Console.WriteLine("Digite o valor de A");
            double A = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B");
            double B = double.Parse(Console.ReadLine());

            Console.WriteLine("O valor de A = " + A + " e o valor de B é = " + B);

            double aux;

            aux = A;
            A = B;
            B = aux;

            Console.WriteLine("O novo valor de A = "+A +" e o novo valor de B é = "+B);
        }
    }
}
