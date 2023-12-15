using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/destination-city/
    /// </summary>
    public class Easy1436_DestinationCity
    {
        public string DestCity(IList<IList<string>> paths)
        {
            var map = new Dictionary<string, string>();
            var result = paths[0][0];

            foreach (var path in paths)
            {
                map[path[0]] = path[1];
            }

            while (map.ContainsKey(result))
            {
                result = map[result];
            }

            return result;
        }
    }
}