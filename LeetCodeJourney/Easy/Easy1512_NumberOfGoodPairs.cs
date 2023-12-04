namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/number-of-good-pairs/
    /// </summary>
    public class Easy1512_NumberOfGoodPairs
    {
        public int NumIdenticalPairs(int[] nums)
        {
            var count = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}