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
            //LongSubstring a = new LongSubstring();
            LongestPalindromeSubstring a = new LongestPalindromeSubstring();
            string word = "aasdskkfls";
            a.LongestPalindrome(word);
            //Console.Write(a.LongestPalindrome(word));
            // int[] num1 = new int[] {2, 3, 4, 5, 7, 8};
            // int[] num2 = new int[] {5, 6, 7, 8, 9, 11};
            // MedianOfTwoArrays arrayNums = new MedianOfTwoArrays();
            // Console.WriteLine(arrayNums.FindMedianSortedArrays(num1, num2));

        }
    }
}
