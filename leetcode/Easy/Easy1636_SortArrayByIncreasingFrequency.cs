using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/sort-array-by-increasing-frequency/description/
    /// </summary>
    public class Easy1636_SortArrayByIncreasingFrequency
    {
        public int[] FrequencySort(int[] nums)
        {
            var counts = new SortedDictionary<int, int>();
            var occurrences = new SortedDictionary<int, List<int>>();
            var result = new List<int>();

            foreach (var num in nums)
            {
                if (!counts.TryAdd(num, 1))
                {
                    counts[num]++;
                }
            }

            foreach (var count in counts)
            {
                if (!occurrences.ContainsKey(count.Value))
                {
                    occurrences[count.Value] = new List<int> { count.Key };
                }
                else
                {
                    occurrences[count.Value].Add(count.Key);
                }
            }

            foreach (var occurence in occurrences)
            {
                for (var i = occurrences[occurence.Key].Count - 1; i >= 0; i--)
                {
                    for (var j = 0; j < occurence.Key; j++)
                    {
                        result.Add(occurrences[occurence.Key][i]);
                    }
                }
            }

            return result.ToArray();
        }
    }
}