using System;

namespace Test
{
    //求最长子回文字符串;
    public class LongestPalindromeSubstring
    {
        //我的解法；
        public String LongestPalindrome(string s)
        {
            int start = 0;
            int end   = 0;
            int finnalCount = 0;
            int count = 1;
            //剔除字符串位数为0和为1的情况
            if(s.Length == 0 || s.Length == 1)
            {
                goto finnal;
            }

            for (int indexNum = 0; indexNum < (s.Length - 1); indexNum++)
            {
                //奇偶判断
                if(s[indexNum] == s[indexNum + 1])
                {
                    count += 1;
                    for (int i = 1; s[indexNum - i] == s[(indexNum + 1) + i ] && indexNum + 1 - i > 0 && i < s.Length / 2; i++)
                    {
                        count++;
                    }
                }
                else 
                {
                    for (int i = 1; s[indexNum - i] == s[indexNum + i] && indexNum + 1 - i > 0 && i < s.Length / 2; i++)
                    {
                        count++;
                    }
                }
                if(finnalCount < count)
                {
                    finnalCount = count;
                    start = indexNum;
                }
                else
                {
                    count = 1;
                }


                // for (int numEnd = indexNum + 1; numEnd < s.Length; numEnd++)
                // {
                //     if (s[indexNum] == s[numEnd])
                //     {
                //         count = numEnd - indexNum + 1; //统计上一次的位数
                //         break;
                //     }
                // }

            }

            
            //返回结果
            String finnalString;
            if(finnalCount % 2 == 0)
                finnalString = s.Substring(start, finnalCount * 2 + 1);
            else
                finnalString = s.Substring(start, finnalCount * 2 - 1); 
            return finnalString;

            finnal:
                return s;

            
        }
    }
}