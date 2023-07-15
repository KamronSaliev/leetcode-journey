using System;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-number-of-events-that-can-be-attended-ii/
    ///     https://leetcode.com/problems/maximum-number-of-events-that-can-be-attended-ii/solutions/3769152/c-solution-for-maximum-number-of-events-that-can-be-attended-ii-problem/
    /// </summary>
    public class Hard1751_MaximumNumberOfEventsThatCanBeAttendedII
    {
        public int MaxValue(int[][] events, int k)
        {
            Array.Sort(events, (a, b) => a[0] - b[0]);

            var dp = new int[k + 1][];

            for (var i = 0; i <= k; i++)
            {
                dp[i] = new int[events.Length];
                Array.Fill(dp[i], -1);
            }

            return DFS(0, k, events, dp);
        }

        private int DFS(int curIndex, int count, int[][] events, int[][] dp)
        {
            if (count == 0 || curIndex == events.Length)
            {
                return 0;
            }

            if (dp[count][curIndex] != -1)
            {
                return dp[count][curIndex];
            }

            var nextIndex = BisectRight(events, events[curIndex][1]);
            dp[count][curIndex] = Math.Max(DFS(curIndex + 1, count, events, dp),
                events[curIndex][2] + DFS(nextIndex, count - 1, events, dp));
            
            return dp[count][curIndex];
        }

        private int BisectRight(int[][] events, int target)
        {
            var left = 0;
            var right = events.Length;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (events[mid][0] <= target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            return left;
        }
    }
}