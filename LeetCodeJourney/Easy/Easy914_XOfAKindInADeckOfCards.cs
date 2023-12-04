using System.Collections.Generic;

namespace LeetCode.Easy
{
    /// <summary>
    ///     https://leetcode.com/problems/x-of-a-kind-in-a-deck-of-cards/
    /// </summary>
    public class Easy914_XOfAKindInADeckOfCards
    {
        public bool HasGroupsSizeX(int[] deck)
        {
            var dictionary = new Dictionary<int, int>();
            var result = 0;

            for (var i = 0; i < deck.Length; i++)
            {
                if (dictionary.ContainsKey(deck[i]))
                {
                    dictionary[deck[i]]++;
                }
                else
                {
                    dictionary[deck[i]] = 1;
                }
            }

            foreach (var value in dictionary.Values)
            {
                result = GCD(value, result);
            }

            return result > 1;
        }

        private int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
    }
}