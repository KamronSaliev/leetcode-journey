using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/contiguous-array
    /// </summary>
    public class Medium525_ContiguousArray
    {
        public int FindMaxLength(int[] nums)
        {
            var dictionary = new Dictionary<int, int>
            {
                [0] = -1
            };

            var count = 0;
            var result = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    count++;
                }
                else
                {
                    count--;
                }

                if (!dictionary.TryAdd(count, i))
                {
                    result = Math.Max(result, i - dictionary[count]);
                }
            }

            return result;
        }
    }
}