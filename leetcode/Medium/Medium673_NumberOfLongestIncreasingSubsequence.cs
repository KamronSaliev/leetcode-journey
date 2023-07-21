using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/number-of-longest-increasing-subsequence/
    ///     https://leetcode.com/problems/number-of-longest-increasing-subsequence/solutions/3794909/c-solution-for-number-of-longest-increasing-subsequence-problem/
    /// </summary>
    public class Medium673_NumberOfLongestIncreasingSubsequence
    {
        public int FindNumberOfLIS(int[] nums)
        {
            var n = nums.Length;

            var lengths = new int[n];
            var counts = new int[n];

            for (var i = 0; i < n; i++)
            {
                lengths[i] = 1;
                counts[i] = 1;
            }

            var maxLength = 1;

            for (var i = 1; i < n; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    if (nums[i] <= nums[j])
                    {
                        continue;
                    }

                    if (lengths[j] + 1 > lengths[i])
                    {
                        lengths[i] = lengths[j] + 1;
                        counts[i] = counts[j];
                    }
                    else if (lengths[j] + 1 == lengths[i])
                    {
                        counts[i] += counts[j];
                    }
                }

                maxLength = Math.Max(maxLength, lengths[i]);
            }

            var result = 0;

            for (var i = 0; i < n; i++)
            {
                if (lengths[i] == maxLength)
                {
                    result += counts[i];
                }
            }

            return result;
        }
    }
}