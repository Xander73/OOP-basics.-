using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace OtherMethods
{    
    public class ThirdLesson
    {
        /// <summary>
        /// Этот метод хорош тем, что мы обходим только половину строки.
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string ReverseStringLoop (string inputString)
        {
            StringBuilder strBilder = new StringBuilder (inputString);
            char temp;
            int stringLenght = inputString.Length - 1;
            for (int i = 0; i < inputString.Length; ++i)
            {
                if (i >= inputString.Length / 2)
                {
                    break;
                }
                temp = inputString[i];
                strBilder[i] = strBilder[stringLenght - i];
                strBilder[stringLenght - i] = temp;
            }
            return strBilder.ToString();
        }

        /// <summary>
        /// Ленивый метод. Если система тянет, то можно и так.))
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string ReverseStringStack (string inputString)
        {
            Stack<char> outputString = new Stack<char>();
            foreach (char item in inputString)
            {
                outputString.Push(item);
            }
            return new string(outputString.ToArray());
        }


        /// <summary>
        /// Парсинг электронных адресов.
        /// </summary>
        public static void SearchMail(ref string s)
        {
            //создаем файл, из которого будем читать строку
            string writeString = "Кучма Андрей Витальевич & Kuchma@mail.ru Мизинцев Павел Николаевич & Pasha@mail.ru";
            File.WriteAllText(Directory.GetCurrentDirectory() + "\\contacts.txt", writeString);
            //чтение из файла

            string [] readString = null;
            try
            {
                readString = File.ReadAllText(Directory.GetCurrentDirectory() + "\\contacts.txt").Split(' ');
            }
            catch (Exception)
            {
                Console.WriteLine(("Ошибка в " + typeof(ThirdLesson).ToString())); 
            }

            //if (readString != null)
            //{
            //    for (int i = 0; i < readString.Length; ++i)
            //    {
            //        if (readString[i] == "&")
            //        {
            //            s += readString[++i] + '\n';
            //        }
            //    }
            //}

            //и пока писал очевидный способ подумал о LINQ
            s = string.Concat(readString.Where(s => s.Contains('@')).Select(x => x + '\n').ToArray());
            File.WriteAllText(Directory.GetCurrentDirectory() + "\\emails.txt", s);
        }

    }
}
