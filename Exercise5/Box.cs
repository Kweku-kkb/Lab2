using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    class Box
    {
        private double length, breadth, height;

        public double getVolume()
        {
            return length * breadth * height;
        }
       

        public void setBreadth(double b)
        {
            breadth = b;
        }

        public void setLength(double l)
        {
            length = l;
        }
        public void setHeight(double h)
        {
            height = h;
        }
    }
}
