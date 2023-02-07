using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-distance-between-a-pair-of-values/
    /// </summary>
    public class Medium1855_MaximumDistanceBetweenAPairOfValues
    {
        public int MaxDistance(int[] nums1, int[] nums2)
        {
            var max = 0;
            var i = 0;
            var j = 0;

            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] <= nums2[j])
                {
                    var distance = j - i;
                    max = Math.Max(max, distance);
                    j++;
                }
                else
                {
                    i++;
                }
            }

            return max;
        }
    }
}