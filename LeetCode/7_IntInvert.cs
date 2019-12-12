using System.Collections.Generic;
using System;
using System.Collections;

namespace leetCode
{
    class IntInvert
    {
        private void _IntInvert(int number)
        {
            int finnalReasult;
            if(number > 0)
            {
                string numberString = number.ToString();
                List<char> numberCharList = new List<char>();
                foreach(var item in numberCharList)
                {
                    numberCharList.Add(item);
                }
                numberCharList.Reverse();
                char[] reasult = numberCharList.ToArray();
                finnalReasult =  Convert.ToInt32(reasult);
            }
        }
    }
}