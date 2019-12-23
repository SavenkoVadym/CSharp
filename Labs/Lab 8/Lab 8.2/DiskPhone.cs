using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_8._2
{
    class DiskPhone
    {
        protected string nameOfDevice;

        public DiskPhone(string nameOfDevice)
        {
            this.nameOfDevice = nameOfDevice;
        }
        public void GetName()
        {
            Console.WriteLine($"Name of device is: {nameOfDevice}");
        }
    }
}
