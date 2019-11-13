using System;
using System.Collections.Generic;
using Chapter1;
using Chapter2;
using Chapter4;
using Test;

namespace LearnCsharp
{
    class Program
    {
        static void Main()
        {
            int[] a = {2, 7, 11, 15, 7, 2, 4, 5, 1, 8, 10, 2, 6, 8};
            Console.Write("Input the number you want: ");
            int t = int.Parse(Console.ReadLine());
            Solution Sum = new Solution();
            Sum.TwoSum(a, t);
            

        }
    }
}
