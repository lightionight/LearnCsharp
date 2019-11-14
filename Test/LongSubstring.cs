using System;
using System.Collections;

namespace Test {
    public class LongSubstring{
        public int LengthOfLongestSubstring(string s) {
            ArrayList result = new ArrayList();
            ArrayList finnal = new ArrayList();
            int i = 0;
            foreach (var item in s)
            {
                if(!result.Contains(item)) {
                    result.Add(item);

                }
                else {
                    finnal.Add(result.Count);
                    i++;
                    result.Clear();
                    result.Add(item);
                    }
                    
            }
            foreach (var obj in finnal)
                {
                    Console.Write(obj);
                }
            return finnal.Count;
        }
    }

}