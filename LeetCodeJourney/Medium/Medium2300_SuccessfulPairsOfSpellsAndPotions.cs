using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/successful-pairs-of-spells-and-potions/
    /// </summary>
    public class Medium2300_SuccessfulPairsOfSpellsAndPotions
    {
        public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
        {
            var n = spells.Length;
            var m = potions.Length;
            var pairs = new int[n];
            
            Array.Sort(potions);
            
            for (var i = 0; i < n; i++)
            {
                var left = 0;
                var right = m - 1;
                
                while (left <= right)
                {
                    var mid = left + (right - left) / 2;
                    var product = (long)spells[i] * potions[mid];
                    
                    if (product >= success)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }

                pairs[i] = m - left;
            }

            return pairs;
        }
    }
}