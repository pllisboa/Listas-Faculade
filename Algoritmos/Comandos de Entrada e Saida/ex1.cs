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
            Console.WriteLine("Digite a primeira nota: ");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            int nota3 = int.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3.0;

            Console.WriteLine("A media das 3 notas é " +media);
        }
    }
}
