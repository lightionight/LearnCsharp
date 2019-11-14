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
            //任意一个数在指定数组中有两个数和等于它.
            // int[] a = {2, 7, 11, 15};
            // Console.Write("Input the number you want: ");
            // int t = int.Parse(Console.ReadLine());
            // Solution Sum = new Solution();
            // Sum.TwoSum(a, t);

            //AddTwoNumber test = new AddTwoNumber();
            //test.ATW();
            LongSubstring a = new LongSubstring();
            string word = "abcabcbbadcdef";
            Console.Write(a.LengthOfLongestSubstring(word));


            
            

        }
    }
}
