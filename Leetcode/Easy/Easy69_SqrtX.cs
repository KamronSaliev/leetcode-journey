namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/sqrtx/
    /// </summary>
    public class Easy69_SqrtX
    {
        public int MySqrt(int x)
        {
            var left = 1;
            var right = x;
            var ans = 0;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (mid <= x / mid)
                {
                    left = mid + 1;
                    ans = mid;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return ans;
        }
    }
}