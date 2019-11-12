using System;

namespace Solutions
{
    class Solution 
    {
        public void TwoSum(int[] nums, int target)
        {
            //寻求数组中所有两个数字的和等于一个特定的数;
            int[] insiderArray;
             foreach (var number in nums)
             {
                 for (int i = 0; i < nums.Length; i++)
                 {
                     if (target == (number + nums[i]))
                     {
                         
                     }
                 }
             }
        }
    }
}