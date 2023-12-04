namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/guess-number-higher-or-lower/
    /// </summary>
    public class Easy374_GuessNumberHigherOrLower
    {
        public int GuessNumber(int n)
        {
            var left = 1;
            var right = n;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (guess(mid) == 0)
                {
                    return mid;
                }

                if (guess(mid) == 1)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return left;
        }

        private int guess(int num)
        {
            return 0;
        }
    }
}