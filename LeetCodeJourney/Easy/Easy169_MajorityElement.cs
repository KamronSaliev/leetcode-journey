using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/majority-element/
    /// </summary>
    public class Easy169_MajorityElement
    {
        public int MajorityElement(int[] nums)
        {
            var occurrences = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (!occurrences.TryAdd(nums[i], 1))
                {
                    occurrences[nums[i]]++;
                }

                if (occurrences[nums[i]] > nums.Length / 2)
                {
                    return nums[i];
                }
            }

            return -1;
        }
    }
}