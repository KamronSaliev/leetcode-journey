using System;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/power-of-two/
    /// </summary>
    public class Easy231_PowerOfTwo
    {
        public bool IsPowerOfTwo(int n)
        {
            if (n <= 0)
            {
                return false;
            }

            var val = Math.Log2(n);

            return Math.Ceiling(val) == val;
        }
    }
}