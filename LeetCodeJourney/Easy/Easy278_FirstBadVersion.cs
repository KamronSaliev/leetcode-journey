namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/first-bad-version/
    /// </summary>
    public class Easy278_FirstBadVersion
    {
        public int FirstBadVersion(int n)
        {
            var left = 0;
            var right = n - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (IsBadVersion(mid))
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }

        /// <summary>
        ///     The isBadVersion API is defined in the parent class VersionControl
        /// </summary>
        /// <returns></returns>
        private bool IsBadVersion(int version)
        {
            return true;
        }
    }
}