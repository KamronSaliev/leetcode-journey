namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/number-of-zero-filled-subarrays/
    /// </summary>
    public class Medium2348_NumberOfZeroFilledSubarrays
    {
        public long ZeroFilledSubarray(int[] nums)
        {
            var result = 0L;
            var count = 0L;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    count++;
                    result += count;
                }
                else
                {
                    count = 0;
                }
            }

            return result;
        }
    }
}