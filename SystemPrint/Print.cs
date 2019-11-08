using System;

namespace SystemPrint
{
    class Name
    {
        public void PrintMsg(string i)
        {
            Console.WriteLine($"my name is {i}");
        }
    }

    // 打印用户输入的名字
    class Hello
    {
        public void SayHello()
        {
            string nameA;
            string nameB;
            Console.WriteLine("What's your name ?");
            nameA = Console.ReadLine();
            Console.WriteLine($"I'm so happy to see you , {nameA}");
            Console.WriteLine("Me too. And what's your name ?");
            Console.Write("My name is ");
            nameB = Console.ReadLine();
            
        }
    }
}