using System.Collections.Generic;

namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/minimum-time-to-collect-all-apples-in-a-tree/
    /// </summary>
    public class Medium1443_MinimumTimeToCollectAllApplesInATree
    {
        private Dictionary<int, List<int>> _tree;

        public int MinTime(int n, int[][] edges, IList<bool> hasApple)
        {
            _tree = new Dictionary<int, List<int>>();

            BuildTree(edges);

            return DFS(0, -1, hasApple);
        }

        private int DFS(int node, int parent, IList<bool> hasApple)
        {
            if (!_tree.ContainsKey(node))
            {
                return 0;
            }

            var totalTime = 0;

            foreach (var child in _tree[node])
            {
                if (child == parent)
                {
                    continue;
                }
                
                var childTime = DFS(child, node, hasApple);

                if (childTime > 0 || hasApple[child])
                {
                    totalTime += childTime + 2;
                }
            }

            return totalTime;
        }

        private void BuildTree(int[][] edges)
        {
            foreach (var edge in edges)
            {
                var a = edge[0];
                var b = edge[1];

                if (!_tree.ContainsKey(a))
                {
                    _tree.Add(a, new List<int>());
                }

                if (!_tree.ContainsKey(b))
                {
                    _tree.Add(b, new List<int>());
                }

                _tree[a].Add(b);
                _tree[b].Add(a);
            }
        }
    }
}