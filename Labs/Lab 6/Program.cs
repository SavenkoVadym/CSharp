using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            6.Створити ліст інтових змінних, який може вміщати тільки 1 і 0,
            заповнити його з клавіатури. Порахувати кількість 1 і 0. Скопіювати
            отриманий ліст в масив.
            */
            int a;
            int counter = 0, CountZero=0, CountOne=0;
            List<int> myInts = new List<int>();
            Console.WriteLine("To exit the fill, enter \"18\"");
            do
            {
                Console.Write("Enter {0} element = ", counter + 1);
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1 || a == 0)
                {
                    myInts.Add(a);
                    counter++;
                }
                else
                {
                    // 18 - способ выйти из заполнения списка
                    if (a != 18)
                    {
                        Console.WriteLine("Incorrect data. Might be only \"0\" or \"1\". Try again");
                    }
                    else
                    {
                        Console.WriteLine("You are out of fill List");
                    }
                }
            } while (a != 18);
            if (myInts != null)
            {
                foreach (var item in myInts)
                {
                    if (item == 0)
                        CountZero++;
                    if (item == 1)
                        CountOne++;
                }
                Console.WriteLine($"Count by zero: {CountZero}");
                Console.WriteLine($"Count by one: {CountOne}");
                //int countZero = myInts.Where(d => d == 0).Count();
                //int countOne = myInts.Where(d => d == 1).Count();
                int[] myArray = myInts.ToArray();
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write("{0}\t", myArray[i]);
                }
                Console.ReadLine();
            }
        }
    }
}