using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/top-k-frequent-words/
    /// </summary>
    public class Medium692_TopKFrequentWords
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {
            var wordsDictionary = new Dictionary<string, int>();

            foreach (var t in words)
            {
                if (wordsDictionary.ContainsKey(t))
                {
                    wordsDictionary[t]++;
                }
                else
                {
                    wordsDictionary.Add(t, 1);
                }
            }

            return wordsDictionary
                .OrderByDescending(pair => pair.Value)
                .ThenBy(pair => pair.Key)
                .Take(k)
                .Select(word => word.Key)
                .ToList();
        }
    }
}