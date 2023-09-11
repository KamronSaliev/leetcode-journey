using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/group-the-people-given-the-group-size-they-belong-to/
    /// </summary>
    public class Medium1282_GroupThePeopleGivenTheGroupSizeTheyBelongTo
    {
        public IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            var dictionary = new Dictionary<int, List<int>>();
            var result = new List<IList<int>>();

            for (var i = 0; i < groupSizes.Length; i++)
            {
                var size = groupSizes[i];
                if (!dictionary.ContainsKey(size))
                {
                    dictionary[size] = new List<int>();
                }

                dictionary[size].Add(i);

                if (dictionary[size].Count != size)
                {
                    continue;
                }

                result.Add(new List<int>(dictionary[size]));
                dictionary[size].Clear();
            }

            return result;
        }
    }
}