namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/increasing-triplet-subsequence
    /// </summary>
    public class Medium334_IncreasingTripletSubsequence
    {
        public bool IncreasingTriplet(int[] nums)
        {
            var n = nums.Length;
            var min = int.MaxValue;
            var minSecond = int.MaxValue;

            foreach (var num in nums)
            {
                if (num <= min)
                {
                    min = num;
                }
                else if (num <= minSecond)
                {
                    minSecond = num;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
    }
}