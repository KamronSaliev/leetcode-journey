using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-number-of-operations-to-make-array-empty/
    /// </summary>
    public class Medium2870_MinimumNumberOfOperationsToMakeArrayEmpty
    {
        public int MinOperations(int[] nums)
        {
            var counts = new Dictionary<int, int>();
            var result = 0;

            foreach (var num in nums)
            {
                counts.TryGetValue(num, out var count);
                counts[num] = count + 1;
            }

            foreach (var count in counts.Values)
            {
                if (count == 1)
                {
                    return -1;
                }

                result += (int)Math.Ceiling(count / 3.0);
            }

            return result;
        }
    }
}