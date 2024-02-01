using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/divide-array-into-arrays-with-max-difference/
    /// </summary>
    public class Medium2966_DivideArrayIntoArraysWithMaxDifference
    {
        public int[][] DivideArray(int[] nums, int k)
        {
            Array.Sort(nums);
            
            var result = new List<int[]>();
            
            for (var i = 2; i < nums.Length; i += 3)
            {
                if (nums[i] - nums[i - 2] > k)
                {
                    return new int[][] { };
                }
                
                result.Add(new[] { nums[i - 2], nums[i - 1], nums[i] });
            }

            return result.ToArray();
        }
    }
}