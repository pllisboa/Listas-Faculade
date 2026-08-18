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
            int i = 1;
            int sup = 0;
            double areaT = 0;
            

            while (i <= 50)
            {
                Console.WriteLine("Digite a dimensao X do " + i + " terreno");
                double X = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite a dimensao Y do " + i + " terreno");
                double Y = double.Parse(Console.ReadLine());

                double area = X * Y;

                if (area > 360)
                {
                    sup = sup + 1;
                }

                areaT = areaT + area;

                i++;
            }

            double media = areaT / 50;

            Console.WriteLine("A media total das areas dos terrenos é " +media);
            Console.WriteLine("A quantidade de terrenos com area superior a 360m é " +sup);

        }
    }
}
