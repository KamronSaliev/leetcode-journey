namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/valid-perfect-square/
    /// </summary>
    public class Easy367_ValidPerfectSquare
    {
        public bool IsPerfectSquare(int num)
        {
            var left = 1;
            var right = num;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                var div = num / mid;
                var remainder = num % mid;

                if (div == mid && remainder == 0)
                {
                    return true;
                }

                if (div < mid)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return false;
        }
    }
}