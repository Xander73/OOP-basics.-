using System;
using OtherMethods;

namespace OOP_basics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Переворачиваем строку задом на перед через цикл.");
            Console.WriteLine(ThirdLesson.ReverseStringLoop("abcd"));
            Console.WriteLine();


            Console.WriteLine("Переворачиваем строку задом на перед через стэк.");
            Console.WriteLine(ThirdLesson.ReverseStringStack("abcd"));
            Console.WriteLine();


            Console.WriteLine("Вытаскиваем электронные адреса и файла.");
            string s = "";
            ThirdLesson.SearchMail(ref s);
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
