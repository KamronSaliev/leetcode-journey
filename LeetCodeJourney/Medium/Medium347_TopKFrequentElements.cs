using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/top-k-frequent-elements/
    /// </summary>
    public class Medium347_TopKFrequentElements
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            var result = new int[k];
            Dictionary<int, int> dictionary = new();

            for (var i = 0; i < nums.Length; i++)
            {
                dictionary[nums[i]] = dictionary.GetValueOrDefault(nums[i], 0) + 1;
            }

            var items = dictionary.OrderByDescending(item => item.Value);

            foreach (var item in items)
            {
                k--;

                if (k < 0)
                {
                    break;
                }

                result[k] = item.Key;
            }

            return result;
        }
    }
}