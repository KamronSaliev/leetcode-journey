namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/subarray-sums-divisible-by-k/
    /// </summary>
    public class Medium974_SubarraySumsDivisibleByK
    {
        public int SubarraysDivByK(int[] nums, int k)
        {
            var result = new int[k];
            var count = 0;
            var sum = 0;

            result[0] = 1;

            for (var i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                var remainder = sum % k;

                if (remainder < 0)
                {
                    remainder += k;
                }

                count += result[remainder];
                result[remainder]++;
            }

            return count;
        }
    }
}