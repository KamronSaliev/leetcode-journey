using System;
using System.Linq;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/last-moment-before-all-ants-fall-out-of-a-plank/description/
    /// </summary>
    public class Medium1503_LastMomentBeforeAllAntsFallOutOfAPlank
    {
        public int GetLastMoment(int n, int[] left, int[] right)
        {
            var maxLeft = left.Length == 0 ? 0 : left.Max();
            var minRight = right.Length == 0 ? n : right.Min();
            return Math.Max(maxLeft, n - minRight);
        }
    }
}