using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/find-the-difference-of-two-arrays/
    /// </summary>
    public class Medium2215_FindTheDifferenceOfTwoArrays
    {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            var numHashSet1 = nums1.ToHashSet();
            var numHashSet2 = nums2.ToHashSet();

            foreach (var item in nums1)
            {
                if (numHashSet2.Contains(item))
                {
                    numHashSet1.Remove(item);
                    numHashSet2.Remove(item);
                }
            }

            return new List<IList<int>> { numHashSet1.ToList(), numHashSet2.ToList() };
        }
    }
}