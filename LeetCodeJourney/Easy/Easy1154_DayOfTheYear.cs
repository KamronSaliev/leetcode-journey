using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/day-of-the-year/
    /// </summary>
    public class Easy1154_DayOfTheYear
    {
        public int DayOfYear(string date)
        {
            return DateTime.Parse(date).DayOfYear;
        }
    }
}