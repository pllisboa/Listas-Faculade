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
            int i = 1;
            int qntm = 0;
            int qntf = 0;
            int qntp = 0;
            double rendaf = 0;
            

            while (i <= 3)
            {
                Console.WriteLine("Digite o seu sexo: M/F");
                string sexo = Console.ReadLine().ToLower();

                Console.WriteLine("Digite sua idade (em anos): ");
                int idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite sua Renda: ");
                double renda = double.Parse(Console.ReadLine());

                if ( idade >= 23 && idade <=30 &&  renda > 3.500)
                {
                    qntp = qntp + 1;

                }

                if (sexo == "m")
                {

                    qntm = qntm + 1;
                    
                }

                else if (sexo == "f")
                {
                    qntf = qntf + 1;
                    rendaf = rendaf + renda;
                }

                i++;
            }

            double media = rendaf / qntf;

            Console.WriteLine("A quantidade de homens é " + qntm + " e a quantidade de mulheres é " + qntf);
            Console.WriteLine("A media salaria das mulheres é " +media);
            Console.WriteLine("A quantidade de pessoas que ganham mais de 3.500 e tem idade entre 23 e 30 anoes é " +qntp);

        }
    }
}
