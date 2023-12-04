using System;
using System.Collections.Generic;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/reconstruct-itinerary/
    /// </summary>
    public class Hard332_ReconstructItinerary
    {
        public IList<string> FindItinerary(IList<IList<string>> tickets)
        {
            var graph = new Dictionary<string, List<string>>();
            var itinerary = new List<string>();

            foreach (var ticket in tickets)
            {
                if (!graph.ContainsKey(ticket[0]))
                {
                    graph[ticket[0]] = new List<string>();
                }

                graph[ticket[0]].Add(ticket[1]);
            }

            foreach (var destinations in graph.Values)
            {
                destinations.Sort((a, b) => string.Compare(b, a, StringComparison.Ordinal));
            }

            DFS("JFK", graph, itinerary);

            itinerary.Reverse();

            return itinerary;
        }

        private void DFS(string airport, Dictionary<string, List<string>> graph, List<string> itinerary)
        {
            while (graph.ContainsKey(airport) && graph[airport].Count > 0)
            {
                var next = graph[airport][^1];
                graph[airport].RemoveAt(graph[airport].Count - 1);
                DFS(next, graph, itinerary);
            }

            itinerary.Add(airport);
        }
    }
}