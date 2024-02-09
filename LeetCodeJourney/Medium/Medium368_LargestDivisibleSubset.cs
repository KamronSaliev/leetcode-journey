using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/largest-divisible-subset/
    /// </summary>
    public class Medium368_LargestDivisibleSubset
    {
        public List<int> LargestDivisibleSubset(int[] nums)
        {
            Array.Sort(nums);

            var n = nums.Length;
            var dp = new int[n];
            var previous = new int[n];
            var maxLength = 0;
            var maxIndex = -1;

            for (var i = 0; i < n; i++)
            {
                dp[i] = 1;
                previous[i] = -1;

                for (var j = i - 1; j >= 0; j--)
                {
                    if (nums[i] % nums[j] == 0 && dp[i] < dp[j] + 1)
                    {
                        dp[i] = dp[j] + 1;
                        previous[i] = j;
                    }
                }

                if (dp[i] > maxLength)
                {
                    maxLength = dp[i];
                    maxIndex = i;
                }
            }

            var result = new List<int>();

            while (maxIndex != -1)
            {
                result.Add(nums[maxIndex]);
                maxIndex = previous[maxIndex];
            }

            result.Reverse();
            return result;
        }
    }
}