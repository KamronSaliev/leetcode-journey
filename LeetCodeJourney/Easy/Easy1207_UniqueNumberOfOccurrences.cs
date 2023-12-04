using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/unique-number-of-occurrences/
    /// </summary>
    public class Easy1207_UniqueNumberOfOccurrences
    {
        public bool UniqueOccurrences(int[] arr)
        {
            var dict = new Dictionary<int, int>();

            for (var i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]]++;
                }
                else
                {
                    dict.Add(arr[i], 1);
                }
            }

            var uniqueList = new List<int>();

            foreach (var val in dict)
            {
                uniqueList.Add(val.Value);
            }

            uniqueList.Sort();

            for (var i = 1; i < uniqueList.Count; i++)
            {
                if (uniqueList[i] == uniqueList[i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}