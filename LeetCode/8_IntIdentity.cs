using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace LeetCode
{
    public class IntIdentity
    {
        private static readonly Int32 _MaxValue = Int32.MaxValue;
        private static readonly Int32 _MinValue = Int32.MinValue;
        
        //判断是否存在多余空格
        private string  _removeBlankSpace = @"^\s*(\w*)\s";

        //判断第一个非空字符是否为正负符号或者数字，regex.match 如果是否，则直接返回0.
        private string _haveAddDeicame = @"^(\+-)\D+$ | ^(\d)\D+$";

        private int Mysolution(string str)
        {
            int defultReturn = 0;
            //* 如果string长度为0， 直接输出结果
            if(str.Length == 0)
            {
                return defultReturn;
            }

            Match match = Regex.Match(str,_removeBlankSpace);
            //去除空格
            if (match.Success)
            {
                str = match.Value;
            }

            Match match1 = Regex.Match(str, _haveAddDeicame);
            if (match1.Success) 
                {
                    
                }

        }
    }
}