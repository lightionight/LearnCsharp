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
            int[] a = {2, 7, 11, 15};
            Console.Write("Input the number you want: ");
            int t = int.Parse(Console.ReadLine());
            Solution Sum = new Solution();
            Sum.TwoSum(a, t);
            

        }
    }
}
