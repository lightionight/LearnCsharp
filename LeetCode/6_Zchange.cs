using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode
{
    class ZChange
    {
        public string MySolution(string s, int numRows)
        {
            /*****方法局部变量*****/
            
            int j = s.Length;
            int i = numRows;
            char[] word = s.ToCharArray();
            char[,] charResult = new char[i, j];
            int count = 0;
            List<char> name = new List<char>();
            string result;
            if(i < 2)
            {
                result = s;
                goto jump;
            }
            
            /******处理方法********/
            for(int num = 0; num < j ; num++)
            {
                //case1
                if(num == 0 || num % (i - 1) == 0)
                {
                    for(int n = 0; n < i && count < j; n++)
                    {
                        charResult[n, num] = word[count];//将处于满列的数字加入对应位置
                        //Console.Write("result[{0}][{1}] is {2}", n, num, result[n, num]);
                        //Console.WriteLine("  -using Case 1");
                        count++;
                    }
                }
                else
                {
                    for(int n = i - 2; n > 0; n--)
                    {
                        if(n + (num % (i - 1)) == (i - 1) && count < j)
                        {
                            charResult[n, num] = word[count];//将间隔的字符串加入对应的位置
                            //Console.Write("result[{0}][{1}] is {2}", n, num, result[n, num]);
                            //Console.WriteLine("  -using Case 2");
                            count++;
                        }
                        
                    }
                }
            }
            /********处理结果********/
            for(int v = 0; v < i; v++)
            {
                for(int h = 0; h < j; h++)
                {
                    if(charResult[v, h] != 0)
                    {
                         name.Add(charResult[v, h]);
                    }
                }
            }

            result = string.Join(' ', name.ToArray());
            result = result.Replace(" ", "");
            Console.WriteLine(result);
            /*****返回结果****/
            jump:

            return result;
        }
    }
}