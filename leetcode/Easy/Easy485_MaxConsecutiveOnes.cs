using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/max-consecutive-ones/
    /// </summary>
    public class Easy485_MaxConsecutiveOnes
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            var result = 0;
            var count = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    result = Math.Max(result, count);
                    count = 0;
                }
                else
                {
                    count++;
                }
            }
            
            return Math.Max(result, count);
        }
    }
}