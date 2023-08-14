using System;
using System.Collections.Generic;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/make-array-strictly-increasing/
    ///     https://leetcode.com/problems/make-array-strictly-increasing/solutions/3646756/c-top-down-dp/
    /// </summary>
    public class Hard1187_MakeArrayStrictlyIncreasing
    {
        private readonly Dictionary<(int, int), int> _dp = new();

        private const int MaxCost = int.MaxValue - 1;

        public int MakeArrayIncreasing(int[] arr1, int[] arr2)
        {
            Array.Sort(arr2);

            var result = DFS(0, -1, arr1, arr2);

            return result < MaxCost ? result : -1;
        }

        private int DFS(int i, int prev, int[] arr1, int[] arr2)
        {
            if (i == arr1.Length)
            {
                return 0;
            }

            var key = (i, prev);

            if (_dp.TryGetValue(key, out var cached))
            {
                return cached;
            }

            var cost = MaxCost;

            if (arr1[i] > prev)
            {
                cost = DFS(i + 1, arr1[i], arr1, arr2);
            }

            var index = BinarySearch(arr2, prev);

            if (index < arr2.Length)
            {
                cost = Math.Min(cost, 1 + DFS(i + 1, arr2[index], arr1, arr2));
            }

            return _dp[key] = cost;
        }

        private int BinarySearch(int[] arr, int value)
        {
            var left = 0;
            var right = arr.Length;

            while (left < right)
            {
                var mid = left + (right - left) / 2;

                if (arr[mid] <= value)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            return left;
        }
    }
}