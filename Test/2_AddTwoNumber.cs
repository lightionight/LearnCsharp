using System;
using System.Collections.Generic;

namespace Test{
    class AddTwoNumber{
        public void ATW() {
            //new List
            LinkedList<int> ll = new LinkedList<int>();

            //输入第一个List参数
            Console.Write("Please input list number one by one : (");
            ConsoleKeyInfo input = Console.ReadKey();//新建input变量
            LinkedListNode<char> l1N1 = new LinkedListNode<char>(input.KeyChar);
            Console.Write(" -> ");
            input =  Console.ReadKey();
            LinkedListNode<char> l1N2 = new LinkedListNode<char>(input.KeyChar);
            Console.Write(" -> ");
            input =  Console.ReadKey();
            LinkedListNode<char> l1N3 = new LinkedListNode<char>(input.KeyChar);
            Console.Write(") + (");

            //输入第二个List参数
            input = Console.ReadKey();
            LinkedListNode<char> l2N1 = new LinkedListNode<char>(input.KeyChar);
            Console.Write(" -> ");
            input =  Console.ReadKey();
            LinkedListNode<char> l2N2 = new LinkedListNode<char>(input.KeyChar);
            Console.Write(" -> ");
            input =  Console.ReadKey();
            LinkedListNode<char> l2N3 = new LinkedListNode<char>(input.KeyChar);
            Console.WriteLine(")");

            //字符串转换为int类型
            int list1FistNumber = int.Parse(l1N1.Value.ToString());
            int list1SecondNumber = int.Parse(l1N2.Value.ToString()) * 10;
            int list1ThirdNumber = int.Parse(l1N3.Value.ToString()) * 100;
            int list1number = list1ThirdNumber + list1SecondNumber + list1FistNumber;

            int list2FistNumber = int.Parse(l2N1.Value.ToString());
            int list2SecondNumber = int.Parse(l2N2.Value.ToString()) * 10;
            int list2ThirdNumber = int.Parse(l2N3.Value.ToString()) * 100;
            int list2number = list2ThirdNumber + list2SecondNumber + list2FistNumber;

            int finnalNumber = list1number + list2number;
            Console.WriteLine(finnalNumber);//Debug

            //输出最后结果c
            String charNumber = finnalNumber.ToString();
            //利用循环判断CharNumber位数及要打印的次数
            Console.WriteLine($"{charNumber[charNumber.Length - 1]} -> {charNumber[charNumber.Length - 2]} -> {charNumber[charNumber.Length - 3]}.");//Debug
            



        }
    }
}