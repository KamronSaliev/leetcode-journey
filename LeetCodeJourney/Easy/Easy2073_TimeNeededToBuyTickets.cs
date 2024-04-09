using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/time-needed-to-buy-tickets
    /// </summary>
    public class Easy2073_TimeNeededToBuyTickets
    {
        public int TimeRequiredToBuy(int[] tickets, int k)
        {
            var result = 0;

            for (var i = 0; i < tickets.Length; i++)
            {
                if (i <= k)
                {
                    result += Math.Min(tickets[i], tickets[k]);
                }
                else
                {
                    result += Math.Min(tickets[i], tickets[k] - 1);
                }
            }

            return result;
        }
    }
}