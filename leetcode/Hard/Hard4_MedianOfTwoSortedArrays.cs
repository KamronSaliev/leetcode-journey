using System;
using System.Linq;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/median-of-two-sorted-arrays/
    /// </summary>
    public class Hard4_MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var combined = nums1.Concat(nums2).ToArray();

            Array.Sort(combined);

            var mid = combined.Length / 2;

            if (combined.Length % 2 == 0)
            {
                return (combined[mid - 1] + combined[mid]) / 2.0d;
            }

            return combined[mid];
        }
    }
}