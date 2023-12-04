using System;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/remove-colored-pieces-if-both-neighbors-are-the-same-color/
    /// </summary>
    public class Medium2038_RemoveColoredPiecesIfBothNeighborsAreTheSameColor
    {
        public bool WinnerOfGame(string colors)
        {
            var alicePlays = 0;
            var bobPlays = 0;
            var count = 0;

            for (var i = 1; i < colors.Length; i++)
            {
                if (colors[i] == colors[i - 1])
                {
                    count++;
                }
                else
                {
                    if (colors[i - 1] == 'A')
                    {
                        alicePlays += Math.Max(0, count - 1);
                    }
                    else
                    {
                        bobPlays += Math.Max(0, count - 1);
                    }

                    count = 0;
                }
            }

            if (colors[^1] == 'A')
            {
                alicePlays += Math.Max(0, count - 1);
            }
            else
            {
                bobPlays += Math.Max(0, count - 1);
            }

            return alicePlays > bobPlays;
        }
    }
}