using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_9
{
    class Picture
    {
        protected int numberOfElements = 0;
        public Picture()
        {
            List<Shape> shapes = new List<Shape>();
        }
        public Picture(int lendth)
        {
            List<Shape> shapes = new List<Shape>(lendth);
        }

    }
}
