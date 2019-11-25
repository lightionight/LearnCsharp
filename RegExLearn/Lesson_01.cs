using System;
using System.Text.RegularExpressions;

namespace RegExLearn
{
    class Lesson_01
    {
        public void MatchStringTest()
        {
            //Local Varw
            string[] word = {"Tom" , "Rosy", "Tony"};
            //regex rulesT
            string patternRegEx = @"^[T]";

            //判断处理
            foreach (var item in word)
            {
                if(Regex.IsMatch(item, patternRegEx))
                    Console.WriteLine(item);
            }

        }
    }
}