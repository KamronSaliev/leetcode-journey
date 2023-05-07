using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/find-the-longest-valid-obstacle-course-at-each-position/
    /// </summary>
    public class Medium1964_FindTheLongestValidObstacleCourseAtEachPosition
    {
        public int[] LongestObstacleCourseAtEachPosition(int[] obstacles)
        {
            var result = new int[obstacles.Length];
            var list = new List<int>();
            
            for (var i = 0; i < obstacles.Length; i++)
            {
                if (list.Count == 0 || obstacles[i] >= list[^1])
                {
                    list.Add(obstacles[i]);
                    result[i] = list.Count;
                }
                else
                {
                    var insertPosition = list.BinarySearch(obstacles[i]);
                    
                    if (insertPosition < 0)
                    {
                        list[~insertPosition] = obstacles[i];
                        result[i] = ~insertPosition + 1;
                    }
                    else
                    {
                        while (insertPosition < list.Count && list[insertPosition] == obstacles[i])
                        {
                            insertPosition++;
                        }

                        list[insertPosition] = obstacles[i];
                        result[i] = insertPosition + 1;
                    }
                }
            }

            return result;
        }
    }
}