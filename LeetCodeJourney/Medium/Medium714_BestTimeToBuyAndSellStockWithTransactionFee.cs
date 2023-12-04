using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/best-time-to-buy-and-sell-stock-with-transaction-fee/
    /// </summary>
    public class Medium714_BestTimeToBuyAndSellStockWithTransactionFee
    {
        public int MaxProfit(int[] prices, int fee)
        {
            if (prices.Length <= 1)
            {
                return 0;
            }

            var save = -prices[0];
            var profit = 0;

            for (var i = 1; i < prices.Length; i++)
            {
                profit = Math.Max(profit, save + prices[i] - fee);
                save = Math.Max(save, profit - prices[i]);
            }

            return profit;
        }
    }
}