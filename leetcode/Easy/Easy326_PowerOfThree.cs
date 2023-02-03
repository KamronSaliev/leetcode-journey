using System;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/power-of-three/
    /// </summary>
    public class Easy326_PowerOfThree
    {
        public bool IsPowerOfThree(int n)
        {
            return Math.Log10(n) / Math.Log10(3) % 1 == 0;
        }
    }
}