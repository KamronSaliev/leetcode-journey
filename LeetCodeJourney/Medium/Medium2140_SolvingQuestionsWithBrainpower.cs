using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/solving-questions-with-brainpower/
    /// </summary>
    public class Medium2140_SolvingQuestionsWithBrainpower
    {
        public long MostPoints(int[][] questions)
        {
            var masMax = new long[questions.Length + 1];
            var currentMax = 0L;
            
            for (var i = 0; i < questions.Length; i++)
            {
                currentMax = Math.Max(currentMax, masMax[i]);
                
                if (questions[i][1] + i + 1 >= questions.Length)
                {
                    masMax[questions.Length] = Math.Max(currentMax + questions[i][0], masMax[questions.Length]);
                }
                else
                {
                    masMax[i + questions[i][1] + 1] = Math.Max(currentMax + questions[i][0], masMax[i + questions[i][1] + 1]);
                }
            }

            return Math.Max(currentMax, masMax[questions.Length]);
        }
    }
}