using System;
using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/count-elements-with-maximum-frequency/
    /// </summary>
    public class Easy3005_CountElementsWithMaximumFrequency
    {
        public int MaxFrequencyElements(int[] nums)
        {
            var dictionary = new Dictionary<int, int>();
            var maxFrequency = 0;
            var result = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (!dictionary.ContainsKey(nums[i]))
                {
                    dictionary[nums[i]] = 0;
                }

                dictionary[nums[i]]++;
            }

            foreach (var item in dictionary)
            {
                maxFrequency = Math.Max(maxFrequency, item.Value);
            }

            foreach (var item in dictionary)
            {
                if (item.Value == maxFrequency)
                {
                    result += item.Value;
                }
            }

            return result;
        }
    }
}