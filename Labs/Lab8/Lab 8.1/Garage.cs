using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_8._1
{
    partial class Garage
    {
        List<Car> Cars = new List<Car>();
        protected Car EnterData()
        {
            string name, color;
            double speed;
            int year;
            do
            {
                Console.Write("Enter name of car: ");
                name = Convert.ToString(Console.ReadLine());
                if (name == "")
                {
                    Console.WriteLine("Incorrect name, try again");
                }
            } while (name == "");
            do
            {
                Console.Write("Enter color of car: ");
                color = Convert.ToString(Console.ReadLine());
                if (color == "")
                {
                    Console.WriteLine("Incorrect color, try again");
                }
            } while (color == "");
            do
            {
                Console.Write("Enter speed of car: ");
                speed = Convert.ToDouble(Console.ReadLine());
                if (speed < -138.4 || speed > 1227.986)
                {
                    Console.WriteLine("Incorrect speed, try again");
                }
            } while (speed < -138.4 || speed > 1227.986);
            do
            {
                Console.Write("Enter year of creation of car: ");
                year = Convert.ToInt32(Console.ReadLine());
                if (year < 1884 || year > DateTime.Today.Year)
                {
                    Console.WriteLine("Incorrect year of creation. Try again");
                }
            } while (year < 1884 || year > DateTime.Today.Year);
            return new Car(name, color, speed, year);
        }
        public void SetCar()
        {
            Cars.Add(EnterData());
        }
        //public void PopCar()
        //{
        //    if (true)
        //    {

        //    }
        //    else
        //    {
        //      Cars.Remove(EnterData());
        //    }
        //}
        public void ViewCars()
        {
            Console.WriteLine("All your cars:");
            Console.WriteLine("Name->Color->Speed->Year of creation\n");
            foreach (var item in Cars)
            {
                Console.WriteLine($"{item.CarName} - {item.CarColor} - {item.CarSpeed} - {item.CarYearOfCreating}");
                //Console.WriteLine(item.ToString());
            }
        }
        public void GetCar()
        {
            ViewCars();
            string name, colour;
            double? speed;
            int? year;
            Console.Write($"Name of car: ");
            name = Console.ReadLine();
            Console.Write($"Colour of car: ");
            colour = Console.ReadLine();
            Console.Write($"Speed of car: ");
            speed = Convert.ToDouble(Console.ReadLine()) != 0 ? Convert.ToDouble(Console.ReadLine()) : 0;
            Console.Write($"Year of car: ");
            year = Convert.ToInt32(Console.ReadLine());
            List<Car> result = new List<Car>();
            if (name != "")
            {
                foreach (var item in Cars)
                {
                    if (item.CarName == name)
                    {
                        result.Add(item);
                    }
                }
            }
            if (colour != "")
            {
                foreach (var item in Cars)
                {
                    if (item.CarColor == colour)
                    {
                        result.Add(item);
                    }
                }
            }
            if (speed != null)
            {
                foreach (var item in Cars)
                {
                    if (item.CarSpeed == speed)
                    {
                        result.Add(item);
                    }
                }
            }
            if (year != null)
            {
                foreach (var item in Cars)
                {
                    if (item.CarYearOfCreating == year)
                    {
                        result.Add(item);
                    }
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}