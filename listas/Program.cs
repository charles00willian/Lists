using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas
{
    class Program
    {
        static int menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Exibir lista");
            Console.WriteLine("2 - Inserir elemento");
            Console.WriteLine("3 - Alterar elemento");
            Console.WriteLine("4 - Remover elemento");
            Console.WriteLine("5 - Contar elementos");
            Console.WriteLine("6 - Somar elementos");
            Console.WriteLine("7 - Maior elemento");
            Console.WriteLine("8 - Inserir elemento depois");
            Console.WriteLine("9 - Inserir elemento antes");
            Console.WriteLine("15 - Sair");
            Console.Write("Opção: ");

            return (int.Parse(Console.ReadLine()));
        }

        static void Main(string[] args)
        {
            int op;

            do
            {
                op = menu();

                switch (op)
                {
                    case 1:
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        break;

                    case 7:
                        break;

                    case 8:
                        break;

                    case 9:
                        break;
                }

            } while (op != 15);
        }
    }
}