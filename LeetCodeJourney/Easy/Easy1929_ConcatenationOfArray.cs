using System.Linq;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/concatenation-of-array/
    /// </summary>
    public class Easy1929_ConcatenationOfArray
    {
        public int[] GetConcatenation(int[] nums)
        {
            return nums.Concat(nums).ToArray();
        }
    }
}