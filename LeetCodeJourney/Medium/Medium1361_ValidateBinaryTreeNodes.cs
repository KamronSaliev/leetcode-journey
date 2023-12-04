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
                TryAddNode(leftChild[i], i, graph);
                TryAddNode(rightChild[i], i, graph);
            }

            return graph;
        }

        private void TryAddNode(int node, int index, Dictionary<int, List<int>> graph)
        {
            if (node == -1)
            {
                return;
            }

            if (!graph.ContainsKey(index))
            {
                graph[index] = new List<int>();
            }

            graph[index].Add(node);
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