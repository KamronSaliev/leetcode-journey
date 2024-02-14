namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/rearrange-array-elements-by-sign/
    /// </summary>
    public class Medium2149_RearrangeArrayElementsBySign
    {
        public int[] RearrangeArray(int[] nums)
        {
            var n = nums.Length;
            var result = new int[n];
            var positiveIndex = 0;
            var negativeIndex = 1;

            for (var i = 0; i < n; i++)
            {
                if (nums[i] > 0)
                {
                    result[positiveIndex] = nums[i];
                    positiveIndex += 2;
                }
                else
                {
                    result[negativeIndex] = nums[i];
                    negativeIndex += 2;
                }
            }

            return result;
        }
    }
}