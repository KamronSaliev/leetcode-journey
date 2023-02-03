namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/single-number/
    /// </summary>
    public class Easy136_SingleNumber
    {
        public int SingleNumber(int[] nums)
        {
            var ans = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                ans ^= nums[i];
            }

            return ans;
        }
    }
}