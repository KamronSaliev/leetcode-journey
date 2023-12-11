using System;
using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/element-appearing-more-than-25-in-sorted-array/
    /// </summary>
    public class Easy1287_ElementAppearingMoreThan25InSortedArray
    {
        public int FindSpecialInteger(int[] arr)
        {
            var count = Math.Ceiling(arr.Length * 0.25);
            var numbers = new Dictionary<int, int>();
            var result = arr[0];

            for (var i = 0; i < arr.Length; i++)
            {
                if (numbers.TryGetValue(arr[i], out var current))
                {
                    current++;
                    numbers[arr[i]] = current;

                    if (current >= count)
                    {
                        result = arr[i];
                    }
                }
                else
                {
                    numbers.Add(arr[i], 1);
                }
            }

            return result;
        }
    }
}