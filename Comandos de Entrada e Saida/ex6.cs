using System;
using System.Globalization;
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

            Console.WriteLine("Digite o valor do salario minimo");
            double min = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor do seu salario");
            double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double qnt = sal / min ;

            Console.WriteLine("Voce recebe " + qnt.ToString("F2") + " salario(s) minimo(s)",CultureInfo.InvariantCulture);

        }
    }
}
