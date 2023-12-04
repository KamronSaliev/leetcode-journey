using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/combinations/
    /// </summary>
    public class Medium77_Combinations
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            var result = new List<IList<int>>();

            Backtrack(k, n, 1, new List<int>(), result);

            return result;
        }

        private void Backtrack(int k, int n, int start, List<int> list, IList<IList<int>> result)
        {
            if (list.Count == k)
            {
                result.Add(new List<int>(list));
                return;
            }

            for (var i = start; i <= n; i++)
            {
                list.Add(i);
                Backtrack(k, n, i + 1, list, result);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}