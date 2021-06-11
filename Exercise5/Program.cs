using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of boxes: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Box[] boxes = new Box[num];
            for (int i = 0; i < num; i++)
            {
                Box box = new Box();
                Console.WriteLine("Enter box length");
                box.setLength(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Enter box height");
                box.setHeight(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Enter box breadth");
                box.setBreadth(Convert.ToDouble(Console.ReadLine()));
                boxes[i] = box;
            }
            for (int i = 0; i < boxes.Length; i++)
            {
                Console.WriteLine("Volume of Box{0} : {1}", i + 1, boxes[i].getVolume());
            }
        }
    }
}
