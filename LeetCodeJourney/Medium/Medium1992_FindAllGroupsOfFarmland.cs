using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/find-all-groups-of-farmland
    /// </summary>
    public class Medium1992_FindAllGroupsOfFarmland
    {
        public int[][] FindFarmland(int[][] land)
        {
            var n = land.Length;
            var m = land[0].Length;

            int DFSByColumn(int r, int c)
            {
                if (c > m - 1 || land[r][c] == 0)
                {
                    return c - 1;
                }

                return DFSByColumn(r, c + 1);
            }

            int DFSByRow(int r, int c)
            {
                if (r > n - 1 || land[r][c] == 0)
                {
                    return r - 1;
                }

                return DFSByRow(r + 1, c);
            }

            var res = new List<int[]>();
            for (var i = 0; i < n; ++i)
            {
                for (var j = 0; j < m; ++j)
                {
                    if (land[i][j] != 1)
                    {
                        continue;
                    }

                    var mC = DFSByColumn(i, j);
                    var mR = DFSByRow(i, j);

                    var subRes = new int[4];
                    subRes[0] = i;
                    subRes[1] = j;
                    subRes[2] = mR;
                    subRes[3] = mC;
                    res.Add(subRes);

                    for (var k = i; k <= mR; ++k)
                    {
                        for (var l = j; l <= mC; ++l)
                        {
                            land[k][l] = -1;
                        }
                    }
                }
            }

            var resultArray = new int[res.Count][];
            for (var i = 0; i < res.Count; i++)
            {
                resultArray[i] = res[i];
            }

            return resultArray;
        }
    }
}