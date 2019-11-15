using System;
using System.Collections;
using System.Collections.Generic;

namespace Test
{
    public class LongestPalindromeSubstring 
    {
        public String LongestPalindrome(string s) 
        {
               
            int start = 0;
            int end   = 0;
            int count = 0;

           for(int numStart = 0; numStart < s.Length; numStart++)
           {
               for(int numEnd = numStart + 1; numEnd < s.Length; numEnd++)
               {   
                   if(s[numStart] == s[numEnd])
                   {
                       start = numStart;
                       end   = numEnd;
                       count = numEnd - numStart;
                       break;

                   }
               }
               if((end - start + 1) <= count)
               {
                   start = numStart;
                   end = numStart + count;
               }
               else
               {
                   count = 0;
               }
           }

           //返回结果
           String finnal = s.Substring(start, (end - start));
           return finnal;
           
        }
    }
}