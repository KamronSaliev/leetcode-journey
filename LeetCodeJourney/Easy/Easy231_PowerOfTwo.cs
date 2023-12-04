using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/power-of-two/
    /// </summary>
    public class Easy231_PowerOfTwo
    {
        public bool IsPowerOfTwo(int n)
        {
            return Math.Log2(n) % 1 == 0;
        }
    }
}