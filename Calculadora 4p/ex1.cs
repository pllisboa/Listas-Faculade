using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static double som(double n1, double n2)
        {
            return n1 + n2;
        }

        static double sub(double n1, double n2)
        {
            return n1 - n2;
        }

        static double mul(double n1, double n2)
        {
            return n1 * n2;
        }

        static double div(double n1, double n2)
        {
            return n1 / n2;
        }

        static double pot(double n1, double n2)
        {
            return Math.Pow(n1, n2);
        }

        static double rac(double n1)
        {
            return Math.Sqrt(n1);
        }

        static void RegistrarResultado(double resultado, List<double> lista, Queue<double> fila, Stack<double> pilha)
        {
            lista.Add(resultado);
            fila.Enqueue(resultado);
            pilha.Push(resultado);
        }

        static void Main(string[] args)
        {
            List<double> ListaResultado = new List<double>();
            Queue<double> Fila = new Queue<double>();
            Stack<double> Pilha = new Stack<double>();

            while (true)
            {
                Console.WriteLine("CALCULADORA\n");
                Console.WriteLine("Digite a opção desejada");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("5 - Potencializar");
                Console.WriteLine("6 - Racionalizar");
                Console.WriteLine("7 - Listar resultados (lista)");
                Console.WriteLine("8 - Listar resultados (fila)");
                Console.WriteLine("9 - Listar resultados (pilha)");
                Console.WriteLine("10 - Buscar na lista (por índice ou valor)");
                Console.WriteLine("11 - Sair");

                int op;

                if (!int.TryParse(Console.ReadLine(), out op))
                {
                    Console.WriteLine("Opção invalida! Digite um numero.");
                    continue;
                }

                switch (op)
                {
                    case 1:
                        {
                            Console.WriteLine("Digite o primeiro valor para ser somado com o segundo\n Primeiro valor:");
                            double n1;

                            if (!double.TryParse(Console.ReadLine(), out n1))
                            {
                                Console.WriteLine("Opção invalida! Digite um numero.");
                                continue;
                            }

                            Console.WriteLine("\nSegundo valor:");
                            double n2;

                            if (!double.TryParse(Console.ReadLine(), out n2))
                            {
                                Console.WriteLine("Opção invalida! Digite um numero.");
                                continue;
                            }

                            double Rsom = som(n1, n2);
                            Console.WriteLine("Resultado da soma é =" + Rsom);
                            RegistrarResultado(Rsom, ListaResultado, Fila, Pilha);
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Digite o primeiro valor para ser subtraido com o segundo\n Primeiro valor:");
                            double n1;

                            if (!double.TryParse(Console.ReadLine(), out n1))
                            {
                                Console.WriteLine("Opção invalida! Digite um numero.");
                                continue;
                            }

                            Console.WriteLine("\nSegundo valor:");
                            double n2;

                            if (!double.TryParse(Console.ReadLine(), out n2))
                            {
                                Console.WriteLine("Opção invalida! Digite um numero.");
                                continue;
                            }

                            double Rsub = sub(n1, n2);
                            Console.WriteLine("Resultado da subtração é =" + Rsub);
                            RegistrarResultado(Rsub, ListaResultado, Fila, Pilha);
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("Digite o primeiro valor para ser multiplicado com o segundo\n Primeiro valor:");
                            double n1;

                            if (!double.TryParse(Console.ReadLine(), out n1))
                            {
                                Console.WriteLine("Opção invalida! Digite um numero.");
                                continue;
                            }

                            Console.WriteLine("\nSegundo valor:");
                            double n2;

                            if (!double.TryParse(Console.ReadLine(), out n2))
                            {
                                Console.WriteLine("Opção invalida! Digite um numero.");
                                continue;
                            }

                            double Rmul = mul(n1, n2);
                            Console.WriteLine("Resultado da multiplicação é =" + Rmul);
                            RegistrarResultado(Rmul, ListaResultado, Fila, Pilha);
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("Digite o primeiro valor para ser divido com o segundo\n Primeiro valor:");
                            double n1;

                            if (!double.TryParse(Console.ReadLine(), out n1))
                            {
                                Console.WriteLine("Opção invalida! Digite um numero.");
                                continue;
                            }

                            Console.WriteLine("\nSegundo valor:");
                            double n2;

                            if (!double.TryParse(Console.ReadLine(), out n2))
                            {
                                Console.WriteLine("Opção invalida! Digite um numero.");
                                continue;
                            }

                            if (n2 == 0)
                            {
                                Console.WriteLine("Divisão por 0 invalida");
                            }
                            else
                            {
                                double Rdiv = div(n1, n2);
                                Console.WriteLine("Resultado da divisão é =" + Rdiv);
                                RegistrarResultado(Rdiv, ListaResultado, Fila, Pilha);
                            }

                            break;
                        }

                    case 5:
                        {
                            Console.WriteLine("Digite o primeiro valor para ser potencializado pelo o segundo\n Primeiro valor:");
                            double n1;

                            if (!double.TryParse(Console.ReadLine(), out n1))
                            {
                                Console.WriteLine("Opção invalida! Digite um numero.");
                                continue;
                            }

                            Console.WriteLine("\nSegundo valor:");
                            double n2;

                            if (!double.TryParse(Console.ReadLine(), out n2))
                            {
                                Console.WriteLine("Opção invalida! Digite um numero.");
                                continue;
                            }

                            double Rpot = pot(n1, n2);
                            Console.WriteLine("Resultado da potencialização é =" + Rpot);
                            RegistrarResultado(Rpot, ListaResultado, Fila, Pilha);
                            break;
                        }

                    case 6:
                        {
                            Console.WriteLine("Digite o valor para ser calculado sua raiz quadrada:");
                            double n1;

                            if (!double.TryParse(Console.ReadLine(), out n1))
                            {
                                Console.WriteLine("Valor inválido! Digite um número.");
                                continue;
                            }

                            double Rrac = rac(n1);
                            Console.WriteLine("Resultado da racionalização é =" + Rrac);
                            RegistrarResultado(Rrac, ListaResultado, Fila, Pilha);
                            break;
                        }

                    case 7:
                        {
                            Console.WriteLine("\nRESULTADOS (LISTA):");

                            if (ListaResultado.Count == 0)
                            {
                                Console.WriteLine("Nenhum resultado ainda.");
                            }
                            else
                            {
                                for (int i = 0; i < ListaResultado.Count; i++)
                                {
                                    Console.WriteLine("[" + i + "] " + ListaResultado[i]);
                                }
                            }
                            break;
                        }

                    case 8:
                        {
                           
                            Console.WriteLine("\nRESULTADOS (FILA - FIFO, do mais antigo para o mais novo):");

                            if (Fila.Count == 0)
                            {
                                Console.WriteLine("Fila vazia.");
                            }
                            else
                            {
                                foreach (double resultado in Fila.ToArray())
                                {
                                    Console.WriteLine(resultado);
                                }
                            }
                            break;
                        }

                    case 9:
                        {
                            Console.WriteLine("\nRESULTADOS (PILHA - LIFO, do mais novo para o mais antigo):");

                            if (Pilha.Count == 0)
                            {
                                Console.WriteLine("Pilha vazia.");
                            }
                            else
                            {
                                foreach (double resultado in Pilha)
                                {
                                    Console.WriteLine(resultado);
                                }
                            }
                            break;
                        }

                    case 10:
                        {
                            if (ListaResultado.Count == 0)
                            {
                                Console.WriteLine("Nenhum resultado ainda.");
                                break;
                            }

                            Console.WriteLine("\nComo deseja buscar?");
                            Console.WriteLine("1 - Por índice");
                            Console.WriteLine("2 - Por resultado específico (valor)");

                            int tipoBusca;
                            if (!int.TryParse(Console.ReadLine(), out tipoBusca))
                            {
                                Console.WriteLine("Opção inválida!");
                                continue;
                            }

                            if (tipoBusca == 1)
                            {
                                Console.WriteLine("Digite o índice (0 a " + (ListaResultado.Count - 1) + "):");
                                int indice;

                                if (!int.TryParse(Console.ReadLine(), out indice))
                                {
                                    Console.WriteLine("Índice inválido! Digite um número inteiro.");
                                    continue;
                                }

                                if (indice < 0 || indice >= ListaResultado.Count)
                                {
                                    Console.WriteLine("Índice fora do intervalo.");
                                }
                                else
                                {
                                    Console.WriteLine("Resultado no índice " + indice + " = " + ListaResultado[indice]);
                                }
                            }
                            else if (tipoBusca == 2)
                            {
                                Console.WriteLine("Digite o valor do resultado que deseja buscar:");
                                double valor;

                                if (!double.TryParse(Console.ReadLine(), out valor))
                                {
                                    Console.WriteLine("Valor inválido!");
                                    continue;
                                }

                                int indiceEncontrado = ListaResultado.IndexOf(valor);

                                if (indiceEncontrado == -1)
                                {
                                    Console.WriteLine("Resultado " + valor + " não encontrado na lista.");
                                }
                                else
                                {
                                    Console.WriteLine("Resultado " + valor + " encontrado no índice " + indiceEncontrado + ".");

                                    var ocorrencias = ListaResultado
                                        .Select((valorAtual, idx) => new { valorAtual, idx })
                                        .Where(x => x.valorAtual == valor)
                                        .Select(x => x.idx)
                                        .ToList();

                                    if (ocorrencias.Count > 1)
                                    {
                                        Console.WriteLine("Também aparece nos índices: " + string.Join(", ", ocorrencias));
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Opção inválida!");
                            }

                            break;
                        }

                    case 11:
                        {
                            Console.WriteLine("Encerrando");
                            return;
                        }

                    default:
                        Console.WriteLine("Opção Invalida");
                        break;
                }
            }
        }
    }
}