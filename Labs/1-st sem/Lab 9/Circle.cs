using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_9
{
    class Circle : Shape, IDraw
    {
        protected double radius = 0;
        protected double circleArea = 0;
        protected double circleLength = 0;
        readonly double pi = 3.1415926535897932384626433832795;
        // конструкторы
        public Circle() { }
        protected Circle(string name) : base(name, 0)
        {
            Random random = new Random();
            radius = random.Next(1, 100);
        }
        protected Circle(string name, double radius) : base(name, 0)
        {
            this.radius = radius;
        }
        protected Circle(string name, double radius, string color) : base(name, 0, color)
        {
            this.radius = radius;
        }
        static public Circle EnterData()
        {
            Circle circle;
            bool isName = true;
            bool isRadius = false;
            bool isColor = false;
            string name;
            double radius;
            string color;
            do
            {
                Console.Write("Enter name of Circle: ");
                name = Convert.ToString(Console.ReadLine());
                if (name == string.Empty)
                {
                    Console.WriteLine("incorrect name of Circle");
                }
            } while (name == string.Empty);
            radius = EnterDoubleNumber();
            if (radius != 0)
            {
                isRadius = true;
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
            if (isName == true && isRadius == true)
            {
                if (isName == true && isRadius == true && isColor == true)
                {
                    circle = new Circle(name, radius, color);
                    return circle;
                }
                else
                {
                    circle = new Circle(name, radius);
                    return circle;
                }
            }
            else
            {
                circle = new Circle(name);
                return circle;
            }
        }
        protected void DisplayData()
        {
            Console.WriteLine($"\nName: {nameOfShape}\nNumber of Verticles: {numberOfVertices}\nColor: {colorOfShape}\n" +
                $"Radius: {radius}\nArea: {circleArea}\nPerimetr: {circleLength}");
        }
        //подсчет площади
        public override void CountArea()
        {
            circleArea = pi * radius * radius;
            Console.WriteLine($"Square area = {circleArea}");
        }
        // подсчет периметра
        public override void CountPerimetr()
        {
            circleLength = 2 * pi * radius;
            Console.WriteLine($"Square perimetr = {circleLength}");
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
