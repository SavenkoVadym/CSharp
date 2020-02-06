using System;

namespace Lab_7._4
{
    class Program
    {
        /*
        Виводити будь-яку строку в зворотному порядку і всі елементи після “магічного
        знаку” теж в зворотному (АБВ,ГДЕ->ВБА,ЕДГ)
        */
         // магический знак " , "
        static void Main(string[] args)
        {
            string str = "hello,hello";
            StringReverse(ref str);
            Console.WriteLine(str);
        }
        static void StringReverse(ref string myString)
        {
            char[] charArray = myString.ToCharArray();
            char[] charArrayReverse = new char[charArray.Length];
            int counter = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == ',')
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
            firstPart[counter - 1] = ',';
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
