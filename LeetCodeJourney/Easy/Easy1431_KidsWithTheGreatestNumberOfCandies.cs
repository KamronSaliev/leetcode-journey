using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/
    /// </summary>
    public class Easy1431_KidsWithTheGreatestNumberOfCandies
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var max = candies[0];
            for (var i = 1; i < candies.Length; i++)
            {
                if (candies[i] > max)
                {
                    max = candies[i];
                }
            }

            var result = new bool[candies.Length];
            for (var i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies >= max)
                {
                    result[i] = true;
                }
            }

            return result;
        }
    }
}