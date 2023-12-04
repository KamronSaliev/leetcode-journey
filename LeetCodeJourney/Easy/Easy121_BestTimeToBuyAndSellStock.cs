using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
    /// </summary>
    public class Easy121_BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            var buy = prices[0];
            var sell = 0;
            var maxProfit = 0;

            for (var i = 0; i < prices.Length; i++)
            {
                if (prices[i] < buy)
                {
                    buy = prices[i];
                    sell = prices[i];
                }
                else if (prices[i] > sell)
                {
                    sell = prices[i];
                    maxProfit = Math.Max(maxProfit, sell - buy);
                }
            }

            return maxProfit;
        }
    }
}