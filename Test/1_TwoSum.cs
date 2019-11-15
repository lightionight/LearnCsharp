using System;
using System.Collections;

namespace Test {


    class TwoSums {
        public void TwoSum(int[] nums, int target) {
            // int[] result = new int[nums.Length];//新建结果数组
            // for(int index1 = 0; index1 < nums.Length - 1; index1++)
            // {
            //     for(int index2 = index1 + 1; index2 < nums.Length; index2++)
            //     {
            //         if(nums[index1] == target - (nums[index2]))
            //         {
            //             result[index1] = nums[index1];
            //             result[index2] = nums[index2];
            //         }
            //     }
            // }
            //筛选数组适合结果的元素
            ArrayList result = new ArrayList();
            for (int outter = 0; outter < nums.Length - 1; outter++)
            {
                for (int inner = outter + 1; inner < nums.Length; inner++)
                {
                    if (nums[inner] == target - nums[outter])
                    {    
                        if( !result.Contains(outter))
                        {
                            result.Add(outter);
                            if(!result.Contains(inner))
                            {
                                result.Add(inner);
                            }
                        }
                    }
                }
            }

            result.Sort();//重新排列结果数组

            //打印结果
            Console.Write("Result is: [");            
            foreach (var item in result)
            {
                if(item != null)
                {
                    if (item == result[0])
                        Console.Write($"{item},");
                    else if(item != result[result.Count - 1])
                        Console.Write($" {item},");
                    else
                        Console.Write($" {item}");

                }
            }
            Console.Write("]");

        }
    }
}