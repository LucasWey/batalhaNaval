    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[5, 5];
            int score = 0;
            int posia; 
            int posib;
            string cod;

            mat[0, 0] = 2;
            mat[0, 1] = 1;
            mat[0, 2] = 1;
            mat[0, 3] = 1;
            mat[0, 4] = 2;
            mat[1, 0] = 1;
            mat[1, 1] = 1;
            mat[1, 2] = 1;
            mat[1, 3] = 1;
            mat[1, 4] = 1;
            mat[2, 0] = 1;
            mat[2, 1] = 1;
            mat[2, 2] = 1;
            mat[2, 3] = 1;
            mat[2, 4] = 1;
            mat[3, 0] = 1;
            mat[3, 1] = 1;
            mat[3, 2] = 1;
            mat[3, 3] = 2;
            mat[3, 4] = 2;
            mat[4, 0] = 1;
            mat[4, 1] = 1;
            mat[4, 2] = 1;
            mat[4, 3] = 1;
            mat[4, 4] = 2;

            do
            {
                Console.WriteLine("Digite a posição da linha");
                cod = Console.ReadLine();
                posia = int.Parse(cod);

                Console.WriteLine("Digite a posição da coluna");
                cod = Console.ReadLine();
               posib = int.Parse(cod);

                if (mat[posia, posib] == 2)
                {
                    Console.WriteLine("Você encontrou uma bomba, tente novamente!");
                    Console.ReadKey();
                    Environment.Exit(0);

                }

                if (mat[posia, posib] == 1)
                {
                    score = score + 1;
                    Console.WriteLine("Piso vazio, prossiga");
                }
                if (score == 20)
                {
                    Console.WriteLine("Você ganhou! Parabéns!");
                    Console.ReadKey();
                    Environment.Exit(0);

                }
            } while ((score < 20) || (mat[posia, posib] == 1)) ;
        }
    }
}
