using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/arithmetic-subarrays/description/
    /// </summary>
    public class Medium1630_ArithmeticSubarrays
    {
        public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r)
        {
            var result = new List<bool>();

            for (var i = 0; i < l.Length; i++)
            {
                var left = l[i];
                var right = r[i];
                var subArray = new int[right - left + 1];
                Array.Copy(nums, left, subArray, 0, right - left + 1);
                result.Add(IsArithmeticSequence(subArray));
            }

            return result;
        }

        private bool IsArithmeticSequence(int[] arr)
        {
            Array.Sort(arr);
            var difference = arr[1] - arr[0];

            for (var i = 2; i < arr.Length; i++)
            {
                if (arr[i] - arr[i - 1] != difference)
                {
                    return false;
                }
            }

            return true;
        }
    }
}