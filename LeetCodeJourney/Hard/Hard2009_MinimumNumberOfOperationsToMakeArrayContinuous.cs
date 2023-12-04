using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-number-of-operations-to-make-array-continuous/
    /// </summary>
    public class Hard2009_MinimumNumberOfOperationsToMakeArrayContinuous
    {
        public int MinOperations(int[] nums)
        {
            Array.Sort(nums);

            var unique = new HashSet<int>(nums).ToArray();

            var result = nums.Length - 1;
            var left = 0;
            var right = 0;

            while (left < unique.Length)
            {
                while (right < unique.Length && unique[right] - unique[left] < nums.Length)
                {
                    right++;
                }

                var interval = right - left;
                result = Math.Min(result, nums.Length - interval);

                left++;
            }

            return result;
        }
    }
}