using System;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/reverse-bits/
    /// </summary>
    public class Easy190_ReverseBits
    {
        public uint reverseBits(uint n)
        {
            var result = string.Empty;

            for (var i = 0; i < 32; i++)
            {
                result += n & 1;
                n >>= 1;
            }

            return Convert.ToUInt32(result, 2);
        }
    }
}