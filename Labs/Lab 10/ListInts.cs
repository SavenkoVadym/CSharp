using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10
{
    public class ListInts
    {
        protected List<int> list = new List<int>();
        protected int size = 0;
        public int Size { get; }
        public ListInts() { }
        protected int EnterData()
        {
            int data = -1;
            for (int i = 0; i < 1;)
            {
                Console.Write($"Enter element № {++size} (\"0\" or \"1\") = ");
                data = Convert.ToInt32(Console.ReadLine());
                if (data != 0 && data != 1)
                {
                    Console.WriteLine("Incorrect number");
                }
                else
                {
                    i++;
                }
            }
            return data;
        }
        public void AddElement()
        {
            list.Add(EnterData());
            size++;
        }
        public void DisplayList()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]}\n");
            }
        }
        public void DisplayElement(int i)
        {
            Console.Write($"{list[i]}");
        }
        public int[] ListToArray()
        {
            int[] myArray = list.ToArray();
            return myArray;
        }

    }
}
