using System;

namespace Lab_7._8
{
    class Program
    {
        static void Main(string[] args)
        {       
            char[] a = { 'h', 'e', 'l', 'l', 'o' };
            ArrayReverse(ref a);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        static void ArrayReverse(ref char[] myChar)
        {
            char[] myCharReverse = new char[myChar.Length];
            int j = 0;
            for (int i = myChar.Length; i > 0; i--)
            {
                myCharReverse[j] = myChar[i - 1];
                j++;
            }           
            myChar = myCharReverse;
        }
    }
}
