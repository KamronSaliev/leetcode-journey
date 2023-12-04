using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/power-of-four/
    /// </summary>
    public class Easy342_PowerOfFour
    {
        public bool IsPowerOfFour(int n)
        {
            return Math.Log10(n) / Math.Log10(4) % 1 == 0;
        }
    }
}