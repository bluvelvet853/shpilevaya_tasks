using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodirovka
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\student\Desktop\kolobok.txt");
            string smallText1 = text.ToLower();
            Console.WriteLine(smallText1);

            string[] smallText2 = new string[smallText1.Length];
            string[] smallText3 = new string[smallText1.Length];

            Random rnd = new Random();
            int value = rnd.Next(1, 7);
            Console.WriteLine(value);
            Console.WriteLine("КОДИРОВАНИЕ");
            for (int i = 0; i < smallText1.Length; i++)
            {
                char symbol = smallText1[i];
                Console.WriteLine(symbol);
                int nomerS = symbol;
                int newNomer = nomerS + value;
                Console.WriteLine(newNomer);
                char newSymbol = (char)newNomer;
                Console.WriteLine(newSymbol);
                smallText2[i] = Convert.ToString(newSymbol);
            }
            //и потом не знаю как вывести текст
            Console.WriteLine("ДЕКОДИРОВАНИЕ");
            for (int i = 0; i < smallText2.Length; i++)
            {
                char symbol = Convert.ToChar(smallText2[i]);
                Console.WriteLine(symbol);
                int nomerS = symbol;
                int oldNomer = nomerS - value;
                Console.WriteLine(oldNomer);
                char oldSymbol = (char)oldNomer;
                Console.WriteLine(oldSymbol);
                smallText3[i] = Convert.ToString(oldSymbol);
            }
            //и потом не знаю как вывести текст

            Console.ReadKey();
        }
    }
        }
    }
}
