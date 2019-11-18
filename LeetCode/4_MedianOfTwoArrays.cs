using System;

namespace LeetCode
{
    public class MedianOfTwoArrays 
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
        {
            
            //合并两个数组num1和Num2;
            int[] all = new int[nums1.Length + nums2.Length];
            nums1.CopyTo(all, 0);
            nums2.CopyTo(all, nums1.Length);
            Array.Sort(all);
            
            //判断数值奇偶性并求出中值;
            double result = 0;
            if (all.Length % 2 == 0)
            {
                //result = (all[all.Length / 2 - 1] + all[all.Length / 2]) / 2;
                result = (all[all.Length / 2 - 1] + all[all.Length / 2]);
                result = Math.Round(Convert.ToDouble(result) / 2 ,1);
            }
            else
            {
                result = all[all.Length / 2];
            }

            //返回计算结果
            return result;
            
        }
    }
}