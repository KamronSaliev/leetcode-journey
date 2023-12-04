using System;
using System.Linq;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-number-of-achievable-transfer-requests/
    /// </summary>
    public class Hard1601_MaximumNumberOfAchievableTransferRequests
    {
        private int _result;

        public int MaximumRequests(int n, int[][] requests)
        {
            DFS(requests, 0, new int[n], 0);
            return _result;
        }

        private void DFS(int[][] requests, int index, int[] buildings, int num)
        {
            if (index == requests.Length)
            {
                if (buildings.All(i => i == 0))
                {
                    _result = Math.Max(_result, num);
                }

                return;
            }

            DFS(requests, index + 1, buildings, num);

            var request = requests[index];
            var from = request[0];
            var to = request[1];

            buildings[from]++;
            buildings[to]--;
            DFS(requests, index + 1, buildings, num + 1);
            buildings[from]--;
            buildings[to]++;
        }
    }
}