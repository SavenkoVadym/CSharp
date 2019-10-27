using System;
using System.Collections.Generic;

namespace Lab_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage myGarage = new Garage();;
            for (int i = 0; i < 1; i++)
            {
                myGarage.SetCar();
            }
            myGarage.ViewCars();
            myGarage.GetCar();
            myGarage.PopCar();
            Console.ReadLine();
          
        }
    }
}
