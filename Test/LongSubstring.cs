using System;
using System.Collections;

namespace Test
{
    public class LongSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
            ArrayList result = new ArrayList();
            int a = 0;
            int b = 0;
            foreach (var item in s)
            {
                if (!result.Contains(item))
                {
                    result.Add(item);
                    b = result.Count;
                }
                else if (a < result.Count)
                {
                    a = result.Count;
                    result.RemoveRange(0, (result.IndexOf(item) + 1));
                    result.Add(item);
                }
                else
                {
                    result.RemoveRange(0, (result.IndexOf(item) + 1));
                    result.Add(item);
                }

            }

            
            if(a > b)
            {
                return a;
            }
            else
            {
                return b;
            }

        }
    }
}