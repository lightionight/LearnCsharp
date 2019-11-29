using System;
using System.Text.RegularExpressions;

namespace LeetCode
{
    class IntIdentity
    {
        public string mySolution(string s)
        {
            Int32 _Max = Int32.MaxValue;
            Int32 _Min = Int32.MinValue;
            string defultReturn = "0";
            //正向表达式模式;
            Regex _isAllNull = new Regex("* ");
            Regex _isAllChar = new Regex("* ");
            


            if (s.Length == 0 || )
            {
                return defultReturn;
            }
            else if (true)
            {
                
            }


            return s;
        }
        //正向表达式判断
        // public bool IsAllNull(string word)
        // {
            
        //     bool result = allNull.IsMatch(word);
        //     return result;
        // }

        // public bool IsAllNull(string word)
        // {
        //     Regex allNull = new Regex("* ");
        //     bool result = allNull.IsMatch(word);
        //     return result;
        // }

    }
}