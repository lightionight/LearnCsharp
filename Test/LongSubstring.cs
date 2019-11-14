using System;
using System.Collections;

namespace Test {
    public class LongSubstring{
        public int LengthOfLongestSubstring(string s) {
            ArrayList result = new ArrayList();
            int finnal = 0;
            int start = 0;
            int i = 0;
            foreach (var item in s)
            {
                if(!result.Contains(item)) {
                    result.Add(item);
                    start = result.Count;
                }
                else if(result.Count >= finnal) {
                    finnal = result.Count;
                    i++;
                    result.Clear();
                    result.Add(item);
                }
                else {
                    result.Clear();
                    result.Add(item);
                }
                    
            }
            if(start <= finnal)
                {
                    return finnal;
                }
            else {
                return start;
            }
        }
    }

}