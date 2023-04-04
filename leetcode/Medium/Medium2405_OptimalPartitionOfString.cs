using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/optimal-partition-of-string/
    /// </summary>
    public class Medium2405_OptimalPartitionOfString
    {
        public int PartitionString(string s)
        {
            var characterSet = new HashSet<char>();
            var count = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if (characterSet.Contains(s[i]))
                {
                    count++;
                    characterSet.Clear();
                }

                characterSet.Add(s[i]);
            }

            return count;
        }
    }
}