using System;

namespace Lab_7._7
{
    class Program
    {
         /*
         Реалізувати метод, що буде масив повертати задом навпаки (Використання
         Array.Reverse() заборонено!)
         */
        static void Main(string[] args)
        {
            char[] arr = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            ReverseArray(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.ReadLine();
        }
        static char[] ReverseArray( char[] array )
        {
            char[] arrayRevers = new char[array.Length];
            int counter = 0;
            for (int i = array.Length; i > 0; i--)
            {
                arrayRevers[counter] = array[i - 1];
                counter++;
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = arrayRevers[i];
                counter++;
            }
            return array;
        }
    }
}
