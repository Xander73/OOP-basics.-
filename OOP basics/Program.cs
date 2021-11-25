using _7_Lesson;
using System;

namespace OOP_basics
{
    public class Program
    {        
        static void Main(string[] args)
        {
            //int a = 'a';
            //int b = 'z';
            //int c = 'A';
            //int d = 'Z';
            //Console.WriteLine("a - z - A - Z");
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine();
            //Console.WriteLine();

            Console.WriteLine("Encryption");
            ICoder coder = new ACoder("Abc");
            Console.WriteLine("A Encoding - " + coder.Encode());
            Console.WriteLine("A Decoding - " + coder.Decode());
            Console.WriteLine();
            coder = new BCoder("Abc");
            Console.WriteLine("B Encoding - " + coder.Encode());
            Console.WriteLine("B Decoding - " + coder.Decode());
            Console.WriteLine();


            Console.WriteLine("==========\nФигуры\n=========");

            Figure figure = new Point(10, 10);

            Console.WriteLine("Poin ToString");

            Console.WriteLine(figure.ToString());

            Console.WriteLine();

            figure = new Circle(20, 20, 5);

            Console.WriteLine("Circle ToString");

            Console.Write(figure.ToString());

            Console.WriteLine("Circle area: " + ((Circle)figure).Areal());

            Console.WriteLine();

            figure = new Rectangle(50, 30, 5, 10);

            Console.WriteLine("Rectangle ToString");

            Console.Write(figure.ToString());

            Console.WriteLine("Rectangle area: " + ((Rectangle)figure).Areal());

            Console.ReadKey();
        }
    }
}
