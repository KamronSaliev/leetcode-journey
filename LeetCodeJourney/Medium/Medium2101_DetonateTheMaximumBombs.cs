using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/detonate-the-maximum-bombs/
    /// </summary>
    public class Medium2101_DetonateTheMaximumBombs
    {
        public int MaximumDetonation(int[][] bombs)
        {
            var maxDetonated = 0;

            for (var i = 0; i < bombs.Length; i++)
            {
                var queue = new Queue<int>();
                queue.Enqueue(i);

                var detonatedCount = 1;
                var detonated = new bool[bombs.Length];
                detonated[i] = true;

                while (queue.Count != 0)
                {
                    var bomb = bombs[queue.Dequeue()];
                    var range = (double)bomb[2];

                    for (var j = 0; j < bombs.Length; j++)
                    {
                        if (detonated[j])
                        {
                            continue;
                        }

                        var otherBomb = bombs[j];
                        var dist = GetDistance(bomb[0], bomb[1], otherBomb[0], otherBomb[1]);

                        if (dist <= range)
                        {
                            queue.Enqueue(j);
                            detonatedCount++;
                            detonated[j] = true;
                        }
                    }

                    maxDetonated = Math.Max(maxDetonated, detonatedCount);
                }
            }

            return maxDetonated;
        }

        private double GetDistance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}