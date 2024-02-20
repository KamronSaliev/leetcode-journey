using System.Linq;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/missing-number/
    /// </summary>
    public class Easy268_MissingNumber
    {
        public int MissingNumber(int[] nums)
        {
            return nums.Length * (nums.Length + 1) / 2 - nums.Sum();
        }
    }
}