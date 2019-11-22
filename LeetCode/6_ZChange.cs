using System;

namespace LeetCode
{
    class ZChange
    {
        public char[,] MySolution(string s, int numRows)
        {
<<<<<<< HEAD
            /*****方法局部变量*****/
            int j = s.Length;
            int i = numRows;
            char[] word = s.ToCharArray();
            char[,] result = new char[i, j];
            int count = 0;
            /******处理方法********/
            for(int num = 0; num < j ; num++)
            {
                //case1
                if(num == 0 || num % (i - 1) == 0)
                {
                    for(int n = 0; n < i && count < j; n++)
                    {
                        result[n, num] = word[count];
                        Console.Write("result[{0}][{1}] is {2}", n, num, result[n, num]);
                        Console.WriteLine("  -using Case 1");
                        count++;
                    }
                }
                else
                {
                    for(int n = i - 2; n > 0; n--)
                    {
                        if(n + (num % (i - 1)) == (i - 1) && count < j)
                        {
                            result[n, num] = word[count];
                            Console.Write("result[{0}][{1}] is {2}", n, num, result[n, num]);
                            Console.WriteLine("  -using Case 2");
                            count++;
                        }
                        
                    }
                }
            }
            /*****返回结果****/
            Console.WriteLine("still ok");
            int row = result.Rank;
            int col = result.Length;
            for(int v = 0; v < row; v++)
            {
                for(int h = 0; h < col; h++)
                {
                    if(v == 0 || v != (row - 1))
                    {
                        Console.Write(result[v, h]);
                    }
                    else
                    {
                        Console.WriteLine(result[v, h]);
                    }
                }
            }
            return result;
=======
            // String result = "";
            // int sLength = s.Length;
            // int m = numRows;
            // int n = 
            // /*****方法局部变量*****/
            // int[] ListNum = new int[m][5];
            // /*****返回结果****/
            // return result;
            int i = numRows;
            int j = numColumn;
            int[,] index2D =  new int[i][j];
            /*********Z变形方法*********/
            
            
>>>>>>> b3132a40aeac54720de2864dd0c7e89df39c7c85
        }
    }
}