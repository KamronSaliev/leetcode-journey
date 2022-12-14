using System;
using System.Collections.Generic;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/two-sum/
    /// </summary>
    public class Easy1_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                dict.TryGetValue(complement, out var complementIndex);

                if (dict.ContainsKey(complement))
                {
                    return new[] { i, complementIndex };
                }

                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }

            return Array.Empty<int>();
        }
    }
}