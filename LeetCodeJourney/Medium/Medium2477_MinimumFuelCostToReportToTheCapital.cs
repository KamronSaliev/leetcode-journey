using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-fuel-cost-to-report-to-the-capital/
    /// </summary>
    public class Medium2477_MinimumFuelCostToReportToTheCapital
    {
        public long MinimumFuelCost(int[][] roads, int seats)
        {
            var graph = new List<int>[roads.Length * 2];
            var inDegree = new int[roads.Length * 2];
            var currentPassengers = new int[roads.Length * 2];
            
            for (var i = 0; i < graph.Length; i++)
            {
                graph[i] = new List<int>();
            }

            for (var i = 0; i < roads.Length; i++)
            {
                var node1 = roads[i][0];
                var node2 = roads[i][1];
                graph[node1].Add(node2);
                graph[node2].Add(node1);
                inDegree[node1]++;
                inDegree[node2]++;
            }

            for (var i = 0; i < currentPassengers.Length; i++)
            {
                currentPassengers[i] = 1;
            }

            var queue = new Queue<int>();
            for (var i = 1; i < inDegree.Length; i++)
            {
                if (inDegree[i] == 1)
                {
                    queue.Enqueue(i);
                }
            }

            var result = 0L;
            while (queue.Count != 0)
            {
                var count = queue.Count;
                
                for (var i = 0; i < count; i++)
                {
                    var current = queue.Dequeue();
                    var parentNode = graph[current][0];
                    inDegree[parentNode]--;
                    
                    if (inDegree[parentNode] == 1 && parentNode != 0)
                    {
                        queue.Enqueue(parentNode);
                    }

                    currentPassengers[parentNode] += currentPassengers[current];

                    result += (currentPassengers[current] - 1) / seats + 1;
                }
            }

            return result;
        }
    }
}