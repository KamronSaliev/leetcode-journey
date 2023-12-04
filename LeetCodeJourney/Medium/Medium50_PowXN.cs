using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/powx-n/
    /// </summary>
    public class Medium50_PowXN
    {
        public double MyPow(double x, int n)
        {
            return CommonUtilities.PowOptimized(x, n);
        }
    }
}