using System;
using System.Collections;

namespace Test
{
    public class LongestPalindromeSubstring 
    {
        public string LongestPalindrome(string s) 
        {
            ArrayList a = new ArrayList();
            ArrayList result = new ArrayList();
            
            foreach (var item in s)
            {
                if (!a.Contains(item))
                {
                    a.Add(item);
                }
                else if (result.Count < a.Count)
                {
                    result = a;
                    a.RemoveRange(0, (a.IndexOf(item) + 1));
                    a.Add(item);
                }
                else
                {
                    a.RemoveRange(0, (a.IndexOf(item) + 1));
                    a.Add(item);
                }

            }
            String str = String.Join("", (result.ToChar(typeof(Char))));

            //打印结果
            return str;
        }
}
}