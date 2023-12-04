using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/time-needed-to-inform-all-employees/
    /// </summary>
    public class Medium1376_TimeNeededToInformAllEmployees
    {
        public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime)
        {
            var graph = new List<int>[n];
            for (var i = 0; i < n; i++)
            {
                graph[i] = new List<int>();
            }

            for (var i = 0; i < manager.Length; i++)
            {
                if (manager[i] != -1)
                {
                    graph[manager[i]].Add(i);
                }
            }

            var queue = new Queue<(int Employee, int Time)>();
            queue.Enqueue((headID, 0));

            var result = 0;

            while (queue.Count != 0)
            {
                var current = queue.Dequeue();
                result = Math.Max(result, current.Time);

                foreach (var sub in graph[current.Employee])
                {
                    queue.Enqueue((sub, current.Time + informTime[current.Employee]));
                }
            }

            return result;
        }
    }
}