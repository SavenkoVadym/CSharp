using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_9
{
    abstract class Shape
    {
        protected string colorOfShape { get; set; }
        protected int numberOfVertices { get; }
        protected string nameOfShape { get; }

        //типа базовый наборцветов для случайного задавания цвета

        string[] colors = { "Black", "Blue", "Cyan", "DarkBlue", "DarkCyan", "DarkGray", "DarkGreen", "DarkMagenta", "DarkRed", "DarkYellow",
            "Gray","Green","Magenta","Red","White","Yellow"};

        //кострукторы
        protected Shape() { }
        protected Shape(string nameOfShape, int numberOfVertices)
        {
            this.nameOfShape = nameOfShape;
            this.numberOfVertices = numberOfVertices;
            Random rndm = new Random();
            colorOfShape = colors[rndm.Next(0, colors.Length)];
        }
        protected Shape(string nameOfShape, int numberOfVertices, string colorOfShape)
        {
            this.nameOfShape = nameOfShape;
            this.numberOfVertices = numberOfVertices;
            this.colorOfShape = colorOfShape;
        }
        abstract public void CountArea();
        abstract public void CountPerimetr();
        // то что надо во всех классах, одно на все и везде будет сделано

        protected static double EnterDoubleNumber()
        {
            double number = 0;
            Console.Write("Enter Side Lendth: ");
            string str1 = Convert.ToString(Console.ReadLine());
            if (str1 != string.Empty)
            {
                bool isAllNumbers = true;
                char[] charArray = str1.ToCharArray();
                for (int i = 0; i < charArray.Length; i++)
                {
                    if (!char.IsDigit(charArray[i]))
                    {
                        if (charArray[i] != '.')
                        {
                            if (charArray[i] != ',')
                            {
                                isAllNumbers = false;
                                break;
                            }
                        }
                    }
                    if (charArray[i] == '.')
                    {
                        charArray[i] = ',';
                    }
                }
                if (isAllNumbers == true)
                {
                    string str2 = new string(charArray);
                    number = Convert.ToDouble(str2);
                }
                if (number < 0)
                {
                    number = 0;
                }
            }
            return number;
        }
        protected void ChangeColorOfLetters(string s)
        {
            switch (s)
            {
                case "Black":
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        break;
                    }
                case "Blue":
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    }
                case "Cyan":
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    }
                case "DarkBlue":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    }
                case "DarkCyan":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        break;
                    }
                case "DarkGray":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        break;
                    }
                case "DarkGreen":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    }
                case "DarkMagenta":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        break;
                    }
                case "DarkRed":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    }
                case "DarkYellow":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                    }
                case "Gray":
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    }
                case "Green":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    }
                case "Magenta":
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    }
                case "Red":
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    }
                case "White":
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                case "Yellow":
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Такого цвета нет ConsoleColor, поэтому будет стандартный белый");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
            }
        }
    }
}
