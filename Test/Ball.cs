using System;

namespace Test
{
    class Ball
    {
        public void countReflectBall()
        {
            Console.Write("What number of frequency of ball reflcet? ");
            int frequency = int.Parse(Console.ReadLine());
            double height = 100;
            int i = 0;
            while(i < frequency)
            {
                height = height / 2;
                i++;
            }
            Console.WriteLine($"After {frequency} times reflect, the ball's height is: {height}");


        }
    }
}