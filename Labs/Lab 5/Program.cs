using System;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Дана матриця розміру m * n. Вивести кількість 1) рядків; 2)стовпчиків, елементи яких монотонно зростають (спадають).
             */
            int n, m;
            do
            {
                Console.Write("Enter number of rows ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Incorrect number of rows. Try again");
                }
            } while (n < 0);
            do
            {
                Console.Write("Enter number of collums ");
                m = Convert.ToInt32(Console.ReadLine());
                if (m < 0)
                {
                    Console.WriteLine("Incorrect number of collums. Try again");
                }
            } while (m < 0);
            Random r = new Random();
            int[,] array = new int[n, m];
            int a;
            do
            {
                Console.WriteLine("How you want enter data:\n1 - auto\n2 - manually");
                a = Convert.ToInt32(Console.ReadLine());
                if (a != 1 && a != 2)
                {
                    Console.WriteLine("incorrect type. Try again");
                }
            } while (a != 1 && a != 2);
            switch (a)
            {
                case 1:
                    {
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                array[i, j] = r.Next(100);
                                Console.Write("{0}\t", array[i, j]);
                            }
                            Console.Write("\n");
                        }
                        break;
                    }
                case 2:
                    {
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                Console.Write("Array[{0}][{1}] = ", i + 1, j + 1);
                                array[i, j] = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                Console.Write("{0}\t", array[i, j]);
                            }
                            Console.Write("\n");
                        }
                        break;
                    }
            }
            int b;
            do
            {
                Console.WriteLine("You want: \n1 - row growth\n2 - row fall\n3 - column growth\n4 - falling columns");
                b = Convert.ToInt32(Console.ReadLine());
                if (b != 1 && b != 2 && b != 3 && b != 4)
                {
                    Console.WriteLine("Incorrect action. Try again");
                }
            } while (b != 1 && b != 2 && b != 3 && b != 4);
            int counter = 0;
            int counterTwo = 0;
            switch (b)
            {
                case 1:
                    {
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m - 1; j++)
                            {
                                if (array[i, j] < array[i, j + 1])
                                {
                                    counter++;
                                }
                            }
                            if (counter == m - 1)
                            {
                                counterTwo++;
                            }
                            counter = 0;
                        }
                        Console.WriteLine("Rows that increase monotonically in this matrix = {0}", counterTwo);
                        break;
                    }
                case 2:
                    {
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m - 1; j++)
                            {
                                if (array[i, j] < array[i, j + 1])
                                {
                                    counter++;
                                }
                            }
                            if (counter == m - 1)
                            {
                                counterTwo++;
                            }
                            counter = 0;
                        }
                        Console.WriteLine("Rows that fall monotonously in this matrix = {0}", counterTwo);
                        break;
                    }
                case 3:
                    {
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m - 1; j++)
                            {
                                if (array[j, i] < array[j + 1, i])
                                {
                                    counter++;
                                }
                            }
                            if (counter == n - 1)
                            {
                                counterTwo++;
                            }
                            counter = 0;
                        }
                        Console.WriteLine("Collums that increase monotonically in this matrix = {0}", counterTwo);
                        break;
                    }
                case 4:
                    {
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m - 1; j++)
                            {
                                if (array[j, i] > array[j + 1, i])
                                {
                                    counter++;
                                }
                            }
                            if (counter == n - 1)
                            {
                                counterTwo++;
                            }
                            counter = 0;
                        }
                        Console.WriteLine("Collums that fall monotonously in this matrix ={0}", counterTwo);
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}
