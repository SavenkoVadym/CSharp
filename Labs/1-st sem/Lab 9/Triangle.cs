using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_9
{
    class Triangle : Shape, IDraw
    {
        // поля
        protected double sideLendth = 0;
        protected double triangleArea = 0;
        protected double trianglePerimetr = 0;

        // конструкторы
        public Triangle() { }
        protected Triangle(string name) : base(name, 3)
        {
            Random random = new Random();
            sideLendth = random.Next(1, 100);
        }
        protected Triangle(string name, double sideLendth) : base(name, 3)
        {
            this.sideLendth = sideLendth;
        }
        protected Triangle(string name, double sideLendth, string color) : base(name, 3, color)
        {
            this.sideLendth = sideLendth;
        }

        static public Triangle EnterData()
        {
            Triangle triangle;
            bool isName = true;
            bool isSideLendth = false;
            bool isColor = false;
            string name;
            double sideLendth;
            string color;
            do
            {
                Console.Write("Enter name of Triangle: ");
                name = Convert.ToString(Console.ReadLine());
                if (name == string.Empty)
                {
                    Console.WriteLine("incorrect name of Triangle");
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
            Console.Write("Enter Color of your Trianle: ");
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
                    triangle = new Triangle(name, sideLendth, color);
                    return triangle;
                }
                else
                {
                    triangle = new Triangle(name, sideLendth);
                    return triangle;
                }
            }
            else
            {
                triangle = new Triangle(name);
                return triangle;
            }
        }
        protected void DisplayData()
        {
            Console.WriteLine($"\nName: {nameOfShape}\nNumber of Verticles: {numberOfVertices}\nColor: {colorOfShape}\n" +
                $"Side Lendth: {sideLendth}\nArea: {triangleArea}\nPerimetr: {trianglePerimetr}");
        }
        //подсчет площади
        public override void CountArea()
        {
            double halfPerimetr = sideLendth * 3 / 2;
            triangleArea = Math.Sqrt(halfPerimetr * (halfPerimetr - sideLendth) * (halfPerimetr - sideLendth) * (halfPerimetr - sideLendth));
            Console.WriteLine($"Square area = {triangleArea}");
        }
        // подсчет периметра
        public override void CountPerimetr()
        {
            trianglePerimetr = sideLendth * 3;
            Console.WriteLine($"Square perimetr = {trianglePerimetr}");
        }
        public void Draw()
        {
            string colorOfLetters = colorOfShape;
            ChangeColorOfLetters(colorOfLetters);
            DisplayData();
            Console.ResetColor();
        }
    }
}
