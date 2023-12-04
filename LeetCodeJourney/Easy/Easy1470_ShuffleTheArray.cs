namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/shuffle-the-array/
    /// </summary>
    public class Easy1470_ShuffleTheArray
    {
        public int[] Shuffle(int[] nums, int n)
        {
            var result = new int[2 * n];

            for (var i = 0; i < n; i++)
            {
                result[2 * i] = nums[i];
                result[2 * i + 1] = nums[i + n];
            }

            return result;
        }
    }
}