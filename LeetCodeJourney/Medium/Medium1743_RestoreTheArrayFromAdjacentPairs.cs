using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/restore-the-array-from-adjacent-pairs/
    /// </summary>
    public class Medium1743_RestoreTheArrayFromAdjacentPairs
    {
        public int[] RestoreArray(int[][] adjacentPairs)
        {
            var connections = new Dictionary<int, int>();
            var used = new HashSet<int>();

            foreach (var pairs in adjacentPairs)
            {
                if (!connections.ContainsKey(pairs[0]))
                {
                    connections.Add(pairs[0], 0);
                }

                if (!connections.ContainsKey(pairs[1]))
                {
                    connections.Add(pairs[1], 0);
                }

                connections[pairs[0]] += pairs[1];
                connections[pairs[1]] += pairs[0];

                if (used.Contains(pairs[0]))
                {
                    used.Remove(pairs[0]);
                }
                else
                {
                    used.Add(pairs[0]);
                }

                if (used.Contains(pairs[1]))
                {
                    used.Remove(pairs[1]);
                }
                else
                {
                    used.Add(pairs[1]);
                }
            }

            var result = new int[connections.Count];
            foreach (var start in used)
            {
                var index = 0;
                var last = 0;
                var num = start;
                while (index < connections.Count)
                {
                    result[index] = num;
                    num = connections[num] - last;
                    last = result[index++];
                }

                break;
            }

            return result;
        }
    }
}