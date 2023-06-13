using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/equal-row-and-column-pairs/
    /// </summary>
    public class Medium2352_EqualRowAndColumnPairs
    {
        public int EqualPairs(int[][] grid)
        {
            var dictionary = new Dictionary<string, int>();
            
            for (var i = 0; i < grid.Length; i++)
            {
                var row = string.Join("", grid[i]);
                
                if (dictionary.ContainsKey(row))
                {
                    dictionary[row]++;
                }
                else
                {
                    dictionary.Add(row, 1);
                }
            }

            var count = 0;
            for (var i = 0; i < grid.Length; i++)
            {
                var key = string.Join("", grid.Select(x => x[i]).ToArray());
                
                if (dictionary.TryGetValue(key, out var value))
                {
                    count += value;
                }
            }

            return count;
        }
    }
}