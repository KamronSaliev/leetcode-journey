using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-length-of-a-concatenated-string-with-unique-characters/
    /// </summary>
    public class Medium1239_MaximumLengthOfAConcatenatedStringWithUniqueCharacters
    {
        private int _answer;

        public int MaxLength(IList<string> arr)
        {
            DFS(arr, "", 0);

            return _answer;
        }

        private void DFS(IList<string> arr, string path, int index)
        {
            var isUnique = IsUniqueCharacters(path);

            if (isUnique)
            {
                _answer = Math.Max(path.Length, _answer);
            }

            if (index == arr.Count || !isUnique)
            {
                return;
            }

            for (var i = index; i < arr.Count; i++)
            {
                DFS(arr, path + arr[i], i + 1);
            }
        }

        private bool IsUniqueCharacters(string s)
        {
            var arr = new bool[26];

            for (var i = 0; i < s.Length; i++)
            {
                if (arr[s[i] - 'a'])
                {
                    return false;
                }

                arr[s[i] - 'a'] = true;
            }

            return true;
        }
    }
}