using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvMasPrim
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArr = new int[7, 7];
            Random ran = new Random();
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    myArr[i, j] = ran.Next(1, 10);
                    Console.Write("{0}\t", myArr[i, j]);
                }
            }
            int str = 0;
            int max = 0;
            int summa1 = 0;
            int c = 0;
            for (int i = 0; i < 7; i++)
            {
                int summa = 0;
                for (int j = 0; j < 7; j++)
                {
                    summa += myArr[i, j];
                    if (summa >= summa1)
                    {
                        max = summa;
                        c = i+1;
                    }
                    else
                    {
                        max = summa1;
                    }
                }
                summa1 = max;
                str = str + 1;
              Console.WriteLine("\r\n Сумма {0} строки = {1}", str, summa);
            }
            Console.WriteLine("\r\n Строкой с максимальной суммой является {0} строка, ее сумма равна {1}", c, summa1);
            Console.ReadKey();
        }
    }
}
