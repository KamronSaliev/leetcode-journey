using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/reduction-operations-to-make-the-array-elements-equal/
    /// </summary>
    public class Medium1887_ReductionOperationsToMakeTheArrayElementsEqual
    {
        public int ReductionOperations(int[] nums)
        {
            Array.Sort(nums);

            var result = 0;
            var increment = 0;

            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    increment++;
                }

                result += increment;
            }

            return result;
        }
    }
}