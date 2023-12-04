using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/third-maximum-number/
    /// </summary>
    public class Easy414_ThirdMaximumNumber
    {
        public int ThirdMax(int[] nums)
        {
            var hashSet = new HashSet<int>();
            var limit = 3;

            for (var i = 0; i < nums.Length; i++)
            {
                hashSet.Add(nums[i]);

                if (hashSet.Count > limit)
                {
                    hashSet.Remove(hashSet.Min());
                }
            }

            return hashSet.Count < limit ? hashSet.Max() : hashSet.Min();
        }
    }
}