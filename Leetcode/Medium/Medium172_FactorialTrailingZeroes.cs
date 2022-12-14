namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/factorial-trailing-zeroes/
    /// </summary>
    public class Medium172_FactorialTrailingZeroes
    {
        public int TrailingZeroes(int n)
        {
            var ans = 0;

            for (var i = 5; n / i > 0; i *= 5)
            {
                ans += n / i;
            }

            return ans;
        }
    }
}