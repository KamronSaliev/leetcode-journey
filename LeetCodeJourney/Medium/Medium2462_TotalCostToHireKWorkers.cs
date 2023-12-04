using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/total-cost-to-hire-k-workers/
    /// </summary>
    public class Medium2462_TotalCostToHireKWorkers
    {
        public long TotalCost(int[] costs, int k, int candidates)
        {
            var workers = new PriorityQueue<(int cost, bool isFirstCandidate), (int cost, int index)>();

            var first = 0;
            var last = costs.Length - 1;
            long totalHireCost = 0;

            var firstCandidates = candidates;
            var lastCandidates = candidates;

            for (var session = 0; session < k; session++)
            {
                while (first <= last && firstCandidates > 0)
                {
                    workers.Enqueue((costs[first], true), (costs[first], first));

                    first++;
                    firstCandidates--;
                }

                while (first <= last && lastCandidates > 0)
                {
                    workers.Enqueue((costs[last], false), (costs[last], last));

                    last--;
                    lastCandidates--;
                }

                if (workers.Count <= 0)
                {
                    continue;
                }

                var lowestCostWorker = workers.Dequeue();
                totalHireCost += lowestCostWorker.cost;

                if (lowestCostWorker.isFirstCandidate)
                {
                    firstCandidates++;
                }
                else
                {
                    lastCandidates++;
                }
            }

            return totalHireCost;
        }
    }
}