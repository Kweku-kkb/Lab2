using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Solution
    {
        public static void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write($"{ arr[i, j]} ");
        }
    }
}
