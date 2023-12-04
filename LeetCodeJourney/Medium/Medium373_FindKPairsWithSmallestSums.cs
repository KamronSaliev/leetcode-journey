using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/find-k-pairs-with-smallest-sums/
    /// </summary>
    public class Medium373_FindKPairsWithSmallestSums
    {
        public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k)
        {
            var result = new List<IList<int>>();
            var priorityQueue = new PriorityQueue<(int sum, int position), int>();

            foreach (var num1 in nums1)
            {
                var sum = num1 + nums2[0];
                priorityQueue.Enqueue((sum, 0), sum);
            }

            while (k-- > 0 && priorityQueue.Count != 0)
            {
                var (sum, pos) = priorityQueue.Dequeue();

                result.Add(new List<int> { sum - nums2[pos], nums2[pos] });

                if (pos + 1 < nums2.Length)
                {
                    var s1 = sum - nums2[pos] + nums2[pos + 1];
                    priorityQueue.Enqueue((s1, pos + 1), s1);
                }
            }

            return result;
        }
    }
}