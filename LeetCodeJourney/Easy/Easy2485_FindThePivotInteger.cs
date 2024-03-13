using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/find-the-pivot-integer
    /// </summary>
    public class Easy2485_FindThePivotInteger
    {
        public int PivotInteger(int n)
        {
            var x = Math.Sqrt((n * n + n) / 2.0);
            var y = (int)x;
            return x == y ? y : -1;
        }
    }
}