using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/path-crossing/
    /// </summary>
    public class Easy1496_PathCrossing
    {
        public bool IsPathCrossing(string path)
        {
            var x = 0;
            var y = 0;
            var visited = new HashSet<string> { "0,0" };

            foreach (var direction in path)
            {
                switch (direction)
                {
                    case 'E':
                        x++;
                        break;
                    case 'W':
                        x--;
                        break;
                    case 'N':
                        y++;
                        break;
                    case 'S':
                        y--;
                        break;
                }

                var current = $"{x},{y}";

                if (!visited.Add(current))
                {
                    return true;
                }
            }

            return false;
        }
    }
}