using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/fruit-into-baskets/
    /// </summary>
    public class Medium904_FruitIntoBaskets
    {
        public int TotalFruit(int[] fruits)
        {
            var fruitTypes = new Dictionary<int, int>();

            var left = 0;
            var right = 0;

            while (right < fruits.Length)
            {
                if (fruitTypes.ContainsKey(fruits[right]))
                {
                    fruitTypes[fruits[right]]++;
                }
                else
                {
                    fruitTypes.Add(fruits[right], 1);
                }

                if (fruitTypes.Count > 2)
                {
                    fruitTypes[fruits[left]]--;

                    if (fruitTypes[fruits[left]] == 0)
                    {
                        fruitTypes.Remove(fruits[left]);
                    }

                    left++;
                }

                right++;
            }

            return right - left;
        }
    }
}