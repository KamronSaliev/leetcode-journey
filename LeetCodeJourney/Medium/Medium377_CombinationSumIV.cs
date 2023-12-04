using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/combination-sum-iv/
    /// </summary>
    public class Medium377_CombinationSumIV
    {
        public int CombinationSum4(int[] nums, int target)
        {
            var dp = new int[target + 1];
            dp[0] = 1;

            Array.Sort(nums);

            for (var i = 0; i <= target; i++)
            {
                foreach (var num in nums)
                {
                    if (num <= i)
                    {
                        dp[i] += dp[i - num];
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return dp[target];
        }
    }
}