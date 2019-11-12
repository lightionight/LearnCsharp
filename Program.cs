using System;
using Chapter1;
using Chapter2;
using Chapter4;
using Test;
using Solutions;

namespace LearnCsharp
{
    class Program
    {
        static void Main()
        {
            //Ball ball01 = new Ball();
            //ball01.countReflectBall();
            //Operator test = new Operator();
            //test.NonNumberic();
            //Chart word = new Chart();
            //word.TransChar();
            //Operator  xor = new Operator();
            //xor.ShiftNumber();
            
            int[] a = {2, 7, 11, 15, 7, 2, 4, 5, 1, 8, 10, 2, 6};
            Console.Write("Input the number you want: ");
            int t = int.Parse(Console.ReadLine());
            Solution Sum = new Solution();
            Sum.TwoSum(a, t);

        }
    }
}
