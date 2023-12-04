using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/maximal-network-rank/
    /// </summary>
    public class Medium1615_MaximalNetworkRank
    {
        public int MaximalNetworkRank(int n, int[][] roads)
        {
            var degree = new int[n];
            var roadSet = new HashSet<string>();

            foreach (var road in roads)
            {
                degree[road[0]]++;
                degree[road[1]]++;
                roadSet.Add(road[0] + "," + road[1]);
                roadSet.Add(road[1] + "," + road[0]);
            }

            var maxRank = 0;
            
            for (var i = 0; i < n; i++)
            {
                for (var j = i + 1; j < n; j++)
                {
                    var rank = degree[i] + degree[j];
                    
                    if (roadSet.Contains(i + "," + j))
                    {
                        rank--;
                    }

                    maxRank = Math.Max(maxRank, rank);
                }
            }

            return maxRank;
        }
    }
}