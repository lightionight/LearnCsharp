using System;
using System.Collections;
using System.Collections.Generic;

namespace Test
{
    public class LongestPalindromeSubstring 
    {
        public void LongestPalindrome(string s) 
        {
            ArrayList a = new ArrayList();
            ArrayList result = new ArrayList();
            
            foreach (var item in s)
            {
                if (!a.Contains(item))
                {
                    a.Add(item);
                }
                else if(result.Count < a.Count)
                    {
                        if (a[a.Count -1] == a[a.Count -2])
                        {
                            
                            a.RemoveRange(0, a.IndexOf(item));
                            a.Add(item);
                            result = a;
                        }
                        else
                        {
                            result = a;
                            a.RemoveRange(0, (a.IndexOf(item) + 1));
                            a.Add(item);
                        }
                    }
                    else
                    {
                        a.RemoveRange(0, (a.IndexOf(item) + 1));
                        a.Add(item);
                    }

            }
            string[] arrString = (string[])result.ToArray(typeof( string));

            //打印结果
            //return str;
        }
}
}