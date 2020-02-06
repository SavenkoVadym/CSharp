using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_9
{
    class Square : Shape, IDraw
    {
        // поля
        protected double sideLendth = 0;
        protected double squareArea = 0;
        protected double squarePerimetr = 0;

        // конструкторы
        public Square() { }
        protected Square(string name) : base(name, 4)
        {
            Random random = new Random();
            sideLendth = random.Next(1, 100);
        }
        protected Square(string name, double sideLendth) : base(name, 4)
        {
            this.sideLendth = sideLendth;
        }
        protected Square(string name, double sideLendth, string color) : base(name, 4, color)
        {
            this.sideLendth = sideLendth;
        }
        static public Square EnterData()
        {
            Square square;
            bool isName = true;
            bool isSideLendth = false;
            bool isColor = false;
            string name;
            double sideLendth;
            string color;
            do
            {
                Console.Write("Enter name of Square: ");
                name = Convert.ToString(Console.ReadLine());
                if (name == string.Empty)
                {
                    Console.WriteLine("incorrect name of Square");
                }
            } while (name == string.Empty);
            sideLendth = EnterDoubleNumber();
            if (sideLendth != 0)
            {
                isSideLendth = true;
            }
            else
            {
                Console.WriteLine("The data entered does not fit - random ones will be used.");
            }
            Console.Write("Enter Color of your Square: ");
            color = Convert.ToString(Console.ReadLine());
            if (color != string.Empty)
            {
                isColor = true;
            }
            else
            {
                Console.WriteLine("The data entered does not fit - random ones will be used.");
            }
            if (isName == true && isSideLendth == true)
            {
                if (isName == true && isSideLendth == true && isColor == true)
                {
                    square = new Square(name, sideLendth, color);
                    return square;
                }
                else
                {
                    square = new Square(name, sideLendth);
                    return square;
                }
            }
            else
            {
                square = new Square(name);
                return square;
            }
        }
        protected void DisplayData()
        {
            Console.WriteLine($"\nName: {nameOfShape}\nNumber of Verticles: {numberOfVertices}\nColor: {colorOfShape}\n" +
                $"Side Lendth: {sideLendth}\nArea: {squareArea}\nPerimetr: {squarePerimetr}");
        }
        //подсчет площади
        public override void CountArea()
        {
            squareArea = sideLendth * sideLendth;
            Console.WriteLine($"Square area = {squareArea}");
        }
        // подсчет периметра
        public override void CountPerimetr()
        {
            squarePerimetr = 4 * sideLendth;
            Console.WriteLine($"Square perimetr = {squarePerimetr}");
        }

        // ввод значения дабл

        public void Draw()
        {
            string colorOfLetters = colorOfShape;
            ChangeColorOfLetters(colorOfLetters);
            DisplayData();
            Console.ResetColor();
        }

    }
}
