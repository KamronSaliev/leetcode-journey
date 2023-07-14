using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/longest-arithmetic-subsequence-of-given-difference/
    /// </summary>
    public class Medium1218_LongestArithmeticSubsequenceOfGivenDifference
    {
        public int LongestSubsequence(int[] arr, int difference)
        {
            var dictionary = new Dictionary<int, int>();
            var result = 0;

            for (var i = 0; i < arr.Length; ++i)
            {
                if (!dictionary.ContainsKey(arr[i]))
                {
                    dictionary.Add(arr[i], 1);
                }

                var temp = dictionary.ContainsKey(arr[i] - difference) ? dictionary[arr[i] - difference] : 1;

                dictionary[arr[i]] = Math.Max(dictionary[arr[i]], temp + 1);
                result = Math.Max(result, temp);
            }

            return result;
        }
    }
}