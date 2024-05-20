namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/sum-of-all-subset-xor-totals
    /// </summary>
    public class Easy1863_SumOfAllSubsetXORTotals
    {
        public int SubsetXORSum(int[] nums)
        {
            var result = 0;

            foreach (var num in nums)
            {
                result |= num;
            }

            return result << (nums.Length - 1);
        }
    }
}