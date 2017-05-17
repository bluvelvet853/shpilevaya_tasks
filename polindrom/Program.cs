using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\student\Desktop\kolobok.txt");
            // считываем текст
            Console.WriteLine("Текст: " + text);
            // выводим текст
            string smallText = text.ToLower(); //переводим текст в нижний регистр
            string slova = smallText.Trim(new char[] { ',', '.', '—', '«', '»', '-' });
            string[] textSlova = slova.Split(new char[] { ',', '.', ' ', '—', '«', '»', '-' });
            // исключаем символы из текста
            string palindrom = null;
            for (int i = 0; i < textSlova.Length; i++)
            {
                string slovo = textSlova[i];
                int t = 0;
                if (textSlova[i].Trim() != "")
                {
                    if (slovo.Length != 1)
                    {
                        if (slovo.Length % 2 == 0)
                        {
                            for (int a = 0; a < (slovo.Length / 2); a++)
                            {
                                char bukva1 = slovo[a];
                                int b = slovo.Length - 1;

                                char bukva2 = slovo[b - a];
                                if (bukva1 == bukva2)
                                {
                                    t = t + 1;
                                }
                            }

                            if (t == slovo.Length / 2)
                            {
                                palindrom = palindrom + slovo + " ";
                            }
                        }
                        else
                        {
                            for (int a = 0; a < ((slovo.Length - 1) / 2); a++)
                            {
                                char bukva1 = slovo[a];
                                int b = slovo.Length - 1;

                                char bukva2 = slovo[b - a];
                                if (bukva1 == bukva2)
                                {
                                    t = t + 1;
                                }
                            }
                            if (t == slovo.Length / 2)
                            {
                                palindrom = slovo + " ";
                                Console.WriteLine("Палиндромом является слово - " + palindrom);
                                // вывод палиндрома
                            }                            
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
