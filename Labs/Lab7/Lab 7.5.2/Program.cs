using System;
namespace Lab_7._2
{
    class Program
    {
        /*
        Виводить будь-яку строку в зворотному порядку(АБВ-> ВБА)
        */
        static void Main(string[] args)
        {
            string myString;
            myString = Convert.ToString(Console.ReadLine());
            StringReverse(ref myString);
            Console.WriteLine($"{myString}");
            Console.ReadLine();
        }
        static void StringReverse(ref string str)
        {
            char[] myChar = str.ToCharArray();
            char[] myCharReverse = new char[myChar.Length];
            int j = 0;
            for (int i = myChar.Length; i > 0; i--)
            {
                myCharReverse[j] = myChar[i - 1];
                j++;
            }
            string myStringReverse = new string(myCharReverse);
            str = myStringReverse;
        }
    }
}
