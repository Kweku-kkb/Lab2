using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Console.WriteLine("Enter size of Array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter values into array and separate by space\nSuch as 10 21 4 20 10 4 10");
            string input = Console.ReadLine();
            string[] strArray = input.Split(" ");
            if (size != strArray.Length)
                Console.WriteLine("Number of values are not equal to size of array");
            for (int i = 0; i < strArray.Length; i++)
            {
                arr[i] = Convert.ToInt32(strArray[i]);
            }
            Console.WriteLine($"Most occurring value in array is: {sol.solution(arr)}");
        }
    }
}
