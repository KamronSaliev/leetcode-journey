using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-value-at-a-given-index-in-a-bounded-array/
    /// </summary>
    public class Medium1802_MaximumValueAtAGivenIndexInABoundedArray
    {
        public int MaxValue(int n, int index, int maxSum)
        {
            if (n == 1)
            {
                return maxSum;
            }

            var result = int.MinValue;
            var left = 1;
            var right = maxSum;

            while (left <= right)
            {
                var num = left + (right - left) / 2;

                var rightSum = CountSum(num - 1, n - index - 1);
                var leftSum = CountSum(num - 1, index);

                var target = maxSum - num;

                if (leftSum <= target - rightSum)
                {
                    result = Math.Max(result, num);
                    left = num + 1;
                }
                else
                {
                    right = num - 1;
                }
            }

            return result;
        }

        private long CountSum(long num, long count)
        {
            if (num >= count)
            {
                return (num + (num - count) + 1) * count / 2;
            }

            return (1 + num) * num / 2 + (count - num);
        }
    }
}