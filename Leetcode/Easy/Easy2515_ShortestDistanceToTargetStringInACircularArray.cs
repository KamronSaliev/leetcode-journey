using System;
using System.Collections.Generic;

namespace Leetcode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/shortest-distance-to-target-string-in-a-circular-array/
    /// </summary>
    public class Easy2515_ShortestDistanceToTargetStringInACircularArray
    {
        public int ClosetTarget(string[] words, string target, int startIndex)
        {
            var indices = new List<int>();

            for (var i = 0; i < words.Length; i++)
            {
                if (words[i] == target)
                {
                    indices.Add(i);
                }
            }

            if (indices.Count == 0)
            {
                return -1;
            }

            var min = (int)1e9;

            for (var i = 0; i < indices.Count; i++)
            {
                var distanceNext = indices[i] - startIndex;
                var distancePrevious = (startIndex - indices[i]) % words.Length;

                if (distanceNext < 0)
                {
                    distanceNext += words.Length;
                }

                if (distancePrevious < 0)
                {
                    distancePrevious += words.Length;
                }

                min = Math.Min(min, Math.Min(distanceNext, distancePrevious));
            }

            return min;
        }
    }
}