using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/greatest-common-divisor-traversal/
    /// </summary>
    public class Hard2709_GreatestCommonDivisorTraversal
    {
        public bool CanTraverseAllPairs(int[] nums)
        {
            var n = nums.Length;
            var graph = BuildGraph(nums);
            var visited = new bool[n];

            DFS(0, visited, graph);

            return visited.All(v => v);
        }

        private List<int>[] BuildGraph(int[] nums)
        {
            var n = nums.Length;
            var graph = new List<int>[n];
            var dictionary = new Dictionary<int, int>();

            for (var i = 0; i < n; i++)
            {
                graph[i] = new List<int>();
            }

            for (var i = 0; i < n; i++)
            {
                AddPrimeFactors(nums[i], i, dictionary, graph);
            }

            return graph;
        }

        private void AddPrimeFactors(int num, int index, Dictionary<int, int> dictionary, List<int>[] graph)
        {
            for (var i = 2; i * i <= num; i++)
            {
                if (num % i != 0)
                {
                    continue;
                }

                AddFactor(i, index, dictionary, graph);

                while (num % i == 0)
                {
                    num /= i;
                }
            }

            if (num > 1)
            {
                AddFactor(num, index, dictionary, graph);
            }
        }

        private void AddFactor(int factor, int index, Dictionary<int, int> dictionary, List<int>[] graph)
        {
            if (dictionary.TryAdd(factor, index))
            {
                return;
            }

            var node = dictionary[factor];
            graph[index].Add(node);
            graph[node].Add(index);
        }

        private void DFS(int node, bool[] visited, List<int>[] graph)
        {
            visited[node] = true;

            foreach (var neighbor in graph[node].Where(neighbor => !visited[neighbor]))
            {
                DFS(neighbor, visited, graph);
            }
        }
    }
}