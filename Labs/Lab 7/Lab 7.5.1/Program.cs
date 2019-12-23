using System;
namespace Lab_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Написати програму, що виконує наступні функції:
            1. Виводить на екран введене число з клавіатури в зворотному порядку (1234->4321)
            */
            int number;
            Console.Write("Enter number ");
            number = Convert.ToInt32(Console.ReadLine());
            NumberReverse(ref number);
            Console.WriteLine("New number {0}", number);
            Console.ReadLine();
        }
        static void NumberReverse(ref int number)
        {
            int temp, answer = 0;
            while (number != 0)
            {
                temp = number % 10;
                answer = answer * 10 + temp;
                number = number / 10;
            }
            number = answer;
        }
    }
}
