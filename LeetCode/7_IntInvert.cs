using System.Collections.Generic;
using System;
using System.Collections;

namespace LeetCode
{
    class IntInvert
    {
        
        public int _IntInvert(int x)
        {
            Int32 intMax = int.MaxValue;
            Int32 intMin = int.MinValue;
            Int64 input = x;
            Int64 result;
            if(input > 0)
            {
                char[] temp = input.ToString().ToCharArray();
                Array.Reverse(temp, 0, temp.Length);
                string ReverseNumber = new string(temp);
                string tempString = ReverseNumber;
                while(tempString[0] == '0')
                {
                    ReverseNumber = tempString;
                    tempString = ReverseNumber.Substring(1);
                }
                result = Int64.Parse(tempString);
                if(result > intMax)
                {
                    return 0;
                }
                else
                {
                    return (Int32)result;
                }
                
            }
            else if(input < 0)
            {
                input = -input;
                char[] temp = input.ToString().ToCharArray();
                Array.Reverse(temp, 0 ,temp.Length);
                string ReverseNumber = new string(temp);
                string tempString = ReverseNumber;
                while(tempString[0] == '0')
                {
                    ReverseNumber = tempString;
                    tempString = ReverseNumber.Substring(1);
                }
                result = Int64.Parse(tempString);
                result = -result;
                if(result < intMin)
                {
                    return 0;
                }
                else
                {
                    return (Int32)result;
                }
            }
            else
            {
                return x;
            }
        }
    }
}