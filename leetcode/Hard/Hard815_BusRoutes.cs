using System.Collections.Generic;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/bus-routes/
    /// </summary>
    public class Hard815_BusRoutes
    {
        public int NumBusesToDestination(int[][] routes, int source, int target)
        {
            if (source == target)
            {
                return 0;
            }

            var stopToRoutes = new Dictionary<int, List<int>>();

            for (var i = 0; i < routes.Length; i++)
            {
                foreach (var stop in routes[i])
                {
                    if (!stopToRoutes.ContainsKey(stop))
                    {
                        stopToRoutes[stop] = new List<int>();
                    }

                    stopToRoutes[stop].Add(i);
                }
            }

            var queue = new Queue<int>();
            var visitedStops = new HashSet<int>();
            var visitedRoutes = new HashSet<int>();
            var result = 0;

            queue.Enqueue(source);
            visitedStops.Add(source);

            while (queue.Count != 0)
            {
                var size = queue.Count;

                for (var i = 0; i < size; i++)
                {
                    var currentStop = queue.Dequeue();
                    var busesAtStop = stopToRoutes.TryGetValue(currentStop, out var route)
                        ? route
                        : new List<int>();

                    foreach (var bus in busesAtStop)
                    {
                        if (!visitedRoutes.Add(bus))
                        {
                            continue;
                        }

                        foreach (var nextStop in routes[bus])
                        {
                            if (!visitedStops.Add(nextStop))
                            {
                                continue;
                            }

                            if (nextStop == target)
                            {
                                return result + 1;
                            }

                            queue.Enqueue(nextStop);
                        }
                    }
                }

                result++;
            }

            return -1;
        }
    }
}