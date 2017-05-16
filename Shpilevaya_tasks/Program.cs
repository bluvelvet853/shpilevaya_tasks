﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shpilevaya_tasks
{
    class Program
    {
        //Метод, который определяет уникальность символа
        static bool UnikalSymb(string text, char symb)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (symb == text[i])
                    return false;
            }
            return true;
        }
        //Метод, который считает процент символа в тексте
        static double PercentOfALetter(char[] textSymbols, char letter)
        {
            double procent = 0, numberOfLetters = 0;
            foreach (var i in textSymbols)
            {
                if (i == letter)
                {
                    numberOfLetters = numberOfLetters + 1;
                }

                procent = numberOfLetters/(textSymbols.Length/100);
            }
            return procent;
        }

        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\student\Desktop\kolobok.txt");
            Console.WriteLine(text);

            //Переведем текст в нижний регистр
            string lowerText = text.ToLower();
            Console.WriteLine(lowerText);


            //Cчитаем количество слов в исходном тексте
            string[] textWords = text.Split(new char[] { ' ', ',', '.', '—', '«', '»', '-' });
            Console.WriteLine("Количество слов: " + textWords.Length);

            //Считаем количество символов в исходном тексте
            char[] textSimbols = text.ToCharArray();
            Console.WriteLine("Количество символов: " + textSimbols.Length);

             //Поиск уникальных букв в тексте
            string unicalChar = "";
            foreach (var i in lowerText)
            {
                {
                    if (unicalChar.Length == 0)
                    {
                        unicalChar = unicalChar + i;
                    }
                    else
                    {
                        bool search = UnikalSymb(unicalChar, i);
                        if (search)
                        {
                            unicalChar = unicalChar + i;
                        }
                    }
                }
            }
            foreach (char i in unicalChar)
            {
                double procent = PercentOfALetter(textSimbols, i);
                Console.WriteLine("Процент символа \"{0}\" в тексте, равен : {1}%", i, procent);

            }
            Console.ReadKey();
        }
    }
}
