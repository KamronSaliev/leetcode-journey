using Leetcode.Utilities;

namespace Leetcode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/powx-n/
    /// </summary>
    public class Medium50_PowXN
    {
        public double MyPow(double x, int n)
        {
            return LeetcodeUtilities.PowOptimized(x, n);
        }
    }
}