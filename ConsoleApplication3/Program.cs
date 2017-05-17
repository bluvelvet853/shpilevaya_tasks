using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myMas = new int[5, 6];
            Random ran = new Random();
            int colstrok = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    myMas[i, j] = ran.Next(1, 9);
                    Console.Write("{0}\t", myMas[i, j]);
                }
            }

            for (int i = 0; i < 10; i++)
            {
                int summ = 0;
                for (int j = 0; j < 10; j++)
                {
                    summ += myMas[i, j];

                }
                colstrok = colstrok + 1;
                Console.WriteLine("Сумма {0} = {1}", colstrok, summ);

            }
            Console.ReadKey();
        }
    }
}

