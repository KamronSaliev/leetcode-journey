namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/k-radius-subarray-averages/
    ///     https://leetcode.com/problems/k-radius-subarray-averages/solutions/3583558/c-solution-sliding-window-and-prefix-sum/
    /// </summary>
    public class Medium2090_KRadiusSubarrayAverages
    {
        public int[] GetAverages(int[] nums, int k)
        {
            var averages = new int[nums.Length];
            var prefixSum = new long[nums.Length + 1];

            for (var i = 0; i < nums.Length; i++)
            {
                prefixSum[i + 1] = prefixSum[i] + nums[i];
            }

            for (var i = 0; i < nums.Length; i++)
            {
                var left = i - k;
                var right = i + k;

                if (left < 0 || right > nums.Length - 1)
                {
                    averages[i] = -1;
                    continue;
                }

                averages[i] = GetAverage(left, right, prefixSum);
            }

            return averages;
        }

        private int GetAverage(int startPos, int endPos, long[] sums)
        {
            var divisor = endPos - startPos + 1;
            var sumSubarray = sums[endPos + 1] - sums[startPos];
            var averageSum = sumSubarray / (divisor != 0 ? divisor : 1);

            return (int)averageSum;
        }
    }
}