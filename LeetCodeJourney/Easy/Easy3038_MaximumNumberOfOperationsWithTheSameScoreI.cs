namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-number-of-operations-with-the-same-score-i/
    /// </summary>
    public class Easy3038_MaximumNumberOfOperationsWithTheSameScoreI
    {
        public int MaxOperations(int[] nums)
        {
            if (nums.Length < 2)
            {
                return 0;
            }

            var result = 1;
            var sum = nums[0] + nums[1];

            for (var i = 3; i < nums.Length; i += 2)
            {
                if (nums[i - 1] + nums[i] == sum)
                {
                    result++;
                }
                else
                {
                    break;
                }
            }

            return result;
        }
    }
}