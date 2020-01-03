using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    class LongestSubstring
    {
        //我的解题方法
        public string MySolution(String s)
        {
            /****************局部变量*************/
            int index1 = 0;
            int index2 = 0;
            int index3 = 0;
            int cycle1 = 0;
            int cycle2 = 0;
            int cycle3 = 0;
            int countNum1 = 0;
            int countNum2 = 0;
            int countNum3 = 0;
            string result = "";
            string ss = new String(s.ToCharArray().Reverse().ToArray());

            /**************特殊情况***************/
            if(s.Length == 0 || s.Length == 1 || ss == s)
            {
                result = s;
                goto jump;
            }

            /*************************正常处理String********************************/
            for (int i = 0; i < s.Length; i++)
            {
                for (int item = 1; i - item >= 0 && (i + item) < s.Length && s[i - item] == s[i + item]; item++)      //奇数对称回文字符串
                {
                    countNum1++;
                }
                for (int item = 1; (i + item) < s.Length && s[i] == s[i+item]; item++)                                //连续相同字符串
                {
                    countNum2++;
                }
                
                for (int item = 0; (i - item) >= 0 && (i + item) < s.Length - 1 && s[i - item] == s[i + item + 1]; item++)//偶数对称回文字符串
                {
                    countNum3++;
                }
                /******判断长度筛选结果********/
                if(cycle1 <= countNum1)
                {
                    cycle1 = countNum1;
                    index1 = i;
                                            
                }
                countNum1 = 0;

                if(cycle2 <= countNum2)
                {
                    cycle2 = countNum2;
                    index2 = i;
                                            
                }
                countNum2 = 0;

                if(cycle3 <= countNum3)
                {
                    cycle3 = countNum3;
                    index3 = i;
                                            
                }
                countNum3 = 0; 
            }

            /********判断选用结果***********/
            if(cycle1 >= cycle2 && cycle1 >= cycle3)
            {
                result = s.Substring((index1 - cycle1), (cycle1 * 2) + 1);
                Console.WriteLine("Now Use Cycle1");

            }
            else if(cycle2 > cycle1 && cycle2 > cycle3)
            {
                result = s.Substring((index2), cycle2 + 1);
                Console.WriteLine("Now Use Cycle2");
            }
            else
            {
                result = s.Substring((index3 - (cycle3 - 1)), cycle3 * 2);
                Console.WriteLine($"Now Index is {index3}");
                Console.WriteLine("Now Use Cycle3");
            }

            if(result.Length == 0)
            {
                result = s.Substring(0, 1);
                goto jump;
            }
            
            // 返回结果
            jump:
            return result;
        }

        // public string BinarySearchSolution(string s)
        // {
        //     /*********Local var*********/
        //     int s_Size = s.Length;
        //     string result;
        //     int count = 0;
        //     List<char> word = new List<char>();
        //     word = s.ToCharArray().ToList();
        //     List<char> resultWord = new List<char>();
        //     /*********特殊处理情况**********/
        //     if(s_Size == 0 || s_Size == 1)
        //     {
        //         result = s;
        //         goto jump;
        //     }
        //     /*********正常处理情况**********/
        //     else if(s_Size % 2 == 0)
        //     {
        //         //添加占位符#
        //         for(int i = 0; i < s_Size; i++)
        //         {
        //             if(i % 2 == 0)
        //             {
        //                 word[i + 1] = '#';
        //             }
        //         }

        //         for(int i = 0 ; i < word.Count; i++)
        //         {
        //             if(word[i] == '#')
        //             {
        //                 for(int j = 1; j < word.Count; j++)
        //                 {
        //                     if(word[i-j] ==  word[i + j])
        //                         count++;
        //                         resultWord[i - j] = word[i - j];
        //                         resultWord[i + j] = word[i + j];
        //                 }
        //             }
        //         }
        //     }
        //     //s_Size为单数的处理情况

        //     else
        //     {
                
        //     }
        //     /**********返回结果*************/
        //     jump:

        //     return result;
        // }
    }
}