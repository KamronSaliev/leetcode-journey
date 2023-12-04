namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/sum-of-absolute-differences-in-a-sorted-array/
    /// </summary>
    public class Medium1685_SumOfAbsoluteDifferencesInASortedArray
    {
        public int[] GetSumAbsoluteDifferences(int[] nums)
        {
            var result = new int[nums.Length];
            var prefix = new int[nums.Length];
            prefix[0] = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                prefix[i] = prefix[i - 1] + nums[i];
            }

            for (var i = 0; i < nums.Length; i++)
            {
                var rightIndex = nums.Length - i - 1;
                var leftSum = i - 1 < 0 ? 0 : prefix[i - 1];
                var rightSum = prefix[nums.Length - 1] - prefix[i];
                result[i] = (i - rightIndex) * nums[i] + (rightSum - leftSum);
            }

            return result;
        }
    }
}