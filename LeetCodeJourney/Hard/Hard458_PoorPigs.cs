using System;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/poor-pigs/
    /// </summary>
    public class Hard458_PoorPigs
    {
        public int PoorPigs(int buckets, int minutesToDie, int minutesToTest)
        {
            return (int)Math.Ceiling(Math.Log2(buckets) / Math.Log2(minutesToTest / minutesToDie + 1));
        }
    }
}