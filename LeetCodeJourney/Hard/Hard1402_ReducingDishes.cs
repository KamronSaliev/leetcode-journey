using System;

namespace LeetCode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/reducing-dishes/
    /// </summary>
    public class Hard1402_ReducingDishes
    {
        public int MaxSatisfaction(int[] satisfaction)
        {
            Array.Sort(satisfaction);
            
            var totalSatisfaction = 0;
            var sum = 0;
            
            for (var i = satisfaction.Length - 1; i >= 0; i--)
            {
                if (totalSatisfaction > totalSatisfaction + sum + satisfaction[i])
                {
                    break;
                }

                sum += satisfaction[i];
                totalSatisfaction += sum;
            }

            return totalSatisfaction;
        }
    }
}