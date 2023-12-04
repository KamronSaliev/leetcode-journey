using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/count-nice-pairs-in-an-array/
    /// </summary>
    public class Medium1814_CountNicePairsInAnArray
    {
        public int CountNicePairs(int[] nums)
        {
            const int mod = (int)(1e9 + 7);

            var occurrences = new Dictionary<long, long>();
            var result = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                var reversed = ReverseNumber(nums[i]);
                var difference = nums[i] - reversed;

                if (!occurrences.TryAdd(difference, 1))
                {
                    occurrences[difference]++;
                }
            }

            foreach (var occurrence in occurrences)
            {
                result = (int)((result + occurrence.Value * (occurrence.Value - 1) / 2) % mod);
            }

            return result;
        }

        private int ReverseNumber(int num)
        {
            var reversed = 0;

            while (num != 0)
            {
                var digit = num % 10;
                reversed = reversed * 10 + digit;
                num /= 10;
            }

            return reversed;
        }
    }
}