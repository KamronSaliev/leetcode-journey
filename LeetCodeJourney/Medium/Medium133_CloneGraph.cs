using System.Collections.Generic;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/clone-graph/
    /// </summary>
    public class Medium133_CloneGraph
    {
        public Node CloneGraph(Node node)
        {
            if (node == null)
            {
                return null;
            }

            var queue = new Queue<Node>();
            var visited = new Dictionary<Node, (Node Node, bool Visited)>();

            queue.Enqueue(node);
            visited.Add(node, (new Node(node.val), false));

            while (queue.Count != 0)
            {
                var current = queue.Dequeue();
                var copy = visited[current].Node;

                foreach (var neighbor in current.neighbors)
                {
                    if (!visited.ContainsKey(neighbor))
                    {
                        visited.Add(neighbor, (new Node(neighbor.val), false));
                    }

                    copy.neighbors.Add(visited[neighbor].Node);

                    if (!visited[neighbor].Visited && !queue.Contains(neighbor))
                    {
                        queue.Enqueue(neighbor);
                    }
                }

                visited[current] = (visited[current].Node, true);
            }

            return visited[node].Node;
        }
    }
}