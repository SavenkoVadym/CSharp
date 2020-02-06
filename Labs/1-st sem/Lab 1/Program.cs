using System;
namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             4. Обчислення опору електричного ланцюга, що складається з трьох
                послідовно з'єднаних резисторів
                Формула R = R1 + R2 + R3
             */
            double a, b, c, d;
            Console.Write("Enter R1: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter R2: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter R3: ");
            c = Convert.ToDouble(Console.ReadLine());
            d = a + b + c;
            Console.WriteLine("Total circuit resistance = {0}", d);
            Console.ReadLine();
        }
    }
}
