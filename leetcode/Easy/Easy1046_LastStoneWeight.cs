using System;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/last-stone-weight/
    /// </summary>
    public class Easy1046_LastStoneWeight
    {
        public int LastStoneWeight(int[] stones)
        {
            if (stones.Length == 1)
            {
                return stones[0];
            }
            
            Array.Sort(stones);

            while (stones[^2] != 0)
            {
                stones[^1] -= stones[^2];
                stones[^2] = 0;
                
                Array.Sort(stones);
            }

            return stones[^1];
        }
    }
}