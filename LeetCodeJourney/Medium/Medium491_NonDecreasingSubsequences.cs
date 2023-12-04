using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/non-decreasing-subsequences/
    /// </summary>
    public class Medium491_NonDecreasingSubsequences
    {
        public IList<IList<int>> FindSubsequences(int[] nums)
        {
            return FindSubsequences(nums, new List<int>(), 0);
        }

        private IList<IList<int>> FindSubsequences(int[] nums, List<int> current, int index)
        {
            var result = new List<IList<int>>();
            var used = new HashSet<int>();

            for (var i = index; i < nums.Length; i++)
            {
                if (i != index && used.Contains(nums[i]))
                {
                    continue;
                }

                if (index == 0 || nums[i] >= current[^1])
                {
                    current.Add(nums[i]);
                    if (current.Count > 1)
                    {
                        result.Add(current.ToList());
                    }

                    result.AddRange(FindSubsequences(nums, current, i + 1));
                    current.RemoveAt(current.Count - 1);
                }

                used.Add(nums[i]);
            }

            return result;
        }
    }
}