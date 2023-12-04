namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/running-sum-of-1d-array/
    /// </summary>
    public class Easy1480_RunningSumOf1dArray
    {
        public int[] RunningSum(int[] nums)
        {
            for (var i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[i - 1];
            }

            return nums;
        }
    }
}