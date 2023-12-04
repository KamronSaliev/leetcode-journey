using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/day-of-the-week/description/
    /// </summary>
    public class Easy1185_DayOfTheWeek
    {
        public string DayOfTheWeek(int day, int month, int year)
        {
            var dateValue = new DateTime(year, month, day);
            return dateValue.DayOfWeek.ToString();
        }
    }
}