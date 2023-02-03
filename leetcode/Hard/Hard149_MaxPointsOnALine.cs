using System;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode.Hard
{
    /// <summary>
    ///     https://leetcode.com/problems/max-points-on-a-line/
    /// </summary>
    public class Hard149_MaxPointsOnALine
    {
        public int MaxPoints(int[][] points)
        {
            var n = points.Length;
            if (n == 1)
            {
                return 1;
            }

            var result = 2;
            
            for (var i = 0; i < n; ++i)
            {
                var cnts = new Dictionary<double, int>();
                
                for (var j = 0; j < n; ++j)
                {
                    if (j != i)
                    {
                        var angle = Math.Atan2(points[j][1] - points[i][1], points[j][0] - points[i][0]);
                        cnts[angle] = cnts.GetValueOrDefault(angle, 0) + 1;
                    }
                }

                result = Math.Max(result, cnts.Values.Max() + 1);
            }

            return result;
        }
    }
}