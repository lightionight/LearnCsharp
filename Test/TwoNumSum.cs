using System;

namespace Solutions
{
    class Solution 
    {
        public void TwoSum(int[] nums, int target)
        {
            //初始化数组和target
             nums = new [] {2, 7, 11, 15};
             target = 9;
             foreach (var number in nums)
             {
                 for (int i = 0; i < nums.Length; i++)
                 {
                     if (target == (number + nums[i]))
                     {
                         if (number != nums[i])
                         {
                             Console.WriteLine($"The target can combile with {number} and {nums[i]}");
                         }
                     }
                 }
             }

            
            //遍历数列中的每一个数
            // for(int a = 0; a < (nums.Length - 1); a++)
            // {
            //     for(int b = 1; b < nums.Length; b++)
            //     {
            //         if(target == (nums[a] + nums[b]))
            //         {
            //             Console.WriteLine($"The target can combile with {nums[a]} and {nums[b]}");
                        
            //         }
            //     }
            // }


        }
    }
}