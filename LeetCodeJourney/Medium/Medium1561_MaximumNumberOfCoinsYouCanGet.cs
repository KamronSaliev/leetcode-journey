using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-number-of-coins-you-can-get/
    /// </summary>
    public class Medium1561_MaximumNumberOfCoinsYouCanGet
    {
        public int MaxCoins(int[] piles)
        {
            Array.Sort(piles);

            var result = 0;

            for (var i = piles.Length / 3; i < piles.Length; i += 2)
            {
                result += piles[i];
            }

            return result;
        }
    }
}