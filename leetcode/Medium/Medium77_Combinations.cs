using System.Collections.Generic;

namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/combinations/
    /// </summary>
    public class Medium77_Combinations
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            var ans = new List<IList<int>>();

            Backtrack(k, n, 1, new List<int>(), ans);

            return ans;
        }

        private void Backtrack(int k, int n, int start, List<int> list, IList<IList<int>> ans)
        {
            if (list.Count == k)
            {
                ans.Add(new List<int>(list));
                return;
            }

            for (var i = start; i <= n; i++)
            {
                list.Add(i);
                Backtrack(k, n, i + 1, list, ans);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}