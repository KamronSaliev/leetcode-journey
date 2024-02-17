using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/furthest-building-you-can-reach/
    /// </summary>
    public class Medium1642_FurthestBuildingYouCanReach
    {
        public int FurthestBuilding(int[] heights, int bricks, int ladders)
        {
            var n = heights.Length;
            var priorityQueue = new PriorityQueue<int, int>();

            for (var i = 0; i < n - 1; i++)
            {
                var difference = heights[i + 1] - heights[i];

                if (difference > 0)
                {
                    priorityQueue.Enqueue(difference, difference);
                }

                if (priorityQueue.Count > ladders)
                {
                    bricks -= priorityQueue.Dequeue();
                }

                if (bricks < 0)
                {
                    return i;
                }
            }

            return n - 1;
        }
    }
}