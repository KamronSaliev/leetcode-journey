using System;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/average-salary-excluding-the-minimum-and-maximum-salary/
    /// </summary>
    public class Easy1491_AverageSalaryExcludingTheMinimumAndMaximumSalary
    {
        public double Average(int[] salary)
        {
            Array.Sort(salary);

            var sum = 0.0d;

            for (int i = 1; i < salary.Length - 1; i++)
            {
                sum += salary[i];
            }

            return sum / (salary.Length - 2);
        }
    }
}