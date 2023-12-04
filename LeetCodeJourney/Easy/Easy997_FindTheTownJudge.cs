using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/find-the-town-judge/
    /// </summary>
    public class Easy997_FindTheTownJudge
    {
        public int FindJudge(int n, int[][] trust)
        {
            if (n == 1)
            {
                return 1;
            }
            
            var trustIn = new List<int>();
            var trustOut = new List<int>();
            
            for (int i = 0; i < n + 1; i++)
            {
                trustIn.Add(0);
                trustOut.Add(0);
            }

            for (var i = 0; i < trust.Length; i++)
            {
                var trustRelation = trust[i];
                trustIn[trustRelation[1]]++;
                trustOut[trustRelation[0]]++;
            }

            for (int i = 0; i < n + 1; i++)
            {
                if (trustIn[i] == n - 1 && trustOut[i] == 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}