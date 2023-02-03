using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/palindrome-partitioning/
    /// </summary>
    public class Medium131_PalindromePartitioning
    {
        public IList<IList<string>> Partition(string s)
        {
            var result = new List<IList<string>>();
            DFS(0, result, new List<string>(), s);
            return result;
        }

        private void DFS(int start, List<IList<string>> result, List<string> currentList, string s)
        {
            if (start >= s.Length)
            {
                result.Add(new List<string>(currentList));
            }

            for (var end = start; end < s.Length; end++)
            {
                if (!IsPalindrome(s, start, end))
                {
                    continue;
                }

                currentList.Add(s.Substring(start, end - start + 1));
                DFS(end + 1, result, currentList, s);
                currentList.RemoveAt(currentList.Count - 1);
            }
        }

        private bool IsPalindrome(string s, int start, int end)
        {
            while (start < end)
            {
                if (s[start++] != s[end--])
                {
                    return false;
                }
            }

            return true;
        }
    }
}