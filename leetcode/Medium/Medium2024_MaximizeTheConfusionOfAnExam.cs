using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/maximize-the-confusion-of-an-exam/
    /// </summary>
    public class Medium2024_MaximizeTheConfusionOfAnExam
    {
        public int MaxConsecutiveAnswers(string answerKey, int k)
        {
            var longestConsecutiveCount = 0;
            var left = 0;
            var maxChanges = k;
            var tCount = 0;
            var fCount = 0;

            for (var right = 0; right < answerKey.Length; right++)
            {
                var currentAnswer = answerKey[right];

                if (currentAnswer == 'T')
                {
                    tCount++;
                }
                else
                {
                    fCount++;
                }

                while (Math.Min(tCount, fCount) > maxChanges)
                {
                    var leftAnswer = answerKey[left];

                    if (leftAnswer == 'T')
                    {
                        tCount--;
                    }
                    else
                    {
                        fCount--;
                    }

                    left++;
                }

                longestConsecutiveCount = Math.Max(longestConsecutiveCount, right - left + 1);
            }

            return longestConsecutiveCount;
        }
    }
}