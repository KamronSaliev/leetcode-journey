using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/ipo/
    /// </summary>
    public class Hard502_IPO
    {
        public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital)
        {
            var projects = new List<(int Capital, int Profit)>();
            for (var i = 0; i < capital.Length; i++)
            {
                projects.Add((capital[i], profits[i]));
            }

            // sort projects by their minimum capital required
            projects = projects.OrderBy(x => x.Capital).ThenByDescending(x => x.Profit).ToList();

            var priorityQueue = new PriorityQueue<int, int>();
            var index = 0;

            while (k > 0)
            {
                // project can be completed, if the current capital is more or equal to the minimum capital requirement
                while (index < projects.Count && w >= projects[index].Capital)
                {
                    priorityQueue.Enqueue(projects[index].Profit, -projects[index].Profit);
                    index++;
                }

                if (priorityQueue.Count == 0)
                {
                    break;
                }

                w += priorityQueue.Dequeue();
                k--;
            }

            return w;
        }
    }
}