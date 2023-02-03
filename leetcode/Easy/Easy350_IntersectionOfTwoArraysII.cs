using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/intersection-of-two-arrays-ii/
    /// </summary>
    public class Easy350_IntersectionOfTwoArraysII
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            var dict = new Dictionary<int, int>();
            var result = new List<int>();

            for (var i = 0; i < nums1.Length; i++)
            {
                if (!dict.ContainsKey(nums1[i]))
                {
                    dict.Add(nums1[i], 1);
                }
                else
                {
                    dict[nums1[i]]++;
                }
            }

            for (var i = 0; i < nums2.Length; i++)
            {
                if (!dict.ContainsKey(nums2[i]))
                {
                    continue;
                }

                if (dict[nums2[i]] <= 0)
                {
                    continue;
                }

                result.Add(nums2[i]);
                dict[nums2[i]]--;
            }

            return result.ToArray();
        }
    }
}