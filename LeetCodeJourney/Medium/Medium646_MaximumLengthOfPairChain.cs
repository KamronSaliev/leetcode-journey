using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-length-of-pair-chain/
    /// </summary>
    public class Medium646_MaximumLengthOfPairChain
    {
        public int FindLongestChain(int[][] pairs)
        {
            Array.Sort(pairs, (a, b) => a[1].CompareTo(b[1]));

            var current = int.MinValue;
            var result = 0;

            foreach (var pair in pairs)
            {
                if (current >= pair[0])
                {
                    continue;
                }

                current = pair[1];
                result++;
            }

            return result;
        }
    }
}