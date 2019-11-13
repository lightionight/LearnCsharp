using System;
using System.Collections;

namespace Test {
    public class LongSubstringWithoutRepeat{
        public void LengthOfLongestSubstring(string s) {
            ArrayList result = new ArrayList();
            foreach (var item in s)
            {
                if(!result.Contains(item))
                {
                    result.Add(item);
                }
            }
            //打印结果
            Console.Write("Result is: ");
            for(int length = 0; length <= result.Count - 1; length++)
            {
                Console.Write(result[length]);
            }
            Console.Write($". And the length is: {result.Count}.");
        }
    }

}