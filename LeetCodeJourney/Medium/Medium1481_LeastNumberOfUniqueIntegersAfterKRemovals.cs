using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/least-number-of-unique-integers-after-k-removals/
    /// </summary>
    public class Medium1481_LeastNumberOfUniqueIntegersAfterKRemovals
    {
        public int FindLeastNumOfUniqueInts(int[] arr, int k)
        {
            var dictionary = new Dictionary<int, int>();

            for (var i = 0; i < arr.Length; i++)
            {
                if (!dictionary.TryAdd(arr[i], 1))
                {
                    dictionary[arr[i]]++;
                }
            }

            var priorityQueue = new PriorityQueue<int, int>();

            foreach (var key in dictionary.Keys)
            {
                priorityQueue.Enqueue(key, dictionary[key]);
            }

            while (k > 0 && priorityQueue.Count != 0)
            {
                var val = priorityQueue.Peek();

                if (dictionary.ContainsKey(val))
                {
                    dictionary[val]--;

                    if (dictionary[val] == 0)
                    {
                        dictionary.Remove(val);
                        priorityQueue.Dequeue();
                    }
                }

                k--;
            }

            return dictionary.Count;
        }
    }
}