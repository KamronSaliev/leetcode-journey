using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/find-players-with-zero-or-one-losses/
    /// </summary>
    public class Medium2225_FindPlayersWithZeroOrOneLosses
    {
        public IList<IList<int>> FindWinners(int[][] matches)
        {
            var winners = matches.Select(i => i[0]).ToList();
            var losers = matches.Select(i => i[1]).ToList();

            return new List<IList<int>>
            {
                winners.Except(losers).OrderBy(i => i).ToList(),
                losers.GroupBy(i => i).Where(i => i.Count() == 1).Select(i => i.Key).OrderBy(i => i).ToList()
            };
        }
    }
}