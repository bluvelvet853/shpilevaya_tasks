using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvMas19
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
            for (int i = 0; i < 7; i++)
            {
                int summa = 0;
                for (int j = 0; j < 7; j++)
                {
                    summa += myArr[i, j];
                }
                str = str + 1;
                Console.WriteLine("\r\n Сумма {0} строки = {1}", str, summa);
            }
            int summa2 = 0;
            int max = 0;
            for (int i = 0; i < 7; i++)
            {
                int summa1 = 0;
                for (int j = 0; j < 7; j++)
                {
                    summa1 += myArr[i, j];
                    if (summa2 >= summa1)
                    {
                        max = summa2;
                    }
                    else
                    {
                        max = summa1;
                    }
                }
                summa2 = summa1;
            }
            Console.WriteLine("\r\n Наибольшая сумма элементов равна " + max);
            Console.ReadKey();
        }
    }
}
