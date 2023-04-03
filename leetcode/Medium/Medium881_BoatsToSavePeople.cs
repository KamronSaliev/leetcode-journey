using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/boats-to-save-people/
    /// </summary>
    public class Medium881_BoatsToSavePeople
    {
        public int NumRescueBoats(int[] people, int limit)
        {
            var left = 0;
            var right = people.Length - 1;
            var count = 0;

            Array.Sort(people);

            while (left <= right)
            {
                if (people[left] + people[right] <= limit)
                {
                    left++;
                    right--;
                }
                else
                {
                    right--;
                }

                count++;
            }

            return count;
        }
    }
}