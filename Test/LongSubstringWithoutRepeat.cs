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
            int countNum = 0;
            int total = 0;
            for (int a = result.Count; a > 1; a--) {
                if(char.Equals(result[countNum], result[countNum + 1])) {
                    countNum = 0;
                }
                else {
                    countNum++;
                    total = countNum;
                }
            }
            total += 1;
            //打印结果
            Console.Write("Result is: ");
            for(int length = 0; length <= result.Count - 1; length++)
            {
                Console.Write(result[length]);
            }
            Console.Write($". And the length is: {total}.");
        }
    }

}