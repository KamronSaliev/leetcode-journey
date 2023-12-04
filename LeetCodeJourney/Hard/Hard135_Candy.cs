using System;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/candy/
    /// </summary>
    public class Hard135_Candy
    {
        public int Candy(int[] ratings)
        {
            var n = ratings.Length;
            var candies = new int[n];
            Array.Fill(candies, 1);

            for (var i = 1; i < n; i++)
            {
                if (ratings[i] > ratings[i - 1])
                {
                    candies[i] = candies[i - 1] + 1;
                }
            }

            for (var i = n - 2; i >= 0; i--)
            {
                if (ratings[i] > ratings[i + 1])
                {
                    candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
                }
            }

            var result = 0;
            for (var i = 0; i < n; i++)
            {
                result += candies[i];
            }

            return result;
        }
    }
}