using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvMas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArr = new int[5, 6];
            Random ran = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    myArr[i, j] = ran.Next(1, 10);
                    Console.Write("{0}\t", myArr[i, j]);
                }
            }
            int st = 0;
            for (int j = 0; j < 6; j++)
            {
                int srar = 0;
                int itog = 0;
                for (int i = 0; i < 5; i++)
                {
                    srar += myArr[i, j];
                    itog = srar / 5;
                }
                st = st + 1;
                Console.WriteLine("Среднее арифметическое {0} столбца = {1}", st, itog);
            }

            int min = 0;
            int max = 0;
            for (int i = 0; i < 5; i++)
            {
                max = 0;
                min = 0;
                for (int j = 0; j < 6; j++)
                {
                    int ch = j;
                    max = ch;
                    if (ch >= max)
                    {
                        max = ch;
                    }
                    else
                        min = ch;
                }
                Console.WriteLine(max);
                Console.WriteLine(min);
            }
            Console.ReadKey();
        }
    }
}
