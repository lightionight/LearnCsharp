using System;

namespace Chapter4
{
    class Operator
    {
        public void NonNumberic()
        {
            int windSpeed = 42;
            Console.WriteLine($"The Car's speed is {windSpeed}" + " fourth miles away.");
        }
        
        public void TestLogic()
        {
            int a = 2;
            int b = 3;
            int c = 4;
            
            //使用逻辑运算符 XOR
            if(a > b ^ c > b)
                {
                    Console.WriteLine("XOR is true.");
                }
            else
                {
                    Console.WriteLine("XOR is False.");
                }
            // AND
            if(a > b && c > b)
                {
                    Console.WriteLine("AND is true.");
                }
            else
                {
                    Console.WriteLine("AND is False.");
                }
            
            //OR
            if(a > b || c > b)
                {
                    Console.WriteLine("OR is true.");
                }
            else
                {
                    Console.WriteLine("OR is False.");
                }
        
        }

        //shift bit
        public void ShiftNumber()
        {
            int x;
            x = (-7 >> 2);
            Console.WriteLine(x);
        }
    }
}