namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/bitwise-and-of-numbers-range/
    /// </summary>
    public class Medium201_BitwiseAndOfNumbersRange
    {
        public int RangeBitwiseAnd(int left, int right)
        {
            var count = 0;

            while (left != right)
            {
                count++;
                left >>= 1;
                right >>= 1;
            }

            return left << count;
        }
    }
}