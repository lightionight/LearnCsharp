using System;
using System.Collections;

namespace Test
{
    public class LongSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
            ArrayList result = new ArrayList();
            int i = 0;
            foreach (var item in s)
            {
                if (!result.Contains(item))
                {
                    result.Add(item);
                }
                else if (i < result.Count)
                {
                    i = result.Count;
                    result.RemoveRange(0, (result.IndexOf(item) + 1));
                    result.Add(item);
                }
                else
                {
                    result.RemoveRange(0, result.IndexOf(item));
                    result.Add(item);

                }

                

                

            }

            if (result.Count == 1)
                {
                    i = 1;
                }
            return i;

        }
    }
}