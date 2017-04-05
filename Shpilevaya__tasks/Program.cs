using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shpilevaya__tasks
{
    class Program
    {
        struct MyType
        {
            public MyType(string T, int C)
            {
                symb = T;
                coun = C;
            }

            public string symb;
            public int coun;
        }
        static List<MyType> list = new List<MyType>();

        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();

            int l = s.Length;

            for (int i = 0; i < l; i++) // распределение символов в текстовой строке
            {
                char temp = s[i];
                bool e = true;
                for (int t = 0; t < list.Count; t++)
                {
                    if (temp.ToString() == list[t].symb)
                    {
                        e = false;
                    }
                }
                if (e == true)
                {
                    int count = 0;
                    for (int j = 0; j < l; j++)
                    {

                        if (temp == s[j])
                        {
                            count++;
                        }
                    }
                    list.Add(new MyType(temp.ToString(), count));
                }
            }

            for (int y = 0; y < list.Count; y++)
            {
                Console.WriteLine(list[y].symb + " - " + list[y].coun);
            }
            Console.ReadKey();
        }
    }
}

