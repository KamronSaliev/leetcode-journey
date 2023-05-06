using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/number-of-subsequences-that-satisfy-the-given-sum-condition/
    /// </summary>
    public class Medium1498_NumberOfSubsequencesThatSatisfyTheGivenSumCondition
    {
        public int NumSubseq(int[] nums, int target)
        {
            Array.Sort(nums);

            var mod = (int)(1e9 + 7);
            var ans = 0;

            var powers = new int[nums.Length];
            powers[0] = 1;
            for (var i = 1; i < nums.Length; i++)
            {
                powers[i] = powers[i - 1] * 2 % mod;
            }

            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                if (nums[left] + nums[right] <= target)
                {
                    ans = (ans + powers[right - left]) % mod;
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return ans;
        }
    }
}