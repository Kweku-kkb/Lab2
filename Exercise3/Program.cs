using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers where second is larger than first and separated by space");
            string[] splitNumbers = Console.ReadLine().Split(" ");
            Solution.solution(Convert.ToInt32(splitNumbers[0]), Convert.ToInt32(splitNumbers[1]));
        }
    }
}
