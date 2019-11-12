using System;

namespace Solutions
{
    class Solution 
    {
        public void TwoSum(int[] nums, int target)
        {
            //寻求数组中所有两个数字的和等于一个特定的数;
            int[] result = new int[(nums.Length)];
            int addNumber = 0;
            int addTwoNumber = addNumber + 1;
            for(int outer = 0; outer <nums.Length - 1; outer++) {
                for(int inner = 1; inner < nums.Length - 1; inner++) {
                    if(target == (nums[outer] + nums[inner])) {
                        result[addNumber] = nums[outer];
                        result[addTwoNumber] = nums[inner];
                        addNumber++;
                        addTwoNumber++;
                    }
                }
            }

            Console.Write("Result is : [");
            foreach (var item in result)
            {
                if(item != 0) {
                    Console.Write($" {item}, ");
                }
            
            }
            Console.Write("].");
        }
    }
}