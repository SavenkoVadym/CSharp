using System;

namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square;
            square = Square.EnterData();
            square.Draw();
            Triangle triangle;
            triangle = Triangle.EnterData();
            triangle.Draw();
            Circle circle;
            circle = Circle.EnterData();
            circle.Draw();


            Console.ReadKey();
        }
    }
}
