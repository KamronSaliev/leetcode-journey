using System.Collections.Generic;

namespace LeetCode.Medium
{
    /// <summary>
    ///     https://leetcode.com/problems/dota2-senate/
    /// </summary>
    public class Medium649_Dota2Senate
    {
        public string PredictPartyVictory(string senate)
        {
            var radiantQueue = new Queue<int>();
            var direQueue = new Queue<int>();

            for (var i = 0; i < senate.Length; i++)
            {
                if (senate[i] == 'R')
                {
                    radiantQueue.Enqueue(i);
                }
                else
                {
                    direQueue.Enqueue(i);
                }
            }

            while (radiantQueue.Count != 0 && direQueue.Count != 0)
            {
                var radiantIndex = radiantQueue.Dequeue();
                var direIndex = direQueue.Dequeue();

                if (radiantIndex < direIndex)
                {
                    radiantQueue.Enqueue(radiantIndex + senate.Length);
                }
                else
                {
                    direQueue.Enqueue(direIndex + senate.Length);
                }
            }

            return radiantQueue.Count > direQueue.Count ? "Radiant" : "Dire";
        }
    }
}