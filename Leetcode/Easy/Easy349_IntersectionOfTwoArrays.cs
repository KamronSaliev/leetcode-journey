using System.Collections.Generic;
using System.Linq;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/intersection-of-two-arrays/
    /// </summary>
    public class Easy349_IntersectionOfTwoArrays
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            var intersection = new HashSet<int>();

            for (var i = 0; i < nums2.Length; i++)
            {
                if (nums1.Contains(nums2[i]))
                {
                    intersection.Add(nums2[i]);
                }
            }

            return intersection.ToArray();
        }
    }
}