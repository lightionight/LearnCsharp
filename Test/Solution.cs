using System;

namespace Test {


    class Solution {
        public void TwoSum(int[] nums, int target) {
            int[] result = new int[nums.Length];//新建结果数组
            for(int index1 = 0; index1 < nums.Length - 1; index1++)
            {
                for(int index2 = index1 + 1; index2 < nums.Length; index2++)
                {
                    if(nums[index1] == target - (nums[index2]))
                    {
                        result[index1] = nums[index1];
                        result[index2] = nums[index2];
                    }
                }
            }
            //打印结果
            Console.Write("Result is: [");
            foreach (var item in result)
            {
                if(item != 0)
                {
                    if(item != result[result.Length - 1])
                    {
                        Console.Write($" {item},");
                    }else
                    {
                        Console.Write($" {item}");
                    }
                }
            }
            Console.Write("]");

        }
    }
}