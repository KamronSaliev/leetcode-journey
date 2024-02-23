using System;
using System.Linq;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/make-two-arrays-equal-by-reversing-subarrays/
    /// </summary>
    public class Easy1460_MakeTwoArraysEqualByReversingSubarrays
    {
        public bool CanBeEqual(int[] target, int[] arr)
        {
            Array.Sort(arr);
            Array.Sort(target);

            return arr.SequenceEqual(target);
        }
    }
}