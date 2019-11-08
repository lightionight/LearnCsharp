using System;

namespace Chapter2
{
    class Chart
    {
        public void CountChar()
        {
            Console.Write("Enter a word : ");
            string oneWorld = Console.ReadLine();

            //统计字符个数
            Console.WriteLine($"You input : \"{oneWorld}\" has: {oneWorld.Length} charts.");
        }
    }
}