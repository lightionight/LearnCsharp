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
            //int n = '3' + '4';
            //char c = (char)n;
            //Console.WriteLine(c);
            //int distance = 'f' - 'c';
            //Console.WriteLine(distance);

            int nowValue = 65;
            char now = (char)nowValue;

            //遍历打印26个字母;
            do
            {
                Console.WriteLine($"The char {now} is number : {nowValue}");
                nowValue++;
                now = (char)nowValue;
            }while(nowValue < 91);

        }
    }
}