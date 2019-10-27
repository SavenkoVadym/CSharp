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
        public void ViewCars()
        {
            Console.WriteLine("All your cars:");
            Console.WriteLine(" №->Name->Color->Speed->Year of creation\n");
            for (int i = 0; i < Cars.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {Cars[i].CarName} - {Cars[i].CarColor} - {Cars[i].CarSpeed} - {Cars[i].CarYearOfCreating}");
            }
        }
        public void PopCar()
        {
            ViewCars();
            int a;
            do
            {
                Console.Write("Enter number of car what You want delete:");
                a = Convert.ToInt32(Console.ReadLine());
                if (a < 1 || a > Cars.Count + 1)
                {
                    Console.WriteLine("Incorrect number of car! Try again");
                }
                else
                {
                    Console.WriteLine("Remove successful");
                }
            } while (a < 1 || a > Cars.Count + 1);
            Cars.RemoveAt(a - 1);
        }
        public void GetCar()
        {
            ViewCars();
            int a;
            do
            {
                Console.Write("What nubber of car do you want to take? ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a - 1 < 0 || a - 1 > Cars.Count)
                {
                    Console.WriteLine("Incorrect number of Car. Try again");
                }
                else
                {
                    Console.WriteLine("Successful trip");
                }
            } while (a - 1 < 0 || a - 1 > Cars.Count) ;
        }
    }
}