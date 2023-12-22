using System;
using System.Linq;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/maximum-score-after-splitting-a-string/
    /// </summary>
    public class Easy1422_MaximumScoreAfterSplittingAString
    {
        public int MaxScore(string s)
        {
            var totalOnes = s.Count(c => c == '1');
            var maxScore = 0;
            var countZerosLeft = 0;
            var countOnesRight = totalOnes;

            for (var i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == '0')
                {
                    countZerosLeft++;
                }
                else
                {
                    countOnesRight--;
                }

                maxScore = Math.Max(maxScore, countZerosLeft + countOnesRight);
            }

            return maxScore;
        }
    }
}