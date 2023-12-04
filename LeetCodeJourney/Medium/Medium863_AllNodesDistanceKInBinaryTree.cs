using System.Collections.Generic;
using System.Linq;
using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/all-nodes-distance-k-in-binary-tree/
    /// </summary>
    public class Medium863_AllNodesDistanceKInBinaryTree
    {
        public IList<int> DistanceK(TreeNode root, TreeNode target, int k)
        {
            if (k == 0)
            {
                return new List<int> { target.val };
            }

            var graph = new Dictionary<int, List<int>> { { root.val, new List<int>() } };

            BuildGraph(root, graph);

            return BFS(graph, target.val, k);
        }

        private IList<int> BFS(Dictionary<int, List<int>> graph, int first, int k)
        {
            var queue = new Queue<int>();
            var visited = new HashSet<int>();

            queue.Enqueue(first);
            visited.Add(first);

            while (k > 0 && queue.Count > 0)
            {
                var size = queue.Count;

                for (var i = 0; i < size; i++)
                {
                    var current = queue.Dequeue();

                    for (var j = 0; j < graph[current].Count; j++)
                    {
                        if (!visited.Contains(graph[current][j]))
                        {
                            queue.Enqueue(graph[current][j]);
                            visited.Add(graph[current][j]);
                        }
                    }
                }

                k--;
            }

            return queue.ToList();
        }

        private void BuildGraph(TreeNode node, Dictionary<int, List<int>> graph)
        {
            if (node == null || (node.left == null && node.right == null))
            {
                return;
            }

            if (node.left != null)
            {
                graph[node.val].Add(node.left.val);
                graph.Add(node.left.val, new List<int>());
                graph[node.left.val].Add(node.val);
            }

            if (node.right != null)
            {
                graph[node.val].Add(node.right.val);
                graph.Add(node.right.val, new List<int>());
                graph[node.right.val].Add(node.val);
            }

            BuildGraph(node.left, graph);
            BuildGraph(node.right, graph);
        }
    }
}