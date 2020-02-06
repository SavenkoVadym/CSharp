using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nn, nk;
            do
            {
                Console.WriteLine("Enter nn:");
                nn = Convert.ToInt32(Console.ReadLine());
                if (nn < 0)
                {
                    Console.WriteLine("Incorrect value nn");
                }
            } while (nn < 0);
            do
            {
                Console.WriteLine("Enter nk:");
                nk = Convert.ToInt32(Console.ReadLine());
                if (nk < nn)
                {
                    Console.WriteLine("Incorrect value nk");
                }
            } while (nk < nn);
            double summ = 0, temp;
            for (int i = nn; i < nk; i++)
            {
                temp = (((-1) ^ ((nn ^ 2) + 1)) * (nn ^ 2) - 2) / ((nn ^ 2) + 3);
                summ += temp;
                Console.WriteLine("Summ is {0}", summ);
            }
            Console.WriteLine(" All Summ is {0}", summ);
            Console.ReadLine();
        }
    }
}