using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/single-number-ii/
    /// </summary>
    public class Medium137_SingleNumberII
    {
        public int SingleNumber(int[] nums)
        {
            var dictionary = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (dictionary.ContainsKey(nums[i]))
                {
                    dictionary[nums[i]]++;
                }
                else
                {
                    dictionary.Add(nums[i], 1);
                }
            }

            return dictionary.First(x => x.Value == 1).Key;
        }
    }
}