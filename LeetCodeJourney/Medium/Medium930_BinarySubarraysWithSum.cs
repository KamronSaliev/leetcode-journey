using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/binary-subarrays-with-sum
    /// </summary>
    public class Medium930_BinarySubarraysWithSum
    {
        public int NumSubarraysWithSum(int[] nums, int goal)
        {
            var dictionary = new Dictionary<int, int>();
            var sum = 0;
            var result = 0;

            foreach (var num in nums)
            {
                sum += num;

                dictionary.TryAdd(sum, 0);

                if (sum == goal)
                {
                    result++;
                }

                if (sum >= goal)
                {
                    if (dictionary.ContainsKey(sum - goal))
                    {
                        result += dictionary[sum - goal];
                    }
                }

                dictionary[sum]++;
            }

            return result;
        }
    }
}