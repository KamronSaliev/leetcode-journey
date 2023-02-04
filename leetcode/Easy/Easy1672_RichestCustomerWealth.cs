using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/richest-customer-wealth/
    /// </summary>
    public class Easy1672_RichestCustomerWealth
    {
        public int MaximumWealth(int[][] accounts)
        {
            var max = int.MinValue;

            for (var i = 0; i < accounts.Length; i++)
            {
                var sum = 0;

                for (var j = 0; j < accounts[0].Length; j++)
                {
                    sum += accounts[i][j];
                }

                max = Math.Max(max, sum);
            }

            return max;
        }
    }
}