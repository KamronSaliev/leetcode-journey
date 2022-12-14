using System;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/number-of-1-bits/
    /// </summary>
    public class Easy191_NumberOf1Bits
    {
        public int HammingWeight(uint n)
        {
            var counter = 0;

            for (var i = 0; i < 32; i++)
            {
                if (Convert.ToBoolean(n & 1))
                {
                    counter++;
                }

                n >>= 1;
            }

            return counter;
        }
    }
}