using System;
namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3-й вариант
            double x, y;
            Console.WriteLine("Enter x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y");
            y = Convert.ToDouble(Console.ReadLine());
            if ((x < 0 && y < 0) || (x > 0 && y > 0)) 
            {
                Console.WriteLine("This point in 1-st or 3-d part");
            }
            else
            {
                Console.WriteLine("This point isnt in 1 - st or 3 - d part");
            }
            Console.ReadLine();
        }
    }
}
