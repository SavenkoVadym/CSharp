using System;

namespace Lab_7._6._3
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static char[] ArrayRecursion(int k, int g, char[] arrReverse, char[] a, char[] b, int i, int j, int arrLenght)
        {
            if (i < k)
            {
                arrReverse[i] = a[i];
                return ArrayRecursion(k, g, arrReverse, a, b, i + 1, j, arrLenght);
            }
            else
            {
                if (g < arrLenght)
                {
                    arrReverse[g] = b[j];
                    return ArrayRecursion(k, g + 1, arrReverse, a, b, i, j + 1, arrLenght);
                }
                else
                {
                    return arrReverse;
                }
            }

        }
    }
}
