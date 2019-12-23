using System;

namespace Lab_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            GoogleGlass glasses = new GoogleGlass("");
            MobileWithColorScreen phone = new MobileWithColorScreen("");
            glasses.GetName();
            phone.GetName();
            Console.ReadLine();
        }
    }
}
