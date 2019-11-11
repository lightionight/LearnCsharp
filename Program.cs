using System;
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
            //Ball ball01 = new Ball();
            //ball01.countReflectBall();
            //Operator test = new Operator();
            //test.NonNumberic();
            //Chart word = new Chart();
            //word.TransChar();
            Operator  xor = new Operator();
            xor.TestLogic();
        }
    }
}
