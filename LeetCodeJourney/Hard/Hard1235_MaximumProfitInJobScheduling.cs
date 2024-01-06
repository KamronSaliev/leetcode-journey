using System;
using System.Collections.Generic;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-profit-in-job-scheduling/
    /// </summary>
    public class Hard1235_MaximumProfitInJobScheduling
    {
        public int JobScheduling(int[] startTime, int[] endTime, int[] profit)
        {
            var n = startTime.Length;
            var jobs = new List<Job>();

            for (var i = 0; i < n; i++)
            {
                jobs.Add(new Job(startTime[i], endTime[i], profit[i]));
            }

            jobs.Sort((x, y) => x.EndTimeTime.CompareTo(y.EndTimeTime));

            var dp = new int[n + 1];

            for (var i = 1; i <= n; i++)
            {
                dp[i] = Math.Max(dp[i - 1], jobs[i - 1].Profit);

                for (var j = i - 1; j > 0; j--)
                {
                    if (jobs[i - 1].StartTimeTime < jobs[j - 1].EndTimeTime)
                    {
                        continue;
                    }

                    dp[i] = Math.Max(dp[i], dp[j] + jobs[i - 1].Profit);
                    break;
                }
            }

            return dp[n];
        }

        private class Job
        {
            public readonly int StartTimeTime;
            public readonly int EndTimeTime;
            public readonly int Profit;

            public Job(int startTime, int endTime, int profit)
            {
                StartTimeTime = startTime;
                EndTimeTime = endTime;
                Profit = profit;
            }
        }
    }
}