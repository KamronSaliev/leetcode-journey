using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/validate-binary-tree-nodes/
    /// </summary>
    public class Medium1361_ValidateBinaryTreeNodes
    {
        public bool ValidateBinaryTreeNodes(int n, int[] leftChild, int[] rightChild)
        {
            var graph = BuildBinaryTreeGraph(n, leftChild, rightChild);
            var queue = new Queue<int>();
            var visited = new HashSet<int>();
            var root = FindBinaryTreeRoot(n, leftChild, rightChild);

            if (root == -1)
            {
                return false;
            }

            queue.Enqueue(root);
            visited.Add(root);

            while (queue.Count != 0)
            {
                var current = queue.Dequeue();

                if (!graph.TryGetValue(current, out var value))
                {
                    continue;
                }

                foreach (var child in value)
                {
                    if (visited.Contains(child))
                    {
                        return false;
                    }

                    visited.Add(child);
                    queue.Enqueue(child);
                }
            }

            return visited.Count == n;
        }

        private Dictionary<int, List<int>> BuildBinaryTreeGraph(int n, int[] leftChild, int[] rightChild)
        {
            var graph = new Dictionary<int, List<int>>();

            for (var i = 0; i < n; i++)
            {
                var left = leftChild[i];
                var right = rightChild[i];

                if (left != -1)
                {
                    if (!graph.ContainsKey(i))
                    {
                        graph[i] = new List<int>();
                    }

                    graph[i].Add(left);
                }

                if (right != -1)
                {
                    if (!graph.ContainsKey(i))
                    {
                        graph[i] = new List<int>();
                    }

                    graph[i].Add(right);
                }
            }

            return graph;
        }

        private int FindBinaryTreeRoot(int n, int[] leftChild, int[] rightChild)
        {
            var set = new HashSet<int>();

            for (var i = 0; i < n; i++)
            {
                set.Add(i);
            }

            foreach (var node in leftChild)
            {
                set.Remove(node);
            }

            foreach (var node in rightChild)
            {
                set.Remove(node);
            }

            return set.Count == 1 ? set.First() : -1;
        }
    }
}