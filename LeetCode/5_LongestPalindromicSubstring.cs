using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace LeetCode
{
    class SubstringNew
    {
        public string LongestSubstring(String s)
        {

            //局部变量**************************
            int index1 = 0;
            int index2 = 0;
            int cycle1 = 0;
            int cycle2 = 0;
            int countNum1 = 0;
            int countNum2 = 0;
            String result = "";
            String ss = new String(s.ToCharArray().Reverse().ToArray());
            //局部变量**************************

            //特殊情况***********************
            if(s.Length == 0 || s.Length == 1 || ss == s)
            {
                result = s;
                goto jump;
            }
            //特殊情况**********************
            //*************************正常处理String********************************//
            for (int i = 0; i < s.Length; i++)
            {
                    for (int item = 1; i - item >= 0 && (i + item) < s.Length && s[i - item] == s[i + item]; item++)
                    {
                        countNum1++;
                    }
                    for (int item = 1; (i + item) < s.Length && s[i] == s[i+item]; item++)
                    {
                        countNum2++;
                    }
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
                    
            }
            //第一次下一位与 当前位相等 且与 前一位不相等的情况
            if(cycle1 >= cycle2)
            {
             result = s.Substring((index1 - cycle1), (cycle1 * 2) + 1);

            }
            else
            {
             result = s.Substring((index2), cycle2 + 1);

            }
            //第一次下一位与当前位不相等的情况
            if(result.Length == 0)
            {
                result = s.Substring(0, 1);
                goto jump;
            }
            //*************************正常处理String********************************//
            // result = s.Substring((index - cycle), (cycle * 2) + 1);
            
            jump:
            // 返回结果
            return result;
            // 返回结果
        }
    }
}