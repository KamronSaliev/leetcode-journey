using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/max-number-of-k-sum-pairs
    /// </summary>
    public class Medium1679_MaxNumberOfKSumPairs
    {
        public int MaxOperations(int[] nums, int k)
        {
            Array.Sort(nums);

            var result = 0;
            var left = 0;
            var right = nums.Length - 1;

            while (left < right)
            {
                var sum = nums[left] + nums[right];

                if (sum == k)
                {
                    result++;
                    left++;
                    right--;
                }
                else if (sum < k)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return result;
        }
    }
}