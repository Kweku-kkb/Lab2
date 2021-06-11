using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class Rectangle
    {
        // member variables
        public double length = 1;
        public double width = 1;

        public void GetData()
        {
        again:
            Console.WriteLine("enter length:");
            this.length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter width:");
            this.width = Convert.ToInt32(Console.ReadLine());
            if (length < 0 || length > 20 || width < 0 || width > 20)
            {
                Console.WriteLine("please enter length and width between 0 and 20");
                goto again;
            }
        }

        public double GetArea()
        {
            return length * width;
        }
        public double GetPerimeter()
        {
            return 2 * (length + width);
        }
        
        public void Display()
        {
            Console.WriteLine("Length: " + length);
            Console.WriteLine("Width: "+ width);
            Console.WriteLine("Area: " + this.GetArea());
            Console.WriteLine("Perimeter: " + this.GetPerimeter());
        }
    }
}
