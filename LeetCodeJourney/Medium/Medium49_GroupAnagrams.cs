using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/group-anagrams/
    /// </summary>
    public class Medium49_GroupAnagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dictionary = new Dictionary<string, IList<string>>();
            
            for (var i = 0; i < strs.Length; i++)
            {
                var arr = strs[i].ToCharArray();
                Array.Sort(arr);
                var sorted = new string(arr);

                if (dictionary.ContainsKey(sorted))
                {
                    dictionary[sorted].Add(strs[i]);
                }
                else
                {
                    dictionary.Add(sorted, new List<string> { strs[i] });
                }
            }

            var result = dictionary.Values.ToList();
            return result;
        }
    }
}