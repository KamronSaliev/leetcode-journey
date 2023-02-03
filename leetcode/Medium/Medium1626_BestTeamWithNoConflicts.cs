using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/best-team-with-no-conflicts/
    /// </summary>
    public class Medium1626_BestTeamWithNoConflicts
    {
        public int BestTeamScore(int[] scores, int[] ages)
        {
            var players = new List<(int Score, int Age)>();

            for (var i = 0; i < scores.Length; i++)
            {
                players.Add((scores[i], ages[i]));
            }

            players.Sort((player1, player2) => player1.Age == player2.Age
                ? player1.Score.CompareTo(player2.Score)
                : player1.Age.CompareTo(player2.Age));

            var dp = new int[players.Count];
            dp[0] = players[0].Score;
            var max = dp[0];

            for (var i = 1; i < players.Count; i++)
            {
                dp[i] = players[i].Score;

                for (var j = 0; j < i; j++)
                {
                    if (players[j].Score <= players[i].Score)
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + players[i].Score);
                    }
                }

                max = Math.Max(max, dp[i]);
            }

            return max;
        }
    }
}