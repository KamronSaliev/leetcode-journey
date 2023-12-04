using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/sort-items-by-groups-respecting-dependencies/
    ///     https://leetcode.com/problems/sort-items-by-groups-respecting-dependencies/solutions/3933824/easy-solution-python-python3-c-java-use-toposort-with-image/
    /// </summary>
    public class Hard1203_SortItemsByGroupsRespectingDependencies
    {
        public int[] SortItems(int n, int m, int[] group, IList<IList<int>> beforeItems)
        {
            var groupItems = new Dictionary<int, List<int>>();
            var groupIdCounter = m;

            for (var i = 0; i < n; i++)
            {
                if (group[i] == -1)
                {
                    group[i] = groupIdCounter;
                    groupIdCounter++;
                }

                if (!groupItems.ContainsKey(group[i]))
                {
                    groupItems[group[i]] = new List<int>();
                }

                groupItems[group[i]].Add(i);
            }

            var itemGraph = new Dictionary<int, List<int>>();
            var itemInDegree = new Dictionary<int, int>();

            for (var v = 0; v < n; v++)
            {
                foreach (var u in beforeItems[v])
                {
                    if (group[u] == group[v])
                    {
                        if (!itemGraph.ContainsKey(u))
                        {
                            itemGraph[u] = new List<int>();
                        }

                        itemGraph[u].Add(v);
                        itemInDegree.TryAdd(v, 0);
                        itemInDegree[v]++;
                    }
                }
            }

            var sortedGroupItems = new Dictionary<int, List<int>>();

            foreach (var groupIdKey in groupItems.Keys)
            {
                var sortedItems = TopologicalSort(groupItems[groupIdKey], itemGraph, itemInDegree);

                if (sortedItems.Count != groupItems[groupIdKey].Count)
                {
                    return new int[] { };
                }

                sortedGroupItems[groupIdKey] = sortedItems;
            }

            var groupGraph = new Dictionary<int, List<int>>();
            var groupInDegree = new Dictionary<int, int>();

            for (var v = 0; v < n; v++)
            {
                foreach (var u in beforeItems[v])
                {
                    if (group[u] != group[v])
                    {
                        if (!groupGraph.ContainsKey(group[u]))
                        {
                            groupGraph[group[u]] = new List<int>();
                        }

                        groupGraph[group[u]].Add(group[v]);
                        if (!groupInDegree.ContainsKey(group[v]))
                        {
                            groupInDegree[group[v]] = 0;
                        }

                        groupInDegree[group[v]]++;
                    }
                }
            }

            var groups = new HashSet<int>(group);
            var sortedGroups = TopologicalSort(groups, groupGraph, groupInDegree);

            if (groups.Count != sortedGroups.Count)
            {
                return new int[] { };
            }

            var result = new List<int>();

            foreach (var groupId in sortedGroups)
            {
                result.AddRange(sortedGroupItems[groupId]);
            }

            return result.ToArray();
        }

        private List<int> TopologicalSort(IEnumerable<int> nodes, Dictionary<int, List<int>> graph,
            Dictionary<int, int> inDegree)
        {
            var queue = new Queue<int>(nodes.Where(node => !inDegree.ContainsKey(node)));
            var result = new List<int>();

            while (queue.Count > 0)
            {
                var curNode = queue.Dequeue();
                result.Add(curNode);

                if (!graph.TryGetValue(curNode, out var value))
                {
                    continue;
                }

                foreach (var neighbor in value)
                {
                    inDegree[neighbor]--;
                    if (inDegree[neighbor] == 0)
                    {
                        queue.Enqueue(neighbor);
                    }
                }
            }

            return result;
        }
    }
}