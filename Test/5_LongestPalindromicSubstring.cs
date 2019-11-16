using System;
using System.Collections;
using System.Collections.Generic;

namespace Test
{
    public class LongestPalindromeSubstring
    {
        public String LongestPalindrome(string s)
        {

            int start, count, lastCount;
                start = count = lastCount = 0;

            for (int numStart = 0; numStart < (s.Length - 1); numStart++)
            {
                for (int numEnd = numStart + 1; numEnd < s.Length; numEnd++)
                {
                    if (s[numStart] == s[numEnd])
                    {
                        count = numEnd - numStart + 1; //统计上一次的位数
                        break;
                    }
                }


                if (lastCount < count)
                {
                    start = numStart;
                    lastCount = count;

                }
                else
                {
                    count = 0;

                }


            }

            //返回结果
            String finnal = s.Substring(start, lastCount);
            return finnal;


        }
    }
}