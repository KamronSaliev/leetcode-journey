using System;
using System.Collections.Generic;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/majority-element/
    /// </summary>
    public class Easy169_MajorityElement
    {
        public int MajorityElement(int[] nums)
        {
            var occurrences = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (occurrences.ContainsKey(nums[i]))
                {
                    occurrences[nums[i]]++;
                }
                else
                {
                    occurrences.Add(nums[i], 1);
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