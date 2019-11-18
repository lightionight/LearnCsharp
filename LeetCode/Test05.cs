using System;

namespace LeetCode
{
    class Test
    {
        public string LongestSubstring(String s)
        {

            //局部变量**************************
            String result   = s;
            int count       = 0;
            int finnalCount = 0;
            int iCount      = 0;
            int lastCount   = 0;
            int index       = 0;
            int lastIndex   = 0;
            //局部变量**************************

            //特殊情况***********************
            if(s.Length == 0 || s.Length == 1)
            {
                result = s;
                goto jump;
            }
            //特殊情况***********************
            //*************************正常处理String********************************//
            for (index = 0; index < s.Length - 1; index++)
            {
            //第一次下一位与当前位相等的情况
                if(s[index] == s[index + 1] && s[index - 1] != s[index + 1])
                {
                    count += 1;
                    for (int i = 1; index - i >= 0 && index + i + 1 <s.Length; i++)
                    {
                        if(s[index - i] == s[index + i + 1])
                        {
                            iCount = i;
                        }
                    }
                
                }
            //第一次下一位与当前位不相等的情况
                else
                {
                    for(int i = 1; index - i >= 0 && index + i + 1 < s.Length; i++)
                    {
                        if(s[index - i] == s[index + i])
                        {
                            iCount = i;
                        }
                    }
                }



                if(finnalCount <= count + iCount)
                {
                    lastCount    = count;
                    finnalCount  = count + iCount;
                    lastIndex    = index;
                    iCount       = 0;
                    count        = 0;
                }
                else
                {
                    iCount = 0;
                    count  = 0;
                }

            }
            if(lastCount == 1)
            {
                result = s.Substring(lastIndex - (finnalCount - lastCount), finnalCount * 2);
            }
            else
            {
                result = s.Substring(lastIndex - finnalCount, finnalCount * 2 + 1);
            }
            
            
            
            //*************************正常处理String********************************//
            
            
            jump:
            // 返回结果
            return result;
            // 返回结果
        }
    }
}