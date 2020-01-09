using System;
using System.Text.RegularExpressions;
namespace LeetCode
{
    public class IntIdentity
    {
        private static readonly Int32 _MaxValue = Int32.MaxValue;
        private static readonly Int32 _MinValue = Int32.MinValue;
        Regex _isNull = new Regex(@"[\s]");
        Regex _isWord = new Regex(@"[]");
        private int Mysolution(string str)
        {
            string defultReturn = "0";

            if (str.Length == 0)
            {
                
            }
            else if(_isNull.IsMatch(str))
            {
                
            }
            return int.Parse(defultReturn);
        }
    }
}