using System.Collections.Generic;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/put-marbles-in-bags/
    /// </summary>
    public class Hard2551_PutMarblesInBags
    {
        public long PutMarbles(int[] weights, int k)
        {
            var max = new PriorityQueue<int, int>();
            var min = new PriorityQueue<int, int>();

            for (var i = 0; i < weights.Length - 1; i++)
            {
                var sum = weights[i] + weights[i + 1];
                max.Enqueue(sum, -sum);
                min.Enqueue(sum, sum);
            }

            var maxSum = 0L;
            var minSum = 0L;

            for (var i = 0; i < k - 1; i++)
            {
                maxSum += max.Dequeue();
                minSum += min.Dequeue();
            }

            return maxSum - minSum;
        }
    }
}