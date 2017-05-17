using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\black\Desktop\Владелецтелефона.txt");
            string[] mus = text.Split('.');
            for (int i = 0; i<mus.Length; i++)
            {
                string[] muss = mus[i].Split(new char[]{';'});

                if (muss[4].StartsWith("720")) 
                {
                    Console.WriteLine("Фамилия: {0}\r\n Имя: {1}\r\n  Отчество: {2}\r\n Адрес: {3}\r\n Номер: {4}\r\n", muss[0], muss[1], muss[2], muss[3], muss[4]);
                }
            }
            Console.ReadKey();
        }
    }
}
