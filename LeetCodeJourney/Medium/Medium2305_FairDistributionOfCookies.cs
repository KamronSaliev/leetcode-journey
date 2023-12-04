using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/fair-distribution-of-cookies/
    /// </summary>
    public class Medium2305_FairDistributionOfCookies
    {
        private int _result = int.MaxValue;

        public int DistributeCookies(int[] cookies, int k)
        {
            DFS(cookies, new int [k], 0, 0);
            
            return _result;
        }

        private void DFS(int[] cookies, int[] children, int index, int max)
        {
            if (index >= cookies.Length)
            {
                _result = Math.Min(_result, max);
                return;
            }

            for (var i = 0; i < children.Length; i++)
            {
                children[i] += cookies[index];
                DFS(cookies, children, index + 1, Math.Max(max, children[i]));
                children[i] -= cookies[index];
            }
        }
    }
}