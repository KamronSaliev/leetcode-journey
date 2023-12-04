using System;
using System.Linq;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-running-time-of-n-computers/
    ///     https://leetcode.com/problems/maximum-running-time-of-n-computers/solutions/3821393/video-o-m-log-k-maximizing-computer-run-time-with-binary-search/
    /// </summary>
    public class Hard2141_MaximumRunningTimeOfNComputers
    {
        public long MaxRunTime(int n, int[] batteries)
        {
            Array.Sort(batteries);

            var left = 1L;
            var right = batteries.Sum(b => (long)b) / n;

            while (left < right)
            {
                var target = right - (right - left) / 2;
                var total = batteries.Sum(battery => Math.Min(battery, target));

                if (total >= target * n)
                {
                    left = target;
                }
                else
                {
                    right = target - 1;
                }
            }

            return left;
        }
    }
}