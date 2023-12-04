using LeetCode.Utilities;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/number-of-provinces/
    /// </summary>
    public class Medium547_NumberOfProvinces
    {
        public int FindCircleNum(int[][] isConnected)
        {
            var dsu = new DisjointSetUnion(isConnected.Length);
            
            for (var i = 0; i < isConnected.Length; i++)
            {
                for (var j = 0; j < isConnected[i].Length; j++)
                {
                    if (isConnected[i][j] == 1)
                    {
                        dsu.Union(i, j);
                    }
                }
            }

            return dsu.Count;
        }
    }
}