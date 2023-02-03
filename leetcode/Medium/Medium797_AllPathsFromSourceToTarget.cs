using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/all-paths-from-source-to-target/
    /// </summary>
    public class Medium797_AllPathsFromSourceToTarget
    {
        public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            var lists = new List<IList<int>>();
            DFS(0, new List<int>() { 0 }, lists, graph);
            return lists;
        }

        private void DFS(int i, IList<int> currentList, IList<IList<int>> lists, int[][] graph)
        {
            if (i == graph.Length - 1)
            {
                lists.Add(new List<int>(currentList));
            }
            else
            {
                for (var j = 0; j < graph[i].Length; j++)
                {
                    currentList.Add(graph[i][j]);
                    DFS(graph[i][j], currentList, lists, graph);
                    currentList.RemoveAt(currentList.Count - 1);
                }
            }
        }
    }
}