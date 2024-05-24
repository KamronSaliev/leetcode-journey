using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/find-closest-number-to-zero
    /// </summary>
    public class Easy2239_FindClosestNumberToZero
    {
        public int FindClosestNumber(int[] nums)
        {
            var result = nums[0];

            foreach (var num in nums)
            {
                if (Math.Abs(num) < Math.Abs(result) || (Math.Abs(num) == Math.Abs(result) && num > result))
                {
                    result = num;
                }
            }

            return result;
        }
    }
}