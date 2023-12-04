using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-operations-to-reduce-x-to-zero/
    /// </summary>
    public class Medium1658_MinimumOperationsToReduceXToZero
    {
        public int MinOperations(int[] nums, int x)
        {
            var target = -x;
            var n = nums.Length;

            for (var i = 0; i < nums.Length; i++)
            {
                target += nums[i];
            }

            if (target == 0)
            {
                return n;
            }
            
            var result = 0;
            var currentSum = 0;
            var left = 0;

            for (var right = 0; right < n; right++)
            {
                currentSum += nums[right];

                while (left <= right && currentSum > target)
                {
                    currentSum -= nums[left];
                    left++;
                }

                if (currentSum == target)
                {
                    result = Math.Max(result, right - left + 1);
                }
            }

            return result != 0 ? n - result : -1;
        }
    }
}