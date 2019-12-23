using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_8._1
{
    class Car
    {
        protected string carName;
        protected string carColor;
        protected double carSpeed;
        protected int carYearOfCreating;
        public string CarName { get { return carName; } }
        public string CarColor { get { return carColor; } }
        public double CarSpeed { get { return carSpeed; } }
        public int CarYearOfCreating { get { return carYearOfCreating; } }
        public Car(string carName, string carColor, double carSpeed, int carYearOfCreating)
        {
            this.carName = carName;
            this.carColor = carColor;
            this.carSpeed = carSpeed;
            this.carYearOfCreating = carYearOfCreating;
        }
    }
}
