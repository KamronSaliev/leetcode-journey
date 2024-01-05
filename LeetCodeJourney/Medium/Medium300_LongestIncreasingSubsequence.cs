using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/longest-increasing-subsequence/
    /// </summary>
    public class Medium300_LongestIncreasingSubsequence
    {
        public int LengthOfLIS(int[] nums)
        {
            var answers = new int[nums.Length];
            var result = 0;
            
            for (var i = nums.Length - 1; i >= 0; i--)
            {
                answers[i] = 1;
                
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j] && answers[i] < 1 + answers[j])
                    {
                        answers[i] = 1 + answers[j];
                    }
                }

                result = Math.Max(result, answers[i]);
            }

            return result;
        }
    }
}