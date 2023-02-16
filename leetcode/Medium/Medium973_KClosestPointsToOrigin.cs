using System.Linq;

namespace LeetCode.Medium
{
    public class Medium973_KClosestPointsToOrigin
    {
        public int[][] KClosest(int[][] points, int k)
        {
            return points.OrderBy(point => point[0] * point[0] + point[1] * point[1]).Take(k).ToArray();
        }
    }
}