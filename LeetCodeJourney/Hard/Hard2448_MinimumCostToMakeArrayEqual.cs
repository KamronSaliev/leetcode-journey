using System;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-cost-to-make-array-equal/
    /// </summary>
    public class Hard2448_MinimumCostToMakeArrayEqual
    {
        public long MinCost(int[] nums, int[] cost)
        {
            var left = int.MaxValue;
            var right = int.MinValue;

            for (var i = 0; i < nums.Length; i++)
            {
                left = Math.Min(nums[i], left);
                right = Math.Max(nums[i], right);
            }

            var result = 0L;

            while (left < right)
            {
                var mid = left + (right - left) / 2;
                var totalCost1 = GetCost(nums, cost, mid);
                var totalCost2 = GetCost(nums, cost, mid + 1);
                result = Math.Min(totalCost1, totalCost2);

                if (totalCost1 > totalCost2)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            return result;
        }

        private long GetCost(int[] nums, int[] cost, int num)
        {
            var totalCost = 0L;

            for (var i = 0; i < nums.Length; i++)
            {
                totalCost += (long)Math.Abs(nums[i] - num) * cost[i];
            }

            return totalCost;
        }
    }
}