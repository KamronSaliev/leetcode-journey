using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/evaluate-division/
    /// </summary>
    public class Medium399_EvaluateDivision
    {
        public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
        {
            var dictionary = new Dictionary<string, Dictionary<string, double>>();
            var result = new double[queries.Count];

            for (var i = 0; i < equations.Count; i++)
            {
                var equation = equations[i];
                var value = values[i];

                if (!dictionary.TryAdd(equation[0], new Dictionary<string, double> { { equation[1], value } }))
                {
                    dictionary[equation[0]].Add(equation[1], value);
                }

                if (!dictionary.TryAdd(equation[1], new Dictionary<string, double> { { equation[0], 1 / value } }))
                {
                    dictionary[equation[1]].Add(equation[0], 1 / value);
                }
            }

            for (var i = 0; i < queries.Count; i++)
            {
                var query = queries[i];
                result[i] = BFS(query[0], query[1], dictionary);
            }

            return result;
        }

        private double BFS(string start, string target, Dictionary<string, Dictionary<string, double>> dictionary)
        {
            if (!dictionary.ContainsKey(start) || !dictionary.ContainsKey(target))
            {
                return -1d;
            }

            var queue = new Queue<(string node, double val)>();
            queue.Enqueue((start, 1d));
            
            var visited = new HashSet<string>();
            
            while (queue.Count > 0)
            {
                var curr = queue.Dequeue();
                
                if (visited.Contains(curr.node))
                {
                    continue;
                }

                visited.Add(curr.node);
                
                foreach (var pair in dictionary[curr.node])
                {
                    if (pair.Key == target)
                    {
                        return curr.val * pair.Value;
                    }

                    queue.Enqueue((pair.Key, curr.val * pair.Value));
                }
            }

            return -1d;
        }
    }
}