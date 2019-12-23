using System;
namespace Lab_7._3
{
    class Program
    {
        /*
         Дробові числа виводяться в зворотному порядку і ціла частина і дробова (123.456->321.654)
         */
        static void Main(string[] args)
        {
            Console.Write("Enter your number");
            string myString= Convert.ToString(Console.ReadLine());
            NumberReverse(ref myString);
            
            Console.WriteLine(myString);
        }
        static void NumberReverse(ref string myString)
        {
            char[] charArray = myString.ToCharArray();
            char[] charArrayReverse = new char[charArray.Length];
            int counter = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == '.')
                {
                    counter = i + 1;
                }
            }
            char[] firstPart = new char[counter];
            char[] secondPart = new char[(charArray.Length) - counter]; int counterOne = 0;
            for (int i = counter - 2; i >= 0; i--)
            {
                firstPart[counterOne] = charArray[i];
                counterOne++;
            }
            firstPart[counter - 1] = '.';
            int counterTwo = 0;
            for (int i = charArray.Length - 1; i > counter - 1; i--)
            {
                secondPart[counterTwo] = charArray[i];
                counterTwo++;
            }
            for (int i = 0; i < counter; i++)
            {
                charArrayReverse[i] = firstPart[i];

            }
            int counterThree = 0;
            for (int i = counter; i < charArray.Length; i++)
            {
                charArrayReverse[i] = secondPart[counterThree];
                counterThree++;

            }
            myString = new string(charArrayReverse);
        }
    }
}
