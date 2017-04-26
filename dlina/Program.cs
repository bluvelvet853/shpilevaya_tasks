using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlina
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\student\Desktop\kolobok.txt");
            Console.WriteLine(text);

            //удаляем пробелы в конце и начале строки (если они есть)
            text = text.Trim();

            //заносим в массив Arr все слова, разделённые пробелом
            string[] Arr = text.Split(' ');

            int min = 999999;
            int max = 0;

            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i].Length < min) min = Arr[i].Length;
                if (Arr[i].Length > max) max = Arr[i].Length;
            }

            Console.WriteLine("Самое длинное слово: {0}\nСамое короткое слово: {1}", max, min);
            Console.ReadKey();
        }
    }
}
