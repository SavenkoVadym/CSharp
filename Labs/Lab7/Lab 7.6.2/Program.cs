using System;

namespace Lab_7._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static string Method_Recursion(char[] arr, char[] arrReverse, int i, int j)
        {
            arrReverse[j] = arr[i - 1];
            if (arrReverse[arr.Length - 1] == '\0')
            {
                return Method_Recursion(arr, arrReverse, i - 1, j + 1);
            }
            else
            {
                string revers_string = new string(arrReverse);
                return revers_string;
            }
        }
    }
}
