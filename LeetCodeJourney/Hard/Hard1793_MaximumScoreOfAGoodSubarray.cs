using System;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-score-of-a-good-subarray/
    ///     https://leetcode.com/problems/maximum-score-of-a-good-subarray/solutions/4194071/92-13-two-pointers/?envType=daily-question
    ///     &amp;envId=2023-10-22
    /// </summary>
    public class Hard1793_MaximumScoreOfAGoodSubarray
    {
        public int MaximumScore(int[] nums, int k)
        {
            var left = k;
            var right = k;
            var minValue = nums[k];
            var maxScore = minValue;

            while (left > 0 || right < nums.Length - 1)
            {
                if (left == 0 || (right < nums.Length - 1 && nums[right + 1] > nums[left - 1]))
                {
                    right++;
                }
                else
                {
                    left--;
                }

                minValue = Math.Min(minValue, Math.Min(nums[left], nums[right]));
                maxScore = Math.Max(maxScore, minValue * (right - left + 1));
            }

            return maxScore;
        }
    }
}