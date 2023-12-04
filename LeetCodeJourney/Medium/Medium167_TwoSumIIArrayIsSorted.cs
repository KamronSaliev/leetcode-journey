using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
    /// </summary>
    public class Medium167_TwoSumIIArrayIsSorted
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            var l = 0;
            var r = numbers.Length - 1;

            while (l < r)
            {
                if (numbers[l] + numbers[r] == target)
                {
                    return new[] { l + 1, r + 1 };
                }

                if (numbers[l] + numbers[r] > target)
                {
                    r--;
                }
                else
                {
                    l++;
                }
            }

            return Array.Empty<int>();
        }
    }
}