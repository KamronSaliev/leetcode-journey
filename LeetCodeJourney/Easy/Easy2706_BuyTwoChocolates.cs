using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/buy-two-chocolates/
    /// </summary>
    public class Easy2706_BuyTwoChocolates
    {
        public int BuyChoco(int[] prices, int money)
        {
            Array.Sort(prices);

            return prices[0] + prices[1] <= money ? money - prices[0] - prices[1] : money;
        }
    }
}