using System;

namespace Chapter2
{
    class Chart
    {
        //定义字符长度;
        public void CountChar()
        {
            Console.Write("Enter a word : ");
            string oneWorld = Console.ReadLine();

            //统计字符个数
            Console.WriteLine($"You input : \"{oneWorld}\" has: {oneWorld.Length} charts.");
        }
        
        //转换字符串
        public void TransChar()
        {
            int n = '3' + '4';
            char c = (char)n;
            Console.WriteLine(c);
            int distance = 'f' - 'c';
            Console.WriteLine(distance);
        }
    }
}