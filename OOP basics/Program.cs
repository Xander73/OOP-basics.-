using Shapes;
using System;

namespace OOP_basics
{
    public class Program
    {        
        static void Main(string[] args)
        {
            BankAccount first = new BankAccount(100, AccountType.Current);

            BankAccount second = new BankAccount(100, AccountType.Current);

            Console.WriteLine("Operator == " + (first == second));

            Console.WriteLine("Operator != " + (first != second));

            Console.WriteLine("Method Equals - " + first.Equals(second));

            Console.WriteLine("Method Equals - " + first.Equals(first));

            Console.WriteLine();

            Console.WriteLine(first);

            Console.WriteLine("==========\nФигуры\n=========");

            Figure figure = new Point(10, 10);

            Console.WriteLine("Poin ToString");

            Console.WriteLine(figure.ToString());

            Console.WriteLine();

            figure = new Circle(20, 20, 5);

            Console.WriteLine("Circle ToString");

            Console.WriteLine(figure.ToString());

            Console.WriteLine("Circle area: " + ((Circle)figure).Areal());

            Console.WriteLine();

            figure = new Rectangle(50, 30, 5, 10);

            Console.WriteLine("Rectangle ToString");

            Console.WriteLine(figure.ToString());

            Console.WriteLine("Rectangle area: " + ((Rectangle)figure).Areal());

            Console.ReadKey();
        }
    }
}
