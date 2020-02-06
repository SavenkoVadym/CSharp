using System;
namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             19. Даний масив розміру N. Знайти номери двох найближчих чисел з цього масиву.
             */
            int N;
            do
            {
                Console.Write("Enter number of element in the array ");
                N = Convert.ToInt32(Console.ReadLine());
                if (N < 0)
                {
                    Console.WriteLine("Incorrect number of elementsin the array. Try again");
                }
            } while (N < 0);
            int[] arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("arr {0} = ", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < N; i++)
            {
                Console.Write(arr[i]); Console.Write("\t");
            }
            int a = arr[0], b = arr[0]; //числа
            int aPos = 0, bPos = 0; // позиция
            int difference = Math.Abs(arr[0] - arr[1]); // их разница
            for (int i = 1; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) < difference && i != j)
                    {
                        a = arr[i];
                        b = arr[j];
                        aPos = i;
                        bPos = j;
                        difference = Math.Abs(arr[i] - arr[j]);
                    }
                }
            }
            Console.WriteLine("\nThe two closest by the value of the number is the number a ={0} and b ={1}, which are in the list at the positions {2} and {3}", a, b, aPos + 1, bPos + 1);
            Console.ReadLine();
        }
    }
}
