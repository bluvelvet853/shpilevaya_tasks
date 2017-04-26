using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1= System.IO.File.ReadAllText(@"C:\Users\student\Desktop\kolobok.txt");
            Console.WriteLine(text1);
            string text = text1.ToLower();
            string[] ar = {",", ".", "—", "«", "»", "!", "?"};

            for (int a = 0; a < ar.Length; a++)
            {
                text = text.Replace(ar[a], "");
            }
            char[] seps = { ' ' };
            string[] parts = text.Split(seps);
            int min = 100;
            int x = 0;
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].Length < min)
                {
                    min = parts[i].Length;
                    x = i;
                }
            }
            Console.WriteLine("Самое короткое слово \"" + parts[x] + "\"");


            int max = 10;
            int y = 0;
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i].Length > max)
                {
                    max = parts[i].Length;
                    y = i;
                }
            }
            Console.WriteLine("Самое длинное слово \"" + parts[y] + "\"");

            Console.ReadKey();
        }
    }
}
