using System.Collections.Generic;
using System;
using System.Collections;

namespace leetCode
{
    class IntInvert
    {
        static int maxInt = int
        private void _IntInvert(int number)
        {
            int finalResult;
            if(number > 0)
            {
                string numberString = number.ToString();
                List<char> numberCharList = new List<char>();
                foreach(var item in numberCharList)
                {
                    numberCharList.Add(item);
                }
                numberCharList.Reverse();
                char[] result = numberCharList.ToArray();
                finalResult =  Convert.ToInt32(result);
            }
        }
    }
}